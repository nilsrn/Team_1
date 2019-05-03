<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class rentalView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rentalView))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.rentalcomplete = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.filing = New System.Windows.Forms.ComboBox()
        Me.commenttxt = New System.Windows.Forms.TextBox()
        Me.extradition = New System.Windows.Forms.ComboBox()
        Me.filingdate = New System.Windows.Forms.DateTimePicker()
        Me.extraditiondate = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnLeggTil = New System.Windows.Forms.Button()
        Me.lbOversikt = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pickequipment = New System.Windows.Forms.ComboBox()
        Me.pickbike = New System.Windows.Forms.ComboBox()
        Me.Kunde = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.presentcustomerid = New System.Windows.Forms.TextBox()
        Me.mailtxt = New System.Windows.Forms.TextBox()
        Me.surnametxt = New System.Windows.Forms.TextBox()
        Me.firstnametxt = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.searchrentals = New System.Windows.Forms.Button()
        Me.txtrentalsearch = New System.Windows.Forms.TextBox()
        Me.lbrentals = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SlettToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Kunde.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(853, 554)
        Me.TabControl1.TabIndex = 12
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.rentalcomplete)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.Kunde)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Size = New System.Drawing.Size(845, 525)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ny bestilling"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'rentalcomplete
        '
        Me.rentalcomplete.Location = New System.Drawing.Point(291, 398)
        Me.rentalcomplete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rentalcomplete.Name = "rentalcomplete"
        Me.rentalcomplete.Size = New System.Drawing.Size(264, 49)
        Me.rentalcomplete.TabIndex = 3
        Me.rentalcomplete.Text = "Fullfør bestilling"
        Me.rentalcomplete.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.filing)
        Me.GroupBox3.Controls.Add(Me.commenttxt)
        Me.GroupBox3.Controls.Add(Me.extradition)
        Me.GroupBox3.Controls.Add(Me.filingdate)
        Me.GroupBox3.Controls.Add(Me.extraditiondate)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(572, 18)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(260, 320)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Utlevering og innlevering"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 130)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 17)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Kommentar:"
        '
        'filing
        '
        Me.filing.FormattingEnabled = True
        Me.filing.Location = New System.Drawing.Point(139, 78)
        Me.filing.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.filing.Name = "filing"
        Me.filing.Size = New System.Drawing.Size(112, 24)
        Me.filing.TabIndex = 10
        '
        'commenttxt
        '
        Me.commenttxt.Location = New System.Drawing.Point(12, 149)
        Me.commenttxt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.commenttxt.Multiline = True
        Me.commenttxt.Name = "commenttxt"
        Me.commenttxt.Size = New System.Drawing.Size(236, 154)
        Me.commenttxt.TabIndex = 4
        '
        'extradition
        '
        Me.extradition.FormattingEnabled = True
        Me.extradition.Location = New System.Drawing.Point(12, 78)
        Me.extradition.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.extradition.Name = "extradition"
        Me.extradition.Size = New System.Drawing.Size(112, 24)
        Me.extradition.TabIndex = 9
        '
        'filingdate
        '
        Me.filingdate.CustomFormat = ""
        Me.filingdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.filingdate.Location = New System.Drawing.Point(139, 46)
        Me.filingdate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.filingdate.Name = "filingdate"
        Me.filingdate.Size = New System.Drawing.Size(112, 22)
        Me.filingdate.TabIndex = 6
        '
        'extraditiondate
        '
        Me.extraditiondate.CustomFormat = ""
        Me.extraditiondate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.extraditiondate.Location = New System.Drawing.Point(12, 46)
        Me.extraditiondate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.extraditiondate.Name = "extraditiondate"
        Me.extraditiondate.Size = New System.Drawing.Size(112, 22)
        Me.extraditiondate.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(135, 25)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 17)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Innlevering:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 25)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 17)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Utlevering:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnLeggTil)
        Me.GroupBox2.Controls.Add(Me.lbOversikt)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.pickequipment)
        Me.GroupBox2.Controls.Add(Me.pickbike)
        Me.GroupBox2.Location = New System.Drawing.Point(291, 18)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(264, 320)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sykkel og utstyr"
        '
        'btnLeggTil
        '
        Me.btnLeggTil.Location = New System.Drawing.Point(9, 78)
        Me.btnLeggTil.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLeggTil.Name = "btnLeggTil"
        Me.btnLeggTil.Size = New System.Drawing.Size(245, 41)
        Me.btnLeggTil.TabIndex = 5
        Me.btnLeggTil.Text = "Legg til"
        Me.btnLeggTil.UseVisualStyleBackColor = True
        '
        'lbOversikt
        '
        Me.lbOversikt.FormattingEnabled = True
        Me.lbOversikt.ItemHeight = 16
        Me.lbOversikt.Location = New System.Drawing.Point(9, 158)
        Me.lbOversikt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbOversikt.Name = "lbOversikt"
        Me.lbOversikt.Size = New System.Drawing.Size(245, 148)
        Me.lbOversikt.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(137, 25)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 17)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Velg utstyr:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 25)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Velg sykkel:"
        '
        'pickequipment
        '
        Me.pickequipment.FormattingEnabled = True
        Me.pickequipment.Location = New System.Drawing.Point(141, 46)
        Me.pickequipment.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pickequipment.Name = "pickequipment"
        Me.pickequipment.Size = New System.Drawing.Size(113, 24)
        Me.pickequipment.TabIndex = 1
        '
        'pickbike
        '
        Me.pickbike.FormattingEnabled = True
        Me.pickbike.Location = New System.Drawing.Point(9, 46)
        Me.pickbike.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pickbike.Name = "pickbike"
        Me.pickbike.Size = New System.Drawing.Size(113, 24)
        Me.pickbike.TabIndex = 0
        '
        'Kunde
        '
        Me.Kunde.Controls.Add(Me.Label11)
        Me.Kunde.Controls.Add(Me.Label12)
        Me.Kunde.Controls.Add(Me.Label14)
        Me.Kunde.Controls.Add(Me.Label15)
        Me.Kunde.Controls.Add(Me.presentcustomerid)
        Me.Kunde.Controls.Add(Me.mailtxt)
        Me.Kunde.Controls.Add(Me.surnametxt)
        Me.Kunde.Controls.Add(Me.firstnametxt)
        Me.Kunde.Controls.Add(Me.btnSearch)
        Me.Kunde.Controls.Add(Me.txtsearch)
        Me.Kunde.Controls.Add(Me.Label1)
        Me.Kunde.Location = New System.Drawing.Point(11, 18)
        Me.Kunde.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Kunde.Name = "Kunde"
        Me.Kunde.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Kunde.Size = New System.Drawing.Size(261, 320)
        Me.Kunde.TabIndex = 0
        Me.Kunde.TabStop = False
        Me.Kunde.Text = "Kunde"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 134)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 17)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Fornavn:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 198)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 17)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "E-post:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 230)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(111, 17)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "Telefonnummer:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 166)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 17)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "Etternavn:"
        '
        'presentcustomerid
        '
        Me.presentcustomerid.Location = New System.Drawing.Point(120, 226)
        Me.presentcustomerid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.presentcustomerid.Name = "presentcustomerid"
        Me.presentcustomerid.ReadOnly = True
        Me.presentcustomerid.Size = New System.Drawing.Size(132, 22)
        Me.presentcustomerid.TabIndex = 11
        '
        'mailtxt
        '
        Me.mailtxt.Location = New System.Drawing.Point(120, 194)
        Me.mailtxt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mailtxt.Name = "mailtxt"
        Me.mailtxt.ReadOnly = True
        Me.mailtxt.Size = New System.Drawing.Size(132, 22)
        Me.mailtxt.TabIndex = 8
        '
        'surnametxt
        '
        Me.surnametxt.Location = New System.Drawing.Point(120, 162)
        Me.surnametxt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.surnametxt.Name = "surnametxt"
        Me.surnametxt.ReadOnly = True
        Me.surnametxt.Size = New System.Drawing.Size(132, 22)
        Me.surnametxt.TabIndex = 7
        '
        'firstnametxt
        '
        Me.firstnametxt.Location = New System.Drawing.Point(120, 130)
        Me.firstnametxt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.firstnametxt.Name = "firstnametxt"
        Me.firstnametxt.ReadOnly = True
        Me.firstnametxt.Size = New System.Drawing.Size(132, 22)
        Me.firstnametxt.TabIndex = 6
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(155, 43)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 28)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Søk"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(13, 46)
        Me.txtsearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(132, 22)
        Me.txtsearch.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Telefonnummer:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.searchrentals)
        Me.TabPage2.Controls.Add(Me.txtrentalsearch)
        Me.TabPage2.Controls.Add(Me.lbrentals)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage2.Size = New System.Drawing.Size(845, 525)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Bestillingsoversikt"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 492)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(241, 17)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Høyreklikk for å slette valgt bestilling."
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.assykkelutleie.My.Resources.Resources.reload
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Location = New System.Drawing.Point(792, 26)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 37)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = True
        '
        'searchrentals
        '
        Me.searchrentals.Location = New System.Drawing.Point(181, 38)
        Me.searchrentals.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.searchrentals.Name = "searchrentals"
        Me.searchrentals.Size = New System.Drawing.Size(100, 26)
        Me.searchrentals.TabIndex = 2
        Me.searchrentals.Text = "Søk"
        Me.searchrentals.UseVisualStyleBackColor = True
        '
        'txtrentalsearch
        '
        Me.txtrentalsearch.Location = New System.Drawing.Point(9, 38)
        Me.txtrentalsearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtrentalsearch.Name = "txtrentalsearch"
        Me.txtrentalsearch.Size = New System.Drawing.Size(163, 22)
        Me.txtrentalsearch.TabIndex = 1
        '
        'lbrentals
        '
        Me.lbrentals.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lbrentals.FormattingEnabled = True
        Me.lbrentals.ItemHeight = 16
        Me.lbrentals.Location = New System.Drawing.Point(9, 68)
        Me.lbrentals.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbrentals.Name = "lbrentals"
        Me.lbrentals.Size = New System.Drawing.Size(821, 420)
        Me.lbrentals.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SlettToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(109, 28)
        '
        'SlettToolStripMenuItem
        '
        Me.SlettToolStripMenuItem.Name = "SlettToolStripMenuItem"
        Me.SlettToolStripMenuItem.Size = New System.Drawing.Size(108, 24)
        Me.SlettToolStripMenuItem.Text = "Slett"
        '
        'rentalView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 554)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "rentalView"
        Me.Text = "rental"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Kunde.ResumeLayout(False)
        Me.Kunde.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents filingdate As DateTimePicker
    Friend WithEvents extraditiondate As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents pickequipment As ComboBox
    Friend WithEvents pickbike As ComboBox
    Friend WithEvents Kunde As GroupBox
    Friend WithEvents mailtxt As TextBox
    Friend WithEvents surnametxt As TextBox
    Friend WithEvents firstnametxt As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents filing As ComboBox
    Friend WithEvents extradition As ComboBox
    Friend WithEvents rentalcomplete As Button
    Friend WithEvents searchrentals As Button
    Friend WithEvents txtrentalsearch As TextBox
    Friend WithEvents lbrentals As ListBox
    Friend WithEvents Label13 As Label
    Friend WithEvents commenttxt As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents SlettToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents presentcustomerid As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLeggTil As Button
    Friend WithEvents lbOversikt As ListBox
End Class
