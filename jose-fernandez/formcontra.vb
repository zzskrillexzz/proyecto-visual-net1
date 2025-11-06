Public Class formcontra
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim nueva As String = txtcambio1.Text
        Dim confirma As String = txtcambio2.Text

        If nueva = "" Or confirma = "" Then
            MsgBox("Por favor, ingrese y confirme la nueva contraseña.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If nueva = confirma Then
            SQL = "UPDATE tb_usuarios SET contraseña='" & nueva & "' WHERE id_usuario=" & codusuario
            basexd.ejecutar(SQL) '´para usar el metodo ejecutar compartido
            MsgBox("Contraseña actualizada.", MsgBoxStyle.Information)
            Me.Close()
        Else
            MsgBox("Las contraseñas no coinciden.", MsgBoxStyle.Critical)
        End If

    End Sub
End Class
