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
        Ptbretroceder = New PictureBox()
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
        bntagregar = New PictureBox()
        bnteliminar = New PictureBox()
        bntactualizar = New PictureBox()
        bntbuscar = New PictureBox()
        Textnombrearti = New TextBox()
        Label9 = New Label()
        bntlimpiar = New PictureBox()
        CType(Ptbretroceder, ComponentModel.ISupportInitialize).BeginInit()
        CType(bntadd, ComponentModel.ISupportInitialize).BeginInit()
        CType(bntagregar, ComponentModel.ISupportInitialize).BeginInit()
        CType(bnteliminar, ComponentModel.ISupportInitialize).BeginInit()
        CType(bntactualizar, ComponentModel.ISupportInitialize).BeginInit()
        CType(bntbuscar, ComponentModel.ISupportInitialize).BeginInit()
        CType(bntlimpiar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Ptbretroceder
        ' 
        Ptbretroceder.BackColor = Color.Transparent
        Ptbretroceder.Image = CType(resources.GetObject("Ptbretroceder.Image"), Image)
        Ptbretroceder.Location = New Point(29, 12)
        Ptbretroceder.Name = "Ptbretroceder"
        Ptbretroceder.Size = New Size(16, 16)
        Ptbretroceder.SizeMode = PictureBoxSizeMode.AutoSize
        Ptbretroceder.TabIndex = 0
        Ptbretroceder.TabStop = False
        ' 
        ' txtid
        ' 
        txtid.BackColor = SystemColors.ButtonHighlight
        txtid.CausesValidation = False
        txtid.ImeMode = ImeMode.NoControl
        txtid.Location = New Point(31, 101)
        txtid.Name = "txtid"
        txtid.Size = New Size(100, 31)
        txtid.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(31, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 25)
        Label1.TabIndex = 4
        Label1.Text = "id_articulo"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(31, 285)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 25)
        Label3.TabIndex = 6
        Label3.Text = "Descripcion"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(321, 61)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 25)
        Label4.TabIndex = 7
        Label4.Text = "Precio"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.ActiveCaptionText
        Label5.Location = New Point(31, 142)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 25)
        Label5.TabIndex = 8
        Label5.Text = "Stock"
        ' 
        ' Texstock
        ' 
        Texstock.BackColor = SystemColors.ButtonHighlight
        Texstock.Location = New Point(33, 170)
        Texstock.Name = "Texstock"
        Texstock.Size = New Size(107, 31)
        Texstock.TabIndex = 12
        ' 
        ' txtprecio
        ' 
        txtprecio.BackColor = SystemColors.ButtonHighlight
        txtprecio.CausesValidation = False
        txtprecio.ImeMode = ImeMode.NoControl
        txtprecio.Location = New Point(321, 101)
        txtprecio.Name = "txtprecio"
        txtprecio.Size = New Size(118, 31)
        txtprecio.TabIndex = 10
        ' 
        ' rtbdescripcion
        ' 
        rtbdescripcion.Location = New Point(170, 285)
        rtbdescripcion.Name = "rtbdescripcion"
        rtbdescripcion.Size = New Size(368, 105)
        rtbdescripcion.TabIndex = 13
        rtbdescripcion.Text = ""
        ' 
        ' Cmbcategoria
        ' 
        Cmbcategoria.ForeColor = SystemColors.WindowText
        Cmbcategoria.FormattingEnabled = True
        Cmbcategoria.Location = New Point(170, 226)
        Cmbcategoria.Name = "Cmbcategoria"
        Cmbcategoria.Size = New Size(368, 33)
        Cmbcategoria.TabIndex = 15
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label7.ForeColor = SystemColors.ActiveCaptionText
        Label7.Location = New Point(31, 229)
        Label7.Name = "Label7"
        Label7.Size = New Size(107, 25)
        Label7.TabIndex = 17
        Label7.Text = "Categorias"
        ' 
        ' bntadd
        ' 
        bntadd.Image = CType(resources.GetObject("bntadd.Image"), Image)
        bntadd.Location = New Point(553, 235)
        bntadd.Name = "bntadd"
        bntadd.Size = New Size(16, 16)
        bntadd.SizeMode = PictureBoxSizeMode.AutoSize
        bntadd.TabIndex = 18
        bntadd.TabStop = False
        ' 
        ' txtdescuento
        ' 
        txtdescuento.BackColor = SystemColors.ButtonHighlight
        txtdescuento.Location = New Point(323, 170)
        txtdescuento.Name = "txtdescuento"
        txtdescuento.Size = New Size(116, 31)
        txtdescuento.TabIndex = 19
        ' 
        ' txtiva
        ' 
        txtiva.BackColor = SystemColors.ButtonHighlight
        txtiva.Location = New Point(170, 170)
        txtiva.Name = "txtiva"
        txtiva.Size = New Size(118, 31)
        txtiva.TabIndex = 20
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label6.ForeColor = SystemColors.ActiveCaptionText
        Label6.Location = New Point(321, 142)
        Label6.Name = "Label6"
        Label6.Size = New Size(105, 25)
        Label6.TabIndex = 21
        Label6.Text = "Descuento"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label8.ForeColor = SystemColors.ActiveCaptionText
        Label8.Location = New Point(170, 142)
        Label8.Name = "Label8"
        Label8.Size = New Size(45, 25)
        Label8.TabIndex = 22
        Label8.Text = "IVA"
        ' 
        ' bntagregar
        ' 
        bntagregar.Image = CType(resources.GetObject("bntagregar.Image"), Image)
        bntagregar.Location = New Point(60, 12)
        bntagregar.Name = "bntagregar"
        bntagregar.Size = New Size(16, 16)
        bntagregar.SizeMode = PictureBoxSizeMode.AutoSize
        bntagregar.TabIndex = 23
        bntagregar.TabStop = False
        ' 
        ' bnteliminar
        ' 
        bnteliminar.Image = CType(resources.GetObject("bnteliminar.Image"), Image)
        bnteliminar.Location = New Point(88, 12)
        bnteliminar.Name = "bnteliminar"
        bnteliminar.Size = New Size(16, 16)
        bnteliminar.SizeMode = PictureBoxSizeMode.AutoSize
        bnteliminar.TabIndex = 24
        bnteliminar.TabStop = False
        ' 
        ' bntactualizar
        ' 
        bntactualizar.Image = CType(resources.GetObject("bntactualizar.Image"), Image)
        bntactualizar.Location = New Point(117, 12)
        bntactualizar.Name = "bntactualizar"
        bntactualizar.Size = New Size(16, 16)
        bntactualizar.SizeMode = PictureBoxSizeMode.AutoSize
        bntactualizar.TabIndex = 25
        bntactualizar.TabStop = False
        ' 
        ' bntbuscar
        ' 
        bntbuscar.Image = CType(resources.GetObject("bntbuscar.Image"), Image)
        bntbuscar.Location = New Point(146, 11)
        bntbuscar.Name = "bntbuscar"
        bntbuscar.Size = New Size(16, 16)
        bntbuscar.SizeMode = PictureBoxSizeMode.AutoSize
        bntbuscar.TabIndex = 26
        bntbuscar.TabStop = False
        ' 
        ' Textnombrearti
        ' 
        Textnombrearti.BackColor = SystemColors.ButtonHighlight
        Textnombrearti.CausesValidation = False
        Textnombrearti.ImeMode = ImeMode.NoControl
        Textnombrearti.Location = New Point(170, 101)
        Textnombrearti.Name = "Textnombrearti"
        Textnombrearti.Size = New Size(118, 31)
        Textnombrearti.TabIndex = 28
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.ActiveCaptionText
        Label9.Location = New Point(170, 61)
        Label9.Name = "Label9"
        Label9.Size = New Size(85, 25)
        Label9.TabIndex = 27
        Label9.Text = "Nombre"
        ' 
        ' bntlimpiar
        ' 
        bntlimpiar.Image = CType(resources.GetObject("bntlimpiar.Image"), Image)
        bntlimpiar.Location = New Point(173, 11)
        bntlimpiar.Name = "bntlimpiar"
        bntlimpiar.Size = New Size(16, 16)
        bntlimpiar.SizeMode = PictureBoxSizeMode.AutoSize
        bntlimpiar.TabIndex = 29
        bntlimpiar.TabStop = False
        ' 
        ' articulos
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ScrollBar
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(599, 403)
        Controls.Add(bntlimpiar)
        Controls.Add(Textnombrearti)
        Controls.Add(Label9)
        Controls.Add(bntbuscar)
        Controls.Add(bntactualizar)
        Controls.Add(bnteliminar)
        Controls.Add(bntagregar)
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
        Controls.Add(Ptbretroceder)
        Name = "articulos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "articulos"
        CType(Ptbretroceder, ComponentModel.ISupportInitialize).EndInit()
        CType(bntadd, ComponentModel.ISupportInitialize).EndInit()
        CType(bntagregar, ComponentModel.ISupportInitialize).EndInit()
        CType(bnteliminar, ComponentModel.ISupportInitialize).EndInit()
        CType(bntactualizar, ComponentModel.ISupportInitialize).EndInit()
        CType(bntbuscar, ComponentModel.ISupportInitialize).EndInit()
        CType(bntlimpiar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Ptbretroceder As PictureBox
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
    Friend WithEvents bntagregar As PictureBox
    Friend WithEvents bnteliminar As PictureBox
    Friend WithEvents bntactualizar As PictureBox
    Friend WithEvents bntbuscar As PictureBox
    Friend WithEvents Textnombrearti As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents bntlimpiar As PictureBox
End Class
