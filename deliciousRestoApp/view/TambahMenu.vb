Imports System.Data.SqlClient
Imports System.IO

Public Class TambahMenu
    Public cmd As SqlCommand

    Private Sub TambahMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RestaurantDataSet1.tbl_supplier' table. You can move, or remove it, as needed.
        Me.Tbl_supplierTableAdapter.Fill(Me.RestaurantDataSet1.tbl_supplier)
        'TODO: This line of code loads data into the 'RestaurantDataSet.tbl_kategori' table. You can move, or remove it, as needed.
        Me.Tbl_kategoriTableAdapter.Fill(Me.RestaurantDataSet.tbl_kategori)
        Koneksi()

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtBrowse.Text = " " Then
            MsgBox("Mohon Isi Gambar")

        Else

            cmd = New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@NamaMenu", txtNamaMenu.Text)
            cmd.Parameters.AddWithValue("@HargaMenu", txtHargaMenu.Text)
            cmd.Parameters.AddWithValue("@Kategori", cmbKategori.SelectedValue)
            cmd.Parameters.AddWithValue("@Supplier", cmbSupplier.SelectedValue)
            Dim MS As New MemoryStream
            pctMenu.BackgroundImage.Save(MS, pctMenu.BackgroundImage.RawFormat)
            Dim Dgambar As Byte() = MS.GetBuffer
            Dim Images As New SqlParameter("@gambar", SqlDbType.Image)
            Images.Value = Dgambar
            cmd.Parameters.Add(Images)
            cmd.CommandText = "INSERT INTO tbl_menu VALUES(@NamaMenu, @HargaMenu, @Kategori, @Supplier, @gambar)"
            cmd.ExecuteNonQuery()
            MsgBox("Menu berhasil ditambahkan!")
            cmd.Dispose()
            conn.Close()
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            pctMenu.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            pctMenu.BackgroundImageLayout = ImageLayout.Zoom

        End If
    End Sub
End Class