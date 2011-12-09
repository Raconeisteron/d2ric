Public Class Form2
    Dim Selected_Hero, NeuerText, Items As String

    Private Sub Form2_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub
    'Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
    '    Select Case ListBox1.SelectedItem.ToString
    '        Case "Anti-Mage"
    '            Selected_Hero = "antimage"
    '        Case "Ancient Apparition"
    '            Selected_Hero = "ancient_apparition"
    '        Case "Crystal Maiden"
    '            Selected_Hero = "crystal_maiden"
    '        Case "Dark Seer"
    '            Selected_Hero = "dark_seer"
    '        Case "Doom Bringer"
    '            Selected_Hero = "doom_bringer"
    '        Case "Dragon Knight"
    '            Selected_Hero = "dragon_knight"
    '        Case "Drow Ranger"
    '            Selected_Hero = "drow_ranger"
    '        Case "Faceless Void"
    '            Selected_Hero = "faceless_void"
    '        Case "Nature's Prophet"
    '            Selected_Hero = "furion"
    '        Case "Clockwerk"
    '            Selected_Hero = "rattletrap"
    '        Case "Night Stalker"
    '            Selected_Hero = "night_stalker"
    '        Case "Queen of Pain"
    '            Selected_Hero = "queenofpain"
    '        Case "Shadow Fiend"
    '            Selected_Hero = "nevermore"
    '        Case "Shadow Shaman"
    '            Selected_Hero = "shadow_shaman"
    '        Case "Skeleton King"
    '            Selected_Hero = "skeleton_king"
    '        Case "Sand King"
    '            Selected_Hero = "sand_king"
    '        Case "Storm Spirit"
    '            Selected_Hero = "storm_spirit"
    '        Case "Vengeful Spirit"
    '            Selected_Hero = "vengefulspirit"
    '        Case "Witch Doctor"
    '            Selected_Hero = "witch_doctor"
    '        Case "Zeus"
    '            Selected_Hero = "zuus"
    '        Case "Lifestealer"
    '            Selected_Hero = "life_stealer"
    '        Case "Mortred"
    '            Selected_Hero = "phantom_assassin"
    '            ' FEHLENDE HEROS BTW. FEHLENDE ITEMDATEIEN
    '        Case "Bounty Hunter"
    '            Selected_Hero = "bounty_hunter"
    '        Case "Centaur Warchief"
    '            Selected_Hero = "centaur_warchief"
    '        Case "Chaos Knight"
    '            Selected_Hero = "chaos_knight"
    '        Case "Death Prophet"
    '            Selected_Hero = "death_prophet"
    '        Case "Goblin Techies"
    '            Selected_Hero = "goblin_techies"
    '        Case "Guardian Wisp"
    '            Selected_Hero = "guardian_wisp"
    '        Case "Keeper of the Light"
    '            Selected_Hero = "keeperofthelight"
    '        Case "Lone Druid"
    '            Selected_Hero = "lone_druid"
    '        Case "Naga Siren"
    '            Selected_Hero = "naga_siren"
    '        Case "Nerubian Assassin"
    '            Selected_Hero = "nerubian_assassin"
    '        Case "Ogre Magi"
    '            Selected_Hero = "ogre_magi"
    '        Case "Pandaren Brewmaster"
    '            Selected_Hero = "pandaren_brewmaster"
    '        Case "Phantom Lancer"
    '            Selected_Hero = "phantom_lancer"
    '        Case "Pit Lord"
    '            Selected_Hero = "pit_lord"
    '        Case "Shadow Demon"
    '            Selected_Hero = "shadow_demon"
    '        Case "Soul Keeper"
    '            Selected_Hero = "soul_keeper"
    '        Case "Spirit Breaker"
    '            Selected_Hero = "spirit_breaker"
    '        Case "Tauren Chieftain"
    '            Selected_Hero = "tauren_chieftain"
    '        Case "Treant Protector"
    '            Selected_Hero = "treant_protector"
    '        Case "Troll Warlord"
    '            Selected_Hero = "troll_warlord"
    '        Case Else
    '            Selected_Hero = ListBox1.SelectedItem.ToString
    '    End Select
    '    Clear()
    '    Label1.Text = ListBox1.SelectedItem.ToString
    '    CheckFile(Selected_Hero)
    'End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        System.Diagnostics.Process.Start("explorer", My.Settings.path)
    End Sub

    Public Sub Clear()
        For Each C In Me.Controls
            If TypeOf (C) Is ComboBox Then C.Text = "none"
        Next
        TextBox1.Text = ""
        Label1.Text = ""
        Items = ""
        NeuerText = ""
    End Sub

    Private Sub CheckFile(ByVal hero As String)
        If IO.File.Exists(My.Settings.path + "\default_" + hero + ".txt") Then
            Dim DeinPfad As String = My.Settings.path + "\default_" + hero + ".txt"
            Dim ItemPlace As String = "Starting Items"
            Dim i As Integer = 1
            For Each Zeile As String In IO.File.ReadAllLines(DeinPfad)
                If Zeile.Contains("item_") And i < 31 Then
                    Me.Controls.Item("ComboBox" & i).Text = RenameItem(Zeile)
                    Me.Controls.Item("ComboBox" & i + 30).Text = ItemPlace
                    i = i + 1
                ElseIf Zeile.Contains("Early_Game") Then
                    ItemPlace = "Early Game"
                    NeuerText &= Zeile & vbNewLine
                ElseIf Zeile.Contains("Core_Items") Then
                    ItemPlace = "Core Items"
                    NeuerText &= Zeile & vbNewLine
                ElseIf Zeile.Contains("Luxury") Then
                    ItemPlace = "Luxury"
                    NeuerText &= Zeile & vbNewLine
                ElseIf Zeile.Contains("author") Then
                    TextBox1.Text = Replace(Zeile, """", "")
                    TextBox1.Text = Replace(TextBox1.Text, "author", "")
                    TextBox1.Text = Replace(TextBox1.Text, vbTab, "")
                    NeuerText &= Zeile & vbNewLine
                Else
                    NeuerText &= Zeile & vbNewLine
                End If
                Items &= Zeile & vbNewLine
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

            For a = 1 To 30
                If Me.Controls.Item("ComboBox" & a + 30).Text = "Starting Items" And CheckItem(Me.Controls.Item("ComboBox" & a).Text) <> "" Then
                    StartingItems &= vbNewLine & vbTab & vbTab & vbTab & """Item""" & vbTab & vbTab & CheckItem(Me.Controls.Item("ComboBox" & a).Text)
                ElseIf Me.Controls.Item("ComboBox" & a + 30).Text = "Early Game" And CheckItem(Me.Controls.Item("ComboBox" & a).Text) <> "" Then
                    Earlygame &= vbNewLine & vbTab & vbTab & vbTab & """Item""" & vbTab & vbTab & CheckItem(Me.Controls.Item("ComboBox" & a).Text)
                ElseIf Me.Controls.Item("ComboBox" & a + 30).Text = "Core Items" And CheckItem(Me.Controls.Item("ComboBox" & a).Text) <> "" Then
                    CoreItems &= vbNewLine & vbTab & vbTab & vbTab & """Item""" & vbTab & vbTab & CheckItem(Me.Controls.Item("ComboBox" & a).Text)
                ElseIf Me.Controls.Item("ComboBox" & a + 30).Text = "Luxury" And CheckItem(Me.Controls.Item("ComboBox" & a).Text) <> "" Then
                    Luxury &= vbNewLine & vbTab & vbTab & vbTab & """Item""" & vbTab & vbTab & CheckItem(Me.Controls.Item("ComboBox" & a).Text)
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

    Public Function CheckItem(ByVal item_name As String) As String
        Dim new_item_name As String
        ' TODO: Rezepte hinzufügen
        Select Case item_name
            Case "Blink Dagger"
                new_item_name = """" & "item_blink" & """"
                Return new_item_name
            Case "Blades of Attack"
                new_item_name = """" & "item_blades_of_attack" & """"
                Return new_item_name
            Case "Aghanim's Scepter"
                new_item_name = """" & "item_ultimate_scepter" & """"
                Return new_item_name
            Case "Animal Courier"
                new_item_name = """" & "item_courier" & """"
                Return new_item_name
            Case "Arcane Boots"
                new_item_name = """" & "item_arcane_boots" & """"
                Return new_item_name
            Case "Armlet"
                new_item_name = """" & "item_armlet" & """"
                Return new_item_name
            Case "Assault Cuirass"
                new_item_name = """" & "item_assault" & """"
                Return new_item_name
            Case "Battle Fury"
                new_item_name = """" & "item_bfury" & """"
                Return new_item_name
            Case "Belt of Strength"
                new_item_name = """" & "item_belt_of_strength" & """"
                Return new_item_name
            Case "Black King Bar"
                new_item_name = """" & "item_black_king_bar" & """"
                Return new_item_name
            Case "Blade Mail"
                new_item_name = """" & "item_blade_mail" & """"
                Return new_item_name
            Case "Blade of Alacrity"
                new_item_name = """" & "item_blade_of_alacrity" & """"
                Return new_item_name
            Case "Bloodstone"
                new_item_name = """" & "item_bloodstone" & """"
                Return new_item_name
            Case "Boots of Elvenskin"
                new_item_name = """" & "item_boots_of_elves" & """"
                Return new_item_name
            Case "Boots of Speed"
                new_item_name = """" & "item_boots" & """"
                Return new_item_name
            Case "Boots of Travel"
                new_item_name = """" & "item_travel_boots" & """"
                Return new_item_name
            Case "Bottle"
                new_item_name = """" & "item_bottle" & """"
                Return new_item_name
            Case "Bracer"
                new_item_name = """" & "item_bracer" & """"
                Return new_item_name
            Case "Broadsword"
                new_item_name = """" & "item_broadsword" & """"
                Return new_item_name
            Case "Buckler"
                new_item_name = """" & "item_buckler" & """"
                Return new_item_name
            Case "Butterfly"
                new_item_name = """" & "item_butterfly" & """"
                Return new_item_name
            Case "Chainmail"
                new_item_name = """" & "item_chainmail" & """"
                Return new_item_name
            Case "Circlet"
                new_item_name = """" & "item_circlet" & """"
                Return new_item_name
            Case "Clarity"
                new_item_name = """" & "item_clarity" & """"
                Return new_item_name
            Case "Claymore"
                new_item_name = """" & "item_claymore" & """"
                Return new_item_name
            Case "Cloak"
                new_item_name = """" & "item_cloak" & """"
                Return new_item_name
            Case "Crystalys"
                new_item_name = """" & "item_lesser_crit" & """"
                Return new_item_name
            Case "Daedalus"
                new_item_name = """" & "item_greater_crit" & """"
                Return new_item_name
            Case "Dagon 1"
                new_item_name = """" & "item_dagon" & """"
                Return new_item_name
            Case "Dagon 2"
                new_item_name = """" & "item_dagon_2" & """"
                Return new_item_name
            Case "Dagon 3"
                new_item_name = """" & "item_dagon_3" & """"
                Return new_item_name
            Case "Dagon 4"
                new_item_name = """" & "item_dagon_4" & """"
                Return new_item_name
            Case "Dagon 5"
                new_item_name = """" & "item_dagon_5" & """"
                Return new_item_name
            Case "Demon Edge"
                new_item_name = """" & "item_demon_edge" & """"
                Return new_item_name
            Case "Desolator"
                new_item_name = """" & "item_desolator" & """"
                Return new_item_name
            Case "Diffusal Blade 1"
                new_item_name = """" & "item_diffusal_blade" & """"
                Return new_item_name
            Case "Diffusal Blade 2"
                new_item_name = """" & "item_diffusal_blade_2" & """"
                Return new_item_name
            Case "Divine Rapier"
                new_item_name = """" & "item_rapier" & """"
                Return new_item_name
            Case "Drum of Endurance"
                new_item_name = """" & "item_ancient_janggo" & """"
                Return new_item_name
            Case "Dust of Appearance"
                new_item_name = """" & "item_dust" & """"
                Return new_item_name
            Case "Eaglesong"
                new_item_name = """" & "item_eagle" & """"
                Return new_item_name
            Case "Energy Booster"
                new_item_name = """" & "item_energy_booster" & """"
                Return new_item_name
            Case "Ethereal Blade"
                new_item_name = """" & "item_ethereal_blade" & """"
                Return new_item_name
            Case "Eul's Scepter of Divinity"
                new_item_name = """" & "item_cyclone" & """"
                Return new_item_name
            Case "Eye of Skadi"
                new_item_name = """" & "item_skadi" & """"
                Return new_item_name
            Case "Flying Courier"
                new_item_name = """" & "item_flying_courier" & """"
                Return new_item_name
            Case "Force Staff"
                new_item_name = """" & "item_force_staff" & """"
                Return new_item_name
            Case "Gauntlets of Strength"
                new_item_name = """" & "item_gauntlets" & """"
                Return new_item_name
            Case "Gem of True Sight"
                new_item_name = """" & "item_gem" & """"
                Return new_item_name
            Case "Ghost Scepter"
                new_item_name = """" & "item_ghost" & """"
                Return new_item_name
            Case "Gloves of Haste"
                new_item_name = """" & "item_gloves" & """"
                Return new_item_name
            Case "Hand of Midas"
                new_item_name = """" & "item_hand_of_midas" & """"
                Return new_item_name
            Case "Headdress"
                new_item_name = """" & "item_headdress" & """"
                Return new_item_name
            Case "Healing Salve"
                new_item_name = """" & "item_flask" & """"
                Return new_item_name
            Case "Heart of Tarrasque"
                new_item_name = """" & "item_heart" & """"
                Return new_item_name
            Case "Helm of Iron Will"
                new_item_name = """" & "item_helm_of_iron_will" & """"
                Return new_item_name
            Case "Helm of the Dominator"
                new_item_name = """" & "item_helm_of_the_dominator" & """"
                Return new_item_name
            Case "Hood of Defiance"
                new_item_name = """" & "item_hood_of_defiance" & """"
                Return new_item_name
            Case "Hyperstone"
                new_item_name = """" & "item_hyperstone" & """"
                Return new_item_name
            Case "Iron Branch"
                new_item_name = """" & "item_branches" & """"
                Return new_item_name
            Case "Javelin"
                new_item_name = """" & "item_javelin" & """"
                Return new_item_name
            Case "Linken's Sphere"
                new_item_name = """" & "item_sphere" & """"
                Return new_item_name
            Case "Maelstrom"
                new_item_name = """" & "item_maelstrom" & """"
                Return new_item_name
            Case "Magic Stick"
                new_item_name = """" & "item_magic_stick" & """"
                Return new_item_name
            Case "Magic Wand"
                new_item_name = """" & "item_magic_wand" & """"
                Return new_item_name
            Case "Manta Style"
                new_item_name = """" & "item_manta" & """"
                Return new_item_name
            Case "Mantle of Intelligence"
                new_item_name = """" & "item_mantle" & """"
                Return new_item_name
            Case "Mask of Madness"
                new_item_name = """" & "item_mask_of_madness" & """"
                Return new_item_name
            Case "Medallion of Courage"
                new_item_name = """" & "item_medallion_of_courage" & """"
                Return new_item_name
            Case "Mekansm"
                new_item_name = """" & "item_mekansm" & """"
                Return new_item_name
            Case "Mithril Hammer"
                new_item_name = """" & "item_mithril_hammer" & """"
                Return new_item_name
            Case "Mjollnir"
                new_item_name = """" & "item_mjollnir" & """"
                Return new_item_name
            Case "Monkey King Bar"
                new_item_name = """" & "item_monkey_king_bar" & """"
                Return new_item_name
            Case "Morbid Mask"
                new_item_name = """" & "item_lifesteal" & """"
                Return new_item_name
            Case "Mystic Staff"
                new_item_name = """" & "item_mystic_staff" & """"
                Return new_item_name
            Case "Necronomicon 1"
                new_item_name = """" & "item_necronomicon" & """"
                Return new_item_name
            Case "Necronomicon 2"
                new_item_name = """" & "item_necronomicon_2" & """"
                Return new_item_name
            Case "Necronomicon 3"
                new_item_name = """" & "item_necronomicon_3" & """"
                Return new_item_name
            Case "Null Talisman"
                new_item_name = """" & "item_null_talisman" & """"
                Return new_item_name
            Case "Oblivion Staff"
                new_item_name = """" & "item_oblivion_staff" & """"
                Return new_item_name
            Case "Observer Ward"
                new_item_name = """" & "item_ward_observer" & """"
                Return new_item_name
            Case "Ogre Club"
                new_item_name = """" & "item_ogre_axe" & """"
                Return new_item_name
            Case "Orb of Venom"
                new_item_name = """" & "item_orb_of_venom" & """"
                Return new_item_name
            Case "Orchid Malevolence"
                new_item_name = """" & "item_orchid" & """"
                Return new_item_name
            Case "Perseverance"
                new_item_name = """" & "item_pers" & """"
                Return new_item_name
            Case "Phase Boots"
                new_item_name = """" & "item_phase_boots" & """"
                Return new_item_name
            Case "Pipe of Insight"
                new_item_name = """" & "item_pipe" & """"
                Return new_item_name
            Case "Platemail"
                new_item_name = """" & "item_platemail" & """"
                Return new_item_name
            Case "Point Booster"
                new_item_name = """" & "item_point_booster" & """"
                Return new_item_name
            Case "Poor Man's Shield"
                new_item_name = """" & "item_poor_mans_shield" & """"
                Return new_item_name
            Case "Power Treads"
                new_item_name = """" & "item_power_treads" & """"
                Return new_item_name
            Case "Quarterstaff"
                new_item_name = """" & "item_quarterstaff" & """"
                Return new_item_name
            Case "Quelling Blade"
                new_item_name = """" & "item_quelling_blade" & """"
                Return new_item_name
            Case "Radiance"
                new_item_name = """" & "item_radiance" & """"
                Return new_item_name
            Case "Reaver"
                new_item_name = """" & "item_reaver" & """"
                Return new_item_name
            Case "Refresher Orb"
                new_item_name = """" & "item_refresher" & """"
                Return new_item_name
            Case "Ring of Basilius"
                new_item_name = """" & "item_ring_of_basilius" & """"
                Return new_item_name
            Case "Ring of Health"
                new_item_name = """" & "item_ring_of_health" & """"
                Return new_item_name
            Case "Ring of Protection"
                new_item_name = """" & "item_ring_of_protection" & """"
                Return new_item_name
            Case "Ring of Regen"
                new_item_name = """" & "item_ring_of_regen" & """"
                Return new_item_name
            Case "Robe of the Magi"
                new_item_name = """" & "item_robe" & """"
                Return new_item_name
            Case "Sacred Relic"
                new_item_name = """" & "item_relic" & """"
                Return new_item_name
            Case "Sage's Mask"
                new_item_name = """" & "item_sobi_mask" & """"
                Return new_item_name
            Case "Sange"
                new_item_name = """" & "item_sange" & """"
                Return new_item_name
            Case "Sange and Yasha"
                new_item_name = """" & "item_sange_and_yasha" & """"
                Return new_item_name
            Case "Satanic"
                new_item_name = """" & "item_satanic" & """"
                Return new_item_name
            Case "Scythe of Vyse"
                new_item_name = """" & "item_sheepstick" & """"
                Return new_item_name
            Case "Sentry Ward"
                new_item_name = """" & "item_ward_sentry" & """"
                Return new_item_name
            Case "Shadow Blade"
                new_item_name = """" & "item_invis_sword" & """"
                Return new_item_name
            Case "Shiva's Guard"
                new_item_name = """" & "item_shivas_guard" & """"
                Return new_item_name
            Case "Skull Basher"
                new_item_name = """" & "item_basher" & """"
                Return new_item_name
            Case "Slippers of Agility"
                new_item_name = """" & "item_slippers" & """"
                Return new_item_name
            Case "Smoke of Deceit"
                new_item_name = """" & "item_smoke_of_deceit" & """"
                Return new_item_name
            Case "Soul Booster"
                new_item_name = """" & "item_soul_booster" & """"
                Return new_item_name
            Case "Soul Ring"
                new_item_name = """" & "item_soul_ring" & """"
                Return new_item_name
            Case "Staff of Wizardry"
                new_item_name = """" & "item_staff_of_wizardry" & """"
                Return new_item_name
            Case "Stout Shield"
                new_item_name = """" & "item_stout_shield" & """"
                Return new_item_name
            Case "Talisman of Evasion"
                new_item_name = """" & "item_talisman_of_evasion" & """"
                Return new_item_name
            Case "Tango"
                new_item_name = """" & "item_tpscroll" & """"
                Return new_item_name
            Case "Town Portal Scroll"
                new_item_name = """" & "item_tango" & """"
                Return new_item_name
            Case "Ultimate Orb"
                new_item_name = """" & "item_ultimate_orb" & """"
                Return new_item_name
            Case "Urn of Shadows"
                new_item_name = """" & "item_urn_of_shadows" & """"
                Return new_item_name
            Case "Vanguard"
                new_item_name = """" & "item_vanguard" & """"
                Return new_item_name
            Case "Veil of Discord"
                new_item_name = """" & "item_veil_of_discord" & """"
                Return new_item_name
            Case "Vitality Booster"
                new_item_name = """" & "item_vitality_booster" & """"
                Return new_item_name
            Case "Vladmir's Offering"
                new_item_name = """" & "item_vladmir" & """"
                Return new_item_name
            Case "Void Stone"
                new_item_name = """" & "item_void_stone" & """"
                Return new_item_name
            Case "Wraith Band"
                new_item_name = """" & "item_wraith_band" & """"
                Return new_item_name
            Case "Yasha"
                new_item_name = """" & "item_yasha" & """"
                Return new_item_name
            Case Else
                new_item_name = ""
                'new_item_name = "Rename error! " + item_name
                Return new_item_name
        End Select
    End Function

    Public Function RenameItem(ByVal item_name As String) As String
        Dim rename_item_name, item_name2 As String
        item_name2 = Replace(item_name, """", "")
        item_name2 = Replace(item_name2, vbTab, "")
        ' TODO: Rezepte hinzufügen
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
                'rename_item_name = "Rename error! " + item_name2
                'MsgBox(item_name2)
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
End Class