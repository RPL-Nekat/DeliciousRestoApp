<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TambahMenu
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtBrowse = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.pctMenu = New System.Windows.Forms.PictureBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.cmbSupplier = New System.Windows.Forms.ComboBox()
        Me.cmbKategori = New System.Windows.Forms.ComboBox()
        Me.txtHargaMenu = New System.Windows.Forms.NumericUpDown()
        Me.txtNamaMenu = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.RestaurantDataSet = New deliciousRestoApp.restaurantDataSet()
        Me.TblkategoriBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_kategoriTableAdapter = New deliciousRestoApp.restaurantDataSetTableAdapters.tbl_kategoriTableAdapter()
        Me.RestaurantDataSet1 = New deliciousRestoApp.restaurantDataSet1()
        Me.TblsupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_supplierTableAdapter = New deliciousRestoApp.restaurantDataSet1TableAdapters.tbl_supplierTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pctMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHargaMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestaurantDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblkategoriBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestaurantDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblsupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(599, 76)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(417, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tambah Menu Delicious Food"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.txtBrowse)
        Me.Panel2.Controls.Add(Me.btnBrowse)
        Me.Panel2.Controls.Add(Me.pctMenu)
        Me.Panel2.Controls.Add(Me.btnTambah)
        Me.Panel2.Controls.Add(Me.cmbSupplier)
        Me.Panel2.Controls.Add(Me.cmbKategori)
        Me.Panel2.Controls.Add(Me.txtHargaMenu)
        Me.Panel2.Controls.Add(Me.txtNamaMenu)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(0, 77)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(599, 393)
        Me.Panel2.TabIndex = 1
        '
        'txtBrowse
        '
        Me.txtBrowse.Location = New System.Drawing.Point(311, 259)
        Me.txtBrowse.Name = "txtBrowse"
        Me.txtBrowse.Size = New System.Drawing.Size(180, 29)
        Me.txtBrowse.TabIndex = 11
        '
        'btnBrowse
        '
        Me.btnBrowse.ForeColor = System.Drawing.Color.Black
        Me.btnBrowse.Location = New System.Drawing.Point(497, 260)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 28)
        Me.btnBrowse.TabIndex = 10
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'pctMenu
        '
        Me.pctMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctMenu.Location = New System.Drawing.Point(311, 49)
        Me.pctMenu.Name = "pctMenu"
        Me.pctMenu.Size = New System.Drawing.Size(261, 191)
        Me.pctMenu.TabIndex = 9
        Me.pctMenu.TabStop = False
        '
        'btnTambah
        '
        Me.btnTambah.ForeColor = System.Drawing.Color.Black
        Me.btnTambah.Location = New System.Drawing.Point(497, 294)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 29)
        Me.btnTambah.TabIndex = 8
        Me.btnTambah.Text = "Tambah+"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'cmbSupplier
        '
        Me.cmbSupplier.DataSource = Me.TblsupplierBindingSource
        Me.cmbSupplier.DisplayMember = "nama_supplier"
        Me.cmbSupplier.FormattingEnabled = True
        Me.cmbSupplier.Location = New System.Drawing.Point(25, 291)
        Me.cmbSupplier.Name = "cmbSupplier"
        Me.cmbSupplier.Size = New System.Drawing.Size(221, 29)
        Me.cmbSupplier.TabIndex = 7
        Me.cmbSupplier.ValueMember = "id_supplier"
        '
        'cmbKategori
        '
        Me.cmbKategori.DataSource = Me.TblkategoriBindingSource
        Me.cmbKategori.DisplayMember = "kategori"
        Me.cmbKategori.FormattingEnabled = True
        Me.cmbKategori.Location = New System.Drawing.Point(25, 211)
        Me.cmbKategori.Name = "cmbKategori"
        Me.cmbKategori.Size = New System.Drawing.Size(121, 29)
        Me.cmbKategori.TabIndex = 6
        Me.cmbKategori.ValueMember = "id_kategori"
        '
        'txtHargaMenu
        '
        Me.txtHargaMenu.Location = New System.Drawing.Point(25, 127)
        Me.txtHargaMenu.Name = "txtHargaMenu"
        Me.txtHargaMenu.Size = New System.Drawing.Size(120, 29)
        Me.txtHargaMenu.TabIndex = 5
        '
        'txtNamaMenu
        '
        Me.txtNamaMenu.Location = New System.Drawing.Point(25, 49)
        Me.txtNamaMenu.Name = "txtNamaMenu"
        Me.txtNamaMenu.Size = New System.Drawing.Size(221, 29)
        Me.txtNamaMenu.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 28)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Nama Supplier:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 28)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Kategori:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 28)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Harga (Rp.):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama Menu:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'RestaurantDataSet
        '
        Me.RestaurantDataSet.DataSetName = "restaurantDataSet"
        Me.RestaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblkategoriBindingSource
        '
        Me.TblkategoriBindingSource.DataMember = "tbl_kategori"
        Me.TblkategoriBindingSource.DataSource = Me.RestaurantDataSet
        '
        'Tbl_kategoriTableAdapter
        '
        Me.Tbl_kategoriTableAdapter.ClearBeforeFill = True
        '
        'RestaurantDataSet1
        '
        Me.RestaurantDataSet1.DataSetName = "restaurantDataSet1"
        Me.RestaurantDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblsupplierBindingSource
        '
        Me.TblsupplierBindingSource.DataMember = "tbl_supplier"
        Me.TblsupplierBindingSource.DataSource = Me.RestaurantDataSet1
        '
        'Tbl_supplierTableAdapter
        '
        Me.Tbl_supplierTableAdapter.ClearBeforeFill = True
        '
        'TambahMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.deliciousRestoApp.My.Resources.Resources.ssbadag
        Me.ClientSize = New System.Drawing.Size(597, 436)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "TambahMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TambahMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pctMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHargaMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestaurantDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblkategoriBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestaurantDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblsupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnTambah As Button
    Friend WithEvents cmbSupplier As ComboBox
    Friend WithEvents cmbKategori As ComboBox
    Friend WithEvents txtHargaMenu As NumericUpDown
    Friend WithEvents txtNamaMenu As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBrowse As Button
    Friend WithEvents pctMenu As PictureBox
    Friend WithEvents txtBrowse As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents RestaurantDataSet As restaurantDataSet
    Friend WithEvents TblkategoriBindingSource As BindingSource
    Friend WithEvents Tbl_kategoriTableAdapter As restaurantDataSetTableAdapters.tbl_kategoriTableAdapter
    Friend WithEvents RestaurantDataSet1 As restaurantDataSet1
    Friend WithEvents TblsupplierBindingSource As BindingSource
    Friend WithEvents Tbl_supplierTableAdapter As restaurantDataSet1TableAdapters.tbl_supplierTableAdapter
End Class
