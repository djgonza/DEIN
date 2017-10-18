Public Class Form1
    'Primera parte de la explicacion
    'Private Sub Form1_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
    '    Debug.Print("Activated")
    'End Sub

    'Private Sub Form1_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    '    Debug.Print("Closed")
    'End Sub

    'Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    '    Debug.Print("Closing")
    'End Sub

    'Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    '    Debug.Print("Load")
    'End Sub

    'Private Sub Form1_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
    '    Debug.Print("Shown")
    'End Sub

    'Private Sub Form1_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
    '    Debug.Print("Resize")
    'End Sub

    'Private Sub Form1_Paint(sender As Object, e As System.EventArgs) Handles Me.Paint
    '    Debug.Print("Paint")
    'End Sub

    Private Sub btnSeleccion_Click(sender As System.Object, e As System.EventArgs) Handles btnSeleccion.Click
        'txtDato.SelectionStart = 1
        'txtDato.SelectionLength = 3
        'txtDato.Focus()
        'MessageBox.Show(txtDato.SelectedText)

        'Forma más comoda de poner lo anterior
        'With txtDato
        '    .SelectionStart = 1
        '    .SelectionLength = 3
        '    .Focus()
        'End With

        'Otra forma
        txtDato.Select(1, 3)
        txtDato.Focus()
        MessageBox.Show(txtDato.SelectedText.Length)
    End Sub

    Private Sub btnInStr_Click(sender As System.Object, e As System.EventArgs) Handles btnInStr.Click
        'MessageBox.Show(InStr(txtDato2.Text, ","))
        'MessageBox.Show(txtDato2.Text.IndexOf(","c))
        MessageBox.Show(txtDato2.Text.LastIndexOf(","c))
    End Sub

    Private Sub txtDato2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtDato2.KeyPress
        If Not (e.KeyChar Like "[0-9,]") And AscW(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        Else
            If e.KeyChar = "," And txtDato2.Text.IndexOf(","c) <> -1 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtDato2_Validated(sender As Object, e As System.EventArgs) Handles txtDato2.Validated
        txtDato2.Text = FormatNumber(txtDato2.Text, 2)
    End Sub

    Private Sub txtDato2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDato2.Validating
        If Not IsNumeric(txtDato2.Text) Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles txtUpdate.Click
        PictureBox1.Image = Image.FromFile(Application.StartupPath & "\Cosas\cuervo.jpg")
        RichTextBox1.LoadFile(Application.StartupPath & "\Cosas\cuervo.rtf")
    End Sub
End Class
