<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usu_clien
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usu_clien))
        btnClien = New Button()
        btnUsu = New Button()
        Bntarticulos = New Button()
        bntfactura = New Button()
        SuspendLayout()
        ' 
        ' btnClien
        ' 
        btnClien.Location = New Point(204, 12)
        btnClien.Name = "btnClien"
        btnClien.Size = New Size(125, 73)
        btnClien.TabIndex = 2
        btnClien.Text = "Clientes"
        btnClien.UseVisualStyleBackColor = True
        ' 
        ' btnUsu
        ' 
        btnUsu.Location = New Point(54, 12)
        btnUsu.Name = "btnUsu"
        btnUsu.Size = New Size(122, 73)
        btnUsu.TabIndex = 1
        btnUsu.Text = "Usuarios"
        btnUsu.UseVisualStyleBackColor = True
        ' 
        ' Bntarticulos
        ' 
        Bntarticulos.Location = New Point(54, 106)
        Bntarticulos.Name = "Bntarticulos"
        Bntarticulos.Size = New Size(125, 73)
        Bntarticulos.TabIndex = 3
        Bntarticulos.Text = "Articulos"
        Bntarticulos.UseVisualStyleBackColor = True
        ' 
        ' bntfactura
        ' 
        bntfactura.Location = New Point(204, 107)
        bntfactura.Name = "bntfactura"
        bntfactura.Size = New Size(125, 70)
        bntfactura.TabIndex = 4
        bntfactura.Text = "Factura"
        bntfactura.UseVisualStyleBackColor = True
        ' 
        ' usu_clien
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(380, 206)
        Controls.Add(bntfactura)
        Controls.Add(Bntarticulos)
        Controls.Add(btnUsu)
        Controls.Add(btnClien)
        Name = "usu_clien"
        StartPosition = FormStartPosition.CenterScreen
        Text = "usu_clien"
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnClien As Button
    Friend WithEvents btnUsu As Button
    Friend WithEvents Bntarticulos As Button
    Friend WithEvents bntfactura As Button
End Class
