Imports System.Data
Imports System.Data.OleDb
Public Class frmRegistroEmpleado

    Private Sub frmRegistroEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim conexion As New OleDbConnection
            conexion.ConnectionString = cadenaconexion

            Dim sentSQL As String
            sentSQL = "SELECT MAX(IDEMPLEADO) FROM EMPLEADOS WHERE IDEMPLEADO>" & Format(Now, "yy") & "0000"

            Dim MiComando As New OleDbCommand(sentSQL, conexion)

            conexion.Open()

            If IsDBNull(MiComando.ExecuteScalar()) = True Then
                'No hay registros coincidentes
                txtIdEmp.Text = Format(Now, "yy") & "0001"
            Else
                txtIdEmp.Text = (MiComando.ExecuteScalar() + 1).ToString

            End If

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            Exit Sub
        End Try

        Try
            Dim conexion As New OleDbConnection
            conexion.ConnectionString = cadenaconexion

            Dim sentSQL As String
            sentSQL = "SELECT MAX(NOOPERACION) FROM OPERACIONES"

            Dim MiComando As New OleDbCommand(sentSQL, conexion)

            conexion.Open()

            If IsDBNull(MiComando.ExecuteScalar()) = True Then
                'No hay registros coincidentes
                txtNoOperacion.Text = "1"
            Else
                txtNoOperacion.Text = (MiComando.ExecuteScalar() + 1).ToString

            End If

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            Exit Sub
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim edad As Integer
        edad = DateDiff(DateInterval.Year, dtpFechNac.Value, Today)

        If txtIdEmp.Text = "" Then
            MsgBox("Falta el campo ID EMPLEADO")
            txtIdEmp.Focus()
            Exit Sub
        End If

        If txtNombre.Text = "" Then
            MsgBox("Falta el campo nombre")
            txtNombre.Focus()
            Exit Sub
        End If

        If txtApellidoP.Text = "" Then
            MsgBox("Falto el campo apellido paterno")
            txtApellidoP.Focus()
            Exit Sub
        End If

        If txtApellidoM.Text = "" Then
            MsgBox("Falto el campo apellido materno")
            txtApellidoP.Focus()
            Exit Sub
        End If

        If txtCurp.Text = "" Then
            MsgBox("Falto el campo CURP")
            txtCurp.Focus()
            Exit Sub
        End If

        If cboSexo.Text = "" Then
            MsgBox("Falta el campo Sexo")
            cboSexo.Focus()
            Exit Sub
        End If

        If txtEdad.Text = "" Then
            MsgBox("Falta el campo Edad")
            txtEdad.Focus()
            Exit Sub
        End If

        If dtpFechNac.Value = Today Then
            MsgBox("La fecha de nacimiento no debe ser igual a la fecha de hoy")
            If edad < 18 Then
                MsgBox("El empleado debe ser mayor de edad")
            End If
            Exit Sub
        End If

        If cboEstadoCivil.Text = "" Then
            MsgBox("Falto el campo Estado Civil")
            Exit Sub
        End If

        If txtTelCasa.Text = "" Then
            MsgBox("Falto el campo Telefon de Casa")
            txtTelCasa.Focus()
            Exit Sub
        End If

        If txtCelular.Text = "" Then
            MsgBox("Falto el campo Celular")
            txtCelular.Focus()
            Exit Sub
        End If

        If txtEmail.Text = "" Then
            MsgBox("Falto el campo Correo electronico")
            txtEmail.Focus()
            Exit Sub
        End If

        If txtCalle.Text = "" Then
            MsgBox("Falta el campo Calle")
            txtCalle.Focus()
            Exit Sub
        End If

        If txtNumCasa.Text = "" Then
            MsgBox("Falta el campo Numero de casa")
            txtNumCasa.Focus()
            Exit Sub
        End If

        If txtColonia.Text = "" Then
            MsgBox("Falta el campo colonia")
            txtColonia.Focus()
            Exit Sub
        End If

        If txtCiudad.Text = "" Then
            MsgBox("Falta el campo Ciudad")
            txtCiudad.Focus()
            Exit Sub
        End If

        If txtCodigoP.Text = "" Then
            MsgBox("Falta el campo Codigo postal")
            txtCodigoP.Focus()
            Exit Sub
        End If

        If txtMunicipio.Text = "" Then
            MsgBox("Falta el campo Municipio")
            txtMunicipio.Focus()
            Exit Sub
        End If

        If txtEstado.Text = "" Then
            MsgBox("Falta el campo Estado")
            txtEstado.Focus()
            Exit Sub
        End If

        If cboPuesto.Text = "" Then
            MsgBox("Falto el campo Puesto")
            Exit Sub
        End If

        If cboDepartamento.Text = "" Then
            MsgBox("Falto el campo Departamento")
            Exit Sub
        End If

        If txtSueldoM.Text = "" Then
            MsgBox("Falta el campo Sueldo mensual")
            txtSueldoM.Focus()
            Exit Sub
        End If

        Try
            Dim conexion As New OleDbConnection
            conexion.ConnectionString = cadenaconexion

            Dim sentSQLInsert As String
            sentSQLInsert = "INSERT INTO EMPLEADOS(IDEMPLEADO, NOMBRE, APELLIDOPATERNO,APELLIDOMATERNO, CURP, SEXO, EDAD, FECHANACIMIENTO, ESTADOCIVIL, TELEFONO, CELULAR, CORREOELECTRONICO, CALLE, NOCASA, COLONIA, CIUDAD, CODIGOPOSTAL, MUNICIPIO, ESTADO, PUESTO, DEPARTAMENTO, SUELDOMENSUAL, FECHAINGRESO) VALUES(" & txtIdEmp.Text & ",'" & txtNombre.Text & "','" & txtApellidoP.Text & "','" & txtApellidoM.Text & "','" & txtCurp.Text & "','" & cboSexo.SelectedItem.ToString & "'," & txtEdad.Text & ",'" & Format(dtpFechNac.Value, "yyyy/MM/dd") & "','" & cboEstadoCivil.SelectedItem.ToString & "','" & txtTelCasa.Text & "','" & txtCelular.Text & "','" & txtEmail.Text & "','" & txtCalle.Text & "'," & txtNumCasa.Text & ",'" & txtColonia.Text & "','" & txtCiudad.Text & "'," & txtCodigoP.Text & ",'" & txtMunicipio.Text & "','" & txtEstado.Text & "','" & cboPuesto.SelectedItem.ToString & "','" & cboDepartamento.SelectedItem.ToString & "'," & txtSueldoM.Text & ",'" & Format(Now, "yyyy/MM/dd") & "')"

            Dim comando As New OleDbCommand(sentSQLInsert, conexion)

            conexion.Open()
            comando.ExecuteNonQuery()
            MessageBox.Show("Los datos fueron guardados con exito.", "Datos guardados...")

            conexion.Close()



        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            Exit Sub
        End Try

        Try
            Dim conexion As New OleDbConnection
            conexion.ConnectionString = cadenaconexion

            Dim sentSQL As String
            sentSQL = "SELECT MAX(IDEMPLEADO) FROM EMPLEADOS WHERE IDEMPLEADO>" & Format(Now, "yy") & "0000"

            Dim MiComando As New OleDbCommand(sentSQL, conexion)

            conexion.Open()

            If IsDBNull(MiComando.ExecuteScalar()) = True Then
                'No hay registros coincidentes
                txtIdEmp.Text = Format(Now, "yy") & "0001"
            Else
                txtIdEmp.Text = (MiComando.ExecuteScalar() + 1).ToString

            End If

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            Exit Sub
        End Try

        Try
            Dim conexion As New OleDbConnection()
            conexion.ConnectionString = cadenaconexion

            Dim SentSQLinsert As String

            SentSQLinsert = "INSERT INTO OPERACIONES(NOOPERACION, OPERACION, QUIEN, AQUIEN, HORA, NOACCESO) VALUES(" & txtNoOperacion.Text & ",'REGISTRO EMPLEADO'," & IdEmpActivo & "," & txtIdEmp.Text & ",'" & Format(Now, "hh:mm") & "'," & Acceso & ")"

            Dim comando As New OleDbCommand(SentSQLinsert, conexion)

            conexion.Open()
            comando.ExecuteNonQuery()

            conexion.Close()

            txtIdEmp.Clear()
            txtNombre.Clear()
            txtApellidoP.Clear()
            txtApellidoM.Clear()
            txtCurp.Clear()
            cboSexo.SelectedIndex = -1
            txtEdad.Clear()
            dtpFechNac.Value = Today
            cboEstadoCivil.SelectedIndex = -1
            txtTelCasa.Clear()
            txtCelular.Clear()
            txtEmail.Clear()
            txtCalle.Clear()
            txtNumCasa.Clear()
            txtColonia.Clear()
            txtCiudad.Clear()
            txtCodigoP.Clear()
            txtMunicipio.Clear()
            txtEstado.Clear()
            cboPuesto.SelectedIndex = -1
            cboDepartamento.SelectedIndex = -1
            txtSueldoM.Clear()



        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            Exit Sub
        End Try

        Try
            Dim conexion As New OleDbConnection
            conexion.ConnectionString = cadenaconexion

            Dim sentSQL As String
            sentSQL = "SELECT MAX(NOOPERACION) FROM OPERACIONES"

            Dim MiComando As New OleDbCommand(sentSQL, conexion)

            conexion.Open()

            If IsDBNull(MiComando.ExecuteScalar()) = True Then
                'No hay registros coincidentes
                txtNoOperacion.Text = "1"
            Else
                txtNoOperacion.Text = (MiComando.ExecuteScalar() + 1).ToString

            End If

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            Exit Sub
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        frmMenu.Show()
        Me.Close()
    End Sub
End Class