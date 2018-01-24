Module Module1

    Public nuevoClientes As New frnClientes
    Public nuevoArticulos As New frnArticulos
    Public nuevoPedidos As New frnPedidos

    'Para mensajes de Error
    Public Sub smsError(ByVal mensaje)
        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

End Module
