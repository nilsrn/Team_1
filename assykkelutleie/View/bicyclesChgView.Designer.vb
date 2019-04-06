<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bicyclesChgView
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
        Dim TypeCmb As System.Windows.Forms.ComboBox
        Me.bicycleRegister = New System.Windows.Forms.Button()
        Me.gearCmb = New System.Windows.Forms.ComboBox()
        Me.wheelCmb = New System.Windows.Forms.ComboBox()
        Me.FramenbrTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        TypeCmb = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'TypeCmb
        '
        TypeCmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        TypeCmb.FormattingEnabled = True
        TypeCmb.Items.AddRange(New Object() {"Terrengsykkel", "Downhill", "Racer", "Barnesykkel"})
        TypeCmb.Location = New System.Drawing.Point(14, 51)
        TypeCmb.Name = "TypeCmb"
        TypeCmb.Size = New System.Drawing.Size(121, 21)
        TypeCmb.TabIndex = 26
        TypeCmb.Text = "Sykkeltype"
        '
        'bicycleRegister
        '
        Me.bicycleRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bicycleRegister.Location = New System.Drawing.Point(14, 107)
        Me.bicycleRegister.Name = "bicycleRegister"
        Me.bicycleRegister.Size = New System.Drawing.Size(375, 44)
        Me.bicycleRegister.TabIndex = 29
        Me.bicycleRegister.Text = "Oppdater sykkel"
        Me.bicycleRegister.UseVisualStyleBackColor = True
        '
        'gearCmb
        '
        Me.gearCmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.gearCmb.FormattingEnabled = True
        Me.gearCmb.Items.AddRange(New Object() {"Shimono", "SRAM"})
        Me.gearCmb.Location = New System.Drawing.Point(268, 51)
        Me.gearCmb.Name = "gearCmb"
        Me.gearCmb.Size = New System.Drawing.Size(121, 21)
        Me.gearCmb.TabIndex = 28
        Me.gearCmb.Text = "Girsystem"
        '
        'wheelCmb
        '
        Me.wheelCmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.wheelCmb.FormattingEnabled = True
        Me.wheelCmb.Items.AddRange(New Object() {"26""", "27,5""", "29"""})
        Me.wheelCmb.Location = New System.Drawing.Point(141, 51)
        Me.wheelCmb.Name = "wheelCmb"
        Me.wheelCmb.Size = New System.Drawing.Size(121, 21)
        Me.wheelCmb.TabIndex = 27
        Me.wheelCmb.Text = "Hjulstørrelse"
        '
        'FramenbrTxt
        '
        Me.FramenbrTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FramenbrTxt.Location = New System.Drawing.Point(141, 14)
        Me.FramenbrTxt.Name = "FramenbrTxt"
        Me.FramenbrTxt.Size = New System.Drawing.Size(248, 20)
        Me.FramenbrTxt.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(11, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Rammenummer :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline)
        Me.Label1.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label1.Location = New System.Drawing.Point(416, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Tilstand"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline)
        Me.Label3.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label3.Location = New System.Drawing.Point(416, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Status"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(419, 33)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(55, 17)
        Me.CheckBox1.TabIndex = 32
        Me.CheckBox1.Text = "Stjålet"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(419, 88)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(51, 17)
        Me.RadioButton1.TabIndex = 33
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Ledig"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(419, 111)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(52, 17)
        Me.RadioButton2.TabIndex = 34
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Utleid"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(419, 134)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(61, 17)
        Me.RadioButton3.TabIndex = 35
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Service"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'bicyclesChgView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 166)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bicycleRegister)
        Me.Controls.Add(Me.gearCmb)
        Me.Controls.Add(Me.wheelCmb)
        Me.Controls.Add(TypeCmb)
        Me.Controls.Add(Me.FramenbrTxt)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "bicyclesChgView"
        Me.Text = "bicyclesChgView"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bicycleRegister As Button
    Friend WithEvents gearCmb As ComboBox
    Friend WithEvents wheelCmb As ComboBox
    Friend WithEvents FramenbrTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
End Class
