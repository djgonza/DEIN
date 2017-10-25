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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.lbl = New System.Windows.Forms.Label()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.rbt1 = New System.Windows.Forms.RadioButton()
        Me.rbt2 = New System.Windows.Forms.RadioButton()
        Me.rbt3 = New System.Windows.Forms.RadioButton()
        Me.rbt4 = New System.Windows.Forms.RadioButton()
        Me.btnMensaje = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'btnIniciar
        '
        Me.btnIniciar.Location = New System.Drawing.Point(13, 13)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(401, 65)
        Me.btnIniciar.TabIndex = 0
        Me.btnIniciar.Text = "&Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'lbl
        '
        Me.lbl.Location = New System.Drawing.Point(149, 81)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(123, 26)
        Me.lbl.TabIndex = 1
        Me.lbl.Text = "Label1"
        Me.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(13, 110)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(401, 70)
        Me.btnStop.TabIndex = 2
        Me.btnStop.Text = "&Parar"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'lbl2
        '
        Me.lbl2.Location = New System.Drawing.Point(175, 183)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(76, 41)
        Me.lbl2.TabIndex = 3
        Me.lbl2.Text = "Label1"
        '
        'Timer2
        '
        Me.Timer2.Interval = 2000
        '
        'rbt1
        '
        Me.rbt1.AutoSize = True
        Me.rbt1.Checked = True
        Me.rbt1.Location = New System.Drawing.Point(13, 220)
        Me.rbt1.Name = "rbt1"
        Me.rbt1.Size = New System.Drawing.Size(71, 24)
        Me.rbt1.TabIndex = 4
        Me.rbt1.TabStop = True
        Me.rbt1.Text = "AAAA"
        Me.rbt1.UseVisualStyleBackColor = True
        '
        'rbt2
        '
        Me.rbt2.AutoSize = True
        Me.rbt2.Location = New System.Drawing.Point(13, 251)
        Me.rbt2.Name = "rbt2"
        Me.rbt2.Size = New System.Drawing.Size(71, 24)
        Me.rbt2.TabIndex = 5
        Me.rbt2.Text = "BBBB"
        Me.rbt2.UseVisualStyleBackColor = True
        '
        'rbt3
        '
        Me.rbt3.AutoSize = True
        Me.rbt3.Location = New System.Drawing.Point(13, 282)
        Me.rbt3.Name = "rbt3"
        Me.rbt3.Size = New System.Drawing.Size(71, 24)
        Me.rbt3.TabIndex = 6
        Me.rbt3.Text = "CCCC"
        Me.rbt3.UseVisualStyleBackColor = True
        '
        'rbt4
        '
        Me.rbt4.AutoSize = True
        Me.rbt4.Location = New System.Drawing.Point(13, 313)
        Me.rbt4.Name = "rbt4"
        Me.rbt4.Size = New System.Drawing.Size(75, 24)
        Me.rbt4.TabIndex = 7
        Me.rbt4.Text = "DDDD"
        Me.rbt4.UseVisualStyleBackColor = True
        '
        'btnMensaje
        '
        Me.btnMensaje.Location = New System.Drawing.Point(120, 220)
        Me.btnMensaje.Name = "btnMensaje"
        Me.btnMensaje.Size = New System.Drawing.Size(166, 35)
        Me.btnMensaje.TabIndex = 8
        Me.btnMensaje.Text = "Sala seleccionada"
        Me.btnMensaje.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 402)
        Me.Controls.Add(Me.btnMensaje)
        Me.Controls.Add(Me.rbt4)
        Me.Controls.Add(Me.rbt3)
        Me.Controls.Add(Me.rbt2)
        Me.Controls.Add(Me.rbt1)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.btnIniciar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnIniciar As System.Windows.Forms.Button
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents rbt1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbt2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbt3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbt4 As System.Windows.Forms.RadioButton
    Friend WithEvents btnMensaje As System.Windows.Forms.Button

End Class
