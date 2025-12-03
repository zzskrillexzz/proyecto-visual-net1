Imports System.Data.Odbc

Public Class factura
    Dim SQL As String
    Dim rst As OdbcDataReader

    ' TOTALES
    Dim dscoTotal As Double = 0
    Dim ivaTotal As Double = 0
    Dim total As Double = 0

    Private Sub factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        basexd.conectar("root", "")

        ' Obtener número de factura
        SQL = "SELECT IFNULL(MAX(id_factura), 0) + 1 AS siguiente FROM factura"
        rst = basexd.leer_Registro(SQL)
        If rst IsNot Nothing AndAlso rst.Read() Then
            lblnumerofactura.Text = "N° " & rst("siguiente").ToString()
            rst.Close()
        Else
            lblnumerofactura.Text = "N° 1"
        End If

        ' Configurar grilla de artículos
        If grilla_inv.Columns.Count = 0 Then
            grilla_inv.Columns.Add("Codigo", "Código")
            grilla_inv.Columns.Add("Nombre", "Nombre")
            grilla_inv.Columns.Add("Cantidad", "Cantidad")
            grilla_inv.Columns.Add("Precio", "Precio")
            grilla_inv.Columns.Add("Descuento", "Desc (%)")
            grilla_inv.Columns.Add("IVA", "IVA (%)")
            grilla_inv.Columns.Add("Subtotal", "Subtotal")
            For Each col As DataGridViewColumn In grilla_inv.Columns
                col.ReadOnly = True
                If col.HeaderText.ToLower = "código" Or col.HeaderText.ToLower = "cantidad" Then
                    col.ReadOnly = False
                End If
            Next
        End If

        grilla_inv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        grilla_inv.AllowUserToAddRows = False
        grilla_inv.SelectionMode = DataGridViewSelectionMode.CellSelect

        If grilla_inv.Rows.Count = 0 Then
            grilla_inv.Rows.Add()
        End If

        grilla_inv.CurrentCell = grilla_inv.Rows(0).Cells(0)


        ' === CONFIGURAR MENÚ DESPLEGABLE DEL TOOLSTRIP SPLIT BUTTON ===
        Dim itemArticulos As New ToolStripMenuItem("Artículos")
        Dim itemClientes As New ToolStripMenuItem("Clientes")

        AddHandler itemArticulos.Click, AddressOf Menu_Articulos_Click
        AddHandler itemClientes.Click, AddressOf Menu_Clientes_Click

        buscar.DropDownItems.Clear()
        buscar.DropDownItems.Add(itemArticulos)
        buscar.DropDownItems.Add(itemClientes)
    End Sub

    ' === ACCIÓN POR DEFECTO: clic en el botón PRINCIPAL (no en la flecha) ===
    Private Sub buscar_ButtonClick(sender As Object, e As EventArgs) Handles buscar.ButtonClick
        ' Por ejemplo, abrir artículos por defecto
        Menu_Articulos_Click(Nothing, Nothing)
    End Sub

    ' === SELECCIÓN: ARTÍCULOS ===
    Private Sub Menu_Articulos_Click(sender As Object, e As EventArgs)
        Dim frm As New frmconsulta2()
        frm.Text = "Buscar Artículo"
        frm.TipoCarga = "ARTICULO"

        frm.Size = New Size(1200, 400)
        frm.grd.Size = New Size(1180, 350)
        frm.grd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        frm.ShowDialog()

        ' Nota: frmconsulta2 debe usar las variables GLOBALES sw_Regreso y vec
        If sw_Regreso = 1 AndAlso vec IsNot Nothing AndAlso vec.Length > 0 Then
            Dim rowIdx As Integer = grilla_inv.CurrentCell.RowIndex

            ' Evitar duplicados
            For i As Integer = 0 To grilla_inv.RowCount - 1
                If i <> rowIdx AndAlso grilla_inv.Rows(i).Cells(0).Value IsNot Nothing AndAlso
                   grilla_inv.Rows(i).Cells(0).Value.ToString() = vec(0) Then
                    MessageBox.Show("¡Este producto ya está agregado en la grilla!", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If
            Next

            ' Asignar valores
            grilla_inv.Item(0, rowIdx).Value = vec(0) ' ID
            grilla_inv.Item(1, rowIdx).Value = vec(1) ' Nombre
            grilla_inv.Item(3, rowIdx).Value = vec(2) ' Precio
            grilla_inv.Item(4, rowIdx).Value = CInt(vec(4)) ' Descuento (%)
            grilla_inv.Item(5, rowIdx).Value = CInt(vec(3)) ' IVA (%)

            ' Mover a cantidad y recalcular
            grilla_inv.CurrentCell = grilla_inv.Rows(rowIdx).Cells(2)
            recorrerDataGrid()
        End If
    End Sub

    ' === SELECCIÓN: CLIENTES ===
    Private Sub Menu_Clientes_Click(sender As Object, e As EventArgs)
        Dim frm As New frmconsulta2()
        frm.Text = "Buscar Cliente"
        frm.TipoCarga = "CLIENTE"
        frm.Size = New Size(1200, 400)
        frm.grd.Size = New Size(1180, 350)
        frm.grd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

        frm.ShowDialog()

        If sw_Regreso = 1 AndAlso vec IsNot Nothing AndAlso vec.Length > 0 Then
            txtIdCliented.Text = vec(0) ' ID
            txtNombreCliente.Text = vec(1) & " " & vec(2) ' Nombre + Apellido
            txtcorreo.Text = vec(3) ' Correo
            rsocial.Text = If(IsDBNull(vec(4)), "", vec(4).ToString()) ' Razon social
        End If
    End Sub

    ' === CÁLCULO DE TOTALES ===
    Sub recorrerDataGrid()
        dscoTotal = 0
        ivaTotal = 0
        total = 0

        For i As Integer = 0 To grilla_inv.RowCount - 1
            If grilla_inv.Rows(i).Cells(0).Value Is Nothing OrElse
               grilla_inv.Rows(i).Cells(2).Value Is Nothing OrElse
               grilla_inv.Rows(i).Cells(3).Value Is Nothing Then
                Continue For
            End If

            Dim precio As Double = Val(grilla_inv.Rows(i).Cells(3).Value)
            Dim cantidad As Double = Val(grilla_inv.Rows(i).Cells(2).Value)
            Dim descPorc As Double = Val(grilla_inv.Rows(i).Cells(4).Value) / 100
            Dim ivaPorc As Double = Val(grilla_inv.Rows(i).Cells(5).Value) / 100

            Dim subtotalSinDesc = precio * cantidad
            Dim valorDescuento = subtotalSinDesc * descPorc
            Dim subtotalConDesc = subtotalSinDesc - valorDescuento
            Dim valorIva = subtotalConDesc * ivaPorc
            Dim subtotalFinal = subtotalConDesc + valorIva

            grilla_inv.Rows(i).Cells(6).Value = subtotalFinal.ToString("N2")

            dscoTotal += valorDescuento
            ivaTotal += valorIva
            total += subtotalFinal
        Next

        txtIva.Text = "$ " & ivaTotal.ToString("N2")
        txtDesc.Text = "$ " & dscoTotal.ToString("N2")
        txtTotal.Text = "$ " & total.ToString("N2")
    End Sub

    ' === EVITAR DUPLICADOS ===
    Private Sub grilla_inv_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles grilla_inv.CellValidating

        ' Solo validar la columna del código (columna 0)
        If e.ColumnIndex <> 0 Then Exit Sub

        Dim nuevoCodigo As String = e.FormattedValue.ToString().Trim()

        ' Si está vacío no validar
        If nuevoCodigo = "" Then Exit Sub

        ' Si no es numérico, cancelar
        If Not IsNumeric(nuevoCodigo) Then
            MessageBox.Show("El código debe ser numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Cancel = True
            Exit Sub
        End If

        ' Validar duplicado en todas las filas menos la actual
        For i As Integer = 0 To grilla_inv.RowCount - 1

            ' Ignorar fila actual
            If i = e.RowIndex Then Continue For

            Dim valorCelda = grilla_inv.Rows(i).Cells(0).Value

            If valorCelda IsNot Nothing Then
                If valorCelda.ToString().Trim() = nuevoCodigo Then
                    MessageBox.Show("¡Este artículo ya está en la factura!", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    e.Cancel = True
                    Exit Sub
                End If
            End If

        Next
    End Sub


    ' === BÚSQUEDA DE CLIENTE POR ENTER EN CAMPO ID ===
    Private Sub txtIdCliented_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdCliented.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If txtIdCliented.Text.Trim() = "" Then
                MsgBox("Debe ingresar un ID de cliente.", vbExclamation)
                txtIdCliented.Focus()
                Return
            End If
            SQL = "SELECT * FROM tb_clientes WHERE id_cliente = " & txtIdCliented.Text
            rst = basexd.leer_Registro(SQL)

            If rst IsNot Nothing AndAlso rst.Read() Then
                txtNombreCliente.Text = rst("nombre").ToString() & " " & rst("apellido").ToString()
                txtcorreo.Text = rst("correo").ToString()
                rsocial.Text = If(IsDBNull(rst("razon")), "", rst("razon").ToString())
                rst.Close()
            Else
                rst?.Close()
                Dim result = MsgBox("Cliente no registrado. ¿Desea agregarlo?", vbYesNo + vbQuestion)
                If result = vbYes Then
                    Dim frm As New clifor()
                    frm.Textbuscador.Text = txtIdCliented.Text

                    frm.FocusFactura = 1
                    frm.FormFactura = Me
                    frm.ShowDialog()
                Else
                    txtIdCliented.Clear()
                    txtNombreCliente.Clear()
                    txtcorreo.Clear()
                    rsocial.Clear()
                    txtIdCliented.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub txtIdCliented_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdCliented.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub bntreverse_Click(sender As Object, e As EventArgs) Handles bntreverse.Click
        Me.Close()
    End Sub



    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rst = basexd.leer_Registro("SELECT * from tb_usuarios WHERE id_usuario=" & codusuario)
        If rst.Read() Then ingresonombre.Text = "Usuario: " & rst("nombre") & " " & rst("apellido")
    End Sub

    ' === FUNCIÓN PERSONALIZADA PARA LIMPIAR FACTURA ===
    Private Sub LimpiarFactura()
        LimpiarFormulario(Me)

        ' Limpieza específica
        grilla_inv.Rows.Clear()
        grilla_inv.Rows.Add()

        txtDesc.Text = "$ 0.00"
        txtIva.Text = "$ 0.00"
        txtTotal.Text = "$ 0.00"

        dscoTotal = 0 : ivaTotal = 0 : total = 0

        ' Recargar número de factura
        Dim rst As OdbcDataReader = basexd.leer_Registro("SELECT IFNULL(MAX(id_factura), 0) + 1 AS siguiente FROM factura")
        If rst IsNot Nothing AndAlso rst.Read() Then
            lblnumerofactura.Text = "N° " & rst("siguiente").ToString()
            rst.Close()
        Else
            lblnumerofactura.Text = "N° 1"
        End If

        txtIdCliented.Focus()
    End Sub

    ' === BOTÓN LIMPIAR ===
    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles limpiar.Click
        Dim hayDatos As Boolean = Not String.IsNullOrWhiteSpace(txtIdCliented.Text) OrElse
                              grilla_inv.RowCount > 1 OrElse
                              (grilla_inv.Rows(0).Cells(0).Value IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(grilla_inv.Rows(0).Cells(0).Value.ToString()))

        If hayDatos Then
            If MessageBox.Show("¿Desea limpiar todos los campos y comenzar una nueva factura?",
                           "Confirmar",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) <> DialogResult.Yes Then
                Return
            End If
        End If

        LimpiarFactura()
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        ' Solo capturar ENTER si estamos editando una celda
        If grilla_inv.IsCurrentCellInEditMode = False Then
            Return MyBase.ProcessCmdKey(msg, keyData)
        End If

        ' Solo ENTER
        If keyData <> Keys.Return Then
            Return MyBase.ProcessCmdKey(msg, keyData)
        End If

        Dim cell As DataGridViewCell = grilla_inv.CurrentCell
        Dim col As Integer = cell.ColumnIndex
        Dim row As Integer = cell.RowIndex

        grilla_inv.CommitEdit(DataGridViewDataErrorContexts.Commit)
        grilla_inv.EndEdit()

        ' ==========================================================
        '  COLUMNA 0 → CÓDIGO DEL ARTÍCULO
        ' ==========================================================
        If col = 0 Then

            Dim codStr As String = If(grilla_inv.Rows(row).Cells(0).Value, "").ToString.Trim()

            For i As Integer = 0 To grilla_inv.RowCount - 1
                If i = row Then Continue For
                If grilla_inv.Rows(i).Cells(0).Value IsNot Nothing AndAlso
       grilla_inv.Rows(i).Cells(0).Value.ToString() = codStr Then

                    MsgBox("Este artículo ya fue agregado en la factura.", MsgBoxStyle.Exclamation)
                    grilla_inv.Rows(row).Cells(0).Value = ""
                    Return True
                End If
            Next
            If codStr = "" Then
                MsgBox("Debe ingresar un código de artículo", MsgBoxStyle.Exclamation)
                Return True
            End If

            Dim cod As Integer
            If Not Integer.TryParse(codStr, cod) Then
                MsgBox("El código debe ser numérico", MsgBoxStyle.Exclamation)
                grilla_inv.Rows(row).Cells(0).Value = ""
                Return True
            End If

            ' Consultar artículo
            SQL = $"SELECT id_articulo, nombre_articulo, precio, iva, descuento 
               FROM articulos 
               WHERE id_articulo = {cod}"

            rst = basexd.leer_Registro(SQL)

            If rst IsNot Nothing AndAlso rst.Read() Then
                grilla_inv.Rows(row).Cells(1).Value = rst("nombre_articulo")
                grilla_inv.Rows(row).Cells(3).Value = rst("precio")
                grilla_inv.Rows(row).Cells(4).Value = rst("descuento")
                grilla_inv.Rows(row).Cells(5).Value = rst("iva")
                rst.Close()

                ' Pasar a cantidad
                grilla_inv.CurrentCell = grilla_inv.Rows(row).Cells(2)
                Return True

            Else
                rst?.Close()
                MsgBox("Codigo del articulo no se encontro", vbQuestion)
                grilla_inv.Rows(row).Cells(0).Value = ""
                Return True
            End If
        End If

        ' ==========================================================
        '  COLUMNA 2 → CANTIDAD
        ' ==========================================================
        If col = 2 Then

            ' Validar que haya código de artículo
            Dim cod As Integer
            If Not Integer.TryParse(If(grilla_inv.Rows(row).Cells(0).Value, "").ToString(), cod) Then
                MsgBox("Primero debe ingresar un código de artículo válido.", MsgBoxStyle.Exclamation)
                Return True
            End If

            ' Actualizar totales
            recorrerDataGrid()

            ' Crear nueva fila si estamos en la última
            Dim filaSiguiente As Integer = row + 1

            If filaSiguiente >= grilla_inv.Rows.Count Then
                grilla_inv.Rows.Add()
            End If

            ' Pasar a la siguiente fila, columna 0
            grilla_inv.CurrentCell = grilla_inv.Rows(filaSiguiente).Cells(0)

            Return True
        End If

        Return True
    End Function

    Private Sub dgvArt_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles grilla_inv.EditingControlShowing

        Dim txt As TextBox = TryCast(e.Control, TextBox)
        If txt Is Nothing Then Exit Sub

        RemoveHandler txt.KeyPress, AddressOf SoloNumeros

        Dim col As Integer = grilla_inv.CurrentCell.ColumnIndex

        Select Case col

            Case 0, 2
                ' Columnas que solo permiten números
                AddHandler txt.KeyPress, AddressOf SoloNumeros


        End Select

    End Sub

    Private Sub SoloNumeros(sender As Object, e As KeyPressEventArgs)
        If Char.IsControl(e.KeyChar) Then Exit Sub
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


End Class