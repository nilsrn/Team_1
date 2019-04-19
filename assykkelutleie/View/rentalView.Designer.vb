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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rentalView))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.rentalcomplete = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.extradition = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.filingdate = New System.Windows.Forms.DateTimePicker()
        Me.extraditiondate = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.commenttxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pickequipment = New System.Windows.Forms.ComboBox()
        Me.pickbike = New System.Windows.Forms.ComboBox()
        Me.Kunde = New System.Windows.Forms.GroupBox()
        Me.presentcustomerid = New System.Windows.Forms.Label()
        Me.customerid = New System.Windows.Forms.Label()
        Me.mailtxt = New System.Windows.Forms.TextBox()
        Me.surnametxt = New System.Windows.Forms.TextBox()
        Me.firstnametxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.searchrentals = New System.Windows.Forms.Button()
        Me.txtrentalsearch = New System.Windows.Forms.TextBox()
        Me.lbrentals = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SlettToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.filing = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.changecommenttxt = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.changedatefiling = New System.Windows.Forms.DateTimePicker()
        Me.changedateex = New System.Windows.Forms.DateTimePicker()
        Me.savechanges = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.changefiling = New System.Windows.Forms.ComboBox()
        Me.changeextradition = New System.Windows.Forms.ComboBox()
        Me.changeequipment = New System.Windows.Forms.ComboBox()
        Me.changebike = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CustomerIDlbl = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.RentalIDlbl = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.usernamelbl = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.pricelbl = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.utleietypelbl = New System.Windows.Forms.Label()
        Me.typanatalllbltxt = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Kunde.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(16, 15)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(823, 524)
        Me.TabControl1.TabIndex = 12
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.rentalcomplete)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.Kunde)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(815, 495)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ny bestilling"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'rentalcomplete
        '
        Me.rentalcomplete.Location = New System.Drawing.Point(197, 417)
        Me.rentalcomplete.Margin = New System.Windows.Forms.Padding(4)
        Me.rentalcomplete.Name = "rentalcomplete"
        Me.rentalcomplete.Size = New System.Drawing.Size(427, 68)
        Me.rentalcomplete.TabIndex = 3
        Me.rentalcomplete.Text = "Fullfør bestilling"
        Me.rentalcomplete.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.filing)
        Me.GroupBox3.Controls.Add(Me.extradition)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.filingdate)
        Me.GroupBox3.Controls.Add(Me.extraditiondate)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(544, 18)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(260, 390)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Utlevering og innlevering"
        '
        'extradition
        '
        Me.extradition.FormattingEnabled = True
        Me.extradition.Location = New System.Drawing.Point(12, 130)
        Me.extradition.Margin = New System.Windows.Forms.Padding(4)
        Me.extradition.Name = "extradition"
        Me.extradition.Size = New System.Drawing.Size(113, 24)
        Me.extradition.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(128, 107)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 17)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Velg sted:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 107)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 17)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Velg sted:"
        '
        'filingdate
        '
        Me.filingdate.Location = New System.Drawing.Point(132, 46)
        Me.filingdate.Margin = New System.Windows.Forms.Padding(4)
        Me.filingdate.Name = "filingdate"
        Me.filingdate.Size = New System.Drawing.Size(116, 22)
        Me.filingdate.TabIndex = 6
        '
        'extraditiondate
        '
        Me.extraditiondate.Location = New System.Drawing.Point(12, 46)
        Me.extraditiondate.Margin = New System.Windows.Forms.Padding(4)
        Me.extraditiondate.Name = "extraditiondate"
        Me.extraditiondate.Size = New System.Drawing.Size(111, 22)
        Me.extraditiondate.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(128, 25)
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
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.commenttxt)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.pickequipment)
        Me.GroupBox2.Controls.Add(Me.pickbike)
        Me.GroupBox2.Location = New System.Drawing.Point(272, 18)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(264, 390)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sykkel og utstyr"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 106)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 17)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Kommentar:"
        '
        'commenttxt
        '
        Me.commenttxt.Location = New System.Drawing.Point(9, 133)
        Me.commenttxt.Multiline = True
        Me.commenttxt.Name = "commenttxt"
        Me.commenttxt.Size = New System.Drawing.Size(245, 154)
        Me.commenttxt.TabIndex = 4
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
        Me.pickequipment.Margin = New System.Windows.Forms.Padding(4)
        Me.pickequipment.Name = "pickequipment"
        Me.pickequipment.Size = New System.Drawing.Size(113, 24)
        Me.pickequipment.TabIndex = 1
        '
        'pickbike
        '
        Me.pickbike.FormattingEnabled = True
        Me.pickbike.Location = New System.Drawing.Point(9, 46)
        Me.pickbike.Margin = New System.Windows.Forms.Padding(4)
        Me.pickbike.Name = "pickbike"
        Me.pickbike.Size = New System.Drawing.Size(113, 24)
        Me.pickbike.TabIndex = 0
        '
        'Kunde
        '
        Me.Kunde.Controls.Add(Me.presentcustomerid)
        Me.Kunde.Controls.Add(Me.customerid)
        Me.Kunde.Controls.Add(Me.mailtxt)
        Me.Kunde.Controls.Add(Me.surnametxt)
        Me.Kunde.Controls.Add(Me.firstnametxt)
        Me.Kunde.Controls.Add(Me.Label4)
        Me.Kunde.Controls.Add(Me.Label3)
        Me.Kunde.Controls.Add(Me.Label2)
        Me.Kunde.Controls.Add(Me.btnSearch)
        Me.Kunde.Controls.Add(Me.txtsearch)
        Me.Kunde.Controls.Add(Me.Label1)
        Me.Kunde.Location = New System.Drawing.Point(8, 18)
        Me.Kunde.Margin = New System.Windows.Forms.Padding(4)
        Me.Kunde.Name = "Kunde"
        Me.Kunde.Padding = New System.Windows.Forms.Padding(4)
        Me.Kunde.Size = New System.Drawing.Size(261, 390)
        Me.Kunde.TabIndex = 0
        Me.Kunde.TabStop = False
        Me.Kunde.Text = "Kunde"
        '
        'presentcustomerid
        '
        Me.presentcustomerid.AutoSize = True
        Me.presentcustomerid.Location = New System.Drawing.Point(108, 270)
        Me.presentcustomerid.Name = "presentcustomerid"
        Me.presentcustomerid.Size = New System.Drawing.Size(0, 17)
        Me.presentcustomerid.TabIndex = 10
        '
        'customerid
        '
        Me.customerid.AutoSize = True
        Me.customerid.Location = New System.Drawing.Point(12, 270)
        Me.customerid.Name = "customerid"
        Me.customerid.Size = New System.Drawing.Size(71, 17)
        Me.customerid.TabIndex = 9
        Me.customerid.Text = "Kunde-ID:"
        '
        'mailtxt
        '
        Me.mailtxt.Location = New System.Drawing.Point(111, 228)
        Me.mailtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.mailtxt.Name = "mailtxt"
        Me.mailtxt.Size = New System.Drawing.Size(132, 22)
        Me.mailtxt.TabIndex = 8
        '
        'surnametxt
        '
        Me.surnametxt.Location = New System.Drawing.Point(111, 181)
        Me.surnametxt.Margin = New System.Windows.Forms.Padding(4)
        Me.surnametxt.Name = "surnametxt"
        Me.surnametxt.Size = New System.Drawing.Size(132, 22)
        Me.surnametxt.TabIndex = 7
        '
        'firstnametxt
        '
        Me.firstnametxt.Location = New System.Drawing.Point(111, 134)
        Me.firstnametxt.Margin = New System.Windows.Forms.Padding(4)
        Me.firstnametxt.Name = "firstnametxt"
        Me.firstnametxt.Size = New System.Drawing.Size(132, 22)
        Me.firstnametxt.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 228)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "E-post"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 181)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Etternavn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 134)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fornavn"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(156, 41)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 28)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Søk"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(13, 46)
        Me.txtsearch.Margin = New System.Windows.Forms.Padding(4)
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
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.searchrentals)
        Me.TabPage2.Controls.Add(Me.txtrentalsearch)
        Me.TabPage2.Controls.Add(Me.lbrentals)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(815, 495)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Bestillingsoversikt"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'searchrentals
        '
        Me.searchrentals.Location = New System.Drawing.Point(338, 32)
        Me.searchrentals.Margin = New System.Windows.Forms.Padding(4)
        Me.searchrentals.Name = "searchrentals"
        Me.searchrentals.Size = New System.Drawing.Size(100, 28)
        Me.searchrentals.TabIndex = 2
        Me.searchrentals.Text = "Søk"
        Me.searchrentals.UseVisualStyleBackColor = True
        '
        'txtrentalsearch
        '
        Me.txtrentalsearch.Location = New System.Drawing.Point(145, 35)
        Me.txtrentalsearch.Margin = New System.Windows.Forms.Padding(4)
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
        Me.lbrentals.Margin = New System.Windows.Forms.Padding(4)
        Me.lbrentals.Name = "lbrentals"
        Me.lbrentals.Size = New System.Drawing.Size(429, 420)
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
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Chart1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(815, 495)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Statistikk"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'filing
        '
        Me.filing.FormattingEnabled = True
        Me.filing.Location = New System.Drawing.Point(131, 130)
        Me.filing.Name = "filing"
        Me.filing.Size = New System.Drawing.Size(117, 24)
        Me.filing.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.typanatalllbltxt)
        Me.GroupBox1.Controls.Add(Me.utleietypelbl)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.pricelbl)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.usernamelbl)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.RentalIDlbl)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.CustomerIDlbl)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.changecommenttxt)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.changedatefiling)
        Me.GroupBox1.Controls.Add(Me.changedateex)
        Me.GroupBox1.Controls.Add(Me.savechanges)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.changefiling)
        Me.GroupBox1.Controls.Add(Me.changeextradition)
        Me.GroupBox1.Controls.Add(Me.changeequipment)
        Me.GroupBox1.Controls.Add(Me.changebike)
        Me.GroupBox1.Location = New System.Drawing.Point(446, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 481)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Endre bestilling:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(45, 293)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(84, 17)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "Kommentar:"
        '
        'changecommenttxt
        '
        Me.changecommenttxt.Location = New System.Drawing.Point(48, 322)
        Me.changecommenttxt.Multiline = True
        Me.changecommenttxt.Name = "changecommenttxt"
        Me.changecommenttxt.Size = New System.Drawing.Size(269, 115)
        Me.changecommenttxt.TabIndex = 29
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(206, 164)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(79, 17)
        Me.Label18.TabIndex = 28
        Me.Label18.Text = "Velg utstyr:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(49, 164)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(83, 17)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "Velg sykkel:"
        '
        'changedatefiling
        '
        Me.changedatefiling.Location = New System.Drawing.Point(207, 270)
        Me.changedatefiling.Name = "changedatefiling"
        Me.changedatefiling.Size = New System.Drawing.Size(121, 22)
        Me.changedatefiling.TabIndex = 26
        '
        'changedateex
        '
        Me.changedateex.Location = New System.Drawing.Point(48, 270)
        Me.changedateex.Name = "changedateex"
        Me.changedateex.Size = New System.Drawing.Size(121, 22)
        Me.changedateex.TabIndex = 25
        '
        'savechanges
        '
        Me.savechanges.Location = New System.Drawing.Point(47, 443)
        Me.savechanges.Name = "savechanges"
        Me.savechanges.Size = New System.Drawing.Size(269, 32)
        Me.savechanges.TabIndex = 24
        Me.savechanges.Text = "Lagre endringer"
        Me.savechanges.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(204, 220)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(81, 17)
        Me.Label20.TabIndex = 23
        Me.Label20.Text = "Innlevering:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(49, 220)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(76, 17)
        Me.Label21.TabIndex = 22
        Me.Label21.Text = "Utlevering:"
        '
        'changefiling
        '
        Me.changefiling.FormattingEnabled = True
        Me.changefiling.Location = New System.Drawing.Point(207, 240)
        Me.changefiling.Name = "changefiling"
        Me.changefiling.Size = New System.Drawing.Size(121, 24)
        Me.changefiling.TabIndex = 21
        '
        'changeextradition
        '
        Me.changeextradition.FormattingEnabled = True
        Me.changeextradition.Location = New System.Drawing.Point(48, 240)
        Me.changeextradition.Name = "changeextradition"
        Me.changeextradition.Size = New System.Drawing.Size(121, 24)
        Me.changeextradition.TabIndex = 20
        '
        'changeequipment
        '
        Me.changeequipment.FormattingEnabled = True
        Me.changeequipment.Location = New System.Drawing.Point(209, 184)
        Me.changeequipment.Name = "changeequipment"
        Me.changeequipment.Size = New System.Drawing.Size(121, 24)
        Me.changeequipment.TabIndex = 19
        '
        'changebike
        '
        Me.changebike.FormattingEnabled = True
        Me.changebike.Location = New System.Drawing.Point(48, 184)
        Me.changebike.Name = "changebike"
        Me.changebike.Size = New System.Drawing.Size(121, 24)
        Me.changebike.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(44, 82)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 17)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Kunde-ID:"
        '
        'CustomerIDlbl
        '
        Me.CustomerIDlbl.AutoSize = True
        Me.CustomerIDlbl.Location = New System.Drawing.Point(169, 82)
        Me.CustomerIDlbl.Name = "CustomerIDlbl"
        Me.CustomerIDlbl.Size = New System.Drawing.Size(0, 17)
        Me.CustomerIDlbl.TabIndex = 32
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(43, 112)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 17)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Bestillingsnummer:"
        '
        'RentalIDlbl
        '
        Me.RentalIDlbl.AutoSize = True
        Me.RentalIDlbl.Location = New System.Drawing.Point(172, 100)
        Me.RentalIDlbl.Name = "RentalIDlbl"
        Me.RentalIDlbl.Size = New System.Drawing.Size(0, 17)
        Me.RentalIDlbl.TabIndex = 34
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(44, 31)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 17)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Brukernavn:"
        '
        'usernamelbl
        '
        Me.usernamelbl.AutoSize = True
        Me.usernamelbl.Location = New System.Drawing.Point(150, 31)
        Me.usernamelbl.Name = "usernamelbl"
        Me.usernamelbl.Size = New System.Drawing.Size(59, 17)
        Me.usernamelbl.TabIndex = 36
        Me.usernamelbl.Text = "Label15"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(44, 138)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(36, 17)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Pris:"
        '
        'pricelbl
        '
        Me.pricelbl.AutoSize = True
        Me.pricelbl.Location = New System.Drawing.Point(159, 138)
        Me.pricelbl.Name = "pricelbl"
        Me.pricelbl.Size = New System.Drawing.Size(59, 17)
        Me.pricelbl.TabIndex = 38
        Me.pricelbl.Text = "Label16"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(46, 61)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 17)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "Utleietype::"
        '
        'utleietypelbl
        '
        Me.utleietypelbl.AutoSize = True
        Me.utleietypelbl.Location = New System.Drawing.Point(150, 65)
        Me.utleietypelbl.Name = "utleietypelbl"
        Me.utleietypelbl.Size = New System.Drawing.Size(79, 17)
        Me.utleietypelbl.TabIndex = 40
        Me.utleietypelbl.Text = "Utleietype::"
        '
        'typanatalllbltxt
        '
        Me.typanatalllbltxt.AutoSize = True
        Me.typanatalllbltxt.Location = New System.Drawing.Point(159, 302)
        Me.typanatalllbltxt.Name = "typanatalllbltxt"
        Me.typanatalllbltxt.Size = New System.Drawing.Size(79, 17)
        Me.typanatalllbltxt.TabIndex = 41
        Me.typanatalllbltxt.Text = "Utleietype::"
        '
        'Chart1
        '
        ChartArea1.Name = "Terreng"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(61, 95)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "Terreng"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(300, 300)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        Title1.Name = "Terrengsykkel"
        Me.Chart1.Titles.Add(Title1)
        '
        'rentalView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 554)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
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
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
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
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents extradition As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents rentalcomplete As Button
    Friend WithEvents searchrentals As Button
    Friend WithEvents txtrentalsearch As TextBox
    Friend WithEvents lbrentals As ListBox
    Friend WithEvents presentcustomerid As Label
    Friend WithEvents customerid As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents commenttxt As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents SlettToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents filing As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents changecommenttxt As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents changedatefiling As DateTimePicker
    Friend WithEvents changedateex As DateTimePicker
    Friend WithEvents savechanges As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents changefiling As ComboBox
    Friend WithEvents changeextradition As ComboBox
    Friend WithEvents changeequipment As ComboBox
    Friend WithEvents changebike As ComboBox
    Friend WithEvents CustomerIDlbl As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents RentalIDlbl As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents pricelbl As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents usernamelbl As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents typanatalllbltxt As Label
    Friend WithEvents utleietypelbl As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class
