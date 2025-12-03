Imports System.Data.Odbc
Imports System.Data
Imports System.Linq

Public Class forregistro
    Private conexion As OdbcConnection
    Dim c_Varias As New Varias

    ' --- INSERTAR USUARIO ---
    Private Sub bntenviar_Click(sender As Object, e As EventArgs) Handles bntenviar.Click
        ' ✅ Normalizar correo antes de validar
        correo.Text = Mprincipal_p.NormalizarCorreo(correo.Text)

        If Not CorreoValido(correo) Then Exit Sub
        ' ...

        If Not CorreoValido(correo) Then Exit Sub
        Try
            Dim camposObligatorios = New TextBox() {Textbuscador, UsernameTextBox, apelli, contra, camCon, correo}

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

            If contra.Text <> camCon.Text Then
                MessageBox.Show("Las contraseñas no coinciden.", "Error de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim sql As String =
                "INSERT INTO tb_usuarios (id_usuario, nombre, nombre2, apellido, apellido2, contraseña, correo, id_estado, rol, id_departamento, id_municipio, observacion) " &
                "VALUES (" & idManual & ", '" & UsernameTextBox.Text.Trim().ToLower() & "','" & UsernameTextBox2.Text.Trim().ToLower() & "', 
                '" & apelli.Text.Trim().ToLower() & "', '" & apelli2.Text.Trim().ToLower() & "', '" & contra.Text.Trim() &
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
    Private Sub txtactuali_Click_1(sender As Object, e As EventArgs) Handles txtactuali.Click
        ' ✅ Normalizar antes de validar/actualizar
        correo.Text = Mprincipal_p.NormalizarCorreo(correo.Text)

        If String.IsNullOrEmpty(Textbuscador.Text.Trim()) Then
            ' ...
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
                "UPDATE tb_usuarios SET 
                nombre='" & UsernameTextBox.Text.Trim().ToLower() &
                "',nombre2 ='" & UsernameTextBox2.Text.Trim().ToLower() &
                "', apellido='" & apelli.Text.Trim().ToLower() &
                "', apellido2='" & apelli2.Text.Trim().ToLower() &
                "', correo='" & correo.Text.Trim() &
                "', rol='" & Comborol.Text & "'" &
                ", id_departamento=" & cmbDepartamentos.SelectedValue &
                ", id_municipio=" & cmbMunicipios.SelectedValue &
                ", observacion='" & txtobservaciones.Text.Trim() &
                "' WHERE id_usuario=" & Textbuscador.Text.Trim()

            Dim cmd As New OdbcCommand(sql, conexion)
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarCampos(True)
            Else
                MessageBox.Show("No se pudo actualizar el usuario. no hubo ningun cambio o usuario bloqueado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al actualizar usuario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- ELIMINAR (BLOQUEAR) USUARIO ---
    Private Sub txteliminar_Click_1(sender As Object, e As EventArgs) Handles txteliminar.Click
        If Textbuscador.Text.Trim() = "" Then
            MessageBox.Show("Ingresa un ID válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim r = MessageBox.Show("¿Seguro que desea BLOQUEAR este usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If r = DialogResult.No Then Exit Sub

        Try
            Dim sql As String = "UPDATE tb_usuarios SET id_estado = 2, observacion = 'Usuario bloqueado' WHERE id_usuario = " & Textbuscador.Text.Trim()
            Dim cmd As New OdbcCommand(sql, conexion)
            Dim rows As Integer = cmd.ExecuteNonQuery()

            If rows > 0 Then
                MessageBox.Show("El usuario fue bloqueado.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'BuscarUsuario()
                LimpiarCampos(True)
            Else
                MessageBox.Show("El usuario no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' --- BUSCAR USUARIO ---
    Private Sub BuscarUsuario()
        Dim idUsuario As Integer
        If Not Integer.TryParse(Textbuscador.Text.Trim, idUsuario) Then
            MessageBox.Show("El ID debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LimpiarCampos(False)
            Textbuscador.Focus()
            Exit Sub
        End If

        Try
            Dim sql As String = "SELECT nombre, nombre2, apellido, apellido2, correo, id_estado, rol, id_departamento, id_municipio, observacion FROM tb_usuarios WHERE id_usuario = " & idUsuario
            Dim cmd As New OdbcCommand(sql, conexion)
            Dim reader As OdbcDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                ' Cargar datos
                UsernameTextBox.Text = reader("nombre")
                UsernameTextBox2.Text = If(IsDBNull(reader("nombre2")), "", reader("nombre2").ToString())
                apelli.Text = reader("apellido")
                apelli2.Text = If(IsDBNull(reader("apellido2")), "", reader("apellido2").ToString())
                correo.Text = reader("correo")
                contra.Text = "******"
                txtobservaciones.Text = reader("observacion")
                Comborol.Text = reader("rol").ToString()

                ' ID bloqueado visual
                Textbuscador.ReadOnly = True
                Textbuscador.BackColor = SystemColors.ControlLight

                ' Cargar combos (departamento -> municipios)
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

                ' Por defecto: habilitar edición (pero lo ajustamos según estado)
                UsernameTextBox.ReadOnly = False
                UsernameTextBox2.ReadOnly = False
                apelli.ReadOnly = False
                apelli2.ReadOnly = False
                correo.ReadOnly = False
                contra.ReadOnly = True ' La contraseña solo cambia con botón
                camCon.ReadOnly = True
                Comborol.Enabled = True
                cmbDepartamentos.Enabled = True
                cmbMunicipios.Enabled = True
                txtobservaciones.ReadOnly = False

                ' Botones por defecto cuando existe registro
                bntenviar.Enabled = False
                txtactuali.Enabled = True
                txteliminar.Enabled = True

                ' Verificar si el usuario está bloqueado con función del módulo
                If Mprincipal_p.UsuarioBloqueado(conexion, idUsuario) Then
                    ' Bloqueado → deshabilitar edición y botones relevantes
                    HabilitarCampos(False)

                    bntenviar.Enabled = False
                    txtactuali.Enabled = False
                    ' permites desbloquear pero no editar
                    bntnewcontra.Enabled = False
                    txteliminar.Enabled = False

                    btndesbloquearusu.Visible = True
                    btndesbloquearusu.Enabled = True

                    MessageBox.Show("Este usuario está BLOQUEADO y no se puede modificar hasta ser desbloqueado.", "Usuario bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    ' Activo → todo habilitado
                    HabilitarCampos(True)
                    btndesbloquearusu.Visible = False
                    bntnewcontra.Enabled = True

                    ' Asegurar botones correctos
                    bntenviar.Enabled = False
                    txtactuali.Enabled = True
                    txteliminar.Enabled = True
                End If

            Else
                ' ID no existe → nuevo registro
                LimpiarCampos(False) ' Solo limpia otros campos (sin tocar el ID)


                UsernameTextBox.ReadOnly = False
                apelli.ReadOnly = False
                UsernameTextBox2.ReadOnly = False
                apelli2.ReadOnly = False
                correo.ReadOnly = False
                contra.ReadOnly = False  ' Permitir escribir contraseña nueva
                camCon.ReadOnly = False  ' Permitir escribir contraseña nueva
                Comborol.Enabled = True
                cmbDepartamentos.Enabled = True
                cmbMunicipios.Enabled = True
                txtobservaciones.ReadOnly = False

                ' Habilitar solo el botón de enviar (registro), no actualizar/eliminar
                bntenviar.Enabled = True
                txtactuali.Enabled = False
                txteliminar.Enabled = False
                bntnewcontra.Enabled = False
                btndesbloquearusu.Visible = False

                'MessageBox.Show("ID libre. Ingrese los datos para registrar un nuevo usuario con ID: " & idUsuario, "Nuevo Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UsernameTextBox.Focus()
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al buscar usuario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- HABILITAR / DESHABILITAR CAMPOS (solo campos) ---
    Private Sub HabilitarCampos(ByVal habilitar As Boolean)
        UsernameTextBox.ReadOnly = Not habilitar
        apelli.ReadOnly = Not habilitar
        UsernameTextBox2.ReadOnly = Not habilitar
        apelli2.ReadOnly = Not habilitar
        correo.ReadOnly = Not habilitar
        contra.ReadOnly = True ' Solo cambia con botón
        camCon.ReadOnly = True ' Solo cambia con botón
        Comborol.Enabled = habilitar
        cmbDepartamentos.Enabled = habilitar
        cmbMunicipios.Enabled = habilitar
        txtobservaciones.ReadOnly = Not habilitar
    End Sub

    ' --- LIMPIAR CAMPOS ---
    Private Sub LimpiarCampos(Optional ByVal limpiarBuscador As Boolean = True)
        UsernameTextBox.Clear()
        apelli.Clear()
        UsernameTextBox2.Clear()
        apelli2.Clear()
        correo.Clear()
        contra.Clear()
        camCon.Clear()
        Comborol.SelectedIndex = -1
        cmbDepartamentos.SelectedIndex = -1
        cmbMunicipios.SelectedIndex = -1
        txtobservaciones.Clear()

        If limpiarBuscador Then
            Textbuscador.Clear()
            Textbuscador.ReadOnly = False
            Textbuscador.BackColor = Color.White
            Textbuscador.Focus()
        End If

        ' Bloquear todos los campos menos ID
        UsernameTextBox.ReadOnly = True
        apelli.ReadOnly = True
        UsernameTextBox2.ReadOnly = True
        apelli2.ReadOnly = True
        correo.ReadOnly = True
        contra.ReadOnly = True
        camCon.ReadOnly = True
        Comborol.Enabled = False
        cmbDepartamentos.Enabled = False
        cmbMunicipios.Enabled = False
        txtobservaciones.ReadOnly = True

        ' Botones deshabilitados
        bntenviar.Enabled = False
        txtactuali.Enabled = False
        txteliminar.Enabled = False
        bntnewcontra.Enabled = False
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
    Private Sub bntcancelar_Click(sender As Object, e As EventArgs) Handles bntcancelar.Click
        Me.Close()
    End Sub

    ' --- CONSULTA ---
    Private Sub btnConsulta_Click_1(sender As Object, e As EventArgs) Handles btnConsulta.Click
        Dim frmCons As New FrmConsulta()
        frmCons.Size = New Size(1200, 400)
        frmCons.DgvConsulta.Size = New Size(1160, 350)
        frmCons.DgvConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
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
        contra.UseSystemPasswordChar = True

        btndesbloquearusu.Visible = False
        bntnewcontra.Enabled = False

        ' Rellenar roles
        Comborol.Items.Clear()
        Comborol.Items.AddRange(New String() {"admin", "usuario", "invitado"})

        ' Departamentos
        Dim sqlDepartamentos As String = "SELECT id_departamento, nombre_departamento FROM departamentos ORDER BY nombre_departamento"
        c_Varias.llena_combo(cmbDepartamentos, sqlDepartamentos, "id_departamento", "nombre_departamento")

        ' Solo ID desbloqueado al inicio, resto bloqueado
        LimpiarCampos(False)
        Textbuscador.ReadOnly = False
        Textbuscador.BackColor = Color.White

        ' Asignar función EnterAvanzaOBusca a cada control
        AddHandler Textbuscador.KeyPress, Sub(s, ev) EnterAvanzaOBusca(Textbuscador, ev, UsernameTextBox)
        AddHandler UsernameTextBox.KeyPress, Sub(s, ev) EnterAvanzaOBusca(UsernameTextBox, ev, UsernameTextBox2)
        AddHandler UsernameTextBox2.KeyPress, Sub(s, ev) EnterAvanzaOBusca(UsernameTextBox2, ev, apelli)
        AddHandler apelli.KeyPress, Sub(s, ev) EnterAvanzaOBusca(apelli, ev, apelli2)
        AddHandler apelli2.KeyPress, Sub(s, ev) EnterAvanzaOBusca(apelli2, ev, contra)
        AddHandler contra.KeyPress, Sub(s, ev) EnterAvanzaOBusca(contra, ev, camCon)
        AddHandler camCon.KeyPress, Sub(s, ev) EnterAvanzaOBusca(camCon, ev, correo)
        AddHandler correo.KeyPress, Sub(s, ev) EnterAvanzaOBusca(correo, ev, Comborol)
        AddHandler Comborol.KeyPress, Sub(s, ev) EnterAvanzaOBusca(Comborol, ev, cmbDepartamentos)
        AddHandler cmbDepartamentos.KeyPress, Sub(s, ev) EnterAvanzaOBusca(cmbDepartamentos, ev, cmbMunicipios)
        AddHandler cmbMunicipios.KeyPress, Sub(s, ev) EnterAvanzaOBusca(cmbMunicipios, ev, txtobservaciones)
    End Sub

    Private Sub cmbDepartamentos_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbDepartamentos.SelectionChangeCommitted
        If cmbDepartamentos.SelectedValue IsNot Nothing Then
            Dim idDepartamento As Integer = CInt(cmbDepartamentos.SelectedValue)
            Dim sqlMunicipios As String = "SELECT id_municipio, nombre_municipio FROM municipios WHERE id_departamento = " & idDepartamento
            c_Varias.llena_combo(cmbMunicipios, sqlMunicipios, "id_municipio", "nombre_municipio")
        End If
    End Sub

    Private Sub Ptbvolver_Click(sender As Object, e As EventArgs) Handles Ptbvolver.Click
        Me.Close()
    End Sub

    Private Sub bntnewcontra_Click(sender As Object, e As EventArgs) Handles bntnewcontra.Click
        If String.IsNullOrWhiteSpace(Textbuscador.Text) Then
            MsgBox("Seleccione un usuario primero.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If Mprincipal_p.conexion Is Nothing OrElse Mprincipal_p.conexion.State <> ConnectionState.Open Then
            basexd.conectar("root", "")
            Mprincipal_p.conexion = basexd.conexion
        End If

        If Not Mprincipal_p.UsuarioExiste(Textbuscador.Text) Then
            MsgBox("Ese usuario no existe.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        ' Pregunta sí/no antes de continuar
        'Dim r = MessageBox.Show("¿Desea cambiar la contraseña del usuario seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If r = DialogResult.No Then Exit Sub

        'Dim contraIngresada As String = InputBox("Ingrese su contraseña:", "Verificación de seguridad")
        'If contraIngresada.Trim() = "" Then
        '    MsgBox("Debe ingresar la contraseña para continuar.", MsgBoxStyle.Exclamation)
        '    Exit Sub
        'End If

        'Dim contraReal As String = Mprincipal_p.ObtenerContraActual(codusuario)
        'If contraReal = "" Then
        '    MsgBox("Error al obtener la contraseña del usuario logueado.", MsgBoxStyle.Critical)
        '    Exit Sub
        'End If

        'If contraIngresada.Trim() <> contraReal.Trim() Then
        '    MsgBox("Contraseña incorrecta.", MsgBoxStyle.Critical)
        '    Exit Sub
        'End If

        Dim frm As New formcontra(CInt(Textbuscador.Text))
        frm.ShowDialog()
        frm.Dispose()
    End Sub

    Private Sub bntlimpiar_Click(sender As Object, e As EventArgs) Handles bntlimpiar.Click
        LimpiarCampos(True)
    End Sub

    Private Sub Textbuscador_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Textbuscador.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txtcorreo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles correo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If Not CorreoValido(correo) Then Exit Sub
        End If
    End Sub

    Private Sub btndesbloquearusu_Click(sender As Object, e As EventArgs) Handles btndesbloquearusu.Click
        Dim idUsuario As Integer
        If Not Integer.TryParse(Textbuscador.Text.Trim, idUsuario) Then Exit Sub

        Try
            Dim sql As String = "UPDATE tb_usuarios SET id_estado = 1, observacion = '' WHERE id_usuario = " & idUsuario
            Dim cmd As New OdbcCommand(sql, conexion)
            If cmd.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Usuario desbloqueado correctamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BuscarUsuario()
            Else
                MessageBox.Show("No se pudo desbloquear.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al desbloquear usuario: " & ex.Message, "Error")
        End Try
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ingresonombre.Text = ObtenerNombreUsuario()
    End Sub

    Private Sub correo_Leave(sender As Object, e As EventArgs) Handles correo.Leave
        correo.Text = Mprincipal_p.NormalizarCorreo(correo.Text)
    End Sub
    Private Sub UsernameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UsernameTextBox.KeyPress, UsernameTextBox2.KeyPress
        SoloLetras(e) ' Validación de solo letras
        EnterAvanzaOBusca(UsernameTextBox, e, apelli)
    End Sub

    Private Sub apelli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles apelli.KeyPress, apelli2.KeyPress
        SoloLetras(e) ' Validación de solo letras
        EnterAvanzaOBusca(apelli, e, contra)
    End Sub

    Private Sub txtobservaciones_KeyDown(sender As Object, e As KeyEventArgs) Handles txtobservaciones.KeyDown
        If e.KeyCode = Keys.Enter Then
            bntlimpiar.PerformClick()
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class
