Public Class frnMulticines

    Const maxSala1 As Integer = 200
    Const maxSala2 As Integer = 150
    Const maxSala3 As Integer = 120
    Const maxSala4 As Integer = 100

    Private salas(3) As RadioButton
    Private horarios(2) As RadioButton
    Private asientos(3) As ListBox
    Private aforo() As Integer = {maxSala1, maxSala2, maxSala3, maxSala4}
    Public film() As String = {"IT", "El guardian invisible", "Blade Runner 2049", "Kingsman: El círculo de oro"}

    Dim s As Integer = 0
    Dim h As Integer = 0

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    
    Private Sub frnMulticines_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Nombre de la sala
        Dim nombre As String = InputBox("Introduce nombre de la sala")
        Dim nombreCompleto As String = lblTitulo.Text + " " + nombre
        lblTitulo.Text = nombreCompleto

        'Controlador salas
        salas(0) = rbtSala1
        salas(1) = rbtSala2
        salas(2) = rbtSala3
        salas(3) = rbtSala4

        'Controlador horarios
        horarios(0) = rbtCinco
        horarios(1) = rbtSiete
        horarios(2) = rbtDiez

        'Controlador ListBox
        asientos(0) = lstSala1
        asientos(1) = lstSala2
        asientos(2) = lstSala3
        asientos(3) = lstSala4

        For i As Integer = 0 To 2 Step 1
            lstSala1.Items.Add(maxSala1)
            lstSala2.Items.Add(maxSala2)
            lstSala3.Items.Add(maxSala3)
            lstSala4.Items.Add(maxSala4)
        Next

        asientos(0).SelectedIndex = 0
        cargarPeliculas()
        menuPeliculas()
    End Sub

    Sub cargarPeliculas()

        txtPeli1.Text = film(0)
        txtPeli2.Text = film(1)
        txtPeli3.Text = film(2)
        txtPeli4.Text = film(3)

    End Sub

    Sub menuPeliculas()
        Dim titulo As String
        Dim indiceUltimo As Integer = mnuPelicula.DropDownItems.Count

        If indiceUltimo <> 0 Then
            MessageBox.Show(indiceUltimo)
            While indiceUltimo > 0
                mnuPelicula.DropDownItems.RemoveAt(indiceUltimo - 1)
                indiceUltimo -= 1
            End While
        End If

        For i As Integer = 0 To film.Length - 1
            titulo = film(i)
            Dim elemento As ToolStripMenuItem = New ToolStripMenuItem(titulo)

            mnuPelicula.DropDownItems.Add(elemento)
        Next
    End Sub
   
    Private Sub rbtSala1_Click(sender As Object, e As System.EventArgs) Handles rbtSala1.Click, rbtSala2.Click, rbtSala3.Click, rbtSala4.Click
        Dim indice As Integer = Array.IndexOf(salas, sender)
        deseleccionar()
        s = indice
        seleccionar()
    End Sub

    Sub deseleccionar()
        asientos(s).SelectedIndex = -1
    End Sub

    Sub seleccionar()
        asientos(s).SelectedIndex = h
    End Sub
    
    Private Sub rbtCinco_Click(sender As Object, e As System.EventArgs) Handles rbtCinco.Click, rbtSiete.Click, rbtDiez.Click
        Dim indice As Integer = Array.IndexOf(horarios, sender)
        deseleccionar()
        h = indice
        seleccionar()
    End Sub

    Private Sub txtEntradas_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtEntradas.KeyPress
        If Not (e.KeyChar Like "[0-9]") And AscW(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        End If
    End Sub
   
    Private Sub btnVenta_Click(sender As System.Object, e As System.EventArgs) Handles btnVenta.Click
        Dim entradas As Integer = CInt(txtEntradas.Text)
        Dim pos As Integer = asientos(s).SelectedIndex
        Dim disponibles As Integer = CInt(asientos(s).Items.Item(pos))

        If entradas > disponibles Then
            MessageBox.Show("Lo sentimos, pero en nº de asientos disponibles es de: " + CStr(disponibles))
        Else
            disponibles -= entradas
            asientos(s).Items.Item(pos) = disponibles
        End If

    End Sub

    Private Sub btnDevolucion_Click(sender As System.Object, e As System.EventArgs) Handles btnDevolucion.Click
        Dim entradas As Integer = CInt(txtEntradas.Text)
        Dim pos As Integer = asientos(s).SelectedIndex
        Dim sillones As Integer = CInt(asientos(s).Items.Item(pos))

        If entradas + sillones > aforo(s) Then
            MessageBox.Show("Lo sentimos, aforo máximo de la sala es de: " + CStr(aforo(s)))
        Else
            sillones += entradas
            asientos(s).Items.Item(pos) = sillones
        End If
    End Sub

    Private Sub CambioDePelículaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CambioDePelículaToolStripMenuItem.Click
        frnCambioPelicula.Show()
    End Sub
End Class
