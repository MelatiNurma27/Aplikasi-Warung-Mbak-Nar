Imports System.Data.Odbc

Public Class Aplikasi
    Dim conn As New OdbcConnection("Dsn=db_MbakNar")
    Dim cmd As OdbcCommand
    Dim dr As OdbcDataReader

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            GenerateIDTransaksi()

            conn.Open()
            cmd = New OdbcCommand("SELECT Kategori FROM table_kategori", conn)
            dr = cmd.ExecuteReader()
            While dr.Read()
                cbKategori.Items.Add(dr("Kategori").ToString())
            End While
            dr.Close()
            conn.Close()

            DataGridView1.Columns.Clear()
            DataGridView1.Columns.Add("ID_Transaksi", "ID Transaksi")
            DataGridView1.Columns.Add("menu", "Menu")
            DataGridView1.Columns.Add("jumlah", "Jumlah")
            DataGridView1.Columns.Add("total", "Total")

        Catch ex As Exception
            MessageBox.Show("Error saat memuat aplikasi: " & ex.Message)
        End Try
    End Sub
    Private Sub GenerateIDTransaksi()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim currentDate As String = DateTime.Now.ToString("yyMMdd")
            Dim query As String = "SELECT MAX(ID_Transaksi) FROM table_transaksi WHERE ID_Transaksi LIKE ?"
            cmd = New OdbcCommand(query, conn)
            cmd.Parameters.AddWithValue("?", currentDate & "%")
            Dim lastID As Object = cmd.ExecuteScalar()

            If lastID IsNot DBNull.Value AndAlso Not String.IsNullOrEmpty(lastID.ToString()) Then
                Dim lastTransactionID As String = lastID.ToString()
                Dim newID As Integer = Convert.ToInt32(lastTransactionID.Substring(6)) + 1
                TxtIDTransaksi.Text = currentDate & newID.ToString("D3")
            Else
                TxtIDTransaksi.Text = currentDate & "001"
            End If
        Catch ex As Exception
            MessageBox.Show("Error generating ID Transaksi: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
    Private Sub cbKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbKategori.SelectedIndexChanged
        Try
            cbMenu.Items.Clear()
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim query As String = "SELECT menu FROM table_menu WHERE ID_Kategori = ?"
            Dim kategoriDipilih As Integer = If(cbKategori.SelectedIndex = 0, 1, 2)

            cmd = New OdbcCommand(query, conn)
            cmd.Parameters.AddWithValue("?", kategoriDipilih)
            dr = cmd.ExecuteReader()

            While dr.Read()
                cbMenu.Items.Add(dr("menu").ToString())
            End While
            dr.Close()

        Catch ex As Exception
            MessageBox.Show("Error memuat menu: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
    Private Sub cbMenu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMenu.SelectedIndexChanged
        Try
            If cbMenu.SelectedIndex = -1 Then
                TxtHarga.Text = ""
                Return
            End If

            conn.Open()
            Dim query As String = "SELECT harga FROM table_menu WHERE menu = ?"
            cmd = New OdbcCommand(query, conn)
            cmd.Parameters.AddWithValue("?", cbMenu.SelectedItem.ToString())
            Dim harga As Object = cmd.ExecuteScalar()

            TxtHarga.Text = If(harga IsNot Nothing, harga.ToString(), "")
        Catch ex As Exception
            MessageBox.Show("Error memuat harga: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Try
            If String.IsNullOrWhiteSpace(cbMenu.Text) OrElse String.IsNullOrWhiteSpace(TxtHarga.Text) OrElse String.IsNullOrWhiteSpace(TxtJumlah.Text) Then
                MessageBox.Show("Pastikan menu, harga, dan jumlah telah diisi!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim jumlah As Integer
            Dim harga As Decimal

            If Integer.TryParse(TxtJumlah.Text, jumlah) AndAlso Decimal.TryParse(TxtHarga.Text, harga) Then
                Dim total As Decimal = harga * jumlah

                DataGridView1.Rows.Add(TxtIDTransaksi.Text, cbMenu.Text, jumlah, total)

                Dim totalHarga As Decimal = 0
                For Each row As DataGridViewRow In DataGridView1.Rows
                    If Not row.IsNewRow Then
                        totalHarga += Convert.ToDecimal(row.Cells("total").Value)
                    End If
                Next
                TxtTotal.Text = totalHarga.ToString("N2")

                cbMenu.SelectedIndex = -1
                cbKategori.SelectedIndex = -1
                TxtHarga.Clear()
                TxtJumlah.Clear()
            Else
                MessageBox.Show("Input jumlah atau harga tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error menambahkan data: " & ex.Message)
        End Try
    End Sub
    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Try
            Using conn As New OdbcConnection("Dsn=db_MbakNar")
                conn.Open()

                Dim queryTransaksi As String = "INSERT INTO table_Transaksi (ID_Transaksi, Tanggal_Transaksi, Nama_Pelanggan, Total) VALUES (?, ?, ?, ?)"
                Using cmd As New OdbcCommand(queryTransaksi, conn)
                    cmd.Parameters.AddWithValue("?", TxtIDTransaksi.Text)
                    cmd.Parameters.AddWithValue("?", DateTimePicker1.Value)
                    cmd.Parameters.AddWithValue("?", TxtNama.Text)

                    Dim total As Double = 0
                    If Double.TryParse(TxtTotal.Text, total) Then
                        cmd.Parameters.AddWithValue("?", total)
                    Else
                        MessageBox.Show("Total tidak valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If

                    cmd.ExecuteNonQuery()
                End Using

                For Each row As DataGridViewRow In DataGridView1.Rows
                    If Not row.IsNewRow Then
                        Dim queryDetail As String = "INSERT INTO table_detailtransaksi (ID_Transaksi, ID_Menu, jumlah, total) VALUES (?, ?, ?, ?)"
                        Using cmdDetail As New OdbcCommand(queryDetail, conn)
                            cmdDetail.Parameters.AddWithValue("?", TxtIDTransaksi.Text)
                            cmdDetail.Parameters.AddWithValue("?", GetID_MenuByName(row.Cells("menu").Value.ToString()))
                            cmdDetail.Parameters.AddWithValue("?", row.Cells("jumlah").Value)

                            Dim itemTotal As Double = 0
                            If Double.TryParse(row.Cells("total").Value.ToString(), itemTotal) Then
                                cmdDetail.Parameters.AddWithValue("?", itemTotal)
                            Else
                                cmdDetail.Parameters.AddWithValue("?", 0)
                            End If

                            cmdDetail.ExecuteNonQuery()
                        End Using
                    End If
                Next

                MessageBox.Show("Transaksi berhasil disimpan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error menyimpan transaksi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function GetID_MenuByName(menu As String) As Integer
        Dim ID_Menu As Integer = 0
        Try
            Using conn As New OdbcConnection("Dsn=db_MbakNar")
                conn.Open()
                Dim query As String = "SELECT ID_Menu FROM table_menu WHERE menu = ?"
                cmd = New OdbcCommand(query, conn)
                cmd.Parameters.AddWithValue("?", menu)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    ID_Menu = Convert.ToInt32(result)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving ID_Menu: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return ID_Menu
    End Function
    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Try
            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                If Not row.IsNewRow Then
                    DataGridView1.Rows.Remove(row)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error menghapus data: " & ex.Message)
        End Try
        Dim totalHarga As Decimal = 0
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                totalHarga += Convert.ToDecimal(row.Cells("total").Value)
            End If
        Next
        TxtTotal.Text = totalHarga.ToString("N2")
    End Sub
    Private Sub BtnBayar_Click(sender As Object, e As EventArgs) Handles BtnBayar.Click
        Dim formBayar As New Bayar
        formBayar.TxtIDTransaksi.Text = TxtIDTransaksi.Text
        formBayar.TxtTotal.Text = TxtTotal.Text
        formBayar.Show()
        Me.Close()
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        If Login.CurrentUserRole = "Owner" Then
            Dim homeOwner As New HomeOwner()
            homeOwner.Show()
        ElseIf Login.CurrentUserRole = "Kasir" Then
            Dim homeKasir As New HomeKasir()
            homeKasir.Show()
        Else
            MessageBox.Show("Peran pengguna tidak dikenali. Hubungi administrator!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Me.Close()
    End Sub
End Class
