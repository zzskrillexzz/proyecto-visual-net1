Imports System.Data.Odbc

Public Class formcontra

    Private ReadOnly idTarget As Integer
    Private conexion As OdbcConnection

    ' Constructor que recibe el id del usuario al que se le cambiará la contraseña
    Public Sub New(ByVal idUsuario As Integer)
        InitializeComponent()
        idTarget = idUsuario
    End Sub

    Private Sub formcontra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Conectar DB si hace falta
        basexd.conectar("root", "")
        conexion = basexd.conexion

        ' Asigna la conexión global del módulo para que las funciones del módulo puedan usarla
        Mprincipal_p.conexion = conexion

        ' Si quieres mostrar el ID en algún label o textbox (opcional)
        ' lblId.Text = idTarget.ToString()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim nueva As String = txtcambio1.Text.Trim()
        Dim confirma As String = txtcambio2.Text.Trim()

        ' --- Validaciones básicas ---
        If nueva = "" Or confirma = "" Then
            MsgBox("Por favor, ingrese y confirme la nueva contraseña.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If nueva <> confirma Then
            MsgBox("Las contraseñas no coinciden.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If idTarget <= 0 Then
            MsgBox("Error: ID de usuario inválido.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        ' --- Validar que la nueva contraseña no sea igual a la actual ---
        ' Usa la función del módulo (asegúrate que EsContraRepetida está en Mprincipal_p)
        If Mprincipal_p.EsContraRepetida(nueva, idTarget.ToString()) Then
            MessageBox.Show("La nueva contraseña no puede ser igual a la anterior.",
                            "Contraseña no válida",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' --- Actualizar en la base de datos ---
        Try
            Dim sqlUpdate As String = "UPDATE tb_usuarios SET contraseña = ? WHERE id_usuario = ?"
            Using cmd As New OdbcCommand(sqlUpdate, conexion)
                cmd.Parameters.AddWithValue("p1", nueva)
                cmd.Parameters.AddWithValue("p2", idTarget)
                cmd.ExecuteNonQuery()
            End Using

            MsgBox("Contraseña actualizada correctamente.", MsgBoxStyle.Information)
            Me.Close()
        Catch ex As Exception
            MsgBox("Error al actualizar la contraseña: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Class
