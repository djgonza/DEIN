Public Class frmInicio

    Private Sub btnHola_Click(sender As System.Object, e As System.EventArgs) Handles btnHola.Click
        'Voy a saludar a los amiguitos ja ja ja
        MessageBox.Show("Hola amiguitos")
        Me.Text = "potatoes"
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
