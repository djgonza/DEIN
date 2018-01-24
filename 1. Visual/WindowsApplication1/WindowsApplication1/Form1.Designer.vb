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
        Me.etArticulo = New System.Windows.Forms.Label()
        Me.etUnidades = New System.Windows.Forms.Label()
        Me.txtArticulo = New System.Windows.Forms.TextBox()
        Me.txtUnidades = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.eqResultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'etArticulo
        '
        Me.etArticulo.AutoSize = True
        Me.etArticulo.Location = New System.Drawing.Point(105, 50)
        Me.etArticulo.Name = "etArticulo"
        Me.etArticulo.Size = New System.Drawing.Size(52, 16)
        Me.etArticulo.TabIndex = 0
        Me.etArticulo.Text = "Articulo"
        '
        'etUnidades
        '
        Me.etUnidades.AutoSize = True
        Me.etUnidades.Location = New System.Drawing.Point(105, 111)
        Me.etUnidades.Name = "etUnidades"
        Me.etUnidades.Size = New System.Drawing.Size(67, 16)
        Me.etUnidades.TabIndex = 1
        Me.etUnidades.Text = "Unidades"
        '
        'txtArticulo
        '
        Me.txtArticulo.Location = New System.Drawing.Point(205, 44)
        Me.txtArticulo.Name = "txtArticulo"
        Me.txtArticulo.Size = New System.Drawing.Size(181, 22)
        Me.txtArticulo.TabIndex = 2
        '
        'txtUnidades
        '
        Me.txtUnidades.Location = New System.Drawing.Point(208, 108)
        Me.txtUnidades.Name = "txtUnidades"
        Me.txtUnidades.Size = New System.Drawing.Size(177, 22)
        Me.txtUnidades.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(149, 184)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(282, 116)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Calcular importe"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'eqResultado
        '
        Me.eqResultado.AutoSize = True
        Me.eqResultado.Location = New System.Drawing.Point(123, 370)
        Me.eqResultado.Name = "eqResultado"
        Me.eqResultado.Size = New System.Drawing.Size(32, 16)
        Me.eqResultado.TabIndex = 5
        Me.eqResultado.Text = "ddd"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 689)
        Me.Controls.Add(Me.eqResultado)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtUnidades)
        Me.Controls.Add(Me.txtArticulo)
        Me.Controls.Add(Me.etUnidades)
        Me.Controls.Add(Me.etArticulo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents etArticulo As System.Windows.Forms.Label
    Friend WithEvents etUnidades As System.Windows.Forms.Label
    Friend WithEvents txtArticulo As System.Windows.Forms.TextBox
    Friend WithEvents txtUnidades As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents eqResultado As System.Windows.Forms.Label

End Class
