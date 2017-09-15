Public Class frnVariables

    Private i As Integer

    Private Sub btnVer_Click(sender As System.Object, e As System.EventArgs) Handles btnVer.Click
        'Dim i As Integer = 25
        'Dim i As Integer
        'Static i As Integer
        'Si declaramos una variable como static, conserva su valor
        i = i + 25
        etResultado.Text = i
    End Sub

    Private Sub btnVer2_Click(sender As System.Object, e As System.EventArgs) Handles btnVer2.Click
        Dim i As Integer
        'Si no se le asigna a i ningun valor, i toma el valor numérico 0
        i = i + 13
        txtVariables.Text = i
    End Sub

    Private Sub btnForm2_Click(sender As System.Object, e As System.EventArgs) Handles btnForm2.Click
        'MessageBox.Show("PATATA QUIERE A PATO")
        frnVariables2.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnSumar.Click
        zzz += 15
        MessageBox.Show(i)
    End Sub
End Class
