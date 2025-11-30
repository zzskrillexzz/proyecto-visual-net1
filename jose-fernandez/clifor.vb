Imports System.Data.Odbc
Imports System.Data
Imports System.Linq

Public Class clifor
    Private conexion As OdbcConnection
    Dim c_Varias As New Varias
    Public FocusFactura As Integer = 0
    Public FormFactura As factura

    ' --- INSERTAR CLIENTE ---
    Private Sub bntenviar_Click_1(sender As Object, e As EventArgs) Handles bntenviar.Click
        Try
            'Validar campos vacíos
            Dim camposObligatorios = New TextBox() {Textbuscador, UsernameTextBox, apelli, correo}
            If camposObligatorios.Any(Function(c) String.IsNullOrWhiteSpace(c.Text)) Then
                MessageBox.Show("Todos los campos, incluyendo el ID, son obligatorios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            ' Validar correo
            If Not CorreoValido(correo) Then
                MessageBox.Show("El correo ingresado no es válido.", "Error de correo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                correo.Focus()
                Exit Sub
            End If

            ' Validar combos
            If cmbDepartamentos.SelectedValue Is Nothing OrElse cmbMunicipios.SelectedValue Is Nothing Then
                MessageBox.Show("Debe seleccionar un departamento y municipio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            'Validar ID
            Dim idManual As Integer
            If Not Integer.TryParse(Textbuscador.Text.Trim, idManual) Then
                MessageBox.Show("El ID debe ser un número válido.", "Error de ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            'Verificar si el ID ya existe
            Dim checkSQL As String = "SELECT COUNT(*) FROM tb_clientes WHERE id_cliente = " & idManual
            Dim cmdCheck As New OdbcCommand(checkSQL, conexion)
            Dim existe As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())

            If existe > 0 Then
                MessageBox.Show("El ID " & idManual & " ya existe. Usa otro o busca el cliente.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Preparar SQL de inserción
            Dim sql As String =
            "INSERT INTO tb_clientes (id_cliente, nombre, apellido, correo, id_estado, rol, id_departamento, id_municipio, observacion) " &
            "VALUES (" & idManual & ", '" & UsernameTextBox.Text.Trim() & "', '" & apelli.Text.Trim() & "', '" & correo.Text.Trim() & "', 1, 'cliente', " &
            cmbDepartamentos.SelectedValue & ", " & cmbMunicipios.SelectedValue & ", '" & txtobservaciones.Text.Trim() & "')"

            ' Ejecutar inserción
            If basexd.ingresar_registros(sql) Then
                MessageBox.Show("Cliente registrado correctamente con ID: " & idManual, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Si vino desde factura
                If FocusFactura = 1 AndAlso FormFactura IsNot Nothing Then
                    FormFactura.txtIdCliented.Text = idManual.ToString()
                    SendKeys.Send("{ENTER}")
                    Me.Close()
                    Exit Sub
                End If
                LimpiarCampos(True)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al registrar cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- ACTUALIZAR CLIENTE ---
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles txtactuali.Click
        If String.IsNullOrEmpty(Textbuscador.Text.Trim()) Then
            MessageBox.Show("Por favor, busca un cliente primero o ingresa su ID para actualizarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        ' Validar correo
        If Not CorreoValido(correo) Then
            MessageBox.Show("El correo ingresado no es válido.", "Error de correo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            correo.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(UsernameTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(apelli.Text) OrElse
           String.IsNullOrWhiteSpace(correo.Text) Then
            MessageBox.Show("Nombre, Apellido y Correo son obligatorios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim sql As String =
"UPDATE tb_clientes SET " &
"nombre='" & UsernameTextBox.Text.Trim() & "', " &
"apellido='" & apelli.Text.Trim() & "', " &
"correo='" & correo.Text.Trim() & "', " &
"id_departamento=" & cmbDepartamentos.SelectedValue & ", " &
"id_municipio=" & cmbMunicipios.SelectedValue & ", " &
"observacion='" & txtobservaciones.Text.Trim() & "' " &
"WHERE id_cliente=" & Textbuscador.Text.Trim()

            Dim cmd As New OdbcCommand(sql, conexion)
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Cliente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No se pudo actualizar.no hubo ningun cambio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al actualizar cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- ELIMINAR CLIENTE ---
    Private Sub txteliminar_Click_1(sender As Object, e As EventArgs) Handles txteliminar.Click
        Dim idCliente As String = Textbuscador.Text.Trim()
        If String.IsNullOrEmpty(idCliente) Then
            MessageBox.Show("Por favor, ingresa el ID del cliente que deseas eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim respuesta As DialogResult = MessageBox.Show("¿Seguro que deseas marcar como inactivo al cliente con ID " & idCliente & "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If respuesta = DialogResult.Yes Then
            Try
                Dim sql As String = "UPDATE tb_clientes SET id_estado = 2, observacion = 'Este cliente está bloqueado' WHERE id_cliente = " & idCliente
                Dim cmd As New OdbcCommand(sql, conexion)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Cliente marcado como inactivo correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    BuscarCliente() ' Refrescar datos del cliente
                Else
                    MessageBox.Show("No se pudo actualizar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            Catch ex As Exception
                MessageBox.Show("Error al actualizar cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' BUSCAR CLIENTE
    Private Sub BuscarCliente()
        ' Validar ID numérico
        Dim idCliente As Integer
        If Not Integer.TryParse(Textbuscador.Text.Trim, idCliente) Then
            MessageBox.Show("El ID debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Textbuscador.Clear()
            Textbuscador.Focus()
            Exit Sub
        End If

        Try
            Dim sql As String = "SELECT nombre, apellido, correo, id_departamento, id_municipio, observacion, id_estado FROM tb_clientes WHERE id_cliente = " & idCliente
            Dim cmd As New OdbcCommand(sql, conexion)
            Dim reader As OdbcDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                ' Cliente existe → cargar datos
                UsernameTextBox.Text = If(IsDBNull(reader("nombre")), "", reader("nombre").ToString())
                apelli.Text = If(IsDBNull(reader("apellido")), "", reader("apellido").ToString())
                correo.Text = If(IsDBNull(reader("correo")), "", reader("correo").ToString())
                txtobservaciones.Text = If(IsDBNull(reader("observacion")), "", reader("observacion").ToString())

                ' ID bloqueado visual
                Textbuscador.ReadOnly = True
                Textbuscador.BackColor = SystemColors.ControlLight

                ' Cargar combos (si vienen)
                If Not IsDBNull(reader("id_departamento")) Then
                    Dim idDepartamento As Integer = CInt(reader("id_departamento"))
                    cmbDepartamentos.SelectedValue = idDepartamento
                    Dim sqlMunicipios As String = "SELECT id_municipio, nombre_municipio FROM municipios WHERE id_departamento = " & idDepartamento
                    c_Varias.llena_combo(cmbMunicipios, sqlMunicipios, "id_municipio", "nombre_municipio")
                Else
                    cmbDepartamentos.SelectedIndex = -1
                    cmbMunicipios.DataSource = Nothing
                End If

                If Not IsDBNull(reader("id_municipio")) Then
                    cmbMunicipios.SelectedValue = reader("id_municipio")
                End If

                ' Por defecto: cuando existe, no permitir agregar
                bntenviar.Enabled = False

                ' Verificar estado
                Dim estado As Integer = If(IsDBNull(reader("id_estado")), 1, CInt(reader("id_estado")))

                If estado = 2 Then
                    ' BLOQUEADO -> no editar, no eliminar, no agregar
                    HabilitarCampos(False)
                    bntenviar.Enabled = False
                    txtactuali.Enabled = False
                    txteliminar.Enabled = False
                    btndesbloquearcli.Visible = True
                    btndesbloquearcli.Enabled = True

                    MessageBox.Show("Este cliente está BLOQUEADO y no se puede modificar hasta ser desbloqueado.", "Cliente bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    ' ACTIVO -> permitir editar y eliminar (agregar sigue bloqueado porque ya existe)
                    HabilitarCampos(True)
                    txtactuali.Enabled = True
                    txteliminar.Enabled = True
                    bntenviar.Enabled = False
                    btndesbloquearcli.Visible = False
                End If

            Else
                ' Cliente no existe → nuevo registro
                LimpiarCampos(False)
                MessageBox.Show("Cliente no existe. Puede registrarlo.", "Nuevo Cliente")

                ' Permitir agregar (nuevo)
                HabilitarCampos(True)
                bntenviar.Enabled = True
                txtactuali.Enabled = False
                txteliminar.Enabled = False
                btndesbloquearcli.Visible = False
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al buscar cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- HABILITAR / DESHABILITAR CAMPOS ---
    Private Sub HabilitarCampos(habilitar As Boolean)
        UsernameTextBox.ReadOnly = Not habilitar
        apelli.ReadOnly = Not habilitar
        correo.ReadOnly = Not habilitar
        txtobservaciones.ReadOnly = Not habilitar

        cmbDepartamentos.Enabled = habilitar
        cmbMunicipios.Enabled = habilitar

        ' cuando llamas HabilitarCampos(true) para registro/edición, ID debe seguir bloqueado si ya existe.
        ' Textbuscador se controla en BuscarCliente/LimpiarCampos.
    End Sub

    ' --- EVENTO ENTER EN TEXTBUSCADOR ---
    Private Sub Textbuscador_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Textbuscador.KeyPress
        ' Validar números (usa tu función existente)
        SoloNumeros(e)
        If e.Handled Then Exit Sub

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            BuscarCliente()
        End If
    End Sub

    'CANCELAR / CERRAR
    Private Sub bntcancelar_Click(sender As Object, e As EventArgs)
        Close()
    End Sub


    ' --- 1 ---
    Private Sub btnConsulta_Click_1(sender As Object, e As EventArgs) Handles btnConsulta.Click
        Dim frmCons As New FrmConsulta()
        frmCons.TipoCarga = "CLIENTE"
        If frmCons.ShowDialog() = DialogResult.OK Then
            Dim selectedID As String = frmCons.SelectedID
            If Not String.IsNullOrEmpty(selectedID) Then
                Textbuscador.Text = selectedID
                BuscarCliente()
            End If
        End If
        frmCons.Dispose()
    End Sub

    'LOAD
    Private Sub clifor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Asegurar conexión (usa tu módulo basexd)
        basexd.conectar("root", "")
        conexion = basexd.conexion

        ' ID editable al inicio
        Textbuscador.ReadOnly = False
        Textbuscador.BackColor = Color.White
        Textbuscador.Focus()

        ' Bloquear los demás campos inicialmente
        UsernameTextBox.ReadOnly = True
        apelli.ReadOnly = True
        correo.ReadOnly = True
        txtobservaciones.ReadOnly = True
        cmbDepartamentos.Enabled = False
        cmbMunicipios.Enabled = False

        bntenviar.Enabled = False
        txtactuali.Enabled = False
        txteliminar.Enabled = False

        btndesbloquearcli.Visible = False

        ' Cargar combos
        c_Varias.llena_combo(cmbDepartamentos, "SELECT id_departamento, nombre_departamento FROM departamentos ORDER BY nombre_departamento", "id_departamento", "nombre_departamento")
        cmbDepartamentos.SelectedIndex = -1
        cmbMunicipios.SelectedIndex = -1

        ' Asignar comportamiento EnterAvanzaOBusca si lo usas en tu proyecto (no sobrescribe handlers existentes)
        AddHandler UsernameTextBox.KeyPress, Sub(s, ev) EnterAvanzaOBusca(UsernameTextBox, ev, apelli)
        AddHandler apelli.KeyPress, Sub(s, ev) EnterAvanzaOBusca(apelli, ev, correo)
        AddHandler correo.KeyPress, Sub(s, ev)
                                        If ev.KeyChar = ChrW(Keys.Enter) Then
                                            ev.Handled = True
                                            cmbDepartamentos.Focus()
                                        End If
                                    End Sub
        AddHandler cmbDepartamentos.KeyPress, Sub(s, ev) EnterAvanzaOBusca(cmbDepartamentos, ev, cmbMunicipios)
        AddHandler cmbMunicipios.KeyPress, Sub(s, ev) EnterAvanzaOBusca(cmbMunicipios, ev, txtobservaciones)
        AddHandler txtobservaciones.KeyPress, Sub(s, ev)
                                                  If ev.KeyChar = ChrW(Keys.Enter) Then
                                                      ev.Handled = True
                                                      If Not CorreoValido(correo) Then
                                                          correo.Focus()
                                                          Return
                                                      End If
                                                      bntenviar.PerformClick()
                                                  End If
                                              End Sub
    End Sub

    'CARGAR MUNICIPIOS SEGÚN DEPARTAMENTO
    Private Sub cmbDepartamentos_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbDepartamentos.SelectionChangeCommitted
        CargarMunicipios()
    End Sub

    Private Sub cmbDepartamentos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartamentos.SelectedIndexChanged
        If cmbDepartamentos.Focused OrElse cmbDepartamentos.DroppedDown Then
            CargarMunicipios()
        End If
    End Sub

    Private Sub CargarMunicipios()
        Try
            If cmbDepartamentos.SelectedValue IsNot Nothing AndAlso IsNumeric(cmbDepartamentos.SelectedValue) Then
                Dim idDepartamento As Integer = CInt(cmbDepartamentos.SelectedValue)
                Dim sqlMunicipios As String = "SELECT id_municipio, nombre_municipio FROM municipios WHERE id_departamento = " & idDepartamento & " ORDER BY nombre_municipio"
                c_Varias.llena_combo(cmbMunicipios, sqlMunicipios, "id_municipio", "nombre_municipio")
            Else
                cmbMunicipios.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar municipios: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bntlimpiar_Click(sender As Object, e As EventArgs) Handles bntlimpiar.Click
        ' Limpiar todos los controles del formulario
        Mprincipal_p.LimpiarFormulario(Me)

        ' ID activo y editable
        Textbuscador.ReadOnly = False
        Textbuscador.BackColor = Color.White
        Textbuscador.Enabled = True
        Textbuscador.Focus()

        ' Bloquear los demás campos
        UsernameTextBox.ReadOnly = True
        apelli.ReadOnly = True
        correo.ReadOnly = True
        txtobservaciones.ReadOnly = True
        cmbDepartamentos.Enabled = False
        cmbMunicipios.Enabled = False
        bntenviar.Enabled = False
        txtactuali.Enabled = False
        txteliminar.Enabled = False

        ' Resetear combos
        cmbDepartamentos.SelectedIndex = -1
        cmbMunicipios.SelectedIndex = -1

        btndesbloquearcli.Visible = False
        btndesbloquearcli.Enabled = False
    End Sub

    Private Sub bntvolver_Click(sender As Object, e As EventArgs) Handles bntvolver.Click
        Me.Close()
    End Sub

    Private Sub UsernameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UsernameTextBox.KeyPress
        EnterAvanzaOBusca(UsernameTextBox, e, apelli)
    End Sub
    Private Sub apelli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles apelli.KeyPress
        EnterAvanzaOBusca(apelli, e, correo)
    End Sub

    Private Sub cmbDepartamentos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbDepartamentos.KeyPress
        EnterAvanzaOBusca(cmbDepartamentos, e, cmbMunicipios)
    End Sub
    Private Sub cmbMunicipios_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbMunicipios.KeyPress
        EnterAvanzaOBusca(cmbMunicipios, e, txtobservaciones)
    End Sub

    Private Sub txtobservaciones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtobservaciones.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If Not CorreoValido(correo) Then
                correo.Focus()
                Return
            End If
            bntenviar.PerformClick()
        End If
    End Sub

    ' --- LIMPIAR CAMPOS ---
    Private Sub LimpiarCampos(Optional ByVal limpiarBuscador As Boolean = True)
        ' Limpiar campos
        UsernameTextBox.Clear()
        apelli.Clear()
        correo.Clear()
        txtobservaciones.Clear()

        ' Resetear combos
        cmbDepartamentos.SelectedIndex = -1
        cmbMunicipios.SelectedIndex = -1

        ' ID editable
        If limpiarBuscador Then
            Textbuscador.Clear()
            Textbuscador.ReadOnly = False
            Textbuscador.BackColor = Color.White
            Textbuscador.Focus()
        End If

        ' Bloquear los demás campos
        UsernameTextBox.ReadOnly = True
        apelli.ReadOnly = True
        correo.ReadOnly = True
        txtobservaciones.ReadOnly = True
        cmbDepartamentos.Enabled = False
        cmbMunicipios.Enabled = False

        ' Botones
        bntenviar.Enabled = False
        txtactuali.Enabled = False
        txteliminar.Enabled = False

        btndesbloquearcli.Visible = False
    End Sub

    Private Sub btndesbloquearcli_Click(sender As Object, e As EventArgs) Handles btndesbloquearcli.Click
        Dim idCliente As Integer
        If Not Integer.TryParse(Textbuscador.Text.Trim, idCliente) Then Exit Sub

        Try
            Dim sql As String = "UPDATE tb_clientes SET id_estado = 1, observacion = '' WHERE id_cliente = " & idCliente
            Dim cmd As New OdbcCommand(sql, conexion)

            If cmd.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Cliente desbloqueado correctamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BuscarCliente()
            Else
                MessageBox.Show("No se pudo desbloquear.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al desbloquear cliente: " & ex.Message)
        End Try
    End Sub

End Class
