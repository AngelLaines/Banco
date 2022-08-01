Imports System.Data
Imports System.Data.OleDb
Public Class frmAsignarCuenta

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
                btnAceptar.Enabled = True
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

                txtUsuario.Enabled = True
                txtContraseña.Enabled = True
                txtConfirmarContraseña.Enabled = True
                chkCaracteres.Enabled = True
            End If

            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtUsuario.Text = "" Then
            MsgBox("Falta el dato Usuario")
            txtUsuario.Focus()
            Exit Sub
        End If

        If txtContraseña.Text = "" Then
            MsgBox("Falta el dato Contraseña")
            txtContraseña.Focus()
            Exit Sub
        End If

        If txtConfirmarContraseña.Text = "" Then
            MsgBox("Falta el dato Confirmar la contraseña")
            txtConfirmarContraseña.Focus()
            Exit Sub
        End If

        If txtContraseña.Text <> txtConfirmarContraseña.Text Then
            MsgBox("La contraseña no coincide con la confirmacion. Proporcionalas de nuevo.")
            txtConfirmarContraseña.Clear()
            txtContraseña.Clear()
            txtContraseña.Focus()
        End If

        Try
            Dim conexion As New OleDbConnection()
            conexion.ConnectionString = Ruta

            Dim SentSQLinsert As String

            SentSQLinsert = "INSERT INTO USUARIOS(IDEMPLEADO, USUARIO, CONTRASEÑA, TIPO) VALUES(" & txtIdEmp.Text & ",'" & txtUsuario.Text & "','" & txtContraseña.Text & "','" & cboTipo.SelectedItem.ToString & "')"

            Dim comando As New OleDbCommand(SentSQLinsert, conexion)

            conexion.Open()
            comando.ExecuteNonQuery()

            MessageBox.Show("Los datos fueron guardados con exito", "Sistema de control de ventas")
            conexion.Close()



            txtUsuario.Enabled = False
            txtContraseña.Enabled = False
            txtConfirmarContraseña.Enabled = False
            btnAceptar.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            Exit Sub
        End Try

        Try
            Dim conexion As New OleDbConnection()
            conexion.ConnectionString = Ruta

            Dim SentSQLinsert As String

            SentSQLinsert = "INSERT INTO OPERACIONES(OPERACION, QUIEN, AQUIEN, FECHA, HORA, NOACCESO) VALUES('ASIGNAR CUENTA'," & IdEmpActivo & "," & txtIdEmp.Text & ",'" & Format(Now, "dd/MM/yyyy") & "','" & Format(Now, "hh:mm") & "'," & Acceso & ")"
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


            txtUsuario.Clear()
            txtContraseña.Clear()
            txtConfirmarContraseña.Clear()

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            Exit Sub
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        frmMenu.Show()
        Me.Close()
    End Sub

    Private Sub chkCaracteres_CheckedChanged(sender As Object, e As EventArgs) Handles chkCaracteres.CheckedChanged
        If chkCaracteres.Checked = True Then
            txtContraseña.PasswordChar = ""
            txtConfirmarContraseña.PasswordChar = ""
        Else
            txtContraseña.PasswordChar = "•"
            txtConfirmarContraseña.PasswordChar = "•"
        End If
    End Sub
End Class