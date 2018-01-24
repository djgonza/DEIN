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
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.txtNombreArchivo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rtbTexto = New System.Windows.Forms.RichTextBox()
        Me.btnCrearArchivo = New System.Windows.Forms.Button()
        Me.btnExaminar = New System.Windows.Forms.Button()
        Me.lstArchivos = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rtbContenido = New System.Windows.Forms.RichTextBox()
        Me.btnHtml = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Usuario:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(172, 8)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(144, 29)
        Me.txtNombre.TabIndex = 1
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(322, 8)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(152, 29)
        Me.btnCrear.TabIndex = 2
        Me.btnCrear.Text = "Crear Carpeta Personal"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'txtNombreArchivo
        '
        Me.txtNombreArchivo.Location = New System.Drawing.Point(172, 43)
        Me.txtNombreArchivo.Name = "txtNombreArchivo"
        Me.txtNombreArchivo.Size = New System.Drawing.Size(144, 29)
        Me.txtNombreArchivo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre Archivo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Texto a almacenar"
        '
        'rtbTexto
        '
        Me.rtbTexto.Location = New System.Drawing.Point(17, 113)
        Me.rtbTexto.Name = "rtbTexto"
        Me.rtbTexto.Size = New System.Drawing.Size(251, 149)
        Me.rtbTexto.TabIndex = 6
        Me.rtbTexto.Text = ""
        '
        'btnCrearArchivo
        '
        Me.btnCrearArchivo.Location = New System.Drawing.Point(17, 268)
        Me.btnCrearArchivo.Name = "btnCrearArchivo"
        Me.btnCrearArchivo.Size = New System.Drawing.Size(144, 40)
        Me.btnCrearArchivo.TabIndex = 7
        Me.btnCrearArchivo.Text = "Crear Archivo"
        Me.btnCrearArchivo.UseVisualStyleBackColor = True
        '
        'btnExaminar
        '
        Me.btnExaminar.Location = New System.Drawing.Point(352, 77)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(292, 42)
        Me.btnExaminar.TabIndex = 8
        Me.btnExaminar.Text = "Examinar Carpeta Personal"
        Me.btnExaminar.UseVisualStyleBackColor = True
        '
        'lstArchivos
        '
        Me.lstArchivos.FormattingEnabled = True
        Me.lstArchivos.ItemHeight = 24
        Me.lstArchivos.Location = New System.Drawing.Point(354, 160)
        Me.lstArchivos.Name = "lstArchivos"
        Me.lstArchivos.Size = New System.Drawing.Size(194, 220)
        Me.lstArchivos.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(350, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Selecciona Archivo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(554, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 24)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Contenido"
        '
        'rtbContenido
        '
        Me.rtbContenido.Location = New System.Drawing.Point(554, 160)
        Me.rtbContenido.Name = "rtbContenido"
        Me.rtbContenido.Size = New System.Drawing.Size(316, 220)
        Me.rtbContenido.TabIndex = 12
        Me.rtbContenido.Text = ""
        '
        'btnHtml
        '
        Me.btnHtml.Location = New System.Drawing.Point(352, 386)
        Me.btnHtml.Name = "btnHtml"
        Me.btnHtml.Size = New System.Drawing.Size(194, 43)
        Me.btnHtml.TabIndex = 13
        Me.btnHtml.Text = "Guardar como html"
        Me.btnHtml.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 482)
        Me.Controls.Add(Me.btnHtml)
        Me.Controls.Add(Me.rtbContenido)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lstArchivos)
        Me.Controls.Add(Me.btnExaminar)
        Me.Controls.Add(Me.btnCrearArchivo)
        Me.Controls.Add(Me.rtbTexto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombreArchivo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnCrear As System.Windows.Forms.Button
    Friend WithEvents txtNombreArchivo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rtbTexto As System.Windows.Forms.RichTextBox
    Friend WithEvents btnCrearArchivo As System.Windows.Forms.Button
    Friend WithEvents btnExaminar As System.Windows.Forms.Button
    Friend WithEvents lstArchivos As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rtbContenido As System.Windows.Forms.RichTextBox
    Friend WithEvents btnHtml As System.Windows.Forms.Button

End Class
