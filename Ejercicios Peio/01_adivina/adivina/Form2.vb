Public Class Form2
    Private intentos As Integer = 1

    Private Sub txtNumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumero.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            btnVerificar.PerformClick()
            Exit Sub
        End If
        If Not (e.KeyChar Like "[0-9]") And AscW(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        End If
    End Sub


    Private Sub btnVerificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerificar.Click
        If IsNumeric(txtNumero.Text) Then
            Dim numero As Integer = txtNumero.Text
            If adivina = numero Then
                etResultado.Text = " ACERTADO en el intento " & intentos
                txtNumero.Enabled = False
                btnVerificar.Enabled = False
                Exit Sub
            End If

            If adivina > numero Then
                etResultado.Text = "MAYOR"
            Else
                etResultado.Text = "MENOR"
            End If

            intentos += 1
            If intentos = 11 Then
                etResultado.Text = "FALLASTE " & adivina
                txtNumero.Enabled = False
                btnVerificar.Enabled = False
            Else
                etIntento.Text = intentos
            End If
        Else
            MessageBox.Show("Debe introducir un valor númerico", "AVISO")
        End If
    End Sub

    Private Sub btnFinalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinalizar.Click
        End
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.Dispose()
    End Sub
End Class