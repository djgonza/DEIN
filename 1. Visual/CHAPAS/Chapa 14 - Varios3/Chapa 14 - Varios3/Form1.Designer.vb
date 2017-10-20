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
        Me.mnuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnMessage = New System.Windows.Forms.Button()
        Me.hsScroll = New System.Windows.Forms.HScrollBar()
        Me.btnPosi = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDato
        '
        Me.txtDato.Location = New System.Drawing.Point(12, 24)
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(207, 20)
        Me.txtDato.TabIndex = 0
        Me.txtDato.Text = "patata"
        '
        'btnSeleccion
        '
        Me.btnSeleccion.Location = New System.Drawing.Point(240, 24)
        Me.btnSeleccion.Name = "btnSeleccion"
        Me.btnSeleccion.Size = New System.Drawing.Size(75, 23)
        Me.btnSeleccion.TabIndex = 1
        Me.btnSeleccion.Text = "Selecciono"
        Me.btnSeleccion.UseVisualStyleBackColor = True
        '
        'btnInStr
        '
        Me.btnInStr.Location = New System.Drawing.Point(240, 53)
        Me.btnInStr.Name = "btnInStr"
        Me.btnInStr.Size = New System.Drawing.Size(75, 23)
        Me.btnInStr.TabIndex = 2
        Me.btnInStr.Text = "inSTr"
        Me.btnInStr.UseVisualStyleBackColor = True
        '
        'txtDato2
        '
        Me.txtDato2.Location = New System.Drawing.Point(12, 53)
        Me.txtDato2.Name = "txtDato2"
        Me.txtDato2.Size = New System.Drawing.Size(207, 20)
        Me.txtDato2.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(207, 223)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'txtUpdate
        '
        Me.txtUpdate.Location = New System.Drawing.Point(182, 311)
        Me.txtUpdate.Name = "txtUpdate"
        Me.txtUpdate.Size = New System.Drawing.Size(75, 23)
        Me.txtUpdate.TabIndex = 5
        Me.txtUpdate.Text = "Update"
        Me.txtUpdate.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(227, 82)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(258, 223)
        Me.RichTextBox1.TabIndex = 6
        Me.RichTextBox1.Text = ""
        '
        'mnuPrincipal
        '
        Me.mnuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.mnuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mnuPrincipal.Name = "mnuPrincipal"
        Me.mnuPrincipal.Size = New System.Drawing.Size(497, 24)
        Me.mnuPrincipal.TabIndex = 7
        Me.mnuPrincipal.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirToolStripMenuItem, Me.CerrarToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.AbrirToolStripMenuItem.Text = "Abrir"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'btnMessage
        '
        Me.btnMessage.Location = New System.Drawing.Point(336, 24)
        Me.btnMessage.Name = "btnMessage"
        Me.btnMessage.Size = New System.Drawing.Size(149, 49)
        Me.btnMessage.TabIndex = 8
        Me.btnMessage.Text = "MessageBox"
        Me.btnMessage.UseVisualStyleBackColor = True
        '
        'hsScroll
        '
        Me.hsScroll.LargeChange = 2
        Me.hsScroll.Location = New System.Drawing.Point(12, 389)
        Me.hsScroll.Maximum = 10
        Me.hsScroll.Name = "hsScroll"
        Me.hsScroll.Size = New System.Drawing.Size(177, 17)
        Me.hsScroll.TabIndex = 9
        '
        'btnPosi
        '
        Me.btnPosi.Location = New System.Drawing.Point(201, 389)
        Me.btnPosi.Name = "btnPosi"
        Me.btnPosi.Size = New System.Drawing.Size(114, 23)
        Me.btnPosi.TabIndex = 10
        Me.btnPosi.Text = "Posición ScrollBar"
        Me.btnPosi.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(198, 363)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 428)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPosi)
        Me.Controls.Add(Me.hsScroll)
        Me.Controls.Add(Me.btnMessage)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.txtUpdate)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtDato2)
        Me.Controls.Add(Me.btnInStr)
        Me.Controls.Add(Me.btnSeleccion)
        Me.Controls.Add(Me.txtDato)
        Me.Controls.Add(Me.mnuPrincipal)
        Me.MainMenuStrip = Me.mnuPrincipal
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuPrincipal.ResumeLayout(False)
        Me.mnuPrincipal.PerformLayout()
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
    Friend WithEvents mnuPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnMessage As System.Windows.Forms.Button
    Friend WithEvents hsScroll As System.Windows.Forms.HScrollBar
    Friend WithEvents btnPosi As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
