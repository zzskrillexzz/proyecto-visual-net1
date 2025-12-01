Imports System.Data.Odbc
Imports System.Data

Public Class FrmConsulta

    ' Indica qué tipo de información se mostrará
    Public TipoCarga As String = "USUARIO"

    ' Devuelve el ID seleccionado
    Public SelectedID As String = ""

    Private Sub FrmConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not basexd.conectar("root", "") Then
            MessageBox.Show("No se pudo conectar a la base de datos.")
            Return
        End If

        With DgvConsulta
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .ReadOnly = True
        End With

        CargarDatos()
    End Sub

    ' CARGAR DATOS SEGÚN EL TIPO DE FORMULARIO
    Private Sub CargarDatos()
        Dim sql As String = ""

        Select Case TipoCarga.ToUpper()
            Case "CLIENTE"
                sql = "SELECT id_cliente AS ID, nombre, apellido, correo " &
          "FROM tb_clientes " &
          "WHERE id_estado = 1 " &
          "ORDER BY nombre, apellido"

            Case "USUARIO"
                sql = "SELECT id_usuario AS ID, nombre, apellido, correo, rol " &
          "FROM tb_usuarios " &
          "WHERE id_estado = 1 " &
          "ORDER BY nombre, apellido"

            Case "ARTICULO"
                sql = "SELECT id_articulo AS ID, nombre_articulo AS Artículo, descripcion, precio, stock FROM articulos"

            Case "CATEGORIA"
                sql = "SELECT id_categoria AS ID, nombre_categoria AS Categoría, descripcion FROM categorias"

            Case "FACTURA"
                sql = "SELECT id_factura AS ID, id_cliente, fecha_emision, total FROM factura"

            Case Else
                sql = "SELECT 'Tipo de carga no definido' AS Mensaje"
        End Select

        DgvConsulta.DataSource = basexd.Listar_datos(sql)
    End Sub

    ' DOBLE CLIK SELECCIONAR REGISTRO
    Private Sub DgvConsulta_DoubleClick(sender As Object, e As EventArgs) Handles DgvConsulta.DoubleClick
        Try
            If DgvConsulta.CurrentRow IsNot Nothing Then
                SelectedID = DgvConsulta.CurrentRow.Cells("ID").Value.ToString()
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al seleccionar un registro: " & ex.Message, "Error de Selección", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DgvConsulta_KeyDown(sender As Object, e As KeyEventArgs) Handles DgvConsulta.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If DgvConsulta.CurrentRow IsNot Nothing Then
                SelectedID = DgvConsulta.CurrentRow.Cells("ID").Value.ToString()
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub



End Class
