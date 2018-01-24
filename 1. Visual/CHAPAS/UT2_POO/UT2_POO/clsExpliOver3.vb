Public Class clsExpliOver3
    Inherits clsExpliOver2

    Overloads Function suma(a As Integer, b As Double) As Integer
        Return (a + b)
    End Function

    Overrides Sub patata()
        MessageBox.Show("PATATA ------ clsExpliOver3")
    End Sub
End Class
