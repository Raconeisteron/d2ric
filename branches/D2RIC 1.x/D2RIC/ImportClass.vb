Public Class ImportClass
    Friend WithEvents Itembuild As New ItembuildClass

    Public Sub Import()
        If FormMain.TextBox2.Text <> "" Then
            IO.File.WriteAllText(My.Settings.path + "\temp.txt", FormMain.TextBox2.Text)
            If IO.File.Exists(My.Settings.path + "\temp.txt") Then
                Dim DeinPfad As String = My.Settings.path + "\temp.txt"
                Dim ItemPlace As String = "Starting Items"
                Dim i As Integer = 1
                Dim pb As Object
                Itembuild.ClearSingle()
                FormMain.ListBox1.SelectedItems.Clear()
                ItembuildClass.Selected_Hero = ""
                For Each Zeile As String In IO.File.ReadAllLines(DeinPfad)
                    If Zeile.Contains("item_") And i <= 39 Then
                        pb = FormMain.TabPage1.Controls.Item("Item" & i)
                        pb.image = FormMain.ChangePicture(FormMain.RenameItem(Zeile))
                        i = i + 1
                    ElseIf Zeile.Contains("Early_Game") Then
                        ItemPlace = "Early Game"
                        i = 10
                    ElseIf Zeile.Contains("Core_Items") Then
                        ItemPlace = "Core Items"
                        i = 19
                    ElseIf Zeile.Contains("Luxury") Then
                        ItemPlace = "Luxury"
                        i = 28
                    ElseIf Zeile.Contains("author") Then
                        FormMain.TextBox1.Text = Replace(Zeile, """", "")
                        FormMain.TextBox1.Text = Replace(FormMain.TextBox1.Text, "author", "")
                        FormMain.TextBox1.Text = Replace(FormMain.TextBox1.Text, vbTab, "")
                    ElseIf Zeile.Contains("hero") Then
                        ItembuildClass.Selected_Hero = Replace(Zeile, """hero""", "")
                        ItembuildClass.Selected_Hero = Replace(ItembuildClass.Selected_Hero, """", "")
                        ItembuildClass.Selected_Hero = Replace(ItembuildClass.Selected_Hero, vbTab, "")
                        ItembuildClass.Selected_Hero = Itembuild.renameHero(ItembuildClass.Selected_Hero)
                        FormMain.Label1.Text = ItembuildClass.Selected_Hero
                        If ItembuildClass.Selected_Hero <> "Unknown hero!" Then
                            FormMain.ListBox1.SelectedItem = ItembuildClass.Selected_Hero
                        End If
                        FormMain.ButtonSave.Enabled = True
                    Else

                    End If
                Next
                IO.File.Delete(My.Settings.path + "\temp.txt")
                FormMain.TabControl1.SelectedTab = FormMain.TabPage1
            Else
                MessageBox.Show("Error! Hero maybe not implemented yet.")
            End If
        End If
    End Sub

    Public Sub OpenFile()
        Using OpenFileDialog1 As OpenFileDialog = New OpenFileDialog
            OpenFileDialog1.Filter = "txt(*.txt)| *.txt"
            OpenFileDialog1.ShowDialog()
            If OpenFileDialog1.FileName <> "" Then
                If IO.File.Exists(OpenFileDialog1.FileName) Then
                    FormMain.TextBox2.Text = IO.File.ReadAllText(OpenFileDialog1.FileName)
                Else
                    MessageBox.Show("Error while reading.")
                End If
            Else
                FormMain.TextBox2.Text = "Error!"
            End If
        End Using
    End Sub
End Class
