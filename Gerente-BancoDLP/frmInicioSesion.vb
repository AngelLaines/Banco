﻿Imports System.Data
Imports System.Data.OleDb

Public Class frmInicioSesion

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtUsuario.Text = "" Then
            MsgBox("Falta el dato usuario")
            txtUsuario.Focus()
            Exit Sub
        End If

        If txtContraseña.Text = "" Then
            MsgBox("Falta el dato contraseña")
            txtContraseña.Focus()
            Exit Sub
        End If

        Try
            Dim sentSQL As String
            sentSQL = "SELECT * FROM USUARIOS WHERE USUARIO='" & Trim(txtUsuario.Text) & "' AND CONTRASEÑA='" & Trim(txtContraseña.Text) & "' AND TIPO='GERENTE'"


            Dim conexion As New OleDbConnection
            conexion.ConnectionString = cadenaconexion

            Dim objAdap As New OleDbDataAdapter(sentSQL, conexion)
            Dim MiConsulta As New DataTable() 'consulta

            conexion.Open()
            objAdap.Fill(MiConsulta)

            If (MiConsulta.Rows.Count) = 0 Then
                MessageBox.Show("El nombre de usuario o la contraseña es incorrecto. Intente de nuevo")
                Exit Sub
            Else
                txtTemp.Visible = True

                txtTemp.DataBindings.Add("text", MiConsulta, "IDEMPLEADO")
                IdEmpActivo = txtTemp.Text
                txtTemp.DataBindings.Clear()
                '****
                txtTemp.Visible = False


            End If

            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            Exit Sub
        End Try


        Try
            Dim sentSQLInsert As String


            sentSQLInsert = "INSERT INTO ACCESOS(NOACCESO, IDEMPLEADO, FECHA, HORAENTRADA) VALUES(" & txtAcceso.Text & "," & IdEmpActivo & ",'" & Format(Now, "yyyy/MM/dd") & "','" & Format(Now, "hh:mm") & "')"



            Dim conexion As New OleDbConnection
            conexion.ConnectionString = cadenaconexion

            Dim comando As New OleDbCommand(sentSQLInsert, conexion)

            conexion.Open()
            comando.ExecuteNonQuery()
            conexion.Close()

            frmMenu.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            Exit Sub
        End Try

    End Sub

    Private Sub frmInicioSesion_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed


    End Sub

    Private Sub frmInicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getAcceso()
        'Try

        '    Dim conexion As New OleDbConnection
        '    conexion.ConnectionString = cadenaconexion
        '    Dim sentSQL As String
        '    sentSQL = "SELECT MAX(NOACCESO) AS MAXIMO FROM ACCESOS"

        '    Dim MiComando As New OleDbCommand(sentSQL, conexion)

        '    conexion.Open()

        '    If IsDBNull(MiComando.ExecuteScalar()) = True Then
        '        no hay registros coincidentes
        '        txtAcceso.Text = "1"
        '        txtNumVenta.Text = Format(Now, "ddMMyyyy") & "0001"

        '    Else
        '        txtAcceso.Visible = True
        '        txtAcceso.Text = (MiComando.ExecuteScalar() + 1).ToString
        '        txtAcceso.Visible = False
        '        Acceso = txtAcceso.Text
        '    End If

        '    conexion.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message.ToString())
        '    Exit Sub
        'End Try
    End Sub

    Private Sub getAcceso()
        Try

            Dim conexion As New OleDbConnection
            conexion.ConnectionString = cadenaconexion
            Dim sentSQL As String
            sentSQL = "SELECT MAX(NOACCESO) AS MAXIMO FROM ACCESOS"

            Dim MiComando As New OleDbCommand(sentSQL, conexion)

            conexion.Open()

            If IsDBNull(MiComando.ExecuteScalar()) = True Then
                'no hay registros coincidentes
                txtAcceso.Text = "1"
                'txtNumVenta.Text = Format(Now, "ddMMyyyy") & "0001"

            Else
                txtAcceso.Visible = True
                txtAcceso.Text = (MiComando.ExecuteScalar() + 1).ToString
                txtAcceso.Visible = False
                Acceso = txtAcceso.Text
            End If

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            Exit Sub
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        End
    End Sub
End Class