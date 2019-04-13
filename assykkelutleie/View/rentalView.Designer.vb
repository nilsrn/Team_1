<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rentalView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rentalView))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbrental = New System.Windows.Forms.ListBox()
        Me.addrentalbtn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pickequipment = New System.Windows.Forms.ComboBox()
        Me.pickbike = New System.Windows.Forms.ComboBox()
        Me.Kunde = New System.Windows.Forms.GroupBox()
        Me.mailtxt = New System.Windows.Forms.TextBox()
        Me.surnametxt = New System.Windows.Forms.TextBox()
        Me.firstnametxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.extradition = New System.Windows.Forms.ComboBox()
        Me.filing = New System.Windows.Forms.ComboBox()
        Me.rentalcomplete = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Kunde.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(617, 426)
        Me.TabControl1.TabIndex = 12
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.rentalcomplete)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.Kunde)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(609, 400)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ny bestilling"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.filing)
        Me.GroupBox3.Controls.Add(Me.extradition)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(408, 15)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(195, 317)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Utlevering og innlevering"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(99, 37)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(88, 20)
        Me.DateTimePicker2.TabIndex = 6
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(9, 37)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(84, 20)
        Me.DateTimePicker1.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(96, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Innlevering:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Utlevering:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbrental)
        Me.GroupBox2.Controls.Add(Me.addrentalbtn)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.pickequipment)
        Me.GroupBox2.Controls.Add(Me.pickbike)
        Me.GroupBox2.Location = New System.Drawing.Point(204, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(198, 317)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sykkel og utstyr"
        '
        'lbrental
        '
        Me.lbrental.FormattingEnabled = True
        Me.lbrental.Location = New System.Drawing.Point(7, 118)
        Me.lbrental.Name = "lbrental"
        Me.lbrental.Size = New System.Drawing.Size(185, 160)
        Me.lbrental.TabIndex = 5
        '
        'addrentalbtn
        '
        Me.addrentalbtn.Location = New System.Drawing.Point(7, 75)
        Me.addrentalbtn.Name = "addrentalbtn"
        Me.addrentalbtn.Size = New System.Drawing.Size(185, 36)
        Me.addrentalbtn.TabIndex = 4
        Me.addrentalbtn.Text = "Legg til bestilling"
        Me.addrentalbtn.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(103, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Velg utstyr:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Velg sykkel:"
        '
        'pickequipment
        '
        Me.pickequipment.FormattingEnabled = True
        Me.pickequipment.Items.AddRange(New Object() {"Sykkelveske", "Barnehenger", "Lastehenger"})
        Me.pickequipment.Location = New System.Drawing.Point(106, 37)
        Me.pickequipment.Name = "pickequipment"
        Me.pickequipment.Size = New System.Drawing.Size(86, 21)
        Me.pickequipment.TabIndex = 1
        '
        'pickbike
        '
        Me.pickbike.FormattingEnabled = True
        Me.pickbike.Items.AddRange(New Object() {"Terreng", "Tandem", "Racer", "Downhill", "Barnesykkel", ""})
        Me.pickbike.Location = New System.Drawing.Point(7, 37)
        Me.pickbike.Name = "pickbike"
        Me.pickbike.Size = New System.Drawing.Size(86, 21)
        Me.pickbike.TabIndex = 0
        '
        'Kunde
        '
        Me.Kunde.Controls.Add(Me.mailtxt)
        Me.Kunde.Controls.Add(Me.surnametxt)
        Me.Kunde.Controls.Add(Me.firstnametxt)
        Me.Kunde.Controls.Add(Me.Label4)
        Me.Kunde.Controls.Add(Me.Label3)
        Me.Kunde.Controls.Add(Me.Label2)
        Me.Kunde.Controls.Add(Me.btnSearch)
        Me.Kunde.Controls.Add(Me.TextBox1)
        Me.Kunde.Controls.Add(Me.Label1)
        Me.Kunde.Location = New System.Drawing.Point(6, 15)
        Me.Kunde.Name = "Kunde"
        Me.Kunde.Size = New System.Drawing.Size(196, 317)
        Me.Kunde.TabIndex = 0
        Me.Kunde.TabStop = False
        Me.Kunde.Text = "Kunde"
        '
        'mailtxt
        '
        Me.mailtxt.Location = New System.Drawing.Point(83, 185)
        Me.mailtxt.Name = "mailtxt"
        Me.mailtxt.Size = New System.Drawing.Size(100, 20)
        Me.mailtxt.TabIndex = 8
        '
        'surnametxt
        '
        Me.surnametxt.Location = New System.Drawing.Point(83, 147)
        Me.surnametxt.Name = "surnametxt"
        Me.surnametxt.Size = New System.Drawing.Size(100, 20)
        Me.surnametxt.TabIndex = 7
        '
        'firstnametxt
        '
        Me.firstnametxt.Location = New System.Drawing.Point(83, 109)
        Me.firstnametxt.Name = "firstnametxt"
        Me.firstnametxt.Size = New System.Drawing.Size(100, 20)
        Me.firstnametxt.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "E-post"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Etternavn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fornavn"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(117, 33)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Søk"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(10, 37)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Telefonnummer:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.TextBox2)
        Me.TabPage2.Controls.Add(Me.ListBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(609, 400)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Bestillingsoversikt"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(609, 400)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Statistikk"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Velg sted:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(96, 87)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Velg sted:"
        '
        'extradition
        '
        Me.extradition.FormattingEnabled = True
        Me.extradition.Items.AddRange(New Object() {"Haugastøl", "Finse", "Flåm", "Myrdal", "Voss"})
        Me.extradition.Location = New System.Drawing.Point(9, 106)
        Me.extradition.Name = "extradition"
        Me.extradition.Size = New System.Drawing.Size(86, 21)
        Me.extradition.TabIndex = 9
        '
        'filing
        '
        Me.filing.FormattingEnabled = True
        Me.filing.Items.AddRange(New Object() {"Haugastøl", "Finse", "Flåm", "Myrdal", "Voss"})
        Me.filing.Location = New System.Drawing.Point(99, 106)
        Me.filing.Name = "filing"
        Me.filing.Size = New System.Drawing.Size(86, 21)
        Me.filing.TabIndex = 10
        '
        'rentalcomplete
        '
        Me.rentalcomplete.Location = New System.Drawing.Point(148, 339)
        Me.rentalcomplete.Name = "rentalcomplete"
        Me.rentalcomplete.Size = New System.Drawing.Size(320, 55)
        Me.rentalcomplete.TabIndex = 3
        Me.rentalcomplete.Text = "Fullfør bestilling"
        Me.rentalcomplete.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(7, 55)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(596, 342)
        Me.ListBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(350, 19)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(123, 20)
        Me.TextBox2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(479, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Søk"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rentalView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "rentalView"
        Me.Text = "rental"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Kunde.ResumeLayout(False)
        Me.Kunde.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbrental As ListBox
    Friend WithEvents addrentalbtn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents pickequipment As ComboBox
    Friend WithEvents pickbike As ComboBox
    Friend WithEvents Kunde As GroupBox
    Friend WithEvents mailtxt As TextBox
    Friend WithEvents surnametxt As TextBox
    Friend WithEvents firstnametxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents filing As ComboBox
    Friend WithEvents extradition As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents rentalcomplete As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ListBox1 As ListBox
End Class
