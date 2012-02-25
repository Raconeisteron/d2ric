Public Class ExportClass

    Public Sub CopyToClipboard()
        Clipboard.Clear()
        If FormMain.TextBox3.Text <> "" Then
            Clipboard.SetText(FormMain.TextBox3.Text)
        End If
    End Sub

    Public Sub SavingToTextfile()
        Using SaveFileDialog1 As SaveFileDialog = New SaveFileDialog
            SaveFileDialog1.Filter = "txt(*.txt)| *.txt"
            SaveFileDialog1.ShowDialog()
            If SaveFileDialog1.FileName <> "" Then
                FileOpen(1, SaveFileDialog1.FileName, OpenMode.Output)
                PrintLine(1, FormMain.TextBox3.Text)
                FileClose(1)
                MessageBox.Show("File saved.")
            End If
        End Using
    End Sub
End Class
