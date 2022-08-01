Imports System.Data
Imports System.Data.OleDb
Public Class frmEliminarCuenta

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
                txtContraseña.DataBindings.Add("text", MiConsulta, "CONTRASEÑA")
                cboTipo.DataBindings.Add("text", MiConsulta, "TIPO")



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
                txtContraseña.DataBindings.Clear()
                cboTipo.DataBindings.Clear()

                chkCaracteres.Enabled = True
            End If

            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub chkCaracteres_CheckedChanged(sender As Object, e As EventArgs) Handles chkCaracteres.CheckedChanged
        If chkCaracteres.Checked = True Then
            txtContraseña.PasswordChar = ""
        Else
            txtContraseña.PasswordChar = "•"
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim r As String
        r = MsgBox("La cuenta de usuario del empleado " & txtNombre.Text & " " & txtApellidoP.Text & " " & txtApellidoM.Text & Chr(13) & "sera eliminada de forma permanente. ¿Esta seguro?", vbYesNo)

        If r = vbYes Then

            Try
                Dim conexion As New OleDbConnection
                conexion.ConnectionString = Ruta

                Dim sentSQLDelete As String
                sentSQLDelete = "DELETE FROM USUARIOS WHERE IDEMPLEADO=" & IDBuscado

                Dim comando As New OleDbCommand(sentSQLDelete, conexion)

                conexion.Open()
                comando.ExecuteNonQuery()

                MessageBox.Show("La cuenta de usuario ha sido eliminada con exito", "Eliminar cuenta...")

                conexion.Close()



                btnAceptar.Enabled = False
                txtContraseña.Enabled = False
                chkCaracteres.Enabled = False
            Catch ex As Exception
                MsgBox(ex.Message.ToString())
                Exit Sub
            End Try

            Try
                Dim conexion As New OleDbConnection()
                conexion.ConnectionString = Ruta

                Dim SentSQLinsert As String

                SentSQLinsert = "INSERT INTO OPERACIONES(OPERACION, QUIEN, AQUIEN, FECHA, HORA, NUM_ACCESO) VALUES('ELIMINAR CUENTA'," & IdEmpActivo & "," & txtIdEmp.Text & ",'" & Format(Now, "dd/MM/yyyy") & "','" & Format(Now, "hh:mm") & "'," & Acceso & ")"
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
                cboTipo.SelectedIndex = -1
            Catch ex As Exception
                MsgBox(ex.Message.ToString())
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        frmMenu.Show()
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class