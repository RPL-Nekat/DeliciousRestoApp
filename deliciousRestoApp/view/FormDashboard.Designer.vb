<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDashboard
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FlieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DaftarMenu = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.daftarSupplier = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RestaurantDataSet2 = New deliciousRestoApp.restaurantDataSet2()
        Me.TblmenuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_menuTableAdapter = New deliciousRestoApp.restaurantDataSet2TableAdapters.tbl_menuTableAdapter()
        Me.IdmenuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamamenuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdkategoriDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdsupplierDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GambarDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.DaftarMenu.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.daftarSupplier.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.RestaurantDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblmenuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 3)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1209, 99)
        Me.Panel1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FlieToolStripMenuItem, Me.ViewToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1205, 29)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FlieToolStripMenuItem
        '
        Me.FlieToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.FlieToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FlieToolStripMenuItem.Name = "FlieToolStripMenuItem"
        Me.FlieToolStripMenuItem.Size = New System.Drawing.Size(41, 25)
        Me.FlieToolStripMenuItem.Text = "Flie"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(122, 26)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DaftarMenuToolStripMenuItem, Me.DaftarSupplierToolStripMenuItem})
        Me.ViewToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(49, 25)
        Me.ViewToolStripMenuItem.Text = "view"
        '
        'DaftarMenuToolStripMenuItem
        '
        Me.DaftarMenuToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.DaftarMenuToolStripMenuItem.Name = "DaftarMenuToolStripMenuItem"
        Me.DaftarMenuToolStripMenuItem.Size = New System.Drawing.Size(174, 26)
        Me.DaftarMenuToolStripMenuItem.Text = "Daftar Menu"
        '
        'DaftarSupplierToolStripMenuItem
        '
        Me.DaftarSupplierToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.DaftarSupplierToolStripMenuItem.Name = "DaftarSupplierToolStripMenuItem"
        Me.DaftarSupplierToolStripMenuItem.Size = New System.Drawing.Size(174, 26)
        Me.DaftarSupplierToolStripMenuItem.Text = "Daftar Supplier"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahMenuToolStripMenuItem, Me.TambahSupplierToolStripMenuItem})
        Me.EditToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(47, 25)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'TambahMenuToolStripMenuItem
        '
        Me.TambahMenuToolStripMenuItem.Name = "TambahMenuToolStripMenuItem"
        Me.TambahMenuToolStripMenuItem.Size = New System.Drawing.Size(183, 26)
        Me.TambahMenuToolStripMenuItem.Text = "Tambah Menu"
        '
        'TambahSupplierToolStripMenuItem
        '
        Me.TambahSupplierToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.TambahSupplierToolStripMenuItem.Name = "TambahSupplierToolStripMenuItem"
        Me.TambahSupplierToolStripMenuItem.Size = New System.Drawing.Size(183, 26)
        Me.TambahSupplierToolStripMenuItem.Text = "Tambah Supplier"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 62)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Delicious Food"
        '
        'DaftarMenu
        '
        Me.DaftarMenu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DaftarMenu.BackColor = System.Drawing.Color.Transparent
        Me.DaftarMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DaftarMenu.Controls.Add(Me.TextBox1)
        Me.DaftarMenu.Controls.Add(Me.Label3)
        Me.DaftarMenu.Controls.Add(Me.DataGridView1)
        Me.DaftarMenu.Location = New System.Drawing.Point(248, 110)
        Me.DaftarMenu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DaftarMenu.Name = "DaftarMenu"
        Me.DaftarMenu.Size = New System.Drawing.Size(961, 602)
        Me.DaftarMenu.TabIndex = 2
        Me.DaftarMenu.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(702, 71)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(244, 36)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Tag = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(526, 42)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Daftar Menu dan Harga di Delicious Food"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdmenuDataGridViewTextBoxColumn, Me.NamamenuDataGridViewTextBoxColumn, Me.HargaDataGridViewTextBoxColumn, Me.IdkategoriDataGridViewTextBoxColumn, Me.IdsupplierDataGridViewTextBoxColumn, Me.GambarDataGridViewImageColumn})
        Me.DataGridView1.DataSource = Me.TblmenuBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(5, 113)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(944, 482)
        Me.DataGridView1.TabIndex = 0
        '
        'daftarSupplier
        '
        Me.daftarSupplier.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.daftarSupplier.BackColor = System.Drawing.Color.Transparent
        Me.daftarSupplier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.daftarSupplier.Controls.Add(Me.TextBox2)
        Me.daftarSupplier.Controls.Add(Me.Label5)
        Me.daftarSupplier.Controls.Add(Me.DataGridView2)
        Me.daftarSupplier.Location = New System.Drawing.Point(248, 110)
        Me.daftarSupplier.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.daftarSupplier.Name = "daftarSupplier"
        Me.daftarSupplier.Size = New System.Drawing.Size(959, 602)
        Me.daftarSupplier.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(702, 71)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(244, 36)
        Me.TextBox2.TabIndex = 6
        Me.TextBox2.Tag = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(533, 42)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Daftar Anggota Supplier di Delicious Food"
        '
        'DataGridView2
        '
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(5, 113)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(942, 482)
        Me.DataGridView2.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(2, 99)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(240, 616)
        Me.Panel2.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(207, 42)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Daftar Supplier"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 42)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Daftar Menu"
        '
        'RestaurantDataSet2
        '
        Me.RestaurantDataSet2.DataSetName = "restaurantDataSet2"
        Me.RestaurantDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblmenuBindingSource
        '
        Me.TblmenuBindingSource.DataMember = "tbl_menu"
        Me.TblmenuBindingSource.DataSource = Me.RestaurantDataSet2
        '
        'Tbl_menuTableAdapter
        '
        Me.Tbl_menuTableAdapter.ClearBeforeFill = True
        '
        'IdmenuDataGridViewTextBoxColumn
        '
        Me.IdmenuDataGridViewTextBoxColumn.DataPropertyName = "id_menu"
        Me.IdmenuDataGridViewTextBoxColumn.HeaderText = "id_menu"
        Me.IdmenuDataGridViewTextBoxColumn.Name = "IdmenuDataGridViewTextBoxColumn"
        Me.IdmenuDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamamenuDataGridViewTextBoxColumn
        '
        Me.NamamenuDataGridViewTextBoxColumn.DataPropertyName = "nama_menu"
        Me.NamamenuDataGridViewTextBoxColumn.HeaderText = "nama_menu"
        Me.NamamenuDataGridViewTextBoxColumn.Name = "NamamenuDataGridViewTextBoxColumn"
        Me.NamamenuDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HargaDataGridViewTextBoxColumn
        '
        Me.HargaDataGridViewTextBoxColumn.DataPropertyName = "harga"
        Me.HargaDataGridViewTextBoxColumn.HeaderText = "harga"
        Me.HargaDataGridViewTextBoxColumn.Name = "HargaDataGridViewTextBoxColumn"
        Me.HargaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdkategoriDataGridViewTextBoxColumn
        '
        Me.IdkategoriDataGridViewTextBoxColumn.DataPropertyName = "id_kategori"
        Me.IdkategoriDataGridViewTextBoxColumn.HeaderText = "id_kategori"
        Me.IdkategoriDataGridViewTextBoxColumn.Name = "IdkategoriDataGridViewTextBoxColumn"
        Me.IdkategoriDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdsupplierDataGridViewTextBoxColumn
        '
        Me.IdsupplierDataGridViewTextBoxColumn.DataPropertyName = "id_supplier"
        Me.IdsupplierDataGridViewTextBoxColumn.HeaderText = "id_supplier"
        Me.IdsupplierDataGridViewTextBoxColumn.Name = "IdsupplierDataGridViewTextBoxColumn"
        Me.IdsupplierDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GambarDataGridViewImageColumn
        '
        Me.GambarDataGridViewImageColumn.DataPropertyName = "gambar"
        Me.GambarDataGridViewImageColumn.HeaderText = "gambar"
        Me.GambarDataGridViewImageColumn.Name = "GambarDataGridViewImageColumn"
        Me.GambarDataGridViewImageColumn.ReadOnly = True
        '
        'FormDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.deliciousRestoApp.My.Resources.Resources.ssbadag
        Me.ClientSize = New System.Drawing.Size(1208, 710)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DaftarMenu)
        Me.Controls.Add(Me.daftarSupplier)
        Me.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FormDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard (Admin)"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.DaftarMenu.ResumeLayout(False)
        Me.DaftarMenu.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.daftarSupplier.ResumeLayout(False)
        Me.daftarSupplier.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.RestaurantDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblmenuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DaftarMenu As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents daftarSupplier As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FlieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DaftarMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DaftarSupplierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahSupplierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestaurantDataSet2 As restaurantDataSet2
    Friend WithEvents TblmenuBindingSource As BindingSource
    Friend WithEvents Tbl_menuTableAdapter As restaurantDataSet2TableAdapters.tbl_menuTableAdapter
    Friend WithEvents IdmenuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamamenuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HargaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdkategoriDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdsupplierDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GambarDataGridViewImageColumn As DataGridViewImageColumn
End Class
