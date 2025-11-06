Imports System.Data.Odbc
Imports System.Data
Imports System.Linq

Public Class forregistro
    Private conexion As OdbcConnection
    Dim c_Varias As New Varias

    ' --- INSERTAR USUARIO ---
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntenviar.Click
        Try
            Dim camposObligatorios = New TextBox() {Textbuscador, UsernameTextBox, apelli, contra, correo}

            If camposObligatorios.Any(Function(c) String.IsNullOrWhiteSpace(c.Text)) Then
                MessageBox.Show("Todos los campos, incluyendo el ID, son obligatorios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If Comborol.SelectedIndex = -1 OrElse cmbDepartamentos.SelectedValue Is Nothing OrElse cmbMunicipios.SelectedValue Is Nothing Then
                MessageBox.Show("Debe seleccionar un rol, departamento y municipio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim idManual As Integer
            If Not Integer.TryParse(Textbuscador.Text.Trim, idManual) Then
                MessageBox.Show("El ID debe ser un número válido.", "Error de ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim sql As String =
                "INSERT INTO tb_usuarios (id_usuario, nombre, apellido, contraseña, correo, id_estado, rol, id_departamento, id_municipio, observacion) " &
                "VALUES (" & idManual & ", '" & UsernameTextBox.Text.Trim() & "', '" & apelli.Text.Trim() & "', '" & contra.Text.Trim() &
                "', '" & correo.Text.Trim() & "', 1, '" & Comborol.Text & "', " &
                cmbDepartamentos.SelectedValue & ", " & cmbMunicipios.SelectedValue & ", '" & txtobservaciones.Text.Trim() & "')"

            Dim cmd As New OdbcCommand(sql, conexion)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Usuario registrado correctamente con ID: " & idManual, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarCampos(True)

        Catch ex As Exception
            MessageBox.Show("Error al registrar usuario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- ACTUALIZAR USUARIO ---
    Private Sub txtactuali_Click(sender As Object, e As EventArgs) Handles txtactuali.Click
        If String.IsNullOrEmpty(Textbuscador.Text.Trim()) Then
            MessageBox.Show("Por favor, busca un usuario primero o ingresa su ID para actualizarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                "UPDATE tb_usuarios SET nombre='" & UsernameTextBox.Text.Trim() &
                "', apellido='" & apelli.Text.Trim() &
                "', correo='" & correo.Text.Trim() &
                "', rol='" & Comborol.Text & "'" &
                ", id_departamento=" & cmbDepartamentos.SelectedValue &
                ", id_municipio=" & cmbMunicipios.SelectedValue &
                ", id_estado=" & Comboestado.SelectedValue &
                ", observacion='" & txtobservaciones.Text.Trim() &
                "' WHERE id_usuario=" & Textbuscador.Text.Trim()

            Dim cmd As New OdbcCommand(sql, conexion)
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No se pudo actualizar el usuario. El ID no fue encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al actualizar usuario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- ELIMINAR USUARIO ---
    Private Sub txteliminar_Click(sender As Object, e As EventArgs) Handles txteliminar.Click
        Dim idUsuario As String = Textbuscador.Text.Trim()
        If String.IsNullOrEmpty(idUsuario) Then
            MessageBox.Show("Por favor, ingresa el ID del usuario que deseas eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim respuesta As DialogResult = MessageBox.Show("¿Seguro que deseas eliminar el usuario con ID " & idUsuario & "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If respuesta = DialogResult.Yes Then
            Try
                Dim sql As String = "DELETE FROM tb_usuarios WHERE id_usuario = " & idUsuario
                Dim cmd As New OdbcCommand(sql, conexion)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarCampos(True)
            Catch ex As Exception
                MessageBox.Show("Error al eliminar usuario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' --- BUSCAR USUARIO ---
    Private Sub BuscarUsuario()
        Dim idUsuario As String = Textbuscador.Text.Trim()
        If idUsuario = "" Then
            MessageBox.Show("Por favor ingresa un ID de usuario.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            LimpiarCampos(False)
            Exit Sub
        End If

        Try
            Dim sql As String = "SELECT nombre, apellido, correo, id_estado, rol, id_departamento, id_municipio, observacion FROM tb_usuarios WHERE id_usuario = " & idUsuario
            Dim cmd As New OdbcCommand(sql, conexion)
            Dim reader As OdbcDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                UsernameTextBox.Text = reader("nombre")
                apelli.Text = reader("apellido")
                correo.Text = reader("correo")
                txtobservaciones.Text = reader("observacion")
                Comboestado.SelectedValue = CInt(reader("id_estado"))

                ' Asignar el rol textual
                If Not IsDBNull(reader("rol")) Then
                    Comborol.Text = reader("rol").ToString()
                End If

                cmbDepartamentos.SelectedValue = reader("id_departamento")
                Dim idDepartamento As Integer = CInt(cmbDepartamentos.SelectedValue)
                Dim sqlMunicipios As String = "SELECT id_municipio, nombre_municipio FROM municipios WHERE id_departamento = " & idDepartamento
                c_Varias.llena_combo(cmbMunicipios, sqlMunicipios, "id_municipio", "nombre_municipio")
                cmbMunicipios.SelectedValue = reader("id_municipio")

                HabilitarCampos(True)
            Else
                MessageBox.Show("ID libre. Ingrese los datos para registrar un nuevo usuario con ID: " & idUsuario, "Nuevo Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarCampos(False)
                HabilitarCampos(True)
            End If
            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error al buscar usuario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        Comborol.Enabled = habilitar
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

        Comborol.SelectedIndex = -1
        Comboestado.SelectedIndex = -1
        cmbDepartamentos.SelectedIndex = -1
        cmbMunicipios.SelectedIndex = -1
        txtobservaciones.Clear()

        HabilitarCampos(True)
    End Sub

    ' --- EVENTO ENTER PARA BUSCAR ---
    Private Sub Textbuscador_KeyDown(sender As Object, e As KeyEventArgs) Handles Textbuscador.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            BuscarUsuario()
            UsernameTextBox.Focus()
        End If
    End Sub

    ' --- CANCELAR ---
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles bntcancelar.Click
        Me.Close()
    End Sub

    ' --- CONSULTA ---
    Private Sub btnConsulta_Click(sender As Object, e As EventArgs) Handles btnConsulta.Click
        Dim frmCons As New FrmConsulta()
        frmCons.TipoCarga = "USUARIO"

        If frmCons.ShowDialog() = DialogResult.OK Then
            Dim selectedID As String = frmCons.SelectedID
            If Not String.IsNullOrEmpty(selectedID) Then
                Textbuscador.Text = selectedID
                BuscarUsuario()
            End If
        End If
        frmCons.Dispose()
    End Sub

    ' --- LOAD DEL FORMULARIO ---
    Private Sub forregistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        basexd.conectar("root", "")
        conexion = basexd.conexion
        Textbuscador.AcceptsReturn = True
        Me.AcceptButton = Nothing

        ' Rellenar roles directamente
        Comborol.Items.Clear()
        Comborol.Items.AddRange(New String() {"admin", "usuario", "invitado"})

        ' Estados desde la BD
        Dim sqlEstado As String = "SELECT id_estado, estado FROM tb_estado ORDER BY id_estado"
        c_Varias.llena_combo(Comboestado, sqlEstado, "id_estado", "estado")

        ' Departamentos
        Dim sqlDepartamentos As String = "SELECT id_departamento, nombre_departamento FROM departamentos ORDER BY nombre_departamento"
        c_Varias.llena_combo(cmbDepartamentos, sqlDepartamentos, "id_departamento", "nombre_departamento")

        LimpiarCampos(True)
    End Sub

    Private Sub cmbDepartamentos_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbDepartamentos.SelectionChangeCommitted
        If cmbDepartamentos.SelectedValue IsNot Nothing Then
            Dim idDepartamento As Integer = CInt(cmbDepartamentos.SelectedValue)
            Dim sqlMunicipios As String = "SELECT id_municipio, nombre_municipio FROM municipios WHERE id_departamento = " & idDepartamento
            c_Varias.llena_combo(cmbMunicipios, sqlMunicipios, "id_municipio", "nombre_municipio")
        End If
    End Sub

    Private Sub Ptbvolver_Click(sender As Object, e As EventArgs) Handles Ptbvolver.Click
        Dim frmSeleccion As New usu_clien()
        frmSeleccion.Show()
        Me.Close()
    End Sub

    Private Sub bntnewcontra_Click(sender As Object, e As EventArgs) Handles bntnewcontra.Click
        'Abre el login solo para validar credenciales
        Dim login As New LoginForm1()
        esCambioContra = True '👉 indicamos que este login es para cambio de contraseña
        login.ShowDialog()
    End Sub

End Class
