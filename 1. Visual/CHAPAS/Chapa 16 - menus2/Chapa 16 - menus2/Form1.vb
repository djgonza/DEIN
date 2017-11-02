Public Class Form1

    Private Sub ArchivoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ArchivoToolStripMenuItem.Click

    End Sub

    Private Sub ArchivoToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ArchivoToolStripMenuItem1.Click
        MessageBox.Show("archivo")
    End Sub

    
    Private Sub SalirToolStripMenuItem_MouseEnter(sender As Object, e As System.EventArgs) Handles SalirToolStripMenuItem.MouseEnter
        wgeuf.Text = "cierra la aplicación"
    End Sub

    Private Sub SalirToolStripMenuItem_MouseLeave(sender As Object, e As System.EventArgs) Handles SalirToolStripMenuItem.MouseLeave
        wgeuf.Text = "Listo"
    End Sub

    Private Sub mnuAñadir_Click(sender As System.Object, e As System.EventArgs) Handles mnuAñadir.Click
        Dim titulo As String
        titulo = "País " & mnuPais.DropDownItems.Count - 2

        Dim elemento As ToolStripMenuItem = New ToolStripMenuItem(titulo)

        AddHandler elemento.Click, AddressOf elementomenupaos_click
        mnuPais.DropDownItems.Add(elemento)
    End Sub

    Sub elementomenupaos_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim elemento As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

        MsgBox(elemento.Text)
    End Sub


    Private Sub mnuBorrar_Click(sender As System.Object, e As System.EventArgs) Handles mnuBorrar.Click
        Dim indiceUltimo As Integer = mnuPais.DropDownItems.Count - 1

        mnuPais.DropDownItems.RemoveAt(indiceUltimo)
    End Sub

    Private Sub WewerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles WewerToolStripMenuItem.Click
        My.Computer.Clipboard.SetText(TextBox1.Text)
    End Sub

    Private Sub WerqerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles WerqerToolStripMenuItem.Click
        etEstado.Text = My.Computer.Clipboard.GetText()
    End Sub
End Class
