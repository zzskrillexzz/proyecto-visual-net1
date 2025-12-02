<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clifor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clifor))
        Label8 = New Label()
        Label7 = New Label()
        Label4 = New Label()
        cmbMunicipios = New ComboBox()
        cmbDepartamentos = New ComboBox()
        Label6 = New Label()
        txtobservaciones = New RichTextBox()
        Textbuscador = New TextBox()
        correo = New TextBox()
        Label2 = New Label()
        apelli = New TextBox()
        Label1 = New Label()
        UsernameTextBox = New TextBox()
        UsernameLabel = New Label()
        LogoPictureBox = New PictureBox()
        ToolStrip1 = New ToolStrip()
        bntvolver = New ToolStripButton()
        bntenviar = New ToolStripButton()
        txtactuali = New ToolStripButton()
        txteliminar = New ToolStripButton()
        btnConsulta = New ToolStripButton()
        bntlimpiar = New ToolStripButton()
        btndesbloquearcli = New ToolStripButton()
        ingresos = New StatusStrip()
        ingresonombre = New ToolStripStatusLabel()
        rsocial = New TextBox()
        Label3 = New Label()
        apelli2 = New TextBox()
        Label5 = New Label()
        UsernameTextBox2 = New TextBox()
        Label9 = New Label()
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        ToolStrip1.SuspendLayout()
        ingresos.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label8
        ' 
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label8.Location = New Point(8, 270)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(80, 14)
        Label8.TabIndex = 76
        Label8.Text = "&Municipio"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label7.Location = New Point(7, 236)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(99, 14)
        Label7.TabIndex = 75
        Label7.Text = "&Departamento"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label4.Location = New Point(5, 35)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(24, 14)
        Label4.TabIndex = 74
        Label4.Text = "ID"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cmbMunicipios
        ' 
        cmbMunicipios.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMunicipios.FormattingEnabled = True
        cmbMunicipios.Location = New Point(134, 270)
        cmbMunicipios.Margin = New Padding(2, 2, 2, 2)
        cmbMunicipios.Name = "cmbMunicipios"
        cmbMunicipios.Size = New Size(170, 23)
        cmbMunicipios.TabIndex = 7
        ' 
        ' cmbDepartamentos
        ' 
        cmbDepartamentos.DropDownStyle = ComboBoxStyle.DropDownList
        cmbDepartamentos.FormattingEnabled = True
        cmbDepartamentos.Location = New Point(134, 234)
        cmbDepartamentos.Margin = New Padding(2, 2, 2, 2)
        cmbDepartamentos.Name = "cmbDepartamentos"
        cmbDepartamentos.Size = New Size(170, 23)
        cmbDepartamentos.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label6.Location = New Point(10, 333)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(99, 14)
        Label6.TabIndex = 70
        Label6.Text = "&Observaciones"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtobservaciones
        ' 
        txtobservaciones.Location = New Point(4, 357)
        txtobservaciones.Margin = New Padding(2, 2, 2, 2)
        txtobservaciones.Name = "txtobservaciones"
        txtobservaciones.Size = New Size(300, 77)
        txtobservaciones.TabIndex = 9
        txtobservaciones.Text = ""
        ' 
        ' Textbuscador
        ' 
        Textbuscador.Location = New Point(127, 35)
        Textbuscador.Margin = New Padding(2, 2, 2, 2)
        Textbuscador.Name = "Textbuscador"
        Textbuscador.Size = New Size(149, 23)
        Textbuscador.TabIndex = 0
        ' 
        ' correo
        ' 
        correo.Location = New Point(134, 204)
        correo.Margin = New Padding(2, 2, 2, 2)
        correo.Name = "correo"
        correo.Size = New Size(170, 23)
        correo.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label2.Location = New Point(8, 204)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 14)
        Label2.TabIndex = 63
        Label2.Text = "&Correo"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' apelli
        ' 
        apelli.Location = New Point(134, 130)
        apelli.Margin = New Padding(2, 2, 2, 2)
        apelli.Name = "apelli"
        apelli.Size = New Size(170, 23)
        apelli.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label1.Location = New Point(7, 139)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 15)
        Label1.TabIndex = 61
        Label1.Text = "&Primer Apellido"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UsernameTextBox
        ' 
        UsernameTextBox.Location = New Point(134, 66)
        UsernameTextBox.Margin = New Padding(2, 2, 2, 2)
        UsernameTextBox.Name = "UsernameTextBox"
        UsernameTextBox.Size = New Size(170, 23)
        UsernameTextBox.TabIndex = 1
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.AutoSize = True
        UsernameLabel.BackColor = Color.Transparent
        UsernameLabel.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        UsernameLabel.Location = New Point(4, 75)
        UsernameLabel.Margin = New Padding(2, 0, 2, 0)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(99, 15)
        UsernameLabel.TabIndex = 57
        UsernameLabel.Text = "&Primer Nombre"
        UsernameLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LogoPictureBox
        ' 
        LogoPictureBox.BackColor = Color.Transparent
        LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), Image)
        LogoPictureBox.Location = New Point(104, 34)
        LogoPictureBox.Margin = New Padding(2, 2, 2, 2)
        LogoPictureBox.Name = "LogoPictureBox"
        LogoPictureBox.Size = New Size(24, 24)
        LogoPictureBox.SizeMode = PictureBoxSizeMode.AutoSize
        LogoPictureBox.TabIndex = 56
        LogoPictureBox.TabStop = False
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.BackColor = Color.WhiteSmoke
        ToolStrip1.Items.AddRange(New ToolStripItem() {bntvolver, bntenviar, txtactuali, txteliminar, btnConsulta, bntlimpiar, btndesbloquearcli})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(315, 25)
        ToolStrip1.TabIndex = 20
        ToolStrip1.TabStop = True
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' bntvolver
        ' 
        bntvolver.DisplayStyle = ToolStripItemDisplayStyle.Image
        bntvolver.Image = CType(resources.GetObject("bntvolver.Image"), Image)
        bntvolver.ImageTransparentColor = Color.Magenta
        bntvolver.Name = "bntvolver"
        bntvolver.Size = New Size(23, 22)
        bntvolver.Text = "Volver"
        ' 
        ' bntenviar
        ' 
        bntenviar.BackColor = Color.Transparent
        bntenviar.DisplayStyle = ToolStripItemDisplayStyle.Image
        bntenviar.Image = CType(resources.GetObject("bntenviar.Image"), Image)
        bntenviar.ImageTransparentColor = Color.Magenta
        bntenviar.Name = "bntenviar"
        bntenviar.Size = New Size(23, 22)
        bntenviar.Text = "Agregar"
        ' 
        ' txtactuali
        ' 
        txtactuali.DisplayStyle = ToolStripItemDisplayStyle.Image
        txtactuali.Image = CType(resources.GetObject("txtactuali.Image"), Image)
        txtactuali.ImageTransparentColor = Color.Magenta
        txtactuali.Name = "txtactuali"
        txtactuali.Size = New Size(23, 22)
        txtactuali.Text = "Editar"
        ' 
        ' txteliminar
        ' 
        txteliminar.DisplayStyle = ToolStripItemDisplayStyle.Image
        txteliminar.Image = CType(resources.GetObject("txteliminar.Image"), Image)
        txteliminar.ImageTransparentColor = Color.Magenta
        txteliminar.Name = "txteliminar"
        txteliminar.Size = New Size(23, 22)
        txteliminar.Text = "Eliminar"
        ' 
        ' btnConsulta
        ' 
        btnConsulta.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnConsulta.Image = CType(resources.GetObject("btnConsulta.Image"), Image)
        btnConsulta.ImageTransparentColor = Color.Magenta
        btnConsulta.Name = "btnConsulta"
        btnConsulta.Size = New Size(23, 22)
        btnConsulta.Text = "Consultar"
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
        ' btndesbloquearcli
        ' 
        btndesbloquearcli.DisplayStyle = ToolStripItemDisplayStyle.Image
        btndesbloquearcli.Image = CType(resources.GetObject("btndesbloquearcli.Image"), Image)
        btndesbloquearcli.ImageTransparentColor = Color.Magenta
        btndesbloquearcli.Name = "btndesbloquearcli"
        btndesbloquearcli.Size = New Size(23, 22)
        btndesbloquearcli.Text = "ToolStripButton1"
        btndesbloquearcli.Visible = False
        ' 
        ' ingresos
        ' 
        ingresos.ImageScalingSize = New Size(24, 24)
        ingresos.Items.AddRange(New ToolStripItem() {ingresonombre})
        ingresos.Location = New Point(0, 455)
        ingresos.Name = "ingresos"
        ingresos.Padding = New Padding(1, 0, 10, 0)
        ingresos.Size = New Size(315, 22)
        ingresos.TabIndex = 77
        ingresos.Text = "StatusStrip1"
        ' 
        ' ingresonombre
        ' 
        ingresonombre.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        ingresonombre.Font = New Font("Cooper Black", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ingresonombre.Name = "ingresonombre"
        ingresonombre.Size = New Size(39, 17)
        ingresonombre.Text = "User"
        ' 
        ' rsocial
        ' 
        rsocial.Location = New Point(134, 300)
        rsocial.Margin = New Padding(2)
        rsocial.Name = "rsocial"
        rsocial.Size = New Size(170, 23)
        rsocial.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label3.Location = New Point(8, 304)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 15)
        Label3.TabIndex = 79
        Label3.Text = "&Razon Social"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' apelli2
        ' 
        apelli2.Location = New Point(134, 166)
        apelli2.Margin = New Padding(2)
        apelli2.Name = "apelli2"
        apelli2.Size = New Size(170, 23)
        apelli2.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label5.Location = New Point(8, 175)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(116, 15)
        Label5.TabIndex = 81
        Label5.Text = "&Segundo Apellido"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UsernameTextBox2
        ' 
        UsernameTextBox2.Location = New Point(134, 98)
        UsernameTextBox2.Margin = New Padding(2)
        UsernameTextBox2.Name = "UsernameTextBox2"
        UsernameTextBox2.Size = New Size(170, 23)
        UsernameTextBox2.TabIndex = 2
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label9.Location = New Point(5, 102)
        Label9.Margin = New Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(113, 15)
        Label9.TabIndex = 83
        Label9.Text = "&Segundo Nombre"
        Label9.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' clifor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ScrollBar
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(315, 477)
        Controls.Add(UsernameTextBox2)
        Controls.Add(Label9)
        Controls.Add(apelli2)
        Controls.Add(Label5)
        Controls.Add(rsocial)
        Controls.Add(Label3)
        Controls.Add(ingresos)
        Controls.Add(ToolStrip1)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label4)
        Controls.Add(cmbMunicipios)
        Controls.Add(cmbDepartamentos)
        Controls.Add(Label6)
        Controls.Add(txtobservaciones)
        Controls.Add(Textbuscador)
        Controls.Add(correo)
        Controls.Add(Label2)
        Controls.Add(apelli)
        Controls.Add(Label1)
        Controls.Add(UsernameTextBox)
        Controls.Add(UsernameLabel)
        Controls.Add(LogoPictureBox)
        Margin = New Padding(2, 2, 2, 2)
        Name = "clifor"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cliente"
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).EndInit()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ingresos.ResumeLayout(False)
        ingresos.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbMunicipios As ComboBox
    Friend WithEvents cmbDepartamentos As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtobservaciones As RichTextBox
    Friend WithEvents Textbuscador As TextBox
    Friend WithEvents correo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents apelli As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents bntvolver As ToolStripButton
    Friend WithEvents bntenviar As ToolStripButton
    Friend WithEvents txtactuali As ToolStripButton
    Friend WithEvents txteliminar As ToolStripButton
    Friend WithEvents btnConsulta As ToolStripButton
    Friend WithEvents bntlimpiar As ToolStripButton
    Friend WithEvents btndesbloquearcli As ToolStripButton
    Friend WithEvents ingresos As StatusStrip
    Friend WithEvents ingresonombre As ToolStripStatusLabel
    Friend WithEvents rsocial As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents apelli2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents UsernameTextBox2 As TextBox
    Friend WithEvents Label9 As Label
End Class
