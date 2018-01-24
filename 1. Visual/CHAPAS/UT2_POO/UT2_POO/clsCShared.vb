Public Class clsCShared

    Public Shared nombreShared As String

    Shared Sub mostrarcompartido()
        MessageBox.Show("mostrar compartido")
        MessageBox.Show(nombreShared)
    End Sub

    Public instancia As String

    Sub mostrarinstancia()
        MessageBox.Show("mostrar instancia")
        MessageBox.Show(instancia)
    End Sub
End Class
