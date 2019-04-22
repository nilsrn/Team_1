<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class transportView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(transportView))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtPickupTime = New System.Windows.Forms.TextBox()
        Me.txtDeliveryLocation = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPickupLocation = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRentalID = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lbFramenbr = New System.Windows.Forms.ListBox()
        Me.lbRentalID = New System.Windows.Forms.ListBox()
        Me.txtRentalSearch = New System.Windows.Forms.TextBox()
        Me.btnBicyclesSearch = New System.Windows.Forms.Button()
        Me.btnBicycleSave = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(16, 15)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(823, 524)
        Me.TabControl1.TabIndex = 19
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtPickupTime)
        Me.TabPage1.Controls.Add(Me.txtDeliveryLocation)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtPickupLocation)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txtRentalID)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.lbFramenbr)
        Me.TabPage1.Controls.Add(Me.lbRentalID)
        Me.TabPage1.Controls.Add(Me.txtRentalSearch)
        Me.TabPage1.Controls.Add(Me.btnBicyclesSearch)
        Me.TabPage1.Controls.Add(Me.btnBicycleSave)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Size = New System.Drawing.Size(815, 495)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ny transport"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtPickupTime
        '
        Me.txtPickupTime.Enabled = False
        Me.txtPickupTime.Location = New System.Drawing.Point(575, 113)
        Me.txtPickupTime.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPickupTime.Name = "txtPickupTime"
        Me.txtPickupTime.Size = New System.Drawing.Size(203, 22)
        Me.txtPickupTime.TabIndex = 67
        '
        'txtDeliveryLocation
        '
        Me.txtDeliveryLocation.Enabled = False
        Me.txtDeliveryLocation.Location = New System.Drawing.Point(575, 145)
        Me.txtDeliveryLocation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDeliveryLocation.Name = "txtDeliveryLocation"
        Me.txtDeliveryLocation.Size = New System.Drawing.Size(203, 22)
        Me.txtDeliveryLocation.TabIndex = 66
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(443, 149)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 17)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Til:"
        '
        'txtPickupLocation
        '
        Me.txtPickupLocation.Enabled = False
        Me.txtPickupLocation.Location = New System.Drawing.Point(575, 81)
        Me.txtPickupLocation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPickupLocation.Name = "txtPickupLocation"
        Me.txtPickupLocation.Size = New System.Drawing.Size(203, 22)
        Me.txtPickupLocation.TabIndex = 64
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(443, 85)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 17)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Fra:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(443, 53)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 17)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Bestillingsnummer:"
        '
        'txtRentalID
        '
        Me.txtRentalID.Enabled = False
        Me.txtRentalID.Location = New System.Drawing.Point(575, 49)
        Me.txtRentalID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRentalID.Name = "txtRentalID"
        Me.txtRentalID.Size = New System.Drawing.Size(203, 22)
        Me.txtRentalID.TabIndex = 57
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(24, 25)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(126, 17)
        Me.Label15.TabIndex = 55
        Me.Label15.Text = "Bestillingsnummer:"
        '
        'lbFramenbr
        '
        Me.lbFramenbr.Enabled = False
        Me.lbFramenbr.FormattingEnabled = True
        Me.lbFramenbr.ItemHeight = 16
        Me.lbFramenbr.Location = New System.Drawing.Point(297, 53)
        Me.lbFramenbr.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbFramenbr.Name = "lbFramenbr"
        Me.lbFramenbr.Size = New System.Drawing.Size(136, 212)
        Me.lbFramenbr.TabIndex = 54
        '
        'lbRentalID
        '
        Me.lbRentalID.FormattingEnabled = True
        Me.lbRentalID.ItemHeight = 16
        Me.lbRentalID.Location = New System.Drawing.Point(28, 53)
        Me.lbRentalID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbRentalID.Name = "lbRentalID"
        Me.lbRentalID.Size = New System.Drawing.Size(260, 212)
        Me.lbRentalID.TabIndex = 49
        '
        'txtRentalSearch
        '
        Me.txtRentalSearch.Location = New System.Drawing.Point(156, 21)
        Me.txtRentalSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRentalSearch.Name = "txtRentalSearch"
        Me.txtRentalSearch.Size = New System.Drawing.Size(221, 22)
        Me.txtRentalSearch.TabIndex = 50
        '
        'btnBicyclesSearch
        '
        Me.btnBicyclesSearch.Location = New System.Drawing.Point(387, 21)
        Me.btnBicyclesSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBicyclesSearch.Name = "btnBicyclesSearch"
        Me.btnBicyclesSearch.Size = New System.Drawing.Size(48, 25)
        Me.btnBicyclesSearch.TabIndex = 48
        Me.btnBicyclesSearch.Text = "Søk"
        Me.btnBicyclesSearch.UseVisualStyleBackColor = True
        '
        'btnBicycleSave
        '
        Me.btnBicycleSave.Location = New System.Drawing.Point(447, 238)
        Me.btnBicycleSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBicycleSave.Name = "btnBicycleSave"
        Me.btnBicycleSave.Size = New System.Drawing.Size(332, 28)
        Me.btnBicycleSave.TabIndex = 51
        Me.btnBicycleSave.Text = "Registrer transport"
        Me.btnBicycleSave.UseVisualStyleBackColor = True
        '
        'transportView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 554)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "transportView"
        Me.Text = "transport"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lbFramenbr As ListBox
    Friend WithEvents lbRentalID As ListBox
    Friend WithEvents txtRentalSearch As TextBox
    Friend WithEvents btnBicyclesSearch As Button
    Friend WithEvents btnBicycleSave As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents txtPickupLocation As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtRentalID As TextBox
    Friend WithEvents txtDeliveryLocation As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPickupTime As TextBox
End Class
