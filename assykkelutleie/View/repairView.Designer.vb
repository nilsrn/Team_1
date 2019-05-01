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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lbEquipmentRepairs = New System.Windows.Forms.ListBox()
        Me.lbBicycleRepairs = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
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
        Me.TabPage1.Controls.Add(Me.Button1)
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
        'lbEquipmentRepairs
        '
        Me.lbEquipmentRepairs.FormattingEnabled = True
        Me.lbEquipmentRepairs.ItemHeight = 20
        Me.lbEquipmentRepairs.Location = New System.Drawing.Point(559, 59)
        Me.lbEquipmentRepairs.Name = "lbEquipmentRepairs"
        Me.lbEquipmentRepairs.Size = New System.Drawing.Size(193, 504)
        Me.lbEquipmentRepairs.TabIndex = 1
        '
        'lbBicycleRepairs
        '
        Me.lbBicycleRepairs.FormattingEnabled = True
        Me.lbBicycleRepairs.ItemHeight = 20
        Me.lbBicycleRepairs.Location = New System.Drawing.Point(68, 59)
        Me.lbBicycleRepairs.Name = "lbBicycleRepairs"
        Me.lbBicycleRepairs.Size = New System.Drawing.Size(231, 504)
        Me.lbBicycleRepairs.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(379, 87)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lbEquipmentRepairs As ListBox
    Friend WithEvents lbBicycleRepairs As ListBox
    Friend WithEvents Button1 As Button
End Class
