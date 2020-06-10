Public Class Login_SINAGER

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim Usuario, Contraseña As String
        Dim UsuarioMin As String

        Usuario = Module1.usuario
        Contraseña = Module1.contraseña


        UsuarioMin = Usuario

        If (Usuario = Module1.usuario) AndAlso (UsuarioMin = Module1.usuario) Then
            Ingreso_de_Usuario__SINAGER_.Show()
            Me.Hide()
        ElseIf Usuario <> Usuario Then
            MessageBox.Show("El usuario es incorrecto o no esta Registrado", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If (Contraseña <> Module1.contraseña) Then
            MessageBox.Show("Contraseña Incorrecta", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Contraseña = ""
        Else
            Ingreso_de_Usuario__SINAGER_.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click
        Module1.usuario = InputBox("Ingrese nombre de usualrio", "Registro de usuario", vbOKCancel, Module1.usuario)
        Module1.contraseña = InputBox("Ingrese contraseña de usualrio", "Registro de usuario", vbOKCancel)
        MessageBox.Show("Usuario Registrado Correctaente", "Registro de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("¿Seguro que desea salir?", vbQuestion + vbYesNo, "Salir del Login") = vbYes Then
            End
        End If
        Module1.usuario = ""
        Module1.contraseña = ""
    End Sub
End Class
