Imports System.Math
Public Class Form1

    Private valor() As Single = {5, 1, 0.05, 0.01}
    Private salida(3) As TextBox

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        salida(0) = txtA
        salida(1) = txtB
        salida(2) = txtC
        salida(3) = txtD
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'MessageBox.Show(salida(1).Text)
        'MessageBox.Show(txtB.Text)
    End Sub

    Private Sub btnCalcular_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcular.Click
        Dim cantidad As Single = CSng(txtValor.Text)

        For i = 0 To 3 Step 1
            salida(i).Text = Int(cantidad / valor(i))
            cantidad = Round(cantidad Mod valor(i), 2)
        Next

    End Sub

    Private Sub txtA_Click(sender As Object, e As System.EventArgs) Handles txtA.Click, txtB.Click, txtC.Click, txtD.Click
        MessageBox.Show("Patata")
        Dim indice As Integer = Array.IndexOf(salida, sender)
        MessageBox.Show(indice)

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnMover.Click
        txtBox1.Top = 0
        txtBox1.Left = 100
    End Sub
End Class
