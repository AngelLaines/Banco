<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.mnsBarra = New System.Windows.Forms.MenuStrip()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NombreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SexoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PuestoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarContraseñaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccesoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperacionesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutorizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsBarra.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnsBarra
        '
        Me.mnsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadosToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.AToolStripMenuItem, Me.SalirToolStripMenuItem, Me.SalirToolStripMenuItem1})
        Me.mnsBarra.Location = New System.Drawing.Point(0, 0)
        Me.mnsBarra.Name = "mnsBarra"
        Me.mnsBarra.Size = New System.Drawing.Size(597, 24)
        Me.mnsBarra.TabIndex = 0
        Me.mnsBarra.Text = "MenuStrip1"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroToolStripMenuItem, Me.ActualizacionToolStripMenuItem, Me.BajaToolStripMenuItem, Me.ConsultaToolStripMenuItem})
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'RegistroToolStripMenuItem
        '
        Me.RegistroToolStripMenuItem.Name = "RegistroToolStripMenuItem"
        Me.RegistroToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.RegistroToolStripMenuItem.Text = "Registro"
        '
        'ActualizacionToolStripMenuItem
        '
        Me.ActualizacionToolStripMenuItem.Name = "ActualizacionToolStripMenuItem"
        Me.ActualizacionToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ActualizacionToolStripMenuItem.Text = "Actualizacion"
        '
        'BajaToolStripMenuItem
        '
        Me.BajaToolStripMenuItem.Name = "BajaToolStripMenuItem"
        Me.BajaToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.BajaToolStripMenuItem.Text = "Baja"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NombreToolStripMenuItem, Me.SexoToolStripMenuItem, Me.PuestoToolStripMenuItem})
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ConsultaToolStripMenuItem.Text = "Consulta"
        '
        'NombreToolStripMenuItem
        '
        Me.NombreToolStripMenuItem.Name = "NombreToolStripMenuItem"
        Me.NombreToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.NombreToolStripMenuItem.Text = "Nombre"
        '
        'SexoToolStripMenuItem
        '
        Me.SexoToolStripMenuItem.Name = "SexoToolStripMenuItem"
        Me.SexoToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.SexoToolStripMenuItem.Text = "Sexo"
        '
        'PuestoToolStripMenuItem
        '
        Me.PuestoToolStripMenuItem.Name = "PuestoToolStripMenuItem"
        Me.PuestoToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.PuestoToolStripMenuItem.Text = "Puesto"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsignarToolStripMenuItem, Me.CambiarContraseñaToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.ConsultaToolStripMenuItem1})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'AsignarToolStripMenuItem
        '
        Me.AsignarToolStripMenuItem.Name = "AsignarToolStripMenuItem"
        Me.AsignarToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.AsignarToolStripMenuItem.Text = "Asignar"
        '
        'CambiarContraseñaToolStripMenuItem
        '
        Me.CambiarContraseñaToolStripMenuItem.Name = "CambiarContraseñaToolStripMenuItem"
        Me.CambiarContraseñaToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.CambiarContraseñaToolStripMenuItem.Text = "Cambiar cuenta"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'ConsultaToolStripMenuItem1
        '
        Me.ConsultaToolStripMenuItem1.Name = "ConsultaToolStripMenuItem1"
        Me.ConsultaToolStripMenuItem1.Size = New System.Drawing.Size(158, 22)
        Me.ConsultaToolStripMenuItem1.Text = "Consulta"
        '
        'AToolStripMenuItem
        '
        Me.AToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccesoToolStripMenuItem, Me.OperacionesToolStripMenuItem, Me.OperacionesToolStripMenuItem1})
        Me.AToolStripMenuItem.Name = "AToolStripMenuItem"
        Me.AToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.AToolStripMenuItem.Text = "Acceso"
        '
        'AccesoToolStripMenuItem
        '
        Me.AccesoToolStripMenuItem.Name = "AccesoToolStripMenuItem"
        Me.AccesoToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.AccesoToolStripMenuItem.Text = "Por empleado"
        '
        'OperacionesToolStripMenuItem
        '
        Me.OperacionesToolStripMenuItem.Name = "OperacionesToolStripMenuItem"
        Me.OperacionesToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.OperacionesToolStripMenuItem.Text = "Por fecha"
        '
        'OperacionesToolStripMenuItem1
        '
        Me.OperacionesToolStripMenuItem1.Name = "OperacionesToolStripMenuItem1"
        Me.OperacionesToolStripMenuItem1.Size = New System.Drawing.Size(148, 22)
        Me.OperacionesToolStripMenuItem1.Text = "Operaciones"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AutorizarToolStripMenuItem})
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.SalirToolStripMenuItem.Text = "Tarjetas"
        '
        'AutorizarToolStripMenuItem
        '
        Me.AutorizarToolStripMenuItem.Name = "AutorizarToolStripMenuItem"
        Me.AutorizarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AutorizarToolStripMenuItem.Text = "Autorizar"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 336)
        Me.Controls.Add(Me.mnsBarra)
        Me.MainMenuStrip = Me.mnsBarra
        Me.MaximizeBox = False
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Gerente"
        Me.mnsBarra.ResumeLayout(False)
        Me.mnsBarra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnsBarra As System.Windows.Forms.MenuStrip
    Friend WithEvents EmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NombreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SexoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PuestoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsignarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarContraseñaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccesoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OperacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OperacionesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AutorizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
