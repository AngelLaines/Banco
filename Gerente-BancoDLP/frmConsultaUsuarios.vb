Imports System.Data
Imports System.Data.OleDb
Public Class frmConsultaUsuarios

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        frmMenu.Show()
        Me.Close()
    End Sub

    Private Sub frmConsultaUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sentSQL As String
            sentSQL = "SELECT * FROM USUARIOS"

            Dim conexion As New OleDbConnection
            conexion.ConnectionString = Ruta

            Dim objAdap As New OleDbDataAdapter(sentSQL, conexion)
            Dim objDataSet As New DataSet

            conexion.Open()
            objAdap.Fill(objDataSet)

            gridUsuarios.DataSource = objDataSet.Tables(0)

            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try


    End Sub
End Class