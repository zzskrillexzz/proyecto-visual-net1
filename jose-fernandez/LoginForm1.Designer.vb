<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm1
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
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm1))
        PasswordLabel = New Label()
        UsernameTextBox = New TextBox()
        PasswordTextBox = New TextBox()
        OK = New Button()
        Cancel = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.BackColor = Color.Transparent
        PasswordLabel.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PasswordLabel.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        PasswordLabel.Location = New Point(124, 137)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(118, 38)
        PasswordLabel.TabIndex = 2
        PasswordLabel.Text = "&Contraseña"
        PasswordLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UsernameTextBox
        ' 
        UsernameTextBox.Location = New Point(73, 90)
        UsernameTextBox.Name = "UsernameTextBox"
        UsernameTextBox.Size = New Size(220, 31)
        UsernameTextBox.TabIndex = 1
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.Location = New Point(73, 184)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.PasswordChar = "*"c
        PasswordTextBox.Size = New Size(220, 31)
        PasswordTextBox.TabIndex = 3
        ' 
        ' OK
        ' 
        OK.Location = New Point(73, 229)
        OK.Name = "OK"
        OK.Size = New Size(94, 49)
        OK.TabIndex = 4
        OK.Text = "&Aceptar"
        ' 
        ' Cancel
        ' 
        Cancel.DialogResult = DialogResult.Cancel
        Cancel.Location = New Point(199, 229)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(94, 49)
        Cancel.TabIndex = 5
        Cancel.Text = "&Cancelar"
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label1.Location = New Point(124, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 38)
        Label1.TabIndex = 6
        Label1.Text = "ID Usuario"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LoginForm1
        ' 
        AcceptButton = OK
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        CancelButton = Cancel
        ClientSize = New Size(378, 344)
        Controls.Add(Label1)
        Controls.Add(Cancel)
        Controls.Add(OK)
        Controls.Add(PasswordTextBox)
        Controls.Add(UsernameTextBox)
        Controls.Add(PasswordLabel)
        MaximizeBox = False
        MinimizeBox = False
        Name = "LoginForm1"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label

End Class
