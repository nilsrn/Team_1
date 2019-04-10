<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bicycleView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bicycleView))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.cbCurrentLoc = New System.Windows.Forms.ComboBox()
        Me.cbDefaultLoc = New System.Windows.Forms.ComboBox()
        Me.rbStolen = New System.Windows.Forms.RadioButton()
        Me.rbService = New System.Windows.Forms.RadioButton()
        Me.rbRented = New System.Windows.Forms.RadioButton()
        Me.rbAvailable = New System.Windows.Forms.RadioButton()
        Me.btnBicycleSave = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtFramenbr = New System.Windows.Forms.TextBox()
        Me.lbBicycle = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SlettToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnBicyclesSearch = New System.Windows.Forms.Button()
        Me.txtBicycleSearch = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(617, 426)
        Me.TabControl1.TabIndex = 18
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.cbType)
        Me.TabPage3.Controls.Add(Me.cbCurrentLoc)
        Me.TabPage3.Controls.Add(Me.cbDefaultLoc)
        Me.TabPage3.Controls.Add(Me.rbStolen)
        Me.TabPage3.Controls.Add(Me.rbService)
        Me.TabPage3.Controls.Add(Me.rbRented)
        Me.TabPage3.Controls.Add(Me.rbAvailable)
        Me.TabPage3.Controls.Add(Me.btnBicycleSave)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.txtFramenbr)
        Me.TabPage3.Controls.Add(Me.lbBicycle)
        Me.TabPage3.Controls.Add(Me.btnBicyclesSearch)
        Me.TabPage3.Controls.Add(Me.txtBicycleSearch)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(609, 400)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Sykler"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'cbType
        '
        Me.cbType.FormattingEnabled = True
        Me.cbType.Location = New System.Drawing.Point(427, 90)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(157, 21)
        Me.cbType.TabIndex = 48
        '
        'cbCurrentLoc
        '
        Me.cbCurrentLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cbCurrentLoc.FormattingEnabled = True
        Me.cbCurrentLoc.Location = New System.Drawing.Point(427, 143)
        Me.cbCurrentLoc.Name = "cbCurrentLoc"
        Me.cbCurrentLoc.Size = New System.Drawing.Size(157, 21)
        Me.cbCurrentLoc.TabIndex = 47
        '
        'cbDefaultLoc
        '
        Me.cbDefaultLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cbDefaultLoc.FormattingEnabled = True
        Me.cbDefaultLoc.Location = New System.Drawing.Point(427, 116)
        Me.cbDefaultLoc.Name = "cbDefaultLoc"
        Me.cbDefaultLoc.Size = New System.Drawing.Size(157, 21)
        Me.cbDefaultLoc.TabIndex = 46
        '
        'rbStolen
        '
        Me.rbStolen.AutoSize = True
        Me.rbStolen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbStolen.Location = New System.Drawing.Point(523, 193)
        Me.rbStolen.Name = "rbStolen"
        Me.rbStolen.Size = New System.Drawing.Size(54, 17)
        Me.rbStolen.TabIndex = 45
        Me.rbStolen.TabStop = True
        Me.rbStolen.Text = "Stjålet"
        Me.rbStolen.UseVisualStyleBackColor = True
        '
        'rbService
        '
        Me.rbService.AutoSize = True
        Me.rbService.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbService.Location = New System.Drawing.Point(523, 170)
        Me.rbService.Name = "rbService"
        Me.rbService.Size = New System.Drawing.Size(61, 17)
        Me.rbService.TabIndex = 44
        Me.rbService.TabStop = True
        Me.rbService.Text = "Service"
        Me.rbService.UseVisualStyleBackColor = True
        '
        'rbRented
        '
        Me.rbRented.AutoSize = True
        Me.rbRented.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbRented.Location = New System.Drawing.Point(427, 193)
        Me.rbRented.Name = "rbRented"
        Me.rbRented.Size = New System.Drawing.Size(52, 17)
        Me.rbRented.TabIndex = 43
        Me.rbRented.TabStop = True
        Me.rbRented.Text = "Utleid"
        Me.rbRented.UseVisualStyleBackColor = True
        '
        'rbAvailable
        '
        Me.rbAvailable.AutoSize = True
        Me.rbAvailable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbAvailable.Location = New System.Drawing.Point(427, 170)
        Me.rbAvailable.Name = "rbAvailable"
        Me.rbAvailable.Size = New System.Drawing.Size(51, 17)
        Me.rbAvailable.TabIndex = 42
        Me.rbAvailable.TabStop = True
        Me.rbAvailable.Text = "Ledig"
        Me.rbAvailable.UseVisualStyleBackColor = True
        '
        'btnBicycleSave
        '
        Me.btnBicycleSave.Location = New System.Drawing.Point(427, 229)
        Me.btnBicycleSave.Name = "btnBicycleSave"
        Me.btnBicycleSave.Size = New System.Drawing.Size(157, 23)
        Me.btnBicycleSave.TabIndex = 41
        Me.btnBicycleSave.Text = "Lagre"
        Me.btnBicycleSave.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(297, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Rammenummer:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(297, 174)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Status:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(297, 146)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 13)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Gjeldende lokasjon:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(297, 119)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 13)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Standard lokasjon:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(297, 93)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Sykkeltype:"
        '
        'txtFramenbr
        '
        Me.txtFramenbr.Location = New System.Drawing.Point(427, 64)
        Me.txtFramenbr.Name = "txtFramenbr"
        Me.txtFramenbr.Size = New System.Drawing.Size(157, 20)
        Me.txtFramenbr.TabIndex = 25
        '
        'lbBicycle
        '
        Me.lbBicycle.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lbBicycle.FormattingEnabled = True
        Me.lbBicycle.Location = New System.Drawing.Point(17, 60)
        Me.lbBicycle.Name = "lbBicycle"
        Me.lbBicycle.Size = New System.Drawing.Size(258, 329)
        Me.lbBicycle.TabIndex = 24
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SlettToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(98, 26)
        '
        'SlettToolStripMenuItem
        '
        Me.SlettToolStripMenuItem.Name = "SlettToolStripMenuItem"
        Me.SlettToolStripMenuItem.Size = New System.Drawing.Size(97, 22)
        Me.SlettToolStripMenuItem.Text = "Slett"
        '
        'btnBicyclesSearch
        '
        Me.btnBicyclesSearch.Location = New System.Drawing.Point(239, 31)
        Me.btnBicyclesSearch.Name = "btnBicyclesSearch"
        Me.btnBicyclesSearch.Size = New System.Drawing.Size(36, 20)
        Me.btnBicyclesSearch.TabIndex = 23
        Me.btnBicyclesSearch.Text = "Søk"
        Me.btnBicyclesSearch.UseVisualStyleBackColor = True
        '
        'txtBicycleSearch
        '
        Me.txtBicycleSearch.Location = New System.Drawing.Point(106, 31)
        Me.txtBicycleSearch.Name = "txtBicycleSearch"
        Me.txtBicycleSearch.Size = New System.Drawing.Size(127, 20)
        Me.txtBicycleSearch.TabIndex = 22
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(17, 34)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Rammenummer:"
        '
        'bicycleView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "bicycleView"
        Me.Text = "bicycles"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents SlettToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents rbStolen As RadioButton
    Friend WithEvents rbService As RadioButton
    Friend WithEvents rbRented As RadioButton
    Friend WithEvents rbAvailable As RadioButton
    Friend WithEvents btnBicycleSave As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtFramenbr As TextBox
    Friend WithEvents lbBicycle As ListBox
    Friend WithEvents btnBicyclesSearch As Button
    Friend WithEvents txtBicycleSearch As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cbDefaultLoc As ComboBox
    Friend WithEvents cbCurrentLoc As ComboBox
    Friend WithEvents cbType As ComboBox
End Class
