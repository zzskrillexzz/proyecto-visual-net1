<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formcontra
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
        Label2 = New Label()
        Label3 = New Label()
        txtcambio1 = New TextBox()
        txtcambio2 = New TextBox()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        btnguardar = New Button()
        txtAnterior = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(38, 134)
        Label2.Name = "Label2"
        Label2.Size = New Size(206, 30)
        Label2.TabIndex = 1
        Label2.Text = "Contraseña nueva"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(15, 235)
        Label3.Name = "Label3"
        Label3.Size = New Size(252, 30)
        Label3.TabIndex = 2
        Label3.Text = "Confirmar Contraseña"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' txtcambio1
        ' 
        txtcambio1.Location = New Point(54, 184)
        txtcambio1.Name = "txtcambio1"
        txtcambio1.PasswordChar = "*"c
        txtcambio1.Size = New Size(174, 31)
        txtcambio1.TabIndex = 2
        ' 
        ' txtcambio2
        ' 
        txtcambio2.Location = New Point(54, 285)
        txtcambio2.Name = "txtcambio2"
        txtcambio2.PasswordChar = "*"c
        txtcambio2.Size = New Size(174, 31)
        txtcambio2.TabIndex = 3
        ' 
        ' btnguardar
        ' 
        btnguardar.Location = New Point(84, 336)
        btnguardar.Name = "btnguardar"
        btnguardar.Size = New Size(114, 41)
        btnguardar.TabIndex = 6
        btnguardar.Text = "Guardar"
        btnguardar.UseVisualStyleBackColor = True
        ' 
        ' txtAnterior
        ' 
        txtAnterior.Location = New Point(54, 83)
        txtAnterior.Name = "txtAnterior"
        txtAnterior.PasswordChar = "*"c
        txtAnterior.Size = New Size(174, 31)
        txtAnterior.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(27, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(229, 30)
        Label1.TabIndex = 8
        Label1.Text = "Contraseña anterior"
        ' 
        ' formcontra
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(289, 416)
        Controls.Add(Label1)
        Controls.Add(txtAnterior)
        Controls.Add(btnguardar)
        Controls.Add(txtcambio2)
        Controls.Add(txtcambio1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Name = "formcontra"
        StartPosition = FormStartPosition.CenterScreen
        Text = "contraseña C."
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcambio1 As TextBox
    Friend WithEvents txtcambio2 As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnguardar As Button
    Friend WithEvents txtAnterior As TextBox
    Friend WithEvents Label1 As Label
End Class
