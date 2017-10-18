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
        Me.txtDato = New System.Windows.Forms.TextBox()
        Me.btnSeleccion = New System.Windows.Forms.Button()
        Me.btnInStr = New System.Windows.Forms.Button()
        Me.txtDato2 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtUpdate = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDato
        '
        Me.txtDato.Location = New System.Drawing.Point(13, 13)
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(207, 20)
        Me.txtDato.TabIndex = 0
        Me.txtDato.Text = "patata"
        '
        'btnSeleccion
        '
        Me.btnSeleccion.Location = New System.Drawing.Point(240, 13)
        Me.btnSeleccion.Name = "btnSeleccion"
        Me.btnSeleccion.Size = New System.Drawing.Size(75, 23)
        Me.btnSeleccion.TabIndex = 1
        Me.btnSeleccion.Text = "Selecciono"
        Me.btnSeleccion.UseVisualStyleBackColor = True
        '
        'btnInStr
        '
        Me.btnInStr.Location = New System.Drawing.Point(240, 43)
        Me.btnInStr.Name = "btnInStr"
        Me.btnInStr.Size = New System.Drawing.Size(75, 23)
        Me.btnInStr.TabIndex = 2
        Me.btnInStr.Text = "inSTr"
        Me.btnInStr.UseVisualStyleBackColor = True
        '
        'txtDato2
        '
        Me.txtDato2.Location = New System.Drawing.Point(13, 40)
        Me.txtDato2.Name = "txtDato2"
        Me.txtDato2.Size = New System.Drawing.Size(207, 20)
        Me.txtDato2.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(13, 67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(207, 223)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'txtUpdate
        '
        Me.txtUpdate.Location = New System.Drawing.Point(196, 299)
        Me.txtUpdate.Name = "txtUpdate"
        Me.txtUpdate.Size = New System.Drawing.Size(75, 23)
        Me.txtUpdate.TabIndex = 5
        Me.txtUpdate.Text = "Update"
        Me.txtUpdate.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(227, 67)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(258, 223)
        Me.RichTextBox1.TabIndex = 6
        Me.RichTextBox1.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 334)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.txtUpdate)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtDato2)
        Me.Controls.Add(Me.btnInStr)
        Me.Controls.Add(Me.btnSeleccion)
        Me.Controls.Add(Me.txtDato)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDato As System.Windows.Forms.TextBox
    Friend WithEvents btnSeleccion As System.Windows.Forms.Button
    Friend WithEvents btnInStr As System.Windows.Forms.Button
    Friend WithEvents txtDato2 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtUpdate As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox

End Class
