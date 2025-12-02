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
        ToolStrip1 = New ToolStrip()
        bntadd = New ToolStripButton()
        bntconsultar = New ToolStripButton()
        bntactualizar = New ToolStripButton()
        bnteliminar = New ToolStripButton()
        bntlimpiar = New ToolStripButton()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtid
        ' 
        txtid.Location = New Point(57, 82)
        txtid.Name = "txtid"
        txtid.Size = New Size(150, 31)
        txtid.TabIndex = 0
        ' 
        ' txtnombre
        ' 
        txtnombre.Location = New Point(57, 154)
        txtnombre.Name = "txtnombre"
        txtnombre.Size = New Size(150, 31)
        txtnombre.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(57, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(148, 28)
        Label1.TabIndex = 2
        Label1.Text = "Identificacion"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(57, 123)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 28)
        Label2.TabIndex = 3
        Label2.Text = "nombre"
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.ImageScalingSize = New Size(24, 24)
        ToolStrip1.Items.AddRange(New ToolStripItem() {bntadd, bntconsultar, bntactualizar, bnteliminar, bntlimpiar})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(264, 33)
        ToolStrip1.TabIndex = 2
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' bntadd
        ' 
        bntadd.DisplayStyle = ToolStripItemDisplayStyle.Image
        bntadd.Image = CType(resources.GetObject("bntadd.Image"), Image)
        bntadd.ImageTransparentColor = Color.Magenta
        bntadd.Name = "bntadd"
        bntadd.Size = New Size(34, 28)
        bntadd.Text = "Agregar"
        ' 
        ' bntconsultar
        ' 
        bntconsultar.DisplayStyle = ToolStripItemDisplayStyle.Image
        bntconsultar.Image = CType(resources.GetObject("bntconsultar.Image"), Image)
        bntconsultar.ImageTransparentColor = Color.Magenta
        bntconsultar.Name = "bntconsultar"
        bntconsultar.Size = New Size(34, 28)
        bntconsultar.Text = "Consultar"
        ' 
        ' bntactualizar
        ' 
        bntactualizar.DisplayStyle = ToolStripItemDisplayStyle.Image
        bntactualizar.Image = CType(resources.GetObject("bntactualizar.Image"), Image)
        bntactualizar.ImageTransparentColor = Color.Magenta
        bntactualizar.Name = "bntactualizar"
        bntactualizar.Size = New Size(34, 28)
        bntactualizar.Text = "Editar"
        ' 
        ' bnteliminar
        ' 
        bnteliminar.DisplayStyle = ToolStripItemDisplayStyle.Image
        bnteliminar.Image = CType(resources.GetObject("bnteliminar.Image"), Image)
        bnteliminar.ImageTransparentColor = Color.Magenta
        bnteliminar.Name = "bnteliminar"
        bnteliminar.Size = New Size(34, 28)
        bnteliminar.Text = "Eliminar"
        ' 
        ' bntlimpiar
        ' 
        bntlimpiar.DisplayStyle = ToolStripItemDisplayStyle.Image
        bntlimpiar.Image = CType(resources.GetObject("bntlimpiar.Image"), Image)
        bntlimpiar.ImageTransparentColor = Color.Magenta
        bntlimpiar.Name = "bntlimpiar"
        bntlimpiar.Size = New Size(34, 28)
        bntlimpiar.Text = "Limpiar"
        bntlimpiar.ToolTipText = "Limpiar"
        ' 
        ' addcategoria
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(264, 201)
        Controls.Add(ToolStrip1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtnombre)
        Controls.Add(txtid)
        Name = "addcategoria"
        StartPosition = FormStartPosition.CenterScreen
        Text = "addcategoria"
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtid As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents bntadd As ToolStripButton
    Friend WithEvents bntconsultar As ToolStripButton
    Friend WithEvents bntactualizar As ToolStripButton
    Friend WithEvents bnteliminar As ToolStripButton
    Friend WithEvents bntlimpiar As ToolStripButton
End Class
