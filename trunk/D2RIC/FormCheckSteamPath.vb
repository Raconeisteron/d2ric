Public Class FormCheckSteamPath

    Private Sub FormCheckSteamPath_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (My.Settings.path <> "") Then
            TextBox1.Text = Replace(My.Settings.path, "\SteamApps\common\dota 2 beta\dota\itembuilds", "")
            If My.Computer.FileSystem.DirectoryExists(My.Settings.path) Then
                FormMain.Visible = True
                Me.Close()
            Else
                MsgBox("Please check your Steam path!!!")
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim steam_path, path As String
        steam_path = TextBox1.Text
        path = steam_path + "\SteamApps\common\dota 2 beta\dota\itembuilds"
        Check(path)
    End Sub

    Private Sub Check(ByVal dota_path As String)
        If My.Computer.FileSystem.DirectoryExists(dota_path) Then
            ' existiert
            My.Settings.path = dota_path
            My.Settings.Save()
            FormMain.Visible = True
            Me.Close()
        Else
            ' existiert nicht
            MsgBox("Please check your Steam path!!!")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Using FolderBrowserDialog1 As FolderBrowserDialog = New FolderBrowserDialog
            If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                TextBox1.Text = FolderBrowserDialog1.SelectedPath
            End If
        End Using
    End Sub
End Class
