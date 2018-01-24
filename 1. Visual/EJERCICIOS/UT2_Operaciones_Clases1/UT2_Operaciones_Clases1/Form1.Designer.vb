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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.btnSumar = New System.Windows.Forms.Button()
        Me.btnRestar = New System.Windows.Forms.Button()
        Me.btnDividir = New System.Windows.Forms.Button()
        Me.btnMultiplicar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(114, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numero 2"
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(12, 36)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(100, 29)
        Me.txtNum1.TabIndex = 2
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(118, 36)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(100, 29)
        Me.txtNum2.TabIndex = 3
        '
        'btnSumar
        '
        Me.btnSumar.Location = New System.Drawing.Point(12, 71)
        Me.btnSumar.Name = "btnSumar"
        Me.btnSumar.Size = New System.Drawing.Size(49, 39)
        Me.btnSumar.TabIndex = 4
        Me.btnSumar.Text = "+"
        Me.btnSumar.UseVisualStyleBackColor = True
        '
        'btnRestar
        '
        Me.btnRestar.Location = New System.Drawing.Point(67, 71)
        Me.btnRestar.Name = "btnRestar"
        Me.btnRestar.Size = New System.Drawing.Size(49, 39)
        Me.btnRestar.TabIndex = 5
        Me.btnRestar.Text = "-"
        Me.btnRestar.UseVisualStyleBackColor = True
        '
        'btnDividir
        '
        Me.btnDividir.Location = New System.Drawing.Point(177, 71)
        Me.btnDividir.Name = "btnDividir"
        Me.btnDividir.Size = New System.Drawing.Size(49, 39)
        Me.btnDividir.TabIndex = 6
        Me.btnDividir.Text = "/"
        Me.btnDividir.UseVisualStyleBackColor = True
        '
        'btnMultiplicar
        '
        Me.btnMultiplicar.Location = New System.Drawing.Point(122, 71)
        Me.btnMultiplicar.Name = "btnMultiplicar"
        Me.btnMultiplicar.Size = New System.Drawing.Size(49, 39)
        Me.btnMultiplicar.TabIndex = 7
        Me.btnMultiplicar.Text = "*"
        Me.btnMultiplicar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Resultado"
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(16, 162)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(100, 29)
        Me.txtResultado.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(243, 234)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnMultiplicar)
        Me.Controls.Add(Me.btnDividir)
        Me.Controls.Add(Me.btnRestar)
        Me.Controls.Add(Me.btnSumar)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.Text = "Ejercicio Clases 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNum1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum2 As System.Windows.Forms.TextBox
    Friend WithEvents btnSumar As System.Windows.Forms.Button
    Friend WithEvents btnRestar As System.Windows.Forms.Button
    Friend WithEvents btnDividir As System.Windows.Forms.Button
    Friend WithEvents btnMultiplicar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtResultado As System.Windows.Forms.TextBox

End Class
