Imports System.Data
Imports System.Data.OleDb
Public Class frmBajaEmp

    Public IDBuscado As Integer
    Private Sub btnBuscar_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnGuardar_Click_1(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtIdEmp.Text = "" Then
            MsgBox("Falto el campo ID Empleado")
            txtIdEmp.Focus()
            Exit Sub
        End If

        Dim r As String
        r = MsgBox("El empleado con" & Chr(13) & "ID: " & IDBuscado & Chr(13) & "NOMBRE: " & txtNombre.Text & Chr(13) & "Apellidos: " & txtApellidoP.Text & " " & txtApellidoM.Text & Chr(13) & "Sera eliminado. ¿Esta seguro?", vbYesNo)
        If r = vbYes Then
            Try
                Dim conexion As New OleDbConnection
                conexion.ConnectionString = Ruta

                Dim sentSQLDelete As String
                sentSQLDelete = "DELETE FROM EMPLEADOS WHERE IDEMPLEADO=" & IDBuscado

                Dim comando As New OleDbCommand(sentSQLDelete, conexion)

                conexion.Open()
                comando.ExecuteNonQuery()

                MessageBox.Show("Los datos se han eliminado con exito.", "Datos eliminados...")

                conexion.Close()


                btnGuardar.Enabled = False

            Catch ex As Exception
                MsgBox(ex.Message.ToString())
                Exit Sub
            End Try

            Try
                Dim conexion As New OleDbConnection()
                conexion.ConnectionString = Ruta

                Dim SentSQLinsert As String

                SentSQLinsert = "INSERT INTO OPERACIONES(OPERACION, QUIEN, AQUIEN, FECHA, HORA, NOACCESO) VALUES('BAJA EMPLEADO'," & IdEmpActivo & "," & txtIdEmp.Text & ",'" & Format(Now, "dd/MM/yyyy") & "','" & Format(Now, "hh:mm") & "'," & Acceso & ")"
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
        End If
    End Sub

    Private Sub btnCancelar_Click_1(sender As Object, e As EventArgs) Handles btnCancelar.Click
        frmMenu.Show()
        Me.Close()
    End Sub

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


            End If

            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    
    Private Sub frmBajaEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class