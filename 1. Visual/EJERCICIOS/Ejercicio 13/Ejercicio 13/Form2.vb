Public Class frnCambioPelicula

    
    Private Sub cmbSalas_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cmbSalas.SelectedIndexChanged
        Dim pos As Integer

        pos = cmbSalas.SelectedIndex
        txtActual.Text = frnMulticines.film(pos)
    End Sub

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
        Dim nuevaPelicula As String = txtNueva.Text
        Dim pos As Integer = cmbSalas.SelectedIndex

        frnMulticines.film(pos) = nuevaPelicula
    End Sub
   
    Private Sub btnVolver_Click(sender As System.Object, e As System.EventArgs) Handles btnVolver.Click
        frnMulticines.cargarPeliculas()
        frnMulticines.menuPeliculas()
        Me.Dispose()
    End Sub
End Class