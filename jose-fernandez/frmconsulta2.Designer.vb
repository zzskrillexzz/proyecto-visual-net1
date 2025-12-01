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
        cbbFiltro.DropDownStyle = ComboBoxStyle.DropDownList
        cbbFiltro.FormattingEnabled = True
        cbbFiltro.Location = New Point(8, 23)
        cbbFiltro.Margin = New Padding(2, 2, 2, 2)
        cbbFiltro.Name = "cbbFiltro"
        cbbFiltro.Size = New Size(123, 23)
        cbbFiltro.TabIndex = 1
        ' 
        ' txtFiltro
        ' 
        txtFiltro.Location = New Point(134, 23)
        txtFiltro.Margin = New Padding(2, 2, 2, 2)
        txtFiltro.Name = "txtFiltro"
        txtFiltro.Size = New Size(326, 23)
        txtFiltro.TabIndex = 2
        ' 
        ' grd
        ' 
        grd.AllowUserToAddRows = False
        grd.AllowUserToDeleteRows = False
        grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grd.Location = New Point(2, 51)
        grd.Margin = New Padding(2, 2, 2, 2)
        grd.Name = "grd"
        grd.ReadOnly = True
        grd.RowHeadersWidth = 62
        grd.Size = New Size(461, 168)
        grd.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(8, 5)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 15)
        Label1.TabIndex = 3
        Label1.Text = "Control De filtros"
        ' 
        ' frmconsulta2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(465, 220)
        Controls.Add(Label1)
        Controls.Add(grd)
        Controls.Add(txtFiltro)
        Controls.Add(cbbFiltro)
        Margin = New Padding(2, 2, 2, 2)
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
