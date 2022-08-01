Imports System.Data
Imports System.Data.OleDb
Public Class frmConsultaPuesto

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        frmMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If cboPuesto.SelectedIndex = -1 Then
            MsgBox("Selecciona un puesto")
            Exit Sub
        End If

        Try
            Dim sentSQL As String
            sentSQL = "SELECT * FROM EMPLEADOS WHERE PUESTO='" & (cboPuesto.SelectedItem) & "'"

            Dim conexion As New OleDbConnection
            conexion.ConnectionString = Ruta

            Dim ObjDataSet As New DataSet
            Dim objAdap As New OleDbDataAdapter(sentSQL, conexion)

            conexion.Open()
            objAdap.Fill(ObjDataSet)

            gridLista.DataSource = ObjDataSet.Tables(0)

            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            Exit Sub
        End Try

        
    End Sub
End Class