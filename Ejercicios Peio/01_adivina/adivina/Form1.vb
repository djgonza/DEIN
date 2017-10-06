Public Class Form1

    Private Sub btnFinalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinalizar.Click
        Me.Dispose()
    End Sub

    Private Sub txtAdivina_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAdivina.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            btnAceptar.PerformClick()
            Exit Sub
        End If
        If Not (e.KeyChar Like "[0-9]") And AscW(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If IsNumeric(txtAdivina.Text) Then
            adivina = txtAdivina.Text
            Form2.ShowDialog()
        Else
            MessageBox.Show("Debe introducir un valor númerico", "AVISO")
        End If
    End Sub
End Class
