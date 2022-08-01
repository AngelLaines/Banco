<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActualizarDatosEmp
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
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtIdEmp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtApellidoM = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
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
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboDepartamento = New System.Windows.Forms.ComboBox()
        Me.cboPuesto = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(284, 20)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(108, 27)
        Me.btnBuscar.TabIndex = 140
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(153, 418)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(108, 48)
        Me.btnCancelar.TabIndex = 139
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(22, 418)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(108, 48)
        Me.btnGuardar.TabIndex = 138
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtIdEmp
        '
        Me.txtIdEmp.Location = New System.Drawing.Point(150, 23)
        Me.txtIdEmp.Name = "txtIdEmp"
        Me.txtIdEmp.Size = New System.Drawing.Size(128, 20)
        Me.txtIdEmp.TabIndex = 116
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "ID EMPLEADO"
        '
        'txtApellidoM
        '
        Me.txtApellidoM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellidoM.Enabled = False
        Me.txtApellidoM.Location = New System.Drawing.Point(150, 116)
        Me.txtApellidoM.Name = "txtApellidoM"
        Me.txtApellidoM.Size = New System.Drawing.Size(242, 20)
        Me.txtApellidoM.TabIndex = 184
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(14, 119)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(116, 13)
        Me.Label22.TabIndex = 183
        Me.Label22.Text = "APELLIDO MATERNO"
        '
        'cboEstadoCivil
        '
        Me.cboEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstadoCivil.Enabled = False
        Me.cboEstadoCivil.FormattingEnabled = True
        Me.cboEstadoCivil.Items.AddRange(New Object() {"SOLTERO(A)", "CASADO(A)", "DIVORCIADO(A)", "UNION LIBRE"})
        Me.cboEstadoCivil.Location = New System.Drawing.Point(150, 300)
        Me.cboEstadoCivil.Name = "cboEstadoCivil"
        Me.cboEstadoCivil.Size = New System.Drawing.Size(242, 21)
        Me.cboEstadoCivil.TabIndex = 180
        '
        'cboSexo
        '
        Me.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSexo.Enabled = False
        Me.cboSexo.FormattingEnabled = True
        Me.cboSexo.Items.AddRange(New Object() {"MASCULINO", "FEMENINO"})
        Me.cboSexo.Location = New System.Drawing.Point(150, 188)
        Me.cboSexo.Name = "cboSexo"
        Me.cboSexo.Size = New System.Drawing.Size(242, 21)
        Me.cboSexo.TabIndex = 179
        '
        'dtpFechNac
        '
        Me.dtpFechNac.Enabled = False
        Me.dtpFechNac.Location = New System.Drawing.Point(150, 261)
        Me.dtpFechNac.Name = "dtpFechNac"
        Me.dtpFechNac.Size = New System.Drawing.Size(242, 20)
        Me.dtpFechNac.TabIndex = 178
        '
        'txtSueldoM
        '
        Me.txtSueldoM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSueldoM.Enabled = False
        Me.txtSueldoM.Location = New System.Drawing.Point(543, 371)
        Me.txtSueldoM.Name = "txtSueldoM"
        Me.txtSueldoM.Size = New System.Drawing.Size(242, 20)
        Me.txtSueldoM.TabIndex = 177
        '
        'txtEstado
        '
        Me.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEstado.Enabled = False
        Me.txtEstado.Location = New System.Drawing.Point(543, 261)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(242, 20)
        Me.txtEstado.TabIndex = 176
        '
        'txtMunicipio
        '
        Me.txtMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMunicipio.Enabled = False
        Me.txtMunicipio.Location = New System.Drawing.Point(543, 223)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(242, 20)
        Me.txtMunicipio.TabIndex = 175
        '
        'txtCodigoP
        '
        Me.txtCodigoP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoP.Enabled = False
        Me.txtCodigoP.Location = New System.Drawing.Point(543, 188)
        Me.txtCodigoP.Name = "txtCodigoP"
        Me.txtCodigoP.Size = New System.Drawing.Size(242, 20)
        Me.txtCodigoP.TabIndex = 174
        '
        'txtCiudad
        '
        Me.txtCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCiudad.Enabled = False
        Me.txtCiudad.Location = New System.Drawing.Point(543, 151)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(242, 20)
        Me.txtCiudad.TabIndex = 173
        '
        'txtColonia
        '
        Me.txtColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtColonia.Enabled = False
        Me.txtColonia.Location = New System.Drawing.Point(543, 116)
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(242, 20)
        Me.txtColonia.TabIndex = 172
        '
        'txtCalle
        '
        Me.txtCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCalle.Enabled = False
        Me.txtCalle.Location = New System.Drawing.Point(543, 53)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(242, 20)
        Me.txtCalle.TabIndex = 171
        '
        'txtNumCasa
        '
        Me.txtNumCasa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumCasa.Enabled = False
        Me.txtNumCasa.Location = New System.Drawing.Point(543, 83)
        Me.txtNumCasa.Name = "txtNumCasa"
        Me.txtNumCasa.Size = New System.Drawing.Size(242, 20)
        Me.txtNumCasa.TabIndex = 170
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(543, 23)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(242, 20)
        Me.txtEmail.TabIndex = 169
        '
        'txtCelular
        '
        Me.txtCelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCelular.Enabled = False
        Me.txtCelular.Location = New System.Drawing.Point(150, 371)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(242, 20)
        Me.txtCelular.TabIndex = 168
        '
        'txtTelCasa
        '
        Me.txtTelCasa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelCasa.Enabled = False
        Me.txtTelCasa.Location = New System.Drawing.Point(150, 336)
        Me.txtTelCasa.Name = "txtTelCasa"
        Me.txtTelCasa.Size = New System.Drawing.Size(242, 20)
        Me.txtTelCasa.TabIndex = 167
        '
        'txtEdad
        '
        Me.txtEdad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEdad.Enabled = False
        Me.txtEdad.Location = New System.Drawing.Point(150, 223)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(242, 20)
        Me.txtEdad.TabIndex = 166
        '
        'txtCurp
        '
        Me.txtCurp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCurp.Enabled = False
        Me.txtCurp.Location = New System.Drawing.Point(150, 151)
        Me.txtCurp.Name = "txtCurp"
        Me.txtCurp.Size = New System.Drawing.Size(242, 20)
        Me.txtCurp.TabIndex = 165
        '
        'txtApellidoP
        '
        Me.txtApellidoP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellidoP.Enabled = False
        Me.txtApellidoP.Location = New System.Drawing.Point(150, 86)
        Me.txtApellidoP.Name = "txtApellidoP"
        Me.txtApellidoP.Size = New System.Drawing.Size(242, 20)
        Me.txtApellidoP.TabIndex = 164
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(150, 53)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(242, 20)
        Me.txtNombre.TabIndex = 163
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(425, 374)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(106, 13)
        Me.Label21.TabIndex = 161
        Me.Label21.Text = "SUELDO MENSUAL"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(425, 339)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(97, 13)
        Me.Label20.TabIndex = 160
        Me.Label20.Text = "DEPARTAMENTO"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(425, 303)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(51, 13)
        Me.Label19.TabIndex = 159
        Me.Label19.Text = "PUESTO"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(425, 264)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 13)
        Me.Label18.TabIndex = 158
        Me.Label18.Text = "ESTADO"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(425, 226)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 13)
        Me.Label17.TabIndex = 157
        Me.Label17.Text = "MUNICIPIO"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(425, 191)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(94, 13)
        Me.Label16.TabIndex = 156
        Me.Label16.Text = "CODIGO POSTAL"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(425, 154)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 13)
        Me.Label15.TabIndex = 155
        Me.Label15.Text = "CIUDAD"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(425, 119)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 13)
        Me.Label14.TabIndex = 154
        Me.Label14.Text = "COLONIA"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(425, 86)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 13)
        Me.Label13.TabIndex = 153
        Me.Label13.Text = "NUMERO DE CASA"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(425, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 152
        Me.Label12.Text = "CALLE"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(407, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(132, 13)
        Me.Label11.TabIndex = 151
        Me.Label11.Text = "CORREO ELECTRONICO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 374)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 150
        Me.Label10.Text = "CELULAR"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 339)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 13)
        Me.Label9.TabIndex = 149
        Me.Label9.Text = "TELEFONO DE CASA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 303)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 148
        Me.Label8.Text = "ESTADO CIVIL"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 264)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 13)
        Me.Label7.TabIndex = 147
        Me.Label7.Text = "FECHA DE NACIMIENTO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 146
        Me.Label6.Text = "EDAD"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 145
        Me.Label5.Text = "SEXO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 144
        Me.Label4.Text = "CURP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 13)
        Me.Label3.TabIndex = 143
        Me.Label3.Text = "APELLIDO PATERNO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 142
        Me.Label2.Text = "NOMBRE"
        '
        'cboDepartamento
        '
        Me.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepartamento.FormattingEnabled = True
        Me.cboDepartamento.Items.AddRange(New Object() {"DEPARTAMENTO DE GERENCIA", "DEPARTAMENTO EJECUTIVO", "VENTANILLA"})
        Me.cboDepartamento.Location = New System.Drawing.Point(543, 336)
        Me.cboDepartamento.Name = "cboDepartamento"
        Me.cboDepartamento.Size = New System.Drawing.Size(242, 21)
        Me.cboDepartamento.TabIndex = 186
        '
        'cboPuesto
        '
        Me.cboPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPuesto.FormattingEnabled = True
        Me.cboPuesto.Items.AddRange(New Object() {"GERENTE", "EJECUTIVO", "VENTANILLA"})
        Me.cboPuesto.Location = New System.Drawing.Point(543, 300)
        Me.cboPuesto.Name = "cboPuesto"
        Me.cboPuesto.Size = New System.Drawing.Size(242, 21)
        Me.cboPuesto.TabIndex = 185
        '
        'frmActualizarDatosEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 488)
        Me.Controls.Add(Me.cboDepartamento)
        Me.Controls.Add(Me.cboPuesto)
        Me.Controls.Add(Me.txtApellidoM)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.cboEstadoCivil)
        Me.Controls.Add(Me.cboSexo)
        Me.Controls.Add(Me.dtpFechNac)
        Me.Controls.Add(Me.txtSueldoM)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.txtMunicipio)
        Me.Controls.Add(Me.txtCodigoP)
        Me.Controls.Add(Me.txtCiudad)
        Me.Controls.Add(Me.txtColonia)
        Me.Controls.Add(Me.txtCalle)
        Me.Controls.Add(Me.txtNumCasa)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtCelular)
        Me.Controls.Add(Me.txtTelCasa)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.txtCurp)
        Me.Controls.Add(Me.txtApellidoP)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtIdEmp)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frmActualizarDatosEmp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar datos de empleado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents txtIdEmp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtApellidoM As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
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
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents cboPuesto As System.Windows.Forms.ComboBox
End Class
