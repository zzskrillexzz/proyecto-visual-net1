<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class forregistro
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents contra As System.Windows.Forms.TextBox
    Friend WithEvents bntenviard As System.Windows.Forms.Button
    Friend WithEvents bntcancelard As System.Windows.Forms.Button

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(forregistro))
        LogoPictureBox = New PictureBox()
        UsernameLabel = New Label()
        PasswordLabel = New Label()
        UsernameTextBox = New TextBox()
        contra = New TextBox()
        apelli = New TextBox()
        Label1 = New Label()
        correo = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Textbuscador = New TextBox()
        Comborol = New ComboBox()
        Label5 = New Label()
        txtobservaciones = New RichTextBox()
        Label6 = New Label()
        cmbDepartamentos = New ComboBox()
        cmbMunicipios = New ComboBox()
        Comboestado = New ComboBox()
        Label4 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Ptbvolver = New PictureBox()
        bntnewcontra = New PictureBox()
        bntenviar = New PictureBox()
        btnConsulta = New PictureBox()
        txtactuali = New PictureBox()
        txteliminar = New PictureBox()
        bntcancelar = New PictureBox()
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(Ptbvolver, ComponentModel.ISupportInitialize).BeginInit()
        CType(bntnewcontra, ComponentModel.ISupportInitialize).BeginInit()
        CType(bntenviar, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnConsulta, ComponentModel.ISupportInitialize).BeginInit()
        CType(txtactuali, ComponentModel.ISupportInitialize).BeginInit()
        CType(txteliminar, ComponentModel.ISupportInitialize).BeginInit()
        CType(bntcancelar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LogoPictureBox
        ' 
        LogoPictureBox.BackColor = Color.Transparent
        LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), Image)
        LogoPictureBox.Location = New Point(149, 69)
        LogoPictureBox.Name = "LogoPictureBox"
        LogoPictureBox.Size = New Size(24, 24)
        LogoPictureBox.SizeMode = PictureBoxSizeMode.AutoSize
        LogoPictureBox.TabIndex = 0
        LogoPictureBox.TabStop = False
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.BackColor = Color.Transparent
        UsernameLabel.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        UsernameLabel.Location = New Point(9, 117)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(94, 23)
        UsernameLabel.TabIndex = 0
        UsernameLabel.Text = "&Nombre"
        UsernameLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.BackColor = Color.Transparent
        PasswordLabel.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        PasswordLabel.Location = New Point(9, 235)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(114, 23)
        PasswordLabel.TabIndex = 2
        PasswordLabel.Text = "&Contraseña"
        PasswordLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UsernameTextBox
        ' 
        UsernameTextBox.Location = New Point(151, 124)
        UsernameTextBox.Name = "UsernameTextBox"
        UsernameTextBox.Size = New Size(243, 32)
        UsernameTextBox.TabIndex = 1
        ' 
        ' contra
        ' 
        contra.Location = New Point(151, 236)
        contra.Name = "contra"
        contra.PasswordChar = "*"c
        contra.Size = New Size(242, 32)
        contra.TabIndex = 3
        ' 
        ' apelli
        ' 
        apelli.Location = New Point(151, 178)
        apelli.Name = "apelli"
        apelli.Size = New Size(242, 32)
        apelli.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label1.Location = New Point(9, 178)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 23)
        Label1.TabIndex = 6
        Label1.Text = "&Apellido"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' correo
        ' 
        correo.Location = New Point(151, 295)
        correo.Name = "correo"
        correo.Size = New Size(242, 32)
        correo.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label2.Location = New Point(8, 295)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 23)
        Label2.TabIndex = 8
        Label2.Text = "&Correo"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label3.Location = New Point(7, 406)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 23)
        Label3.TabIndex = 10
        Label3.Text = "&Estado"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Textbuscador
        ' 
        Textbuscador.Location = New Point(181, 70)
        Textbuscador.Name = "Textbuscador"
        Textbuscador.Size = New Size(212, 32)
        Textbuscador.TabIndex = 16
        ' 
        ' Comborol
        ' 
        Comborol.FormattingEnabled = True
        Comborol.Location = New Point(151, 349)
        Comborol.Name = "Comborol"
        Comborol.Size = New Size(242, 33)
        Comborol.TabIndex = 18
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label5.Location = New Point(8, 349)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 23)
        Label5.TabIndex = 19
        Label5.Text = "&Rol"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtobservaciones
        ' 
        txtobservaciones.Location = New Point(12, 604)
        txtobservaciones.Name = "txtobservaciones"
        txtobservaciones.Size = New Size(386, 129)
        txtobservaciones.TabIndex = 20
        txtobservaciones.Text = ""
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label6.Location = New Point(10, 572)
        Label6.Name = "Label6"
        Label6.Size = New Size(142, 23)
        Label6.TabIndex = 21
        Label6.Text = "&Observaciones"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cmbDepartamentos
        ' 
        cmbDepartamentos.FormattingEnabled = True
        cmbDepartamentos.Location = New Point(151, 465)
        cmbDepartamentos.Name = "cmbDepartamentos"
        cmbDepartamentos.Size = New Size(243, 33)
        cmbDepartamentos.TabIndex = 22
        ' 
        ' cmbMunicipios
        ' 
        cmbMunicipios.FormattingEnabled = True
        cmbMunicipios.Location = New Point(151, 520)
        cmbMunicipios.Name = "cmbMunicipios"
        cmbMunicipios.Size = New Size(243, 33)
        cmbMunicipios.TabIndex = 23
        ' 
        ' Comboestado
        ' 
        Comboestado.FormattingEnabled = True
        Comboestado.Location = New Point(151, 406)
        Comboestado.Name = "Comboestado"
        Comboestado.Size = New Size(242, 33)
        Comboestado.TabIndex = 24
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label4.Location = New Point(10, 74)
        Label4.Name = "Label4"
        Label4.Size = New Size(35, 23)
        Label4.TabIndex = 39
        Label4.Text = "ID"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label8
        ' 
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label8.Location = New Point(6, 520)
        Label8.Name = "Label8"
        Label8.Size = New Size(115, 23)
        Label8.TabIndex = 52
        Label8.Text = "&Municipio"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label7.Location = New Point(3, 465)
        Label7.Name = "Label7"
        Label7.Size = New Size(141, 23)
        Label7.TabIndex = 51
        Label7.Text = "&Departamento"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Ptbvolver
        ' 
        Ptbvolver.BackColor = Color.Transparent
        Ptbvolver.Image = CType(resources.GetObject("Ptbvolver.Image"), Image)
        Ptbvolver.Location = New Point(7, 12)
        Ptbvolver.Name = "Ptbvolver"
        Ptbvolver.Size = New Size(16, 16)
        Ptbvolver.SizeMode = PictureBoxSizeMode.AutoSize
        Ptbvolver.TabIndex = 54
        Ptbvolver.TabStop = False
        ' 
        ' bntnewcontra
        ' 
        bntnewcontra.BackColor = Color.Transparent
        bntnewcontra.Image = CType(resources.GetObject("bntnewcontra.Image"), Image)
        bntnewcontra.Location = New Point(408, 238)
        bntnewcontra.Name = "bntnewcontra"
        bntnewcontra.Size = New Size(16, 16)
        bntnewcontra.SizeMode = PictureBoxSizeMode.AutoSize
        bntnewcontra.TabIndex = 55
        bntnewcontra.TabStop = False
        ' 
        ' bntenviar
        ' 
        bntenviar.Image = CType(resources.GetObject("bntenviar.Image"), Image)
        bntenviar.Location = New Point(38, 12)
        bntenviar.Name = "bntenviar"
        bntenviar.Size = New Size(16, 16)
        bntenviar.SizeMode = PictureBoxSizeMode.AutoSize
        bntenviar.TabIndex = 56
        bntenviar.TabStop = False
        ' 
        ' btnConsulta
        ' 
        btnConsulta.Image = CType(resources.GetObject("btnConsulta.Image"), Image)
        btnConsulta.Location = New Point(70, 12)
        btnConsulta.Name = "btnConsulta"
        btnConsulta.Size = New Size(16, 16)
        btnConsulta.SizeMode = PictureBoxSizeMode.AutoSize
        btnConsulta.TabIndex = 57
        btnConsulta.TabStop = False
        ' 
        ' txtactuali
        ' 
        txtactuali.Image = CType(resources.GetObject("txtactuali.Image"), Image)
        txtactuali.Location = New Point(101, 12)
        txtactuali.Name = "txtactuali"
        txtactuali.Size = New Size(16, 16)
        txtactuali.SizeMode = PictureBoxSizeMode.AutoSize
        txtactuali.TabIndex = 58
        txtactuali.TabStop = False
        ' 
        ' txteliminar
        ' 
        txteliminar.Image = CType(resources.GetObject("txteliminar.Image"), Image)
        txteliminar.Location = New Point(133, 12)
        txteliminar.Name = "txteliminar"
        txteliminar.Size = New Size(16, 16)
        txteliminar.SizeMode = PictureBoxSizeMode.AutoSize
        txteliminar.TabIndex = 59
        txteliminar.TabStop = False
        ' 
        ' bntcancelar
        ' 
        bntcancelar.Image = CType(resources.GetObject("bntcancelar.Image"), Image)
        bntcancelar.Location = New Point(165, 12)
        bntcancelar.Name = "bntcancelar"
        bntcancelar.Size = New Size(16, 16)
        bntcancelar.SizeMode = PictureBoxSizeMode.AutoSize
        bntcancelar.TabIndex = 60
        bntcancelar.TabStop = False
        ' 
        ' forregistro
        ' 
        AutoScaleDimensions = New SizeF(11F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ScrollBar
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(434, 766)
        Controls.Add(bntcancelar)
        Controls.Add(txteliminar)
        Controls.Add(txtactuali)
        Controls.Add(btnConsulta)
        Controls.Add(bntenviar)
        Controls.Add(bntnewcontra)
        Controls.Add(Ptbvolver)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label4)
        Controls.Add(Comboestado)
        Controls.Add(cmbMunicipios)
        Controls.Add(cmbDepartamentos)
        Controls.Add(Label6)
        Controls.Add(txtobservaciones)
        Controls.Add(Label5)
        Controls.Add(Comborol)
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
        Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "forregistro"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "forregistro"
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).EndInit()
        CType(Ptbvolver, ComponentModel.ISupportInitialize).EndInit()
        CType(bntnewcontra, ComponentModel.ISupportInitialize).EndInit()
        CType(bntenviar, ComponentModel.ISupportInitialize).EndInit()
        CType(btnConsulta, ComponentModel.ISupportInitialize).EndInit()
        CType(txtactuali, ComponentModel.ISupportInitialize).EndInit()
        CType(txteliminar, ComponentModel.ISupportInitialize).EndInit()
        CType(bntcancelar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents apelli As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents correo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtactualid As Button
    Friend WithEvents txteliminard As Button
    Friend WithEvents Textbuscador As TextBox
    Friend WithEvents Comborol As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtobservaciones As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbDepartamentos As ComboBox
    Friend WithEvents cmbMunicipios As ComboBox
    Friend WithEvents Comboestado As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Ptbvolver As PictureBox
    Friend WithEvents bntnewcontra As PictureBox
    Friend WithEvents bntenviar As PictureBox
    Friend WithEvents btnConsulta As PictureBox
    Friend WithEvents txtactuali As PictureBox
    Friend WithEvents txteliminar As PictureBox
    Friend WithEvents bntcancelar As PictureBox

End Class
