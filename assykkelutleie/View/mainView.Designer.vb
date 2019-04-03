<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainView))
        Me.btnCustomers = New System.Windows.Forms.Button()
        Me.btnBicycles = New System.Windows.Forms.Button()
        Me.btnTransport = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnRental = New System.Windows.Forms.Button()
        Me.PanelMainView = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'btnCustomers
        '
        Me.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomers.ImageKey = "(none)"
        Me.btnCustomers.Location = New System.Drawing.Point(12, 76)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(141, 45)
        Me.btnCustomers.TabIndex = 1
        Me.btnCustomers.Text = "Kunder"
        Me.btnCustomers.UseVisualStyleBackColor = True
        '
        'btnBicycles
        '
        Me.btnBicycles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBicycles.ImageKey = "(none)"
        Me.btnBicycles.Location = New System.Drawing.Point(12, 140)
        Me.btnBicycles.Name = "btnBicycles"
        Me.btnBicycles.Size = New System.Drawing.Size(141, 45)
        Me.btnBicycles.TabIndex = 2
        Me.btnBicycles.Text = "Sykler"
        Me.btnBicycles.UseVisualStyleBackColor = True
        '
        'btnTransport
        '
        Me.btnTransport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransport.ImageKey = "(none)"
        Me.btnTransport.Location = New System.Drawing.Point(12, 204)
        Me.btnTransport.Name = "btnTransport"
        Me.btnTransport.Size = New System.Drawing.Size(141, 45)
        Me.btnTransport.TabIndex = 3
        Me.btnTransport.Text = "Transport"
        Me.btnTransport.UseVisualStyleBackColor = True
        '
        'btnAdmin
        '
        Me.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdmin.ImageKey = "(none)"
        Me.btnAdmin.Location = New System.Drawing.Point(12, 268)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(141, 45)
        Me.btnAdmin.TabIndex = 4
        Me.btnAdmin.Text = "Admin"
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'btnRental
        '
        Me.btnRental.Image = Global.assykkelutleie.My.Resources.Resources.Rental
        Me.btnRental.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRental.ImageKey = "(none)"
        Me.btnRental.Location = New System.Drawing.Point(12, 12)
        Me.btnRental.Name = "btnRental"
        Me.btnRental.Size = New System.Drawing.Size(141, 45)
        Me.btnRental.TabIndex = 6
        Me.btnRental.Text = "Utleie"
        Me.btnRental.UseVisualStyleBackColor = True
        '
        'PanelMainView
        '
        Me.PanelMainView.Location = New System.Drawing.Point(175, 12)
        Me.PanelMainView.Name = "PanelMainView"
        Me.PanelMainView.Size = New System.Drawing.Size(613, 426)
        Me.PanelMainView.TabIndex = 7
        '
        'mainView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelMainView)
        Me.Controls.Add(Me.btnRental)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.btnTransport)
        Me.Controls.Add(Me.btnBicycles)
        Me.Controls.Add(Me.btnCustomers)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mainView"
        Me.Text = "main"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCustomers As Button
    Friend WithEvents btnBicycles As Button
    Friend WithEvents btnTransport As Button
    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnRental As Button
    Friend WithEvents PanelMainView As Panel
End Class
