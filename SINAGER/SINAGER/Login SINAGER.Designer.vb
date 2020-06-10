<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_SINAGER
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_SINAGER))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btnRegistrarse = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LimeGreen
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(206, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenido(a) a SINAGER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LimeGreen
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ingrese el Usuario: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(295, 166)
        Me.txtUsuario.Multiline = True
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(239, 35)
        Me.txtUsuario.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LimeGreen
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(239, 28)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Ingrese la Contraseña:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtContraseña
        '
        Me.txtContraseña.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.Location = New System.Drawing.Point(295, 253)
        Me.txtContraseña.Multiline = True
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(239, 35)
        Me.txtContraseña.TabIndex = 4
        '
        'btnIngresar
        '
        Me.btnIngresar.BackColor = System.Drawing.Color.Turquoise
        Me.btnIngresar.Font = New System.Drawing.Font("Segoe Print", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.Location = New System.Drawing.Point(222, 321)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(141, 51)
        Me.btnIngresar.TabIndex = 5
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'btnRegistrarse
        '
        Me.btnRegistrarse.BackColor = System.Drawing.Color.Khaki
        Me.btnRegistrarse.Font = New System.Drawing.Font("Segoe Print", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarse.Location = New System.Drawing.Point(32, 397)
        Me.btnRegistrarse.Name = "btnRegistrarse"
        Me.btnRegistrarse.Size = New System.Drawing.Size(157, 51)
        Me.btnRegistrarse.TabIndex = 6
        Me.btnRegistrarse.Text = "Registrarse "
        Me.btnRegistrarse.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Tomato
        Me.btnSalir.Font = New System.Drawing.Font("Segoe Print", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(393, 397)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(141, 51)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir "
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.SINAGER.My.Resources.Resources.login
        Me.PictureBox1.Location = New System.Drawing.Point(20, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(168, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(233, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(308, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Nota: Debe registrarse antes de ingresar"
        '
        'Login_SINAGER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.ClientSize = New System.Drawing.Size(568, 476)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnRegistrarse)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login_SINAGER"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login SINAGER "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents btnRegistrarse As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
End Class
