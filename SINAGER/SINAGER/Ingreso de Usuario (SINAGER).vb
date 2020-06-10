Imports System.ComponentModel

Public Class Ingreso_de_Usuario__SINAGER_

    Dim No_Deptos(18, 2000) As String
    Dim Total As Integer
    Dim nombre As String
    Dim edad As Integer
    Dim resultadoPrueba As String
    Dim descripcion, muni, estadoPaciente As String
    Dim d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, d13, d14, d15, d16, d17, d18 As Integer
    Dim totalActivos, totalRecuperados, totalMuertos, totalPositivos, totalNegativos As Integer

    Private Sub Pacient()

        nombre = txtNombre.Text
        muni = txtMunicipios.Text
        edad = Val(txtEdad.Text)


        If chkPositivo.Checked = True Then

            If chkActivo.Checked = True Then
                totalActivos += 1
                totalPositivos += 1
                estadoPaciente = "Activo"
            ElseIf chkMuerto.Checked = True Then
                totalMuertos += 1
                estadoPaciente = "Muerto"
            End If
        End If
        If chkNegativo.Checked = True And chkRecuperado.Checked = True Then
            totalRecuperados += 1
            totalNegativos += 1
            estadoPaciente = "Recuperado"
        ElseIf chkNegativo.Checked = True Then
            totalNegativos += 1
            estadoPaciente = "Negativo"
        End If

        txtActivos.Text = totalActivos
        txtPositivos.Text = totalPositivos
        txtNegativos.Text = totalNegativos
        txtRecuperados.Text = totalRecuperados
        txtMuertos.Text = totalMuertos



    End Sub


    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        Try
            If Me.ValidateChildren And txtNombre.Text <> String.Empty And Val(txtEdad.Text) - Int(Val(txtEdad.Text)) = 0 Then
                MessageBox.Show("Datos Registrados Correctamente", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("Ingrese correctamente algunos Datos remarcados", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Select Case cmbDepartamentos.SelectedIndex
            Case 0
                nombre = txtNombre.Text
                muni = txtMunicipios.Text
                edad = txtEdad.Text
                Pacient()
                d1 += 1
                No_Deptos(1, d1) = nombre & "," & edad & "años, " & "Estado: " & estadoPaciente & "Depto: Atlantida"
                lsbCasosxDepto.Items.Add(No_Deptos(1, d1))
            Case 1
                nombre = txtNombre.Text
                muni = txtMunicipios.Text
                edad = txtEdad.Text
                Pacient()
                d2 += 1
                No_Deptos(2, d2) = nombre & "," & edad & "años, " & "Estado: " & estadoPaciente & "Depto: Choluteca"
                lsbCasosxDepto.Items.Add(No_Deptos(2, d2))
            Case 2
                nombre = txtNombre.Text
                muni = txtMunicipios.Text
                edad = txtEdad.Text
                Pacient()
                d3 += 1
                No_Deptos(3, d3) = nombre & "," & edad & "años, " & "Estado: " & estadoPaciente & "Depto: Colon"
                lsbCasosxDepto.Items.Add(No_Deptos(3, d3))
            Case 3
                nombre = txtNombre.Text
                muni = txtMunicipios.Text
                edad = txtEdad.Text
                Pacient()
                d4 += 1
                No_Deptos(4, d4) = nombre & "," & edad & "años, " & "Estado: " & estadoPaciente & "Depto: Comayagua"
                lsbCasosxDepto.Items.Add(No_Deptos(4, d4))
            Case 4
                nombre = txtNombre.Text
                muni = txtMunicipios.Text
                edad = txtEdad.Text
                Pacient()
                d5 += 1
                No_Deptos(5, d5) = nombre & "," & edad & "años, " & "Estado: " & estadoPaciente & "Depto: Copan"
                lsbCasosxDepto.Items.Add(No_Deptos(5, d5))
            Case 5
                nombre = txtNombre.Text
                muni = txtMunicipios.Text
                edad = txtEdad.Text
                Pacient()
                d6 += 1
                No_Deptos(6, d6) = nombre & "," & edad & "años, " & "Estado: " & estadoPaciente & "Depto: Cortes"
                lsbCasosxDepto.Items.Add(No_Deptos(6, d6))
            Case 6
                nombre = txtNombre.Text
                muni = txtMunicipios.Text
                edad = txtEdad.Text
                Pacient()
                d7 += 1
                No_Deptos(7, d7) = nombre & "," & edad & "años, " & "Estado: " & estadoPaciente & "Depto: El Paraiso"
                lsbCasosxDepto.Items.Add(No_Deptos(7, d7))
            Case 7
                nombre = txtNombre.Text
                muni = txtMunicipios.Text
                edad = txtEdad.Text
                Pacient()
                d8 += 1
                No_Deptos(8, d8) = nombre & "," & edad & "años, " & "Estado: " & estadoPaciente & "Depto: Francisco Morazan"
                lsbCasosxDepto.Items.Add(No_Deptos(8, d8))
            Case 8
                nombre = txtNombre.Text
                muni = txtMunicipios.Text
                edad = txtEdad.Text
                Pacient()
                d9 += 1
                No_Deptos(9, d9) = nombre & "," & edad & "años, " & "Estado: " & estadoPaciente & "Depto: Gracias a Dios"
                lsbCasosxDepto.Items.Add(No_Deptos(9, d9))
            Case 9
                nombre = txtNombre.Text
                muni = txtMunicipios.Text
                edad = txtEdad.Text
                Pacient()
                d10 += 1
                No_Deptos(10, d10) = nombre & "," & edad & "años, " & "Estado: " & estadoPaciente & "Depto: Intibuca"
                lsbCasosxDepto.Items.Add(No_Deptos(10, d10))
            Case 10
                nombre = txtNombre.Text
                muni = txtMunicipios.Text
                edad = txtEdad.Text
                Pacient()
                d11 += 1
                No_Deptos(11, d11) = nombre & "," & edad & "años, " & "Estado: " & estadoPaciente & "Depto: La Paz"
                lsbCasosxDepto.Items.Add(No_Deptos(11, d11))
            Case 11
                nombre = txtNombre.Text
                muni = txtMunicipios.Text
                edad = txtEdad.Text
                Pacient()
                d12 = d12 + 1
                No_Deptos(12, d12) = nombre & "," & edad & "años, " & "Estado: " & estadoPaciente & "Depto: Lempira"
                lsbCasosxDepto.Items.Add(No_Deptos(12, d12))
            Case 12
                nombre = txtNombre.Text
                muni = txtMunicipios.Text
                edad = txtEdad.Text
                Pacient()
                d13 += 1
                No_Deptos(13, d13) = nombre & "," & edad & "años, " & "Estado: " & estadoPaciente & "Depto: Ocotepque"
                lsbCasosxDepto.Items.Add(No_Deptos(13, d13))
            Case 13
                nombre = txtNombre.Text
                muni = txtMunicipios.Text
                edad = txtEdad.Text
                Pacient()
                d14 += 1
                No_Deptos(14, d14) = nombre & "," & edad & "años, " & "Estado: " & estadoPaciente & "Depto: Olancho"
                lsbCasosxDepto.Items.Add(No_Deptos(14, d14))
            Case 14
                nombre = txtNombre.Text
                muni = txtMunicipios.Text
                edad = txtEdad.Text
                Pacient()
                d15 += 1
                No_Deptos(15, d15) = nombre & "," & edad & "años, " & "Estado: " & estadoPaciente & "Depto: Santa Barbara"
                lsbCasosxDepto.Items.Add(No_Deptos(15, d15))
            Case 15
                nombre = txtNombre.Text
                muni = txtMunicipios.Text
                edad = txtEdad.Text
                Pacient()
                d16 += 1
                No_Deptos(16, d16) = nombre & "," & edad & "años, " & "Estado: " & estadoPaciente & "Depto: Yoro"
                lsbCasosxDepto.Items.Add(No_Deptos(16, d16))
            Case 16
                nombre = txtNombre.Text
                muni = txtMunicipios.Text
                edad = txtEdad.Text
                Pacient()
                d17 += 1
                No_Deptos(17, d17) = nombre & "," & edad & "años, " & "Estado: " & estadoPaciente & "Depto: Yoro"
                lsbCasosxDepto.Items.Add(No_Deptos(17, d17))
            Case 17
                nombre = txtNombre.Text
                muni = txtMunicipios.Text
                edad = txtEdad.Text
                Pacient()
                d18 += 1
                No_Deptos(18, d18) = nombre & "," & edad & "años, " & "Estado: " & estadoPaciente & "Depto: Islas de la Bahia"
                lsbCasosxDepto.Items.Add(No_Deptos(18, d18))

        End Select

    End Sub

    Private Sub HistorialSINAGER2020(a, b)
        For c = 1 To b Step 1
            lsbCasosxDepto.Items.Add(No_Deptos(a, c))
        Next

    End Sub


    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre del usuario, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtEdad_Validating(sender As Object, e As CancelEventArgs) Handles txtEdad.Validating
        If Val(txtEdad.Text) - Int(Val(txtEdad.Text)) = 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese la edad del usuario, este dato es obligatorio")
        End If
    End Sub

    Private Sub cmbDepartamentos_Validating(sender As Object, e As CancelEventArgs) Handles cmbDepartamentos.Validating
        If DirectCast(sender, ComboBox).SelectedIndex.ToString = 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el Departamento, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtMunicipios_Validating(sender As Object, e As CancelEventArgs) Handles txtMunicipios.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el Municipio, este dato es obligatorio")
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtNombre.Clear()
        txtEdad.Clear()
        cmbDepartamentos.Items.Clear()
        chkPositivo.Checked = False
        chkNegativo.Checked = False
        chkActivo.Checked = False
        chkRecuperado.Checked = False
        chkMuerto.Checked = False
        txtDescripcion.Clear()
        txtMunicipios.Clear()
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Login_SINAGER.Show()
        Me.Hide()
    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        ToolTip1.SetToolTip(txtNombre, "Ingrese aqui el Nombre")
        ToolTip1.ToolTipTitle = "Nombre del Paciente"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub txtEdad_MouseHover(sender As Object, e As EventArgs) Handles txtEdad.MouseHover
        ToolTip1.SetToolTip(txtEdad, "Ingrese aqui la Edad")
        ToolTip1.ToolTipTitle = "Edad del Paciente"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub cmbDepartamentos_MouseHover(sender As Object, e As EventArgs) Handles cmbDepartamentos.MouseHover
        ToolTip1.SetToolTip(cmbDepartamentos, "Seleccione aqui el Departamento")
        ToolTip1.ToolTipTitle = "Departamento que Pertenece"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub txtMunicipios_MouseHover(sender As Object, e As EventArgs) Handles txtMunicipios.MouseHover
        ToolTip1.SetToolTip(txtMunicipios, "Ingrese aqui el Municipio")
        ToolTip1.ToolTipTitle = "Municipio de Residencia"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub txtDescipcion_MouseHover(sender As Object, e As EventArgs) Handles txtDescripcion.MouseHover
        ToolTip1.SetToolTip(txtDescripcion, "Ingrese aqui una breve descripcion del Paciente")
        ToolTip1.ToolTipTitle = "Descripcion del Paciente"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class