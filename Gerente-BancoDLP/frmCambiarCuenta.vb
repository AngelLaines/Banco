Imports System.Data
Imports System.Data.OleDb
Public Class frmCambiarCuenta

    Public IDBuscado, passactual As String
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnBuscar_Click_1(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtIdEmp.Text = "" Then
            MsgBox("Falto el campo ID Empleado")
            txtIdEmp.Focus()
            Exit Sub
        End If

        Try
            Dim conexion As New OleDbConnection
            conexion.ConnectionString = Ruta

            Dim sentSQL As String
            sentSQL = "SELECT EMPLEADOS.*, USUARIOS.* FROM EMPLEADOS, USUARIOS WHERE EMPLEADOS.IDEMPLEADO=USUARIOS.IDEMPLEADO AND EMPLEADOS.IDEMPLEADO=" & txtIdEmp.Text


            Dim objAdap As New OleDbDataAdapter(sentSQL, conexion)
            Dim MiConsulta As New DataTable
            conexion.Open()
            objAdap.Fill(MiConsulta)

            If (MiConsulta.Rows.Count) = 0 Then

                MessageBox.Show("El empleado con id " & txtIdEmp.Text & " no existe. verifique")

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




            Else
                btnAceptar.Enabled = True
                IDBuscado = txtIdEmp.Text

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


                txtUsuario.DataBindings.Add("text", MiConsulta, "USUARIO")
                txtContraseñaActual.DataBindings.Add("text", MiConsulta, "CONTRASEÑA")

                passactual = txtContraseñaActual.Text

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

                txtUsuario.DataBindings.Clear()
                txtContraseñaActual.DataBindings.Clear()
                txtContraseñaActual.Clear()

                txtUsuario.Enabled = True
                txtContraseñaActual.Enabled = True
                txtNuevaContraseña.Enabled = True
                txtConfirmarContraseña.Enabled = True
                chkCaracteres.Enabled = True
                cboTipo.Enabled = True
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

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtIdEmp.Text = "" Then
            MsgBox("Falta el dato Id del empleado")
            txtIdEmp.Focus()
            Exit Sub
        End If

        If (txtContraseñaActual.Text <> passactual) Then
            MessageBox.Show("La contraseña actual que capturaste no es correcta. Verifique")
        Else
            If (txtNuevaContraseña.Text <> txtConfirmarContraseña.Text) Then
                MessageBox.Show("La confirmacion de la contraseña que capturaste es diferente a la nueva contraseña. Verifique")
            Else
                Try
                    Dim conexion As New OleDbConnection
                    conexion.ConnectionString = Ruta

                    Dim SentSQLUpdate As String
                    SentSQLUpdate = "UPDATE USUARIOS SET USUARIO='" & txtUsuario.Text & "', CONTRASEÑA='" & txtNuevaContraseña.Text & "', TIPO='" & cboTipo.SelectedItem.ToString & "' WHERE IDEMPLEADO=" & IDBuscado

                    Dim comando As New OleDbCommand(SentSQLUpdate, conexion)
                    conexion.Open()
                    comando.ExecuteNonQuery()

                    MessageBox.Show("Los datos fueron actualizados con exito")
                    conexion.Close()


                    btnAceptar.Enabled = False
                    txtUsuario.Enabled = False
                    txtContraseñaActual.Enabled = False
                    txtNuevaContraseña.Enabled = False
                    txtConfirmarContraseña.Enabled = False
                    chkCaracteres.Enabled = False
                    cboTipo.Enabled = False
                Catch ex As Exception
                    MsgBox(ex.Message.ToString())
                    Exit Sub
                End Try

                Try
                    Dim conexion As New OleDbConnection()
                    conexion.ConnectionString = Ruta

                    Dim SentSQLinsert As String

                    SentSQLinsert = "INSERT INTO OPERACIONES(OPERACION, QUIEN, AQUIEN, FECHA, HORA, NOACCESO) VALUES('CAMBIAR CUENTA'," & IdEmpActivo & "," & txtIdEmp.Text & ",'" & Format(Now, "dd/MM/yyyy") & "','" & Format(Now, "hh:mm") & "'," & Acceso & ")"
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
                    txtContraseñaActual.Clear()
                    txtConfirmarContraseña.Clear()
                    txtNuevaContraseña.Clear()
                    cboTipo.SelectedIndex = -1
                Catch ex As Exception
                    MsgBox(ex.Message.ToString())
                    Exit Sub
                End Try
            End If
        End If
    End Sub

    Private Sub chkCaracteres_CheckedChanged(sender As Object, e As EventArgs) Handles chkCaracteres.CheckedChanged
        If chkCaracteres.Checked = True Then
            txtContraseñaActual.PasswordChar = ""
            txtNuevaContraseña.PasswordChar = ""
            txtConfirmarContraseña.PasswordChar = ""
        Else
            txtContraseñaActual.PasswordChar = "•"
            txtNuevaContraseña.PasswordChar = "•"
            txtConfirmarContraseña.PasswordChar = "•"
        End If
    End Sub
End Class