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
        Me.btnRental = New System.Windows.Forms.Button()
        Me.btnTransport = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnRepair = New System.Windows.Forms.Button()
        Me.btnInOut = New System.Windows.Forms.Button()
        Me.btnStatistics = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCustomers
        '
        Me.btnCustomers.BackgroundImage = Global.assykkelutleie.My.Resources.Resources.Customers
        Me.btnCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomers.ImageKey = "(none)"
        Me.btnCustomers.Location = New System.Drawing.Point(9, 55)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(144, 45)
        Me.btnCustomers.TabIndex = 2
        Me.btnCustomers.Text = "Kunder"
        Me.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomers.UseVisualStyleBackColor = True
        '
        'btnBicycles
        '
        Me.btnBicycles.BackgroundImage = Global.assykkelutleie.My.Resources.Resources.Bicycles
        Me.btnBicycles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBicycles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBicycles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBicycles.ImageKey = "(none)"
        Me.btnBicycles.Location = New System.Drawing.Point(9, 106)
        Me.btnBicycles.Name = "btnBicycles"
        Me.btnBicycles.Size = New System.Drawing.Size(144, 45)
        Me.btnBicycles.TabIndex = 3
        Me.btnBicycles.Text = "Sykler                Utstyr"
        Me.btnBicycles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBicycles.UseVisualStyleBackColor = True
        '
        'btnRental
        '
        Me.btnRental.BackgroundImage = Global.assykkelutleie.My.Resources.Resources.Rental
        Me.btnRental.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnRental.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRental.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRental.ImageKey = "(none)"
        Me.btnRental.Location = New System.Drawing.Point(9, 3)
        Me.btnRental.Name = "btnRental"
        Me.btnRental.Size = New System.Drawing.Size(144, 45)
        Me.btnRental.TabIndex = 1
        Me.btnRental.Text = "Utleie"
        Me.btnRental.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRental.UseVisualStyleBackColor = True
        '
        'btnTransport
        '
        Me.btnTransport.BackgroundImage = Global.assykkelutleie.My.Resources.Resources.Transport
        Me.btnTransport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnTransport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransport.ImageKey = "(none)"
        Me.btnTransport.Location = New System.Drawing.Point(9, 157)
        Me.btnTransport.Name = "btnTransport"
        Me.btnTransport.Size = New System.Drawing.Size(144, 45)
        Me.btnTransport.TabIndex = 4
        Me.btnTransport.Text = "Transport"
        Me.btnTransport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransport.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.BackgroundImage = Global.assykkelutleie.My.Resources.Resources.Logout
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.ImageKey = "(none)"
        Me.btnLogout.Location = New System.Drawing.Point(11, 407)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(144, 34)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "Logg ut"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnAdmin
        '
        Me.btnAdmin.BackgroundImage = Global.assykkelutleie.My.Resources.Resources.Admin
        Me.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdmin.ImageKey = "(none)"
        Me.btnAdmin.Location = New System.Drawing.Point(11, 363)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(144, 38)
        Me.btnAdmin.TabIndex = 5
        Me.btnAdmin.Text = "Admin"
        Me.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnRepair)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnInOut)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnStatistics)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnCustomers)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnRental)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnBicycles)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnLogout)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnTransport)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAdmin)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackgroundImage = Global.assykkelutleie.My.Resources.Resources.AS_SykkelUtleie_Logo
        Me.SplitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 450)
        Me.SplitContainer1.SplitterDistance = 157
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 8
        '
        'btnRepair
        '
        Me.btnRepair.BackgroundImage = Global.assykkelutleie.My.Resources.Resources.tools
        Me.btnRepair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnRepair.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRepair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRepair.ImageKey = "(none)"
        Me.btnRepair.Location = New System.Drawing.Point(11, 260)
        Me.btnRepair.Name = "btnRepair"
        Me.btnRepair.Size = New System.Drawing.Size(144, 45)
        Me.btnRepair.TabIndex = 10
        Me.btnRepair.Text = "Reparasjon"
        Me.btnRepair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRepair.UseVisualStyleBackColor = True
        '
        'btnInOut
        '
        Me.btnInOut.BackgroundImage = Global.assykkelutleie.My.Resources.Resources.check_in
        Me.btnInOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnInOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInOut.ImageKey = "(none)"
        Me.btnInOut.Location = New System.Drawing.Point(11, 209)
        Me.btnInOut.Name = "btnInOut"
        Me.btnInOut.Size = New System.Drawing.Size(144, 45)
        Me.btnInOut.TabIndex = 9
        Me.btnInOut.Text = "Mottak         Uthenting"
        Me.btnInOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInOut.UseVisualStyleBackColor = True
        '
        'btnStatistics
        '
        Me.btnStatistics.BackgroundImage = Global.assykkelutleie.My.Resources.Resources.graph
        Me.btnStatistics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnStatistics.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStatistics.ImageKey = "(none)"
        Me.btnStatistics.Location = New System.Drawing.Point(11, 311)
        Me.btnStatistics.Name = "btnStatistics"
        Me.btnStatistics.Size = New System.Drawing.Size(144, 45)
        Me.btnStatistics.TabIndex = 8
        Me.btnStatistics.Text = "Statistikk"
        Me.btnStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStatistics.UseVisualStyleBackColor = True
        '
        'mainView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mainView"
        Me.Text = "AS SykkelUtleie"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCustomers As Button
    Friend WithEvents btnBicycles As Button
    Friend WithEvents btnRental As Button
    Friend WithEvents btnTransport As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnAdmin As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btnStatistics As Button
    Friend WithEvents btnInOut As Button
    Friend WithEvents btnRepair As Button
End Class
