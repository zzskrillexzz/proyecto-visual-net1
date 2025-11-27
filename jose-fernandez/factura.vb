Imports System.Data.Odbc
Imports Mysqlx.XDevAPI

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
        SQL = "SELECT IFNULL(MAX(id_factura), 0) + 1 AS siguiente FROM factura"
        rst = basexd.leer_Registro(SQL)

        If rst IsNot Nothing AndAlso rst.Read() Then
            lblnumerofactura.Text = "N° " & rst("siguiente").ToString()
            rst.Close()
        Else
            lblnumerofactura.Text = "N° 1"
        End If

        If grilla_inv.Columns.Count = 0 Then
            grilla_inv.Columns.Add("Codigo", "Código")
            grilla_inv.Columns.Add("Nombre", "Nombre")
            grilla_inv.Columns.Add("Cantidad", "Cantidad")
            grilla_inv.Columns.Add("Precio", "Precio")
            grilla_inv.Columns.Add("Descuento", "Desc (%)")
            grilla_inv.Columns.Add("IVA", "IVA (%)")
            grilla_inv.Columns.Add("Subtotal", "Subtotal")
        End If

        grilla_inv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        grilla_inv.AllowUserToAddRows = False
        grilla_inv.SelectionMode = DataGridViewSelectionMode.CellSelect

        If grilla_inv.Rows.Count = 0 Then
            grilla_inv.Rows.Add()
        End If

        grilla_inv.CurrentCell = grilla_inv.Rows(0).Cells(0)
        tssusuario.Text = "Usuario: " & codusuario
    End Sub


    'calculo
    Sub recorrerDataGrid()
        dscoTotal = 0
        ivaTotal = 0
        total = 0

        For i As Integer = 0 To grilla_inv.RowCount - 1
            If grilla_inv.Rows(i).Cells(0).Value Is Nothing Then Continue For

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



    'subtotal
    Private Sub grilla_inv_KeyDown(sender As Object, e As KeyEventArgs) Handles grilla_inv.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            Dim col = grilla_inv.CurrentCell.ColumnIndex
            Dim row = grilla_inv.CurrentCell.RowIndex

            ' =============== AUTO-LLENAR SI DIGITA EL CÓDIGO ==================
            If col = 0 Then
                Dim cod As String = grilla_inv.Rows(row).Cells(0).Value


                If cod <> "" Then
                    SQL = "SELECT id_articulo, nombre_articulo, precio, iva, descuento 
                       FROM articulos 
                       WHERE id_articulo = " & cod

                    rst = basexd.leer_Registro(SQL)

                    If rst.Read() Then
                        grilla_inv.Item(1, row).Value = rst("nombre_articulo")
                        grilla_inv.Item(3, row).Value = rst("precio")
                        grilla_inv.Item(4, row).Value = CInt(rst("descuento"))   ' <--- SIN "%"
                        grilla_inv.Item(5, row).Value = CInt(rst("iva"))         ' <--- SIN "%"

                        rst.Close()

                        ' Pasar a cantidad
                        grilla_inv.CurrentCell = grilla_inv.Rows(row).Cells(2)
                        Exit Sub
                    End If

                    rst.Close()
                End If
            End If


            ' =================== SI NO EXISTE → ABRIR CONSULTA =================
            If col = 0 Then
                Try
                    frmconsulta2.Text = "Planilla de Artículos"
                    frmconsulta2.grd.DataSource = ""

                    SQL = "SELECT id_articulo AS Id, nombre_articulo AS Nombre, precio, iva, descuento 
                       FROM articulos ORDER BY nombre_articulo;"

                    frmconsulta2.bind.DataSource = basexd.Listar_datos(SQL)
                    frmconsulta2.grd.DataSource = frmconsulta2.bind.DataSource

                    frmconsulta2.ShowDialog()

                    If sw_Regreso = 1 Then
                        ' --- Verificar duplicado antes de asignar ---
                        Dim codSeleccionado As String = vec(0)
                        For i As Integer = 0 To grilla_inv.RowCount - 1
                            If i = row Then Continue For
                            If grilla_inv.Rows(i).Cells(0).Value IsNot Nothing AndAlso grilla_inv.Rows(i).Cells(0).Value.ToString() = codSeleccionado Then
                                MsgBox("¡Este producto ya está agregado en la grilla!", MsgBoxStyle.Exclamation)
                                Exit Sub
                            End If
                        Next

                        ' --- Asignar valores si no hay duplicado ---
                        grilla_inv.Item(0, row).Value = vec(0)
                        grilla_inv.Item(1, row).Value = vec(1)
                        grilla_inv.Item(3, row).Value = vec(2)
                        grilla_inv.Item(4, row).Value = CInt(vec(4))
                        grilla_inv.Item(5, row).Value = CInt(vec(3))

                        grilla_inv.CurrentCell = grilla_inv.Rows(row).Cells(2)
                    Else
                        SendKeys.Send("{TAB}")
                    End If


                Catch ex As Exception
                    MsgBox("Error al abrir artículos: " & ex.Message)
                End Try
            End If


            ' ========================= RECALCULAR ==============================
            If col = 2 Or col = 3 Or col = 4 Or col = 5 Then
                Try
                    grilla_inv.CommitEdit(DataGridViewDataErrorContexts.Commit)
                    recorrerDataGrid()
                    SendKeys.Send("{TAB}")
                Catch
                End Try
            End If

        End If


        ' ======================= INSERTAR FILA ================================
        If e.KeyCode = Keys.Insert Then
            grilla_inv.Rows.Add()
            grilla_inv.CurrentCell = grilla_inv.Rows(grilla_inv.Rows.Count - 1).Cells(0)
        End If

    End Sub

    ' --- EVITAR DUPLICADOS EN LA GRILLA ---
    Private Sub grilla_inv_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles grilla_inv.CellValidating
        ' Verificar solo la columna de Código (0)
        If e.ColumnIndex = 0 Then
            Dim nuevoCodigo As String = e.FormattedValue.ToString().Trim()

            If String.IsNullOrEmpty(nuevoCodigo) Then
                Return ' No validar si está vacío
            End If

            ' Revisar todas las filas excepto la actual
            For i As Integer = 0 To grilla_inv.RowCount - 1
                If i = e.RowIndex Then Continue For
                If grilla_inv.Rows(i).Cells(0).Value IsNot Nothing AndAlso
               grilla_inv.Rows(i).Cells(0).Value.ToString() = nuevoCodigo Then
                    MessageBox.Show("¡Este producto ya está agregado en la grilla!", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    e.Cancel = True ' Cancela la edición y no deja duplicar
                    Exit Sub
                End If
            Next
        End If
    End Sub






    Private Sub txtIdCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdCliented.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            SQL = "SELECT * FROM tb_clientes WHERE id_cliente=" & txtIdCliented.Text
            rst = basexd.leer_Registro(SQL)

            If rst IsNot Nothing AndAlso rst.Read() Then
                txtNombreCliente.Text = rst("nombre").ToString() & " " & rst("apellido").ToString()
                txtcorreo.Text = rst("correo").ToString()
                rst.Close()
            Else
                rst?.Close()
                ' Cliente no registrado
                Dim result As MsgBoxResult = MsgBox("Cliente no registrado. ¿Desea agregarlo?", vbYesNo + vbQuestion)
                If result = vbYes Then
                    Dim frm As New clifor()
                    frm.Textbuscador.Text = txtIdCliented.Text
                    frm.FocusFactura = 1
                    frm.FormFactura = Me
                    frm.ShowDialog()
                Else
                    ' Limpiar automáticamente el campo de ID
                    txtIdCliented.Clear()
                    txtNombreCliente.Clear()
                    txtcorreo.Clear()
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

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles bntreverse.Click
        Me.Close()
    End Sub

    Private Sub lblnumerofactura_Click(sender As Object, e As EventArgs) Handles lblnumerofactura.Click

    End Sub
End Class
