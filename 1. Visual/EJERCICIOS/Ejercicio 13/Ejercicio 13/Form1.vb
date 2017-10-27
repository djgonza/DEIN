Public Class frnMulticines

    Const maxSala1 As Integer = 200
    Const maxSala2 As Integer = 150
    Const maxSala3 As Integer = 120
    Const maxSala4 As Integer = 100

    Private salas(3) As RadioButton
    Private horarios(2) As RadioButton
    Private asientos(3) As ListBox

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
        Dim quedan As Integer = salas(s).Text
        Dim max As Integer

        Select Case s
            Case 0
                max = maxSala1
            Case 1
                max = maxSala2
            Case 2
                max = maxSala3
            Case Else
                max = maxSala4
        End Select

        If entradas > max or Then
            MessageBox.Show("No hay suficientes entradas)
        Else
            Dim e As Integer = 
        End If
    End Sub

    Private Sub btnDevolucion_Click(sender As System.Object, e As System.EventArgs) Handles btnDevolucion.Click

    End Sub
End Class
