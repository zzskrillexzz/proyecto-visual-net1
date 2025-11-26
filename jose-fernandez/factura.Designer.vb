<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class factura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(factura))
        txtIdCliented = New TextBox()
        txtTotal = New TextBox()
        txtNombreCliente = New TextBox()
        TextBox5 = New TextBox()
        txtcorreo = New TextBox()
        txtDesc = New TextBox()
        txtIva = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        grilla_inv = New DataGridView()
        DateTimePicker1 = New DateTimePicker()
        lblnumerofactura = New Label()
        RichTextBox1 = New RichTextBox()
        Label11 = New Label()
        StatusStrip1 = New StatusStrip()
        tssusuario = New ToolStripStatusLabel()
        ToolStrip1 = New ToolStrip()
        bntreverse = New ToolStripButton()
        bntagregar = New ToolStripButton()
        bntmodificar = New ToolStripButton()
        bnteliminar = New ToolStripButton()
        bnt = New ToolStripButton()
        ToolStripButton5 = New ToolStripButton()
        CType(grilla_inv, ComponentModel.ISupportInitialize).BeginInit()
        StatusStrip1.SuspendLayout()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtIdCliented
        ' 
        txtIdCliented.Location = New Point(178, 110)
        txtIdCliented.Name = "txtIdCliented"
        txtIdCliented.Size = New Size(178, 31)
        txtIdCliented.TabIndex = 2
        ' 
        ' txtTotal
        ' 
        txtTotal.Location = New Point(688, 583)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(150, 31)
        txtTotal.TabIndex = 9
        ' 
        ' txtNombreCliente
        ' 
        txtNombreCliente.Location = New Point(473, 110)
        txtNombreCliente.Name = "txtNombreCliente"
        txtNombreCliente.Size = New Size(364, 31)
        txtNombreCliente.TabIndex = 3
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(178, 168)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(278, 31)
        TextBox5.TabIndex = 4
        ' 
        ' txtcorreo
        ' 
        txtcorreo.AcceptsReturn = True
        txtcorreo.Location = New Point(576, 165)
        txtcorreo.Name = "txtcorreo"
        txtcorreo.Size = New Size(261, 31)
        txtcorreo.TabIndex = 5
        ' 
        ' txtDesc
        ' 
        txtDesc.Location = New Point(688, 533)
        txtDesc.Name = "txtDesc"
        txtDesc.Size = New Size(150, 31)
        txtDesc.TabIndex = 8
        ' 
        ' txtIva
        ' 
        txtIva.Location = New Point(688, 486)
        txtIva.Name = "txtIva"
        txtIva.Size = New Size(150, 31)
        txtIva.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.Location = New Point(29, 116)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 25)
        Label1.TabIndex = 8
        Label1.Text = "Identificacion"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.Location = New Point(367, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 25)
        Label2.TabIndex = 9
        Label2.Text = "Nombres"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.Location = New Point(29, 168)
        Label3.Name = "Label3"
        Label3.Size = New Size(125, 25)
        Label3.TabIndex = 10
        Label3.Text = "Razon  Social"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.Location = New Point(487, 168)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 25)
        Label4.TabIndex = 11
        Label4.Text = "Correo"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label6.Location = New Point(586, 492)
        Label6.Name = "Label6"
        Label6.Size = New Size(84, 25)
        Label6.TabIndex = 13
        Label6.Text = "Total iva"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label7.Location = New Point(523, 539)
        Label7.Name = "Label7"
        Label7.Size = New Size(147, 25)
        Label7.TabIndex = 14
        Label7.Text = "Total descuento"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label8.Location = New Point(550, 589)
        Label8.Name = "Label8"
        Label8.Size = New Size(120, 25)
        Label8.TabIndex = 15
        Label8.Text = "Total factura"
        ' 
        ' grilla_inv
        ' 
        grilla_inv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grilla_inv.Location = New Point(29, 214)
        grilla_inv.Name = "grilla_inv"
        grilla_inv.RowHeadersWidth = 62
        grilla_inv.Size = New Size(809, 225)
        grilla_inv.TabIndex = 6
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(28, 63)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(328, 31)
        DateTimePicker1.TabIndex = 1
        ' 
        ' lblnumerofactura
        ' 
        lblnumerofactura.AutoSize = True
        lblnumerofactura.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblnumerofactura.Location = New Point(567, 40)
        lblnumerofactura.Name = "lblnumerofactura"
        lblnumerofactura.Size = New Size(46, 54)
        lblnumerofactura.TabIndex = 24
        lblnumerofactura.Text = "1"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(28, 486)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(449, 144)
        RichTextBox1.TabIndex = 10
        RichTextBox1.Text = ""
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(29, 453)
        Label11.Name = "Label11"
        Label11.Size = New Size(142, 25)
        Label11.TabIndex = 26
        Label11.Text = "Observaciones"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(24, 24)
        StatusStrip1.Items.AddRange(New ToolStripItem() {tssusuario})
        StatusStrip1.Location = New Point(0, 662)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(871, 32)
        StatusStrip1.TabIndex = 27
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' tssusuario
        ' 
        tssusuario.Name = "tssusuario"
        tssusuario.Size = New Size(180, 25)
        tssusuario.Text = "ToolStripStatusLabel1"
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.ImageScalingSize = New Size(24, 24)
        ToolStrip1.Items.AddRange(New ToolStripItem() {bntreverse, bntagregar, bntmodificar, bnteliminar, bnt, ToolStripButton5})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(871, 33)
        ToolStrip1.TabIndex = 0
        ToolStrip1.TabStop = True
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' bntreverse
        ' 
        bntreverse.DisplayStyle = ToolStripItemDisplayStyle.Image
        bntreverse.Image = CType(resources.GetObject("bntreverse.Image"), Image)
        bntreverse.ImageTransparentColor = Color.Magenta
        bntreverse.Name = "bntreverse"
        bntreverse.Size = New Size(34, 28)
        bntreverse.Text = "ToolStripButton1"
        ' 
        ' bntagregar
        ' 
        bntagregar.DisplayStyle = ToolStripItemDisplayStyle.Image
        bntagregar.Image = CType(resources.GetObject("bntagregar.Image"), Image)
        bntagregar.ImageTransparentColor = Color.Magenta
        bntagregar.Name = "bntagregar"
        bntagregar.Size = New Size(34, 28)
        bntagregar.Text = "ToolStripButton1"
        ' 
        ' bntmodificar
        ' 
        bntmodificar.DisplayStyle = ToolStripItemDisplayStyle.Image
        bntmodificar.Image = CType(resources.GetObject("bntmodificar.Image"), Image)
        bntmodificar.ImageTransparentColor = Color.Magenta
        bntmodificar.Name = "bntmodificar"
        bntmodificar.Size = New Size(34, 28)
        bntmodificar.Text = "ToolStripButton2"
        ' 
        ' bnteliminar
        ' 
        bnteliminar.DisplayStyle = ToolStripItemDisplayStyle.Image
        bnteliminar.Image = CType(resources.GetObject("bnteliminar.Image"), Image)
        bnteliminar.ImageTransparentColor = Color.Magenta
        bnteliminar.Name = "bnteliminar"
        bnteliminar.Size = New Size(34, 28)
        bnteliminar.Text = "ToolStripButton4"
        ' 
        ' bnt
        ' 
        bnt.DisplayStyle = ToolStripItemDisplayStyle.Image
        bnt.Image = CType(resources.GetObject("bnt.Image"), Image)
        bnt.ImageTransparentColor = Color.Magenta
        bnt.Name = "bnt"
        bnt.Size = New Size(34, 28)
        bnt.Text = "ToolStripButton3"
        bnt.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ToolStripButton5
        ' 
        ToolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), Image)
        ToolStripButton5.ImageTransparentColor = Color.Magenta
        ToolStripButton5.Name = "ToolStripButton5"
        ToolStripButton5.Size = New Size(34, 28)
        ToolStripButton5.Text = "ToolStripButton5"
        ' 
        ' factura
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(871, 694)
        Controls.Add(ToolStrip1)
        Controls.Add(StatusStrip1)
        Controls.Add(Label11)
        Controls.Add(RichTextBox1)
        Controls.Add(lblnumerofactura)
        Controls.Add(DateTimePicker1)
        Controls.Add(grilla_inv)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtDesc)
        Controls.Add(txtIva)
        Controls.Add(TextBox5)
        Controls.Add(txtcorreo)
        Controls.Add(txtTotal)
        Controls.Add(txtNombreCliente)
        Controls.Add(txtIdCliented)
        Name = "factura"
        StartPosition = FormStartPosition.CenterScreen
        Text = "factura"
        CType(grilla_inv, ComponentModel.ISupportInitialize).EndInit()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtIdCliented As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents txtIva As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents grilla_inv As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblnumerofactura As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tssusuario As ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents bntreverse As ToolStripButton
    Friend WithEvents bnteliminar As ToolStripButton
    Friend WithEvents bnt As ToolStripButton
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents bntagregar As ToolStripButton
    Friend WithEvents bntmodificar As ToolStripButton
End Class
