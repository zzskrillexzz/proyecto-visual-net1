Imports System.Data.Odbc

Public Class LoginForm1
    Dim SQL As String
    Dim rst As OdbcDataReader

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        ' Validación básica (igual que tenías)
        SQL = "SELECT * FROM tb_usuarios WHERE id_usuario=" & UsernameTextBox.Text & " AND contraseña='" & PasswordTextBox.Text & "'"
        rst = basexd.leer_Registro(SQL)

        If rst IsNot Nothing AndAlso rst.Read() Then
            ' Guardar el ID del usuario que se acaba de loguear (si lo necesitas en otras partes)
            codusuario = rst("id_usuario").ToString()

            If esCambioContra Then
                ' Pasamos explícitamente el idUsuarioACambiar al formulario de cambio
                Dim idTarget As Integer = idUsuarioACambiar ' viene de forregistro antes de abrir el login

                ' Si por alguna razón no hay id target válido, prevenir
                If idTarget <= 0 Then
                    MessageBox.Show("No se definió correctamente el ID del usuario a cambiar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    esCambioContra = False
                    Me.Close()
                    Exit Sub
                End If

                Dim cambio As New formcontra(idTarget) ' <-- usamos constructor con parámetro
                esCambioContra = False
                cambio.ShowDialog()
                Me.Close()
                Exit Sub
            End If

            ' Flujo normal de login
            Dim menuPrincipal As New usu_clien()
            menuPrincipal.Show()
            Me.Hide()
        Else
            MsgBox("Usuario o contraseña incorrectos.", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        basexd.conectar("root", "")
    End Sub
End Class
