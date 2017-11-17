Public Class frnEjercicio14

    Private Sub lstLista_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstLista.SelectedIndexChanged
        Dim pos As Integer = lstLista.SelectedIndex
        Try
            picImagen.Image = Image.FromFile(Application.StartupPath & "\images\" & lstLista.SelectedItem & ".jpg")
        Catch
            picImagen.Image = Image.FromFile(Application.StartupPath & "\images\no disponible.jpg")
        End Try
    End Sub

    Private Sub AlFinalToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles mnuFinal.Click
        picImagen.Visible = False
        gpbAltasPosi.Visible = False
        gpbBajas.Visible = False
        gpbAltasFinal.Visible = True
    End Sub

    Private Sub txtAltaFin_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtAltaFin.KeyPress
        If Not (e.KeyChar Like "[A-Z ]") And AscW(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnAñadirFin_Click(sender As System.Object, e As System.EventArgs) Handles btnAñadirFin.Click
        Dim nombre As String = txtAltaFin.Text
        lstLista.Items.Add(nombre)
    End Sub

    Private Sub btnSalir1_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir1.Click
        picImagen.Visible = True
        gpbAltasFinal.Visible = False
        gpbBajas.Visible = False
        gpbAltasPosi.Visible = False
    End Sub

    Private Sub EnPosiciónToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles mnuPosicion.Click
        picImagen.Visible = False
        gpbAltasFinal.Visible = False
        gpbBajas.Visible = False
        gpbAltasPosi.Visible = True

        Dim cont As Integer = lstLista.Items.Count

        For i As Integer = 0 To cont - 1
            cmbPosiciones.Items.Add(i)
        Next
        
    End Sub

    Private Sub btnSalirPosi_Click(sender As System.Object, e As System.EventArgs) Handles btnSalirPosi.Click
        picImagen.Visible = True
        gpbAltasPosi.Visible = False
        gpbAltasPosi.Visible = False
        gpbBajas.Visible = False
    End Sub
    
    Private Sub btnAñaPosi_Click(sender As System.Object, e As System.EventArgs) Handles btnAñaPosi.Click
        Dim nombre As String = txtAñaPosi.Text
        Dim donde As Integer = cmbPosiciones.SelectedIndex

        lstLista.Items.Insert(donde, nombre)
    End Sub

    Private Sub mnuBorrar_Click(sender As System.Object, e As System.EventArgs) Handles mnuBorrar.Click
        picImagen.Visible = False
        gpbAltasFinal.Visible = False
        gpbAltasPosi.Visible = False
        gpbBajas.Visible = True

        Dim cont As Integer = lstLista.Items.Count

        For i As Integer = 0 To cont - 1
            cmbBajas.Items.Add(i)
        Next
    End Sub

    Private Sub btnBajas_Click(sender As System.Object, e As System.EventArgs) Handles btnBajas.Click
        Dim donde As Integer = cmbBajas.SelectedIndex

        lstLista.Items.RemoveAt(donde)

        Dim cont As Integer = lstLista.Items.Count

        cmbBajas.Items.Clear()

        For i As Integer = 0 To cont - 1
            cmbBajas.Items.Add(i)
        Next

    End Sub

    Private Sub btnSalirBajas_Click(sender As System.Object, e As System.EventArgs) Handles btnSalirBajas.Click
        picImagen.Visible = True
        gpbAltasPosi.Visible = False
        gpbAltasPosi.Visible = False
        gpbBajas.Visible = False
    End Sub
End Class
