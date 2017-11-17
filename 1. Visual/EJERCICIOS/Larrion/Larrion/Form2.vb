Public Class frnMedallero

    Private Sub frnMedallero_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        actualizarLabel()
    End Sub

    Private Sub btnVolver_Click(sender As System.Object, e As System.EventArgs) Handles btnVolver.Click
        Me.Dispose()
    End Sub

    Private Sub txtPatron_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPatron.KeyPress
        soloLetras(e)
    End Sub

    Private Sub btnMas_Click(sender As System.Object, e As System.EventArgs) Handles btnMas.Click
        Dim cont As Integer = 0

        If lstPais.SelectedIndex = -1 Then
            smsAdvertencia("Debe seleccionar un país")
        End If

        indiceSeleccionadoMedallero = primerSeleccionado()

        Dim oro As Integer = lstOro.Items.Item(indiceSeleccionadoMedallero)
        Dim plata As Integer = lstPlata.Items.Item(indiceSeleccionadoMedallero)
        Dim bronce As Integer = lstBronce.Items.Item(indiceSeleccionadoMedallero)
        Dim totalM As Integer

        If rbtOro.Checked Then
            oro += 1
            lstOro.Items.Item(indiceSeleccionadoMedallero) = oro
        ElseIf rbtPlata.Checked Then
            plata += 1
            lstPlata.Items.Item(indiceSeleccionadoMedallero) = plata
        Else
            bronce += 1
            lstBronce.Items.Item(indiceSeleccionadoMedallero) = bronce
        End If

        totalM = oro + plata + bronce
        lstTotal.Items.Item(indiceSeleccionadoMedallero) = totalM
        actualizarLabel()

    End Sub

    Function primerSeleccionado()
        For i = 0 To lstPais.Items.Count - 1
            If lstPais.GetSelected(i) Then
                Return i
            End If
        Next
        Return False
    End Function


    Private Sub btnMenos_Click(sender As System.Object, e As System.EventArgs) Handles btnMenos.Click
        Dim cont As Integer = 0

        indiceSeleccionadoMedallero = primerSeleccionado()

        Dim oro As Integer = lstOro.Items.Item(indiceSeleccionadoMedallero)
        Dim plata As Integer = lstPlata.Items.Item(indiceSeleccionadoMedallero)
        Dim bronce As Integer = lstBronce.Items.Item(indiceSeleccionadoMedallero)
        Dim totalM As Integer

        If rbtOro.Checked Then
            If medalleroCero(oro) Then
                oro -= 1
                lstOro.Items.Item(indiceSeleccionadoMedallero) = oro
            Else
                smsAdvertencia("Tiene el mínimo de medallas que es 0")
            End If
        ElseIf rbtPlata.Checked Then
            If medalleroCero(plata) Then
                plata -= 1
                lstPlata.Items.Item(indiceSeleccionadoMedallero) = plata
            Else
                smsAdvertencia("Tiene el mínimo de medallas que es 0")
            End If
        Else
            If medalleroCero(oro) Then
                bronce -= 1
                lstBronce.Items.Item(indiceSeleccionadoMedallero) = bronce
            Else
                smsAdvertencia("Tiene el mínimo de medallas que es 0")
            End If
        End If

        totalM = oro + plata + bronce
        lstTotal.Items.Item(indiceSeleccionadoMedallero) = totalM
        actualizarLabel()
    End Sub

    Function medalleroCero(num)
        If num - 1 < 0 Then
            Return False
        End If
        Return True
    End Function

    Private Sub lstPais_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstPais.SelectedIndexChanged
        Dim i As Integer = lstPais.SelectedIndex

        lstOro.SelectedIndex = i
        lstPlata.SelectedIndex = i
        lstBronce.SelectedIndex = i
        lstTotal.SelectedIndex = i
    End Sub

    Sub actualizarLabel()
        Dim t As Integer = 0

        For i As Integer = 0 To lstTotal.Items.Count - 1
            t += CInt(lstTotal.Items.Item(i))
        Next

        lblTotalMedallas.Text = t
    End Sub

    Private Sub btnSeleccionPatron_Click(sender As System.Object, e As System.EventArgs) Handles btnSeleccionPatron.Click
        Dim patron As String = txtPatron.Text
        Dim oro As Integer = 0
        Dim plata As Integer = 0
        Dim bronce As Integer = 0

        lstTotalSelec.Items.Clear()
        limpiar()

        If patron = "" Or patron = " " Then
            smsError("HA INTRODUCIDO UNA CADENA VACIA")
        Else

            For i As Integer = 0 To lstPais.Items.Count - 1
                Dim nombre As String = lstPais.Items.Item(i).ToString
                If nombre.Contains(patron) Then
                    Dim pos As Integer = busca(nombre)
                    oro += lstOro.Items.Item(pos)
                    plata += lstPlata.Items.Item(pos)
                    bronce += lstBronce.Items.Item(pos)
                End If
            Next

            Dim txtOro As String = "Oro       " + CStr(oro)
            Dim txtPlata As String = "Plata     " + CStr(plata)
            Dim txtBronce As String = "Bronce  " + CStr(bronce)

            lstTotalSelec.Items.Add(txtOro)
            lstTotalSelec.Items.Add(txtPlata)
            lstTotalSelec.Items.Add(txtBronce)

        End If

    End Sub

    Function busca(nombre)
        Dim pos As Integer = lstPais.Items.IndexOf(nombre)
        seleccionPais(pos)
        Return pos
    End Function

    Sub seleccionPais(posicion)
        lstPais.SelectedIndex = posicion
        lstOro.SelectedIndex = posicion
        lstPlata.SelectedIndex = posicion
        lstBronce.SelectedIndex = posicion
        lstTotal.SelectedIndex = posicion
    End Sub

    Sub limpiar()
        lstPais.SelectedIndex = -1
        lstOro.SelectedIndex = -1
        lstPlata.SelectedIndex = -1
        lstBronce.SelectedIndex = -1
        lstTotal.SelectedIndex = -1
    End Sub

    Private Sub btnClasificacion_Click(sender As System.Object, e As System.EventArgs) Handles btnClasificacion.Click
        frnClasi.ShowDialog()
    End Sub
End Class