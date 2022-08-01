Imports System.Data
Imports System.Data.OleDb
Public Class frmAutorizarTarjeta

    Private Sub frmAutorizarTarjeta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sentSQL As String
            sentSQL = "SELECT * FROM TARJETAS WHERE ESTATUS='INACTIVO'"

            Dim conexion As New OleDbConnection
            conexion.ConnectionString = cadenaconexion

            Dim objAdap As New OleDbDataAdapter(sentSQL, conexion)
            Dim objDataSet As New DataSet

            conexion.Open()
            objAdap.Fill(objDataSet)

            gridTarjetas.DataSource = objDataSet.Tables(0)

            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAutorizar_Click(sender As Object, e As EventArgs) Handles btnAutorizar.Click
        If txtNum4.Text = "" Then
            MsgBox("Escriba un numero")
            txtNum4.Focus()
            Exit Sub
        End If

        If txtNum4.Text.Trim.Length < 4 Then
            MsgBox("Deben ser obligatoriamente 4 digitos")
            txtNum4.Focus()
            Exit Sub
        End If

        Try
            Dim conexion As New OleDbConnection
            conexion.ConnectionString = cadenaconexion

            Dim sentSQLUpdate As String
            sentSQLUpdate = "insert into Tarjetas(NOtarjeta, estatus) values('" & txtNum1.Text & txtNum2.Text & txtNum3.Text & txtNum4.Text & "','INACTIVO')"

            Dim comando As New OleDbCommand(sentSQLUpdate, conexion)

            conexion.Open()
            comando.ExecuteNonQuery()

            MessageBox.Show("La tarjeta se ha autorizado con exito.", "Autorizando tarjeta...")

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            Exit Sub
        End Try

        Try
            Dim sentSQL As String
            sentSQL = "SELECT * FROM TARJETAS WHERE ESTATUS='INACTIVO'"

            Dim conexion As New OleDbConnection
            conexion.ConnectionString = cadenaconexion

            Dim objAdap As New OleDbDataAdapter(sentSQL, conexion)
            Dim objDataSet As New DataSet

            conexion.Open()
            objAdap.Fill(objDataSet)

            gridTarjetas.DataSource = objDataSet.Tables(0)

            conexion.Close()
            txtNum4.Clear()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            Exit Sub
        End Try

        '        Try
        'Dim conexion As New OleDbConnection()
        ' conexion.ConnectionString = cadenaconexion

        '  Dim SentSQLinsert As String

        ' SentSQLinsert = "INSERT INTO [CONTROL OPERACIONES](OPERACION, QUIEN, [A QUIEN], FECHA, HORA, NUM_ACCESO) VALUES('AUTORIZAR TARJETA'," & IdEmpActivo & ",'NUEVA TARJETA','" & Format(Now, "dd/MM/yyyy") & "','" & Format(Now, "hh:mm") & "'," & Acceso & ")"
        '  Dim comando As New OleDbCommand(SentSQLinsert, conexion)

        '  conexion.Open()
        '  comando.ExecuteNonQuery()

        ' conexion.Close()

        ' txtNum4.Clear()
        '  Catch ex As Exception
        'MsgBox(ex.Message.ToString())
        '  Exit Sub
        '  End Try
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        frmMenu.Show()
        Me.Close()
    End Sub
End Class