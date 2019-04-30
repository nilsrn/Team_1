<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inoutView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnInUpdate = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbIn = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MarkerSomTilbakelevertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnOutUpdate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbOut = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MarkerSomUtlevertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(640, 450)
        Me.TabControl1.TabIndex = 19
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnInUpdate)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.lbIn)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(632, 424)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Mottak"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnInUpdate
        '
        Me.btnInUpdate.BackgroundImage = Global.assykkelutleie.My.Resources.Resources.reload
        Me.btnInUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnInUpdate.Location = New System.Drawing.Point(593, 14)
        Me.btnInUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnInUpdate.Name = "btnInUpdate"
        Me.btnInUpdate.Size = New System.Drawing.Size(30, 30)
        Me.btnInUpdate.TabIndex = 7
        Me.btnInUpdate.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 397)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(240, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Høyreklikk for å markere sykkel som tilbakelevert."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 31)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(306, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Oversikt over utleverte sykler som kan merkes som tilbakelevert"
        '
        'lbIn
        '
        Me.lbIn.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lbIn.FormattingEnabled = True
        Me.lbIn.Location = New System.Drawing.Point(13, 53)
        Me.lbIn.Margin = New System.Windows.Forms.Padding(2)
        Me.lbIn.Name = "lbIn"
        Me.lbIn.Size = New System.Drawing.Size(610, 342)
        Me.lbIn.TabIndex = 4
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MarkerSomTilbakelevertToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(205, 26)
        '
        'MarkerSomTilbakelevertToolStripMenuItem
        '
        Me.MarkerSomTilbakelevertToolStripMenuItem.Name = "MarkerSomTilbakelevertToolStripMenuItem"
        Me.MarkerSomTilbakelevertToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.MarkerSomTilbakelevertToolStripMenuItem.Text = "Marker som tilbakelevert"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnOutUpdate)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.lbOut)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(632, 424)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Uthenting"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnOutUpdate
        '
        Me.btnOutUpdate.BackgroundImage = Global.assykkelutleie.My.Resources.Resources.reload
        Me.btnOutUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnOutUpdate.Location = New System.Drawing.Point(593, 14)
        Me.btnOutUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOutUpdate.Name = "btnOutUpdate"
        Me.btnOutUpdate.Size = New System.Drawing.Size(30, 30)
        Me.btnOutUpdate.TabIndex = 11
        Me.btnOutUpdate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 397)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Høyreklikk for å markere sykkel som utlevert."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Oversikt over sykler som er tilgjengelig for utlevering"
        '
        'lbOut
        '
        Me.lbOut.ContextMenuStrip = Me.ContextMenuStrip2
        Me.lbOut.FormattingEnabled = True
        Me.lbOut.Location = New System.Drawing.Point(13, 53)
        Me.lbOut.Margin = New System.Windows.Forms.Padding(2)
        Me.lbOut.Name = "lbOut"
        Me.lbOut.Size = New System.Drawing.Size(610, 342)
        Me.lbOut.TabIndex = 8
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MarkerSomUtlevertToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(181, 26)
        '
        'MarkerSomUtlevertToolStripMenuItem
        '
        Me.MarkerSomUtlevertToolStripMenuItem.Name = "MarkerSomUtlevertToolStripMenuItem"
        Me.MarkerSomUtlevertToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MarkerSomUtlevertToolStripMenuItem.Text = "Marker som utlevert"
        '
        'inoutView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "inoutView"
        Me.Text = "inoutView"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnInUpdate As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbIn As ListBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents MarkerSomTilbakelevertToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnOutUpdate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbOut As ListBox
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents MarkerSomUtlevertToolStripMenuItem As ToolStripMenuItem
End Class
