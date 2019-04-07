<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bicyclesChgView
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
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.cmbCurrentLoc = New System.Windows.Forms.ComboBox()
        Me.cmbDefaultLoc = New System.Windows.Forms.ComboBox()
        Me.txtFramenbr = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbAvailable = New System.Windows.Forms.RadioButton()
        Me.rbRented = New System.Windows.Forms.RadioButton()
        Me.rbService = New System.Windows.Forms.RadioButton()
        Me.rbStolen = New System.Windows.Forms.RadioButton()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(14, 93)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(375, 44)
        Me.btnUpdate.TabIndex = 29
        Me.btnUpdate.Text = "Oppdater sykkel"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'cmbCurrentLoc
        '
        Me.cmbCurrentLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmbCurrentLoc.FormattingEnabled = True
        Me.cmbCurrentLoc.Location = New System.Drawing.Point(268, 51)
        Me.cmbCurrentLoc.Name = "cmbCurrentLoc"
        Me.cmbCurrentLoc.Size = New System.Drawing.Size(121, 21)
        Me.cmbCurrentLoc.TabIndex = 28
        Me.cmbCurrentLoc.Text = "Gjeldende lokasjon"
        '
        'cmbDefaultLoc
        '
        Me.cmbDefaultLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmbDefaultLoc.FormattingEnabled = True
        Me.cmbDefaultLoc.Location = New System.Drawing.Point(141, 51)
        Me.cmbDefaultLoc.Name = "cmbDefaultLoc"
        Me.cmbDefaultLoc.Size = New System.Drawing.Size(121, 21)
        Me.cmbDefaultLoc.TabIndex = 27
        Me.cmbDefaultLoc.Text = "Standard lokasjon"
        '
        'txtFramenbr
        '
        Me.txtFramenbr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtFramenbr.Location = New System.Drawing.Point(141, 14)
        Me.txtFramenbr.Name = "txtFramenbr"
        Me.txtFramenbr.Size = New System.Drawing.Size(248, 20)
        Me.txtFramenbr.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(11, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Rammenummer :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline)
        Me.Label3.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label3.Location = New System.Drawing.Point(413, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Status"
        '
        'rbAvailable
        '
        Me.rbAvailable.AutoSize = True
        Me.rbAvailable.Location = New System.Drawing.Point(416, 51)
        Me.rbAvailable.Name = "rbAvailable"
        Me.rbAvailable.Size = New System.Drawing.Size(51, 17)
        Me.rbAvailable.TabIndex = 33
        Me.rbAvailable.TabStop = True
        Me.rbAvailable.Text = "Ledig"
        Me.rbAvailable.UseVisualStyleBackColor = True
        '
        'rbRented
        '
        Me.rbRented.AutoSize = True
        Me.rbRented.Location = New System.Drawing.Point(416, 74)
        Me.rbRented.Name = "rbRented"
        Me.rbRented.Size = New System.Drawing.Size(52, 17)
        Me.rbRented.TabIndex = 34
        Me.rbRented.TabStop = True
        Me.rbRented.Text = "Utleid"
        Me.rbRented.UseVisualStyleBackColor = True
        '
        'rbService
        '
        Me.rbService.AutoSize = True
        Me.rbService.Location = New System.Drawing.Point(416, 97)
        Me.rbService.Name = "rbService"
        Me.rbService.Size = New System.Drawing.Size(61, 17)
        Me.rbService.TabIndex = 35
        Me.rbService.TabStop = True
        Me.rbService.Text = "Service"
        Me.rbService.UseVisualStyleBackColor = True
        '
        'rbStolen
        '
        Me.rbStolen.AutoSize = True
        Me.rbStolen.Location = New System.Drawing.Point(416, 120)
        Me.rbStolen.Name = "rbStolen"
        Me.rbStolen.Size = New System.Drawing.Size(54, 17)
        Me.rbStolen.TabIndex = 37
        Me.rbStolen.TabStop = True
        Me.rbStolen.Text = "Stjålet"
        Me.rbStolen.UseVisualStyleBackColor = True
        '
        'cmbType
        '
        Me.cmbType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Location = New System.Drawing.Point(14, 51)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(121, 21)
        Me.cmbType.TabIndex = 38
        Me.cmbType.Text = "Sykkeltype"
        '
        'bicyclesChgView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 156)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.rbStolen)
        Me.Controls.Add(Me.rbService)
        Me.Controls.Add(Me.rbRented)
        Me.Controls.Add(Me.rbAvailable)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.cmbCurrentLoc)
        Me.Controls.Add(Me.cmbDefaultLoc)
        Me.Controls.Add(Me.txtFramenbr)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "bicyclesChgView"
        Me.Text = "bicyclesChgView"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUpdate As Button
    Friend WithEvents cmbCurrentLoc As ComboBox
    Friend WithEvents cmbDefaultLoc As ComboBox
    Friend WithEvents txtFramenbr As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents rbAvailable As RadioButton
    Friend WithEvents rbRented As RadioButton
    Friend WithEvents rbService As RadioButton
    Friend WithEvents rbStolen As RadioButton
    Friend WithEvents cmbType As ComboBox
End Class
