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

    Public Function CorreoValido(caja As TextBox) As Boolean
        Dim regex As New System.Text.RegularExpressions.Regex("^[\w\-\.]+@([\w\-]+\.)+[\w\-]{2,4}$")

        If Not regex.IsMatch(caja.Text.Trim()) Then
            MessageBox.Show("Correo inválido. Debe contener un formato válido como ejemplo@correo.com",
                        "Correo incorrecto",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
            caja.Focus()
            Return False
        End If

        Return True
    End Function





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


    ' Función  que limpia paneles, groupbox, etc.
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
    'Función para Enter: busca o avanza
    Public Sub EnterAvanzaOBusca(ctrlActual As Control,
                             e As KeyPressEventArgs,
                             ctrlSiguiente As Object,
                             Optional accionBusqueda As Action = Nothing)

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True

            ' Ejecutar acción de búsqueda si la hay
            accionBusqueda?.Invoke()

            ' Avanzar o hacer click según tipo
            If TypeOf ctrlSiguiente Is Control Then
                CType(ctrlSiguiente, Control).Focus()
            ElseIf TypeOf ctrlSiguiente Is ToolStripButton Then
                CType(ctrlSiguiente, ToolStripButton).PerformClick()
            End If
        End If
    End Sub




End Module
