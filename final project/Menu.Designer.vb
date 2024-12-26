<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.cbKategori = New System.Windows.Forms.ComboBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtMenu = New System.Windows.Forms.TextBox()
        Me.txtIDMenu = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnHapusMenu = New System.Windows.Forms.Button()
        Me.btnTambahMenu = New System.Windows.Forms.Button()
        Me.btnEditMenu = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbKategori
        '
        Me.cbKategori.FormattingEnabled = True
        Me.cbKategori.Location = New System.Drawing.Point(127, 116)
        Me.cbKategori.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbKategori.Name = "cbKategori"
        Me.cbKategori.Size = New System.Drawing.Size(215, 24)
        Me.cbKategori.TabIndex = 39
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(127, 188)
        Me.txtHarga.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(215, 22)
        Me.txtHarga.TabIndex = 38
        '
        'txtMenu
        '
        Me.txtMenu.Location = New System.Drawing.Point(127, 153)
        Me.txtMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMenu.Name = "txtMenu"
        Me.txtMenu.Size = New System.Drawing.Size(215, 22)
        Me.txtMenu.TabIndex = 37
        '
        'txtIDMenu
        '
        Me.txtIDMenu.Location = New System.Drawing.Point(127, 79)
        Me.txtIDMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIDMenu.Name = "txtIDMenu"
        Me.txtIDMenu.Size = New System.Drawing.Size(215, 22)
        Me.txtIDMenu.TabIndex = 36
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.Tomato
        Me.Label10.Location = New System.Drawing.Point(44, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 16)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Menu"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.Tomato
        Me.Label9.Location = New System.Drawing.Point(44, 191)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 16)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Harga"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Tomato
        Me.Label4.Location = New System.Drawing.Point(44, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "ID Menu"
        '
        'btnHapusMenu
        '
        Me.btnHapusMenu.BackColor = System.Drawing.Color.Tomato
        Me.btnHapusMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapusMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapusMenu.ForeColor = System.Drawing.Color.White
        Me.btnHapusMenu.Location = New System.Drawing.Point(613, 179)
        Me.btnHapusMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnHapusMenu.Name = "btnHapusMenu"
        Me.btnHapusMenu.Size = New System.Drawing.Size(142, 30)
        Me.btnHapusMenu.TabIndex = 42
        Me.btnHapusMenu.Text = "HAPUS MENU"
        Me.btnHapusMenu.UseVisualStyleBackColor = False
        '
        'btnTambahMenu
        '
        Me.btnTambahMenu.BackColor = System.Drawing.Color.Tomato
        Me.btnTambahMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambahMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahMenu.ForeColor = System.Drawing.Color.White
        Me.btnTambahMenu.Location = New System.Drawing.Point(613, 128)
        Me.btnTambahMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTambahMenu.Name = "btnTambahMenu"
        Me.btnTambahMenu.Size = New System.Drawing.Size(142, 30)
        Me.btnTambahMenu.TabIndex = 41
        Me.btnTambahMenu.Text = "TAMBAH MENU"
        Me.btnTambahMenu.UseVisualStyleBackColor = False
        '
        'btnEditMenu
        '
        Me.btnEditMenu.BackColor = System.Drawing.Color.Tomato
        Me.btnEditMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditMenu.ForeColor = System.Drawing.Color.White
        Me.btnEditMenu.Location = New System.Drawing.Point(613, 78)
        Me.btnEditMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEditMenu.Name = "btnEditMenu"
        Me.btnEditMenu.Size = New System.Drawing.Size(142, 30)
        Me.btnEditMenu.TabIndex = 40
        Me.btnEditMenu.Text = "EDIT MENU"
        Me.btnEditMenu.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.Tomato
        Me.DataGridView1.Location = New System.Drawing.Point(45, 224)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(710, 153)
        Me.DataGridView1.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Tomato
        Me.Label1.Location = New System.Drawing.Point(44, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Kategori"
        '
        'BtnKeluar
        '
        Me.BtnKeluar.BackColor = System.Drawing.Color.Tomato
        Me.BtnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeluar.ForeColor = System.Drawing.Color.White
        Me.BtnKeluar.Location = New System.Drawing.Point(613, 391)
        Me.BtnKeluar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(142, 30)
        Me.BtnKeluar.TabIndex = 46
        Me.BtnKeluar.Text = "KELUAR"
        Me.BtnKeluar.UseVisualStyleBackColor = False
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnHapusMenu)
        Me.Controls.Add(Me.btnTambahMenu)
        Me.Controls.Add(Me.btnEditMenu)
        Me.Controls.Add(Me.cbKategori)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.txtMenu)
        Me.Controls.Add(Me.txtIDMenu)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Menu"
        Me.Text = "Menu"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbKategori As ComboBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtMenu As TextBox
    Friend WithEvents txtIDMenu As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnHapusMenu As Button
    Friend WithEvents btnTambahMenu As Button
    Friend WithEvents btnEditMenu As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnKeluar As Button
End Class
