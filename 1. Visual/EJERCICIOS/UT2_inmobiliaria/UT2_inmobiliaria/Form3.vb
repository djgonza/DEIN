Imports System.IO
Public Class frnModificar
    Private filePath As String
    Private Sub frnModificar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim casa As clsCasa = listaCasas(index)

        txtId.Text = casa.id
        txtDir.Text = casa.direccion
        txtPoblacion.Text = casa.poblacion
        txtCP.Text = casa.cp
        txtPropietario.Text = casa.propietario
        txtPrecio.Text = casa.precio
        filePath = casa.foto

    End Sub

    Private Sub btnFoto_Click(sender As System.Object, e As System.EventArgs) Handles btnFoto.Click
        ' Abrir un dialogo para seleccionar la imagen
        Dim ofd As OpenFileDialog = New OpenFileDialog()
        ofd.InitialDirectory = ".\"
        ofd.Filter = "todo (*.*)|*.*|png files (*.png)|*.png|jpg files (*.jpg)|*.jpg"

        If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                filePath = Path.GetFullPath(ofd.FileName)
                'MessageBox.Show(filePath)

            Catch ex As Exception
                smsError("Error al cargar la imagen")
            Finally

            End Try
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        Dim casa As New clsCasa(txtId.Text, txtDir.Text, txtPoblacion.Text, txtCP.Text, txtPropietario.Text, txtPrecio.Text, filePath)
        listaCasas(index) = casa

        frnPrincipal.cargarLista()
        Me.Dispose()
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecio.KeyPress
        If Not (e.KeyChar Like "[0-9,]") And AscW(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        Else
            If e.KeyChar = "," And txtPrecio.Text.IndexOf(","c) <> -1 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtId_LostFocus(sender As Object, e As System.EventArgs) Handles txtId.LostFocus, txtCP.LostFocus, txtDir.LostFocus, txtPoblacion.LostFocus, txtPrecio.LostFocus, txtPropietario.LostFocus
        If sender.Text = "" Or sender.Text = " " Then
            sender.Focus()
        End If
    End Sub

End Class