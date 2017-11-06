Public Class Form1

    Private Sub btnShow_Click(sender As System.Object, e As System.EventArgs) Handles btnShow.Click
        MessageBox.Show(cmbLista.SelectedIndex)
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cmbLista.SelectedIndex = 0
    End Sub

    Private Sub btnMulti_Click(sender As System.Object, e As System.EventArgs) Handles btnMulti.Click
        'lstMultiple.SelectedIndex = 1
        'lstMultiple.SelectedIndex = 3
        'lstMultiple.SelectedIndex = 5

        lstMultiple.SetSelected(1, True)
        lstMultiple.SetSelected(3, True)
        lstMultiple.SetSelected(5, True)

        MessageBox.Show(lstMultiple.SelectedIndex)
        MessageBox.Show(lstMultiple.GetSelected(3))
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        For i = 0 To lstPalabras.Items.Count - 1 Step 1
            If lstPalabras.Items(i).contains("o") Then
                MessageBox.Show(lstPalabras.Items(i))
            End If
        Next
    End Sub
End Class
