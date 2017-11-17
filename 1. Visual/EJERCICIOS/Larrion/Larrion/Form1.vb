Public Class frnPrincipal

    Private Sub lstDeporte_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstDeporte.SelectedIndexChanged
        Dim pos As Integer = lstDeporte.SelectedIndex
        lstGanador.SelectedIndex = pos
    End Sub


    Private Sub btnIntroducir_Click(sender As System.Object, e As System.EventArgs) Handles btnIntroducir.Click
        Dim posDeporte As Integer = lstDeporte.SelectedIndex
        Dim posPais As Integer = cmbPais.SelectedIndex

        If posDeporte = -1 Then
            smsAdvertencia("Debes de seleccionar un DEPORTE")
        ElseIf posPais = -1 Then
            smsAdvertencia("Debes de seleccionar un PAÍS ganador")
        Else
            Dim ganador As String = cmbPais.Items.Item(posPais)
            Dim paisGanador As String = lstGanador.Items.Item(posDeporte)

            If paisGanador = "*****" Then
                lstGanador.Items.Item(posDeporte) = ganador
            Else
                smsAdvertencia("Medalla ya adjudicada a: " + paisGanador + ".")
            End If
        End If
    End Sub

    Private Sub btnMedallero_Click(sender As System.Object, e As System.EventArgs) Handles btnMedallero.Click
        frnMedallero.ShowDialog()
    End Sub

    Private Sub btnTerminar_Click(sender As System.Object, e As System.EventArgs) Handles btnTerminar.Click
        Me.Dispose()
    End Sub
End Class
