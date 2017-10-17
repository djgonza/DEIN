Public Class frnFunciones
    Dim l As ArrayList = New ArrayList

    Private Sub btnCallFunction_Click(sender As System.Object, e As System.EventArgs) Handles btnCallFunction.Click
        MessageBox.Show("Botón 1")
        hola()
        holas()
        MessageBox.Show("otra vez en Botón 1")
    End Sub

    Sub hola()
        MessageBox.Show("Estoy en hola")
    End Sub

    Private Sub btnFactorial_Click(sender As System.Object, e As System.EventArgs) Handles btnFactorial.Click
        Dim r As Long
        factorial(4, r)
        MessageBox.Show("El factorial de 4 es " & r)
    End Sub

    'Método Factorial
    Sub factorial(ByVal n As Integer, ByRef f As Long)
        If n = 0 Then
            f = 1
        Else
            f = 1
            While n > 0
                f *= n
                n -= 1
            End While
        End If
    End Sub

    Private Sub btnSuma_Click(sender As System.Object, e As System.EventArgs) Handles btnSuma.Click
        Dim a, b, s As Integer
        a = 7
        b = 13
        MessageBox.Show("Valor de a: " & a)
        MessageBox.Show("Valor de b: " & b)
        s = suma(a, b)
        MessageBox.Show("La suma es: " & s)
        MessageBox.Show("Valor de a: " & a)
        MessageBox.Show("Valor de b: " & b)
    End Sub

    'Funcion SUMAR
    Function suma(ByRef a As Integer, ByVal b As Integer)
        a += 10
        b += 10
        Return a + b
    End Function

    Private Sub btnMatriz_Click(sender As System.Object, e As System.EventArgs) Handles btnMatriz.Click
        Dim a() As Integer = {10, 20, 30, 40}
        sumaMatriz(a)
        'Cuando se pasa un array siempre es por Referencia (ByRef)
        MessageBox.Show(a(2))
    End Sub

    Sub sumaMatriz(ByVal matriz() As Integer)
        For i = 0 To matriz.Length - 1
            matriz(i) += 4
        Next
    End Sub

    Private Sub frnFunciones_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        l.Add("1")
        l.Add(2)

        MessageBox.Show(CStr(l.Item(0) * 2))
        MessageBox.Show(CStr(l.Item(1) * 2))
    End Sub
End Class
