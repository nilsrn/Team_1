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
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCustomers
        '
        Me.btnCustomers.BackgroundImage = Global.assykkelutleie.My.Resources.Resources.Customers
        Me.btnCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomers.ImageKey = "(none)"
        Me.btnCustomers.Location = New System.Drawing.Point(18, 117)
        Me.btnCustomers.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(212, 69)
        Me.btnCustomers.TabIndex = 2
        Me.btnCustomers.Text = "Kunder"
        Me.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomers.UseVisualStyleBackColor = True
        '
        'btnBicycles
        '
        Me.btnBicycles.BackgroundImage = Global.assykkelutleie.My.Resources.Resources.Bicycles
        Me.btnBicycles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBicycles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBicycles.ImageKey = "(none)"
        Me.btnBicycles.Location = New System.Drawing.Point(18, 215)
        Me.btnBicycles.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBicycles.Name = "btnBicycles"
        Me.btnBicycles.Size = New System.Drawing.Size(212, 69)
        Me.btnBicycles.TabIndex = 3
        Me.btnBicycles.Text = "Sykler"
        Me.btnBicycles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBicycles.UseVisualStyleBackColor = True
        '
        'btnTransport
        '
        Me.btnTransport.BackgroundImage = Global.assykkelutleie.My.Resources.Resources.Transport
        Me.btnTransport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnTransport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransport.ImageKey = "(none)"
        Me.btnTransport.Location = New System.Drawing.Point(18, 314)
        Me.btnTransport.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTransport.Name = "btnTransport"
        Me.btnTransport.Size = New System.Drawing.Size(212, 69)
        Me.btnTransport.TabIndex = 4
        Me.btnTransport.Text = "Transport"
        Me.btnTransport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransport.UseVisualStyleBackColor = True
        '
        'btnAdmin
        '
        Me.btnAdmin.BackgroundImage = Global.assykkelutleie.My.Resources.Resources.Admin
        Me.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdmin.ImageKey = "(none)"
        Me.btnAdmin.Location = New System.Drawing.Point(18, 412)
        Me.btnAdmin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(212, 69)
        Me.btnAdmin.TabIndex = 5
        Me.btnAdmin.Text = "Admin"
        Me.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'btnRental
        '
        Me.btnRental.BackgroundImage = Global.assykkelutleie.My.Resources.Resources.Rental
        Me.btnRental.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnRental.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRental.ImageKey = "(none)"
        Me.btnRental.Location = New System.Drawing.Point(18, 18)
        Me.btnRental.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRental.Name = "btnRental"
        Me.btnRental.Size = New System.Drawing.Size(212, 69)
        Me.btnRental.TabIndex = 1
        Me.btnRental.Text = "Utleie"
        Me.btnRental.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRental.UseVisualStyleBackColor = True
        '
        'PanelMainView
        '
        Me.PanelMainView.Location = New System.Drawing.Point(262, 18)
        Me.PanelMainView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelMainView.Name = "PanelMainView"
        Me.PanelMainView.Size = New System.Drawing.Size(920, 655)
        Me.PanelMainView.TabIndex = 6
        '
        'btnLogout
        '
        Me.btnLogout.BackgroundImage = Global.assykkelutleie.My.Resources.Resources.Admin
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.ImageKey = "(none)"
        Me.btnLogout.Location = New System.Drawing.Point(18, 604)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(212, 69)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "Logg ut"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'mainView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.PanelMainView)
        Me.Controls.Add(Me.btnRental)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.btnTransport)
        Me.Controls.Add(Me.btnBicycles)
        Me.Controls.Add(Me.btnCustomers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "mainView"
        Me.Text = "AS SykkelUtleie"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCustomers As Button
    Friend WithEvents btnBicycles As Button
    Friend WithEvents btnTransport As Button
    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnRental As Button
    Friend WithEvents PanelMainView As Panel
    Friend WithEvents btnLogout As Button
End Class
