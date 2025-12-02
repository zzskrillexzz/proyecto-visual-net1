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
        Textbuscador = New TextBox()
        Comborol = New ComboBox()
        Label5 = New Label()
        txtobservaciones = New RichTextBox()
        Label6 = New Label()
        cmbDepartamentos = New ComboBox()
        cmbMunicipios = New ComboBox()
        Label4 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        bntnewcontra = New PictureBox()
        ToolStrip1 = New ToolStrip()
        Ptbvolver = New ToolStripButton()
        bntenviar = New ToolStripButton()
        txtactuali = New ToolStripButton()
        txteliminar = New ToolStripButton()
        btnConsulta = New ToolStripButton()
        bntlimpiar = New ToolStripButton()
        bntcancelar = New ToolStripButton()
        btndesbloquearusu = New ToolStripButton()
        ingresos = New StatusStrip()
        ingresonombre = New ToolStripStatusLabel()
        camCon = New TextBox()
        Label3 = New Label()
        apelli2 = New TextBox()
        Label9 = New Label()
        UsernameTextBox2 = New TextBox()
        Label10 = New Label()
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(bntnewcontra, ComponentModel.ISupportInitialize).BeginInit()
        ToolStrip1.SuspendLayout()
        ingresos.SuspendLayout()
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
        UsernameLabel.AutoSize = True
        UsernameLabel.BackColor = Color.Transparent
        UsernameLabel.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        UsernameLabel.Location = New Point(11, 101)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(99, 15)
        UsernameLabel.TabIndex = 0
        UsernameLabel.Text = "&Primer Nombre"
        UsernameLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.BackColor = Color.Transparent
        PasswordLabel.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        PasswordLabel.Location = New Point(8, 225)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(114, 23)
        PasswordLabel.TabIndex = 2
        PasswordLabel.Text = "&Contraseña"
        PasswordLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UsernameTextBox
        ' 
        UsernameTextBox.Location = New Point(149, 100)
        UsernameTextBox.Name = "UsernameTextBox"
        UsernameTextBox.Size = New Size(243, 24)
        UsernameTextBox.TabIndex = 2
        ' 
        ' contra
        ' 
        contra.Location = New Point(150, 226)
        contra.Name = "contra"
        contra.PasswordChar = "*"c
        contra.Size = New Size(242, 24)
        contra.TabIndex = 6
        ' 
        ' apelli
        ' 
        apelli.Location = New Point(150, 165)
        apelli.Name = "apelli"
        apelli.Size = New Size(242, 24)
        apelli.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label1.Location = New Point(8, 165)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 15)
        Label1.TabIndex = 6
        Label1.Text = "&Primer Apellido"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' correo
        ' 
        correo.Location = New Point(150, 286)
        correo.Name = "correo"
        correo.Size = New Size(242, 24)
        correo.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label2.Location = New Point(7, 286)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 23)
        Label2.TabIndex = 8
        Label2.Text = "&Correo"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Textbuscador
        ' 
        Textbuscador.Location = New Point(181, 70)
        Textbuscador.Name = "Textbuscador"
        Textbuscador.Size = New Size(212, 24)
        Textbuscador.TabIndex = 1
        ' 
        ' Comborol
        ' 
        Comborol.DropDownStyle = ComboBoxStyle.DropDownList
        Comborol.FormattingEnabled = True
        Comborol.Location = New Point(150, 317)
        Comborol.Name = "Comborol"
        Comborol.Size = New Size(242, 23)
        Comborol.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label5.Location = New Point(7, 316)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 23)
        Label5.TabIndex = 19
        Label5.Text = "&Rol"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtobservaciones
        ' 
        txtobservaciones.Location = New Point(11, 437)
        txtobservaciones.Name = "txtobservaciones"
        txtobservaciones.Size = New Size(386, 114)
        txtobservaciones.TabIndex = 12
        txtobservaciones.Text = ""
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label6.Location = New Point(7, 406)
        Label6.Name = "Label6"
        Label6.Size = New Size(142, 23)
        Label6.TabIndex = 21
        Label6.Text = "&Observaciones"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cmbDepartamentos
        ' 
        cmbDepartamentos.DropDownStyle = ComboBoxStyle.DropDownList
        cmbDepartamentos.FormattingEnabled = True
        cmbDepartamentos.Location = New Point(150, 350)
        cmbDepartamentos.Name = "cmbDepartamentos"
        cmbDepartamentos.Size = New Size(243, 23)
        cmbDepartamentos.TabIndex = 10
        ' 
        ' cmbMunicipios
        ' 
        cmbMunicipios.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMunicipios.FormattingEnabled = True
        cmbMunicipios.Location = New Point(150, 380)
        cmbMunicipios.Name = "cmbMunicipios"
        cmbMunicipios.Size = New Size(243, 23)
        cmbMunicipios.TabIndex = 11
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
        Label8.Location = New Point(5, 380)
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
        Label7.Location = New Point(7, 349)
        Label7.Name = "Label7"
        Label7.Size = New Size(141, 23)
        Label7.TabIndex = 51
        Label7.Text = "&Departamento"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' bntnewcontra
        ' 
        bntnewcontra.BackColor = Color.Transparent
        bntnewcontra.Image = CType(resources.GetObject("bntnewcontra.Image"), Image)
        bntnewcontra.Location = New Point(398, 232)
        bntnewcontra.Name = "bntnewcontra"
        bntnewcontra.Size = New Size(16, 16)
        bntnewcontra.SizeMode = PictureBoxSizeMode.AutoSize
        bntnewcontra.TabIndex = 55
        bntnewcontra.TabStop = False
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.BackColor = SystemColors.Window
        ToolStrip1.Items.AddRange(New ToolStripItem() {Ptbvolver, bntenviar, txtactuali, txteliminar, btnConsulta, bntlimpiar, bntcancelar, btndesbloquearusu})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(434, 25)
        ToolStrip1.TabIndex = 19
        ToolStrip1.TabStop = True
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' Ptbvolver
        ' 
        Ptbvolver.DisplayStyle = ToolStripItemDisplayStyle.Image
        Ptbvolver.Image = CType(resources.GetObject("Ptbvolver.Image"), Image)
        Ptbvolver.ImageTransparentColor = Color.Magenta
        Ptbvolver.Name = "Ptbvolver"
        Ptbvolver.Size = New Size(23, 22)
        Ptbvolver.Text = "ToolStripButton1"
        Ptbvolver.ToolTipText = "Volver"
        ' 
        ' bntenviar
        ' 
        bntenviar.DisplayStyle = ToolStripItemDisplayStyle.Image
        bntenviar.Image = CType(resources.GetObject("bntenviar.Image"), Image)
        bntenviar.ImageTransparentColor = Color.Magenta
        bntenviar.Name = "bntenviar"
        bntenviar.Size = New Size(23, 22)
        bntenviar.Text = "ToolStripButton2"
        bntenviar.ToolTipText = "Agregar"
        ' 
        ' txtactuali
        ' 
        txtactuali.DisplayStyle = ToolStripItemDisplayStyle.Image
        txtactuali.Image = CType(resources.GetObject("txtactuali.Image"), Image)
        txtactuali.ImageTransparentColor = Color.Magenta
        txtactuali.Name = "txtactuali"
        txtactuali.Size = New Size(23, 22)
        txtactuali.Text = "ToolStripButton3"
        txtactuali.ToolTipText = "Editar"
        ' 
        ' txteliminar
        ' 
        txteliminar.DisplayStyle = ToolStripItemDisplayStyle.Image
        txteliminar.Image = CType(resources.GetObject("txteliminar.Image"), Image)
        txteliminar.ImageTransparentColor = Color.Magenta
        txteliminar.Name = "txteliminar"
        txteliminar.Size = New Size(23, 22)
        txteliminar.Text = "ToolStripButton4"
        txteliminar.ToolTipText = "Eliminar"
        ' 
        ' btnConsulta
        ' 
        btnConsulta.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnConsulta.Image = CType(resources.GetObject("btnConsulta.Image"), Image)
        btnConsulta.ImageTransparentColor = Color.Magenta
        btnConsulta.Name = "btnConsulta"
        btnConsulta.Size = New Size(23, 22)
        btnConsulta.Text = "ToolStripButton5"
        btnConsulta.ToolTipText = "Consultar"
        ' 
        ' bntlimpiar
        ' 
        bntlimpiar.DisplayStyle = ToolStripItemDisplayStyle.Image
        bntlimpiar.Image = CType(resources.GetObject("bntlimpiar.Image"), Image)
        bntlimpiar.ImageTransparentColor = Color.Magenta
        bntlimpiar.Name = "bntlimpiar"
        bntlimpiar.Size = New Size(23, 22)
        bntlimpiar.Text = "ToolStripButton6"
        bntlimpiar.ToolTipText = "Limpiar"
        ' 
        ' bntcancelar
        ' 
        bntcancelar.DisplayStyle = ToolStripItemDisplayStyle.Image
        bntcancelar.Image = CType(resources.GetObject("bntcancelar.Image"), Image)
        bntcancelar.ImageTransparentColor = Color.Magenta
        bntcancelar.Name = "bntcancelar"
        bntcancelar.Size = New Size(23, 22)
        bntcancelar.Text = "ToolStripButton7"
        bntcancelar.ToolTipText = "Cancelar"
        ' 
        ' btndesbloquearusu
        ' 
        btndesbloquearusu.DisplayStyle = ToolStripItemDisplayStyle.Image
        btndesbloquearusu.Enabled = False
        btndesbloquearusu.Image = CType(resources.GetObject("btndesbloquearusu.Image"), Image)
        btndesbloquearusu.ImageTransparentColor = Color.Magenta
        btndesbloquearusu.Name = "btndesbloquearusu"
        btndesbloquearusu.Size = New Size(23, 22)
        btndesbloquearusu.Text = "ToolStripButton1"
        btndesbloquearusu.Visible = False
        ' 
        ' ingresos
        ' 
        ingresos.ImageScalingSize = New Size(24, 24)
        ingresos.Items.AddRange(New ToolStripItem() {ingresonombre})
        ingresos.Location = New Point(0, 567)
        ingresos.Name = "ingresos"
        ingresos.Size = New Size(434, 22)
        ingresos.TabIndex = 56
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
        ' camCon
        ' 
        camCon.Location = New Point(150, 256)
        camCon.Name = "camCon"
        camCon.PasswordChar = "*"c
        camCon.Size = New Size(242, 24)
        camCon.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label3.Location = New Point(8, 255)
        Label3.Name = "Label3"
        Label3.Size = New Size(140, 15)
        Label3.TabIndex = 57
        Label3.Text = "&Confirmar Contraseña"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' apelli2
        ' 
        apelli2.Location = New Point(150, 195)
        apelli2.Name = "apelli2"
        apelli2.Size = New Size(242, 24)
        apelli2.TabIndex = 5
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label9.Location = New Point(8, 195)
        Label9.Name = "Label9"
        Label9.Size = New Size(116, 15)
        Label9.TabIndex = 60
        Label9.Text = "&Segundo Apellido"
        Label9.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UsernameTextBox2
        ' 
        UsernameTextBox2.Location = New Point(149, 130)
        UsernameTextBox2.Name = "UsernameTextBox2"
        UsernameTextBox2.Size = New Size(243, 24)
        UsernameTextBox2.TabIndex = 3
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label10.Location = New Point(10, 134)
        Label10.Name = "Label10"
        Label10.Size = New Size(113, 15)
        Label10.TabIndex = 61
        Label10.Text = "&Segundo Nombre"
        Label10.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' forregistro
        ' 
        AutoScaleDimensions = New SizeF(8F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(434, 589)
        Controls.Add(UsernameTextBox2)
        Controls.Add(Label10)
        Controls.Add(apelli2)
        Controls.Add(Label9)
        Controls.Add(camCon)
        Controls.Add(Label3)
        Controls.Add(ingresos)
        Controls.Add(ToolStrip1)
        Controls.Add(bntnewcontra)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label4)
        Controls.Add(cmbMunicipios)
        Controls.Add(cmbDepartamentos)
        Controls.Add(Label6)
        Controls.Add(txtobservaciones)
        Controls.Add(Label5)
        Controls.Add(Comborol)
        Controls.Add(Textbuscador)
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
        Text = "Usuario"
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).EndInit()
        CType(bntnewcontra, ComponentModel.ISupportInitialize).EndInit()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ingresos.ResumeLayout(False)
        ingresos.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents apelli As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents correo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtactualid As Button
    Friend WithEvents txteliminard As Button
    Friend WithEvents Textbuscador As TextBox
    Friend WithEvents Comborol As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtobservaciones As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbDepartamentos As ComboBox
    Friend WithEvents cmbMunicipios As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents bntnewcontra As PictureBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Ptbvolver As ToolStripButton
    Friend WithEvents bntenviar As ToolStripButton
    Friend WithEvents txtactuali As ToolStripButton
    Friend WithEvents txteliminar As ToolStripButton
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents bntlimpiar As ToolStripButton
    Friend WithEvents bntcancelar As ToolStripButton
    Friend WithEvents btnConsulta As ToolStripButton
    Friend WithEvents btndesbloquearusu As ToolStripButton
    Friend WithEvents ingresos As StatusStrip
    Friend WithEvents ingresonombre As ToolStripStatusLabel
    Friend WithEvents camCon As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents apelli2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents UsernameTextBox2 As TextBox
    Friend WithEvents Label10 As Label

End Class
