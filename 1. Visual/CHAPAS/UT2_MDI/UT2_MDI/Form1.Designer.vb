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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCerrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVentana = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCascada = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOrganizada = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuArchivo, Me.mnuVentana})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.mnuVentana
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(906, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuArchivo
        '
        Me.mnuArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNuevo, Me.mnuCerrar})
        Me.mnuArchivo.MergeIndex = 0
        Me.mnuArchivo.Name = "mnuArchivo"
        Me.mnuArchivo.Size = New System.Drawing.Size(60, 20)
        Me.mnuArchivo.Text = "Archivo"
        '
        'mnuNuevo
        '
        Me.mnuNuevo.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.mnuNuevo.MergeIndex = 0
        Me.mnuNuevo.Name = "mnuNuevo"
        Me.mnuNuevo.Size = New System.Drawing.Size(152, 22)
        Me.mnuNuevo.Text = "Nuevo"
        '
        'mnuCerrar
        '
        Me.mnuCerrar.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.mnuCerrar.Name = "mnuCerrar"
        Me.mnuCerrar.Size = New System.Drawing.Size(152, 22)
        Me.mnuCerrar.Text = "Cerrar"
        '
        'mnuVentana
        '
        Me.mnuVentana.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCascada, Me.mnuHorizontal, Me.mnuVertical, Me.mnuOrganizada})
        Me.mnuVentana.MergeIndex = 2
        Me.mnuVentana.Name = "mnuVentana"
        Me.mnuVentana.Size = New System.Drawing.Size(61, 20)
        Me.mnuVentana.Text = "Ventana"
        '
        'mnuCascada
        '
        Me.mnuCascada.Name = "mnuCascada"
        Me.mnuCascada.Size = New System.Drawing.Size(152, 22)
        Me.mnuCascada.Text = "Cascada"
        '
        'mnuHorizontal
        '
        Me.mnuHorizontal.Name = "mnuHorizontal"
        Me.mnuHorizontal.Size = New System.Drawing.Size(152, 22)
        Me.mnuHorizontal.Text = "Horizontal"
        '
        'mnuVertical
        '
        Me.mnuVertical.Name = "mnuVertical"
        Me.mnuVertical.Size = New System.Drawing.Size(152, 22)
        Me.mnuVertical.Text = "Vertical"
        '
        'mnuOrganizada
        '
        Me.mnuOrganizada.Name = "mnuOrganizada"
        Me.mnuOrganizada.Size = New System.Drawing.Size(152, 22)
        Me.mnuOrganizada.Text = "Organizada"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 553)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuArchivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCerrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVentana As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCascada As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHorizontal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVertical As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOrganizada As System.Windows.Forms.ToolStripMenuItem

End Class
