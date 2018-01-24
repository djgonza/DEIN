Imports System.IO
Public Class Form1
    Dim ruta As String
    Private Sub btnCrear_Click(sender As System.Object, e As System.EventArgs) Handles btnCrear.Click
        Dim usuario As String = txtNombre.Text
        ruta = "C:\" + usuario

        Directory.CreateDirectory(ruta)
    End Sub

    Private Sub btnCrearArchivo_Click(sender As System.Object, e As System.EventArgs) Handles btnCrearArchivo.Click
        Dim nombreArchivo As String = txtNombreArchivo.Text
        Dim contenido As String = rtbTexto.Text

        Dim fileName As String = ruta + "\" + nombreArchivo + ".txt"

        File.Create(fileName)

        File.WriteAllText(fileName, contenido)

        MessageBox.Show("Fichero " + nombreArchivo + " creado.")
    End Sub

    Private Sub btnExaminar_Click(sender As System.Object, e As System.EventArgs) Handles btnExaminar.Click

        If Not Directory.Exists(ruta) Then
            MessageBox.Show("Directorio no existe")
        Else
            For Each fich In Directory.GetFiles(ruta)
                lstArchivos.Items.Add(Path.GetFileName(fich))
            Next
        End If
    End Sub

    Private Sub lstArchivos_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstArchivos.SelectedIndexChanged
        Dim pos As Integer = lstArchivos.SelectedIndex

        If pos = -1 Then
            MessageBox.Show("Seleccione un archivo")
        Else
            Dim fichero As String = lstArchivos.Items(pos)
            Dim texto As String = File.ReadAllText(ruta + "\" + fichero)
            rtbContenido.Text = texto
        End If
    End Sub

    Private Sub btnHtml_Click(sender As System.Object, e As System.EventArgs) Handles btnHtml.Click
        Dim doc As XDocument = <?xml version='1.0'?>
                               <!-- Este documento XML representa las líneas del documento seleccionado -->
                               <Lineas>
                               </Lineas>

        Try
            Dim pos As Integer = lstArchivos.SelectedIndex
            Dim fichero As String = lstArchivos.Items(pos)
            Dim Lector As StreamReader = New StreamReader(ruta + "\" + fichero)

            Do While Lector.Peek() > -1
                Dim linea As String = Lector.ReadLine()
                Dim nuevo As XElement = _
                                    <linea><%= linea %></linea>

                doc.Root.Add(nuevo)

            Loop
            Lector.Close()

            Dim docHtml =
            <html>
                <body>
                    <%= From linea In doc.<Lineas>.<linea>
                        Select <p><%= linea.Value %></p> %>
                </body>
            </html>
            docHtml.Save("prueba1.html")
        Catch ex As System.IO.FileNotFoundException
            MessageBox.Show("Fichero no encontrado")
        End Try

    End Sub
End Class
