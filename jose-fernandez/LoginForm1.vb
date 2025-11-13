Imports System.Data.Odbc

Public Class LoginForm1
    Dim SQL As String
    Dim rst As OdbcDataReader

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        ' Validar usuario y contraseña
        SQL = "SELECT * FROM tb_usuarios WHERE id_usuario=" & UsernameTextBox.Text & " AND contraseña='" & PasswordTextBox.Text & "'"
        rst = basexd.leer_Registro(SQL)

        If rst IsNot Nothing AndAlso rst.Read() Then
            ' ? Guardar el ID real del usuario (no el nombre)
            codusuario = rst("id_usuario").ToString()

            ' Si se está accediendo desde "Cambio de contraseña"
            If esCambioContra Then
                Dim cambio As New formcontra()
                cambio.ShowDialog()
                esCambioContra = False
                Me.Close()
                Exit Sub
            End If

            ' Si es un login normal, abrir menú principal
            Dim menuPrincipal As New usu_clien()
            menuPrincipal.Show()
            Me.Hide()
        Else
            MsgBox("Usuario o contraseña incorrectos.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        basexd.conectar("root", "")
    End Sub
End Class
