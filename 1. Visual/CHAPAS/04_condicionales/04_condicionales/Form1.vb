Public Class frnCondicionales

    Private Sub btnIf_Click(sender As System.Object, e As System.EventArgs) Handles btnIf.Click
        Dim a, b, c As Integer

        a = 15
        b = 15
        c = 3

        'operadores lógicos >(mayor) >=(mayor o igual) <(menor) <=(menor o igual) =(igual) <>(distinto) 
        ' and or not & | !
        If a <> b Then
            MessageBox.Show("patata")
        ElseIf a = 23 Then
            MessageBox.Show("pato cua cua cua")
        Else
            MessageBox.Show("El pene de Arturituriiiiiiito")
        End If

    End Sub

    Private Sub btnSwitch_Click(sender As System.Object, e As System.EventArgs) Handles btnSwitch.Click
        Dim num As Integer
        num = CInt(txtValor.Text)

        Select Case num
            Case 1 To 5
                MessageBox.Show("uno a cinco")
            Case 22, 33, 55
                MessageBox.Show("patitos o tresitos o cinquillos")
            Case Else
                MessageBox.Show("otra cosa")
        End Select
    End Sub
End Class
