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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminView))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
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
        Me.btnUserSearch = New System.Windows.Forms.Button()
        Me.tbUsernameSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
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
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(617, 426)
        Me.TabControl1.TabIndex = 19
        '
        'TabPage1
        '
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
        Me.TabPage1.Controls.Add(Me.tbUsernameSearch)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(609, 400)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Brukere"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnUserSave
        '
        Me.btnUserSave.Location = New System.Drawing.Point(392, 292)
        Me.btnUserSave.Name = "btnUserSave"
        Me.btnUserSave.Size = New System.Drawing.Size(158, 23)
        Me.btnUserSave.TabIndex = 20
        Me.btnUserSave.Text = "Lagre / Oppdater"
        Me.btnUserSave.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(294, 193)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Telefonnummer:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(294, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Brukernavn:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(294, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Lokasjon:"
        '
        'cbUserLocation
        '
        Me.cbUserLocation.FormattingEnabled = True
        Me.cbUserLocation.Location = New System.Drawing.Point(382, 246)
        Me.cbUserLocation.Name = "cbUserLocation"
        Me.cbUserLocation.Size = New System.Drawing.Size(193, 21)
        Me.cbUserLocation.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(294, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "E-postadresse"
        '
        'cbAccountType
        '
        Me.cbAccountType.FormattingEnabled = True
        Me.cbAccountType.Location = New System.Drawing.Point(383, 219)
        Me.cbAccountType.Name = "cbAccountType"
        Me.cbAccountType.Size = New System.Drawing.Size(192, 21)
        Me.cbAccountType.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(294, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Kontotype:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(294, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Passord"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(294, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Etternavn:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(294, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Fornavn:"
        '
        'tbUserPhoneNumber
        '
        Me.tbUserPhoneNumber.Location = New System.Drawing.Point(383, 193)
        Me.tbUserPhoneNumber.Name = "tbUserPhoneNumber"
        Me.tbUserPhoneNumber.Size = New System.Drawing.Size(192, 20)
        Me.tbUserPhoneNumber.TabIndex = 9
        '
        'tbEmail
        '
        Me.tbEmail.Location = New System.Drawing.Point(383, 163)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(192, 20)
        Me.tbEmail.TabIndex = 8
        '
        'tbSurname
        '
        Me.tbSurname.Location = New System.Drawing.Point(383, 115)
        Me.tbSurname.Name = "tbSurname"
        Me.tbSurname.Size = New System.Drawing.Size(192, 20)
        Me.tbSurname.TabIndex = 7
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(383, 138)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(192, 20)
        Me.tbPassword.TabIndex = 6
        '
        'tbFirstName
        '
        Me.tbFirstName.Location = New System.Drawing.Point(383, 92)
        Me.tbFirstName.Name = "tbFirstName"
        Me.tbFirstName.Size = New System.Drawing.Size(192, 20)
        Me.tbFirstName.TabIndex = 5
        '
        'tbUsername
        '
        Me.tbUsername.Location = New System.Drawing.Point(383, 63)
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.Size = New System.Drawing.Size(192, 20)
        Me.tbUsername.TabIndex = 4
        '
        'lbUsers
        '
        Me.lbUsers.FormattingEnabled = True
        Me.lbUsers.Location = New System.Drawing.Point(6, 95)
        Me.lbUsers.Name = "lbUsers"
        Me.lbUsers.Size = New System.Drawing.Size(258, 95)
        Me.lbUsers.TabIndex = 3
        '
        'btnUserSearch
        '
        Me.btnUserSearch.Location = New System.Drawing.Point(189, 64)
        Me.btnUserSearch.Name = "btnUserSearch"
        Me.btnUserSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnUserSearch.TabIndex = 2
        Me.btnUserSearch.Text = "Søk"
        Me.btnUserSearch.UseVisualStyleBackColor = True
        '
        'tbUsernameSearch
        '
        Me.tbUsernameSearch.Location = New System.Drawing.Point(83, 66)
        Me.tbUsernameSearch.Name = "tbUsernameSearch"
        Me.tbUsernameSearch.Size = New System.Drawing.Size(100, 20)
        Me.tbUsernameSearch.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Brukernavn:"
        '
        'TabPage2
        '
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
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(609, 400)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Lokasjoner"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnSaveLocation
        '
        Me.btnSaveLocation.Location = New System.Drawing.Point(460, 178)
        Me.btnSaveLocation.Name = "btnSaveLocation"
        Me.btnSaveLocation.Size = New System.Drawing.Size(100, 23)
        Me.btnSaveLocation.TabIndex = 25
        Me.btnSaveLocation.Text = "Lagre / Oppdater"
        Me.btnSaveLocation.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(343, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Lokasjon:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(343, 118)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Telefon:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(343, 95)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Adresse:"
        '
        'tbLocationTelephoneNumber
        '
        Me.tbLocationTelephoneNumber.Location = New System.Drawing.Point(432, 118)
        Me.tbLocationTelephoneNumber.Name = "tbLocationTelephoneNumber"
        Me.tbLocationTelephoneNumber.Size = New System.Drawing.Size(157, 20)
        Me.tbLocationTelephoneNumber.TabIndex = 21
        '
        'tbLocationAddress
        '
        Me.tbLocationAddress.Location = New System.Drawing.Point(432, 95)
        Me.tbLocationAddress.Name = "tbLocationAddress"
        Me.tbLocationAddress.Size = New System.Drawing.Size(157, 20)
        Me.tbLocationAddress.TabIndex = 20
        '
        'tbLocationName
        '
        Me.tbLocationName.Location = New System.Drawing.Point(432, 66)
        Me.tbLocationName.Name = "tbLocationName"
        Me.tbLocationName.Size = New System.Drawing.Size(157, 20)
        Me.tbLocationName.TabIndex = 19
        '
        'lbLocations
        '
        Me.lbLocations.FormattingEnabled = True
        Me.lbLocations.Location = New System.Drawing.Point(13, 66)
        Me.lbLocations.Name = "lbLocations"
        Me.lbLocations.Size = New System.Drawing.Size(258, 225)
        Me.lbLocations.TabIndex = 7
        '
        'btnLocationSearch
        '
        Me.btnLocationSearch.Location = New System.Drawing.Point(196, 36)
        Me.btnLocationSearch.Name = "btnLocationSearch"
        Me.btnLocationSearch.Size = New System.Drawing.Size(83, 21)
        Me.btnLocationSearch.TabIndex = 6
        Me.btnLocationSearch.Text = "Søk"
        Me.btnLocationSearch.UseVisualStyleBackColor = True
        '
        'tbLocationSearch
        '
        Me.tbLocationSearch.Location = New System.Drawing.Point(90, 37)
        Me.tbLocationSearch.Name = "tbLocationSearch"
        Me.tbLocationSearch.Size = New System.Drawing.Size(100, 20)
        Me.tbLocationSearch.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Lokasjon:"
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(609, 400)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Sykkeltyper"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(609, 400)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Utstyrstyper"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'adminView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "adminView"
        Me.Text = "admin"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents lbUsers As ListBox
    Friend WithEvents btnUserSearch As Button
    Friend WithEvents tbUsernameSearch As TextBox
    Friend WithEvents Label1 As Label
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
End Class
