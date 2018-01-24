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
        Me.txtArticulo = New System.Windows.Forms.TextBox()
        Me.txtUnidades = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.lblImporte = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Articulo:"
        '
        'txtArticulo
        '
        Me.txtArticulo.Location = New System.Drawing.Point(65, 13)
        Me.txtArticulo.Name = "txtArticulo"
        Me.txtArticulo.Size = New System.Drawing.Size(113, 20)
        Me.txtArticulo.TabIndex = 1
        '
        'txtUnidades
        '
        Me.txtUnidades.Location = New System.Drawing.Point(78, 54)
        Me.txtUnidades.Name = "txtUnidades"
        Me.txtUnidades.Size = New System.Drawing.Size(100, 20)
        Me.txtUnidades.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Unidades:"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(13, 90)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(165, 23)
        Me.btnCalcular.TabIndex = 4
        Me.btnCalcular.Text = "Calcular importe"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'lblImporte
        '
        Me.lblImporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblImporte.Location = New System.Drawing.Point(16, 116)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(162, 36)
        Me.lblImporte.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(187, 167)
        Me.Controls.Add(Me.lblImporte)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtUnidades)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtArticulo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtArticulo As System.Windows.Forms.TextBox
    Friend WithEvents txtUnidades As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents lblImporte As System.Windows.Forms.Label

End Class
