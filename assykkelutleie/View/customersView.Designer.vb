<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class customersView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(customersView))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CustomerRegister = New System.Windows.Forms.Button()
        Me.birthTxt = New System.Windows.Forms.DateTimePicker()
        Me.emailTxt = New System.Windows.Forms.TextBox()
        Me.phoneTxt = New System.Windows.Forms.TextBox()
        Me.surnameTxt = New System.Windows.Forms.TextBox()
        Me.firstnameTxt = New System.Windows.Forms.TextBox()
        Me.birth = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.Label()
        Me.phonenumber = New System.Windows.Forms.Label()
        Me.surname = New System.Windows.Forms.Label()
        Me.firstname = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.refresh = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchBtn = New System.Windows.Forms.Button()
        Me.txtSøk = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(617, 426)
        Me.TabControl1.TabIndex = 18
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CustomerRegister)
        Me.TabPage1.Controls.Add(Me.birthTxt)
        Me.TabPage1.Controls.Add(Me.emailTxt)
        Me.TabPage1.Controls.Add(Me.phoneTxt)
        Me.TabPage1.Controls.Add(Me.surnameTxt)
        Me.TabPage1.Controls.Add(Me.firstnameTxt)
        Me.TabPage1.Controls.Add(Me.birth)
        Me.TabPage1.Controls.Add(Me.email)
        Me.TabPage1.Controls.Add(Me.phonenumber)
        Me.TabPage1.Controls.Add(Me.surname)
        Me.TabPage1.Controls.Add(Me.firstname)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(609, 400)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ny kunde"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CustomerRegister
        '
        Me.CustomerRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CustomerRegister.Location = New System.Drawing.Point(22, 278)
        Me.CustomerRegister.Name = "CustomerRegister"
        Me.CustomerRegister.Size = New System.Drawing.Size(307, 44)
        Me.CustomerRegister.TabIndex = 22
        Me.CustomerRegister.Text = "Registrer kunde"
        Me.CustomerRegister.UseVisualStyleBackColor = True
        '
        'birthTxt
        '
        Me.birthTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.birthTxt.Location = New System.Drawing.Point(174, 218)
        Me.birthTxt.Name = "birthTxt"
        Me.birthTxt.Size = New System.Drawing.Size(155, 22)
        Me.birthTxt.TabIndex = 21
        '
        'emailTxt
        '
        Me.emailTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.emailTxt.Location = New System.Drawing.Point(174, 165)
        Me.emailTxt.Name = "emailTxt"
        Me.emailTxt.Size = New System.Drawing.Size(155, 22)
        Me.emailTxt.TabIndex = 20
        '
        'phoneTxt
        '
        Me.phoneTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.phoneTxt.Location = New System.Drawing.Point(174, 117)
        Me.phoneTxt.Name = "phoneTxt"
        Me.phoneTxt.Size = New System.Drawing.Size(155, 22)
        Me.phoneTxt.TabIndex = 19
        '
        'surnameTxt
        '
        Me.surnameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.surnameTxt.Location = New System.Drawing.Point(174, 71)
        Me.surnameTxt.Name = "surnameTxt"
        Me.surnameTxt.Size = New System.Drawing.Size(155, 22)
        Me.surnameTxt.TabIndex = 18
        '
        'firstnameTxt
        '
        Me.firstnameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.firstnameTxt.Location = New System.Drawing.Point(174, 28)
        Me.firstnameTxt.Name = "firstnameTxt"
        Me.firstnameTxt.Size = New System.Drawing.Size(155, 22)
        Me.firstnameTxt.TabIndex = 17
        '
        'birth
        '
        Me.birth.AutoSize = True
        Me.birth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.birth.Location = New System.Drawing.Point(19, 224)
        Me.birth.Name = "birth"
        Me.birth.Size = New System.Drawing.Size(84, 16)
        Me.birth.TabIndex = 16
        Me.birth.Text = "Fødselsdato"
        '
        'email
        '
        Me.email.AutoSize = True
        Me.email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.email.Location = New System.Drawing.Point(19, 171)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(47, 16)
        Me.email.TabIndex = 15
        Me.email.Text = "E-post"
        '
        'phonenumber
        '
        Me.phonenumber.AutoSize = True
        Me.phonenumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.phonenumber.Location = New System.Drawing.Point(19, 123)
        Me.phonenumber.Name = "phonenumber"
        Me.phonenumber.Size = New System.Drawing.Size(89, 16)
        Me.phonenumber.TabIndex = 14
        Me.phonenumber.Text = "Mobilnummer"
        '
        'surname
        '
        Me.surname.AutoSize = True
        Me.surname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.surname.Location = New System.Drawing.Point(19, 77)
        Me.surname.Name = "surname"
        Me.surname.Size = New System.Drawing.Size(64, 16)
        Me.surname.TabIndex = 13
        Me.surname.Text = "Etternavn"
        '
        'firstname
        '
        Me.firstname.AutoSize = True
        Me.firstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.firstname.Location = New System.Drawing.Point(19, 34)
        Me.firstname.Name = "firstname"
        Me.firstname.Size = New System.Drawing.Size(57, 16)
        Me.firstname.TabIndex = 12
        Me.firstname.Text = "Fornavn"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.refresh)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.searchBtn)
        Me.TabPage2.Controls.Add(Me.txtSøk)
        Me.TabPage2.Controls.Add(Me.ListBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(609, 400)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Kundeoversikt"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'refresh
        '
        Me.refresh.BackgroundImage = Global.assykkelutleie.My.Resources.Resources.update
        Me.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.refresh.Location = New System.Drawing.Point(532, 14)
        Me.refresh.Margin = New System.Windows.Forms.Padding(2)
        Me.refresh.Name = "refresh"
        Me.refresh.Size = New System.Drawing.Size(56, 50)
        Me.refresh.TabIndex = 16
        Me.refresh.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline)
        Me.Label1.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label1.Location = New System.Drawing.Point(11, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Søk på telefonnummer"
        '
        'searchBtn
        '
        Me.searchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.searchBtn.Location = New System.Drawing.Point(186, 49)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(83, 22)
        Me.searchBtn.TabIndex = 11
        Me.searchBtn.Text = "Søk"
        Me.searchBtn.UseVisualStyleBackColor = True
        '
        'txtSøk
        '
        Me.txtSøk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtSøk.Location = New System.Drawing.Point(14, 49)
        Me.txtSøk.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSøk.Name = "txtSøk"
        Me.txtSøk.Size = New System.Drawing.Size(167, 22)
        Me.txtSøk.TabIndex = 9
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(14, 76)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(574, 308)
        Me.ListBox1.TabIndex = 8
        '
        'customersView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "customersView"
        Me.Text = "customers"
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
    Friend WithEvents CustomerRegister As Button
    Friend WithEvents birthTxt As DateTimePicker
    Friend WithEvents emailTxt As TextBox
    Friend WithEvents phoneTxt As TextBox
    Friend WithEvents surnameTxt As TextBox
    Friend WithEvents firstnameTxt As TextBox
    Friend WithEvents birth As Label
    Friend WithEvents email As Label
    Friend WithEvents phonenumber As Label
    Friend WithEvents surname As Label
    Friend WithEvents firstname As Label
    Friend WithEvents txtSøk As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents searchBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents refresh As Button
End Class
