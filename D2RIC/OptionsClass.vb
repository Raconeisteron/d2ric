Public Class OptionsClass
    Friend WithEvents Itembuild As New ItembuildClass

    Public Sub ChangeSteamPath()
        Using FolderBrowserDialog1 As FolderBrowserDialog = New FolderBrowserDialog
            If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                FormMain.TextBox4.Text = FolderBrowserDialog1.SelectedPath
            End If
            Dim steam_path, path As String
            steam_path = FormMain.TextBox4.Text
            path = steam_path + "\SteamApps\common\dota 2 beta\dota\itembuilds"

            If My.Computer.FileSystem.DirectoryExists(path) Then
                ' existiert
                My.Settings.path = path
                My.Settings.Save()
                MsgBox("Path changed successfully.")
            Else
                ' existiert nicht
                MsgBox("Please check your Steam path!!!")
            End If
        End Using
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
                MsgBox("Error while creating folder")
            End Try
        End If
        If IO.Directory.Exists(My.Settings.path & "\Backup") Then
            For Each file As String In IO.Directory.GetFiles(My.Settings.path) ' Ermittelt alle Dateien des Ordners
                IO.File.Copy(file, My.Settings.path & "\Backup\" & System.DateTime.Now.Year.ToString & "-" & System.DateTime.Now.Month.ToString & "-" & System.DateTime.Now.Day.ToString & "_" & cut_file(file), True)  ' Kopiert die Dateien
            Next
        End If
    End Sub

    Public Sub DeleteBackup()
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

    Public Sub OpenBackup()
        If IO.Directory.Exists(My.Settings.path & "\Backup") Then
            System.Diagnostics.Process.Start("explorer", My.Settings.path + "\Backup")
        Else
            MsgBox("Backup folder doesn't exist.")
        End If
    End Sub

    Public Sub ChangeItemIcons()
        If FormMain.ComboBoxItemIcons.SelectedItem = "DotA 1" Then
            'Change Items Icons to DotA 1
            FormMain.PictureBox42.Image = D2RIC.My.Resources.Resources.Kelensdagger
            FormMain.PictureBox41.Image = D2RIC.My.Resources.Resources.Bladesofattack
            FormMain.PictureBox31.Image = D2RIC.My.Resources.Resources.Aghanimsscepter
            FormMain.PictureBox32.Image = D2RIC.My.Resources.Resources.Animalcourier
            FormMain.PictureBox33.Image = D2RIC.My.Resources.Resources.ArcaneBoots
            FormMain.PictureBox34.Image = D2RIC.My.Resources.Resources.Armletofmordiggian
            FormMain.PictureBox35.Image = D2RIC.My.Resources.Resources.Assaultcuirass
            FormMain.PictureBox36.Image = D2RIC.My.Resources.Resources.Battlefury
            FormMain.PictureBox37.Image = D2RIC.My.Resources.Resources.Beltofgiantstrength
            FormMain.PictureBox38.Image = D2RIC.My.Resources.Resources.Blackkingbar
            FormMain.PictureBox39.Image = D2RIC.My.Resources.Resources.Blademail
            FormMain.PictureBox40.Image = D2RIC.My.Resources.Resources.Bladesofalacrity
            FormMain.PictureBox43.Image = D2RIC.My.Resources.Resources.Bloodstone
            FormMain.PictureBox44.Image = D2RIC.My.Resources.Resources.Bootsofelvenskin
            FormMain.PictureBox45.Image = D2RIC.My.Resources.Resources.Bootsofspeed
            FormMain.PictureBox46.Image = D2RIC.My.Resources.Resources.Bootsoftravel
            FormMain.PictureBox47.Image = D2RIC.My.Resources.Resources.Bottle
            FormMain.PictureBox48.Image = D2RIC.My.Resources.Resources.Bracer
            FormMain.PictureBox49.Image = D2RIC.My.Resources.Resources.Broadsword
            FormMain.PictureBox50.Image = D2RIC.My.Resources.Resources.Nathrezimbuckler
            FormMain.PictureBox51.Image = D2RIC.My.Resources.Resources.Butterfly
            FormMain.PictureBox52.Image = D2RIC.My.Resources.Resources.Chainmail
            FormMain.PictureBox53.Image = D2RIC.My.Resources.Resources.Circletofnobility
            FormMain.PictureBox54.Image = D2RIC.My.Resources.Resources.Claritypotion
            FormMain.PictureBox55.Image = D2RIC.My.Resources.Resources.Claymore
            FormMain.PictureBox56.Image = D2RIC.My.Resources.Resources.Planeswalkerscloak
            FormMain.PictureBox57.Image = D2RIC.My.Resources.Resources.Crystalys
            FormMain.PictureBox58.Image = D2RIC.My.Resources.Resources.Burizadokyanon
            FormMain.PictureBox59.Image = D2RIC.My.Resources.Resources.Dagon
            FormMain.PictureBox60.Image = D2RIC.My.Resources.Resources.Dagon2
            FormMain.PictureBox61.Image = D2RIC.My.Resources.Resources.Dagon3
            FormMain.PictureBox62.Image = D2RIC.My.Resources.Resources.Dagon4
            FormMain.PictureBox63.Image = D2RIC.My.Resources.Resources.Dagon5
            FormMain.PictureBox64.Image = D2RIC.My.Resources.Resources.Demonedge
            FormMain.PictureBox65.Image = D2RIC.My.Resources.Resources.Stygiandesolator
            FormMain.PictureBox66.Image = D2RIC.My.Resources.Resources.Diffusalblade
            FormMain.PictureBox67.Image = D2RIC.My.Resources.Resources.Diffusalblade2
            FormMain.PictureBox68.Image = D2RIC.My.Resources.Resources.Divinerapier
            FormMain.PictureBox69.Image = D2RIC.My.Resources.Resources.Ancientjanggoofendurance
            FormMain.PictureBox70.Image = D2RIC.My.Resources.Resources.Dustofappearance
            FormMain.PictureBox71.Image = D2RIC.My.Resources.Resources.Eaglehorn
            FormMain.PictureBox72.Image = D2RIC.My.Resources.Resources.Energybooster
            FormMain.PictureBox73.Image = D2RIC.My.Resources.Resources.Etheral_Blade
            FormMain.PictureBox74.Image = D2RIC.My.Resources.Resources.Eulsscepterofdivinity
            FormMain.PictureBox75.Image = D2RIC.My.Resources.Resources.Eyeofskadi
            FormMain.PictureBox76.Image = D2RIC.My.Resources.Resources.Flyingcourier
            FormMain.PictureBox77.Image = D2RIC.My.Resources.Resources.Forcestaff
            FormMain.PictureBox78.Image = D2RIC.My.Resources.Resources.Gauntletsofstrength
            FormMain.PictureBox79.Image = D2RIC.My.Resources.Resources.Gemoftruesight
            FormMain.PictureBox80.Image = D2RIC.My.Resources.Resources.Ghostscepter
            FormMain.PictureBox81.Image = D2RIC.My.Resources.Resources.Ghostscepter
            FormMain.PictureBox82.Image = D2RIC.My.Resources.Resources.Handofmidas
            FormMain.PictureBox83.Image = D2RIC.My.Resources.Resources.Headdressofrejuvenation
            FormMain.PictureBox84.Image = D2RIC.My.Resources.Resources.Healingsalve
            FormMain.PictureBox85.Image = D2RIC.My.Resources.Resources.Heartoftarrasque
            FormMain.PictureBox86.Image = D2RIC.My.Resources.Resources.Helmofironwill
            FormMain.PictureBox87.Image = D2RIC.My.Resources.Resources.Helmofthedominator
            FormMain.PictureBox88.Image = D2RIC.My.Resources.Resources.Hoodofdefiance
            FormMain.PictureBox89.Image = D2RIC.My.Resources.Resources.Hyperstone
            FormMain.PictureBox90.Image = D2RIC.My.Resources.Resources.Ironwoodbranch
            FormMain.PictureBox91.Image = D2RIC.My.Resources.Resources.Javelin
            FormMain.PictureBox92.Image = D2RIC.My.Resources.Resources.Linkenssphere
            FormMain.PictureBox93.Image = D2RIC.My.Resources.Resources.Maelstrom
            FormMain.PictureBox94.Image = D2RIC.My.Resources.Resources.Magicstick
            FormMain.PictureBox95.Image = D2RIC.My.Resources.Resources.Magicwand
            FormMain.PictureBox96.Image = D2RIC.My.Resources.Resources.Mantastyle
            FormMain.PictureBox97.Image = D2RIC.My.Resources.Resources.Mantleofintelligence
            FormMain.PictureBox98.Image = D2RIC.My.Resources.Resources.Maskofmadness
            FormMain.PictureBox99.Image = D2RIC.My.Resources.Resources.Medallionofcourage
            FormMain.PictureBox100.Image = D2RIC.My.Resources.Resources.Mekansm
            FormMain.PictureBox101.Image = D2RIC.My.Resources.Resources.Mithrilhammer
            FormMain.PictureBox102.Image = D2RIC.My.Resources.Resources.Mjollnir
            FormMain.PictureBox103.Image = D2RIC.My.Resources.Resources.Monkeykingbar
            FormMain.PictureBox104.Image = D2RIC.My.Resources.Resources.Maskofdeath
            FormMain.PictureBox105.Image = D2RIC.My.Resources.Resources.Mysticstaff
            FormMain.PictureBox121.Image = D2RIC.My.Resources.Resources.Necronomicon
            FormMain.PictureBox106.Image = D2RIC.My.Resources.Resources.Necronomicon2
            FormMain.PictureBox107.Image = D2RIC.My.Resources.Resources.Necronomicon3
            FormMain.PictureBox108.Image = D2RIC.My.Resources.Resources.Nulltalisman
            FormMain.PictureBox109.Image = D2RIC.My.Resources.Resources.Oblivionstaff
            FormMain.PictureBox110.Image = D2RIC.My.Resources.Resources.Observerwards
            FormMain.PictureBox111.Image = D2RIC.My.Resources.Resources.Ogreaxe
            FormMain.PictureBox112.Image = D2RIC.My.Resources.Resources.OrbOfVenom
            FormMain.PictureBox113.Image = D2RIC.My.Resources.Resources.Orchidmalevolence
            FormMain.PictureBox114.Image = D2RIC.My.Resources.Resources.Perseverance
            FormMain.PictureBox115.Image = D2RIC.My.Resources.Resources.Phaseboots
            FormMain.PictureBox116.Image = D2RIC.My.Resources.Resources.Khadgarspipeofinsight
            FormMain.PictureBox117.Image = D2RIC.My.Resources.Resources.Platemail
            FormMain.PictureBox118.Image = D2RIC.My.Resources.Resources.Pointbooster
            FormMain.PictureBox119.Image = D2RIC.My.Resources.Resources.Poormansshield
            FormMain.PictureBox120.Image = D2RIC.My.Resources.Resources.Powertreads
            FormMain.PictureBox122.Image = D2RIC.My.Resources.Resources.Quarterstaff
            FormMain.PictureBox123.Image = D2RIC.My.Resources.Resources.Quellingblade
            FormMain.PictureBox124.Image = D2RIC.My.Resources.Resources.Radiance
            FormMain.PictureBox125.Image = D2RIC.My.Resources.Resources.Messerschmidtsreaver
            FormMain.PictureBox126.Image = D2RIC.My.Resources.Resources.Refresherorb
            FormMain.PictureBox127.Image = D2RIC.My.Resources.Resources.Ringofbasilius
            FormMain.PictureBox128.Image = D2RIC.My.Resources.Resources.Ringofhealth
            FormMain.PictureBox129.Image = D2RIC.My.Resources.Resources.Ringofprotection
            FormMain.PictureBox130.Image = D2RIC.My.Resources.Resources.Ringofregeneration
            FormMain.PictureBox131.Image = D2RIC.My.Resources.Resources.Robeofthemagi
            FormMain.PictureBox132.Image = D2RIC.My.Resources.Resources.Sacredrelic
            FormMain.PictureBox133.Image = D2RIC.My.Resources.Resources.Sobimask
            FormMain.PictureBox134.Image = D2RIC.My.Resources.Resources.Sange
            FormMain.PictureBox135.Image = D2RIC.My.Resources.Resources.Sangeandyasha
            FormMain.PictureBox136.Image = D2RIC.My.Resources.Resources.Satanic
            FormMain.PictureBox137.Image = D2RIC.My.Resources.Resources.Guinsoosscytheofvyse
            FormMain.PictureBox138.Image = D2RIC.My.Resources.Resources.Sentrywards
            FormMain.PictureBox139.Image = D2RIC.My.Resources.Resources.Lotharsedge
            FormMain.PictureBox140.Image = D2RIC.My.Resources.Resources.Shivasguard
            FormMain.PictureBox141.Image = D2RIC.My.Resources.Resources.Craniumbasher
            FormMain.PictureBox142.Image = D2RIC.My.Resources.Resources.Slippersofagility
            FormMain.PictureBox143.Image = D2RIC.My.Resources.Resources.SmokeOfDeceit
            FormMain.PictureBox144.Image = D2RIC.My.Resources.Resources.Soulbooster
            FormMain.PictureBox145.Image = D2RIC.My.Resources.Resources.Soul_Ring
            FormMain.PictureBox146.Image = D2RIC.My.Resources.Resources.Staffofwizardry
            FormMain.PictureBox147.Image = D2RIC.My.Resources.Resources.Stoutshield
            FormMain.PictureBox148.Image = D2RIC.My.Resources.Resources.Talismanofevasion
            FormMain.PictureBox149.Image = D2RIC.My.Resources.Resources.Ancienttangoofessifation
            FormMain.PictureBox150.Image = D2RIC.My.Resources.Resources.Townportal
            FormMain.PictureBox151.Image = D2RIC.My.Resources.Resources.Ultimateorb
            FormMain.PictureBox152.Image = D2RIC.My.Resources.Resources.Urnofshadows
            FormMain.PictureBox153.Image = D2RIC.My.Resources.Resources.Vanguard
            FormMain.PictureBox154.Image = D2RIC.My.Resources.Resources.Fatalbonds
            FormMain.PictureBox155.Image = D2RIC.My.Resources.Resources.Vitalitybooster
            FormMain.PictureBox156.Image = D2RIC.My.Resources.Resources.Vladimirsoffering
            FormMain.PictureBox157.Image = D2RIC.My.Resources.Resources.Voidstone
            FormMain.PictureBox158.Image = D2RIC.My.Resources.Resources.Wraithband
            FormMain.PictureBox159.Image = D2RIC.My.Resources.Resources.Yasha
            FormMain.PictureBox160.Image = D2RIC.My.Resources.Resources.AbyssalBlade
            FormMain.PictureBox161.Image = D2RIC.My.Resources.Resources.Halberd
            FormMain.PictureBox162.Image = D2RIC.My.Resources.Resources.RingofAquila
            FormMain.PictureBox163.Image = D2RIC.My.Resources.Resources.RodofAtos
            FormMain.PictureBox164.Image = D2RIC.My.Resources.Resources.TranquilBoots
        ElseIf FormMain.ComboBoxItemIcons.SelectedItem = "HoN" Then
            'Change Items Icons to HoN
            FormMain.PictureBox42.Image = D2RIC.My.Resources.Resources.HoN_Portal_Key
            FormMain.PictureBox41.Image = D2RIC.My.Resources.Resources.HoN_Punchdagger
            FormMain.PictureBox31.Image = D2RIC.My.Resources.Resources.HoN_Staff_Of_The_Master
            FormMain.PictureBox32.Image = D2RIC.My.Resources.Resources.HoN_Monkey_Courier
            FormMain.PictureBox33.Image = D2RIC.My.Resources.Resources.HoN_Ring_Of_Sorcery
            FormMain.PictureBox34.Image = D2RIC.My.Resources.Resources.HoN_Insanitarius
            FormMain.PictureBox35.Image = D2RIC.My.Resources.Resources.HoN_Daemonic_Breastplate
            FormMain.PictureBox36.Image = D2RIC.My.Resources.Resources.HoN_Runed_Axe
            FormMain.PictureBox37.Image = D2RIC.My.Resources.Resources.HoN_Bolstering_Armband
            FormMain.PictureBox38.Image = D2RIC.My.Resources.Resources.HoN_Shrunken_Head
            FormMain.PictureBox39.Image = D2RIC.My.Resources.Resources.HoN_Barbed_Armor
            FormMain.PictureBox40.Image = D2RIC.My.Resources.Resources.HoN_Quickblade
            FormMain.PictureBox43.Image = D2RIC.My.Resources.Resources.HoN_Sacrificial_Stone
            FormMain.PictureBox44.Image = D2RIC.My.Resources.Resources.HoN_Fleet_Feet
            FormMain.PictureBox45.Image = D2RIC.My.Resources.Resources.HoN_Marchers
            FormMain.PictureBox46.Image = D2RIC.My.Resources.Resources.HoN_Post_Haste
            FormMain.PictureBox47.Image = D2RIC.My.Resources.Resources.HoN_Bottle
            FormMain.PictureBox48.Image = D2RIC.My.Resources.Resources.HoN_Fortified_Bracelet
            FormMain.PictureBox49.Image = D2RIC.My.Resources.Resources.HoN_Broadsword
            FormMain.PictureBox50.Image = D2RIC.My.Resources.Resources.HoN_Shield_Of_The_Five
            FormMain.PictureBox51.Image = D2RIC.My.Resources.Resources.HoN_Wingbow
            FormMain.PictureBox52.Image = D2RIC.My.Resources.Resources.HoN_Ringmail
            FormMain.PictureBox53.Image = D2RIC.My.Resources.Resources.HoN_Pretenders_Crown
            FormMain.PictureBox54.Image = D2RIC.My.Resources.Resources.HoN_Mana_Potion
            FormMain.PictureBox55.Image = D2RIC.My.Resources.Resources.HoN_Bastard_Sword
            FormMain.PictureBox56.Image = D2RIC.My.Resources.Resources.HoN_Mystic_Vestments
            FormMain.PictureBox57.Image = D2RIC.My.Resources.Resources.HoN_Riftshards
            FormMain.PictureBox58.Image = D2RIC.My.Resources.Resources._40px_Daedalus
            FormMain.PictureBox59.Image = D2RIC.My.Resources.Resources.HoN_Codex
            FormMain.PictureBox60.Image = D2RIC.My.Resources.Resources.HoN_Codex2
            FormMain.PictureBox61.Image = D2RIC.My.Resources.Resources.HoN_Codex3
            FormMain.PictureBox62.Image = D2RIC.My.Resources.Resources.HoN_Codex4
            FormMain.PictureBox63.Image = D2RIC.My.Resources.Resources.HoN_Codex5
            FormMain.PictureBox64.Image = D2RIC.My.Resources.Resources.HoN_Slayer
            FormMain.PictureBox65.Image = D2RIC.My.Resources.Resources.HoN_Shieldbreaker
            FormMain.PictureBox66.Image = D2RIC.My.Resources.Resources.HoN_Nullfire_Blade
            FormMain.PictureBox67.Image = D2RIC.My.Resources.Resources.HoN_Nullfire_Blade2
            FormMain.PictureBox68.Image = D2RIC.My.Resources.Resources.HoN_Doombringer
            FormMain.PictureBox69.Image = D2RIC.My.Resources.Resources._40px_Drum_of_Endurance
            FormMain.PictureBox70.Image = D2RIC.My.Resources.Resources.HoN_Dust_Of_Revelation
            FormMain.PictureBox71.Image = D2RIC.My.Resources.Resources.HoN_Dancing_Blade
            FormMain.PictureBox72.Image = D2RIC.My.Resources.Resources.HoN_Pickled_Brain
            FormMain.PictureBox73.Image = D2RIC.My.Resources.Resources._40px_Ethereal_Blade
            FormMain.PictureBox74.Image = D2RIC.My.Resources.Resources.HoN_Stormspirit
            FormMain.PictureBox75.Image = D2RIC.My.Resources.Resources.HoN_Frostwolfs_Skull
            FormMain.PictureBox76.Image = D2RIC.My.Resources.Resources.HoN_Winged_Courier
            FormMain.PictureBox77.Image = D2RIC.My.Resources.Resources.HoN_Tablet_of_Command
            FormMain.PictureBox78.Image = D2RIC.My.Resources.Resources.HoN_Crushing_Claws
            FormMain.PictureBox79.Image = D2RIC.My.Resources.Resources.HoN_Bound_Eye
            FormMain.PictureBox80.Image = D2RIC.My.Resources.Resources.HoN_Void_Talisman
            FormMain.PictureBox81.Image = D2RIC.My.Resources.Resources.HoN_Gloves_of_the_Swift
            FormMain.PictureBox82.Image = D2RIC.My.Resources.Resources.HoN_Alchemist_Bones
            FormMain.PictureBox83.Image = D2RIC.My.Resources.Resources.HoN_Refreshing_Ornament
            FormMain.PictureBox84.Image = D2RIC.My.Resources.Resources.HoN_Health_Potion
            FormMain.PictureBox85.Image = D2RIC.My.Resources.Resources.HoN_Behemoths_Hearth
            FormMain.PictureBox86.Image = D2RIC.My.Resources.Resources.HoN_Helm_Of_The_Victim
            FormMain.PictureBox87.Image = D2RIC.My.Resources.Resources.HoN_Whispering_Helm
            FormMain.PictureBox88.Image = D2RIC.My.Resources.Resources.HoN_Shamans_Headress
            FormMain.PictureBox89.Image = D2RIC.My.Resources.Resources.HoN_Warpcleft
            FormMain.PictureBox90.Image = D2RIC.My.Resources.Resources.HoN_Minor_Totem
            FormMain.PictureBox91.Image = D2RIC.My.Resources.Resources.HoN_Halberd
            FormMain.PictureBox92.Image = D2RIC.My.Resources.Resources.HoN_Null_Stone
            FormMain.PictureBox93.Image = D2RIC.My.Resources.Resources.HoN_Thunderclaw
            FormMain.PictureBox94.Image = D2RIC.My.Resources.Resources.HoN_Mana_Battery
            FormMain.PictureBox95.Image = D2RIC.My.Resources.Resources.HoN_Power_Supply
            FormMain.PictureBox96.Image = D2RIC.My.Resources.Resources.HoN_Geometers_Bane
            FormMain.PictureBox97.Image = D2RIC.My.Resources.Resources.HoN_Mark_Of_The_Novice
            FormMain.PictureBox98.Image = D2RIC.My.Resources.Resources.HoN_Elder_Parasite
            FormMain.PictureBox99.Image = D2RIC.My.Resources.Resources._40px_Medallion_of_Courage
            FormMain.PictureBox100.Image = D2RIC.My.Resources.Resources.HoN_Astrolabe
            FormMain.PictureBox101.Image = D2RIC.My.Resources.Resources.HoN_Warhammer
            FormMain.PictureBox102.Image = D2RIC.My.Resources.Resources.HoN_Charged_Hammer
            FormMain.PictureBox103.Image = D2RIC.My.Resources.Resources.HoN_Savage_Mace
            FormMain.PictureBox104.Image = D2RIC.My.Resources.Resources.HoN_Hungry_Spirit
            FormMain.PictureBox105.Image = D2RIC.My.Resources.Resources.HoN_Acolytes_Staff
            FormMain.PictureBox121.Image = D2RIC.My.Resources.Resources.HoN_Puzzlebox
            FormMain.PictureBox106.Image = D2RIC.My.Resources.Resources.HoN_Puzzlebox2
            FormMain.PictureBox107.Image = D2RIC.My.Resources.Resources.HoN_Puzzlebox3
            FormMain.PictureBox108.Image = D2RIC.My.Resources.Resources.HoN_Talisman_Of_Exile
            FormMain.PictureBox109.Image = D2RIC.My.Resources.Resources.HoN_Great_Arcana
            FormMain.PictureBox110.Image = D2RIC.My.Resources.Resources.HoN_Wards_of_Sight
            FormMain.PictureBox111.Image = D2RIC.My.Resources.Resources.HoN_Mighty_Blade
            FormMain.PictureBox112.Image = D2RIC.My.Resources.Resources._40px_Orb_of_Venom
            FormMain.PictureBox113.Image = D2RIC.My.Resources.Resources.HoN_Hellflower
            FormMain.PictureBox114.Image = D2RIC.My.Resources.Resources.HoN_Sustainer
            FormMain.PictureBox115.Image = D2RIC.My.Resources.Resources.HoN_Enhanced_Marchers
            FormMain.PictureBox116.Image = D2RIC.My.Resources.Resources.HoN_Barrier_Idol
            FormMain.PictureBox117.Image = D2RIC.My.Resources.Resources.HoN_Platemail
            FormMain.PictureBox118.Image = D2RIC.My.Resources.Resources.HoN_Glowstone
            FormMain.PictureBox119.Image = D2RIC.My.Resources.Resources.HoN_Iron_Shield
            FormMain.PictureBox120.Image = D2RIC.My.Resources.Resources.HoN_Steamboots_Strength
            FormMain.PictureBox122.Image = D2RIC.My.Resources.Resources.HoN_Steamstaff
            FormMain.PictureBox123.Image = D2RIC.My.Resources.Resources.HoN_Loggers_Hatchet
            FormMain.PictureBox124.Image = D2RIC.My.Resources.Resources.HoN_Mock_of_Brilliance
            FormMain.PictureBox125.Image = D2RIC.My.Resources.Resources.HoN_Axe_Of_The_Malphai
            FormMain.PictureBox126.Image = D2RIC.My.Resources.Resources.HoN_Restoration_Stone
            FormMain.PictureBox127.Image = D2RIC.My.Resources.Resources.HoN_Ring_Of_The_Teacher
            FormMain.PictureBox128.Image = D2RIC.My.Resources.Resources.HoN_Lifetube
            FormMain.PictureBox129.Image = D2RIC.My.Resources.Resources.HoN_Guardian_Ring
            FormMain.PictureBox130.Image = D2RIC.My.Resources.Resources.HoN_Trinket_Of_Restoration
            FormMain.PictureBox131.Image = D2RIC.My.Resources.Resources.HoN_Apprentices_Robe
            FormMain.PictureBox132.Image = D2RIC.My.Resources.Resources.HoN_Sword_Of_The_High
            FormMain.PictureBox133.Image = D2RIC.My.Resources.Resources.HoN_Scarab
            FormMain.PictureBox134.Image = D2RIC.My.Resources.Resources.HoN_Icebrand
            FormMain.PictureBox135.Image = D2RIC.My.Resources.Resources.HoN_Frostburn
            FormMain.PictureBox136.Image = D2RIC.My.Resources.Resources.HoN_Symbol_Of_Rage
            FormMain.PictureBox137.Image = D2RIC.My.Resources.Resources.HoN_Kuldras_Sheepstick
            FormMain.PictureBox138.Image = D2RIC.My.Resources.Resources.HoN_Wards_of_Revelation
            FormMain.PictureBox139.Image = D2RIC.My.Resources.Resources.HoN_Shroud_Of_The_Assasin
            FormMain.PictureBox140.Image = D2RIC.My.Resources.Resources.HoN_Frostfield_Plate
            FormMain.PictureBox141.Image = D2RIC.My.Resources.Resources.HoN_Brutalizer
            FormMain.PictureBox142.Image = D2RIC.My.Resources.Resources.HoN_Duck_Boots
            FormMain.PictureBox143.Image = D2RIC.My.Resources.Resources._40px_Smoke_of_Deceit
            FormMain.PictureBox144.Image = D2RIC.My.Resources.Resources.HoN_Icon_Of_The_Goddess
            FormMain.PictureBox145.Image = D2RIC.My.Resources.Resources.HoN_Blood_Chalice
            FormMain.PictureBox146.Image = D2RIC.My.Resources.Resources.HoN_Neophytes_Book
            FormMain.PictureBox147.Image = D2RIC.My.Resources.Resources.HoN_Iron_Buckler
            FormMain.PictureBox148.Image = D2RIC.My.Resources.Resources.HoN_Snake_Bracelet
            FormMain.PictureBox149.Image = D2RIC.My.Resources.Resources.HoN_Runes_Of_The_Blight
            FormMain.PictureBox150.Image = D2RIC.My.Resources.Resources.HoN_Homecoming_Stone
            FormMain.PictureBox151.Image = D2RIC.My.Resources.Resources.HoN_Blessed_Orb
            FormMain.PictureBox152.Image = D2RIC.My.Resources.Resources._40px_Urn_of_Shadows
            FormMain.PictureBox153.Image = D2RIC.My.Resources.Resources.HoN_Helm_Of_The_Black_Legion
            FormMain.PictureBox154.Image = D2RIC.My.Resources.Resources._40px_Veil_of_Discord
            FormMain.PictureBox155.Image = D2RIC.My.Resources.Resources.HoN_Beastheart
            FormMain.PictureBox156.Image = D2RIC.My.Resources.Resources.HoN_Abyssal_Skull
            FormMain.PictureBox157.Image = D2RIC.My.Resources.Resources.HoN_Manatube
            FormMain.PictureBox158.Image = D2RIC.My.Resources.Resources.HoN_Soulscream_Ring
            FormMain.PictureBox159.Image = D2RIC.My.Resources.Resources.HoN_Firebrand
            FormMain.PictureBox160.Image = D2RIC.My.Resources.Resources._40px_Abyssal_Blade
            FormMain.PictureBox161.Image = D2RIC.My.Resources.Resources._40px_Heaven_s_Halberd
            FormMain.PictureBox162.Image = D2RIC.My.Resources.Resources._40px_Ring_of_Aquila
            FormMain.PictureBox163.Image = D2RIC.My.Resources.Resources._40px_Rod_of_Atos
            FormMain.PictureBox164.Image = D2RIC.My.Resources.Resources.HoN_Striders
        Else
            'Change Items Icons to DotA 2
            FormMain.PictureBox42.Image = D2RIC.My.Resources.Resources._40px_Blink_Dagger
            FormMain.PictureBox41.Image = D2RIC.My.Resources.Resources._40px_Blades_of_Attack
            FormMain.PictureBox31.Image = D2RIC.My.Resources.Resources._40px_Aghanim_s_Scepter
            FormMain.PictureBox32.Image = D2RIC.My.Resources.Resources._40px_Animal_Courier
            FormMain.PictureBox33.Image = D2RIC.My.Resources.Resources._40px_Arcane_Boots
            FormMain.PictureBox34.Image = D2RIC.My.Resources.Resources._40px_Armlet
            FormMain.PictureBox35.Image = D2RIC.My.Resources.Resources._40px_Assault_Cuirass
            FormMain.PictureBox36.Image = D2RIC.My.Resources.Resources._40px_Battle_Fury
            FormMain.PictureBox37.Image = D2RIC.My.Resources.Resources._40px_Belt_of_Strength
            FormMain.PictureBox38.Image = D2RIC.My.Resources.Resources._40px_Black_King_Bar
            FormMain.PictureBox39.Image = D2RIC.My.Resources.Resources._40px_Blade_Mail
            FormMain.PictureBox40.Image = D2RIC.My.Resources.Resources._40px_Blade_of_Alacrity
            FormMain.PictureBox43.Image = D2RIC.My.Resources.Resources._40px_Bloodstone
            FormMain.PictureBox44.Image = D2RIC.My.Resources.Resources._40px_Boots_of_Elvenskin
            FormMain.PictureBox45.Image = D2RIC.My.Resources.Resources._40px_Boots_of_Speed
            FormMain.PictureBox46.Image = D2RIC.My.Resources.Resources._40px_Boots_of_Travel
            FormMain.PictureBox47.Image = D2RIC.My.Resources.Resources._40px_Bottle
            FormMain.PictureBox48.Image = D2RIC.My.Resources.Resources._40px_Bracer
            FormMain.PictureBox49.Image = D2RIC.My.Resources.Resources._40px_Broadsword
            FormMain.PictureBox50.Image = D2RIC.My.Resources.Resources._40px_Buckler
            FormMain.PictureBox51.Image = D2RIC.My.Resources.Resources._40px_Butterfly
            FormMain.PictureBox52.Image = D2RIC.My.Resources.Resources._40px_Chainmail
            FormMain.PictureBox53.Image = D2RIC.My.Resources.Resources._40px_Circlet
            FormMain.PictureBox54.Image = D2RIC.My.Resources.Resources._40px_Clarity
            FormMain.PictureBox55.Image = D2RIC.My.Resources.Resources._40px_Claymore
            FormMain.PictureBox56.Image = D2RIC.My.Resources.Resources._40px_Cloak
            FormMain.PictureBox57.Image = D2RIC.My.Resources.Resources._40px_Crystalys
            FormMain.PictureBox58.Image = D2RIC.My.Resources.Resources._40px_Daedalus
            FormMain.PictureBox59.Image = D2RIC.My.Resources.Resources._40px_Dagon
            FormMain.PictureBox60.Image = D2RIC.My.Resources.Resources._40px_Dagon2
            FormMain.PictureBox61.Image = D2RIC.My.Resources.Resources._40px_Dagon3
            FormMain.PictureBox62.Image = D2RIC.My.Resources.Resources._40px_Dagon4
            FormMain.PictureBox63.Image = D2RIC.My.Resources.Resources._40px_Dagon5
            FormMain.PictureBox64.Image = D2RIC.My.Resources.Resources._40px_Demon_Edge
            FormMain.PictureBox65.Image = D2RIC.My.Resources.Resources._40px_Desolator
            FormMain.PictureBox66.Image = D2RIC.My.Resources.Resources._40px_Diffusal_Blade
            FormMain.PictureBox67.Image = D2RIC.My.Resources.Resources._40px_Diffusal_Blade2
            FormMain.PictureBox68.Image = D2RIC.My.Resources.Resources._40px_Divine_Rapier
            FormMain.PictureBox69.Image = D2RIC.My.Resources.Resources._40px_Drum_of_Endurance
            FormMain.PictureBox70.Image = D2RIC.My.Resources.Resources._40px_Dust_of_Appearance
            FormMain.PictureBox71.Image = D2RIC.My.Resources.Resources._40px_Eaglesong
            FormMain.PictureBox72.Image = D2RIC.My.Resources.Resources._40px_Energy_Booster
            FormMain.PictureBox73.Image = D2RIC.My.Resources.Resources._40px_Ethereal_Blade
            FormMain.PictureBox74.Image = D2RIC.My.Resources.Resources._40px_Eul_s_Scepter_of_Divinity
            FormMain.PictureBox75.Image = D2RIC.My.Resources.Resources._40px_Eye_of_Skadi
            FormMain.PictureBox76.Image = D2RIC.My.Resources.Resources._40px_Flying_Courier
            FormMain.PictureBox77.Image = D2RIC.My.Resources.Resources._40px_Force_Staff
            FormMain.PictureBox78.Image = D2RIC.My.Resources.Resources._40px_Gauntlets_of_Strength
            FormMain.PictureBox79.Image = D2RIC.My.Resources.Resources._40px_Gem_of_True_Sight
            FormMain.PictureBox80.Image = D2RIC.My.Resources.Resources._40px_Ghost_Scepter
            FormMain.PictureBox81.Image = D2RIC.My.Resources.Resources._40px_Gloves_of_Haste
            FormMain.PictureBox82.Image = D2RIC.My.Resources.Resources._40px_Hand_of_Midas
            FormMain.PictureBox83.Image = D2RIC.My.Resources.Resources._40px_Headdress
            FormMain.PictureBox84.Image = D2RIC.My.Resources.Resources._40px_Healing_Salve
            FormMain.PictureBox85.Image = D2RIC.My.Resources.Resources._40px_Heart_of_Tarrasque
            FormMain.PictureBox86.Image = D2RIC.My.Resources.Resources._40px_Helm_of_Iron_Will
            FormMain.PictureBox87.Image = D2RIC.My.Resources.Resources._40px_Helm_of_the_Dominator
            FormMain.PictureBox88.Image = D2RIC.My.Resources.Resources._40px_Hood_of_Defiance
            FormMain.PictureBox89.Image = D2RIC.My.Resources.Resources._40px_Hyperstone
            FormMain.PictureBox90.Image = D2RIC.My.Resources.Resources._40px_Iron_Branch
            FormMain.PictureBox91.Image = D2RIC.My.Resources.Resources._40px_Javelin
            FormMain.PictureBox92.Image = D2RIC.My.Resources.Resources._40px_Linken_s_Sphere
            FormMain.PictureBox93.Image = D2RIC.My.Resources.Resources._40px_Maelstrom
            FormMain.PictureBox94.Image = D2RIC.My.Resources.Resources._40px_Magic_Stick
            FormMain.PictureBox95.Image = D2RIC.My.Resources.Resources._40px_Magic_Wand
            FormMain.PictureBox96.Image = D2RIC.My.Resources.Resources._40px_Manta_Style
            FormMain.PictureBox97.Image = D2RIC.My.Resources.Resources._40px_Mantle_of_Intelligence
            FormMain.PictureBox98.Image = D2RIC.My.Resources.Resources._40px_Mask_of_Madness
            FormMain.PictureBox99.Image = D2RIC.My.Resources.Resources._40px_Medallion_of_Courage
            FormMain.PictureBox100.Image = D2RIC.My.Resources.Resources._40px_Mekansm
            FormMain.PictureBox101.Image = D2RIC.My.Resources.Resources._40px_Mithril_Hammer
            FormMain.PictureBox102.Image = D2RIC.My.Resources.Resources._40px_Mjollnir
            FormMain.PictureBox103.Image = D2RIC.My.Resources.Resources._40px_Monkey_King_Bar
            FormMain.PictureBox104.Image = D2RIC.My.Resources.Resources._40px_Morbid_Mask
            FormMain.PictureBox105.Image = D2RIC.My.Resources.Resources._40px_Mystic_Staff
            FormMain.PictureBox121.Image = D2RIC.My.Resources.Resources._40px_Necronomicon
            FormMain.PictureBox106.Image = D2RIC.My.Resources.Resources._40px_Necronomicon2
            FormMain.PictureBox107.Image = D2RIC.My.Resources.Resources._40px_Necronomicon3
            FormMain.PictureBox108.Image = D2RIC.My.Resources.Resources._40px_Null_Talisman
            FormMain.PictureBox109.Image = D2RIC.My.Resources.Resources._40px_Oblivion_Staff
            FormMain.PictureBox110.Image = D2RIC.My.Resources.Resources._40px_Observer_Ward
            FormMain.PictureBox111.Image = D2RIC.My.Resources.Resources._40px_Ogre_Club
            FormMain.PictureBox112.Image = D2RIC.My.Resources.Resources._40px_Orb_of_Venom
            FormMain.PictureBox113.Image = D2RIC.My.Resources.Resources._40px_Orchid_Malevolence
            FormMain.PictureBox114.Image = D2RIC.My.Resources.Resources._40px_Perseverance
            FormMain.PictureBox115.Image = D2RIC.My.Resources.Resources._40px_Phase_Boots
            FormMain.PictureBox116.Image = D2RIC.My.Resources.Resources._40px_Pipe_of_Insight
            FormMain.PictureBox117.Image = D2RIC.My.Resources.Resources._40px_Platemail
            FormMain.PictureBox118.Image = D2RIC.My.Resources.Resources._40px_Point_Booster
            FormMain.PictureBox119.Image = D2RIC.My.Resources.Resources._40px_Poor_Man_s_Shield
            FormMain.PictureBox120.Image = D2RIC.My.Resources.Resources._40px_Power_Treads
            FormMain.PictureBox122.Image = D2RIC.My.Resources.Resources._40px_Quarterstaff
            FormMain.PictureBox123.Image = D2RIC.My.Resources.Resources._40px_Quelling_Blade
            FormMain.PictureBox124.Image = D2RIC.My.Resources.Resources._40px_Radiance
            FormMain.PictureBox125.Image = D2RIC.My.Resources.Resources._40px_Reaver
            FormMain.PictureBox126.Image = D2RIC.My.Resources.Resources._40px_Refresher_Orb
            FormMain.PictureBox127.Image = D2RIC.My.Resources.Resources._40px_Ring_of_Basilius
            FormMain.PictureBox128.Image = D2RIC.My.Resources.Resources._40px_Ring_of_Health
            FormMain.PictureBox129.Image = D2RIC.My.Resources.Resources._40px_Ring_of_Protection
            FormMain.PictureBox130.Image = D2RIC.My.Resources.Resources._40px_Ring_of_Regen
            FormMain.PictureBox131.Image = D2RIC.My.Resources.Resources._40px_Robe_of_the_Magi
            FormMain.PictureBox132.Image = D2RIC.My.Resources.Resources._40px_Sacred_Relic
            FormMain.PictureBox133.Image = D2RIC.My.Resources.Resources._40px_Sage_s_Mask
            FormMain.PictureBox134.Image = D2RIC.My.Resources.Resources._40px_Sange
            FormMain.PictureBox135.Image = D2RIC.My.Resources.Resources._40px_Sange_and_Yasha
            FormMain.PictureBox136.Image = D2RIC.My.Resources.Resources._40px_Satanic
            FormMain.PictureBox137.Image = D2RIC.My.Resources.Resources._40px_Scythe_of_Vyse
            FormMain.PictureBox138.Image = D2RIC.My.Resources.Resources._40px_Sentry_Ward
            FormMain.PictureBox139.Image = D2RIC.My.Resources.Resources._40px_Shadow_Blade
            FormMain.PictureBox140.Image = D2RIC.My.Resources.Resources._40px_Shiva_s_Guard
            FormMain.PictureBox141.Image = D2RIC.My.Resources.Resources._40px_Skull_Basher
            FormMain.PictureBox142.Image = D2RIC.My.Resources.Resources._40px_Slippers_of_Agility
            FormMain.PictureBox143.Image = D2RIC.My.Resources.Resources._40px_Smoke_of_Deceit
            FormMain.PictureBox144.Image = D2RIC.My.Resources.Resources._40px_Soul_Booster
            FormMain.PictureBox145.Image = D2RIC.My.Resources.Resources._40px_Soul_Ring
            FormMain.PictureBox146.Image = D2RIC.My.Resources.Resources._40px_Staff_of_Wizardry
            FormMain.PictureBox147.Image = D2RIC.My.Resources.Resources._40px_Stout_Shield
            FormMain.PictureBox148.Image = D2RIC.My.Resources.Resources._40px_Talisman_of_Evasion
            FormMain.PictureBox149.Image = D2RIC.My.Resources.Resources._40px_Tango
            FormMain.PictureBox150.Image = D2RIC.My.Resources.Resources._40px_Town_Portal_Scroll
            FormMain.PictureBox151.Image = D2RIC.My.Resources.Resources._40px_Ultimate_Orb
            FormMain.PictureBox152.Image = D2RIC.My.Resources.Resources._40px_Urn_of_Shadows
            FormMain.PictureBox153.Image = D2RIC.My.Resources.Resources._40px_Vanguard
            FormMain.PictureBox154.Image = D2RIC.My.Resources.Resources._40px_Veil_of_Discord
            FormMain.PictureBox155.Image = D2RIC.My.Resources.Resources._40px_Vitality_Booster
            FormMain.PictureBox156.Image = D2RIC.My.Resources.Resources._40px_Vladmir_s_Offering
            FormMain.PictureBox157.Image = D2RIC.My.Resources.Resources._40px_Void_Stone
            FormMain.PictureBox158.Image = D2RIC.My.Resources.Resources._40px_Wraith_Band
            FormMain.PictureBox159.Image = D2RIC.My.Resources.Resources._40px_Yasha
            FormMain.PictureBox160.Image = D2RIC.My.Resources.Resources._40px_Abyssal_Blade
            FormMain.PictureBox161.Image = D2RIC.My.Resources.Resources._40px_Heaven_s_Halberd
            FormMain.PictureBox162.Image = D2RIC.My.Resources.Resources._40px_Ring_of_Aquila
            FormMain.PictureBox163.Image = D2RIC.My.Resources.Resources._40px_Rod_of_Atos
            FormMain.PictureBox164.Image = D2RIC.My.Resources.Resources._40px_Tranquil_Boots
        End If
        Itembuild.ClearSingle()
        FormMain.ListBox1.ClearSelected()
        My.Settings.item_icons = FormMain.ComboBoxItemIcons.Text
        My.Settings.Save()
    End Sub
End Class
