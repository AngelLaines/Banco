<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambiarCuenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtConfirmarContraseña = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNuevaContraseña = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkCaracteres = New System.Windows.Forms.CheckBox()
        Me.txtContraseñaActual = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtApellidoM = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cboPuesto = New System.Windows.Forms.ComboBox()
        Me.cboEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.cboSexo = New System.Windows.Forms.ComboBox()
        Me.dtpFechNac = New System.Windows.Forms.DateTimePicker()
        Me.txtSueldoM = New System.Windows.Forms.TextBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.txtCodigoP = New System.Windows.Forms.TextBox()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.txtColonia = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.txtNumCasa = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.txtTelCasa = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtCurp = New System.Windows.Forms.TextBox()
        Me.txtApellidoP = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtIdEmp = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cboDepartamento = New System.Windows.Forms.ComboBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(994, 211)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 45)
        Me.btnCancelar.TabIndex = 28
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.Location = New System.Drawing.Point(844, 211)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(100, 45)
        Me.btnAceptar.TabIndex = 27
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboTipo)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtConfirmarContraseña)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtNuevaContraseña)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.chkCaracteres)
        Me.GroupBox2.Controls.Add(Me.txtContraseñaActual)
        Me.GroupBox2.Controls.Add(Me.txtUsuario)
        Me.GroupBox2.Location = New System.Drawing.Point(844, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(261, 193)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de inicio de sesion"
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.Enabled = False
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Items.AddRange(New Object() {"GERENTE", "EJECUTIVO", "VENTANILLA"})
        Me.cboTipo.Location = New System.Drawing.Point(122, 123)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(126, 21)
        Me.cboTipo.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(84, 126)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Tipo"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 100)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Confirmar contraseña"
        '
        'txtConfirmarContraseña
        '
        Me.txtConfirmarContraseña.Enabled = False
        Me.txtConfirmarContraseña.Location = New System.Drawing.Point(122, 97)
        Me.txtConfirmarContraseña.Name = "txtConfirmarContraseña"
        Me.txtConfirmarContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtConfirmarContraseña.Size = New System.Drawing.Size(126, 20)
        Me.txtConfirmarContraseña.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Nueva contraseña"
        '
        'txtNuevaContraseña
        '
        Me.txtNuevaContraseña.Enabled = False
        Me.txtNuevaContraseña.Location = New System.Drawing.Point(122, 71)
        Me.txtNuevaContraseña.Name = "txtNuevaContraseña"
        Me.txtNuevaContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtNuevaContraseña.Size = New System.Drawing.Size(126, 20)
        Me.txtNuevaContraseña.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Contraseña actual"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(73, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Usuario"
        '
        'chkCaracteres
        '
        Me.chkCaracteres.AutoSize = True
        Me.chkCaracteres.Enabled = False
        Me.chkCaracteres.Location = New System.Drawing.Point(122, 160)
        Me.chkCaracteres.Name = "chkCaracteres"
        Me.chkCaracteres.Size = New System.Drawing.Size(114, 17)
        Me.chkCaracteres.TabIndex = 13
        Me.chkCaracteres.Text = "Mostrar caracteres"
        Me.chkCaracteres.UseVisualStyleBackColor = True
        '
        'txtContraseñaActual
        '
        Me.txtContraseñaActual.Enabled = False
        Me.txtContraseñaActual.Location = New System.Drawing.Point(122, 45)
        Me.txtContraseñaActual.Name = "txtContraseñaActual"
        Me.txtContraseñaActual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtContraseñaActual.Size = New System.Drawing.Size(126, 20)
        Me.txtContraseñaActual.TabIndex = 10
        '
        'txtUsuario
        '
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(122, 19)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(126, 20)
        Me.txtUsuario.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboDepartamento)
        Me.GroupBox1.Controls.Add(Me.txtApellidoM)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.cboPuesto)
        Me.GroupBox1.Controls.Add(Me.cboEstadoCivil)
        Me.GroupBox1.Controls.Add(Me.cboSexo)
        Me.GroupBox1.Controls.Add(Me.dtpFechNac)
        Me.GroupBox1.Controls.Add(Me.txtSueldoM)
        Me.GroupBox1.Controls.Add(Me.txtEstado)
        Me.GroupBox1.Controls.Add(Me.txtMunicipio)
        Me.GroupBox1.Controls.Add(Me.txtCodigoP)
        Me.GroupBox1.Controls.Add(Me.txtCiudad)
        Me.GroupBox1.Controls.Add(Me.txtColonia)
        Me.GroupBox1.Controls.Add(Me.txtCalle)
        Me.GroupBox1.Controls.Add(Me.txtNumCasa)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtCelular)
        Me.GroupBox1.Controls.Add(Me.txtTelCasa)
        Me.GroupBox1.Controls.Add(Me.txtEdad)
        Me.GroupBox1.Controls.Add(Me.txtCurp)
        Me.GroupBox1.Controls.Add(Me.txtApellidoP)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.txtIdEmp)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(826, 417)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del empleado"
        '
        'txtApellidoM
        '
        Me.txtApellidoM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellidoM.Enabled = False
        Me.txtApellidoM.Location = New System.Drawing.Point(149, 120)
        Me.txtApellidoM.Name = "txtApellidoM"
        Me.txtApellidoM.Size = New System.Drawing.Size(242, 20)
        Me.txtApellidoM.TabIndex = 315
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(13, 123)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(116, 13)
        Me.Label22.TabIndex = 314
        Me.Label22.Text = "APELLIDO MATERNO"
        '
        'cboPuesto
        '
        Me.cboPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPuesto.Enabled = False
        Me.cboPuesto.FormattingEnabled = True
        Me.cboPuesto.Items.AddRange(New Object() {"GERENTE", "EJECUTIVO", "VENTANILLA", "CAJERO"})
        Me.cboPuesto.Location = New System.Drawing.Point(542, 304)
        Me.cboPuesto.Name = "cboPuesto"
        Me.cboPuesto.Size = New System.Drawing.Size(242, 21)
        Me.cboPuesto.TabIndex = 312
        '
        'cboEstadoCivil
        '
        Me.cboEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstadoCivil.Enabled = False
        Me.cboEstadoCivil.FormattingEnabled = True
        Me.cboEstadoCivil.Items.AddRange(New Object() {"SOLTERO(A)", "CASADO(A)", "DIVORCIADO(A)", "UNION LIBRE"})
        Me.cboEstadoCivil.Location = New System.Drawing.Point(149, 304)
        Me.cboEstadoCivil.Name = "cboEstadoCivil"
        Me.cboEstadoCivil.Size = New System.Drawing.Size(242, 21)
        Me.cboEstadoCivil.TabIndex = 311
        '
        'cboSexo
        '
        Me.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSexo.Enabled = False
        Me.cboSexo.FormattingEnabled = True
        Me.cboSexo.Items.AddRange(New Object() {"MASCULINO", "FEMENINO"})
        Me.cboSexo.Location = New System.Drawing.Point(149, 192)
        Me.cboSexo.Name = "cboSexo"
        Me.cboSexo.Size = New System.Drawing.Size(242, 21)
        Me.cboSexo.TabIndex = 310
        '
        'dtpFechNac
        '
        Me.dtpFechNac.Enabled = False
        Me.dtpFechNac.Location = New System.Drawing.Point(149, 265)
        Me.dtpFechNac.Name = "dtpFechNac"
        Me.dtpFechNac.Size = New System.Drawing.Size(242, 20)
        Me.dtpFechNac.TabIndex = 309
        '
        'txtSueldoM
        '
        Me.txtSueldoM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSueldoM.Enabled = False
        Me.txtSueldoM.Location = New System.Drawing.Point(542, 375)
        Me.txtSueldoM.Name = "txtSueldoM"
        Me.txtSueldoM.Size = New System.Drawing.Size(242, 20)
        Me.txtSueldoM.TabIndex = 308
        '
        'txtEstado
        '
        Me.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEstado.Enabled = False
        Me.txtEstado.Location = New System.Drawing.Point(542, 265)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(242, 20)
        Me.txtEstado.TabIndex = 307
        '
        'txtMunicipio
        '
        Me.txtMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMunicipio.Enabled = False
        Me.txtMunicipio.Location = New System.Drawing.Point(542, 227)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(242, 20)
        Me.txtMunicipio.TabIndex = 306
        '
        'txtCodigoP
        '
        Me.txtCodigoP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoP.Enabled = False
        Me.txtCodigoP.Location = New System.Drawing.Point(542, 192)
        Me.txtCodigoP.Name = "txtCodigoP"
        Me.txtCodigoP.Size = New System.Drawing.Size(242, 20)
        Me.txtCodigoP.TabIndex = 305
        '
        'txtCiudad
        '
        Me.txtCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCiudad.Enabled = False
        Me.txtCiudad.Location = New System.Drawing.Point(542, 155)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(242, 20)
        Me.txtCiudad.TabIndex = 304
        '
        'txtColonia
        '
        Me.txtColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtColonia.Enabled = False
        Me.txtColonia.Location = New System.Drawing.Point(542, 120)
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(242, 20)
        Me.txtColonia.TabIndex = 303
        '
        'txtCalle
        '
        Me.txtCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCalle.Enabled = False
        Me.txtCalle.Location = New System.Drawing.Point(542, 57)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(242, 20)
        Me.txtCalle.TabIndex = 302
        '
        'txtNumCasa
        '
        Me.txtNumCasa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumCasa.Enabled = False
        Me.txtNumCasa.Location = New System.Drawing.Point(542, 87)
        Me.txtNumCasa.Name = "txtNumCasa"
        Me.txtNumCasa.Size = New System.Drawing.Size(242, 20)
        Me.txtNumCasa.TabIndex = 301
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(542, 27)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(242, 20)
        Me.txtEmail.TabIndex = 300
        '
        'txtCelular
        '
        Me.txtCelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCelular.Enabled = False
        Me.txtCelular.Location = New System.Drawing.Point(149, 375)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(242, 20)
        Me.txtCelular.TabIndex = 299
        '
        'txtTelCasa
        '
        Me.txtTelCasa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelCasa.Enabled = False
        Me.txtTelCasa.Location = New System.Drawing.Point(149, 340)
        Me.txtTelCasa.Name = "txtTelCasa"
        Me.txtTelCasa.Size = New System.Drawing.Size(242, 20)
        Me.txtTelCasa.TabIndex = 298
        '
        'txtEdad
        '
        Me.txtEdad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEdad.Enabled = False
        Me.txtEdad.Location = New System.Drawing.Point(149, 227)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(242, 20)
        Me.txtEdad.TabIndex = 297
        '
        'txtCurp
        '
        Me.txtCurp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCurp.Enabled = False
        Me.txtCurp.Location = New System.Drawing.Point(149, 155)
        Me.txtCurp.Name = "txtCurp"
        Me.txtCurp.Size = New System.Drawing.Size(242, 20)
        Me.txtCurp.TabIndex = 296
        '
        'txtApellidoP
        '
        Me.txtApellidoP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellidoP.Enabled = False
        Me.txtApellidoP.Location = New System.Drawing.Point(149, 90)
        Me.txtApellidoP.Name = "txtApellidoP"
        Me.txtApellidoP.Size = New System.Drawing.Size(242, 20)
        Me.txtApellidoP.TabIndex = 295
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(149, 57)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(242, 20)
        Me.txtNombre.TabIndex = 294
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(424, 378)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(106, 13)
        Me.Label21.TabIndex = 293
        Me.Label21.Text = "SUELDO MENSUAL"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(424, 343)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(97, 13)
        Me.Label20.TabIndex = 292
        Me.Label20.Text = "DEPARTAMENTO"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(424, 307)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(51, 13)
        Me.Label19.TabIndex = 291
        Me.Label19.Text = "PUESTO"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(424, 268)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 13)
        Me.Label18.TabIndex = 290
        Me.Label18.Text = "ESTADO"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(424, 230)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 13)
        Me.Label17.TabIndex = 289
        Me.Label17.Text = "MUNICIPIO"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(424, 195)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(94, 13)
        Me.Label16.TabIndex = 288
        Me.Label16.Text = "CODIGO POSTAL"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(424, 158)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 13)
        Me.Label15.TabIndex = 287
        Me.Label15.Text = "CIUDAD"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(424, 123)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 13)
        Me.Label14.TabIndex = 286
        Me.Label14.Text = "COLONIA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(424, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 285
        Me.Label1.Text = "NUMERO DE CASA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(424, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 284
        Me.Label2.Text = "CALLE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(406, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 13)
        Me.Label3.TabIndex = 283
        Me.Label3.Text = "CORREO ELECTRONICO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 378)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 282
        Me.Label4.Text = "CELULAR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 343)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 13)
        Me.Label5.TabIndex = 281
        Me.Label5.Text = "TELEFONO DE CASA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 307)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 280
        Me.Label8.Text = "ESTADO CIVIL"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 13)
        Me.Label7.TabIndex = 279
        Me.Label7.Text = "FECHA DE NACIMIENTO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 278
        Me.Label6.Text = "EDAD"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(13, 195)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(36, 13)
        Me.Label23.TabIndex = 277
        Me.Label23.Text = "SEXO"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(13, 158)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(37, 13)
        Me.Label24.TabIndex = 276
        Me.Label24.Text = "CURP"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(13, 93)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(114, 13)
        Me.Label25.TabIndex = 275
        Me.Label25.Text = "APELLIDO PATERNO"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(13, 60)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(54, 13)
        Me.Label26.TabIndex = 274
        Me.Label26.Text = "NOMBRE"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(283, 25)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(108, 27)
        Me.btnBuscar.TabIndex = 100
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtIdEmp
        '
        Me.txtIdEmp.Location = New System.Drawing.Point(149, 28)
        Me.txtIdEmp.Name = "txtIdEmp"
        Me.txtIdEmp.Size = New System.Drawing.Size(128, 20)
        Me.txtIdEmp.TabIndex = 97
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(13, 31)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(80, 13)
        Me.Label27.TabIndex = 94
        Me.Label27.Text = "ID EMPLEADO"
        '
        'cboDepartamento
        '
        Me.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepartamento.Enabled = False
        Me.cboDepartamento.FormattingEnabled = True
        Me.cboDepartamento.Items.AddRange(New Object() {"DEPARTAMENTO DE GERENCIA", "DEPARTAMENTO EJECUTIVO", "VENTANILLA"})
        Me.cboDepartamento.Location = New System.Drawing.Point(542, 340)
        Me.cboDepartamento.Name = "cboDepartamento"
        Me.cboDepartamento.Size = New System.Drawing.Size(242, 21)
        Me.cboDepartamento.TabIndex = 316
        '
        'frmCambiarCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 440)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.MaximizeBox = False
        Me.Name = "frmCambiarCuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambiar Contraseña"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtConfirmarContraseña As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtNuevaContraseña As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chkCaracteres As System.Windows.Forms.CheckBox
    Friend WithEvents txtContraseñaActual As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtIdEmp As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtApellidoM As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cboPuesto As System.Windows.Forms.ComboBox
    Friend WithEvents cboEstadoCivil As System.Windows.Forms.ComboBox
    Friend WithEvents cboSexo As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFechNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtSueldoM As System.Windows.Forms.TextBox
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents txtMunicipio As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoP As System.Windows.Forms.TextBox
    Friend WithEvents txtCiudad As System.Windows.Forms.TextBox
    Friend WithEvents txtColonia As System.Windows.Forms.TextBox
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents txtNumCasa As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtCelular As System.Windows.Forms.TextBox
    Friend WithEvents txtTelCasa As System.Windows.Forms.TextBox
    Friend WithEvents txtEdad As System.Windows.Forms.TextBox
    Friend WithEvents txtCurp As System.Windows.Forms.TextBox
    Friend WithEvents txtApellidoP As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents cboDepartamento As System.Windows.Forms.ComboBox
End Class
