Public Module CustomMessageBox
    Private result As String
    Public Function Show(options As IEnumerable(Of String), Optional message As String = "", Optional title As String = "") As String
        result = ""
        Dim myForm As New Form With {.Text = title}
        Dim tlp As New TableLayoutPanel With {.ColumnCount = 1, .RowCount = 2}
        Dim flp As New FlowLayoutPanel()
        Dim l As New Label With {.Text = message}
        myForm.Controls.Add(tlp)
        tlp.Dock = DockStyle.Fill
        tlp.Controls.Add(l)
        l.Dock = DockStyle.Fill
        tlp.Controls.Add(flp)
        flp.Dock = DockStyle.Fill
        For Each o In options
            Dim b As New Button With {.Text = o}
            flp.Controls.Add(b)
            AddHandler b.Click,
                Sub(sender As Object, e As EventArgs)
                    result = DirectCast(sender, Button).Text
                    myForm.Close()
                End Sub
        Next
        myForm.FormBorderStyle = FormBorderStyle.FixedToolWindow
        myForm.Height = 100
        myForm.ShowDialog()
        Return result
    End Function
End Module
