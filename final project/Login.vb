Imports System.Data.Odbc

Public Class Login
    Dim conn As New OdbcConnection("Dsn=db_MbakNar")
    Dim cmd As OdbcCommand
    Dim dr As OdbcDataReader
    Public Shared CurrentUserRole As String

    Private Sub BtnMasuk_Click(sender As Object, e As EventArgs) Handles BtnMasuk.Click
        Dim username As String = TxtUsername.Text
        Dim password As String = TxtPassword.Text

        If username = "" Or password = "" Then
            MessageBox.Show("Harap isi username dan password!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            conn.Open()
            Dim query As String = "SELECT * FROM table_user WHERE Username = ? AND Password = ?"
            cmd = New OdbcCommand(query, conn)
            cmd.Parameters.AddWithValue("@Username", username)
            cmd.Parameters.AddWithValue("@Password", password)

            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                dr.Read()
                Dim role As String = dr("Role").ToString()

                CurrentUserRole = role

                MessageBox.Show("Login berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

                If role = "Owner" Then
                    Dim homeOwner As New HomeOwner
                    homeOwner.Show()
                ElseIf role = "Kasir" Then
                    Dim homeKasir As New HomeKasir
                    homeKasir.Show()
                End If

                Me.Hide()
            Else
                MessageBox.Show("Username atau password salah!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
End Class
