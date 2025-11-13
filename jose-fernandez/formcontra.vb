Public Class formcontra

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim nueva As String = txtcambio1.Text.Trim()
        Dim confirma As String = txtcambio2.Text.Trim()

        If nueva = "" Or confirma = "" Then
            MsgBox("Por favor, ingrese y confirme la nueva contraseña.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If nueva <> confirma Then
            MsgBox("Las contraseñas no coinciden.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Try
            'Usa el ID del usuario correcto
            SQL = "UPDATE tb_usuarios SET contraseña='" & nueva & "' WHERE id_usuario=" & codusuario
            basexd.ejecutar(SQL)
            MsgBox("Contraseña actualizada correctamente.", MsgBoxStyle.Information)
            Me.Close()
        Catch ex As Exception
            MsgBox("Error al actualizar la contraseña: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Class
