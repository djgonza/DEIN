<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSiNo = New System.Windows.Forms.Button()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.btnAbrir = New System.Windows.Forms.Button()
        Me.btnColor = New System.Windows.Forms.Button()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnProgreso = New System.Windows.Forms.Button()
        Me.mtxtMascara = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'btnSiNo
        '
        Me.btnSiNo.Location = New System.Drawing.Point(12, 12)
        Me.btnSiNo.Name = "btnSiNo"
        Me.btnSiNo.Size = New System.Drawing.Size(112, 44)
        Me.btnSiNo.TabIndex = 0
        Me.btnSiNo.Text = "SI / NO"
        Me.btnSiNo.UseVisualStyleBackColor = True
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(160, 12)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(112, 44)
        Me.btnInput.TabIndex = 1
        Me.btnInput.Text = "InputBox"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'btnAbrir
        '
        Me.btnAbrir.Location = New System.Drawing.Point(12, 62)
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.Size = New System.Drawing.Size(260, 55)
        Me.btnAbrir.TabIndex = 2
        Me.btnAbrir.Text = "Abrir"
        Me.btnAbrir.UseVisualStyleBackColor = True
        '
        'btnColor
        '
        Me.btnColor.Location = New System.Drawing.Point(99, 123)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(75, 23)
        Me.btnColor.TabIndex = 3
        Me.btnColor.Text = "Color"
        Me.btnColor.UseVisualStyleBackColor = True
        '
        'txtWord
        '
        Me.txtWord.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtWord.Location = New System.Drawing.Point(87, 152)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(100, 20)
        Me.txtWord.TabIndex = 4
        Me.txtWord.Text = "Patata"
        Me.txtWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 178)
        Me.ProgressBar1.Maximum = 12000000
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(260, 23)
        Me.ProgressBar1.TabIndex = 5
        '
        'btnProgreso
        '
        Me.btnProgreso.Location = New System.Drawing.Point(99, 207)
        Me.btnProgreso.Name = "btnProgreso"
        Me.btnProgreso.Size = New System.Drawing.Size(75, 23)
        Me.btnProgreso.TabIndex = 6
        Me.btnProgreso.Text = "Comenzar"
        Me.btnProgreso.UseVisualStyleBackColor = True
        '
        'mtxtMascara
        '
        Me.mtxtMascara.Location = New System.Drawing.Point(13, 236)
        Me.mtxtMascara.Mask = "00000"
        Me.mtxtMascara.Name = "mtxtMascara"
        Me.mtxtMascara.Size = New System.Drawing.Size(259, 20)
        Me.mtxtMascara.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 310)
        Me.Controls.Add(Me.mtxtMascara)
        Me.Controls.Add(Me.btnProgreso)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.btnColor)
        Me.Controls.Add(Me.btnAbrir)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.btnSiNo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSiNo As System.Windows.Forms.Button
    Friend WithEvents btnInput As System.Windows.Forms.Button
    Friend WithEvents btnAbrir As System.Windows.Forms.Button
    Friend WithEvents btnColor As System.Windows.Forms.Button
    Friend WithEvents txtWord As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents btnProgreso As System.Windows.Forms.Button
    Friend WithEvents mtxtMascara As System.Windows.Forms.MaskedTextBox

End Class
