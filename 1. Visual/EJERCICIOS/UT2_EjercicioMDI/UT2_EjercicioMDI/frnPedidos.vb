Public Class frnPedidos

    Private Sub btnCliente_Click(sender As System.Object, e As System.EventArgs) Handles btnCliente.Click
        Dim pos As Integer = nuevoClientes.lstClientes.SelectedIndex

        If pos <> -1 Then
            txtCliente.Text = nuevoClientes.lstClientes.Items.Item(pos)
            btnArticulo.Enabled = True
        Else
            smsError("Nos se ha seleccionado un cliente")
        End If
    End Sub

    Private Sub btnArticulo_Click(sender As System.Object, e As System.EventArgs) Handles btnArticulo.Click
        Dim pos As Integer = nuevoArticulos.lstArticulo.SelectedIndex

        If pos <> -1 Then
            txtArticulo.Text = nuevoArticulos.lstArticulo.Items.Item(pos)
            txtPrecio.Text = nuevoArticulos.lstPrecio.Items.Item(pos)
            btnAñadir.Enabled = True
        Else
            smsError("Nos se ha seleccionado un artículo")
        End If
    End Sub

    Private Sub btnAñadir_Click(sender As System.Object, e As System.EventArgs) Handles btnAñadir.Click
        Dim cliente As String = txtCliente.Text
        Dim articulo As String = txtArticulo.Text
        Dim precio As String = txtPrecio.Text
        Dim unidades As Integer = nudUnidades.Value
        Dim tot As Double = CDbl(precio) * unidades

        Dim total As Double = CDbl(txtTotal.Text)
        total += tot
        txtTotal.Text = total

        Dim lineaCarro As String = "Cliente: " & cliente & " - Artículo: " & articulo & " - Precio: " & precio & " - Unidades: " & CStr(unidades) & " - Total: " & CStr(tot) & "€."
        lstCarro.Items.Add(lineaCarro)

        btnAñadir.Enabled = False
        nudUnidades.Value = 0
        txtCliente.Text = ""
        txtArticulo.Text = ""
        txtPrecio.Text = ""
        btnCliente.Focus()
    End Sub
End Class