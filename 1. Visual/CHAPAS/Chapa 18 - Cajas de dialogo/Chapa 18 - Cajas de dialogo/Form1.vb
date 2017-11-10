Public Class Form1

    Private Sub btnSiNo_Click(sender As System.Object, e As System.EventArgs) Handles btnSiNo.Click
        Dim resultado As DialogResult

        resultado = MessageBox.Show("Quieres continuar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)

        If resultado = Windows.Forms.DialogResult.Yes Then
            MessageBox.Show("SIIIIRRRRL")
        Else
            MessageBox.Show("NORRRRRLLL")
        End If
    End Sub

    Private Sub btnInput_Click(sender As System.Object, e As System.EventArgs) Handles btnInput.Click
        Dim a As String

        a = InputBox("Provincia", "TITULO")

        If a = "" Then
            MessageBox.Show("CANCELADO o VACIO")
        Else
            MessageBox.Show(a)
        End If


    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        If Not contraseña() Then
            Me.Close()
        End If

    End Sub

    Function contraseña() As Boolean
        Dim intentos As Integer = 0
        Dim palabraClave As String = "patata"
        Dim dlg As New frnPalabraClave

        Do
            If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                palabraClave = dlg.txtPalabra.Text
            Else
                Return False
            End If
            If palabraClave <> "patata" Then
                intentos += 1
                MessageBox.Show("ERROR, le quedan: " + CStr(3 - intentos))
            Else
                Return True
            End If
        Loop While intentos < 3
        Return False
    End Function

    Private Sub btnAbrir_Click(sender As System.Object, e As System.EventArgs) Handles btnAbrir.Click
        Dim dlgAbrir As New OpenFileDialog

        dlgAbrir.ShowReadOnly = True
        dlgAbrir.InitialDirectory = "C:\"
        dlgAbrir.Filter = "los txt|*.txt|los doc|*.doc|todos|*.*"
        dlgAbrir.FilterIndex = 2
        dlgAbrir.RestoreDirectory = True

        If dlgAbrir.ShowDialog = Windows.Forms.DialogResult.OK Then
            MessageBox.Show(dlgAbrir.FileName)
        Else
            MessageBox.Show("Has canselado")
        End If
    End Sub

    Private Sub btnColor_Click(sender As System.Object, e As System.EventArgs) Handles btnColor.Click
        Dim dlg As New ColorDialog
        dlg.Color = txtWord.ForeColor

        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtWord.ForeColor = dlg.Color
        End If
    End Sub

    Private Sub btnProgreso_Click(sender As System.Object, e As System.EventArgs) Handles btnProgreso.Click
        For i = 0 To 12000000 Step 1
            ProgressBar1.Value = i
        Next
    End Sub
End Class
