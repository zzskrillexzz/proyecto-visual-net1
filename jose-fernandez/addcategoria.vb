Imports MySql.Data.MySqlClient

Public Class addcategoria

    Dim conexion As New MySqlConnection("server=localhost;user=root;password=;database=db_login")

    ' AGREGAR CATEGORÍA
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles bntadd.Click
        Try
            If txtnombre.Text = "" Then
                MessageBox.Show("Por favor ingresa el nombre de la categoría.")
                Return
            End If

            conexion.Open()
            Dim cmd As New MySqlCommand("INSERT INTO categorias (nombre_categoria) VALUES (@nombre)", conexion)
            cmd.Parameters.AddWithValue("@nombre", txtnombre.Text)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Categoría agregada correctamente.")
            LimpiarCampos()

        Catch ex As MySqlException
            MessageBox.Show("Error al agregar categoría: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    ' CONSULTAR CATEGORÍAS (ABRIR FrmConsulta)
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles bntconsultar.Click
        Try
            Dim f As New FrmConsulta()
            f.TipoCarga = "CATEGORIA"
            f.ShowDialog()

            If f.DialogResult = DialogResult.OK Then
                txtid.Text = f.SelectedID
                CargarCategoriaPorID(CInt(f.SelectedID))
            End If

        Catch ex As Exception
            MessageBox.Show("Error al abrir la consulta: " & ex.Message)
        End Try
    End Sub

    ' CARGAR UNA CATEGORÍA POR ID
    Private Sub CargarCategoriaPorID(id As Integer)
        Try
            conexion.Open()
            Dim sql As String = "SELECT nombre_categoria FROM categorias WHERE id_categoria = @id"
            Dim cmd As New MySqlCommand(sql, conexion)
            cmd.Parameters.AddWithValue("@id", id)
            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            If dr.Read() Then
                txtid.Text = id.ToString()
                txtnombre.Text = dr("nombre_categoria").ToString()
            End If

        Catch ex As Exception
            MessageBox.Show("Error al cargar categoría: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    ' ACTUALIZAR CATEGORÍA
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles bntactualizar.Click
        Try
            If txtid.Text = "" Then
                MessageBox.Show("Por favor ingresa el ID de la categoría a actualizar.")
                Return
            End If

            conexion.Open()
            Dim cmd As New MySqlCommand("UPDATE categorias SET nombre_categoria=@nombre WHERE id_categoria=@id", conexion)
            cmd.Parameters.AddWithValue("@nombre", txtnombre.Text)
            cmd.Parameters.AddWithValue("@id", txtid.Text)

            Dim filas As Integer = cmd.ExecuteNonQuery()
            If filas > 0 Then
                MessageBox.Show("Categoría actualizada correctamente.")
            Else
                MessageBox.Show("No se encontró la categoría con ese ID.")
            End If

            LimpiarCampos()

        Catch ex As MySqlException
            MessageBox.Show("Error al actualizar categoría: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    ' ELIMINAR CATEGORÍA
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles bnteliminar.Click
        Try
            If txtid.Text = "" Then
                MessageBox.Show("Por favor ingresa el ID de la categoría a eliminar.")
                Return
            End If

            conexion.Open()
            Dim cmd As New MySqlCommand("DELETE FROM categorias WHERE id_categoria=@id", conexion)
            cmd.Parameters.AddWithValue("@id", txtid.Text)
            Dim filas As Integer = cmd.ExecuteNonQuery()

            If filas > 0 Then
                MessageBox.Show("Categoría eliminada correctamente.")
            Else
                MessageBox.Show("No se encontró la categoría con ese ID.")
            End If

            LimpiarCampos()

        Catch ex As MySqlException
            MessageBox.Show("Error al eliminar categoría: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    ' LIMPIAR CAMPOS
    Private Sub LimpiarCampos()
        txtid.Clear()
        txtnombre.Clear()
    End Sub

End Class
