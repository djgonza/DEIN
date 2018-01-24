<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnDisco
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
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.txtArtista = New System.Windows.Forms.TextBox()
        Me.txtRef = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.pbCaratula = New System.Windows.Forms.PictureBox()
        CType(Me.pbCaratula, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPrecio
        '
        Me.txtPrecio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPrecio.Enabled = False
        Me.txtPrecio.Location = New System.Drawing.Point(12, 142)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(133, 20)
        Me.txtPrecio.TabIndex = 32
        '
        'txtTitulo
        '
        Me.txtTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTitulo.Enabled = False
        Me.txtTitulo.Location = New System.Drawing.Point(12, 103)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(133, 20)
        Me.txtTitulo.TabIndex = 31
        '
        'txtArtista
        '
        Me.txtArtista.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtArtista.Enabled = False
        Me.txtArtista.Location = New System.Drawing.Point(12, 64)
        Me.txtArtista.Name = "txtArtista"
        Me.txtArtista.Size = New System.Drawing.Size(133, 20)
        Me.txtArtista.TabIndex = 30
        '
        'txtRef
        '
        Me.txtRef.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtRef.Enabled = False
        Me.txtRef.Location = New System.Drawing.Point(12, 25)
        Me.txtRef.Name = "txtRef"
        Me.txtRef.Size = New System.Drawing.Size(133, 20)
        Me.txtRef.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Precio Disco"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Título del disco"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Artista"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Referencia Producto"
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Location = New System.Drawing.Point(12, 183)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(131, 165)
        Me.btnSalir.TabIndex = 33
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'pbCaratula
        '
        Me.pbCaratula.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbCaratula.BackColor = System.Drawing.Color.White
        Me.pbCaratula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbCaratula.Location = New System.Drawing.Point(158, 15)
        Me.pbCaratula.Name = "pbCaratula"
        Me.pbCaratula.Size = New System.Drawing.Size(319, 333)
        Me.pbCaratula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCaratula.TabIndex = 34
        Me.pbCaratula.TabStop = False
        '
        'frnDisco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 380)
        Me.Controls.Add(Me.pbCaratula)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.txtArtista)
        Me.Controls.Add(Me.txtRef)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frnDisco"
        Me.Text = "frnDisco"
        CType(Me.pbCaratula, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents txtArtista As System.Windows.Forms.TextBox
    Friend WithEvents txtRef As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents pbCaratula As System.Windows.Forms.PictureBox
End Class
