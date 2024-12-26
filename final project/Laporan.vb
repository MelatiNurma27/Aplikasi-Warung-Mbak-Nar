Imports System.Data.Odbc

Public Class Laporan
    Private ReadOnly Conn As OdbcConnection
    Private Da As OdbcDataAdapter
    Private Ds As DataSet

    Public Sub New()
        InitializeComponent()
        Conn = New OdbcConnection("Dsn=db_MbakNar")
        Try
            Conn.Open()
        Catch ex As Exception
            MessageBox.Show("Koneksi ke database gagal: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            InitializeDataGridView()
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub InitializeDataGridView()
        DataGridView1.AutoGenerateColumns = True
        DataGridView1.Columns.Clear()

        DataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub LoadData()
        Try
            Dim Query As String = "SELECT ID_Laporan, ID_Transaksi, ID_JenisPembayaran, tanggal, total_pembayaran FROM table_laporan"
            Da = New OdbcDataAdapter(Query, Conn)
            Ds = New DataSet()
            Da.Fill(Ds, "table_laporan")

            If Ds.Tables("table_laporan").Rows.Count > 0 Then
                DataGridView1.DataSource = Ds.Tables("table_laporan")
            Else
                MessageBox.Show("Tidak ada data ditemukan di tabel.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Try
            Dim HomeOwnerForm As New HomeOwner()
            HomeOwnerForm.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal keluar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError
        MessageBox.Show("Terjadi kesalahan pada DataGridView: " & e.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
End Class
