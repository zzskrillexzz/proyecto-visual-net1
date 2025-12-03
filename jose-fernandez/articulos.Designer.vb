<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class articulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(articulos))
        txtid = New TextBox()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Texstock = New TextBox()
        txtprecio = New TextBox()
        rtbdescripcion = New RichTextBox()
        Cmbcategoria = New ComboBox()
        Label7 = New Label()
        bntadd = New PictureBox()
        txtdescuento = New TextBox()
        txtiva = New TextBox()
        Label6 = New Label()
        Label8 = New Label()
        Textnombrearti = New TextBox()
        Label9 = New Label()
        ToolStrip1 = New ToolStrip()
        Ptbretroceder = New ToolStripButton()
        bntagregar = New ToolStripButton()
        bnteliminar = New ToolStripButton()
        bntbuscar = New ToolStripButton()
        bntlimpiar = New ToolStripButton()
        bntactualizar = New ToolStripButton()
        CType(bntadd, ComponentModel.ISupportInitialize).BeginInit()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtid
        ' 
        txtid.BackColor = SystemColors.ButtonHighlight
        txtid.CausesValidation = False
        txtid.ImeMode = ImeMode.NoControl
        txtid.Location = New Point(13, 50)
        txtid.Margin = New Padding(2, 2, 2, 2)
        txtid.Name = "txtid"
        txtid.Size = New Size(87, 23)
        txtid.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(13, 33)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 15)
        Label1.TabIndex = 4
        Label1.Text = "id_articulo"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(13, 160)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 15)
        Label3.TabIndex = 6
        Label3.Text = "Descripcion"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(274, 32)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(45, 15)
        Label4.TabIndex = 7
        Label4.Text = "Precio"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.ActiveCaptionText
        Label5.Location = New Point(13, 74)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(40, 15)
        Label5.TabIndex = 8
        Label5.Text = "Stock"
        ' 
        ' Texstock
        ' 
        Texstock.BackColor = SystemColors.ButtonHighlight
        Texstock.Location = New Point(13, 91)
        Texstock.Margin = New Padding(2, 2, 2, 2)
        Texstock.Name = "Texstock"
        Texstock.Size = New Size(87, 23)
        Texstock.TabIndex = 4
        ' 
        ' txtprecio
        ' 
        txtprecio.BackColor = SystemColors.ButtonHighlight
        txtprecio.CausesValidation = False
        txtprecio.ImeMode = ImeMode.NoControl
        txtprecio.Location = New Point(274, 49)
        txtprecio.Margin = New Padding(2, 2, 2, 2)
        txtprecio.Name = "txtprecio"
        txtprecio.Size = New Size(95, 23)
        txtprecio.TabIndex = 3
        ' 
        ' rtbdescripcion
        ' 
        rtbdescripcion.Location = New Point(110, 160)
        rtbdescripcion.Margin = New Padding(2, 2, 2, 2)
        rtbdescripcion.Name = "rtbdescripcion"
        rtbdescripcion.Size = New Size(259, 65)
        rtbdescripcion.TabIndex = 8
        rtbdescripcion.Text = ""
        ' 
        ' Cmbcategoria
        ' 
        Cmbcategoria.DropDownStyle = ComboBoxStyle.DropDownList
        Cmbcategoria.ForeColor = SystemColors.WindowText
        Cmbcategoria.FormattingEnabled = True
        Cmbcategoria.Location = New Point(110, 125)
        Cmbcategoria.Margin = New Padding(2, 2, 2, 2)
        Cmbcategoria.Name = "Cmbcategoria"
        Cmbcategoria.Size = New Size(259, 23)
        Cmbcategoria.TabIndex = 7
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label7.ForeColor = SystemColors.ActiveCaptionText
        Label7.Location = New Point(13, 127)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(72, 15)
        Label7.TabIndex = 17
        Label7.Text = "Categorias"
        ' 
        ' bntadd
        ' 
        bntadd.Image = CType(resources.GetObject("bntadd.Image"), Image)
        bntadd.Location = New Point(377, 130)
        bntadd.Margin = New Padding(2, 2, 2, 2)
        bntadd.Name = "bntadd"
        bntadd.Size = New Size(16, 16)
        bntadd.SizeMode = PictureBoxSizeMode.AutoSize
        bntadd.TabIndex = 18
        bntadd.TabStop = False
        ' 
        ' txtdescuento
        ' 
        txtdescuento.BackColor = SystemColors.ButtonHighlight
        txtdescuento.Location = New Point(274, 91)
        txtdescuento.Margin = New Padding(2, 2, 2, 2)
        txtdescuento.Name = "txtdescuento"
        txtdescuento.Size = New Size(94, 23)
        txtdescuento.TabIndex = 6
        txtdescuento.Text = "0"
        ' 
        ' txtiva
        ' 
        txtiva.BackColor = SystemColors.ButtonHighlight
        txtiva.Location = New Point(135, 91)
        txtiva.Margin = New Padding(2, 2, 2, 2)
        txtiva.Name = "txtiva"
        txtiva.Size = New Size(103, 23)
        txtiva.TabIndex = 5
        txtiva.Text = "19"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label6.ForeColor = SystemColors.ActiveCaptionText
        Label6.Location = New Point(274, 74)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(71, 15)
        Label6.TabIndex = 21
        Label6.Text = "Descuento"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label8.ForeColor = SystemColors.ActiveCaptionText
        Label8.Location = New Point(136, 74)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(28, 15)
        Label8.TabIndex = 22
        Label8.Text = "IVA"
        ' 
        ' Textnombrearti
        ' 
        Textnombrearti.BackColor = SystemColors.ButtonHighlight
        Textnombrearti.CausesValidation = False
        Textnombrearti.ImeMode = ImeMode.NoControl
        Textnombrearti.Location = New Point(135, 50)
        Textnombrearti.Margin = New Padding(2, 2, 2, 2)
        Textnombrearti.Name = "Textnombrearti"
        Textnombrearti.Size = New Size(103, 23)
        Textnombrearti.TabIndex = 2
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.ActiveCaptionText
        Label9.Location = New Point(135, 33)
        Label9.Margin = New Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(56, 15)
        Label9.TabIndex = 27
        Label9.Text = "Nombre"
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Items.AddRange(New ToolStripItem() {bntagregar, bntactualizar, bnteliminar, bntbuscar, bntlimpiar, Ptbretroceder})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Padding = New Padding(0, 0, 2, 0)
        ToolStrip1.Size = New Size(394, 25)
        ToolStrip1.TabIndex = 9
        ToolStrip1.TabStop = True
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' Ptbretroceder
        ' 
        Ptbretroceder.DisplayStyle = ToolStripItemDisplayStyle.Image
        Ptbretroceder.Image = CType(resources.GetObject("Ptbretroceder.Image"), Image)
        Ptbretroceder.ImageTransparentColor = Color.Magenta
        Ptbretroceder.Name = "Ptbretroceder"
        Ptbretroceder.Size = New Size(23, 22)
        Ptbretroceder.Text = "Volver"
        ' 
        ' bntagregar
        ' 
        bntagregar.DisplayStyle = ToolStripItemDisplayStyle.Image
        bntagregar.Image = CType(resources.GetObject("bntagregar.Image"), Image)
        bntagregar.ImageTransparentColor = Color.Magenta
        bntagregar.Name = "bntagregar"
        bntagregar.Size = New Size(23, 22)
        bntagregar.Text = "Agregar"
        ' 
        ' bnteliminar
        ' 
        bnteliminar.DisplayStyle = ToolStripItemDisplayStyle.Image
        bnteliminar.Image = CType(resources.GetObject("bnteliminar.Image"), Image)
        bnteliminar.ImageTransparentColor = Color.Magenta
        bnteliminar.Name = "bnteliminar"
        bnteliminar.Size = New Size(23, 22)
        bnteliminar.Text = "Eliminar"
        ' 
        ' bntbuscar
        ' 
        bntbuscar.DisplayStyle = ToolStripItemDisplayStyle.Image
        bntbuscar.Image = CType(resources.GetObject("bntbuscar.Image"), Image)
        bntbuscar.ImageTransparentColor = Color.Magenta
        bntbuscar.Name = "bntbuscar"
        bntbuscar.Size = New Size(23, 22)
        bntbuscar.Text = "Consultar"
        ' 
        ' bntlimpiar
        ' 
        bntlimpiar.DisplayStyle = ToolStripItemDisplayStyle.Image
        bntlimpiar.Image = CType(resources.GetObject("bntlimpiar.Image"), Image)
        bntlimpiar.ImageTransparentColor = Color.Magenta
        bntlimpiar.Name = "bntlimpiar"
        bntlimpiar.Size = New Size(23, 22)
        bntlimpiar.Text = "Limpiar"
        ' 
        ' bntactualizar
        ' 
        bntactualizar.DisplayStyle = ToolStripItemDisplayStyle.Image
        bntactualizar.Image = CType(resources.GetObject("bntactualizar.Image"), Image)
        bntactualizar.ImageTransparentColor = Color.Magenta
        bntactualizar.Name = "bntactualizar"
        bntactualizar.Size = New Size(23, 22)
        bntactualizar.Text = "Editar"
        ' 
        ' articulos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ScrollBar
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(394, 251)
        Controls.Add(ToolStrip1)
        Controls.Add(Textnombrearti)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label6)
        Controls.Add(txtiva)
        Controls.Add(txtdescuento)
        Controls.Add(bntadd)
        Controls.Add(Label7)
        Controls.Add(Cmbcategoria)
        Controls.Add(rtbdescripcion)
        Controls.Add(Texstock)
        Controls.Add(txtprecio)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(txtid)
        Margin = New Padding(2, 2, 2, 2)
        Name = "articulos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "articulos"
        CType(bntadd, ComponentModel.ISupportInitialize).EndInit()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Texstock As TextBox
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents rtbdescripcion As RichTextBox
    Friend WithEvents Cmbcategoria As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents bntadd As PictureBox
    Friend WithEvents txtdescuento As TextBox
    Friend WithEvents txtiva As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Textnombrearti As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents bntagregar As ToolStripButton
    Friend WithEvents bnteliminar As ToolStripButton
    Friend WithEvents bntbuscar As ToolStripButton
    Friend WithEvents bntlimpiar As ToolStripButton
    Friend WithEvents bntactualizar As ToolStripButton
    Friend WithEvents Ptbretroceder As ToolStripButton
End Class
