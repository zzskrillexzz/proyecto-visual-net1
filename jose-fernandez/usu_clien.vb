Public Class usu_clien
    Private Sub btnClien_Click(sender As Object, e As EventArgs) Handles btnClien.Click
        ' ---abre el formulario de clientes ---
        Dim ps As New clifor()
        ps.Show()
        Me.Close()
    End Sub

    Private Sub btnUsu_Click(sender As Object, e As EventArgs) Handles btnUsu.Click
        ' --- abre el formulario de usuarios ---
        Dim ps As New forregistro()
        ps.Show()
        Me.Close()
    End Sub

    Private Sub Bntarticulos_Click(sender As Object, e As EventArgs) Handles Bntarticulos.Click
        Dim ps As New articulos
        ps.Show()
        Me.Close()

    End Sub

    Private Sub bntfactura_Click(sender As Object, e As EventArgs) Handles bntfactura.Click
        Dim ps As New factura
        ps.Show()
        Me.Close()
    End Sub
End Class