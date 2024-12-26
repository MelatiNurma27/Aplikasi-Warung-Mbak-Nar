Imports System.Data.Odbc
Public Class Bayar
    Dim conn As New OdbcConnection("Dsn=db_MbakNar")
    Dim cmd As OdbcCommand
    Dim adapter As OdbcDataAdapter
    Dim dt As DataTable

    Private Sub Bayar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbJenisPembayaran.Items.Add("Tunai")
        cbJenisPembayaran.Items.Add("Non Tunai")
        cbJenisPembayaran.SelectedIndex = -1
        TxtUangBayar.Enabled = False
        TxtUangKembali.Visible = True
    End Sub

    Private Sub cbJenisPembayaran_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbJenisPembayaran.SelectedIndexChanged
        If cbJenisPembayaran.SelectedIndex = -1 Then
            TxtUangBayar.Enabled = False
            TxtUangKembali.Visible = False
            TxtUangBayar.Clear()
            TxtUangKembali.Clear()
        ElseIf cbJenisPembayaran.SelectedItem.ToString() = "Tunai" Then
            TxtUangBayar.Enabled = True
            TxtUangKembali.Visible = True
            TxtUangKembali.Text = ""
        ElseIf cbJenisPembayaran.SelectedItem.ToString() = "Non Tunai" Then
            TxtUangBayar.Enabled = True
            TxtUangKembali.Visible = False
            TxtUangBayar.Clear()
            TxtUangKembali.Clear()
        End If
    End Sub

    Private Sub BtnBayar_Click(sender As Object, e As EventArgs) Handles BtnBayar.Click
        If cbJenisPembayaran.SelectedItem.ToString() = "Tunai" Then
            If TxtUangBayar.Text = "" OrElse Not IsNumeric(TxtUangBayar.Text) Then
                MessageBox.Show("Masukkan jumlah uang bayar yang valid!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim total As Decimal = Convert.ToDecimal(TxtTotal.Text)
                Dim uangBayar As Decimal = Convert.ToDecimal(TxtUangBayar.Text)
                If uangBayar >= total Then
                    TxtUangKembali.Text = (uangBayar - total).ToString("N0")
                    MessageBox.Show("Pembayaran berhasil dihitung!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Uang bayar kurang dari total!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        ElseIf cbJenisPembayaran.SelectedItem.ToString() = "Non Tunai" Then
            TxtUangKembali.Text = "0"
            MessageBox.Show("Pembayaran berhasil dihitung tanpa uang kembali!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnSelesai_Click(sender As Object, e As EventArgs) Handles BtnSelesai.Click
        Try
            Using conn As New OdbcConnection("Dsn=db_MbakNar")
                conn.Open()

                Dim idJenisPembayaran As Integer
                If cbJenisPembayaran.SelectedItem.ToString() = "Tunai" Then
                    idJenisPembayaran = 1
                ElseIf cbJenisPembayaran.SelectedItem.ToString() = "Non Tunai" Then
                    idJenisPembayaran = 2
                Else
                    MessageBox.Show("Pilih jenis pembayaran terlebih dahulu.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
                Dim queryTransaksi As String = "INSERT INTO table_pembayaran (ID_Transaksi, ID_JenisPembayaran, uang_bayar, uang_kembali) VALUES (?, ?, ?, ?)"
                Using cmd As New OdbcCommand(queryTransaksi, conn)
                    cmd.Parameters.AddWithValue("?", TxtIDTransaksi.Text)
                    cmd.Parameters.AddWithValue("?", idJenisPembayaran)
                    cmd.Parameters.AddWithValue("?", TxtUangBayar.Text)
                    cmd.Parameters.AddWithValue("?", TxtUangKembali.Text)
                    cmd.ExecuteNonQuery()
                End Using

                Dim queryLaporan As String = "INSERT INTO table_laporan (ID_Transaksi, ID_JenisPembayaran, tanggal, total_pembayaran) VALUES (?, ?, ?, ?)"
                Using cmdLaporan As New OdbcCommand(queryLaporan, conn)
                    cmdLaporan.Parameters.AddWithValue("?", TxtIDTransaksi.Text)
                    cmdLaporan.Parameters.AddWithValue("?", idJenisPembayaran)
                    cmdLaporan.Parameters.AddWithValue("?", DateTime.Now)
                    cmdLaporan.Parameters.AddWithValue("?", TxtTotal.Text)
                    cmdLaporan.ExecuteNonQuery()
                End Using
                MessageBox.Show("Transaksi berhasil disimpan dan laporan berhasil diperbarui.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error menyimpan transaksi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Me.Close()
        Aplikasi.Show()
    End Sub
End Class