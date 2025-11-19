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
        bntvolver = New PictureBox()
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
        contra = New TextBox()
        UsernameTextBox = New TextBox()
        PasswordLabel = New Label()
        UsernameLabel = New Label()
        LogoPictureBox = New PictureBox()
        bntcancelar = New PictureBox()
        txteliminar = New PictureBox()
        txtactuali = New PictureBox()
        btnConsulta = New PictureBox()
        bntenviar = New PictureBox()
        CType(bntvolver, ComponentModel.ISupportInitialize).BeginInit()
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(bntcancelar, ComponentModel.ISupportInitialize).BeginInit()
        CType(txteliminar, ComponentModel.ISupportInitialize).BeginInit()
        CType(txtactuali, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnConsulta, ComponentModel.ISupportInitialize).BeginInit()
        CType(bntenviar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' bntvolver
        ' 
        bntvolver.BackColor = Color.Transparent
        bntvolver.Image = CType(resources.GetObject("bntvolver.Image"), Image)
        bntvolver.Location = New Point(9, 12)
        bntvolver.Name = "bntvolver"
        bntvolver.Size = New Size(16, 16)
        bntvolver.SizeMode = PictureBoxSizeMode.AutoSize
        bntvolver.TabIndex = 55
        bntvolver.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label8.Location = New Point(5, 449)
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
        Label7.Location = New Point(4, 393)
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
        Label4.Location = New Point(12, 71)
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
        Comboestado.Location = New Point(151, 335)
        Comboestado.Name = "Comboestado"
        Comboestado.Size = New Size(241, 33)
        Comboestado.TabIndex = 73
        ' 
        ' cmbMunicipios
        ' 
        cmbMunicipios.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMunicipios.FormattingEnabled = True
        cmbMunicipios.Location = New Point(151, 449)
        cmbMunicipios.Name = "cmbMunicipios"
        cmbMunicipios.Size = New Size(241, 33)
        cmbMunicipios.TabIndex = 72
        ' 
        ' cmbDepartamentos
        ' 
        cmbDepartamentos.DropDownStyle = ComboBoxStyle.DropDownList
        cmbDepartamentos.FormattingEnabled = True
        cmbDepartamentos.Location = New Point(151, 389)
        cmbDepartamentos.Name = "cmbDepartamentos"
        cmbDepartamentos.Size = New Size(241, 33)
        cmbDepartamentos.TabIndex = 71
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label6.Location = New Point(7, 534)
        Label6.Name = "Label6"
        Label6.Size = New Size(142, 23)
        Label6.TabIndex = 70
        Label6.Text = "&Observaciones"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtobservaciones
        ' 
        txtobservaciones.Location = New Point(9, 574)
        txtobservaciones.Name = "txtobservaciones"
        txtobservaciones.Size = New Size(379, 126)
        txtobservaciones.TabIndex = 69
        txtobservaciones.Text = ""
        ' 
        ' Textbuscador
        ' 
        Textbuscador.Location = New Point(181, 71)
        Textbuscador.Name = "Textbuscador"
        Textbuscador.Size = New Size(211, 31)
        Textbuscador.TabIndex = 66
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label3.Location = New Point(5, 335)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 23)
        Label3.TabIndex = 65
        Label3.Text = "&Estado"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' correo
        ' 
        correo.Location = New Point(151, 285)
        correo.Name = "correo"
        correo.Size = New Size(241, 31)
        correo.TabIndex = 64
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label2.Location = New Point(5, 285)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 23)
        Label2.TabIndex = 63
        Label2.Text = "&Correo"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' apelli
        ' 
        apelli.Location = New Point(151, 174)
        apelli.Name = "apelli"
        apelli.Size = New Size(241, 31)
        apelli.TabIndex = 62
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label1.Location = New Point(6, 174)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 23)
        Label1.TabIndex = 61
        Label1.Text = "&Apellido"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' contra
        ' 
        contra.Location = New Point(151, 232)
        contra.Name = "contra"
        contra.PasswordChar = "*"c
        contra.Size = New Size(241, 31)
        contra.TabIndex = 60
        ' 
        ' UsernameTextBox
        ' 
        UsernameTextBox.Location = New Point(151, 123)
        UsernameTextBox.Name = "UsernameTextBox"
        UsernameTextBox.Size = New Size(241, 31)
        UsernameTextBox.TabIndex = 58
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.BackColor = Color.Transparent
        PasswordLabel.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        PasswordLabel.Location = New Point(6, 231)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(114, 23)
        PasswordLabel.TabIndex = 59
        PasswordLabel.Text = "&Contraseña"
        PasswordLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.BackColor = Color.Transparent
        UsernameLabel.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        UsernameLabel.Location = New Point(6, 113)
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
        LogoPictureBox.Location = New Point(148, 69)
        LogoPictureBox.Name = "LogoPictureBox"
        LogoPictureBox.Size = New Size(24, 24)
        LogoPictureBox.SizeMode = PictureBoxSizeMode.AutoSize
        LogoPictureBox.TabIndex = 56
        LogoPictureBox.TabStop = False
        ' 
        ' bntcancelar
        ' 
        bntcancelar.Image = CType(resources.GetObject("bntcancelar.Image"), Image)
        bntcancelar.Location = New Point(179, 12)
        bntcancelar.Name = "bntcancelar"
        bntcancelar.Size = New Size(16, 16)
        bntcancelar.SizeMode = PictureBoxSizeMode.AutoSize
        bntcancelar.TabIndex = 81
        bntcancelar.TabStop = False
        ' 
        ' txteliminar
        ' 
        txteliminar.Image = CType(resources.GetObject("txteliminar.Image"), Image)
        txteliminar.Location = New Point(147, 12)
        txteliminar.Name = "txteliminar"
        txteliminar.Size = New Size(16, 16)
        txteliminar.SizeMode = PictureBoxSizeMode.AutoSize
        txteliminar.TabIndex = 80
        txteliminar.TabStop = False
        ' 
        ' txtactuali
        ' 
        txtactuali.Image = CType(resources.GetObject("txtactuali.Image"), Image)
        txtactuali.Location = New Point(115, 12)
        txtactuali.Name = "txtactuali"
        txtactuali.Size = New Size(16, 16)
        txtactuali.SizeMode = PictureBoxSizeMode.AutoSize
        txtactuali.TabIndex = 79
        txtactuali.TabStop = False
        ' 
        ' btnConsulta
        ' 
        btnConsulta.Image = CType(resources.GetObject("btnConsulta.Image"), Image)
        btnConsulta.Location = New Point(84, 12)
        btnConsulta.Name = "btnConsulta"
        btnConsulta.Size = New Size(16, 16)
        btnConsulta.SizeMode = PictureBoxSizeMode.AutoSize
        btnConsulta.TabIndex = 78
        btnConsulta.TabStop = False
        ' 
        ' bntenviar
        ' 
        bntenviar.Image = CType(resources.GetObject("bntenviar.Image"), Image)
        bntenviar.Location = New Point(52, 12)
        bntenviar.Name = "bntenviar"
        bntenviar.Size = New Size(16, 16)
        bntenviar.SizeMode = PictureBoxSizeMode.AutoSize
        bntenviar.TabIndex = 77
        bntenviar.TabStop = False
        ' 
        ' clifor
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ScrollBar
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(434, 766)
        Controls.Add(bntcancelar)
        Controls.Add(txteliminar)
        Controls.Add(txtactuali)
        Controls.Add(btnConsulta)
        Controls.Add(bntenviar)
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
        Controls.Add(contra)
        Controls.Add(UsernameTextBox)
        Controls.Add(PasswordLabel)
        Controls.Add(UsernameLabel)
        Controls.Add(LogoPictureBox)
        Controls.Add(bntvolver)
        Name = "clifor"
        StartPosition = FormStartPosition.CenterScreen
        Text = "clifor"
        CType(bntvolver, ComponentModel.ISupportInitialize).EndInit()
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).EndInit()
        CType(bntcancelar, ComponentModel.ISupportInitialize).EndInit()
        CType(txteliminar, ComponentModel.ISupportInitialize).EndInit()
        CType(txtactuali, ComponentModel.ISupportInitialize).EndInit()
        CType(btnConsulta, ComponentModel.ISupportInitialize).EndInit()
        CType(bntenviar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents bntvolver As PictureBox
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
    Friend WithEvents contra As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents bntcancelar As PictureBox
    Friend WithEvents txteliminar As PictureBox
    Friend WithEvents txtactuali As PictureBox
    Friend WithEvents btnConsulta As PictureBox
    Friend WithEvents bntenviar As PictureBox
End Class
