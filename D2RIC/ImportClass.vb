Imports System.Resources

'This class contains all methods you need on the import page
Public Class ImportClass
    Friend WithEvents Itembuild As New ItembuildClass
    Dim LocRM As New ResourceManager("D2RIC.Resources", GetType(FormMain).Assembly)

    'Import the itembuild out of textbox2 and switch to the itembuild tab
    Public Sub Import()
        If FormMain.TextBox2.Text <> "" Then
            IO.File.WriteAllText(My.Settings.path + "\temp.txt", FormMain.TextBox2.Text)
            If IO.File.Exists(My.Settings.path + "\temp.txt") Then
                Dim Path As String = My.Settings.path + "\temp.txt"
                Dim ItemName As String
                Dim ItemList As Object = FormMain.ListView2
                Dim Index As Integer = 0
                Dim price As Object = FormMain.Label15
                Dim savePrice As Boolean = True
                Dim int As Integer
                Itembuild.Clear()
                FormMain.ListBox1.SelectedItems.Clear()
                ItembuildClass.Selected_Hero = ""
                For Each Zeile As String In IO.File.ReadAllLines(Path)
                    If Zeile.Contains("item_") Then
                        ItemName = FormMain.RenameItem(Zeile)
                        If savePrice Then
                            int = (CInt(price.Text) + Itembuild.GetPrice(ItemName))
                            price.Text = int.ToString
                            FormMain.CheckCosts(int)
                        End If
                        With ItemList
                            Dim item As New ListViewItem(New String() {"", ItemName}, FormMain.GetPicture(ItemName))
                            .Items.AddRange(New ListViewItem() {item})
                            .Items(Index).ToolTipText = Itembuild.GetToolTip(ItemName)
                        End With
                        Index = Index + 1
                    ElseIf Zeile.Contains("Early_Game") Then
                        ItemList = FormMain.ListView3
                        Index = 0
                        savePrice = False
                    ElseIf Zeile.Contains("Core_Items") Then
                        ItemList = FormMain.ListView4
                        Index = 0
                        savePrice = False
                    ElseIf Zeile.Contains("Luxury") Then
                        ItemList = FormMain.ListView5
                        Index = 0
                        savePrice = False
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
                            FormMain.ImportHero = True
                            FormMain.ListBox1.SelectedItem = ItembuildClass.Selected_Hero
                            FormMain.ButtonSave.Enabled = True
                        End If
                    End If
                Next
                IO.File.Delete(My.Settings.path + "\temp.txt")
                FormMain.TabControl1.SelectedTab = FormMain.TabPage1
            Else
                MessageBox.Show(LocRM.GetString("cantLoadItembuild"))
            End If
        End If
    End Sub

    'Open a textfile and write to textbox2
    Public Sub OpenFile()
        Using OpenFileDialog1 As OpenFileDialog = New OpenFileDialog
            OpenFileDialog1.Filter = "txt(*.txt)| *.txt"
            OpenFileDialog1.ShowDialog()
            If OpenFileDialog1.FileName <> "" Then
                If IO.File.Exists(OpenFileDialog1.FileName) Then
                    FormMain.TextBox2.Text = IO.File.ReadAllText(OpenFileDialog1.FileName)
                Else
                    MessageBox.Show(LocRM.GetString("cantRead"))
                End If
            Else
                FormMain.TextBox2.Text = "Error!"
            End If
        End Using
    End Sub
End Class
