<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class customerView
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.btnBicycleSave = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.lbCustomer = New System.Windows.Forms.ListBox()
        Me.btnCustomerSearch = New System.Windows.Forms.Button()
        Me.txtCustomerSearch = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SlettToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(617, 426)
        Me.TabControl1.TabIndex = 19
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtEmail)
        Me.TabPage3.Controls.Add(Me.txtTelephone)
        Me.TabPage3.Controls.Add(Me.txtSurname)
        Me.TabPage3.Controls.Add(Me.btnBicycleSave)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.txtFirstname)
        Me.TabPage3.Controls.Add(Me.lbCustomer)
        Me.TabPage3.Controls.Add(Me.btnCustomerSearch)
        Me.TabPage3.Controls.Add(Me.txtCustomerSearch)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(609, 400)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Kunder"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(427, 142)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(157, 20)
        Me.txtEmail.TabIndex = 44
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(427, 116)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(157, 20)
        Me.txtTelephone.TabIndex = 43
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(427, 90)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(157, 20)
        Me.txtSurname.TabIndex = 42
        '
        'btnBicycleSave
        '
        Me.btnBicycleSave.Location = New System.Drawing.Point(427, 177)
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
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Fornavn"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(297, 145)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "E-post:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(297, 119)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 13)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Telefonnummer:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(297, 93)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 13)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Etternavn"
        '
        'txtFirstname
        '
        Me.txtFirstname.Location = New System.Drawing.Point(427, 64)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(157, 20)
        Me.txtFirstname.TabIndex = 25
        '
        'lbCustomer
        '
        Me.lbCustomer.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lbCustomer.FormattingEnabled = True
        Me.lbCustomer.Location = New System.Drawing.Point(17, 60)
        Me.lbCustomer.Name = "lbCustomer"
        Me.lbCustomer.Size = New System.Drawing.Size(258, 329)
        Me.lbCustomer.TabIndex = 24
        '
        'btnCustomerSearch
        '
        Me.btnCustomerSearch.Location = New System.Drawing.Point(239, 31)
        Me.btnCustomerSearch.Name = "btnCustomerSearch"
        Me.btnCustomerSearch.Size = New System.Drawing.Size(36, 20)
        Me.btnCustomerSearch.TabIndex = 23
        Me.btnCustomerSearch.Text = "Søk"
        Me.btnCustomerSearch.UseVisualStyleBackColor = True
        '
        'txtCustomerSearch
        '
        Me.txtCustomerSearch.Location = New System.Drawing.Point(106, 31)
        Me.txtCustomerSearch.Name = "txtCustomerSearch"
        Me.txtCustomerSearch.Size = New System.Drawing.Size(127, 20)
        Me.txtCustomerSearch.TabIndex = 22
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(17, 34)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Telefonnummer:"
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
        Me.SlettToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SlettToolStripMenuItem.Text = "Slett"
        '
        'customerView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "customerView"
        Me.Text = "customerView"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents btnBicycleSave As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents lbCustomer As ListBox
    Friend WithEvents btnCustomerSearch As Button
    Friend WithEvents txtCustomerSearch As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents SlettToolStripMenuItem As ToolStripMenuItem
End Class
