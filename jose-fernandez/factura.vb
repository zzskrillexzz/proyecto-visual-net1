Imports System.Data.Odbc
Imports Mysqlx.XDevAPI

Public Class factura
    Dim SQL As String
    Dim rst As OdbcDataReader

    Private Sub factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            grilla_inv.Columns.Add("nombre", "Nombre del Artículo")
            grilla_inv.Columns.Add("Cantidad", "Cantidad")
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

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles ptbreverse.Click
        Dim frmSeleccion As New usu_clien()
        frmSeleccion.Show()
        Me.Close()
    End Sub
    Private Sub txtIdCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            'codigo is el cliente existe o no
            SQL = "SELECT * FROM tb_clientes WHERE id_cliente=" & txtIdCliente.Text
            rst = basexd.leer_Registro(SQL)

            If rst IsNot Nothing AndAlso rst.Read() Then

                txtNombreCliente.Text = rst("nombre").ToString() & " " & rst("apellido").ToString()
                txtcorreo.Text = rst("correo").ToString()
                rst.Close()
            Else

                Dim Rpta As MsgBoxResult
                Rpta = MsgBox("Cliente no registrado. ¿Desea agregarlo?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Error")

                If Rpta = vbYes Then
                    Dim frm As New clifor()
                    frm.Textbuscador.Text = txtIdCliente.Text
                    frm.FocusFactura = 1
                    frm.FormFactura = Me   ' 🔹 (usa esto si ya lo tienes en tu clifor)
                    frm.ShowDialog()
                    Exit Sub
                Else
                    Exit Sub
                End If





            End If
        End If
    End Sub
    Private Sub grilla_inv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grilla_inv.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Select Case grilla_inv.CurrentCell.ColumnIndex
                    Case 0
                        e.Handled = True
                        SendKeys.Send("{TAB}")

                    Case 1
                        Try

                            frmconsulta2.Text = "Planilla de Articulos"
                            frmconsulta2.grd.DataSource = ""
                            SQL = "SELECT id_articulo AS Id, nombre_articulo AS Nombre " &
                                  "FROM articulos ORDER BY nombre_articulo"


                            frmconsulta2.bind.DataSource = basexd.Listar_datos(SQL)
                            frmconsulta2.grd.DataSource = frmconsulta2.bind.DataSource

                            frmconsulta2.ShowDialog()


                            If sw_Regreso = 1 Then
                                grilla_inv.Item(0, grilla_inv.CurrentRow.Index).Value = vec(0)
                                grilla_inv.Item(1, grilla_inv.CurrentRow.Index).Value = vec(1)
                            Else
                                grilla_inv.CurrentCell = grilla_inv.Rows(grilla_inv.CurrentRow.Index).Cells(1)

                            End If
                        Catch ex As Exception
                            MsgBox("Error al cargar artículo: " & ex.Message)
                        End Try

                    Case 2, 3
                        e.Handled = True
                        SendKeys.Send("{TAB}")
                End Select

            Case Keys.Insert
                grilla_inv.Rows.Add()
                grilla_inv.CurrentCell = grilla_inv.Rows(grilla_inv.CurrentRow.Index + 1).Cells(1)
        End Select
    End Sub

    Private Sub lblnumerofactura_Click(sender As Object, e As EventArgs) Handles lblnumerofactura.Click
    End Sub

    Private Sub tssusuario_Click(sender As Object, e As EventArgs) Handles tssusuario.Click
    End Sub

    Private Sub txtid_TextChanged(sender As Object, e As EventArgs) Handles txtIdCliente.TextChanged

    End Sub
End Class
