Public Class usu_clien
    Private Sub btnClien_Click(sender As Object, e As EventArgs) Handles btnClien.Click
        Dim frm As New clifor()
        frm.Show() ' Abre clifor sin cerrar usu_clien
    End Sub


    Private Sub btnUsu_Click(sender As Object, e As EventArgs) Handles btnUsu.Click
        Dim ps As New forregistro()
        ps.ShowDialog()
    End Sub

    Private Sub Bntarticulos_Click(sender As Object, e As EventArgs) Handles Bntarticulos.Click
        Dim ps As New articulos
        ps.ShowDialog()
    End Sub

    Private Sub bntfactura_Click(sender As Object, e As EventArgs) Handles bntfactura.Click
        Dim ps As New factura
        ps.ShowDialog()
    End Sub
End Class