<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class statisticsView
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
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtAverage = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtDecember = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNovember = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtOctober = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSeptember = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAugust = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtJuly = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtJune = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMay = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtApril = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMars = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFebruary = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtJanuary = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.TabIndex = 19
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.btnRefresh)
        Me.TabPage1.Controls.Add(Me.Label30)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(609, 400)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Popularitet"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.BackgroundImage = Global.assykkelutleie.My.Resources.Resources.reload
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnRefresh.Location = New System.Drawing.Point(561, 9)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(30, 30)
        Me.btnRefresh.TabIndex = 59
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(11, 11)
        Me.Label30.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(203, 17)
        Me.Label30.TabIndex = 57
        Me.Label30.Text = "Mest populære sykkeltyper"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtAverage)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.txtTotal)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.txtDecember)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.txtNovember)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.txtOctober)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.txtSeptember)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.txtAugust)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.txtJuly)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.txtJune)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.txtMay)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.txtApril)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.txtMars)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.txtFebruary)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txtJanuary)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.DateTimePicker1)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(609, 400)
        Me.TabPage2.TabIndex = 4
        Me.TabPage2.Text = "Avanse"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtAverage
        '
        Me.txtAverage.Location = New System.Drawing.Point(351, 82)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.ReadOnly = True
        Me.txtAverage.Size = New System.Drawing.Size(82, 20)
        Me.txtAverage.TabIndex = 87
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(277, 85)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 13)
        Me.Label15.TabIndex = 86
        Me.Label15.Text = "Gjennomsnitt"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(351, 56)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(82, 20)
        Me.txtTotal.TabIndex = 85
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(277, 59)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 13)
        Me.Label14.TabIndex = 84
        Me.Label14.Text = "Totalt"
        '
        'txtDecember
        '
        Me.txtDecember.Location = New System.Drawing.Point(78, 342)
        Me.txtDecember.Name = "txtDecember"
        Me.txtDecember.ReadOnly = True
        Me.txtDecember.Size = New System.Drawing.Size(82, 20)
        Me.txtDecember.TabIndex = 83
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 345)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 13)
        Me.Label13.TabIndex = 82
        Me.Label13.Text = "Desember"
        '
        'txtNovember
        '
        Me.txtNovember.Location = New System.Drawing.Point(78, 316)
        Me.txtNovember.Name = "txtNovember"
        Me.txtNovember.ReadOnly = True
        Me.txtNovember.Size = New System.Drawing.Size(82, 20)
        Me.txtNovember.TabIndex = 81
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 319)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 80
        Me.Label12.Text = "November"
        '
        'txtOctober
        '
        Me.txtOctober.Location = New System.Drawing.Point(78, 290)
        Me.txtOctober.Name = "txtOctober"
        Me.txtOctober.ReadOnly = True
        Me.txtOctober.Size = New System.Drawing.Size(82, 20)
        Me.txtOctober.TabIndex = 79
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 293)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 78
        Me.Label11.Text = "Oktober"
        '
        'txtSeptember
        '
        Me.txtSeptember.Location = New System.Drawing.Point(78, 264)
        Me.txtSeptember.Name = "txtSeptember"
        Me.txtSeptember.ReadOnly = True
        Me.txtSeptember.Size = New System.Drawing.Size(82, 20)
        Me.txtSeptember.TabIndex = 77
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 267)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 76
        Me.Label10.Text = "September"
        '
        'txtAugust
        '
        Me.txtAugust.Location = New System.Drawing.Point(78, 238)
        Me.txtAugust.Name = "txtAugust"
        Me.txtAugust.ReadOnly = True
        Me.txtAugust.Size = New System.Drawing.Size(82, 20)
        Me.txtAugust.TabIndex = 75
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 241)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "August"
        '
        'txtJuly
        '
        Me.txtJuly.Location = New System.Drawing.Point(78, 212)
        Me.txtJuly.Name = "txtJuly"
        Me.txtJuly.ReadOnly = True
        Me.txtJuly.Size = New System.Drawing.Size(82, 20)
        Me.txtJuly.TabIndex = 73
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 215)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 13)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "Juli"
        '
        'txtJune
        '
        Me.txtJune.Location = New System.Drawing.Point(78, 186)
        Me.txtJune.Name = "txtJune"
        Me.txtJune.ReadOnly = True
        Me.txtJune.Size = New System.Drawing.Size(82, 20)
        Me.txtJune.TabIndex = 71
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "Juni"
        '
        'txtMay
        '
        Me.txtMay.Location = New System.Drawing.Point(78, 160)
        Me.txtMay.Name = "txtMay"
        Me.txtMay.ReadOnly = True
        Me.txtMay.Size = New System.Drawing.Size(82, 20)
        Me.txtMay.TabIndex = 69
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 13)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Mai"
        '
        'txtApril
        '
        Me.txtApril.Location = New System.Drawing.Point(78, 134)
        Me.txtApril.Name = "txtApril"
        Me.txtApril.ReadOnly = True
        Me.txtApril.Size = New System.Drawing.Size(82, 20)
        Me.txtApril.TabIndex = 67
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "April"
        '
        'txtMars
        '
        Me.txtMars.Location = New System.Drawing.Point(78, 108)
        Me.txtMars.Name = "txtMars"
        Me.txtMars.ReadOnly = True
        Me.txtMars.Size = New System.Drawing.Size(82, 20)
        Me.txtMars.TabIndex = 65
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Mars"
        '
        'txtFebruary
        '
        Me.txtFebruary.Location = New System.Drawing.Point(78, 82)
        Me.txtFebruary.Name = "txtFebruary"
        Me.txtFebruary.ReadOnly = True
        Me.txtFebruary.Size = New System.Drawing.Size(82, 20)
        Me.txtFebruary.TabIndex = 63
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Februar"
        '
        'txtJanuary
        '
        Me.txtJanuary.Location = New System.Drawing.Point(78, 56)
        Me.txtJanuary.Name = "txtJanuary"
        Me.txtJanuary.ReadOnly = True
        Me.txtJanuary.Size = New System.Drawing.Size(82, 20)
        Me.txtJanuary.TabIndex = 61
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Januar"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(103, 15)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowUpDown = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(57, 20)
        Me.DateTimePicker1.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 17)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Omsetning"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(14, 48)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.ReadOnly = True
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.Size = New System.Drawing.Size(295, 326)
        Me.DataGridView1.TabIndex = 60
        '
        'statisticsView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "statisticsView"
        Me.Text = "statisticsView"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label30 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAverage As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtDecember As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtNovember As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtOctober As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtSeptember As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtAugust As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtJuly As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtJune As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMay As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtApril As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMars As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFebruary As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtJanuary As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRefresh As Button
    Protected WithEvents DataGridView1 As DataGridView
End Class
