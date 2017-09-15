Public Class frnVariables2
    Private i As Integer

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        'Me.Close()
        'Conserva los valores de las variables
        Me.Dispose()
        'Limpia la cache
    End Sub

    Private Sub btnShow1_Click(sender As System.Object, e As System.EventArgs) Handles btnShow1.Click
        i = i + 11
        MessageBox.Show(i)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        zzz += 10
        MessageBox.Show(i)
    End Sub
End Class