<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnCondicionales
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
        Me.btnIf = New System.Windows.Forms.Button()
        Me.btnSwitch = New System.Windows.Forms.Button()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.rbtOpcion1 = New System.Windows.Forms.RadioButton()
        Me.rbtOpcion2 = New System.Windows.Forms.RadioButton()
        Me.gpColores = New System.Windows.Forms.GroupBox()
        Me.gpColores.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnIf
        '
        Me.btnIf.Location = New System.Drawing.Point(13, 13)
        Me.btnIf.Name = "btnIf"
        Me.btnIf.Size = New System.Drawing.Size(136, 43)
        Me.btnIf.TabIndex = 0
        Me.btnIf.Text = "IF"
        Me.btnIf.UseVisualStyleBackColor = True
        '
        'btnSwitch
        '
        Me.btnSwitch.Location = New System.Drawing.Point(13, 63)
        Me.btnSwitch.Name = "btnSwitch"
        Me.btnSwitch.Size = New System.Drawing.Size(136, 50)
        Me.btnSwitch.TabIndex = 1
        Me.btnSwitch.Text = "Select Case"
        Me.btnSwitch.UseVisualStyleBackColor = True
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(13, 120)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(100, 20)
        Me.txtValor.TabIndex = 2
        '
        'rbtOpcion1
        '
        Me.rbtOpcion1.AutoSize = True
        Me.rbtOpcion1.Checked = True
        Me.rbtOpcion1.Location = New System.Drawing.Point(6, 19)
        Me.rbtOpcion1.Name = "rbtOpcion1"
        Me.rbtOpcion1.Size = New System.Drawing.Size(45, 17)
        Me.rbtOpcion1.TabIndex = 3
        Me.rbtOpcion1.TabStop = True
        Me.rbtOpcion1.Text = "Azúl"
        Me.rbtOpcion1.UseVisualStyleBackColor = True
        '
        'rbtOpcion2
        '
        Me.rbtOpcion2.AutoSize = True
        Me.rbtOpcion2.Location = New System.Drawing.Point(6, 42)
        Me.rbtOpcion2.Name = "rbtOpcion2"
        Me.rbtOpcion2.Size = New System.Drawing.Size(47, 17)
        Me.rbtOpcion2.TabIndex = 4
        Me.rbtOpcion2.TabStop = True
        Me.rbtOpcion2.Text = "Rojo"
        Me.rbtOpcion2.UseVisualStyleBackColor = True
        '
        'gpColores
        '
        Me.gpColores.Controls.Add(Me.rbtOpcion1)
        Me.gpColores.Controls.Add(Me.rbtOpcion2)
        Me.gpColores.Location = New System.Drawing.Point(12, 149)
        Me.gpColores.Name = "gpColores"
        Me.gpColores.Size = New System.Drawing.Size(72, 88)
        Me.gpColores.TabIndex = 5
        Me.gpColores.TabStop = False
        Me.gpColores.Text = "Colores"
        '
        'frnCondicionales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.gpColores)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.btnSwitch)
        Me.Controls.Add(Me.btnIf)
        Me.Name = "frnCondicionales"
        Me.Text = "Form1"
        Me.gpColores.ResumeLayout(False)
        Me.gpColores.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnIf As System.Windows.Forms.Button
    Friend WithEvents btnSwitch As System.Windows.Forms.Button
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents rbtOpcion1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtOpcion2 As System.Windows.Forms.RadioButton
    Friend WithEvents gpColores As System.Windows.Forms.GroupBox

End Class
