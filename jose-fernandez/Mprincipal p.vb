Imports System.Data.Odbc

Module Mprincipal_p
    Public SQL As String
    Public rst As Odbc.OdbcDataReader
    Public codusuario As String
    Public sw_Regreso As Integer = 0
    Public vec() As String
    Public esCambioContra As Boolean = False
    Public UsuarioActual As String = ""
    Public idUsuarioACambiar As Integer

    ' Conexión global
    Public conexion As OdbcConnection

    ' VALIDACIONES

    'SOLO NÚMEROS
    Public Sub SoloNumeros(e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Solo se aceptan caracteres numéricos.",
                            "Entrada no válida",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
        End If
    End Sub


    'VALIDAR CORREO AL SALIR
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


    'COLOR DE CORREO MIENTRAS ESCRIBE
    Public Sub ColorCorreo(caja As TextBox)
        If caja.Text.Length > 0 AndAlso Not caja.Text.Contains("@") Then
            caja.BackColor = Color.LightCoral
        Else
            caja.BackColor = Color.White
        End If
    End Sub

    ' VALIDACIÓN DE CONTRASEÑA

    'OBTENER CONTRASEÑA ACTUAL
    Public Function ObtenerContraActual(idUsuario As String) As String
        Try
            Dim sql As String = "SELECT contraseña FROM tb_usuarios WHERE id_usuario = '" & idUsuario & "'"
            Dim cmd As New OdbcCommand(sql, conexion)
            Dim reader As OdbcDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim contra As String = reader("contraseña").ToString()
                reader.Close()
                Return contra
            End If

            reader.Close()
            Return ""

        Catch ex As Exception
            MessageBox.Show("Error al obtener la contraseña actual: " & ex.Message)
            Return ""
        End Try
    End Function


    'VER SI LA CONTRASEÑA NUEVA ES IGUAL A LA ANTERIOR
    Public Function EsContraRepetida(contraNueva As String, idUsuario As String) As Boolean
        Dim contraActual As String = ObtenerContraActual(idUsuario)
        Return contraNueva.Trim() = contraActual.Trim()
    End Function

    Public Sub LimpiarFormulario(frm As Form)

        For Each ctrl As Control In frm.Controls
            LimpiarControl(ctrl)
        Next

    End Sub


    ' Función recursiva que limpia paneles, groupbox, etc.
    Private Sub LimpiarControl(ctrl As Control)

        If TypeOf ctrl Is TextBox Then
            CType(ctrl, TextBox).Clear()

        ElseIf TypeOf ctrl Is ComboBox Then
            CType(ctrl, ComboBox).SelectedIndex = -1

        ElseIf TypeOf ctrl Is RichTextBox Then
            CType(ctrl, RichTextBox).Clear()

        ElseIf ctrl.HasChildren Then
            For Each hijo As Control In ctrl.Controls
                LimpiarControl(hijo)
            Next
        End If

    End Sub

End Module
