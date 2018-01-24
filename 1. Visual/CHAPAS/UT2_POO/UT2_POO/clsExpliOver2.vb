Public Class clsExpliOver2

    Inherits clsExpliOver

    Overloads Function suma(a As Double, b As Double) As Integer
        Return a + b
    End Function

    Overrides Sub patata()
        MessageBox.Show("PATATA ------ clsExpliOver2")
    End Sub
End Class
