Public Class frnClases3

    Private Sub btnCalcular_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcular.Click
        'Para poder hacer lo siguiente, deberemos darle a la pestaña de Proyecto(arriba), Propiedades nombreProyectoAbierto, Pestaña Referencias,
        'Agregar, seleccionamos Examinar y buscamos el fichero DLL que hemos creado en la biblioteca UT2_Chapa_03_Clases_III_Libreria
        Dim rec03 As New UT2_Chapa_03_Clases_III_Libreria.clsRectangulo03

        rec03.anchura = CDbl(txtBase.Text)
        rec03.altura = CDbl(txtAltura.Text)

        txtArea.Text = rec03.calcularArea
        txtPerimetro.Text = rec03.calcularPerimetro
    End Sub
End Class
