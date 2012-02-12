Imports System.Security.Cryptography, System.Net

Public Class FormMain

    Dim Selected_Hero, NeuerText As String
    Private m_MouseIsDown As Boolean

    Private Sub FormMain_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.Save()
        End
    End Sub

    Private Sub FormMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Item1.AllowDrop = True
        Item2.AllowDrop = True
        Item3.AllowDrop = True
        Item4.AllowDrop = True
        Item5.AllowDrop = True
        Item6.AllowDrop = True
        Item7.AllowDrop = True
        Item8.AllowDrop = True
        Item9.AllowDrop = True
        Item10.AllowDrop = True
        Item11.AllowDrop = True
        Item12.AllowDrop = True
        Item13.AllowDrop = True
        Item14.AllowDrop = True
        Item15.AllowDrop = True
        Item16.AllowDrop = True
        Item17.AllowDrop = True
        Item18.AllowDrop = True
        Item19.AllowDrop = True
        Item20.AllowDrop = True
        Item21.AllowDrop = True
        Item22.AllowDrop = True
        Item23.AllowDrop = True
        Item24.AllowDrop = True
        Item25.AllowDrop = True
        Item26.AllowDrop = True
        Item27.AllowDrop = True
        Item28.AllowDrop = True
        Item29.AllowDrop = True
        Item30.AllowDrop = True
        Item31.AllowDrop = True
        Item32.AllowDrop = True
        Item33.AllowDrop = True
        Item34.AllowDrop = True
        Item35.AllowDrop = True
        Item36.AllowDrop = True
        Item37.AllowDrop = True
        Item38.AllowDrop = True
        Item39.AllowDrop = True
        ButtonSave.Enabled = False
        With ToolTip1
            .SetToolTip(Item1, "none")
            .SetToolTip(Item2, "none")
            .SetToolTip(Item3, "none")
            .SetToolTip(Item4, "none")
            .SetToolTip(Item5, "none")
            .SetToolTip(Item6, "none")
            .SetToolTip(Item7, "none")
            .SetToolTip(Item8, "none")
            .SetToolTip(Item9, "none")
            .SetToolTip(Item10, "none")
            .SetToolTip(Item11, "none")
            .SetToolTip(Item12, "none")
            .SetToolTip(Item13, "none")
            .SetToolTip(Item14, "none")
            .SetToolTip(Item15, "none")
            .SetToolTip(Item16, "none")
            .SetToolTip(Item17, "none")
            .SetToolTip(Item18, "none")
            .SetToolTip(Item19, "none")
            .SetToolTip(Item20, "none")
            .SetToolTip(Item21, "none")
            .SetToolTip(Item22, "none")
            .SetToolTip(Item23, "none")
            .SetToolTip(Item24, "none")
            .SetToolTip(Item25, "none")
            .SetToolTip(Item26, "none")
            .SetToolTip(Item27, "none")
            .SetToolTip(Item28, "none")
            .SetToolTip(Item29, "none")
            .SetToolTip(Item30, "none")
            .SetToolTip(Item31, "none")
            .SetToolTip(Item32, "none")
            .SetToolTip(Item33, "none")
            .SetToolTip(Item34, "none")
            .SetToolTip(Item35, "none")
            .SetToolTip(Item36, "none")
            .SetToolTip(Item37, "none")
            .SetToolTip(Item38, "none")
            .SetToolTip(Item39, "none")
            .SetToolTip(PictureBox31, "Aghanim's Scepter" + vbNewLine + vbNewLine + "+10 All Attributes" + vbNewLine + "+200 HP" + vbNewLine + "+150 Mana" + vbNewLine + "Ultimate Upgrade (passive)")
            .SetToolTip(PictureBox32, "Animal Courier" + vbNewLine + vbNewLine + "Summon Animal Courier")
            .SetToolTip(PictureBox33, "Arcane Boots" + vbNewLine + vbNewLine + "+65 Movement Speed " + vbNewLine + "+250 Mana" + vbNewLine + "Replenish Mana (active)")
            .SetToolTip(PictureBox34, "Armlet" + vbNewLine + vbNewLine + "+9 Damage" + vbNewLine + "+15 Attack Speed" + vbNewLine + "+5 Armor" + vbNewLine + "+5 HP/sec Regeneration" + vbNewLine + "Unholy Strength (active)")
            .SetToolTip(PictureBox35, "Assault Cuirass" + vbNewLine + vbNewLine + "+10 Armor" + vbNewLine + "+35 Attack Speed" + vbNewLine + "Positive Armor (Aura)" + vbNewLine + "Negative Armor (Aura)" + vbNewLine + "Attack Speed (Aura)")
            .SetToolTip(PictureBox36, "Battle Fury" + vbNewLine + vbNewLine + "+65 Damage" + vbNewLine + "+6 HP/sec Regeneration" + vbNewLine + "+150% Mana Regeneration" + vbNewLine + "Cleave")
            .SetToolTip(PictureBox37, "Belt of Strength" + vbNewLine + vbNewLine + "+6 Strength")
            .SetToolTip(PictureBox38, "Black King Bar" + vbNewLine + vbNewLine + "+10 Strength" + vbNewLine + "+24 Damage" + vbNewLine + "Avatar (active)")
            .SetToolTip(PictureBox39, "Blade Mail" + vbNewLine + vbNewLine + "+22 Damage" + vbNewLine + "+5 Armor" + vbNewLine + "+10 Intelligence" + vbNewLine + "Damage Return (active)")
            .SetToolTip(PictureBox40, "Blade of Alacrity" + vbNewLine + vbNewLine + "+10 Agility")
            .SetToolTip(PictureBox41, "Blades of Attack" + vbNewLine + vbNewLine + "+9 Damage")
            .SetToolTip(PictureBox42, "Blink Dagger" + vbNewLine + vbNewLine + "Blink")
            .SetToolTip(PictureBox43, "Bloodstone" + vbNewLine + vbNewLine + "+500 HP" + vbNewLine + "+400 Mana" + vbNewLine + "+8 HP/sec Regeneration" + vbNewLine + "+200% Mana Regeneration" + vbNewLine + "Bloodpact" + vbNewLine + "5 Charges")
            .SetToolTip(PictureBox44, "Boots of Elvenskin" + vbNewLine + vbNewLine + "+6 Agility")
            .SetToolTip(PictureBox45, "Boots of Speed" + vbNewLine + vbNewLine + "+55 Movement Speed")
            .SetToolTip(PictureBox46, "Boots of Travel" + vbNewLine + vbNewLine + "+95 Movement Speed" + vbNewLine + "Teleport (active)")
            .SetToolTip(PictureBox47, "Bottle" + vbNewLine + vbNewLine + "Regenerate" + vbNewLine + "Rune Capture")
            .SetToolTip(PictureBox48, "Bracer" + vbNewLine + vbNewLine + "+3 Damage" + vbNewLine + "+6 Strength" + vbNewLine + "+3 Agility" + vbNewLine + "+3 Intelligence")
            .SetToolTip(PictureBox49, "Broadsword" + vbNewLine + vbNewLine + "+18 Damage")
            .SetToolTip(PictureBox50, "Buckler" + vbNewLine + vbNewLine + "+5 Armor" + vbNewLine + "+2 All Attributes" + vbNewLine + "Armor Bonus (active)")
            .SetToolTip(PictureBox51, "Butterfly" + vbNewLine + vbNewLine + "+30 Agility" + vbNewLine + "+30 Damage" + vbNewLine + "30% Evasion" + vbNewLine + "+30 Attack Speed")
            .SetToolTip(PictureBox52, "Chainmail" + vbNewLine + vbNewLine + "+5 Armor")
            .SetToolTip(PictureBox53, "Circlet" + vbNewLine + vbNewLine + "+2 All Attributes")
            .SetToolTip(PictureBox54, "Clarity" + vbNewLine + vbNewLine + "Regenerate Mana" + vbNewLine + "1 Charges")
            .SetToolTip(PictureBox55, "Claymore" + vbNewLine + vbNewLine + "+21 Damage")
            .SetToolTip(PictureBox56, "Cloak" + vbNewLine + vbNewLine + "+15% Magic Resistance")
            .SetToolTip(PictureBox57, "Crystalys" + vbNewLine + vbNewLine + "+35 Damage" + vbNewLine + "Critical Strike")
            .SetToolTip(PictureBox58, "Daedalus" + vbNewLine + vbNewLine + "+81 Damage" + vbNewLine + "Critical Strike")
            .SetToolTip(PictureBox59, "Dagon 1" + vbNewLine + vbNewLine + "+13 Intelligence" + vbNewLine + "+3 All Attributes" + vbNewLine + "+9 Damage" + vbNewLine + "Energy Burst (active)")
            .SetToolTip(PictureBox60, "Dagon 2" + vbNewLine + vbNewLine + "+15 Intelligence" + vbNewLine + "+3 All Attributes" + vbNewLine + "+9 Damage" + vbNewLine + "Energy Burst (active)")
            .SetToolTip(PictureBox61, "Dagon 3" + vbNewLine + vbNewLine + "+17 Intelligence" + vbNewLine + "+3 All Attributes" + vbNewLine + "+9 Damage" + vbNewLine + "Energy Burst (active)")
            .SetToolTip(PictureBox62, "Dagon 4" + vbNewLine + vbNewLine + "+19 Intelligence" + vbNewLine + "+3 All Attributes" + vbNewLine + "+9 Damage" + vbNewLine + "Energy Burst (active)")
            .SetToolTip(PictureBox63, "Dagon 5" + vbNewLine + vbNewLine + "+21 Intelligence" + vbNewLine + "+3 All Attributes" + vbNewLine + "+9 Damage" + vbNewLine + "Energy Burst (active)")
            .SetToolTip(PictureBox64, "Demon Edge" + vbNewLine + vbNewLine + "+46 Damage")
            .SetToolTip(PictureBox65, "Desolator" + vbNewLine + vbNewLine + "+60 Damage" + vbNewLine + "Corruption")
            .SetToolTip(PictureBox66, "Diffusal Blade 1" + vbNewLine + vbNewLine + "+22 Agility" + vbNewLine + "+6 Intelligence" + vbNewLine + "Feedback" + vbNewLine + "Purge (active)" + vbNewLine + "8 Charges")
            .SetToolTip(PictureBox67, "Diffusal Blade 2" + vbNewLine + vbNewLine + "+26 Agility" + vbNewLine + "+10 Intelligence" + vbNewLine + "Feedback" + vbNewLine + "Purge (active)" + vbNewLine + "8 Charges")
            .SetToolTip(PictureBox68, "Divine Rapier" + vbNewLine + vbNewLine + "+250 Damage")
            .SetToolTip(PictureBox69, "Drum of Endurance" + vbNewLine + vbNewLine + "+9 All Attributes" + vbNewLine + "+9 Damage" + vbNewLine + "Endurance Aura" + vbNewLine + "Endurance (active)" + vbNewLine + "4 Charges")
            .SetToolTip(PictureBox70, "Dust of Appearance" + vbNewLine + vbNewLine + "Reveal" + vbNewLine + "2 Charges")
            .SetToolTip(PictureBox71, "Eaglesong" + vbNewLine + vbNewLine + "+25 Agility")
            .SetToolTip(PictureBox72, "Energy Booster" + vbNewLine + vbNewLine + "+250 Mana")
            .SetToolTip(PictureBox73, "Ethereal Blade" + vbNewLine + vbNewLine + "+40 Agility" + vbNewLine + "+10 Strength" + vbNewLine + "+10 Intelligence" + vbNewLine + "Ether Blast (active)")
            .SetToolTip(PictureBox74, "Eul's Scepter of Divinity" + vbNewLine + vbNewLine + "+10 Intelligence" + vbNewLine + "+150% Mana Regeneration" + vbNewLine + "+25 Movement Speed" + vbNewLine + "Cyclone (active)")
            .SetToolTip(PictureBox75, "Eye of Skadi" + vbNewLine + vbNewLine + "+25 All Attributes" + vbNewLine + "+200 HP" + vbNewLine + "+150 Mana" + vbNewLine + "Cold Attack")
            .SetToolTip(PictureBox76, "Flying Courier" + vbNewLine + vbNewLine + "Summon Flying Courier")
            .SetToolTip(PictureBox77, "Force Staff" + vbNewLine + vbNewLine + "+10 Intelligence" + vbNewLine + "+10 Damage" + vbNewLine + "+10 Attack Speed" + vbNewLine + "Force (active)")
            .SetToolTip(PictureBox78, "Gauntlets of Strength" + vbNewLine + vbNewLine + "+3 Strength")
            .SetToolTip(PictureBox79, "Gem of True Sight" + vbNewLine + vbNewLine + "True Sight")
            .SetToolTip(PictureBox80, "Ghost Scepter" + vbNewLine + vbNewLine + "+7 All Attributes" + vbNewLine + "Ghost Form (active)")
            .SetToolTip(PictureBox81, "Gloves of Haste" + vbNewLine + vbNewLine + "+15 Attack Speed")
            .SetToolTip(PictureBox82, "Hand of Midas" + vbNewLine + vbNewLine + "+30 Attack Speed" + vbNewLine + "Transmute (active)")
            .SetToolTip(PictureBox83, "Headdress" + vbNewLine + vbNewLine + "+2 All Attributes" + vbNewLine + "Regeneration Aura")
            .SetToolTip(PictureBox84, "Healing Salve" + vbNewLine + vbNewLine + "Regenerate Health" + vbNewLine + "1 Charges")
            .SetToolTip(PictureBox85, "Heart of Tarrasque" + vbNewLine + vbNewLine + "+40 Strength" + vbNewLine + "+300 HP" + vbNewLine + "Health Regeneration")
            .SetToolTip(PictureBox86, "Helm of Iron Will" + vbNewLine + vbNewLine + "+5 Armor" + vbNewLine + "+3 HP/sec Regeneration")
            .SetToolTip(PictureBox87, "Helm of the Dominator" + vbNewLine + vbNewLine + "+20 Damage" + vbNewLine + "+5 Armor" + vbNewLine + "+15% Lifesteal" + vbNewLine + "Dominate (active)")
            .SetToolTip(PictureBox88, "Hood of Defiance" + vbNewLine + vbNewLine + "+30% Magic Resistance" + vbNewLine + "+8 HP/sec Regeneration")
            .SetToolTip(PictureBox89, "Hyperstone" + vbNewLine + vbNewLine + "+55 Attack Speed")
            .SetToolTip(PictureBox90, "Iron Branch" + vbNewLine + vbNewLine + "+1 All Attributes")
            .SetToolTip(PictureBox91, "Javelin" + vbNewLine + vbNewLine + "+21 Damage" + vbNewLine + "20% chance to deal 40 bonus damage")
            .SetToolTip(PictureBox92, "Linken's Sphere" + vbNewLine + vbNewLine + "+15 All Attributes" + vbNewLine + "+6 HP/sec regeneration" + vbNewLine + "+150% Mana Regeneration" + vbNewLine + "Spell Block")
            .SetToolTip(PictureBox93, "Maelstrom" + vbNewLine + vbNewLine + "+24 Damage" + vbNewLine + "+25 Attack Speed" + vbNewLine + "Chain Lightning")
            .SetToolTip(PictureBox94, "Magic Stick" + vbNewLine + vbNewLine + "Energy Charge (active)")
            .SetToolTip(PictureBox95, "Magic Wand" + vbNewLine + vbNewLine + "+3 All Attributes" + vbNewLine + "Energy Charge (active)")
            .SetToolTip(PictureBox96, "Manta Style" + vbNewLine + vbNewLine + "+26 Agility" + vbNewLine + "+10 Strength" + vbNewLine + "+10 Intelligence" + vbNewLine + "+15 Attack Speed" + vbNewLine + "+10% Movement Speed" + vbNewLine + "Mirror Image (active)")
            .SetToolTip(PictureBox97, "Mantle of Intelligence" + vbNewLine + vbNewLine + "+3 Intelligence")
            .SetToolTip(PictureBox98, "Mask of Madness" + vbNewLine + vbNewLine + "+17% Lifesteal" + vbNewLine + "Berserk (active)")
            .SetToolTip(PictureBox99, "Medallion of Courage" + vbNewLine + vbNewLine + "+6 Armor" + vbNewLine + "+50% Mana Regeneration" + vbNewLine + "Valor (active)")
            .SetToolTip(PictureBox100, "Mekansm" + vbNewLine + vbNewLine + "+5 All Attributes" + vbNewLine + "+5 Armor" + vbNewLine + "Mekansm Aura" + vbNewLine + "Restore (active)")
            .SetToolTip(PictureBox101, "Mithril Hammer" + vbNewLine + vbNewLine + "+24 Damage")
            .SetToolTip(PictureBox102, "Mjollnir" + vbNewLine + vbNewLine + "+80 Attack Speed" + vbNewLine + "+24 Damage" + vbNewLine + "Chain Lightning" + vbNewLine + "Static Charge (active)")
            .SetToolTip(PictureBox103, "Monkey King Bar" + vbNewLine + vbNewLine + "+88 Damage" + vbNewLine + "+15 Attack Speed" + vbNewLine + "True Strike" + vbNewLine + "Mini-Bash")
            .SetToolTip(PictureBox104, "Morbid Mask" + vbNewLine + vbNewLine + "+15% Lifesteal")
            .SetToolTip(PictureBox105, "Mystic Staff" + vbNewLine + vbNewLine + "+25 Intelligence")
            .SetToolTip(PictureBox121, "Necronomicon 1" + vbNewLine + vbNewLine + "+15 Intelligence" + vbNewLine + "+8 Strength" + vbNewLine + "Demonic Summoning (active)")
            .SetToolTip(PictureBox106, "Necronomicon 2" + vbNewLine + vbNewLine + "+21 Intelligence" + vbNewLine + "+12 Strength" + vbNewLine + "Demonic Summoning (active)")
            .SetToolTip(PictureBox107, "Necronomicon 3" + vbNewLine + vbNewLine + "+24 Intelligence" + vbNewLine + "+16 Strength" + vbNewLine + "Demonic Summoning (active)")
            .SetToolTip(PictureBox108, "Null Talisman" + vbNewLine + vbNewLine + "+3 Damage" + vbNewLine + "+6 Intelligence" + vbNewLine + "+3 Strength" + vbNewLine + "+3 Agility")
            .SetToolTip(PictureBox109, "Oblivion Staff" + vbNewLine + vbNewLine + "+6 Intelligence" + vbNewLine + "+10 Attack Speed" + vbNewLine + "+15 Damage" + vbNewLine + "+75% Mana Regeneration")
            .SetToolTip(PictureBox110, "Observer Ward" + vbNewLine + vbNewLine + "Place Ward" + vbNewLine + "2 Charges")
            .SetToolTip(PictureBox111, "Ogre Club" + vbNewLine + vbNewLine + "+10 Strength")
            .SetToolTip(PictureBox112, "Orb of Venom" + vbNewLine + vbNewLine + "Poison Attack")
            .SetToolTip(PictureBox113, "Orchid Malevolence" + vbNewLine + vbNewLine + "+20 Intelligence" + vbNewLine + "+30 Attack Speed" + vbNewLine + "+45 Damage" + vbNewLine + "+225% Mana Regeneration" + vbNewLine + "Soul Burn (active)")
            .SetToolTip(PictureBox114, "Perseverance" + vbNewLine + vbNewLine + "+10 Damage" + vbNewLine + "+5 HP/sec Regeneration" + vbNewLine + "+125% Mana Regeneration")
            .SetToolTip(PictureBox115, "Phase Boots" + vbNewLine + vbNewLine + "+60 Movement Speed" + vbNewLine + "+24 damage" + vbNewLine + "Phase (active)")
            .SetToolTip(PictureBox116, "Pipe of Insight" + vbNewLine + vbNewLine + "+11 HP/sec Regeneration" + vbNewLine + "+30% Magic Resistance" + vbNewLine + "Barrier (active)")
            .SetToolTip(PictureBox117, "Platemail" + vbNewLine + vbNewLine + "+10 Armor")
            .SetToolTip(PictureBox118, "Point Booster" + vbNewLine + vbNewLine + "+200 HP" + vbNewLine + "+150 Mana")
            .SetToolTip(PictureBox119, "Poor Man's Shield" + vbNewLine + vbNewLine + "+6 Agility" + vbNewLine + "Damage Block")
            .SetToolTip(PictureBox120, "Power Treads" + vbNewLine + vbNewLine + "+60 Move Speed" + vbNewLine + "+8 Selected Attribute" + vbNewLine + "+25 Attack Speed" + vbNewLine + "Switch Attribute (active)")
            .SetToolTip(PictureBox122, "Quarterstaff" + vbNewLine + vbNewLine + "+10 Damage" + vbNewLine + "+10 Attack Speed")
            .SetToolTip(PictureBox123, "Quelling Blade" + vbNewLine + vbNewLine + "Demolish" + vbNewLine + "Tree Chop (active)")
            .SetToolTip(PictureBox124, "Radiance" + vbNewLine + vbNewLine + "+60 Damage" + vbNewLine + "Burn Damage")
            .SetToolTip(PictureBox125, "Reaver" + vbNewLine + vbNewLine + "+25 Strength")
            .SetToolTip(PictureBox126, "Refresher Orb" + vbNewLine + vbNewLine + "+5 HP/Sec Regeneration" + vbNewLine + "+200% Mana Regeneration" + vbNewLine + "+40 Damage" + vbNewLine + "Reset Cooldowns (active)")
            .SetToolTip(PictureBox127, "Ring of Basilius" + vbNewLine + vbNewLine + "+6 Damage" + vbNewLine + "+1 Armor" + vbNewLine + "Mana Aura" + vbNewLine + "Armor Aura")
            .SetToolTip(PictureBox128, "Ring of Health" + vbNewLine + vbNewLine + "+5 HP/sec Regeneration")
            .SetToolTip(PictureBox129, "Ring of Protection" + vbNewLine + vbNewLine + "+2 Armor")
            .SetToolTip(PictureBox130, "Ring of Regen" + vbNewLine + vbNewLine + "+2 HP/sec Regeneration")
            .SetToolTip(PictureBox131, "Robe of the Magi" + vbNewLine + vbNewLine + "+6 Intelligence")
            .SetToolTip(PictureBox132, "Sacred Relic" + vbNewLine + vbNewLine + "+60 Damage")
            .SetToolTip(PictureBox133, "Sage's Mask" + vbNewLine + vbNewLine + "+50% Mana Regeneration")
            .SetToolTip(PictureBox134, "Sange" + vbNewLine + vbNewLine + "+16 Strength" + vbNewLine + "+10 Damage" + vbNewLine + "Lesser Maim")
            .SetToolTip(PictureBox135, "Sange and Yasha" + vbNewLine + vbNewLine + "+16 Agility" + vbNewLine + "+16 Strength" + vbNewLine + "+12 Damage" + vbNewLine + "+15 Attack Speed" + vbNewLine + "+12% Movement Speed" + vbNewLine + "Greater Maim")
            .SetToolTip(PictureBox136, "Satanic" + vbNewLine + vbNewLine + "+25 Strength" + vbNewLine + "+20 Damage" + vbNewLine + "+5 Armor" + vbNewLine + "Lifesteal" + vbNewLine + "Unholy Rage (active)")
            .SetToolTip(PictureBox137, "Scythe of Vyse" + vbNewLine + vbNewLine + "+35 Intelligence" + vbNewLine + "+10 Strength" + vbNewLine + "+10 Agility" + vbNewLine + "+150% Mana Regeneration" + vbNewLine + "Hex (active)")
            .SetToolTip(PictureBox138, "Sentry Ward" + vbNewLine + vbNewLine + "Place Ward" + vbNewLine + "950 Radius True Sight" + vbNewLine + "2 Charges")
            .SetToolTip(PictureBox139, "Shadow Blade" + vbNewLine + vbNewLine + "+38 Damage" + vbNewLine + "+10 Attack Speed" + vbNewLine + "Shadow Walk (active)")
            .SetToolTip(PictureBox140, "Shiva's Guard" + vbNewLine + vbNewLine + "+30 Intelligence" + vbNewLine + "+15 Armor" + vbNewLine + "Freezing Aura" + vbNewLine + "Arctic Blast (active)")
            .SetToolTip(PictureBox141, "Skull Basher" + vbNewLine + vbNewLine + "+40 Damage" + vbNewLine + "+6 Strength" + vbNewLine + "Bash")
            .SetToolTip(PictureBox142, "Slippers of Agility" + vbNewLine + vbNewLine + "+3 Agility")
            .SetToolTip(PictureBox143, "Smoke of Deceit" + vbNewLine + vbNewLine + "Smoke of Deceit (active)" + vbNewLine + "1 Charges")
            .SetToolTip(PictureBox144, "Soul Booster" + vbNewLine + vbNewLine + "+450 HP" + vbNewLine + "+400 Mana" + vbNewLine + "+4 HP/sec Regeneration" + vbNewLine + "+100% Mana Regeneration")
            .SetToolTip(PictureBox145, "Soul Ring" + vbNewLine + vbNewLine + "+3 HP/sec Regeneration" + vbNewLine + "+50% Mana Regeneration" + vbNewLine + "Sacrifice (active)")
            .SetToolTip(PictureBox146, "Staff of Wizardry" + vbNewLine + vbNewLine + "+10 Intelligence")
            .SetToolTip(PictureBox147, "Stout Shield" + vbNewLine + vbNewLine + "Damage Block")
            .SetToolTip(PictureBox148, "Talisman of Evasion" + vbNewLine + vbNewLine + "+25% Evasion")
            .SetToolTip(PictureBox149, "Tango" + vbNewLine + vbNewLine + "Eat Tree (active)" + vbNewLine + "3 Charges")
            .SetToolTip(PictureBox150, "Town Portal Scroll" + vbNewLine + vbNewLine + "Teleport (active)" + vbNewLine + "1 Charges")
            .SetToolTip(PictureBox151, "Ultimate Orb" + vbNewLine + vbNewLine + "+10 All Attributes")
            .SetToolTip(PictureBox152, "Urn of Shadows" + vbNewLine + vbNewLine + "+50% Mana Regeneration" + vbNewLine + "+6 Strength" + vbNewLine + "Soul Release (active)")
            .SetToolTip(PictureBox153, "Vanguard" + vbNewLine + vbNewLine + "+6 HP/sec Regeneration" + vbNewLine + "+250 HP" + vbNewLine + "Damage Block")
            .SetToolTip(PictureBox154, "Veil of Discord" + vbNewLine + vbNewLine + "+5 Armor" + vbNewLine + "+5 HP/sec Regeneration" + vbNewLine + "+12 Intelligence" + vbNewLine + "Discord (active)")
            .SetToolTip(PictureBox155, "Vitality Booster" + vbNewLine + vbNewLine + "+250 HP")
            .SetToolTip(PictureBox156, "Vladmir's Offering" + vbNewLine + vbNewLine + "+2 HP/sec Regeneration" + vbNewLine + "Vampiric Aura" + vbNewLine + "Damage Aura" + vbNewLine + "Armor Aura" + vbNewLine + "Mana Regeneration Aura")
            .SetToolTip(PictureBox157, "Void Stone" + vbNewLine + vbNewLine + "+100% Mana Regeneration")
            .SetToolTip(PictureBox158, "Wraith Band" + vbNewLine + vbNewLine + "+3 Damage" + vbNewLine + "+6 Agility" + vbNewLine + "+3 Strength" + vbNewLine + "+3 Intelligence")
            .SetToolTip(PictureBox159, "Yasha" + vbNewLine + vbNewLine + "+16 Agility" + vbNewLine + "+15 Attack Speed" + vbNewLine + "+10% Movement Speed")
            .SetToolTip(PictureBox160, "Abyssal Blade" + vbNewLine + vbNewLine + "+100 Damage" + vbNewLine + "+10 Strength" + vbNewLine + "Bash" + vbNewLine + "Overwhelm (active)")
            .SetToolTip(PictureBox161, "Heaven's Halberd" + vbNewLine + vbNewLine + "+25 Damage" + vbNewLine + "+20 Strength" + vbNewLine + "+25 Evasion" + vbNewLine + "Lesser Maim" + vbNewLine + "Disarm (active)")
            .SetToolTip(PictureBox162, "Ring of Aquila" + vbNewLine + vbNewLine + "+9 Damage" + vbNewLine + "+3 All Stats" + vbNewLine + "+3 Agility" + vbNewLine + "+1 Armor" + vbNewLine + "Armor Aura" + vbNewLine + "Mana Aura")
            .SetToolTip(PictureBox163, "Rod of Atos" + vbNewLine + vbNewLine + "+25 Intelligence" + vbNewLine + "+250 HP" + vbNewLine + "Cripple (active)")
            .SetToolTip(PictureBox164, "Tranquil Boots" + vbNewLine + vbNewLine + "+80 Movement Speed" + vbNewLine + "+3 HP/sec Regeneration" + vbNewLine + "+3 Armor" + vbNewLine + "Rejuvenate (active)")
            .SetToolTip(PictureBox165, "Delete Item")
        End With
        ComboBox3.SelectedItem = "All"
        ComboBox5.SelectedItem = "DotA Like"

        If Not My.Settings.autoupdate Then
            CheckBox5.Checked = False
        Else
            CheckBox5.Checked = True
            LabelWait.Visible = True
            BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub

    Public Sub ClearSingle()
        TextBox1.Text = ""
        Label1.Text = ""
        NeuerText = ""
        Dim pb As Object
        Dim picbox As Integer = 1
        For picbox = 1 To 39
            pb = TabPage1.Controls.Item("Item" & picbox)
            pb.image = D2RIC.My.Resources.Resources.none
            ToolTip1.SetToolTip(pb, "none")
        Next
    End Sub

    Private Sub CheckFile(ByVal hero As String)
        If IO.File.Exists(My.Settings.path + "\default_" + hero + ".txt") Then
            Dim DeinPfad As String = My.Settings.path + "\default_" + hero + ".txt"
            Dim ItemPlace As String = "Starting Items"
            Dim i As Integer = 1
            Dim pb As Object
            For Each Zeile As String In IO.File.ReadAllLines(DeinPfad)
                If Zeile.Contains("item_") And i <= 39 Then
                    pb = TabPage1.Controls.Item("Item" & i)
                    pb.image = ChangePicture(RenameItem(Zeile))
                    ToolTip1.SetToolTip(pb, GetToolTip(RenameItem(Zeile)))
                    i = i + 1
                ElseIf Zeile.Contains("Early_Game") Then
                    ItemPlace = "Early Game"
                    i = 10
                    NeuerText &= Zeile & vbNewLine
                ElseIf Zeile.Contains("Core_Items") Then
                    ItemPlace = "Core Items"
                    i = 19
                    NeuerText &= Zeile & vbNewLine
                ElseIf Zeile.Contains("Luxury") Then
                    ItemPlace = "Luxury"
                    i = 28
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
            ButtonSave.Enabled = True
        Else
            ClearSingle()
            ButtonSave.Enabled = False
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

            For a = 1 To 39
                pb = TabPage1.Controls.Item("Item" & a)
                If a < 10 And Not doImagesMatch(pb.Image, D2RIC.My.Resources.Resources.none) Then
                    StartingItems &= vbNewLine & vbTab & vbTab & vbTab & """Item""" & vbTab & vbTab & CheckItem(pb.Image)
                ElseIf 9 < a And a < 19 And Not doImagesMatch(pb.Image, D2RIC.My.Resources.Resources.none) Then
                    Earlygame &= vbNewLine & vbTab & vbTab & vbTab & """Item""" & vbTab & vbTab & CheckItem(pb.Image)
                ElseIf 18 < a And a < 27 And Not doImagesMatch(pb.Image, D2RIC.My.Resources.Resources.none) Then
                    CoreItems &= vbNewLine & vbTab & vbTab & vbTab & """Item""" & vbTab & vbTab & CheckItem(pb.Image)
                ElseIf 26 < a And Not doImagesMatch(pb.Image, D2RIC.My.Resources.Resources.none) Then
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

    Private Function renameHero(ByVal hero) As String
        Select Case True
            Case hero Like "npc_dota_hero_?lchemist"
                hero = "Alchemist"
            Case hero Like "npc_dota_hero_?ncient_?pparition"
                hero = "Ancient Apparition"
            Case hero Like "npc_dota_hero_?ntimage"
                hero = "Anti-Mage"
            Case hero Like "npc_dota_hero_?xe"
                hero = "Axe"
            Case hero Like "npc_dota_hero_?ane"
                hero = "Bane"
            Case hero Like "npc_dota_hero_?atrider"
                hero = "Batrider"
            Case hero Like "npc_dota_hero_?eastmaster"
                hero = "Beastmaster"
            Case hero Like "npc_dota_hero_?loodseeker"
                hero = "Bloodseeker"
            Case hero Like "npc_dota_hero_?ounty_?unter"
                hero = "Bounty Hunter"
            Case hero Like "npc_dota_hero_?roodmother"
                hero = "Broodmother"
            Case hero Like "npc_dota_hero_?hen"
                hero = "Chen"
            Case hero Like "npc_dota_hero_?linkz"
                hero = "Clinkz"
            Case hero Like "npc_dota_hero_?rystal_?aiden"
                hero = "Crystal Maiden"
            Case hero Like "npc_dota_hero_?ark_seer"
                hero = "Dark Seer"
            Case hero Like "npc_dota_hero_?azzle"
                hero = "Dazzle"
            Case hero Like "npc_dota_hero_?eath_?rophet"
                hero = "Death Prophet"
            Case hero Like "npc_dota_hero_?oom_?ringer"
                hero = "Doom Bringer"
            Case hero Like "npc_dota_hero_?ragon_?night"
                hero = "Dragon Knight"
            Case hero Like "npc_dota_hero_?row_?anger"
                hero = "Drow Ranger"
            Case hero Like "npc_dota_hero_?arthshaker"
                hero = "Earthshaker"
            Case hero Like "npc_dota_hero_?nchantress"
                hero = "Enchantress"
            Case hero Like "npc_dota_hero_?nigma"
                hero = "Enigma"
            Case hero Like "npc_dota_hero_?aceless_?oid"
                hero = "Faceless Void"
            Case hero Like "npc_dota_hero_?urion"
                hero = "Nature's Prophet"
            Case hero Like "npc_dota_hero_?yrocopter"
                hero = "Gyrocopter"
            Case hero Like "npc_dota_hero_?uskar"
                hero = "Huskar"
            Case hero Like "npc_dota_hero_?nvoker"
                hero = "Invoker"
            Case hero Like "npc_dota_hero_?akiro"
                hero = "Jakiro"
            Case hero Like "npc_dota_hero_?uggernaut"
                hero = "Juggernaut"
            Case hero Like "npc_dota_hero_?unkka"
                hero = "Kunkka"
            Case hero Like "npc_dota_hero_?eshrac"
                hero = "Leshrac"
            Case hero Like "npc_dota_hero_?ich"
                hero = "Lich"
            Case hero Like "npc_dota_hero_?ife_?tealer"
                hero = "Lifestealer"
            Case hero Like "npc_dota_hero_?ina"
                hero = "Lina"
            Case hero Like "npc_dota_hero_?ion"
                hero = "Lion"
            Case hero Like "npc_dota_hero_?irana"
                hero = "Mirana"
            Case hero Like "npc_dota_hero_?orphling"
                hero = "Morphling"
            Case hero Like "npc_dota_hero_?ecrolyte"
                hero = "Necrolyte"
            Case hero Like "npc_dota_hero_?evermore"
                hero = "Shadow Fiend"
            Case hero Like "npc_dota_hero_?ight_?talker"
                hero = "Night Stalker"
            Case hero Like "npc_dota_hero_?bsidian_?estroyer"
                hero = "Obsidian Destroyer"
            Case hero Like "npc_dota_hero_?mniknight"
                hero = "Omniknight"
            Case hero Like "npc_dota_hero_?hantom_?ssassin"
                hero = "Mortred"
            Case hero Like "npc_dota_hero_?uck"
                hero = "Puck"
            Case hero Like "npc_dota_hero_?udge"
                hero = "Pudge"
            Case hero Like "npc_dota_hero_?ugna"
                hero = "Pugna"
            Case hero Like "npc_dota_hero_?ueenofpain"
                hero = "Queen of Pain"
            Case hero Like "npc_dota_hero_?attletrap"
                hero = "Clockwerk"
            Case hero Like "npc_dota_hero_?azor"
                hero = "Razor"
            Case hero Like "npc_dota_hero_?iki"
                hero = "Riki"
            Case hero Like "npc_dota_hero_?and_?ing"
                hero = "Sand King"
            Case hero Like "npc_dota_hero_?hadow_?haman"
                hero = "Shadow Shaman"
            Case hero Like "npc_dota_hero_?ilencer"
                hero = "Silencer"
            Case hero Like "npc_dota_hero_?keleton_?ing"
                hero = "Skeleton King"
            Case hero Like "npc_dota_hero_?lardar"
                hero = "Slardar"
            Case hero Like "npc_dota_hero_?niper"
                hero = "Sniper"
            Case hero Like "npc_dota_hero_?pectre"
                hero = "Spectre"
            Case hero Like "npc_dota_hero_?pirit_?reaker"
                hero = "Spirit Breaker"
            Case hero Like "npc_dota_hero_?torm_?pirit"
                hero = "Storm Spirit"
            Case hero Like "npc_dota_hero_?ven"
                hero = "Sven"
            Case hero Like "npc_dota_hero_?emplar_?ssassin"
                hero = "Lanaya"
            Case hero Like "npc_dota_hero_?idehunter"
                hero = "Tidehunter"
            Case hero Like "npc_dota_hero_?inker"
                hero = "Tinker"
            Case hero Like "npc_dota_hero_?iny"
                hero = "Tiny"
            Case hero Like "npc_dota_hero_?rsa"
                hero = "Ursa"
            Case hero Like "npc_dota_hero_?engefulspirit"
                hero = "Vengeful Spirit"
            Case hero Like "npc_dota_hero_?enomancer"
                hero = "Venomancer"
            Case hero Like "npc_dota_hero_?iper"
                hero = "Viper"
            Case hero Like "npc_dota_hero_?arlock"
                hero = "Warlock"
            Case hero Like "npc_dota_hero_?eaver"
                hero = "Weaver"
            Case hero Like "npc_dota_hero_?indrunner"
                hero = "Windrunner"
            Case hero Like "npc_dota_hero_?itch_?octor"
                hero = "Witch Doctor"
            Case hero Like "npc_dota_hero_?uus"
                hero = "Zeus"
                ' FEHLENDE HEROS BTW. FEHLENDE ITEMDATEIEN
            Case hero Like "npc_dota_hero_?baddon"
                hero = "Abaddon"
            Case hero Like "npc_dota_hero_?ristleback"
                hero = "Bristleback"
            Case hero Like "npc_dota_hero_?entaur_?archief"
                hero = "Centaur Warchief"
            Case hero Like "npc_dota_hero_?haos_?night"
                hero = "Chaos Knight"
            Case hero Like "npc_dota_hero_?irge"
                hero = "Dirge"
            Case hero Like "npc_dota_hero_?isruptor"
                hero = "Disruptor"
            Case hero Like "npc_dota_hero_?oblin_?echies"
                hero = "Goblin Techies"
            Case hero Like "npc_dota_hero_?uardian_?isp"
                hero = "Guardian Wisp"
            Case hero Like "npc_dota_hero_?eeperoftheLight"
                hero = "Keeper of the Light"
            Case hero Like "npc_dota_hero_?one_?ruid"
                hero = "Lone Druid"
            Case hero Like "npc_dota_hero_?una"
                hero = "Luna"
            Case hero Like "npc_dota_hero_?ycanthrope"
                hero = "Lycanthrope"
            Case hero Like "npc_dota_hero_?agnataur"
                hero = "Magnataur"
            Case hero Like "npc_dota_hero_?edusa"
                hero = "Medusa"
            Case hero Like "npc_dota_hero_?eepo"
                hero = "Meepo"
            Case hero Like "npc_dota_hero_?aga_?iren"
                hero = "Naga Siren"
            Case hero Like "npc_dota_hero_?erubian_?ssassin"
                hero = "Nerubian Assassin"
            Case hero Like "npc_dota_hero_?gre_?agi"
                hero = "Ogre Magi"
            Case hero Like "npc_dota_hero_?andaren_?rewmaster"
                hero = "Pandaren Brewmaster"
            Case hero Like "npc_dota_hero_?hantom_?ancer"
                hero = "Phantom Lancer"
            Case hero Like "npc_dota_hero_?hoenix"
                hero = "Phoenix"
            Case hero Like "npc_dota_hero_?it_?ord"
                hero = "Pit Lord"
            Case hero Like "npc_dota_hero_?ubick"
                hero = "Rubick"
            Case hero Like "npc_dota_hero_?hadow_?emon"
                hero = "Shadow Demon"
            Case hero Like "npc_dota_hero_?lark"
                hero = "Slark"
            Case hero Like "npc_dota_hero_?oul_?eeper"
                hero = "Soul Keeper"
            Case hero Like "npc_dota_hero_?auren_?hieftain"
                hero = "Tauren Chieftain"
            Case hero Like "npc_dota_hero_?reant_?rotector"
                hero = "Treant Protector"
            Case hero Like "npc_dota_hero_?roll_?arlord"
                hero = "Troll Warlord"
            Case hero Like "npc_dota_hero_?uskarr"
                hero = "Tuskarr"
            Case hero Like "npc_dota_hero_?isage"
                hero = "Visage"
            Case Else
                hero = "Unknown hero!"
        End Select
        Return hero
    End Function

    Private Function cut_file(ByVal file As String) As String ' Funktion zum Entfernen der Backslashs / Ordner
        While file.Contains("\")
            file = file.Remove(0, 1)
        End While
        Return file
    End Function

    Private Function CheckHero(ByVal hero As String) As String
        Select Case hero
            Case "Anti-Mage"
                Selected_Hero = "antimage"
            Case "Ancient Apparition"
                Selected_Hero = "ancient_apparition"
            Case "Bounty Hunter"
                Selected_Hero = "bounty_hunter"
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
            Case "Lanaya"
                Selected_Hero = "templar_assassin"
            Case "Lifestealer"
                Selected_Hero = "life_stealer"
            Case "Mortred"
                Selected_Hero = "phantom_assassin"
            Case "Obsidian Destroyer"
                Selected_Hero = "obsidian_destroyer"
                ' FEHLENDE HEROS BTW. FEHLENDE ITEMDATEIEN
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
                Selected_Hero = hero
        End Select
        Return Selected_Hero
    End Function

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedItem <> "" Then
            CheckHero(ListBox1.SelectedItem.ToString)
            ClearSingle()
            Label1.Text = ListBox1.SelectedItem.ToString
            CheckFile(Selected_Hero)
        End If
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
                i += 30
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
        'we made it this far so the images must match
        Return True
    End Function

    Public Function PicRes2Name(ByVal img_res As System.Drawing.Bitmap) As String
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
    End Function
    Public Function GetToolTip(ByVal item_name As String) As String
        Dim tooltip As String
        Select Case item_name
            Case "Blink Dagger"
                tooltip = "Blink Dagger" + vbNewLine + vbNewLine + "Blink"
                Return tooltip
            Case "Blades of Attack"
                tooltip = "Blades of Attack" + vbNewLine + vbNewLine + "+9 Damage"
                Return tooltip
            Case "Aghanim's Scepter"
                tooltip = "Aghanim's Scepter" + vbNewLine + vbNewLine + "+10 All Attributes" + vbNewLine + "+200 HP" + vbNewLine + "+150 Mana" + vbNewLine + "Ultimate Upgrade (passive)"
                Return tooltip
            Case "Animal Courier"
                tooltip = "Animal Courier" + vbNewLine + vbNewLine + "Summon Animal Courier"
                Return tooltip
            Case "Arcane Boots"
                tooltip = "Arcane Boots" + vbNewLine + vbNewLine + "+65 Movement Speed " + vbNewLine + "+250 Mana" + vbNewLine + "Replenish Mana (active)"
                Return tooltip
            Case "Armlet"
                tooltip = "Armlet" + vbNewLine + vbNewLine + "+9 Damage" + vbNewLine + "+15 Attack Speed" + vbNewLine + "+5 Armor" + vbNewLine + "+5 HP/sec Regeneration" + vbNewLine + "Unholy Strength (active)"
                Return tooltip
            Case "Assault Cuirass"
                tooltip = "Assault Cuirass" + vbNewLine + vbNewLine + "+10 Armor" + vbNewLine + "+35 Attack Speed" + vbNewLine + "Positive Armor (Aura)" + vbNewLine + "Negative Armor (Aura)" + vbNewLine + "Attack Speed (Aura)"
                Return tooltip
            Case "Battle Fury"
                tooltip = "Battle Fury" + vbNewLine + vbNewLine + "+65 Damage" + vbNewLine + "+6 HP/sec Regeneration" + vbNewLine + "+150% Mana Regeneration" + vbNewLine + "Cleave"
                Return tooltip
            Case "Belt of Strength"
                tooltip = "Belt of Strength" + vbNewLine + vbNewLine + "+6 Strength"
                Return tooltip
            Case "Black King Bar"
                tooltip = "Black King Bar" + vbNewLine + vbNewLine + "+10 Strength" + vbNewLine + "+24 Damage" + vbNewLine + "Avatar (active)"""
                Return tooltip
            Case "Blade Mail"
                tooltip = "Blade Mail" + vbNewLine + vbNewLine + "+22 Damage" + vbNewLine + "+5 Armor" + vbNewLine + "+10 Intelligence" + vbNewLine + "Damage Return (active)"
                Return tooltip
            Case "Blade of Alacrity"
                tooltip = "Blade of Alacrity" + vbNewLine + vbNewLine + "+10 Agility"
                Return tooltip
            Case "Bloodstone"
                tooltip = "Bloodstone" + vbNewLine + vbNewLine + "+500 HP" + vbNewLine + "+400 Mana" + vbNewLine + "+8 HP/sec Regeneration" + vbNewLine + "+200% Mana Regeneration" + vbNewLine + "Bloodpact" + vbNewLine + "5 Charges"
                Return tooltip
            Case "Boots of Elvenskin"
                tooltip = "Boots of Elvenskin" + vbNewLine + vbNewLine + "+6 Agility"
                Return tooltip
            Case "Boots of Speed"
                tooltip = "Boots of Speed" + vbNewLine + vbNewLine + "+55 Movement Speed"
                Return tooltip
            Case "Boots of Travel"
                tooltip = "Boots of Travel" + vbNewLine + vbNewLine + "+95 Movement Speed" + vbNewLine + "Teleport (active)"
                Return tooltip
            Case "Bottle"
                tooltip = "Bottle" + vbNewLine + vbNewLine + "Regenerate" + vbNewLine + "Rune Capture"
                Return tooltip
            Case "Bracer"
                tooltip = "Bracer" + vbNewLine + vbNewLine + "+3 Damage" + vbNewLine + "+6 Strength" + vbNewLine + "+3 Agility" + vbNewLine + "+3 Intelligence"
                Return tooltip
            Case "Broadsword"
                tooltip = "Broadsword" + vbNewLine + vbNewLine + "+18 Damage"
                Return tooltip
            Case "Buckler"
                tooltip = "Buckler" + vbNewLine + vbNewLine + "+5 Armor" + vbNewLine + "+2 All Attributes" + vbNewLine + "Armor Bonus (active)"
                Return tooltip
            Case "Butterfly"
                tooltip = "Butterfly" + vbNewLine + vbNewLine + "+30 Agility" + vbNewLine + "+30 Damage" + vbNewLine + "30% Evasion" + vbNewLine + "+30 Attack Speed"
                Return tooltip
            Case "Chainmail"
                tooltip = "Chainmail" + vbNewLine + vbNewLine + "+5 Armor"
                Return tooltip
            Case "Circlet"
                tooltip = "Circlet" + vbNewLine + vbNewLine + "+2 All Attributes"
                Return tooltip
            Case "Clarity"
                tooltip = "Clarity" + vbNewLine + vbNewLine + "Regenerate Mana" + vbNewLine + "1 Charges"
                Return tooltip
            Case "Claymore"
                tooltip = "Claymore" + vbNewLine + vbNewLine + "+21 Damage"
                Return tooltip
            Case "Cloak"
                tooltip = "Cloak" + vbNewLine + vbNewLine + "+15% Magic Resistance"
                Return tooltip
            Case "Crystalys"
                tooltip = "Crystalys" + vbNewLine + vbNewLine + "+35 Damage" + vbNewLine + "Critical Strike"
                Return tooltip
            Case "Daedalus"
                tooltip = "Daedalus" + vbNewLine + vbNewLine + "+81 Damage" + vbNewLine + "Critical Strike"
                Return tooltip
            Case "Dagon 1"
                tooltip = "Dagon 1" + vbNewLine + vbNewLine + "+13 Intelligence" + vbNewLine + "+3 All Attributes" + vbNewLine + "+9 Damage" + vbNewLine + "Energy Burst (active)"
                Return tooltip
            Case "Dagon 2"
                tooltip = "Dagon 2" + vbNewLine + vbNewLine + "+15 Intelligence" + vbNewLine + "+3 All Attributes" + vbNewLine + "+9 Damage" + vbNewLine + "Energy Burst (active)"
                Return tooltip
            Case "Dagon 3"
                tooltip = "Dagon 3" + vbNewLine + vbNewLine + "+17 Intelligence" + vbNewLine + "+3 All Attributes" + vbNewLine + "+9 Damage" + vbNewLine + "Energy Burst (active)"
                Return tooltip
            Case "Dagon 4"
                tooltip = "Dagon 4" + vbNewLine + vbNewLine + "+19 Intelligence" + vbNewLine + "+3 All Attributes" + vbNewLine + "+9 Damage" + vbNewLine + "Energy Burst (active)"
                Return tooltip
            Case "Dagon 5"
                tooltip = "Dagon 5" + vbNewLine + vbNewLine + "+21 Intelligence" + vbNewLine + "+3 All Attributes" + vbNewLine + "+9 Damage" + vbNewLine + "Energy Burst (active)"
                Return tooltip
            Case "Demon Edge"
                tooltip = "Demon Edge" + vbNewLine + vbNewLine + "+46 Damage"
                Return tooltip
            Case "Desolator"
                tooltip = "Desolator" + vbNewLine + vbNewLine + "+60 Damage" + vbNewLine + "Corruption"
                Return tooltip
            Case "Diffusal Blade 1"
                tooltip = "Diffusal Blade 1" + vbNewLine + vbNewLine + "+22 Agility" + vbNewLine + "+6 Intelligence" + vbNewLine + "Feedback" + vbNewLine + "Purge (active)" + vbNewLine + "8 Charges"
                Return tooltip
            Case "Diffusal Blade 2"
                tooltip = "Diffusal Blade 2" + vbNewLine + vbNewLine + "+26 Agility" + vbNewLine + "+10 Intelligence" + vbNewLine + "Feedback" + vbNewLine + "Purge (active)" + vbNewLine + "8 Charges"
                Return tooltip
            Case "Divine Rapier"
                tooltip = "Divine Rapier" + vbNewLine + vbNewLine + "+250 Damage"
                Return tooltip
            Case "Drum of Endurance"
                tooltip = "Drum of Endurance" + vbNewLine + vbNewLine + "+9 All Attributes" + vbNewLine + "+9 Damage" + vbNewLine + "Endurance Aura" + vbNewLine + "Endurance (active)" + vbNewLine + "4 Charges"
                Return tooltip
            Case "Dust of Appearance"
                tooltip = "Dust of Appearance" + vbNewLine + vbNewLine + "Reveal" + vbNewLine + "2 Charges"
                Return tooltip
            Case "Eaglesong"
                tooltip = "Eaglesong" + vbNewLine + vbNewLine + "+25 Agility"
                Return tooltip
            Case "Energy Booster"
                tooltip = "Energy Booster" + vbNewLine + vbNewLine + "+250 Mana"
                Return tooltip
            Case "Ethereal Blade"
                tooltip = "Ethereal Blade" + vbNewLine + vbNewLine + "+40 Agility" + vbNewLine + "+10 Strength" + vbNewLine + "+10 Intelligence" + vbNewLine + "Ether Blast (active)"
                Return tooltip
            Case "Eul's Scepter of Divinity"
                tooltip = "Eul's Scepter of Divinity" + vbNewLine + vbNewLine + "+10 Intelligence" + vbNewLine + "+150% Mana Regeneration" + vbNewLine + "+25 Movement Speed" + vbNewLine + "Cyclone (active)"
                Return tooltip
            Case "Eye of Skadi"
                tooltip = "Eye of Skadi" + vbNewLine + vbNewLine + "+25 All Attributes" + vbNewLine + "+200 HP" + vbNewLine + "+150 Mana" + vbNewLine + "Cold Attack"
                Return tooltip
            Case "Flying Courier"
                tooltip = "Flying Courier" + vbNewLine + vbNewLine + "Summon Flying Courier"
                Return tooltip
            Case "Force Staff"
                tooltip = "Force Staff" + vbNewLine + vbNewLine + "+10 Intelligence" + vbNewLine + "+10 Damage" + vbNewLine + "+10 Attack Speed" + vbNewLine + "Force (active)"
                Return tooltip
            Case "Gauntlets of Strength"
                tooltip = "Gauntlets of Strength" + vbNewLine + vbNewLine + "+3 Strength"
                Return tooltip
            Case "Gem of True Sight"
                tooltip = "Gem of True Sight" + vbNewLine + vbNewLine + "True Sight"
                Return tooltip
            Case "Ghost Scepter"
                tooltip = "Ghost Scepter" + vbNewLine + vbNewLine + "+7 All Attributes" + vbNewLine + "Ghost Form (active)"
                Return tooltip
            Case "Gloves of Haste"
                tooltip = "Gloves of Haste" + vbNewLine + vbNewLine + "+15 Attack Speed"
                Return tooltip
            Case "Hand of Midas"
                tooltip = "Hand of Midas" + vbNewLine + vbNewLine + "+30 Attack Speed" + vbNewLine + "Transmute (active)"
                Return tooltip
            Case "Headdress"
                tooltip = "Headdress" + vbNewLine + vbNewLine + "+2 All Attributes" + vbNewLine + "Regeneration Aura"
                Return tooltip
            Case "Healing Salve"
                tooltip = "Healing Salve" + vbNewLine + vbNewLine + "Regenerate Health" + vbNewLine + "1 Charges"
                Return tooltip
            Case "Heart of Tarrasque"
                tooltip = "Heart of Tarrasque" + vbNewLine + vbNewLine + "+40 Strength" + vbNewLine + "+300 HP" + vbNewLine + "Health Regeneration"
                Return tooltip
            Case "Helm of Iron Will"
                tooltip = "Helm of Iron Will" + vbNewLine + vbNewLine + "+5 Armor" + vbNewLine + "+3 HP/sec Regeneration"
                Return tooltip
            Case "Helm of the Dominator"
                tooltip = "Helm of the Dominator" + vbNewLine + vbNewLine + "+20 Damage" + vbNewLine + "+5 Armor" + vbNewLine + "+15% Lifesteal" + vbNewLine + "Dominate (active)"
                Return tooltip
            Case "Hood of Defiance"
                tooltip = "Hood of Defiance" + vbNewLine + vbNewLine + "+30% Magic Resistance" + vbNewLine + "+8 HP/sec Regeneration"
                Return tooltip
            Case "Hyperstone"
                tooltip = "Hyperstone" + vbNewLine + vbNewLine + "+55 Attack Speed"
                Return tooltip
            Case "Iron Branch"
                tooltip = "Iron Branch" + vbNewLine + vbNewLine + "+1 All Attributes"
                Return tooltip
            Case "Javelin"
                tooltip = "Javelin" + vbNewLine + vbNewLine + "+21 Damage" + vbNewLine + "20% chance to deal 40 bonus damage"
                Return tooltip
            Case "Linken's Sphere"
                tooltip = "Linken's Sphere" + vbNewLine + vbNewLine + "+15 All Attributes" + vbNewLine + "+6 HP/sec Regeneration" + vbNewLine + "+150% Mana Regeneration" + vbNewLine + "Spell Block"
                Return tooltip
            Case "Maelstrom"
                tooltip = "Maelstrom" + vbNewLine + vbNewLine + "+24 Damage" + vbNewLine + "+25 Attack Speed" + vbNewLine + "Chain Lightning"
                Return tooltip
            Case "Magic Stick"
                tooltip = "Magic Stick" + vbNewLine + vbNewLine + "Energy Charge (active)"
                Return tooltip
            Case "Magic Wand"
                tooltip = "Magic Wand" + vbNewLine + vbNewLine + "+3 All Attributes" + vbNewLine + "Energy Charge (active)"
                Return tooltip
            Case "Manta Style"
                tooltip = "Manta Style" + vbNewLine + vbNewLine + "+26 Agility" + vbNewLine + "+10 Strength" + vbNewLine + "+10 Intelligence" + vbNewLine + "+15 Attack Speed" + vbNewLine + "+10% Movement Speed" + vbNewLine + "Mirror Image (active)"
                Return tooltip
            Case "Mantle of Intelligence"
                tooltip = "Mantle of Intelligence" + vbNewLine + vbNewLine + "+3 Intelligence"
                Return tooltip
            Case "Mask of Madness"
                tooltip = "Mask of Madness" + vbNewLine + vbNewLine + "+17% Lifesteal" + vbNewLine + "Berserk (active)"
                Return tooltip
            Case "Medallion of Courage"
                tooltip = "Medallion of Courage" + vbNewLine + vbNewLine + "+6 Armor" + vbNewLine + "+50% Mana Regeneration" + vbNewLine + "Valor (active)"
                Return tooltip
            Case "Mekansm"
                tooltip = "Mekansm" + vbNewLine + vbNewLine + "+5 All Attributes" + vbNewLine + "+5 Armor" + vbNewLine + "Mekansm Aura" + vbNewLine + "Restore (active)"
                Return tooltip
            Case "Mithril Hammer"
                tooltip = "Mithril Hammer" + vbNewLine + vbNewLine + "+24 Damage"
                Return tooltip
            Case "Mjollnir"
                tooltip = "Mjollnir" + vbNewLine + vbNewLine + "+80 Attack Speed" + vbNewLine + "+24 Damage" + vbNewLine + "Chain Lightning" + vbNewLine + "Static Charge (active)"
                Return tooltip
            Case "Monkey King Bar"
                tooltip = "Monkey King Bar" + vbNewLine + vbNewLine + "+88 Damage" + vbNewLine + "+15 Attack Speed" + vbNewLine + "True Strike" + vbNewLine + "Mini-Bash"
                Return tooltip
            Case "Morbid Mask"
                tooltip = "Morbid Mask" + vbNewLine + vbNewLine + "+15% Lifesteal"
                Return tooltip
            Case "Mystic Staff"
                tooltip = "Mystic Staff" + vbNewLine + vbNewLine + "+25 Intelligence"
                Return tooltip
            Case "Necronomicon 1"
                tooltip = "Necronomicon 1" + vbNewLine + vbNewLine + "+15 Intelligence" + vbNewLine + "+8 Strength" + vbNewLine + "Demonic Summoning (active)"
                Return tooltip
            Case "Necronomicon 2"
                tooltip = "Necronomicon 2" + vbNewLine + vbNewLine + "+21 Intelligence" + vbNewLine + "+12 Strength" + vbNewLine + "Demonic Summoning (active)"
                Return tooltip
            Case "Necronomicon 3"
                tooltip = "Necronomicon 3" + vbNewLine + vbNewLine + "+24 Intelligence" + vbNewLine + "+16 Strength" + vbNewLine + "Demonic Summoning (active)"
                Return tooltip
            Case "Null Talisman"
                tooltip = "Null Talisman" + vbNewLine + vbNewLine + "+3 Damage" + vbNewLine + "+6 Intelligence" + vbNewLine + "+3 Strength" + vbNewLine + "+3 Agility"
                Return tooltip
            Case "Oblivion Staff"
                tooltip = "Oblivion Staff" + vbNewLine + vbNewLine + "+6 Intelligence" + vbNewLine + "+10 Attack Speed" + vbNewLine + "+15 Damage" + vbNewLine + "+75% Mana Regeneration"
                Return tooltip
            Case "Observer Ward"
                tooltip = "Observer Ward" + vbNewLine + vbNewLine + "Place Ward" + vbNewLine + "2 Charges"
                Return tooltip
            Case "Ogre Club"
                tooltip = "Ogre Club" + vbNewLine + vbNewLine + "+10 Strength"
                Return tooltip
            Case "Orb of Venom"
                tooltip = "Orb of Venom" + vbNewLine + vbNewLine + "Poison Attack"
                Return tooltip
            Case "Orchid Malevolence"
                tooltip = "Orchid Malevolence" + vbNewLine + vbNewLine + "+20 Intelligence" + vbNewLine + "+30 Attack Speed" + vbNewLine + "+45 Damage" + vbNewLine + "+225% Mana Regeneration" + vbNewLine + "Soul Burn (active)"
                Return tooltip
            Case "Perseverance"
                tooltip = "Perseverance" + vbNewLine + vbNewLine + "+10 Damage" + vbNewLine + "+5 HP/sec Regeneration" + vbNewLine + "+125% Mana Regeneration"
                Return tooltip
            Case "Phase Boots"
                tooltip = "Phase Boots" + vbNewLine + vbNewLine + "+60 Movement Speed" + vbNewLine + "+24 damage" + vbNewLine + "Phase (active)"
                Return tooltip
            Case "Pipe of Insight"
                tooltip = "Pipe of Insight" + vbNewLine + vbNewLine + "+11 HP/sec Regeneration" + vbNewLine + "+30% Magic Resistance" + vbNewLine + "Barrier (active)"
                Return tooltip
            Case "Platemail"
                tooltip = "Platemail" + vbNewLine + vbNewLine + "+10 Armor"
                Return tooltip
            Case "Point Booster"
                tooltip = "Point Booster" + vbNewLine + vbNewLine + "+200 HP" + vbNewLine + "+150 Mana"
                Return tooltip
            Case "Poor Man's Shield"
                tooltip = "Poor Man's Shield" + vbNewLine + vbNewLine + "+6 Agility" + vbNewLine + "Damage Block"
                Return tooltip
            Case "Power Treads"
                tooltip = "Power Treads" + vbNewLine + vbNewLine + "+60 Move Speed" + vbNewLine + "+8 Selected Attribute" + vbNewLine + "+25 Attack Speed" + vbNewLine + "Switch Attribute (active)"
                Return tooltip
            Case "Quarterstaff"
                tooltip = "Quarterstaff" + vbNewLine + vbNewLine + "+10 Damage" + vbNewLine + "+10 Attack Speed"
                Return tooltip
            Case "Quelling Blade"
                tooltip = "Quelling Blade" + vbNewLine + vbNewLine + "Demolish" + vbNewLine + "Tree Chop (active)"
                Return tooltip
            Case "Radiance"
                tooltip = "Radiance" + vbNewLine + vbNewLine + "+60 Damage" + vbNewLine + "Burn Damage"
                Return tooltip
            Case "Reaver"
                tooltip = "Reaver" + vbNewLine + vbNewLine + "+25 Strength"
                Return tooltip
            Case "Refresher Orb"
                tooltip = "Refresher Orb" + vbNewLine + vbNewLine + "+5 HP/Sec Regeneration" + vbNewLine + "+200% Mana Regeneration" + vbNewLine + "+40 Damage" + vbNewLine + "Reset Cooldowns (active)"
                Return tooltip
            Case "Ring of Basilius"
                tooltip = "Ring of Basilius" + vbNewLine + vbNewLine + "+6 Damage" + vbNewLine + "+1 Armor" + vbNewLine + "Mana Aura" + vbNewLine + "Armor Aura"
                Return tooltip
            Case "Ring of Health"
                tooltip = "Ring of Health" + vbNewLine + vbNewLine + "+5 HP/sec Regeneration"
                Return tooltip
            Case "Ring of Protection"
                tooltip = "Ring of Protection" + vbNewLine + vbNewLine + "+2 Armor"
                Return tooltip
            Case "Ring of Regen"
                tooltip = "Ring of Regen" + vbNewLine + vbNewLine + "+2 HP/sec Regeneration"
                Return tooltip
            Case "Robe of the Magi"
                tooltip = "Robe of the Magi" + vbNewLine + vbNewLine + "+6 Intelligence"
                Return tooltip
            Case "Sacred Relic"
                tooltip = "Sacred Relic" + vbNewLine + vbNewLine + "+60 Damage"
                Return tooltip
            Case "Sage's Mask"
                tooltip = "Sage's Mask" + vbNewLine + vbNewLine + "+50% Mana Regeneration"
                Return tooltip
            Case "Sange"
                tooltip = "Sange" + vbNewLine + vbNewLine + "+16 Strength" + vbNewLine + "+10 Damage" + vbNewLine + "Lesser Maim"
                Return tooltip
            Case "Sange and Yasha"
                tooltip = "Sange and Yasha" + vbNewLine + vbNewLine + "+16 Agility" + vbNewLine + "+16 Strength" + vbNewLine + "+12 Damage" + vbNewLine + "+15 Attack Speed" + vbNewLine + "+12% Movement Speed" + vbNewLine + "Greater Maim"
                Return tooltip
            Case "Satanic"
                tooltip = "Satanic" + vbNewLine + vbNewLine + "+25 Strength" + vbNewLine + "+20 Damage" + vbNewLine + "+5 Armor" + vbNewLine + "+25% Lifesteal" + vbNewLine + "Unholy Rage (active)"
                Return tooltip
            Case "Scythe of Vyse"
                tooltip = "Scythe of Vyse" + vbNewLine + vbNewLine + "+35 Intelligence" + vbNewLine + "+10 Strength" + vbNewLine + "+10 Agility" + vbNewLine + "+150% Mana Regeneration" + vbNewLine + "Hex (active)"
                Return tooltip
            Case "Sentry Ward"
                tooltip = "Sentry Ward" + vbNewLine + vbNewLine + "Place Ward" + vbNewLine + "950 Radius True Sight " + vbNewLine + "2 Charges"
                Return tooltip
            Case "Shadow Blade"
                tooltip = "Shadow Blade" + vbNewLine + vbNewLine + "+38 Damage" + vbNewLine + "+10 Attack Speed" + vbNewLine + "Shadow Walk (active)"
                Return tooltip
            Case "Shiva's Guard"
                tooltip = "Shiva's Guard" + vbNewLine + vbNewLine + "+30 Intelligence" + vbNewLine + "+15 Armor" + vbNewLine + "Freezing Aura" + vbNewLine + "Arctic Blast (active)"
                Return tooltip
            Case "Skull Basher"
                tooltip = "Skull Basher" + vbNewLine + vbNewLine + "+40 Damage" + vbNewLine + "+6 Strength" + vbNewLine + "Bash"
                Return tooltip
            Case "Slippers of Agility"
                tooltip = "Slippers of Agility" + vbNewLine + vbNewLine + "+3 Agility"
                Return tooltip
            Case "Smoke of Deceit"
                tooltip = "Smoke of Deceit" + vbNewLine + vbNewLine + "Smoke of Deceit (active)" + vbNewLine + "1 Charges"
                Return tooltip
            Case "Soul Booster"
                tooltip = "Soul Booster" + vbNewLine + vbNewLine + "+450 HP" + vbNewLine + "+400 Mana" + vbNewLine + "+4 HP/sec Regeneration" + vbNewLine + "+100% Mana Regeneration"
                Return tooltip
            Case "Soul Ring"
                tooltip = "Soul Ring" + vbNewLine + vbNewLine + "+3 HP/sec Regeneration" + vbNewLine + "+50% Mana Regeneration" + vbNewLine + "Sacrifice (active)"
                Return tooltip
            Case "Staff of Wizardry"
                tooltip = "Staff of Wizardry" + vbNewLine + vbNewLine + "+10 Intelligence"
                Return tooltip
            Case "Stout Shield"
                tooltip = "Stout Shield" + vbNewLine + vbNewLine + "Damage Block"
                Return tooltip
            Case "Talisman of Evasion"
                tooltip = "Talisman of Evasion" + vbNewLine + vbNewLine + "+25% Evasion"
                Return tooltip
            Case "Tango"
                tooltip = "Tango" + vbNewLine + vbNewLine + "Eat Tree" + vbNewLine + "3 Charges"
                Return tooltip
            Case "Town Portal Scroll"
                tooltip = "Town Portal Scroll" + vbNewLine + vbNewLine + "Teleport" + vbNewLine + "1 Charges"
                Return tooltip
            Case "Ultimate Orb"
                tooltip = "Ultimate Orb" + vbNewLine + vbNewLine + "+10 All Attributes"
                Return tooltip
            Case "Urn of Shadows"
                tooltip = "Urn of Shadows" + vbNewLine + vbNewLine + "+50% Mana Regeneration" + vbNewLine + "+6 Strength" + vbNewLine + "Soul Release (active)"
                Return tooltip
            Case "Vanguard"
                tooltip = "Vanguard" + vbNewLine + vbNewLine + "+6 HP/sec regeneration" + vbNewLine + "+275 HP" + vbNewLine + "Damage Block"
                Return tooltip
            Case "Veil of Discord"
                tooltip = "Veil of Discord" + vbNewLine + vbNewLine + "+5 Armor" + vbNewLine + "+5 HP/sec Regeneration" + vbNewLine + "+12 Intelligence" + vbNewLine + "Discord (active)"
                Return tooltip
            Case "Vitality Booster"
                tooltip = "Vitality Booster" + vbNewLine + vbNewLine + "+250 HP"
                Return tooltip
            Case "Vladmir's Offering"
                tooltip = "Vladmir's Offering" + vbNewLine + vbNewLine + "+2 HP/sec Regeneration" + vbNewLine + "Vampiric Aura" + vbNewLine + "Damage Aura" + vbNewLine + "Armor Aura" + vbNewLine + "Mana Regeneration Aura"
                Return tooltip
            Case "Void Stone"
                tooltip = "Void Stone" + vbNewLine + vbNewLine + "+100% Mana Regeneration"
                Return tooltip
            Case "Wraith Band"
                tooltip = "Wraith Band" + vbNewLine + vbNewLine + "+3 Damage" + vbNewLine + "+6 Agility" + vbNewLine + "+3 Strength" + vbNewLine + "+3 Intelligence"
                Return tooltip
            Case "Yasha"
                tooltip = "Yasha" + vbNewLine + vbNewLine + "+16 Agility" + vbNewLine + "+15 Attack Speed" + vbNewLine + "+10% Movement Speed"
                Return tooltip
            Case "Abyssal Blade"
                tooltip = "Abyssal Blade" + vbNewLine + vbNewLine + "+100 Damage" + vbNewLine + "+10 Strength" + vbNewLine + "Bash" + vbNewLine + "Overwhelm (active)"
                Return tooltip
            Case "Heaven's Halberd"
                tooltip = "Heaven's Halberd" + vbNewLine + vbNewLine + "+25 Damage" + vbNewLine + "+20 Strength" + vbNewLine + "+25 Evasion" + vbNewLine + "Lesser Maim" + vbNewLine + "Disarm (active)"
                Return tooltip
            Case "Ring of Aquila"
                tooltip = "Ring of Aquila" + vbNewLine + vbNewLine + "+9 Damage" + vbNewLine + "+3 All Stats" + vbNewLine + "+3 Agility" + vbNewLine + "+1 Armor" + vbNewLine + "Armor Aura" + vbNewLine + "Mana Aura"
                Return tooltip
            Case "Rod of Atos"
                tooltip = "Rod of Atos" + vbNewLine + vbNewLine + "+25 Intelligence" + vbNewLine + "+250 HP" + vbNewLine + "Cripple (active)"
                Return tooltip
            Case "Tranquil Boots"
                tooltip = "Tranquil Boots" + vbNewLine + vbNewLine + "+80 Movement Speed" + vbNewLine + "+3 HP/sec Regeneration" + vbNewLine + "+3 Armor" + vbNewLine + "Rejuvenate (active)"
                Return tooltip
            Case Else
                tooltip = "Error!"
                Return tooltip
        End Select
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
            ToolTip1.SetToolTip(Item1, GetToolTip(PicRes2Name(Item1.Image)))
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
            ToolTip1.SetToolTip(Item2, GetToolTip(PicRes2Name(Item2.Image)))
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
            ToolTip1.SetToolTip(Item3, GetToolTip(PicRes2Name(Item3.Image)))
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
            ToolTip1.SetToolTip(Item4, GetToolTip(PicRes2Name(Item4.Image)))
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
            ToolTip1.SetToolTip(Item5, GetToolTip(PicRes2Name(Item5.Image)))
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
            ToolTip1.SetToolTip(Item6, GetToolTip(PicRes2Name(Item6.Image)))
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
            ToolTip1.SetToolTip(Item7, GetToolTip(PicRes2Name(Item7.Image)))
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
            ToolTip1.SetToolTip(Item8, GetToolTip(PicRes2Name(Item8.Image)))
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
            ToolTip1.SetToolTip(Item9, GetToolTip(PicRes2Name(Item9.Image)))
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
            ToolTip1.SetToolTip(Item10, GetToolTip(PicRes2Name(Item10.Image)))
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
            ToolTip1.SetToolTip(Item11, GetToolTip(PicRes2Name(Item11.Image)))
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
            ToolTip1.SetToolTip(Item12, GetToolTip(PicRes2Name(Item12.Image)))
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
            ToolTip1.SetToolTip(Item13, GetToolTip(PicRes2Name(Item13.Image)))
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
            ToolTip1.SetToolTip(Item14, GetToolTip(PicRes2Name(Item14.Image)))
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
            ToolTip1.SetToolTip(Item15, GetToolTip(PicRes2Name(Item15.Image)))
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
            ToolTip1.SetToolTip(Item16, GetToolTip(PicRes2Name(Item16.Image)))
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
            ToolTip1.SetToolTip(Item17, GetToolTip(PicRes2Name(Item17.Image)))
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
            ToolTip1.SetToolTip(Item18, GetToolTip(PicRes2Name(Item18.Image)))
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
            ToolTip1.SetToolTip(Item19, GetToolTip(PicRes2Name(Item19.Image)))
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
            ToolTip1.SetToolTip(Item20, GetToolTip(PicRes2Name(Item20.Image)))
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
            ToolTip1.SetToolTip(Item21, GetToolTip(PicRes2Name(Item21.Image)))
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
            ToolTip1.SetToolTip(Item22, GetToolTip(PicRes2Name(Item22.Image)))
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
            ToolTip1.SetToolTip(Item23, GetToolTip(PicRes2Name(Item23.Image)))
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
            ToolTip1.SetToolTip(Item24, GetToolTip(PicRes2Name(Item24.Image)))
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
            ToolTip1.SetToolTip(Item25, GetToolTip(PicRes2Name(Item25.Image)))
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
            ToolTip1.SetToolTip(Item26, GetToolTip(PicRes2Name(Item26.Image)))
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
            ToolTip1.SetToolTip(Item27, GetToolTip(PicRes2Name(Item27.Image)))
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
            ToolTip1.SetToolTip(Item28, GetToolTip(PicRes2Name(Item28.Image)))
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
            ToolTip1.SetToolTip(Item29, GetToolTip(PicRes2Name(Item29.Image)))
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
            ToolTip1.SetToolTip(Item30, GetToolTip(PicRes2Name(Item30.Image)))
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
            ToolTip1.SetToolTip(Item31, GetToolTip(PicRes2Name(Item31.Image)))
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
            ToolTip1.SetToolTip(Item32, GetToolTip(PicRes2Name(Item32.Image)))
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
            ToolTip1.SetToolTip(Item33, GetToolTip(PicRes2Name(Item33.Image)))
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
            ToolTip1.SetToolTip(Item34, GetToolTip(PicRes2Name(Item34.Image)))
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
            ToolTip1.SetToolTip(Item35, GetToolTip(PicRes2Name(Item35.Image)))
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
            ToolTip1.SetToolTip(Item36, GetToolTip(PicRes2Name(Item36.Image)))
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
            ToolTip1.SetToolTip(Item37, GetToolTip(PicRes2Name(Item37.Image)))
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
            ToolTip1.SetToolTip(Item38, GetToolTip(PicRes2Name(Item38.Image)))
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
            ToolTip1.SetToolTip(Item39, GetToolTip(PicRes2Name(Item39.Image)))
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

    Private Sub PictureBox166_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox166.MouseDown
        If Not PictureBox166.Image Is Nothing Then
            ' Set a flag to show that the mouse is down. 
            m_MouseIsDown = True
        End If
    End Sub
    Private Sub PictureBox166_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox166.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy. 
            PictureBox166.DoDragDrop(PictureBox166.Image, DragDropEffects.Copy)
        End If
        m_MouseIsDown = False
    End Sub


    Private Sub ButtonOpenFolder_Click(sender As System.Object, e As System.EventArgs) Handles ButtonOpenFolder.Click
        System.Diagnostics.Process.Start("explorer", My.Settings.path)
    End Sub

    Private Sub ButtonSave_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSave.Click
        If (Selected_Hero <> "") Then
            SaveChanges()
            If TextBox1.Text <> "" Then
                ChangeAuthor(TextBox1.Text, Selected_Hero)
            End If
            'MsgBox(NeuerText)
            IO.File.WriteAllText(My.Settings.path + "\default_" + Selected_Hero + ".txt", NeuerText)
        Else
            MsgBox("Please choose a hero first.")
        End If
    End Sub

    Private Sub ButtonBackup_Click(sender As System.Object, e As System.EventArgs) Handles ButtonBackup.Click
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

    Private Sub ButtonDeleteBackup_Click(sender As System.Object, e As System.EventArgs) Handles ButtonDeleteBackup.Click
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

    Private Sub ButtonOpenTextfile_Click(sender As System.Object, e As System.EventArgs) Handles ButtonOpenTextfile.Click
        Using OpenFileDialog1 As OpenFileDialog = New OpenFileDialog
            OpenFileDialog1.Filter = "txt(*.txt)| *.txt"
            OpenFileDialog1.ShowDialog()
            If OpenFileDialog1.FileName <> "" Then
                If IO.File.Exists(OpenFileDialog1.FileName) Then
                    TextBox2.Text = IO.File.ReadAllText(OpenFileDialog1.FileName)
                Else
                    MsgBox("Error while reading.")
                End If
            Else
                TextBox2.Text = "Error!"
            End If
        End Using
    End Sub

    Private Sub ButtonImport_Click(sender As System.Object, e As System.EventArgs) Handles ButtonImport.Click
        If TextBox2.Text <> "" Then
            IO.File.WriteAllText(My.Settings.path + "\temp.txt", TextBox2.Text)
            If IO.File.Exists(My.Settings.path + "\temp.txt") Then
                Dim DeinPfad As String = My.Settings.path + "\temp.txt"
                Dim ItemPlace As String = "Starting Items"
                Dim i As Integer = 1
                Dim pb As Object
                ClearSingle()
                ListBox1.SelectedItems.Clear()
                For Each Zeile As String In IO.File.ReadAllLines(DeinPfad)
                    If Zeile.Contains("item_") And i <= 39 Then
                        pb = TabPage1.Controls.Item("Item" & i)
                        pb.image = ChangePicture(RenameItem(Zeile))
                        i = i + 1
                    ElseIf Zeile.Contains("Early_Game") Then
                        ItemPlace = "Early Game"
                        i = 10
                    ElseIf Zeile.Contains("Core_Items") Then
                        ItemPlace = "Core Items"
                        i = 19
                    ElseIf Zeile.Contains("Luxury") Then
                        ItemPlace = "Luxury"
                        i = 28
                    ElseIf Zeile.Contains("author") Then
                        TextBox1.Text = Replace(Zeile, """", "")
                        TextBox1.Text = Replace(TextBox1.Text, "author", "")
                        TextBox1.Text = Replace(TextBox1.Text, vbTab, "")
                    ElseIf Zeile.Contains("hero") Then
                        Selected_Hero = Replace(Zeile, """hero""", "")
                        Selected_Hero = Replace(Selected_Hero, """", "")
                        Selected_Hero = Replace(Selected_Hero, vbTab, "")
                        Label1.Text = renameHero(Selected_Hero)
                        If renameHero(Selected_Hero) <> "Unknown hero!" Then
                            ListBox1.SelectedItem = renameHero(Selected_Hero)
                        End If
                        ButtonSave.Enabled = True
                    Else

                    End If
                Next
                IO.File.Delete(My.Settings.path + "\temp.txt")
                TabControl1.SelectedTab = TabPage1
            Else
                MsgBox("Error! Hero maybe not implemented yet.")
            End If
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab Is TabPage4 Then
            TextBox3.Text = "Please choose a hero first."
            If (Selected_Hero <> "") Then
                SaveChanges()
                ChangeAuthor(TextBox1.Text, Selected_Hero)
                My.Settings.clipboard = NeuerText
                If (My.Settings.clipboard <> "") Then
                    TextBox3.Text = My.Settings.clipboard
                Else
                    TextBox3.Text = "Error!"
                End If
            End If
        ElseIf TabControl1.SelectedTab Is TabPage5 Then
            If (My.Settings.path <> "") Then
                TextBox4.Text = Replace(My.Settings.path, "\SteamApps\common\dota 2 beta\dota\itembuilds", "")
            End If
        ElseIf TabControl1.SelectedTab Is TabPage2 Then
            MsgBox("Not finished yet!")
            TabControl1.SelectedTab = TabPage1
        End If
    End Sub

    Private Sub ButtonCopy_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCopy.Click
        Clipboard.Clear()
        If TextBox3.Text <> "" Then
            Clipboard.SetText(TextBox3.Text)
        End If
    End Sub

    Private Sub ButtonSaveTextfile_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSaveTextfile.Click
        Using SaveFileDialog1 As SaveFileDialog = New SaveFileDialog
            SaveFileDialog1.Filter = "txt(*.txt)| *.txt"
            SaveFileDialog1.ShowDialog()
            If SaveFileDialog1.FileName <> "" Then
                FileOpen(1, SaveFileDialog1.FileName, OpenMode.Output)
                PrintLine(1, TextBox3.Text)
                FileClose(1)
                MsgBox("File saved.")
            End If
        End Using
    End Sub

    Private Sub Check(ByVal dota_path As String)
        If My.Computer.FileSystem.DirectoryExists(dota_path) Then
            ' existiert
            My.Settings.path = dota_path
            My.Settings.Save()
            MsgBox("Path changed successfully.")
        Else
            ' existiert nicht
            MsgBox("Please check your Steam path!!!")
        End If
    End Sub

    Private Sub ButtonChangeSteam_Click(sender As System.Object, e As System.EventArgs) Handles ButtonChangeSteam.Click
        Using FolderBrowserDialog1 As FolderBrowserDialog = New FolderBrowserDialog
            If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                TextBox4.Text = FolderBrowserDialog1.SelectedPath
            End If
            Dim steam_path, path As String
            steam_path = TextBox4.Text
            path = steam_path + "\SteamApps\common\dota 2 beta\dota\itembuilds"
            Check(path)
        End Using
    End Sub

    Private Sub ButtonOpenBackupFolder_Click(sender As System.Object, e As System.EventArgs) Handles ButtonOpenBackupFolder.Click
        System.Diagnostics.Process.Start("explorer", My.Settings.path + "\Backup")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        PictureBox166.Image = ChangePicture(ComboBox1.Text)
        ' aktuellen Inhalt der PictureBox als ToolTipText anzeigen
        If Not doImagesMatch(PictureBox166.Image, D2RIC.My.Resources.Resources.none) Then
            ToolTip1.SetToolTip(PictureBox166, GetToolTip(PicRes2Name(PictureBox166.Image)))
        Else
            ToolTip1.SetToolTip(PictureBox166, "none")
        End If
    End Sub

    Private WithEvents WebClient1 As New WebClient
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

    Private Sub ButtonUpdate_Click(sender As System.Object, e As System.EventArgs) Handles ButtonUpdate.Click
        LabelWait.Visible = True
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Check4Update()
    End Sub


    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As System.Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        LabelWait.Visible = False
    End Sub

    Dim FirstChange As Boolean = True
    Private Sub CheckBox5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If Not FirstChange Then
            If CheckBox5.Checked Then
                My.Settings.autoupdate = True
            Else
                My.Settings.autoupdate = False
            End If
        Else
            FirstChange = False
        End If
    End Sub

    Private Sub ChangeHeroList(ByVal cb As Object, ByVal lb As Object)
        Dim i As Integer
        If cb.SelectedItem = "All" Then
            lb.SelectedItems.Clear()
            For i = lb.Items.Count - 1 To 0 Step -1
                lb.Items.Remove(lb.Items(i).ToString)
            Next
            lb.Items.Add("Abaddon")
            lb.Items.Add("Alchemist")
            lb.Items.Add("Ancient Apparition")
            lb.Items.Add("Anti-Mage")
            lb.Items.Add("Axe")
            lb.Items.Add("Bane")
            lb.Items.Add("Batrider")
            lb.Items.Add("Beastmaster")
            lb.Items.Add("Bloodseeker")
            lb.Items.Add("Bounty Hunter")
            lb.Items.Add("Bristleback")
            lb.Items.Add("Broodmother")
            lb.Items.Add("Centaur Warchief")
            lb.Items.Add("Chaos Knight")
            lb.Items.Add("Chen")
            lb.Items.Add("Clinkz")
            lb.Items.Add("Clockwerk")
            lb.Items.Add("Crystal Maiden")
            lb.Items.Add("Dark Seer")
            lb.Items.Add("Dazzle")
            lb.Items.Add("Death Prophet")
            lb.Items.Add("Dirge")
            lb.Items.Add("Disruptor")
            lb.Items.Add("Doom Bringer")
            lb.Items.Add("Dragon Knight")
            lb.Items.Add("Drow Ranger")
            lb.Items.Add("Earthshaker")
            lb.Items.Add("Ember Spirit")
            lb.Items.Add("Enchantress")
            lb.Items.Add("Enigma")
            lb.Items.Add("Faceless Void")
            lb.Items.Add("Goblin Shredder")
            lb.Items.Add("Goblin Techies")
            lb.Items.Add("Guardian Wisp")
            lb.Items.Add("Gyrocopter")
            lb.Items.Add("Huskar")
            lb.Items.Add("Invoker")
            lb.Items.Add("Jakiro")
            lb.Items.Add("Juggernaut")
            lb.Items.Add("Keeper of the Light")
            lb.Items.Add("Kunkka")
            lb.Items.Add("Lanaya")
            lb.Items.Add("Legion Commander")
            lb.Items.Add("Leshrac")
            lb.Items.Add("Lich")
            lb.Items.Add("Lifestealer")
            lb.Items.Add("Lina")
            lb.Items.Add("Lion")
            lb.Items.Add("Lone Druid")
            lb.Items.Add("Luna")
            lb.Items.Add("Lycanthrope")
            lb.Items.Add("Magnataur")
            lb.Items.Add("Medusa")
            lb.Items.Add("Meepo")
            lb.Items.Add("Mirana")
            lb.Items.Add("Morphling")
            lb.Items.Add("Mortred")
            lb.Items.Add("Naga Siren")
            lb.Items.Add("Nature's Prophet")
            lb.Items.Add("Necrolyte")
            lb.Items.Add("Nerubian Assassin")
            lb.Items.Add("Night Stalker")
            lb.Items.Add("Obsidian Destroyer")
            lb.Items.Add("Ogre Magi")
            lb.Items.Add("Omniknight")
            lb.Items.Add("Pandaren Brewmaster")
            lb.Items.Add("Phantom Lancer")
            lb.Items.Add("Phoenix")
            lb.Items.Add("Pit Lord")
            lb.Items.Add("Puck")
            lb.Items.Add("Pudge")
            lb.Items.Add("Pugna")
            lb.Items.Add("Queen of Pain")
            lb.Items.Add("Razor")
            lb.Items.Add("Riki")
            lb.Items.Add("Rubick")
            lb.Items.Add("Sand King")
            lb.Items.Add("Shadow Demon")
            lb.Items.Add("Shadow Fiend")
            lb.Items.Add("Shadow Shaman")
            lb.Items.Add("Silencer")
            lb.Items.Add("Skeleton King")
            lb.Items.Add("Skywrath Mage")
            lb.Items.Add("Slardar")
            lb.Items.Add("Slark")
            lb.Items.Add("Sniper")
            lb.Items.Add("Soul Keeper")
            lb.Items.Add("Spectre")
            lb.Items.Add("Spirit Breaker")
            lb.Items.Add("Storm Spirit")
            lb.Items.Add("Sven")
            lb.Items.Add("Tauren Chieftain")
            lb.Items.Add("Tidehunter")
            lb.Items.Add("Tinker")
            lb.Items.Add("Tiny")
            lb.Items.Add("Treant Protector")
            lb.Items.Add("Troll Warlord")
            lb.Items.Add("Tuskarr")
            lb.Items.Add("Ursa")
            lb.Items.Add("Vengeful Spirit")
            lb.Items.Add("Venomancer")
            lb.Items.Add("Viper")
            lb.Items.Add("Visage")
            lb.Items.Add("Warlock")
            lb.Items.Add("Weaver")
            lb.Items.Add("Windrunner")
            lb.Items.Add("Witch Doctor")
            lb.Items.Add("Zeus")
        ElseIf cb.SelectedItem = "Carry" Then
            lb.SelectedItems.Clear()
            For i = lb.Items.Count - 1 To 0 Step -1
                lb.Items.Remove(lb.Items(i).ToString)
            Next
            lb.Items.Add("Abaddon")
            lb.Items.Add("Alchemist")
            lb.Items.Add("Anti-Mage")
            lb.Items.Add("Bloodseeker")
            lb.Items.Add("Bounty Hunter")
            lb.Items.Add("Bristleback")
            lb.Items.Add("Broodmother")
            lb.Items.Add("Clinkz")
            lb.Items.Add("Dirge")
            lb.Items.Add("Doom Bringer")
            lb.Items.Add("Dragon Knight")
            lb.Items.Add("Drow Ranger")
            lb.Items.Add("Ember Spirit")
            lb.Items.Add("Faceless Void")
            lb.Items.Add("Goblin Shredder")
            lb.Items.Add("Goblin Techies")
            lb.Items.Add("Guardian Wisp")
            lb.Items.Add("Gyrocopter")
            lb.Items.Add("Huskar")
            lb.Items.Add("Invoker")
            lb.Items.Add("Juggernaut")
            lb.Items.Add("Keeper of the Light")
            lb.Items.Add("Kunkka")
            lb.Items.Add("Lanaya")
            lb.Items.Add("Legion Commander")
            lb.Items.Add("Leshrac")
            lb.Items.Add("Lone Druid")
            lb.Items.Add("Luna")
            lb.Items.Add("Lycanthrope")
            lb.Items.Add("Magnataur")
            lb.Items.Add("Medusa")
            lb.Items.Add("Meepo")
            lb.Items.Add("Mirana")
            lb.Items.Add("Morphling")
            lb.Items.Add("Mortred")
            lb.Items.Add("Naga Siren")
            lb.Items.Add("Necrolyte")
            lb.Items.Add("Night Stalker")
            lb.Items.Add("Obsidian Destroyer")
            lb.Items.Add("Ogre Magi")
            lb.Items.Add("Phantom Lancer")
            lb.Items.Add("Phoenix")
            lb.Items.Add("Pit Lord")
            lb.Items.Add("Queen of Pain")
            lb.Items.Add("Razor")
            lb.Items.Add("Riki")
            lb.Items.Add("Rubick")
            lb.Items.Add("Shadow Demon")
            lb.Items.Add("Shadow Fiend")
            lb.Items.Add("Silencer")
            lb.Items.Add("Skeleton King")
            lb.Items.Add("Skywrath Mage")
            lb.Items.Add("Slardar")
            lb.Items.Add("Slark")
            lb.Items.Add("Sniper")
            lb.Items.Add("Soul Keeper")
            lb.Items.Add("Spectre")
            lb.Items.Add("Storm Spirit")
            lb.Items.Add("Sven")
            lb.Items.Add("Tauren Chieftain")
            lb.Items.Add("Tinker")
            lb.Items.Add("Treant Protector")
            lb.Items.Add("Troll Warlord")
            lb.Items.Add("Tuskarr")
            lb.Items.Add("Ursa")
            lb.Items.Add("Venomancer")
            lb.Items.Add("Viper")
            lb.Items.Add("Visage")
            lb.Items.Add("Weaver")
            lb.Items.Add("Windrunner")
        ElseIf cb.SelectedItem = "Support" Then
            lb.SelectedItems.Clear()
            For i = lb.Items.Count - 1 To 0 Step -1
                lb.Items.Remove(lb.Items(i).ToString)
            Next
            lb.Items.Add("Abaddon")
            lb.Items.Add("Ancient Apparition")
            lb.Items.Add("Bane")
            lb.Items.Add("Chen")
            lb.Items.Add("Crystal Maiden")
            lb.Items.Add("Dark Seer")
            lb.Items.Add("Dazzle")
            lb.Items.Add("Disruptor")
            lb.Items.Add("Goblin Techies")
            lb.Items.Add("Guardian Wisp")
            lb.Items.Add("Invoker")
            lb.Items.Add("Keeper of the Light")
            lb.Items.Add("Lich")
            lb.Items.Add("Lion")
            lb.Items.Add("Necrolyte")
            lb.Items.Add("Obsidian Destroyer")
            lb.Items.Add("Ogre Magi")
            lb.Items.Add("Omniknight")
            lb.Items.Add("Rubick")
            lb.Items.Add("Shadow Demon")
            lb.Items.Add("Silencer")
            lb.Items.Add("Skywrath Mage")
            lb.Items.Add("Vengeful Spirit")
            lb.Items.Add("Warlock")
            lb.Items.Add("Witch Doctor")
        ElseIf cb.SelectedItem = "Ganker" Then
            lb.SelectedItems.Clear()
            For i = lb.Items.Count - 1 To 0 Step -1
                lb.Items.Remove(lb.Items(i).ToString)
            Next
            lb.Items.Add("Ancient Apparition")
            lb.Items.Add("Bane")
            lb.Items.Add("Batrider")
            lb.Items.Add("Beastmaster")
            lb.Items.Add("Bloodseeker")
            lb.Items.Add("Bounty Hunter")
            lb.Items.Add("Bristleback")
            lb.Items.Add("Chaos Knight")
            lb.Items.Add("Clockwerk")
            lb.Items.Add("Dirge")
            lb.Items.Add("Disruptor")
            lb.Items.Add("Doom Bringer")
            lb.Items.Add("Earthshaker")
            lb.Items.Add("Ember Spirit")
            lb.Items.Add("Goblin Shredder")
            lb.Items.Add("Goblin Techies")
            lb.Items.Add("Guardian Wisp")
            lb.Items.Add("Invoker")
            lb.Items.Add("Jakiro")
            lb.Items.Add("Keeper of the Light")
            lb.Items.Add("Kunkka")
            lb.Items.Add("Lanaya")
            lb.Items.Add("Legion Commander")
            lb.Items.Add("Lich")
            lb.Items.Add("Lifestealer")
            lb.Items.Add("Lina")
            lb.Items.Add("Lion")
            lb.Items.Add("Lone Druid")
            lb.Items.Add("Lycanthrope")
            lb.Items.Add("Magnataur")
            lb.Items.Add("Medusa")
            lb.Items.Add("Mirana")
            lb.Items.Add("Morphling")
            lb.Items.Add("Naga Siren")
            lb.Items.Add("Nature's Prophet")
            lb.Items.Add("Nerubian Assassin")
            lb.Items.Add("Night Stalker")
            lb.Items.Add("Obsidian Destroyer")
            lb.Items.Add("Ogre Magi")
            lb.Items.Add("Phoenix")
            lb.Items.Add("Pit Lord")
            lb.Items.Add("Pudge")
            lb.Items.Add("Queen of Pain")
            lb.Items.Add("Riki")
            lb.Items.Add("Rubick")
            lb.Items.Add("Sand King")
            lb.Items.Add("Shadow Demon")
            lb.Items.Add("Skywrath Mage")
            lb.Items.Add("Slark")
            lb.Items.Add("Soul Keeper")
            lb.Items.Add("Spirit Breaker")
            lb.Items.Add("Storm Spirit")
            lb.Items.Add("Sven")
            lb.Items.Add("Tauren Chieftain")
            lb.Items.Add("Tidehunter")
            lb.Items.Add("Tinker")
            lb.Items.Add("Tiny")
            lb.Items.Add("Treant Protector")
            lb.Items.Add("Tuskarr")
            lb.Items.Add("Vengeful Spirit")
            lb.Items.Add("Visage")
            lb.Items.Add("Weaver")
            lb.Items.Add("Witch Doctor")
            lb.Items.Add("Zeus")
        ElseIf cb.SelectedItem = "Initiator" Then
            lb.SelectedItems.Clear()
            For i = lb.Items.Count - 1 To 0 Step -1
                lb.Items.Remove(lb.Items(i).ToString)
            Next
            lb.Items.Add("Axe")
            lb.Items.Add("Clockwerk")
            lb.Items.Add("Earthshaker")
            lb.Items.Add("Enigma")
            lb.Items.Add("Magnataur")
            lb.Items.Add("Pandaren Brewmaster")
            lb.Items.Add("Phoenix")
            lb.Items.Add("Puck")
            lb.Items.Add("Pudge")
            lb.Items.Add("Sand King")
            lb.Items.Add("Slardar")
            lb.Items.Add("Slark")
            lb.Items.Add("Tidehunter")
            lb.Items.Add("Tiny")
            lb.Items.Add("Treant Protector")
            lb.Items.Add("Tuskarr")
        ElseIf cb.SelectedItem = "Pusher" Then
            lb.SelectedItems.Clear()
            For i = lb.Items.Count - 1 To 0 Step -1
                lb.Items.Remove(lb.Items(i).ToString)
            Next
            lb.Items.Add("Broodmother")
            lb.Items.Add("Chen")
            lb.Items.Add("Death Prophet")
            lb.Items.Add("Enchantress")
            lb.Items.Add("Goblin Techies")
            lb.Items.Add("Invoker")
            lb.Items.Add("Keeper of the Light")
            lb.Items.Add("Kunkka")
            lb.Items.Add("Leshrac")
            lb.Items.Add("Meepo")
            lb.Items.Add("Nature's Prophet")
            lb.Items.Add("Necrolyte")
            lb.Items.Add("Phantom Lancer")
            lb.Items.Add("Pit Lord")
            lb.Items.Add("Pugna")
            lb.Items.Add("Shadow Shaman")
            lb.Items.Add("Tauren Chieftain")
            lb.Items.Add("Tinker")
            lb.Items.Add("Venomancer")
        ElseIf cb.SelectedItem = "Jungler" Then
            lb.SelectedItems.Clear()
            For i = lb.Items.Count - 1 To 0 Step -1
                lb.Items.Remove(lb.Items(i).ToString)
            Next
            lb.Items.Add("Axe")
            lb.Items.Add("Chen")
            lb.Items.Add("Enigma")
            lb.Items.Add("Lycanthrope")
            lb.Items.Add("Nature's Prophet")
            lb.Items.Add("Pit Lord")
            lb.Items.Add("Ursa")
        ElseIf cb.SelectedItem = "Tank" Then
            lb.SelectedItems.Clear()
            For i = lb.Items.Count - 1 To 0 Step -1
                lb.Items.Remove(lb.Items(i).ToString)
            Next
            lb.Items.Add("Abaddon")
            lb.Items.Add("Bristleback")
            lb.Items.Add("Centaur Warchief")
            lb.Items.Add("Death Prophet")
            lb.Items.Add("Dirge")
            lb.Items.Add("Goblin Shredder")
            lb.Items.Add("Guardian Wisp")
            lb.Items.Add("Legion Commander")
            lb.Items.Add("Lone Druid")
            lb.Items.Add("Lycanthrope")
            lb.Items.Add("Magnataur")
            lb.Items.Add("Pandaren Brewmaster")
            lb.Items.Add("Phoenix")
            lb.Items.Add("Pit Lord")
            lb.Items.Add("Skeleton King")
            lb.Items.Add("Tauren Chieftain")
            lb.Items.Add("Treant Protector")
            lb.Items.Add("Tuskarr")
            lb.Items.Add("Visage")
        ElseIf cb.SelectedItem = "Strength" Then
            lb.SelectedItems.Clear()
            For i = lb.Items.Count - 1 To 0 Step -1
                lb.Items.Remove(lb.Items(i).ToString)
            Next
            lb.Items.Add("Abaddon")
            lb.Items.Add("Alchemist")
            lb.Items.Add("Axe")
            lb.Items.Add("Beastmaster")
            lb.Items.Add("Bristleback")
            lb.Items.Add("Centaur Warchief")
            lb.Items.Add("Chaos Knight")
            lb.Items.Add("Clockwerk")
            lb.Items.Add("Dirge")
            lb.Items.Add("Doom Bringer")
            lb.Items.Add("Dragon Knight")
            lb.Items.Add("Earthshaker")
            lb.Items.Add("Goblin Shredder")
            lb.Items.Add("Guardian Wisp")
            lb.Items.Add("Huskar")
            lb.Items.Add("Kunkka")
            lb.Items.Add("Legion Commander")
            lb.Items.Add("Lifestealer")
            lb.Items.Add("Lycanthrope")
            lb.Items.Add("Magnataur")
            lb.Items.Add("Night Stalker")
            lb.Items.Add("Omniknight")
            lb.Items.Add("Pandaren Brewmaster")
            lb.Items.Add("Phoenix")
            lb.Items.Add("Pit Lord")
            lb.Items.Add("Pudge")
            lb.Items.Add("Sand King")
            lb.Items.Add("Skeleton King")
            lb.Items.Add("Slardar")
            lb.Items.Add("Spirit Breaker")
            lb.Items.Add("Sven")
            lb.Items.Add("Tauren Chieftain")
            lb.Items.Add("Tidehunter")
            lb.Items.Add("Tiny")
            lb.Items.Add("Treant Protector")
            lb.Items.Add("Tuskarr")
        ElseIf cb.SelectedItem = "Agility" Then
            lb.SelectedItems.Clear()
            For i = lb.Items.Count - 1 To 0 Step -1
                lb.Items.Remove(lb.Items(i).ToString)
            Next
            lb.Items.Add("Anti-Mage")
            lb.Items.Add("Bloodseeker")
            lb.Items.Add("Bounty Hunter")
            lb.Items.Add("Broodmother")
            lb.Items.Add("Clinkz")
            lb.Items.Add("Drow Ranger")
            lb.Items.Add("Ember Spirit")
            lb.Items.Add("Faceless Void")
            lb.Items.Add("Gyrocopter")
            lb.Items.Add("Juggernaut")
            lb.Items.Add("Lanaya")
            lb.Items.Add("Lone Druid")
            lb.Items.Add("Luna")
            lb.Items.Add("Medusa")
            lb.Items.Add("Meepo")
            lb.Items.Add("Mirana")
            lb.Items.Add("Morphling")
            lb.Items.Add("Mortred")
            lb.Items.Add("Naga Siren")
            lb.Items.Add("Nerubian Assassin")
            lb.Items.Add("Phantom Lancer")
            lb.Items.Add("Razor")
            lb.Items.Add("Riki")
            lb.Items.Add("Shadow Fiend")
            lb.Items.Add("Slark")
            lb.Items.Add("Sniper")
            lb.Items.Add("Soul Keeper")
            lb.Items.Add("Spectre")
            lb.Items.Add("Troll Warlord")
            lb.Items.Add("Ursa")
            lb.Items.Add("Vengeful Spirit")
            lb.Items.Add("Venomancer")
            lb.Items.Add("Viper")
            lb.Items.Add("Weaver")
        ElseIf cb.SelectedItem = "Intelligence" Then
            lb.SelectedItems.Clear()
            For i = lb.Items.Count - 1 To 0 Step -1
                lb.Items.Remove(lb.Items(i).ToString)
            Next
            lb.Items.Add("Ancient Apparition")
            lb.Items.Add("Bane")
            lb.Items.Add("Batrider")
            lb.Items.Add("Chen")
            lb.Items.Add("Crystal Maiden")
            lb.Items.Add("Dark Seer")
            lb.Items.Add("Dazzle")
            lb.Items.Add("Death Prophet")
            lb.Items.Add("Disruptor")
            lb.Items.Add("Enchantress")
            lb.Items.Add("Enigma")
            lb.Items.Add("Goblin Techies")
            lb.Items.Add("Invoker")
            lb.Items.Add("Jakiro")
            lb.Items.Add("Keeper of the Light")
            lb.Items.Add("Leshrac")
            lb.Items.Add("Lich")
            lb.Items.Add("Lina")
            lb.Items.Add("Lion")
            lb.Items.Add("Nature's Prophet")
            lb.Items.Add("Necrolyte")
            lb.Items.Add("Obsidian Destroyer")
            lb.Items.Add("Ogre Magi")
            lb.Items.Add("Puck")
            lb.Items.Add("Pugna")
            lb.Items.Add("Queen of Pain")
            lb.Items.Add("Rubick")
            lb.Items.Add("Shadow Demon")
            lb.Items.Add("Shadow Shaman")
            lb.Items.Add("Silencer")
            lb.Items.Add("Skywrath Mage")
            lb.Items.Add("Storm Spirit")
            lb.Items.Add("Tinker")
            lb.Items.Add("Visage")
            lb.Items.Add("Warlock")
            lb.Items.Add("Windrunner")
            lb.Items.Add("Witch Doctor")
            lb.Items.Add("Zeus")
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        ChangeHeroList(ComboBox3, ListBox1)
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        If ComboBox5.SelectedItem = "DotA Like" Then
            Label13.Visible = True
            Label14.Visible = True
            Label15.Visible = True
            Label16.Visible = True
            Label17.Visible = True
            Label18.Visible = True
            Label19.Visible = True
            Label20.Visible = True
            Label21.Visible = True
            Label22.Visible = True
            Label23.Visible = True
            RectangleShape1.Visible = True
            RectangleShape2.Visible = True
            RectangleShape3.Visible = True
            RectangleShape4.Visible = True
            RectangleShape5.Visible = True
            RectangleShape6.Visible = True
            RectangleShape7.Visible = True
            RectangleShape8.Visible = True
            RectangleShape9.Visible = True
            RectangleShape10.Visible = True
            RectangleShape11.Visible = True
            'Consumables
            PictureBox54.Location = New Point(159, 238)
            PictureBox149.Location = New Point(205, 238)
            PictureBox84.Location = New Point(251, 238)
            PictureBox143.Location = New Point(297, 238)
            PictureBox150.Location = New Point(159, 274)
            PictureBox70.Location = New Point(205, 274)
            PictureBox32.Location = New Point(251, 274)
            PictureBox76.Location = New Point(297, 274)
            PictureBox110.Location = New Point(159, 310)
            PictureBox138.Location = New Point(205, 310)
            PictureBox47.Location = New Point(251, 310)
            'Attributes
            PictureBox90.Location = New Point(350, 238)
            PictureBox78.Location = New Point(396, 238)
            PictureBox142.Location = New Point(442, 238)
            PictureBox97.Location = New Point(488, 238)
            PictureBox53.Location = New Point(350, 274)
            PictureBox37.Location = New Point(396, 274)
            PictureBox44.Location = New Point(442, 274)
            PictureBox131.Location = New Point(488, 274)
            PictureBox111.Location = New Point(350, 310)
            PictureBox40.Location = New Point(396, 310)
            PictureBox146.Location = New Point(442, 310)
            PictureBox151.Location = New Point(488, 310)
            'Armaments
            PictureBox129.Location = New Point(543, 238)
            PictureBox123.Location = New Point(589, 238)
            PictureBox147.Location = New Point(635, 238)
            PictureBox41.Location = New Point(681, 238)
            PictureBox52.Location = New Point(543, 274)
            PictureBox86.Location = New Point(589, 274)
            PictureBox49.Location = New Point(635, 274)
            PictureBox122.Location = New Point(681, 274)
            PictureBox55.Location = New Point(543, 310)
            PictureBox91.Location = New Point(589, 310)
            PictureBox117.Location = New Point(635, 310)
            PictureBox101.Location = New Point(681, 310)
            'Arcane
            PictureBox94.Location = New Point(736, 238)
            PictureBox133.Location = New Point(782, 238)
            PictureBox130.Location = New Point(828, 238)
            PictureBox45.Location = New Point(874, 238)
            PictureBox81.Location = New Point(736, 274)
            PictureBox56.Location = New Point(782, 274)
            PictureBox79.Location = New Point(828, 274)
            PictureBox104.Location = New Point(874, 274)
            PictureBox80.Location = New Point(736, 310)
            PictureBox148.Location = New Point(782, 310)
            PictureBox42.Location = New Point(828, 310)
            'Common
            PictureBox158.Location = New Point(159, 380)
            PictureBox108.Location = New Point(205, 380)
            PictureBox95.Location = New Point(251, 380)
            PictureBox48.Location = New Point(297, 380)
            PictureBox119.Location = New Point(159, 416)
            PictureBox145.Location = New Point(205, 416)
            PictureBox115.Location = New Point(251, 416)
            PictureBox120.Location = New Point(297, 416)
            PictureBox109.Location = New Point(159, 452)
            PictureBox114.Location = New Point(205, 452)
            PictureBox82.Location = New Point(251, 452)
            PictureBox46.Location = New Point(297, 452)
            'Weapons
            PictureBox57.Location = New Point(350, 380)
            PictureBox34.Location = New Point(396, 380)
            PictureBox141.Location = New Point(442, 380)
            PictureBox139.Location = New Point(488, 380)
            PictureBox36.Location = New Point(350, 416)
            PictureBox73.Location = New Point(396, 416)
            PictureBox124.Location = New Point(442, 416)
            PictureBox103.Location = New Point(488, 416)
            PictureBox58.Location = New Point(350, 452)
            PictureBox51.Location = New Point(396, 452)
            PictureBox68.Location = New Point(442, 452)
            PictureBox160.Location = New Point(488, 452)
            'Support
            PictureBox127.Location = New Point(543, 380)
            PictureBox83.Location = New Point(589, 380)
            PictureBox50.Location = New Point(635, 380)
            PictureBox152.Location = New Point(681, 380)
            PictureBox99.Location = New Point(543, 416)
            PictureBox33.Location = New Point(589, 416)
            PictureBox69.Location = New Point(635, 416)
            PictureBox156.Location = New Point(681, 416)
            PictureBox100.Location = New Point(543, 452)
            PictureBox116.Location = New Point(589, 452)
            PictureBox162.Location = New Point(635, 452)
            PictureBox164.Location = New Point(681, 452)
            'Caster
            PictureBox77.Location = New Point(736, 380)
            PictureBox121.Location = New Point(782, 380)
            PictureBox106.Location = New Point(828, 380)
            PictureBox107.Location = New Point(874, 380)
            PictureBox74.Location = New Point(736, 416)
            PictureBox59.Location = New Point(782, 416)
            PictureBox60.Location = New Point(828, 416)
            PictureBox61.Location = New Point(874, 416)
            PictureBox62.Location = New Point(736, 452)
            PictureBox63.Location = New Point(782, 452)
            PictureBox154.Location = New Point(828, 452)
            PictureBox31.Location = New Point(874, 452)
            PictureBox113.Location = New Point(736, 488)
            PictureBox126.Location = New Point(782, 488)
            PictureBox137.Location = New Point(828, 488)
            PictureBox163.Location = New Point(874, 488)
            'Armor
            PictureBox88.Location = New Point(159, 526)
            PictureBox39.Location = New Point(205, 526)
            PictureBox153.Location = New Point(251, 526)
            PictureBox144.Location = New Point(297, 526)
            PictureBox38.Location = New Point(159, 562)
            PictureBox140.Location = New Point(205, 562)
            PictureBox96.Location = New Point(251, 562)
            PictureBox43.Location = New Point(297, 562)
            PictureBox92.Location = New Point(159, 598)
            PictureBox35.Location = New Point(205, 598)
            PictureBox85.Location = New Point(251, 598)
            'Artifacts
            PictureBox87.Location = New Point(350, 526)
            PictureBox98.Location = New Point(396, 526)
            PictureBox134.Location = New Point(442, 526)
            PictureBox159.Location = New Point(488, 526)
            PictureBox93.Location = New Point(350, 562)
            PictureBox66.Location = New Point(396, 562)
            PictureBox67.Location = New Point(442, 562)
            PictureBox65.Location = New Point(488, 562)
            PictureBox135.Location = New Point(350, 598)
            PictureBox102.Location = New Point(396, 598)
            PictureBox75.Location = New Point(442, 598)
            PictureBox136.Location = New Point(488, 598)
            PictureBox161.Location = New Point(350, 634)
            'Secret Shop
            PictureBox112.Location = New Point(543, 526)
            PictureBox128.Location = New Point(589, 526)
            PictureBox157.Location = New Point(635, 526)
            PictureBox72.Location = New Point(681, 526)
            PictureBox155.Location = New Point(543, 562)
            PictureBox118.Location = New Point(589, 562)
            PictureBox89.Location = New Point(635, 562)
            PictureBox64.Location = New Point(681, 562)
            PictureBox105.Location = New Point(543, 598)
            PictureBox125.Location = New Point(589, 598)
            PictureBox71.Location = New Point(635, 598)
            PictureBox132.Location = New Point(681, 598)
            'Delete
            PictureBox165.Location = New Point(782, 562)
        Else
            Label13.Visible = False
            Label14.Visible = False
            Label15.Visible = False
            Label16.Visible = False
            Label17.Visible = False
            Label18.Visible = False
            Label19.Visible = False
            Label20.Visible = False
            Label21.Visible = False
            Label22.Visible = False
            Label23.Visible = False
            RectangleShape1.Visible = False
            RectangleShape2.Visible = False
            RectangleShape3.Visible = False
            RectangleShape4.Visible = False
            RectangleShape5.Visible = False
            RectangleShape6.Visible = False
            RectangleShape7.Visible = False
            RectangleShape8.Visible = False
            RectangleShape9.Visible = False
            RectangleShape10.Visible = False
            RectangleShape11.Visible = False
            PictureBox160.Location = New Point(201, 276)
            PictureBox31.Location = New Point(247, 276)
            PictureBox32.Location = New Point(293, 276)
            PictureBox33.Location = New Point(339, 276)
            PictureBox34.Location = New Point(385, 276)
            PictureBox35.Location = New Point(431, 276)
            PictureBox36.Location = New Point(477, 276)
            PictureBox37.Location = New Point(523, 276)
            PictureBox38.Location = New Point(569, 276)
            PictureBox39.Location = New Point(615, 276)
            PictureBox40.Location = New Point(661, 276)
            PictureBox41.Location = New Point(707, 276)
            PictureBox42.Location = New Point(753, 276)
            PictureBox43.Location = New Point(799, 276)
            PictureBox44.Location = New Point(845, 276)
            PictureBox45.Location = New Point(201, 312)
            PictureBox46.Location = New Point(247, 312)
            PictureBox47.Location = New Point(293, 312)
            PictureBox48.Location = New Point(339, 312)
            PictureBox49.Location = New Point(385, 312)
            PictureBox50.Location = New Point(431, 312)
            PictureBox51.Location = New Point(477, 312)
            PictureBox52.Location = New Point(523, 312)
            PictureBox53.Location = New Point(569, 312)
            PictureBox54.Location = New Point(615, 312)
            PictureBox55.Location = New Point(661, 312)
            PictureBox56.Location = New Point(707, 312)
            PictureBox57.Location = New Point(753, 312)
            PictureBox58.Location = New Point(799, 312)
            PictureBox59.Location = New Point(845, 312)
            PictureBox60.Location = New Point(201, 348)
            PictureBox61.Location = New Point(247, 348)
            PictureBox62.Location = New Point(293, 348)
            PictureBox63.Location = New Point(339, 348)
            PictureBox64.Location = New Point(385, 348)
            PictureBox65.Location = New Point(431, 348)
            PictureBox66.Location = New Point(477, 348)
            PictureBox67.Location = New Point(523, 348)
            PictureBox68.Location = New Point(569, 348)
            PictureBox69.Location = New Point(615, 348)
            PictureBox70.Location = New Point(661, 348)
            PictureBox71.Location = New Point(707, 348)
            PictureBox72.Location = New Point(753, 348)
            PictureBox73.Location = New Point(799, 348)
            PictureBox74.Location = New Point(845, 348)
            PictureBox75.Location = New Point(201, 384)
            PictureBox76.Location = New Point(247, 384)
            PictureBox77.Location = New Point(293, 384)
            PictureBox78.Location = New Point(339, 384)
            PictureBox79.Location = New Point(385, 384)
            PictureBox80.Location = New Point(431, 384)
            PictureBox81.Location = New Point(477, 384)
            PictureBox82.Location = New Point(523, 384)
            PictureBox83.Location = New Point(569, 384)
            PictureBox84.Location = New Point(615, 384)
            PictureBox85.Location = New Point(661, 384)
            PictureBox161.Location = New Point(707, 384)
            PictureBox86.Location = New Point(753, 384)
            PictureBox87.Location = New Point(799, 384)
            PictureBox88.Location = New Point(845, 384)
            PictureBox89.Location = New Point(201, 420)
            PictureBox90.Location = New Point(247, 420)
            PictureBox91.Location = New Point(293, 420)
            PictureBox92.Location = New Point(339, 420)
            PictureBox93.Location = New Point(385, 420)
            PictureBox94.Location = New Point(431, 420)
            PictureBox95.Location = New Point(477, 420)
            PictureBox96.Location = New Point(523, 420)
            PictureBox97.Location = New Point(569, 420)
            PictureBox98.Location = New Point(615, 420)
            PictureBox99.Location = New Point(661, 420)
            PictureBox100.Location = New Point(707, 420)
            PictureBox101.Location = New Point(753, 420)
            PictureBox102.Location = New Point(799, 420)
            PictureBox103.Location = New Point(845, 420)
            PictureBox104.Location = New Point(201, 456)
            PictureBox105.Location = New Point(247, 456)
            PictureBox121.Location = New Point(293, 456)
            PictureBox106.Location = New Point(339, 456)
            PictureBox107.Location = New Point(385, 456)
            PictureBox108.Location = New Point(431, 456)
            PictureBox109.Location = New Point(477, 456)
            PictureBox110.Location = New Point(523, 456)
            PictureBox111.Location = New Point(569, 456)
            PictureBox112.Location = New Point(615, 456)
            PictureBox113.Location = New Point(661, 456)
            PictureBox114.Location = New Point(707, 456)
            PictureBox115.Location = New Point(753, 456)
            PictureBox116.Location = New Point(799, 456)
            PictureBox117.Location = New Point(845, 456)
            PictureBox118.Location = New Point(201, 492)
            PictureBox119.Location = New Point(247, 492)
            PictureBox120.Location = New Point(293, 492)
            PictureBox122.Location = New Point(339, 492)
            PictureBox123.Location = New Point(385, 492)
            PictureBox124.Location = New Point(431, 492)
            PictureBox125.Location = New Point(477, 492)
            PictureBox126.Location = New Point(523, 492)
            PictureBox127.Location = New Point(569, 492)
            PictureBox162.Location = New Point(615, 492)
            PictureBox128.Location = New Point(661, 492)
            PictureBox129.Location = New Point(707, 492)
            PictureBox130.Location = New Point(753, 492)
            PictureBox131.Location = New Point(799, 492)
            PictureBox132.Location = New Point(845, 492)
            PictureBox163.Location = New Point(201, 528)
            PictureBox133.Location = New Point(247, 528)
            PictureBox134.Location = New Point(293, 528)
            PictureBox135.Location = New Point(339, 528)
            PictureBox136.Location = New Point(385, 528)
            PictureBox137.Location = New Point(431, 528)
            PictureBox138.Location = New Point(477, 528)
            PictureBox139.Location = New Point(523, 528)
            PictureBox140.Location = New Point(569, 528)
            PictureBox141.Location = New Point(615, 528)
            PictureBox142.Location = New Point(661, 528)
            PictureBox143.Location = New Point(707, 528)
            PictureBox144.Location = New Point(753, 528)
            PictureBox145.Location = New Point(799, 528)
            PictureBox146.Location = New Point(845, 528)
            PictureBox147.Location = New Point(201, 564)
            PictureBox148.Location = New Point(247, 564)
            PictureBox149.Location = New Point(293, 564)
            PictureBox150.Location = New Point(339, 564)
            PictureBox164.Location = New Point(385, 564)
            PictureBox151.Location = New Point(431, 564)
            PictureBox152.Location = New Point(477, 564)
            PictureBox153.Location = New Point(523, 564)
            PictureBox154.Location = New Point(569, 564)
            PictureBox155.Location = New Point(615, 564)
            PictureBox156.Location = New Point(661, 564)
            PictureBox157.Location = New Point(707, 564)
            PictureBox158.Location = New Point(753, 564)
            PictureBox159.Location = New Point(799, 564)
            PictureBox165.Location = New Point(845, 564)
        End If
    End Sub
End Class