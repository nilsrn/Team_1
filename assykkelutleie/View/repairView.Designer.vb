<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class repairView
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
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lbEquipmentRepairs = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.repairUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbBicycleRepairs = New System.Windows.Forms.ListBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(1, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(960, 692)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btnUpdate)
        Me.TabPage1.Controls.Add(Me.lbEquipmentRepairs)
        Me.TabPage1.Controls.Add(Me.lbBicycleRepairs)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(952, 659)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Reparasjon"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(476, 611)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(242, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Høyreklikk for å oppdatere status"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 611)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(242, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Høyreklikk for å oppdatere status"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(476, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(296, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Liste over alt utstyr med status ""Service"":"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Liste over alle sykler med status ""Service"":"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackgroundImage = Global.assykkelutleie.My.Resources.Resources.reload
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnUpdate.Location = New System.Drawing.Point(889, 18)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(45, 46)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lbEquipmentRepairs
        '
        Me.lbEquipmentRepairs.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lbEquipmentRepairs.FormattingEnabled = True
        Me.lbEquipmentRepairs.ItemHeight = 20
        Me.lbEquipmentRepairs.Location = New System.Drawing.Point(480, 93)
        Me.lbEquipmentRepairs.Name = "lbEquipmentRepairs"
        Me.lbEquipmentRepairs.Size = New System.Drawing.Size(425, 504)
        Me.lbEquipmentRepairs.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.repairUpdate})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(162, 34)
        '
        'repairUpdate
        '
        Me.repairUpdate.Name = "repairUpdate"
        Me.repairUpdate.Size = New System.Drawing.Size(161, 30)
        Me.repairUpdate.Text = "Oppdater"
        '
        'lbBicycleRepairs
        '
        Me.lbBicycleRepairs.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lbBicycleRepairs.FormattingEnabled = True
        Me.lbBicycleRepairs.ItemHeight = 20
        Me.lbBicycleRepairs.Location = New System.Drawing.Point(30, 93)
        Me.lbBicycleRepairs.Name = "lbBicycleRepairs"
        Me.lbBicycleRepairs.Size = New System.Drawing.Size(385, 504)
        Me.lbBicycleRepairs.TabIndex = 0
        '
        'repairView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 692)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "repairView"
        Me.Text = "repairView"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lbEquipmentRepairs As ListBox
    Friend WithEvents lbBicycleRepairs As ListBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents repairUpdate As ToolStripMenuItem
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
