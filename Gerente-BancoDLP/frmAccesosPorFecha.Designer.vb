<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccesosPorFecha
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
        Me.dtpFechad = New System.Windows.Forms.DateTimePicker()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.gridLista = New System.Windows.Forms.DataGridView()
        CType(Me.gridLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpFechad
        '
        Me.dtpFechad.Location = New System.Drawing.Point(13, 7)
        Me.dtpFechad.Name = "dtpFechad"
        Me.dtpFechad.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechad.TabIndex = 12
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(214, 4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 11
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(595, 321)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(75, 23)
        Me.btnMenu.TabIndex = 10
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'gridLista
        '
        Me.gridLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridLista.Location = New System.Drawing.Point(1, 33)
        Me.gridLista.Name = "gridLista"
        Me.gridLista.Size = New System.Drawing.Size(680, 287)
        Me.gridLista.TabIndex = 9
        '
        'frmAccesosPorFecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 346)
        Me.Controls.Add(Me.dtpFechad)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.gridLista)
        Me.MaximizeBox = False
        Me.Name = "frmAccesosPorFecha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accesos Por Fecha"
        CType(Me.gridLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtpFechad As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents gridLista As System.Windows.Forms.DataGridView
End Class
