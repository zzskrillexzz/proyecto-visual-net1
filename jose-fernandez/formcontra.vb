Imports System.Data.Odbc

Public Class formcontra

    Private ReadOnly idUsuario As Integer
    Private conexion As OdbcConnection

    ' Constructor: recibe el ID del usuario al que se le cambiará la contraseña
    Public Sub New(ByVal id As Integer)
        InitializeComponent()
        idUsuario = id

        ' Asegurar conexión global
        If Mprincipal_p.conexion Is Nothing OrElse Mprincipal_p.conexion.State <> ConnectionState.Open Then
            basexd.conectar("root", "")
            Mprincipal_p.conexion = basexd.conexion
        End If

        conexion = Mprincipal_p.conexion
    End Sub


    ' -------------------------
    ' GUARDAR CAMBIO DE CONTRASEÑA
    ' -------------------------
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click

        Dim contraAnterior As String = txtAnterior.Text.Trim()
        Dim nueva As String = txtcambio1.Text.Trim()
        Dim confirma As String = txtcambio2.Text.Trim()

        ' Validación de campos vacíos
        If contraAnterior = "" OrElse nueva = "" OrElse confirma = "" Then
            MsgBox("Todos los campos son obligatorios.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        ' Validación coincidencia
        If nueva <> confirma Then
            MsgBox("Las contraseñas nuevas no coinciden.", MsgBoxStyle.Critical)
            Exit Sub
        End If


        ' Obtener contraseña real del usuario desde BD
        Dim contraReal As String = ""
        Dim sql As String = "SELECT contraseña FROM tb_usuarios WHERE id_usuario = ?"

        Try
            Using cmd As New OdbcCommand(sql, conexion)
                cmd.Parameters.AddWithValue("p1", idUsuario)

                Using rd As OdbcDataReader = cmd.ExecuteReader()
                    If rd.Read() Then
                        contraReal = rd("contraseña").ToString().Trim()
                    Else
                        MsgBox("El usuario no existe en la base de datos.", MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Error obteniendo la contraseña: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try


        ' Validar contraseña anterior
        If contraAnterior <> contraReal Then
            MsgBox("La contraseña anterior no es correcta.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        ' No permitir misma contraseña
        If nueva = contraReal Then
            MsgBox("La nueva contraseña no puede ser igual a la anterior.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If


        ' Actualizar contraseña
        Try
            Dim sqlUpdate As String = "UPDATE tb_usuarios SET contraseña = ? WHERE id_usuario = ?"

            Using cmdUpd As New OdbcCommand(sqlUpdate, conexion)
                cmdUpd.Parameters.AddWithValue("p1", nueva)
                cmdUpd.Parameters.AddWithValue("p2", idUsuario)

                Dim filas As Integer = cmdUpd.ExecuteNonQuery()

                If filas > 0 Then
                    MsgBox("Contraseña actualizada correctamente.", MsgBoxStyle.Information)
                    Me.Close()
                Else
                    MsgBox("No se actualizó la contraseña.", MsgBoxStyle.Exclamation)
                End If
            End Using

        Catch ex As Exception
            MsgBox("Error al actualizar contraseña: " & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub formcontra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAnterior.Focus()
    End Sub
End Class
