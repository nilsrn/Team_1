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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(customersView))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.searchlbl = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lstCustomers = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CustomerRegister = New System.Windows.Forms.Button()
        Me.emailTxt = New System.Windows.Forms.TextBox()
        Me.phoneTxt = New System.Windows.Forms.TextBox()
        Me.surnameTxt = New System.Windows.Forms.TextBox()
        Me.firstnameTxt = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.Label()
        Me.phonenumber = New System.Windows.Forms.Label()
        Me.surname = New System.Windows.Forms.Label()
        Me.firstname = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(16, 15)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(823, 524)
        Me.TabControl1.TabIndex = 18
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnsearch)
        Me.TabPage1.Controls.Add(Me.searchlbl)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.lstCustomers)
        Me.TabPage1.Controls.Add(Me.CustomerRegister)
        Me.TabPage1.Controls.Add(Me.emailTxt)
        Me.TabPage1.Controls.Add(Me.phoneTxt)
        Me.TabPage1.Controls.Add(Me.surnameTxt)
        Me.TabPage1.Controls.Add(Me.firstnameTxt)
        Me.TabPage1.Controls.Add(Me.email)
        Me.TabPage1.Controls.Add(Me.phonenumber)
        Me.TabPage1.Controls.Add(Me.surname)
        Me.TabPage1.Controls.Add(Me.firstname)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(815, 495)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ny kunde"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(352, 64)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(75, 23)
        Me.btnsearch.TabIndex = 26
        Me.btnsearch.Text = "Søk"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'searchlbl
        '
        Me.searchlbl.AutoSize = True
        Me.searchlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchlbl.Location = New System.Drawing.Point(16, 64)
        Me.searchlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.searchlbl.Name = "searchlbl"
        Me.searchlbl.Size = New System.Drawing.Size(144, 17)
        Me.searchlbl.TabIndex = 25
        Me.searchlbl.Text = "Søk på mobilnummer:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(167, 64)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(179, 22)
        Me.TextBox1.TabIndex = 24
        '
        'lstCustomers
        '
        Me.lstCustomers.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lstCustomers.FormattingEnabled = True
        Me.lstCustomers.ItemHeight = 16
        Me.lstCustomers.Location = New System.Drawing.Point(19, 92)
        Me.lstCustomers.Name = "lstCustomers"
        Me.lstCustomers.Size = New System.Drawing.Size(429, 340)
        Me.lstCustomers.TabIndex = 23
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'CustomerRegister
        '
        Me.CustomerRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerRegister.Location = New System.Drawing.Point(563, 326)
        Me.CustomerRegister.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomerRegister.Name = "CustomerRegister"
        Me.CustomerRegister.Size = New System.Drawing.Size(205, 29)
        Me.CustomerRegister.TabIndex = 22
        Me.CustomerRegister.Text = "Lagre"
        Me.CustomerRegister.UseVisualStyleBackColor = True
        '
        'emailTxt
        '
        Me.emailTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailTxt.Location = New System.Drawing.Point(573, 277)
        Me.emailTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.emailTxt.Name = "emailTxt"
        Me.emailTxt.Size = New System.Drawing.Size(195, 22)
        Me.emailTxt.TabIndex = 20
        '
        'phoneTxt
        '
        Me.phoneTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneTxt.Location = New System.Drawing.Point(573, 218)
        Me.phoneTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.phoneTxt.Name = "phoneTxt"
        Me.phoneTxt.Size = New System.Drawing.Size(195, 22)
        Me.phoneTxt.TabIndex = 19
        '
        'surnameTxt
        '
        Me.surnameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.surnameTxt.Location = New System.Drawing.Point(573, 161)
        Me.surnameTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.surnameTxt.Name = "surnameTxt"
        Me.surnameTxt.Size = New System.Drawing.Size(195, 22)
        Me.surnameTxt.TabIndex = 18
        '
        'firstnameTxt
        '
        Me.firstnameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstnameTxt.Location = New System.Drawing.Point(573, 108)
        Me.firstnameTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.firstnameTxt.Name = "firstnameTxt"
        Me.firstnameTxt.Size = New System.Drawing.Size(195, 22)
        Me.firstnameTxt.TabIndex = 17
        '
        'email
        '
        Me.email.AutoSize = True
        Me.email.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.Location = New System.Drawing.Point(473, 280)
        Me.email.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(49, 17)
        Me.email.TabIndex = 15
        Me.email.Text = "E-post"
        '
        'phonenumber
        '
        Me.phonenumber.AutoSize = True
        Me.phonenumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phonenumber.Location = New System.Drawing.Point(473, 221)
        Me.phonenumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.phonenumber.Name = "phonenumber"
        Me.phonenumber.Size = New System.Drawing.Size(92, 17)
        Me.phonenumber.TabIndex = 14
        Me.phonenumber.Text = "Mobilnummer"
        '
        'surname
        '
        Me.surname.AutoSize = True
        Me.surname.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.surname.Location = New System.Drawing.Point(473, 166)
        Me.surname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.surname.Name = "surname"
        Me.surname.Size = New System.Drawing.Size(69, 17)
        Me.surname.TabIndex = 13
        Me.surname.Text = "Etternavn"
        '
        'firstname
        '
        Me.firstname.AutoSize = True
        Me.firstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstname.Location = New System.Drawing.Point(473, 113)
        Me.firstname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.firstname.Name = "firstname"
        Me.firstname.Size = New System.Drawing.Size(60, 17)
        Me.firstname.TabIndex = 12
        Me.firstname.Text = "Fornavn"
        '
        'customersView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 554)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "customersView"
        Me.Text = "customers"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents CustomerRegister As Button
    Friend WithEvents emailTxt As TextBox
    Friend WithEvents phoneTxt As TextBox
    Friend WithEvents surnameTxt As TextBox
    Friend WithEvents firstnameTxt As TextBox
    Friend WithEvents email As Label
    Friend WithEvents phonenumber As Label
    Friend WithEvents surname As Label
    Friend WithEvents firstname As Label
    Friend WithEvents lstCustomers As ListBox
    Friend WithEvents searchlbl As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnsearch As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
#Disable Warning BC40004 ' Member conflicts with member in the base type and should be declared 'Shadows'
#Enable Warning BC40004 ' Member conflicts with member in the base type and should be declared 'Shadows'
End Class
