<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsulta
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
        DgvConsulta = New DataGridView()
        CType(DgvConsulta, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DgvConsulta
        ' 
        DgvConsulta.BackgroundColor = Color.MintCream
        DgvConsulta.BorderStyle = BorderStyle.None
        DgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvConsulta.Location = New Point(12, 12)
        DgvConsulta.Name = "DgvConsulta"
        DgvConsulta.RowHeadersWidth = 62
        DgvConsulta.Size = New Size(682, 271)
        DgvConsulta.TabIndex = 0
        ' 
        ' FrmConsulta
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.WindowFrame
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(706, 295)
        Controls.Add(DgvConsulta)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "FrmConsulta"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FrmConsulta"
        CType(DgvConsulta, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DgvConsulta As DataGridView
End Class
