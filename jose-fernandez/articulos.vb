Imports System.Data.Odbc

Public Class articulos
    Dim conexion As New OdbcConnection("DSN=hola")

    ' CARGA INICIAL
    Private Sub articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bnteliminar.Enabled = False
        CargarCategorias()

    End Sub


    ' Cargar categorías ComboBox
    Private Sub CargarCategorias()
        conexion.Open()
        Dim cmd As New OdbcCommand("SELECT id_categoria, nombre_categoria FROM categorias", conexion)
        Dim da As New OdbcDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        conexion.Close()

        Cmbcategoria.DataSource = dt
        Cmbcategoria.DisplayMember = "nombre_categoria"
        Cmbcategoria.ValueMember = "id_categoria"
    End Sub

    ' BOTÓN AGREGAR
    Private Sub bntagregar_Click_1(sender As Object, e As EventArgs) Handles bntagregar.Click
        ' ---- VALIDAR CAMPOS VACÍOS ----
        If Textnombrearti.Text.Trim() = "" Or
       rtbdescripcion.Text.Trim() = "" Or
       txtprecio.Text.Trim() = "" Or
       Texstock.Text.Trim() = "" Or
       txtiva.Text.Trim() = "" Or
       txtdescuento.Text.Trim() = "" Or
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

            conexion.Close()

            MsgBox("Artículo agregado correctamente.")
        Catch ex As Exception
            MsgBox("Error al agregar artículo: " & ex.Message)
            Try : conexion.Close() : Catch : End Try
        End Try
    End Sub

    ' BOTÓN BUSCAR

    Private Sub bntbuscar_Click_1(sender As Object, e As EventArgs) Handles bntbuscar.Click
        Try
            Dim f As New FrmConsulta()
            f.TipoCarga = "ARTICULO"
            f.ShowDialog()

            If f.DialogResult = DialogResult.OK Then
                txtid.Text = f.SelectedID
                CargarArticuloPorID(CInt(f.SelectedID))
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
                Textnombrearti.Text = dr("nombre_articulo").ToString()
                rtbdescripcion.Text = dr("descripcion").ToString()
                txtprecio.Text = dr("precio").ToString()
                Texstock.Text = dr("stock").ToString()
                txtiva.Text = dr("iva").ToString()
                txtdescuento.Text = dr("descuento").ToString()
                Cmbcategoria.SelectedValue = dr("id_categoria")

                txtid.Enabled = False
                bnteliminar.Enabled = True

            End If

            conexion.Close()
        Catch ex As Exception
            MsgBox("Error al cargar artículo: " & ex.Message)
            Try : conexion.Close() : Catch : End Try
        End Try
    End Sub


    ' BOTÓN ACTUALIZAR

    Private Sub bntactualizar_Click_1(sender As Object, e As EventArgs) Handles bntactualizar.Click
        If txtid.Text.Trim() = "" Then
            MsgBox("Ingresa el ID del artículo a actualizar.")
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
            cmd.ExecuteNonQuery()
            conexion.Close()

            MsgBox("Artículo actualizado correctamente.")
        Catch ex As Exception
            MsgBox("Error al actualizar: " & ex.Message)
            Try : conexion.Close() : Catch : End Try
        End Try
    End Sub

    ' BOTÓN ELIMINAR
    Private Sub bnteliminar_Click_1(sender As Object, e As EventArgs) Handles bnteliminar.Click



        If txtid.Text.Trim() = "" Then
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
            cmd.ExecuteNonQuery()
            conexion.Close()

            MsgBox("Artículo eliminado correctamente.")
        Catch ex As Exception
            MsgBox("Error al eliminar: " & ex.Message)
            Try : conexion.Close() : Catch : End Try
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
        Try
            txtid.Clear()
            txtid.Enabled = True
            Textnombrearti.Clear()
            rtbdescripcion.Clear()
            txtprecio.Clear()
            Texstock.Clear()
            txtiva.Clear()
            txtdescuento.Clear()

            If Cmbcategoria.Items.Count > 0 Then
                Cmbcategoria.SelectedIndex = 0
            End If
            bnteliminar.Enabled = False
            Textnombrearti.Focus()
        Catch ex As Exception
            MsgBox("Error al limpiar los campos: " & ex.Message)
        End Try
    End Sub

    ' BOTÓN RETROCEDER
    Private Sub Ptbretroceder_Click_1(sender As Object, e As EventArgs) Handles Ptbretroceder.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Ptbretrocederd_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtid_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtid.Validating
        If txtid.Text.Trim() <> "" AndAlso Not IsNumeric(txtid.Text) Then
            MsgBox("ID no válido. Solo se permiten números.")
            txtid.Clear()
            e.Cancel = True
        End If
    End Sub

End Class
