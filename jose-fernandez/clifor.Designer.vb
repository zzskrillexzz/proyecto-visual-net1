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
        Comboestado = New ComboBox()
        cmbMunicipios = New ComboBox()
        cmbDepartamentos = New ComboBox()
        Label6 = New Label()
        txtobservaciones = New RichTextBox()
        Textbuscador = New TextBox()
        Label3 = New Label()
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
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label8
        ' 
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label8.Location = New Point(5, 378)
        Label8.Name = "Label8"
        Label8.Size = New Size(115, 23)
        Label8.TabIndex = 76
        Label8.Text = "&Municipio"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label7.Location = New Point(4, 322)
        Label7.Name = "Label7"
        Label7.Size = New Size(141, 23)
        Label7.TabIndex = 75
        Label7.Text = "&Departamento"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label4.Location = New Point(7, 58)
        Label4.Name = "Label4"
        Label4.Size = New Size(35, 23)
        Label4.TabIndex = 74
        Label4.Text = "ID"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Comboestado
        ' 
        Comboestado.DropDownStyle = ComboBoxStyle.DropDownList
        Comboestado.FormattingEnabled = True
        Comboestado.Location = New Point(151, 264)
        Comboestado.Name = "Comboestado"
        Comboestado.Size = New Size(241, 33)
        Comboestado.TabIndex = 4
        ' 
        ' cmbMunicipios
        ' 
        cmbMunicipios.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMunicipios.FormattingEnabled = True
        cmbMunicipios.Location = New Point(151, 378)
        cmbMunicipios.Name = "cmbMunicipios"
        cmbMunicipios.Size = New Size(241, 33)
        cmbMunicipios.TabIndex = 6
        ' 
        ' cmbDepartamentos
        ' 
        cmbDepartamentos.DropDownStyle = ComboBoxStyle.DropDownList
        cmbDepartamentos.FormattingEnabled = True
        cmbDepartamentos.Location = New Point(151, 318)
        cmbDepartamentos.Name = "cmbDepartamentos"
        cmbDepartamentos.Size = New Size(241, 33)
        cmbDepartamentos.TabIndex = 5
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label6.Location = New Point(7, 439)
        Label6.Name = "Label6"
        Label6.Size = New Size(142, 23)
        Label6.TabIndex = 70
        Label6.Text = "&Observaciones"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtobservaciones
        ' 
        txtobservaciones.Location = New Point(9, 479)
        txtobservaciones.Name = "txtobservaciones"
        txtobservaciones.Size = New Size(379, 126)
        txtobservaciones.TabIndex = 7
        txtobservaciones.Text = ""
        ' 
        ' Textbuscador
        ' 
        Textbuscador.Location = New Point(181, 58)
        Textbuscador.Name = "Textbuscador"
        Textbuscador.Size = New Size(211, 31)
        Textbuscador.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label3.Location = New Point(5, 264)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 23)
        Label3.TabIndex = 65
        Label3.Text = "&Estado"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' correo
        ' 
        correo.Location = New Point(151, 214)
        correo.Name = "correo"
        correo.Size = New Size(241, 31)
        correo.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label2.Location = New Point(5, 214)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 23)
        Label2.TabIndex = 63
        Label2.Text = "&Correo"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' apelli
        ' 
        apelli.Location = New Point(151, 161)
        apelli.Name = "apelli"
        apelli.Size = New Size(241, 31)
        apelli.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label1.Location = New Point(6, 161)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 23)
        Label1.TabIndex = 61
        Label1.Text = "&Apellido"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UsernameTextBox
        ' 
        UsernameTextBox.Location = New Point(151, 110)
        UsernameTextBox.Name = "UsernameTextBox"
        UsernameTextBox.Size = New Size(241, 31)
        UsernameTextBox.TabIndex = 1
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.BackColor = Color.Transparent
        UsernameLabel.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        UsernameLabel.Location = New Point(6, 100)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(94, 23)
        UsernameLabel.TabIndex = 57
        UsernameLabel.Text = "&Nombre"
        UsernameLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LogoPictureBox
        ' 
        LogoPictureBox.BackColor = Color.Transparent
        LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), Image)
        LogoPictureBox.Location = New Point(148, 56)
        LogoPictureBox.Name = "LogoPictureBox"
        LogoPictureBox.Size = New Size(24, 24)
        LogoPictureBox.SizeMode = PictureBoxSizeMode.AutoSize
        LogoPictureBox.TabIndex = 56
        LogoPictureBox.TabStop = False
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.BackColor = Color.WhiteSmoke
        ToolStrip1.Items.AddRange(New ToolStripItem() {bntvolver, bntenviar, txtactuali, txteliminar, btnConsulta, bntlimpiar})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(404, 33)
        ToolStrip1.TabIndex = 83
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' bntvolver
        ' 
        bntvolver.DisplayStyle = ToolStripItemDisplayStyle.Image
        bntvolver.Image = CType(resources.GetObject("bntvolver.Image"), Image)
        bntvolver.ImageTransparentColor = Color.Magenta
        bntvolver.Name = "bntvolver"
        bntvolver.Size = New Size(34, 28)
        bntvolver.Text = "Volver"
        ' 
        ' bntenviar
        ' 
        bntenviar.BackColor = Color.Transparent
        bntenviar.DisplayStyle = ToolStripItemDisplayStyle.Image
        bntenviar.Image = CType(resources.GetObject("bntenviar.Image"), Image)
        bntenviar.ImageTransparentColor = Color.Magenta
        bntenviar.Name = "bntenviar"
        bntenviar.Size = New Size(34, 28)
        bntenviar.Text = "Agregar"
        ' 
        ' txtactuali
        ' 
        txtactuali.DisplayStyle = ToolStripItemDisplayStyle.Image
        txtactuali.Image = CType(resources.GetObject("txtactuali.Image"), Image)
        txtactuali.ImageTransparentColor = Color.Magenta
        txtactuali.Name = "txtactuali"
        txtactuali.Size = New Size(34, 28)
        txtactuali.Text = "Editar"
        ' 
        ' txteliminar
        ' 
        txteliminar.DisplayStyle = ToolStripItemDisplayStyle.Image
        txteliminar.Image = CType(resources.GetObject("txteliminar.Image"), Image)
        txteliminar.ImageTransparentColor = Color.Magenta
        txteliminar.Name = "txteliminar"
        txteliminar.Size = New Size(34, 28)
        txteliminar.Text = "Eliminar"
        ' 
        ' btnConsulta
        ' 
        btnConsulta.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnConsulta.Image = CType(resources.GetObject("btnConsulta.Image"), Image)
        btnConsulta.ImageTransparentColor = Color.Magenta
        btnConsulta.Name = "btnConsulta"
        btnConsulta.Size = New Size(34, 28)
        btnConsulta.Text = "Consultar"
        ' 
        ' bntlimpiar
        ' 
        bntlimpiar.DisplayStyle = ToolStripItemDisplayStyle.Image
        bntlimpiar.Image = CType(resources.GetObject("bntlimpiar.Image"), Image)
        bntlimpiar.ImageTransparentColor = Color.Magenta
        bntlimpiar.Name = "bntlimpiar"
        bntlimpiar.Size = New Size(34, 28)
        bntlimpiar.Text = "Limpiar"
        ' 
        ' clifor
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ScrollBar
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(404, 617)
        Controls.Add(ToolStrip1)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label4)
        Controls.Add(Comboestado)
        Controls.Add(cmbMunicipios)
        Controls.Add(cmbDepartamentos)
        Controls.Add(Label6)
        Controls.Add(txtobservaciones)
        Controls.Add(Textbuscador)
        Controls.Add(Label3)
        Controls.Add(correo)
        Controls.Add(Label2)
        Controls.Add(apelli)
        Controls.Add(Label1)
        Controls.Add(UsernameTextBox)
        Controls.Add(UsernameLabel)
        Controls.Add(LogoPictureBox)
        Name = "clifor"
        StartPosition = FormStartPosition.CenterScreen
        Text = "clifor"
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).EndInit()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Comboestado As ComboBox
    Friend WithEvents cmbMunicipios As ComboBox
    Friend WithEvents cmbDepartamentos As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtobservaciones As RichTextBox
    Friend WithEvents Textbuscador As TextBox
    Friend WithEvents Label3 As Label
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
End Class
