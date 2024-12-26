<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Bayar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bayar))
        Me.TxtIDTransaksi = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtUangBayar = New System.Windows.Forms.TextBox()
        Me.TxtUangKembali = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbJenisPembayaran = New System.Windows.Forms.ComboBox()
        Me.BtnSelesai = New System.Windows.Forms.Button()
        Me.BtnBayar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtIDTransaksi
        '
        Me.TxtIDTransaksi.Location = New System.Drawing.Point(451, 69)
        Me.TxtIDTransaksi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtIDTransaksi.Name = "TxtIDTransaksi"
        Me.TxtIDTransaksi.Size = New System.Drawing.Size(205, 22)
        Me.TxtIDTransaksi.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Tomato
        Me.Label7.Location = New System.Drawing.Point(447, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "ID Transaksi"
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(452, 144)
        Me.TxtTotal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(205, 22)
        Me.TxtTotal.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Tomato
        Me.Label2.Location = New System.Drawing.Point(410, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 16)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Rp"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Tomato
        Me.Label1.Location = New System.Drawing.Point(448, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Total Pembayaran"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Tomato
        Me.Label3.Location = New System.Drawing.Point(449, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Uang Bayar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Tomato
        Me.Label4.Location = New System.Drawing.Point(449, 333)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 16)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Uang Kembali"
        '
        'TxtUangBayar
        '
        Me.TxtUangBayar.Location = New System.Drawing.Point(452, 292)
        Me.TxtUangBayar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtUangBayar.Name = "TxtUangBayar"
        Me.TxtUangBayar.Size = New System.Drawing.Size(205, 22)
        Me.TxtUangBayar.TabIndex = 27
        '
        'TxtUangKembali
        '
        Me.TxtUangKembali.Location = New System.Drawing.Point(452, 361)
        Me.TxtUangKembali.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtUangKembali.Name = "TxtUangKembali"
        Me.TxtUangKembali.Size = New System.Drawing.Size(205, 22)
        Me.TxtUangKembali.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Tomato
        Me.Label6.Location = New System.Drawing.Point(449, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 16)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Jenis Pembayaran"
        '
        'cbJenisPembayaran
        '
        Me.cbJenisPembayaran.FormattingEnabled = True
        Me.cbJenisPembayaran.Location = New System.Drawing.Point(452, 216)
        Me.cbJenisPembayaran.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbJenisPembayaran.Name = "cbJenisPembayaran"
        Me.cbJenisPembayaran.Size = New System.Drawing.Size(205, 24)
        Me.cbJenisPembayaran.TabIndex = 30
        '
        'BtnSelesai
        '
        Me.BtnSelesai.BackColor = System.Drawing.Color.Tomato
        Me.BtnSelesai.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSelesai.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSelesai.ForeColor = System.Drawing.Color.White
        Me.BtnSelesai.Location = New System.Drawing.Point(669, 409)
        Me.BtnSelesai.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSelesai.Name = "BtnSelesai"
        Me.BtnSelesai.Size = New System.Drawing.Size(119, 30)
        Me.BtnSelesai.TabIndex = 31
        Me.BtnSelesai.Text = "Selesai"
        Me.BtnSelesai.UseVisualStyleBackColor = False
        '
        'BtnBayar
        '
        Me.BtnBayar.BackColor = System.Drawing.Color.Tomato
        Me.BtnBayar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBayar.ForeColor = System.Drawing.Color.White
        Me.BtnBayar.Location = New System.Drawing.Point(669, 357)
        Me.BtnBayar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnBayar.Name = "BtnBayar"
        Me.BtnBayar.Size = New System.Drawing.Size(119, 30)
        Me.BtnBayar.TabIndex = 32
        Me.BtnBayar.Text = "Bayar"
        Me.BtnBayar.UseVisualStyleBackColor = False
        '
        'Bayar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnBayar)
        Me.Controls.Add(Me.BtnSelesai)
        Me.Controls.Add(Me.cbJenisPembayaran)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtUangKembali)
        Me.Controls.Add(Me.TxtUangBayar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtIDTransaksi)
        Me.Controls.Add(Me.Label7)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Bayar"
        Me.Text = "Bayar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtIDTransaksi As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtUangBayar As TextBox
    Friend WithEvents TxtUangKembali As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbJenisPembayaran As ComboBox
    Friend WithEvents BtnSelesai As Button
    Friend WithEvents BtnBayar As Button
End Class
