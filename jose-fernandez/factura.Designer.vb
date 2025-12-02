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
        txtcorreo = New TextBox()
        txtDesc = New TextBox()
        txtIva = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        grilla_inv = New DataGridView()
        DateTimePicker1 = New DateTimePicker()
        RichTextBox1 = New RichTextBox()
        Label11 = New Label()
        ingresos = New StatusStrip()
        ingresonombre = New ToolStripStatusLabel()
        ToolStrip1 = New ToolStrip()
        bntreverse = New ToolStripButton()
        bntagregar = New ToolStripButton()
        bntmodificar = New ToolStripButton()
        bnteliminar = New ToolStripButton()
        buscar = New ToolStripSplitButton()
        ArticulosToolStripMenuItem = New ToolStripMenuItem()
        ClientesToolStripMenuItem = New ToolStripMenuItem()
        limpiar = New ToolStripButton()
        lblnumerofactura = New Label()
        Label3 = New Label()
        rsocial = New TextBox()
        CType(grilla_inv, ComponentModel.ISupportInitialize).BeginInit()
        ingresos.SuspendLayout()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtIdCliented
        ' 
        txtIdCliented.Location = New Point(125, 66)
        txtIdCliented.Margin = New Padding(2, 2, 2, 2)
        txtIdCliented.Name = "txtIdCliented"
        txtIdCliented.Size = New Size(126, 23)
        txtIdCliented.TabIndex = 2
        ' 
        ' txtTotal
        ' 
        txtTotal.Location = New Point(646, 346)
        txtTotal.Margin = New Padding(2, 2, 2, 2)
        txtTotal.Name = "txtTotal"
        txtTotal.ReadOnly = True
        txtTotal.Size = New Size(106, 23)
        txtTotal.TabIndex = 9
        ' 
        ' txtNombreCliente
        ' 
        txtNombreCliente.Location = New Point(331, 66)
        txtNombreCliente.Margin = New Padding(2, 2, 2, 2)
        txtNombreCliente.Name = "txtNombreCliente"
        txtNombreCliente.Size = New Size(421, 23)
        txtNombreCliente.TabIndex = 3
        ' 
        ' txtcorreo
        ' 
        txtcorreo.AcceptsReturn = True
        txtcorreo.Location = New Point(125, 99)
        txtcorreo.Margin = New Padding(2, 2, 2, 2)
        txtcorreo.Name = "txtcorreo"
        txtcorreo.Size = New Size(243, 23)
        txtcorreo.TabIndex = 5
        ' 
        ' txtDesc
        ' 
        txtDesc.Location = New Point(646, 316)
        txtDesc.Margin = New Padding(2, 2, 2, 2)
        txtDesc.Name = "txtDesc"
        txtDesc.ReadOnly = True
        txtDesc.Size = New Size(106, 23)
        txtDesc.TabIndex = 8
        ' 
        ' txtIva
        ' 
        txtIva.Location = New Point(646, 288)
        txtIva.Margin = New Padding(2, 2, 2, 2)
        txtIva.Name = "txtIva"
        txtIva.ReadOnly = True
        txtIva.Size = New Size(106, 23)
        txtIva.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.Location = New Point(20, 70)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 15)
        Label1.TabIndex = 8
        Label1.Text = "Identificacion"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.Location = New Point(257, 66)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 15)
        Label2.TabIndex = 9
        Label2.Text = "Nombres"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.Location = New Point(20, 103)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(45, 15)
        Label4.TabIndex = 11
        Label4.Text = "Correo"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label6.Location = New Point(574, 291)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 15)
        Label6.TabIndex = 13
        Label6.Text = "Total iva"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label7.Location = New Point(530, 319)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(95, 15)
        Label7.TabIndex = 14
        Label7.Text = "Total descuento"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label8.Location = New Point(549, 349)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(77, 15)
        Label8.TabIndex = 15
        Label8.Text = "Total factura"
        ' 
        ' grilla_inv
        ' 
        grilla_inv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grilla_inv.Location = New Point(20, 128)
        grilla_inv.Margin = New Padding(2, 2, 2, 2)
        grilla_inv.Name = "grilla_inv"
        grilla_inv.RowHeadersWidth = 62
        grilla_inv.Size = New Size(732, 135)
        grilla_inv.TabIndex = 6
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(20, 38)
        DateTimePicker1.Margin = New Padding(2, 2, 2, 2)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(231, 23)
        DateTimePicker1.TabIndex = 1
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(20, 292)
        RichTextBox1.Margin = New Padding(2, 2, 2, 2)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(506, 88)
        RichTextBox1.TabIndex = 10
        RichTextBox1.Text = ""
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(20, 272)
        Label11.Margin = New Padding(2, 0, 2, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(95, 15)
        Label11.TabIndex = 26
        Label11.Text = "Observaciones"
        ' 
        ' ingresos
        ' 
        ingresos.ImageScalingSize = New Size(24, 24)
        ingresos.Items.AddRange(New ToolStripItem() {ingresonombre})
        ingresos.Location = New Point(0, 394)
        ingresos.Name = "ingresos"
        ingresos.Padding = New Padding(1, 0, 10, 0)
        ingresos.Size = New Size(763, 22)
        ingresos.TabIndex = 27
        ingresos.Text = "StatusStrip1"
        ' 
        ' ingresonombre
        ' 
        ingresonombre.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        ingresonombre.Font = New Font("Cooper Black", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ingresonombre.Name = "ingresonombre"
        ingresonombre.Size = New Size(39, 17)
        ingresonombre.Text = "User"
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.ImageScalingSize = New Size(20, 20)
        ToolStrip1.Items.AddRange(New ToolStripItem() {bntreverse, bntagregar, bntmodificar, bnteliminar, buscar, limpiar})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Padding = New Padding(0, 0, 2, 0)
        ToolStrip1.Size = New Size(763, 27)
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
        bntreverse.Size = New Size(24, 24)
        bntreverse.Text = "Volver"
        bntreverse.ToolTipText = "volver"
        ' 
        ' bntagregar
        ' 
        bntagregar.DisplayStyle = ToolStripItemDisplayStyle.Image
        bntagregar.Image = CType(resources.GetObject("bntagregar.Image"), Image)
        bntagregar.ImageTransparentColor = Color.Magenta
        bntagregar.Name = "bntagregar"
        bntagregar.Size = New Size(24, 24)
        bntagregar.Text = "Agregar"
        bntagregar.ToolTipText = "agregar"
        ' 
        ' bntmodificar
        ' 
        bntmodificar.DisplayStyle = ToolStripItemDisplayStyle.Image
        bntmodificar.Image = CType(resources.GetObject("bntmodificar.Image"), Image)
        bntmodificar.ImageTransparentColor = Color.Magenta
        bntmodificar.Name = "bntmodificar"
        bntmodificar.Size = New Size(24, 24)
        bntmodificar.Text = "Editar"
        ' 
        ' bnteliminar
        ' 
        bnteliminar.DisplayStyle = ToolStripItemDisplayStyle.Image
        bnteliminar.Image = CType(resources.GetObject("bnteliminar.Image"), Image)
        bnteliminar.ImageTransparentColor = Color.Magenta
        bnteliminar.Name = "bnteliminar"
        bnteliminar.Size = New Size(24, 24)
        bnteliminar.Text = "Eliminar"
        ' 
        ' buscar
        ' 
        buscar.DisplayStyle = ToolStripItemDisplayStyle.Image
        buscar.DropDownItems.AddRange(New ToolStripItem() {ArticulosToolStripMenuItem, ClientesToolStripMenuItem})
        buscar.Image = CType(resources.GetObject("buscar.Image"), Image)
        buscar.ImageTransparentColor = Color.Magenta
        buscar.Name = "buscar"
        buscar.Size = New Size(36, 24)
        buscar.Text = "Consultar"
        ' 
        ' ArticulosToolStripMenuItem
        ' 
        ArticulosToolStripMenuItem.Name = "ArticulosToolStripMenuItem"
        ArticulosToolStripMenuItem.Size = New Size(121, 22)
        ArticulosToolStripMenuItem.Text = "Artículos"
        ' 
        ' ClientesToolStripMenuItem
        ' 
        ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        ClientesToolStripMenuItem.Size = New Size(121, 22)
        ClientesToolStripMenuItem.Text = "Clientes"
        ' 
        ' limpiar
        ' 
        limpiar.DisplayStyle = ToolStripItemDisplayStyle.Image
        limpiar.Image = CType(resources.GetObject("limpiar.Image"), Image)
        limpiar.ImageTransparentColor = Color.Magenta
        limpiar.Name = "limpiar"
        limpiar.Size = New Size(24, 24)
        limpiar.Text = "Limpiar"
        ' 
        ' lblnumerofactura
        ' 
        lblnumerofactura.AutoSize = True
        lblnumerofactura.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblnumerofactura.Location = New Point(397, 24)
        lblnumerofactura.Margin = New Padding(2, 0, 2, 0)
        lblnumerofactura.Name = "lblnumerofactura"
        lblnumerofactura.Size = New Size(33, 37)
        lblnumerofactura.TabIndex = 24
        lblnumerofactura.Text = "1"
        lblnumerofactura.Visible = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.Location = New Point(372, 102)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 15)
        Label3.TabIndex = 29
        Label3.Text = "Razon Social"
        ' 
        ' rsocial
        ' 
        rsocial.AcceptsReturn = True
        rsocial.Location = New Point(452, 99)
        rsocial.Margin = New Padding(2)
        rsocial.Name = "rsocial"
        rsocial.Size = New Size(300, 23)
        rsocial.TabIndex = 28
        ' 
        ' factura
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(763, 416)
        Controls.Add(Label3)
        Controls.Add(rsocial)
        Controls.Add(ToolStrip1)
        Controls.Add(ingresos)
        Controls.Add(Label11)
        Controls.Add(RichTextBox1)
        Controls.Add(lblnumerofactura)
        Controls.Add(DateTimePicker1)
        Controls.Add(grilla_inv)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtDesc)
        Controls.Add(txtIva)
        Controls.Add(txtcorreo)
        Controls.Add(txtTotal)
        Controls.Add(txtNombreCliente)
        Controls.Add(txtIdCliented)
        Margin = New Padding(2, 2, 2, 2)
        Name = "factura"
        StartPosition = FormStartPosition.CenterScreen
        Text = "factura"
        CType(grilla_inv, ComponentModel.ISupportInitialize).EndInit()
        ingresos.ResumeLayout(False)
        ingresos.PerformLayout()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtIdCliented As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents txtIva As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents grilla_inv As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ingresos As StatusStrip
    Friend WithEvents ingresonombre As ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents bntreverse As ToolStripButton
    Friend WithEvents bnteliminar As ToolStripButton
    Friend WithEvents limpiar As ToolStripButton
    Friend WithEvents bntagregar As ToolStripButton
    Friend WithEvents bntmodificar As ToolStripButton
    Friend WithEvents lblnumerofactura As Label
    Friend WithEvents buscar As ToolStripSplitButton
    Friend WithEvents ArticulosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents rsocial As TextBox
End Class
