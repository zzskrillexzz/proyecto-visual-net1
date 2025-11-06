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
        txtIdCliente = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        txtNombreCliente = New TextBox()
        TextBox5 = New TextBox()
        txtcorreo = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        grilla_inv = New DataGridView()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        DateTimePicker1 = New DateTimePicker()
        ptbreverse = New PictureBox()
        lblnumerofactura = New Label()
        RichTextBox1 = New RichTextBox()
        Label11 = New Label()
        StatusStrip1 = New StatusStrip()
        tssusuario = New ToolStripStatusLabel()
        CType(grilla_inv, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(ptbreverse, ComponentModel.ISupportInitialize).BeginInit()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtIdCliente
        ' 
        txtIdCliente.Location = New Point(178, 103)
        txtIdCliente.Name = "txtIdCliente"
        txtIdCliente.Size = New Size(178, 31)
        txtIdCliente.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(687, 446)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(150, 31)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(687, 592)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(150, 31)
        TextBox3.TabIndex = 3
        ' 
        ' txtNombreCliente
        ' 
        txtNombreCliente.Location = New Point(473, 103)
        txtNombreCliente.Name = "txtNombreCliente"
        txtNombreCliente.Size = New Size(364, 31)
        txtNombreCliente.TabIndex = 2
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(178, 161)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(278, 31)
        TextBox5.TabIndex = 5
        ' 
        ' txtcorreo
        ' 
        txtcorreo.AcceptsReturn = True
        txtcorreo.Location = New Point(576, 158)
        txtcorreo.Name = "txtcorreo"
        txtcorreo.Size = New Size(261, 31)
        txtcorreo.TabIndex = 4
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(687, 542)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(150, 31)
        TextBox7.TabIndex = 7
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(687, 495)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(150, 31)
        TextBox8.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.Location = New Point(29, 109)
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
        Label2.Location = New Point(367, 103)
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
        Label3.Location = New Point(29, 161)
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
        Label4.Location = New Point(487, 161)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 25)
        Label4.TabIndex = 11
        Label4.Text = "Correo"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label5.Location = New Point(585, 452)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 25)
        Label5.TabIndex = 12
        Label5.Text = "Subtotal"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label6.Location = New Point(585, 501)
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
        Label7.Location = New Point(522, 548)
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
        Label8.Location = New Point(549, 598)
        Label8.Name = "Label8"
        Label8.Size = New Size(120, 25)
        Label8.TabIndex = 15
        Label8.Text = "Total factura"
        ' 
        ' grilla_inv
        ' 
        grilla_inv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grilla_inv.Location = New Point(29, 207)
        grilla_inv.Name = "grilla_inv"
        grilla_inv.RowHeadersWidth = 62
        grilla_inv.Size = New Size(809, 225)
        grilla_inv.TabIndex = 16
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(58, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(16, 16)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(88, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(16, 16)
        PictureBox2.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox2.TabIndex = 18
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(118, 12)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(16, 16)
        PictureBox3.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox3.TabIndex = 19
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(148, 12)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(16, 16)
        PictureBox4.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox4.TabIndex = 20
        PictureBox4.TabStop = False
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(28, 56)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(328, 31)
        DateTimePicker1.TabIndex = 21
        ' 
        ' ptbreverse
        ' 
        ptbreverse.Image = CType(resources.GetObject("ptbreverse.Image"), Image)
        ptbreverse.Location = New Point(29, 12)
        ptbreverse.Name = "ptbreverse"
        ptbreverse.Size = New Size(16, 16)
        ptbreverse.SizeMode = PictureBoxSizeMode.AutoSize
        ptbreverse.TabIndex = 22
        ptbreverse.TabStop = False
        ' 
        ' lblnumerofactura
        ' 
        lblnumerofactura.AutoSize = True
        lblnumerofactura.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblnumerofactura.Location = New Point(720, 15)
        lblnumerofactura.Name = "lblnumerofactura"
        lblnumerofactura.Size = New Size(46, 54)
        lblnumerofactura.TabIndex = 24
        lblnumerofactura.Text = "1"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(28, 479)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(449, 144)
        RichTextBox1.TabIndex = 25
        RichTextBox1.Text = ""
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(29, 446)
        Label11.Name = "Label11"
        Label11.Size = New Size(142, 25)
        Label11.TabIndex = 26
        Label11.Text = "Observaciones"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(24, 24)
        StatusStrip1.Items.AddRange(New ToolStripItem() {tssusuario})
        StatusStrip1.Location = New Point(0, 645)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(864, 32)
        StatusStrip1.TabIndex = 27
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' tssusuario
        ' 
        tssusuario.Name = "tssusuario"
        tssusuario.Size = New Size(180, 25)
        tssusuario.Text = "ToolStripStatusLabel1"
        ' 
        ' factura
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(864, 677)
        Controls.Add(StatusStrip1)
        Controls.Add(Label11)
        Controls.Add(RichTextBox1)
        Controls.Add(lblnumerofactura)
        Controls.Add(ptbreverse)
        Controls.Add(DateTimePicker1)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(grilla_inv)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox7)
        Controls.Add(TextBox8)
        Controls.Add(TextBox5)
        Controls.Add(txtcorreo)
        Controls.Add(TextBox3)
        Controls.Add(txtNombreCliente)
        Controls.Add(TextBox2)
        Controls.Add(txtIdCliente)
        Name = "factura"
        StartPosition = FormStartPosition.CenterScreen
        Text = "factura"
        CType(grilla_inv, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(ptbreverse, ComponentModel.ISupportInitialize).EndInit()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents grilla_inv As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ptbreverse As PictureBox
    Friend WithEvents lblnumerofactura As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tssusuario As ToolStripStatusLabel
End Class
