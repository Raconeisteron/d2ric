Imports System.Security.Cryptography, System.Net, vb = Microsoft.VisualBasic

Public Class FormMain
    Dim FirstChange As Boolean = True
    Friend WithEvents Import As New ImportClass
    Friend WithEvents Export As New ExportClass
    Friend WithEvents Options As New OptionsClass
    Friend WithEvents Itembuild As New ItembuildClass
    Private WithEvents WebClient1 As New WebClient
    Dim cursor_image As Icon
    Dim Selected_Item As String
    Public IntPrice As Integer
    Dim Unsaved As Boolean = False
    Public ImportHero As Boolean = False

    Private Sub FormMain_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.Save()
        End
    End Sub

    Private Sub FormMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Itembuild.Initialize()
        Itembuild.InitializeListbox()

        Me.ListView2.AllowDrop = True
        Me.ListView3.AllowDrop = True
        Me.ListView4.AllowDrop = True
        Me.ListView5.AllowDrop = True

        If Not My.Settings.autoupdate Then
            CheckBox1.Checked = False
        Else
            CheckBox1.Checked = True
            LabelWait.Visible = True
            BackgroundWorker1.RunWorkerAsync()
        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If Unsaved = True Then
            If MessageBox.Show("You have unsaved changes!" + vbNewLine + "Do you want to continue?", "Unsaved changes", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                If ListBox1.SelectedItem <> "" Then
                    If ImportHero Then
                        ImportHero = False
                    Else
                        Itembuild.CheckHero(ListBox1.SelectedItem.ToString)
                        Itembuild.Clear()
                        Label1.Text = ListBox1.SelectedItem.ToString
                        Itembuild.CheckFile(ItembuildClass.Selected_Hero)
                        Unsaved = False
                    End If
                End If
            End If
        Else
            If ListBox1.SelectedItem <> "" Then
                If ImportHero Then
                    ImportHero = False
                Else
                    Itembuild.CheckHero(ListBox1.SelectedItem.ToString)
                    Itembuild.Clear()
                    Label1.Text = ListBox1.SelectedItem.ToString
                    Itembuild.CheckFile(ItembuildClass.Selected_Hero)
                End If
            End If
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab Is TabPage4 Then
            TextBox3.Text = "Please choose a hero first."
            If (ItembuildClass.Selected_Hero <> "") Then
                Itembuild.SaveChanges()
                Itembuild.ChangeAuthor(TextBox1.Text, ItembuildClass.Selected_Hero)
                My.Settings.clipboard = Itembuild.NewText
                If (My.Settings.clipboard <> "") Then
                    TextBox3.Text = My.Settings.clipboard
                Else
                    TextBox3.Text = "Error!"
                End If
            End If
        ElseIf TabControl1.SelectedTab Is TabPage5 Then
            If (My.Settings.path <> "") Then
                TextBox4.Text = Microsoft.VisualBasic.Left(My.Settings.path, My.Settings.path.IndexOf("\SteamApps"))
            End If
            If My.Settings.client = "Release Client" Then
                ComboBoxClient.Text = "Release Client"
            ElseIf My.Settings.client = "Test Client" Then
                ComboBoxClient.Text = "Test Client"
            Else
                ComboBoxClient.Text = "Beta Client"
            End If
        ElseIf TabControl1.SelectedTab Is TabPage3 Then
            'Focus on TextBox2
            TextBox2.Select()
        End If
    End Sub

    Private Sub Check4Update()
        Dim pgversion As String = Application.ProductVersion
        If pgversion.Substring(pgversion.Length - 1) = "0" Then
            pgversion = pgversion.Substring(0, pgversion.Length - 2)
        End If
        Dim aktversion As String = WebClient1.DownloadString("http://holyzone.bplaced.net/maddy/d2ric_version.txt")

        If pgversion < aktversion Then 'Wenn die Programmversion kleiner als die Aktuelle Version ist:
            If MessageBox.Show("New Update available!!" + vbNewLine + vbNewLine + "Your Version: " + pgversion + vbNewLine + "New Version: " + aktversion + vbNewLine + vbNewLine + "Open the Download page?", "Update", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Process.Start("http://code.google.com/p/d2ric/downloads/list")
            End If
        Else
            'Nothing
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If Not FirstChange Then
            If CheckBox1.Checked Then
                My.Settings.autoupdate = True
            Else
                My.Settings.autoupdate = False
            End If
        Else
            FirstChange = False
        End If
    End Sub

    Private Sub ButtonUpdate_Click(sender As System.Object, e As System.EventArgs) Handles ButtonUpdate.Click
        LabelWait.Visible = True
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub ButtonOpenFolder_Click(sender As System.Object, e As System.EventArgs) Handles ButtonOpenFolder.Click
        System.Diagnostics.Process.Start("explorer", My.Settings.path)
    End Sub

    Private Sub ButtonSave_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSave.Click
        Unsaved = False
        Itembuild.Save()
    End Sub

    Private Sub ButtonBackup_Click(sender As System.Object, e As System.EventArgs) Handles ButtonBackup.Click
        Options.Backup()
    End Sub

    Private Sub ButtonDeleteBackup_Click(sender As System.Object, e As System.EventArgs) Handles ButtonDeleteBackup.Click
        Options.DeleteBackup()
    End Sub

    Private Sub ButtonOpenTextfile_Click(sender As System.Object, e As System.EventArgs) Handles ButtonOpenTextfile.Click
        Import.OpenFile()
    End Sub

    Private Sub ButtonImport_Click(sender As System.Object, e As System.EventArgs) Handles ButtonImport.Click
        Import.Import()
    End Sub

    Private Sub ButtonCopy_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCopy.Click
        Export.CopyToClipboard()
    End Sub

    Private Sub ButtonSaveTextfile_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSaveTextfile.Click
        Export.SavingToTextfile()
    End Sub

    Private Sub ButtonChangeSteam_Click(sender As System.Object, e As System.EventArgs) Handles ButtonChangeSteam.Click
        Options.ChangeSteamPath()
    End Sub

    Private Sub ComboBoxClient_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxClient.SelectedIndexChanged
        Options.ChangeClient()
    End Sub

    Private Sub ButtonOpenBackupFolder_Click(sender As System.Object, e As System.EventArgs) Handles ButtonOpenBackupFolder.Click
        Options.OpenBackup()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Check4Update()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As System.Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        LabelWait.Visible = False
    End Sub

    'CHANGE THE HEROS SHOWN IN THE LIST
    Private Sub ComboBox3_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        Itembuild.ChangeHeroList(ComboBox3, ListBox1)
        If CheckBox2.Checked Then
            Itembuild.ClearNotImplemented()
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        Itembuild.ChangeHeroList(ComboBox3, ListBox1)
        If CheckBox2.Checked Then
            Itembuild.ClearNotImplemented()
        End If
    End Sub

    Private Sub ButtonDefaultItembuild_Click(sender As System.Object, e As System.EventArgs) Handles ButtonDefaultItembuild.Click
        Itembuild.LoadDefault()
    End Sub

    Private Sub TextBoxItemsearch_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxItemsearch.TextChanged
        Timer1.Stop()
        Timer1.Start()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Timer2.Stop()
        Timer2.Start()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Timer3.Stop()
        Timer3.Start()
    End Sub

    Private Sub Searchitem(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick, Timer2.Tick, Timer3.Tick
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        Itembuild.InitializeListbox()
        For Each item As ListViewItem In ListView1.Items
            If Not item.Text.ToLower.Contains(TextBoxItemsearch.Text.ToLower) Then
                item.Remove()
            End If
        Next
        If ComboBox1.Text <> "" Then
            For Each item As ListViewItem In ListView1.Items
                If Not item.ToolTipText.ToLower.Contains(ComboBox1.Text.ToLower) Then
                    item.Remove()
                End If
            Next
        End If
        If ComboBox2.Text <> "All" Then
            For Each item As ListViewItem In ListView1.Items
                If Not item.SubItems(1).Text.ToLower.Contains(ComboBox2.Text.ToLower) Then
                    item.Remove()
                End If
            Next
        End If
    End Sub

    'Return the pictureID (ImageList1) for each Item
    Public Function GetPicture(ByVal item_name As String) As Integer
        Dim picID As Integer

        Select Case item_name
            Case "Abyssal Blade"
                picID = 0
                Return picID
            Case "Aghanim's Scepter"
                picID = 1
                Return picID
            Case "Animal Courier"
                picID = 2
                Return picID
            Case "Arcane Boots"
                picID = 3
                Return picID
            Case "Armlet"
                picID = 4
                Return picID
            Case "Assault Cuirass"
                picID = 5
                Return picID
            Case "Battle Fury"
                picID = 6
                Return picID
            Case "Belt of Strength"
                picID = 7
                Return picID
            Case "Black King Bar"
                picID = 8
                Return picID
            Case "Blade Mail"
                picID = 9
                Return picID
            Case "Blade of Alacrity"
                picID = 10
                Return picID
            Case "Blades of Attack"
                picID = 11
                Return picID
            Case "Blink Dagger"
                picID = 12
                Return picID
            Case "Bloodstone"
                picID = 13
                Return picID
            Case "Boots of Elvenskin"
                picID = 14
                Return picID
            Case "Boots of Speed"
                picID = 15
                Return picID
            Case "Boots of Travel"
                picID = 16
                Return picID
            Case "Bottle"
                picID = 17
                Return picID
            Case "Bracer"
                picID = 18
                Return picID
            Case "Broadsword"
                picID = 19
                Return picID
            Case "Buckler"
                picID = 20
                Return picID
            Case "Butterfly"
                picID = 21
                Return picID
            Case "Chainmail"
                picID = 22
                Return picID
            Case "Circlet"
                picID = 23
                Return picID
            Case "Clarity"
                picID = 24
                Return picID
            Case "Claymore"
                picID = 25
                Return picID
            Case "Cloak"
                picID = 26
                Return picID
            Case "Crystalys"
                picID = 27
                Return picID
            Case "Daedalus"
                picID = 28
                Return picID
            Case "Dagon 1"
                picID = 29
                Return picID
            Case "Dagon 2"
                picID = 30
                Return picID
            Case "Dagon 3"
                picID = 31
                Return picID
            Case "Dagon 4"
                picID = 32
                Return picID
            Case "Dagon 5"
                picID = 33
                Return picID
            Case "Demon Edge"
                picID = 34
                Return picID
            Case "Desolator"
                picID = 35
                Return picID
            Case "Diffusal Blade 1"
                picID = 36
                Return picID
            Case "Diffusal Blade 2"
                picID = 37
                Return picID
            Case "Divine Rapier"
                picID = 38
                Return picID
            Case "Drum of Endurance"
                picID = 39
                Return picID
            Case "Dust of Appearance"
                picID = 40
                Return picID
            Case "Eaglesong"
                picID = 41
                Return picID
            Case "Energy Booster"
                picID = 42
                Return picID
            Case "Ethereal Blade"
                picID = 43
                Return picID
            Case "Eul's Scepter of Divinity"
                picID = 44
                Return picID
            Case "Eye of Skadi"
                picID = 45
                Return picID
            Case "Flying Courier"
                picID = 46
                Return picID
            Case "Force Staff"
                picID = 47
                Return picID
            Case "Gauntlets of Strength"
                picID = 48
                Return picID
            Case "Gem of True Sight"
                picID = 49
                Return picID
            Case "Ghost Scepter"
                picID = 50
                Return picID
            Case "Gloves of Haste"
                picID = 51
                Return picID
            Case "Hand of Midas"
                picID = 52
                Return picID
            Case "Headdress"
                picID = 53
                Return picID
            Case "Healing Salve"
                picID = 54
                Return picID
            Case "Heart of Tarrasque"
                picID = 55
                Return picID
            Case "Heaven's Halberd"
                picID = 56
                Return picID
            Case "Helm of Iron Will"
                picID = 57
                Return picID
            Case "Helm of the Dominator"
                picID = 58
                Return picID
            Case "Hood of Defiance"
                picID = 59
                Return picID
            Case "Hyperstone"
                picID = 60
                Return picID
            Case "Iron Branch"
                picID = 61
                Return picID
            Case "Javelin"
                picID = 62
                Return picID
            Case "Linken's Sphere"
                picID = 63
                Return picID
            Case "Maelstrom"
                picID = 64
                Return picID
            Case "Magic Stick"
                picID = 65
                Return picID
            Case "Magic Wand"
                picID = 66
                Return picID
            Case "Manta Style"
                picID = 67
                Return picID
            Case "Mantle of Intelligence"
                picID = 68
                Return picID
            Case "Mask of Madness"
                picID = 69
                Return picID
            Case "Medallion of Courage"
                picID = 70
                Return picID
            Case "Mekansm"
                picID = 71
                Return picID
            Case "Mithril Hammer"
                picID = 72
                Return picID
            Case "Mjollnir"
                picID = 73
                Return picID
            Case "Monkey King Bar"
                picID = 74
                Return picID
            Case "Morbid Mask"
                picID = 75
                Return picID
            Case "Mystic Staff"
                picID = 76
                Return picID
            Case "Necronomicon 1"
                picID = 77
                Return picID
            Case "Necronomicon 2"
                picID = 78
                Return picID
            Case "Necronomicon 3"
                picID = 79
                Return picID
            Case "Null Talisman"
                picID = 80
                Return picID
            Case "Oblivion Staff"
                picID = 81
                Return picID
            Case "Observer Ward"
                picID = 82
                Return picID
            Case "Ogre Club"
                picID = 83
                Return picID
            Case "Orb of Venom"
                picID = 84
                Return picID
            Case "Orchid Malevolence"
                picID = 85
                Return picID
            Case "Perseverance"
                picID = 86
                Return picID
            Case "Phase Boots"
                picID = 87
                Return picID
            Case "Pipe of Insight"
                picID = 88
                Return picID
            Case "Platemail"
                picID = 89
                Return picID
            Case "Point Booster"
                picID = 90
                Return picID
            Case "Poor Man's Shield"
                picID = 91
                Return picID
            Case "Power Treads"
                picID = 92
                Return picID
            Case "Quarterstaff"
                picID = 93
                Return picID
            Case "Quelling Blade"
                picID = 94
                Return picID
            Case "Radiance"
                picID = 95
                Return picID
            Case "Reaver"
                picID = 96
                Return picID
            Case "Refresher Orb"
                picID = 97
                Return picID
            Case "Ring of Aquila"
                picID = 98
                Return picID
            Case "Ring of Basilius"
                picID = 99
                Return picID
            Case "Ring of Health"
                picID = 100
                Return picID
            Case "Ring of Protection"
                picID = 101
                Return picID
            Case "Ring of Regen"
                picID = 102
                Return picID
            Case "Robe of the Magi"
                picID = 103
                Return picID
            Case "Rod of Atos"
                picID = 104
                Return picID
            Case "Sacred Relic"
                picID = 105
                Return picID
            Case "Sage's Mask"
                picID = 106
                Return picID
            Case "Sange"
                picID = 107
                Return picID
            Case "Sange and Yasha"
                picID = 108
                Return picID
            Case "Satanic"
                picID = 109
                Return picID
            Case "Scythe of Vyse"
                picID = 110
                Return picID
            Case "Sentry Ward"
                picID = 111
                Return picID
            Case "Shadow Blade"
                picID = 112
                Return picID
            Case "Shiva's Guard"
                picID = 113
                Return picID
            Case "Skull Basher"
                picID = 114
                Return picID
            Case "Slippers of Agility"
                picID = 115
                Return picID
            Case "Smoke of Deceit"
                picID = 116
                Return picID
            Case "Soul Booster"
                picID = 117
                Return picID
            Case "Soul Ring"
                picID = 118
                Return picID
            Case "Staff of Wizardry"
                picID = 119
                Return picID
            Case "Stout Shield"
                picID = 120
                Return picID
            Case "Talisman of Evasion"
                picID = 121
                Return picID
            Case "Tango"
                picID = 122
                Return picID
            Case "Town Portal Scroll"
                picID = 123
                Return picID
            Case "Tranquil Boots"
                picID = 124
                Return picID
            Case "Ultimate Orb"
                picID = 125
                Return picID
            Case "Urn of Shadows"
                picID = 126
                Return picID
            Case "Vanguard"
                picID = 127
                Return picID
            Case "Veil of Discord"
                picID = 128
                Return picID
            Case "Vitality Booster"
                picID = 129
                Return picID
            Case "Vladmir's Offering"
                picID = 130
                Return picID
            Case "Void Stone"
                picID = 131
                Return picID
            Case "Wraith Band"
                picID = 132
                Return picID
            Case "Yasha"
                picID = 133
                Return picID
            Case Else
                Return -1
        End Select
    End Function

    'Changes color to red when the costs exceed 603, otherwise to blue
    Public Sub CheckCosts(ByVal price As Integer)
        If (price > 603) Then
            Label15.ForeColor = Color.Red
        Else
            Label15.ForeColor = Color.Black
        End If
    End Sub

    'Return the normal itemname, needs the itemname of the itembuild file
    Public Function RenameItem(ByVal item_name As String) As String
        Dim rename_item_name, item_name2 As String
        item_name2 = Replace(item_name, """", "")
        item_name2 = Replace(item_name2, vbTab, "")
        Select Case True
            Case item_name2 Like "*item_blink"
                rename_item_name = "Blink Dagger"
                Return rename_item_name
            Case item_name2 Like "*item_blades_of_attack"
                rename_item_name = "Blades of Attack"
                Return rename_item_name
            Case item_name2 Like "*item_basher"
                rename_item_name = "Skull Basher"
                Return rename_item_name
            Case item_name2 Like "*item_tango"
                rename_item_name = "Tango"
                Return rename_item_name
            Case item_name2 Like "*item_ancient_janggo"
                rename_item_name = "Drum of Endurance"
                Return rename_item_name
            Case item_name2 Like "*item_arcane_boots"
                rename_item_name = "Arcane Boots"
                Return rename_item_name
            Case item_name2 Like "*item_armlet"
                rename_item_name = "Armlet"
                Return rename_item_name
            Case item_name2 Like "*item_assault"
                rename_item_name = "Assault Cuirass"
                Return rename_item_name
            Case item_name2 Like "*item_bfury"
                rename_item_name = "Battle Fury"
                Return rename_item_name
            Case item_name2 Like "*item_belt_of_strength"
                rename_item_name = "Belt of Strength"
                Return rename_item_name
            Case item_name2 Like "*item_black_king_bar"
                rename_item_name = "Black King Bar"
                Return rename_item_name
            Case item_name2 Like "*item_blade_mail"
                rename_item_name = "Blade Mail"
                Return rename_item_name
            Case item_name2 Like "*item_blade_of_alacrity"
                rename_item_name = "Blade of Alacrity"
                Return rename_item_name
            Case item_name2 Like "*item_bloodstone"
                rename_item_name = "Bloodstone"
                Return rename_item_name
            Case item_name2 Like "*item_boots"
                rename_item_name = "Boots of Speed"
                Return rename_item_name
            Case item_name2 Like "*item_boots_of_elves"
                rename_item_name = "Boots of Elvenskin"
                Return rename_item_name
            Case item_name2 Like "*item_bottle"
                rename_item_name = "Bottle"
                Return rename_item_name
            Case item_name2 Like "*item_bracer"
                rename_item_name = "Bracer"
                Return rename_item_name
            Case item_name2 Like "*item_branches"
                rename_item_name = "Iron Branch"
                Return rename_item_name
            Case item_name2 Like "*item_broadsword"
                rename_item_name = "Broadsword"
                Return rename_item_name
            Case item_name2 Like "*item_buckler"
                rename_item_name = "Buckler"
                Return rename_item_name
            Case item_name2 Like "*item_butterfly"
                rename_item_name = "Butterfly"
                Return rename_item_name
            Case item_name2 Like "*item_chainmail"
                rename_item_name = "Chainmail"
                Return rename_item_name
            Case item_name2 Like "*item_circlet"
                rename_item_name = "Circlet"
                Return rename_item_name
            Case item_name2 Like "*item_clarity"
                rename_item_name = "Clarity"
                Return rename_item_name
            Case item_name2 Like "*item_claymore"
                rename_item_name = "Claymore"
                Return rename_item_name
            Case item_name2 Like "*item_cloak"
                rename_item_name = "Cloak"
                Return rename_item_name
            Case item_name2 Like "*item_courier"
                rename_item_name = "Animal Courier"
                Return rename_item_name
            Case item_name2 Like "*item_cyclone"
                rename_item_name = "Eul's Scepter of Divinity"
                Return rename_item_name
            Case item_name2 Like "*item_dagon"
                rename_item_name = "Dagon 1"
                Return rename_item_name
            Case item_name2 Like "*item_dagon_2"
                rename_item_name = "Dagon 2"
                Return rename_item_name
            Case item_name2 Like "*item_dagon_3"
                rename_item_name = "Dagon 3"
                Return rename_item_name
            Case item_name2 Like "*item_dagon_4"
                rename_item_name = "Dagon 4"
                Return rename_item_name
            Case item_name2 Like "*item_dagon_5"
                rename_item_name = "Dagon 5"
                Return rename_item_name
            Case item_name2 Like "*item_demon_edge"
                rename_item_name = "Demon Edge"
                Return rename_item_name
            Case item_name2 Like "*item_desolator"
                rename_item_name = "Desolator"
                Return rename_item_name
            Case item_name2 Like "*item_diffusal_blade"
                rename_item_name = "Diffusal Blade 1"
                Return rename_item_name
            Case item_name2 Like "*item_diffusal_blade_2"
                rename_item_name = "Diffusal Blade 2"
                Return rename_item_name
            Case item_name2 Like "*item_dust"
                rename_item_name = "Dust of Appearance"
                Return rename_item_name
            Case item_name2 Like "*item_eagle"
                rename_item_name = "Eaglesong"
                Return rename_item_name
            Case item_name2 Like "*item_energy_booster"
                rename_item_name = "Energy Booster"
                Return rename_item_name
            Case item_name2 Like "*item_ethereal_blade"
                rename_item_name = "Ethereal Blade"
                Return rename_item_name
            Case item_name2 Like "*item_flask"
                rename_item_name = "Healing Salve"
                Return rename_item_name
            Case item_name2 Like "*item_flying_courier"
                rename_item_name = "Flying Courier"
                Return rename_item_name
            Case item_name2 Like "*item_force_staff"
                rename_item_name = "Force Staff"
                Return rename_item_name
            Case item_name2 Like "*item_gauntlets"
                rename_item_name = "Gauntlets of Strength"
                Return rename_item_name
            Case item_name2 Like "*item_gem"
                rename_item_name = "Gem of True Sight"
                Return rename_item_name
            Case item_name2 Like "*item_ghost"
                rename_item_name = "Ghost Scepter"
                Return rename_item_name
            Case item_name2 Like "*item_gloves"
                rename_item_name = "Gloves of Haste"
                Return rename_item_name
            Case item_name2 Like "*item_greater_crit"
                rename_item_name = "Daedalus"
                Return rename_item_name
            Case item_name2 Like "*item_hand_of_midas"
                rename_item_name = "Hand of Midas"
                Return rename_item_name
            Case item_name2 Like "*item_headdress"
                rename_item_name = "Headdress"
                Return rename_item_name
            Case item_name2 Like "*item_heart"
                rename_item_name = "Heart of Tarrasque"
                Return rename_item_name
            Case item_name2 Like "*item_helm_of_iron_will"
                rename_item_name = "Helm of Iron Will"
                Return rename_item_name
            Case item_name2 Like "*item_helm_of_the_dominator"
                rename_item_name = "Helm of the Dominator"
                Return rename_item_name
            Case item_name2 Like "*item_hood_of_defiance"
                rename_item_name = "Hood of Defiance"
                Return rename_item_name
            Case item_name2 Like "*item_hyperstone"
                rename_item_name = "Hyperstone"
                Return rename_item_name
            Case item_name2 Like "*item_invis_sword"
                rename_item_name = "Shadow Blade"
                Return rename_item_name
            Case item_name2 Like "*item_javelin"
                rename_item_name = "Javelin"
                Return rename_item_name
            Case item_name2 Like "*item_lesser_crit"
                rename_item_name = "Crystalys"
                Return rename_item_name
            Case item_name2 Like "*item_lifesteal"
                rename_item_name = "Morbid Mask"
                Return rename_item_name
            Case item_name2 Like "*item_maelstrom"
                rename_item_name = "Maelstrom"
                Return rename_item_name
            Case item_name2 Like "*item_magic_stick"
                rename_item_name = "Magic Stick"
                Return rename_item_name
            Case item_name2 Like "*item_magic_wand"
                rename_item_name = "Magic Wand"
                Return rename_item_name
            Case item_name2 Like "*item_manta"
                rename_item_name = "Manta Style"
                Return rename_item_name
            Case item_name2 Like "*item_mantle"
                rename_item_name = "Mantle of Intelligence"
                Return rename_item_name
            Case item_name2 Like "*item_mask_of_madness"
                rename_item_name = "Mask of Madness"
                Return rename_item_name
            Case item_name2 Like "*item_medallion_of_courage"
                rename_item_name = "Medallion of Courage"
                Return rename_item_name
            Case item_name2 Like "*item_mekansm"
                rename_item_name = "Mekansm"
                Return rename_item_name
            Case item_name2 Like "*item_mithril_hammer"
                rename_item_name = "Mithril Hammer"
                Return rename_item_name
            Case item_name2 Like "*item_mjollnir"
                rename_item_name = "Mjollnir"
                Return rename_item_name
            Case item_name2 Like "*item_monkey_king_bar"
                rename_item_name = "Monkey King Bar"
                Return rename_item_name
            Case item_name2 Like "*item_mystic_staff"
                rename_item_name = "Mystic Staff"
                Return rename_item_name
            Case item_name2 Like "*item_necronomicon"
                rename_item_name = "Necronomicon 1"
                Return rename_item_name
            Case item_name2 Like "*item_necronomicon_2"
                rename_item_name = "Necronomicon 2"
                Return rename_item_name
            Case item_name2 Like "*item_necronomicon_3"
                rename_item_name = "Necronomicon 3"
                Return rename_item_name
            Case item_name2 Like "*item_null_talisman"
                rename_item_name = "Null Talisman"
                Return rename_item_name
            Case item_name2 Like "*item_oblivion_staff"
                rename_item_name = "Oblivion Staff"
                Return rename_item_name
            Case item_name2 Like "*item_ward_observer"
                rename_item_name = "Observer Ward"
                Return rename_item_name
            Case item_name2 Like "*item_ogre_axe"
                rename_item_name = "Ogre Club"
                Return rename_item_name
            Case item_name2 Like "*item_orb_of_venom"
                rename_item_name = "Orb of Venom"
                Return rename_item_name
            Case item_name2 Like "*item_orchid"
                rename_item_name = "Orchid Malevolence"
                Return rename_item_name
            Case item_name2 Like "*item_pers"
                rename_item_name = "Perseverance"
                Return rename_item_name
            Case item_name2 Like "*item_phase_boots"
                rename_item_name = "Phase Boots"
                Return rename_item_name
            Case item_name2 Like "*item_pipe"
                rename_item_name = "Pipe of Insight"
                Return rename_item_name
            Case item_name2 Like "*item_platemail"
                rename_item_name = "Platemail"
                Return rename_item_name
            Case item_name2 Like "*item_point_booster"
                rename_item_name = "Point Booster"
                Return rename_item_name
            Case item_name2 Like "*item_poor_mans_shield"
                rename_item_name = "Poor Man's Shield"
                Return rename_item_name
            Case item_name2 Like "*item_power_treads"
                rename_item_name = "Power Treads"
                Return rename_item_name
            Case item_name2 Like "*item_quarterstaff"
                rename_item_name = "Quarterstaff"
                Return rename_item_name
            Case item_name2 Like "*item_quelling_blade"
                rename_item_name = "Quelling Blade"
                Return rename_item_name
            Case item_name2 Like "*item_radiance"
                rename_item_name = "Radiance"
                Return rename_item_name
            Case item_name2 Like "*item_rapier"
                rename_item_name = "Divine Rapier"
                Return rename_item_name
            Case item_name2 Like "*item_reaver"
                rename_item_name = "Reaver"
                Return rename_item_name
            Case item_name2 Like "*item_refresher"
                rename_item_name = "Refresher Orb"
                Return rename_item_name
            Case item_name2 Like "*item_ring_of_basilius"
                rename_item_name = "Ring of Basilius"
                Return rename_item_name
            Case item_name2 Like "*item_ring_of_health"
                rename_item_name = "Ring of Health"
                Return rename_item_name
            Case item_name2 Like "*item_ring_of_protection"
                rename_item_name = "Ring of Protection"
                Return rename_item_name
            Case item_name2 Like "*item_ring_of_regen"
                rename_item_name = "Ring of Regen"
                Return rename_item_name
            Case item_name2 Like "*item_robe"
                rename_item_name = "Robe of the Magi"
                Return rename_item_name
            Case item_name2 Like "*item_relic"
                rename_item_name = "Sacred Relic"
                Return rename_item_name
            Case item_name2 Like "*item_sange"
                rename_item_name = "Sange"
                Return rename_item_name
            Case item_name2 Like "*item_sange_and_yasha"
                rename_item_name = "Sange and Yasha"
                Return rename_item_name
            Case item_name2 Like "*item_satanic"
                rename_item_name = "Satanic"
                Return rename_item_name
            Case item_name2 Like "*item_ultimate_scepter"
                rename_item_name = "Aghanim's Scepter"
                Return rename_item_name
            Case item_name2 Like "*item_ward_sentry"
                rename_item_name = "Sentry Ward"
                Return rename_item_name
            Case item_name2 Like "*item_sheepstick"
                rename_item_name = "Scythe of Vyse"
                Return rename_item_name
            Case item_name2 Like "*item_shivas_guard"
                rename_item_name = "Shiva's Guard"
                Return rename_item_name
            Case item_name2 Like "*item_skadi"
                rename_item_name = "Eye of Skadi"
                Return rename_item_name
            Case item_name2 Like "*item_slippers"
                rename_item_name = "Slippers of Agility"
                Return rename_item_name
            Case item_name2 Like "*item_smoke_of_deceit"
                rename_item_name = "Smoke of Deceit"
                Return rename_item_name
            Case item_name2 Like "*item_sobi_mask"
                rename_item_name = "Sage's Mask"
                Return rename_item_name
            Case item_name2 Like "*item_soul_booster"
                rename_item_name = "Soul Booster"
                Return rename_item_name
            Case item_name2 Like "*item_soul_ring"
                rename_item_name = "Soul Ring"
                Return rename_item_name
            Case item_name2 Like "*item_sphere"
                rename_item_name = "Linken's Sphere"
                Return rename_item_name
            Case item_name2 Like "*item_staff_of_wizardry"
                rename_item_name = "Staff of Wizardry"
                Return rename_item_name
            Case item_name2 Like "*item_stout_shield"
                rename_item_name = "Stout Shield"
                Return rename_item_name
            Case item_name2 Like "*item_talisman_of_evasion"
                rename_item_name = "Talisman of Evasion"
                Return rename_item_name
            Case item_name2 Like "*item_tpscroll"
                rename_item_name = "Town Portal Scroll"
                Return rename_item_name
            Case item_name2 Like "*item_travel_boots"
                rename_item_name = "Boots of Travel"
                Return rename_item_name
            Case item_name2 Like "*item_ultimate_orb"
                rename_item_name = "Ultimate Orb"
                Return rename_item_name
            Case item_name2 Like "*item_urn_of_shadows"
                rename_item_name = "Urn of Shadows"
                Return rename_item_name
            Case item_name2 Like "*item_vanguard"
                rename_item_name = "Vanguard"
                Return rename_item_name
            Case item_name2 Like "*item_veil_of_discord"
                rename_item_name = "Veil of Discord"
                Return rename_item_name
            Case item_name2 Like "*item_vitality_booster"
                rename_item_name = "Vitality Booster"
                Return rename_item_name
            Case item_name2 Like "*item_vladmir"
                rename_item_name = "Vladmir's Offering"
                Return rename_item_name
            Case item_name2 Like "*item_void_stone"
                rename_item_name = "Void Stone"
                Return rename_item_name
            Case item_name2 Like "*item_wraith_band"
                rename_item_name = "Wraith Band"
                Return rename_item_name
            Case item_name2 Like "*item_yasha"
                rename_item_name = "Yasha"
                Return rename_item_name
            Case item_name2 Like "*item_abyssal_blade"
                rename_item_name = "Abyssal Blade"
                Return rename_item_name
            Case item_name2 Like "*item_heavens_halberd"
                rename_item_name = "Heaven's Halberd"
                Return rename_item_name
            Case item_name2 Like "*item_ring_of_aquila"
                rename_item_name = "Ring of Aquila"
                Return rename_item_name
            Case item_name2 Like "*item_rod_of_atos"
                rename_item_name = "Rod of Atos"
                Return rename_item_name
            Case item_name2 Like "*item_tranquil_boots"
                rename_item_name = "Tranquil Boots"
                Return rename_item_name
            Case Else
                rename_item_name = "Error!"
                Return rename_item_name
        End Select
    End Function

    'Return the itemname for the itembuild file, needs the normal itemname
    Public Function GetItem(ByVal item_name As String) As String
        Select Case item_name
            Case "Blink Dagger"
                Return "item_blink"
            Case "Blades of Attack"
                Return "item_blades_of_attack"
            Case "Skull Basher"
                Return "item_basher"
            Case "Tango"
                Return "item_tango"
            Case "Drum of Endurance"
                Return "item_ancient_janggo"
            Case "Arcane Boots"
                Return "item_arcane_boots"
            Case "Armlet"
                Return "item_armlet"
            Case "Assault Cuirass"
                Return "item_assault"
            Case "Battle Fury"
                Return "item_bfury"
            Case "Belt of Strength"
                Return "item_belt_of_strength"
            Case "Black King Bar"
                Return "item_black_king_bar"
            Case "Blade Mail"
                Return "item_blade_mail"
            Case "Blade of Alacrity"
                Return "item_blade_of_alacrity"
            Case "Bloodstone"
                Return "item_bloodstone"
            Case "Boots of Speed"
                Return "item_boots"
            Case "Boots of Elvenskin"
                Return "item_boots_of_elves"
            Case "Bottle"
                Return "item_bottle"
            Case "Bracer"
                Return "item_bracer"
            Case "Iron Branch"
                Return "item_branches"
            Case "Broadsword"
                Return "item_broadsword"
            Case "Buckler"
                Return "item_buckler"
            Case "Butterfly"
                Return "item_butterfly"
            Case "Chainmail"
                Return "item_chainmail"
            Case "Circlet"
                Return "item_circlet"
            Case "Clarity"
                Return "item_clarity"
            Case "Claymore"
                Return "item_claymore"
            Case "Cloak"
                Return "item_cloak"
            Case "Animal Courier"
                Return "item_courier"
            Case "Eul's Scepter of Divinity"
                Return "item_cyclone"
            Case "Dagon 1"
                Return "item_dagon"
            Case "Dagon 2"
                Return "item_dagon_2"
            Case "Dagon 3"
                Return "item_dagon_3"
            Case "Dagon 4"
                Return "item_dagon_4"
            Case "Dagon 5"
                Return "item_dagon_5"
            Case "Demon Edge"
                Return "item_demon_edge"
            Case "Desolator"
                Return "item_desolator"
            Case "Diffusal Blade 1"
                Return "item_diffusal_blade"
            Case "Diffusal Blade 2"
                Return "item_diffusal_blade_2"
            Case "Dust of Appearance"
                Return "item_dust"
            Case "Eaglesong"
                Return "item_eagle"
            Case "Energy Booster"
                Return "item_energy_booster"
            Case "Ethereal Blade"
                Return "item_ethereal_blade"
            Case "Healing Salve"
                Return "item_flask"
            Case "Flying Courier"
                Return "item_flying_courier"
            Case "Force Staff"
                Return "item_force_staff"
            Case "Gauntlets of Strength"
                Return "item_gauntlets"
            Case "Gem of True Sight"
                Return "item_gem"
            Case "Ghost Scepter"
                Return "item_ghost"
            Case "Gloves of Haste"
                Return "item_gloves"
            Case "Daedalus"
                Return "item_greater_crit"
            Case "Hand of Midas"
                Return "item_hand_of_midas"
            Case "Headdress"
                Return "item_headdress"
            Case "Heart of Tarrasque"
                Return "item_heart"
            Case "Helm of Iron Will"
                Return "item_helm_of_iron_will"
            Case "Helm of the Dominator"
                Return "item_helm_of_the_dominator"
            Case "Hood of Defiance"
                Return "item_hood_of_defiance"
            Case "Hyperstone"
                Return "item_hyperstone"
            Case "Shadow Blade"
                Return "item_invis_sword"
            Case "Javelin"
                Return "item_javelin"
            Case "Crystalys"
                Return "item_lesser_crit"
            Case "Morbid Mask"
                Return "item_lifesteal"
            Case = "Maelstrom"
                Return "item_maelstrom"
            Case = "Magic Stick"
                Return "item_magic_stick"
            Case = "Magic Wand"
                Return "item_magic_wand"
            Case = "Manta Style"
                Return "item_manta"
            Case "Mantle of Intelligence"
                Return "item_mantle"
            Case = "Mask of Madness"
                Return "item_mask_of_madness"
            Case "Medallion of Courage"
                Return "item_medallion_of_courage"
            Case "Mekansm"
                Return "item_mekansm"
            Case "Mithril Hammer"
                Return "item_mithril_hammer"
            Case "Mjollnir"
                Return "item_mjollnir"
            Case "Monkey King Bar"
                Return "item_monkey_king_bar"
            Case "Mystic Staff"
                Return "item_mystic_staff"
            Case "Necronomicon 1"
                Return "item_necronomicon"
            Case "Necronomicon 2"
                Return "item_necronomicon_2"
            Case "Necronomicon 3"
                Return "item_necronomicon_3"
            Case "Null Talisman"
                Return "item_null_talisman"
            Case "Oblivion Staff"
                Return "item_oblivion_staff"
            Case "Observer Ward"
                Return "item_ward_observer"
            Case "Ogre Club"
                Return "item_ogre_axe"
            Case "Orb of Venom"
                Return "item_orb_of_venom"
            Case "Orchid Malevolence"
                Return "item_orchid"
            Case "Perseverance"
                Return "item_pers"
            Case "Phase Boots"
                Return "item_phase_boots"
            Case "Pipe of Insight"
                Return "item_pipe"
            Case "Platemail"
                Return "item_platemail"
            Case "Point Booster"
                Return "item_point_booster"
            Case "Poor Man's Shield"
                Return "item_poor_mans_shield"
            Case "Power Treads"
                Return "item_power_treads"
            Case "Quarterstaff"
                Return "item_quarterstaff"
            Case "Quelling Blade"
                Return "item_quelling_blade"
            Case "Radiance"
                Return "item_radiance"
            Case "Divine Rapier"
                Return "item_rapier"
            Case "Reaver"
                Return "item_reaver"
            Case "Refresher Orb"
                Return "item_refresher"
            Case "Ring of Basilius"
                Return "item_ring_of_basilius"
            Case "Ring of Health"
                Return "item_ring_of_health"
            Case "Ring of Protection"
                Return "item_ring_of_protection"
            Case "Ring of Regen"
                Return "item_ring_of_regen"
            Case "Robe of the Magi"
                Return "item_robe"
            Case "Sacred Relic"
                Return "item_relic"
            Case "Sange"
                Return "item_sange"
            Case "Sange and Yasha"
                Return "item_sange_and_yasha"
            Case "Satanic"
                Return "item_satanic"
            Case "Aghanim's Scepter"
                Return "item_ultimate_scepter"
            Case "Sentry Ward"
                Return "item_ward_sentry"
            Case "Scythe of Vyse"
                Return "item_sheepstick"
            Case "Shiva's Guard"
                Return "item_shivas_guard"
            Case "Eye of Skadi"
                Return "item_skadi"
            Case "Slippers of Agility"
                Return "item_slippers"
            Case "Smoke of Deceit"
                Return "item_smoke_of_deceit"
            Case "Sage's Mask"
                Return "item_sobi_mask"
            Case "Soul Booster"
                Return "item_soul_booster"
            Case "Soul Ring"
                Return "item_soul_ring"
            Case "Linken's Sphere"
                Return "item_sphere"
            Case "Staff of Wizardry"
                Return "item_staff_of_wizardry"
            Case "Stout Shield"
                Return "item_stout_shield"
            Case "Talisman of Evasion"
                Return "item_talisman_of_evasion"
            Case "Town Portal Scroll"
                Return "item_tpscroll"
            Case "Boots of Travel"
                Return "item_travel_boots"
            Case "Ultimate Orb"
                Return "item_ultimate_orb"
            Case "Urn of Shadows"
                Return "item_urn_of_shadows"
            Case "Vanguard"
                Return "item_vanguard"
            Case "Veil of Discord"
                Return "item_veil_of_discord"
            Case "Vitality Booster"
                Return "item_vitality_booster"
            Case "Vladmir's Offering"
                Return "item_vladmir"
            Case "Void Stone"
                Return "item_void_stone"
            Case "Wraith Band"
                Return "item_wraith_band"
            Case "Yasha"
                Return "item_yasha"
            Case "Abyssal Blade"
                Return "item_abyssal_blade"
            Case "Heaven's Halberd"
                Return "item_heavens_halberd"
            Case "Ring of Aquila"
                Return "item_ring_of_aquila"
            Case "Rod of Atos"
                Return "item_rod_of_atos"
            Case "Tranquil Boots"
                Return "item_tranquil_boots"
            Case Else
                Return "Error! Itemname: " + item_name
        End Select
    End Function

    'Source: http://dotnet-snippets.de/dns/bild-transparent-machen-mit-colormatrix-SID168.aspx
    Private Function SetImageAlpha(ByVal Image As Image, ByVal Alpha As Single) As Image
        Dim ImgAttr As New Imaging.ImageAttributes()

        'Standard-ColorMatrix für Transparenz
        Dim ColorMatrix As New Imaging.ColorMatrix(New Single()() {New Single() {1, 0, 0, 0, 0}, New Single() {0, 1, 0, 0, 0}, New Single() {0, 0, 1, 0, 0}, New Single() {0, 0, 0, CSng(Alpha / 100), 0}, New Single() {0, 0, 0, 0, 1}})

        'ColorMatrix an ImageAttribute-Objekt übergeben
        ImgAttr.SetColorMatrix(ColorMatrix)

        'Neue 32bit Bitmap erstellen
        Dim NewBitmap = New Bitmap(Image.Width, Image.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)

        'Resolution (DPI) vom Quellbitmap auf Zielbitmap übertragen
        NewBitmap.SetResolution(Image.HorizontalResolution, Image.VerticalResolution)

        'Graphicsobjekt von NewBitmap erstellen
        Dim NewGraphics As Graphics = Graphics.FromImage(NewBitmap)

        'NewBitmap auf NewGraphics zeichnen
        NewGraphics.DrawImage(Image, New Rectangle(0, 0, NewBitmap.Width, NewBitmap.Height), 0, 0, Image.Width, Image.Height, GraphicsUnit.Pixel, ImgAttr)

        'Ressource freigeben
        NewGraphics.Dispose()
        ImgAttr.Dispose()
        Return NewBitmap
    End Function

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        Dim Index As Integer
        Dim itemImage As Bitmap

        If ListView1.SelectedItems.Count > 0 Then
            Dim lvi As ListViewItem = ListView1.SelectedItems.Item(0)
            If lvi.Selected Then
                Index = lvi.Index
            Else
                Index = -1
            End If
        End If

        If Index > -1 Then
            Selected_Item = ListView1.Items(Index).Text
            itemImage = SetImageAlpha(ImageList1.Images(GetPicture(Selected_Item)), 75)
            cursor_image = Icon.FromHandle(itemImage.GetHicon())
        End If
    End Sub

    'Change the cursor while dragging an item
    Private Sub ListView1_GiveFeedback(ByVal sender As System.Object, ByVal e As System.Windows.Forms.GiveFeedbackEventArgs) Handles ListView1.GiveFeedback
        e.UseDefaultCursors = False
        If ((e.Effect And DragDropEffects.Copy) = DragDropEffects.Copy) Then
            Cursor.Current = Cursors.Hand
        Else
            Cursor.Current = New Cursor(cursor_image.Handle)
        End If
    End Sub

    'LISTVIEW DRAG&DROP
    Private Sub ListView1_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles ListView1.ItemDrag
        ListView1.DoDragDrop(Selected_Item, DragDropEffects.Copy)
    End Sub

    Private Sub ListView2_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListView2.DragDrop
        Dim lvi As ListViewItem = Nothing
        Dim lv As ListView = CType(sender, ListView)
        If e.Data.GetDataPresent("System.Windows.Forms.ListViewItem", False) Then
            lvi = CType(e.Data.GetData("System.Windows.Forms.ListViewItem"), ListViewItem)
            With lvi
                .ListView.Items.Remove(lvi)
                With lv
                    .Items.Add(lvi)
                End With
            End With
            IntPrice = (CInt(Label15.Text) + Itembuild.GetPrice(ListView2.SelectedItems(0).SubItems(1).Text))
            Label15.Text = IntPrice.ToString
            CheckCosts(IntPrice.ToString)
            Unsaved = True
        Else
            With ListView2
                Dim item As New ListViewItem(New String() {"", Selected_Item}, GetPicture(Selected_Item))
                .Items.AddRange(New ListViewItem() {item})
                .Items(ListView2.Items.Count - 1).ToolTipText = Itembuild.GetToolTip(Selected_Item)
            End With
            IntPrice = (CInt(Label15.Text) + Itembuild.GetPrice(Selected_Item))
            Label15.Text = IntPrice.ToString
            CheckCosts(IntPrice.ToString)
            Unsaved = True
        End If
    End Sub
    Private Sub ListView2_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListView2.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub
    Private Sub ListView2_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles ListView2.ItemDrag
        IntPrice = (CInt(Label15.Text) - Itembuild.GetPrice(ListView2.SelectedItems(0).SubItems(1).Text))
        Label15.Text = IntPrice.ToString
        CheckCosts(IntPrice.ToString)
        DoDragDrop(e.Item, DragDropEffects.Copy)
    End Sub

    Private Sub ListView3_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListView3.DragDrop
        Dim lvi As ListViewItem = Nothing
        Dim lv As ListView = CType(sender, ListView)
        If e.Data.GetDataPresent("System.Windows.Forms.ListViewItem", False) Then
            lvi = CType(e.Data.GetData("System.Windows.Forms.ListViewItem"), ListViewItem)
            With lvi
                .ListView.Items.Remove(lvi)
                With lv
                    .Items.Add(lvi)
                End With
            End With
        Else
            With ListView3
                Dim item As New ListViewItem(New String() {"", Selected_Item}, GetPicture(Selected_Item))
                .Items.AddRange(New ListViewItem() {item})
                .Items(ListView3.Items.Count - 1).ToolTipText = Itembuild.GetToolTip(Selected_Item)
            End With
        End If
    End Sub
    Private Sub ListView3_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListView3.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub
    Private Sub ListView3_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles ListView3.ItemDrag
        DoDragDrop(e.Item, DragDropEffects.Copy)
    End Sub

    Private Sub ListView4_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListView4.DragDrop
        Dim lvi As ListViewItem = Nothing
        Dim lv As ListView = CType(sender, ListView)
        If e.Data.GetDataPresent("System.Windows.Forms.ListViewItem", False) Then
            lvi = CType(e.Data.GetData("System.Windows.Forms.ListViewItem"), ListViewItem)
            With lvi
                .ListView.Items.Remove(lvi)
                With lv
                    .Items.Add(lvi)
                End With
            End With
        Else
            With ListView4
                Dim item As New ListViewItem(New String() {"", Selected_Item}, GetPicture(Selected_Item))
                .Items.AddRange(New ListViewItem() {item})
                .Items(ListView4.Items.Count - 1).ToolTipText = Itembuild.GetToolTip(Selected_Item)
            End With
        End If
    End Sub
    Private Sub ListView4_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListView4.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub
    Private Sub ListView4_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles ListView4.ItemDrag
        DoDragDrop(e.Item, DragDropEffects.Copy)
    End Sub

    Private Sub ListView5_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListView5.DragDrop
        Dim lvi As ListViewItem = Nothing
        Dim lv As ListView = CType(sender, ListView)
        If e.Data.GetDataPresent("System.Windows.Forms.ListViewItem", False) Then
            lvi = CType(e.Data.GetData("System.Windows.Forms.ListViewItem"), ListViewItem)
            With lvi
                .ListView.Items.Remove(lvi)
                With lv
                    .Items.Add(lvi)
                End With
            End With
        Else
            With ListView5
                Dim item As New ListViewItem(New String() {"", Selected_Item}, GetPicture(Selected_Item))
                .Items.AddRange(New ListViewItem() {item})
                .Items(ListView5.Items.Count - 1).ToolTipText = Itembuild.GetToolTip(Selected_Item)
            End With
        End If
    End Sub
    Private Sub ListView5_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListView5.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub
    Private Sub ListView5_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles ListView5.ItemDrag
        DoDragDrop(e.Item, DragDropEffects.Copy)
    End Sub

    ' RIGHTCLICK DELTE
    Private Sub ListView2_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView2.MouseClick
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label15.Text) - Itembuild.GetPrice(ListView2.SelectedItems.Item(0).SubItems(1).Text))
            Label15.Text = IntPrice.ToString
            CheckCosts(IntPrice.ToString)
            ListView2.SelectedItems.Item(0).Remove()
            Unsaved = True
        End If
    End Sub

    Private Sub ListView3_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView3.MouseClick
        If e.Button = MouseButtons.Right Then
            ListView3.SelectedItems.Item(0).Remove()
            Unsaved = True
        End If
    End Sub

    Private Sub ListView4_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView4.MouseClick
        If e.Button = MouseButtons.Right Then
            ListView4.SelectedItems.Item(0).Remove()
            Unsaved = True
        End If
    End Sub

    Private Sub ListView5_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView5.MouseClick
        If e.Button = MouseButtons.Right Then
            ListView5.SelectedItems.Item(0).Remove()
            Unsaved = True
        End If
    End Sub

    'Allow ctrl+a to select all text in this textbox
    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If (e.KeyChar = vb.Chr(1)) Then
            TextBox2.SelectAll()
            e.Handled = True
        End If
    End Sub

End Class