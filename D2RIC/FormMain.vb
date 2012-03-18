﻿Imports System.Security.Cryptography, System.Net

Public Class FormMain
    Dim FirstChange As Boolean = True
    Private m_MouseIsDown As Boolean
    Friend WithEvents Import As New ImportClass
    Friend WithEvents Export As New ExportClass
    Friend WithEvents Options As New OptionsClass
    Friend WithEvents Itembuild As New ItembuildClass
    Private WithEvents WebClient1 As New WebClient
    Dim cursor_image As Icon
    Dim Selected_Item As Bitmap
    Dim IntPrice As Integer

    Private Sub FormMain_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.Save()
        End
    End Sub

    Private Sub FormMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Itembuild.Initialize()
        Itembuild.InitializeListbox()

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

    Private Sub ComboBoxItemIcons_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxItemIcons.SelectedIndexChanged
        If ComboBoxItemIcons.Text <> "DotA 2" Then
            ComboBoxItemIcons.Text = "Dota 2"
        End If
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

    'Source: http://dotnet-snippets.de/dns/bild-transparent-machen-mit-colormatrix-SID168.aspx
    Public Function SetImageAlpha(ByVal Image As Image, ByVal Alpha As Single) As Image
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

    Private Function ListView_GetItemIndex(ByRef lv As ListView) As Integer
        If lv.SelectedItems.Count > 0 Then
            Dim lvi As ListViewItem = lv.SelectedItems.Item(0)
            If lvi.Selected Then
                Return lvi.Index
            Else
                Return -1
            End If
        End If
        Return -1
    End Function

    Private Sub ListView1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseDown
        If Not Selected_Item Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub ListView1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            ListView1.DoDragDrop(Selected_Item, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        Dim Index As Integer = ListView_GetItemIndex(ListView1)
        Dim blubb As Bitmap
        If Index > -1 Then
            Selected_Item = ImageList1.Images(ListView1.Items(Index).ImageIndex)
            blubb = SetImageAlpha(Selected_Item, 75)
            cursor_image = Icon.FromHandle(blubb.GetHicon())
        End If
    End Sub

    Private Sub ListView1_GiveFeedback(sender As System.Object, e As System.Windows.Forms.GiveFeedbackEventArgs) Handles ListView1.GiveFeedback
        e.UseDefaultCursors = False
        If ((e.Effect And DragDropEffects.Copy) = DragDropEffects.Copy) Then
            Cursor.Current = Cursors.Hand
        Else
            Cursor.Current = New Cursor(cursor_image.Handle)
        End If
    End Sub

    Private Sub TextBoxItemsearch_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxItemsearch.TextChanged
        Timer1.Stop()
        Timer1.Start()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Timer2.Stop()
        Timer2.Start()
    End Sub

    Private Sub Searchitem(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick, Timer2.Tick
        Timer1.Stop()
        Timer2.Stop()
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
            If doImagesMatch(item_name, ImageList1.Images(146)) Then
                new_item_name = """" & "item_blink" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(145)) Then
                new_item_name = """" & "item_blades_of_attack" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(135)) Then
                new_item_name = """" & "item_ultimate_scepter" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(136)) Then
                new_item_name = """" & "item_courier" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(137)) Then
                new_item_name = """" & "item_arcane_boots" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(138)) Then
                new_item_name = """" & "item_armlet" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(139)) Then
                new_item_name = """" & "item_assault" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(140)) Then
                new_item_name = """" & "item_bfury" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(141)) Then
                new_item_name = """" & "item_black_king_bar" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(142)) Then
                new_item_name = """" & "item_belt_of_strength" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(143)) Then
                new_item_name = """" & "item_blade_mail" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(144)) Then
                new_item_name = """" & "item_blade_of_alacrity" & """"
                Return new_item_name
                'ElseIf doImagesMatch(item_name, Bloodstone) Then
                '    new_item_name = """" & "item_bloodstone" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Bootsofelvenskin) Then
                '    new_item_name = """" & "item_boots_of_elves" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Bootsofspeed) Then
                '    new_item_name = """" & "item_boots" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Bootsoftravel) Then
                '    new_item_name = """" & "item_travel_boots" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Bottle) Then
                '    new_item_name = """" & "item_bottle" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Bracer) Then
                '    new_item_name = """" & "item_bracer" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Broadsword) Then
                '    new_item_name = """" & "item_broadsword" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Nathrezimbuckler) Then
                '    new_item_name = """" & "item_buckler" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Butterfly) Then
                '    new_item_name = """" & "item_butterfly" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Chainmail) Then
                '    new_item_name = """" & "item_chainmail" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Circletofnobility) Then
                '    new_item_name = """" & "item_circlet" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Claritypotion) Then
                '    new_item_name = """" & "item_clarity" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Claymore) Then
                '    new_item_name = """" & "item_claymore" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Planeswalkerscloak) Then
                '    new_item_name = """" & "item_cloak" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Crystalys) Then
                '    new_item_name = """" & "item_lesser_crit" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Burizadokyanon) Then
                '    new_item_name = """" & "item_greater_crit" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Dagon) Then
                '    new_item_name = """" & "item_dagon" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Dagon2) Then
                '    new_item_name = """" & "item_dagon_2" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Dagon3) Then
                '    new_item_name = """" & "item_dagon_3" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Dagon4) Then
                '    new_item_name = """" & "item_dagon_4" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Dagon5) Then
                '    new_item_name = """" & "item_dagon_5" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Demonedge) Then
                '    new_item_name = """" & "item_demon_edge" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Stygiandesolator) Then
                '    new_item_name = """" & "item_desolator" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Diffusalblade) Then
                '    new_item_name = """" & "item_diffusal_blade" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Diffusalblade2) Then
                '    new_item_name = """" & "item_diffusal_blade_2" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Divinerapier) Then
                '    new_item_name = """" & "item_rapier" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Ancientjanggoofendurance) Then
                '    new_item_name = """" & "item_ancient_janggo" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Dustofappearance) Then
                '    new_item_name = """" & "item_dust" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Eaglehorn) Then
                '    new_item_name = """" & "item_eagle" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Energybooster) Then
                '    new_item_name = """" & "item_energy_booster" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Etheral_Blade) Then
                '    new_item_name = """" & "item_ethereal_blade" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Eulsscepterofdivinity) Then
                '    new_item_name = """" & "item_cyclone" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Eyeofskadi) Then
                '    new_item_name = """" & "item_skadi" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Flyingcourier) Then
                '    new_item_name = """" & "item_flying_courier" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Forcestaff) Then
                '    new_item_name = """" & "item_force_staff" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Gauntletsofstrength) Then
                '    new_item_name = """" & "item_gauntlets" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Gemoftruesight) Then
                '    new_item_name = """" & "item_gem" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Ghostscepter) Then
                '    new_item_name = """" & "item_ghost" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Glovesofhaste) Then
                '    new_item_name = """" & "item_gloves" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Handofmidas) Then
                '    new_item_name = """" & "item_hand_of_midas" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Headdressofrejuvenation) Then
                '    new_item_name = """" & "item_headdress" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Healingsalve) Then
                '    new_item_name = """" & "item_flask" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Heartoftarrasque) Then
                '    new_item_name = """" & "item_heart" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Helmofironwill) Then
                '    new_item_name = """" & "item_helm_of_iron_will" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Helmofthedominator) Then
                '    new_item_name = """" & "item_helm_of_the_dominator" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Hoodofdefiance) Then
                '    new_item_name = """" & "item_hood_of_defiance" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Hyperstone) Then
                '    new_item_name = """" & "item_hyperstone" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Ironwoodbranch) Then
                '    new_item_name = """" & "item_branches" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Javelin) Then
                '    new_item_name = """" & "item_javelin" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Linkenssphere) Then
                '    new_item_name = """" & "item_sphere" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Maelstrom) Then
                '    new_item_name = """" & "item_maelstrom" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Magicstick) Then
                '    new_item_name = """" & "item_magic_stick" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Magicwand) Then
                '    new_item_name = """" & "item_magic_wand" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Mantastyle) Then
                '    new_item_name = """" & "item_manta" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Mantleofintelligence) Then
                '    new_item_name = """" & "item_mantle" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Maskofmadness) Then
                '    new_item_name = """" & "item_mask_of_madness" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Medallionofcourage) Then
                '    new_item_name = """" & "item_medallion_of_courage" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Mekansm) Then
                '    new_item_name = """" & "item_mekansm" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Mithrilhammer) Then
                '    new_item_name = """" & "item_mithril_hammer" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Mjollnir) Then
                '    new_item_name = """" & "item_mjollnir" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Monkeykingbar) Then
                '    new_item_name = """" & "item_monkey_king_bar" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Maskofdeath) Then
                '    new_item_name = """" & "item_lifesteal" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Mysticstaff) Then
                '    new_item_name = """" & "item_mystic_staff" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Necronomicon) Then
                '    new_item_name = """" & "item_necronomicon" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Necronomicon2) Then
                '    new_item_name = """" & "item_necronomicon_2" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Necronomicon3) Then
                '    new_item_name = """" & "item_necronomicon_3" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Nulltalisman) Then
                '    new_item_name = """" & "item_null_talisman" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Oblivionstaff) Then
                '    new_item_name = """" & "item_oblivion_staff" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Observerwards) Then
                '    new_item_name = """" & "item_ward_observer" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Ogreaxe) Then
                '    new_item_name = """" & "item_ogre_axe" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, OrbOfVenom) Then
                '    new_item_name = """" & "item_orb_of_venom" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Orchidmalevolence) Then
                '    new_item_name = """" & "item_orchid" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Perseverance) Then
                '    new_item_name = """" & "item_pers" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Phaseboots) Then
                '    new_item_name = """" & "item_phase_boots" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Khadgarspipeofinsight) Then
                '    new_item_name = """" & "item_pipe" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Platemail) Then
                '    new_item_name = """" & "item_platemail" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Pointbooster) Then
                '    new_item_name = """" & "item_point_booster" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Poormansshield) Then
                '    new_item_name = """" & "item_poor_mans_shield" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Powertreads) Then
                '    new_item_name = """" & "item_power_treads" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Quarterstaff) Then
                '    new_item_name = """" & "item_quarterstaff" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Quellingblade) Then
                '    new_item_name = """" & "item_quelling_blade" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Radiance) Then
                '    new_item_name = """" & "item_radiance" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Messerschmidtsreaver) Then
                '    new_item_name = """" & "item_reaver" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Refresherorb) Then
                '    new_item_name = """" & "item_refresher" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Ringofbasilius) Then
                '    new_item_name = """" & "item_ring_of_basilius" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Ringofhealth) Then
                '    new_item_name = """" & "item_ring_of_health" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Ringofprotection) Then
                '    new_item_name = """" & "item_ring_of_protection" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Ringofregeneration) Then
                '    new_item_name = """" & "item_ring_of_regen" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Robeofthemagi) Then
                '    new_item_name = """" & "item_robe" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Sacredrelic) Then
                '    new_item_name = """" & "item_relic" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Sobimask) Then
                '    new_item_name = """" & "item_sobi_mask" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Sange) Then
                '    new_item_name = """" & "item_sange" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Sangeandyasha) Then
                '    new_item_name = """" & "item_sange_and_yasha" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Satanic) Then
                '    new_item_name = """" & "item_satanic" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Guinsoosscytheofvyse) Then
                '    new_item_name = """" & "item_sheepstick" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Sentrywards) Then
                '    new_item_name = """" & "item_ward_sentry" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Lotharsedge) Then
                '    new_item_name = """" & "item_invis_sword" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Shivasguard) Then
                '    new_item_name = """" & "item_shivas_guard" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Craniumbasher) Then
                '    new_item_name = """" & "item_basher" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Slippersofagility) Then
                '    new_item_name = """" & "item_slippers" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, SmokeOfDeceit) Then
                '    new_item_name = """" & "item_smoke_of_deceit" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Soulbooster) Then
                '    new_item_name = """" & "item_soul_booster" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Soul_Ring) Then
                '    new_item_name = """" & "item_soul_ring" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Staffofwizardry) Then
                '    new_item_name = """" & "item_staff_of_wizardry" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Stoutshield) Then
                '    new_item_name = """" & "item_stout_shield" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Talismanofevasion) Then
                '    new_item_name = """" & "item_talisman_of_evasion" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Ancienttangoofessifation) Then
                '    new_item_name = """" & "item_tango" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Townportal) Then
                '    new_item_name = """" & "item_tpscroll" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Ultimateorb) Then
                '    new_item_name = """" & "item_ultimate_orb" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Urnofshadows) Then
                '    new_item_name = """" & "item_urn_of_shadows" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Vanguard) Then
                '    new_item_name = """" & "item_vanguard" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Fatalbonds) Then
                '    new_item_name = """" & "item_veil_of_discord" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Vitalitybooster) Then
                '    new_item_name = """" & "item_vitality_booster" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Vladimirsoffering) Then
                '    new_item_name = """" & "item_vladmir" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Voidstone) Then
                '    new_item_name = """" & "item_void_stone" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Wraithband) Then
                '    new_item_name = """" & "item_wraith_band" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Yasha) Then
                '    new_item_name = """" & "item_yasha" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, AbyssalBlade) Then
                '    new_item_name = """" & "item_abyssal_blade" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, Halberd) Then
                '    new_item_name = """" & "item_heavens_halberd" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, RingofAquila) Then
                '    new_item_name = """" & "item_ring_of_aquila" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, RodofAtos) Then
                '    new_item_name = """" & "item_rod_of_atos" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, TranquilBoots) Then
                new_item_name = """" & "item_tranquil_boots" & """"
                Return new_item_name
            Else
                new_item_name = ""
                Return new_item_name
            End If
        ElseIf ComboBoxItemIcons.Text = "HoN" Then
            If doImagesMatch(item_name, ImageList1.Images(1)) Then
                '    new_item_name = """" & "item_blink" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Punchdagger) Then
                '    new_item_name = """" & "item_blades_of_attack" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Staff_Of_The_Master) Then
                '    new_item_name = """" & "item_ultimate_scepter" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Monkey_Courier) Then
                '    new_item_name = """" & "item_courier" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Ring_Of_Sorcery) Then
                '    new_item_name = """" & "item_arcane_boots" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Insanitarius) Then
                '    new_item_name = """" & "item_armlet" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Daemonic_Breastplate) Then
                '    new_item_name = """" & "item_assault" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Runed_Axe) Then
                '    new_item_name = """" & "item_bfury" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Bolstering_Armband) Then
                '    new_item_name = """" & "item_black_king_bar" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Shrunken_Head) Then
                '    new_item_name = """" & "item_belt_of_strength" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Barbed_Armor) Then
                '    new_item_name = """" & "item_blade_mail" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Quickblade) Then
                '    new_item_name = """" & "item_blade_of_alacrity" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Sacrificial_Stone) Then
                '    new_item_name = """" & "item_bloodstone" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Fleet_Feet) Then
                '    new_item_name = """" & "item_boots_of_elves" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Marchers) Then
                '    new_item_name = """" & "item_boots" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Post_Haste) Then
                '    new_item_name = """" & "item_travel_boots" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Bottle) Then
                '    new_item_name = """" & "item_bottle" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Fortified_Bracelet) Then
                '    new_item_name = """" & "item_bracer" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Broadsword) Then
                '    new_item_name = """" & "item_broadsword" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Shield_Of_The_Five) Then
                '    new_item_name = """" & "item_buckler" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Wingbow) Then
                '    new_item_name = """" & "item_butterfly" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Ringmail) Then
                '    new_item_name = """" & "item_chainmail" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Pretenders_Crown) Then
                '    new_item_name = """" & "item_circlet" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Mana_Potion) Then
                '    new_item_name = """" & "item_clarity" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Bastard_Sword) Then
                '    new_item_name = """" & "item_claymore" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Mystic_Vestments) Then
                '    new_item_name = """" & "item_cloak" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Riftshards) Then
                '    new_item_name = """" & "item_lesser_crit" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, ImageList1.Images(28)) Then
                '    new_item_name = """" & "item_greater_crit" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Codex) Then
                '    new_item_name = """" & "item_dagon" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Codex2) Then
                '    new_item_name = """" & "item_dagon_2" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Codex3) Then
                '    new_item_name = """" & "item_dagon_3" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Codex4) Then
                '    new_item_name = """" & "item_dagon_4" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Codex5) Then
                '    new_item_name = """" & "item_dagon_5" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Slayer) Then
                '    new_item_name = """" & "item_demon_edge" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Shieldbreaker) Then
                '    new_item_name = """" & "item_desolator" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Nullfire_Blade) Then
                '    new_item_name = """" & "item_diffusal_blade" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Nullfire_Blade2) Then
                '    new_item_name = """" & "item_diffusal_blade_2" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Doombringer) Then
                '    new_item_name = """" & "item_rapier" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, ImageList1.Images(39)) Then
                '    new_item_name = """" & "item_ancient_janggo" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Dust_Of_Revelation) Then
                '    new_item_name = """" & "item_dust" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Dancing_Blade) Then
                '    new_item_name = """" & "item_eagle" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Pickled_Brain) Then
                '    new_item_name = """" & "item_energy_booster" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, ImageList1.Images(43)) Then
                '    new_item_name = """" & "item_ethereal_blade" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Stormspirit) Then
                '    new_item_name = """" & "item_cyclone" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Frostwolfs_Skull) Then
                '    new_item_name = """" & "item_skadi" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Winged_Courier) Then
                '    new_item_name = """" & "item_flying_courier" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Tablet_of_Command) Then
                '    new_item_name = """" & "item_force_staff" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Crushing_Claws) Then
                '    new_item_name = """" & "item_gauntlets" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Bound_Eye) Then
                '    new_item_name = """" & "item_gem" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Void_Talisman) Then
                '    new_item_name = """" & "item_ghost" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Gloves_of_the_Swift) Then
                '    new_item_name = """" & "item_gloves" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Alchemist_Bones) Then
                '    new_item_name = """" & "item_hand_of_midas" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Refreshing_Ornament) Then
                '    new_item_name = """" & "item_headdress" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Health_Potion) Then
                '    new_item_name = """" & "item_flask" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Behemoths_Hearth) Then
                '    new_item_name = """" & "item_heart" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Helm_Of_The_Victim) Then
                '    new_item_name = """" & "item_helm_of_iron_will" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Whispering_Helm) Then
                '    new_item_name = """" & "item_helm_of_the_dominator" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Shamans_Headress) Then
                '    new_item_name = """" & "item_hood_of_defiance" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Warpcleft) Then
                '    new_item_name = """" & "item_hyperstone" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Minor_Totem) Then
                '    new_item_name = """" & "item_branches" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Halberd) Then
                '    new_item_name = """" & "item_javelin" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Null_Stone) Then
                '    new_item_name = """" & "item_sphere" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Thunderclaw) Then
                '    new_item_name = """" & "item_maelstrom" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Mana_Battery) Then
                '    new_item_name = """" & "item_magic_stick" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Power_Supply) Then
                '    new_item_name = """" & "item_magic_wand" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Geometers_Bane) Then
                '    new_item_name = """" & "item_manta" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Mark_Of_The_Novice) Then
                '    new_item_name = """" & "item_mantle" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Elder_Parasite) Then
                '    new_item_name = """" & "item_mask_of_madness" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, ImageList1.Images(70)) Then
                '    new_item_name = """" & "item_medallion_of_courage" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Astrolabe) Then
                '    new_item_name = """" & "item_mekansm" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Warhammer) Then
                '    new_item_name = """" & "item_mithril_hammer" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Charged_Hammer) Then
                '    new_item_name = """" & "item_mjollnir" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Savage_Mace) Then
                '    new_item_name = """" & "item_monkey_king_bar" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Hungry_Spirit) Then
                '    new_item_name = """" & "item_lifesteal" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Acolytes_Staff) Then
                '    new_item_name = """" & "item_mystic_staff" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Puzzlebox) Then
                '    new_item_name = """" & "item_necronomicon" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Puzzlebox2) Then
                '    new_item_name = """" & "item_necronomicon_2" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Puzzlebox3) Then
                '    new_item_name = """" & "item_necronomicon_3" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Talisman_Of_Exile) Then
                '    new_item_name = """" & "item_null_talisman" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Great_Arcana) Then
                '    new_item_name = """" & "item_oblivion_staff" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Wards_of_Sight) Then
                '    new_item_name = """" & "item_ward_observer" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Mighty_Blade) Then
                '    new_item_name = """" & "item_ogre_axe" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, ImageList1.Images(84)) Then
                '    new_item_name = """" & "item_orb_of_venom" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Hellflower) Then
                '    new_item_name = """" & "item_orchid" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Sustainer) Then
                '    new_item_name = """" & "item_pers" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Enhanced_Marchers) Then
                '    new_item_name = """" & "item_phase_boots" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Barrier_Idol) Then
                '    new_item_name = """" & "item_pipe" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Platemail) Then
                '    new_item_name = """" & "item_platemail" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Glowstone) Then
                '    new_item_name = """" & "item_point_booster" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Iron_Shield) Then
                '    new_item_name = """" & "item_poor_mans_shield" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Steamboots_Strength) Then
                '    new_item_name = """" & "item_power_treads" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Steamstaff) Then
                '    new_item_name = """" & "item_quarterstaff" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Loggers_Hatchet) Then
                '    new_item_name = """" & "item_quelling_blade" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Mock_of_Brilliance) Then
                '    new_item_name = """" & "item_radiance" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Axe_Of_The_Malphai) Then
                '    new_item_name = """" & "item_reaver" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Restoration_Stone) Then
                '    new_item_name = """" & "item_refresher" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Ring_Of_The_Teacher) Then
                '    new_item_name = """" & "item_ring_of_basilius" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Lifetube) Then
                '    new_item_name = """" & "item_ring_of_health" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Guardian_Ring) Then
                '    new_item_name = """" & "item_ring_of_protection" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Trinket_Of_Restoration) Then
                '    new_item_name = """" & "item_ring_of_regen" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Apprentices_Robe) Then
                '    new_item_name = """" & "item_robe" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Sword_Of_The_High) Then
                '    new_item_name = """" & "item_relic" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Scarab) Then
                '    new_item_name = """" & "item_sobi_mask" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Icebrand) Then
                '    new_item_name = """" & "item_sange" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Frostburn) Then
                '    new_item_name = """" & "item_sange_and_yasha" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Symbol_Of_Rage) Then
                '    new_item_name = """" & "item_satanic" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Kuldras_Sheepstick) Then
                '    new_item_name = """" & "item_sheepstick" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Wards_of_Revelation) Then
                '    new_item_name = """" & "item_ward_sentry" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Shroud_Of_The_Assasin) Then
                '    new_item_name = """" & "item_invis_sword" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Frostfield_Plate) Then
                '    new_item_name = """" & "item_shivas_guard" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Brutalizer) Then
                '    new_item_name = """" & "item_basher" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Duck_Boots) Then
                '    new_item_name = """" & "item_slippers" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, ImageList1.Images(116)) Then
                '    new_item_name = """" & "item_smoke_of_deceit" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Icon_Of_The_Goddess) Then
                '    new_item_name = """" & "item_soul_booster" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Blood_Chalice) Then
                '    new_item_name = """" & "item_soul_ring" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Neophytes_Book) Then
                '    new_item_name = """" & "item_staff_of_wizardry" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Iron_Buckler) Then
                '    new_item_name = """" & "item_stout_shield" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Snake_Bracelet) Then
                '    new_item_name = """" & "item_talisman_of_evasion" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Runes_Of_The_Blight) Then
                '    new_item_name = """" & "item_tango" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Homecoming_Stone) Then
                '    new_item_name = """" & "item_tpscroll" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Blessed_Orb) Then
                '    new_item_name = """" & "item_ultimate_orb" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, ImageList1.Images(126)) Then
                '    new_item_name = """" & "item_urn_of_shadows" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Helm_Of_The_Black_Legion) Then
                '    new_item_name = """" & "item_vanguard" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, ImageList1.Images(128)) Then
                '    new_item_name = """" & "item_veil_of_discord" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Beastheart) Then
                '    new_item_name = """" & "item_vitality_booster" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Abyssal_Skull) Then
                '    new_item_name = """" & "item_vladmir" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Manatube) Then
                '    new_item_name = """" & "item_void_stone" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Soulscream_Ring) Then
                '    new_item_name = """" & "item_wraith_band" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Firebrand) Then
                '    new_item_name = """" & "item_yasha" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, ImageList1.Images(0)) Then
                '    new_item_name = """" & "item_abyssal_blade" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, ImageList1.Images(56)) Then
                '    new_item_name = """" & "item_heavens_halberd" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, ImageList1.Images(98)) Then
                '    new_item_name = """" & "item_ring_of_aquila" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, ImageList1.Images(104)) Then
                '    new_item_name = """" & "item_rod_of_atos" & """"
                '    Return new_item_name
                'ElseIf doImagesMatch(item_name, HoN_Striders) Then
                new_item_name = """" & "item_tranquil_boots" & """"
                Return new_item_name
            Else
                new_item_name = ""
                Return new_item_name
            End If
        Else
            If doImagesMatch(item_name, ImageList1.Images(12)) Then
                new_item_name = """" & "item_blink" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(11)) Then
                new_item_name = """" & "item_blades_of_attack" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(1)) Then
                new_item_name = """" & "item_ultimate_scepter" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(2)) Then
                new_item_name = """" & "item_courier" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(3)) Then
                new_item_name = """" & "item_arcane_boots" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(4)) Then
                new_item_name = """" & "item_armlet" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(5)) Then
                new_item_name = """" & "item_assault" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(6)) Then
                new_item_name = """" & "item_bfury" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(7)) Then
                new_item_name = """" & "item_black_king_bar" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(8)) Then
                new_item_name = """" & "item_belt_of_strength" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(9)) Then
                new_item_name = """" & "item_blade_mail" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(10)) Then
                new_item_name = """" & "item_blade_of_alacrity" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(13)) Then
                new_item_name = """" & "item_bloodstone" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(14)) Then
                new_item_name = """" & "item_boots_of_elves" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(15)) Then
                new_item_name = """" & "item_boots" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(16)) Then
                new_item_name = """" & "item_travel_boots" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(17)) Then
                new_item_name = """" & "item_bottle" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(18)) Then
                new_item_name = """" & "item_bracer" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(19)) Then
                new_item_name = """" & "item_broadsword" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(20)) Then
                new_item_name = """" & "item_buckler" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(21)) Then
                new_item_name = """" & "item_butterfly" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(22)) Then
                new_item_name = """" & "item_chainmail" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(23)) Then
                new_item_name = """" & "item_circlet" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(24)) Then
                new_item_name = """" & "item_clarity" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(25)) Then
                new_item_name = """" & "item_claymore" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(26)) Then
                new_item_name = """" & "item_cloak" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(27)) Then
                new_item_name = """" & "item_lesser_crit" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(28)) Then
                new_item_name = """" & "item_greater_crit" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(29)) Then
                new_item_name = """" & "item_dagon" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(30)) Then
                new_item_name = """" & "item_dagon_2" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(31)) Then
                new_item_name = """" & "item_dagon_3" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(32)) Then
                new_item_name = """" & "item_dagon_4" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(33)) Then
                new_item_name = """" & "item_dagon_5" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(34)) Then
                new_item_name = """" & "item_demon_edge" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(35)) Then
                new_item_name = """" & "item_desolator" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(36)) Then
                new_item_name = """" & "item_diffusal_blade" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(37)) Then
                new_item_name = """" & "item_diffusal_blade_2" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(38)) Then
                new_item_name = """" & "item_rapier" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(39)) Then
                new_item_name = """" & "item_ancient_janggo" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(40)) Then
                new_item_name = """" & "item_dust" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(41)) Then
                new_item_name = """" & "item_eagle" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(42)) Then
                new_item_name = """" & "item_energy_booster" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(43)) Then
                new_item_name = """" & "item_ethereal_blade" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(44)) Then
                new_item_name = """" & "item_cyclone" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(45)) Then
                new_item_name = """" & "item_skadi" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(46)) Then
                new_item_name = """" & "item_flying_courier" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(47)) Then
                new_item_name = """" & "item_force_staff" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(48)) Then
                new_item_name = """" & "item_gauntlets" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(49)) Then
                new_item_name = """" & "item_gem" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(50)) Then
                new_item_name = """" & "item_ghost" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(51)) Then
                new_item_name = """" & "item_gloves" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(52)) Then
                new_item_name = """" & "item_hand_of_midas" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(53)) Then
                new_item_name = """" & "item_headdress" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(54)) Then
                new_item_name = """" & "item_flask" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(55)) Then
                new_item_name = """" & "item_heart" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(57)) Then
                new_item_name = """" & "item_helm_of_iron_will" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(58)) Then
                new_item_name = """" & "item_helm_of_the_dominator" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(59)) Then
                new_item_name = """" & "item_hood_of_defiance" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(60)) Then
                new_item_name = """" & "item_hyperstone" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(61)) Then
                new_item_name = """" & "item_branches" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(62)) Then
                new_item_name = """" & "item_javelin" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(63)) Then
                new_item_name = """" & "item_sphere" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(64)) Then
                new_item_name = """" & "item_maelstrom" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(65)) Then
                new_item_name = """" & "item_magic_stick" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(66)) Then
                new_item_name = """" & "item_magic_wand" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(67)) Then
                new_item_name = """" & "item_manta" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(68)) Then
                new_item_name = """" & "item_mantle" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(69)) Then
                new_item_name = """" & "item_mask_of_madness" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(70)) Then
                new_item_name = """" & "item_medallion_of_courage" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(71)) Then
                new_item_name = """" & "item_mekansm" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(72)) Then
                new_item_name = """" & "item_mithril_hammer" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(73)) Then
                new_item_name = """" & "item_mjollnir" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(74)) Then
                new_item_name = """" & "item_monkey_king_bar" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(75)) Then
                new_item_name = """" & "item_lifesteal" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(76)) Then
                new_item_name = """" & "item_mystic_staff" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(77)) Then
                new_item_name = """" & "item_necronomicon" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(78)) Then
                new_item_name = """" & "item_necronomicon_2" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(79)) Then
                new_item_name = """" & "item_necronomicon_3" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(80)) Then
                new_item_name = """" & "item_null_talisman" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(81)) Then
                new_item_name = """" & "item_oblivion_staff" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(82)) Then
                new_item_name = """" & "item_ward_observer" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(83)) Then
                new_item_name = """" & "item_ogre_axe" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(84)) Then
                new_item_name = """" & "item_orb_of_venom" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(85)) Then
                new_item_name = """" & "item_orchid" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(86)) Then
                new_item_name = """" & "item_pers" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(87)) Then
                new_item_name = """" & "item_phase_boots" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(88)) Then
                new_item_name = """" & "item_pipe" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(89)) Then
                new_item_name = """" & "item_platemail" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(90)) Then
                new_item_name = """" & "item_point_booster" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(91)) Then
                new_item_name = """" & "item_poor_mans_shield" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(92)) Then
                new_item_name = """" & "item_power_treads" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(93)) Then
                new_item_name = """" & "item_quarterstaff" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(94)) Then
                new_item_name = """" & "item_quelling_blade" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(95)) Then
                new_item_name = """" & "item_radiance" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(96)) Then
                new_item_name = """" & "item_reaver" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(97)) Then
                new_item_name = """" & "item_refresher" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(99)) Then
                new_item_name = """" & "item_ring_of_basilius" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(100)) Then
                new_item_name = """" & "item_ring_of_health" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(101)) Then
                new_item_name = """" & "item_ring_of_protection" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(102)) Then
                new_item_name = """" & "item_ring_of_regen" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(103)) Then
                new_item_name = """" & "item_robe" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(105)) Then
                new_item_name = """" & "item_relic" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(106)) Then
                new_item_name = """" & "item_sobi_mask" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(107)) Then
                new_item_name = """" & "item_sange" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(108)) Then
                new_item_name = """" & "item_sange_and_yasha" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(109)) Then
                new_item_name = """" & "item_satanic" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(110)) Then
                new_item_name = """" & "item_sheepstick" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(111)) Then
                new_item_name = """" & "item_ward_sentry" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(112)) Then
                new_item_name = """" & "item_invis_sword" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(113)) Then
                new_item_name = """" & "item_shivas_guard" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(114)) Then
                new_item_name = """" & "item_basher" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(115)) Then
                new_item_name = """" & "item_slippers" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(116)) Then
                new_item_name = """" & "item_smoke_of_deceit" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(117)) Then
                new_item_name = """" & "item_soul_booster" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(118)) Then
                new_item_name = """" & "item_soul_ring" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(119)) Then
                new_item_name = """" & "item_staff_of_wizardry" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(120)) Then
                new_item_name = """" & "item_stout_shield" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(121)) Then
                new_item_name = """" & "item_talisman_of_evasion" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(122)) Then
                new_item_name = """" & "item_tango" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(123)) Then
                new_item_name = """" & "item_tpscroll" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(125)) Then
                new_item_name = """" & "item_ultimate_orb" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(126)) Then
                new_item_name = """" & "item_urn_of_shadows" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(127)) Then
                new_item_name = """" & "item_vanguard" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(128)) Then
                new_item_name = """" & "item_veil_of_discord" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(129)) Then
                new_item_name = """" & "item_vitality_booster" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(130)) Then
                new_item_name = """" & "item_vladmir" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(131)) Then
                new_item_name = """" & "item_void_stone" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(132)) Then
                new_item_name = """" & "item_wraith_band" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(133)) Then
                new_item_name = """" & "item_yasha" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(0)) Then
                new_item_name = """" & "item_abyssal_blade" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(56)) Then
                new_item_name = """" & "item_heavens_halberd" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(98)) Then
                new_item_name = """" & "item_ring_of_aquila" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(104)) Then
                new_item_name = """" & "item_rod_of_atos" & """"
                Return new_item_name
            ElseIf doImagesMatch(item_name, ImageList1.Images(124)) Then
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
                    pic_res = ImageList1.Images(146)
                    Return pic_res
                Case "Blades of Attack"
                    pic_res = ImageList1.Images(145)
                    Return pic_res
                Case "Aghanim's Scepter"
                    pic_res = ImageList1.Images(135)
                    Return pic_res
                Case "Animal Courier"
                    pic_res = ImageList1.Images(136)
                    Return pic_res
                Case "Arcane Boots"
                    pic_res = ImageList1.Images(137)
                    Return pic_res
                Case "Armlet"
                    pic_res = ImageList1.Images(138)
                    Return pic_res
                Case "Assault Cuirass"
                    pic_res = ImageList1.Images(139)
                    Return pic_res
                Case "Battle Fury"
                    pic_res = ImageList1.Images(140)
                    Return pic_res
                Case "Belt of Strength"
                    pic_res = ImageList1.Images(141)
                    Return pic_res
                Case "Black King Bar"
                    pic_res = ImageList1.Images(142)
                    Return pic_res
                Case "Blade Mail"
                    pic_res = ImageList1.Images(143)
                    Return pic_res
                Case "Blade of Alacrity"
                    pic_res = ImageList1.Images(144)
                    Return pic_res
                    'Case "Bloodstone"
                    '    pic_res = Bloodstone
                    '    Return pic_res
                    'Case "Boots of Elvenskin"
                    '    pic_res = Bootsofelvenskin
                    '    Return pic_res
                    'Case "Boots of Speed"
                    '    pic_res = Bootsofspeed
                    '    Return pic_res
                    'Case "Boots of Travel"
                    '    pic_res = Bootsoftravel
                    '    Return pic_res
                    'Case "Bottle"
                    '    pic_res = Bottle
                    '    Return pic_res
                    'Case "Bracer"
                    '    pic_res = Bracer
                    '    Return pic_res
                    'Case "Broadsword"
                    '    pic_res = Broadsword
                    '    Return pic_res
                    'Case "Buckler"
                    '    pic_res = Nathrezimbuckler
                    '    Return pic_res
                    'Case "Butterfly"
                    '    pic_res = Butterfly
                    '    Return pic_res
                    'Case "Chainmail"
                    '    pic_res = Chainmail
                    '    Return pic_res
                    'Case "Circlet"
                    '    pic_res = Circletofnobility
                    '    Return pic_res
                    'Case "Clarity"
                    '    pic_res = Claritypotion
                    '    Return pic_res
                    'Case "Claymore"
                    '    pic_res = Claymore
                    '    Return pic_res
                    'Case "Cloak"
                    '    pic_res = Planeswalkerscloak
                    '    Return pic_res
                    'Case "Crystalys"
                    '    pic_res = Crystalys
                    '    Return pic_res
                    'Case "Daedalus"
                    '    pic_res = Burizadokyanon
                    '    Return pic_res
                    'Case "Dagon 1"
                    '    pic_res = Dagon
                    '    Return pic_res
                    'Case "Dagon 2"
                    '    pic_res = Dagon2
                    '    Return pic_res
                    'Case "Dagon 3"
                    '    pic_res = Dagon3
                    '    Return pic_res
                    'Case "Dagon 4"
                    '    pic_res = Dagon4
                    '    Return pic_res
                    'Case "Dagon 5"
                    '    pic_res = Dagon5
                    '    Return pic_res
                    'Case "Demon Edge"
                    '    pic_res = Demonedge
                    '    Return pic_res
                    'Case "Desolator"
                    '    pic_res = Stygiandesolator
                    '    Return pic_res
                    'Case "Diffusal Blade 1"
                    '    pic_res = Diffusalblade
                    '    Return pic_res
                    'Case "Diffusal Blade 2"
                    '    pic_res = Diffusalblade2
                    '    Return pic_res
                    'Case "Divine Rapier"
                    '    pic_res = Divinerapier
                    '    Return pic_res
                    'Case "Drum of Endurance"
                    '    pic_res = Ancientjanggoofendurance
                    '    Return pic_res
                    'Case "Dust of Appearance"
                    '    pic_res = Dustofappearance
                    '    Return pic_res
                    'Case "Eaglesong"
                    '    pic_res = Eaglehorn
                    '    Return pic_res
                    'Case "Energy Booster"
                    '    pic_res = Energybooster
                    '    Return pic_res
                    'Case "Ethereal Blade"
                    '    pic_res = Etheral_Blade
                    '    Return pic_res
                    'Case "Eul's Scepter of Divinity"
                    '    pic_res = Eulsscepterofdivinity
                    '    Return pic_res
                    'Case "Eye of Skadi"
                    '    pic_res = Eyeofskadi
                    '    Return pic_res
                    'Case "Flying Courier"
                    '    pic_res = Flyingcourier
                    '    Return pic_res
                    'Case "Force Staff"
                    '    pic_res = Forcestaff
                    '    Return pic_res
                    'Case "Gauntlets of Strength"
                    '    pic_res = Gauntletsofstrength
                    '    Return pic_res
                    'Case "Gem of True Sight"
                    '    pic_res = Gemoftruesight
                    '    Return pic_res
                    'Case "Ghost Scepter"
                    '    pic_res = Ghostscepter
                    '    Return pic_res
                    'Case "Gloves of Haste"
                    '    pic_res = Glovesofhaste
                    '    Return pic_res
                    'Case "Hand of Midas"
                    '    pic_res = Handofmidas
                    '    Return pic_res
                    'Case "Headdress"
                    '    pic_res = Headdressofrejuvenation
                    '    Return pic_res
                    'Case "Healing Salve"
                    '    pic_res = Healingsalve
                    '    Return pic_res
                    'Case "Heart of Tarrasque"
                    '    pic_res = Heartoftarrasque
                    '    Return pic_res
                    'Case "Helm of Iron Will"
                    '    pic_res = Helmofironwill
                    '    Return pic_res
                    'Case "Helm of the Dominator"
                    '    pic_res = Helmofthedominator
                    '    Return pic_res
                    'Case "Hood of Defiance"
                    '    pic_res = Hoodofdefiance
                    '    Return pic_res
                    'Case "Hyperstone"
                    '    pic_res = Hyperstone
                    '    Return pic_res
                    'Case "Iron Branch"
                    '    pic_res = Ironwoodbranch
                    '    Return pic_res
                    'Case "Javelin"
                    '    pic_res = Javelin
                    '    Return pic_res
                    'Case "Linken's Sphere"
                    '    pic_res = Linkenssphere
                    '    Return pic_res
                    'Case "Maelstrom"
                    '    pic_res = Maelstrom
                    '    Return pic_res
                    'Case "Magic Stick"
                    '    pic_res = Magicstick
                    '    Return pic_res
                    'Case "Magic Wand"
                    '    pic_res = Magicwand
                    '    Return pic_res
                    'Case "Manta Style"
                    '    pic_res = Mantastyle
                    '    Return pic_res
                    'Case "Mantle of Intelligence"
                    '    pic_res = Mantleofintelligence
                    '    Return pic_res
                    'Case "Mask of Madness"
                    '    pic_res = Maskofmadness
                    '    Return pic_res
                    'Case "Medallion of Courage"
                    '    pic_res = Medallionofcourage
                    '    Return pic_res
                    'Case "Mekansm"
                    '    pic_res = Mekansm
                    '    Return pic_res
                    'Case "Mithril Hammer"
                    '    pic_res = Mithrilhammer
                    '    Return pic_res
                    'Case "Mjollnir"
                    '    pic_res = Mjollnir
                    '    Return pic_res
                    'Case "Monkey King Bar"
                    '    pic_res = Monkeykingbar
                    '    Return pic_res
                    'Case "Morbid Mask"
                    '    pic_res = Maskofdeath
                    '    Return pic_res
                    'Case "Mystic Staff"
                    '    pic_res = Mysticstaff
                    '    Return pic_res
                    'Case "Necronomicon 1"
                    '    pic_res = Necronomicon
                    '    Return pic_res
                    'Case "Necronomicon 2"
                    '    pic_res = Necronomicon2
                    '    Return pic_res
                    'Case "Necronomicon 3"
                    '    pic_res = Necronomicon3
                    '    Return pic_res
                    'Case "Null Talisman"
                    '    pic_res = Nulltalisman
                    '    Return pic_res
                    'Case "Oblivion Staff"
                    '    pic_res = Oblivionstaff
                    '    Return pic_res
                    'Case "Observer Ward"
                    '    pic_res = Observerwards
                    '    Return pic_res
                    'Case "Ogre Club"
                    '    pic_res = Ogreaxe
                    '    Return pic_res
                    'Case "Orb of Venom"
                    '    pic_res = OrbOfVenom
                    '    Return pic_res
                    'Case "Orchid Malevolence"
                    '    pic_res = Orchidmalevolence
                    '    Return pic_res
                    'Case "Perseverance"
                    '    pic_res = Perseverance
                    '    Return pic_res
                    'Case "Phase Boots"
                    '    pic_res = Phaseboots
                    '    Return pic_res
                    'Case "Pipe of Insight"
                    '    pic_res = Khadgarspipeofinsight
                    '    Return pic_res
                    'Case "Platemail"
                    '    pic_res = Platemail
                    '    Return pic_res
                    'Case "Point Booster"
                    '    pic_res = Pointbooster
                    '    Return pic_res
                    'Case "Poor Man's Shield"
                    '    pic_res = Poormansshield
                    '    Return pic_res
                    'Case "Power Treads"
                    '    pic_res = Powertreads
                    '    Return pic_res
                    'Case "Quarterstaff"
                    '    pic_res = Quarterstaff
                    '    Return pic_res
                    'Case "Quelling Blade"
                    '    pic_res = Quellingblade
                    '    Return pic_res
                    'Case "Radiance"
                    '    pic_res = Radiance
                    '    Return pic_res
                    'Case "Reaver"
                    '    pic_res = Messerschmidtsreaver
                    '    Return pic_res
                    'Case "Refresher Orb"
                    '    pic_res = Refresherorb
                    '    Return pic_res
                    'Case "Ring of Basilius"
                    '    pic_res = Ringofbasilius
                    '    Return pic_res
                    'Case "Ring of Health"
                    '    pic_res = Ringofhealth
                    '    Return pic_res
                    'Case "Ring of Protection"
                    '    pic_res = Ringofprotection
                    '    Return pic_res
                    'Case "Ring of Regen"
                    '    pic_res = Ringofregeneration
                    '    Return pic_res
                    'Case "Robe of the Magi"
                    '    pic_res = Robeofthemagi
                    '    Return pic_res
                    'Case "Sacred Relic"
                    '    pic_res = Sacredrelic
                    '    Return pic_res
                    'Case "Sage's Mask"
                    '    pic_res = Sobimask
                    '    Return pic_res
                    'Case "Sange"
                    '    pic_res = Sange
                    '    Return pic_res
                    'Case "Sange and Yasha"
                    '    pic_res = Sangeandyasha
                    '    Return pic_res
                    'Case "Satanic"
                    '    pic_res = Satanic
                    '    Return pic_res
                    'Case "Scythe of Vyse"
                    '    pic_res = Guinsoosscytheofvyse
                    '    Return pic_res
                    'Case "Sentry Ward"
                    '    pic_res = Sentrywards
                    '    Return pic_res
                    'Case "Shadow Blade"
                    '    pic_res = Lotharsedge
                    '    Return pic_res
                    'Case "Shiva's Guard"
                    '    pic_res = Shivasguard
                    '    Return pic_res
                    'Case "Skull Basher"
                    '    pic_res = Craniumbasher
                    '    Return pic_res
                    'Case "Slippers of Agility"
                    '    pic_res = Slippersofagility
                    '    Return pic_res
                    'Case "Smoke of Deceit"
                    '    pic_res = SmokeOfDeceit
                    '    Return pic_res
                    'Case "Soul Booster"
                    '    pic_res = Soulbooster
                    '    Return pic_res
                    'Case "Soul Ring"
                    '    pic_res = Soul_Ring
                    '    Return pic_res
                    'Case "Staff of Wizardry"
                    '    pic_res = Staffofwizardry
                    '    Return pic_res
                    'Case "Stout Shield"
                    '    pic_res = Stoutshield
                    '    Return pic_res
                    'Case "Talisman of Evasion"
                    '    pic_res = Talismanofevasion
                    '    Return pic_res
                    'Case "Tango"
                    '    pic_res = Ancienttangoofessifation
                    '    Return pic_res
                    'Case "Town Portal Scroll"
                    '    pic_res = Townportal
                    '    Return pic_res
                    'Case "Ultimate Orb"
                    '    pic_res = Ultimateorb
                    '    Return pic_res
                    'Case "Urn of Shadows"
                    '    pic_res = Urnofshadows
                    '    Return pic_res
                    'Case "Vanguard"
                    '    pic_res = Vanguard
                    '    Return pic_res
                    'Case "Veil of Discord"
                    '    pic_res = Fatalbonds
                    '    Return pic_res
                    'Case "Vitality Booster"
                    '    pic_res = Vitalitybooster
                    '    Return pic_res
                    'Case "Vladmir's Offering"
                    '    pic_res = Vladimirsoffering
                    '    Return pic_res
                    'Case "Void Stone"
                    '    pic_res = Voidstone
                    '    Return pic_res
                    'Case "Wraith Band"
                    '    pic_res = Wraithband
                    '    Return pic_res
                    'Case "Yasha"
                    '    pic_res = Yasha
                    '    Return pic_res
                    'Case "Abyssal Blade"
                    '    pic_res = AbyssalBlade
                    '    Return pic_res
                    'Case "Heaven's Halberd"
                    '    pic_res = Halberd
                    '    Return pic_res
                    'Case "Ring of Aquila"
                    '    pic_res = RingofAquila
                    '    Return pic_res
                    'Case "Rod of Atos"
                    '    pic_res = RodofAtos
                    '    Return pic_res
                    'Case "Tranquil Boots"
                    '    pic_res = TranquilBoots
                    Return pic_res
                Case Else
                    pic_res = D2RIC.My.Resources.Resources.none
                    Return pic_res
            End Select
        ElseIf ComboBoxItemIcons.Text = "HoN" Then
            Select Case item_name
                Case "Blink Dagger"
                    '    pic_res = HoN_Portal_Key
                    '    Return pic_res
                    'Case "Blades of Attack"
                    '    pic_res = HoN_Punchdagger
                    '    Return pic_res
                    'Case "Aghanim's Scepter"
                    '    pic_res = HoN_Staff_Of_The_Master
                    '    Return pic_res
                    'Case "Animal Courier"
                    '    pic_res = HoN_Monkey_Courier
                    '    Return pic_res
                    'Case "Arcane Boots"
                    '    pic_res = HoN_Ring_Of_Sorcery
                    '    Return pic_res
                    'Case "Armlet"
                    '    pic_res = HoN_Insanitarius
                    '    Return pic_res
                    'Case "Assault Cuirass"
                    '    pic_res = HoN_Daemonic_Breastplate
                    '    Return pic_res
                    'Case "Battle Fury"
                    '    pic_res = HoN_Runed_Axe
                    '    Return pic_res
                    'Case "Belt of Strength"
                    '    pic_res = HoN_Bolstering_Armband
                    '    Return pic_res
                    'Case "Black King Bar"
                    '    pic_res = HoN_Shrunken_Head
                    '    Return pic_res
                    'Case "Blade Mail"
                    '    pic_res = HoN_Barbed_Armor
                    '    Return pic_res
                    'Case "Blade of Alacrity"
                    '    pic_res = HoN_Quickblade
                    '    Return pic_res
                    'Case "Bloodstone"
                    '    pic_res = HoN_Sacrificial_Stone
                    '    Return pic_res
                    'Case "Boots of Elvenskin"
                    '    pic_res = HoN_Fleet_Feet
                    '    Return pic_res
                    'Case "Boots of Speed"
                    '    pic_res = HoN_Marchers
                    '    Return pic_res
                    'Case "Boots of Travel"
                    '    pic_res = HoN_Post_Haste
                    '    Return pic_res
                    'Case "Bottle"
                    '    pic_res = HoN_Bottle
                    '    Return pic_res
                    'Case "Bracer"
                    '    pic_res = HoN_Fortified_Bracelet
                    '    Return pic_res
                    'Case "Broadsword"
                    '    pic_res = HoN_Broadsword
                    '    Return pic_res
                    'Case "Buckler"
                    '    pic_res = HoN_Shield_Of_The_Five
                    '    Return pic_res
                    'Case "Butterfly"
                    '    pic_res = HoN_Wingbow
                    '    Return pic_res
                    'Case "Chainmail"
                    '    pic_res = HoN_Ringmail
                    '    Return pic_res
                    'Case "Circlet"
                    '    pic_res = HoN_Pretenders_Crown
                    '    Return pic_res
                    'Case "Clarity"
                    '    pic_res = HoN_Mana_Potion
                    '    Return pic_res
                    'Case "Claymore"
                    '    pic_res = HoN_Bastard_Sword
                    '    Return pic_res
                    'Case "Cloak"
                    '    pic_res = HoN_Mystic_Vestments
                    '    Return pic_res
                    'Case "Crystalys"
                    '    pic_res = HoN_Riftshards
                    '    Return pic_res
                    'Case "Daedalus"
                    '    pic_res = ImageList1.Images(28)
                    '    Return pic_res
                    'Case "Dagon 1"
                    '    pic_res = HoN_Codex
                    '    Return pic_res
                    'Case "Dagon 2"
                    '    pic_res = HoN_Codex2
                    '    Return pic_res
                    'Case "Dagon 3"
                    '    pic_res = HoN_Codex3
                    '    Return pic_res
                    'Case "Dagon 4"
                    '    pic_res = HoN_Codex4
                    '    Return pic_res
                    'Case "Dagon 5"
                    '    pic_res = HoN_Codex5
                    '    Return pic_res
                    'Case "Demon Edge"
                    '    pic_res = HoN_Slayer
                    '    Return pic_res
                    'Case "Desolator"
                    '    pic_res = HoN_Shieldbreaker
                    '    Return pic_res
                    'Case "Diffusal Blade 1"
                    '    pic_res = HoN_Nullfire_Blade
                    '    Return pic_res
                    'Case "Diffusal Blade 2"
                    '    pic_res = HoN_Nullfire_Blade2
                    '    Return pic_res
                    'Case "Divine Rapier"
                    '    pic_res = HoN_Doombringer
                    '    Return pic_res
                    'Case "Drum of Endurance"
                    '    pic_res = ImageList1.Images(39)
                    '    Return pic_res
                    'Case "Dust of Appearance"
                    '    pic_res = HoN_Dust_Of_Revelation
                    '    Return pic_res
                    'Case "Eaglesong"
                    '    pic_res = HoN_Dancing_Blade
                    '    Return pic_res
                    'Case "Energy Booster"
                    '    pic_res = HoN_Pickled_Brain
                    '    Return pic_res
                    'Case "Ethereal Blade"
                    '    pic_res = ImageList1.Images(43)
                    '    Return pic_res
                    'Case "Eul's Scepter of Divinity"
                    '    pic_res = HoN_Stormspirit
                    '    Return pic_res
                    'Case "Eye of Skadi"
                    '    pic_res = HoN_Frostwolfs_Skull
                    '    Return pic_res
                    'Case "Flying Courier"
                    '    pic_res = HoN_Winged_Courier
                    '    Return pic_res
                    'Case "Force Staff"
                    '    pic_res = HoN_Tablet_of_Command
                    '    Return pic_res
                    'Case "Gauntlets of Strength"
                    '    pic_res = HoN_Crushing_Claws
                    '    Return pic_res
                    'Case "Gem of True Sight"
                    '    pic_res = HoN_Bound_Eye
                    '    Return pic_res
                    'Case "Ghost Scepter"
                    '    pic_res = HoN_Void_Talisman
                    '    Return pic_res
                    'Case "Gloves of Haste"
                    '    pic_res = HoN_Gloves_of_the_Swift
                    '    Return pic_res
                    'Case "Hand of Midas"
                    '    pic_res = HoN_Alchemist_Bones
                    '    Return pic_res
                    'Case "Headdress"
                    '    pic_res = HoN_Refreshing_Ornament
                    '    Return pic_res
                    'Case "Healing Salve"
                    '    pic_res = HoN_Health_Potion
                    '    Return pic_res
                    'Case "Heart of Tarrasque"
                    '    pic_res = HoN_Behemoths_Hearth
                    '    Return pic_res
                    'Case "Helm of Iron Will"
                    '    pic_res = HoN_Helm_Of_The_Victim
                    '    Return pic_res
                    'Case "Helm of the Dominator"
                    '    pic_res = HoN_Whispering_Helm
                    '    Return pic_res
                    'Case "Hood of Defiance"
                    '    pic_res = HoN_Shamans_Headress
                    '    Return pic_res
                    'Case "Hyperstone"
                    '    pic_res = HoN_Warpcleft
                    '    Return pic_res
                    'Case "Iron Branch"
                    '    pic_res = HoN_Minor_Totem
                    '    Return pic_res
                    'Case "Javelin"
                    '    pic_res = HoN_Halberd
                    '    Return pic_res
                    'Case "Linken's Sphere"
                    '    pic_res = HoN_Null_Stone
                    '    Return pic_res
                    'Case "Maelstrom"
                    '    pic_res = HoN_Thunderclaw
                    '    Return pic_res
                    'Case "Magic Stick"
                    '    pic_res = HoN_Mana_Battery
                    '    Return pic_res
                    'Case "Magic Wand"
                    '    pic_res = HoN_Power_Supply
                    '    Return pic_res
                    'Case "Manta Style"
                    '    pic_res = HoN_Geometers_Bane
                    '    Return pic_res
                    'Case "Mantle of Intelligence"
                    '    pic_res = HoN_Mark_Of_The_Novice
                    '    Return pic_res
                    'Case "Mask of Madness"
                    '    pic_res = HoN_Elder_Parasite
                    '    Return pic_res
                    'Case "Medallion of Courage"
                    '    pic_res = ImageList1.Images(70)
                    '    Return pic_res
                    'Case "Mekansm"
                    '    pic_res = HoN_Astrolabe
                    '    Return pic_res
                    'Case "Mithril Hammer"
                    '    pic_res = HoN_Warhammer
                    '    Return pic_res
                    'Case "Mjollnir"
                    '    pic_res = HoN_Charged_Hammer
                    '    Return pic_res
                    'Case "Monkey King Bar"
                    '    pic_res = HoN_Savage_Mace
                    '    Return pic_res
                    'Case "Morbid Mask"
                    '    pic_res = HoN_Hungry_Spirit
                    '    Return pic_res
                    'Case "Mystic Staff"
                    '    pic_res = HoN_Acolytes_Staff
                    '    Return pic_res
                    'Case "Necronomicon 1"
                    '    pic_res = HoN_Puzzlebox
                    '    Return pic_res
                    'Case "Necronomicon 2"
                    '    pic_res = HoN_Puzzlebox2
                    '    Return pic_res
                    'Case "Necronomicon 3"
                    '    pic_res = HoN_Puzzlebox3
                    '    Return pic_res
                    'Case "Null Talisman"
                    '    pic_res = HoN_Talisman_Of_Exile
                    '    Return pic_res
                    'Case "Oblivion Staff"
                    '    pic_res = HoN_Great_Arcana
                    '    Return pic_res
                    'Case "Observer Ward"
                    '    pic_res = HoN_Wards_of_Sight
                    '    Return pic_res
                    'Case "Ogre Club"
                    '    pic_res = HoN_Mighty_Blade
                    '    Return pic_res
                    'Case "Orb of Venom"
                    '    pic_res = ImageList1.Images(84)
                    '    Return pic_res
                    'Case "Orchid Malevolence"
                    '    pic_res = HoN_Hellflower
                    '    Return pic_res
                    'Case "Perseverance"
                    '    pic_res = HoN_Sustainer
                    '    Return pic_res
                    'Case "Phase Boots"
                    '    pic_res = HoN_Enhanced_Marchers
                    '    Return pic_res
                    'Case "Pipe of Insight"
                    '    pic_res = HoN_Barrier_Idol
                    '    Return pic_res
                    'Case "Platemail"
                    '    pic_res = HoN_Platemail
                    '    Return pic_res
                    'Case "Point Booster"
                    '    pic_res = HoN_Glowstone
                    '    Return pic_res
                    'Case "Poor Man's Shield"
                    '    pic_res = HoN_Iron_Shield
                    '    Return pic_res
                    'Case "Power Treads"
                    '    pic_res = HoN_Steamboots_Strength
                    '    Return pic_res
                    'Case "Quarterstaff"
                    '    pic_res = HoN_Steamstaff
                    '    Return pic_res
                    'Case "Quelling Blade"
                    '    pic_res = HoN_Loggers_Hatchet
                    '    Return pic_res
                    'Case "Radiance"
                    '    pic_res = HoN_Mock_of_Brilliance
                    '    Return pic_res
                    'Case "Reaver"
                    '    pic_res = HoN_Axe_Of_The_Malphai
                    '    Return pic_res
                    'Case "Refresher Orb"
                    '    pic_res = HoN_Restoration_Stone
                    '    Return pic_res
                    'Case "Ring of Basilius"
                    '    pic_res = HoN_Ring_Of_The_Teacher
                    '    Return pic_res
                    'Case "Ring of Health"
                    '    pic_res = HoN_Lifetube
                    '    Return pic_res
                    'Case "Ring of Protection"
                    '    pic_res = HoN_Guardian_Ring
                    '    Return pic_res
                    'Case "Ring of Regen"
                    '    pic_res = HoN_Trinket_Of_Restoration
                    '    Return pic_res
                    'Case "Robe of the Magi"
                    '    pic_res = HoN_Apprentices_Robe
                    '    Return pic_res
                    'Case "Sacred Relic"
                    '    pic_res = HoN_Sword_Of_The_High
                    '    Return pic_res
                    'Case "Sage's Mask"
                    '    pic_res = HoN_Scarab
                    '    Return pic_res
                    'Case "Sange"
                    '    pic_res = HoN_Icebrand
                    '    Return pic_res
                    'Case "Sange and Yasha"
                    '    pic_res = HoN_Frostburn
                    '    Return pic_res
                    'Case "Satanic"
                    '    pic_res = HoN_Symbol_Of_Rage
                    '    Return pic_res
                    'Case "Scythe of Vyse"
                    '    pic_res = HoN_Kuldras_Sheepstick
                    '    Return pic_res
                    'Case "Sentry Ward"
                    '    pic_res = HoN_Wards_of_Revelation
                    '    Return pic_res
                    'Case "Shadow Blade"
                    '    pic_res = HoN_Shroud_Of_The_Assasin
                    '    Return pic_res
                    'Case "Shiva's Guard"
                    '    pic_res = HoN_Frostfield_Plate
                    '    Return pic_res
                    'Case "Skull Basher"
                    '    pic_res = HoN_Brutalizer
                    '    Return pic_res
                    'Case "Slippers of Agility"
                    '    pic_res = HoN_Duck_Boots
                    '    Return pic_res
                    'Case "Smoke of Deceit"
                    '    pic_res = ImageList1.Images(116)
                    '    Return pic_res
                    'Case "Soul Booster"
                    '    pic_res = HoN_Icon_Of_The_Goddess
                    '    Return pic_res
                    'Case "Soul Ring"
                    '    pic_res = HoN_Blood_Chalice
                    '    Return pic_res
                    'Case "Staff of Wizardry"
                    '    pic_res = HoN_Neophytes_Book
                    '    Return pic_res
                    'Case "Stout Shield"
                    '    pic_res = HoN_Iron_Buckler
                    '    Return pic_res
                    'Case "Talisman of Evasion"
                    '    pic_res = HoN_Snake_Bracelet
                    '    Return pic_res
                    'Case "Tango"
                    '    pic_res = HoN_Runes_Of_The_Blight
                    '    Return pic_res
                    'Case "Town Portal Scroll"
                    '    pic_res = HoN_Homecoming_Stone
                    '    Return pic_res
                    'Case "Ultimate Orb"
                    '    pic_res = HoN_Blessed_Orb
                    '    Return pic_res
                    'Case "Urn of Shadows"
                    '    pic_res = ImageList1.Images(126)
                    '    Return pic_res
                    'Case "Vanguard"
                    '    pic_res = HoN_Helm_Of_The_Black_Legion
                    '    Return pic_res
                    'Case "Veil of Discord"
                    '    pic_res = ImageList1.Images(128)
                    '    Return pic_res
                    'Case "Vitality Booster"
                    '    pic_res = HoN_Beastheart
                    '    Return pic_res
                    'Case "Vladmir's Offering"
                    '    pic_res = HoN_Abyssal_Skull
                    '    Return pic_res
                    'Case "Void Stone"
                    '    pic_res = HoN_Manatube
                    '    Return pic_res
                    'Case "Wraith Band"
                    '    pic_res = HoN_Soulscream_Ring
                    '    Return pic_res
                    'Case "Yasha"
                    '    pic_res = HoN_Firebrand
                    '    Return pic_res
                    'Case "Abyssal Blade"
                    '    pic_res = ImageList1.Images(0)
                    '    Return pic_res
                    'Case "Heaven's Halberd"
                    '    pic_res = ImageList1.Images(56)
                    '    Return pic_res
                    'Case "Ring of Aquila"
                    '    pic_res = ImageList1.Images(98)
                    '    Return pic_res
                    'Case "Rod of Atos"
                    pic_res = ImageList1.Images(104)
                    '    Return pic_res
                    'Case "Tranquil Boots"
                    'pic_res = HoN_Striders
                    Return pic_res
                Case Else
                    pic_res = D2RIC.My.Resources.Resources.none
                    Return pic_res
            End Select
        Else
            Select Case item_name
                Case "Blink Dagger"
                    pic_res = ImageList1.Images(12)
                    Return pic_res
                Case "Blades of Attack"
                    pic_res = ImageList1.Images(11)
                    Return pic_res
                Case "Aghanim's Scepter"
                    pic_res = ImageList1.Images(1)
                    Return pic_res
                Case "Animal Courier"
                    pic_res = ImageList1.Images(2)
                    Return pic_res
                Case "Arcane Boots"
                    pic_res = ImageList1.Images(3)
                    Return pic_res
                Case "Armlet"
                    pic_res = ImageList1.Images(4)
                    Return pic_res
                Case "Assault Cuirass"
                    pic_res = ImageList1.Images(5)
                    Return pic_res
                Case "Battle Fury"
                    pic_res = ImageList1.Images(6)
                    Return pic_res
                Case "Belt of Strength"
                    pic_res = ImageList1.Images(8)
                    Return pic_res
                Case "Black King Bar"
                    pic_res = ImageList1.Images(7)
                    Return pic_res
                Case "Blade Mail"
                    pic_res = ImageList1.Images(9)
                    Return pic_res
                Case "Blade of Alacrity"
                    pic_res = ImageList1.Images(10)
                    Return pic_res
                Case "Bloodstone"
                    pic_res = ImageList1.Images(13)
                    Return pic_res
                Case "Boots of Elvenskin"
                    pic_res = ImageList1.Images(14)
                    Return pic_res
                Case "Boots of Speed"
                    pic_res = ImageList1.Images(15)
                    Return pic_res
                Case "Boots of Travel"
                    pic_res = ImageList1.Images(16)
                    Return pic_res
                Case "Bottle"
                    pic_res = ImageList1.Images(17)
                    Return pic_res
                Case "Bracer"
                    pic_res = ImageList1.Images(18)
                    Return pic_res
                Case "Broadsword"
                    pic_res = ImageList1.Images(19)
                    Return pic_res
                Case "Buckler"
                    pic_res = ImageList1.Images(20)
                    Return pic_res
                Case "Butterfly"
                    pic_res = ImageList1.Images(21)
                    Return pic_res
                Case "Chainmail"
                    pic_res = ImageList1.Images(22)
                    Return pic_res
                Case "Circlet"
                    pic_res = ImageList1.Images(23)
                    Return pic_res
                Case "Clarity"
                    pic_res = ImageList1.Images(24)
                    Return pic_res
                Case "Claymore"
                    pic_res = ImageList1.Images(25)
                    Return pic_res
                Case "Cloak"
                    pic_res = ImageList1.Images(26)
                    Return pic_res
                Case "Crystalys"
                    pic_res = ImageList1.Images(27)
                    Return pic_res
                Case "Daedalus"
                    pic_res = ImageList1.Images(28)
                    Return pic_res
                Case "Dagon 1"
                    pic_res = ImageList1.Images(29)
                    Return pic_res
                Case "Dagon 2"
                    pic_res = ImageList1.Images(30)
                    Return pic_res
                Case "Dagon 3"
                    pic_res = ImageList1.Images(31)
                    Return pic_res
                Case "Dagon 4"
                    pic_res = ImageList1.Images(32)
                    Return pic_res
                Case "Dagon 5"
                    pic_res = ImageList1.Images(33)
                    Return pic_res
                Case "Demon Edge"
                    pic_res = ImageList1.Images(34)
                    Return pic_res
                Case "Desolator"
                    pic_res = ImageList1.Images(35)
                    Return pic_res
                Case "Diffusal Blade 1"
                    pic_res = ImageList1.Images(36)
                    Return pic_res
                Case "Diffusal Blade 2"
                    pic_res = ImageList1.Images(37)
                    Return pic_res
                Case "Divine Rapier"
                    pic_res = ImageList1.Images(38)
                    Return pic_res
                Case "Drum of Endurance"
                    pic_res = ImageList1.Images(39)
                    Return pic_res
                Case "Dust of Appearance"
                    pic_res = ImageList1.Images(40)
                    Return pic_res
                    'Case "Eaglesong"
                    pic_res = ImageList1.Images(41)
                    Return pic_res
                Case "Energy Booster"
                    pic_res = ImageList1.Images(42)
                    Return pic_res
                Case "Ethereal Blade"
                    pic_res = ImageList1.Images(43)
                    Return pic_res
                Case "Eul's Scepter of Divinity"
                    pic_res = ImageList1.Images(44)
                    Return pic_res
                Case "Eye of Skadi"
                    pic_res = ImageList1.Images(45)
                    Return pic_res
                Case "Flying Courier"
                    pic_res = ImageList1.Images(46)
                    Return pic_res
                Case "Force Staff"
                    pic_res = ImageList1.Images(47)
                    Return pic_res
                Case "Gauntlets of Strength"
                    pic_res = ImageList1.Images(48)
                    Return pic_res
                Case "Gem of True Sight"
                    pic_res = ImageList1.Images(49)
                    Return pic_res
                Case "Ghost Scepter"
                    pic_res = ImageList1.Images(50)
                    Return pic_res
                Case "Gloves of Haste"
                    pic_res = ImageList1.Images(51)
                    Return pic_res
                Case "Hand of Midas"
                    pic_res = ImageList1.Images(52)
                    Return pic_res
                Case "Headdress"
                    pic_res = ImageList1.Images(53)
                    Return pic_res
                Case "Healing Salve"
                    pic_res = ImageList1.Images(54)
                    Return pic_res
                Case "Heart of Tarrasque"
                    pic_res = ImageList1.Images(55)
                    Return pic_res
                Case "Helm of Iron Will"
                    pic_res = ImageList1.Images(57)
                    Return pic_res
                Case "Helm of the Dominator"
                    pic_res = ImageList1.Images(58)
                    Return pic_res
                Case "Hood of Defiance"
                    pic_res = ImageList1.Images(59)
                    Return pic_res
                Case "Hyperstone"
                    pic_res = ImageList1.Images(60)
                    Return pic_res
                Case "Iron Branch"
                    pic_res = ImageList1.Images(61)
                    Return pic_res
                Case "Javelin"
                    pic_res = ImageList1.Images(62)
                    Return pic_res
                Case "Linken's Sphere"
                    pic_res = ImageList1.Images(63)
                    Return pic_res
                Case "Maelstrom"
                    pic_res = ImageList1.Images(64)
                    Return pic_res
                Case "Magic Stick"
                    pic_res = ImageList1.Images(65)
                    Return pic_res
                Case "Magic Wand"
                    pic_res = ImageList1.Images(66)
                    Return pic_res
                Case "Manta Style"
                    pic_res = ImageList1.Images(67)
                    Return pic_res
                Case "Mantle of Intelligence"
                    pic_res = ImageList1.Images(68)
                    Return pic_res
                Case "Mask of Madness"
                    pic_res = ImageList1.Images(69)
                    Return pic_res
                Case "Medallion of Courage"
                    pic_res = ImageList1.Images(70)
                    Return pic_res
                Case "Mekansm"
                    pic_res = ImageList1.Images(71)
                    Return pic_res
                Case "Mithril Hammer"
                    pic_res = ImageList1.Images(72)
                    Return pic_res
                Case "Mjollnir"
                    pic_res = ImageList1.Images(73)
                    Return pic_res
                Case "Monkey King Bar"
                    pic_res = ImageList1.Images(74)
                    Return pic_res
                Case "Morbid Mask"
                    pic_res = ImageList1.Images(75)
                    Return pic_res
                Case "Mystic Staff"
                    pic_res = ImageList1.Images(76)
                    Return pic_res
                Case "Necronomicon 1"
                    pic_res = ImageList1.Images(77)
                    Return pic_res
                Case "Necronomicon 2"
                    pic_res = ImageList1.Images(78)
                    Return pic_res
                Case "Necronomicon 3"
                    pic_res = ImageList1.Images(79)
                    Return pic_res
                Case "Null Talisman"
                    pic_res = ImageList1.Images(80)
                    Return pic_res
                Case "Oblivion Staff"
                    pic_res = ImageList1.Images(81)
                    Return pic_res
                Case "Observer Ward"
                    pic_res = ImageList1.Images(82)
                    Return pic_res
                Case "Ogre Club"
                    pic_res = ImageList1.Images(83)
                    Return pic_res
                Case "Orb of Venom"
                    pic_res = ImageList1.Images(84)
                    Return pic_res
                Case "Orchid Malevolence"
                    pic_res = ImageList1.Images(85)
                    Return pic_res
                Case "Perseverance"
                    pic_res = ImageList1.Images(86)
                    Return pic_res
                Case "Phase Boots"
                    pic_res = ImageList1.Images(87)
                    Return pic_res
                Case "Pipe of Insight"
                    pic_res = ImageList1.Images(88)
                    Return pic_res
                Case "Platemail"
                    pic_res = ImageList1.Images(89)
                    Return pic_res
                Case "Point Booster"
                    pic_res = ImageList1.Images(90)
                    Return pic_res
                Case "Poor Man's Shield"
                    pic_res = ImageList1.Images(91)
                    Return pic_res
                Case "Power Treads"
                    pic_res = ImageList1.Images(92)
                    Return pic_res
                Case "Quarterstaff"
                    pic_res = ImageList1.Images(93)
                    Return pic_res
                Case "Quelling Blade"
                    pic_res = ImageList1.Images(94)
                    Return pic_res
                Case "Radiance"
                    pic_res = ImageList1.Images(95)
                    Return pic_res
                Case "Reaver"
                    pic_res = ImageList1.Images(96)
                    Return pic_res
                Case "Refresher Orb"
                    pic_res = ImageList1.Images(97)
                    Return pic_res
                Case "Ring of Basilius"
                    pic_res = ImageList1.Images(99)
                    Return pic_res
                Case "Ring of Health"
                    pic_res = ImageList1.Images(100)
                    Return pic_res
                Case "Ring of Protection"
                    pic_res = ImageList1.Images(101)
                    Return pic_res
                Case "Ring of Regen"
                    pic_res = ImageList1.Images(102)
                    Return pic_res
                Case "Robe of the Magi"
                    pic_res = ImageList1.Images(103)
                    Return pic_res
                Case "Sacred Relic"
                    pic_res = ImageList1.Images(105)
                    Return pic_res
                Case "Sage's Mask"
                    pic_res = ImageList1.Images(106)
                    Return pic_res
                Case "Sange"
                    pic_res = ImageList1.Images(107)
                    Return pic_res
                Case "Sange and Yasha"
                    pic_res = ImageList1.Images(108)
                    Return pic_res
                Case "Satanic"
                    pic_res = ImageList1.Images(109)
                    Return pic_res
                Case "Scythe of Vyse"
                    pic_res = ImageList1.Images(110)
                    Return pic_res
                Case "Sentry Ward"
                    pic_res = ImageList1.Images(111)
                    Return pic_res
                Case "Shadow Blade"
                    pic_res = ImageList1.Images(112)
                    Return pic_res
                Case "Shiva's Guard"
                    pic_res = ImageList1.Images(113)
                    Return pic_res
                Case "Skull Basher"
                    pic_res = ImageList1.Images(114)
                    Return pic_res
                Case "Slippers of Agility"
                    pic_res = ImageList1.Images(115)
                    Return pic_res
                Case "Smoke of Deceit"
                    pic_res = ImageList1.Images(116)
                    Return pic_res
                Case "Soul Booster"
                    pic_res = ImageList1.Images(117)
                    Return pic_res
                Case "Soul Ring"
                    pic_res = ImageList1.Images(118)
                    Return pic_res
                Case "Staff of Wizardry"
                    pic_res = ImageList1.Images(119)
                    Return pic_res
                Case "Stout Shield"
                    pic_res = ImageList1.Images(120)
                    Return pic_res
                Case "Talisman of Evasion"
                    pic_res = ImageList1.Images(121)
                    Return pic_res
                Case "Tango"
                    pic_res = ImageList1.Images(122)
                    Return pic_res
                Case "Town Portal Scroll"
                    pic_res = ImageList1.Images(123)
                    Return pic_res
                Case "Ultimate Orb"
                    pic_res = ImageList1.Images(125)
                    Return pic_res
                Case "Urn of Shadows"
                    pic_res = ImageList1.Images(126)
                    Return pic_res
                Case "Vanguard"
                    pic_res = ImageList1.Images(127)
                    Return pic_res
                Case "Veil of Discord"
                    pic_res = ImageList1.Images(128)
                    Return pic_res
                Case "Vitality Booster"
                    pic_res = ImageList1.Images(129)
                    Return pic_res
                Case "Vladmir's Offering"
                    pic_res = ImageList1.Images(130)
                    Return pic_res
                Case "Void Stone"
                    pic_res = ImageList1.Images(131)
                    Return pic_res
                Case "Wraith Band"
                    pic_res = ImageList1.Images(132)
                    Return pic_res
                Case "Yasha"
                    pic_res = ImageList1.Images(133)
                    Return pic_res
                Case "Abyssal Blade"
                    pic_res = ImageList1.Images(0)
                    Return pic_res
                Case "Heaven's Halberd"
                    pic_res = ImageList1.Images(56)
                    Return pic_res
                Case "Ring of Aquila"
                    pic_res = ImageList1.Images(98)
                    Return pic_res
                Case "Rod of Atos"
                    pic_res = ImageList1.Images(104)
                    Return pic_res
                Case "Tranquil Boots"
                    pic_res = ImageList1.Images(124)
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
            If doImagesMatch(img_res, ImageList1.Images(146)) Then
                pic_res = "Blink Dagger"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(145)) Then
                pic_res = "Blades of Attack"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(135)) Then
                pic_res = "Aghanim's Scepter"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(136)) Then
                pic_res = "Animal Courier"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(137)) Then
                pic_res = "Arcane Boots"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(138)) Then
                pic_res = "Armlet"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(139)) Then
                pic_res = "Assault Cuirass"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(140)) Then
                pic_res = "Battle Fury"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(141)) Then
                pic_res = "Belt of Strength"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(142)) Then
                pic_res = "Black King Bar"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(143)) Then
                pic_res = "Blade Mail"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(144)) Then
                pic_res = "Blade of Alacrity"
                Return pic_res
                'ElseIf doImagesMatch(img_res, Bloodstone) Then
                '    pic_res = "Bloodstone"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Bootsofelvenskin) Then
                '    pic_res = "Boots of Elvenskin"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Bootsofspeed) Then
                '    pic_res = "Boots of Speed"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Bootsoftravel) Then
                '    pic_res = "Boots of Travel"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Bottle) Then
                '    pic_res = "Bottle"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Bracer) Then
                '    pic_res = "Bracer"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Broadsword) Then
                '    pic_res = "Broadsword"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Nathrezimbuckler) Then
                '    pic_res = "Buckler"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Butterfly) Then
                '    pic_res = "Butterfly"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Chainmail) Then
                '    pic_res = "Chainmail"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Circletofnobility) Then
                '    pic_res = "Circlet"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Claritypotion) Then
                '    pic_res = "Clarity"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Claymore) Then
                '    pic_res = "Claymore"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Planeswalkerscloak) Then
                '    pic_res = "Cloak"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Crystalys) Then
                '    pic_res = "Crystalys"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Burizadokyanon) Then
                '    pic_res = "Daedalus"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Dagon) Then
                '    pic_res = "Dagon 1"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Dagon2) Then
                '    pic_res = "Dagon 2"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Dagon3) Then
                '    pic_res = "Dagon 3"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Dagon4) Then
                '    pic_res = "Dagon 4"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Dagon5) Then
                '    pic_res = "Dagon 5"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Demonedge) Then
                '    pic_res = "Demon Edge"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Stygiandesolator) Then
                '    pic_res = "Desolator"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Diffusalblade) Then
                '    pic_res = "Diffusal Blade 1"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Diffusalblade2) Then
                '    pic_res = "Diffusal Blade 2"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Divinerapier) Then
                '    pic_res = "Divine Rapier"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Ancientjanggoofendurance) Then
                '    pic_res = "Drum of Endurance"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Dustofappearance) Then
                '    pic_res = "Dust of Appearance"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Eaglehorn) Then
                '    pic_res = "Eaglesong"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Energybooster) Then
                '    pic_res = "Energy Booster"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Etheral_Blade) Then
                '    pic_res = "Ethereal Blade"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Eulsscepterofdivinity) Then
                '    pic_res = "Eul's Scepter of Divinity"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Eyeofskadi) Then
                '    pic_res = "Eye of Skadi"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Flyingcourier) Then
                '    pic_res = "Flying Courier"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Forcestaff) Then
                '    pic_res = "Force Staff"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Gauntletsofstrength) Then
                '    pic_res = "Gauntlets of Strength"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Gemoftruesight) Then
                '    pic_res = "Gem of True Sight"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Ghostscepter) Then
                '    pic_res = "Ghost Scepter"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Glovesofhaste) Then
                '    pic_res = "Gloves of Haste"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Handofmidas) Then
                '    pic_res = "Hand of Midas"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Headdressofrejuvenation) Then
                '    pic_res = "Headdress"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Healingsalve) Then
                '    pic_res = "Healing Salve"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Heartoftarrasque) Then
                '    pic_res = "Heart of Tarrasque"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Helmofironwill) Then
                '    pic_res = "Helm of Iron Will"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Helmofthedominator) Then
                '    pic_res = "Helm of the Dominator"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Hoodofdefiance) Then
                '    pic_res = "Hood of Defiance"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Hyperstone) Then
                '    pic_res = "Hyperstone"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Ironwoodbranch) Then
                '    pic_res = "Iron Branch"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Javelin) Then
                '    pic_res = "Javelin"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Linkenssphere) Then
                '    pic_res = "Linken's Sphere"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Maelstrom) Then
                '    pic_res = "Maelstrom"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Magicstick) Then
                '    pic_res = "Magic Stick"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Magicwand) Then
                '    pic_res = "Magic Wand"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Mantastyle) Then
                '    pic_res = "Manta Style"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Mantleofintelligence) Then
                '    pic_res = "Mantle of Intelligence"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Maskofmadness) Then
                '    pic_res = "Mask of Madness"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Medallionofcourage) Then
                '    pic_res = "Medallion of Courage"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Mekansm) Then
                '    pic_res = "Mekansm"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Mithrilhammer) Then
                '    pic_res = "Mithril Hammer"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Mjollnir) Then
                '    pic_res = "Mjollnir"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Monkeykingbar) Then
                '    pic_res = "Monkey King Bar"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Maskofdeath) Then
                '    pic_res = "Morbid Mask"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Mysticstaff) Then
                '    pic_res = "Mystic Staff"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Necronomicon) Then
                '    pic_res = "Necronomicon 1"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Necronomicon2) Then
                '    pic_res = "Necronomicon 2"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Necronomicon3) Then
                '    pic_res = "Necronomicon 3"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Nulltalisman) Then
                '    pic_res = "Null Talisman"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Oblivionstaff) Then
                '    pic_res = "Oblivion Staff"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Observerwards) Then
                '    pic_res = "Observer Ward"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Ogreaxe) Then
                '    pic_res = "Ogre Club"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, OrbOfVenom) Then
                '    pic_res = "Orb of Venom"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Orchidmalevolence) Then
                '    pic_res = "Orchid Malevolence"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Perseverance) Then
                '    pic_res = "Perseverance"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Phaseboots) Then
                '    pic_res = "Phase Boots"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Khadgarspipeofinsight) Then
                '    pic_res = "Pipe of Insight"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Platemail) Then
                '    pic_res = "Platemail"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Pointbooster) Then
                '    pic_res = "Point Booster"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Poormansshield) Then
                '    pic_res = "Poor Man's Shield"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Powertreads) Then
                '    pic_res = "Power Treads"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Quarterstaff) Then
                '    pic_res = "Quarterstaff"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Quellingblade) Then
                '    pic_res = "Quelling Blade"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Radiance) Then
                '    pic_res = "Radiance"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Messerschmidtsreaver) Then
                '    pic_res = "Reaver"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Refresherorb) Then
                '    pic_res = "Refresher Orb"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Ringofbasilius) Then
                '    pic_res = "Ring of Basilius"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Ringofhealth) Then
                '    pic_res = "Ring of Health"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Ringofprotection) Then
                '    pic_res = "Ring of Protection"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Ringofregeneration) Then
                '    pic_res = "Ring of Regen"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Robeofthemagi) Then
                '    pic_res = "Robe of the Magi"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Sacredrelic) Then
                '    pic_res = "Sacred Relic"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Sobimask) Then
                '    pic_res = "Sage's Mask"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Sange) Then
                '    pic_res = "Sange"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Sangeandyasha) Then
                '    pic_res = "Sange and Yasha"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Satanic) Then
                '    pic_res = "Satanic"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Guinsoosscytheofvyse) Then
                '    pic_res = "Scythe of Vyse"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Sentrywards) Then
                '    pic_res = "Sentry Ward"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Lotharsedge) Then
                '    pic_res = "Shadow Blade"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Shivasguard) Then
                '    pic_res = "Shiva's Guard"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Craniumbasher) Then
                '    pic_res = "Skull Basher"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Slippersofagility) Then
                '    pic_res = "Slippers of Agility"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, SmokeOfDeceit) Then
                '    pic_res = "Smoke of Deceit"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Soulbooster) Then
                '    pic_res = "Soul Booster"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Soul_Ring) Then
                '    pic_res = "Soul Ring"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Staffofwizardry) Then
                '    pic_res = "Staff of Wizardry"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Stoutshield) Then
                '    pic_res = "Stout Shield"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Talismanofevasion) Then
                '    pic_res = "Talisman of Evasion"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, ImageList1.Images(122)) Then
                '    pic_res = "Tango"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Townportal) Then
                '    pic_res = "Town Portal Scroll"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Ultimateorb) Then
                '    pic_res = "Ultimate Orb"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Urnofshadows) Then
                '    pic_res = "Urn of Shadows"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Vanguard) Then
                '    pic_res = "Vanguard"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Fatalbonds) Then
                '    pic_res = "Veil of Discord"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Vitalitybooster) Then
                '    pic_res = "Vitality Booster"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Vladimirsoffering) Then
                '    pic_res = "Vladmir's Offering"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Voidstone) Then
                '    pic_res = "Void Stone"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Wraithband) Then
                '    pic_res = "Wraith Band"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Yasha) Then
                '    pic_res = "Yasha"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, AbyssalBlade) Then
                '    pic_res = "Abyssal Blade"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, Halberd) Then
                '    pic_res = "Heaven's Halberd"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, RingofAquila) Then
                '    pic_res = "Ring of Aquila"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, RodofAtos) Then
                '    pic_res = "Rod of Atos"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, TranquilBoots) Then
                pic_res = "Tranquil Boots"
                Return pic_res
            Else
                pic_res = "Error!"
                Return pic_res
            End If
        ElseIf ComboBoxItemIcons.Text = "HoN" Then
            If doImagesMatch(img_res, ImageList1.Images(1)) Then
                pic_res = "Blink Dagger"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Punchdagger) Then
                '    pic_res = "Blades of Attack"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Staff_Of_The_Master) Then
                '    pic_res = "Aghanim's Scepter"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Monkey_Courier) Then
                '    pic_res = "Animal Courier"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Ring_Of_Sorcery) Then
                '    pic_res = "Arcane Boots"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Insanitarius) Then
                '    pic_res = "Armlet"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Daemonic_Breastplate) Then
                '    pic_res = "Assault Cuirass"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Runed_Axe) Then
                '    pic_res = "Battle Fury"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Bolstering_Armband) Then
                '    pic_res = "Belt of Strength"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Shrunken_Head) Then
                '    pic_res = "Black King Bar"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Barbed_Armor) Then
                '    pic_res = "Blade Mail"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Quickblade) Then
                '    pic_res = "Blade of Alacrity"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Sacrificial_Stone) Then
                '    pic_res = "Bloodstone"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Fleet_Feet) Then
                '    pic_res = "Boots of Elvenskin"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Marchers) Then
                '    pic_res = "Boots of Speed"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Post_Haste) Then
                '    pic_res = "Boots of Travel"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Bottle) Then
                '    pic_res = "Bottle"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Fortified_Bracelet) Then
                '    pic_res = "Bracer"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Broadsword) Then
                '    pic_res = "Broadsword"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Shield_Of_The_Five) Then
                '    pic_res = "Buckler"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Wingbow) Then
                '    pic_res = "Butterfly"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Ringmail) Then
                '    pic_res = "Chainmail"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Pretenders_Crown) Then
                '    pic_res = "Circlet"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Mana_Potion) Then
                '    pic_res = "Clarity"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Bastard_Sword) Then
                '    pic_res = "Claymore"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Mystic_Vestments) Then
                '    pic_res = "Cloak"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Riftshards) Then
                '    pic_res = "Crystalys"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, ImageList1.Images(28)) Then
                '    pic_res = "Daedalus"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Codex) Then
                '    pic_res = "Dagon 1"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Codex2) Then
                '    pic_res = "Dagon 2"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Codex3) Then
                '    pic_res = "Dagon 3"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Codex4) Then
                '    pic_res = "Dagon 4"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Codex5) Then
                '    pic_res = "Dagon 5"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Slayer) Then
                '    pic_res = "Demon Edge"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Shieldbreaker) Then
                '    pic_res = "Desolator"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Nullfire_Blade) Then
                '    pic_res = "Diffusal Blade 1"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Nullfire_Blade2) Then
                '    pic_res = "Diffusal Blade 2"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Doombringer) Then
                '    pic_res = "Divine Rapier"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, ImageList1.Images(39)) Then
                '    pic_res = "Drum of Endurance"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Dust_Of_Revelation) Then
                '    pic_res = "Dust of Appearance"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Dancing_Blade) Then
                '    pic_res = "Eaglesong"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Pickled_Brain) Then
                '    pic_res = "Energy Booster"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, ImageList1.Images(43)) Then
                '    pic_res = "Ethereal Blade"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Stormspirit) Then
                '    pic_res = "Eul's Scepter of Divinity"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Frostwolfs_Skull) Then
                '    pic_res = "Eye of Skadi"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Winged_Courier) Then
                '    pic_res = "Flying Courier"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Tablet_of_Command) Then
                '    pic_res = "Force Staff"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Crushing_Claws) Then
                '    pic_res = "Gauntlets of Strength"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Bound_Eye) Then
                '    pic_res = "Gem of True Sight"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Void_Talisman) Then
                '    pic_res = "Ghost Scepter"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Gloves_of_the_Swift) Then
                '    pic_res = "Gloves of Haste"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Alchemist_Bones) Then
                '    pic_res = "Hand of Midas"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Refreshing_Ornament) Then
                '    pic_res = "Headdress"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Health_Potion) Then
                '    pic_res = "Healing Salve"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Behemoths_Hearth) Then
                '    pic_res = "Heart of Tarrasque"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Helm_Of_The_Victim) Then
                '    pic_res = "Helm of Iron Will"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Whispering_Helm) Then
                '    pic_res = "Helm of the Dominator"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Shamans_Headress) Then
                '    pic_res = "Hood of Defiance"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Warpcleft) Then
                '    pic_res = "Hyperstone"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Minor_Totem) Then
                '    pic_res = "Iron Branch"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Halberd) Then
                '    pic_res = "Javelin"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Null_Stone) Then
                '    pic_res = "Linken's Sphere"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Thunderclaw) Then
                '    pic_res = "Maelstrom"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Mana_Battery) Then
                '    pic_res = "Magic Stick"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Power_Supply) Then
                '    pic_res = "Magic Wand"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Geometers_Bane) Then
                '    pic_res = "Manta Style"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Mark_Of_The_Novice) Then
                '    pic_res = "Mantle of Intelligence"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Elder_Parasite) Then
                '    pic_res = "Mask of Madness"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, ImageList1.Images(70)) Then
                '    pic_res = "Medallion of Courage"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Astrolabe) Then
                '    pic_res = "Mekansm"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Warhammer) Then
                '    pic_res = "Mithril Hammer"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Charged_Hammer) Then
                '    pic_res = "Mjollnir"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Savage_Mace) Then
                '    pic_res = "Monkey King Bar"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Hungry_Spirit) Then
                '    pic_res = "Morbid Mask"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Acolytes_Staff) Then
                '    pic_res = "Mystic Staff"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Puzzlebox) Then
                '    pic_res = "Necronomicon 1"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Puzzlebox2) Then
                '    pic_res = "Necronomicon 2"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Puzzlebox3) Then
                '    pic_res = "Necronomicon 3"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Talisman_Of_Exile) Then
                '    pic_res = "Null Talisman"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Great_Arcana) Then
                '    pic_res = "Oblivion Staff"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Wards_of_Sight) Then
                '    pic_res = "Observer Ward"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Mighty_Blade) Then
                '    pic_res = "Ogre Club"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, ImageList1.Images(84)) Then
                '    pic_res = "Orb of Venom"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Hellflower) Then
                '    pic_res = "Orchid Malevolence"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Sustainer) Then
                '    pic_res = "Perseverance"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Enhanced_Marchers) Then
                '    pic_res = "Phase Boots"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Barrier_Idol) Then
                '    pic_res = "Pipe of Insight"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Platemail) Then
                '    pic_res = "Platemail"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Glowstone) Then
                '    pic_res = "Point Booster"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Iron_Shield) Then
                '    pic_res = "Poor Man's Shield"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Steamboots_Strength) Then
                '    pic_res = "Power Treads"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Steamstaff) Then
                '    pic_res = "Quarterstaff"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Loggers_Hatchet) Then
                '    pic_res = "Quelling Blade"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Mock_of_Brilliance) Then
                '    pic_res = "Radiance"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Axe_Of_The_Malphai) Then
                '    pic_res = "Reaver"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Restoration_Stone) Then
                '    pic_res = "Refresher Orb"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Ring_Of_The_Teacher) Then
                '    pic_res = "Ring of Basilius"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Lifetube) Then
                '    pic_res = "Ring of Health"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Guardian_Ring) Then
                '    pic_res = "Ring of Protection"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Trinket_Of_Restoration) Then
                '    pic_res = "Ring of Regen"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Apprentices_Robe) Then
                '    pic_res = "Robe of the Magi"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Sword_Of_The_High) Then
                '    pic_res = "Sacred Relic"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Scarab) Then
                '    pic_res = "Sage's Mask"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Icebrand) Then
                '    pic_res = "Sange"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Frostburn) Then
                '    pic_res = "Sange and Yasha"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Symbol_Of_Rage) Then
                '    pic_res = "Satanic"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Kuldras_Sheepstick) Then
                '    pic_res = "Scythe of Vyse"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Wards_of_Revelation) Then
                '    pic_res = "Sentry Ward"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Shroud_Of_The_Assasin) Then
                '    pic_res = "Shadow Blade"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Frostfield_Plate) Then
                '    pic_res = "Shiva's Guard"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Brutalizer) Then
                '    pic_res = "Skull Basher"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Duck_Boots) Then
                '    pic_res = "Slippers of Agility"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, ImageList1.Images(116)) Then
                '    pic_res = "Smoke of Deceit"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Icon_Of_The_Goddess) Then
                '    pic_res = "Soul Booster"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Blood_Chalice) Then
                '    pic_res = "Soul Ring"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Neophytes_Book) Then
                '    pic_res = "Staff of Wizardry"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Iron_Buckler) Then
                '    pic_res = "Stout Shield"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Snake_Bracelet) Then
                '    pic_res = "Talisman of Evasion"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Runes_Of_The_Blight) Then
                '    pic_res = "Tango"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Homecoming_Stone) Then
                '    pic_res = "Town Portal Scroll"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Blessed_Orb) Then
                '    pic_res = "Ultimate Orb"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, ImageList1.Images(126)) Then
                '    pic_res = "Urn of Shadows"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Helm_Of_The_Black_Legion) Then
                '    pic_res = "Vanguard"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, ImageList1.Images(128)) Then
                '    pic_res = "Veil of Discord"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Beastheart) Then
                '    pic_res = "Vitality Booster"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Abyssal_Skull) Then
                '    pic_res = "Vladmir's Offering"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Manatube) Then
                '    pic_res = "Void Stone"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Soulscream_Ring) Then
                '    pic_res = "Wraith Band"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Firebrand) Then
                '    pic_res = "Yasha"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, ImageList1.Images(0)) Then
                '    pic_res = "Abyssal Blade"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, ImageList1.Images(56)) Then
                '    pic_res = "Heaven's Halberd"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, ImageList1.Images(98)) Then
                '    pic_res = "Ring of Aquila"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, ImageList1.Images(104)) Then
                '    pic_res = "Rod of Atos"
                '    Return pic_res
                'ElseIf doImagesMatch(img_res, HoN_Striders) Then
                '    pic_res = "Tranquil Boots"
                Return pic_res
            Else
                pic_res = "Error!"
                Return pic_res
            End If
        Else
            If doImagesMatch(img_res, ImageList1.Images(12)) Then
                pic_res = "Blink Dagger"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(11)) Then
                pic_res = "Blades of Attack"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(1)) Then
                pic_res = "Aghanim's Scepter"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(2)) Then
                pic_res = "Animal Courier"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(3)) Then
                pic_res = "Arcane Boots"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(4)) Then
                pic_res = "Armlet"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(5)) Then
                pic_res = "Assault Cuirass"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(6)) Then
                pic_res = "Battle Fury"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(7)) Then
                pic_res = "Belt of Strength"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(8)) Then
                pic_res = "Black King Bar"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(9)) Then
                pic_res = "Blade Mail"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(10)) Then
                pic_res = "Blade of Alacrity"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(13)) Then
                pic_res = "Bloodstone"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(14)) Then
                pic_res = "Boots of Elvenskin"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(15)) Then
                pic_res = "Boots of Speed"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(16)) Then
                pic_res = "Boots of Travel"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(17)) Then
                pic_res = "Bottle"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(18)) Then
                pic_res = "Bracer"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(19)) Then
                pic_res = "Broadsword"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(20)) Then
                pic_res = "Buckler"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(21)) Then
                pic_res = "Butterfly"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(22)) Then
                pic_res = "Chainmail"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(23)) Then
                pic_res = "Circlet"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(24)) Then
                pic_res = "Clarity"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(25)) Then
                pic_res = "Claymore"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(26)) Then
                pic_res = "Cloak"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(27)) Then
                pic_res = "Crystalys"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(28)) Then
                pic_res = "Daedalus"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(29)) Then
                pic_res = "Dagon 1"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(30)) Then
                pic_res = "Dagon 2"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(31)) Then
                pic_res = "Dagon 3"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(32)) Then
                pic_res = "Dagon 4"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(33)) Then
                pic_res = "Dagon 5"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(34)) Then
                pic_res = "Demon Edge"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(35)) Then
                pic_res = "Desolator"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(36)) Then
                pic_res = "Diffusal Blade 1"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(37)) Then
                pic_res = "Diffusal Blade 2"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(38)) Then
                pic_res = "Divine Rapier"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(39)) Then
                pic_res = "Drum of Endurance"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(40)) Then
                pic_res = "Dust of Appearance"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(41)) Then
                pic_res = "Eaglesong"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(42)) Then
                pic_res = "Energy Booster"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(43)) Then
                pic_res = "Ethereal Blade"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(44)) Then
                pic_res = "Eul's Scepter of Divinity"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(45)) Then
                pic_res = "Eye of Skadi"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(46)) Then
                pic_res = "Flying Courier"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(47)) Then
                pic_res = "Force Staff"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(48)) Then
                pic_res = "Gauntlets of Strength"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(49)) Then
                pic_res = "Gem of True Sight"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(50)) Then
                pic_res = "Ghost Scepter"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(51)) Then
                pic_res = "Gloves of Haste"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(52)) Then
                pic_res = "Hand of Midas"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(53)) Then
                pic_res = "Headdress"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(54)) Then
                pic_res = "Healing Salve"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(55)) Then
                pic_res = "Heart of Tarrasque"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(57)) Then
                pic_res = "Helm of Iron Will"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(58)) Then
                pic_res = "Helm of the Dominator"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(59)) Then
                pic_res = "Hood of Defiance"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(60)) Then
                pic_res = "Hyperstone"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(61)) Then
                pic_res = "Iron Branch"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(62)) Then
                pic_res = "Javelin"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(63)) Then
                pic_res = "Linken's Sphere"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(64)) Then
                pic_res = "Maelstrom"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(65)) Then
                pic_res = "Magic Stick"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(66)) Then
                pic_res = "Magic Wand"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(67)) Then
                pic_res = "Manta Style"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(68)) Then
                pic_res = "Mantle of Intelligence"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(69)) Then
                pic_res = "Mask of Madness"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(70)) Then
                pic_res = "Medallion of Courage"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(71)) Then
                pic_res = "Mekansm"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(72)) Then
                pic_res = "Mithril Hammer"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(73)) Then
                pic_res = "Mjollnir"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(74)) Then
                pic_res = "Monkey King Bar"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(75)) Then
                pic_res = "Morbid Mask"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(76)) Then
                pic_res = "Mystic Staff"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(77)) Then
                pic_res = "Necronomicon 1"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(78)) Then
                pic_res = "Necronomicon 2"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(79)) Then
                pic_res = "Necronomicon 3"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(80)) Then
                pic_res = "Null Talisman"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(81)) Then
                pic_res = "Oblivion Staff"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(82)) Then
                pic_res = "Observer Ward"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(83)) Then
                pic_res = "Ogre Club"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(84)) Then
                pic_res = "Orb of Venom"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(85)) Then
                pic_res = "Orchid Malevolence"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(86)) Then
                pic_res = "Perseverance"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(87)) Then
                pic_res = "Phase Boots"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(88)) Then
                pic_res = "Pipe of Insight"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(89)) Then
                pic_res = "Platemail"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(90)) Then
                pic_res = "Point Booster"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(91)) Then
                pic_res = "Poor Man's Shield"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(92)) Then
                pic_res = "Power Treads"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(93)) Then
                pic_res = "Quarterstaff"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(94)) Then
                pic_res = "Quelling Blade"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(95)) Then
                pic_res = "Radiance"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(96)) Then
                pic_res = "Reaver"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(97)) Then
                pic_res = "Refresher Orb"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(99)) Then
                pic_res = "Ring of Basilius"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(100)) Then
                pic_res = "Ring of Health"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(101)) Then
                pic_res = "Ring of Protection"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(102)) Then
                pic_res = "Ring of Regen"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(103)) Then
                pic_res = "Robe of the Magi"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(105)) Then
                pic_res = "Sacred Relic"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(106)) Then
                pic_res = "Sage's Mask"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(107)) Then
                pic_res = "Sange"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(108)) Then
                pic_res = "Sange and Yasha"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(109)) Then
                pic_res = "Satanic"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(110)) Then
                pic_res = "Scythe of Vyse"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(111)) Then
                pic_res = "Sentry Ward"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(112)) Then
                pic_res = "Shadow Blade"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(113)) Then
                pic_res = "Shiva's Guard"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(114)) Then
                pic_res = "Skull Basher"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(115)) Then
                pic_res = "Slippers of Agility"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(116)) Then
                pic_res = "Smoke of Deceit"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(117)) Then
                pic_res = "Soul Booster"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(118)) Then
                pic_res = "Soul Ring"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(119)) Then
                pic_res = "Staff of Wizardry"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(120)) Then
                pic_res = "Stout Shield"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(121)) Then
                pic_res = "Talisman of Evasion"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(122)) Then
                pic_res = "Tango"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(123)) Then
                pic_res = "Town Portal Scroll"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(125)) Then
                pic_res = "Ultimate Orb"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(126)) Then
                pic_res = "Urn of Shadows"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(127)) Then
                pic_res = "Vanguard"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(128)) Then
                pic_res = "Veil of Discord"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(129)) Then
                pic_res = "Vitality Booster"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(130)) Then
                pic_res = "Vladmir's Offering"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(131)) Then
                pic_res = "Void Stone"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(132)) Then
                pic_res = "Wraith Band"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(133)) Then
                pic_res = "Yasha"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(0)) Then
                pic_res = "Abyssal Blade"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(56)) Then
                pic_res = "Heaven's Halberd"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(98)) Then
                pic_res = "Ring of Aquila"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(104)) Then
                pic_res = "Rod of Atos"
                Return pic_res
            ElseIf doImagesMatch(img_res, ImageList1.Images(124)) Then
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
        IntPrice = (CInt(Label15.Text) - Itembuild.GetPrice(PicRes2Name(Item1.Image)))
        Label15.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item1.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item1, Itembuild.GetToolTip(PicRes2Name(Item1.Image)))
        IntPrice = (CInt(Label15.Text) + Itembuild.GetPrice(PicRes2Name(Item1.Image)))
        Label15.Text = IntPrice.ToString
    End Sub

    Private Sub Item2_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item2.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item2_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item2.DragDrop
        IntPrice = (CInt(Label15.Text) - Itembuild.GetPrice(PicRes2Name(Item2.Image)))
        Label15.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item2.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item2, Itembuild.GetToolTip(PicRes2Name(Item2.Image)))
        IntPrice = (CInt(Label15.Text) + Itembuild.GetPrice(PicRes2Name(Item2.Image)))
        Label15.Text = IntPrice.ToString
    End Sub

    Private Sub Item3_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item3.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item3_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item3.DragDrop
        IntPrice = (CInt(Label15.Text) - Itembuild.GetPrice(PicRes2Name(Item3.Image)))
        Label15.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item3.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item3, Itembuild.GetToolTip(PicRes2Name(Item3.Image)))
        IntPrice = (CInt(Label15.Text) + Itembuild.GetPrice(PicRes2Name(Item3.Image)))
        Label15.Text = IntPrice.ToString
    End Sub

    Private Sub Item4_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item4.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item4_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item4.DragDrop
        IntPrice = (CInt(Label15.Text) - Itembuild.GetPrice(PicRes2Name(Item4.Image)))
        Label15.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item4.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item4, Itembuild.GetToolTip(PicRes2Name(Item4.Image)))
        IntPrice = (CInt(Label15.Text) + Itembuild.GetPrice(PicRes2Name(Item4.Image)))
        Label15.Text = IntPrice.ToString
    End Sub

    Private Sub Item5_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item5.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item5_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item5.DragDrop
        IntPrice = (CInt(Label15.Text) - Itembuild.GetPrice(PicRes2Name(Item5.Image)))
        Label15.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item5.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item5, Itembuild.GetToolTip(PicRes2Name(Item5.Image)))
        IntPrice = (CInt(Label15.Text) + Itembuild.GetPrice(PicRes2Name(Item5.Image)))
        Label15.Text = IntPrice.ToString
    End Sub

    Private Sub Item6_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item6.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item6_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item6.DragDrop
        IntPrice = (CInt(Label15.Text) - Itembuild.GetPrice(PicRes2Name(Item6.Image)))
        Label15.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item6.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item6, Itembuild.GetToolTip(PicRes2Name(Item6.Image)))
        IntPrice = (CInt(Label15.Text) + Itembuild.GetPrice(PicRes2Name(Item6.Image)))
        Label15.Text = IntPrice.ToString
    End Sub

    Private Sub Item7_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item7.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item7_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item7.DragDrop
        IntPrice = (CInt(Label15.Text) - Itembuild.GetPrice(PicRes2Name(Item7.Image)))
        Label15.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item7.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item7, Itembuild.GetToolTip(PicRes2Name(Item7.Image)))
        IntPrice = (CInt(Label15.Text) + Itembuild.GetPrice(PicRes2Name(Item7.Image)))
        Label15.Text = IntPrice.ToString
    End Sub

    Private Sub Item8_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item8.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item8_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item8.DragDrop
        IntPrice = (CInt(Label15.Text) - Itembuild.GetPrice(PicRes2Name(Item8.Image)))
        Label15.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item8.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item8, Itembuild.GetToolTip(PicRes2Name(Item8.Image)))
        IntPrice = (CInt(Label15.Text) + Itembuild.GetPrice(PicRes2Name(Item8.Image)))
        Label15.Text = IntPrice.ToString
    End Sub

    Private Sub Item9_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item9.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item9_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item9.DragDrop
        IntPrice = (CInt(Label15.Text) - Itembuild.GetPrice(PicRes2Name(Item9.Image)))
        Label15.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item9.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item9, Itembuild.GetToolTip(PicRes2Name(Item9.Image)))
        IntPrice = (CInt(Label15.Text) + Itembuild.GetPrice(PicRes2Name(Item9.Image)))
        Label15.Text = IntPrice.ToString
    End Sub

    Private Sub Item10_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item10.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item10_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item10.DragDrop
        IntPrice = (CInt(Label16.Text) - Itembuild.GetPrice(PicRes2Name(Item10.Image)))
        Label16.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item10.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item10, Itembuild.GetToolTip(PicRes2Name(Item10.Image)))
        IntPrice = (CInt(Label16.Text) + Itembuild.GetPrice(PicRes2Name(Item10.Image)))
        Label16.Text = IntPrice.ToString
    End Sub

    Private Sub Item11_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item11.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item11_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item11.DragDrop
        IntPrice = (CInt(Label16.Text) - Itembuild.GetPrice(PicRes2Name(Item11.Image)))
        Label16.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item11.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item11, Itembuild.GetToolTip(PicRes2Name(Item11.Image)))
        IntPrice = (CInt(Label16.Text) + Itembuild.GetPrice(PicRes2Name(Item11.Image)))
        Label16.Text = IntPrice.ToString
    End Sub

    Private Sub Item12_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item12.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item12_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item12.DragDrop
        IntPrice = (CInt(Label16.Text) - Itembuild.GetPrice(PicRes2Name(Item12.Image)))
        Label16.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item12.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item12, Itembuild.GetToolTip(PicRes2Name(Item12.Image)))
        IntPrice = (CInt(Label16.Text) + Itembuild.GetPrice(PicRes2Name(Item12.Image)))
        Label16.Text = IntPrice.ToString
    End Sub

    Private Sub Item13_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item13.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item13_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item13.DragDrop
        IntPrice = (CInt(Label16.Text) - Itembuild.GetPrice(PicRes2Name(Item13.Image)))
        Label16.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item13.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item13, Itembuild.GetToolTip(PicRes2Name(Item13.Image)))
        IntPrice = (CInt(Label16.Text) + Itembuild.GetPrice(PicRes2Name(Item13.Image)))
        Label16.Text = IntPrice.ToString
    End Sub

    Private Sub Item14_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item14.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item14_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item14.DragDrop
        IntPrice = (CInt(Label16.Text) - Itembuild.GetPrice(PicRes2Name(Item14.Image)))
        Label16.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item14.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item14, Itembuild.GetToolTip(PicRes2Name(Item14.Image)))
        IntPrice = (CInt(Label16.Text) + Itembuild.GetPrice(PicRes2Name(Item14.Image)))
        Label16.Text = IntPrice.ToString
    End Sub

    Private Sub Item15_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item15.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item15_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item15.DragDrop
        IntPrice = (CInt(Label16.Text) - Itembuild.GetPrice(PicRes2Name(Item15.Image)))
        Label16.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item15.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item15, Itembuild.GetToolTip(PicRes2Name(Item15.Image)))
        IntPrice = (CInt(Label16.Text) + Itembuild.GetPrice(PicRes2Name(Item15.Image)))
        Label16.Text = IntPrice.ToString
    End Sub

    Private Sub Item16_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item16.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item16_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item16.DragDrop
        IntPrice = (CInt(Label16.Text) - Itembuild.GetPrice(PicRes2Name(Item16.Image)))
        Label16.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item16.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item16, Itembuild.GetToolTip(PicRes2Name(Item16.Image)))
        IntPrice = (CInt(Label16.Text) + Itembuild.GetPrice(PicRes2Name(Item16.Image)))
        Label16.Text = IntPrice.ToString
    End Sub

    Private Sub Item17_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item17.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item17_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item17.DragDrop
        IntPrice = (CInt(Label16.Text) - Itembuild.GetPrice(PicRes2Name(Item17.Image)))
        Label16.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item17.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item17, Itembuild.GetToolTip(PicRes2Name(Item17.Image)))
        IntPrice = (CInt(Label16.Text) + Itembuild.GetPrice(PicRes2Name(Item17.Image)))
        Label16.Text = IntPrice.ToString
    End Sub

    Private Sub Item18_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item18.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item18_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item18.DragDrop
        IntPrice = (CInt(Label16.Text) - Itembuild.GetPrice(PicRes2Name(Item18.Image)))
        Label16.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item18.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item18, Itembuild.GetToolTip(PicRes2Name(Item18.Image)))
        IntPrice = (CInt(Label16.Text) + Itembuild.GetPrice(PicRes2Name(Item18.Image)))
        Label16.Text = IntPrice.ToString
    End Sub

    Private Sub Item19_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item19.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item19_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item19.DragDrop
        IntPrice = (CInt(Label18.Text) - Itembuild.GetPrice(PicRes2Name(Item19.Image)))
        Label18.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item19.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item19, Itembuild.GetToolTip(PicRes2Name(Item19.Image)))
        IntPrice = (CInt(Label18.Text) + Itembuild.GetPrice(PicRes2Name(Item19.Image)))
        Label18.Text = IntPrice.ToString
    End Sub

    Private Sub Item20_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item20.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item20_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item20.DragDrop
        IntPrice = (CInt(Label18.Text) - Itembuild.GetPrice(PicRes2Name(Item20.Image)))
        Label18.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item20.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item20, Itembuild.GetToolTip(PicRes2Name(Item20.Image)))
        IntPrice = (CInt(Label18.Text) + Itembuild.GetPrice(PicRes2Name(Item20.Image)))
        Label18.Text = IntPrice.ToString
    End Sub

    Private Sub Item21_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item21.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item21_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item21.DragDrop
        IntPrice = (CInt(Label18.Text) - Itembuild.GetPrice(PicRes2Name(Item21.Image)))
        Label18.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item21.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item21, Itembuild.GetToolTip(PicRes2Name(Item21.Image)))
        IntPrice = (CInt(Label18.Text) + Itembuild.GetPrice(PicRes2Name(Item21.Image)))
        Label18.Text = IntPrice.ToString
    End Sub

    Private Sub Item22_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item22.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item22_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item22.DragDrop
        IntPrice = (CInt(Label18.Text) - Itembuild.GetPrice(PicRes2Name(Item22.Image)))
        Label18.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item22.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item22, Itembuild.GetToolTip(PicRes2Name(Item22.Image)))
        IntPrice = (CInt(Label18.Text) + Itembuild.GetPrice(PicRes2Name(Item22.Image)))
        Label18.Text = IntPrice.ToString
    End Sub

    Private Sub Item23_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item23.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item23_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item23.DragDrop
        IntPrice = (CInt(Label18.Text) - Itembuild.GetPrice(PicRes2Name(Item23.Image)))
        Label18.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item23.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item23, Itembuild.GetToolTip(PicRes2Name(Item23.Image)))
        IntPrice = (CInt(Label18.Text) + Itembuild.GetPrice(PicRes2Name(Item23.Image)))
        Label18.Text = IntPrice.ToString
    End Sub

    Private Sub Item24_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item24.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item24_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item24.DragDrop
        IntPrice = (CInt(Label18.Text) - Itembuild.GetPrice(PicRes2Name(Item24.Image)))
        Label18.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item24.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item24, Itembuild.GetToolTip(PicRes2Name(Item24.Image)))
        IntPrice = (CInt(Label18.Text) + Itembuild.GetPrice(PicRes2Name(Item24.Image)))
        Label18.Text = IntPrice.ToString
    End Sub

    Private Sub Item25_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item25.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item25_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item25.DragDrop
        IntPrice = (CInt(Label18.Text) - Itembuild.GetPrice(PicRes2Name(Item25.Image)))
        Label18.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item25.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item25, Itembuild.GetToolTip(PicRes2Name(Item25.Image)))
        IntPrice = (CInt(Label18.Text) + Itembuild.GetPrice(PicRes2Name(Item25.Image)))
        Label18.Text = IntPrice.ToString
    End Sub

    Private Sub Item26_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item26.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item26_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item26.DragDrop
        IntPrice = (CInt(Label18.Text) - Itembuild.GetPrice(PicRes2Name(Item26.Image)))
        Label18.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item26.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item26, Itembuild.GetToolTip(PicRes2Name(Item26.Image)))
        IntPrice = (CInt(Label18.Text) + Itembuild.GetPrice(PicRes2Name(Item26.Image)))
        Label18.Text = IntPrice.ToString
    End Sub

    Private Sub Item27_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item27.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item27_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item27.DragDrop
        IntPrice = (CInt(Label18.Text) - Itembuild.GetPrice(PicRes2Name(Item27.Image)))
        Label18.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item27.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item27, Itembuild.GetToolTip(PicRes2Name(Item27.Image)))
        IntPrice = (CInt(Label18.Text) + Itembuild.GetPrice(PicRes2Name(Item27.Image)))
        Label18.Text = IntPrice.ToString
    End Sub

    Private Sub Item28_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item28.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item28_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item28.DragDrop
        IntPrice = (CInt(Label20.Text) - Itembuild.GetPrice(PicRes2Name(Item28.Image)))
        Label20.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item28.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item28, Itembuild.GetToolTip(PicRes2Name(Item28.Image)))
        IntPrice = (CInt(Label20.Text) + Itembuild.GetPrice(PicRes2Name(Item28.Image)))
        Label20.Text = IntPrice.ToString
    End Sub

    Private Sub Item29_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item29.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item29_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item29.DragDrop
        IntPrice = (CInt(Label20.Text) - Itembuild.GetPrice(PicRes2Name(Item29.Image)))
        Label20.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item29.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item29, Itembuild.GetToolTip(PicRes2Name(Item29.Image)))
        IntPrice = (CInt(Label20.Text) + Itembuild.GetPrice(PicRes2Name(Item29.Image)))
        Label20.Text = IntPrice.ToString
    End Sub

    Private Sub Item30_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item30.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item30_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item30.DragDrop
        IntPrice = (CInt(Label20.Text) - Itembuild.GetPrice(PicRes2Name(Item30.Image)))
        Label20.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item30.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item30, Itembuild.GetToolTip(PicRes2Name(Item30.Image)))
        IntPrice = (CInt(Label20.Text) + Itembuild.GetPrice(PicRes2Name(Item30.Image)))
        Label20.Text = IntPrice.ToString
    End Sub

    Private Sub Item31_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item31.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item31_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item31.DragDrop
        IntPrice = (CInt(Label20.Text) - Itembuild.GetPrice(PicRes2Name(Item31.Image)))
        Label20.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item31.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item31, Itembuild.GetToolTip(PicRes2Name(Item31.Image)))
        IntPrice = (CInt(Label20.Text) + Itembuild.GetPrice(PicRes2Name(Item31.Image)))
        Label20.Text = IntPrice.ToString
    End Sub

    Private Sub Item32_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item32.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item32_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item32.DragDrop
        IntPrice = (CInt(Label20.Text) - Itembuild.GetPrice(PicRes2Name(Item32.Image)))
        Label20.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item32.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item32, Itembuild.GetToolTip(PicRes2Name(Item32.Image)))
        IntPrice = (CInt(Label20.Text) + Itembuild.GetPrice(PicRes2Name(Item32.Image)))
        Label20.Text = IntPrice.ToString
    End Sub

    Private Sub Item33_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item33.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item33_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item33.DragDrop
        IntPrice = (CInt(Label20.Text) - Itembuild.GetPrice(PicRes2Name(Item33.Image)))
        Label20.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item33.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item33, Itembuild.GetToolTip(PicRes2Name(Item33.Image)))
        IntPrice = (CInt(Label20.Text) + Itembuild.GetPrice(PicRes2Name(Item33.Image)))
        Label20.Text = IntPrice.ToString
    End Sub

    Private Sub Item34_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item34.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item34_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item34.DragDrop
        IntPrice = (CInt(Label20.Text) - Itembuild.GetPrice(PicRes2Name(Item34.Image)))
        Label20.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item34.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item34, Itembuild.GetToolTip(PicRes2Name(Item34.Image)))
        IntPrice = (CInt(Label20.Text) + Itembuild.GetPrice(PicRes2Name(Item34.Image)))
        Label20.Text = IntPrice.ToString
    End Sub

    Private Sub Item35_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item35.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item35_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item35.DragDrop
        IntPrice = (CInt(Label20.Text) - Itembuild.GetPrice(PicRes2Name(Item35.Image)))
        Label20.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item35.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item35, Itembuild.GetToolTip(PicRes2Name(Item35.Image)))
        IntPrice = (CInt(Label20.Text) + Itembuild.GetPrice(PicRes2Name(Item35.Image)))
        Label20.Text = IntPrice.ToString
    End Sub

    Private Sub Item36_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item36.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item36_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item36.DragDrop
        IntPrice = (CInt(Label20.Text) - Itembuild.GetPrice(PicRes2Name(Item36.Image)))
        Label20.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item36.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item36, Itembuild.GetToolTip(PicRes2Name(Item36.Image)))
        IntPrice = (CInt(Label20.Text) + Itembuild.GetPrice(PicRes2Name(Item36.Image)))
        Label20.Text = IntPrice.ToString
    End Sub

    Private Sub Item37_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item37.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item37_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item37.DragDrop
        IntPrice = (CInt(Label20.Text) - Itembuild.GetPrice(PicRes2Name(Item37.Image)))
        Label20.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item37.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item37, Itembuild.GetToolTip(PicRes2Name(Item37.Image)))
        IntPrice = (CInt(Label20.Text) + Itembuild.GetPrice(PicRes2Name(Item37.Image)))
        Label20.Text = IntPrice.ToString
    End Sub

    Private Sub Item38_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item38.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item38_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item38.DragDrop
        IntPrice = (CInt(Label20.Text) - Itembuild.GetPrice(PicRes2Name(Item38.Image)))
        Label20.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item38.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item38, Itembuild.GetToolTip(PicRes2Name(Item38.Image)))
        IntPrice = (CInt(Label20.Text) + Itembuild.GetPrice(PicRes2Name(Item38.Image)))
        Label20.Text = IntPrice.ToString
    End Sub

    Private Sub Item39_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item39.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Item39_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Item39.DragDrop
        IntPrice = (CInt(Label20.Text) - Itembuild.GetPrice(PicRes2Name(Item39.Image)))
        Label20.Text = IntPrice.ToString
        ' Assign the image to the PictureBox. 
        Item39.Image = e.Data.GetData(DataFormats.Bitmap)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        ToolTip1.SetToolTip(Item39, Itembuild.GetToolTip(PicRes2Name(Item39.Image)))
        IntPrice = (CInt(Label20.Text) + Itembuild.GetPrice(PicRes2Name(Item39.Image)))
        Label20.Text = IntPrice.ToString
    End Sub

    ' RIGHTCLICK DELTE
    Private Sub Item1_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item1.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label15.Text) - Itembuild.GetPrice(PicRes2Name(Item1.Image)))
            If IntPrice >= 0 Then
                Label15.Text = IntPrice.ToString
            Else
                Label15.Text = "0"
            End If
            Item1.Image = My.Resources.none
            ToolTip1.SetToolTip(Item1, "none")
        End If
    End Sub

    Private Sub Item2_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item2.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label15.Text) - Itembuild.GetPrice(PicRes2Name(Item2.Image)))
            If IntPrice >= 0 Then
                Label15.Text = IntPrice.ToString
            Else
                Label15.Text = "0"
            End If
            Item2.Image = My.Resources.none
            ToolTip1.SetToolTip(Item2, "none")
        End If
    End Sub

    Private Sub Item3_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item3.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label15.Text) - Itembuild.GetPrice(PicRes2Name(Item3.Image)))
            If IntPrice >= 0 Then
                Label15.Text = IntPrice.ToString
            Else
                Label15.Text = "0"
            End If
            Item3.Image = My.Resources.none
            ToolTip1.SetToolTip(Item3, "none")
        End If
    End Sub

    Private Sub Item4_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item4.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label15.Text) - Itembuild.GetPrice(PicRes2Name(Item4.Image)))
            If IntPrice >= 0 Then
                Label15.Text = IntPrice.ToString
            Else
                Label15.Text = "0"
            End If
            Item4.Image = My.Resources.none
            ToolTip1.SetToolTip(Item4, "none")
        End If
    End Sub

    Private Sub Item5_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item5.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label15.Text) - Itembuild.GetPrice(PicRes2Name(Item5.Image)))
            If IntPrice >= 0 Then
                Label15.Text = IntPrice.ToString
            Else
                Label15.Text = "0"
            End If
            Item5.Image = My.Resources.none
            ToolTip1.SetToolTip(Item5, "none")
        End If
    End Sub

    Private Sub Item6_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item6.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label15.Text) - Itembuild.GetPrice(PicRes2Name(Item6.Image)))
            If IntPrice >= 0 Then
                Label15.Text = IntPrice.ToString
            Else
                Label15.Text = "0"
            End If
            Item6.Image = My.Resources.none
            ToolTip1.SetToolTip(Item6, "none")
        End If
    End Sub

    Private Sub Item7_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item7.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label15.Text) - Itembuild.GetPrice(PicRes2Name(Item7.Image)))
            If IntPrice >= 0 Then
                Label15.Text = IntPrice.ToString
            Else
                Label15.Text = "0"
            End If
            Item7.Image = My.Resources.none
            ToolTip1.SetToolTip(Item7, "none")
        End If
    End Sub

    Private Sub Item8_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item8.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label15.Text) - Itembuild.GetPrice(PicRes2Name(Item8.Image)))
            If IntPrice >= 0 Then
                Label15.Text = IntPrice.ToString
            Else
                Label15.Text = "0"
            End If
            Item8.Image = My.Resources.none
            ToolTip1.SetToolTip(Item8, "none")
        End If
    End Sub

    Private Sub Item9_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item9.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label15.Text) - Itembuild.GetPrice(PicRes2Name(Item9.Image)))
            If IntPrice >= 0 Then
                Label15.Text = IntPrice.ToString
            Else
                Label15.Text = "0"
            End If
            Item9.Image = My.Resources.none
            ToolTip1.SetToolTip(Item9, "none")
        End If
    End Sub

    Private Sub Item10_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item10.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label16.Text) - Itembuild.GetPrice(PicRes2Name(Item10.Image)))
            If IntPrice >= 0 Then
                Label16.Text = IntPrice.ToString
            Else
                Label16.Text = "0"
            End If
            Item10.Image = My.Resources.none
            ToolTip1.SetToolTip(Item10, "none")
        End If
    End Sub

    Private Sub Item11_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item11.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label16.Text) - Itembuild.GetPrice(PicRes2Name(Item11.Image)))
            If IntPrice >= 0 Then
                Label16.Text = IntPrice.ToString
            Else
                Label16.Text = "0"
            End If
            Item11.Image = My.Resources.none
            ToolTip1.SetToolTip(Item11, "none")
        End If
    End Sub

    Private Sub Item12_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item12.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label16.Text) - Itembuild.GetPrice(PicRes2Name(Item12.Image)))
            If IntPrice >= 0 Then
                Label16.Text = IntPrice.ToString
            Else
                Label16.Text = "0"
            End If
            Item12.Image = My.Resources.none
            ToolTip1.SetToolTip(Item12, "none")
        End If
    End Sub

    Private Sub Item13_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item13.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label16.Text) - Itembuild.GetPrice(PicRes2Name(Item13.Image)))
            If IntPrice >= 0 Then
                Label16.Text = IntPrice.ToString
            Else
                Label16.Text = "0"
            End If
            Item13.Image = My.Resources.none
            ToolTip1.SetToolTip(Item13, "none")
        End If
    End Sub

    Private Sub Item14_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item14.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label16.Text) - Itembuild.GetPrice(PicRes2Name(Item14.Image)))
            If IntPrice >= 0 Then
                Label16.Text = IntPrice.ToString
            Else
                Label16.Text = "0"
            End If
            Item14.Image = My.Resources.none
            ToolTip1.SetToolTip(Item14, "none")
        End If
    End Sub

    Private Sub Item15_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item15.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label16.Text) - Itembuild.GetPrice(PicRes2Name(Item15.Image)))
            If IntPrice >= 0 Then
                Label16.Text = IntPrice.ToString
            Else
                Label16.Text = "0"
            End If
            Item15.Image = My.Resources.none
            ToolTip1.SetToolTip(Item15, "none")
        End If
    End Sub

    Private Sub Item16_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item16.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label16.Text) - Itembuild.GetPrice(PicRes2Name(Item16.Image)))
            If IntPrice >= 0 Then
                Label16.Text = IntPrice.ToString
            Else
                Label16.Text = "0"
            End If
            Item16.Image = My.Resources.none
            ToolTip1.SetToolTip(Item16, "none")
        End If
    End Sub

    Private Sub Item17_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item17.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label16.Text) - Itembuild.GetPrice(PicRes2Name(Item17.Image)))
            If IntPrice >= 0 Then
                Label16.Text = IntPrice.ToString
            Else
                Label16.Text = "0"
            End If
            Item17.Image = My.Resources.none
            ToolTip1.SetToolTip(Item17, "none")
        End If
    End Sub

    Private Sub Item18_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item18.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label16.Text) - Itembuild.GetPrice(PicRes2Name(Item18.Image)))
            If IntPrice >= 0 Then
                Label16.Text = IntPrice.ToString
            Else
                Label16.Text = "0"
            End If
            Item18.Image = My.Resources.none
            ToolTip1.SetToolTip(Item18, "none")
        End If
    End Sub

    Private Sub Item19_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item19.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label18.Text) - Itembuild.GetPrice(PicRes2Name(Item19.Image)))
            If IntPrice >= 0 Then
                Label18.Text = IntPrice.ToString
            Else
                Label18.Text = "0"
            End If
            Item19.Image = My.Resources.none
            ToolTip1.SetToolTip(Item19, "none")
        End If
    End Sub

    Private Sub Item20_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item20.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label18.Text) - Itembuild.GetPrice(PicRes2Name(Item20.Image)))
            If IntPrice >= 0 Then
                Label18.Text = IntPrice.ToString
            Else
                Label18.Text = "0"
            End If
            Item20.Image = My.Resources.none
            ToolTip1.SetToolTip(Item20, "none")
        End If
    End Sub

    Private Sub Item21_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item21.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label18.Text) - Itembuild.GetPrice(PicRes2Name(Item21.Image)))
            If IntPrice >= 0 Then
                Label18.Text = IntPrice.ToString
            Else
                Label18.Text = "0"
            End If
            Item21.Image = My.Resources.none
            ToolTip1.SetToolTip(Item21, "none")
        End If
    End Sub

    Private Sub Item22_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item22.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label18.Text) - Itembuild.GetPrice(PicRes2Name(Item22.Image)))
            If IntPrice >= 0 Then
                Label18.Text = IntPrice.ToString
            Else
                Label18.Text = "0"
            End If
            Item22.Image = My.Resources.none
            ToolTip1.SetToolTip(Item22, "none")
        End If
    End Sub

    Private Sub Item23_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item23.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label18.Text) - Itembuild.GetPrice(PicRes2Name(Item23.Image)))
            If IntPrice >= 0 Then
                Label18.Text = IntPrice.ToString
            Else
                Label18.Text = "0"
            End If
            Item23.Image = My.Resources.none
            ToolTip1.SetToolTip(Item23, "none")
        End If
    End Sub

    Private Sub Item24_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item24.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label18.Text) - Itembuild.GetPrice(PicRes2Name(Item24.Image)))
            If IntPrice >= 0 Then
                Label18.Text = IntPrice.ToString
            Else
                Label18.Text = "0"
            End If
            Item24.Image = My.Resources.none
            ToolTip1.SetToolTip(Item24, "none")
        End If
    End Sub

    Private Sub Item25_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item25.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label18.Text) - Itembuild.GetPrice(PicRes2Name(Item25.Image)))
            If IntPrice >= 0 Then
                Label18.Text = IntPrice.ToString
            Else
                Label18.Text = "0"
            End If
            Item25.Image = My.Resources.none
            ToolTip1.SetToolTip(Item25, "none")
        End If
    End Sub

    Private Sub Item26_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item26.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label18.Text) - Itembuild.GetPrice(PicRes2Name(Item26.Image)))
            If IntPrice >= 0 Then
                Label18.Text = IntPrice.ToString
            Else
                Label18.Text = "0"
            End If
            Item26.Image = My.Resources.none
            ToolTip1.SetToolTip(Item26, "none")
        End If
    End Sub

    Private Sub Item27_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item27.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label18.Text) - Itembuild.GetPrice(PicRes2Name(Item27.Image)))
            If IntPrice >= 0 Then
                Label18.Text = IntPrice.ToString
            Else
                Label18.Text = "0"
            End If
            Item27.Image = My.Resources.none
            ToolTip1.SetToolTip(Item27, "none")
        End If
    End Sub

    Private Sub Item28_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item28.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label20.Text) - Itembuild.GetPrice(PicRes2Name(Item28.Image)))
            If IntPrice >= 0 Then
                Label20.Text = IntPrice.ToString
            Else
                Label20.Text = "0"
            End If
            Item28.Image = My.Resources.none
            ToolTip1.SetToolTip(Item28, "none")
        End If
    End Sub

    Private Sub Item29_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item29.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label20.Text) - Itembuild.GetPrice(PicRes2Name(Item29.Image)))
            If IntPrice >= 0 Then
                Label20.Text = IntPrice.ToString
            Else
                Label20.Text = "0"
            End If
            Item29.Image = My.Resources.none
            ToolTip1.SetToolTip(Item29, "none")
        End If
    End Sub

    Private Sub Item30_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item30.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label20.Text) - Itembuild.GetPrice(PicRes2Name(Item30.Image)))
            If IntPrice >= 0 Then
                Label20.Text = IntPrice.ToString
            Else
                Label20.Text = "0"
            End If
            Item30.Image = My.Resources.none
            ToolTip1.SetToolTip(Item30, "none")
        End If
    End Sub

    Private Sub Item31_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item31.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label20.Text) - Itembuild.GetPrice(PicRes2Name(Item31.Image)))
            If IntPrice >= 0 Then
                Label20.Text = IntPrice.ToString
            Else
                Label20.Text = "0"
            End If
            Item31.Image = My.Resources.none
            ToolTip1.SetToolTip(Item31, "none")
        End If
    End Sub

    Private Sub Item32_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item32.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label20.Text) - Itembuild.GetPrice(PicRes2Name(Item32.Image)))
            If IntPrice >= 0 Then
                Label20.Text = IntPrice.ToString
            Else
                Label20.Text = "0"
            End If
            Item32.Image = My.Resources.none
            ToolTip1.SetToolTip(Item32, "none")
        End If
    End Sub

    Private Sub Item33_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item33.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label20.Text) - Itembuild.GetPrice(PicRes2Name(Item33.Image)))
            If IntPrice >= 0 Then
                Label20.Text = IntPrice.ToString
            Else
                Label20.Text = "0"
            End If
            Item33.Image = My.Resources.none
            ToolTip1.SetToolTip(Item33, "none")
        End If
    End Sub

    Private Sub Item34_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item34.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label20.Text) - Itembuild.GetPrice(PicRes2Name(Item34.Image)))
            If IntPrice >= 0 Then
                Label20.Text = IntPrice.ToString
            Else
                Label20.Text = "0"
            End If
            Item34.Image = My.Resources.none
            ToolTip1.SetToolTip(Item34, "none")
        End If
    End Sub

    Private Sub Item35_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item35.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label20.Text) - Itembuild.GetPrice(PicRes2Name(Item35.Image)))
            If IntPrice >= 0 Then
                Label20.Text = IntPrice.ToString
            Else
                Label20.Text = "0"
            End If
            Item35.Image = My.Resources.none
            ToolTip1.SetToolTip(Item35, "none")
        End If
    End Sub

    Private Sub Item36_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item36.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label20.Text) - Itembuild.GetPrice(PicRes2Name(Item36.Image)))
            If IntPrice >= 0 Then
                Label20.Text = IntPrice.ToString
            Else
                Label20.Text = "0"
            End If
            Item36.Image = My.Resources.none
            ToolTip1.SetToolTip(Item36, "none")
        End If
    End Sub

    Private Sub Item37_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item37.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label20.Text) - Itembuild.GetPrice(PicRes2Name(Item37.Image)))
            If IntPrice >= 0 Then
                Label20.Text = IntPrice.ToString
            Else
                Label20.Text = "0"
            End If
            Item37.Image = My.Resources.none
            ToolTip1.SetToolTip(Item37, "none")
        End If
    End Sub

    Private Sub Item38_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item38.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label20.Text) - Itembuild.GetPrice(PicRes2Name(Item38.Image)))
            If IntPrice >= 0 Then
                Label20.Text = IntPrice.ToString
            Else
                Label20.Text = "0"
            End If
            Item38.Image = My.Resources.none
            ToolTip1.SetToolTip(Item38, "none")
        End If
    End Sub

    Private Sub Item39_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Item39.MouseDown
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label20.Text) - Itembuild.GetPrice(PicRes2Name(Item39.Image)))
            If IntPrice >= 0 Then
                Label20.Text = IntPrice.ToString
            Else
                Label20.Text = "0"
            End If
            Item39.Image = My.Resources.none
            ToolTip1.SetToolTip(Item39, "none")
        End If
    End Sub

End Class