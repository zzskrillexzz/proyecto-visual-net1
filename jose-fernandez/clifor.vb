Imports System.Data.Odbc
Imports System.Data
Imports System.Linq

Public Class clifor
    Private conexion As OdbcConnection
    Dim c_Varias As New Varias
    Public FocusFactura As Integer = 0
    Public FormFactura As factura

    ' --- INSERTAR CLIENTE ---
    Private Sub bntenviar_Click(sender As Object, e As EventArgs) Handles bntenviar.Click
        Try
            'Validar campos vacíos
            Dim camposObligatorios = New TextBox() {Textbuscador, UsernameTextBox, apelli, contra, correo}
            If camposObligatorios.Any(Function(c) String.IsNullOrWhiteSpace(c.Text)) Then
                MessageBox.Show("Todos los campos, incluyendo el ID, son obligatorios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
            "INSERT INTO tb_clientes (id_cliente, nombre, apellido, correo, contraseña, id_estado, rol, id_departamento, id_municipio, observacion) " &
            "VALUES (" & idManual & ", '" & UsernameTextBox.Text.Trim() & "', '" & apelli.Text.Trim() & "', '" & correo.Text.Trim() & "', '" & contra.Text.Trim() & "', 1, 'cliente', " &
            cmbDepartamentos.SelectedValue & ", " & cmbMunicipios.SelectedValue & ", '" & txtobservaciones.Text.Trim() & "')"

            ' Ejecutar inserción
            If basexd.ingresar_registros(sql) Then
                MessageBox.Show("Cliente registrado correctamente con ID: " & idManual, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Si vino desde factura
                If FocusFactura = 1 AndAlso FormFactura IsNot Nothing Then
                    FormFactura.txtIdCliente.Text = idManual.ToString()
                    SendKeys.Send("{ENTER}")
                    Me.Close()
                    Exit Sub
                End If

                ' Limpiar formulario
                LimpiarCampos(True)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al registrar cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- ACTUALIZAR CLIENTE ---
    Private Sub txtactuali_Click_1(sender As Object, e As EventArgs) Handles txtactuali.Click
        If String.IsNullOrEmpty(Textbuscador.Text.Trim()) Then
            MessageBox.Show("Por favor, busca un cliente primero o ingresa su ID para actualizarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                "UPDATE tb_clientes SET nombre='" & UsernameTextBox.Text.Trim() &
                "', apellido='" & apelli.Text.Trim() &
                "', correo='" & correo.Text.Trim() &
                "', id_departamento=" & cmbDepartamentos.SelectedValue &
                ", id_municipio=" & cmbMunicipios.SelectedValue &
                ", id_estado=" & Comboestado.SelectedValue &
                ", observacion='" & txtobservaciones.Text.Trim() &
                "' WHERE id_cliente=" & Textbuscador.Text.Trim()

            Dim cmd As New OdbcCommand(sql, conexion)
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Cliente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No se pudo actualizar el cliente. El ID no fue encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

        Dim respuesta As DialogResult = MessageBox.Show("¿Seguro que deseas eliminar el cliente con ID " & idCliente & "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If respuesta = DialogResult.Yes Then
            Try
                Dim sql As String = "DELETE FROM tb_clientes WHERE id_cliente = " & idCliente
                Dim cmd As New OdbcCommand(sql, conexion)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarCampos(True)
            Catch ex As Exception
                MessageBox.Show("Error al eliminar cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' --- BUSCAR CLIENTE ---
    Private Sub BuscarCliente()
        Dim idCliente As String = Textbuscador.Text.Trim()
        If idCliente = "" Then
            MessageBox.Show("Por favor ingresa un ID de cliente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            LimpiarCampos(False)
            Exit Sub
        End If

        HabilitarCampos(True)

        Try
            Dim sql As String = "SELECT nombre, apellido, correo, id_estado, id_departamento, id_municipio, observacion FROM tb_clientes WHERE id_cliente = " & idCliente
            Dim cmd As New OdbcCommand(sql, conexion)
            Dim reader As OdbcDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                UsernameTextBox.Text = reader("nombre")
                apelli.Text = reader("apellido")
                correo.Text = reader("correo")
                txtobservaciones.Text = reader("observacion")

                ' Cargar departamento y municipio del cliente
                Dim idDepartamento As Integer = CInt(reader("id_departamento"))
                Dim idMunicipio As Integer = CInt(reader("id_municipio"))

                cmbDepartamentos.SelectedValue = idDepartamento

                ' 🔹 Llenar municipios después de asignar el departamento
                Dim sqlMunicipios As String = "SELECT id_municipio, nombre_municipio FROM municipios WHERE id_departamento = " & idDepartamento
                c_Varias.llena_combo(cmbMunicipios, sqlMunicipios, "id_municipio", "nombre_municipio")

                cmbMunicipios.SelectedValue = idMunicipio
                HabilitarCampos(True)
            Else
                MessageBox.Show("ID libre. Ingrese los datos para registrar un nuevo cliente con ID: " & idCliente, "Nuevo Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarCampos(False)
                HabilitarCampos(True)
            End If
            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error al buscar cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            HabilitarCampos(True)
        End Try
    End Sub

    ' --- HABILITAR / DESHABILITAR CAMPOS ---
    Private Sub HabilitarCampos(ByVal habilitar As Boolean)
        Textbuscador.ReadOnly = Not habilitar
        UsernameTextBox.ReadOnly = Not habilitar
        apelli.ReadOnly = Not habilitar
        correo.ReadOnly = Not habilitar
        contra.ReadOnly = True
        cmbDepartamentos.Enabled = habilitar
        cmbMunicipios.Enabled = habilitar
        Comboestado.Enabled = habilitar
        txtobservaciones.ReadOnly = Not habilitar

        Dim modoEdicion As Boolean = Not String.IsNullOrWhiteSpace(UsernameTextBox.Text)
        bntenviar.Enabled = Not modoEdicion
        txtactuali.Enabled = modoEdicion
        txteliminar.Enabled = modoEdicion

        If Not modoEdicion Then
            contra.ReadOnly = Not habilitar
        End If
    End Sub

    ' --- LIMPIAR CAMPOS ---
    Private Sub LimpiarCampos(Optional ByVal limpiarBuscador As Boolean = True)
        UsernameTextBox.Clear()
        apelli.Clear()
        correo.Clear()
        contra.Clear()

        If limpiarBuscador Then Textbuscador.Clear()

        Comboestado.SelectedIndex = -1
        cmbDepartamentos.SelectedIndex = -1
        cmbMunicipios.SelectedIndex = -1
        txtobservaciones.Clear()

        HabilitarCampos(True)
    End Sub

    ' --- EVENTO ENTER EN TEXTBUSCADOR ---
    Private Sub Textbuscador_KeyDown(sender As Object, e As KeyEventArgs) Handles Textbuscador.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            BuscarCliente()
            UsernameTextBox.Focus()
        End If
    End Sub

    'CANCELAR / CERRAR
    Private Sub bntcancelar_Click(sender As Object, e As EventArgs) Handles bntcancelar.Click
        Me.Close()
    End Sub

    ' --- CONSULTA ---
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
        basexd.conectar("root", "")
        conexion = basexd.conexion
        Textbuscador.AcceptsReturn = True
        Me.AcceptButton = Nothing

        ' Cargar combos antes de cualquier otra cosa ---
        Dim sqlEstado As String = "SELECT id_estado, estado FROM tb_estado ORDER BY id_estado"
        c_Varias.llena_combo(Comboestado, sqlEstado, "id_estado", "estado")

        Dim sqlDepartamentos As String = "SELECT id_departamento, nombre_departamento FROM departamentos ORDER BY nombre_departamento"
        c_Varias.llena_combo(cmbDepartamentos, sqlDepartamentos, "id_departamento", "nombre_departamento")

        ' --- Comportamiento según si viene desde factura ---
        If FocusFactura = 0 Then
            LimpiarCampos(True)
        Else
            'Bloquear controles cuando viene desde factura
            Textbuscador.Enabled = False
            Textbuscador.ReadOnly = True
            Textbuscador.BackColor = SystemColors.ControlLight

            txtactuali.Enabled = False
            btnConsulta.Enabled = False
            txteliminar.Enabled = False

            UsernameTextBox.Focus()
        End If
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

    Private Sub bntvolver_Click_1(sender As Object, e As EventArgs) Handles bntvolver.Click
        Dim frmSeleccion As New usu_clien()
        frmSeleccion.Show()
        Me.Close()
    End Sub

    Private Sub Textbuscador_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Textbuscador.KeyPress
        SoloNumeros(e)
    End Sub


    Private Sub txtCorreo_Leave(sender As Object, e As EventArgs) Handles correo.Leave
        ValidarCorreo(correo)
    End Sub

    Private Sub txtCorreo_TextChanged(sender As Object, e As EventArgs) Handles correo.TextChanged
        ColorCorreo(correo)
    End Sub





End Class
