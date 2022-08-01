Imports System.Data
Imports System.Data.OleDb
Public Class frmAccesosPorFecha

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Try
            Dim conexion As New OleDbConnection
            conexion.ConnectionString = Ruta

            Dim sentSQL As String
            sentSQL = "SELECT * FROM ACCESOS WHERE FECHA=datevalue('" & dtpFechad.Value & "')"

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

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        frmMenu.Show()
        Me.Close()
    End Sub

    Private Sub frmAccesosPorFecha_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtpFechad.Value = Format(Now, "dd/MM/yyyy")
    End Sub
End Class