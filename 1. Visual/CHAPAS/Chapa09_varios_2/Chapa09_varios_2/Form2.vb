'Option Explicit Off
'Sirve para desactivar la opcion que obliga a declarar todas las variables

'Option Strict On
'Si esta opcion está activa, obliga a parsear

Public Class Form2

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim a As Integer
        a = TextBox1.Text
        MessageBox.Show(a)

    End Sub
End Class