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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArchivoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.wgeuf = New System.Windows.Forms.StatusStrip()
        Me.etEstado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mnuPais = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAñadir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBorrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.mnuBotonDerecho = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.WewerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WerqerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RewqewrwerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.WeqrqewrwqToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QwerqwerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WeqrqwrewqerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WerqwerweqToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.wgeuf.SuspendLayout()
        Me.mnuBotonDerecho.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.mnuPais})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(335, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem1, Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'ArchivoToolStripMenuItem1
        '
        Me.ArchivoToolStripMenuItem1.Name = "ArchivoToolStripMenuItem1"
        Me.ArchivoToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ArchivoToolStripMenuItem1.Size = New System.Drawing.Size(156, 22)
        Me.ArchivoToolStripMenuItem1.Text = "&Archivo"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(153, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton5, Me.ToolStripSeparator1, Me.ToolStripButton6, Me.ToolStripButton7, Me.ToolStripButton8})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(335, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'wgeuf
        '
        Me.wgeuf.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.etEstado})
        Me.wgeuf.Location = New System.Drawing.Point(0, 260)
        Me.wgeuf.Name = "wgeuf"
        Me.wgeuf.Size = New System.Drawing.Size(335, 22)
        Me.wgeuf.TabIndex = 2
        Me.wgeuf.Text = "Listo"
        '
        'etEstado
        '
        Me.etEstado.Name = "etEstado"
        Me.etEstado.Size = New System.Drawing.Size(32, 17)
        Me.etEstado.Text = "Listo"
        '
        'mnuPais
        '
        Me.mnuPais.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAñadir, Me.mnuBorrar, Me.ToolStripMenuItem2})
        Me.mnuPais.Name = "mnuPais"
        Me.mnuPais.Size = New System.Drawing.Size(40, 20)
        Me.mnuPais.Text = "País"
        '
        'mnuAñadir
        '
        Me.mnuAñadir.Name = "mnuAñadir"
        Me.mnuAñadir.Size = New System.Drawing.Size(152, 22)
        Me.mnuAñadir.Text = "Añadir"
        '
        'mnuBorrar
        '
        Me.mnuBorrar.Name = "mnuBorrar"
        Me.mnuBorrar.Size = New System.Drawing.Size(152, 22)
        Me.mnuBorrar.Text = "Borrar"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(149, 6)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "ToolStripButton4"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "ToolStripButton5"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "ToolStripButton6"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton7.Text = "ToolStripButton7"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton8.Text = "ToolStripButton8"
        '
        'TextBox1
        '
        Me.TextBox1.ContextMenuStrip = Me.mnuBotonDerecho
        Me.TextBox1.Location = New System.Drawing.Point(46, 108)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(185, 20)
        Me.TextBox1.TabIndex = 3
        '
        'mnuBotonDerecho
        '
        Me.mnuBotonDerecho.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WewerToolStripMenuItem, Me.WerqerToolStripMenuItem, Me.RewqewrwerToolStripMenuItem, Me.ToolStripMenuItem3, Me.WeqrqewrwqToolStripMenuItem, Me.QwerqwerToolStripMenuItem})
        Me.mnuBotonDerecho.Name = "mnuBotonDerecho"
        Me.mnuBotonDerecho.Size = New System.Drawing.Size(193, 120)
        '
        'WewerToolStripMenuItem
        '
        Me.WewerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WeqrqwrewqerToolStripMenuItem, Me.WerqwerweqToolStripMenuItem})
        Me.WewerToolStripMenuItem.Name = "WewerToolStripMenuItem"
        Me.WewerToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.WewerToolStripMenuItem.Text = "Copiar al portapapeles"
        '
        'WerqerToolStripMenuItem
        '
        Me.WerqerToolStripMenuItem.Name = "WerqerToolStripMenuItem"
        Me.WerqerToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.WerqerToolStripMenuItem.Text = "Pegar"
        '
        'RewqewrwerToolStripMenuItem
        '
        Me.RewqewrwerToolStripMenuItem.Name = "RewqewrwerToolStripMenuItem"
        Me.RewqewrwerToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.RewqewrwerToolStripMenuItem.Text = "rewqewrwer"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(139, 6)
        '
        'WeqrqewrwqToolStripMenuItem
        '
        Me.WeqrqewrwqToolStripMenuItem.Name = "WeqrqewrwqToolStripMenuItem"
        Me.WeqrqewrwqToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.WeqrqewrwqToolStripMenuItem.Text = "weqrqewrwq"
        '
        'QwerqwerToolStripMenuItem
        '
        Me.QwerqwerToolStripMenuItem.Name = "QwerqwerToolStripMenuItem"
        Me.QwerqwerToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.QwerqwerToolStripMenuItem.Text = "qwerqwer"
        '
        'WeqrqwrewqerToolStripMenuItem
        '
        Me.WeqrqwrewqerToolStripMenuItem.Name = "WeqrqwrewqerToolStripMenuItem"
        Me.WeqrqwrewqerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.WeqrqwrewqerToolStripMenuItem.Text = "weqrqwrewqer"
        '
        'WerqwerweqToolStripMenuItem
        '
        Me.WerqwerweqToolStripMenuItem.Name = "WerqwerweqToolStripMenuItem"
        Me.WerqwerweqToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.WerqwerweqToolStripMenuItem.Text = "werqwerweq"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 282)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.wgeuf)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.wgeuf.ResumeLayout(False)
        Me.wgeuf.PerformLayout()
        Me.mnuBotonDerecho.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArchivoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents wgeuf As System.Windows.Forms.StatusStrip
    Friend WithEvents etEstado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mnuPais As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAñadir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBorrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents mnuBotonDerecho As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents WewerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WeqrqwrewqerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WerqwerweqToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WerqerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RewqewrwerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents WeqrqewrwqToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QwerqwerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
