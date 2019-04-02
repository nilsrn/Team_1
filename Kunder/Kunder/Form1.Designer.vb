<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.refresh = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
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
        Me.TabControl1.Location = New System.Drawing.Point(195, 33)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(856, 506)
        Me.TabControl1.TabIndex = 0
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
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(848, 477)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ny kunde"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CustomerRegister
        '
        Me.CustomerRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerRegister.Location = New System.Drawing.Point(29, 313)
        Me.CustomerRegister.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomerRegister.Name = "CustomerRegister"
        Me.CustomerRegister.Size = New System.Drawing.Size(409, 78)
        Me.CustomerRegister.TabIndex = 11
        Me.CustomerRegister.Text = "Registrer kunde"
        Me.CustomerRegister.UseVisualStyleBackColor = True
        '
        'birthTxt
        '
        Me.birthTxt.Location = New System.Drawing.Point(232, 263)
        Me.birthTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.birthTxt.Name = "birthTxt"
        Me.birthTxt.Size = New System.Drawing.Size(205, 22)
        Me.birthTxt.TabIndex = 10
        '
        'emailTxt
        '
        Me.emailTxt.Location = New System.Drawing.Point(232, 198)
        Me.emailTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.emailTxt.Name = "emailTxt"
        Me.emailTxt.Size = New System.Drawing.Size(205, 22)
        Me.emailTxt.TabIndex = 8
        '
        'phoneTxt
        '
        Me.phoneTxt.Location = New System.Drawing.Point(232, 139)
        Me.phoneTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.phoneTxt.Name = "phoneTxt"
        Me.phoneTxt.Size = New System.Drawing.Size(205, 22)
        Me.phoneTxt.TabIndex = 7
        '
        'surnameTxt
        '
        Me.surnameTxt.Location = New System.Drawing.Point(232, 82)
        Me.surnameTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.surnameTxt.Name = "surnameTxt"
        Me.surnameTxt.Size = New System.Drawing.Size(205, 22)
        Me.surnameTxt.TabIndex = 6
        '
        'firstnameTxt
        '
        Me.firstnameTxt.Location = New System.Drawing.Point(232, 30)
        Me.firstnameTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.firstnameTxt.Name = "firstnameTxt"
        Me.firstnameTxt.Size = New System.Drawing.Size(205, 22)
        Me.firstnameTxt.TabIndex = 5
        '
        'birth
        '
        Me.birth.AutoSize = True
        Me.birth.Location = New System.Drawing.Point(25, 263)
        Me.birth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.birth.Name = "birth"
        Me.birth.Size = New System.Drawing.Size(85, 17)
        Me.birth.TabIndex = 4
        Me.birth.Text = "Fødselsdato"
        '
        'email
        '
        Me.email.AutoSize = True
        Me.email.Location = New System.Drawing.Point(25, 202)
        Me.email.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(49, 17)
        Me.email.TabIndex = 3
        Me.email.Text = "E-post"
        '
        'phonenumber
        '
        Me.phonenumber.AutoSize = True
        Me.phonenumber.Location = New System.Drawing.Point(25, 139)
        Me.phonenumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.phonenumber.Name = "phonenumber"
        Me.phonenumber.Size = New System.Drawing.Size(92, 17)
        Me.phonenumber.TabIndex = 2
        Me.phonenumber.Text = "Mobilnummer"
        '
        'surname
        '
        Me.surname.AutoSize = True
        Me.surname.Location = New System.Drawing.Point(25, 82)
        Me.surname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.surname.Name = "surname"
        Me.surname.Size = New System.Drawing.Size(69, 17)
        Me.surname.TabIndex = 1
        Me.surname.Text = "Etternavn"
        '
        'firstname
        '
        Me.firstname.AutoSize = True
        Me.firstname.Location = New System.Drawing.Point(25, 30)
        Me.firstname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.firstname.Name = "firstname"
        Me.firstname.Size = New System.Drawing.Size(60, 17)
        Me.firstname.TabIndex = 0
        Me.firstname.Text = "Fornavn"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.refresh)
        Me.TabPage2.Controls.Add(Me.btnSearch)
        Me.TabPage2.Controls.Add(Me.txtSearch)
        Me.TabPage2.Controls.Add(Me.ListBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(848, 477)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Kundeoversikt"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(478, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Søk på telefonnummer:"
        '
        'refresh
        '
        Me.refresh.BackgroundImage = CType(resources.GetObject("refresh.BackgroundImage"), System.Drawing.Image)
        Me.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.refresh.Location = New System.Drawing.Point(749, 55)
        Me.refresh.Name = "refresh"
        Me.refresh.Size = New System.Drawing.Size(75, 62)
        Me.refresh.TabIndex = 15
        Me.refresh.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(646, 75)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 7
        Me.btnSearch.Text = "Søk"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(478, 75)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(162, 22)
        Me.txtSearch.TabIndex = 6
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(63, 120)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(658, 244)
        Me.ListBox1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
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
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents refresh As Button
    Friend WithEvents Label1 As Label
End Class
