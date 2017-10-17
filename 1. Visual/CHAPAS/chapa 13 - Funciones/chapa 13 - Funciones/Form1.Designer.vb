<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnFunciones
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
        Me.btnCallFunction = New System.Windows.Forms.Button()
        Me.btnFactorial = New System.Windows.Forms.Button()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.btnMatriz = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCallFunction
        '
        Me.btnCallFunction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCallFunction.Location = New System.Drawing.Point(20, 20)
        Me.btnCallFunction.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCallFunction.Name = "btnCallFunction"
        Me.btnCallFunction.Size = New System.Drawing.Size(213, 69)
        Me.btnCallFunction.TabIndex = 0
        Me.btnCallFunction.Text = "LLamada_Procedimiento"
        Me.btnCallFunction.UseVisualStyleBackColor = True
        '
        'btnFactorial
        '
        Me.btnFactorial.Location = New System.Drawing.Point(20, 100)
        Me.btnFactorial.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnFactorial.Name = "btnFactorial"
        Me.btnFactorial.Size = New System.Drawing.Size(213, 58)
        Me.btnFactorial.TabIndex = 1
        Me.btnFactorial.Text = "Factorial"
        Me.btnFactorial.UseVisualStyleBackColor = True
        '
        'btnSuma
        '
        Me.btnSuma.Location = New System.Drawing.Point(20, 166)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(213, 57)
        Me.btnSuma.TabIndex = 2
        Me.btnSuma.Text = "Suma"
        Me.btnSuma.UseVisualStyleBackColor = True
        '
        'btnMatriz
        '
        Me.btnMatriz.Location = New System.Drawing.Point(20, 230)
        Me.btnMatriz.Name = "btnMatriz"
        Me.btnMatriz.Size = New System.Drawing.Size(213, 53)
        Me.btnMatriz.TabIndex = 3
        Me.btnMatriz.Text = "Matriz"
        Me.btnMatriz.UseVisualStyleBackColor = True
        '
        'frnFunciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 480)
        Me.Controls.Add(Me.btnMatriz)
        Me.Controls.Add(Me.btnSuma)
        Me.Controls.Add(Me.btnFactorial)
        Me.Controls.Add(Me.btnCallFunction)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frnFunciones"
        Me.Text = "Funciones"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCallFunction As System.Windows.Forms.Button
    Friend WithEvents btnFactorial As System.Windows.Forms.Button
    Friend WithEvents btnSuma As System.Windows.Forms.Button
    Friend WithEvents btnMatriz As System.Windows.Forms.Button

End Class
