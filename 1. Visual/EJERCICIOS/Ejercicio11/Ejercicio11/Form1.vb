Public Class frnAtletas

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


    Private Sub btnNuevoAtleta_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevoAtleta.Click
        Dim atleta As String = txtAtletaNuevo.Text

        If atleta <> "" Then
            If Not cbAtletas.Items.Contains(atleta) Then
                cbAtletas.Items.Add(atleta)
                lstSalto1.Items.Add(0)
                lstSalto2.Items.Add(0)
                lstSalto3.Items.Add(0)
            Else
                MessageBox.Show("El atleta ya existe")
            End If
        Else
            MessageBox.Show("No has introducido nombre de atleta")
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

        If pos = -1 Then
            MessageBox.Show("No se ha seleccionado ningun atleta", "AVISO")
        Else
            Dim valorList1, valorList2, valorList3 As String
            valorList1 = lstSalto1.Items(pos)
            valorList2 = lstSalto2.Items(pos)
            valorList3 = lstSalto3.Items(pos)

            If rbtNulo.Checked Then
                If valorList1 = "0" Then
                    lstSalto1.Items(pos) = "NULO"
                ElseIf valorList2 = "0" Then
                    lstSalto2.Items(pos) = "NULO"
                ElseIf valorList3 = "0" Then
                    lstSalto3.Items(pos) = "NULO"
                End If

            ElseIf rbtValido.Checked Then
                Dim dato As String
                dato = InputBox("Introduzca marca", "MARCA A REGISTRAR", AcceptButton)

                While IsNumeric(dato) = False
                    dato = InputBox("Introduzca marca", "MARCA A REGISTRAR", AcceptButton)
                End While

                If valorList1 = "0" Then
                    lstSalto1.Items(pos) = dato
                ElseIf valorList2 = "0" Then
                    lstSalto2.Items(pos) = dato
                ElseIf valorList3 = "0" Then
                    lstSalto3.Items(pos) = dato
                End If
            End If
        End If
        
    End Sub

    Private Sub txtAtletaNuevo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtAtletaNuevo.KeyPress
        If Not (e.KeyChar Like "[A-Z ]") And AscW(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        End If
    End Sub
End Class
