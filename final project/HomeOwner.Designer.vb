<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeOwner
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeOwner))
        Me.BtnLaporan = New System.Windows.Forms.Button()
        Me.BtnAplikasi = New System.Windows.Forms.Button()
        Me.BtnMenu = New System.Windows.Forms.Button()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnLaporan
        '
        Me.BtnLaporan.BackColor = System.Drawing.Color.Tomato
        Me.BtnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLaporan.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLaporan.ForeColor = System.Drawing.Color.White
        Me.BtnLaporan.Location = New System.Drawing.Point(453, 124)
        Me.BtnLaporan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnLaporan.Name = "BtnLaporan"
        Me.BtnLaporan.Size = New System.Drawing.Size(256, 30)
        Me.BtnLaporan.TabIndex = 6
        Me.BtnLaporan.Text = "LIHAT LAPORAN"
        Me.BtnLaporan.UseVisualStyleBackColor = False
        '
        'BtnAplikasi
        '
        Me.BtnAplikasi.BackColor = System.Drawing.Color.Tomato
        Me.BtnAplikasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAplikasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAplikasi.ForeColor = System.Drawing.Color.White
        Me.BtnAplikasi.Location = New System.Drawing.Point(453, 188)
        Me.BtnAplikasi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAplikasi.Name = "BtnAplikasi"
        Me.BtnAplikasi.Size = New System.Drawing.Size(256, 30)
        Me.BtnAplikasi.TabIndex = 7
        Me.BtnAplikasi.Text = "APLIKASI HITUNG"
        Me.BtnAplikasi.UseVisualStyleBackColor = False
        '
        'BtnMenu
        '
        Me.BtnMenu.BackColor = System.Drawing.Color.Tomato
        Me.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMenu.ForeColor = System.Drawing.Color.White
        Me.BtnMenu.Location = New System.Drawing.Point(453, 254)
        Me.BtnMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(256, 30)
        Me.BtnMenu.TabIndex = 8
        Me.BtnMenu.Text = "DAFTAR MENU"
        Me.BtnMenu.UseVisualStyleBackColor = False
        '
        'BtnKeluar
        '
        Me.BtnKeluar.BackColor = System.Drawing.Color.Tomato
        Me.BtnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeluar.ForeColor = System.Drawing.Color.White
        Me.BtnKeluar.Location = New System.Drawing.Point(453, 315)
        Me.BtnKeluar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(256, 30)
        Me.BtnKeluar.TabIndex = 9
        Me.BtnKeluar.Text = "KELUAR"
        Me.BtnKeluar.UseVisualStyleBackColor = False
        '
        'HomeOwner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnMenu)
        Me.Controls.Add(Me.BtnAplikasi)
        Me.Controls.Add(Me.BtnLaporan)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "HomeOwner"
        Me.Text = "Home"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnLaporan As Button
    Friend WithEvents BtnAplikasi As Button
    Friend WithEvents BtnMenu As Button
    Friend WithEvents BtnKeluar As Button
End Class
