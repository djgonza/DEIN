Module Module1
    Public indiceSeleccionadoMedallero As Integer

    'Para mensajes de Advertencia
    Public Sub smsAdvertencia(ByVal mensaje)
        MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    'Para mensajes de Información
    Public Sub smsInfo(ByVal mensaje)
        MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'Para mensajes de Error
    Public Sub smsError(ByVal mensaje)
        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    'PARA COMPROBAR SI SE HA ACEPTADO O SE HA DADO A CANCELAR
    Public Function confirmar(ByVal pregunta As String) As Boolean
        Dim respuesta As DialogResult
        respuesta = MessageBox.Show(pregunta, "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = Windows.Forms.DialogResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub soloLetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)

        If Not e.KeyChar Like "[A-Z ]" And e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If

    End Sub
End Module
