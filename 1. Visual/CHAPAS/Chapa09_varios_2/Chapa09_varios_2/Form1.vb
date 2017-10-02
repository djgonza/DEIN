Public Class frnVarios

    Private Sub btnIsNumeric_Click(sender As System.Object, e As System.EventArgs) Handles btnIsNumeric.Click
        TextBox2.PasswordChar = ""

        If IsNumeric(TextBox1.Text) Then
            MessageBox.Show("ES NUMÉRICO!!")
        End If
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As System.EventArgs) Handles TextBox1.GotFocus
        TextBox1.Text = ""
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        'MessageBox.Show("Has pulsado una puta tecla")
        'MessageBox.Show(e.KeyChar)

        'Cuando se presiona ENTER, pone el valor del TEXTBOX1 en la label y manda el foco al TEXTBOX2
        If AscW(e.KeyChar) = Keys.Enter Then
            lblOne.Text = TextBox1.Text
            TextBox2.Focus()
        End If

        'Solo aparecen las letras en mayusculas => If Not (e.KeyChar Like "[A-Z]") Then
        'Solo aparecen las letras en mayusculas, la "Ñ" y 8 => [A-ZÑ 8]
        'Sole aparecen las letras en mayusculas y retroceso(e.KeyChar <> Convert.ToChar(Keys.Back))
        If Not (e.KeyChar Like "[A-Z]") And e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True

        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        'MessageBox.Show("Has cambiado tiiiiiio, antes molabas")
    End Sub


    Private Sub TextBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox1.Validating
        If TextBox1.Text <> "PATATA" Then
            e.Cancel = True
        End If
    End Sub

    
    Private Sub btnRandom_Click(sender As System.Object, e As System.EventArgs) Handles btnRandom.Click
        'Label1.Text = Rnd()
        'Genera números random entre 4 - 6 => FORMULA: Int(menor + Rnd() * (mayor - menor + 1))
        'Label1.Text = Int(4 + Rnd() * 3)

        'Otra forma de generar randoms entre 4 - 6
        Dim numRandom As New Random
        Dim a As Integer
        a = numRandom.Next(4, 7)
        Label1.Text = a
    End Sub

    Private Sub frnVarios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Randomize()
    End Sub
End Class
