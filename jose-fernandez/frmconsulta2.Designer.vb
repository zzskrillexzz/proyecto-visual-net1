<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmconsulta2
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
        components = New ComponentModel.Container()
        cbbFiltro = New ComboBox()
        txtFiltro = New TextBox()
        grd = New DataGridView()
        Label1 = New Label()
        bind = New BindingSource(components)
        CType(grd, ComponentModel.ISupportInitialize).BeginInit()
        CType(bind, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cbbFiltro
        ' 
        cbbFiltro.FormattingEnabled = True
        cbbFiltro.Location = New Point(12, 39)
        cbbFiltro.Name = "cbbFiltro"
        cbbFiltro.Size = New Size(174, 33)
        cbbFiltro.TabIndex = 1
        ' 
        ' txtFiltro
        ' 
        txtFiltro.Location = New Point(192, 39)
        txtFiltro.Name = "txtFiltro"
        txtFiltro.Size = New Size(464, 31)
        txtFiltro.TabIndex = 2
        ' 
        ' grd
        ' 
        grd.AllowUserToAddRows = False
        grd.AllowUserToDeleteRows = False
        grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grd.Location = New Point(3, 85)
        grd.Name = "grd"
        grd.ReadOnly = True
        grd.RowHeadersWidth = 62
        grd.Size = New Size(659, 280)
        grd.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(148, 25)
        Label1.TabIndex = 3
        Label1.Text = "Control De filtros"
        ' 
        ' frmconsulta2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(664, 366)
        Controls.Add(Label1)
        Controls.Add(grd)
        Controls.Add(txtFiltro)
        Controls.Add(cbbFiltro)
        Name = "frmconsulta2"
        Text = "tarea"
        CType(grd, ComponentModel.ISupportInitialize).EndInit()
        CType(bind, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cbbFiltro As ComboBox
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents grd As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents bind As BindingSource
End Class
