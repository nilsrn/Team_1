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
        Me.TabUsers = New System.Windows.Forms.TabPage()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
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
        Me.TabLocations = New System.Windows.Forms.TabPage()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
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
        Me.TabBicycleTypes = New System.Windows.Forms.TabPage()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
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
        Me.TabEquipmentType = New System.Windows.Forms.TabPage()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.btnEquipmentTypeClear = New System.Windows.Forms.Button()
        Me.tbEquipmentTypeRateDay = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.btnEquipmentTypeSave = New System.Windows.Forms.Button()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.tbEquipmentTypeRateHour = New System.Windows.Forms.TextBox()
        Me.tbEquipmentTypeDescription = New System.Windows.Forms.TextBox()
        Me.tbEquipmentTypeName = New System.Windows.Forms.TextBox()
        Me.lbEquipmentType = New System.Windows.Forms.ListBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabUsers.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabLocations.SuspendLayout()
        Me.TabBicycleTypes.SuspendLayout()
        Me.TabEquipmentType.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabUsers)
        Me.TabControl1.Controls.Add(Me.TabLocations)
        Me.TabControl1.Controls.Add(Me.TabBicycleTypes)
        Me.TabControl1.Controls.Add(Me.TabEquipmentType)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(920, 655)
        Me.TabControl1.TabIndex = 19
        '
        'TabUsers
        '
        Me.TabUsers.Controls.Add(Me.Label31)
        Me.TabUsers.Controls.Add(Me.Label30)
        Me.TabUsers.Controls.Add(Me.Label1)
        Me.TabUsers.Controls.Add(Me.Label15)
        Me.TabUsers.Controls.Add(Me.btnUserClear)
        Me.TabUsers.Controls.Add(Me.Label14)
        Me.TabUsers.Controls.Add(Me.btnUserSave)
        Me.TabUsers.Controls.Add(Me.Label9)
        Me.TabUsers.Controls.Add(Me.Label8)
        Me.TabUsers.Controls.Add(Me.Label7)
        Me.TabUsers.Controls.Add(Me.cbUserLocation)
        Me.TabUsers.Controls.Add(Me.Label6)
        Me.TabUsers.Controls.Add(Me.cbAccountType)
        Me.TabUsers.Controls.Add(Me.Label5)
        Me.TabUsers.Controls.Add(Me.Label4)
        Me.TabUsers.Controls.Add(Me.Label3)
        Me.TabUsers.Controls.Add(Me.Label2)
        Me.TabUsers.Controls.Add(Me.tbUserPhoneNumber)
        Me.TabUsers.Controls.Add(Me.tbEmail)
        Me.TabUsers.Controls.Add(Me.tbSurname)
        Me.TabUsers.Controls.Add(Me.tbPassword)
        Me.TabUsers.Controls.Add(Me.tbFirstName)
        Me.TabUsers.Controls.Add(Me.tbUsername)
        Me.TabUsers.Controls.Add(Me.lbUsers)
        Me.TabUsers.Controls.Add(Me.btnUserSearch)
        Me.TabUsers.Location = New System.Drawing.Point(4, 29)
        Me.TabUsers.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabUsers.Name = "TabUsers"
        Me.TabUsers.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabUsers.Size = New System.Drawing.Size(918, 622)
        Me.TabUsers.TabIndex = 0
        Me.TabUsers.Text = "Brukere"
        Me.TabUsers.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(465, 21)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(212, 25)
        Me.Label31.TabIndex = 57
        Me.Label31.Text = "Brukerkonto detaljer:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(7, 24)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(292, 25)
        Me.Label30.TabIndex = 56
        Me.Label30.Text = "Liste over alle brukerkontoer:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(532, 490)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 20)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Velg et unikt brukernavn for å opprette ny bruker."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(613, 458)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(273, 20)
        Me.Label15.TabIndex = 54
        Me.Label15.Text = "Felter merket med (*) er obligatoriske."
        '
        'btnUserClear
        '
        Me.btnUserClear.Location = New System.Drawing.Point(800, 400)
        Me.btnUserClear.Name = "btnUserClear"
        Me.btnUserClear.Size = New System.Drawing.Size(85, 35)
        Me.btnUserClear.TabIndex = 11
        Me.btnUserClear.Text = "Tøm"
        Me.btnUserClear.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 474)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(290, 20)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "Høyreklikk for å slette valgt brukerkonto."
        '
        'btnUserSave
        '
        Me.btnUserSave.Location = New System.Drawing.Point(598, 400)
        Me.btnUserSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUserSave.Name = "btnUserSave"
        Me.btnUserSave.Size = New System.Drawing.Size(187, 35)
        Me.btnUserSave.TabIndex = 10
        Me.btnUserSave.Text = "Oppdater / Opprett"
        Me.btnUserSave.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(466, 264)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 20)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Telefonnummer:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(466, 69)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 20)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Brukernavn(*):"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(466, 350)
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
        Me.cbUserLocation.Location = New System.Drawing.Point(598, 345)
        Me.cbUserLocation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbUserLocation.Name = "cbUserLocation"
        Me.cbUserLocation.Size = New System.Drawing.Size(288, 28)
        Me.cbUserLocation.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(466, 229)
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
        Me.cbAccountType.Location = New System.Drawing.Point(599, 304)
        Me.cbAccountType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbAccountType.Name = "cbAccountType"
        Me.cbAccountType.Size = New System.Drawing.Size(286, 28)
        Me.cbAccountType.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(466, 304)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Kontotype(*):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(466, 184)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Passord(*):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(466, 144)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Etternavn:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(466, 109)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Fornavn:"
        '
        'tbUserPhoneNumber
        '
        Me.tbUserPhoneNumber.Location = New System.Drawing.Point(599, 264)
        Me.tbUserPhoneNumber.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbUserPhoneNumber.MaxLength = 255
        Me.tbUserPhoneNumber.Name = "tbUserPhoneNumber"
        Me.tbUserPhoneNumber.Size = New System.Drawing.Size(286, 26)
        Me.tbUserPhoneNumber.TabIndex = 7
        '
        'tbEmail
        '
        Me.tbEmail.Location = New System.Drawing.Point(599, 218)
        Me.tbEmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbEmail.MaxLength = 255
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(286, 26)
        Me.tbEmail.TabIndex = 6
        '
        'tbSurname
        '
        Me.tbSurname.Location = New System.Drawing.Point(599, 144)
        Me.tbSurname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbSurname.MaxLength = 255
        Me.tbSurname.Name = "tbSurname"
        Me.tbSurname.Size = New System.Drawing.Size(286, 26)
        Me.tbSurname.TabIndex = 4
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(599, 179)
        Me.tbPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbPassword.MaxLength = 255
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(286, 26)
        Me.tbPassword.TabIndex = 5
        '
        'tbFirstName
        '
        Me.tbFirstName.Location = New System.Drawing.Point(599, 109)
        Me.tbFirstName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbFirstName.MaxLength = 255
        Me.tbFirstName.Name = "tbFirstName"
        Me.tbFirstName.Size = New System.Drawing.Size(286, 26)
        Me.tbFirstName.TabIndex = 3
        '
        'tbUsername
        '
        Me.tbUsername.Location = New System.Drawing.Point(599, 64)
        Me.tbUsername.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbUsername.MaxLength = 50
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.Size = New System.Drawing.Size(186, 26)
        Me.tbUsername.TabIndex = 1
        '
        'lbUsers
        '
        Me.lbUsers.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lbUsers.FormattingEnabled = True
        Me.lbUsers.ItemHeight = 20
        Me.lbUsers.Location = New System.Drawing.Point(13, 65)
        Me.lbUsers.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lbUsers.Name = "lbUsers"
        Me.lbUsers.Size = New System.Drawing.Size(286, 404)
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
        Me.btnUserSearch.Location = New System.Drawing.Point(793, 62)
        Me.btnUserSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUserSearch.Name = "btnUserSearch"
        Me.btnUserSearch.Size = New System.Drawing.Size(92, 37)
        Me.btnUserSearch.TabIndex = 2
        Me.btnUserSearch.Text = "Søk"
        Me.btnUserSearch.UseVisualStyleBackColor = True
        '
        'TabLocations
        '
        Me.TabLocations.Controls.Add(Me.Label36)
        Me.TabLocations.Controls.Add(Me.Label34)
        Me.TabLocations.Controls.Add(Me.btnLocationClear)
        Me.TabLocations.Controls.Add(Me.Label26)
        Me.TabLocations.Controls.Add(Me.Label16)
        Me.TabLocations.Controls.Add(Me.btnSaveLocation)
        Me.TabLocations.Controls.Add(Me.Label11)
        Me.TabLocations.Controls.Add(Me.Label12)
        Me.TabLocations.Controls.Add(Me.Label13)
        Me.TabLocations.Controls.Add(Me.tbLocationTelephoneNumber)
        Me.TabLocations.Controls.Add(Me.tbLocationAddress)
        Me.TabLocations.Controls.Add(Me.tbLocationName)
        Me.TabLocations.Controls.Add(Me.lbLocations)
        Me.TabLocations.Controls.Add(Me.btnLocationSearch)
        Me.TabLocations.Controls.Add(Me.tbLocationSearch)
        Me.TabLocations.Controls.Add(Me.Label10)
        Me.TabLocations.Location = New System.Drawing.Point(4, 29)
        Me.TabLocations.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabLocations.Name = "TabLocations"
        Me.TabLocations.Size = New System.Drawing.Size(918, 622)
        Me.TabLocations.TabIndex = 1
        Me.TabLocations.Text = "Lokasjoner"
        Me.TabLocations.UseVisualStyleBackColor = True
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(480, 23)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(183, 25)
        Me.Label36.TabIndex = 77
        Me.Label36.Text = "Lokasjon detaljer:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(3, 23)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(258, 25)
        Me.Label34.TabIndex = 76
        Me.Label34.Text = "Liste over alle lokasjoner:"
        '
        'btnLocationClear
        '
        Me.btnLocationClear.Location = New System.Drawing.Point(812, 178)
        Me.btnLocationClear.Name = "btnLocationClear"
        Me.btnLocationClear.Size = New System.Drawing.Size(66, 35)
        Me.btnLocationClear.TabIndex = 5
        Me.btnLocationClear.Text = "Tøm"
        Me.btnLocationClear.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(20, 530)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(263, 20)
        Me.Label26.TabIndex = 75
        Me.Label26.Text = "Høyreklikk for å slette valgt lokasjon."
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(578, 232)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(273, 20)
        Me.Label16.TabIndex = 55
        Me.Label16.Text = "Felter merket med (*) er obligatoriske."
        '
        'btnSaveLocation
        '
        Me.btnSaveLocation.Location = New System.Drawing.Point(582, 178)
        Me.btnSaveLocation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSaveLocation.Name = "btnSaveLocation"
        Me.btnSaveLocation.Size = New System.Drawing.Size(212, 35)
        Me.btnSaveLocation.TabIndex = 4
        Me.btnSaveLocation.Text = "Oppdater / Opprett"
        Me.btnSaveLocation.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(481, 65)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 20)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Lokasjon(*):"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(481, 142)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 20)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Telefon:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(481, 106)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 20)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Adresse:"
        '
        'tbLocationTelephoneNumber
        '
        Me.tbLocationTelephoneNumber.Location = New System.Drawing.Point(582, 142)
        Me.tbLocationTelephoneNumber.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbLocationTelephoneNumber.Name = "tbLocationTelephoneNumber"
        Me.tbLocationTelephoneNumber.Size = New System.Drawing.Size(296, 26)
        Me.tbLocationTelephoneNumber.TabIndex = 3
        '
        'tbLocationAddress
        '
        Me.tbLocationAddress.Location = New System.Drawing.Point(582, 106)
        Me.tbLocationAddress.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbLocationAddress.Name = "tbLocationAddress"
        Me.tbLocationAddress.Size = New System.Drawing.Size(296, 26)
        Me.tbLocationAddress.TabIndex = 2
        '
        'tbLocationName
        '
        Me.tbLocationName.Location = New System.Drawing.Point(582, 62)
        Me.tbLocationName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbLocationName.Name = "tbLocationName"
        Me.tbLocationName.Size = New System.Drawing.Size(296, 26)
        Me.tbLocationName.TabIndex = 1
        '
        'lbLocations
        '
        Me.lbLocations.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lbLocations.FormattingEnabled = True
        Me.lbLocations.ItemHeight = 20
        Me.lbLocations.Location = New System.Drawing.Point(20, 106)
        Me.lbLocations.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lbLocations.Name = "lbLocations"
        Me.lbLocations.Size = New System.Drawing.Size(398, 404)
        Me.lbLocations.TabIndex = 7
        '
        'btnLocationSearch
        '
        Me.btnLocationSearch.Location = New System.Drawing.Point(290, 62)
        Me.btnLocationSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLocationSearch.Name = "btnLocationSearch"
        Me.btnLocationSearch.Size = New System.Drawing.Size(124, 32)
        Me.btnLocationSearch.TabIndex = 6
        Me.btnLocationSearch.Text = "Søk"
        Me.btnLocationSearch.UseVisualStyleBackColor = True
        '
        'tbLocationSearch
        '
        Me.tbLocationSearch.Location = New System.Drawing.Point(131, 64)
        Me.tbLocationSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbLocationSearch.Name = "tbLocationSearch"
        Me.tbLocationSearch.Size = New System.Drawing.Size(148, 26)
        Me.tbLocationSearch.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 69)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 20)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Lokasjon:"
        '
        'TabBicycleTypes
        '
        Me.TabBicycleTypes.Controls.Add(Me.Label38)
        Me.TabBicycleTypes.Controls.Add(Me.Label37)
        Me.TabBicycleTypes.Controls.Add(Me.Label25)
        Me.TabBicycleTypes.Controls.Add(Me.btnBicycleTypeClear)
        Me.TabBicycleTypes.Controls.Add(Me.tbBicycleTypeRateHour)
        Me.TabBicycleTypes.Controls.Add(Me.tbBicycleTypeRateDay)
        Me.TabBicycleTypes.Controls.Add(Me.tbBicycleTypeFrameSize)
        Me.TabBicycleTypes.Controls.Add(Me.tbBicycleTypeWheelSize)
        Me.TabBicycleTypes.Controls.Add(Me.Label24)
        Me.TabBicycleTypes.Controls.Add(Me.Label23)
        Me.TabBicycleTypes.Controls.Add(Me.Label22)
        Me.TabBicycleTypes.Controls.Add(Me.Label21)
        Me.TabBicycleTypes.Controls.Add(Me.Label17)
        Me.TabBicycleTypes.Controls.Add(Me.btnBicycleTypeSave)
        Me.TabBicycleTypes.Controls.Add(Me.Label18)
        Me.TabBicycleTypes.Controls.Add(Me.Label19)
        Me.TabBicycleTypes.Controls.Add(Me.Label20)
        Me.TabBicycleTypes.Controls.Add(Me.tbBicycleTypeGearSystem)
        Me.TabBicycleTypes.Controls.Add(Me.tbBicycleTypeDescription)
        Me.TabBicycleTypes.Controls.Add(Me.tbBicycleTypeName)
        Me.TabBicycleTypes.Controls.Add(Me.lbBicycleType)
        Me.TabBicycleTypes.Location = New System.Drawing.Point(4, 29)
        Me.TabBicycleTypes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabBicycleTypes.Name = "TabBicycleTypes"
        Me.TabBicycleTypes.Size = New System.Drawing.Size(918, 622)
        Me.TabBicycleTypes.TabIndex = 2
        Me.TabBicycleTypes.Text = "Sykkeltyper"
        Me.TabBicycleTypes.UseVisualStyleBackColor = True
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(465, 24)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(202, 25)
        Me.Label38.TabIndex = 78
        Me.Label38.Text = "Sykkeltype detaljer:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(3, 24)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(268, 25)
        Me.Label37.TabIndex = 77
        Me.Label37.Text = "Liste over alle sykkeltyper:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(4, 536)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(274, 20)
        Me.Label25.TabIndex = 74
        Me.Label25.Text = "Høyreklikk for å slette valgt sykkeltype"
        '
        'btnBicycleTypeClear
        '
        Me.btnBicycleTypeClear.Location = New System.Drawing.Point(819, 414)
        Me.btnBicycleTypeClear.Name = "btnBicycleTypeClear"
        Me.btnBicycleTypeClear.Size = New System.Drawing.Size(66, 35)
        Me.btnBicycleTypeClear.TabIndex = 9
        Me.btnBicycleTypeClear.Text = "Tøm"
        Me.btnBicycleTypeClear.UseVisualStyleBackColor = True
        '
        'tbBicycleTypeRateHour
        '
        Me.tbBicycleTypeRateHour.Location = New System.Drawing.Point(595, 372)
        Me.tbBicycleTypeRateHour.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbBicycleTypeRateHour.Name = "tbBicycleTypeRateHour"
        Me.tbBicycleTypeRateHour.Size = New System.Drawing.Size(290, 26)
        Me.tbBicycleTypeRateHour.TabIndex = 7
        '
        'tbBicycleTypeRateDay
        '
        Me.tbBicycleTypeRateDay.Location = New System.Drawing.Point(595, 333)
        Me.tbBicycleTypeRateDay.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbBicycleTypeRateDay.Name = "tbBicycleTypeRateDay"
        Me.tbBicycleTypeRateDay.Size = New System.Drawing.Size(290, 26)
        Me.tbBicycleTypeRateDay.TabIndex = 6
        '
        'tbBicycleTypeFrameSize
        '
        Me.tbBicycleTypeFrameSize.Location = New System.Drawing.Point(595, 292)
        Me.tbBicycleTypeFrameSize.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbBicycleTypeFrameSize.Name = "tbBicycleTypeFrameSize"
        Me.tbBicycleTypeFrameSize.Size = New System.Drawing.Size(290, 26)
        Me.tbBicycleTypeFrameSize.TabIndex = 5
        '
        'tbBicycleTypeWheelSize
        '
        Me.tbBicycleTypeWheelSize.Location = New System.Drawing.Point(595, 248)
        Me.tbBicycleTypeWheelSize.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbBicycleTypeWheelSize.Name = "tbBicycleTypeWheelSize"
        Me.tbBicycleTypeWheelSize.Size = New System.Drawing.Size(290, 26)
        Me.tbBicycleTypeWheelSize.TabIndex = 4
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(466, 378)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 20)
        Me.Label24.TabIndex = 68
        Me.Label24.Text = "Timespris:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(466, 333)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(76, 20)
        Me.Label23.TabIndex = 67
        Me.Label23.Text = "Dagspris:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(466, 292)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(130, 20)
        Me.Label22.TabIndex = 66
        Me.Label22.Text = "Rammestørrelse:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(466, 248)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(101, 20)
        Me.Label21.TabIndex = 65
        Me.Label21.Text = "Hjulstørrelse:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(591, 454)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(273, 20)
        Me.Label17.TabIndex = 64
        Me.Label17.Text = "Felter merket med (*) er obligatoriske."
        '
        'btnBicycleTypeSave
        '
        Me.btnBicycleTypeSave.Location = New System.Drawing.Point(595, 414)
        Me.btnBicycleTypeSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBicycleTypeSave.Name = "btnBicycleTypeSave"
        Me.btnBicycleTypeSave.Size = New System.Drawing.Size(206, 35)
        Me.btnBicycleTypeSave.TabIndex = 8
        Me.btnBicycleTypeSave.Text = "Oppdater / Opprett"
        Me.btnBicycleTypeSave.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(466, 64)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(65, 20)
        Me.Label18.TabIndex = 62
        Me.Label18.Text = "Navn(*):"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(466, 205)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(84, 20)
        Me.Label19.TabIndex = 61
        Me.Label19.Text = "Girsystem:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(466, 104)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(93, 20)
        Me.Label20.TabIndex = 60
        Me.Label20.Text = "Beskrivelse:"
        '
        'tbBicycleTypeGearSystem
        '
        Me.tbBicycleTypeGearSystem.Location = New System.Drawing.Point(595, 205)
        Me.tbBicycleTypeGearSystem.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbBicycleTypeGearSystem.Name = "tbBicycleTypeGearSystem"
        Me.tbBicycleTypeGearSystem.Size = New System.Drawing.Size(290, 26)
        Me.tbBicycleTypeGearSystem.TabIndex = 3
        '
        'tbBicycleTypeDescription
        '
        Me.tbBicycleTypeDescription.Location = New System.Drawing.Point(595, 104)
        Me.tbBicycleTypeDescription.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbBicycleTypeDescription.MaxLength = 254
        Me.tbBicycleTypeDescription.Multiline = True
        Me.tbBicycleTypeDescription.Name = "tbBicycleTypeDescription"
        Me.tbBicycleTypeDescription.Size = New System.Drawing.Size(290, 91)
        Me.tbBicycleTypeDescription.TabIndex = 2
        '
        'tbBicycleTypeName
        '
        Me.tbBicycleTypeName.Location = New System.Drawing.Point(595, 60)
        Me.tbBicycleTypeName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbBicycleTypeName.Name = "tbBicycleTypeName"
        Me.tbBicycleTypeName.Size = New System.Drawing.Size(290, 26)
        Me.tbBicycleTypeName.TabIndex = 1
        '
        'lbBicycleType
        '
        Me.lbBicycleType.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lbBicycleType.FormattingEnabled = True
        Me.lbBicycleType.ItemHeight = 20
        Me.lbBicycleType.Location = New System.Drawing.Point(8, 54)
        Me.lbBicycleType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lbBicycleType.Name = "lbBicycleType"
        Me.lbBicycleType.Size = New System.Drawing.Size(276, 464)
        Me.lbBicycleType.TabIndex = 56
        '
        'TabEquipmentType
        '
        Me.TabEquipmentType.Controls.Add(Me.Label40)
        Me.TabEquipmentType.Controls.Add(Me.Label39)
        Me.TabEquipmentType.Controls.Add(Me.Label27)
        Me.TabEquipmentType.Controls.Add(Me.btnEquipmentTypeClear)
        Me.TabEquipmentType.Controls.Add(Me.tbEquipmentTypeRateDay)
        Me.TabEquipmentType.Controls.Add(Me.Label28)
        Me.TabEquipmentType.Controls.Add(Me.Label29)
        Me.TabEquipmentType.Controls.Add(Me.Label32)
        Me.TabEquipmentType.Controls.Add(Me.btnEquipmentTypeSave)
        Me.TabEquipmentType.Controls.Add(Me.Label33)
        Me.TabEquipmentType.Controls.Add(Me.Label35)
        Me.TabEquipmentType.Controls.Add(Me.tbEquipmentTypeRateHour)
        Me.TabEquipmentType.Controls.Add(Me.tbEquipmentTypeDescription)
        Me.TabEquipmentType.Controls.Add(Me.tbEquipmentTypeName)
        Me.TabEquipmentType.Controls.Add(Me.lbEquipmentType)
        Me.TabEquipmentType.Location = New System.Drawing.Point(4, 29)
        Me.TabEquipmentType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabEquipmentType.Name = "TabEquipmentType"
        Me.TabEquipmentType.Size = New System.Drawing.Size(912, 622)
        Me.TabEquipmentType.TabIndex = 3
        Me.TabEquipmentType.Text = "Utstyrstyper"
        Me.TabEquipmentType.UseVisualStyleBackColor = True
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(3, 30)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(271, 25)
        Me.Label39.TabIndex = 94
        Me.Label39.Text = "Liste over alle utstyrstyper:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(4, 409)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(282, 20)
        Me.Label27.TabIndex = 93
        Me.Label27.Text = "Høyreklikk for å slette valgt utstyrstype."
        '
        'btnEquipmentTypeClear
        '
        Me.btnEquipmentTypeClear.Location = New System.Drawing.Point(819, 283)
        Me.btnEquipmentTypeClear.Name = "btnEquipmentTypeClear"
        Me.btnEquipmentTypeClear.Size = New System.Drawing.Size(66, 35)
        Me.btnEquipmentTypeClear.TabIndex = 6
        Me.btnEquipmentTypeClear.Text = "Tøm"
        Me.btnEquipmentTypeClear.UseVisualStyleBackColor = True
        '
        'tbEquipmentTypeRateDay
        '
        Me.tbEquipmentTypeRateDay.Location = New System.Drawing.Point(564, 213)
        Me.tbEquipmentTypeRateDay.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbEquipmentTypeRateDay.Name = "tbEquipmentTypeRateDay"
        Me.tbEquipmentTypeRateDay.Size = New System.Drawing.Size(321, 26)
        Me.tbEquipmentTypeRateDay.TabIndex = 3
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(470, 251)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(80, 20)
        Me.Label28.TabIndex = 87
        Me.Label28.Text = "Timespris:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(470, 215)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(76, 20)
        Me.Label29.TabIndex = 86
        Me.Label29.Text = "Dagspris:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(560, 333)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(273, 20)
        Me.Label32.TabIndex = 83
        Me.Label32.Text = "Felter merket med (*) er obligatoriske."
        '
        'btnEquipmentTypeSave
        '
        Me.btnEquipmentTypeSave.Location = New System.Drawing.Point(564, 283)
        Me.btnEquipmentTypeSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEquipmentTypeSave.Name = "btnEquipmentTypeSave"
        Me.btnEquipmentTypeSave.Size = New System.Drawing.Size(237, 35)
        Me.btnEquipmentTypeSave.TabIndex = 5
        Me.btnEquipmentTypeSave.Text = "Oppdater / Opprett"
        Me.btnEquipmentTypeSave.UseVisualStyleBackColor = True
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(470, 71)
        Me.Label33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(65, 20)
        Me.Label33.TabIndex = 81
        Me.Label33.Text = "Navn(*):"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(470, 111)
        Me.Label35.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(93, 20)
        Me.Label35.TabIndex = 79
        Me.Label35.Text = "Beskrivelse:"
        '
        'tbEquipmentTypeRateHour
        '
        Me.tbEquipmentTypeRateHour.Location = New System.Drawing.Point(564, 249)
        Me.tbEquipmentTypeRateHour.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbEquipmentTypeRateHour.Name = "tbEquipmentTypeRateHour"
        Me.tbEquipmentTypeRateHour.Size = New System.Drawing.Size(321, 26)
        Me.tbEquipmentTypeRateHour.TabIndex = 4
        '
        'tbEquipmentTypeDescription
        '
        Me.tbEquipmentTypeDescription.Location = New System.Drawing.Point(564, 112)
        Me.tbEquipmentTypeDescription.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbEquipmentTypeDescription.MaxLength = 254
        Me.tbEquipmentTypeDescription.Multiline = True
        Me.tbEquipmentTypeDescription.Name = "tbEquipmentTypeDescription"
        Me.tbEquipmentTypeDescription.Size = New System.Drawing.Size(321, 91)
        Me.tbEquipmentTypeDescription.TabIndex = 2
        '
        'tbEquipmentTypeName
        '
        Me.tbEquipmentTypeName.Location = New System.Drawing.Point(564, 68)
        Me.tbEquipmentTypeName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbEquipmentTypeName.Name = "tbEquipmentTypeName"
        Me.tbEquipmentTypeName.Size = New System.Drawing.Size(321, 26)
        Me.tbEquipmentTypeName.TabIndex = 1
        '
        'lbEquipmentType
        '
        Me.lbEquipmentType.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lbEquipmentType.FormattingEnabled = True
        Me.lbEquipmentType.ItemHeight = 20
        Me.lbEquipmentType.Location = New System.Drawing.Point(8, 60)
        Me.lbEquipmentType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lbEquipmentType.Name = "lbEquipmentType"
        Me.lbEquipmentType.Size = New System.Drawing.Size(276, 344)
        Me.lbEquipmentType.TabIndex = 75
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(469, 30)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(202, 25)
        Me.Label40.TabIndex = 95
        Me.Label40.Text = "Sykkeltype detaljer:"
        '
        'adminView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 655)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "adminView"
        Me.Text = "admin"
        Me.TabControl1.ResumeLayout(False)
        Me.TabUsers.ResumeLayout(False)
        Me.TabUsers.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TabLocations.ResumeLayout(False)
        Me.TabLocations.PerformLayout()
        Me.TabBicycleTypes.ResumeLayout(False)
        Me.TabBicycleTypes.PerformLayout()
        Me.TabEquipmentType.ResumeLayout(False)
        Me.TabEquipmentType.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabUsers As TabPage
    Friend WithEvents TabLocations As TabPage
    Friend WithEvents TabBicycleTypes As TabPage
    Friend WithEvents lbUsers As ListBox
    Friend WithEvents btnUserSearch As Button
    Friend WithEvents TabEquipmentType As TabPage
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
    Friend WithEvents Label27 As Label
    Friend WithEvents btnEquipmentTypeClear As Button
    Friend WithEvents tbEquipmentTypeRateDay As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents btnEquipmentTypeSave As Button
    Friend WithEvents Label33 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents tbEquipmentTypeRateHour As TextBox
    Friend WithEvents tbEquipmentTypeDescription As TextBox
    Friend WithEvents tbEquipmentTypeName As TextBox
    Friend WithEvents lbEquipmentType As ListBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
End Class
