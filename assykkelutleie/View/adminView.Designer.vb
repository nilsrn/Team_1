<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminView))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnUserClear = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnUserSave = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbUserLocation = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbAccountType = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbUserPhoneNumber = New System.Windows.Forms.TextBox()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.tbSurname = New System.Windows.Forms.TextBox()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.tbFirstName = New System.Windows.Forms.TextBox()
        Me.tbUsername = New System.Windows.Forms.TextBox()
        Me.lbUsers = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SlettToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnUserSearch = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnLocationClear = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnSaveLocation = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbLocationTelephoneNumber = New System.Windows.Forms.TextBox()
        Me.tbLocationAddress = New System.Windows.Forms.TextBox()
        Me.tbLocationName = New System.Windows.Forms.TextBox()
        Me.lbLocations = New System.Windows.Forms.ListBox()
        Me.btnLocationSearch = New System.Windows.Forms.Button()
        Me.tbLocationSearch = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.btnBicycleTypeClear = New System.Windows.Forms.Button()
        Me.tbBicycleTypeRateHour = New System.Windows.Forms.TextBox()
        Me.tbBicycleTypeRateDay = New System.Windows.Forms.TextBox()
        Me.tbBicycleTypeFrameSize = New System.Windows.Forms.TextBox()
        Me.tbBicycleTypeWheelSize = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnBicycleTypeSave = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tbBicycleTypeGearSystem = New System.Windows.Forms.TextBox()
        Me.tbBicycleTypeDescription = New System.Windows.Forms.TextBox()
        Me.tbBicycleTypeName = New System.Windows.Forms.TextBox()
        Me.lbBicycleType = New System.Windows.Forms.ListBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(18, 18)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(926, 655)
        Me.TabControl1.TabIndex = 19
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.btnUserClear)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.btnUserSave)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.cbUserLocation)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.cbAccountType)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.tbUserPhoneNumber)
        Me.TabPage1.Controls.Add(Me.tbEmail)
        Me.TabPage1.Controls.Add(Me.tbSurname)
        Me.TabPage1.Controls.Add(Me.tbPassword)
        Me.TabPage1.Controls.Add(Me.tbFirstName)
        Me.TabPage1.Controls.Add(Me.tbUsername)
        Me.TabPage1.Controls.Add(Me.lbUsers)
        Me.TabPage1.Controls.Add(Me.btnUserSearch)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Size = New System.Drawing.Size(918, 622)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Brukere"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(507, 523)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 20)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Velg et unikt brukernavn for å opprette ny bruker."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(588, 491)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(273, 20)
        Me.Label15.TabIndex = 54
        Me.Label15.Text = "Felter merket med (*) er obligatoriske."
        '
        'btnUserClear
        '
        Me.btnUserClear.Location = New System.Drawing.Point(775, 433)
        Me.btnUserClear.Name = "btnUserClear"
        Me.btnUserClear.Size = New System.Drawing.Size(85, 35)
        Me.btnUserClear.TabIndex = 53
        Me.btnUserClear.Text = "Tøm"
        Me.btnUserClear.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(26, 411)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(290, 20)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "Høyreklikk for å slette valgt brukerkonto."
        '
        'btnUserSave
        '
        Me.btnUserSave.Location = New System.Drawing.Point(573, 433)
        Me.btnUserSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUserSave.Name = "btnUserSave"
        Me.btnUserSave.Size = New System.Drawing.Size(187, 35)
        Me.btnUserSave.TabIndex = 20
        Me.btnUserSave.Text = "Lagre / Oppdater"
        Me.btnUserSave.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(441, 297)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 20)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Telefonnummer:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(441, 102)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 20)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Brukernavn(*):"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(441, 383)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Lokasjon(*):"
        '
        'cbUserLocation
        '
        Me.cbUserLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUserLocation.FormattingEnabled = True
        Me.cbUserLocation.Location = New System.Drawing.Point(573, 378)
        Me.cbUserLocation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbUserLocation.Name = "cbUserLocation"
        Me.cbUserLocation.Size = New System.Drawing.Size(288, 28)
        Me.cbUserLocation.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(441, 262)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "E-postadresse"
        '
        'cbAccountType
        '
        Me.cbAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAccountType.FormattingEnabled = True
        Me.cbAccountType.Location = New System.Drawing.Point(574, 337)
        Me.cbAccountType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbAccountType.Name = "cbAccountType"
        Me.cbAccountType.Size = New System.Drawing.Size(286, 28)
        Me.cbAccountType.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(441, 337)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Kontotype(*):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(441, 217)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Passord(*):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(441, 177)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Etternavn:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(441, 142)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Fornavn:"
        '
        'tbUserPhoneNumber
        '
        Me.tbUserPhoneNumber.Location = New System.Drawing.Point(574, 297)
        Me.tbUserPhoneNumber.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbUserPhoneNumber.Name = "tbUserPhoneNumber"
        Me.tbUserPhoneNumber.Size = New System.Drawing.Size(286, 26)
        Me.tbUserPhoneNumber.TabIndex = 9
        '
        'tbEmail
        '
        Me.tbEmail.Location = New System.Drawing.Point(574, 251)
        Me.tbEmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(286, 26)
        Me.tbEmail.TabIndex = 8
        '
        'tbSurname
        '
        Me.tbSurname.Location = New System.Drawing.Point(574, 177)
        Me.tbSurname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbSurname.Name = "tbSurname"
        Me.tbSurname.Size = New System.Drawing.Size(286, 26)
        Me.tbSurname.TabIndex = 7
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(574, 212)
        Me.tbPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(286, 26)
        Me.tbPassword.TabIndex = 6
        '
        'tbFirstName
        '
        Me.tbFirstName.Location = New System.Drawing.Point(574, 142)
        Me.tbFirstName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbFirstName.Name = "tbFirstName"
        Me.tbFirstName.Size = New System.Drawing.Size(286, 26)
        Me.tbFirstName.TabIndex = 5
        '
        'tbUsername
        '
        Me.tbUsername.Location = New System.Drawing.Point(574, 97)
        Me.tbUsername.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.Size = New System.Drawing.Size(186, 26)
        Me.tbUsername.TabIndex = 4
        '
        'lbUsers
        '
        Me.lbUsers.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lbUsers.FormattingEnabled = True
        Me.lbUsers.ItemHeight = 20
        Me.lbUsers.Location = New System.Drawing.Point(30, 102)
        Me.lbUsers.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lbUsers.Name = "lbUsers"
        Me.lbUsers.Size = New System.Drawing.Size(286, 304)
        Me.lbUsers.TabIndex = 3
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SlettToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(120, 34)
        '
        'SlettToolStripMenuItem
        '
        Me.SlettToolStripMenuItem.Name = "SlettToolStripMenuItem"
        Me.SlettToolStripMenuItem.Size = New System.Drawing.Size(119, 30)
        Me.SlettToolStripMenuItem.Text = "Slett"
        '
        'btnUserSearch
        '
        Me.btnUserSearch.Location = New System.Drawing.Point(768, 95)
        Me.btnUserSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUserSearch.Name = "btnUserSearch"
        Me.btnUserSearch.Size = New System.Drawing.Size(92, 37)
        Me.btnUserSearch.TabIndex = 2
        Me.btnUserSearch.Text = "Søk"
        Me.btnUserSearch.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnLocationClear)
        Me.TabPage2.Controls.Add(Me.Label26)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.btnSaveLocation)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.tbLocationTelephoneNumber)
        Me.TabPage2.Controls.Add(Me.tbLocationAddress)
        Me.TabPage2.Controls.Add(Me.tbLocationName)
        Me.TabPage2.Controls.Add(Me.lbLocations)
        Me.TabPage2.Controls.Add(Me.btnLocationSearch)
        Me.TabPage2.Controls.Add(Me.tbLocationSearch)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(918, 622)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Lokasjoner"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnLocationClear
        '
        Me.btnLocationClear.Location = New System.Drawing.Point(816, 218)
        Me.btnLocationClear.Name = "btnLocationClear"
        Me.btnLocationClear.Size = New System.Drawing.Size(66, 35)
        Me.btnLocationClear.TabIndex = 76
        Me.btnLocationClear.Text = "Tøm"
        Me.btnLocationClear.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(16, 460)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(263, 20)
        Me.Label26.TabIndex = 75
        Me.Label26.Text = "Høyreklikk for å slette valgt lokasjon."
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(609, 290)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(273, 20)
        Me.Label16.TabIndex = 55
        Me.Label16.Text = "Felter merket med (*) er obligatoriske."
        '
        'btnSaveLocation
        '
        Me.btnSaveLocation.Location = New System.Drawing.Point(648, 218)
        Me.btnSaveLocation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSaveLocation.Name = "btnSaveLocation"
        Me.btnSaveLocation.Size = New System.Drawing.Size(150, 35)
        Me.btnSaveLocation.TabIndex = 25
        Me.btnSaveLocation.Text = "Lagre / Oppdater"
        Me.btnSaveLocation.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(514, 106)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 20)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Lokasjon(*):"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(514, 182)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 20)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Telefon:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(514, 146)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 20)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Adresse:"
        '
        'tbLocationTelephoneNumber
        '
        Me.tbLocationTelephoneNumber.Location = New System.Drawing.Point(648, 182)
        Me.tbLocationTelephoneNumber.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbLocationTelephoneNumber.Name = "tbLocationTelephoneNumber"
        Me.tbLocationTelephoneNumber.Size = New System.Drawing.Size(234, 26)
        Me.tbLocationTelephoneNumber.TabIndex = 21
        '
        'tbLocationAddress
        '
        Me.tbLocationAddress.Location = New System.Drawing.Point(648, 146)
        Me.tbLocationAddress.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbLocationAddress.Name = "tbLocationAddress"
        Me.tbLocationAddress.Size = New System.Drawing.Size(234, 26)
        Me.tbLocationAddress.TabIndex = 20
        '
        'tbLocationName
        '
        Me.tbLocationName.Location = New System.Drawing.Point(648, 102)
        Me.tbLocationName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbLocationName.Name = "tbLocationName"
        Me.tbLocationName.Size = New System.Drawing.Size(234, 26)
        Me.tbLocationName.TabIndex = 19
        '
        'lbLocations
        '
        Me.lbLocations.FormattingEnabled = True
        Me.lbLocations.ItemHeight = 20
        Me.lbLocations.Location = New System.Drawing.Point(20, 102)
        Me.lbLocations.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lbLocations.Name = "lbLocations"
        Me.lbLocations.Size = New System.Drawing.Size(385, 344)
        Me.lbLocations.TabIndex = 7
        '
        'btnLocationSearch
        '
        Me.btnLocationSearch.Location = New System.Drawing.Point(294, 55)
        Me.btnLocationSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLocationSearch.Name = "btnLocationSearch"
        Me.btnLocationSearch.Size = New System.Drawing.Size(124, 32)
        Me.btnLocationSearch.TabIndex = 6
        Me.btnLocationSearch.Text = "Søk"
        Me.btnLocationSearch.UseVisualStyleBackColor = True
        '
        'tbLocationSearch
        '
        Me.tbLocationSearch.Location = New System.Drawing.Point(135, 57)
        Me.tbLocationSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbLocationSearch.Name = "tbLocationSearch"
        Me.tbLocationSearch.Size = New System.Drawing.Size(148, 26)
        Me.tbLocationSearch.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 62)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 20)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Lokasjon:"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label25)
        Me.TabPage3.Controls.Add(Me.btnBicycleTypeClear)
        Me.TabPage3.Controls.Add(Me.tbBicycleTypeRateHour)
        Me.TabPage3.Controls.Add(Me.tbBicycleTypeRateDay)
        Me.TabPage3.Controls.Add(Me.tbBicycleTypeFrameSize)
        Me.TabPage3.Controls.Add(Me.tbBicycleTypeWheelSize)
        Me.TabPage3.Controls.Add(Me.Label24)
        Me.TabPage3.Controls.Add(Me.Label23)
        Me.TabPage3.Controls.Add(Me.Label22)
        Me.TabPage3.Controls.Add(Me.Label21)
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Controls.Add(Me.btnBicycleTypeSave)
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Controls.Add(Me.Label19)
        Me.TabPage3.Controls.Add(Me.Label20)
        Me.TabPage3.Controls.Add(Me.tbBicycleTypeGearSystem)
        Me.TabPage3.Controls.Add(Me.tbBicycleTypeDescription)
        Me.TabPage3.Controls.Add(Me.tbBicycleTypeName)
        Me.TabPage3.Controls.Add(Me.lbBicycleType)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(918, 622)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Sykkeltyper"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(24, 493)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(274, 20)
        Me.Label25.TabIndex = 74
        Me.Label25.Text = "Høyreklikk for å slette valgt sykkeltype"
        '
        'btnBicycleTypeClear
        '
        Me.btnBicycleTypeClear.Location = New System.Drawing.Point(785, 493)
        Me.btnBicycleTypeClear.Name = "btnBicycleTypeClear"
        Me.btnBicycleTypeClear.Size = New System.Drawing.Size(66, 35)
        Me.btnBicycleTypeClear.TabIndex = 73
        Me.btnBicycleTypeClear.Text = "Tøm"
        Me.btnBicycleTypeClear.UseVisualStyleBackColor = True
        '
        'tbBicycleTypeRateHour
        '
        Me.tbBicycleTypeRateHour.Location = New System.Drawing.Point(617, 451)
        Me.tbBicycleTypeRateHour.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbBicycleTypeRateHour.Name = "tbBicycleTypeRateHour"
        Me.tbBicycleTypeRateHour.Size = New System.Drawing.Size(234, 26)
        Me.tbBicycleTypeRateHour.TabIndex = 72
        '
        'tbBicycleTypeRateDay
        '
        Me.tbBicycleTypeRateDay.Location = New System.Drawing.Point(617, 412)
        Me.tbBicycleTypeRateDay.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbBicycleTypeRateDay.Name = "tbBicycleTypeRateDay"
        Me.tbBicycleTypeRateDay.Size = New System.Drawing.Size(234, 26)
        Me.tbBicycleTypeRateDay.TabIndex = 71
        '
        'tbBicycleTypeFrameSize
        '
        Me.tbBicycleTypeFrameSize.Location = New System.Drawing.Point(617, 371)
        Me.tbBicycleTypeFrameSize.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbBicycleTypeFrameSize.Name = "tbBicycleTypeFrameSize"
        Me.tbBicycleTypeFrameSize.Size = New System.Drawing.Size(234, 26)
        Me.tbBicycleTypeFrameSize.TabIndex = 70
        '
        'tbBicycleTypeWheelSize
        '
        Me.tbBicycleTypeWheelSize.Location = New System.Drawing.Point(617, 327)
        Me.tbBicycleTypeWheelSize.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbBicycleTypeWheelSize.Name = "tbBicycleTypeWheelSize"
        Me.tbBicycleTypeWheelSize.Size = New System.Drawing.Size(234, 26)
        Me.tbBicycleTypeWheelSize.TabIndex = 69
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(483, 457)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 20)
        Me.Label24.TabIndex = 68
        Me.Label24.Text = "Timespris:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(483, 412)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(76, 20)
        Me.Label23.TabIndex = 67
        Me.Label23.Text = "Dagspris:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(483, 371)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(130, 20)
        Me.Label22.TabIndex = 66
        Me.Label22.Text = "Rammestørrelse:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(483, 327)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(101, 20)
        Me.Label21.TabIndex = 65
        Me.Label21.Text = "Hjulstørrelse:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(578, 543)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(273, 20)
        Me.Label17.TabIndex = 64
        Me.Label17.Text = "Felter merket med (*) er obligatoriske."
        '
        'btnBicycleTypeSave
        '
        Me.btnBicycleTypeSave.Location = New System.Drawing.Point(617, 493)
        Me.btnBicycleTypeSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBicycleTypeSave.Name = "btnBicycleTypeSave"
        Me.btnBicycleTypeSave.Size = New System.Drawing.Size(150, 35)
        Me.btnBicycleTypeSave.TabIndex = 63
        Me.btnBicycleTypeSave.Text = "Lagre / Oppdater"
        Me.btnBicycleTypeSave.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(483, 143)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(65, 20)
        Me.Label18.TabIndex = 62
        Me.Label18.Text = "Navn(*):"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(483, 284)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(84, 20)
        Me.Label19.TabIndex = 61
        Me.Label19.Text = "Girsystem:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(483, 183)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(93, 20)
        Me.Label20.TabIndex = 60
        Me.Label20.Text = "Beskrivelse:"
        '
        'tbBicycleTypeGearSystem
        '
        Me.tbBicycleTypeGearSystem.Location = New System.Drawing.Point(617, 284)
        Me.tbBicycleTypeGearSystem.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbBicycleTypeGearSystem.Name = "tbBicycleTypeGearSystem"
        Me.tbBicycleTypeGearSystem.Size = New System.Drawing.Size(234, 26)
        Me.tbBicycleTypeGearSystem.TabIndex = 59
        '
        'tbBicycleTypeDescription
        '
        Me.tbBicycleTypeDescription.Location = New System.Drawing.Point(617, 183)
        Me.tbBicycleTypeDescription.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbBicycleTypeDescription.MaxLength = 254
        Me.tbBicycleTypeDescription.Multiline = True
        Me.tbBicycleTypeDescription.Name = "tbBicycleTypeDescription"
        Me.tbBicycleTypeDescription.Size = New System.Drawing.Size(234, 91)
        Me.tbBicycleTypeDescription.TabIndex = 58
        '
        'tbBicycleTypeName
        '
        Me.tbBicycleTypeName.Location = New System.Drawing.Point(617, 139)
        Me.tbBicycleTypeName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbBicycleTypeName.Name = "tbBicycleTypeName"
        Me.tbBicycleTypeName.Size = New System.Drawing.Size(234, 26)
        Me.tbBicycleTypeName.TabIndex = 57
        '
        'lbBicycleType
        '
        Me.lbBicycleType.FormattingEnabled = True
        Me.lbBicycleType.ItemHeight = 20
        Me.lbBicycleType.Location = New System.Drawing.Point(28, 139)
        Me.lbBicycleType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lbBicycleType.Name = "lbBicycleType"
        Me.lbBicycleType.Size = New System.Drawing.Size(276, 344)
        Me.lbBicycleType.TabIndex = 56
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 29)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(918, 622)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Utstyrstyper"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'adminView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 692)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "adminView"
        Me.Text = "admin"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents lbUsers As ListBox
    Friend WithEvents btnUserSearch As Button
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents btnUserSave As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbUserLocation As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbAccountType As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbUserPhoneNumber As TextBox
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents tbSurname As TextBox
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents tbFirstName As TextBox
    Friend WithEvents tbUsername As TextBox
    Friend WithEvents lbLocations As ListBox
    Friend WithEvents btnLocationSearch As Button
    Friend WithEvents tbLocationSearch As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSaveLocation As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents tbLocationTelephoneNumber As TextBox
    Friend WithEvents tbLocationAddress As TextBox
    Friend WithEvents tbLocationName As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents SlettToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label14 As Label
    Friend WithEvents btnUserClear As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents btnBicycleTypeSave As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents tbBicycleTypeGearSystem As TextBox
    Friend WithEvents tbBicycleTypeDescription As TextBox
    Friend WithEvents tbBicycleTypeName As TextBox
    Friend WithEvents lbBicycleType As ListBox
    Friend WithEvents tbBicycleTypeRateHour As TextBox
    Friend WithEvents tbBicycleTypeRateDay As TextBox
    Friend WithEvents tbBicycleTypeFrameSize As TextBox
    Friend WithEvents tbBicycleTypeWheelSize As TextBox
    Friend WithEvents btnBicycleTypeClear As Button
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents btnLocationClear As Button
End Class
