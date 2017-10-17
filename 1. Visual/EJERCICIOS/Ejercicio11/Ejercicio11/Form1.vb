Public Class frnAtletas

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


    Private Sub btnNuevoAtleta_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevoAtleta.Click
        Dim atleta As String = txtAtletaNuevo.Text
        If Not cbAtletas.Items.Contains(atleta) Then
            cbAtletas.Items.Add(atleta)
            lstSalto1.Items.Add(0)
            lstSalto2.Items.Add(0)
            lstSalto3.Items.Add(0)
        Else
            MessageBox.Show("El atleta ya existe")
        End If

    End Sub
    
    Private Sub cbAtletas_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbAtletas.SelectedIndexChanged
        Dim pos As Integer
        pos = cbAtletas.SelectedIndex

        lstSalto1.SelectedIndex = pos
        lstSalto2.SelectedIndex = pos
        lstSalto3.SelectedIndex = pos
        
    End Sub

    Private Sub btnSalto_Click(sender As System.Object, e As System.EventArgs) Handles btnSalto.Click
        Dim pos As Integer
        pos = cbAtletas.SelectedIndex

        If rbtNulo.Checked Then
            If lstSalto1.GetItemText(pos) = 0 Then
                lstSalto1.
            End If
        End If
    End Sub
End Class
