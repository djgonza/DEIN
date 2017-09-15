<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnVariables
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frnVariables))
        Me.btnVer = New System.Windows.Forms.Button()
        Me.txtVariables = New System.Windows.Forms.TextBox()
        Me.etResultado = New System.Windows.Forms.Label()
        Me.btnVer2 = New System.Windows.Forms.Button()
        Me.btnForm2 = New System.Windows.Forms.Button()
        Me.btnSumar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVer
        '
        Me.btnVer.Location = New System.Drawing.Point(12, 12)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(355, 54)
        Me.btnVer.TabIndex = 0
        Me.btnVer.Text = "VER"
        Me.btnVer.UseVisualStyleBackColor = True
        '
        'txtVariables
        '
        Me.txtVariables.Location = New System.Drawing.Point(13, 73)
        Me.txtVariables.Name = "txtVariables"
        Me.txtVariables.Size = New System.Drawing.Size(354, 26)
        Me.txtVariables.TabIndex = 1
        '
        'etResultado
        '
        Me.etResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.etResultado.Location = New System.Drawing.Point(12, 116)
        Me.etResultado.Name = "etResultado"
        Me.etResultado.Size = New System.Drawing.Size(355, 45)
        Me.etResultado.TabIndex = 2
        Me.etResultado.Text = "caricatura"
        Me.etResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnVer2
        '
        Me.btnVer2.Location = New System.Drawing.Point(12, 178)
        Me.btnVer2.Name = "btnVer2"
        Me.btnVer2.Size = New System.Drawing.Size(355, 62)
        Me.btnVer2.TabIndex = 3
        Me.btnVer2.Text = "VER2"
        Me.btnVer2.UseVisualStyleBackColor = True
        '
        'btnForm2
        '
        Me.btnForm2.Location = New System.Drawing.Point(255, 246)
        Me.btnForm2.Name = "btnForm2"
        Me.btnForm2.Size = New System.Drawing.Size(112, 48)
        Me.btnForm2.TabIndex = 4
        Me.btnForm2.Text = "Ir a form2"
        Me.btnForm2.UseVisualStyleBackColor = True
        '
        'btnSumar
        '
        Me.btnSumar.Location = New System.Drawing.Point(13, 247)
        Me.btnSumar.Name = "btnSumar"
        Me.btnSumar.Size = New System.Drawing.Size(107, 47)
        Me.btnSumar.TabIndex = 5
        Me.btnSumar.Text = "Button1"
        Me.btnSumar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(454, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(212, 228)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'frnVariables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 398)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSumar)
        Me.Controls.Add(Me.btnForm2)
        Me.Controls.Add(Me.btnVer2)
        Me.Controls.Add(Me.etResultado)
        Me.Controls.Add(Me.txtVariables)
        Me.Controls.Add(Me.btnVer)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frnVariables"
        Me.Text = "VARIABLES"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVer As System.Windows.Forms.Button
    Friend WithEvents txtVariables As System.Windows.Forms.TextBox
    Friend WithEvents etResultado As System.Windows.Forms.Label
    Friend WithEvents btnVer2 As System.Windows.Forms.Button
    Friend WithEvents btnForm2 As System.Windows.Forms.Button
    Friend WithEvents btnSumar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
