Imports System.Data.Odbc

Public Class Menu
    Private connection As OdbcConnection

    Public Sub New()
        InitializeComponent()
        connection = New OdbcConnection("DSN=db_MbakNar")
        LoadKategori()
        LoadDataGrid()
    End Sub

    Private Sub LoadKategori()
        Using connection = New OdbcConnection("DSN=db_MbakNar")
            Dim cmd As OdbcCommand = Nothing
            Dim reader As OdbcDataReader = Nothing
            Try
                connection.Open()
                cmd = New OdbcCommand("SELECT ID_Kategori, Kategori FROM table_kategori", connection)
                reader = cmd.ExecuteReader()
                cbKategori.Items.Clear()

                While reader.Read()
                    cbKategori.Items.Add(New KeyValuePair(Of String, String)(reader("ID_Kategori").ToString(), reader("Kategori").ToString()))
                End While

                cbKategori.DisplayMember = "Value"
                cbKategori.ValueMember = "Key"
            Catch ex As Exception
                MessageBox.Show("Error loading categories: " & ex.Message)
            Finally
                If reader IsNot Nothing Then reader.Close()
            End Try
        End Using
    End Sub

    Private Sub LoadDataGrid()
        Using connection = New OdbcConnection("DSN=db_MbakNar")
            Dim adapter As OdbcDataAdapter = Nothing
            Try
                connection.Open()
                adapter = New OdbcDataAdapter("SELECT ID_Menu, ID_Kategori, menu, harga FROM table_menu", connection)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnTambahMenu_Click(sender As Object, e As EventArgs) Handles btnTambahMenu.Click
        Using connection = New OdbcConnection("DSN=db_MbakNar")
            Try
                connection.Open()
                Dim query As String = "INSERT INTO table_menu (ID_Menu, ID_Kategori, menu, harga) VALUES (?, ?, ?, ?)"
                Using cmd As New OdbcCommand(query, connection)
                    cmd.Parameters.AddWithValue("?", txtIDMenu.Text)
                    cmd.Parameters.AddWithValue("?", CType(cbKategori.SelectedItem, KeyValuePair(Of String, String)).Key)
                    cmd.Parameters.AddWithValue("?", txtMenu.Text)
                    cmd.Parameters.AddWithValue("?", txtHarga.Text)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Menu added successfully!")
                LoadDataGrid()
            Catch ex As Exception
                MessageBox.Show("Error adding menu: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnEditMenu_Click(sender As Object, e As EventArgs) Handles btnEditMenu.Click
        Using connection = New OdbcConnection("DSN=db_MbakNar")
            Try
                connection.Open()
                Dim query As String = "UPDATE table_menu SET ID_Kategori = ?, menu = ?, harga = ? WHERE ID_Menu = ?"
                Using cmd As New OdbcCommand(query, connection)
                    cmd.Parameters.AddWithValue("?", CType(cbKategori.SelectedItem, KeyValuePair(Of String, String)).Key)
                    cmd.Parameters.AddWithValue("?", txtMenu.Text)
                    cmd.Parameters.AddWithValue("?", txtHarga.Text)
                    cmd.Parameters.AddWithValue("?", txtIDMenu.Text)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Menu updated successfully!")
                LoadDataGrid()
            Catch ex As Exception
                MessageBox.Show("Error updating menu: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnHapusMenu_Click(sender As Object, e As EventArgs) Handles btnHapusMenu.Click
        Using connection = New OdbcConnection("DSN=db_MbakNar")
            Try
                connection.Open()
                Dim query As String = "DELETE FROM table_menu WHERE ID_Menu = ?"
                Using cmd As New OdbcCommand(query, connection)
                    cmd.Parameters.AddWithValue("?", txtIDMenu.Text)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Menu deleted successfully!")
                LoadDataGrid()
            Catch ex As Exception
                MessageBox.Show("Error deleting menu: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Dim homeForm As New HomeOwner()
        homeForm.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            txtIDMenu.Text = row.Cells("ID_Menu").Value.ToString()
            cbKategori.Text = row.Cells("ID_Kategori").Value.ToString()
            txtMenu.Text = row.Cells("menu").Value.ToString()
            txtHarga.Text = row.Cells("harga").Value.ToString()
        End If
    End Sub
End Class
