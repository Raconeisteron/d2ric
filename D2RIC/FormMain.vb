Imports System.Security.Cryptography, System.Net

Public Class FormMain

    Dim FirstChange As Boolean = True
    Private m_MouseIsDown As Boolean
    Friend WithEvents Import As New ImportClass
    Friend WithEvents Export As New ExportClass
    Friend WithEvents Options As New OptionsClass
    Friend WithEvents Itembuild As New ItembuildClass
    Private WithEvents WebClient1 As New WebClient

    Private Sub FormMain_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.Save()
        End
    End Sub

    Private Sub FormMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Itembuild.Initialize()

        If Not My.Settings.autoupdate Then
            CheckBox1.Checked = False
        Else
            CheckBox1.Checked = True
            LabelWait.Visible = True
            BackgroundWorker1.RunWorkerAsync()
        End If

        If (My.Settings.item_icons <> "") Then
            ComboBoxItemIcons.Text = My.Settings.item_icons
        Else
            ComboBoxItemIcons.Text = "DotA 2"
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedItem <> "" Then
            Itembuild.CheckHero(ListBox1.SelectedItem.ToString)
            Itembuild.ClearSingle()
            Label1.Text = ListBox1.SelectedItem.ToString
            Itembuild.CheckFile(ItembuildClass.Selected_Hero)
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab Is TabPage4 Then
            TextBox3.Text = "Please choose a hero first."
            If (ItembuildClass.Selected_Hero <> "") Then
                Itembuild.SaveChanges()
                Itembuild.ChangeAuthor(TextBox1.Text, ItembuildClass.Selected_Hero)
                My.Settings.clipboard = Itembuild.NeuerText
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
        End If
    End Sub

    Public Sub Check4Update()
        Dim pgversion As String = Application.ProductVersion.Substring(0, Application.ProductVersion.Length - 2)
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

    'CHANGE PICTUREBOX aka ITEM POSITION/ORDER
    Private Sub ComboBox5_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        Itembuild.ChangeItemPosition()
    End Sub

    Private Sub ComboBoxItemIcons_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxItemIcons.SelectedIndexChanged
        Options.ChangeItemIcons()
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

    ''' method for comparing 2 images to see if they are the same. First
    ''' we convert both images to a byte array, we then get their hash (their
    ''' hash should match if the images are the same), we then loop through
    ''' each item in the hash comparing with the 2nd Bitmap
    Public Function doImagesMatch(ByRef bmp1 As Bitmap, ByRef bmp2 As Bitmap) As Boolean
        Try
            'create instance or System.Drawing.ImageConverter to convert
            'each image to a byte array
            Dim converter As New ImageConverter()
            'create 2 byte arrays, one for each image
            Dim imgBytes1 As Byte() = New Byte(0) {}
            Dim imgBytes2 As Byte() = New Byte(0) {}

            'convert images to byte array
            imgBytes1 = DirectCast(converter.ConvertTo(bmp1, imgBytes2.[GetType]()), Byte())
            imgBytes2 = DirectCast(converter.ConvertTo(bmp2, imgBytes1.[GetType]()), Byte())

            'now compute a hash for each image from the byte arrays
            Dim sha As New SHA256Managed()
            Dim imgHash1 As Byte() = sha.ComputeHash(imgBytes1)
            Dim imgHash2 As Byte() = sha.ComputeHash(imgBytes2)

            'now let's compare the hashes
            Dim i As Integer = 0
            While i < imgHash1.Length AndAlso i < imgHash2.Length
                'whoops, found a non-match, exit the loop
                'with a false value
                If Not (imgHash1(i) = imgHash2(i)) Then
                    Return False
                End If
                i += 30
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
        'we made it this far so the images must match
        Return True
    End Function

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

    Public Function CheckItem(ByVal item_name As System.Drawing.Image) As String
        Dim new_item_name As String
        If ComboBoxItemIcons.Text = "DotA 1" Then
            If doImagesMatch(item_name, D2RIC.My.Resources.Resources.Kelensdagger) Then
                new_item_name = """" & "item_blink" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Bladesofattack) Then
                new_item_name = """" & "item_blades_of_attack" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Aghanimsscepter) Then
                new_item_name = """" & "item_ultimate_scepter" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Animalcourier) Then
                new_item_name = """" & "item_courier" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.ArcaneBoots) Then
                new_item_name = """" & "item_arcane_boots" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Armletofmordiggian) Then
                new_item_name = """" & "item_armlet" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Assaultcuirass) Then
                new_item_name = """" & "item_assault" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Battlefury) Then
                new_item_name = """" & "item_bfury" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Blackkingbar) Then
                new_item_name = """" & "item_black_king_bar" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Beltofgiantstrength) Then
                new_item_name = """" & "item_belt_of_strength" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Blademail) Then
                new_item_name = """" & "item_blade_mail" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Bladesofalacrity) Then
                new_item_name = """" & "item_blade_of_alacrity" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Bloodstone) Then
                new_item_name = """" & "item_bloodstone" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Bootsofelvenskin) Then
                new_item_name = """" & "item_boots_of_elves" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Bootsofspeed) Then
                new_item_name = """" & "item_boots" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Bootsoftravel) Then
                new_item_name = """" & "item_travel_boots" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Bottle) Then
                new_item_name = """" & "item_bottle" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Bracer) Then
                new_item_name = """" & "item_bracer" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Broadsword) Then
                new_item_name = """" & "item_broadsword" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Nathrezimbuckler) Then
                new_item_name = """" & "item_buckler" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Butterfly) Then
                new_item_name = """" & "item_butterfly" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Chainmail) Then
                new_item_name = """" & "item_chainmail" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Circletofnobility) Then
                new_item_name = """" & "item_circlet" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Claritypotion) Then
                new_item_name = """" & "item_clarity" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Claymore) Then
                new_item_name = """" & "item_claymore" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Planeswalkerscloak) Then
                new_item_name = """" & "item_cloak" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Crystalys) Then
                new_item_name = """" & "item_lesser_crit" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Burizadokyanon) Then
                new_item_name = """" & "item_greater_crit" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Dagon) Then
                new_item_name = """" & "item_dagon" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Dagon2) Then
                new_item_name = """" & "item_dagon_2" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Dagon3) Then
                new_item_name = """" & "item_dagon_3" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Dagon4) Then
                new_item_name = """" & "item_dagon_4" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Dagon5) Then
                new_item_name = """" & "item_dagon_5" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Demonedge) Then
                new_item_name = """" & "item_demon_edge" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Stygiandesolator) Then
                new_item_name = """" & "item_desolator" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Diffusalblade) Then
                new_item_name = """" & "item_diffusal_blade" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Diffusalblade2) Then
                new_item_name = """" & "item_diffusal_blade_2" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Divinerapier) Then
                new_item_name = """" & "item_rapier" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Ancientjanggoofendurance) Then
                new_item_name = """" & "item_ancient_janggo" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Dustofappearance) Then
                new_item_name = """" & "item_dust" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Eaglehorn) Then
                new_item_name = """" & "item_eagle" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Energybooster) Then
                new_item_name = """" & "item_energy_booster" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Etheral_Blade) Then
                new_item_name = """" & "item_ethereal_blade" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Eulsscepterofdivinity) Then
                new_item_name = """" & "item_cyclone" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Eyeofskadi) Then
                new_item_name = """" & "item_skadi" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Flyingcourier) Then
                new_item_name = """" & "item_flying_courier" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Forcestaff) Then
                new_item_name = """" & "item_force_staff" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Gauntletsofstrength) Then
                new_item_name = """" & "item_gauntlets" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Gemoftruesight) Then
                new_item_name = """" & "item_gem" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Ghostscepter) Then
                new_item_name = """" & "item_ghost" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Glovesofhaste) Then
                new_item_name = """" & "item_gloves" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Handofmidas) Then
                new_item_name = """" & "item_hand_of_midas" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Headdressofrejuvenation) Then
                new_item_name = """" & "item_headdress" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Healingsalve) Then
                new_item_name = """" & "item_flask" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Heartoftarrasque) Then
                new_item_name = """" & "item_heart" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Helmofironwill) Then
                new_item_name = """" & "item_helm_of_iron_will" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Helmofthedominator) Then
                new_item_name = """" & "item_helm_of_the_dominator" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Hoodofdefiance) Then
                new_item_name = """" & "item_hood_of_defiance" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Hyperstone) Then
                new_item_name = """" & "item_hyperstone" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Ironwoodbranch) Then
                new_item_name = """" & "item_branches" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Javelin) Then
                new_item_name = """" & "item_javelin" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Linkenssphere) Then
                new_item_name = """" & "item_sphere" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Maelstrom) Then
                new_item_name = """" & "item_maelstrom" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Magicstick) Then
                new_item_name = """" & "item_magic_stick" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Magicwand) Then
                new_item_name = """" & "item_magic_wand" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Mantastyle) Then
                new_item_name = """" & "item_manta" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Mantleofintelligence) Then
                new_item_name = """" & "item_mantle" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Maskofmadness) Then
                new_item_name = """" & "item_mask_of_madness" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Medallionofcourage) Then
                new_item_name = """" & "item_medallion_of_courage" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Mekansm) Then
                new_item_name = """" & "item_mekansm" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Mithrilhammer) Then
                new_item_name = """" & "item_mithril_hammer" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Mjollnir) Then
                new_item_name = """" & "item_mjollnir" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Monkeykingbar) Then
                new_item_name = """" & "item_monkey_king_bar" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Maskofdeath) Then
                new_item_name = """" & "item_lifesteal" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Mysticstaff) Then
                new_item_name = """" & "item_mystic_staff" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Necronomicon) Then
                new_item_name = """" & "item_necronomicon" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Necronomicon2) Then
                new_item_name = """" & "item_necronomicon_2" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Necronomicon3) Then
                new_item_name = """" & "item_necronomicon_3" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Nulltalisman) Then
                new_item_name = """" & "item_null_talisman" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Oblivionstaff) Then
                new_item_name = """" & "item_oblivion_staff" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Observerwards) Then
                new_item_name = """" & "item_ward_observer" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Ogreaxe) Then
                new_item_name = """" & "item_ogre_axe" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.OrbOfVenom) Then
                new_item_name = """" & "item_orb_of_venom" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Orchidmalevolence) Then
                new_item_name = """" & "item_orchid" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Perseverance) Then
                new_item_name = """" & "item_pers" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Phaseboots) Then
                new_item_name = """" & "item_phase_boots" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Khadgarspipeofinsight) Then
                new_item_name = """" & "item_pipe" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Platemail) Then
                new_item_name = """" & "item_platemail" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Pointbooster) Then
                new_item_name = """" & "item_point_booster" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Poormansshield) Then
                new_item_name = """" & "item_poor_mans_shield" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Powertreads) Then
                new_item_name = """" & "item_power_treads" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Quarterstaff) Then
                new_item_name = """" & "item_quarterstaff" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Quellingblade) Then
                new_item_name = """" & "item_quelling_blade" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Radiance) Then
                new_item_name = """" & "item_radiance" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Messerschmidtsreaver) Then
                new_item_name = """" & "item_reaver" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Refresherorb) Then
                new_item_name = """" & "item_refresher" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Ringofbasilius) Then
                new_item_name = """" & "item_ring_of_basilius" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Ringofhealth) Then
                new_item_name = """" & "item_ring_of_health" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Ringofprotection) Then
                new_item_name = """" & "item_ring_of_protection" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Ringofregeneration) Then
                new_item_name = """" & "item_ring_of_regen" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Robeofthemagi) Then
                new_item_name = """" & "item_robe" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Sacredrelic) Then
                new_item_name = """" & "item_relic" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Sobimask) Then
                new_item_name = """" & "item_sobi_mask" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Sange) Then
                new_item_name = """" & "item_sange" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Sangeandyasha) Then
                new_item_name = """" & "item_sange_and_yasha" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Satanic) Then
                new_item_name = """" & "item_satanic" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Guinsoosscytheofvyse) Then
                new_item_name = """" & "item_sheepstick" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Sentrywards) Then
                new_item_name = """" & "item_ward_sentry" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Lotharsedge) Then
                new_item_name = """" & "item_invis_sword" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Shivasguard) Then
                new_item_name = """" & "item_shivas_guard" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Craniumbasher) Then
                new_item_name = """" & "item_basher" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Slippersofagility) Then
                new_item_name = """" & "item_slippers" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.SmokeOfDeceit) Then
                new_item_name = """" & "item_smoke_of_deceit" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Soulbooster) Then
                new_item_name = """" & "item_soul_booster" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Soul_Ring) Then
                new_item_name = """" & "item_soul_ring" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Staffofwizardry) Then
                new_item_name = """" & "item_staff_of_wizardry" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Stoutshield) Then
                new_item_name = """" & "item_stout_shield" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Talismanofevasion) Then
                new_item_name = """" & "item_talisman_of_evasion" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Ancienttangoofessifation) Then
                new_item_name = """" & "item_tango" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Townportal) Then
                new_item_name = """" & "item_tpscroll" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Ultimateorb) Then
                new_item_name = """" & "item_ultimate_orb" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Urnofshadows) Then
                new_item_name = """" & "item_urn_of_shadows" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Vanguard) Then
                new_item_name = """" & "item_vanguard" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Fatalbonds) Then
                new_item_name = """" & "item_veil_of_discord" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Vitalitybooster) Then
                new_item_name = """" & "item_vitality_booster" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Vladimirsoffering) Then
                new_item_name = """" & "item_vladmir" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Voidstone) Then
                new_item_name = """" & "item_void_stone" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Wraithband) Then
                new_item_name = """" & "item_wraith_band" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Yasha) Then
                new_item_name = """" & "item_yasha" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.AbyssalBlade) Then
                new_item_name = """" & "item_abyssal_blade" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.Halberd) Then
                new_item_name = """" & "item_heavens_halberd" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.RingofAquila) Then
                new_item_name = """" & "item_ring_of_aquila" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.RodofAtos) Then
                new_item_name = """" & "item_rod_of_atos" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.TranquilBoots) Then
                new_item_name = """" & "item_tranquil_boots" & """"
                Return new_item_name
            Else
                new_item_name = ""
                Return new_item_name
            End If
        ElseIf ComboBoxItemIcons.Text = "HoN" Then
            If doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Portal_Key) Then
                new_item_name = """" & "item_blink" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Punchdagger) Then
                new_item_name = """" & "item_blades_of_attack" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Staff_Of_The_Master) Then
                new_item_name = """" & "item_ultimate_scepter" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Monkey_Courier) Then
                new_item_name = """" & "item_courier" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Ring_Of_Sorcery) Then
                new_item_name = """" & "item_arcane_boots" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Insanitarius) Then
                new_item_name = """" & "item_armlet" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Daemonic_Breastplate) Then
                new_item_name = """" & "item_assault" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Runed_Axe) Then
                new_item_name = """" & "item_bfury" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Bolstering_Armband) Then
                new_item_name = """" & "item_black_king_bar" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Shrunken_Head) Then
                new_item_name = """" & "item_belt_of_strength" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Barbed_Armor) Then
                new_item_name = """" & "item_blade_mail" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Quickblade) Then
                new_item_name = """" & "item_blade_of_alacrity" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Sacrificial_Stone) Then
                new_item_name = """" & "item_bloodstone" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Fleet_Feet) Then
                new_item_name = """" & "item_boots_of_elves" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Marchers) Then
                new_item_name = """" & "item_boots" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Post_Haste) Then
                new_item_name = """" & "item_travel_boots" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Bottle) Then
                new_item_name = """" & "item_bottle" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Fortified_Bracelet) Then
                new_item_name = """" & "item_bracer" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Broadsword) Then
                new_item_name = """" & "item_broadsword" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Shield_Of_The_Five) Then
                new_item_name = """" & "item_buckler" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Wingbow) Then
                new_item_name = """" & "item_butterfly" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Ringmail) Then
                new_item_name = """" & "item_chainmail" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Pretenders_Crown) Then
                new_item_name = """" & "item_circlet" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Mana_Potion) Then
                new_item_name = """" & "item_clarity" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Bastard_Sword) Then
                new_item_name = """" & "item_claymore" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Mystic_Vestments) Then
                new_item_name = """" & "item_cloak" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Riftshards) Then
                new_item_name = """" & "item_lesser_crit" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Daedalus) Then
                new_item_name = """" & "item_greater_crit" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Codex) Then
                new_item_name = """" & "item_dagon" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Codex2) Then
                new_item_name = """" & "item_dagon_2" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Codex3) Then
                new_item_name = """" & "item_dagon_3" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Codex4) Then
                new_item_name = """" & "item_dagon_4" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Codex5) Then
                new_item_name = """" & "item_dagon_5" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Slayer) Then
                new_item_name = """" & "item_demon_edge" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Shieldbreaker) Then
                new_item_name = """" & "item_desolator" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Nullfire_Blade) Then
                new_item_name = """" & "item_diffusal_blade" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Nullfire_Blade2) Then
                new_item_name = """" & "item_diffusal_blade_2" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Doombringer) Then
                new_item_name = """" & "item_rapier" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Drum_of_Endurance) Then
                new_item_name = """" & "item_ancient_janggo" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Dust_Of_Revelation) Then
                new_item_name = """" & "item_dust" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Dancing_Blade) Then
                new_item_name = """" & "item_eagle" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Pickled_Brain) Then
                new_item_name = """" & "item_energy_booster" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Ethereal_Blade) Then
                new_item_name = """" & "item_ethereal_blade" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Stormspirit) Then
                new_item_name = """" & "item_cyclone" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Frostwolfs_Skull) Then
                new_item_name = """" & "item_skadi" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Winged_Courier) Then
                new_item_name = """" & "item_flying_courier" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Tablet_of_Command) Then
                new_item_name = """" & "item_force_staff" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Crushing_Claws) Then
                new_item_name = """" & "item_gauntlets" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Bound_Eye) Then
                new_item_name = """" & "item_gem" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Void_Talisman) Then
                new_item_name = """" & "item_ghost" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Gloves_of_the_Swift) Then
                new_item_name = """" & "item_gloves" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Alchemist_Bones) Then
                new_item_name = """" & "item_hand_of_midas" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Refreshing_Ornament) Then
                new_item_name = """" & "item_headdress" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Health_Potion) Then
                new_item_name = """" & "item_flask" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Behemoths_Hearth) Then
                new_item_name = """" & "item_heart" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Helm_Of_The_Victim) Then
                new_item_name = """" & "item_helm_of_iron_will" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Whispering_Helm) Then
                new_item_name = """" & "item_helm_of_the_dominator" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Shamans_Headress) Then
                new_item_name = """" & "item_hood_of_defiance" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Warpcleft) Then
                new_item_name = """" & "item_hyperstone" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Minor_Totem) Then
                new_item_name = """" & "item_branches" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Halberd) Then
                new_item_name = """" & "item_javelin" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Null_Stone) Then
                new_item_name = """" & "item_sphere" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Thunderclaw) Then
                new_item_name = """" & "item_maelstrom" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Mana_Battery) Then
                new_item_name = """" & "item_magic_stick" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Power_Supply) Then
                new_item_name = """" & "item_magic_wand" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Geometers_Bane) Then
                new_item_name = """" & "item_manta" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Mark_Of_The_Novice) Then
                new_item_name = """" & "item_mantle" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Elder_Parasite) Then
                new_item_name = """" & "item_mask_of_madness" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Medallion_of_Courage) Then
                new_item_name = """" & "item_medallion_of_courage" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Astrolabe) Then
                new_item_name = """" & "item_mekansm" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Warhammer) Then
                new_item_name = """" & "item_mithril_hammer" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Charged_Hammer) Then
                new_item_name = """" & "item_mjollnir" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Savage_Mace) Then
                new_item_name = """" & "item_monkey_king_bar" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Hungry_Spirit) Then
                new_item_name = """" & "item_lifesteal" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Acolytes_Staff) Then
                new_item_name = """" & "item_mystic_staff" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Puzzlebox) Then
                new_item_name = """" & "item_necronomicon" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Puzzlebox2) Then
                new_item_name = """" & "item_necronomicon_2" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Puzzlebox3) Then
                new_item_name = """" & "item_necronomicon_3" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Talisman_Of_Exile) Then
                new_item_name = """" & "item_null_talisman" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Great_Arcana) Then
                new_item_name = """" & "item_oblivion_staff" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Wards_of_Sight) Then
                new_item_name = """" & "item_ward_observer" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Mighty_Blade) Then
                new_item_name = """" & "item_ogre_axe" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Orb_of_Venom) Then
                new_item_name = """" & "item_orb_of_venom" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Hellflower) Then
                new_item_name = """" & "item_orchid" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Sustainer) Then
                new_item_name = """" & "item_pers" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Enhanced_Marchers) Then
                new_item_name = """" & "item_phase_boots" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Barrier_Idol) Then
                new_item_name = """" & "item_pipe" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Platemail) Then
                new_item_name = """" & "item_platemail" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Glowstone) Then
                new_item_name = """" & "item_point_booster" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Iron_Shield) Then
                new_item_name = """" & "item_poor_mans_shield" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Steamboots_Strength) Then
                new_item_name = """" & "item_power_treads" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Steamstaff) Then
                new_item_name = """" & "item_quarterstaff" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Loggers_Hatchet) Then
                new_item_name = """" & "item_quelling_blade" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Mock_of_Brilliance) Then
                new_item_name = """" & "item_radiance" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Axe_Of_The_Malphai) Then
                new_item_name = """" & "item_reaver" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Restoration_Stone) Then
                new_item_name = """" & "item_refresher" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Ring_Of_The_Teacher) Then
                new_item_name = """" & "item_ring_of_basilius" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Lifetube) Then
                new_item_name = """" & "item_ring_of_health" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Guardian_Ring) Then
                new_item_name = """" & "item_ring_of_protection" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Trinket_Of_Restoration) Then
                new_item_name = """" & "item_ring_of_regen" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Apprentices_Robe) Then
                new_item_name = """" & "item_robe" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Sword_Of_The_High) Then
                new_item_name = """" & "item_relic" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Scarab) Then
                new_item_name = """" & "item_sobi_mask" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Icebrand) Then
                new_item_name = """" & "item_sange" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Frostburn) Then
                new_item_name = """" & "item_sange_and_yasha" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Symbol_Of_Rage) Then
                new_item_name = """" & "item_satanic" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Kuldras_Sheepstick) Then
                new_item_name = """" & "item_sheepstick" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Wards_of_Revelation) Then
                new_item_name = """" & "item_ward_sentry" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Shroud_Of_The_Assasin) Then
                new_item_name = """" & "item_invis_sword" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Frostfield_Plate) Then
                new_item_name = """" & "item_shivas_guard" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Brutalizer) Then
                new_item_name = """" & "item_basher" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Duck_Boots) Then
                new_item_name = """" & "item_slippers" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Smoke_of_Deceit) Then
                new_item_name = """" & "item_smoke_of_deceit" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Icon_Of_The_Goddess) Then
                new_item_name = """" & "item_soul_booster" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Blood_Chalice) Then
                new_item_name = """" & "item_soul_ring" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Neophytes_Book) Then
                new_item_name = """" & "item_staff_of_wizardry" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Iron_Buckler) Then
                new_item_name = """" & "item_stout_shield" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Snake_Bracelet) Then
                new_item_name = """" & "item_talisman_of_evasion" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Runes_Of_The_Blight) Then
                new_item_name = """" & "item_tango" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Homecoming_Stone) Then
                new_item_name = """" & "item_tpscroll" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Blessed_Orb) Then
                new_item_name = """" & "item_ultimate_orb" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Urn_of_Shadows) Then
                new_item_name = """" & "item_urn_of_shadows" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Helm_Of_The_Black_Legion) Then
                new_item_name = """" & "item_vanguard" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Veil_of_Discord) Then
                new_item_name = """" & "item_veil_of_discord" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Beastheart) Then
                new_item_name = """" & "item_vitality_booster" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Abyssal_Skull) Then
                new_item_name = """" & "item_vladmir" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Manatube) Then
                new_item_name = """" & "item_void_stone" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Soulscream_Ring) Then
                new_item_name = """" & "item_wraith_band" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Firebrand) Then
                new_item_name = """" & "item_yasha" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Abyssal_Blade) Then
                new_item_name = """" & "item_abyssal_blade" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Heaven_s_Halberd) Then
                new_item_name = """" & "item_heavens_halberd" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Ring_of_Aquila) Then
                new_item_name = """" & "item_ring_of_aquila" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Rod_of_Atos) Then
                new_item_name = """" & "item_rod_of_atos" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources.HoN_Striders) Then
                new_item_name = """" & "item_tranquil_boots" & """"
                Return new_item_name
            Else
                new_item_name = ""
                Return new_item_name
            End If
        Else
            If doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Blink_Dagger) Then
                new_item_name = """" & "item_blink" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Blades_of_Attack) Then
                new_item_name = """" & "item_blades_of_attack" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Aghanim_s_Scepter) Then
                new_item_name = """" & "item_ultimate_scepter" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Animal_Courier) Then
                new_item_name = """" & "item_courier" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Arcane_Boots) Then
                new_item_name = """" & "item_arcane_boots" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Armlet) Then
                new_item_name = """" & "item_armlet" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Assault_Cuirass) Then
                new_item_name = """" & "item_assault" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Battle_Fury) Then
                new_item_name = """" & "item_bfury" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Black_King_Bar) Then
                new_item_name = """" & "item_black_king_bar" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Belt_of_Strength) Then
                new_item_name = """" & "item_belt_of_strength" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Blade_Mail) Then
                new_item_name = """" & "item_blade_mail" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Blade_of_Alacrity) Then
                new_item_name = """" & "item_blade_of_alacrity" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Bloodstone) Then
                new_item_name = """" & "item_bloodstone" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Boots_of_Elvenskin) Then
                new_item_name = """" & "item_boots_of_elves" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Boots_of_Speed) Then
                new_item_name = """" & "item_boots" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Boots_of_Travel) Then
                new_item_name = """" & "item_travel_boots" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Bottle) Then
                new_item_name = """" & "item_bottle" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Bracer) Then
                new_item_name = """" & "item_bracer" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Broadsword) Then
                new_item_name = """" & "item_broadsword" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Buckler) Then
                new_item_name = """" & "item_buckler" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Butterfly) Then
                new_item_name = """" & "item_butterfly" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Chainmail) Then
                new_item_name = """" & "item_chainmail" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Circlet) Then
                new_item_name = """" & "item_circlet" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Clarity) Then
                new_item_name = """" & "item_clarity" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Claymore) Then
                new_item_name = """" & "item_claymore" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Cloak) Then
                new_item_name = """" & "item_cloak" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Crystalys) Then
                new_item_name = """" & "item_lesser_crit" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Daedalus) Then
                new_item_name = """" & "item_greater_crit" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Dagon) Then
                new_item_name = """" & "item_dagon" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Dagon2) Then
                new_item_name = """" & "item_dagon_2" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Dagon3) Then
                new_item_name = """" & "item_dagon_3" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Dagon4) Then
                new_item_name = """" & "item_dagon_4" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Dagon5) Then
                new_item_name = """" & "item_dagon_5" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Demon_Edge) Then
                new_item_name = """" & "item_demon_edge" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Desolator) Then
                new_item_name = """" & "item_desolator" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Diffusal_Blade) Then
                new_item_name = """" & "item_diffusal_blade" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Diffusal_Blade2) Then
                new_item_name = """" & "item_diffusal_blade_2" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Divine_Rapier) Then
                new_item_name = """" & "item_rapier" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Drum_of_Endurance) Then
                new_item_name = """" & "item_ancient_janggo" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Dust_of_Appearance) Then
                new_item_name = """" & "item_dust" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Eaglesong) Then
                new_item_name = """" & "item_eagle" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Energy_Booster) Then
                new_item_name = """" & "item_energy_booster" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Ethereal_Blade) Then
                new_item_name = """" & "item_ethereal_blade" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Eul_s_Scepter_of_Divinity) Then
                new_item_name = """" & "item_cyclone" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Eye_of_Skadi) Then
                new_item_name = """" & "item_skadi" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Flying_Courier) Then
                new_item_name = """" & "item_flying_courier" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Force_Staff) Then
                new_item_name = """" & "item_force_staff" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Gauntlets_of_Strength) Then
                new_item_name = """" & "item_gauntlets" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Gem_of_True_Sight) Then
                new_item_name = """" & "item_gem" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Ghost_Scepter) Then
                new_item_name = """" & "item_ghost" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Gloves_of_Haste) Then
                new_item_name = """" & "item_gloves" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Hand_of_Midas) Then
                new_item_name = """" & "item_hand_of_midas" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Headdress) Then
                new_item_name = """" & "item_headdress" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Healing_Salve) Then
                new_item_name = """" & "item_flask" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Heart_of_Tarrasque) Then
                new_item_name = """" & "item_heart" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Helm_of_Iron_Will) Then
                new_item_name = """" & "item_helm_of_iron_will" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Helm_of_the_Dominator) Then
                new_item_name = """" & "item_helm_of_the_dominator" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Hood_of_Defiance) Then
                new_item_name = """" & "item_hood_of_defiance" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Hyperstone) Then
                new_item_name = """" & "item_hyperstone" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Iron_Branch) Then
                new_item_name = """" & "item_branches" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Javelin) Then
                new_item_name = """" & "item_javelin" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Linken_s_Sphere) Then
                new_item_name = """" & "item_sphere" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Maelstrom) Then
                new_item_name = """" & "item_maelstrom" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Magic_Stick) Then
                new_item_name = """" & "item_magic_stick" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Magic_Wand) Then
                new_item_name = """" & "item_magic_wand" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Manta_Style) Then
                new_item_name = """" & "item_manta" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Mantle_of_Intelligence) Then
                new_item_name = """" & "item_mantle" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Mask_of_Madness) Then
                new_item_name = """" & "item_mask_of_madness" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Medallion_of_Courage) Then
                new_item_name = """" & "item_medallion_of_courage" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Mekansm) Then
                new_item_name = """" & "item_mekansm" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Mithril_Hammer) Then
                new_item_name = """" & "item_mithril_hammer" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Mjollnir) Then
                new_item_name = """" & "item_mjollnir" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Monkey_King_Bar) Then
                new_item_name = """" & "item_monkey_king_bar" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Morbid_Mask) Then
                new_item_name = """" & "item_lifesteal" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Mystic_Staff) Then
                new_item_name = """" & "item_mystic_staff" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Necronomicon) Then
                new_item_name = """" & "item_necronomicon" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Necronomicon2) Then
                new_item_name = """" & "item_necronomicon_2" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Necronomicon3) Then
                new_item_name = """" & "item_necronomicon_3" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Null_Talisman) Then
                new_item_name = """" & "item_null_talisman" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Oblivion_Staff) Then
                new_item_name = """" & "item_oblivion_staff" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Observer_Ward) Then
                new_item_name = """" & "item_ward_observer" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Ogre_Club) Then
                new_item_name = """" & "item_ogre_axe" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Orb_of_Venom) Then
                new_item_name = """" & "item_orb_of_venom" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Orchid_Malevolence) Then
                new_item_name = """" & "item_orchid" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Perseverance) Then
                new_item_name = """" & "item_pers" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Phase_Boots) Then
                new_item_name = """" & "item_phase_boots" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Pipe_of_Insight) Then
                new_item_name = """" & "item_pipe" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Platemail) Then
                new_item_name = """" & "item_platemail" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Point_Booster) Then
                new_item_name = """" & "item_point_booster" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Poor_Man_s_Shield) Then
                new_item_name = """" & "item_poor_mans_shield" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Power_Treads) Then
                new_item_name = """" & "item_power_treads" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Quarterstaff) Then
                new_item_name = """" & "item_quarterstaff" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Quelling_Blade) Then
                new_item_name = """" & "item_quelling_blade" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Radiance) Then
                new_item_name = """" & "item_radiance" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Reaver) Then
                new_item_name = """" & "item_reaver" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Refresher_Orb) Then
                new_item_name = """" & "item_refresher" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Ring_of_Basilius) Then
                new_item_name = """" & "item_ring_of_basilius" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Ring_of_Health) Then
                new_item_name = """" & "item_ring_of_health" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Ring_of_Protection) Then
                new_item_name = """" & "item_ring_of_protection" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Ring_of_Regen) Then
                new_item_name = """" & "item_ring_of_regen" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Robe_of_the_Magi) Then
                new_item_name = """" & "item_robe" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Sacred_Relic) Then
                new_item_name = """" & "item_relic" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Sage_s_Mask) Then
                new_item_name = """" & "item_sobi_mask" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Sange) Then
                new_item_name = """" & "item_sange" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Sange_and_Yasha) Then
                new_item_name = """" & "item_sange_and_yasha" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Satanic) Then
                new_item_name = """" & "item_satanic" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Scythe_of_Vyse) Then
                new_item_name = """" & "item_sheepstick" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Sentry_Ward) Then
                new_item_name = """" & "item_ward_sentry" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Shadow_Blade) Then
                new_item_name = """" & "item_invis_sword" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Shiva_s_Guard) Then
                new_item_name = """" & "item_shivas_guard" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Skull_Basher) Then
                new_item_name = """" & "item_basher" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Slippers_of_Agility) Then
                new_item_name = """" & "item_slippers" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Smoke_of_Deceit) Then
                new_item_name = """" & "item_smoke_of_deceit" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Soul_Booster) Then
                new_item_name = """" & "item_soul_booster" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Soul_Ring) Then
                new_item_name = """" & "item_soul_ring" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Staff_of_Wizardry) Then
                new_item_name = """" & "item_staff_of_wizardry" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Stout_Shield) Then
                new_item_name = """" & "item_stout_shield" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Talisman_of_Evasion) Then
                new_item_name = """" & "item_talisman_of_evasion" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Tango) Then
                new_item_name = """" & "item_tango" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Town_Portal_Scroll) Then
                new_item_name = """" & "item_tpscroll" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Ultimate_Orb) Then
                new_item_name = """" & "item_ultimate_orb" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Urn_of_Shadows) Then
                new_item_name = """" & "item_urn_of_shadows" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Vanguard) Then
                new_item_name = """" & "item_vanguard" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Veil_of_Discord) Then
                new_item_name = """" & "item_veil_of_discord" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Vitality_Booster) Then
                new_item_name = """" & "item_vitality_booster" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Vladmir_s_Offering) Then
                new_item_name = """" & "item_vladmir" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Void_Stone) Then
                new_item_name = """" & "item_void_stone" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Wraith_Band) Then
                new_item_name = """" & "item_wraith_band" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Yasha) Then
                new_item_name = """" & "item_yasha" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Abyssal_Blade) Then
                new_item_name = """" & "item_abyssal_blade" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Heaven_s_Halberd) Then
                new_item_name = """" & "item_heavens_halberd" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Ring_of_Aquila) Then
                new_item_name = """" & "item_ring_of_aquila" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Rod_of_Atos) Then
                new_item_name = """" & "item_rod_of_atos" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, D2RIC.My.Resources.Resources._40px_Tranquil_Boots) Then
                new_item_name = """" & "item_tranquil_boots" & """"
                Return new_item_name
            Else
                new_item_name = ""
                Return new_item_name
            End If
        End If
    End Function

    Public Function ChangePicture(ByVal item_name As String) As System.Drawing.Image
        Dim pic_res As System.Drawing.Image
        ' TODO: Rezepte hinzufügen
        If ComboBoxItemIcons.Text = "DotA 1" Then
            Select Case item_name
                Case "Blink Dagger"
                    pic_res = D2RIC.My.Resources.Resources.Kelensdagger
                    Return pic_res
                Case "Blades of Attack"
                    pic_res = D2RIC.My.Resources.Resources.Bladesofattack
                    Return pic_res
                Case "Aghanim's Scepter"
                    pic_res = D2RIC.My.Resources.Resources.Aghanimsscepter
                    Return pic_res
                Case "Animal Courier"
                    pic_res = D2RIC.My.Resources.Resources.Animalcourier
                    Return pic_res
                Case "Arcane Boots"
                    pic_res = D2RIC.My.Resources.Resources.ArcaneBoots
                    Return pic_res
                Case "Armlet"
                    pic_res = D2RIC.My.Resources.Resources.Armletofmordiggian
                    Return pic_res
                Case "Assault Cuirass"
                    pic_res = D2RIC.My.Resources.Resources.Assaultcuirass
                    Return pic_res
                Case "Battle Fury"
                    pic_res = D2RIC.My.Resources.Resources.Battlefury
                    Return pic_res
                Case "Belt of Strength"
                    pic_res = D2RIC.My.Resources.Resources.Beltofgiantstrength
                    Return pic_res
                Case "Black King Bar"
                    pic_res = D2RIC.My.Resources.Resources.Blackkingbar
                    Return pic_res
                Case "Blade Mail"
                    pic_res = D2RIC.My.Resources.Resources.Blademail
                    Return pic_res
                Case "Blade of Alacrity"
                    pic_res = D2RIC.My.Resources.Resources.Bladesofalacrity
                    Return pic_res
                Case "Bloodstone"
                    pic_res = D2RIC.My.Resources.Resources.Bloodstone
                    Return pic_res
                Case "Boots of Elvenskin"
                    pic_res = D2RIC.My.Resources.Resources.Bootsofelvenskin
                    Return pic_res
                Case "Boots of Speed"
                    pic_res = D2RIC.My.Resources.Resources.Bootsofspeed
                    Return pic_res
                Case "Boots of Travel"
                    pic_res = D2RIC.My.Resources.Resources.Bootsoftravel
                    Return pic_res
                Case "Bottle"
                    pic_res = D2RIC.My.Resources.Resources.Bottle
                    Return pic_res
                Case "Bracer"
                    pic_res = D2RIC.My.Resources.Resources.Bracer
                    Return pic_res
                Case "Broadsword"
                    pic_res = D2RIC.My.Resources.Resources.Broadsword
                    Return pic_res
                Case "Buckler"
                    pic_res = D2RIC.My.Resources.Resources.Nathrezimbuckler
                    Return pic_res
                Case "Butterfly"
                    pic_res = D2RIC.My.Resources.Resources.Butterfly
                    Return pic_res
                Case "Chainmail"
                    pic_res = D2RIC.My.Resources.Resources.Chainmail
                    Return pic_res
                Case "Circlet"
                    pic_res = D2RIC.My.Resources.Resources.Circletofnobility
                    Return pic_res
                Case "Clarity"
                    pic_res = D2RIC.My.Resources.Resources.Claritypotion
                    Return pic_res
                Case "Claymore"
                    pic_res = D2RIC.My.Resources.Resources.Claymore
                    Return pic_res
                Case "Cloak"
                    pic_res = D2RIC.My.Resources.Resources.Planeswalkerscloak
                    Return pic_res
                Case "Crystalys"
                    pic_res = D2RIC.My.Resources.Resources.Crystalys
                    Return pic_res
                Case "Daedalus"
                    pic_res = D2RIC.My.Resources.Resources.Burizadokyanon
                    Return pic_res
                Case "Dagon 1"
                    pic_res = D2RIC.My.Resources.Resources.Dagon
                    Return pic_res
                Case "Dagon 2"
                    pic_res = D2RIC.My.Resources.Resources.Dagon2
                    Return pic_res
                Case "Dagon 3"
                    pic_res = D2RIC.My.Resources.Resources.Dagon3
                    Return pic_res
                Case "Dagon 4"
                    pic_res = D2RIC.My.Resources.Resources.Dagon4
                    Return pic_res
                Case "Dagon 5"
                    pic_res = D2RIC.My.Resources.Resources.Dagon5
                    Return pic_res
                Case "Demon Edge"
                    pic_res = D2RIC.My.Resources.Resources.Demonedge
                    Return pic_res
                Case "Desolator"
                    pic_res = D2RIC.My.Resources.Resources.Stygiandesolator
                    Return pic_res
                Case "Diffusal Blade 1"
                    pic_res = D2RIC.My.Resources.Resources.Diffusalblade
                    Return pic_res
                Case "Diffusal Blade 2"
                    pic_res = D2RIC.My.Resources.Resources.Diffusalblade2
                    Return pic_res
                Case "Divine Rapier"
                    pic_res = D2RIC.My.Resources.Resources.Divinerapier
                    Return pic_res
                Case "Drum of Endurance"
                    pic_res = D2RIC.My.Resources.Resources.Ancientjanggoofendurance
                    Return pic_res
                Case "Dust of Appearance"
                    pic_res = D2RIC.My.Resources.Resources.Dustofappearance
                    Return pic_res
                Case "Eaglesong"
                    pic_res = D2RIC.My.Resources.Resources.Eaglehorn
                    Return pic_res
                Case "Energy Booster"
                    pic_res = D2RIC.My.Resources.Resources.Energybooster
                    Return pic_res
                Case "Ethereal Blade"
                    pic_res = D2RIC.My.Resources.Resources.Etheral_Blade
                    Return pic_res
                Case "Eul's Scepter of Divinity"
                    pic_res = D2RIC.My.Resources.Resources.Eulsscepterofdivinity
                    Return pic_res
                Case "Eye of Skadi"
                    pic_res = D2RIC.My.Resources.Resources.Eyeofskadi
                    Return pic_res
                Case "Flying Courier"
                    pic_res = D2RIC.My.Resources.Resources.Flyingcourier
                    Return pic_res
                Case "Force Staff"
                    pic_res = D2RIC.My.Resources.Resources.Forcestaff
                    Return pic_res
                Case "Gauntlets of Strength"
                    pic_res = D2RIC.My.Resources.Resources.Gauntletsofstrength
                    Return pic_res
                Case "Gem of True Sight"
                    pic_res = D2RIC.My.Resources.Resources.Gemoftruesight
                    Return pic_res
                Case "Ghost Scepter"
                    pic_res = D2RIC.My.Resources.Resources.Ghostscepter
                    Return pic_res
                Case "Gloves of Haste"
                    pic_res = D2RIC.My.Resources.Resources.Glovesofhaste
                    Return pic_res
                Case "Hand of Midas"
                    pic_res = D2RIC.My.Resources.Resources.Handofmidas
                    Return pic_res
                Case "Headdress"
                    pic_res = D2RIC.My.Resources.Resources.Headdressofrejuvenation
                    Return pic_res
                Case "Healing Salve"
                    pic_res = D2RIC.My.Resources.Resources.Healingsalve
                    Return pic_res
                Case "Heart of Tarrasque"
                    pic_res = D2RIC.My.Resources.Resources.Heartoftarrasque
                    Return pic_res
                Case "Helm of Iron Will"
                    pic_res = D2RIC.My.Resources.Resources.Helmofironwill
                    Return pic_res
                Case "Helm of the Dominator"
                    pic_res = D2RIC.My.Resources.Resources.Helmofthedominator
                    Return pic_res
                Case "Hood of Defiance"
                    pic_res = D2RIC.My.Resources.Resources.Hoodofdefiance
                    Return pic_res
                Case "Hyperstone"
                    pic_res = D2RIC.My.Resources.Resources.Hyperstone
                    Return pic_res
                Case "Iron Branch"
                    pic_res = D2RIC.My.Resources.Resources.Ironwoodbranch
                    Return pic_res
                Case "Javelin"
                    pic_res = D2RIC.My.Resources.Resources.Javelin
                    Return pic_res
                Case "Linken's Sphere"
                    pic_res = D2RIC.My.Resources.Resources.Linkenssphere
                    Return pic_res
                Case "Maelstrom"
                    pic_res = D2RIC.My.Resources.Resources.Maelstrom
                    Return pic_res
                Case "Magic Stick"
                    pic_res = D2RIC.My.Resources.Resources.Magicstick
                    Return pic_res
                Case "Magic Wand"
                    pic_res = D2RIC.My.Resources.Resources.Magicwand
                    Return pic_res
                Case "Manta Style"
                    pic_res = D2RIC.My.Resources.Resources.Mantastyle
                    Return pic_res
                Case "Mantle of Intelligence"
                    pic_res = D2RIC.My.Resources.Resources.Mantleofintelligence
                    Return pic_res
                Case "Mask of Madness"
                    pic_res = D2RIC.My.Resources.Resources.Maskofmadness
                    Return pic_res
                Case "Medallion of Courage"
                    pic_res = D2RIC.My.Resources.Resources.Medallionofcourage
                    Return pic_res
                Case "Mekansm"
                    pic_res = D2RIC.My.Resources.Resources.Mekansm
                    Return pic_res
                Case "Mithril Hammer"
                    pic_res = D2RIC.My.Resources.Resources.Mithrilhammer
                    Return pic_res
                Case "Mjollnir"
                    pic_res = D2RIC.My.Resources.Resources.Mjollnir
                    Return pic_res
                Case "Monkey King Bar"
                    pic_res = D2RIC.My.Resources.Resources.Monkeykingbar
                    Return pic_res
                Case "Morbid Mask"
                    pic_res = D2RIC.My.Resources.Resources.Maskofdeath
                    Return pic_res
                Case "Mystic Staff"
                    pic_res = D2RIC.My.Resources.Resources.Mysticstaff
                    Return pic_res
                Case "Necronomicon 1"
                    pic_res = D2RIC.My.Resources.Resources.Necronomicon
                    Return pic_res
                Case "Necronomicon 2"
                    pic_res = D2RIC.My.Resources.Resources.Necronomicon2
                    Return pic_res
                Case "Necronomicon 3"
                    pic_res = D2RIC.My.Resources.Resources.Necronomicon3
                    Return pic_res
                Case "Null Talisman"
                    pic_res = D2RIC.My.Resources.Resources.Nulltalisman
                    Return pic_res
                Case "Oblivion Staff"
                    pic_res = D2RIC.My.Resources.Resources.Oblivionstaff
                    Return pic_res
                Case "Observer Ward"
                    pic_res = D2RIC.My.Resources.Resources.Observerwards
                    Return pic_res
                Case "Ogre Club"
                    pic_res = D2RIC.My.Resources.Resources.Ogreaxe
                    Return pic_res
                Case "Orb of Venom"
                    pic_res = D2RIC.My.Resources.Resources.OrbOfVenom
                    Return pic_res
                Case "Orchid Malevolence"
                    pic_res = D2RIC.My.Resources.Resources.Orchidmalevolence
                    Return pic_res
                Case "Perseverance"
                    pic_res = D2RIC.My.Resources.Resources.Perseverance
                    Return pic_res
                Case "Phase Boots"
                    pic_res = D2RIC.My.Resources.Resources.Phaseboots
                    Return pic_res
                Case "Pipe of Insight"
                    pic_res = D2RIC.My.Resources.Resources.Khadgarspipeofinsight
                    Return pic_res
                Case "Platemail"
                    pic_res = D2RIC.My.Resources.Resources.Platemail
                    Return pic_res
                Case "Point Booster"
                    pic_res = D2RIC.My.Resources.Resources.Pointbooster
                    Return pic_res
                Case "Poor Man's Shield"
                    pic_res = D2RIC.My.Resources.Resources.Poormansshield
                    Return pic_res
                Case "Power Treads"
                    pic_res = D2RIC.My.Resources.Resources.Powertreads
                    Return pic_res
                Case "Quarterstaff"
                    pic_res = D2RIC.My.Resources.Resources.Quarterstaff
                    Return pic_res
                Case "Quelling Blade"
                    pic_res = D2RIC.My.Resources.Resources.Quellingblade
                    Return pic_res
                Case "Radiance"
                    pic_res = D2RIC.My.Resources.Resources.Radiance
                    Return pic_res
                Case "Reaver"
                    pic_res = D2RIC.My.Resources.Resources.Messerschmidtsreaver
                    Return pic_res
                Case "Refresher Orb"
                    pic_res = D2RIC.My.Resources.Resources.Refresherorb
                    Return pic_res
                Case "Ring of Basilius"
                    pic_res = D2RIC.My.Resources.Resources.Ringofbasilius
                    Return pic_res
                Case "Ring of Health"
                    pic_res = D2RIC.My.Resources.Resources.Ringofhealth
                    Return pic_res
                Case "Ring of Protection"
                    pic_res = D2RIC.My.Resources.Resources.Ringofprotection
                    Return pic_res
                Case "Ring of Regen"
                    pic_res = D2RIC.My.Resources.Resources.Ringofregeneration
                    Return pic_res
                Case "Robe of the Magi"
                    pic_res = D2RIC.My.Resources.Resources.Robeofthemagi
                    Return pic_res
                Case "Sacred Relic"
                    pic_res = D2RIC.My.Resources.Resources.Sacredrelic
                    Return pic_res
                Case "Sage's Mask"
                    pic_res = D2RIC.My.Resources.Resources.Sobimask
                    Return pic_res
                Case "Sange"
                    pic_res = D2RIC.My.Resources.Resources.Sange
                    Return pic_res
                Case "Sange and Yasha"
                    pic_res = D2RIC.My.Resources.Resources.Sangeandyasha
                    Return pic_res
                Case "Satanic"
                    pic_res = D2RIC.My.Resources.Resources.Satanic
                    Return pic_res
                Case "Scythe of Vyse"
                    pic_res = D2RIC.My.Resources.Resources.Guinsoosscytheofvyse
                    Return pic_res
                Case "Sentry Ward"
                    pic_res = D2RIC.My.Resources.Resources.Sentrywards
                    Return pic_res
                Case "Shadow Blade"
                    pic_res = D2RIC.My.Resources.Resources.Lotharsedge
                    Return pic_res
                Case "Shiva's Guard"
                    pic_res = D2RIC.My.Resources.Resources.Shivasguard
                    Return pic_res
                Case "Skull Basher"
                    pic_res = D2RIC.My.Resources.Resources.Craniumbasher
                    Return pic_res
                Case "Slippers of Agility"
                    pic_res = D2RIC.My.Resources.Resources.Slippersofagility
                    Return pic_res
                Case "Smoke of Deceit"
                    pic_res = D2RIC.My.Resources.Resources.SmokeOfDeceit
                    Return pic_res
                Case "Soul Booster"
                    pic_res = D2RIC.My.Resources.Resources.Soulbooster
                    Return pic_res
                Case "Soul Ring"
                    pic_res = D2RIC.My.Resources.Resources.Soul_Ring
                    Return pic_res
                Case "Staff of Wizardry"
                    pic_res = D2RIC.My.Resources.Resources.Staffofwizardry
                    Return pic_res
                Case "Stout Shield"
                    pic_res = D2RIC.My.Resources.Resources.Stoutshield
                    Return pic_res
                Case "Talisman of Evasion"
                    pic_res = D2RIC.My.Resources.Resources.Talismanofevasion
                    Return pic_res
                Case "Tango"
                    pic_res = D2RIC.My.Resources.Resources.Ancienttangoofessifation
                    Return pic_res
                Case "Town Portal Scroll"
                    pic_res = D2RIC.My.Resources.Resources.Townportal
                    Return pic_res
                Case "Ultimate Orb"
                    pic_res = D2RIC.My.Resources.Resources.Ultimateorb
                    Return pic_res
                Case "Urn of Shadows"
                    pic_res = D2RIC.My.Resources.Resources.Urnofshadows
                    Return pic_res
                Case "Vanguard"
                    pic_res = D2RIC.My.Resources.Resources.Vanguard
                    Return pic_res
                Case "Veil of Discord"
                    pic_res = D2RIC.My.Resources.Resources.Fatalbonds
                    Return pic_res
                Case "Vitality Booster"
                    pic_res = D2RIC.My.Resources.Resources.Vitalitybooster
                    Return pic_res
                Case "Vladmir's Offering"
                    pic_res = D2RIC.My.Resources.Resources.Vladimirsoffering
                    Return pic_res
                Case "Void Stone"
                    pic_res = D2RIC.My.Resources.Resources.Voidstone
                    Return pic_res
                Case "Wraith Band"
                    pic_res = D2RIC.My.Resources.Resources.Wraithband
                    Return pic_res
                Case "Yasha"
                    pic_res = D2RIC.My.Resources.Resources.Yasha
                    Return pic_res
                Case "Abyssal Blade"
                    pic_res = D2RIC.My.Resources.Resources.AbyssalBlade
                    Return pic_res
                Case "Heaven's Halberd"
                    pic_res = D2RIC.My.Resources.Resources.Halberd
                    Return pic_res
                Case "Ring of Aquila"
                    pic_res = D2RIC.My.Resources.Resources.RingofAquila
                    Return pic_res
                Case "Rod of Atos"
                    pic_res = D2RIC.My.Resources.Resources.RodofAtos
                    Return pic_res
                Case "Tranquil Boots"
                    pic_res = D2RIC.My.Resources.Resources.TranquilBoots
                    Return pic_res
                Case Else
                    pic_res = D2RIC.My.Resources.Resources.none
                    Return pic_res
            End Select
        ElseIf ComboBoxItemIcons.Text = "HoN" Then
            Select Case item_name
                Case "Blink Dagger"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Portal_Key
                    Return pic_res
                Case "Blades of Attack"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Punchdagger
                    Return pic_res
                Case "Aghanim's Scepter"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Staff_Of_The_Master
                    Return pic_res
                Case "Animal Courier"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Monkey_Courier
                    Return pic_res
                Case "Arcane Boots"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Ring_Of_Sorcery
                    Return pic_res
                Case "Armlet"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Insanitarius
                    Return pic_res
                Case "Assault Cuirass"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Daemonic_Breastplate
                    Return pic_res
                Case "Battle Fury"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Runed_Axe
                    Return pic_res
                Case "Belt of Strength"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Bolstering_Armband
                    Return pic_res
                Case "Black King Bar"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Shrunken_Head
                    Return pic_res
                Case "Blade Mail"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Barbed_Armor
                    Return pic_res
                Case "Blade of Alacrity"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Quickblade
                    Return pic_res
                Case "Bloodstone"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Sacrificial_Stone
                    Return pic_res
                Case "Boots of Elvenskin"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Fleet_Feet
                    Return pic_res
                Case "Boots of Speed"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Marchers
                    Return pic_res
                Case "Boots of Travel"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Post_Haste
                    Return pic_res
                Case "Bottle"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Bottle
                    Return pic_res
                Case "Bracer"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Fortified_Bracelet
                    Return pic_res
                Case "Broadsword"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Broadsword
                    Return pic_res
                Case "Buckler"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Shield_Of_The_Five
                    Return pic_res
                Case "Butterfly"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Wingbow
                    Return pic_res
                Case "Chainmail"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Ringmail
                    Return pic_res
                Case "Circlet"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Pretenders_Crown
                    Return pic_res
                Case "Clarity"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Mana_Potion
                    Return pic_res
                Case "Claymore"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Bastard_Sword
                    Return pic_res
                Case "Cloak"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Mystic_Vestments
                    Return pic_res
                Case "Crystalys"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Riftshards
                    Return pic_res
                Case "Daedalus"
                    pic_res = D2RIC.My.Resources.Resources._40px_Daedalus
                    Return pic_res
                Case "Dagon 1"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Codex
                    Return pic_res
                Case "Dagon 2"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Codex2
                    Return pic_res
                Case "Dagon 3"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Codex3
                    Return pic_res
                Case "Dagon 4"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Codex4
                    Return pic_res
                Case "Dagon 5"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Codex5
                    Return pic_res
                Case "Demon Edge"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Slayer
                    Return pic_res
                Case "Desolator"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Shieldbreaker
                    Return pic_res
                Case "Diffusal Blade 1"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Nullfire_Blade
                    Return pic_res
                Case "Diffusal Blade 2"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Nullfire_Blade2
                    Return pic_res
                Case "Divine Rapier"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Doombringer
                    Return pic_res
                Case "Drum of Endurance"
                    pic_res = D2RIC.My.Resources.Resources._40px_Drum_of_Endurance
                    Return pic_res
                Case "Dust of Appearance"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Dust_Of_Revelation
                    Return pic_res
                Case "Eaglesong"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Dancing_Blade
                    Return pic_res
                Case "Energy Booster"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Pickled_Brain
                    Return pic_res
                Case "Ethereal Blade"
                    pic_res = D2RIC.My.Resources.Resources._40px_Ethereal_Blade
                    Return pic_res
                Case "Eul's Scepter of Divinity"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Stormspirit
                    Return pic_res
                Case "Eye of Skadi"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Frostwolfs_Skull
                    Return pic_res
                Case "Flying Courier"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Winged_Courier
                    Return pic_res
                Case "Force Staff"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Tablet_of_Command
                    Return pic_res
                Case "Gauntlets of Strength"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Crushing_Claws
                    Return pic_res
                Case "Gem of True Sight"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Bound_Eye
                    Return pic_res
                Case "Ghost Scepter"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Void_Talisman
                    Return pic_res
                Case "Gloves of Haste"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Gloves_of_the_Swift
                    Return pic_res
                Case "Hand of Midas"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Alchemist_Bones
                    Return pic_res
                Case "Headdress"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Refreshing_Ornament
                    Return pic_res
                Case "Healing Salve"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Health_Potion
                    Return pic_res
                Case "Heart of Tarrasque"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Behemoths_Hearth
                    Return pic_res
                Case "Helm of Iron Will"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Helm_Of_The_Victim
                    Return pic_res
                Case "Helm of the Dominator"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Whispering_Helm
                    Return pic_res
                Case "Hood of Defiance"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Shamans_Headress
                    Return pic_res
                Case "Hyperstone"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Warpcleft
                    Return pic_res
                Case "Iron Branch"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Minor_Totem
                    Return pic_res
                Case "Javelin"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Halberd
                    Return pic_res
                Case "Linken's Sphere"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Null_Stone
                    Return pic_res
                Case "Maelstrom"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Thunderclaw
                    Return pic_res
                Case "Magic Stick"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Mana_Battery
                    Return pic_res
                Case "Magic Wand"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Power_Supply
                    Return pic_res
                Case "Manta Style"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Geometers_Bane
                    Return pic_res
                Case "Mantle of Intelligence"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Mark_Of_The_Novice
                    Return pic_res
                Case "Mask of Madness"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Elder_Parasite
                    Return pic_res
                Case "Medallion of Courage"
                    pic_res = D2RIC.My.Resources.Resources._40px_Medallion_of_Courage
                    Return pic_res
                Case "Mekansm"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Astrolabe
                    Return pic_res
                Case "Mithril Hammer"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Warhammer
                    Return pic_res
                Case "Mjollnir"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Charged_Hammer
                    Return pic_res
                Case "Monkey King Bar"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Savage_Mace
                    Return pic_res
                Case "Morbid Mask"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Hungry_Spirit
                    Return pic_res
                Case "Mystic Staff"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Acolytes_Staff
                    Return pic_res
                Case "Necronomicon 1"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Puzzlebox
                    Return pic_res
                Case "Necronomicon 2"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Puzzlebox2
                    Return pic_res
                Case "Necronomicon 3"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Puzzlebox3
                    Return pic_res
                Case "Null Talisman"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Talisman_Of_Exile
                    Return pic_res
                Case "Oblivion Staff"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Great_Arcana
                    Return pic_res
                Case "Observer Ward"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Wards_of_Sight
                    Return pic_res
                Case "Ogre Club"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Mighty_Blade
                    Return pic_res
                Case "Orb of Venom"
                    pic_res = D2RIC.My.Resources.Resources._40px_Orb_of_Venom
                    Return pic_res
                Case "Orchid Malevolence"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Hellflower
                    Return pic_res
                Case "Perseverance"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Sustainer
                    Return pic_res
                Case "Phase Boots"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Enhanced_Marchers
                    Return pic_res
                Case "Pipe of Insight"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Barrier_Idol
                    Return pic_res
                Case "Platemail"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Platemail
                    Return pic_res
                Case "Point Booster"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Glowstone
                    Return pic_res
                Case "Poor Man's Shield"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Iron_Shield
                    Return pic_res
                Case "Power Treads"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Steamboots_Strength
                    Return pic_res
                Case "Quarterstaff"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Steamstaff
                    Return pic_res
                Case "Quelling Blade"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Loggers_Hatchet
                    Return pic_res
                Case "Radiance"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Mock_of_Brilliance
                    Return pic_res
                Case "Reaver"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Axe_Of_The_Malphai
                    Return pic_res
                Case "Refresher Orb"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Restoration_Stone
                    Return pic_res
                Case "Ring of Basilius"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Ring_Of_The_Teacher
                    Return pic_res
                Case "Ring of Health"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Lifetube
                    Return pic_res
                Case "Ring of Protection"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Guardian_Ring
                    Return pic_res
                Case "Ring of Regen"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Trinket_Of_Restoration
                    Return pic_res
                Case "Robe of the Magi"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Apprentices_Robe
                    Return pic_res
                Case "Sacred Relic"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Sword_Of_The_High
                    Return pic_res
                Case "Sage's Mask"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Scarab
                    Return pic_res
                Case "Sange"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Icebrand
                    Return pic_res
                Case "Sange and Yasha"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Frostburn
                    Return pic_res
                Case "Satanic"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Symbol_Of_Rage
                    Return pic_res
                Case "Scythe of Vyse"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Kuldras_Sheepstick
                    Return pic_res
                Case "Sentry Ward"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Wards_of_Revelation
                    Return pic_res
                Case "Shadow Blade"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Shroud_Of_The_Assasin
                    Return pic_res
                Case "Shiva's Guard"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Frostfield_Plate
                    Return pic_res
                Case "Skull Basher"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Brutalizer
                    Return pic_res
                Case "Slippers of Agility"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Duck_Boots
                    Return pic_res
                Case "Smoke of Deceit"
                    pic_res = D2RIC.My.Resources.Resources._40px_Smoke_of_Deceit
                    Return pic_res
                Case "Soul Booster"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Icon_Of_The_Goddess
                    Return pic_res
                Case "Soul Ring"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Blood_Chalice
                    Return pic_res
                Case "Staff of Wizardry"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Neophytes_Book
                    Return pic_res
                Case "Stout Shield"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Iron_Buckler
                    Return pic_res
                Case "Talisman of Evasion"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Snake_Bracelet
                    Return pic_res
                Case "Tango"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Runes_Of_The_Blight
                    Return pic_res
                Case "Town Portal Scroll"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Homecoming_Stone
                    Return pic_res
                Case "Ultimate Orb"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Blessed_Orb
                    Return pic_res
                Case "Urn of Shadows"
                    pic_res = D2RIC.My.Resources.Resources._40px_Urn_of_Shadows
                    Return pic_res
                Case "Vanguard"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Helm_Of_The_Black_Legion
                    Return pic_res
                Case "Veil of Discord"
                    pic_res = D2RIC.My.Resources.Resources._40px_Veil_of_Discord
                    Return pic_res
                Case "Vitality Booster"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Beastheart
                    Return pic_res
                Case "Vladmir's Offering"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Abyssal_Skull
                    Return pic_res
                Case "Void Stone"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Manatube
                    Return pic_res
                Case "Wraith Band"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Soulscream_Ring
                    Return pic_res
                Case "Yasha"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Firebrand
                    Return pic_res
                Case "Abyssal Blade"
                    pic_res = D2RIC.My.Resources.Resources._40px_Abyssal_Blade
                    Return pic_res
                Case "Heaven's Halberd"
                    pic_res = D2RIC.My.Resources.Resources._40px_Heaven_s_Halberd
                    Return pic_res
                Case "Ring of Aquila"
                    pic_res = D2RIC.My.Resources.Resources._40px_Ring_of_Aquila
                    Return pic_res
                Case "Rod of Atos"
                    pic_res = D2RIC.My.Resources.Resources._40px_Rod_of_Atos
                    Return pic_res
                Case "Tranquil Boots"
                    pic_res = D2RIC.My.Resources.Resources.HoN_Striders
                    Return pic_res
                Case Else
                    pic_res = D2RIC.My.Resources.Resources.none
                    Return pic_res
            End Select
        Else
            Select Case item_name
                Case "Blink Dagger"
                    pic_res = D2RIC.My.Resources.Resources._40px_Blink_Dagger
                    Return pic_res
                Case "Blades of Attack"
                    pic_res = D2RIC.My.Resources.Resources._40px_Blades_of_Attack
                    Return pic_res
                Case "Aghanim's Scepter"
                    pic_res = D2RIC.My.Resources.Resources._40px_Aghanim_s_Scepter
                    Return pic_res
                Case "Animal Courier"
                    pic_res = D2RIC.My.Resources.Resources._40px_Animal_Courier
                    Return pic_res
                Case "Arcane Boots"
                    pic_res = D2RIC.My.Resources.Resources._40px_Arcane_Boots
                    Return pic_res
                Case "Armlet"
                    pic_res = D2RIC.My.Resources.Resources._40px_Armlet
                    Return pic_res
                Case "Assault Cuirass"
                    pic_res = D2RIC.My.Resources.Resources._40px_Assault_Cuirass
                    Return pic_res
                Case "Battle Fury"
                    pic_res = D2RIC.My.Resources.Resources._40px_Battle_Fury
                    Return pic_res
                Case "Belt of Strength"
                    pic_res = D2RIC.My.Resources.Resources._40px_Belt_of_Strength
                    Return pic_res
                Case "Black King Bar"
                    pic_res = D2RIC.My.Resources.Resources._40px_Black_King_Bar
                    Return pic_res
                Case "Blade Mail"
                    pic_res = D2RIC.My.Resources.Resources._40px_Blade_Mail
                    Return pic_res
                Case "Blade of Alacrity"
                    pic_res = D2RIC.My.Resources.Resources._40px_Blade_of_Alacrity
                    Return pic_res
                Case "Bloodstone"
                    pic_res = D2RIC.My.Resources.Resources._40px_Bloodstone
                    Return pic_res
                Case "Boots of Elvenskin"
                    pic_res = D2RIC.My.Resources.Resources._40px_Boots_of_Elvenskin
                    Return pic_res
                Case "Boots of Speed"
                    pic_res = D2RIC.My.Resources.Resources._40px_Boots_of_Speed
                    Return pic_res
                Case "Boots of Travel"
                    pic_res = D2RIC.My.Resources.Resources._40px_Boots_of_Travel
                    Return pic_res
                Case "Bottle"
                    pic_res = D2RIC.My.Resources.Resources._40px_Bottle
                    Return pic_res
                Case "Bracer"
                    pic_res = D2RIC.My.Resources.Resources._40px_Bracer
                    Return pic_res
                Case "Broadsword"
                    pic_res = D2RIC.My.Resources.Resources._40px_Broadsword
                    Return pic_res
                Case "Buckler"
                    pic_res = D2RIC.My.Resources.Resources._40px_Buckler
                    Return pic_res
                Case "Butterfly"
                    pic_res = D2RIC.My.Resources.Resources._40px_Butterfly
                    Return pic_res
                Case "Chainmail"
                    pic_res = D2RIC.My.Resources.Resources._40px_Chainmail
                    Return pic_res
                Case "Circlet"
                    pic_res = D2RIC.My.Resources.Resources._40px_Circlet
                    Return pic_res
                Case "Clarity"
                    pic_res = D2RIC.My.Resources.Resources._40px_Clarity
                    Return pic_res
                Case "Claymore"
                    pic_res = D2RIC.My.Resources.Resources._40px_Claymore
                    Return pic_res
                Case "Cloak"
                    pic_res = D2RIC.My.Resources.Resources._40px_Cloak
                    Return pic_res
                Case "Crystalys"
                    pic_res = D2RIC.My.Resources.Resources._40px_Crystalys
                    Return pic_res
                Case "Daedalus"
                    pic_res = D2RIC.My.Resources.Resources._40px_Daedalus
                    Return pic_res
                Case "Dagon 1"
                    pic_res = D2RIC.My.Resources.Resources._40px_Dagon
                    Return pic_res
                Case "Dagon 2"
                    pic_res = D2RIC.My.Resources.Resources._40px_Dagon2
                    Return pic_res
                Case "Dagon 3"
                    pic_res = D2RIC.My.Resources.Resources._40px_Dagon3
                    Return pic_res
                Case "Dagon 4"
                    pic_res = D2RIC.My.Resources.Resources._40px_Dagon4
                    Return pic_res
                Case "Dagon 5"
                    pic_res = D2RIC.My.Resources.Resources._40px_Dagon5
                    Return pic_res
                Case "Demon Edge"
                    pic_res = D2RIC.My.Resources.Resources._40px_Demon_Edge
                    Return pic_res
                Case "Desolator"
                    pic_res = D2RIC.My.Resources.Resources._40px_Desolator
                    Return pic_res
                Case "Diffusal Blade 1"
                    pic_res = D2RIC.My.Resources.Resources._40px_Diffusal_Blade
                    Return pic_res
                Case "Diffusal Blade 2"
                    pic_res = D2RIC.My.Resources.Resources._40px_Diffusal_Blade2
                    Return pic_res
                Case "Divine Rapier"
                    pic_res = D2RIC.My.Resources.Resources._40px_Divine_Rapier
                    Return pic_res
                Case "Drum of Endurance"
                    pic_res = D2RIC.My.Resources.Resources._40px_Drum_of_Endurance
                    Return pic_res
                Case "Dust of Appearance"
                    pic_res = D2RIC.My.Resources.Resources._40px_Dust_of_Appearance
                    Return pic_res
                Case "Eaglesong"
                    pic_res = D2RIC.My.Resources.Resources._40px_Eaglesong
                    Return pic_res
                Case "Energy Booster"
                    pic_res = D2RIC.My.Resources.Resources._40px_Energy_Booster
                    Return pic_res
                Case "Ethereal Blade"
                    pic_res = D2RIC.My.Resources.Resources._40px_Ethereal_Blade
                    Return pic_res
                Case "Eul's Scepter of Divinity"
                    pic_res = D2RIC.My.Resources.Resources._40px_Eul_s_Scepter_of_Divinity
                    Return pic_res
                Case "Eye of Skadi"
                    pic_res = D2RIC.My.Resources.Resources._40px_Eye_of_Skadi
                    Return pic_res
                Case "Flying Courier"
                    pic_res = D2RIC.My.Resources.Resources._40px_Flying_Courier
                    Return pic_res
                Case "Force Staff"
                    pic_res = D2RIC.My.Resources.Resources._40px_Force_Staff
                    Return pic_res
                Case "Gauntlets of Strength"
                    pic_res = D2RIC.My.Resources.Resources._40px_Gauntlets_of_Strength
                    Return pic_res
                Case "Gem of True Sight"
                    pic_res = D2RIC.My.Resources.Resources._40px_Gem_of_True_Sight
                    Return pic_res
                Case "Ghost Scepter"
                    pic_res = D2RIC.My.Resources.Resources._40px_Ghost_Scepter
                    Return pic_res
                Case "Gloves of Haste"
                    pic_res = D2RIC.My.Resources.Resources._40px_Gloves_of_Haste
                    Return pic_res
                Case "Hand of Midas"
                    pic_res = D2RIC.My.Resources.Resources._40px_Hand_of_Midas
                    Return pic_res
                Case "Headdress"
                    pic_res = D2RIC.My.Resources.Resources._40px_Headdress
                    Return pic_res
                Case "Healing Salve"
                    pic_res = D2RIC.My.Resources.Resources._40px_Healing_Salve
                    Return pic_res
                Case "Heart of Tarrasque"
                    pic_res = D2RIC.My.Resources.Resources._40px_Heart_of_Tarrasque
                    Return pic_res
                Case "Helm of Iron Will"
                    pic_res = D2RIC.My.Resources.Resources._40px_Helm_of_Iron_Will
                    Return pic_res
                Case "Helm of the Dominator"
                    pic_res = D2RIC.My.Resources.Resources._40px_Helm_of_the_Dominator
                    Return pic_res
                Case "Hood of Defiance"
                    pic_res = D2RIC.My.Resources.Resources._40px_Hood_of_Defiance
                    Return pic_res
                Case "Hyperstone"
                    pic_res = D2RIC.My.Resources.Resources._40px_Hyperstone
                    Return pic_res
                Case "Iron Branch"
                    pic_res = D2RIC.My.Resources.Resources._40px_Iron_Branch
                    Return pic_res
                Case "Javelin"
                    pic_res = D2RIC.My.Resources.Resources._40px_Javelin
                    Return pic_res
                Case "Linken's Sphere"
                    pic_res = D2RIC.My.Resources.Resources._40px_Linken_s_Sphere
                    Return pic_res
                Case "Maelstrom"
                    pic_res = D2RIC.My.Resources.Resources._40px_Maelstrom
                    Return pic_res
                Case "Magic Stick"
                    pic_res = D2RIC.My.Resources.Resources._40px_Magic_Stick
                    Return pic_res
                Case "Magic Wand"
                    pic_res = D2RIC.My.Resources.Resources._40px_Magic_Wand
                    Return pic_res
                Case "Manta Style"
                    pic_res = D2RIC.My.Resources.Resources._40px_Manta_Style
                    Return pic_res
                Case "Mantle of Intelligence"
                    pic_res = D2RIC.My.Resources.Resources._40px_Mantle_of_Intelligence
                    Return pic_res
                Case "Mask of Madness"
                    pic_res = D2RIC.My.Resources.Resources._40px_Mask_of_Madness
                    Return pic_res
                Case "Medallion of Courage"
                    pic_res = D2RIC.My.Resources.Resources._40px_Medallion_of_Courage
                    Return pic_res
                Case "Mekansm"
                    pic_res = D2RIC.My.Resources.Resources._40px_Mekansm
                    Return pic_res
                Case "Mithril Hammer"
                    pic_res = D2RIC.My.Resources.Resources._40px_Mithril_Hammer
                    Return pic_res
                Case "Mjollnir"
                    pic_res = D2RIC.My.Resources.Resources._40px_Mjollnir
                    Return pic_res
                Case "Monkey King Bar"
                    pic_res = D2RIC.My.Resources.Resources._40px_Monkey_King_Bar
                    Return pic_res
                Case "Morbid Mask"
                    pic_res = D2RIC.My.Resources.Resources._40px_Morbid_Mask
                    Return pic_res
                Case "Mystic Staff"
                    pic_res = D2RIC.My.Resources.Resources._40px_Mystic_Staff
                    Return pic_res
                Case "Necronomicon 1"
                    pic_res = D2RIC.My.Resources.Resources._40px_Necronomicon
                    Return pic_res
                Case "Necronomicon 2"
                    pic_res = D2RIC.My.Resources.Resources._40px_Necronomicon2
                    Return pic_res
                Case "Necronomicon 3"
                    pic_res = D2RIC.My.Resources.Resources._40px_Necronomicon3
                    Return pic_res
                Case "Null Talisman"
                    pic_res = D2RIC.My.Resources.Resources._40px_Null_Talisman
                    Return pic_res
                Case "Oblivion Staff"
                    pic_res = D2RIC.My.Resources.Resources._40px_Oblivion_Staff
                    Return pic_res
                Case "Observer Ward"
                    pic_res = D2RIC.My.Resources.Resources._40px_Observer_Ward
                    Return pic_res
                Case "Ogre Club"
                    pic_res = D2RIC.My.Resources.Resources._40px_Ogre_Club
                    Return pic_res
                Case "Orb of Venom"
                    pic_res = D2RIC.My.Resources.Resources._40px_Orb_of_Venom
                    Return pic_res
                Case "Orchid Malevolence"
                    pic_res = D2RIC.My.Resources.Resources._40px_Orchid_Malevolence
                    Return pic_res
                Case "Perseverance"
                    pic_res = D2RIC.My.Resources.Resources._40px_Perseverance
                    Return pic_res
                Case "Phase Boots"
                    pic_res = D2RIC.My.Resources.Resources._40px_Phase_Boots
                    Return pic_res
                Case "Pipe of Insight"
                    pic_res = D2RIC.My.Resources.Resources._40px_Pipe_of_Insight
                    Return pic_res
                Case "Platemail"
                    pic_res = D2RIC.My.Resources.Resources._40px_Platemail
                    Return pic_res
                Case "Point Booster"
                    pic_res = D2RIC.My.Resources.Resources._40px_Point_Booster
                    Return pic_res
                Case "Poor Man's Shield"
                    pic_res = D2RIC.My.Resources.Resources._40px_Poor_Man_s_Shield
                    Return pic_res
                Case "Power Treads"
                    pic_res = D2RIC.My.Resources.Resources._40px_Power_Treads
                    Return pic_res
                Case "Quarterstaff"
                    pic_res = D2RIC.My.Resources.Resources._40px_Quarterstaff
                    Return pic_res
                Case "Quelling Blade"
                    pic_res = D2RIC.My.Resources.Resources._40px_Quelling_Blade
                    Return pic_res
                Case "Radiance"
                    pic_res = D2RIC.My.Resources.Resources._40px_Radiance
                    Return pic_res
                Case "Reaver"
                    pic_res = D2RIC.My.Resources.Resources._40px_Reaver
                    Return pic_res
                Case "Refresher Orb"
                    pic_res = D2RIC.My.Resources.Resources._40px_Refresher_Orb
                    Return pic_res
                Case "Ring of Basilius"
                    pic_res = D2RIC.My.Resources.Resources._40px_Ring_of_Basilius
                    Return pic_res
                Case "Ring of Health"
                    pic_res = D2RIC.My.Resources.Resources._40px_Ring_of_Health
                    Return pic_res
                Case "Ring of Protection"
                    pic_res = D2RIC.My.Resources.Resources._40px_Ring_of_Protection
                    Return pic_res
                Case "Ring of Regen"
                    pic_res = D2RIC.My.Resources.Resources._40px_Ring_of_Regen
                    Return pic_res
                Case "Robe of the Magi"
                    pic_res = D2RIC.My.Resources.Resources._40px_Robe_of_the_Magi
                    Return pic_res
                Case "Sacred Relic"
                    pic_res = D2RIC.My.Resources.Resources._40px_Sacred_Relic
                    Return pic_res
                Case "Sage's Mask"
                    pic_res = D2RIC.My.Resources.Resources._40px_Sage_s_Mask
                    Return pic_res
                Case "Sange"
                    pic_res = D2RIC.My.Resources.Resources._40px_Sange
                    Return pic_res
                Case "Sange and Yasha"
                    pic_res = D2RIC.My.Resources.Resources._40px_Sange_and_Yasha
                    Return pic_res
                Case "Satanic"
                    pic_res = D2RIC.My.Resources.Resources._40px_Satanic
                    Return pic_res
                Case "Scythe of Vyse"
                    pic_res = D2RIC.My.Resources.Resources._40px_Scythe_of_Vyse
                    Return pic_res
                Case "Sentry Ward"
                    pic_res = D2RIC.My.Resources.Resources._40px_Sentry_Ward
                    Return pic_res
                Case "Shadow Blade"
                    pic_res = D2RIC.My.Resources.Resources._40px_Shadow_Blade
                    Return pic_res
                Case "Shiva's Guard"
                    pic_res = D2RIC.My.Resources.Resources._40px_Shiva_s_Guard
                    Return pic_res
                Case "Skull Basher"
                    pic_res = D2RIC.My.Resources.Resources._40px_Skull_Basher
                    Return pic_res
                Case "Slippers of Agility"
                    pic_res = D2RIC.My.Resources.Resources._40px_Slippers_of_Agility
                    Return pic_res
                Case "Smoke of Deceit"
                    pic_res = D2RIC.My.Resources.Resources._40px_Smoke_of_Deceit
                    Return pic_res
                Case "Soul Booster"
                    pic_res = D2RIC.My.Resources.Resources._40px_Soul_Booster
                    Return pic_res
                Case "Soul Ring"
                    pic_res = D2RIC.My.Resources.Resources._40px_Soul_Ring
                    Return pic_res
                Case "Staff of Wizardry"
                    pic_res = D2RIC.My.Resources.Resources._40px_Staff_of_Wizardry
                    Return pic_res
                Case "Stout Shield"
                    pic_res = D2RIC.My.Resources.Resources._40px_Stout_Shield
                    Return pic_res
                Case "Talisman of Evasion"
                    pic_res = D2RIC.My.Resources.Resources._40px_Talisman_of_Evasion
                    Return pic_res
                Case "Tango"
                    pic_res = D2RIC.My.Resources.Resources._40px_Tango
                    Return pic_res
                Case "Town Portal Scroll"
                    pic_res = D2RIC.My.Resources.Resources._40px_Town_Portal_Scroll
                    Return pic_res
                Case "Ultimate Orb"
                    pic_res = D2RIC.My.Resources.Resources._40px_Ultimate_Orb
                    Return pic_res
                Case "Urn of Shadows"
                    pic_res = D2RIC.My.Resources.Resources._40px_Urn_of_Shadows
                    Return pic_res
                Case "Vanguard"
                    pic_res = D2RIC.My.Resources.Resources._40px_Vanguard
                    Return pic_res
                Case "Veil of Discord"
                    pic_res = D2RIC.My.Resources.Resources._40px_Veil_of_Discord
                    Return pic_res
                Case "Vitality Booster"
                    pic_res = D2RIC.My.Resources.Resources._40px_Vitality_Booster
                    Return pic_res
                Case "Vladmir's Offering"
                    pic_res = D2RIC.My.Resources.Resources._40px_Vladmir_s_Offering
                    Return pic_res
                Case "Void Stone"
                    pic_res = D2RIC.My.Resources.Resources._40px_Void_Stone
                    Return pic_res
                Case "Wraith Band"
                    pic_res = D2RIC.My.Resources.Resources._40px_Wraith_Band
                    Return pic_res
                Case "Yasha"
                    pic_res = D2RIC.My.Resources.Resources._40px_Yasha
                    Return pic_res
                Case "Abyssal Blade"
                    pic_res = D2RIC.My.Resources.Resources._40px_Abyssal_Blade
                    Return pic_res
                Case "Heaven's Halberd"
                    pic_res = D2RIC.My.Resources.Resources._40px_Heaven_s_Halberd
                    Return pic_res
                Case "Ring of Aquila"
                    pic_res = D2RIC.My.Resources.Resources._40px_Ring_of_Aquila
                    Return pic_res
                Case "Rod of Atos"
                    pic_res = D2RIC.My.Resources.Resources._40px_Rod_of_Atos
                    Return pic_res
                Case "Tranquil Boots"
                    pic_res = D2RIC.My.Resources.Resources._40px_Tranquil_Boots
                    Return pic_res
                Case Else
                    pic_res = D2RIC.My.Resources.Resources.none
                    Return pic_res
            End Select
        End If
    End Function

    Public Function PicRes2Name(ByVal img_res As System.Drawing.Bitmap) As String
        Dim pic_res As String
        If ComboBoxItemIcons.Text = "DotA 1" Then
            If doImagesMatch(img_res, D2RIC.My.Resources.Resources.Kelensdagger) Then
                pic_res = "Blink Dagger"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Bladesofattack) Then
                pic_res = "Blades of Attack"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Aghanimsscepter) Then
                pic_res = "Aghanim's Scepter"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Animalcourier) Then
                pic_res = "Animal Courier"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.ArcaneBoots) Then
                pic_res = "Arcane Boots"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Armletofmordiggian) Then
                pic_res = "Armlet"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Assaultcuirass) Then
                pic_res = "Assault Cuirass"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Battlefury) Then
                pic_res = "Battle Fury"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Beltofgiantstrength) Then
                pic_res = "Belt of Strength"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Blackkingbar) Then
                pic_res = "Black King Bar"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Blademail) Then
                pic_res = "Blade Mail"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Bladesofalacrity) Then
                pic_res = "Blade of Alacrity"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Bloodstone) Then
                pic_res = "Bloodstone"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Bootsofelvenskin) Then
                pic_res = "Boots of Elvenskin"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Bootsofspeed) Then
                pic_res = "Boots of Speed"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Bootsoftravel) Then
                pic_res = "Boots of Travel"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Bottle) Then
                pic_res = "Bottle"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Bracer) Then
                pic_res = "Bracer"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Broadsword) Then
                pic_res = "Broadsword"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Nathrezimbuckler) Then
                pic_res = "Buckler"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Butterfly) Then
                pic_res = "Butterfly"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Chainmail) Then
                pic_res = "Chainmail"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Circletofnobility) Then
                pic_res = "Circlet"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Claritypotion) Then
                pic_res = "Clarity"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Claymore) Then
                pic_res = "Claymore"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Planeswalkerscloak) Then
                pic_res = "Cloak"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Crystalys) Then
                pic_res = "Crystalys"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Burizadokyanon) Then
                pic_res = "Daedalus"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Dagon) Then
                pic_res = "Dagon 1"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Dagon2) Then
                pic_res = "Dagon 2"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Dagon3) Then
                pic_res = "Dagon 3"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Dagon4) Then
                pic_res = "Dagon 4"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Dagon5) Then
                pic_res = "Dagon 5"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Demonedge) Then
                pic_res = "Demon Edge"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Stygiandesolator) Then
                pic_res = "Desolator"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Diffusalblade) Then
                pic_res = "Diffusal Blade 1"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Diffusalblade2) Then
                pic_res = "Diffusal Blade 2"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Divinerapier) Then
                pic_res = "Divine Rapier"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Ancientjanggoofendurance) Then
                pic_res = "Drum of Endurance"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Dustofappearance) Then
                pic_res = "Dust of Appearance"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Eaglehorn) Then
                pic_res = "Eaglesong"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Energybooster) Then
                pic_res = "Energy Booster"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Etheral_Blade) Then
                pic_res = "Ethereal Blade"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Eulsscepterofdivinity) Then
                pic_res = "Eul's Scepter of Divinity"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Eyeofskadi) Then
                pic_res = "Eye of Skadi"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Flyingcourier) Then
                pic_res = "Flying Courier"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Forcestaff) Then
                pic_res = "Force Staff"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Gauntletsofstrength) Then
                pic_res = "Gauntlets of Strength"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Gemoftruesight) Then
                pic_res = "Gem of True Sight"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Ghostscepter) Then
                pic_res = "Ghost Scepter"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Glovesofhaste) Then
                pic_res = "Gloves of Haste"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Handofmidas) Then
                pic_res = "Hand of Midas"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Headdressofrejuvenation) Then
                pic_res = "Headdress"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Healingsalve) Then
                pic_res = "Healing Salve"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Heartoftarrasque) Then
                pic_res = "Heart of Tarrasque"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Helmofironwill) Then
                pic_res = "Helm of Iron Will"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Helmofthedominator) Then
                pic_res = "Helm of the Dominator"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Hoodofdefiance) Then
                pic_res = "Hood of Defiance"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Hyperstone) Then
                pic_res = "Hyperstone"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Ironwoodbranch) Then
                pic_res = "Iron Branch"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Javelin) Then
                pic_res = "Javelin"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Linkenssphere) Then
                pic_res = "Linken's Sphere"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Maelstrom) Then
                pic_res = "Maelstrom"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Magicstick) Then
                pic_res = "Magic Stick"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Magicwand) Then
                pic_res = "Magic Wand"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Mantastyle) Then
                pic_res = "Manta Style"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Mantleofintelligence) Then
                pic_res = "Mantle of Intelligence"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Maskofmadness) Then
                pic_res = "Mask of Madness"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Medallionofcourage) Then
                pic_res = "Medallion of Courage"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Mekansm) Then
                pic_res = "Mekansm"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Mithrilhammer) Then
                pic_res = "Mithril Hammer"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Mjollnir) Then
                pic_res = "Mjollnir"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Monkeykingbar) Then
                pic_res = "Monkey King Bar"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Maskofdeath) Then
                pic_res = "Morbid Mask"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Mysticstaff) Then
                pic_res = "Mystic Staff"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Necronomicon) Then
                pic_res = "Necronomicon 1"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Necronomicon2) Then
                pic_res = "Necronomicon 2"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Necronomicon3) Then
                pic_res = "Necronomicon 3"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Nulltalisman) Then
                pic_res = "Null Talisman"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Oblivionstaff) Then
                pic_res = "Oblivion Staff"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Observerwards) Then
                pic_res = "Observer Ward"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Ogreaxe) Then
                pic_res = "Ogre Club"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.OrbOfVenom) Then
                pic_res = "Orb of Venom"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Orchidmalevolence) Then
                pic_res = "Orchid Malevolence"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Perseverance) Then
                pic_res = "Perseverance"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Phaseboots) Then
                pic_res = "Phase Boots"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Khadgarspipeofinsight) Then
                pic_res = "Pipe of Insight"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Platemail) Then
                pic_res = "Platemail"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Pointbooster) Then
                pic_res = "Point Booster"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Poormansshield) Then
                pic_res = "Poor Man's Shield"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Powertreads) Then
                pic_res = "Power Treads"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Quarterstaff) Then
                pic_res = "Quarterstaff"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Quellingblade) Then
                pic_res = "Quelling Blade"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Radiance) Then
                pic_res = "Radiance"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Messerschmidtsreaver) Then
                pic_res = "Reaver"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Refresherorb) Then
                pic_res = "Refresher Orb"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Ringofbasilius) Then
                pic_res = "Ring of Basilius"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Ringofhealth) Then
                pic_res = "Ring of Health"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Ringofprotection) Then
                pic_res = "Ring of Protection"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Ringofregeneration) Then
                pic_res = "Ring of Regen"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Robeofthemagi) Then
                pic_res = "Robe of the Magi"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Sacredrelic) Then
                pic_res = "Sacred Relic"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Sobimask) Then
                pic_res = "Sage's Mask"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Sange) Then
                pic_res = "Sange"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Sangeandyasha) Then
                pic_res = "Sange and Yasha"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Satanic) Then
                pic_res = "Satanic"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Guinsoosscytheofvyse) Then
                pic_res = "Scythe of Vyse"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Sentrywards) Then
                pic_res = "Sentry Ward"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Lotharsedge) Then
                pic_res = "Shadow Blade"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Shivasguard) Then
                pic_res = "Shiva's Guard"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Craniumbasher) Then
                pic_res = "Skull Basher"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Slippersofagility) Then
                pic_res = "Slippers of Agility"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.SmokeOfDeceit) Then
                pic_res = "Smoke of Deceit"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Soulbooster) Then
                pic_res = "Soul Booster"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Soul_Ring) Then
                pic_res = "Soul Ring"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Staffofwizardry) Then
                pic_res = "Staff of Wizardry"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Stoutshield) Then
                pic_res = "Stout Shield"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Talismanofevasion) Then
                pic_res = "Talisman of Evasion"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Tango) Then
                pic_res = "Tango"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Townportal) Then
                pic_res = "Town Portal Scroll"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Ultimateorb) Then
                pic_res = "Ultimate Orb"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Urnofshadows) Then
                pic_res = "Urn of Shadows"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Vanguard) Then
                pic_res = "Vanguard"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Fatalbonds) Then
                pic_res = "Veil of Discord"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Vitalitybooster) Then
                pic_res = "Vitality Booster"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Vladimirsoffering) Then
                pic_res = "Vladmir's Offering"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Voidstone) Then
                pic_res = "Void Stone"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Wraithband) Then
                pic_res = "Wraith Band"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Yasha) Then
                pic_res = "Yasha"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.AbyssalBlade) Then
                pic_res = "Abyssal Blade"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.Halberd) Then
                pic_res = "Heaven's Halberd"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.RingofAquila) Then
                pic_res = "Ring of Aquila"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.RodofAtos) Then
                pic_res = "Rod of Atos"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.TranquilBoots) Then
                pic_res = "Tranquil Boots"
                Return pic_res
            Else
                pic_res = "Error!"
                Return pic_res
            End If
        ElseIf ComboBoxItemIcons.Text = "HoN" Then
            If doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Portal_Key) Then
                pic_res = "Blink Dagger"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Punchdagger) Then
                pic_res = "Blades of Attack"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Staff_Of_The_Master) Then
                pic_res = "Aghanim's Scepter"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Monkey_Courier) Then
                pic_res = "Animal Courier"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Ring_Of_Sorcery) Then
                pic_res = "Arcane Boots"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Insanitarius) Then
                pic_res = "Armlet"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Daemonic_Breastplate) Then
                pic_res = "Assault Cuirass"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Runed_Axe) Then
                pic_res = "Battle Fury"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Bolstering_Armband) Then
                pic_res = "Belt of Strength"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Shrunken_Head) Then
                pic_res = "Black King Bar"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Barbed_Armor) Then
                pic_res = "Blade Mail"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Quickblade) Then
                pic_res = "Blade of Alacrity"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Sacrificial_Stone) Then
                pic_res = "Bloodstone"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Fleet_Feet) Then
                pic_res = "Boots of Elvenskin"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Marchers) Then
                pic_res = "Boots of Speed"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Post_Haste) Then
                pic_res = "Boots of Travel"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Bottle) Then
                pic_res = "Bottle"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Fortified_Bracelet) Then
                pic_res = "Bracer"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Broadsword) Then
                pic_res = "Broadsword"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Shield_Of_The_Five) Then
                pic_res = "Buckler"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Wingbow) Then
                pic_res = "Butterfly"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Ringmail) Then
                pic_res = "Chainmail"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Pretenders_Crown) Then
                pic_res = "Circlet"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Mana_Potion) Then
                pic_res = "Clarity"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Bastard_Sword) Then
                pic_res = "Claymore"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Mystic_Vestments) Then
                pic_res = "Cloak"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Riftshards) Then
                pic_res = "Crystalys"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Daedalus) Then
                pic_res = "Daedalus"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Codex) Then
                pic_res = "Dagon 1"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Codex2) Then
                pic_res = "Dagon 2"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Codex3) Then
                pic_res = "Dagon 3"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Codex4) Then
                pic_res = "Dagon 4"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Codex5) Then
                pic_res = "Dagon 5"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Slayer) Then
                pic_res = "Demon Edge"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Shieldbreaker) Then
                pic_res = "Desolator"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Nullfire_Blade) Then
                pic_res = "Diffusal Blade 1"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Nullfire_Blade2) Then
                pic_res = "Diffusal Blade 2"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Doombringer) Then
                pic_res = "Divine Rapier"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Drum_of_Endurance) Then
                pic_res = "Drum of Endurance"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Dust_Of_Revelation) Then
                pic_res = "Dust of Appearance"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Dancing_Blade) Then
                pic_res = "Eaglesong"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Pickled_Brain) Then
                pic_res = "Energy Booster"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Ethereal_Blade) Then
                pic_res = "Ethereal Blade"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Stormspirit) Then
                pic_res = "Eul's Scepter of Divinity"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Frostwolfs_Skull) Then
                pic_res = "Eye of Skadi"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Winged_Courier) Then
                pic_res = "Flying Courier"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Tablet_of_Command) Then
                pic_res = "Force Staff"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Crushing_Claws) Then
                pic_res = "Gauntlets of Strength"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Bound_Eye) Then
                pic_res = "Gem of True Sight"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Void_Talisman) Then
                pic_res = "Ghost Scepter"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Gloves_of_the_Swift) Then
                pic_res = "Gloves of Haste"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Alchemist_Bones) Then
                pic_res = "Hand of Midas"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Refreshing_Ornament) Then
                pic_res = "Headdress"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Health_Potion) Then
                pic_res = "Healing Salve"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Behemoths_Hearth) Then
                pic_res = "Heart of Tarrasque"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Helm_Of_The_Victim) Then
                pic_res = "Helm of Iron Will"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Whispering_Helm) Then
                pic_res = "Helm of the Dominator"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Shamans_Headress) Then
                pic_res = "Hood of Defiance"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Warpcleft) Then
                pic_res = "Hyperstone"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Minor_Totem) Then
                pic_res = "Iron Branch"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Halberd) Then
                pic_res = "Javelin"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Null_Stone) Then
                pic_res = "Linken's Sphere"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Thunderclaw) Then
                pic_res = "Maelstrom"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Mana_Battery) Then
                pic_res = "Magic Stick"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Power_Supply) Then
                pic_res = "Magic Wand"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Geometers_Bane) Then
                pic_res = "Manta Style"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Mark_Of_The_Novice) Then
                pic_res = "Mantle of Intelligence"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Elder_Parasite) Then
                pic_res = "Mask of Madness"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Medallion_of_Courage) Then
                pic_res = "Medallion of Courage"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Astrolabe) Then
                pic_res = "Mekansm"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Warhammer) Then
                pic_res = "Mithril Hammer"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Charged_Hammer) Then
                pic_res = "Mjollnir"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Savage_Mace) Then
                pic_res = "Monkey King Bar"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Hungry_Spirit) Then
                pic_res = "Morbid Mask"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Acolytes_Staff) Then
                pic_res = "Mystic Staff"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Puzzlebox) Then
                pic_res = "Necronomicon 1"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Puzzlebox2) Then
                pic_res = "Necronomicon 2"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Puzzlebox3) Then
                pic_res = "Necronomicon 3"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Talisman_Of_Exile) Then
                pic_res = "Null Talisman"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Great_Arcana) Then
                pic_res = "Oblivion Staff"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Wards_of_Sight) Then
                pic_res = "Observer Ward"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Mighty_Blade) Then
                pic_res = "Ogre Club"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Orb_of_Venom) Then
                pic_res = "Orb of Venom"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Hellflower) Then
                pic_res = "Orchid Malevolence"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Sustainer) Then
                pic_res = "Perseverance"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Enhanced_Marchers) Then
                pic_res = "Phase Boots"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Barrier_Idol) Then
                pic_res = "Pipe of Insight"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Platemail) Then
                pic_res = "Platemail"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Glowstone) Then
                pic_res = "Point Booster"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Iron_Shield) Then
                pic_res = "Poor Man's Shield"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Steamboots_Strength) Then
                pic_res = "Power Treads"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Steamstaff) Then
                pic_res = "Quarterstaff"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Loggers_Hatchet) Then
                pic_res = "Quelling Blade"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Mock_of_Brilliance) Then
                pic_res = "Radiance"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Axe_Of_The_Malphai) Then
                pic_res = "Reaver"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Restoration_Stone) Then
                pic_res = "Refresher Orb"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Ring_Of_The_Teacher) Then
                pic_res = "Ring of Basilius"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Lifetube) Then
                pic_res = "Ring of Health"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Guardian_Ring) Then
                pic_res = "Ring of Protection"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Trinket_Of_Restoration) Then
                pic_res = "Ring of Regen"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Apprentices_Robe) Then
                pic_res = "Robe of the Magi"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Sword_Of_The_High) Then
                pic_res = "Sacred Relic"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Scarab) Then
                pic_res = "Sage's Mask"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Icebrand) Then
                pic_res = "Sange"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Frostburn) Then
                pic_res = "Sange and Yasha"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Symbol_Of_Rage) Then
                pic_res = "Satanic"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Kuldras_Sheepstick) Then
                pic_res = "Scythe of Vyse"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Wards_of_Revelation) Then
                pic_res = "Sentry Ward"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Shroud_Of_The_Assasin) Then
                pic_res = "Shadow Blade"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Frostfield_Plate) Then
                pic_res = "Shiva's Guard"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Brutalizer) Then
                pic_res = "Skull Basher"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Duck_Boots) Then
                pic_res = "Slippers of Agility"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Smoke_of_Deceit) Then
                pic_res = "Smoke of Deceit"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Icon_Of_The_Goddess) Then
                pic_res = "Soul Booster"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Blood_Chalice) Then
                pic_res = "Soul Ring"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Neophytes_Book) Then
                pic_res = "Staff of Wizardry"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Iron_Buckler) Then
                pic_res = "Stout Shield"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Snake_Bracelet) Then
                pic_res = "Talisman of Evasion"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Runes_Of_The_Blight) Then
                pic_res = "Tango"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Homecoming_Stone) Then
                pic_res = "Town Portal Scroll"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Blessed_Orb) Then
                pic_res = "Ultimate Orb"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Urn_of_Shadows) Then
                pic_res = "Urn of Shadows"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Helm_Of_The_Black_Legion) Then
                pic_res = "Vanguard"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Veil_of_Discord) Then
                pic_res = "Veil of Discord"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Beastheart) Then
                pic_res = "Vitality Booster"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Abyssal_Skull) Then
                pic_res = "Vladmir's Offering"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Manatube) Then
                pic_res = "Void Stone"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Soulscream_Ring) Then
                pic_res = "Wraith Band"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Firebrand) Then
                pic_res = "Yasha"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Abyssal_Blade) Then
                pic_res = "Abyssal Blade"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Heaven_s_Halberd) Then
                pic_res = "Heaven's Halberd"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Ring_of_Aquila) Then
                pic_res = "Ring of Aquila"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Rod_of_Atos) Then
                pic_res = "Rod of Atos"
                Return pic_res
            ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources.HoN_Striders) Then
                pic_res = "Tranquil Boots"
                Return pic_res
            Else
                pic_res = "Error!"
                Return pic_res
            End If
        Else
                If doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Blink_Dagger) Then
                    pic_res = "Blink Dagger"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Blades_of_Attack) Then
                    pic_res = "Blades of Attack"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Aghanim_s_Scepter) Then
                    pic_res = "Aghanim's Scepter"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Animal_Courier) Then
                    pic_res = "Animal Courier"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Arcane_Boots) Then
                    pic_res = "Arcane Boots"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Armlet) Then
                    pic_res = "Armlet"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Assault_Cuirass) Then
                    pic_res = "Assault Cuirass"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Battle_Fury) Then
                    pic_res = "Battle Fury"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Belt_of_Strength) Then
                    pic_res = "Belt of Strength"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Black_King_Bar) Then
                    pic_res = "Black King Bar"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Blade_Mail) Then
                    pic_res = "Blade Mail"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Blade_of_Alacrity) Then
                    pic_res = "Blade of Alacrity"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Bloodstone) Then
                    pic_res = "Bloodstone"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Boots_of_Elvenskin) Then
                    pic_res = "Boots of Elvenskin"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Boots_of_Speed) Then
                    pic_res = "Boots of Speed"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Boots_of_Travel) Then
                    pic_res = "Boots of Travel"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Bottle) Then
                    pic_res = "Bottle"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Bracer) Then
                    pic_res = "Bracer"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Broadsword) Then
                    pic_res = "Broadsword"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Buckler) Then
                    pic_res = "Buckler"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Butterfly) Then
                    pic_res = "Butterfly"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Chainmail) Then
                    pic_res = "Chainmail"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Circlet) Then
                    pic_res = "Circlet"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Clarity) Then
                    pic_res = "Clarity"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Claymore) Then
                    pic_res = "Claymore"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Cloak) Then
                    pic_res = "Cloak"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Crystalys) Then
                    pic_res = "Crystalys"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Daedalus) Then
                    pic_res = "Daedalus"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Dagon) Then
                    pic_res = "Dagon 1"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Dagon2) Then
                    pic_res = "Dagon 2"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Dagon3) Then
                    pic_res = "Dagon 3"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Dagon4) Then
                    pic_res = "Dagon 4"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Dagon5) Then
                    pic_res = "Dagon 5"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Demon_Edge) Then
                    pic_res = "Demon Edge"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Desolator) Then
                    pic_res = "Desolator"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Diffusal_Blade) Then
                    pic_res = "Diffusal Blade 1"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Diffusal_Blade2) Then
                    pic_res = "Diffusal Blade 2"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Divine_Rapier) Then
                    pic_res = "Divine Rapier"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Drum_of_Endurance) Then
                    pic_res = "Drum of Endurance"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Dust_of_Appearance) Then
                    pic_res = "Dust of Appearance"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Eaglesong) Then
                    pic_res = "Eaglesong"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Energy_Booster) Then
                    pic_res = "Energy Booster"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Ethereal_Blade) Then
                    pic_res = "Ethereal Blade"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Eul_s_Scepter_of_Divinity) Then
                    pic_res = "Eul's Scepter of Divinity"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Eye_of_Skadi) Then
                    pic_res = "Eye of Skadi"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Flying_Courier) Then
                    pic_res = "Flying Courier"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Force_Staff) Then
                    pic_res = "Force Staff"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Gauntlets_of_Strength) Then
                    pic_res = "Gauntlets of Strength"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Gem_of_True_Sight) Then
                    pic_res = "Gem of True Sight"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Ghost_Scepter) Then
                    pic_res = "Ghost Scepter"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Gloves_of_Haste) Then
                    pic_res = "Gloves of Haste"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Hand_of_Midas) Then
                    pic_res = "Hand of Midas"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Headdress) Then
                    pic_res = "Headdress"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Healing_Salve) Then
                    pic_res = "Healing Salve"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Heart_of_Tarrasque) Then
                    pic_res = "Heart of Tarrasque"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Helm_of_Iron_Will) Then
                    pic_res = "Helm of Iron Will"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Helm_of_the_Dominator) Then
                    pic_res = "Helm of the Dominator"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Hood_of_Defiance) Then
                    pic_res = "Hood of Defiance"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Hyperstone) Then
                    pic_res = "Hyperstone"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Iron_Branch) Then
                    pic_res = "Iron Branch"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Javelin) Then
                    pic_res = "Javelin"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Linken_s_Sphere) Then
                    pic_res = "Linken's Sphere"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Maelstrom) Then
                    pic_res = "Maelstrom"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Magic_Stick) Then
                    pic_res = "Magic Stick"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Magic_Wand) Then
                    pic_res = "Magic Wand"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Manta_Style) Then
                    pic_res = "Manta Style"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Mantle_of_Intelligence) Then
                    pic_res = "Mantle of Intelligence"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Mask_of_Madness) Then
                    pic_res = "Mask of Madness"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Medallion_of_Courage) Then
                    pic_res = "Medallion of Courage"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Mekansm) Then
                    pic_res = "Mekansm"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Mithril_Hammer) Then
                    pic_res = "Mithril Hammer"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Mjollnir) Then
                    pic_res = "Mjollnir"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Monkey_King_Bar) Then
                    pic_res = "Monkey King Bar"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Morbid_Mask) Then
                    pic_res = "Morbid Mask"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Mystic_Staff) Then
                    pic_res = "Mystic Staff"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Necronomicon) Then
                    pic_res = "Necronomicon 1"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Necronomicon2) Then
                    pic_res = "Necronomicon 2"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Necronomicon3) Then
                    pic_res = "Necronomicon 3"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Null_Talisman) Then
                    pic_res = "Null Talisman"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Oblivion_Staff) Then
                    pic_res = "Oblivion Staff"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Observer_Ward) Then
                    pic_res = "Observer Ward"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Ogre_Club) Then
                    pic_res = "Ogre Club"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Orb_of_Venom) Then
                    pic_res = "Orb of Venom"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Orchid_Malevolence) Then
                    pic_res = "Orchid Malevolence"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Perseverance) Then
                    pic_res = "Perseverance"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Phase_Boots) Then
                    pic_res = "Phase Boots"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Pipe_of_Insight) Then
                    pic_res = "Pipe of Insight"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Platemail) Then
                    pic_res = "Platemail"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Point_Booster) Then
                    pic_res = "Point Booster"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Poor_Man_s_Shield) Then
                    pic_res = "Poor Man's Shield"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Power_Treads) Then
                    pic_res = "Power Treads"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Quarterstaff) Then
                    pic_res = "Quarterstaff"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Quelling_Blade) Then
                    pic_res = "Quelling Blade"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Radiance) Then
                    pic_res = "Radiance"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Reaver) Then
                    pic_res = "Reaver"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Refresher_Orb) Then
                    pic_res = "Refresher Orb"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Ring_of_Basilius) Then
                    pic_res = "Ring of Basilius"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Ring_of_Health) Then
                    pic_res = "Ring of Health"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Ring_of_Protection) Then
                    pic_res = "Ring of Protection"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Ring_of_Regen) Then
                    pic_res = "Ring of Regen"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Robe_of_the_Magi) Then
                    pic_res = "Robe of the Magi"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Sacred_Relic) Then
                    pic_res = "Sacred Relic"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Sage_s_Mask) Then
                    pic_res = "Sage's Mask"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Sange) Then
                    pic_res = "Sange"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Sange_and_Yasha) Then
                    pic_res = "Sange and Yasha"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Satanic) Then
                    pic_res = "Satanic"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Scythe_of_Vyse) Then
                    pic_res = "Scythe of Vyse"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Sentry_Ward) Then
                    pic_res = "Sentry Ward"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Shadow_Blade) Then
                    pic_res = "Shadow Blade"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Shiva_s_Guard) Then
                    pic_res = "Shiva's Guard"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Skull_Basher) Then
                    pic_res = "Skull Basher"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Slippers_of_Agility) Then
                    pic_res = "Slippers of Agility"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Smoke_of_Deceit) Then
                    pic_res = "Smoke of Deceit"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Soul_Booster) Then
                    pic_res = "Soul Booster"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Soul_Ring) Then
                    pic_res = "Soul Ring"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Staff_of_Wizardry) Then
                    pic_res = "Staff of Wizardry"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Stout_Shield) Then
                    pic_res = "Stout Shield"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Talisman_of_Evasion) Then
                    pic_res = "Talisman of Evasion"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Tango) Then
                    pic_res = "Tango"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Town_Portal_Scroll) Then
                    pic_res = "Town Portal Scroll"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Ultimate_Orb) Then
                    pic_res = "Ultimate Orb"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Urn_of_Shadows) Then
                    pic_res = "Urn of Shadows"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Vanguard) Then
                    pic_res = "Vanguard"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Veil_of_Discord) Then
                    pic_res = "Veil of Discord"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Vitality_Booster) Then
                    pic_res = "Vitality Booster"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Vladmir_s_Offering) Then
                    pic_res = "Vladmir's Offering"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Void_Stone) Then
                    pic_res = "Void Stone"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Wraith_Band) Then
                    pic_res = "Wraith Band"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Yasha) Then
                    pic_res = "Yasha"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Abyssal_Blade) Then
                    pic_res = "Abyssal Blade"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Heaven_s_Halberd) Then
                    pic_res = "Heaven's Halberd"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Ring_of_Aquila) Then
                    pic_res = "Ring of Aquila"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Rod_of_Atos) Then
                    pic_res = "Rod of Atos"
                    Return pic_res
                ElseIf doImagesMatch(img_res, D2RIC.My.Resources.Resources._40px_Tranquil_Boots) Then
                    pic_res = "Tranquil Boots"
                    Return pic_res
                Else
                    pic_res = "Error!"
                    Return pic_res
                End If
            End If
    End Function



    'TARGET PICTUREBOXES
    Private Sub Item1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item1.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item1.DragDrop
        ' Assign the image to the PictureBox. 
        Item1.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item1.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item1, Itembuild.GetToolTip(PicRes2Name(Item1.Image)))
        Else
            ToolTip1.SetToolTip(Item1, "none")
        End If
    End Sub

    Private Sub Item2_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item2.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item2_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item2.DragDrop
        ' Assign the image to the PictureBox. 
        Item2.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item2.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item2, Itembuild.GetToolTip(PicRes2Name(Item2.Image)))
        Else
            ToolTip1.SetToolTip(Item2, "none")
        End If
    End Sub

    Private Sub Item3_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item3.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item3_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item3.DragDrop
        ' Assign the image to the PictureBox. 
        Item3.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item3.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item3, Itembuild.GetToolTip(PicRes2Name(Item3.Image)))
        Else
            ToolTip1.SetToolTip(Item3, "none")
        End If
    End Sub

    Private Sub Item4_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item4.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item4_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item4.DragDrop
        ' Assign the image to the PictureBox. 
        Item4.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item4.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item4, Itembuild.GetToolTip(PicRes2Name(Item4.Image)))
        Else
            ToolTip1.SetToolTip(Item4, "none")
        End If
    End Sub

    Private Sub Item5_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item5.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item5_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item5.DragDrop
        ' Assign the image to the PictureBox. 
        Item5.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item5.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item5, Itembuild.GetToolTip(PicRes2Name(Item5.Image)))
        Else
            ToolTip1.SetToolTip(Item5, "none")
        End If
    End Sub

    Private Sub Item6_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item6.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item6_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item6.DragDrop
        ' Assign the image to the PictureBox. 
        Item6.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item6.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item6, Itembuild.GetToolTip(PicRes2Name(Item6.Image)))
        Else
            ToolTip1.SetToolTip(Item6, "none")
        End If
    End Sub

    Private Sub Item7_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item7.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item7_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item7.DragDrop
        ' Assign the image to the PictureBox. 
        Item7.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item7.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item7, Itembuild.GetToolTip(PicRes2Name(Item7.Image)))
        Else
            ToolTip1.SetToolTip(Item7, "none")
        End If
    End Sub

    Private Sub Item8_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item8.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item8_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item8.DragDrop
        ' Assign the image to the PictureBox. 
        Item8.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item8.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item8, Itembuild.GetToolTip(PicRes2Name(Item8.Image)))
        Else
            ToolTip1.SetToolTip(Item8, "none")
        End If
    End Sub

    Private Sub Item9_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item9.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item9_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item9.DragDrop
        ' Assign the image to the PictureBox. 
        Item9.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item9.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item9, Itembuild.GetToolTip(PicRes2Name(Item9.Image)))
        Else
            ToolTip1.SetToolTip(Item9, "none")
        End If
    End Sub

    Private Sub Item10_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item10.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item10_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item10.DragDrop
        ' Assign the image to the PictureBox. 
        Item10.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item10.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item10, Itembuild.GetToolTip(PicRes2Name(Item10.Image)))
        Else
            ToolTip1.SetToolTip(Item10, "none")
        End If
    End Sub

    Private Sub Item11_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item11.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item11_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item11.DragDrop
        ' Assign the image to the PictureBox. 
        Item11.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item11.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item11, Itembuild.GetToolTip(PicRes2Name(Item11.Image)))
        Else
            ToolTip1.SetToolTip(Item11, "none")
        End If
    End Sub

    Private Sub Item12_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item12.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item12_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item12.DragDrop
        ' Assign the image to the PictureBox. 
        Item12.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item12.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item12, Itembuild.GetToolTip(PicRes2Name(Item12.Image)))
        Else
            ToolTip1.SetToolTip(Item12, "none")
        End If
    End Sub

    Private Sub Item13_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item13.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item13_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item13.DragDrop
        ' Assign the image to the PictureBox. 
        Item13.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item13.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item13, Itembuild.GetToolTip(PicRes2Name(Item13.Image)))
        Else
            ToolTip1.SetToolTip(Item13, "none")
        End If
    End Sub

    Private Sub Item14_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item14.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item14_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item14.DragDrop
        ' Assign the image to the PictureBox. 
        Item14.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item14.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item14, Itembuild.GetToolTip(PicRes2Name(Item14.Image)))
        Else
            ToolTip1.SetToolTip(Item14, "none")
        End If
    End Sub

    Private Sub Item15_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item15.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item15_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item15.DragDrop
        ' Assign the image to the PictureBox. 
        Item15.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item15.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item15, Itembuild.GetToolTip(PicRes2Name(Item15.Image)))
        Else
            ToolTip1.SetToolTip(Item15, "none")
        End If
    End Sub

    Private Sub Item16_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item16.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item16_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item16.DragDrop
        ' Assign the image to the PictureBox. 
        Item16.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item16.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item16, Itembuild.GetToolTip(PicRes2Name(Item16.Image)))
        Else
            ToolTip1.SetToolTip(Item16, "none")
        End If
    End Sub

    Private Sub Item17_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item17.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item17_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item17.DragDrop
        ' Assign the image to the PictureBox. 
        Item17.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item17.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item17, Itembuild.GetToolTip(PicRes2Name(Item17.Image)))
        Else
            ToolTip1.SetToolTip(Item17, "none")
        End If
    End Sub

    Private Sub Item18_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item18.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item18_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item18.DragDrop
        ' Assign the image to the PictureBox. 
        Item18.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item18.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item18, Itembuild.GetToolTip(PicRes2Name(Item18.Image)))
        Else
            ToolTip1.SetToolTip(Item18, "none")
        End If
    End Sub

    Private Sub Item19_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item19.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item19_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item19.DragDrop
        ' Assign the image to the PictureBox. 
        Item19.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item19.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item19, Itembuild.GetToolTip(PicRes2Name(Item19.Image)))
        Else
            ToolTip1.SetToolTip(Item19, "none")
        End If
    End Sub

    Private Sub Item20_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item20.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item20_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item20.DragDrop
        ' Assign the image to the PictureBox. 
        Item20.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item20.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item20, Itembuild.GetToolTip(PicRes2Name(Item20.Image)))
        Else
            ToolTip1.SetToolTip(Item20, "none")
        End If
    End Sub

    Private Sub Item21_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item21.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item21_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item21.DragDrop
        ' Assign the image to the PictureBox. 
        Item21.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item21.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item21, Itembuild.GetToolTip(PicRes2Name(Item21.Image)))
        Else
            ToolTip1.SetToolTip(Item21, "none")
        End If
    End Sub

    Private Sub Item22_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item22.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item22_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item22.DragDrop
        ' Assign the image to the PictureBox. 
        Item22.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item22.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item22, Itembuild.GetToolTip(PicRes2Name(Item22.Image)))
        Else
            ToolTip1.SetToolTip(Item22, "none")
        End If
    End Sub

    Private Sub Item23_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item23.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item23_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item23.DragDrop
        ' Assign the image to the PictureBox. 
        Item23.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item23.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item23, Itembuild.GetToolTip(PicRes2Name(Item23.Image)))
        Else
            ToolTip1.SetToolTip(Item23, "none")
        End If
    End Sub

    Private Sub Item24_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item24.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item24_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item24.DragDrop
        ' Assign the image to the PictureBox. 
        Item24.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item24.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item24, Itembuild.GetToolTip(PicRes2Name(Item24.Image)))
        Else
            ToolTip1.SetToolTip(Item24, "none")
        End If
    End Sub

    Private Sub Item25_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item25.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item25_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item25.DragDrop
        ' Assign the image to the PictureBox. 
        Item25.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item25.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item25, Itembuild.GetToolTip(PicRes2Name(Item25.Image)))
        Else
            ToolTip1.SetToolTip(Item25, "none")
        End If
    End Sub

    Private Sub Item26_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item26.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item26_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item26.DragDrop
        ' Assign the image to the PictureBox. 
        Item26.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item26.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item26, Itembuild.GetToolTip(PicRes2Name(Item26.Image)))
        Else
            ToolTip1.SetToolTip(Item26, "none")
        End If
    End Sub

    Private Sub Item27_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item27.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item27_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item27.DragDrop
        ' Assign the image to the PictureBox. 
        Item27.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item27.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item27, Itembuild.GetToolTip(PicRes2Name(Item27.Image)))
        Else
            ToolTip1.SetToolTip(Item27, "none")
        End If
    End Sub

    Private Sub Item28_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item28.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item28_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item28.DragDrop
        ' Assign the image to the PictureBox. 
        Item28.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item28.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item28, Itembuild.GetToolTip(PicRes2Name(Item28.Image)))
        Else
            ToolTip1.SetToolTip(Item28, "none")
        End If
    End Sub

    Private Sub Item29_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item29.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item29_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item29.DragDrop
        ' Assign the image to the PictureBox. 
        Item29.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item29.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item29, Itembuild.GetToolTip(PicRes2Name(Item29.Image)))
        Else
            ToolTip1.SetToolTip(Item29, "none")
        End If
    End Sub

    Private Sub Item30_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item30.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item30_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item30.DragDrop
        ' Assign the image to the PictureBox. 
        Item30.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item30.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item30, Itembuild.GetToolTip(PicRes2Name(Item30.Image)))
        Else
            ToolTip1.SetToolTip(Item30, "none")
        End If
    End Sub

    Private Sub Item31_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item31.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item31_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item31.DragDrop
        ' Assign the image to the PictureBox. 
        Item31.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item31.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item31, Itembuild.GetToolTip(PicRes2Name(Item31.Image)))
        Else
            ToolTip1.SetToolTip(Item31, "none")
        End If
    End Sub

    Private Sub Item32_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item32.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item32_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item32.DragDrop
        ' Assign the image to the PictureBox. 
        Item32.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item32.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item32, Itembuild.GetToolTip(PicRes2Name(Item32.Image)))
        Else
            ToolTip1.SetToolTip(Item32, "none")
        End If
    End Sub

    Private Sub Item33_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item33.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item33_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item33.DragDrop
        ' Assign the image to the PictureBox. 
        Item33.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item33.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item33, Itembuild.GetToolTip(PicRes2Name(Item33.Image)))
        Else
            ToolTip1.SetToolTip(Item33, "none")
        End If
    End Sub

    Private Sub Item34_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item34.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item34_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item34.DragDrop
        ' Assign the image to the PictureBox. 
        Item34.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item34.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item34, Itembuild.GetToolTip(PicRes2Name(Item34.Image)))
        Else
            ToolTip1.SetToolTip(Item34, "none")
        End If
    End Sub

    Private Sub Item35_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item35.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item35_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item35.DragDrop
        ' Assign the image to the PictureBox. 
        Item35.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item35.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item35, Itembuild.GetToolTip(PicRes2Name(Item35.Image)))
        Else
            ToolTip1.SetToolTip(Item35, "none")
        End If
    End Sub

    Private Sub Item36_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item36.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item36_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item36.DragDrop
        ' Assign the image to the PictureBox. 
        Item36.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item36.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item36, Itembuild.GetToolTip(PicRes2Name(Item36.Image)))
        Else
            ToolTip1.SetToolTip(Item36, "none")
        End If
    End Sub

    Private Sub Item37_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item37.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item37_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item37.DragDrop
        ' Assign the image to the PictureBox. 
        Item37.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item37.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item37, Itembuild.GetToolTip(PicRes2Name(Item37.Image)))
        Else
            ToolTip1.SetToolTip(Item37, "none")
        End If
    End Sub

    Private Sub Item38_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item38.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item38_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item38.DragDrop
        ' Assign the image to the PictureBox. 
        Item38.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item38.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item38, Itembuild.GetToolTip(PicRes2Name(Item38.Image)))
        Else
            ToolTip1.SetToolTip(Item38, "none")
        End If
    End Sub

    Private Sub Item39_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item39.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item39_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item39.DragDrop
        ' Assign the image to the PictureBox. 
        Item39.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(Item39.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(Item39, Itembuild.GetToolTip(PicRes2Name(Item39.Image)))
        Else
            ToolTip1.SetToolTip(Item39, "none")
        End If
    End Sub

    'SOURCE PICTUREBOXES
    Private Sub PictureBox31_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox31.MouseDown
        If Not PictureBox31.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox31_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox31.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox31.DoDragDrop(PictureBox31.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox32_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox32.MouseDown
        If Not PictureBox32.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox32_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox32.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox32.DoDragDrop(PictureBox32.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox33_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox33.MouseDown
        If Not PictureBox33.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox33_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox33.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox33.DoDragDrop(PictureBox33.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox34_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox34.MouseDown
        If Not PictureBox34.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox34_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox34.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox34.DoDragDrop(PictureBox34.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox35_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox35.MouseDown
        If Not PictureBox35.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox35_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox35.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox35.DoDragDrop(PictureBox35.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox36_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox36.MouseDown
        If Not PictureBox36.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox36_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox36.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox36.DoDragDrop(PictureBox36.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox37_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox37.MouseDown
        If Not PictureBox37.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox37_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox37.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox37.DoDragDrop(PictureBox37.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox38_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox38.MouseDown
        If Not PictureBox38.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox38_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox38.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox38.DoDragDrop(PictureBox38.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox39_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox39.MouseDown
        If Not PictureBox39.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox39_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox39.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox39.DoDragDrop(PictureBox39.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox40_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox40.MouseDown
        If Not PictureBox40.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox40_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox40.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox40.DoDragDrop(PictureBox40.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox41_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox41.MouseDown
        If Not PictureBox41.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox41_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox41.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox41.DoDragDrop(PictureBox41.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox42_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox42.MouseDown
        If Not PictureBox42.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox42_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox42.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox42.DoDragDrop(PictureBox42.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox43_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox43.MouseDown
        If Not PictureBox43.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox43_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox43.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox43.DoDragDrop(PictureBox43.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox44_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox44.MouseDown
        If Not PictureBox44.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox44_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox44.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox44.DoDragDrop(PictureBox44.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox45_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox45.MouseDown
        If Not PictureBox45.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox45_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox45.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox45.DoDragDrop(PictureBox45.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox46_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox46.MouseDown
        If Not PictureBox46.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox46_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox46.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox46.DoDragDrop(PictureBox46.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox47_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox47.MouseDown
        If Not PictureBox47.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox47_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox47.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox47.DoDragDrop(PictureBox47.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox48_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox48.MouseDown
        If Not PictureBox48.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox48_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox48.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox48.DoDragDrop(PictureBox48.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox49_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox49.MouseDown
        If Not PictureBox49.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox49_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox49.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox49.DoDragDrop(PictureBox49.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox50_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox50.MouseDown
        If Not PictureBox50.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox50_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox50.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox50.DoDragDrop(PictureBox50.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox51_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox51.MouseDown
        If Not PictureBox51.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox51_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox51.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox51.DoDragDrop(PictureBox51.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox52_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox52.MouseDown
        If Not PictureBox52.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox52_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox52.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox52.DoDragDrop(PictureBox52.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox53_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox53.MouseDown
        If Not PictureBox53.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox53_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox53.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox53.DoDragDrop(PictureBox53.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox54_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox54.MouseDown
        If Not PictureBox54.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox54_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox54.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox54.DoDragDrop(PictureBox54.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox55_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox55.MouseDown
        If Not PictureBox55.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox55_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox55.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox55.DoDragDrop(PictureBox55.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox56_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox56.MouseDown
        If Not PictureBox56.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox56_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox56.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox56.DoDragDrop(PictureBox56.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox57_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox57.MouseDown
        If Not PictureBox57.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox57_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox57.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox57.DoDragDrop(PictureBox57.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox58_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox58.MouseDown
        If Not PictureBox58.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox58_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox58.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox58.DoDragDrop(PictureBox58.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox59_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox59.MouseDown
        If Not PictureBox59.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox59_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox59.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox59.DoDragDrop(PictureBox59.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox60_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox60.MouseDown
        If Not PictureBox60.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox60_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox60.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox60.DoDragDrop(PictureBox60.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox61_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox61.MouseDown
        If Not PictureBox61.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox61_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox61.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox61.DoDragDrop(PictureBox61.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox62_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox62.MouseDown
        If Not PictureBox62.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox62_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox62.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox62.DoDragDrop(PictureBox62.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox63_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox63.MouseDown
        If Not PictureBox63.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox63_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox63.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox63.DoDragDrop(PictureBox63.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox64_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox64.MouseDown
        If Not PictureBox64.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox64_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox64.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox64.DoDragDrop(PictureBox64.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox65_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox65.MouseDown
        If Not PictureBox65.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox65_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox65.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox65.DoDragDrop(PictureBox65.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox66_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox66.MouseDown
        If Not PictureBox66.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox66_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox66.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox66.DoDragDrop(PictureBox66.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox67_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox67.MouseDown
        If Not PictureBox67.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox67_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox67.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox67.DoDragDrop(PictureBox67.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox68_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox68.MouseDown
        If Not PictureBox68.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox68_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox68.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox68.DoDragDrop(PictureBox68.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox69_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox69.MouseDown
        If Not PictureBox69.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox69_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox69.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox69.DoDragDrop(PictureBox69.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox70_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox70.MouseDown
        If Not PictureBox70.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox70_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox70.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox70.DoDragDrop(PictureBox70.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox71_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox71.MouseDown
        If Not PictureBox71.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox71_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox71.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox71.DoDragDrop(PictureBox71.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox72_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox72.MouseDown
        If Not PictureBox72.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox72_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox72.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox72.DoDragDrop(PictureBox72.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox73_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox73.MouseDown
        If Not PictureBox73.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox73_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox73.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox73.DoDragDrop(PictureBox73.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox74_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox74.MouseDown
        If Not PictureBox74.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox74_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox74.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox74.DoDragDrop(PictureBox74.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox75_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox75.MouseDown
        If Not PictureBox75.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox75_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox75.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox75.DoDragDrop(PictureBox75.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox76_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox76.MouseDown
        If Not PictureBox76.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox76_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox76.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox76.DoDragDrop(PictureBox76.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox77_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox77.MouseDown
        If Not PictureBox77.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox77_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox77.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox77.DoDragDrop(PictureBox77.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox78_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox78.MouseDown
        If Not PictureBox78.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox78_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox78.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox78.DoDragDrop(PictureBox78.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox79_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox79.MouseDown
        If Not PictureBox79.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox79_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox79.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox79.DoDragDrop(PictureBox79.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox80_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox80.MouseDown
        If Not PictureBox80.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox80_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox80.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox80.DoDragDrop(PictureBox80.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox81_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox81.MouseDown
        If Not PictureBox81.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox81_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox81.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox81.DoDragDrop(PictureBox81.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox82_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox82.MouseDown
        If Not PictureBox82.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox82_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox82.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox82.DoDragDrop(PictureBox82.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox83_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox83.MouseDown
        If Not PictureBox83.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox83_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox83.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox83.DoDragDrop(PictureBox83.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox84_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox84.MouseDown
        If Not PictureBox84.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox84_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox84.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox84.DoDragDrop(PictureBox84.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox85_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox85.MouseDown
        If Not PictureBox85.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox85_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox85.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox85.DoDragDrop(PictureBox85.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox86_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox86.MouseDown
        If Not PictureBox86.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox86_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox86.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox86.DoDragDrop(PictureBox86.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox87_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox87.MouseDown
        If Not PictureBox87.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox87_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox87.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox87.DoDragDrop(PictureBox87.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox88_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox88.MouseDown
        If Not PictureBox88.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox88_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox88.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox88.DoDragDrop(PictureBox88.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox89_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox89.MouseDown
        If Not PictureBox89.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox89_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox89.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox89.DoDragDrop(PictureBox89.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox90_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox90.MouseDown
        If Not PictureBox90.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox90_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox90.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox90.DoDragDrop(PictureBox90.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox91_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox91.MouseDown
        If Not PictureBox91.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox91_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox91.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox91.DoDragDrop(PictureBox91.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox92_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox92.MouseDown
        If Not PictureBox92.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox92_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox92.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox92.DoDragDrop(PictureBox92.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox93_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox93.MouseDown
        If Not PictureBox93.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox93_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox93.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox93.DoDragDrop(PictureBox93.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox94_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox94.MouseDown
        If Not PictureBox94.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox94_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox94.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox94.DoDragDrop(PictureBox94.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox95_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox95.MouseDown
        If Not PictureBox95.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox95_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox95.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox95.DoDragDrop(PictureBox95.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox96_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox96.MouseDown
        If Not PictureBox96.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox96_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox96.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox96.DoDragDrop(PictureBox96.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox97_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox97.MouseDown
        If Not PictureBox97.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox97_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox97.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox97.DoDragDrop(PictureBox97.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox98_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox98.MouseDown
        If Not PictureBox98.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox98_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox98.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox98.DoDragDrop(PictureBox98.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox99_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox99.MouseDown
        If Not PictureBox99.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox99_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox99.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox99.DoDragDrop(PictureBox99.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox100_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox100.MouseDown
        If Not PictureBox100.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox100_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox100.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox100.DoDragDrop(PictureBox100.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox101_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox101.MouseDown
        If Not PictureBox101.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox101_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox101.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox101.DoDragDrop(PictureBox101.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox102_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox102.MouseDown
        If Not PictureBox102.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox102_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox102.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox102.DoDragDrop(PictureBox102.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox103_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox103.MouseDown
        If Not PictureBox103.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox103_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox103.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox103.DoDragDrop(PictureBox103.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox104_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox104.MouseDown
        If Not PictureBox104.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox104_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox104.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox104.DoDragDrop(PictureBox104.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox105_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox105.MouseDown
        If Not PictureBox105.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox105_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox105.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox105.DoDragDrop(PictureBox105.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox106_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox106.MouseDown
        If Not PictureBox106.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox106_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox106.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox106.DoDragDrop(PictureBox106.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox107_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox107.MouseDown
        If Not PictureBox107.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox107_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox107.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox107.DoDragDrop(PictureBox107.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox108_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox108.MouseDown
        If Not PictureBox108.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox108_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox108.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox108.DoDragDrop(PictureBox108.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox109_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox109.MouseDown
        If Not PictureBox109.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox109_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox109.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox109.DoDragDrop(PictureBox109.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox110_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox110.MouseDown
        If Not PictureBox110.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox110_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox110.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox110.DoDragDrop(PictureBox110.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox111_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox111.MouseDown
        If Not PictureBox111.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox111_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox111.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox111.DoDragDrop(PictureBox111.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox112_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox112.MouseDown
        If Not PictureBox112.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox112_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox112.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox112.DoDragDrop(PictureBox112.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox113_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox113.MouseDown
        If Not PictureBox113.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox113_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox113.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox113.DoDragDrop(PictureBox113.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox114_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox114.MouseDown
        If Not PictureBox114.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox114_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox114.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox114.DoDragDrop(PictureBox114.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox115_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox115.MouseDown
        If Not PictureBox115.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox115_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox115.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox115.DoDragDrop(PictureBox115.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox116_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox116.MouseDown
        If Not PictureBox116.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox116_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox116.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox116.DoDragDrop(PictureBox116.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox117_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox117.MouseDown
        If Not PictureBox117.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox117_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox117.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox117.DoDragDrop(PictureBox117.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox118_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox118.MouseDown
        If Not PictureBox118.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox118_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox118.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox118.DoDragDrop(PictureBox118.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox119_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox119.MouseDown
        If Not PictureBox119.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox119_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox119.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox119.DoDragDrop(PictureBox119.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox120_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox120.MouseDown
        If Not PictureBox120.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox120_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox120.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox120.DoDragDrop(PictureBox120.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox121_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox121.MouseDown
        If Not PictureBox121.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox121_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox121.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox121.DoDragDrop(PictureBox121.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox122_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox122.MouseDown
        If Not PictureBox122.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox122_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox122.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox122.DoDragDrop(PictureBox122.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox123_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox123.MouseDown
        If Not PictureBox123.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox123_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox123.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox123.DoDragDrop(PictureBox123.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox124_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox124.MouseDown
        If Not PictureBox124.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox124_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox124.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox124.DoDragDrop(PictureBox124.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox125_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox125.MouseDown
        If Not PictureBox125.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox125_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox125.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox125.DoDragDrop(PictureBox125.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox126_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox126.MouseDown
        If Not PictureBox126.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox126_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox126.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox126.DoDragDrop(PictureBox126.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox127_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox127.MouseDown
        If Not PictureBox127.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox127_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox127.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox127.DoDragDrop(PictureBox127.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox128_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox128.MouseDown
        If Not PictureBox128.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox128_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox128.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox128.DoDragDrop(PictureBox128.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox129_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox129.MouseDown
        If Not PictureBox129.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox129_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox129.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox129.DoDragDrop(PictureBox129.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox130_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox130.MouseDown
        If Not PictureBox130.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox130_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox130.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox130.DoDragDrop(PictureBox130.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox131_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox131.MouseDown
        If Not PictureBox131.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox131_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox131.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox131.DoDragDrop(PictureBox131.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox132_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox132.MouseDown
        If Not PictureBox132.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox132_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox132.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox132.DoDragDrop(PictureBox132.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox133_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox133.MouseDown
        If Not PictureBox133.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox133_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox133.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox133.DoDragDrop(PictureBox133.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox134_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox134.MouseDown
        If Not PictureBox134.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox134_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox134.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox134.DoDragDrop(PictureBox134.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox135_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox135.MouseDown
        If Not PictureBox135.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox135_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox135.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox135.DoDragDrop(PictureBox135.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox136_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox136.MouseDown
        If Not PictureBox136.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox136_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox136.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox136.DoDragDrop(PictureBox136.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox137_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox137.MouseDown
        If Not PictureBox137.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox137_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox137.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox137.DoDragDrop(PictureBox137.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox138_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox138.MouseDown
        If Not PictureBox138.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox138_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox138.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox138.DoDragDrop(PictureBox138.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox139_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox139.MouseDown
        If Not PictureBox139.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox139_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox139.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox139.DoDragDrop(PictureBox139.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox140_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox140.MouseDown
        If Not PictureBox140.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox140_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox140.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox140.DoDragDrop(PictureBox140.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox141_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox141.MouseDown
        If Not PictureBox141.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox141_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox141.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox141.DoDragDrop(PictureBox141.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox142_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox142.MouseDown
        If Not PictureBox142.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox142_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox142.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox142.DoDragDrop(PictureBox142.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox143_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox143.MouseDown
        If Not PictureBox143.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox143_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox143.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox143.DoDragDrop(PictureBox143.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox144_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox144.MouseDown
        If Not PictureBox144.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox144_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox144.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox144.DoDragDrop(PictureBox144.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox145_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox145.MouseDown
        If Not PictureBox145.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox145_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox145.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox145.DoDragDrop(PictureBox145.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox146_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox146.MouseDown
        If Not PictureBox146.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox146_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox146.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox146.DoDragDrop(PictureBox146.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox147_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox147.MouseDown
        If Not PictureBox147.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox147_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox147.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox147.DoDragDrop(PictureBox147.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox148_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox148.MouseDown
        If Not PictureBox148.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox148_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox148.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox148.DoDragDrop(PictureBox148.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox149_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox149.MouseDown
        If Not PictureBox149.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox149_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox149.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox149.DoDragDrop(PictureBox149.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox150_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox150.MouseDown
        If Not PictureBox150.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox150_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox150.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox150.DoDragDrop(PictureBox150.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox151_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox151.MouseDown
        If Not PictureBox151.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox151_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox151.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox151.DoDragDrop(PictureBox151.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox152_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox152.MouseDown
        If Not PictureBox152.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox152_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox152.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox152.DoDragDrop(PictureBox152.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox153_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox153.MouseDown
        If Not PictureBox153.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox153_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox153.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox153.DoDragDrop(PictureBox153.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox154_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox154.MouseDown
        If Not PictureBox154.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox154_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox154.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox154.DoDragDrop(PictureBox154.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox155_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox155.MouseDown
        If Not PictureBox155.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox155_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox155.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox155.DoDragDrop(PictureBox155.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox156_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox156.MouseDown
        If Not PictureBox156.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox156_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox156.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox156.DoDragDrop(PictureBox156.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox157_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox157.MouseDown
        If Not PictureBox157.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox157_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox157.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox157.DoDragDrop(PictureBox157.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox158_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox158.MouseDown
        If Not PictureBox158.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox158_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox158.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox158.DoDragDrop(PictureBox158.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox159_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox159.MouseDown
        If Not PictureBox159.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox159_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox159.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox159.DoDragDrop(PictureBox159.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox160_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox160.MouseDown
        If Not PictureBox160.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox160_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox160.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox160.DoDragDrop(PictureBox160.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox161_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox161.MouseDown
        If Not PictureBox161.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox161_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox161.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox161.DoDragDrop(PictureBox161.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox162_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox162.MouseDown
        If Not PictureBox162.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox162_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox162.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox162.DoDragDrop(PictureBox162.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox163_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox163.MouseDown
        If Not PictureBox163.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox163_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox163.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox163.DoDragDrop(PictureBox163.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox164_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox164.MouseDown
        If Not PictureBox164.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox164_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox164.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox164.DoDragDrop(PictureBox164.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox165_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox165.MouseDown
        If Not PictureBox165.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox165_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox165.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox165.DoDragDrop(PictureBox165.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    ' RIGHTCLICK DELTE
    Private Sub Item1_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item1.MouseDown
        If e.Button = MouseButtons.Right Then
            Item1.Image = My.Resources.none
            ToolTip1.SetToolTip(Item1, "none")
        End If
    End Sub

    Private Sub Item2_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item2.MouseDown
        If e.Button = MouseButtons.Right Then
            Item2.Image = My.Resources.none
            ToolTip1.SetToolTip(Item2, "none")
        End If
    End Sub

    Private Sub Item3_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item3.MouseDown
        If e.Button = MouseButtons.Right Then
            Item3.Image = My.Resources.none
            ToolTip1.SetToolTip(Item3, "none")
        End If
    End Sub

    Private Sub Item4_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item4.MouseDown
        If e.Button = MouseButtons.Right Then
            Item4.Image = My.Resources.none
            ToolTip1.SetToolTip(Item4, "none")
        End If
    End Sub

    Private Sub Item5_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item5.MouseDown
        If e.Button = MouseButtons.Right Then
            Item5.Image = My.Resources.none
            ToolTip1.SetToolTip(Item5, "none")
        End If
    End Sub

    Private Sub Item6_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item6.MouseDown
        If e.Button = MouseButtons.Right Then
            Item6.Image = My.Resources.none
            ToolTip1.SetToolTip(Item6, "none")
        End If
    End Sub

    Private Sub Item7_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item7.MouseDown
        If e.Button = MouseButtons.Right Then
            Item7.Image = My.Resources.none
            ToolTip1.SetToolTip(Item7, "none")
        End If
    End Sub

    Private Sub Item8_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item8.MouseDown
        If e.Button = MouseButtons.Right Then
            Item8.Image = My.Resources.none
            ToolTip1.SetToolTip(Item8, "none")
        End If
    End Sub

    Private Sub Item9_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item9.MouseDown
        If e.Button = MouseButtons.Right Then
            Item9.Image = My.Resources.none
            ToolTip1.SetToolTip(Item9, "none")
        End If
    End Sub

    Private Sub Item10_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item10.MouseDown
        If e.Button = MouseButtons.Right Then
            Item10.Image = My.Resources.none
            ToolTip1.SetToolTip(Item10, "none")
        End If
    End Sub

    Private Sub Item11_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item11.MouseDown
        If e.Button = MouseButtons.Right Then
            Item11.Image = My.Resources.none
            ToolTip1.SetToolTip(Item11, "none")
        End If
    End Sub

    Private Sub Item12_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item12.MouseDown
        If e.Button = MouseButtons.Right Then
            Item12.Image = My.Resources.none
            ToolTip1.SetToolTip(Item12, "none")
        End If
    End Sub

    Private Sub Item13_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item13.MouseDown
        If e.Button = MouseButtons.Right Then
            Item13.Image = My.Resources.none
            ToolTip1.SetToolTip(Item13, "none")
        End If
    End Sub

    Private Sub Item14_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item14.MouseDown
        If e.Button = MouseButtons.Right Then
            Item14.Image = My.Resources.none
            ToolTip1.SetToolTip(Item14, "none")
        End If
    End Sub

    Private Sub Item15_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item15.MouseDown
        If e.Button = MouseButtons.Right Then
            Item15.Image = My.Resources.none
            ToolTip1.SetToolTip(Item15, "none")
        End If
    End Sub

    Private Sub Item16_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item16.MouseDown
        If e.Button = MouseButtons.Right Then
            Item16.Image = My.Resources.none
            ToolTip1.SetToolTip(Item16, "none")
        End If
    End Sub

    Private Sub Item17_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item17.MouseDown
        If e.Button = MouseButtons.Right Then
            Item17.Image = My.Resources.none
            ToolTip1.SetToolTip(Item17, "none")
        End If
    End Sub

    Private Sub Item18_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item18.MouseDown
        If e.Button = MouseButtons.Right Then
            Item18.Image = My.Resources.none
            ToolTip1.SetToolTip(Item18, "none")
        End If
    End Sub

    Private Sub Item19_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item19.MouseDown
        If e.Button = MouseButtons.Right Then
            Item19.Image = My.Resources.none
            ToolTip1.SetToolTip(Item19, "none")
        End If
    End Sub

    Private Sub Item20_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item20.MouseDown
        If e.Button = MouseButtons.Right Then
            Item20.Image = My.Resources.none
            ToolTip1.SetToolTip(Item20, "none")
        End If
    End Sub

    Private Sub Item21_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item21.MouseDown
        If e.Button = MouseButtons.Right Then
            Item21.Image = My.Resources.none
            ToolTip1.SetToolTip(Item21, "none")
        End If
    End Sub

    Private Sub Item22_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item22.MouseDown
        If e.Button = MouseButtons.Right Then
            Item22.Image = My.Resources.none
            ToolTip1.SetToolTip(Item22, "none")
        End If
    End Sub

    Private Sub Item23_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item23.MouseDown
        If e.Button = MouseButtons.Right Then
            Item23.Image = My.Resources.none
            ToolTip1.SetToolTip(Item23, "none")
        End If
    End Sub

    Private Sub Item24_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item24.MouseDown
        If e.Button = MouseButtons.Right Then
            Item24.Image = My.Resources.none
            ToolTip1.SetToolTip(Item24, "none")
        End If
    End Sub

    Private Sub Item25_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item25.MouseDown
        If e.Button = MouseButtons.Right Then
            Item25.Image = My.Resources.none
            ToolTip1.SetToolTip(Item25, "none")
        End If
    End Sub

    Private Sub Item26_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item26.MouseDown
        If e.Button = MouseButtons.Right Then
            Item26.Image = My.Resources.none
            ToolTip1.SetToolTip(Item26, "none")
        End If
    End Sub

    Private Sub Item27_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item27.MouseDown
        If e.Button = MouseButtons.Right Then
            Item27.Image = My.Resources.none
            ToolTip1.SetToolTip(Item27, "none")
        End If
    End Sub

    Private Sub Item28_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item28.MouseDown
        If e.Button = MouseButtons.Right Then
            Item28.Image = My.Resources.none
            ToolTip1.SetToolTip(Item28, "none")
        End If
    End Sub

    Private Sub Item29_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item29.MouseDown
        If e.Button = MouseButtons.Right Then
            Item29.Image = My.Resources.none
            ToolTip1.SetToolTip(Item29, "none")
        End If
    End Sub

    Private Sub Item30_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item30.MouseDown
        If e.Button = MouseButtons.Right Then
            Item30.Image = My.Resources.none
            ToolTip1.SetToolTip(Item30, "none")
        End If
    End Sub

    Private Sub Item31_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item31.MouseDown
        If e.Button = MouseButtons.Right Then
            Item31.Image = My.Resources.none
            ToolTip1.SetToolTip(Item31, "none")
        End If
    End Sub

    Private Sub Item32_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item32.MouseDown
        If e.Button = MouseButtons.Right Then
            Item32.Image = My.Resources.none
            ToolTip1.SetToolTip(Item32, "none")
        End If
    End Sub

    Private Sub Item33_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item33.MouseDown
        If e.Button = MouseButtons.Right Then
            Item33.Image = My.Resources.none
            ToolTip1.SetToolTip(Item33, "none")
        End If
    End Sub

    Private Sub Item34_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item34.MouseDown
        If e.Button = MouseButtons.Right Then
            Item34.Image = My.Resources.none
            ToolTip1.SetToolTip(Item34, "none")
        End If
    End Sub

    Private Sub Item35_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item35.MouseDown
        If e.Button = MouseButtons.Right Then
            Item35.Image = My.Resources.none
            ToolTip1.SetToolTip(Item35, "none")
        End If
    End Sub

    Private Sub Item36_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item36.MouseDown
        If e.Button = MouseButtons.Right Then
            Item36.Image = My.Resources.none
            ToolTip1.SetToolTip(Item36, "none")
        End If
    End Sub

    Private Sub Item37_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item37.MouseDown
        If e.Button = MouseButtons.Right Then
            Item37.Image = My.Resources.none
            ToolTip1.SetToolTip(Item37, "none")
        End If
    End Sub

    Private Sub Item38_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item38.MouseDown
        If e.Button = MouseButtons.Right Then
            Item38.Image = My.Resources.none
            ToolTip1.SetToolTip(Item38, "none")
        End If
    End Sub

    Private Sub Item39_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item39.MouseDown
        If e.Button = MouseButtons.Right Then
            Item39.Image = My.Resources.none
            ToolTip1.SetToolTip(Item39, "none")
        End If
    End Sub

End Class