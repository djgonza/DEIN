Public Class frnVuelos

    Private tarifas() As Integer = {150, 200, 300, 500}

    Private Sub rbtNacional_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtNacional.CheckedChanged
        lstNacional.Enabled = True
        lstInternacional.Enabled = False
        lstInternacional.SelectedIndex = -1
    End Sub

    Private Sub rbtInternacional_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtInternacional.CheckedChanged
        lstNacional.Enabled = False
        lstNacional.SelectedIndex = -1
        lstInternacional.Enabled = True
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnAñadir_Click(sender As System.Object, e As System.EventArgs) Handles btnAñadir.Click
        Dim origen, destino, cadena, tarifaText As String
        Dim posOrigen, posDestino, billetes, tarifa, numero As Integer

        billetes = nudBilletes.Value

        If cbOrigen.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar el origen del viaje", "ERROR")
            Exit Sub
        End If

        If lstNacional.Enabled = True And lstNacional.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar el destino del viaje", "ERROR")
            Exit Sub
        ElseIf lstInternacional.Enabled And lstInternacional.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar el destino del viaje", "ERROR")
            Exit Sub
        End If

        posOrigen = cbOrigen.SelectedIndex
        origen = CStr(cbOrigen.Items.Item(posOrigen))

        If lstNacional.Enabled Then
            posDestino = lstNacional.SelectedIndex
            destino = lstNacional.Items.Item(posDestino)
        End If

        If lstInternacional.Enabled Then
            posDestino = lstInternacional.SelectedIndex
            destino = lstInternacional.Items.Item(posDestino)
        End If

        If origen.Equals(destino) Then
            MessageBox.Show("El origen coincide con el destino", "ERROR")
            Exit Sub
        End If

        If cbTarifa.SelectedIndex = -1 Or cbTarifa.SelectedIndex = 0 Then
            MessageBox.Show("Debe seleccionar una tarifa", "ERROR")
            Exit Sub
        End If

        numero = cbTarifa.SelectedIndex - 1
        tarifa = tarifas(numero)

        If rbtInternacional.Checked Then
            tarifa = tarifa * 2
        End If

        tarifa = tarifa * billetes
        tarifaText = CStr(tarifa)
        cadena = origen + "  " + destino + "  " + tarifaText + "€"
        lstVuelos.Items.Add(cadena)
        lstPrecio.Items.Add(tarifa)
        actualizar()

    End Sub

    Sub actualizar()
        Dim total As Integer
        total = 0
        For i = 0 To lstPrecio.Items.Count - 1 Step 1
            total = total + CInt(lstPrecio.Items.Item(i))
        Next

        lblTotal.Text = Format(total, "#,#0.00")

    End Sub

    Private Sub lstVuelo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
        lstPrecio.SelectedIndex = lstVuelos.SelectedIndex
    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        Dim pos As Integer
        Dim respuesta As DialogResult

        pos = lstVuelos.SelectedIndex
        If pos = -1 Then
            MessageBox.Show("Debe seleccionar un vuelo a eliminar", "ERROR")
            Exit Sub
        End If

        respuesta = MessageBox.Show("¿Desea eliminar el vuelo seleccionado?", "ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If respuesta = Windows.Forms.DialogResult.Yes Then
            lstVuelos.Items.RemoveAt(pos)
            lstPrecio.Items.RemoveAt(pos)
            actualizar()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnAnular_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Dim respuesta As DialogResult

        respuesta = MessageBox.Show("¿Desea eliminar TODOS los viajes?", "AVISO!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If respuesta = Windows.Forms.DialogResult.Yes Then
            reset()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnAceptarCompra_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        Dim mensaje, all, nombre, apellido, cp As String

        If txtNombre.Text = "" Or txtApellido.Text = "" Or txtCP.Text = "" Then
            MessageBox.Show("Rellene los campos NOMBRE, APELLIDO y C.P.", "ERROR")
            Exit Sub
        End If

        cp = txtCP.Text
        If cp.Length <> 5 Then
            MessageBox.Show("El código postal tiene que tener 5 números", "ERROR")
            Exit Sub
        End If

        nombre = txtNombre.Text
        apellido = txtApellido.Text
        mensaje = nombre + " " + apellido + " - CP: " + cp + vbLf + "ha realizado una compra de: " + vbLf
        all = lblTotal.Text
        mensaje = mensaje + all + "€ en viajes"
        MessageBox.Show(mensaje)
        reset()

    End Sub

    Sub reset()

        lstVuelos.Items.Clear()
        lstPrecio.Items.Clear()
        actualizar()
        cbOrigen.SelectedIndex = -1
        If rbtNacional.Checked Then
            lstNacional.SelectedIndex = -1
        End If
        If rbtInternacional.Checked Then
            lstInternacional.SelectedIndex = -1
        End If
        cbTarifa.SelectedIndex = 0
        nudBilletes.Value = 1

        txtNombre.Text = ""
        txtApellido.Text = ""
        txtCP.Text = ""

    End Sub

    Private Sub txtCP_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCP.KeyPress
        If Not (e.KeyChar Like "[0-9]") And AscW(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        End If
    End Sub

   
    Private Sub txtNombre_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress, txtApellido.KeyPress
        If Not (e.KeyChar Like "[A-Z ]") And AscW(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub frnVuelos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblTotal.Text = "0,00"
    End Sub
End Class
