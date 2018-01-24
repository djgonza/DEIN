Public Class Form1

    Private Sub btnSumar_Click(sender As System.Object, e As System.EventArgs) Handles btnSumar.Click
        Dim operacion As New Operaciones

        operacion.num1 = CDbl(txtNum1.Text)
        operacion.num2 = CDbl(txtNum2.Text)

        txtResultado.Text = operacion.sumar
    End Sub

    Private Sub btnRestar_Click(sender As System.Object, e As System.EventArgs) Handles btnRestar.Click
        Dim operacion As New Operaciones

        operacion.num1 = CDbl(txtNum1.Text)
        operacion.num2 = CDbl(txtNum2.Text)

        txtResultado.Text = operacion.restar
    End Sub

    Private Sub btnMultiplicar_Click(sender As System.Object, e As System.EventArgs) Handles btnMultiplicar.Click
        Dim operacion As New Operaciones

        operacion.num1 = CDbl(txtNum1.Text)
        operacion.num2 = CDbl(txtNum2.Text)

        txtResultado.Text = operacion.multiplicar
    End Sub

    Private Sub btnDividir_Click(sender As System.Object, e As System.EventArgs) Handles btnDividir.Click
        Dim operacion As New Operaciones

        operacion.num1 = CDbl(txtNum1.Text)
        operacion.num2 = CDbl(txtNum2.Text)

        txtResultado.Text = operacion.dividir
    End Sub
End Class
