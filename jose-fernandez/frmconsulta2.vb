Public Class frmconsulta2
    Dim n_Col As String
    Dim c_varias As New Varias

    'estos hace que el doble clic guarde la fila seleecionada y luego se cierra
    Private Sub grd_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd.DoubleClick
        ReDim vec(grd.Columns.Count)
        For i As Integer = 0 To grd.Columns.Count - 1
            vec(i) = IIf(IsDBNull(grd.Item(i, grd.CurrentCell.RowIndex).Value), "", grd.Item(i, grd.CurrentCell.RowIndex).Value)
        Next
        bind.DataSource = ""
        sw_Regreso = 1
        Me.Close()
    End Sub
    Private Sub temp_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        bind.RemoveFilter()
    End Sub

    'cuando se presione el escape se cierra frmconsulta
    Private Sub temp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                sw_Regreso = 1
                Me.Close()
            Case Keys.Enter
                e.Handled = True
        End Select
    End Sub

    Private Sub temp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        c_varias.carga_combo_filtro(Me, cbbFiltro, grd)
        sw_Regreso = 0
    End Sub

    Private Sub cbbFiltro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbFiltro.SelectedIndexChanged
        n_Col = cbbFiltro.Text
        c_varias.Tabula()
    End Sub

    Private Sub txtFiltro_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFiltro.TextChanged
        c_varias.filtrar(bind, txtFiltro, n_Col, grd)
    End Sub

    'cuando se presione la tecla enter guarda la fila anterior y cierra
    Private Sub grd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles grd.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Try
                ReDim vec(grd.Columns.Count)
                For i As Integer = 0 To grd.Columns.Count - 1
                    vec(i) = IIf(IsDBNull(grd.Item(i, grd.CurrentCell.RowIndex - 1).Value), "", grd.Item(i, grd.CurrentCell.RowIndex - 1).Value)
                Next
                bind.DataSource = ""
                sw_Regreso = 1
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub grd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grd.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                sw_Regreso = 0
                Me.Close()
        End Select
    End Sub
End Class
