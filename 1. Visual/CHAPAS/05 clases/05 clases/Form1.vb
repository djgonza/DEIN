Public Class Form1
    Dim frutas1 = New clsFrutas

    Private Sub txtArticulo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtArticulo.KeyPress
        Dim caracterTecleado As String
        caracterTecleado = e.KeyChar
        If Not frutas1.CaracterValido(caracterTecleado) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtArticulo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtArticulo.Validating
        If frutas1.existeFruta(txtArticulo.Text) = False Then
            e.Cancel = True
        End If
    End Sub

    Private Sub txtUnidades_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtUnidades.KeyPress
        If Not e.KeyChar Like "[0-9]" Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnCalcular_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcular.Click
        Dim uni As Integer
        uni = CInt(txtUnidades.Text)
        frutas1.unidades = uni
        lblImporte.Text = frutas1.importe
    End Sub
End Class
