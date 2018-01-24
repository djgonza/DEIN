Public Class frnClases

    Private Sub btnCalcular_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcular.Click
        Dim rec01 As New clsRectangulo01

        rec01.anchura = CDbl(txtBase.Text)
        rec01.altura = CDbl(txtAltura.Text)

        txtArea.Text = rec01.calcularArea
        txtPerimetro.Text = rec01.calcularPerimetro
    End Sub

End Class
