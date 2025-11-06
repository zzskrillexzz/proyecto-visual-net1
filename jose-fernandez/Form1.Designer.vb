<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        aceptar = New Button()
        Label1 = New Label()
        Txt = New TextBox()
        ComboBox1 = New ComboBox()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' aceptar
        ' 
        aceptar.Location = New Point(325, 252)
        aceptar.Name = "aceptar"
        aceptar.Size = New Size(112, 34)
        aceptar.TabIndex = 0
        aceptar.Text = "Aceptar"
        aceptar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(214, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 25)
        Label1.TabIndex = 1
        Label1.Text = "Nombre"
        ' 
        ' Txt
        ' 
        Txt.Location = New Point(312, 25)
        Txt.Name = "Txt"
        Txt.Size = New Size(53, 31)
        Txt.TabIndex = 2
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(325, 155)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(182, 33)
        ComboBox1.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(214, 163)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 25)
        Label2.TabIndex = 4
        Label2.Text = "Ciudad"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(987, 698)
        Controls.Add(Label2)
        Controls.Add(ComboBox1)
        Controls.Add(Txt)
        Controls.Add(Label1)
        Controls.Add(aceptar)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents aceptar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label

End Class
