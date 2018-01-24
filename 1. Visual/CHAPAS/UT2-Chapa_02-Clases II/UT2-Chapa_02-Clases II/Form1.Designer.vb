<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnClasesII
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
        Me.txtPerimetro = New System.Windows.Forms.TextBox()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.txtBase = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtPerimetro
        '
        Me.txtPerimetro.Location = New System.Drawing.Point(118, 162)
        Me.txtPerimetro.Name = "txtPerimetro"
        Me.txtPerimetro.Size = New System.Drawing.Size(121, 29)
        Me.txtPerimetro.TabIndex = 17
        '
        'txtArea
        '
        Me.txtArea.Location = New System.Drawing.Point(12, 162)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(100, 29)
        Me.txtArea.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(118, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 24)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "PERIMETRO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 24)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "AREA"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(47, 73)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(123, 51)
        Me.btnCalcular.TabIndex = 13
        Me.btnCalcular.Text = "CALCULAR"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtAltura
        '
        Me.txtAltura.Location = New System.Drawing.Point(118, 38)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(100, 29)
        Me.txtAltura.TabIndex = 12
        '
        'txtBase
        '
        Me.txtBase.Location = New System.Drawing.Point(12, 38)
        Me.txtBase.Name = "txtBase"
        Me.txtBase.Size = New System.Drawing.Size(100, 29)
        Me.txtBase.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(118, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 24)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "ALTURA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "BASE"
        '
        'frnClasesII
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 258)
        Me.Controls.Add(Me.txtPerimetro)
        Me.Controls.Add(Me.txtArea)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtAltura)
        Me.Controls.Add(Me.txtBase)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "frnClasesII"
        Me.Text = "Clases en VB - Parte 2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPerimetro As System.Windows.Forms.TextBox
    Friend WithEvents txtArea As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents txtAltura As System.Windows.Forms.TextBox
    Friend WithEvents txtBase As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
