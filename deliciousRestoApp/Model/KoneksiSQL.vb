Imports System.Data.SqlClient
Module KoneksiSQL
    Public conn As SqlConnection
    Public query As String
    Public DA As SqlDataAdapter
    Public DS As DataSet
    Sub Koneksi()
        conn = New SqlConnection
        conn.ConnectionString = "data source=ASUS;initial catalog=restaurant;user=uhekroco;password=uhekroco123"
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Koneksi gagal!" & Err.Description)
        End Try
    End Sub
End Module
