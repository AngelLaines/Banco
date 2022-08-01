Imports System.Data
Imports System.Data.OleDb

Public Class frmActualizarDatosEmp

    Public IDBuscado As Integer

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtIdEmp.Text = "" Then
            MsgBox("Falto el campo ID Empleado")
            txtIdEmp.Focus()
            Exit Sub
        End If

        Try
            Dim conexion As New OleDbConnection
            conexion.ConnectionString = Ruta

            Dim sentSQL As String
            sentSQL = "SELECT * FROM EMPLEADOS WHERE IDEMPLEADO=" & txtIdEmp.Text


            Dim objAdap As New OleDbDataAdapter(sentSQL, conexion)
            Dim MiConsulta As New DataTable
            conexion.Open()
            objAdap.Fill(MiConsulta)

            If (MiConsulta.Rows.Count) = 0 Then
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


                MessageBox.Show("El empleado con id " & txtIdEmp.Text & " no existe. verifique")

            Else
                btnGuardar.Enabled = True
                IDBuscado = txtIdEmp.Text

                txtIdEmp.DataBindings.Add("text", MiConsulta, "IDEMPLEADO")
                txtNombre.DataBindings.Add("text", MiConsulta, "NOMBRE")
                txtApellidoP.DataBindings.Add("text", MiConsulta, "APELLIDOPATERNO")
                txtApellidoM.DataBindings.Add("text", MiConsulta, "APELLIDOMATERNO")
                txtCurp.DataBindings.Add("text", MiConsulta, "CURP")
                cboSexo.DataBindings.Add("text", MiConsulta, "SEXO")
                txtEdad.DataBindings.Add("text", MiConsulta, "EDAD")
                dtpFechNac.DataBindings.Add("text", MiConsulta, "FECHANACIMIENTO")
                cboEstadoCivil.DataBindings.Add("text", MiConsulta, "ESTADOCIVIL")
                txtTelCasa.DataBindings.Add("text", MiConsulta, "TELEFONO")
                txtCelular.DataBindings.Add("text", MiConsulta, "CELULAR")
                txtEmail.DataBindings.Add("text", MiConsulta, "CORREOELECTRONICO")
                txtCalle.DataBindings.Add("text", MiConsulta, "CALLE")
                txtNumCasa.DataBindings.Add("text", MiConsulta, "NOCASA")
                txtColonia.DataBindings.Add("text", MiConsulta, "COLONIA")
                txtCiudad.DataBindings.Add("text", MiConsulta, "CIUDAD")
                txtCodigoP.DataBindings.Add("text", MiConsulta, "CODIGOPOSTAL")
                txtMunicipio.DataBindings.Add("text", MiConsulta, "MUNICIPIO")
                txtEstado.DataBindings.Add("text", MiConsulta, "ESTADO")
                cboPuesto.DataBindings.Add("text", MiConsulta, "PUESTO")
                cboDepartamento.DataBindings.Add("text", MiConsulta, "DEPARTAMENTO")
                txtSueldoM.DataBindings.Add("text", MiConsulta, "SUELDOMENSUAL")


                txtIdEmp.DataBindings.Clear()
                txtNombre.DataBindings.Clear()
                txtApellidoP.DataBindings.Clear()
                txtApellidoM.DataBindings.Clear()
                txtCurp.DataBindings.Clear()
                cboSexo.DataBindings.Clear()
                txtEdad.DataBindings.Clear()
                dtpFechNac.DataBindings.Clear()
                cboEstadoCivil.DataBindings.Clear()
                txtTelCasa.DataBindings.Clear()
                txtCelular.DataBindings.Clear()
                txtEmail.DataBindings.Clear()
                txtCalle.DataBindings.Clear()
                txtNumCasa.DataBindings.Clear()
                txtColonia.DataBindings.Clear()
                txtCiudad.DataBindings.Clear()
                txtCodigoP.DataBindings.Clear()
                txtMunicipio.DataBindings.Clear()
                txtEstado.DataBindings.Clear()
                cboPuesto.DataBindings.Clear()
                cboDepartamento.DataBindings.Clear()
                txtSueldoM.DataBindings.Clear()


                txtNombre.Enabled = True
                txtApellidoP.Enabled = True
                txtApellidoM.Enabled = True
                txtCurp.Enabled = True
                cboSexo.Enabled = True
                txtEdad.Enabled = True
                dtpFechNac.Enabled = True
                cboEstadoCivil.Enabled = True
                txtTelCasa.Enabled = True
                txtCelular.Enabled = True
                txtEmail.Enabled = True
                txtCalle.Enabled = True
                txtNumCasa.Enabled = True
                txtColonia.Enabled = True
                txtCiudad.Enabled = True
                txtCodigoP.Enabled = True
                txtMunicipio.Enabled = True
                txtEstado.Enabled = True
                cboPuesto.Enabled = True
                cboDepartamento.Enabled = True
                txtSueldoM.Enabled = True

            End If

            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
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
            conexion.ConnectionString = Ruta

            Dim sentSQLUpdate As String
            sentSQLUpdate = "UPDATE EMPLEADOS SET NOMBRE='" & txtNombre.Text & "', APELLIDOPATERNO='" & txtApellidoP.Text & "', APELLIDOMATERNO='" & txtApellidoM.Text & "', CURP='" & txtCurp.Text & "', SEXO='" & cboSexo.SelectedItem & "', EDAD=" & txtEdad.Text & ", FECHANACIMIENTO='" & dtpFechNac.Value.ToString & "', ESTADOCIVIL='" & cboEstadoCivil.SelectedItem & "', TELEFONO=" & txtTelCasa.Text & ", CELULAR=" & txtCelular.Text & ", CORREOELECTRONICO='" & txtEmail.Text & "', CALLE='" & txtCalle.Text & "', NOCASA=" & txtNumCasa.Text & ", COLONIA='" & txtColonia.Text & "', CIUDAD='" & txtCiudad.Text & "', CODIGOPOSTAL=" & txtCodigoP.Text & ", MUNICIPIO='" & txtMunicipio.Text & "', ESTADO='" & txtEstado.Text & "', PUESTO='" & cboPuesto.SelectedItem & "', DEPARTAMENTO='" & cboDepartamento.SelectedItem & "', SUELDOMENSUAL=" & txtSueldoM.Text & " WHERE IDEMPLEADO=" & IDBuscado

            Dim comando As New OleDbCommand(sentSQLUpdate, conexion)

            conexion.Open()
            comando.ExecuteNonQuery()

            MessageBox.Show("Los datos han sido actualizados con exito.", "Actualizando datos...")

            conexion.Close()


            txtNombre.Enabled = False
            txtApellidoP.Enabled = False
            txtApellidoM.Enabled = False
            txtCurp.Enabled = False
            cboSexo.Enabled = False
            txtEdad.Enabled = False
            dtpFechNac.Enabled = False
            cboEstadoCivil.Enabled = False
            txtTelCasa.Enabled = False
            txtCelular.Enabled = False
            txtEmail.Enabled = False
            txtCalle.Enabled = False
            txtNumCasa.Enabled = False
            txtColonia.Enabled = False
            txtCiudad.Enabled = False
            txtCodigoP.Enabled = False
            txtMunicipio.Enabled = False
            txtEstado.Enabled = False
            cboPuesto.Enabled = False
            cboDepartamento.Enabled = False
            txtSueldoM.Enabled = False

            btnGuardar.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            Exit Sub
        End Try

        Try
            Dim conexion As New OleDbConnection()
            conexion.ConnectionString = Ruta

            Dim SentSQLinsert As String

            SentSQLinsert = "INSERT INTO OPERACIONES(OPERACION, QUIEN, AQUIEN, FECHA, HORA, NOACCESO) VALUES('ACTUALIZAR DATOS EMPLEADO'," & IdEmpActivo & "," & txtIdEmp.Text & ",'" & Format(Now, "dd/MM/yyyy") & "','" & Format(Now, "hh:mm") & "'," & Acceso & ")"
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
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        frmMenu.Show()
        Me.Close()
    End Sub

    Private Sub frmActualizarDatosEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class