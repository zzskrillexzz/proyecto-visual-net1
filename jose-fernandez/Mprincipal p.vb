Module Mprincipal_p

    '===========================
    ' VARIABLES GLOBALES QUE YA TENÍAS
    '===========================
    Public SQL As String
    Public rst As Odbc.OdbcDataReader
    Public codusuario As String
    Public sw_Regreso As Integer = 0
    Public vec() As String
    Public esCambioContra As Boolean = False
    Public UsuarioActual As String = ""



    '===========================
    ' VALIDACIONES REUTILIZABLES
    '===========================

    ' 🔹 Permite solo números en un TextBox
    Public Sub SoloNumeros(e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True  ' Bloquea la tecla
            MessageBox.Show("Solo se aceptan caracteres numéricos.",
                            "Entrada no válida",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
        End If
    End Sub


    ' 🔹 Valida el correo cuando el usuario sale del TextBox
    Public Sub ValidarCorreo(caja As TextBox)
        If Not caja.Text.Contains("@") Then
            caja.BackColor = Color.LightCoral
            MessageBox.Show("El correo debe contener '@'.",
                            "Correo no válido",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
        Else
            caja.BackColor = Color.White
        End If
    End Sub


    ' 🔹 Cambia el color mientras escribe
    Public Sub ColorCorreo(caja As TextBox)
        If caja.Text.Length > 0 AndAlso Not caja.Text.Contains("@") Then
            caja.BackColor = Color.LightCoral
        Else
            caja.BackColor = Color.White
        End If
    End Sub

End Module
