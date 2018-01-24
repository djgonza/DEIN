Imports System.IO
Public Class Form1
    Dim cont As Integer = 0

    Private Sub btnMostrar_Click(sender As System.Object, e As System.EventArgs) Handles btnMostrar.Click
        Dim doc As XDocument = XDocument.Load("Liga.xml")

        Dim Seleccion = _
            From datos In doc...<lista_equipos>.<equipo>.<plantilla_jugadores>.<jugador>
            Select datos.<nombre>.Value

        For Each s In Seleccion
            lstNombres.Items.Add(s)
        Next
    End Sub

    Private Sub lstNombres_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstNombres.SelectedIndexChanged
        Dim pos As Integer = lstNombres.SelectedIndex
        Dim jugador As String = lstNombres.Items.Item(pos)
        Dim doc As XDocument = XDocument.Load("Liga.xml")


        Dim Seleccion = _
            From datos In doc...<lista_equipos>.<equipo>.<plantilla_jugadores>.<jugador>
            Where datos.<nombre>.Value Like jugador
            Select datos.<posicion>.Value, datos.<nacionalidad>.Value

        For Each s In Seleccion
            Dim posicion As String = s.posicion
            Dim nacionalidad As String = s.nacionalidad
            txtNacionalidad.Text = nacionalidad
            txtPosicion.Text = posicion
        Next

    End Sub

    Private Sub btnAñadir_Click(sender As System.Object, e As System.EventArgs) Handles btnAñadir.Click
        
        Dim doc As XDocument
        Dim docOri As XDocument = XDocument.Load("Liga.xml")
        Dim pos As Integer = lstNombres.SelectedIndex
        Dim jugador As String = lstNombres.Items.Item(pos)
        cont += 1
        Dim Seleccion = _
        From datos In docOri...<lista_equipos>.<equipo>.<plantilla_jugadores>.<jugador>
        Where datos.<nombre>.Value Like jugador
        Select <Jugador id=<%= cont %>>
                   <nombreJugador><%= datos.<nombre>.Value %></nombreJugador>
                   <posicionJugador><%= datos.<posicion>.Value %></posicionJugador>
                   <nacionalidadJugador><%= datos.<nacionalidad>.Value %></nacionalidadJugador>
                   <fechaDeAlta><%= Today %></fechaDeAlta>
               </Jugador>

        If Not File.Exists("Seleccion.xml") Then
            doc = <?xml version='1.0'?>
                  <Seleccion>
                  </Seleccion>
        Else
            doc = XDocument.Load("Seleccion.xml")
            doc.Root.Add(Seleccion)
            doc.Save("Seleccion.xml")
        End If
    End Sub
End Class
