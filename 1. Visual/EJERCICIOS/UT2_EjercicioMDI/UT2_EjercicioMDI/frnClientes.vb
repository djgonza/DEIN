Public Class frnClientes

    Private Sub mnuAltas_Click(sender As System.Object, e As System.EventArgs) Handles mnuAltas.Click
        Dim newCliente As String = InputBox("Introduce un nuevo CLIENTE", "Nuevo Cliente")

        If String.IsNullOrEmpty(newCliente) Then
            smsError("No ha introducido cliente")
        Else
            lstClientes.Items.Add(newCliente)
        End If
    End Sub

    Private Sub mnuBajas_Click(sender As System.Object, e As System.EventArgs) Handles mnuBajas.Click
        Dim pos As Integer = nuevoClientes.lstClientes.SelectedIndex

        If pos <> -1 Then
            lstClientes.Items.RemoveAt(pos)
        Else
            smsError("Debe seleccionar un cliente para borrar")
        End If
    End Sub

    Private Sub MnuModificar_Click(sender As System.Object, e As System.EventArgs) Handles MnuModificar.Click
        Dim pos As Integer = nuevoClientes.lstClientes.SelectedIndex

        If pos <> -1 Then
            Dim modificarCliente As String = InputBox("Introduce modificación CLIENTE", "Modificar Cliente")
            If String.IsNullOrEmpty(modificarCliente) Then
                smsError("No ha introducido modificación")
            Else
                lstClientes.Items.Item(pos) = modificarCliente
            End If
        Else
            smsError("Debe seleccionar un cliente para modificar")
        End If
    End Sub

    Private Sub mnuSalir_Click(sender As System.Object, e As System.EventArgs) Handles mnuSalir.Click
        Me.Close()
    End Sub
End Class