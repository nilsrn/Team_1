<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rentalView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rentalView))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.rentalcomplete = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.filing = New System.Windows.Forms.ComboBox()
        Me.extradition = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.filingdate = New System.Windows.Forms.DateTimePicker()
        Me.extraditiondate = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pickequipment = New System.Windows.Forms.ComboBox()
        Me.pickbike = New System.Windows.Forms.ComboBox()
        Me.Kunde = New System.Windows.Forms.GroupBox()
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
        Me.filingdate2 = New System.Windows.Forms.DateTimePicker()
        Me.extraditiondate2 = New System.Windows.Forms.DateTimePicker()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.filing2 = New System.Windows.Forms.ComboBox()
        Me.extradition2 = New System.Windows.Forms.ComboBox()
        Me.pickequipment2 = New System.Windows.Forms.ComboBox()
        Me.pickbike2 = New System.Windows.Forms.ComboBox()
        Me.searchrentals = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lbrentals = New System.Windows.Forms.ListBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.customerid = New System.Windows.Forms.Label()
        Me.presentcustomerid = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Kunde.SuspendLayout()
        Me.TabPage2.SuspendLayout()
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
        'filing
        '
        Me.filing.FormattingEnabled = True
        Me.filing.Items.AddRange(New Object() {"Haugastøl", "Finse", "Flåm", "Myrdal", "Voss"})
        Me.filing.Location = New System.Drawing.Point(132, 130)
        Me.filing.Margin = New System.Windows.Forms.Padding(4)
        Me.filing.Name = "filing"
        Me.filing.Size = New System.Drawing.Size(113, 24)
        Me.filing.TabIndex = 10
        '
        'extradition
        '
        Me.extradition.FormattingEnabled = True
        Me.extradition.Items.AddRange(New Object() {"Haugastøl", "Finse", "Flåm", "Myrdal", "Voss"})
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
        Me.pickequipment.Items.AddRange(New Object() {"Sykkelveske", "Barnehenger", "Lastehenger"})
        Me.pickequipment.Location = New System.Drawing.Point(141, 46)
        Me.pickequipment.Margin = New System.Windows.Forms.Padding(4)
        Me.pickequipment.Name = "pickequipment"
        Me.pickequipment.Size = New System.Drawing.Size(113, 24)
        Me.pickequipment.TabIndex = 1
        '
        'pickbike
        '
        Me.pickbike.FormattingEnabled = True
        Me.pickbike.Items.AddRange(New Object() {"Terreng", "Tandem", "Racer", "Downhill", "Barnesykkel", ""})
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
        Me.TabPage2.Controls.Add(Me.filingdate2)
        Me.TabPage2.Controls.Add(Me.extraditiondate2)
        Me.TabPage2.Controls.Add(Me.btnSave)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.filing2)
        Me.TabPage2.Controls.Add(Me.extradition2)
        Me.TabPage2.Controls.Add(Me.pickequipment2)
        Me.TabPage2.Controls.Add(Me.pickbike2)
        Me.TabPage2.Controls.Add(Me.searchrentals)
        Me.TabPage2.Controls.Add(Me.TextBox2)
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
        'filingdate2
        '
        Me.filingdate2.Location = New System.Drawing.Point(634, 229)
        Me.filingdate2.Name = "filingdate2"
        Me.filingdate2.Size = New System.Drawing.Size(121, 22)
        Me.filingdate2.TabIndex = 13
        '
        'extraditiondate2
        '
        Me.extraditiondate2.Location = New System.Drawing.Point(473, 229)
        Me.extraditiondate2.Name = "extraditiondate2"
        Me.extraditiondate2.Size = New System.Drawing.Size(121, 22)
        Me.extraditiondate2.TabIndex = 12
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(476, 280)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(269, 32)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Lagre"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(631, 159)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 17)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Innlevering:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(473, 159)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 17)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Utlevering:"
        '
        'filing2
        '
        Me.filing2.FormattingEnabled = True
        Me.filing2.Location = New System.Drawing.Point(634, 182)
        Me.filing2.Name = "filing2"
        Me.filing2.Size = New System.Drawing.Size(121, 24)
        Me.filing2.TabIndex = 6
        Me.filing2.Text = "Sted"
        '
        'extradition2
        '
        Me.extradition2.FormattingEnabled = True
        Me.extradition2.Location = New System.Drawing.Point(473, 182)
        Me.extradition2.Name = "extradition2"
        Me.extradition2.Size = New System.Drawing.Size(121, 24)
        Me.extradition2.TabIndex = 5
        Me.extradition2.Text = "Sted"
        '
        'pickequipment2
        '
        Me.pickequipment2.FormattingEnabled = True
        Me.pickequipment2.Location = New System.Drawing.Point(634, 68)
        Me.pickequipment2.Name = "pickequipment2"
        Me.pickequipment2.Size = New System.Drawing.Size(121, 24)
        Me.pickequipment2.TabIndex = 4
        Me.pickequipment2.Text = "Utstyr"
        '
        'pickbike2
        '
        Me.pickbike2.FormattingEnabled = True
        Me.pickbike2.Location = New System.Drawing.Point(473, 68)
        Me.pickbike2.Name = "pickbike2"
        Me.pickbike2.Size = New System.Drawing.Size(121, 24)
        Me.pickbike2.TabIndex = 3
        Me.pickbike2.Text = "Sykkel"
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
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(145, 35)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(163, 22)
        Me.TextBox2.TabIndex = 1
        '
        'lbrentals
        '
        Me.lbrentals.FormattingEnabled = True
        Me.lbrentals.ItemHeight = 16
        Me.lbrentals.Location = New System.Drawing.Point(9, 68)
        Me.lbrentals.Margin = New System.Windows.Forms.Padding(4)
        Me.lbrentals.Name = "lbrentals"
        Me.lbrentals.Size = New System.Drawing.Size(429, 420)
        Me.lbrentals.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(815, 495)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Statistikk"
        Me.TabPage3.UseVisualStyleBackColor = True
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
        'presentcustomerid
        '
        Me.presentcustomerid.AutoSize = True
        Me.presentcustomerid.Location = New System.Drawing.Point(108, 270)
        Me.presentcustomerid.Name = "presentcustomerid"
        Me.presentcustomerid.Size = New System.Drawing.Size(0, 17)
        Me.presentcustomerid.TabIndex = 10
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
    Friend WithEvents filing As ComboBox
    Friend WithEvents extradition As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents rentalcomplete As Button
    Friend WithEvents searchrentals As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lbrentals As ListBox
    Friend WithEvents filing2 As ComboBox
    Friend WithEvents extradition2 As ComboBox
    Friend WithEvents pickequipment2 As ComboBox
    Friend WithEvents pickbike2 As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents filingdate2 As DateTimePicker
    Friend WithEvents extraditiondate2 As DateTimePicker
    Friend WithEvents presentcustomerid As Label
    Friend WithEvents customerid As Label
End Class
