Public Class OptionsClass
    Friend WithEvents Itembuild As New ItembuildClass

    Public Sub ChangeSteamPath()
        Using FolderBrowserDialog1 As FolderBrowserDialog = New FolderBrowserDialog
            If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                FormMain.TextBox4.Text = FolderBrowserDialog1.SelectedPath
            End If
            Dim steam_path, path As String
            steam_path = FormMain.TextBox4.Text
            If My.Settings.client = "Release Client" Then
                path = steam_path + "\SteamApps\common\dota 2\dota\itembuilds"
            ElseIf My.Settings.client = "Test Client" Then
                path = steam_path + "\SteamApps\common\dota 2 test\dota\itembuilds"
            Else
                path = steam_path + "\SteamApps\common\dota 2 beta\dota\itembuilds"
            End If

            If My.Computer.FileSystem.DirectoryExists(path) Then
                ' existiert
                My.Settings.path = path
                My.Settings.Save()
                MessageBox.Show("Path changed successfully.")
            Else
                ' existiert nicht
                MessageBox.Show("Please check your Steam path!!!")
            End If
        End Using
    End Sub

    Public Sub ChangeClient()
        Dim steam_path, path As String
        steam_path = FormMain.TextBox4.Text
        If FormMain.ComboBoxClient.Text = "Release Client" Then
            path = steam_path + "\SteamApps\common\dota 2\dota\itembuilds"
        ElseIf FormMain.ComboBoxClient.Text = "Test Client" Then
            path = steam_path + "\SteamApps\common\dota 2 test\dota\itembuilds"
        Else
            path = steam_path + "\SteamApps\common\dota 2 beta\dota\itembuilds"
        End If

        If My.Computer.FileSystem.DirectoryExists(path) Then
            ' existiert
            My.Settings.client = FormMain.ComboBoxClient.Text
            My.Settings.path = path
            My.Settings.Save()
            Itembuild.ClearSingle()
            FormMain.ListBox1.ClearSelected()
        Else
            ' existiert nicht
            MessageBox.Show("Client not found.")
            FormMain.ComboBoxClient.Text = My.Settings.client
        End If
    End Sub

    Private Function cut_file(ByVal file As String) As String ' Funktion zum Entfernen der Backslashs / Ordner
        While file.Contains("\")
            file = file.Remove(0, 1)
        End While
        Return file
    End Function

    Public Sub Backup()
        If Not IO.Directory.Exists(My.Settings.path & "\Backup") Then
            ' Nein! Jetzt erstellen...
            Try
                IO.Directory.CreateDirectory(My.Settings.path & "\Backup")
                ' Ordner wurde korrekt erstellt!
            Catch ex As Exception
                ' Ordner wurde nich erstellt
                MessageBox.Show("Error while creating folder")
            End Try
        End If
        If IO.Directory.Exists(My.Settings.path & "\Backup") Then
            For Each file As String In IO.Directory.GetFiles(My.Settings.path) ' Ermittelt alle Dateien des Ordners
                IO.File.Copy(file, My.Settings.path & "\Backup\" & System.DateTime.Now.Year.ToString & "-" & System.DateTime.Now.Month.ToString & "-" & System.DateTime.Now.Day.ToString & "_" & Replace(cut_file(file), "default_", ""), True)  ' Kopiert die Dateien
            Next
        End If
    End Sub

    Public Sub DeleteBackup()
        If MessageBox.Show("Delete backups?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If IO.Directory.Exists(My.Settings.path & "\Backup") Then
                For Each file As String In IO.Directory.GetFiles(My.Settings.path & "\Backup") ' Ermittelt alle Dateien des Ordners
                    If Not file.Contains("default") Then
                        IO.File.Delete(file)  ' Löscht die Dateien
                    End If
                Next
            End If
        Else
            'code wenn man auf nein drückt
        End If
    End Sub

    Public Sub OpenBackup()
        If IO.Directory.Exists(My.Settings.path & "\Backup") Then
            System.Diagnostics.Process.Start("explorer", My.Settings.path + "\Backup")
        Else
            MessageBox.Show("Backup folder doesn't exist.")
        End If
    End Sub

    Public Sub ChangeItemIcons()
        Itembuild.InitializeListbox()
        Itembuild.ClearSingle()
        FormMain.ListBox1.ClearSelected()
        My.Settings.item_icons = FormMain.ComboBoxItemIcons.Text
        My.Settings.Save()
    End Sub
End Class
