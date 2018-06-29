Public Class FormDashboard
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RestaurantDataSet2.tbl_menu' table. You can move, or remove it, as needed.
        Me.Tbl_menuTableAdapter.Fill(Me.RestaurantDataSet2.tbl_menu)
        DaftarMenu.Visible = False
        daftarSupplier.Visible = False
        Koneksi()

    End Sub

    Private Sub DaftarMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarMenuToolStripMenuItem.Click
        DaftarMenu.Visible = True
        daftarSupplier.Visible = False

    End Sub

    Private Sub DaftarSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarSupplierToolStripMenuItem.Click
        DaftarMenu.Visible = False
        daftarSupplier.Visible = True

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click
        DaftarMenu.Visible = True
        daftarSupplier.Visible = False
    End Sub

    Private Sub Label4_Click_1(sender As Object, e As EventArgs) Handles Label4.Click
        DaftarMenu.Visible = False
        daftarSupplier.Visible = True
    End Sub

    Private Sub TambahSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahSupplierToolStripMenuItem.Click
        Dim supp = New TambahSupplier()
        supp.ShowDialog()

    End Sub

    Private Sub TambahMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahMenuToolStripMenuItem.Click
        Dim menu = New TambahMenu
        menu.Show()


    End Sub
End Class
