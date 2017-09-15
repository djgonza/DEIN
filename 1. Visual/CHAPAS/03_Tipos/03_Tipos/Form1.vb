Public Class frnTipos

    Private Sub btnCalcular_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcular.Click
        'integer long single double string char
        Dim num1, num2, result As Single

        'cint -> integer; csin -> single; cdbl -> double; cstr -> string

        'MessageBox.Show(0.5 * 4)
        num1 = CSng(txtNum1.Text)
        num2 = CSng(txtNum2.Text)

        '+ - * / mod(resto) \(divisor entero) ^(elevar un numero a otro)
        'MessageBox.Show(7 \ 2)
        MessageBox.Show("Hola" & " holita vecinillo")

        result = num1 * num2
        txtResultados.Text = result
    End Sub

    Private Sub btnCalcular2_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcular2.Click
        Dim a, b, s As Double
        a = CDbl(txtNum1.Text)
        b = CDbl(txtNum2.Text)

        s = a * b
        txtResultados.Text = Format(s, "#,##0.00")


    End Sub
End Class
