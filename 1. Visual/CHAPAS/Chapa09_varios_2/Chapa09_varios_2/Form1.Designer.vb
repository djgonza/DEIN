<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnVarios
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnIsNumeric = New System.Windows.Forms.Button()
        Me.lblOne = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRandom = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(13, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'btnIsNumeric
        '
        Me.btnIsNumeric.Location = New System.Drawing.Point(132, 13)
        Me.btnIsNumeric.Name = "btnIsNumeric"
        Me.btnIsNumeric.Size = New System.Drawing.Size(75, 23)
        Me.btnIsNumeric.TabIndex = 2
        Me.btnIsNumeric.Text = "isNumeric"
        Me.btnIsNumeric.UseVisualStyleBackColor = True
        '
        'lblOne
        '
        Me.lblOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOne.Location = New System.Drawing.Point(13, 40)
        Me.lblOne.Name = "lblOne"
        Me.lblOne.Size = New System.Drawing.Size(100, 23)
        Me.lblOne.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(132, 42)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(132, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRandom
        '
        Me.btnRandom.Location = New System.Drawing.Point(13, 66)
        Me.btnRandom.Name = "btnRandom"
        Me.btnRandom.Size = New System.Drawing.Size(100, 23)
        Me.btnRandom.TabIndex = 5
        Me.btnRandom.Text = "Generar aleatorio"
        Me.btnRandom.UseVisualStyleBackColor = True
        '
        'frnVarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 390)
        Me.Controls.Add(Me.btnRandom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lblOne)
        Me.Controls.Add(Me.btnIsNumeric)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "frnVarios"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnIsNumeric As System.Windows.Forms.Button
    Friend WithEvents lblOne As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRandom As System.Windows.Forms.Button

End Class
