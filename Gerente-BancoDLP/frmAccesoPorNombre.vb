Imports System.Data
Imports System.Data.OleDb
Public Class frmAccesoPorNombre

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        frmMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtIdEmp.Text = "" Then
            MsgBox("Introduzca un ID del empelado")
            txtIdEmp.Focus()
            Exit Sub
        End If

        Try
            Dim conexion As New OleDbConnection
            conexion.ConnectionString = Ruta

            Dim sentSQL As String
            sentSQL = "SELECT * FROM ACCESOS WHERE IDEMPLEADO=" & txtIdEmp.Text

            Dim ObjDataSet As New DataSet
            Dim objAdap As New OleDbDataAdapter(sentSQL, conexion)

            conexion.Open()
            objAdap.Fill(ObjDataSet)
            gridLista.DataSource = ObjDataSet.Tables(0)
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
End Class