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
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(117, 27)
        Label2.Name = "Label2"
        Label2.Size = New Size(135, 30)
        Label2.TabIndex = 1
        Label2.Text = "Contraseña"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(60, 126)
        Label3.Name = "Label3"
        Label3.Size = New Size(252, 30)
        Label3.TabIndex = 2
        Label3.Text = "Confirmar Contraseña"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' txtcambio1
        ' 
        txtcambio1.Location = New Point(99, 72)
        txtcambio1.Name = "txtcambio1"
        txtcambio1.Size = New Size(174, 31)
        txtcambio1.TabIndex = 3
        ' 
        ' txtcambio2
        ' 
        txtcambio2.Location = New Point(99, 173)
        txtcambio2.Name = "txtcambio2"
        txtcambio2.Size = New Size(174, 31)
        txtcambio2.TabIndex = 4
        ' 
        ' btnguardar
        ' 
        btnguardar.Location = New Point(134, 235)
        btnguardar.Name = "btnguardar"
        btnguardar.Size = New Size(114, 41)
        btnguardar.TabIndex = 6
        btnguardar.Text = "Guardar"
        btnguardar.UseVisualStyleBackColor = True
        ' 
        ' formcontra
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(357, 314)
        Controls.Add(btnguardar)
        Controls.Add(txtcambio2)
        Controls.Add(txtcambio1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Name = "formcontra"
        StartPosition = FormStartPosition.CenterScreen
        Text = "formcontra"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcambio1 As TextBox
    Friend WithEvents txtcambio2 As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnguardar As Button
End Class
