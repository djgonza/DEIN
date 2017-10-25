Public Class frnMulticines

    Const maxSala1 As Integer = 200
    Const maxSala2 As Integer = 150
    Const maxSala3 As Integer = 120
    Const maxSala4 As Integer = 100

    Dim x As Integer = 1

    Dim salas(4) As RadioButton
    Dim horarios(3) As RadioButton

    Dim asientos(4) As ListBox

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
    End Sub
   
    Private Sub rbtSala1_Click(sender As Object, e As System.EventArgs) Handles rbtSala1.Click, rbtSala2.Click, rbtSala3.Click, rbtSala4.Click
        Dim indice As Integer = Array.IndexOf(salas, sender)
        asientos(indice).SelectedIndex = False
        asientos(indice).SelectedIndex = 0
    End Sub


    Private Sub rbtCinco_Click(sender As Object, e As System.EventArgs) Handles rbtCinco.Click, rbtSiete.Click, rbtDiez.Click
        Dim indice As Integer = Array.IndexOf(horarios, sender)
        asientos(indice).SelectedIndex = True
    End Sub
End Class
