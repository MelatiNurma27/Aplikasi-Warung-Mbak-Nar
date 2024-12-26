Public Class HomeKasir
    Private Sub BtnAplikasi_Click(sender As Object, e As EventArgs) Handles BtnAplikasi.Click
        Dim Aplikasi As New Aplikasi()
        Aplikasi.Show()
        Me.Hide()
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Dim loginForm As New Login()
        loginForm.Show()
        Me.Close()
    End Sub
End Class