Public Class Form1

    Dim i As Integer
    Const palabra As String = "PATATA"
    Dim x As Integer = 1
    Dim sala(4) As RadioButton

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        i += 1

        lbl.Text = i
    End Sub

    Private Sub btnIniciar_Click(sender As System.Object, e As System.EventArgs) Handles btnIniciar.Click
        Timer1.Enabled = True
    End Sub


    Private Sub btnStop_Click(sender As System.Object, e As System.EventArgs) Handles btnStop.Click
        btnIniciar.Enabled = False
        Timer1.Enabled = False
        Timer2.Enabled = True
    End Sub

    
    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        lbl2.Text = palabra.Substring(0, x)
        x += 1

        If x > palabra.Length Then
            Timer2.Enabled = False
            btnIniciar.Enabled = True
            x = 1
        End If

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        sala(0) = rbt1
        sala(1) = rbt2
        sala(2) = rbt3
        sala(3) = rbt4
    End Sub

    Private Sub btnMensaje_Click(sender As System.Object, e As System.EventArgs) Handles btnMensaje.Click
        MessageBox.Show(sala(1).Text)
        MessageBox.Show(rbt2.Text)
    End Sub

    Private Sub rbt1_Click(sender As Object, e As System.EventArgs) Handles rbt1.Click, rbt2.Click, rbt3.Click, rbt4.Click
        'MessageBox.Show("Cri cri criiiii")
        Dim indice As Integer = Array.IndexOf(sala, sender)

        'MessageBox.Show(indice)
        MessageBox.Show(sala(indice).Text)
    End Sub
End Class
