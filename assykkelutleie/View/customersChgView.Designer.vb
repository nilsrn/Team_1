<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customersChgView
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
        Me.idlabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.deleteCustomer = New System.Windows.Forms.Button()
        Me.updateCustomer = New System.Windows.Forms.Button()
        Me.birthtxt = New System.Windows.Forms.DateTimePicker()
        Me.mailtxt = New System.Windows.Forms.TextBox()
        Me.phonetxt = New System.Windows.Forms.TextBox()
        Me.surnametxt = New System.Windows.Forms.TextBox()
        Me.firstnametxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'idlabel
        '
        Me.idlabel.AutoSize = True
        Me.idlabel.Location = New System.Drawing.Point(95, 13)
        Me.idlabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.idlabel.Name = "idlabel"
        Me.idlabel.Size = New System.Drawing.Size(0, 13)
        Me.idlabel.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 13)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "ID"
        '
        'deleteCustomer
        '
        Me.deleteCustomer.Location = New System.Drawing.Point(159, 232)
        Me.deleteCustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.deleteCustomer.Name = "deleteCustomer"
        Me.deleteCustomer.Size = New System.Drawing.Size(90, 36)
        Me.deleteCustomer.TabIndex = 25
        Me.deleteCustomer.Text = "Slett kunde"
        Me.deleteCustomer.UseVisualStyleBackColor = True
        '
        'updateCustomer
        '
        Me.updateCustomer.Location = New System.Drawing.Point(14, 232)
        Me.updateCustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.updateCustomer.Name = "updateCustomer"
        Me.updateCustomer.Size = New System.Drawing.Size(90, 36)
        Me.updateCustomer.TabIndex = 24
        Me.updateCustomer.Text = "Oppdater kunde"
        Me.updateCustomer.UseVisualStyleBackColor = True
        '
        'birthtxt
        '
        Me.birthtxt.Location = New System.Drawing.Point(98, 193)
        Me.birthtxt.Margin = New System.Windows.Forms.Padding(2)
        Me.birthtxt.Name = "birthtxt"
        Me.birthtxt.Size = New System.Drawing.Size(151, 20)
        Me.birthtxt.TabIndex = 23
        '
        'mailtxt
        '
        Me.mailtxt.Location = New System.Drawing.Point(98, 149)
        Me.mailtxt.Margin = New System.Windows.Forms.Padding(2)
        Me.mailtxt.Name = "mailtxt"
        Me.mailtxt.Size = New System.Drawing.Size(151, 20)
        Me.mailtxt.TabIndex = 22
        '
        'phonetxt
        '
        Me.phonetxt.Location = New System.Drawing.Point(98, 110)
        Me.phonetxt.Margin = New System.Windows.Forms.Padding(2)
        Me.phonetxt.Name = "phonetxt"
        Me.phonetxt.Size = New System.Drawing.Size(151, 20)
        Me.phonetxt.TabIndex = 21
        '
        'surnametxt
        '
        Me.surnametxt.Location = New System.Drawing.Point(98, 69)
        Me.surnametxt.Margin = New System.Windows.Forms.Padding(2)
        Me.surnametxt.Name = "surnametxt"
        Me.surnametxt.Size = New System.Drawing.Size(151, 20)
        Me.surnametxt.TabIndex = 20
        '
        'firstnametxt
        '
        Me.firstnametxt.Location = New System.Drawing.Point(98, 33)
        Me.firstnametxt.Margin = New System.Windows.Forms.Padding(2)
        Me.firstnametxt.Name = "firstnametxt"
        Me.firstnametxt.Size = New System.Drawing.Size(151, 20)
        Me.firstnametxt.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 193)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Fødseslsdato"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 151)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "E-post"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 110)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Telefonnummer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Etternavn"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Fornavn"
        '
        'customersChgView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 280)
        Me.Controls.Add(Me.idlabel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.deleteCustomer)
        Me.Controls.Add(Me.updateCustomer)
        Me.Controls.Add(Me.birthtxt)
        Me.Controls.Add(Me.mailtxt)
        Me.Controls.Add(Me.phonetxt)
        Me.Controls.Add(Me.surnametxt)
        Me.Controls.Add(Me.firstnametxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "customersChgView"
        Me.Text = "customersChgView"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents idlabel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents deleteCustomer As Button
    Friend WithEvents updateCustomer As Button
    Friend WithEvents birthtxt As DateTimePicker
    Friend WithEvents mailtxt As TextBox
    Friend WithEvents phonetxt As TextBox
    Friend WithEvents surnametxt As TextBox
    Friend WithEvents firstnametxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
