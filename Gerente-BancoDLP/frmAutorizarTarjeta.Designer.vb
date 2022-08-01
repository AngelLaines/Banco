<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAutorizarTarjeta
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
        Me.gridTarjetas = New System.Windows.Forms.DataGridView()
        Me.btnAutorizar = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.txtNum3 = New System.Windows.Forms.TextBox()
        Me.txtNum4 = New System.Windows.Forms.TextBox()
        CType(Me.gridTarjetas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridTarjetas
        '
        Me.gridTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridTarjetas.Location = New System.Drawing.Point(1, 1)
        Me.gridTarjetas.Name = "gridTarjetas"
        Me.gridTarjetas.Size = New System.Drawing.Size(574, 220)
        Me.gridTarjetas.TabIndex = 0
        '
        'btnAutorizar
        '
        Me.btnAutorizar.Location = New System.Drawing.Point(489, 248)
        Me.btnAutorizar.Name = "btnAutorizar"
        Me.btnAutorizar.Size = New System.Drawing.Size(75, 23)
        Me.btnAutorizar.TabIndex = 9
        Me.btnAutorizar.Text = "Autorizar"
        Me.btnAutorizar.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(489, 277)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(75, 23)
        Me.btnMenu.TabIndex = 11
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNum4)
        Me.GroupBox1.Controls.Add(Me.txtNum3)
        Me.GroupBox1.Controls.Add(Me.txtNum2)
        Me.GroupBox1.Controls.Add(Me.txtNum1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 227)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(471, 90)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ID TARJETA"
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(6, 35)
        Me.txtNum1.MaxLength = 4
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.ReadOnly = True
        Me.txtNum1.Size = New System.Drawing.Size(100, 20)
        Me.txtNum1.TabIndex = 0
        Me.txtNum1.Text = "1111"
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(112, 35)
        Me.txtNum2.MaxLength = 4
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.ReadOnly = True
        Me.txtNum2.Size = New System.Drawing.Size(100, 20)
        Me.txtNum2.TabIndex = 1
        Me.txtNum2.Text = "0179"
        '
        'txtNum3
        '
        Me.txtNum3.Location = New System.Drawing.Point(218, 35)
        Me.txtNum3.MaxLength = 4
        Me.txtNum3.Name = "txtNum3"
        Me.txtNum3.ReadOnly = True
        Me.txtNum3.Size = New System.Drawing.Size(100, 20)
        Me.txtNum3.TabIndex = 2
        Me.txtNum3.Text = "0603"
        '
        'txtNum4
        '
        Me.txtNum4.Location = New System.Drawing.Point(324, 35)
        Me.txtNum4.MaxLength = 4
        Me.txtNum4.Name = "txtNum4"
        Me.txtNum4.Size = New System.Drawing.Size(100, 20)
        Me.txtNum4.TabIndex = 3
        '
        'frmAutorizarTarjeta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 321)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnAutorizar)
        Me.Controls.Add(Me.gridTarjetas)
        Me.MaximizeBox = False
        Me.Name = "frmAutorizarTarjeta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Autorizar Tarjeta"
        CType(Me.gridTarjetas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gridTarjetas As System.Windows.Forms.DataGridView
    Friend WithEvents btnAutorizar As System.Windows.Forms.Button
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNum4 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum3 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum1 As System.Windows.Forms.TextBox
End Class
