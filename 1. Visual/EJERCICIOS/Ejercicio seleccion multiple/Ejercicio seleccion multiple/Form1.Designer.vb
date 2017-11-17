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
        Me.lstAnimales = New System.Windows.Forms.ListBox()
        Me.nudSeleccion = New System.Windows.Forms.NumericUpDown()
        Me.btnSeleccion = New System.Windows.Forms.Button()
        Me.btnMoverDerecha = New System.Windows.Forms.Button()
        Me.lstResultado = New System.Windows.Forms.ListBox()
        Me.btnMoverIzquierda = New System.Windows.Forms.Button()
        CType(Me.nudSeleccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstAnimales
        '
        Me.lstAnimales.FormattingEnabled = True
        Me.lstAnimales.Items.AddRange(New Object() {"Águila", "Leopardo", "Conejo", "Candemor", "Tontolabas", "Perdiz", "Codorniz", "Pato"})
        Me.lstAnimales.Location = New System.Drawing.Point(12, 12)
        Me.lstAnimales.Name = "lstAnimales"
        Me.lstAnimales.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstAnimales.Size = New System.Drawing.Size(78, 238)
        Me.lstAnimales.TabIndex = 0
        '
        'nudSeleccion
        '
        Me.nudSeleccion.Location = New System.Drawing.Point(96, 40)
        Me.nudSeleccion.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nudSeleccion.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudSeleccion.Name = "nudSeleccion"
        Me.nudSeleccion.Size = New System.Drawing.Size(143, 20)
        Me.nudSeleccion.TabIndex = 1
        Me.nudSeleccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudSeleccion.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnSeleccion
        '
        Me.btnSeleccion.Location = New System.Drawing.Point(96, 66)
        Me.btnSeleccion.Name = "btnSeleccion"
        Me.btnSeleccion.Size = New System.Drawing.Size(143, 23)
        Me.btnSeleccion.TabIndex = 2
        Me.btnSeleccion.Text = "Seleccion Múltiple"
        Me.btnSeleccion.UseVisualStyleBackColor = True
        '
        'btnMoverDerecha
        '
        Me.btnMoverDerecha.Location = New System.Drawing.Point(96, 113)
        Me.btnMoverDerecha.Name = "btnMoverDerecha"
        Me.btnMoverDerecha.Size = New System.Drawing.Size(143, 23)
        Me.btnMoverDerecha.TabIndex = 3
        Me.btnMoverDerecha.Text = "---->>"
        Me.btnMoverDerecha.UseVisualStyleBackColor = True
        '
        'lstResultado
        '
        Me.lstResultado.FormattingEnabled = True
        Me.lstResultado.Location = New System.Drawing.Point(245, 12)
        Me.lstResultado.Name = "lstResultado"
        Me.lstResultado.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstResultado.Size = New System.Drawing.Size(78, 238)
        Me.lstResultado.TabIndex = 4
        '
        'btnMoverIzquierda
        '
        Me.btnMoverIzquierda.Location = New System.Drawing.Point(96, 142)
        Me.btnMoverIzquierda.Name = "btnMoverIzquierda"
        Me.btnMoverIzquierda.Size = New System.Drawing.Size(143, 23)
        Me.btnMoverIzquierda.TabIndex = 5
        Me.btnMoverIzquierda.Text = "<<----"
        Me.btnMoverIzquierda.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 261)
        Me.Controls.Add(Me.btnMoverIzquierda)
        Me.Controls.Add(Me.lstResultado)
        Me.Controls.Add(Me.btnMoverDerecha)
        Me.Controls.Add(Me.btnSeleccion)
        Me.Controls.Add(Me.nudSeleccion)
        Me.Controls.Add(Me.lstAnimales)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.nudSeleccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstAnimales As System.Windows.Forms.ListBox
    Friend WithEvents nudSeleccion As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnSeleccion As System.Windows.Forms.Button
    Friend WithEvents btnMoverDerecha As System.Windows.Forms.Button
    Friend WithEvents lstResultado As System.Windows.Forms.ListBox
    Friend WithEvents btnMoverIzquierda As System.Windows.Forms.Button

End Class
