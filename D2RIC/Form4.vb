Public Class Form4
    Dim Selected_Hero, NeuerText, Items As String
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Then
            IO.File.WriteAllText(My.Settings.path + "\temp.txt", TextBox1.Text)
            If IO.File.Exists(My.Settings.path + "\temp.txt") Then
                Dim DeinPfad As String = My.Settings.path + "\temp.txt"
                Dim ItemPlace As String = "Starting Items"
                Dim i As Integer = 1
                Form2.Clear()
                Form2.ListBox1.SelectedItems.Clear()
                For Each Zeile As String In IO.File.ReadAllLines(DeinPfad)
                    If Zeile.Contains("item_") And i < 31 Then
                        Form2.Controls.Item("ComboBox" & i).Text = Form2.RenameItem(Zeile)
                        Form2.Controls.Item("ComboBox" & i + 30).Text = ItemPlace
                        i = i + 1
                    ElseIf Zeile.Contains("Early_Game") Then
                        ItemPlace = "Early Game"
                    ElseIf Zeile.Contains("Core_Items") Then
                        ItemPlace = "Core Items"
                    ElseIf Zeile.Contains("Luxury") Then
                        ItemPlace = "Luxury"
                    ElseIf Zeile.Contains("author") Then
                        Form2.TextBox1.Text = Replace(Zeile, """", "")
                        Form2.TextBox1.Text = Replace(Form2.TextBox1.Text, "author", "")
                        Form2.TextBox1.Text = Replace(Form2.TextBox1.Text, vbTab, "")
                    ElseIf Zeile.Contains("hero") Then
                        Selected_Hero = Replace(Zeile, """hero""", "")
                        Selected_Hero = Replace(Selected_Hero, """", "")
                        Selected_Hero = Replace(Selected_Hero, vbTab, "")
                        Form2.Label1.Text = renameHero(Selected_Hero)
                        Form2.ListBox1.SelectedItem = renameHero(Selected_Hero)
                        Form2.Button1.Enabled = True
                        Form2.Button3.Enabled = True
                    Else

                    End If
                Next
                IO.File.Delete(My.Settings.path + "\temp.txt")
            Else
                MsgBox("Error! Hero maybe not implemented yet.")
            End If
            Me.Close()
        End If
    End Sub

    Private Function renameHero(ByVal hero) As String
        Select Case True
            Case hero Like "npc_dota_hero_alchemist"
                hero = "Alchemist"
            Case hero Like "npc_dota_hero_ancient_apparition"
                hero = "Ancient Apparition"
            Case hero Like "npc_dota_hero_antimage"
                hero = "Anti-Mage"
            Case hero Like "npc_dota_hero_axe"
                hero = "Axe"
            Case hero Like "npc_dota_hero_bane"
                hero = "Bane"
            Case hero Like "npc_dota_hero_batrider"
                hero = "Batrider"
            Case hero Like "npc_dota_hero_beastmaster"
                hero = "Beastmaster"
            Case hero Like "npc_dota_hero_bloodseeker"
                hero = "Bloodseeker"
            Case hero Like "npc_dota_hero_bounty_hunter"
                hero = "Bounty Hunter"
            Case hero Like "npc_dota_hero_broodmother"
                hero = "Broodmother"
            Case hero Like "npc_dota_hero_chen"
                hero = "Chen"
            Case hero Like "npc_dota_hero_clinkz"
                hero = "Clinkz"
            Case hero Like "npc_dota_hero_crystal_maiden"
                hero = "Crystal Maiden"
            Case hero Like "npc_dota_hero_dark_seer"
                hero = "Dark Seer"
            Case hero Like "npc_dota_hero_dazzle"
                hero = "Dazzle"
            Case hero Like "npc_dota_hero_death_prophet"
                hero = "Death Prophet"
            Case hero Like "npc_dota_hero_doom_bringer"
                hero = "Doom Bringer"
            Case hero Like "npc_dota_hero_dragon_knight"
                hero = "Dragon Knight"
            Case hero Like "npc_dota_hero_drow_ranger"
                hero = "Drow Ranger"
            Case hero Like "npc_dota_hero_earthshaker"
                hero = "Earthshaker"
            Case hero Like "npc_dota_hero_enchantress"
                hero = "Enchantress"
            Case hero Like "npc_dota_hero_enigma"
                hero = "Enigma"
            Case hero Like "npc_dota_hero_faceless_void"
                hero = "Faceless Void"
            Case hero Like "npc_dota_hero_furion"
                hero = "Nature's Prophet"
            Case hero Like "npc_dota_hero_gyrocopter"
                hero = "Gyrocopter"
            Case hero Like "npc_dota_hero_huskar"
                hero = "Huskar"
            Case hero Like "npc_dota_hero_invoker"
                hero = "Invoker"
            Case hero Like "npc_dota_hero_jakiro"
                hero = "Jakiro"
            Case hero Like "npc_dota_hero_juggernaut"
                hero = "Juggernaut"
            Case hero Like "npc_dota_hero_kunkka"
                hero = "Kunkka"
            Case hero Like "npc_dota_hero_leshrac"
                hero = "Leshrac"
            Case hero Like "npc_dota_hero_lich"
                hero = "Lich"
            Case hero Like "npc_dota_hero_life_stealer"
                hero = "Lifestealer"
            Case hero Like "npc_dota_hero_lina"
                hero = "Lina"
            Case hero Like "npc_dota_hero_lion"
                hero = "Lion"
            Case hero Like "npc_dota_hero_mirana"
                hero = "Mirana"
            Case hero Like "npc_dota_hero_morphling"
                hero = "Morphling"
            Case hero Like "npc_dota_hero_necrolyte"
                hero = "Necrolyte"
            Case hero Like "npc_dota_hero_nevermore"
                hero = "Shadow Fiend"
            Case hero Like "npc_dota_hero_night_stalker"
                hero = "Night Stalker"
            Case hero Like "npc_dota_hero_omniknight"
                hero = "Omniknight"
            Case hero Like "npc_dota_hero_phantom_assassin"
                hero = "Mortred"
            Case hero Like "npc_dota_hero_puck"
                hero = "Puck"
            Case hero Like "npc_dota_hero_pudge"
                hero = "Pudge"
            Case hero Like "npc_dota_hero_pugna"
                hero = "Pugna"
            Case hero Like "npc_dota_hero_queenofpain"
                hero = "Queen of Pain"
            Case hero Like "npc_dota_hero_rattletrap"
                hero = "Clockwerk"
            Case hero Like "npc_dota_hero_razor"
                hero = "Razor"
            Case hero Like "npc_dota_hero_riki"
                hero = "Riki"
            Case hero Like "npc_dota_hero_sand_king"
                hero = "Sand King"
            Case hero Like "npc_dota_hero_shadow_shaman"
                hero = "Shadow Shaman"
            Case hero Like "npc_dota_hero_silencer"
                hero = "Silencer"
            Case hero Like "npc_dota_hero_skeleton_king"
                hero = "Skeleton King"
            Case hero Like "npc_dota_hero_slardar"
                hero = "Slardar"
            Case hero Like "npc_dota_hero_sniper"
                hero = "Sniper"
            Case hero Like "npc_dota_hero_spectre"
                hero = "Spectre"
            Case hero Like "npc_dota_hero_spirit_breaker"
                hero = "Spirit Breaker"
            Case hero Like "npc_dota_hero_storm_spirit"
                hero = "Storm Spirit"
            Case hero Like "npc_dota_hero_sven"
                hero = "Sven"
            Case hero Like "npc_dota_hero_templar_assassin"
                hero = "Lanaya"
            Case hero Like "npc_dota_hero_tidehunter"
                hero = "Tidehunter"
            Case hero Like "npc_dota_hero_tinker"
                hero = "Tinker"
            Case hero Like "npc_dota_hero_tiny"
                hero = "Tiny"
            Case hero Like "npc_dota_hero_ursa"
                hero = "Ursa"
            Case hero Like "npc_dota_hero_vengefulspirit"
                hero = "Vengeful Spirit"
            Case hero Like "npc_dota_hero_venomancer"
                hero = "Venomancer"
            Case hero Like "npc_dota_hero_viper"
                hero = "Viper"
            Case hero Like "npc_dota_hero_warlock"
                hero = "Warlock"
            Case hero Like "npc_dota_hero_weaver"
                hero = "Weaver"
            Case hero Like "npc_dota_hero_windrunner"
                hero = "Windrunner"
            Case hero Like "npc_dota_hero_witch_doctor"
                hero = "Witch Doctor"
            Case hero Like "npc_dota_hero_zuus"
                hero = "Zeus"
                ' FEHLENDE HEROS BTW. FEHLENDE ITEMDATEIEN
            Case hero Like "npc_dota_hero_abaddon"
                hero = "Abaddon"
            Case hero Like "npc_dota_hero_bristleback"
                hero = "Bristleback"
            Case hero Like "npc_dota_hero_centaur_warchief"
                hero = "Centaur Warchief"
            Case hero Like "npc_dota_hero_chaos_knight"
                hero = "Chaos Knight"
            Case hero Like "npc_dota_hero_dirge"
                hero = "Dirge"
            Case hero Like "npc_dota_hero_disruptor"
                hero = "Disruptor"
            Case hero Like "npc_dota_hero_goblin_techies"
                hero = "Goblin Techies"
            Case hero Like "npc_dota_hero_guardian_wisp"
                hero = "Guardian Wisp"
            Case hero Like "npc_dota_hero_harbinger"
                hero = "Harbinger"
            Case hero Like "npc_dota_hero_keeperoftheLight"
                hero = "Keeper of the Light"
            Case hero Like "npc_dota_hero_lone_druid"
                hero = "Lone Druid"
            Case hero Like "npc_dota_hero_luna"
                hero = "Luna"
            Case hero Like "npc_dota_hero_lycanthrope"
                hero = "Lycanthrope"
            Case hero Like "npc_dota_hero_magnataur"
                hero = "Magnataur"
            Case hero Like "npc_dota_hero_medusa"
                hero = "Medusa"
            Case hero Like "npc_dota_hero_meepo"
                hero = "Meepo"
            Case hero Like "npc_dota_hero_naga_siren"
                hero = "Naga Siren"
            Case hero Like "npc_dota_hero_nerubian_assassin"
                hero = "Nerubian Assassin"
            Case hero Like "npc_dota_hero_ogre_magi"
                hero = "Ogre Magi"
            Case hero Like "npc_dota_hero_pandaren_brewmaster"
                hero = "Pandaren Brewmaster"
            Case hero Like "npc_dota_hero_phantom_lancer"
                hero = "Phantom Lancer"
            Case hero Like "npc_dota_hero_phoenix"
                hero = "Phoenix"
            Case hero Like "npc_dota_hero_pit_lord"
                hero = "Pit Lord"
            Case hero Like "npc_dota_hero_rubick"
                hero = "Rubick"
            Case hero Like "npc_dota_hero_shadow_demon"
                hero = "Shadow Demon"
            Case hero Like "npc_dota_hero_slark"
                hero = "Slark"
            Case hero Like "npc_dota_hero_soul_keeper"
                hero = "Soul Keeper"
            Case hero Like "npc_dota_hero_tauren_chieftain"
                hero = "Tauren Chieftain"
            Case hero Like "npc_dota_hero_treant_protector"
                hero = "Treant Protector"
            Case hero Like "npc_dota_hero_troll_warlord"
                hero = "Troll Warlord"
            Case hero Like "npc_dota_hero_tuskarr"
                hero = "Tuskarr"
            Case hero Like "npc_dota_hero_visage"
                hero = "Visage"
            Case Else
                hero = "Unknown hero!"
        End Select
        Return hero
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Dim OpenFileDialog1 As OpenFileDialog = New OpenFileDialog
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        OpenFileDialog1.Filter = "txt(*.txt)| *.txt"
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName <> "" Then
            If IO.File.Exists(OpenFileDialog1.FileName) Then
                TextBox1.Text = IO.File.ReadAllText(OpenFileDialog1.FileName)
            Else
                MsgBox("Error while reading.")
            End If
        Else
            TextBox1.Text = "Error!"
        End If
    End Sub
End Class