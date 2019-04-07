<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bicyclesView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bicyclesView))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.rbStolen = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbService = New System.Windows.Forms.RadioButton()
        Me.rbRented = New System.Windows.Forms.RadioButton()
        Me.rbAvailable = New System.Windows.Forms.RadioButton()
        Me.btnBicycleRegister = New System.Windows.Forms.Button()
        Me.cmbCurrentLoc = New System.Windows.Forms.ComboBox()
        Me.cmbDefaultLoc = New System.Windows.Forms.ComboBox()
        Me.txtFramenbr = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lstBicycles = New System.Windows.Forms.ListBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(617, 426)
        Me.TabControl1.TabIndex = 18
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cmbType)
        Me.TabPage1.Controls.Add(Me.rbStolen)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.rbService)
        Me.TabPage1.Controls.Add(Me.rbRented)
        Me.TabPage1.Controls.Add(Me.rbAvailable)
        Me.TabPage1.Controls.Add(Me.btnBicycleRegister)
        Me.TabPage1.Controls.Add(Me.cmbCurrentLoc)
        Me.TabPage1.Controls.Add(Me.cmbDefaultLoc)
        Me.TabPage1.Controls.Add(Me.txtFramenbr)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(609, 400)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ny sykkel"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cmbType
        '
        Me.cmbType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Location = New System.Drawing.Point(20, 60)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(121, 24)
        Me.cmbType.TabIndex = 41
        Me.cmbType.Text = "Sykkeltype"
        '
        'rbStolen
        '
        Me.rbStolen.AutoSize = True
        Me.rbStolen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.rbStolen.Location = New System.Drawing.Point(416, 138)
        Me.rbStolen.Name = "rbStolen"
        Me.rbStolen.Size = New System.Drawing.Size(63, 20)
        Me.rbStolen.TabIndex = 40
        Me.rbStolen.TabStop = True
        Me.rbStolen.Text = "Stjålet"
        Me.rbStolen.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline)
        Me.Label3.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label3.Location = New System.Drawing.Point(413, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Status"
        '
        'rbService
        '
        Me.rbService.AutoSize = True
        Me.rbService.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.rbService.Location = New System.Drawing.Point(416, 112)
        Me.rbService.Name = "rbService"
        Me.rbService.Size = New System.Drawing.Size(72, 20)
        Me.rbService.TabIndex = 38
        Me.rbService.TabStop = True
        Me.rbService.Text = "Service"
        Me.rbService.UseVisualStyleBackColor = True
        '
        'rbRented
        '
        Me.rbRented.AutoSize = True
        Me.rbRented.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.rbRented.Location = New System.Drawing.Point(416, 86)
        Me.rbRented.Name = "rbRented"
        Me.rbRented.Size = New System.Drawing.Size(61, 20)
        Me.rbRented.TabIndex = 37
        Me.rbRented.TabStop = True
        Me.rbRented.Text = "Utleid"
        Me.rbRented.UseVisualStyleBackColor = True
        '
        'rbAvailable
        '
        Me.rbAvailable.AutoSize = True
        Me.rbAvailable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.rbAvailable.Location = New System.Drawing.Point(416, 60)
        Me.rbAvailable.Name = "rbAvailable"
        Me.rbAvailable.Size = New System.Drawing.Size(60, 20)
        Me.rbAvailable.TabIndex = 36
        Me.rbAvailable.TabStop = True
        Me.rbAvailable.Text = "Ledig"
        Me.rbAvailable.UseVisualStyleBackColor = True
        '
        'btnBicycleRegister
        '
        Me.btnBicycleRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnBicycleRegister.Location = New System.Drawing.Point(20, 114)
        Me.btnBicycleRegister.Name = "btnBicycleRegister"
        Me.btnBicycleRegister.Size = New System.Drawing.Size(375, 44)
        Me.btnBicycleRegister.TabIndex = 23
        Me.btnBicycleRegister.Text = "Registrer sykkel"
        Me.btnBicycleRegister.UseVisualStyleBackColor = True
        '
        'cmbCurrentLoc
        '
        Me.cmbCurrentLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmbCurrentLoc.FormattingEnabled = True
        Me.cmbCurrentLoc.Location = New System.Drawing.Point(274, 60)
        Me.cmbCurrentLoc.Name = "cmbCurrentLoc"
        Me.cmbCurrentLoc.Size = New System.Drawing.Size(121, 24)
        Me.cmbCurrentLoc.TabIndex = 14
        Me.cmbCurrentLoc.Text = "Gjeldende lokasjon"
        '
        'cmbDefaultLoc
        '
        Me.cmbDefaultLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmbDefaultLoc.FormattingEnabled = True
        Me.cmbDefaultLoc.Location = New System.Drawing.Point(147, 60)
        Me.cmbDefaultLoc.Name = "cmbDefaultLoc"
        Me.cmbDefaultLoc.Size = New System.Drawing.Size(121, 24)
        Me.cmbDefaultLoc.TabIndex = 13
        Me.cmbDefaultLoc.Text = "Standard lokasjon"
        '
        'txtFramenbr
        '
        Me.txtFramenbr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtFramenbr.Location = New System.Drawing.Point(147, 23)
        Me.txtFramenbr.Name = "txtFramenbr"
        Me.txtFramenbr.Size = New System.Drawing.Size(248, 22)
        Me.txtFramenbr.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(17, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Rammenummer :"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.btnSearch)
        Me.TabPage2.Controls.Add(Me.txtSearch)
        Me.TabPage2.Controls.Add(Me.lstBicycles)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(609, 400)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Sykkeloversikt"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline)
        Me.Label4.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label4.Location = New System.Drawing.Point(7, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Søk på rammenummer"
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnSearch.Location = New System.Drawing.Point(183, 47)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(83, 22)
        Me.btnSearch.TabIndex = 9
        Me.btnSearch.Text = "Søk"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtSearch.Location = New System.Drawing.Point(10, 47)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(167, 22)
        Me.txtSearch.TabIndex = 8
        '
        'lstBicycles
        '
        Me.lstBicycles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lstBicycles.FormattingEnabled = True
        Me.lstBicycles.ItemHeight = 16
        Me.lstBicycles.Location = New System.Drawing.Point(10, 80)
        Me.lstBicycles.Name = "lstBicycles"
        Me.lstBicycles.Size = New System.Drawing.Size(580, 308)
        Me.lstBicycles.TabIndex = 7
        '
        'bicyclesView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "bicyclesView"
        Me.Text = "bicycles"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtFramenbr As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lstBicycles As ListBox
    Friend WithEvents btnBicycleRegister As Button
    Friend WithEvents cmbCurrentLoc As ComboBox
    Friend WithEvents cmbDefaultLoc As ComboBox
    Friend WithEvents rbService As RadioButton
    Friend WithEvents rbRented As RadioButton
    Friend WithEvents rbAvailable As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents rbStolen As RadioButton
    Friend WithEvents cmbType As ComboBox
End Class
