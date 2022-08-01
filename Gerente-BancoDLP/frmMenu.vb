Imports System.Data
Imports System.Data.OleDb
Public Class frmMenu

    Private Sub RegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroToolStripMenuItem.Click
        frmRegistroEmpleado.Show()
        Me.Close()
    End Sub

    Private Sub ActualizacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizacionToolStripMenuItem.Click
        frmActualizarDatosEmp.Show()
        Me.Close()
    End Sub

    Private Sub BajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaToolStripMenuItem.Click
        frmBajaEmp.Show()
        Me.Close()
    End Sub

    Private Sub AsignarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignarToolStripMenuItem.Click
        frmAsignarCuenta.Show()
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

    End Sub

    Private Sub CambiarContraseñaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarContraseñaToolStripMenuItem.Click
        frmCambiarCuenta.Show()
        Me.Close()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        frmEliminarCuenta.Show()
        Me.Close()
    End Sub

    Private Sub frmMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Try
            Dim sentSQL As String
            sentSQL = "UPDATE ACCESOS SET HORASALIDA='" & Format(Now, "hh:mm") & "' WHERE NOACCESO=" & Acceso

            Dim conexion As New OleDbConnection
            conexion.ConnectionString = cadenaconexion

            Dim comando As New OleDbCommand(sentSQL, conexion)

            conexion.Open()

            comando.ExecuteNonQuery()

            conexion.Close()



        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SexoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SexoToolStripMenuItem.Click
        frmConsultaSexo.Show()
        Me.Close()
    End Sub

    Private Sub PuestoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PuestoToolStripMenuItem.Click
        frmConsultaPuesto.Show()
        Me.Close()
    End Sub

    Private Sub NombreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NombreToolStripMenuItem.Click
        frmConsultaNombre.Show()
        Me.Close()
    End Sub

    Private Sub AccesoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccesoToolStripMenuItem.Click
        frmAccesoPorNombre.Show()
        Me.Close()
    End Sub

    Private Sub OperacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperacionesToolStripMenuItem.Click
        frmAccesosPorFecha.Show()
        Me.Close()
    End Sub

    Private Sub ConsultaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem1.Click
        frmConsultaUsuarios.Show()
        Me.Close()
    End Sub

    Private Sub AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AToolStripMenuItem.Click

    End Sub

    Private Sub OperacionesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OperacionesToolStripMenuItem1.Click
        frmControlOperaciones.Show()
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        Me.Close()
        End
    End Sub

    Private Sub AutorizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutorizarToolStripMenuItem.Click
        frmAutorizarTarjeta.Show()
        Me.Close()
    End Sub
End Class
