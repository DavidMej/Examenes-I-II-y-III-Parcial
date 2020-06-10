<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingreso_de_Usuario__SINAGER_
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingreso_de_Usuario__SINAGER_))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtMunicipios = New System.Windows.Forms.TextBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.cmbDepartamentos = New System.Windows.Forms.ComboBox()
        Me.chkPositivo = New System.Windows.Forms.CheckBox()
        Me.chkNegativo = New System.Windows.Forms.CheckBox()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lsbCasosxDepto = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.chkRecuperado = New System.Windows.Forms.CheckBox()
        Me.chkMuerto = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtActivos = New System.Windows.Forms.TextBox()
        Me.txtRecuperados = New System.Windows.Forms.TextBox()
        Me.txtMuertos = New System.Windows.Forms.TextBox()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPositivos = New System.Windows.Forms.TextBox()
        Me.txtNegativos = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(252, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese sus datos personales:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Edad:" & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Departamento:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 326)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 28)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Municipio:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(51, 417)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(251, 28)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Resultado de la Prueba:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(175, 98)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(271, 31)
        Me.txtNombre.TabIndex = 6
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(175, 177)
        Me.txtEdad.Multiline = True
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(127, 28)
        Me.txtEdad.TabIndex = 7
        '
        'txtMunicipios
        '
        Me.txtMunicipios.Location = New System.Drawing.Point(194, 323)
        Me.txtMunicipios.Multiline = True
        Me.txtMunicipios.Name = "txtMunicipios"
        Me.txtMunicipios.Size = New System.Drawing.Size(205, 31)
        Me.txtMunicipios.TabIndex = 9
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnRegistrar.Font = New System.Drawing.Font("Segoe Print", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.Location = New System.Drawing.Point(517, 102)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(148, 45)
        Me.btnRegistrar.TabIndex = 11
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.Chartreuse
        Me.btnNuevo.Font = New System.Drawing.Font("Segoe Print", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(517, 202)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(148, 45)
        Me.btnNuevo.TabIndex = 12
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'cmbDepartamentos
        '
        Me.cmbDepartamentos.FormattingEnabled = True
        Me.cmbDepartamentos.Items.AddRange(New Object() {"1) Atlantida ", "2) Choluteca ", "3) Colón ", "4) Comayacgua ", "5) Copán ", "6) Cortes ", "7) El Paraiso ", "8) Francisco Morazan ", "9) Gracias a Dios ", "10) Intibuca ", "11) La paz ", "12) Lempira ", "13) Ocotepeque ", "14) Olancho", "15) Santa Barbara ", "16) Valle", "17) Yoro ", "18) Islas de la Bahia ", ""})
        Me.cmbDepartamentos.Location = New System.Drawing.Point(236, 250)
        Me.cmbDepartamentos.Name = "cmbDepartamentos"
        Me.cmbDepartamentos.Size = New System.Drawing.Size(198, 28)
        Me.cmbDepartamentos.TabIndex = 13
        '
        'chkPositivo
        '
        Me.chkPositivo.AutoSize = True
        Me.chkPositivo.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPositivo.Location = New System.Drawing.Point(318, 418)
        Me.chkPositivo.Name = "chkPositivo"
        Me.chkPositivo.Size = New System.Drawing.Size(102, 27)
        Me.chkPositivo.TabIndex = 14
        Me.chkPositivo.Text = "Positivo"
        Me.chkPositivo.UseVisualStyleBackColor = True
        '
        'chkNegativo
        '
        Me.chkNegativo.AutoSize = True
        Me.chkNegativo.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNegativo.Location = New System.Drawing.Point(455, 421)
        Me.chkNegativo.Name = "chkNegativo"
        Me.chkNegativo.Size = New System.Drawing.Size(109, 27)
        Me.chkNegativo.TabIndex = 15
        Me.chkNegativo.Text = "Negativo"
        Me.chkNegativo.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.Color.Tomato
        Me.btnRegresar.Font = New System.Drawing.Font("Segoe Print", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresar.Location = New System.Drawing.Point(517, 298)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(148, 45)
        Me.btnRegresar.TabIndex = 16
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SandyBrown
        Me.GroupBox1.Controls.Add(Me.lsbCasosxDepto)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(714, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(510, 511)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "     Historial de Casos por Departamento:"
        '
        'lsbCasosxDepto
        '
        Me.lsbCasosxDepto.FormattingEnabled = True
        Me.lsbCasosxDepto.ItemHeight = 23
        Me.lsbCasosxDepto.Location = New System.Drawing.Point(29, 44)
        Me.lsbCasosxDepto.Name = "lsbCasosxDepto"
        Me.lsbCasosxDepto.Size = New System.Drawing.Size(454, 441)
        Me.lsbCasosxDepto.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(51, 488)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(217, 28)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Estado del Paciente:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.Location = New System.Drawing.Point(285, 489)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(88, 27)
        Me.chkActivo.TabIndex = 19
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'chkRecuperado
        '
        Me.chkRecuperado.AutoSize = True
        Me.chkRecuperado.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRecuperado.Location = New System.Drawing.Point(399, 489)
        Me.chkRecuperado.Name = "chkRecuperado"
        Me.chkRecuperado.Size = New System.Drawing.Size(135, 27)
        Me.chkRecuperado.TabIndex = 20
        Me.chkRecuperado.Text = "Recuperado"
        Me.chkRecuperado.UseVisualStyleBackColor = True
        '
        'chkMuerto
        '
        Me.chkMuerto.AutoSize = True
        Me.chkMuerto.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMuerto.Location = New System.Drawing.Point(567, 488)
        Me.chkMuerto.Name = "chkMuerto"
        Me.chkMuerto.Size = New System.Drawing.Size(98, 27)
        Me.chkMuerto.TabIndex = 21
        Me.chkMuerto.Text = "Muerto"
        Me.chkMuerto.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(51, 557)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 28)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Descripcion:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(199, 543)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(365, 110)
        Me.txtDescripcion.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(738, 566)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 28)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Activos:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(709, 612)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(148, 28)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Recuperados:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(868, 666)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 28)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Muertos:"
        '
        'txtActivos
        '
        Me.txtActivos.Location = New System.Drawing.Point(846, 566)
        Me.txtActivos.Multiline = True
        Me.txtActivos.Name = "txtActivos"
        Me.txtActivos.Size = New System.Drawing.Size(66, 28)
        Me.txtActivos.TabIndex = 27
        '
        'txtRecuperados
        '
        Me.txtRecuperados.Location = New System.Drawing.Point(873, 612)
        Me.txtRecuperados.Multiline = True
        Me.txtRecuperados.Name = "txtRecuperados"
        Me.txtRecuperados.Size = New System.Drawing.Size(66, 28)
        Me.txtRecuperados.TabIndex = 28
        '
        'txtMuertos
        '
        Me.txtMuertos.Location = New System.Drawing.Point(997, 666)
        Me.txtMuertos.Multiline = True
        Me.txtMuertos.Name = "txtMuertos"
        Me.txtMuertos.Size = New System.Drawing.Size(66, 28)
        Me.txtMuertos.TabIndex = 29
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1031, 566)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 28)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Positivos:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(1031, 609)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(118, 28)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Negativos:"
        '
        'txtPositivos
        '
        Me.txtPositivos.Location = New System.Drawing.Point(1158, 566)
        Me.txtPositivos.Multiline = True
        Me.txtPositivos.Name = "txtPositivos"
        Me.txtPositivos.Size = New System.Drawing.Size(66, 28)
        Me.txtPositivos.TabIndex = 32
        '
        'txtNegativos
        '
        Me.txtNegativos.Location = New System.Drawing.Point(1158, 609)
        Me.txtNegativos.Multiline = True
        Me.txtNegativos.Name = "txtNegativos"
        Me.txtNegativos.Size = New System.Drawing.Size(66, 28)
        Me.txtNegativos.TabIndex = 33
        '
        'Ingreso_de_Usuario__SINAGER_
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SandyBrown
        Me.ClientSize = New System.Drawing.Size(1249, 703)
        Me.Controls.Add(Me.txtNegativos)
        Me.Controls.Add(Me.txtPositivos)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtMuertos)
        Me.Controls.Add(Me.txtRecuperados)
        Me.Controls.Add(Me.txtActivos)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.chkMuerto)
        Me.Controls.Add(Me.chkRecuperado)
        Me.Controls.Add(Me.chkActivo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.chkNegativo)
        Me.Controls.Add(Me.chkPositivo)
        Me.Controls.Add(Me.cmbDepartamentos)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.txtMunicipios)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ingreso_de_Usuario__SINAGER_"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso_de_Usuario__SINAGER_"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents txtMunicipios As TextBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents cmbDepartamentos As ComboBox
    Friend WithEvents chkPositivo As CheckBox
    Friend WithEvents chkNegativo As CheckBox
    Friend WithEvents btnRegresar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents chkRecuperado As CheckBox
    Friend WithEvents chkMuerto As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtActivos As TextBox
    Friend WithEvents txtRecuperados As TextBox
    Friend WithEvents lsbCasosxDepto As ListBox
    Friend WithEvents txtMuertos As TextBox
    Friend WithEvents erroricono As ErrorProvider
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents txtNegativos As TextBox
    Friend WithEvents txtPositivos As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
End Class
