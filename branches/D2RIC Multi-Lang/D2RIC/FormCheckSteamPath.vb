Imports System.Globalization, System.Threading, System.Resources

Public Class FormCheckSteamPath
    ' Declare a Resource Manager instance.
    Dim LocRM As New ResourceManager("D2RIC.Resources", GetType(FormCheckSteamPath).Assembly)

    Public Sub New()
        ' Sets the UI culture to the choosen language
        If My.Settings.lang <> "" Then
            Thread.CurrentThread.CurrentUICulture = New CultureInfo(My.Settings.lang)
        Else
            Thread.CurrentThread.CurrentUICulture = New CultureInfo("en")
        End If

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()
        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
    End Sub

    Private Sub FormCheckSteamPath_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (My.Settings.path <> "") Then
            TextBox1.Text = Microsoft.VisualBasic.Left(My.Settings.path, My.Settings.path.IndexOf("\SteamApps"))
            If My.Computer.FileSystem.DirectoryExists(My.Settings.path) Then
                FormMain.Visible = True
                Me.Close()
            Else
                MessageBox.Show(LocRM.GetString("checkPath"))
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim steam_path, path As String
        steam_path = TextBox1.Text
        If My.Settings.client = "Release Client" Then
            path = steam_path + "\SteamApps\common\dota 2\dota\itembuilds"
        ElseIf My.Settings.client = "Test Client" Then
            path = steam_path + "\SteamApps\common\dota 2 test\dota\itembuilds"
        Else
            path = steam_path + "\SteamApps\common\dota 2 beta\dota\itembuilds"
        End If
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
            MessageBox.Show(LocRM.GetString("checkPath"))
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
