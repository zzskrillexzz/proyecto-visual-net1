Imports System.Data.Odbc
Imports System.Windows.Forms

Public Class Varias
    Public Sub llena_combo(ByVal cmb As ComboBox, ByVal sql As String, ByVal cod As String, ByVal nombre As String)
        Try
            cmb.DataSource = basexd.Listar_datos(sql)
            With cmb
                .ValueMember = cod
                .DisplayMember = nombre
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se encontraron Registros Asociados a la Selección Anterior")
        End Try
    End Sub
    Sub carga_combo_filtro(ByVal frm As Form, ByVal cmb As ComboBox, ByVal grd As DataGridView)
        cmb.Items.Clear()
        cmb.Text = ""
        For i As Integer = 0 To grd.Columns.Count - 1
            If grd.Columns(i).Visible = True Then
                cmb.Items.Add(grd.Columns(i).HeaderText)
            End If
        Next
    End Sub
    Sub filtrar(ByVal bind As Object, ByVal txt As TextBox, ByVal combo As String, ByVal grd As DataGridView)
        If (txt.Text <> "") Then
            Try
                If (grd.Columns(combo).ValueType Is GetType(String) Or grd.Columns(combo).ValueType Is GetType(System.String)) Then
                    bind.Filter = String.Format(" {0} LIKE '%{1}%' ", combo, txt.Text)
                    grd.DataSource = bind.DataSource
                Else
                    If (grd.Columns(combo).ValueType Is GetType(Date)) Then
                        bind.Filter = String.Format(" {0} = '{1}' ", combo, txt.Text)
                        grd.DataSource = bind.DataSource
                    Else
                        If (grd.Columns(combo).ValueType Is GetType(Integer) Or grd.Columns(combo).ValueType Is GetType(System.Int16) Or
                        grd.Columns(combo).ValueType Is GetType(Int32) Or grd.Columns(combo).ValueType Is GetType(Int64)) Then
                            bind.Filter = String.Format(" {0} = {1} ", combo, txt.Text)
                            grd.DataSource = bind.DataSource
                        End If
                    End If
                End If
            Catch ex As Exception
                MsgBox("Parámetro de Búsqueda Incorrecto. " & ex.Message)
                txt.Clear()
            End Try
        Else
            bind.RemoveFilter()
        End If
    End Sub
    Public Sub Tabula()
        SendKeys.Send("{tab}")
    End Sub
End Class