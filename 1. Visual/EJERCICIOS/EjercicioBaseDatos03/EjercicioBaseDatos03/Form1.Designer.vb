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
        Me.txtFoto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtArtista = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRef = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.imgCaratula = New System.Windows.Forms.PictureBox()
        CType(Me.imgCaratula, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFoto
        '
        Me.txtFoto.Enabled = False
        Me.txtFoto.Location = New System.Drawing.Point(172, 134)
        Me.txtFoto.Name = "txtFoto"
        Me.txtFoto.Size = New System.Drawing.Size(151, 20)
        Me.txtFoto.TabIndex = 43
        Me.txtFoto.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(169, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "&Foto Prod.:"
        '
        'txtPrecio
        '
        Me.txtPrecio.Enabled = False
        Me.txtPrecio.Location = New System.Drawing.Point(15, 134)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(151, 20)
        Me.txtPrecio.TabIndex = 41
        Me.txtPrecio.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "&Precio Prod:"
        '
        'txtTitulo
        '
        Me.txtTitulo.Enabled = False
        Me.txtTitulo.Location = New System.Drawing.Point(172, 92)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(151, 20)
        Me.txtTitulo.TabIndex = 39
        Me.txtTitulo.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(169, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "&Título:"
        '
        'txtArtista
        '
        Me.txtArtista.Enabled = False
        Me.txtArtista.Location = New System.Drawing.Point(15, 92)
        Me.txtArtista.Name = "txtArtista"
        Me.txtArtista.Size = New System.Drawing.Size(151, 20)
        Me.txtArtista.TabIndex = 37
        Me.txtArtista.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "&Artista"
        '
        'txtRef
        '
        Me.txtRef.Location = New System.Drawing.Point(15, 42)
        Me.txtRef.Name = "txtRef"
        Me.txtRef.Size = New System.Drawing.Size(151, 20)
        Me.txtRef.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "&Ref. Producto:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(196, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(108, 50)
        Me.btnBuscar.TabIndex = 44
        Me.btnBuscar.Text = "BUSCAR"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Enabled = False
        Me.btnEditar.Location = New System.Drawing.Point(15, 160)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 45
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Enabled = False
        Me.btnBorrar.Location = New System.Drawing.Point(96, 160)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 46
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'imgCaratula
        '
        Me.imgCaratula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgCaratula.Location = New System.Drawing.Point(329, 12)
        Me.imgCaratula.Name = "imgCaratula"
        Me.imgCaratula.Size = New System.Drawing.Size(154, 151)
        Me.imgCaratula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCaratula.TabIndex = 47
        Me.imgCaratula.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 256)
        Me.Controls.Add(Me.imgCaratula)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtFoto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtArtista)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRef)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.imgCaratula, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFoto As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtArtista As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRef As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents imgCaratula As System.Windows.Forms.PictureBox

End Class
