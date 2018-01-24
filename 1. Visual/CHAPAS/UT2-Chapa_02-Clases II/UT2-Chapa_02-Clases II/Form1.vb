Public Class frnClasesII

    Private Sub btnCalcular_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcular.Click
        'Para poder hacer lo siguiente, deberemos darle a la pestaña de Proyecto(arriba), Propiedades nombreProyectoAbierto, Pestaña Referencias,
        'Agregar y seleccionamos la biblioteca creada
        Dim rec02 As New FiguraGeometrica.clsRectangulo02

        rec02.anchura = CDbl(txtBase.Text)
        rec02.altura = CDbl(txtAltura.Text)

        txtArea.Text = rec02.calcularArea
        txtPerimetro.Text = rec02.calcularPerimetro
    End Sub
End Class
