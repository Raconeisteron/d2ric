Public Class Form3
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (My.Settings.clipboard <> "") Then
            TextBox1.Text = My.Settings.clipboard
        Else
            TextBox1.Text = "Error!"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Clipboard.Clear()
        Clipboard.SetText(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Dim SaveFileDialog1 As SaveFileDialog = New SaveFileDialog
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        SaveFileDialog1.Filter = "txt(*.txt)| *.txt"
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName <> "" Then
            FileOpen(1, SaveFileDialog1.FileName, OpenMode.Output)
            PrintLine(1, TextBox1.Text)
            FileClose(1)
            MsgBox("File saved.")
        End If
        Me.Close()
    End Sub
End Class