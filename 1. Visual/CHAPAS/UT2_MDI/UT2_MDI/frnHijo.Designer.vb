<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnHijo
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
        Me.mnuHijo = New System.Windows.Forms.MenuStrip()
        Me.mnuArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAaa = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBbb = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCcc = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdicion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCortar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPegar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopiar = New System.Windows.Forms.ToolStripMenuItem()
        Me.rtbTextillo = New System.Windows.Forms.RichTextBox()
        Me.mnuHijo.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuHijo
        '
        Me.mnuHijo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuArchivo, Me.mnuEdicion})
        Me.mnuHijo.Location = New System.Drawing.Point(0, 0)
        Me.mnuHijo.Name = "mnuHijo"
        Me.mnuHijo.Size = New System.Drawing.Size(534, 24)
        Me.mnuHijo.TabIndex = 0
        Me.mnuHijo.Text = "MenuStrip1"
        '
        'mnuArchivo
        '
        Me.mnuArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAaa, Me.mnuBbb, Me.mnuCcc})
        Me.mnuArchivo.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
        Me.mnuArchivo.MergeIndex = 0
        Me.mnuArchivo.Name = "mnuArchivo"
        Me.mnuArchivo.Size = New System.Drawing.Size(60, 20)
        Me.mnuArchivo.Text = "Archivo"
        '
        'mnuAaa
        '
        Me.mnuAaa.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.mnuAaa.MergeIndex = 1
        Me.mnuAaa.Name = "mnuAaa"
        Me.mnuAaa.Size = New System.Drawing.Size(95, 22)
        Me.mnuAaa.Text = "aaa"
        '
        'mnuBbb
        '
        Me.mnuBbb.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.mnuBbb.MergeIndex = 2
        Me.mnuBbb.Name = "mnuBbb"
        Me.mnuBbb.Size = New System.Drawing.Size(95, 22)
        Me.mnuBbb.Text = "bbb"
        '
        'mnuCcc
        '
        Me.mnuCcc.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.mnuCcc.MergeIndex = 3
        Me.mnuCcc.Name = "mnuCcc"
        Me.mnuCcc.Size = New System.Drawing.Size(95, 22)
        Me.mnuCcc.Text = "ccc"
        '
        'mnuEdicion
        '
        Me.mnuEdicion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCortar, Me.mnuPegar, Me.mnuCopiar})
        Me.mnuEdicion.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.mnuEdicion.MergeIndex = 1
        Me.mnuEdicion.Name = "mnuEdicion"
        Me.mnuEdicion.Size = New System.Drawing.Size(58, 20)
        Me.mnuEdicion.Text = "Edicion"
        '
        'mnuCortar
        '
        Me.mnuCortar.Name = "mnuCortar"
        Me.mnuCortar.Size = New System.Drawing.Size(109, 22)
        Me.mnuCortar.Text = "Cortar"
        '
        'mnuPegar
        '
        Me.mnuPegar.Name = "mnuPegar"
        Me.mnuPegar.Size = New System.Drawing.Size(109, 22)
        Me.mnuPegar.Text = "Pegar"
        '
        'mnuCopiar
        '
        Me.mnuCopiar.Name = "mnuCopiar"
        Me.mnuCopiar.Size = New System.Drawing.Size(109, 22)
        Me.mnuCopiar.Text = "Copiar"
        '
        'rtbTextillo
        '
        Me.rtbTextillo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.rtbTextillo.Location = New System.Drawing.Point(0, 283)
        Me.rtbTextillo.Name = "rtbTextillo"
        Me.rtbTextillo.Size = New System.Drawing.Size(534, 135)
        Me.rtbTextillo.TabIndex = 1
        Me.rtbTextillo.Text = ""
        '
        'frnHijo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 418)
        Me.Controls.Add(Me.rtbTextillo)
        Me.Controls.Add(Me.mnuHijo)
        Me.MainMenuStrip = Me.mnuHijo
        Me.Name = "frnHijo"
        Me.Text = "frnHijo"
        Me.mnuHijo.ResumeLayout(False)
        Me.mnuHijo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuHijo As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuArchivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAaa As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBbb As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCcc As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdicion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCortar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPegar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCopiar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rtbTextillo As System.Windows.Forms.RichTextBox
End Class
