<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addcategoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addcategoria))
        txtid = New TextBox()
        txtnombre = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        bntadd = New PictureBox()
        bntconsultar = New PictureBox()
        bntactualizar = New PictureBox()
        bnteliminar = New PictureBox()
        CType(bntadd, ComponentModel.ISupportInitialize).BeginInit()
        CType(bntconsultar, ComponentModel.ISupportInitialize).BeginInit()
        CType(bntactualizar, ComponentModel.ISupportInitialize).BeginInit()
        CType(bnteliminar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtid
        ' 
        txtid.Location = New Point(29, 85)
        txtid.Name = "txtid"
        txtid.Size = New Size(150, 31)
        txtid.TabIndex = 0
        ' 
        ' txtnombre
        ' 
        txtnombre.Location = New Point(29, 162)
        txtnombre.Name = "txtnombre"
        txtnombre.Size = New Size(150, 31)
        txtnombre.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(29, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(148, 28)
        Label1.TabIndex = 2
        Label1.Text = "Identificacion"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(29, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 28)
        Label2.TabIndex = 3
        Label2.Text = "nombre"
        ' 
        ' bntadd
        ' 
        bntadd.Image = CType(resources.GetObject("bntadd.Image"), Image)
        bntadd.Location = New Point(29, 10)
        bntadd.Name = "bntadd"
        bntadd.Size = New Size(16, 16)
        bntadd.SizeMode = PictureBoxSizeMode.AutoSize
        bntadd.TabIndex = 4
        bntadd.TabStop = False
        ' 
        ' bntconsultar
        ' 
        bntconsultar.Image = CType(resources.GetObject("bntconsultar.Image"), Image)
        bntconsultar.Location = New Point(58, 10)
        bntconsultar.Name = "bntconsultar"
        bntconsultar.Size = New Size(16, 16)
        bntconsultar.SizeMode = PictureBoxSizeMode.AutoSize
        bntconsultar.TabIndex = 5
        bntconsultar.TabStop = False
        ' 
        ' bntactualizar
        ' 
        bntactualizar.Image = CType(resources.GetObject("bntactualizar.Image"), Image)
        bntactualizar.Location = New Point(86, 10)
        bntactualizar.Name = "bntactualizar"
        bntactualizar.Size = New Size(16, 16)
        bntactualizar.SizeMode = PictureBoxSizeMode.AutoSize
        bntactualizar.TabIndex = 6
        bntactualizar.TabStop = False
        ' 
        ' bnteliminar
        ' 
        bnteliminar.Image = CType(resources.GetObject("bnteliminar.Image"), Image)
        bnteliminar.Location = New Point(112, 10)
        bnteliminar.Name = "bnteliminar"
        bnteliminar.Size = New Size(16, 16)
        bnteliminar.SizeMode = PictureBoxSizeMode.AutoSize
        bnteliminar.TabIndex = 7
        bnteliminar.TabStop = False
        ' 
        ' addcategoria
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(209, 245)
        Controls.Add(bnteliminar)
        Controls.Add(bntactualizar)
        Controls.Add(bntconsultar)
        Controls.Add(bntadd)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtnombre)
        Controls.Add(txtid)
        Name = "addcategoria"
        StartPosition = FormStartPosition.CenterScreen
        Text = "addcategoria"
        CType(bntadd, ComponentModel.ISupportInitialize).EndInit()
        CType(bntconsultar, ComponentModel.ISupportInitialize).EndInit()
        CType(bntactualizar, ComponentModel.ISupportInitialize).EndInit()
        CType(bnteliminar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtid As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents bntadd As PictureBox
    Friend WithEvents bntconsultar As PictureBox
    Friend WithEvents bntactualizar As PictureBox
    Friend WithEvents bnteliminar As PictureBox
End Class
