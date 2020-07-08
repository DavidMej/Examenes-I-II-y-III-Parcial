Imports System.ComponentModel

Public Class Ventas
    Dim conexion As conexion = New conexion()
    Dim tabla As New DataTable
    Private Sub ProductosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem1.Click
        Me.Hide()
        Productos.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Me.Hide()
        Clientes.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.abrirConexion()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim idVenta As Integer
        Dim precio, cantidad, idClient, idProduct As String
        Dim fechaVenta As Date

        idVenta = txtIdVenta.Text
        precio = txtPrecio.Text
        cantidad = txtCantidad.Text
        idClient = txtCodCliente.Text
        idProduct = txtCodProducto.Text
        fechaVenta = mktFecha.Text

        Try
            If conexion.ingresarVenta(idVenta, fechaVenta, precio, cantidad, idClient, idProduct) Then
                MsgBox("Ingresado correctamente")
            Else
                MsgBox("Error, no se pudo agregar")
            End If
        Catch ex As Exception
            MsgBox("Error de ingreso")
        End Try
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Try
            tabla = conexion.consultaTienda()
            If tabla.Rows.Count <> 0 Then
                dgvRegistroVentas.DataSource = tabla
            Else
                dgvRegistroVentas.DataSource = Nothing

            End If
        Catch ex As Exception
            MsgBox("No se pudo mostrar informacion")
        End Try
    End Sub

    Private Sub txtCodCliente_Validating(sender As Object, e As CancelEventArgs) Handles txtCodCliente.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidarCampos.SetError(sender, "")
        Else
            Me.ErrorValidarCampos.SetError(sender, "Debe ingresar un codigo de Cliente,
es oblibatorio")
        End If
    End Sub

    Private Sub txtIdVenta_Validating(sender As Object, e As CancelEventArgs) Handles txtIdVenta.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidarCampos.SetError(sender, "")
        Else
            Me.ErrorValidarCampos.SetError(sender, "Debe ingresar un ID de Venta, es oblibatorio")
        End If
    End Sub

    Private Sub txtPrecio_Validating(sender As Object, e As CancelEventArgs) Handles txtPrecio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidarCampos.SetError(sender, "")
        Else
            Me.ErrorValidarCampos.SetError(sender, "Debe ingresar un precio del Producto, es oblibatorio")
        End If
    End Sub

    Private Sub txtCantidad_Validating(sender As Object, e As CancelEventArgs) Handles txtCantidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidarCampos.SetError(sender, "")
        Else
            Me.ErrorValidarCampos.SetError(sender, "Debe ingresar una cantidad de Producto(s), es oblibatorio")
        End If
    End Sub

    Private Sub mktFecha_Validating(sender As Object, e As CancelEventArgs) Handles mktFecha.Validating
        If DirectCast(sender, MaskedTextBox).Text.Length > 0 Then
            Me.ErrorValidarCampos.SetError(sender, "")
        Else
            Me.ErrorValidarCampos.SetError(sender, "Debe ingrese una fecha, es oblibatorio")
        End If
    End Sub

    Private Sub txtCodProducto_Validating(sender As Object, e As CancelEventArgs) Handles txtCodProducto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidarCampos.SetError(sender, "")
        Else
            Me.ErrorValidarCampos.SetError(sender, "Debe ingresar un ID de Producto, es oblibatorio")
        End If
    End Sub
End Class