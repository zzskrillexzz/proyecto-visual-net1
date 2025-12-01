Imports System.Data.Odbc
Imports System.Data

Public Class articulos
    Dim conexion As New OdbcConnection("DSN=hola")

    ' CARGA INICIAL
    Private Sub articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bnteliminar.Enabled = False
        CargarCategorias()
    End Sub


    ' Cargar categorías ComboBox
    Private Sub CargarCategorias()
        Try
            conexion.Open()
            Dim cmd As New OdbcCommand("SELECT id_categoria, nombre_categoria FROM categorias", conexion)
            Dim da As New OdbcDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            conexion.Close()

            Cmbcategoria.DataSource = dt
            Cmbcategoria.DisplayMember = "nombre_categoria"
            Cmbcategoria.ValueMember = "id_categoria"
            Cmbcategoria.SelectedIndex = -1
        Catch ex As Exception
            MsgBox("Error al cargar categorías: " & ex.Message)
            If conexion.State = ConnectionState.Open Then conexion.Close()
        End Try
    End Sub

    ' Método para preparar formulario para nuevo registro
    Private Sub LimpiarCamposParaNuevo(Optional idPredefinido As Integer = 0)
        If idPredefinido > 0 Then
            txtid.Text = idPredefinido.ToString()
        Else
            txtid.Clear()
        End If

        txtid.ReadOnly = False
        txtid.BackColor = Color.White

        Textnombrearti.Clear()
        rtbdescripcion.Clear()
        txtprecio.Clear()
        Texstock.Clear()
        txtiva.Text = "19"
        txtdescuento.Text = "0"

        If Cmbcategoria.Items.Count > 0 Then
            Cmbcategoria.SelectedIndex = -1
        End If

        bnteliminar.Enabled = False
        bntactualizar.Enabled = False
        bntagregar.Enabled = True

        Textnombrearti.Focus()
    End Sub

    ' BOTÓN AGREGAR
    Private Sub bntagregar_Click_1(sender As Object, e As EventArgs) Handles bntagregar.Click
        If String.IsNullOrWhiteSpace(Textnombrearti.Text) OrElse
           String.IsNullOrWhiteSpace(txtprecio.Text) OrElse
           String.IsNullOrWhiteSpace(Texstock.Text) OrElse
           String.IsNullOrWhiteSpace(txtiva.Text) OrElse
           String.IsNullOrWhiteSpace(txtdescuento.Text) OrElse
           Cmbcategoria.SelectedIndex = -1 Then

            MsgBox("Todos los campos son obligatorios. Por favor, completa la información.")
            Exit Sub
        End If

        Try
            conexion.Open()
            Dim sql As String = "INSERT INTO articulos (nombre_articulo, descripcion, precio, stock, iva, descuento, id_categoria) VALUES ('" &
                                Replace(Textnombrearti.Text, "'", "''") & "', '" &
                                Replace(rtbdescripcion.Text, "'", "''") & "', " &
                                CDbl(txtprecio.Text) & ", " &
                                CInt(Texstock.Text) & ", " &
                                CDbl(txtiva.Text) & ", " &
                                CDbl(txtdescuento.Text) & ", " &
                                CInt(Cmbcategoria.SelectedValue) & ")"

            Dim cmd As New OdbcCommand(sql, conexion)
            cmd.ExecuteNonQuery()  ' ✅ Ejecutar el INSERT

            MsgBox("Artículo agregado correctamente.")
            LimpiarCamposParaNuevo()

        Catch ex As Exception
            MsgBox("Error al agregar artículo: " & ex.Message)
        Finally
            If conexion.State = ConnectionState.Open Then conexion.Close()
        End Try
    End Sub

    ' BOTÓN BUSCAR
    Private Sub bntbuscar_Click_1(sender As Object, e As EventArgs) Handles bntbuscar.Click
        Try
            Dim frm As New frmconsulta2()
            frm.Text = "Buscar Artículo"
            frm.TipoCarga = "ARTICULO"
            frm.Size = New Size(600, 400)
            frm.grd.Size = New Size(580, 300)
            frm.grd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            frm.ShowDialog()
            If sw_Regreso = 1 AndAlso vec IsNot Nothing AndAlso vec.Length > 0 Then
                CargarArticuloPorID(vec(0))
            End If
        Catch ex As Exception
            MsgBox("Error al abrir la consulta: " & ex.Message)
        End Try
    End Sub

    ' Carga los datos de un artículo por su ID
    Private Sub CargarArticuloPorID(id As Integer)
        Try
            conexion.Open()
            Dim sql As String = "SELECT nombre_articulo, descripcion, precio, stock, iva, descuento, id_categoria FROM articulos WHERE id_articulo = " & id
            Dim cmd As New OdbcCommand(sql, conexion)
            Dim dr As OdbcDataReader = cmd.ExecuteReader()

            If dr.Read() Then
                txtid.Text = id.ToString()
                txtid.ReadOnly = True
                txtid.BackColor = SystemColors.Control

                Textnombrearti.Text = dr("nombre_articulo").ToString()
                rtbdescripcion.Text = dr("descripcion").ToString()
                txtprecio.Text = dr("precio").ToString()
                Texstock.Text = dr("stock").ToString()
                txtiva.Text = dr("iva").ToString()
                txtdescuento.Text = dr("descuento").ToString()
                Cmbcategoria.SelectedValue = dr("id_categoria")

                bnteliminar.Enabled = True
                bntactualizar.Enabled = True
                bntagregar.Enabled = False

            Else
                ' ID no existe → nuevo registro

                MsgBox("ID no encontrado. Puedes registrar un nuevo artículo con este ID.", MsgBoxStyle.Information)
                LimpiarCamposParaNuevo(id)
            End If

            dr.Close()

        Catch ex As Exception
            MsgBox("Error al cargar artículo: " & ex.Message)
        Finally
            If conexion.State = ConnectionState.Open Then conexion.Close()
        End Try
    End Sub

    ' BOTÓN ACTUALIZAR
    Private Sub bntactualizar_Click_1(sender As Object, e As EventArgs) Handles bntactualizar.Click
        If String.IsNullOrWhiteSpace(txtid.Text) Then
            MsgBox("Ingresa el ID del artículo a actualizar.")
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(Textnombrearti.Text) OrElse
           String.IsNullOrWhiteSpace(txtprecio.Text) OrElse
           String.IsNullOrWhiteSpace(Texstock.Text) OrElse
           String.IsNullOrWhiteSpace(txtiva.Text) OrElse
           String.IsNullOrWhiteSpace(txtdescuento.Text) OrElse
           Cmbcategoria.SelectedIndex = -1 Then

            MsgBox("Todos los campos son obligatorios. Por favor, completa la información.")
            Exit Sub
        End If
        Try
            conexion.Open()
            Dim sql As String = "UPDATE articulos SET " &
                                "nombre_articulo='" & Replace(Textnombrearti.Text, "'", "''") & "', " &
                                "descripcion='" & Replace(rtbdescripcion.Text, "'", "''") & "', " &
                                "precio=" & CDbl(txtprecio.Text) & ", " &
                                "stock=" & CInt(Texstock.Text) & ", " &
                                "iva=" & CDbl(txtiva.Text) & ", " &
                                "descuento=" & CDbl(txtdescuento.Text) & ", " &
                                "id_categoria=" & CInt(Cmbcategoria.SelectedValue) &
                                " WHERE id_articulo=" & CInt(txtid.Text)

            Dim cmd As New OdbcCommand(sql, conexion)
            Dim rows As Integer = cmd.ExecuteNonQuery()
            conexion.Close()

            If rows > 0 Then
                MsgBox("Artículo actualizado correctamente.", MsgBoxStyle.Information)
            Else
                MsgBox("No se detectaron cambios para actualizar.", MsgBoxStyle.Information)

            End If

        Catch ex As Exception
            MsgBox("Error al actualizar: " & ex.Message)
        Finally
            If conexion.State = ConnectionState.Open Then conexion.Close()
        End Try
    End Sub

    ' BOTÓN ELIMINAR
    Private Sub bnteliminar_Click_1(sender As Object, e As EventArgs) Handles bnteliminar.Click
        If String.IsNullOrWhiteSpace(txtid.Text) Then
            MsgBox("Ingresa el ID del artículo a eliminar.")
            Exit Sub
        End If

        If MsgBox("¿Seguro que deseas eliminar el artículo?", MsgBoxStyle.YesNo) <> MsgBoxResult.Yes Then
            Exit Sub
        End If

        Try
            conexion.Open()
            Dim sql As String = "DELETE FROM articulos WHERE id_articulo = " & CInt(txtid.Text)
            Dim cmd As New OdbcCommand(sql, conexion)
            Dim rows As Integer = cmd.ExecuteNonQuery()

            If rows > 0 Then
                MsgBox("Artículo eliminado correctamente.")
                LimpiarCamposParaNuevo()
            Else
                MsgBox("No se encontró el artículo con ese ID.")
            End If

        Catch ex As Exception
            MsgBox("Error al eliminar: " & ex.Message)
        Finally
            If conexion.State = ConnectionState.Open Then conexion.Close()
        End Try
    End Sub

    ' BOTÓN ADD
    Private Sub bntadd_Click(sender As Object, e As EventArgs) Handles bntadd.Click
        Dim f As New addcategoria()
        f.ShowDialog()
        CargarCategorias()
    End Sub

    ' BOTÓN LIMPIAR CAMPOS
    Private Sub bntlimpiar_Click_1(sender As Object, e As EventArgs) Handles bntlimpiar.Click
        LimpiarCamposParaNuevo()
    End Sub

    ' BOTÓN RETROCEDER
    Private Sub Ptbretroceder_Click_1(sender As Object, e As EventArgs) Handles Ptbretroceder.Click
        Me.Close()
    End Sub

    ' Buscar con Enter en txtid
    Private Sub txtid_KeyDown(sender As Object, e As KeyEventArgs) Handles txtid.KeyDown
        If e.KeyCode = Keys.Enter AndAlso Not String.IsNullOrWhiteSpace(txtid.Text) Then
            e.SuppressKeyPress = True
            Dim id As Integer
            If Integer.TryParse(txtid.Text.Trim(), id) Then
                CargarArticuloPorID(id)
            Else
                MsgBox("ID no válido. Debe ser un número entero.", MsgBoxStyle.Exclamation)
                txtid.SelectAll()
                txtid.Focus()
            End If
        End If
    End Sub

    ' Solo enteros: asignamos la función del módulo a cada TextBox
    Private Sub txtid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtid.KeyPress
        Mprincipal_p.SoloNumeros(e)
    End Sub

    Private Sub txtprecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecio.KeyPress
        Mprincipal_p.SoloNumeros(e)
    End Sub

    Private Sub Texstock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Texstock.KeyPress
        Mprincipal_p.SoloNumeros(e)
    End Sub

    Private Sub txtiva_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtiva.KeyPress
        Mprincipal_p.SoloNumeros(e)
    End Sub

    Private Sub txtdescuento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdescuento.KeyPress
        Mprincipal_p.SoloNumeros(e)
    End Sub
    Private Sub txtiva_LostFocus(sender As Object, e As EventArgs) Handles txtiva.LostFocus, txtdescuento.LostFocus
        Dim txt As TextBox = DirectCast(sender, TextBox)
        Dim valor As Double

        ' Si el campo está vacío, ponerlo en 0
        If txt.Text.Trim() = "" Then
            txt.Text = "0"
            Exit Sub
        End If

        ' Intentar convertir a número
        If Not Double.TryParse(txt.Text, valor) Then
            MsgBox("Debe ingresar un valor numérico entre 0 y 100.", vbExclamation)
            txt.Text = "0"
            Exit Sub
        End If

        ' Corregir límites inferiores y superiores
        If valor < 0 Then valor = 0
        If valor > 100 Then valor = 100

        ' Establecer el valor corregido
        txt.Text = valor.ToString()
    End Sub

End Class