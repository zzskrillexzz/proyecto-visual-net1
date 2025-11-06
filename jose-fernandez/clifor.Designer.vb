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
        Label6 = New Label()
        txtobservaciones = New RichTextBox()
        Textbuscador = New TextBox()
        Label4 = New Label()
        txteliminar = New Button()
        txtactuali = New Button()
        correo = New TextBox()
        Label2 = New Label()
        apelli = New TextBox()
        Label1 = New Label()
        bntcancelar = New Button()
        bntenviar = New Button()
        contra = New TextBox()
        UsernameTextBox = New TextBox()
        PasswordLabel = New Label()
        UsernameLabel = New Label()
        LogoPictureBox = New PictureBox()
        cmbMunicipios = New ComboBox()
        cmbDepartamentos = New ComboBox()
        Comboestado = New ComboBox()
        Label3 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        btnConsulta = New Button()
        PictureBox1 = New PictureBox()
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ControlText
        Label6.Location = New Point(66, 159)
        Label6.Name = "Label6"
        Label6.Size = New Size(129, 23)
        Label6.TabIndex = 44
        Label6.Text = "&Observaciones"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtobservaciones
        ' 
        txtobservaciones.Location = New Point(66, 197)
        txtobservaciones.Name = "txtobservaciones"
        txtobservaciones.Size = New Size(405, 107)
        txtobservaciones.TabIndex = 43
        txtobservaciones.Text = ""
        ' 
        ' Textbuscador
        ' 
        Textbuscador.Location = New Point(880, 39)
        Textbuscador.Name = "Textbuscador"
        Textbuscador.Size = New Size(94, 31)
        Textbuscador.TabIndex = 39
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label4.Location = New Point(880, 10)
        Label4.Name = "Label4"
        Label4.Size = New Size(128, 23)
        Label4.TabIndex = 38
        Label4.Text = "Id/Buscar"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txteliminar
        ' 
        txteliminar.Location = New Point(508, 260)
        txteliminar.Name = "txteliminar"
        txteliminar.Size = New Size(94, 38)
        txteliminar.TabIndex = 36
        txteliminar.Text = "&Eliminar"
        ' 
        ' txtactuali
        ' 
        txtactuali.Location = New Point(634, 196)
        txtactuali.Name = "txtactuali"
        txtactuali.Size = New Size(94, 38)
        txtactuali.TabIndex = 35
        txtactuali.Text = "&Modificar"
        ' 
        ' correo
        ' 
        correo.Location = New Point(432, 118)
        correo.Name = "correo"
        correo.Size = New Size(220, 31)
        correo.TabIndex = 32
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label2.Location = New Point(432, 87)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 23)
        Label2.TabIndex = 31
        Label2.Text = "&Correo"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' apelli
        ' 
        apelli.Location = New Point(432, 46)
        apelli.Name = "apelli"
        apelli.Size = New Size(220, 31)
        apelli.TabIndex = 30
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label1.Location = New Point(432, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 23)
        Label1.TabIndex = 29
        Label1.Text = "&Apellido"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' bntcancelar
        ' 
        bntcancelar.DialogResult = DialogResult.Cancel
        bntcancelar.Location = New Point(634, 260)
        bntcancelar.Name = "bntcancelar"
        bntcancelar.Size = New Size(94, 38)
        bntcancelar.TabIndex = 28
        bntcancelar.Text = "&Cancelar"
        ' 
        ' bntenviar
        ' 
        bntenviar.Location = New Point(508, 199)
        bntenviar.Name = "bntenviar"
        bntenviar.Size = New Size(94, 38)
        bntenviar.TabIndex = 27
        bntenviar.Text = "&Registrar"
        ' 
        ' contra
        ' 
        contra.Location = New Point(187, 118)
        contra.Name = "contra"
        contra.PasswordChar = "*"c
        contra.Size = New Size(220, 31)
        contra.TabIndex = 26
        ' 
        ' UsernameTextBox
        ' 
        UsernameTextBox.Location = New Point(187, 46)
        UsernameTextBox.Name = "UsernameTextBox"
        UsernameTextBox.Size = New Size(220, 31)
        UsernameTextBox.TabIndex = 24
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.BackColor = Color.Transparent
        PasswordLabel.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        PasswordLabel.Location = New Point(187, 87)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(114, 23)
        PasswordLabel.TabIndex = 25
        PasswordLabel.Text = "&Contraseña"
        PasswordLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.BackColor = Color.Transparent
        UsernameLabel.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        UsernameLabel.Location = New Point(187, 15)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(86, 23)
        UsernameLabel.TabIndex = 23
        UsernameLabel.Text = "&Nombre"
        UsernameLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LogoPictureBox
        ' 
        LogoPictureBox.BackColor = Color.Transparent
        LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), Image)
        LogoPictureBox.Location = New Point(89, 39)
        LogoPictureBox.Name = "LogoPictureBox"
        LogoPictureBox.Size = New Size(83, 95)
        LogoPictureBox.SizeMode = PictureBoxSizeMode.CenterImage
        LogoPictureBox.TabIndex = 22
        LogoPictureBox.TabStop = False
        ' 
        ' cmbMunicipios
        ' 
        cmbMunicipios.FormattingEnabled = True
        cmbMunicipios.Location = New Point(880, 116)
        cmbMunicipios.Name = "cmbMunicipios"
        cmbMunicipios.Size = New Size(171, 33)
        cmbMunicipios.TabIndex = 46
        ' 
        ' cmbDepartamentos
        ' 
        cmbDepartamentos.FormattingEnabled = True
        cmbDepartamentos.Location = New Point(673, 118)
        cmbDepartamentos.Name = "cmbDepartamentos"
        cmbDepartamentos.Size = New Size(182, 33)
        cmbDepartamentos.TabIndex = 45
        ' 
        ' Comboestado
        ' 
        Comboestado.FormattingEnabled = True
        Comboestado.Location = New Point(673, 39)
        Comboestado.Name = "Comboestado"
        Comboestado.Size = New Size(171, 33)
        Comboestado.TabIndex = 48
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label3.Location = New Point(673, 8)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 23)
        Label3.TabIndex = 47
        Label3.Text = "&Estado"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label7.Location = New Point(673, 87)
        Label7.Name = "Label7"
        Label7.Size = New Size(148, 23)
        Label7.TabIndex = 49
        Label7.Text = "&Departamento"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label8
        ' 
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label8.Location = New Point(880, 87)
        Label8.Name = "Label8"
        Label8.Size = New Size(102, 23)
        Label8.TabIndex = 50
        Label8.Text = "&Municipio"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnConsulta
        ' 
        btnConsulta.Location = New Point(750, 193)
        btnConsulta.Name = "btnConsulta"
        btnConsulta.Size = New Size(94, 38)
        btnConsulta.TabIndex = 54
        btnConsulta.Text = "Consulta"
        btnConsulta.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(26, 15)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(32, 32)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 55
        PictureBox1.TabStop = False
        ' 
        ' clifor
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1069, 354)
        Controls.Add(PictureBox1)
        Controls.Add(btnConsulta)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Comboestado)
        Controls.Add(Label3)
        Controls.Add(cmbMunicipios)
        Controls.Add(cmbDepartamentos)
        Controls.Add(Label6)
        Controls.Add(txtobservaciones)
        Controls.Add(Textbuscador)
        Controls.Add(Label4)
        Controls.Add(txteliminar)
        Controls.Add(txtactuali)
        Controls.Add(correo)
        Controls.Add(Label2)
        Controls.Add(apelli)
        Controls.Add(Label1)
        Controls.Add(bntcancelar)
        Controls.Add(bntenviar)
        Controls.Add(contra)
        Controls.Add(UsernameTextBox)
        Controls.Add(PasswordLabel)
        Controls.Add(UsernameLabel)
        Controls.Add(LogoPictureBox)
        Name = "clifor"
        StartPosition = FormStartPosition.CenterScreen
        Text = "clifor"
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents txtobservaciones As RichTextBox
    Friend WithEvents Textbuscador As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txteliminar As Button
    Friend WithEvents txtactuali As Button
    Friend WithEvents correo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents apelli As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents bntcancelar As Button
    Friend WithEvents bntenviar As Button
    Friend WithEvents contra As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents cmbMunicipios As ComboBox
    Friend WithEvents cmbDepartamentos As ComboBox
    Friend WithEvents Comboestado As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnConsulta As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
