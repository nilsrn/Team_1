<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class endre
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.firstnametxt = New System.Windows.Forms.TextBox()
        Me.surnametxt = New System.Windows.Forms.TextBox()
        Me.phonetxt = New System.Windows.Forms.TextBox()
        Me.mailtxt = New System.Windows.Forms.TextBox()
        Me.birthtxt = New System.Windows.Forms.DateTimePicker()
        Me.updateCustomer = New System.Windows.Forms.Button()
        Me.deleteCustomer = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.idlabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fornavn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Etternavn"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Telefonnummer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "E-post"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fødseslsdato"
        '
        'firstnametxt
        '
        Me.firstnametxt.Location = New System.Drawing.Point(153, 33)
        Me.firstnametxt.Name = "firstnametxt"
        Me.firstnametxt.Size = New System.Drawing.Size(200, 22)
        Me.firstnametxt.TabIndex = 5
        '
        'surnametxt
        '
        Me.surnametxt.Location = New System.Drawing.Point(153, 78)
        Me.surnametxt.Name = "surnametxt"
        Me.surnametxt.Size = New System.Drawing.Size(200, 22)
        Me.surnametxt.TabIndex = 6
        '
        'phonetxt
        '
        Me.phonetxt.Location = New System.Drawing.Point(153, 128)
        Me.phonetxt.Name = "phonetxt"
        Me.phonetxt.Size = New System.Drawing.Size(200, 22)
        Me.phonetxt.TabIndex = 7
        '
        'mailtxt
        '
        Me.mailtxt.Location = New System.Drawing.Point(153, 176)
        Me.mailtxt.Name = "mailtxt"
        Me.mailtxt.Size = New System.Drawing.Size(200, 22)
        Me.mailtxt.TabIndex = 8
        '
        'birthtxt
        '
        Me.birthtxt.Location = New System.Drawing.Point(153, 230)
        Me.birthtxt.Name = "birthtxt"
        Me.birthtxt.Size = New System.Drawing.Size(200, 22)
        Me.birthtxt.TabIndex = 9
        '
        'updateCustomer
        '
        Me.updateCustomer.Location = New System.Drawing.Point(41, 278)
        Me.updateCustomer.Name = "updateCustomer"
        Me.updateCustomer.Size = New System.Drawing.Size(120, 44)
        Me.updateCustomer.TabIndex = 10
        Me.updateCustomer.Text = "Oppdater kunde"
        Me.updateCustomer.UseVisualStyleBackColor = True
        '
        'deleteCustomer
        '
        Me.deleteCustomer.Location = New System.Drawing.Point(202, 278)
        Me.deleteCustomer.Name = "deleteCustomer"
        Me.deleteCustomer.Size = New System.Drawing.Size(120, 44)
        Me.deleteCustomer.TabIndex = 11
        Me.deleteCustomer.Text = "Slett kunde"
        Me.deleteCustomer.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "ID"
        '
        'idlabel
        '
        Me.idlabel.AutoSize = True
        Me.idlabel.Location = New System.Drawing.Point(150, 9)
        Me.idlabel.Name = "idlabel"
        Me.idlabel.Size = New System.Drawing.Size(0, 17)
        Me.idlabel.TabIndex = 13
        '
        'endre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 334)
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
        Me.Name = "endre"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents firstnametxt As TextBox
    Friend WithEvents surnametxt As TextBox
    Friend WithEvents phonetxt As TextBox
    Friend WithEvents mailtxt As TextBox
    Friend WithEvents birthtxt As DateTimePicker
    Friend WithEvents updateCustomer As Button
    Friend WithEvents deleteCustomer As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents idlabel As Label
End Class
