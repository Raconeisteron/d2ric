Imports System.Security.Cryptography

Public Class Form2
    Dim Selected_Hero, NeuerText As String
    Private m_MouseIsDown As Boolean

    Private Sub DragAndDropTest_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub

    Private Sub DragAndDropTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.AllowDrop = True
        PictureBox2.AllowDrop = True
        PictureBox3.AllowDrop = True
        PictureBox4.AllowDrop = True
        PictureBox5.AllowDrop = True
        PictureBox6.AllowDrop = True
        PictureBox7.AllowDrop = True
        PictureBox8.AllowDrop = True
        PictureBox9.AllowDrop = True
        PictureBox10.AllowDrop = True
        PictureBox11.AllowDrop = True
        PictureBox12.AllowDrop = True
        PictureBox13.AllowDrop = True
        PictureBox14.AllowDrop = True
        PictureBox15.AllowDrop = True
        PictureBox16.AllowDrop = True
        PictureBox17.AllowDrop = True
        PictureBox18.AllowDrop = True
        PictureBox19.AllowDrop = True
        PictureBox20.AllowDrop = True
        PictureBox21.AllowDrop = True
        PictureBox22.AllowDrop = True
        PictureBox23.AllowDrop = True
        PictureBox24.AllowDrop = True
        PictureBox25.AllowDrop = True
        PictureBox26.AllowDrop = True
        PictureBox27.AllowDrop = True
        PictureBox28.AllowDrop = True
        PictureBox29.AllowDrop = True
        PictureBox30.AllowDrop = True
        Button3.Enabled = False
        Button4.Enabled = False
        With ToolTip1
            .SetToolTip(PictureBox31, "Aghanim's Scepter")
            .SetToolTip(PictureBox32, "Animal Courier")
            .SetToolTip(PictureBox33, "Arcane Boots")
            .SetToolTip(PictureBox34, "Armlet")
            .SetToolTip(PictureBox35, "Assault Cuirass")
            .SetToolTip(PictureBox36, "Battle Fury")
            .SetToolTip(PictureBox37, "Belt of Strength")
            .SetToolTip(PictureBox38, "Black King Bar")
            .SetToolTip(PictureBox39, "Blade Mail")
            .SetToolTip(PictureBox40, "Blade of Alacrity")
            .SetToolTip(PictureBox41, "Blades of Attack")
            .SetToolTip(PictureBox42, "Blink Dagger")
            .SetToolTip(PictureBox43, "Bloodstone")
            .SetToolTip(PictureBox44, "Boots of Elvenskin")
            .SetToolTip(PictureBox45, "Boots of Speed")
            .SetToolTip(PictureBox46, "Boots of Travel")
            .SetToolTip(PictureBox47, "Bottle")
            .SetToolTip(PictureBox48, "Bracer")
            .SetToolTip(PictureBox49, "Broadsword")
            .SetToolTip(PictureBox50, "Buckler")
            .SetToolTip(PictureBox51, "Butterfly")
            .SetToolTip(PictureBox52, "Chainmail")
            .SetToolTip(PictureBox53, "Circlet")
            .SetToolTip(PictureBox54, "Clarity")
            .SetToolTip(PictureBox55, "Claymore")
            .SetToolTip(PictureBox56, "Cloak")
            .SetToolTip(PictureBox57, "Crystalys")
            .SetToolTip(PictureBox58, "Daedalus")
            .SetToolTip(PictureBox59, "Dagon 1")
            .SetToolTip(PictureBox60, "Dagon 2")
            .SetToolTip(PictureBox61, "Dagon 3")
            .SetToolTip(PictureBox62, "Dagon 4")
            .SetToolTip(PictureBox63, "Dagon 5")
            .SetToolTip(PictureBox64, "Demon Edge")
            .SetToolTip(PictureBox65, "Desolator")
            .SetToolTip(PictureBox66, "Diffusal Blade 1")
            .SetToolTip(PictureBox67, "Diffusal Blade 2")
            .SetToolTip(PictureBox68, "Divine Rapier")
            .SetToolTip(PictureBox69, "Drum of Endurance")
            .SetToolTip(PictureBox70, "Dust of Appearance")
            .SetToolTip(PictureBox71, "Eaglesong")
            .SetToolTip(PictureBox72, "Energy Booster")
            .SetToolTip(PictureBox73, "Ethereal Blade")
            .SetToolTip(PictureBox74, "Eul's Scepter of Divinity")
            .SetToolTip(PictureBox75, "Eye of Skadi")
            .SetToolTip(PictureBox76, "Flying Courier")
            .SetToolTip(PictureBox77, "Force Staff")
            .SetToolTip(PictureBox78, "Gauntlets of Strength")
            .SetToolTip(PictureBox79, "Gem of True Sight")
            .SetToolTip(PictureBox80, "Ghost Scepter")
            .SetToolTip(PictureBox81, "Gloves of Haste")
            .SetToolTip(PictureBox82, "Hand of Midas")
            .SetToolTip(PictureBox83, "Headdress")
            .SetToolTip(PictureBox84, "Healing Salve")
            .SetToolTip(PictureBox85, "Heart of Tarrasque")
            .SetToolTip(PictureBox86, "Helm of Iron Will")
            .SetToolTip(PictureBox87, "Helm of the Dominator")
            .SetToolTip(PictureBox88, "Hood of Defiance")
            .SetToolTip(PictureBox89, "Hyperstone")
            .SetToolTip(PictureBox90, "Iron Branch")
            .SetToolTip(PictureBox91, "Javelin")
            .SetToolTip(PictureBox92, "Linken's Sphere")
            .SetToolTip(PictureBox93, "Maelstrom")
            .SetToolTip(PictureBox94, "Magic Stick")
            .SetToolTip(PictureBox95, "Magic Wand")
            .SetToolTip(PictureBox96, "Manta Style")
            .SetToolTip(PictureBox97, "Mantle of Intelligence")
            .SetToolTip(PictureBox98, "Mask of Madness")
            .SetToolTip(PictureBox99, "Medallion of Courage")
            .SetToolTip(PictureBox100, "Mekansm")
            .SetToolTip(PictureBox101, "Mithril Hammer")
            .SetToolTip(PictureBox102, "Mjollnir")
            .SetToolTip(PictureBox103, "Monkey King Bar")
            .SetToolTip(PictureBox104, "Morbid Mask")
            .SetToolTip(PictureBox105, "Mystic Staff")
            .SetToolTip(PictureBox121, "Necronomicon 1")
            .SetToolTip(PictureBox106, "Necronomicon 2")
            .SetToolTip(PictureBox107, "Necronomicon 3")
            .SetToolTip(PictureBox108, "Null Talisman")
            .SetToolTip(PictureBox109, "Oblivion Staff")
            .SetToolTip(PictureBox110, "Observer Ward")
            .SetToolTip(PictureBox111, "Ogre Club")
            .SetToolTip(PictureBox112, "Orb of Venom")
            .SetToolTip(PictureBox113, "Orchid Malevolence")
            .SetToolTip(PictureBox114, "Perseverance")
            .SetToolTip(PictureBox115, "Phase Boots")
            .SetToolTip(PictureBox116, "Pipe of Insight")
            .SetToolTip(PictureBox117, "Platemail")
            .SetToolTip(PictureBox118, "Point Booster")
            .SetToolTip(PictureBox119, "Poor Man's Shield")
            .SetToolTip(PictureBox120, "Power Treads")
            .SetToolTip(PictureBox122, "Quarterstaff")
            .SetToolTip(PictureBox123, "Quelling Blade")
            .SetToolTip(PictureBox124, "Radiance")
            .SetToolTip(PictureBox125, "Reaver")
            .SetToolTip(PictureBox126, "Refresher Orb")
            .SetToolTip(PictureBox127, "Ring of Basilius")
            .SetToolTip(PictureBox128, "Ring of Health")
            .SetToolTip(PictureBox129, "Ring of Protection")
            .SetToolTip(PictureBox130, "Ring of Regen")
            .SetToolTip(PictureBox131, "Robe of the Magi")
            .SetToolTip(PictureBox132, "Sacred Relic")
            .SetToolTip(PictureBox133, "Sage's Mask")
            .SetToolTip(PictureBox134, "Sange")
            .SetToolTip(PictureBox135, "Sange and Yasha")
            .SetToolTip(PictureBox136, "Satanic")
            .SetToolTip(PictureBox137, "Scythe of Vyse")
            .SetToolTip(PictureBox138, "Sentry Ward")
            .SetToolTip(PictureBox139, "Shadow Blade")
            .SetToolTip(PictureBox140, "Shiva's Guard")
            .SetToolTip(PictureBox141, "Skull Basher")
            .SetToolTip(PictureBox142, "Slippers of Agility")
            .SetToolTip(PictureBox143, "Smoke of Deceit")
            .SetToolTip(PictureBox144, "Soul Booster")
            .SetToolTip(PictureBox145, "Soul Ring")
            .SetToolTip(PictureBox146, "Staff of Wizardry")
            .SetToolTip(PictureBox147, "Stout Shield")
            .SetToolTip(PictureBox148, "Talisman of Evasion")
            .SetToolTip(PictureBox149, "Tango")
            .SetToolTip(PictureBox150, "Town Portal Scroll")
            .SetToolTip(PictureBox151, "Ultimate Orb")
            .SetToolTip(PictureBox152, "Urn of Shadows")
            .SetToolTip(PictureBox153, "Vanguard")
            .SetToolTip(PictureBox154, "Veil of Discord")
            .SetToolTip(PictureBox155, "Vitality Booster")
            .SetToolTip(PictureBox156, "Vladmir's Offering")
            .SetToolTip(PictureBox157, "Void Stone")
            .SetToolTip(PictureBox158, "Wraith Band")
            .SetToolTip(PictureBox159, "Yasha")
        End With

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        System.Diagnostics.Process.Start("explorer", My.Settings.path)
    End Sub

    Public Sub Clear()
        TextBox1.Text = ""
        Label1.Text = ""
        NeuerText = ""
        Dim pb As Object
        Dim picbox As Integer = 1
        For picbox = 1 To 30
            pb = Me.Controls.Item("PictureBox" & picbox)
            pb.image = D2RIC.My.Resources.Resources.none
        Next
    End Sub

    Private Sub CheckFile(ByVal hero As String)
        If IO.File.Exists(My.Settings.path + "\default_" + hero + ".txt") Then
            Dim DeinPfad As String = My.Settings.path + "\default_" + hero + ".txt"
            Dim ItemPlace As String = "Starting Items"
            Dim i As Integer = 1
            Dim pb As Object
            For Each Zeile As String In IO.File.ReadAllLines(DeinPfad)
                If Zeile.Contains("item_") And i < 31 Then
                    pb = Me.Controls.Item("PictureBox" & i)
                    pb.image = ChangePicture(RenameItem(Zeile))
                    i = i + 1
                ElseIf Zeile.Contains("Early_Game") Then
                    ItemPlace = "Early Game"
                    i = 7
                    NeuerText &= Zeile & vbNewLine
                ElseIf Zeile.Contains("Core_Items") Then
                    ItemPlace = "Core Items"
                    i = 13
                    NeuerText &= Zeile & vbNewLine
                ElseIf Zeile.Contains("Luxury") Then
                    ItemPlace = "Luxury"
                    i = 19
                    NeuerText &= Zeile & vbNewLine
                ElseIf Zeile.Contains("author") Then
                    TextBox1.Text = Replace(Zeile, """", "")
                    TextBox1.Text = Replace(TextBox1.Text, "author", "")
                    TextBox1.Text = Replace(TextBox1.Text, vbTab, "")
                    NeuerText &= Zeile & vbNewLine
                Else
                    NeuerText &= Zeile & vbNewLine
                End If
            Next
            Button1.Enabled = True
            Button3.Enabled = True
        Else
            Clear()
            Button1.Enabled = False
            Button3.Enabled = False
            MsgBox("Error! Hero maybe not implemented yet.")
        End If
    End Sub

    Private Sub ChangeAuthor(ByVal author As String, ByVal hero As String)
        IO.File.WriteAllText(My.Settings.path + "\temp.txt", NeuerText)
        If IO.File.Exists(My.Settings.path + "\temp.txt") Then
            NeuerText = ""
            Dim DeinPfad As String = My.Settings.path + "\temp.txt"
            Dim i As Integer = 1
            For Each Zeile As String In IO.File.ReadAllLines(DeinPfad)
                If Zeile.Contains("author") Then
                    NeuerText &= vbTab & """author""" & vbTab & vbTab & """" & author & """" & vbNewLine
                ElseIf Zeile.Contains("hero") Then
                    NeuerText &= vbTab & """hero""" & vbTab & vbTab & vbTab & """npc_dota_hero_" & hero & """" & vbNewLine
                Else
                    NeuerText &= Zeile & vbNewLine
                End If
            Next
            IO.File.Delete(My.Settings.path + "\temp.txt")
        Else

        End If
    End Sub

    Private Sub SaveChanges()
        IO.File.WriteAllText(My.Settings.path + "\temp.txt", NeuerText)
        If IO.File.Exists(My.Settings.path + "\temp.txt") Then
            NeuerText = ""
            Dim DeinPfad As String = My.Settings.path + "\temp.txt"
            Dim i As Integer = 1
            For Each Zeile As String In IO.File.ReadAllLines(DeinPfad)
                If Zeile.Contains("DOTA_Item_Build_Starting_Items") Then
                    NeuerText &= Zeile & vbNewLine
                    Exit For
                Else
                    NeuerText &= Zeile & vbNewLine
                End If
            Next
            IO.File.Delete(My.Settings.path + "\temp.txt")

            Dim StartingItems As String = ""
            Dim Earlygame As String = ""
            Dim CoreItems As String = ""
            Dim Luxury As String = ""
            Dim a As Integer = 1
            Dim pb As Object

            For a = 1 To 30
                pb = Me.Controls.Item("PictureBox" & a)
                If a < 7 And Not doImagesMatch(pb.Image, D2RIC.My.Resources.Resources.none) Then
                    StartingItems &= vbNewLine & vbTab & vbTab & vbTab & """Item""" & vbTab & vbTab & CheckItem(pb.Image)
                ElseIf 6 < a And a < 13 And Not doImagesMatch(pb.Image, D2RIC.My.Resources.Resources.none) Then
                    Earlygame &= vbNewLine & vbTab & vbTab & vbTab & """Item""" & vbTab & vbTab & CheckItem(pb.Image)
                ElseIf 12 < a And a < 19 And Not doImagesMatch(pb.Image, D2RIC.My.Resources.Resources.none) Then
                    CoreItems &= vbNewLine & vbTab & vbTab & vbTab & """Item""" & vbTab & vbTab & CheckItem(pb.Image)
                ElseIf 18 < a And Not doImagesMatch(pb.Image, D2RIC.My.Resources.Resources.none) Then
                    Luxury &= vbNewLine & vbTab & vbTab & vbTab & """Item""" & vbTab & vbTab & CheckItem(pb.Image)
                Else
                    'nichts
                End If
            Next

            NeuerText &= vbTab & vbTab & "{"
            ' Start Items hinzufügen
            NeuerText &= StartingItems & vbNewLine
            NeuerText &= vbTab & vbTab & "}" & vbNewLine & vbNewLine
            NeuerText &= vbTab & vbTab & """#DOTA_Item_Build_Early_Game""" & vbNewLine & vbTab & vbTab & "{"
            ' Early Items hinzufügen
            NeuerText &= vbTab & vbTab & Earlygame & vbNewLine
            NeuerText &= vbTab & vbTab & "}" & vbNewLine & vbNewLine
            NeuerText &= vbTab & vbTab & """#DOTA_Item_Build_Core_Items""" & vbNewLine & vbTab & vbTab & "{"
            ' Core Items hinzufügen
            NeuerText &= vbTab & vbTab & CoreItems & vbNewLine
            NeuerText &= vbTab & vbTab & "}" & vbNewLine & vbNewLine
            NeuerText &= vbTab & vbTab & """#DOTA_Item_Build_Luxury""" & vbNewLine & vbTab & vbTab & "{"
            ' Luxury Items hinzufügen
            NeuerText &= vbTab & vbTab & Luxury & vbNewLine
            NeuerText &= vbTab & vbTab & "}" & vbNewLine & vbTab & "}" & vbNewLine & "}"

        Else
            MsgBox("Error!")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (Selected_Hero <> "") Then
            SaveChanges()
            ChangeAuthor(TextBox1.Text, Selected_Hero)
            'MsgBox(NeuerText)
            IO.File.WriteAllText(My.Settings.path + "\default_" + Selected_Hero + ".txt", NeuerText)
        Else
            MsgBox("Please choose a hero first.")
        End If
    End Sub

    Public Function CheckItem(ByVal item_name As System.Drawing.Image) As String
        Dim new_item_name As String
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
        Else
            new_item_name = ""
            Return new_item_name
        End If
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
            Case Else
                rename_item_name = "Error!"
                Return rename_item_name
        End Select
    End Function

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If (Selected_Hero <> "") Then
            SaveChanges()
            ChangeAuthor(TextBox1.Text, Selected_Hero)
            My.Settings.clipboard = NeuerText
            Form3.Show()
        Else
            MsgBox("Please choose a hero first.")
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Form4.Show()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Form5.Show()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        If Not IO.Directory.Exists(My.Settings.path & "\Backup") Then
            ' Nein! Jetzt erstellen...
            Try
                IO.Directory.CreateDirectory(My.Settings.path & "\Backup")
                ' Ordner wurde korrekt erstellt!
            Catch ex As Exception
                ' Ordner wurde nich erstellt
                MsgBox("Error while creating folder")
            End Try
        End If
        If IO.Directory.Exists(My.Settings.path & "\Backup") Then
            For Each file As String In IO.Directory.GetFiles(My.Settings.path) ' Ermittelt alle Dateien des Ordners
                IO.File.Copy(file, My.Settings.path & "\Backup\" & System.DateTime.Now.Year.ToString & "-" & System.DateTime.Now.Month.ToString & "-" & System.DateTime.Now.Day.ToString & "_" & cut_file(file), True)  ' Kopiert die Dateien
            Next
        End If
    End Sub

    Private Function cut_file(ByVal file As String) As String ' Funktion zum Entfernen der Backslashs / Ordner
        While file.Contains("\")
            file = file.Remove(0, 1)
        End While
        Return file
    End Function

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        If MessageBox.Show("Delete backups?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If IO.Directory.Exists(My.Settings.path & "\Backup") Then
                For Each file As String In IO.Directory.GetFiles(My.Settings.path & "\Backup") ' Ermittelt alle Dateien des Ordners
                    IO.File.Delete(file)  ' Löscht die Dateien
                Next
            End If
        Else
            'code wenn man auf nein drückt
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case ListBox1.SelectedItem.ToString
            Case "Anti-Mage"
                Selected_Hero = "antimage"
            Case "Ancient Apparition"
                Selected_Hero = "ancient_apparition"
            Case "Crystal Maiden"
                Selected_Hero = "crystal_maiden"
            Case "Dark Seer"
                Selected_Hero = "dark_seer"
            Case "Doom Bringer"
                Selected_Hero = "doom_bringer"
            Case "Dragon Knight"
                Selected_Hero = "dragon_knight"
            Case "Drow Ranger"
                Selected_Hero = "drow_ranger"
            Case "Faceless Void"
                Selected_Hero = "faceless_void"
            Case "Nature's Prophet"
                Selected_Hero = "furion"
            Case "Clockwerk"
                Selected_Hero = "rattletrap"
            Case "Night Stalker"
                Selected_Hero = "night_stalker"
            Case "Queen of Pain"
                Selected_Hero = "queenofpain"
            Case "Shadow Fiend"
                Selected_Hero = "nevermore"
            Case "Shadow Shaman"
                Selected_Hero = "shadow_shaman"
            Case "Skeleton King"
                Selected_Hero = "skeleton_king"
            Case "Sand King"
                Selected_Hero = "sand_king"
            Case "Storm Spirit"
                Selected_Hero = "storm_spirit"
            Case "Vengeful Spirit"
                Selected_Hero = "vengefulspirit"
            Case "Witch Doctor"
                Selected_Hero = "witch_doctor"
            Case "Zeus"
                Selected_Hero = "zuus"
            Case "Lifestealer"
                Selected_Hero = "life_stealer"
            Case "Mortred"
                Selected_Hero = "phantom_assassin"
                ' FEHLENDE HEROS BTW. FEHLENDE ITEMDATEIEN
            Case "Bounty Hunter"
                Selected_Hero = "bounty_hunter"
            Case "Centaur Warchief"
                Selected_Hero = "centaur_warchief"
            Case "Chaos Knight"
                Selected_Hero = "chaos_knight"
            Case "Death Prophet"
                Selected_Hero = "death_prophet"
            Case "Goblin Techies"
                Selected_Hero = "goblin_techies"
            Case "Guardian Wisp"
                Selected_Hero = "guardian_wisp"
            Case "Keeper of the Light"
                Selected_Hero = "keeperofthelight"
            Case "Lone Druid"
                Selected_Hero = "lone_druid"
            Case "Naga Siren"
                Selected_Hero = "naga_siren"
            Case "Nerubian Assassin"
                Selected_Hero = "nerubian_assassin"
            Case "Ogre Magi"
                Selected_Hero = "ogre_magi"
            Case "Pandaren Brewmaster"
                Selected_Hero = "pandaren_brewmaster"
            Case "Phantom Lancer"
                Selected_Hero = "phantom_lancer"
            Case "Pit Lord"
                Selected_Hero = "pit_lord"
            Case "Shadow Demon"
                Selected_Hero = "shadow_demon"
            Case "Soul Keeper"
                Selected_Hero = "soul_keeper"
            Case "Spirit Breaker"
                Selected_Hero = "spirit_breaker"
            Case "Tauren Chieftain"
                Selected_Hero = "tauren_chieftain"
            Case "Treant Protector"
                Selected_Hero = "treant_protector"
            Case "Troll Warlord"
                Selected_Hero = "troll_warlord"
            Case Else
                Selected_Hero = ListBox1.SelectedItem.ToString
        End Select
        Clear()
        Label1.Text = ListBox1.SelectedItem.ToString
        CheckFile(Selected_Hero)
    End Sub

    Public Function ChangePicture(ByVal item_name As String) As System.Drawing.Image
        Dim pic_res As System.Drawing.Image
        ' TODO: Rezepte hinzufügen
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
            Case Else
                pic_res = D2RIC.My.Resources.Resources.none
                Return pic_res
        End Select
    End Function

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
                i += 1
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
        'we made it this far so the images must match
        Return True
    End Function

    Public Function GetToolTip(ByVal img_res As System.Drawing.Bitmap) As String
        Dim pic_res As String
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
        Else
            pic_res = "Error!"
            Return pic_res
        End If
    End Function

    Private Sub PictureBox1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox1.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub PictureBox1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox1.DragDrop
        ' Assign the image to the PictureBox. 
        PictureBox1.Image = e.Data.GetData(DataFormats.Bitmap)
    End Sub

    Private Sub PictureBox2_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox2.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub PictureBox2_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox2.DragDrop
        ' Assign the image to the PictureBox. 
        PictureBox2.Image = e.Data.GetData(DataFormats.Bitmap)
    End Sub

    Private Sub PictureBox3_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox3.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub PictureBox3_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox3.DragDrop
        ' Assign the image to the PictureBox. 
        PictureBox3.Image = e.Data.GetData(DataFormats.Bitmap)
    End Sub

    Private Sub PictureBox4_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox4.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub PictureBox4_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox4.DragDrop
        ' Assign the image to the PictureBox. 
        PictureBox4.Image = e.Data.GetData(DataFormats.Bitmap)
    End Sub

    Private Sub PictureBox5_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox5.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub PictureBox5_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox5.DragDrop
        ' Assign the image to the PictureBox. 
        PictureBox5.Image = e.Data.GetData(DataFormats.Bitmap)
    End Sub

    Private Sub PictureBox6_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox6.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub PictureBox6_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox6.DragDrop
        ' Assign the image to the PictureBox. 
        PictureBox6.Image = e.Data.GetData(DataFormats.Bitmap)
    End Sub

    Private Sub PictureBox7_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox7.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub PictureBox7_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox7.DragDrop
        ' Assign the image to the PictureBox. 
        PictureBox7.Image = e.Data.GetData(DataFormats.Bitmap)
    End Sub

    Private Sub PictureBox8_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox8.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub PictureBox8_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox8.DragDrop
        ' Assign the image to the PictureBox. 
        PictureBox8.Image = e.Data.GetData(DataFormats.Bitmap)
    End Sub

    Private Sub PictureBox9_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox9.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub PictureBox9_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox9.DragDrop
        ' Assign the image to the PictureBox. 
        PictureBox9.Image = e.Data.GetData(DataFormats.Bitmap)
    End Sub

    Private Sub PictureBox10_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox10.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub PictureBox10_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox10.DragDrop
        ' Assign the image to the PictureBox. 
        PictureBox10.Image = e.Data.GetData(DataFormats.Bitmap)
    End Sub

    Private Sub PictureBox11_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox11.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub PictureBox11_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox11.DragDrop
        ' Assign the image to the PictureBox. 
        PictureBox11.Image = e.Data.GetData(DataFormats.Bitmap)
    End Sub

    Private Sub PictureBox12_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox12.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub PictureBox12_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox12.DragDrop
        ' Assign the image to the PictureBox. 
        PictureBox12.Image = e.Data.GetData(DataFormats.Bitmap)
    End Sub

    Private Sub PictureBox13_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox13.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub PictureBox13_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox13.DragDrop
        ' Assign the image to the PictureBox. 
        PictureBox13.Image = e.Data.GetData(DataFormats.Bitmap)
    End Sub

    Private Sub PictureBox14_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox14.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub PictureBox14_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox14.DragDrop
        ' Assign the image to the PictureBox. 
        PictureBox14.Image = e.Data.GetData(DataFormats.Bitmap)
    End Sub

    Private Sub PictureBox15_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox15.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub PictureBox15_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox15.DragDrop
        ' Assign the image to the PictureBox. 
        PictureBox15.Image = e.Data.GetData(DataFormats.Bitmap)
    End Sub

    Private Sub PictureBox16_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox16.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub PictureBox16_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox16.DragDrop
        ' Assign the image to the PictureBox. 
        PictureBox16.Image = e.Data.GetData(DataFormats.Bitmap)
    End Sub

    Private Sub PictureBox17_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox17.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub PictureBox17_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox17.DragDrop
        ' Assign the image to the PictureBox. 
        PictureBox17.Image = e.Data.GetData(DataFormats.Bitmap)
    End Sub

    Private Sub PictureBox18_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox18.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub PictureBox18_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox18.DragDrop
        ' Assign the image to the PictureBox. 
        PictureBox18.Image = e.Data.GetData(DataFormats.Bitmap)
    End Sub

    Private Sub PictureBox19_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox19.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub PictureBox19_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox19.DragDrop
        ' Assign the image to the PictureBox. 
        PictureBox19.Image = e.Data.GetData(DataFormats.Bitmap)
    End Sub

    Private Sub PictureBox20_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox20.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub PictureBox20_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox20.DragDrop
        ' Assign the image to the PictureBox. 
        PictureBox20.Image = e.Data.GetData(DataFormats.Bitmap)
    End Sub

    Private Sub PictureBox21_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox21.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub PictureBox21_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox21.DragDrop
        ' Assign the image to the PictureBox. 
        PictureBox21.Image = e.Data.GetData(DataFormats.Bitmap)
    End Sub

    Private Sub PictureBox22_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox22.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub PictureBox22_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox22.DragDrop
        ' Assign the image to the PictureBox. 
        PictureBox22.Image = e.Data.GetData(DataFormats.Bitmap)
    End Sub

    Private Sub PictureBox23_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox23.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub PictureBox23_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox23.DragDrop
        ' Assign the image to the PictureBox. 
        PictureBox23.Image = e.Data.GetData(DataFormats.Bitmap)
    End Sub

    Private Sub PictureBox24_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox24.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub PictureBox24_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox24.DragDrop
        ' Assign the image to the PictureBox. 
        PictureBox24.Image = e.Data.GetData(DataFormats.Bitmap)
    End Sub

    Private Sub PictureBox25_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox25.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub PictureBox25_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox25.DragDrop
        ' Assign the image to the PictureBox. 
        PictureBox25.Image = e.Data.GetData(DataFormats.Bitmap)
    End Sub

    Private Sub PictureBox26_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox26.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub PictureBox26_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox26.DragDrop
        ' Assign the image to the PictureBox. 
        PictureBox26.Image = e.Data.GetData(DataFormats.Bitmap)
    End Sub

    Private Sub PictureBox27_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox27.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub PictureBox27_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox27.DragDrop
        ' Assign the image to the PictureBox. 
        PictureBox27.Image = e.Data.GetData(DataFormats.Bitmap)
    End Sub

    Private Sub PictureBox28_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox28.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub PictureBox28_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox28.DragDrop
        ' Assign the image to the PictureBox. 
        PictureBox28.Image = e.Data.GetData(DataFormats.Bitmap)
    End Sub

    Private Sub PictureBox29_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox29.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub PictureBox29_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox29.DragDrop
        ' Assign the image to the PictureBox. 
        PictureBox29.Image = e.Data.GetData(DataFormats.Bitmap)
    End Sub

    Private Sub PictureBox30_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox30.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub PictureBox30_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox30.DragDrop
        ' Assign the image to the PictureBox. 
        PictureBox30.Image = e.Data.GetData(DataFormats.Bitmap)
    End Sub

    'TOOLTIPS
    Private Sub PictureBox1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseHover
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(PictureBox1.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(PictureBox1, "")
            ToolTip1.SetToolTip(PictureBox1, GetToolTip(PictureBox1.Image))
        Else
            ToolTip1.SetToolTip(PictureBox1, "none")
        End If
    End Sub

    Private Sub PictureBox2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseHover
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(PictureBox2.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(PictureBox2, "")
            ToolTip1.SetToolTip(PictureBox2, GetToolTip(PictureBox2.Image))
        Else
            ToolTip1.SetToolTip(PictureBox2, "none")
        End If
    End Sub

    Private Sub PictureBox3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseHover
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(PictureBox3.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(PictureBox3, "")
            ToolTip1.SetToolTip(PictureBox3, GetToolTip(PictureBox3.Image))
        Else
            ToolTip1.SetToolTip(PictureBox3, "none")
        End If
    End Sub

    Private Sub PictureBox4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseHover
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(PictureBox4.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(PictureBox4, "")
            ToolTip1.SetToolTip(PictureBox4, GetToolTip(PictureBox4.Image))
        Else
            ToolTip1.SetToolTip(PictureBox4, "none")
        End If
    End Sub

    Private Sub PictureBox5_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseHover
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(PictureBox5.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(PictureBox5, "")
            ToolTip1.SetToolTip(PictureBox5, GetToolTip(PictureBox5.Image))
        Else
            ToolTip1.SetToolTip(PictureBox5, "none")
        End If
    End Sub

    Private Sub PictureBox6_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseHover
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(PictureBox6.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(PictureBox6, "")
            ToolTip1.SetToolTip(PictureBox6, GetToolTip(PictureBox6.Image))
        Else
            ToolTip1.SetToolTip(PictureBox6, "none")
        End If
    End Sub

    Private Sub PictureBox7_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox7.MouseHover
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(PictureBox7.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(PictureBox7, "")
            ToolTip1.SetToolTip(PictureBox7, GetToolTip(PictureBox7.Image))
        Else
            ToolTip1.SetToolTip(PictureBox7, "none")
        End If
    End Sub

    Private Sub PictureBox8_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox8.MouseHover
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(PictureBox8.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(PictureBox8, "")
            ToolTip1.SetToolTip(PictureBox8, GetToolTip(PictureBox8.Image))
        Else
            ToolTip1.SetToolTip(PictureBox8, "none")
        End If
    End Sub

    Private Sub PictureBox9_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox9.MouseHover
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(PictureBox9.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(PictureBox9, "")
            ToolTip1.SetToolTip(PictureBox9, GetToolTip(PictureBox9.Image))
        Else
            ToolTip1.SetToolTip(PictureBox9, "none")
        End If
    End Sub

    Private Sub PictureBox10_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox10.MouseHover
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(PictureBox10.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(PictureBox10, "")
            ToolTip1.SetToolTip(PictureBox10, GetToolTip(PictureBox10.Image))
        Else
            ToolTip1.SetToolTip(PictureBox10, "none")
        End If
    End Sub

    Private Sub PictureBox11_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox11.MouseHover
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(PictureBox11.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(PictureBox11, "")
            ToolTip1.SetToolTip(PictureBox11, GetToolTip(PictureBox11.Image))
        Else
            ToolTip1.SetToolTip(PictureBox11, "none")
        End If
    End Sub

    Private Sub PictureBox12_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox12.MouseHover
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(PictureBox12.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(PictureBox12, "")
            ToolTip1.SetToolTip(PictureBox12, GetToolTip(PictureBox12.Image))
        Else
            ToolTip1.SetToolTip(PictureBox12, "none")
        End If
    End Sub

    Private Sub PictureBox13_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox13.MouseHover
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(PictureBox13.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(PictureBox13, "")
            ToolTip1.SetToolTip(PictureBox13, GetToolTip(PictureBox13.Image))
        Else
            ToolTip1.SetToolTip(PictureBox13, "none")
        End If
    End Sub

    Private Sub PictureBox14_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox14.MouseHover
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(PictureBox14.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(PictureBox14, "")
            ToolTip1.SetToolTip(PictureBox14, GetToolTip(PictureBox14.Image))
        Else
            ToolTip1.SetToolTip(PictureBox14, "none")
        End If
    End Sub

    Private Sub PictureBox15_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox15.MouseHover
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(PictureBox15.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(PictureBox15, "")
            ToolTip1.SetToolTip(PictureBox15, GetToolTip(PictureBox15.Image))
        Else
            ToolTip1.SetToolTip(PictureBox15, "none")
        End If
    End Sub

    Private Sub PictureBox16_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox16.MouseHover
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(PictureBox16.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(PictureBox16, "")
            ToolTip1.SetToolTip(PictureBox16, GetToolTip(PictureBox16.Image))
        Else
            ToolTip1.SetToolTip(PictureBox16, "none")
        End If
    End Sub

    Private Sub PictureBox17_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox17.MouseHover
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(PictureBox17.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(PictureBox17, "")
            ToolTip1.SetToolTip(PictureBox17, GetToolTip(PictureBox17.Image))
        Else
            ToolTip1.SetToolTip(PictureBox17, "none")
        End If
    End Sub

    Private Sub PictureBox18_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox18.MouseHover
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(PictureBox18.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(PictureBox18, "")
            ToolTip1.SetToolTip(PictureBox18, GetToolTip(PictureBox18.Image))
        Else
            ToolTip1.SetToolTip(PictureBox18, "none")
        End If
    End Sub

    Private Sub PictureBox19_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox19.MouseHover
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(PictureBox19.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(PictureBox19, "")
            ToolTip1.SetToolTip(PictureBox19, GetToolTip(PictureBox19.Image))
        Else
            ToolTip1.SetToolTip(PictureBox19, "none")
        End If
    End Sub

    Private Sub PictureBox20_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox20.MouseHover
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(PictureBox20.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(PictureBox20, "")
            ToolTip1.SetToolTip(PictureBox20, GetToolTip(PictureBox20.Image))
        Else
            ToolTip1.SetToolTip(PictureBox20, "none")
        End If
    End Sub

    Private Sub PictureBox21_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox21.MouseHover
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(PictureBox21.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(PictureBox21, "")
            ToolTip1.SetToolTip(PictureBox21, GetToolTip(PictureBox21.Image))
        Else
            ToolTip1.SetToolTip(PictureBox21, "none")
        End If
    End Sub

    Private Sub PictureBox22_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox22.MouseHover
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(PictureBox22.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(PictureBox22, "")
            ToolTip1.SetToolTip(PictureBox22, GetToolTip(PictureBox22.Image))
        Else
            ToolTip1.SetToolTip(PictureBox22, "none")
        End If
    End Sub

    Private Sub PictureBox23_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox23.MouseHover
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(PictureBox23.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(PictureBox23, "")
            ToolTip1.SetToolTip(PictureBox23, GetToolTip(PictureBox23.Image))
        Else
            ToolTip1.SetToolTip(PictureBox23, "none")
        End If
    End Sub

    Private Sub PictureBox24_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox24.MouseHover
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(PictureBox24.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(PictureBox24, "")
            ToolTip1.SetToolTip(PictureBox24, GetToolTip(PictureBox24.Image))
        Else
            ToolTip1.SetToolTip(PictureBox24, "none")
        End If
    End Sub

    Private Sub PictureBox25_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox25.MouseHover
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(PictureBox25.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(PictureBox25, "")
            ToolTip1.SetToolTip(PictureBox25, GetToolTip(PictureBox25.Image))
        Else
            ToolTip1.SetToolTip(PictureBox25, "none")
        End If
    End Sub

    Private Sub PictureBox26_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox26.MouseHover
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(PictureBox26.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(PictureBox26, "")
            ToolTip1.SetToolTip(PictureBox26, GetToolTip(PictureBox26.Image))
        Else
            ToolTip1.SetToolTip(PictureBox26, "none")
        End If
    End Sub

    Private Sub PictureBox27_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox27.MouseHover
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(PictureBox27.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(PictureBox27, "")
            ToolTip1.SetToolTip(PictureBox27, GetToolTip(PictureBox27.Image))
        Else
            ToolTip1.SetToolTip(PictureBox27, "none")
        End If
    End Sub

    Private Sub PictureBox28_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox28.MouseHover
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(PictureBox28.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(PictureBox28, "")
            ToolTip1.SetToolTip(PictureBox28, GetToolTip(PictureBox28.Image))
        Else
            ToolTip1.SetToolTip(PictureBox28, "none")
        End If
    End Sub

    Private Sub PictureBox29_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox29.MouseHover
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(PictureBox29.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(PictureBox29, "")
            ToolTip1.SetToolTip(PictureBox29, GetToolTip(PictureBox29.Image))
        Else
            ToolTip1.SetToolTip(PictureBox29, "none")
        End If
    End Sub

    Private Sub PictureBox30_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox30.MouseHover
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(PictureBox30.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(PictureBox30, "")
            ToolTip1.SetToolTip(PictureBox30, GetToolTip(PictureBox30.Image))
        Else
            ToolTip1.SetToolTip(PictureBox30, "none")
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
    Private Sub PictureBox39MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox39.MouseMove
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

End Class