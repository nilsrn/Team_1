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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(transportView))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFramenbr = New System.Windows.Forms.TextBox()
        Me.txtPickupTime = New System.Windows.Forms.TextBox()
        Me.txtDeliveryLocation = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPickupLocation = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRentalID = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lbFramenbr = New System.Windows.Forms.ListBox()
        Me.lbRentals = New System.Windows.Forms.ListBox()
        Me.txtRentalSearch = New System.Windows.Forms.TextBox()
        Me.btnBicyclesSearch = New System.Windows.Forms.Button()
        Me.btnBicycleSave = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbTransportation = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnTransportUpdate = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(18, 18)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(926, 655)
        Me.TabControl1.TabIndex = 19
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtFramenbr)
        Me.TabPage1.Controls.Add(Me.txtPickupTime)
        Me.TabPage1.Controls.Add(Me.txtDeliveryLocation)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtPickupLocation)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txtRentalID)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.lbFramenbr)
        Me.TabPage1.Controls.Add(Me.lbRentals)
        Me.TabPage1.Controls.Add(Me.txtRentalSearch)
        Me.TabPage1.Controls.Add(Me.btnBicyclesSearch)
        Me.TabPage1.Controls.Add(Me.btnBicycleSave)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Size = New System.Drawing.Size(918, 622)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Transport"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(498, 106)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 20)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Rammenummer:"
        '
        'txtFramenbr
        '
        Me.txtFramenbr.Enabled = False
        Me.txtFramenbr.Location = New System.Drawing.Point(646, 102)
        Me.txtFramenbr.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFramenbr.Name = "txtFramenbr"
        Me.txtFramenbr.Size = New System.Drawing.Size(228, 26)
        Me.txtFramenbr.TabIndex = 68
        '
        'txtPickupTime
        '
        Me.txtPickupTime.Enabled = False
        Me.txtPickupTime.Location = New System.Drawing.Point(646, 182)
        Me.txtPickupTime.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPickupTime.Name = "txtPickupTime"
        Me.txtPickupTime.Size = New System.Drawing.Size(228, 26)
        Me.txtPickupTime.TabIndex = 67
        '
        'txtDeliveryLocation
        '
        Me.txtDeliveryLocation.Enabled = False
        Me.txtDeliveryLocation.Location = New System.Drawing.Point(646, 222)
        Me.txtDeliveryLocation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDeliveryLocation.Name = "txtDeliveryLocation"
        Me.txtDeliveryLocation.Size = New System.Drawing.Size(228, 26)
        Me.txtDeliveryLocation.TabIndex = 66
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(498, 226)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 20)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Til:"
        '
        'txtPickupLocation
        '
        Me.txtPickupLocation.Enabled = False
        Me.txtPickupLocation.Location = New System.Drawing.Point(646, 142)
        Me.txtPickupLocation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPickupLocation.Name = "txtPickupLocation"
        Me.txtPickupLocation.Size = New System.Drawing.Size(228, 26)
        Me.txtPickupLocation.TabIndex = 64
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(498, 146)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 20)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Fra:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(498, 66)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 20)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Bestillingsnummer:"
        '
        'txtRentalID
        '
        Me.txtRentalID.Enabled = False
        Me.txtRentalID.Location = New System.Drawing.Point(646, 62)
        Me.txtRentalID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRentalID.Name = "txtRentalID"
        Me.txtRentalID.Size = New System.Drawing.Size(228, 26)
        Me.txtRentalID.TabIndex = 57
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(27, 31)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(142, 20)
        Me.Label15.TabIndex = 55
        Me.Label15.Text = "Bestillingsnummer:"
        '
        'lbFramenbr
        '
        Me.lbFramenbr.Enabled = False
        Me.lbFramenbr.FormattingEnabled = True
        Me.lbFramenbr.ItemHeight = 20
        Me.lbFramenbr.Location = New System.Drawing.Point(334, 66)
        Me.lbFramenbr.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lbFramenbr.Name = "lbFramenbr"
        Me.lbFramenbr.Size = New System.Drawing.Size(152, 264)
        Me.lbFramenbr.TabIndex = 54
        '
        'lbRentals
        '
        Me.lbRentals.FormattingEnabled = True
        Me.lbRentals.ItemHeight = 20
        Me.lbRentals.Location = New System.Drawing.Point(32, 66)
        Me.lbRentals.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lbRentals.Name = "lbRentals"
        Me.lbRentals.Size = New System.Drawing.Size(292, 264)
        Me.lbRentals.TabIndex = 49
        '
        'txtRentalSearch
        '
        Me.txtRentalSearch.Location = New System.Drawing.Point(176, 26)
        Me.txtRentalSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRentalSearch.Name = "txtRentalSearch"
        Me.txtRentalSearch.Size = New System.Drawing.Size(248, 26)
        Me.txtRentalSearch.TabIndex = 50
        '
        'btnBicyclesSearch
        '
        Me.btnBicyclesSearch.Location = New System.Drawing.Point(435, 26)
        Me.btnBicyclesSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBicyclesSearch.Name = "btnBicyclesSearch"
        Me.btnBicyclesSearch.Size = New System.Drawing.Size(54, 31)
        Me.btnBicyclesSearch.TabIndex = 48
        Me.btnBicyclesSearch.Text = "Søk"
        Me.btnBicyclesSearch.UseVisualStyleBackColor = True
        '
        'btnBicycleSave
        '
        Me.btnBicycleSave.Location = New System.Drawing.Point(502, 297)
        Me.btnBicycleSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBicycleSave.Name = "btnBicycleSave"
        Me.btnBicycleSave.Size = New System.Drawing.Size(374, 35)
        Me.btnBicycleSave.TabIndex = 51
        Me.btnBicycleSave.Text = "Registrer transport"
        Me.btnBicycleSave.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnTransportUpdate)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.lbTransportation)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(918, 622)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Til Transport"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(368, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Oversikt over sykler og utstyr som må transporteres"
        '
        'lbTransportation
        '
        Me.lbTransportation.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lbTransportation.FormattingEnabled = True
        Me.lbTransportation.ItemHeight = 20
        Me.lbTransportation.Location = New System.Drawing.Point(22, 70)
        Me.lbTransportation.Name = "lbTransportation"
        Me.lbTransportation.Size = New System.Drawing.Size(694, 484)
        Me.lbTransportation.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(259, 34)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(258, 30)
        Me.ToolStripMenuItem1.Text = "Markert som returnert"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 577)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(397, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Høyreklikk for å markere sykel eller utstyr som returnert."
        '
        'btnTransportUpdate
        '
        Me.btnTransportUpdate.Location = New System.Drawing.Point(758, 70)
        Me.btnTransportUpdate.Name = "btnTransportUpdate"
        Me.btnTransportUpdate.Size = New System.Drawing.Size(127, 81)
        Me.btnTransportUpdate.TabIndex = 3
        Me.btnTransportUpdate.Text = "Generer transportliste"
        Me.btnTransportUpdate.UseVisualStyleBackColor = True
        '
        'transportView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 692)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "transportView"
        Me.Text = "transport"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lbFramenbr As ListBox
    Friend WithEvents lbRentals As ListBox
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
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFramenbr As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents lbTransportation As ListBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Label5 As Label
    Friend WithEvents btnTransportUpdate As Button
End Class
