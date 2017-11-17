Public Class Form1

    Private Sub btnSeleccion_Click(sender As System.Object, e As System.EventArgs) Handles btnSeleccion.Click
        Dim selec As Integer = nudSeleccion.Value
        Dim total As Integer = lstAnimales.Items.Count - 1
        Dim totalR As Integer = lstResultado.Items.Count - 1
        Dim num As Integer
        'MessageBox.Show(selec)

        lstAnimales.SelectedIndex = -1
        lstResultado.SelectedIndex = -1

        For i As Integer = 0 To total
            num = i + 1
            If selec = 1 Then
                lstAnimales.SelectedIndex = i
            ElseIf selec = 2 Then
                If num Mod 2 = 0 Then
                    lstAnimales.SelectedIndex = i
                End If
            Else
                If num Mod 3 = 0 Then
                    lstAnimales.SelectedIndex = i
                End If
            End If
        Next

        If totalR <> -1 Then
            For i As Integer = 0 To totalR
                num = i + 1
                If selec = 1 Then
                    lstResultado.SelectedIndex = i
                ElseIf selec = 2 Then
                    If num Mod 2 = 0 Then
                        lstResultado.SelectedIndex = i
                    End If
                Else
                    If num Mod 3 = 0 Then
                        lstResultado.SelectedIndex = i
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub btnMoverDerecha_Click(sender As System.Object, e As System.EventArgs) Handles btnMoverDerecha.Click
        For i = lstAnimales.Items.Count - 1 To 0 Step -1
            If lstAnimales.GetSelected(i) Then
                lstResultado.Items.Insert(0, lstAnimales.Items(i))
                lstAnimales.Items.RemoveAt(i)
            End If
        Next

    End Sub

    Private Sub btnMoverIzquierda_Click(sender As System.Object, e As System.EventArgs) Handles btnMoverIzquierda.Click
        For i = lstResultado.Items.Count - 1 To 0 Step -1
            If lstResultado.GetSelected(i) = True Then
                lstAnimales.Items.Add(lstResultado.Items(i))
                lstResultado.Items.RemoveAt(i)
            End If
        Next
    End Sub
End Class
