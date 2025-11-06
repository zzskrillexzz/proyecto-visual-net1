Imports System.Data.Odbc

Public Class basexd
    Public Shared conexion As Odbc.OdbcConnection
    Public Shared adaptador As OdbcDataAdapter
    Public Shared orden As OdbcCommand
    Public Shared insertar As OdbcCommand

    Public Shared Function conectar(ByVal user As String, ByVal pass As String) As Boolean
        Try
            conexion = New OdbcConnection("DSN=hola;UID=" & user & ";PWD=" & pass & ";")
            conexion.Open()
            Return True
        Catch ex As OdbcException
            MsgBox("Error al conectar: " & ex.Message)
            Return False
        End Try
    End Function

    Public Shared Function leer_Registro(ByVal sql As String) As OdbcDataReader
        Try
            orden = New OdbcCommand(sql, conexion)
            Return orden.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("Error al Leer Registros en la Base de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Shared Function ingresar_registros(ByVal sql As String) As Boolean
        Try
            insertar = New OdbcCommand(sql, conexion)
            insertar.ExecuteNonQuery()
            MsgBox("Datos insertados correctamente")
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se insertaron los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Shared Function Listar_datos(ByVal sql As String) As DataTable
        Try
            Dim tab As New DataTable
            adaptador = New OdbcDataAdapter(sql, conexion)
            adaptador.Fill(tab)
            Return tab
        Catch ex As Exception
            MsgBox("¡No se encontraron Datos a Listar!", MsgBoxStyle.Exclamation)
            Return Nothing
        End Try
    End Function
    Public Shared Sub ejecutar(ByVal SQL As String)
        Try
            Dim cmd As New OdbcCommand(SQL, conexion)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error al ejecutar SQL: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Class