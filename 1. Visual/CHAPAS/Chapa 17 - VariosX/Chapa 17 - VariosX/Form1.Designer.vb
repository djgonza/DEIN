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
        Me.cmbLista = New System.Windows.Forms.ComboBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.lstMultiple = New System.Windows.Forms.ListBox()
        Me.btnMulti = New System.Windows.Forms.Button()
        Me.lstPalabras = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbLista
        '
        Me.cmbLista.FormattingEnabled = True
        Me.cmbLista.Items.AddRange(New Object() {"--Seleccione de la lista--", "aaaa", "bbbb", "ccccc", "dddd"})
        Me.cmbLista.Location = New System.Drawing.Point(13, 13)
        Me.cmbLista.Name = "cmbLista"
        Me.cmbLista.Size = New System.Drawing.Size(259, 21)
        Me.cmbLista.TabIndex = 0
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(13, 41)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 23)
        Me.btnShow.TabIndex = 1
        Me.btnShow.Text = "Mostrar"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'lstMultiple
        '
        Me.lstMultiple.FormattingEnabled = True
        Me.lstMultiple.Items.AddRange(New Object() {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j"})
        Me.lstMultiple.Location = New System.Drawing.Point(12, 70)
        Me.lstMultiple.Name = "lstMultiple"
        Me.lstMultiple.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstMultiple.Size = New System.Drawing.Size(120, 147)
        Me.lstMultiple.TabIndex = 2
        '
        'btnMulti
        '
        Me.btnMulti.Location = New System.Drawing.Point(138, 70)
        Me.btnMulti.Name = "btnMulti"
        Me.btnMulti.Size = New System.Drawing.Size(75, 23)
        Me.btnMulti.TabIndex = 3
        Me.btnMulti.Text = "Mostrar Multiseleccion"
        Me.btnMulti.UseVisualStyleBackColor = True
        '
        'lstPalabras
        '
        Me.lstPalabras.FormattingEnabled = True
        Me.lstPalabras.Items.AddRange(New Object() {"el coche", "la casa", "el pato", "la patata", "el ñu", "la jirafa"})
        Me.lstPalabras.Location = New System.Drawing.Point(13, 223)
        Me.lstPalabras.Name = "lstPalabras"
        Me.lstPalabras.Size = New System.Drawing.Size(120, 95)
        Me.lstPalabras.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(140, 223)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 533)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lstPalabras)
        Me.Controls.Add(Me.btnMulti)
        Me.Controls.Add(Me.lstMultiple)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.cmbLista)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbLista As System.Windows.Forms.ComboBox
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents lstMultiple As System.Windows.Forms.ListBox
    Friend WithEvents btnMulti As System.Windows.Forms.Button
    Friend WithEvents lstPalabras As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
