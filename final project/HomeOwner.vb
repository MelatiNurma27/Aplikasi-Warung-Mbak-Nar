Imports System.Data.Odbc
Public Class HomeOwner
    Private Sub BtnLaporan_Click(sender As Object, e As EventArgs) Handles BtnLaporan.Click
        Dim LaporanForm As New Laporan()
        LaporanForm.Show()
        Me.Close()
    End Sub

    Private Sub BtnAplikasi_Click(sender As Object, e As EventArgs) Handles BtnAplikasi.Click
        Dim Aplikasiform As New Aplikasi()
        Aplikasiform.Show()
        Me.Close()
    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        Dim MenuForm As New Menu()
        MenuForm.Show()
        Me.Close()
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Dim loginForm As New Login()
        loginForm.Show()
        Me.Close()
    End Sub
End Class
