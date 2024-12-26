<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeKasir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeKasir))
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.BtnAplikasi = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnKeluar
        '
        Me.BtnKeluar.BackColor = System.Drawing.Color.Tomato
        Me.BtnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeluar.ForeColor = System.Drawing.Color.White
        Me.BtnKeluar.Location = New System.Drawing.Point(453, 188)
        Me.BtnKeluar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(258, 30)
        Me.BtnKeluar.TabIndex = 14
        Me.BtnKeluar.Text = "KELUAR"
        Me.BtnKeluar.UseVisualStyleBackColor = False
        '
        'BtnAplikasi
        '
        Me.BtnAplikasi.BackColor = System.Drawing.Color.Tomato
        Me.BtnAplikasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAplikasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAplikasi.ForeColor = System.Drawing.Color.White
        Me.BtnAplikasi.Location = New System.Drawing.Point(453, 126)
        Me.BtnAplikasi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAplikasi.Name = "BtnAplikasi"
        Me.BtnAplikasi.Size = New System.Drawing.Size(258, 30)
        Me.BtnAplikasi.TabIndex = 12
        Me.BtnAplikasi.Text = "APLIKASI HITUNG"
        Me.BtnAplikasi.UseVisualStyleBackColor = False
        '
        'HomeKasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnAplikasi)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "HomeKasir"
        Me.Text = "HomeKasir"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnKeluar As Button
    Friend WithEvents BtnAplikasi As Button
End Class
