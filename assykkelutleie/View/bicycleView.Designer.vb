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
        Me.TabBicycle = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbBicycleStatus = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbBicycleType = New System.Windows.Forms.ComboBox()
        Me.cbBicycleCurrentLoc = New System.Windows.Forms.ComboBox()
        Me.cbBicycleDefaultLoc = New System.Windows.Forms.ComboBox()
        Me.rbBicycleStolen = New System.Windows.Forms.RadioButton()
        Me.rbBicycleService = New System.Windows.Forms.RadioButton()
        Me.rbBicycleRented = New System.Windows.Forms.RadioButton()
        Me.rbBicycleAvailable = New System.Windows.Forms.RadioButton()
        Me.btnBicycleSave = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtBicycleID = New System.Windows.Forms.TextBox()
        Me.lbBicycle = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SlettToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnBicycleSearch = New System.Windows.Forms.Button()
        Me.TabEquipment = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbEquipmentType = New System.Windows.Forms.ComboBox()
        Me.cbEquipmentCurrentLoc = New System.Windows.Forms.ComboBox()
        Me.cbEquipmentDefaultLoc = New System.Windows.Forms.ComboBox()
        Me.rbEquipmentStolen = New System.Windows.Forms.RadioButton()
        Me.rbEquipmentService = New System.Windows.Forms.RadioButton()
        Me.rbEquipmentRented = New System.Windows.Forms.RadioButton()
        Me.rbEquipmentAvailable = New System.Windows.Forms.RadioButton()
        Me.btnEquipmentSave = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtEquipmentID = New System.Windows.Forms.TextBox()
        Me.lbEquipment = New System.Windows.Forms.ListBox()
        Me.btnEquipmentSearch = New System.Windows.Forms.Button()
        Me.cbEquipmentStatus = New System.Windows.Forms.ComboBox()
        Me.TabControl1.SuspendLayout()
        Me.TabBicycle.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabEquipment.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabBicycle)
        Me.TabControl1.Controls.Add(Me.TabEquipment)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(617, 426)
        Me.TabControl1.TabIndex = 18
        '
        'TabBicycle
        '
        Me.TabBicycle.Controls.Add(Me.Label2)
        Me.TabBicycle.Controls.Add(Me.cbBicycleStatus)
        Me.TabBicycle.Controls.Add(Me.Label1)
        Me.TabBicycle.Controls.Add(Me.cbBicycleType)
        Me.TabBicycle.Controls.Add(Me.cbBicycleCurrentLoc)
        Me.TabBicycle.Controls.Add(Me.cbBicycleDefaultLoc)
        Me.TabBicycle.Controls.Add(Me.rbBicycleStolen)
        Me.TabBicycle.Controls.Add(Me.rbBicycleService)
        Me.TabBicycle.Controls.Add(Me.rbBicycleRented)
        Me.TabBicycle.Controls.Add(Me.rbBicycleAvailable)
        Me.TabBicycle.Controls.Add(Me.btnBicycleSave)
        Me.TabBicycle.Controls.Add(Me.Label8)
        Me.TabBicycle.Controls.Add(Me.Label10)
        Me.TabBicycle.Controls.Add(Me.Label12)
        Me.TabBicycle.Controls.Add(Me.Label13)
        Me.TabBicycle.Controls.Add(Me.Label14)
        Me.TabBicycle.Controls.Add(Me.txtBicycleID)
        Me.TabBicycle.Controls.Add(Me.lbBicycle)
        Me.TabBicycle.Controls.Add(Me.btnBicycleSearch)
        Me.TabBicycle.Location = New System.Drawing.Point(4, 22)
        Me.TabBicycle.Name = "TabBicycle"
        Me.TabBicycle.Size = New System.Drawing.Size(609, 400)
        Me.TabBicycle.TabIndex = 2
        Me.TabBicycle.Text = "Sykler"
        Me.TabBicycle.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 370)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Høyreklikk for å slette valgt sykkel."
        '
        'cbBicycleStatus
        '
        Me.cbBicycleStatus.FormattingEnabled = True
        Me.cbBicycleStatus.Location = New System.Drawing.Point(17, 26)
        Me.cbBicycleStatus.Name = "cbBicycleStatus"
        Me.cbBicycleStatus.Size = New System.Drawing.Size(258, 21)
        Me.cbBicycleStatus.TabIndex = 51
        Me.cbBicycleStatus.Text = "Status"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Filter"
        '
        'cbBicycleType
        '
        Me.cbBicycleType.FormattingEnabled = True
        Me.cbBicycleType.Location = New System.Drawing.Point(427, 90)
        Me.cbBicycleType.Name = "cbBicycleType"
        Me.cbBicycleType.Size = New System.Drawing.Size(157, 21)
        Me.cbBicycleType.TabIndex = 48
        '
        'cbBicycleCurrentLoc
        '
        Me.cbBicycleCurrentLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cbBicycleCurrentLoc.FormattingEnabled = True
        Me.cbBicycleCurrentLoc.Location = New System.Drawing.Point(427, 143)
        Me.cbBicycleCurrentLoc.Name = "cbBicycleCurrentLoc"
        Me.cbBicycleCurrentLoc.Size = New System.Drawing.Size(157, 21)
        Me.cbBicycleCurrentLoc.TabIndex = 47
        '
        'cbBicycleDefaultLoc
        '
        Me.cbBicycleDefaultLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cbBicycleDefaultLoc.FormattingEnabled = True
        Me.cbBicycleDefaultLoc.Location = New System.Drawing.Point(427, 116)
        Me.cbBicycleDefaultLoc.Name = "cbBicycleDefaultLoc"
        Me.cbBicycleDefaultLoc.Size = New System.Drawing.Size(157, 21)
        Me.cbBicycleDefaultLoc.TabIndex = 46
        '
        'rbBicycleStolen
        '
        Me.rbBicycleStolen.AutoSize = True
        Me.rbBicycleStolen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbBicycleStolen.Location = New System.Drawing.Point(523, 193)
        Me.rbBicycleStolen.Name = "rbBicycleStolen"
        Me.rbBicycleStolen.Size = New System.Drawing.Size(54, 17)
        Me.rbBicycleStolen.TabIndex = 45
        Me.rbBicycleStolen.Text = "Stjålet"
        Me.rbBicycleStolen.UseVisualStyleBackColor = True
        '
        'rbBicycleService
        '
        Me.rbBicycleService.AutoSize = True
        Me.rbBicycleService.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbBicycleService.Location = New System.Drawing.Point(523, 170)
        Me.rbBicycleService.Name = "rbBicycleService"
        Me.rbBicycleService.Size = New System.Drawing.Size(61, 17)
        Me.rbBicycleService.TabIndex = 44
        Me.rbBicycleService.Text = "Service"
        Me.rbBicycleService.UseVisualStyleBackColor = True
        '
        'rbBicycleRented
        '
        Me.rbBicycleRented.AutoSize = True
        Me.rbBicycleRented.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbBicycleRented.Location = New System.Drawing.Point(427, 193)
        Me.rbBicycleRented.Name = "rbBicycleRented"
        Me.rbBicycleRented.Size = New System.Drawing.Size(52, 17)
        Me.rbBicycleRented.TabIndex = 43
        Me.rbBicycleRented.Text = "Utleid"
        Me.rbBicycleRented.UseVisualStyleBackColor = True
        '
        'rbBicycleAvailable
        '
        Me.rbBicycleAvailable.AutoSize = True
        Me.rbBicycleAvailable.Checked = True
        Me.rbBicycleAvailable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbBicycleAvailable.Location = New System.Drawing.Point(427, 170)
        Me.rbBicycleAvailable.Name = "rbBicycleAvailable"
        Me.rbBicycleAvailable.Size = New System.Drawing.Size(51, 17)
        Me.rbBicycleAvailable.TabIndex = 42
        Me.rbBicycleAvailable.TabStop = True
        Me.rbBicycleAvailable.Text = "Ledig"
        Me.rbBicycleAvailable.UseVisualStyleBackColor = True
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
        'txtBicycleID
        '
        Me.txtBicycleID.Location = New System.Drawing.Point(427, 64)
        Me.txtBicycleID.Name = "txtBicycleID"
        Me.txtBicycleID.Size = New System.Drawing.Size(115, 20)
        Me.txtBicycleID.TabIndex = 25
        '
        'lbBicycle
        '
        Me.lbBicycle.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lbBicycle.FormattingEnabled = True
        Me.lbBicycle.Location = New System.Drawing.Point(17, 64)
        Me.lbBicycle.Name = "lbBicycle"
        Me.lbBicycle.Size = New System.Drawing.Size(258, 303)
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
        'btnBicycleSearch
        '
        Me.btnBicycleSearch.Location = New System.Drawing.Point(548, 64)
        Me.btnBicycleSearch.Name = "btnBicycleSearch"
        Me.btnBicycleSearch.Size = New System.Drawing.Size(36, 20)
        Me.btnBicycleSearch.TabIndex = 23
        Me.btnBicycleSearch.Text = "Søk"
        Me.btnBicycleSearch.UseVisualStyleBackColor = True
        '
        'TabEquipment
        '
        Me.TabEquipment.Controls.Add(Me.cbEquipmentStatus)
        Me.TabEquipment.Controls.Add(Me.Label3)
        Me.TabEquipment.Controls.Add(Me.Label4)
        Me.TabEquipment.Controls.Add(Me.cbEquipmentType)
        Me.TabEquipment.Controls.Add(Me.cbEquipmentCurrentLoc)
        Me.TabEquipment.Controls.Add(Me.cbEquipmentDefaultLoc)
        Me.TabEquipment.Controls.Add(Me.rbEquipmentStolen)
        Me.TabEquipment.Controls.Add(Me.rbEquipmentService)
        Me.TabEquipment.Controls.Add(Me.rbEquipmentRented)
        Me.TabEquipment.Controls.Add(Me.rbEquipmentAvailable)
        Me.TabEquipment.Controls.Add(Me.btnEquipmentSave)
        Me.TabEquipment.Controls.Add(Me.Label5)
        Me.TabEquipment.Controls.Add(Me.Label6)
        Me.TabEquipment.Controls.Add(Me.Label7)
        Me.TabEquipment.Controls.Add(Me.Label9)
        Me.TabEquipment.Controls.Add(Me.Label11)
        Me.TabEquipment.Controls.Add(Me.txtEquipmentID)
        Me.TabEquipment.Controls.Add(Me.lbEquipment)
        Me.TabEquipment.Controls.Add(Me.btnEquipmentSearch)
        Me.TabEquipment.Location = New System.Drawing.Point(4, 22)
        Me.TabEquipment.Name = "TabEquipment"
        Me.TabEquipment.Size = New System.Drawing.Size(609, 400)
        Me.TabEquipment.TabIndex = 3
        Me.TabEquipment.Text = "Utstyr"
        Me.TabEquipment.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 371)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 13)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Høyreklikk for å slette valgt sykkel."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Filter"
        '
        'cbEquipmentType
        '
        Me.cbEquipmentType.FormattingEnabled = True
        Me.cbEquipmentType.Location = New System.Drawing.Point(425, 91)
        Me.cbEquipmentType.Name = "cbEquipmentType"
        Me.cbEquipmentType.Size = New System.Drawing.Size(157, 21)
        Me.cbEquipmentType.TabIndex = 69
        '
        'cbEquipmentCurrentLoc
        '
        Me.cbEquipmentCurrentLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cbEquipmentCurrentLoc.FormattingEnabled = True
        Me.cbEquipmentCurrentLoc.Location = New System.Drawing.Point(425, 144)
        Me.cbEquipmentCurrentLoc.Name = "cbEquipmentCurrentLoc"
        Me.cbEquipmentCurrentLoc.Size = New System.Drawing.Size(157, 21)
        Me.cbEquipmentCurrentLoc.TabIndex = 68
        '
        'cbEquipmentDefaultLoc
        '
        Me.cbEquipmentDefaultLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cbEquipmentDefaultLoc.FormattingEnabled = True
        Me.cbEquipmentDefaultLoc.Location = New System.Drawing.Point(425, 117)
        Me.cbEquipmentDefaultLoc.Name = "cbEquipmentDefaultLoc"
        Me.cbEquipmentDefaultLoc.Size = New System.Drawing.Size(157, 21)
        Me.cbEquipmentDefaultLoc.TabIndex = 67
        '
        'rbEquipmentStolen
        '
        Me.rbEquipmentStolen.AutoSize = True
        Me.rbEquipmentStolen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbEquipmentStolen.Location = New System.Drawing.Point(521, 194)
        Me.rbEquipmentStolen.Name = "rbEquipmentStolen"
        Me.rbEquipmentStolen.Size = New System.Drawing.Size(54, 17)
        Me.rbEquipmentStolen.TabIndex = 66
        Me.rbEquipmentStolen.Text = "Stjålet"
        Me.rbEquipmentStolen.UseVisualStyleBackColor = True
        '
        'rbEquipmentService
        '
        Me.rbEquipmentService.AutoSize = True
        Me.rbEquipmentService.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbEquipmentService.Location = New System.Drawing.Point(521, 171)
        Me.rbEquipmentService.Name = "rbEquipmentService"
        Me.rbEquipmentService.Size = New System.Drawing.Size(61, 17)
        Me.rbEquipmentService.TabIndex = 65
        Me.rbEquipmentService.Text = "Service"
        Me.rbEquipmentService.UseVisualStyleBackColor = True
        '
        'rbEquipmentRented
        '
        Me.rbEquipmentRented.AutoSize = True
        Me.rbEquipmentRented.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbEquipmentRented.Location = New System.Drawing.Point(425, 194)
        Me.rbEquipmentRented.Name = "rbEquipmentRented"
        Me.rbEquipmentRented.Size = New System.Drawing.Size(52, 17)
        Me.rbEquipmentRented.TabIndex = 64
        Me.rbEquipmentRented.Text = "Utleid"
        Me.rbEquipmentRented.UseVisualStyleBackColor = True
        '
        'rbEquipmentAvailable
        '
        Me.rbEquipmentAvailable.AutoSize = True
        Me.rbEquipmentAvailable.Checked = True
        Me.rbEquipmentAvailable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbEquipmentAvailable.Location = New System.Drawing.Point(425, 171)
        Me.rbEquipmentAvailable.Name = "rbEquipmentAvailable"
        Me.rbEquipmentAvailable.Size = New System.Drawing.Size(51, 17)
        Me.rbEquipmentAvailable.TabIndex = 63
        Me.rbEquipmentAvailable.TabStop = True
        Me.rbEquipmentAvailable.Text = "Ledig"
        Me.rbEquipmentAvailable.UseVisualStyleBackColor = True
        '
        'btnEquipmentSave
        '
        Me.btnEquipmentSave.Location = New System.Drawing.Point(425, 230)
        Me.btnEquipmentSave.Name = "btnEquipmentSave"
        Me.btnEquipmentSave.Size = New System.Drawing.Size(157, 23)
        Me.btnEquipmentSave.TabIndex = 62
        Me.btnEquipmentSave.Text = "Lagre"
        Me.btnEquipmentSave.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(295, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Utstyr ID:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(295, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Status:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(295, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 13)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Gjeldende lokasjon:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(295, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 13)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Standard lokasjon:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(295, 94)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Utstyrstype:"
        '
        'txtEquipmentID
        '
        Me.txtEquipmentID.Location = New System.Drawing.Point(425, 65)
        Me.txtEquipmentID.Name = "txtEquipmentID"
        Me.txtEquipmentID.Size = New System.Drawing.Size(115, 20)
        Me.txtEquipmentID.TabIndex = 56
        '
        'lbEquipment
        '
        Me.lbEquipment.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lbEquipment.FormattingEnabled = True
        Me.lbEquipment.Location = New System.Drawing.Point(15, 65)
        Me.lbEquipment.Name = "lbEquipment"
        Me.lbEquipment.Size = New System.Drawing.Size(258, 303)
        Me.lbEquipment.TabIndex = 55
        '
        'btnEquipmentSearch
        '
        Me.btnEquipmentSearch.Location = New System.Drawing.Point(546, 65)
        Me.btnEquipmentSearch.Name = "btnEquipmentSearch"
        Me.btnEquipmentSearch.Size = New System.Drawing.Size(36, 20)
        Me.btnEquipmentSearch.TabIndex = 54
        Me.btnEquipmentSearch.Text = "Søk"
        Me.btnEquipmentSearch.UseVisualStyleBackColor = True
        '
        'cbEquipmentStatus
        '
        Me.cbEquipmentStatus.FormattingEnabled = True
        Me.cbEquipmentStatus.Location = New System.Drawing.Point(15, 27)
        Me.cbEquipmentStatus.Name = "cbEquipmentStatus"
        Me.cbEquipmentStatus.Size = New System.Drawing.Size(258, 21)
        Me.cbEquipmentStatus.TabIndex = 73
        Me.cbEquipmentStatus.Text = "Status"
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
        Me.TabBicycle.ResumeLayout(False)
        Me.TabBicycle.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TabEquipment.ResumeLayout(False)
        Me.TabEquipment.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents SlettToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabBicycle As TabPage
    Friend WithEvents rbBicycleStolen As RadioButton
    Friend WithEvents rbBicycleService As RadioButton
    Friend WithEvents rbBicycleRented As RadioButton
    Friend WithEvents rbBicycleAvailable As RadioButton
    Friend WithEvents btnBicycleSave As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtBicycleID As TextBox
    Friend WithEvents lbBicycle As ListBox
    Friend WithEvents btnBicycleSearch As Button
    Friend WithEvents cbBicycleDefaultLoc As ComboBox
    Friend WithEvents cbBicycleCurrentLoc As ComboBox
    Friend WithEvents cbBicycleType As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbBicycleStatus As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TabEquipment As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbEquipmentType As ComboBox
    Friend WithEvents cbEquipmentCurrentLoc As ComboBox
    Friend WithEvents cbEquipmentDefaultLoc As ComboBox
    Friend WithEvents rbEquipmentStolen As RadioButton
    Friend WithEvents rbEquipmentService As RadioButton
    Friend WithEvents rbEquipmentRented As RadioButton
    Friend WithEvents rbEquipmentAvailable As RadioButton
    Friend WithEvents btnEquipmentSave As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtEquipmentID As TextBox
    Friend WithEvents lbEquipment As ListBox
    Friend WithEvents btnEquipmentSearch As Button
    Friend WithEvents cbEquipmentStatus As ComboBox
End Class
