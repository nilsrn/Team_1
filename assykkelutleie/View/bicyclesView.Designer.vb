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
        Dim TypeCmb As System.Windows.Forms.ComboBox
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bicyclesView))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.bicycleRegister = New System.Windows.Forms.Button()
        Me.gearCmb = New System.Windows.Forms.ComboBox()
        Me.wheelCmb = New System.Windows.Forms.ComboBox()
        Me.FramenbrTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.refresh = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gear2Cmb = New System.Windows.Forms.ComboBox()
        Me.wheel2Cmb = New System.Windows.Forms.ComboBox()
        Me.type2Cmb = New System.Windows.Forms.ComboBox()
        Me.searchBtn = New System.Windows.Forms.Button()
        Me.searchTxt = New System.Windows.Forms.TextBox()
        Me.bicyclesLst = New System.Windows.Forms.ListBox()
        TypeCmb = New System.Windows.Forms.ComboBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TypeCmb
        '
        TypeCmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        TypeCmb.FormattingEnabled = True
        TypeCmb.Location = New System.Drawing.Point(20, 60)
        TypeCmb.Name = "TypeCmb"
        TypeCmb.Size = New System.Drawing.Size(121, 24)
        TypeCmb.TabIndex = 12
        TypeCmb.Text = "Sykkeltype"
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
        Me.TabPage1.Controls.Add(Me.bicycleRegister)
        Me.TabPage1.Controls.Add(Me.gearCmb)
        Me.TabPage1.Controls.Add(Me.wheelCmb)
        Me.TabPage1.Controls.Add(TypeCmb)
        Me.TabPage1.Controls.Add(Me.FramenbrTxt)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(609, 400)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ny sykkel"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'bicycleRegister
        '
        Me.bicycleRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.bicycleRegister.Location = New System.Drawing.Point(20, 116)
        Me.bicycleRegister.Name = "bicycleRegister"
        Me.bicycleRegister.Size = New System.Drawing.Size(375, 44)
        Me.bicycleRegister.TabIndex = 23
        Me.bicycleRegister.Text = "Registrer sykkel"
        Me.bicycleRegister.UseVisualStyleBackColor = True
        '
        'gearCmb
        '
        Me.gearCmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.gearCmb.FormattingEnabled = True
        Me.gearCmb.Location = New System.Drawing.Point(274, 60)
        Me.gearCmb.Name = "gearCmb"
        Me.gearCmb.Size = New System.Drawing.Size(121, 24)
        Me.gearCmb.TabIndex = 14
        Me.gearCmb.Text = "Girsystem"
        '
        'wheelCmb
        '
        Me.wheelCmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.wheelCmb.FormattingEnabled = True
        Me.wheelCmb.Location = New System.Drawing.Point(147, 60)
        Me.wheelCmb.Name = "wheelCmb"
        Me.wheelCmb.Size = New System.Drawing.Size(121, 24)
        Me.wheelCmb.TabIndex = 13
        Me.wheelCmb.Text = "Hjulstørrelse"
        '
        'FramenbrTxt
        '
        Me.FramenbrTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.FramenbrTxt.Location = New System.Drawing.Point(147, 23)
        Me.FramenbrTxt.Name = "FramenbrTxt"
        Me.FramenbrTxt.Size = New System.Drawing.Size(248, 22)
        Me.FramenbrTxt.TabIndex = 11
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
        Me.TabPage2.Controls.Add(Me.refresh)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.gear2Cmb)
        Me.TabPage2.Controls.Add(Me.wheel2Cmb)
        Me.TabPage2.Controls.Add(Me.type2Cmb)
        Me.TabPage2.Controls.Add(Me.searchBtn)
        Me.TabPage2.Controls.Add(Me.searchTxt)
        Me.TabPage2.Controls.Add(Me.bicyclesLst)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(609, 400)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Sykkeloversikt"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'refresh
        '
        Me.refresh.BackgroundImage = Global.assykkelutleie.My.Resources.Resources.update
        Me.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.refresh.Location = New System.Drawing.Point(534, 72)
        Me.refresh.Margin = New System.Windows.Forms.Padding(2)
        Me.refresh.Name = "refresh"
        Me.refresh.Size = New System.Drawing.Size(56, 50)
        Me.refresh.TabIndex = 17
        Me.refresh.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline)
        Me.Label1.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label1.Location = New System.Drawing.Point(7, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Filtrer søk"
        '
        'gear2Cmb
        '
        Me.gear2Cmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.gear2Cmb.FormattingEnabled = True
        Me.gear2Cmb.Location = New System.Drawing.Point(264, 42)
        Me.gear2Cmb.Name = "gear2Cmb"
        Me.gear2Cmb.Size = New System.Drawing.Size(121, 24)
        Me.gear2Cmb.TabIndex = 12
        Me.gear2Cmb.Text = "Girsystem"
        '
        'wheel2Cmb
        '
        Me.wheel2Cmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.wheel2Cmb.FormattingEnabled = True
        Me.wheel2Cmb.Location = New System.Drawing.Point(137, 42)
        Me.wheel2Cmb.Name = "wheel2Cmb"
        Me.wheel2Cmb.Size = New System.Drawing.Size(121, 24)
        Me.wheel2Cmb.TabIndex = 11
        Me.wheel2Cmb.Text = "Hjulstørrelse"
        '
        'type2Cmb
        '
        Me.type2Cmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.type2Cmb.FormattingEnabled = True
        Me.type2Cmb.Location = New System.Drawing.Point(10, 42)
        Me.type2Cmb.Name = "type2Cmb"
        Me.type2Cmb.Size = New System.Drawing.Size(121, 24)
        Me.type2Cmb.TabIndex = 10
        Me.type2Cmb.Text = "Sykkeltype"
        '
        'searchBtn
        '
        Me.searchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.searchBtn.Location = New System.Drawing.Point(302, 100)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(83, 22)
        Me.searchBtn.TabIndex = 9
        Me.searchBtn.Text = "Søk"
        Me.searchBtn.UseVisualStyleBackColor = True
        '
        'searchTxt
        '
        Me.searchTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.searchTxt.Location = New System.Drawing.Point(10, 100)
        Me.searchTxt.Name = "searchTxt"
        Me.searchTxt.Size = New System.Drawing.Size(286, 22)
        Me.searchTxt.TabIndex = 8
        '
        'bicyclesLst
        '
        Me.bicyclesLst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.bicyclesLst.FormattingEnabled = True
        Me.bicyclesLst.ItemHeight = 16
        Me.bicyclesLst.Location = New System.Drawing.Point(10, 128)
        Me.bicyclesLst.Name = "bicyclesLst"
        Me.bicyclesLst.Size = New System.Drawing.Size(580, 260)
        Me.bicyclesLst.TabIndex = 7
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
    Friend WithEvents gearCmb As ComboBox
    Friend WithEvents wheelCmb As ComboBox
    Friend WithEvents FramenbrTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents gear2Cmb As ComboBox
    Friend WithEvents wheel2Cmb As ComboBox
    Friend WithEvents type2Cmb As ComboBox
    Friend WithEvents searchBtn As Button
    Friend WithEvents searchTxt As TextBox
    Friend WithEvents bicyclesLst As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents bicycleRegister As Button
    Friend WithEvents refresh As Button
End Class
