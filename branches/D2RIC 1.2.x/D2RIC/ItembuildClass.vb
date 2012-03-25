Public Class ItembuildClass
    Public NeuerText As String
    Public Shared Selected_Hero As String

    Public Sub Initialize()
        'ALLOW TO DROP SOMETHING IN THE PICTUREBOX
        FormMain.Item1.AllowDrop = True
        FormMain.Item2.AllowDrop = True
        FormMain.Item3.AllowDrop = True
        FormMain.Item4.AllowDrop = True
        FormMain.Item5.AllowDrop = True
        FormMain.Item6.AllowDrop = True
        FormMain.Item7.AllowDrop = True
        FormMain.Item8.AllowDrop = True
        FormMain.Item9.AllowDrop = True
        FormMain.Item10.AllowDrop = True
        FormMain.Item11.AllowDrop = True
        FormMain.Item12.AllowDrop = True
        FormMain.Item13.AllowDrop = True
        FormMain.Item14.AllowDrop = True
        FormMain.Item15.AllowDrop = True
        FormMain.Item16.AllowDrop = True
        FormMain.Item17.AllowDrop = True
        FormMain.Item18.AllowDrop = True
        FormMain.Item19.AllowDrop = True
        FormMain.Item20.AllowDrop = True
        FormMain.Item21.AllowDrop = True
        FormMain.Item22.AllowDrop = True
        FormMain.Item23.AllowDrop = True
        FormMain.Item24.AllowDrop = True
        FormMain.Item25.AllowDrop = True
        FormMain.Item26.AllowDrop = True
        FormMain.Item27.AllowDrop = True
        FormMain.Item28.AllowDrop = True
        FormMain.Item29.AllowDrop = True
        FormMain.Item30.AllowDrop = True
        FormMain.Item31.AllowDrop = True
        FormMain.Item32.AllowDrop = True
        FormMain.Item33.AllowDrop = True
        FormMain.Item34.AllowDrop = True
        FormMain.Item35.AllowDrop = True
        FormMain.Item36.AllowDrop = True
        FormMain.Item37.AllowDrop = True
        FormMain.Item38.AllowDrop = True
        FormMain.Item39.AllowDrop = True
        'DISABLE THE SAVE BUTTON BECAUSE NO HERO IS CHOOSEN IF THE PROGRAM STARTS
        FormMain.ButtonSave.Enabled = False
        'SET TOOLTIPS
        With FormMain.ToolTip1
            .SetToolTip(FormMain.Item1, "none")
            .SetToolTip(FormMain.Item2, "none")
            .SetToolTip(FormMain.Item3, "none")
            .SetToolTip(FormMain.Item4, "none")
            .SetToolTip(FormMain.Item5, "none")
            .SetToolTip(FormMain.Item6, "none")
            .SetToolTip(FormMain.Item7, "none")
            .SetToolTip(FormMain.Item8, "none")
            .SetToolTip(FormMain.Item9, "none")
            .SetToolTip(FormMain.Item10, "none")
            .SetToolTip(FormMain.Item11, "none")
            .SetToolTip(FormMain.Item12, "none")
            .SetToolTip(FormMain.Item13, "none")
            .SetToolTip(FormMain.Item14, "none")
            .SetToolTip(FormMain.Item15, "none")
            .SetToolTip(FormMain.Item16, "none")
            .SetToolTip(FormMain.Item17, "none")
            .SetToolTip(FormMain.Item18, "none")
            .SetToolTip(FormMain.Item19, "none")
            .SetToolTip(FormMain.Item20, "none")
            .SetToolTip(FormMain.Item21, "none")
            .SetToolTip(FormMain.Item22, "none")
            .SetToolTip(FormMain.Item23, "none")
            .SetToolTip(FormMain.Item24, "none")
            .SetToolTip(FormMain.Item25, "none")
            .SetToolTip(FormMain.Item26, "none")
            .SetToolTip(FormMain.Item27, "none")
            .SetToolTip(FormMain.Item28, "none")
            .SetToolTip(FormMain.Item29, "none")
            .SetToolTip(FormMain.Item30, "none")
            .SetToolTip(FormMain.Item31, "none")
            .SetToolTip(FormMain.Item32, "none")
            .SetToolTip(FormMain.Item33, "none")
            .SetToolTip(FormMain.Item34, "none")
            .SetToolTip(FormMain.Item35, "none")
            .SetToolTip(FormMain.Item36, "none")
            .SetToolTip(FormMain.Item37, "none")
            .SetToolTip(FormMain.Item38, "none")
            .SetToolTip(FormMain.Item39, "none")
            .SetToolTip(FormMain.PictureBox31, "Aghanim's Scepter" + vbNewLine + vbNewLine + "+10 All Attributes" + vbNewLine + "+200 HP" + vbNewLine + "+150 Mana" + vbNewLine + "Ultimate Upgrade (passive)")
            .SetToolTip(FormMain.PictureBox32, "Animal Courier" + vbNewLine + vbNewLine + "Summon Animal Courier")
            .SetToolTip(FormMain.PictureBox33, "Arcane Boots" + vbNewLine + vbNewLine + "+65 Movement Speed " + vbNewLine + "+250 Mana" + vbNewLine + "Replenish Mana (active)")
            .SetToolTip(FormMain.PictureBox34, "Armlet" + vbNewLine + vbNewLine + "+9 Damage" + vbNewLine + "+15 Attack Speed" + vbNewLine + "+5 Armor" + vbNewLine + "+5 HP/sec Regeneration" + vbNewLine + "Unholy Strength (active)")
            .SetToolTip(FormMain.PictureBox35, "Assault Cuirass" + vbNewLine + vbNewLine + "+10 Armor" + vbNewLine + "+35 Attack Speed" + vbNewLine + "Positive Armor (Aura)" + vbNewLine + "Negative Armor (Aura)" + vbNewLine + "Attack Speed (Aura)")
            .SetToolTip(FormMain.PictureBox36, "Battle Fury" + vbNewLine + vbNewLine + "+65 Damage" + vbNewLine + "+6 HP/sec Regeneration" + vbNewLine + "+150% Mana Regeneration" + vbNewLine + "Cleave")
            .SetToolTip(FormMain.PictureBox37, "Belt of Strength" + vbNewLine + vbNewLine + "+6 Strength")
            .SetToolTip(FormMain.PictureBox38, "Black King Bar" + vbNewLine + vbNewLine + "+10 Strength" + vbNewLine + "+24 Damage" + vbNewLine + "Avatar (active)")
            .SetToolTip(FormMain.PictureBox39, "Blade Mail" + vbNewLine + vbNewLine + "+22 Damage" + vbNewLine + "+5 Armor" + vbNewLine + "+10 Intelligence" + vbNewLine + "Damage Return (active)")
            .SetToolTip(FormMain.PictureBox40, "Blade of Alacrity" + vbNewLine + vbNewLine + "+10 Agility")
            .SetToolTip(FormMain.PictureBox41, "Blades of Attack" + vbNewLine + vbNewLine + "+9 Damage")
            .SetToolTip(FormMain.PictureBox42, "Blink Dagger" + vbNewLine + vbNewLine + "Blink")
            .SetToolTip(FormMain.PictureBox43, "Bloodstone" + vbNewLine + vbNewLine + "+500 HP" + vbNewLine + "+400 Mana" + vbNewLine + "+8 HP/sec Regeneration" + vbNewLine + "+200% Mana Regeneration" + vbNewLine + "Bloodpact" + vbNewLine + "5 Charges")
            .SetToolTip(FormMain.PictureBox44, "Boots of Elvenskin" + vbNewLine + vbNewLine + "+6 Agility")
            .SetToolTip(FormMain.PictureBox45, "Boots of Speed" + vbNewLine + vbNewLine + "+55 Movement Speed")
            .SetToolTip(FormMain.PictureBox46, "Boots of Travel" + vbNewLine + vbNewLine + "+95 Movement Speed" + vbNewLine + "Teleport (active)")
            .SetToolTip(FormMain.PictureBox47, "Bottle" + vbNewLine + vbNewLine + "Regenerate" + vbNewLine + "Rune Capture")
            .SetToolTip(FormMain.PictureBox48, "Bracer" + vbNewLine + vbNewLine + "+3 Damage" + vbNewLine + "+6 Strength" + vbNewLine + "+3 Agility" + vbNewLine + "+3 Intelligence")
            .SetToolTip(FormMain.PictureBox49, "Broadsword" + vbNewLine + vbNewLine + "+18 Damage")
            .SetToolTip(FormMain.PictureBox50, "Buckler" + vbNewLine + vbNewLine + "+5 Armor" + vbNewLine + "+2 All Attributes" + vbNewLine + "Armor Bonus (active)")
            .SetToolTip(FormMain.PictureBox51, "Butterfly" + vbNewLine + vbNewLine + "+30 Agility" + vbNewLine + "+30 Damage" + vbNewLine + "30% Evasion" + vbNewLine + "+30 Attack Speed")
            .SetToolTip(FormMain.PictureBox52, "Chainmail" + vbNewLine + vbNewLine + "+5 Armor")
            .SetToolTip(FormMain.PictureBox53, "Circlet" + vbNewLine + vbNewLine + "+2 All Attributes")
            .SetToolTip(FormMain.PictureBox54, "Clarity" + vbNewLine + vbNewLine + "Regenerate Mana" + vbNewLine + "1 Charges")
            .SetToolTip(FormMain.PictureBox55, "Claymore" + vbNewLine + vbNewLine + "+21 Damage")
            .SetToolTip(FormMain.PictureBox56, "Cloak" + vbNewLine + vbNewLine + "+15% Magic Resistance")
            .SetToolTip(FormMain.PictureBox57, "Crystalys" + vbNewLine + vbNewLine + "+35 Damage" + vbNewLine + "Critical Strike")
            .SetToolTip(FormMain.PictureBox58, "Daedalus" + vbNewLine + vbNewLine + "+81 Damage" + vbNewLine + "Critical Strike")
            .SetToolTip(FormMain.PictureBox59, "Dagon 1" + vbNewLine + vbNewLine + "+13 Intelligence" + vbNewLine + "+3 All Attributes" + vbNewLine + "+9 Damage" + vbNewLine + "Energy Burst (active)")
            .SetToolTip(FormMain.PictureBox60, "Dagon 2" + vbNewLine + vbNewLine + "+15 Intelligence" + vbNewLine + "+3 All Attributes" + vbNewLine + "+9 Damage" + vbNewLine + "Energy Burst (active)")
            .SetToolTip(FormMain.PictureBox61, "Dagon 3" + vbNewLine + vbNewLine + "+17 Intelligence" + vbNewLine + "+3 All Attributes" + vbNewLine + "+9 Damage" + vbNewLine + "Energy Burst (active)")
            .SetToolTip(FormMain.PictureBox62, "Dagon 4" + vbNewLine + vbNewLine + "+19 Intelligence" + vbNewLine + "+3 All Attributes" + vbNewLine + "+9 Damage" + vbNewLine + "Energy Burst (active)")
            .SetToolTip(FormMain.PictureBox63, "Dagon 5" + vbNewLine + vbNewLine + "+21 Intelligence" + vbNewLine + "+3 All Attributes" + vbNewLine + "+9 Damage" + vbNewLine + "Energy Burst (active)")
            .SetToolTip(FormMain.PictureBox64, "Demon Edge" + vbNewLine + vbNewLine + "+46 Damage")
            .SetToolTip(FormMain.PictureBox65, "Desolator" + vbNewLine + vbNewLine + "+60 Damage" + vbNewLine + "Corruption")
            .SetToolTip(FormMain.PictureBox66, "Diffusal Blade 1" + vbNewLine + vbNewLine + "+22 Agility" + vbNewLine + "+6 Intelligence" + vbNewLine + "Feedback" + vbNewLine + "Purge (active)" + vbNewLine + "8 Charges")
            .SetToolTip(FormMain.PictureBox67, "Diffusal Blade 2" + vbNewLine + vbNewLine + "+26 Agility" + vbNewLine + "+10 Intelligence" + vbNewLine + "Feedback" + vbNewLine + "Purge (active)" + vbNewLine + "8 Charges")
            .SetToolTip(FormMain.PictureBox68, "Divine Rapier" + vbNewLine + vbNewLine + "+250 Damage")
            .SetToolTip(FormMain.PictureBox69, "Drum of Endurance" + vbNewLine + vbNewLine + "+9 All Attributes" + vbNewLine + "+9 Damage" + vbNewLine + "Endurance Aura" + vbNewLine + "Endurance (active)" + vbNewLine + "4 Charges")
            .SetToolTip(FormMain.PictureBox70, "Dust of Appearance" + vbNewLine + vbNewLine + "Reveal" + vbNewLine + "2 Charges")
            .SetToolTip(FormMain.PictureBox71, "Eaglesong" + vbNewLine + vbNewLine + "+25 Agility")
            .SetToolTip(FormMain.PictureBox72, "Energy Booster" + vbNewLine + vbNewLine + "+250 Mana")
            .SetToolTip(FormMain.PictureBox73, "Ethereal Blade" + vbNewLine + vbNewLine + "+40 Agility" + vbNewLine + "+10 Strength" + vbNewLine + "+10 Intelligence" + vbNewLine + "Ether Blast (active)")
            .SetToolTip(FormMain.PictureBox74, "Eul's Scepter of Divinity" + vbNewLine + vbNewLine + "+10 Intelligence" + vbNewLine + "+150% Mana Regeneration" + vbNewLine + "+25 Movement Speed" + vbNewLine + "Cyclone (active)")
            .SetToolTip(FormMain.PictureBox75, "Eye of Skadi" + vbNewLine + vbNewLine + "+25 All Attributes" + vbNewLine + "+200 HP" + vbNewLine + "+150 Mana" + vbNewLine + "Cold Attack")
            .SetToolTip(FormMain.PictureBox76, "Flying Courier" + vbNewLine + vbNewLine + "Summon Flying Courier")
            .SetToolTip(FormMain.PictureBox77, "Force Staff" + vbNewLine + vbNewLine + "+10 Intelligence" + vbNewLine + "+10 Damage" + vbNewLine + "+10 Attack Speed" + vbNewLine + "Force (active)")
            .SetToolTip(FormMain.PictureBox78, "Gauntlets of Strength" + vbNewLine + vbNewLine + "+3 Strength")
            .SetToolTip(FormMain.PictureBox79, "Gem of True Sight" + vbNewLine + vbNewLine + "True Sight")
            .SetToolTip(FormMain.PictureBox80, "Ghost Scepter" + vbNewLine + vbNewLine + "+7 All Attributes" + vbNewLine + "Ghost Form (active)")
            .SetToolTip(FormMain.PictureBox81, "Gloves of Haste" + vbNewLine + vbNewLine + "+15 Attack Speed")
            .SetToolTip(FormMain.PictureBox82, "Hand of Midas" + vbNewLine + vbNewLine + "+30 Attack Speed" + vbNewLine + "Transmute (active)")
            .SetToolTip(FormMain.PictureBox83, "Headdress" + vbNewLine + vbNewLine + "+2 All Attributes" + vbNewLine + "Regeneration Aura")
            .SetToolTip(FormMain.PictureBox84, "Healing Salve" + vbNewLine + vbNewLine + "Regenerate Health" + vbNewLine + "1 Charges")
            .SetToolTip(FormMain.PictureBox85, "Heart of Tarrasque" + vbNewLine + vbNewLine + "+40 Strength" + vbNewLine + "+300 HP" + vbNewLine + "Health Regeneration")
            .SetToolTip(FormMain.PictureBox86, "Helm of Iron Will" + vbNewLine + vbNewLine + "+5 Armor" + vbNewLine + "+3 HP/sec Regeneration")
            .SetToolTip(FormMain.PictureBox87, "Helm of the Dominator" + vbNewLine + vbNewLine + "+20 Damage" + vbNewLine + "+5 Armor" + vbNewLine + "+15% Lifesteal" + vbNewLine + "Dominate (active)")
            .SetToolTip(FormMain.PictureBox88, "Hood of Defiance" + vbNewLine + vbNewLine + "+30% Magic Resistance" + vbNewLine + "+8 HP/sec Regeneration")
            .SetToolTip(FormMain.PictureBox89, "Hyperstone" + vbNewLine + vbNewLine + "+55 Attack Speed")
            .SetToolTip(FormMain.PictureBox90, "Iron Branch" + vbNewLine + vbNewLine + "+1 All Attributes")
            .SetToolTip(FormMain.PictureBox91, "Javelin" + vbNewLine + vbNewLine + "+21 Damage" + vbNewLine + "20% chance to deal 40 bonus damage")
            .SetToolTip(FormMain.PictureBox92, "Linken's Sphere" + vbNewLine + vbNewLine + "+15 All Attributes" + vbNewLine + "+6 HP/sec regeneration" + vbNewLine + "+150% Mana Regeneration" + vbNewLine + "Spell Block")
            .SetToolTip(FormMain.PictureBox93, "Maelstrom" + vbNewLine + vbNewLine + "+24 Damage" + vbNewLine + "+25 Attack Speed" + vbNewLine + "Chain Lightning")
            .SetToolTip(FormMain.PictureBox94, "Magic Stick" + vbNewLine + vbNewLine + "Energy Charge (active)")
            .SetToolTip(FormMain.PictureBox95, "Magic Wand" + vbNewLine + vbNewLine + "+3 All Attributes" + vbNewLine + "Energy Charge (active)")
            .SetToolTip(FormMain.PictureBox96, "Manta Style" + vbNewLine + vbNewLine + "+26 Agility" + vbNewLine + "+10 Strength" + vbNewLine + "+10 Intelligence" + vbNewLine + "+15 Attack Speed" + vbNewLine + "+10% Movement Speed" + vbNewLine + "Mirror Image (active)")
            .SetToolTip(FormMain.PictureBox97, "Mantle of Intelligence" + vbNewLine + vbNewLine + "+3 Intelligence")
            .SetToolTip(FormMain.PictureBox98, "Mask of Madness" + vbNewLine + vbNewLine + "+17% Lifesteal" + vbNewLine + "Berserk (active)")
            .SetToolTip(FormMain.PictureBox99, "Medallion of Courage" + vbNewLine + vbNewLine + "+6 Armor" + vbNewLine + "+50% Mana Regeneration" + vbNewLine + "Valor (active)")
            .SetToolTip(FormMain.PictureBox100, "Mekansm" + vbNewLine + vbNewLine + "+5 All Attributes" + vbNewLine + "+5 Armor" + vbNewLine + "Mekansm Aura" + vbNewLine + "Restore (active)")
            .SetToolTip(FormMain.PictureBox101, "Mithril Hammer" + vbNewLine + vbNewLine + "+24 Damage")
            .SetToolTip(FormMain.PictureBox102, "Mjollnir" + vbNewLine + vbNewLine + "+80 Attack Speed" + vbNewLine + "+24 Damage" + vbNewLine + "Chain Lightning" + vbNewLine + "Static Charge (active)")
            .SetToolTip(FormMain.PictureBox103, "Monkey King Bar" + vbNewLine + vbNewLine + "+88 Damage" + vbNewLine + "+15 Attack Speed" + vbNewLine + "True Strike" + vbNewLine + "Mini-Bash")
            .SetToolTip(FormMain.PictureBox104, "Morbid Mask" + vbNewLine + vbNewLine + "+15% Lifesteal")
            .SetToolTip(FormMain.PictureBox105, "Mystic Staff" + vbNewLine + vbNewLine + "+25 Intelligence")
            .SetToolTip(FormMain.PictureBox121, "Necronomicon 1" + vbNewLine + vbNewLine + "+15 Intelligence" + vbNewLine + "+8 Strength" + vbNewLine + "Demonic Summoning (active)")
            .SetToolTip(FormMain.PictureBox106, "Necronomicon 2" + vbNewLine + vbNewLine + "+21 Intelligence" + vbNewLine + "+12 Strength" + vbNewLine + "Demonic Summoning (active)")
            .SetToolTip(FormMain.PictureBox107, "Necronomicon 3" + vbNewLine + vbNewLine + "+24 Intelligence" + vbNewLine + "+16 Strength" + vbNewLine + "Demonic Summoning (active)")
            .SetToolTip(FormMain.PictureBox108, "Null Talisman" + vbNewLine + vbNewLine + "+3 Damage" + vbNewLine + "+6 Intelligence" + vbNewLine + "+3 Strength" + vbNewLine + "+3 Agility")
            .SetToolTip(FormMain.PictureBox109, "Oblivion Staff" + vbNewLine + vbNewLine + "+6 Intelligence" + vbNewLine + "+10 Attack Speed" + vbNewLine + "+15 Damage" + vbNewLine + "+75% Mana Regeneration")
            .SetToolTip(FormMain.PictureBox110, "Observer Ward" + vbNewLine + vbNewLine + "Place Ward" + vbNewLine + "2 Charges")
            .SetToolTip(FormMain.PictureBox111, "Ogre Club" + vbNewLine + vbNewLine + "+10 Strength")
            .SetToolTip(FormMain.PictureBox112, "Orb of Venom" + vbNewLine + vbNewLine + "Poison Attack")
            .SetToolTip(FormMain.PictureBox113, "Orchid Malevolence" + vbNewLine + vbNewLine + "+20 Intelligence" + vbNewLine + "+30 Attack Speed" + vbNewLine + "+45 Damage" + vbNewLine + "+225% Mana Regeneration" + vbNewLine + "Soul Burn (active)")
            .SetToolTip(FormMain.PictureBox114, "Perseverance" + vbNewLine + vbNewLine + "+10 Damage" + vbNewLine + "+5 HP/sec Regeneration" + vbNewLine + "+125% Mana Regeneration")
            .SetToolTip(FormMain.PictureBox115, "Phase Boots" + vbNewLine + vbNewLine + "+60 Movement Speed" + vbNewLine + "+24 damage" + vbNewLine + "Phase (active)")
            .SetToolTip(FormMain.PictureBox116, "Pipe of Insight" + vbNewLine + vbNewLine + "+11 HP/sec Regeneration" + vbNewLine + "+30% Magic Resistance" + vbNewLine + "Barrier (active)")
            .SetToolTip(FormMain.PictureBox117, "Platemail" + vbNewLine + vbNewLine + "+10 Armor")
            .SetToolTip(FormMain.PictureBox118, "Point Booster" + vbNewLine + vbNewLine + "+200 HP" + vbNewLine + "+150 Mana")
            .SetToolTip(FormMain.PictureBox119, "Poor Man's Shield" + vbNewLine + vbNewLine + "+6 Agility" + vbNewLine + "Damage Block")
            .SetToolTip(FormMain.PictureBox120, "Power Treads" + vbNewLine + vbNewLine + "+60 Move Speed" + vbNewLine + "+8 Selected Attribute" + vbNewLine + "+25 Attack Speed" + vbNewLine + "Switch Attribute (active)")
            .SetToolTip(FormMain.PictureBox122, "Quarterstaff" + vbNewLine + vbNewLine + "+10 Damage" + vbNewLine + "+10 Attack Speed")
            .SetToolTip(FormMain.PictureBox123, "Quelling Blade" + vbNewLine + vbNewLine + "Demolish" + vbNewLine + "Tree Chop (active)")
            .SetToolTip(FormMain.PictureBox124, "Radiance" + vbNewLine + vbNewLine + "+60 Damage" + vbNewLine + "Burn Damage")
            .SetToolTip(FormMain.PictureBox125, "Reaver" + vbNewLine + vbNewLine + "+25 Strength")
            .SetToolTip(FormMain.PictureBox126, "Refresher Orb" + vbNewLine + vbNewLine + "+5 HP/Sec Regeneration" + vbNewLine + "+200% Mana Regeneration" + vbNewLine + "+40 Damage" + vbNewLine + "Reset Cooldowns (active)")
            .SetToolTip(FormMain.PictureBox127, "Ring of Basilius" + vbNewLine + vbNewLine + "+6 Damage" + vbNewLine + "+1 Armor" + vbNewLine + "Mana Aura" + vbNewLine + "Armor Aura")
            .SetToolTip(FormMain.PictureBox128, "Ring of Health" + vbNewLine + vbNewLine + "+5 HP/sec Regeneration")
            .SetToolTip(FormMain.PictureBox129, "Ring of Protection" + vbNewLine + vbNewLine + "+2 Armor")
            .SetToolTip(FormMain.PictureBox130, "Ring of Regen" + vbNewLine + vbNewLine + "+2 HP/sec Regeneration")
            .SetToolTip(FormMain.PictureBox131, "Robe of the Magi" + vbNewLine + vbNewLine + "+6 Intelligence")
            .SetToolTip(FormMain.PictureBox132, "Sacred Relic" + vbNewLine + vbNewLine + "+60 Damage")
            .SetToolTip(FormMain.PictureBox133, "Sage's Mask" + vbNewLine + vbNewLine + "+50% Mana Regeneration")
            .SetToolTip(FormMain.PictureBox134, "Sange" + vbNewLine + vbNewLine + "+16 Strength" + vbNewLine + "+10 Damage" + vbNewLine + "Lesser Maim")
            .SetToolTip(FormMain.PictureBox135, "Sange and Yasha" + vbNewLine + vbNewLine + "+16 Agility" + vbNewLine + "+16 Strength" + vbNewLine + "+12 Damage" + vbNewLine + "+15 Attack Speed" + vbNewLine + "+12% Movement Speed" + vbNewLine + "Greater Maim")
            .SetToolTip(FormMain.PictureBox136, "Satanic" + vbNewLine + vbNewLine + "+25 Strength" + vbNewLine + "+20 Damage" + vbNewLine + "+5 Armor" + vbNewLine + "Lifesteal" + vbNewLine + "Unholy Rage (active)")
            .SetToolTip(FormMain.PictureBox137, "Scythe of Vyse" + vbNewLine + vbNewLine + "+35 Intelligence" + vbNewLine + "+10 Strength" + vbNewLine + "+10 Agility" + vbNewLine + "+150% Mana Regeneration" + vbNewLine + "Hex (active)")
            .SetToolTip(FormMain.PictureBox138, "Sentry Ward" + vbNewLine + vbNewLine + "Place Ward" + vbNewLine + "950 Radius True Sight" + vbNewLine + "2 Charges")
            .SetToolTip(FormMain.PictureBox139, "Shadow Blade" + vbNewLine + vbNewLine + "+38 Damage" + vbNewLine + "+10 Attack Speed" + vbNewLine + "Shadow Walk (active)")
            .SetToolTip(FormMain.PictureBox140, "Shiva's Guard" + vbNewLine + vbNewLine + "+30 Intelligence" + vbNewLine + "+15 Armor" + vbNewLine + "Freezing Aura" + vbNewLine + "Arctic Blast (active)")
            .SetToolTip(FormMain.PictureBox141, "Skull Basher" + vbNewLine + vbNewLine + "+40 Damage" + vbNewLine + "+6 Strength" + vbNewLine + "Bash")
            .SetToolTip(FormMain.PictureBox142, "Slippers of Agility" + vbNewLine + vbNewLine + "+3 Agility")
            .SetToolTip(FormMain.PictureBox143, "Smoke of Deceit" + vbNewLine + vbNewLine + "Smoke of Deceit (active)" + vbNewLine + "1 Charges")
            .SetToolTip(FormMain.PictureBox144, "Soul Booster" + vbNewLine + vbNewLine + "+450 HP" + vbNewLine + "+400 Mana" + vbNewLine + "+4 HP/sec Regeneration" + vbNewLine + "+100% Mana Regeneration")
            .SetToolTip(FormMain.PictureBox145, "Soul Ring" + vbNewLine + vbNewLine + "+3 HP/sec Regeneration" + vbNewLine + "+50% Mana Regeneration" + vbNewLine + "Sacrifice (active)")
            .SetToolTip(FormMain.PictureBox146, "Staff of Wizardry" + vbNewLine + vbNewLine + "+10 Intelligence")
            .SetToolTip(FormMain.PictureBox147, "Stout Shield" + vbNewLine + vbNewLine + "Damage Block")
            .SetToolTip(FormMain.PictureBox148, "Talisman of Evasion" + vbNewLine + vbNewLine + "+25% Evasion")
            .SetToolTip(FormMain.PictureBox149, "Tango" + vbNewLine + vbNewLine + "Eat Tree (active)" + vbNewLine + "3 Charges")
            .SetToolTip(FormMain.PictureBox150, "Town Portal Scroll" + vbNewLine + vbNewLine + "Teleport (active)" + vbNewLine + "1 Charges")
            .SetToolTip(FormMain.PictureBox151, "Ultimate Orb" + vbNewLine + vbNewLine + "+10 All Attributes")
            .SetToolTip(FormMain.PictureBox152, "Urn of Shadows" + vbNewLine + vbNewLine + "+50% Mana Regeneration" + vbNewLine + "+6 Strength" + vbNewLine + "Soul Release (active)")
            .SetToolTip(FormMain.PictureBox153, "Vanguard" + vbNewLine + vbNewLine + "+6 HP/sec Regeneration" + vbNewLine + "+250 HP" + vbNewLine + "Damage Block")
            .SetToolTip(FormMain.PictureBox154, "Veil of Discord" + vbNewLine + vbNewLine + "+5 Armor" + vbNewLine + "+5 HP/sec Regeneration" + vbNewLine + "+12 Intelligence" + vbNewLine + "Discord (active)")
            .SetToolTip(FormMain.PictureBox155, "Vitality Booster" + vbNewLine + vbNewLine + "+250 HP")
            .SetToolTip(FormMain.PictureBox156, "Vladmir's Offering" + vbNewLine + vbNewLine + "+2 HP/sec Regeneration" + vbNewLine + "Vampiric Aura" + vbNewLine + "Damage Aura" + vbNewLine + "Armor Aura" + vbNewLine + "Mana Regeneration Aura")
            .SetToolTip(FormMain.PictureBox157, "Void Stone" + vbNewLine + vbNewLine + "+100% Mana Regeneration")
            .SetToolTip(FormMain.PictureBox158, "Wraith Band" + vbNewLine + vbNewLine + "+3 Damage" + vbNewLine + "+6 Agility" + vbNewLine + "+3 Strength" + vbNewLine + "+3 Intelligence")
            .SetToolTip(FormMain.PictureBox159, "Yasha" + vbNewLine + vbNewLine + "+16 Agility" + vbNewLine + "+15 Attack Speed" + vbNewLine + "+10% Movement Speed")
            .SetToolTip(FormMain.PictureBox160, "Abyssal Blade" + vbNewLine + vbNewLine + "+100 Damage" + vbNewLine + "+10 Strength" + vbNewLine + "Bash" + vbNewLine + "Overwhelm (active)")
            .SetToolTip(FormMain.PictureBox161, "Heaven's Halberd" + vbNewLine + vbNewLine + "+25 Damage" + vbNewLine + "+20 Strength" + vbNewLine + "+25 Evasion" + vbNewLine + "Lesser Maim" + vbNewLine + "Disarm (active)")
            .SetToolTip(FormMain.PictureBox162, "Ring of Aquila" + vbNewLine + vbNewLine + "+9 Damage" + vbNewLine + "+3 All Stats" + vbNewLine + "+3 Agility" + vbNewLine + "+1 Armor" + vbNewLine + "Armor Aura" + vbNewLine + "Mana Aura")
            .SetToolTip(FormMain.PictureBox163, "Rod of Atos" + vbNewLine + vbNewLine + "+25 Intelligence" + vbNewLine + "+250 HP" + vbNewLine + "Cripple (active)")
            .SetToolTip(FormMain.PictureBox164, "Tranquil Boots" + vbNewLine + vbNewLine + "+80 Movement Speed" + vbNewLine + "+3 HP/sec Regeneration" + vbNewLine + "+3 Armor" + vbNewLine + "Rejuvenate (active)")
            .SetToolTip(FormMain.PictureBox165, "Delete FormMain.Item")
        End With
        'PRESELECT THE BOX
        FormMain.ComboBox3.SelectedItem = "All"
        FormMain.ComboBox5.SelectedItem = "DotA Like"

        FormMain.CheckBox2.Checked = True
        ClearNotImplemented()
    End Sub

    Public Sub ClearSingle()
        FormMain.TextBox1.Text = ""
        FormMain.Label1.Text = ""
        NeuerText = ""
        Dim pb As Object
        Dim picbox As Integer = 1
        For picbox = 1 To 39
            pb = FormMain.TabPage1.Controls.Item("Item" & picbox)
            pb.image = D2RIC.My.Resources.Resources.none
            FormMain.ToolTip1.SetToolTip(pb, "none")
        Next
    End Sub

    Public Sub Save()
        If (Selected_Hero <> "") Then
            SaveChanges()
            If FormMain.TextBox1.Text <> "" Then
                ChangeAuthor(FormMain.TextBox1.Text, Selected_Hero)
            End If
            IO.File.WriteAllText(My.Settings.path + "\default_" + Selected_Hero + ".txt", NeuerText)
        Else
            MessageBox.Show("Please choose a hero first.")
        End If
    End Sub

    Public Sub CheckFile(ByVal hero As String)
        If IO.File.Exists(My.Settings.path + "\default_" + hero + ".txt") Then
            Dim DeinPfad As String = My.Settings.path + "\default_" + hero + ".txt"
            Dim ItemPlace As String = "Starting Items"
            Dim i As Integer = 1
            Dim pb As Object
            For Each Zeile As String In IO.File.ReadAllLines(DeinPfad)
                If Zeile.Contains("item_") And i <= 39 Then
                    pb = FormMain.TabPage1.Controls.Item("Item" & i)
                    pb.image = FormMain.ChangePicture(FormMain.RenameItem(Zeile))
                    FormMain.ToolTip1.SetToolTip(pb, GetToolTip(FormMain.RenameItem(Zeile)))
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
                    FormMain.TextBox1.Text = Replace(Zeile, """", "")
                    FormMain.TextBox1.Text = Replace(FormMain.TextBox1.Text, "author", "")
                    FormMain.TextBox1.Text = Replace(FormMain.TextBox1.Text, vbTab, "")
                    NeuerText &= Zeile & vbNewLine
                Else
                    NeuerText &= Zeile & vbNewLine
                End If
            Next
            FormMain.ButtonSave.Enabled = True
        Else
            ClearSingle()
            FormMain.ButtonSave.Enabled = False
            MessageBox.Show("Error! Hero maybe not implemented yet.")
        End If
    End Sub

    Public Sub LoadDefault()
        If IO.File.Exists(My.Settings.path + "\Backup\default_" + Selected_Hero + ".txt") Then
            Dim DeinPfad As String = My.Settings.path + "\Backup\default_" + Selected_Hero + ".txt"
            Dim ItemPlace As String = "Starting Items"
            Dim i As Integer = 1
            Dim pb As Object
            Dim picbox As Integer = 1
            For picbox = 1 To 39
                pb = FormMain.TabPage1.Controls.Item("Item" & picbox)
                pb.image = D2RIC.My.Resources.Resources.none
                FormMain.ToolTip1.SetToolTip(pb, "none")
            Next
            For Each Zeile As String In IO.File.ReadAllLines(DeinPfad)
                If Zeile.Contains("item_") And i <= 39 Then
                    pb = FormMain.TabPage1.Controls.Item("Item" & i)
                    pb.image = FormMain.ChangePicture(FormMain.RenameItem(Zeile))
                    FormMain.ToolTip1.SetToolTip(pb, GetToolTip(FormMain.RenameItem(Zeile)))
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
                    FormMain.TextBox1.Text = Replace(Zeile, """", "")
                    FormMain.TextBox1.Text = Replace(FormMain.TextBox1.Text, "author", "")
                    FormMain.TextBox1.Text = Replace(FormMain.TextBox1.Text, vbTab, "")
                    NeuerText &= Zeile & vbNewLine
                Else
                    NeuerText &= Zeile & vbNewLine
                End If
            Next
            FormMain.ButtonSave.Enabled = True
        Else
            MessageBox.Show("Backup not found.")
        End If
    End Sub

    Public Sub ChangeAuthor(ByVal author As String, ByVal hero As String)
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

    Public Sub SaveChanges()
        If Not IO.File.Exists(My.Settings.path + "\Backup\default_" + Selected_Hero + ".txt") Then
            If Not IO.Directory.Exists(My.Settings.path & "\Backup") Then
                ' Nein! Jetzt erstellen...
                Try
                    IO.Directory.CreateDirectory(My.Settings.path & "\Backup")
                    ' Ordner wurde korrekt erstellt!
                Catch ex As Exception
                    ' Ordner wurde nich erstellt
                    MessageBox.Show("Error while backup creating folder")
                End Try
            End If
            'Create Backup
            Try
                IO.File.Copy(My.Settings.path + "\default_" + Selected_Hero + ".txt", My.Settings.path + "\Backup\default_" + Selected_Hero + ".txt", True)  ' Kopiert die Dateien
            Catch ex As Exception
                ' Ordner wurde nich erstellt
                MessageBox.Show("Error while creating backup")
            End Try
        End If

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
                pb = FormMain.TabPage1.Controls.Item("Item" & a)
                If a < 10 And Not FormMain.doImagesMatch(pb.Image, D2RIC.My.Resources.Resources.none) Then
                    StartingItems &= vbNewLine & vbTab & vbTab & vbTab & """Item""" & vbTab & vbTab & FormMain.CheckItem(pb.Image)
                ElseIf 9 < a And a < 19 And Not FormMain.doImagesMatch(pb.Image, D2RIC.My.Resources.Resources.none) Then
                    Earlygame &= vbNewLine & vbTab & vbTab & vbTab & """Item""" & vbTab & vbTab & FormMain.CheckItem(pb.Image)
                ElseIf 18 < a And a < 27 And Not FormMain.doImagesMatch(pb.Image, D2RIC.My.Resources.Resources.none) Then
                    CoreItems &= vbNewLine & vbTab & vbTab & vbTab & """Item""" & vbTab & vbTab & FormMain.CheckItem(pb.Image)
                ElseIf 26 < a And Not FormMain.doImagesMatch(pb.Image, D2RIC.My.Resources.Resources.none) Then
                    Luxury &= vbNewLine & vbTab & vbTab & vbTab & """Item""" & vbTab & vbTab & FormMain.CheckItem(pb.Image)
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
            MessageBox.Show("Error!")
        End If
    End Sub

    Public Function renameHero(ByVal hero) As String
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
                hero = "Outworld Destroyer"
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
            Case hero Like "npc_dota_hero_?ycan"
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

    Public Function CheckHero(ByVal hero As String) As String
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
            Case "Outworld Destroyer"
                Selected_Hero = "obsidian_destroyer"
            Case "Lycanthrope"
                Selected_Hero = "lycan"
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

    Public Sub ChangeHeroList(ByVal cb As Object, ByVal lb As Object)
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
            lb.Items.Add("Ogre Magi")
            lb.Items.Add("Omniknight")
            lb.Items.Add("Outworld Destroyer")
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
            lb.Items.Add("Alchemist")
            lb.Items.Add("Anti-Mage")
            lb.Items.Add("Bloodseeker")
            lb.Items.Add("Bounty Hunter")
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
            lb.Items.Add("Kunkka")
            lb.Items.Add("Lanaya")
            lb.Items.Add("Legion Commander")
            lb.Items.Add("Leshrac")
            lb.Items.Add("Lone Druid")
            lb.Items.Add("Luna")
            lb.Items.Add("Lycanthrope")
            lb.Items.Add("Medusa")
            lb.Items.Add("Meepo")
            lb.Items.Add("Mirana")
            lb.Items.Add("Morphling")
            lb.Items.Add("Mortred")
            lb.Items.Add("Naga Siren")
            lb.Items.Add("Necrolyte")
            lb.Items.Add("Night Stalker")
            lb.Items.Add("Outworld Destroyer")
            lb.Items.Add("Phantom Lancer")
            lb.Items.Add("Phoenix")
            lb.Items.Add("Queen of Pain")
            lb.Items.Add("Razor")
            lb.Items.Add("Riki")
            lb.Items.Add("Rubick")
            lb.Items.Add("Shadow Fiend")
            lb.Items.Add("Silencer")
            lb.Items.Add("Skeleton King")
            lb.Items.Add("Skywrath Mage")
            lb.Items.Add("Slardar")
            lb.Items.Add("Sniper")
            lb.Items.Add("Soul Keeper")
            lb.Items.Add("Spectre")
            lb.Items.Add("Storm Spirit")
            lb.Items.Add("Sven")
            lb.Items.Add("Tauren Chieftain")
            lb.Items.Add("Tinker")
            lb.Items.Add("Troll Warlord")
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
            lb.Items.Add("Kunkka")
            lb.Items.Add("Lanaya")
            lb.Items.Add("Legion Commander")
            lb.Items.Add("Lich")
            lb.Items.Add("Lifestealer")
            lb.Items.Add("Lina")
            lb.Items.Add("Lion")
            lb.Items.Add("Mirana")
            lb.Items.Add("Morphling")
            lb.Items.Add("Naga Siren")
            lb.Items.Add("Nature's Prophet")
            lb.Items.Add("Nerubian Assassin")
            lb.Items.Add("Night Stalker")
            lb.Items.Add("Phoenix")
            lb.Items.Add("Pudge")
            lb.Items.Add("Queen of Pain")
            lb.Items.Add("Riki")
            lb.Items.Add("Rubick")
            lb.Items.Add("Sand King")
            lb.Items.Add("Skywrath Mage")
            lb.Items.Add("Slark")
            lb.Items.Add("Spirit Breaker")
            lb.Items.Add("Storm Spirit")
            lb.Items.Add("Sven")
            lb.Items.Add("Tauren Chieftain")
            lb.Items.Add("Tidehunter")
            lb.Items.Add("Tinker")
            lb.Items.Add("Tiny")
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
            lb.Items.Add("Tidehunter")
            lb.Items.Add("Tiny")
            lb.Items.Add("Treant Protector")
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
            lb.Items.Add("Lone Druid")
            lb.Items.Add("Lycanthrope")
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
            lb.Items.Add("Ursa")
        ElseIf cb.SelectedItem = "Tank" Then
            lb.SelectedItems.Clear()
            For i = lb.Items.Count - 1 To 0 Step -1
                lb.Items.Remove(lb.Items(i).ToString)
            Next
            lb.Items.Add("Centaur Warchief")
            lb.Items.Add("Death Prophet")
            lb.Items.Add("Dirge")
            lb.Items.Add("Goblin Shredder")
            lb.Items.Add("Guardian Wisp")
            lb.Items.Add("Legion Commander")
            lb.Items.Add("Pandaren Brewmaster")
            lb.Items.Add("Phoenix")
            lb.Items.Add("Skeleton King")
            lb.Items.Add("Tauren Chieftain")
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
            lb.Items.Add("Outworld Destroyer")
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

    Public Sub ClearNotImplemented()
        With FormMain.ListBox1
            .Items.Remove("Abaddon")
            .Items.Remove("Bristleback")
            .Items.Remove("Centaur Warchief")
            .Items.Remove("Chaos Knight")
            .Items.Remove("Dirge")
            .Items.Remove("Disruptor")
            .Items.Remove("Ember Spirit")
            .Items.Remove("Goblin Shredder")
            .Items.Remove("Goblin Techies")
            .Items.Remove("Guardian Wisp")
            .Items.Remove("Keeper of the Light")
            .Items.Remove("Legion Commander")
            .Items.Remove("Lone Druid")
            .Items.Remove("Luna")
            .Items.Remove("Magnataur")
            .Items.Remove("Medusa")
            .Items.Remove("Meepo")
            .Items.Remove("Naga Siren")
            .Items.Remove("Nerubian Assassin")
            .Items.Remove("Ogre Magi")
            .Items.Remove("Pandaren Brewmaster")
            .Items.Remove("Phantom Lancer")
            .Items.Remove("Phoenix")
            .Items.Remove("Pit Lord")
            .Items.Remove("Rubick")
            .Items.Remove("Skywrath Mage")
            .Items.Remove("Slark")
            .Items.Remove("Soul Keeper")
            .Items.Remove("Tauren Chieftain")
            .Items.Remove("Treant Protector")
            .Items.Remove("Troll Warlord")
            .Items.Remove("Tuskarr")
            .Items.Remove("Visage")
        End With
    End Sub

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

    Public Sub ChangeItemPosition()
        If FormMain.ComboBox5.SelectedItem = "DotA Like" Then
            FormMain.Label13.Visible = True
            FormMain.Label14.Visible = True
            FormMain.Label15.Visible = True
            FormMain.Label16.Visible = True
            FormMain.Label17.Visible = True
            FormMain.Label18.Visible = True
            FormMain.Label19.Visible = True
            FormMain.Label20.Visible = True
            FormMain.Label21.Visible = True
            FormMain.Label22.Visible = True
            FormMain.Label23.Visible = True
            'Consumables
            FormMain.PictureBox54.Location = New Point(159, 238)
            FormMain.PictureBox149.Location = New Point(205, 238)
            FormMain.PictureBox84.Location = New Point(251, 238)
            FormMain.PictureBox143.Location = New Point(297, 238)
            FormMain.PictureBox150.Location = New Point(159, 274)
            FormMain.PictureBox70.Location = New Point(205, 274)
            FormMain.PictureBox32.Location = New Point(251, 274)
            FormMain.PictureBox76.Location = New Point(297, 274)
            FormMain.PictureBox110.Location = New Point(159, 310)
            FormMain.PictureBox138.Location = New Point(205, 310)
            FormMain.PictureBox47.Location = New Point(251, 310)
            'Attributes
            FormMain.PictureBox90.Location = New Point(350, 238)
            FormMain.PictureBox78.Location = New Point(396, 238)
            FormMain.PictureBox142.Location = New Point(442, 238)
            FormMain.PictureBox97.Location = New Point(488, 238)
            FormMain.PictureBox53.Location = New Point(350, 274)
            FormMain.PictureBox37.Location = New Point(396, 274)
            FormMain.PictureBox44.Location = New Point(442, 274)
            FormMain.PictureBox131.Location = New Point(488, 274)
            FormMain.PictureBox111.Location = New Point(350, 310)
            FormMain.PictureBox40.Location = New Point(396, 310)
            FormMain.PictureBox146.Location = New Point(442, 310)
            FormMain.PictureBox151.Location = New Point(488, 310)
            'Armaments
            FormMain.PictureBox129.Location = New Point(543, 238)
            FormMain.PictureBox123.Location = New Point(589, 238)
            FormMain.PictureBox147.Location = New Point(635, 238)
            FormMain.PictureBox41.Location = New Point(681, 238)
            FormMain.PictureBox52.Location = New Point(543, 274)
            FormMain.PictureBox86.Location = New Point(589, 274)
            FormMain.PictureBox49.Location = New Point(635, 274)
            FormMain.PictureBox122.Location = New Point(681, 274)
            FormMain.PictureBox55.Location = New Point(543, 310)
            FormMain.PictureBox91.Location = New Point(589, 310)
            FormMain.PictureBox117.Location = New Point(635, 310)
            FormMain.PictureBox101.Location = New Point(681, 310)
            'Arcane
            FormMain.PictureBox94.Location = New Point(736, 238)
            FormMain.PictureBox133.Location = New Point(782, 238)
            FormMain.PictureBox130.Location = New Point(828, 238)
            FormMain.PictureBox45.Location = New Point(874, 238)
            FormMain.PictureBox81.Location = New Point(736, 274)
            FormMain.PictureBox56.Location = New Point(782, 274)
            FormMain.PictureBox79.Location = New Point(828, 274)
            FormMain.PictureBox104.Location = New Point(874, 274)
            FormMain.PictureBox80.Location = New Point(736, 310)
            FormMain.PictureBox148.Location = New Point(782, 310)
            FormMain.PictureBox42.Location = New Point(828, 310)
            'Common
            FormMain.PictureBox158.Location = New Point(159, 380)
            FormMain.PictureBox108.Location = New Point(205, 380)
            FormMain.PictureBox95.Location = New Point(251, 380)
            FormMain.PictureBox48.Location = New Point(297, 380)
            FormMain.PictureBox119.Location = New Point(159, 416)
            FormMain.PictureBox145.Location = New Point(205, 416)
            FormMain.PictureBox115.Location = New Point(251, 416)
            FormMain.PictureBox120.Location = New Point(297, 416)
            FormMain.PictureBox109.Location = New Point(159, 452)
            FormMain.PictureBox114.Location = New Point(205, 452)
            FormMain.PictureBox82.Location = New Point(251, 452)
            FormMain.PictureBox46.Location = New Point(297, 452)
            'Weapons
            FormMain.PictureBox57.Location = New Point(350, 380)
            FormMain.PictureBox34.Location = New Point(396, 380)
            FormMain.PictureBox141.Location = New Point(442, 380)
            FormMain.PictureBox139.Location = New Point(488, 380)
            FormMain.PictureBox36.Location = New Point(350, 416)
            FormMain.PictureBox73.Location = New Point(396, 416)
            FormMain.PictureBox124.Location = New Point(442, 416)
            FormMain.PictureBox103.Location = New Point(488, 416)
            FormMain.PictureBox58.Location = New Point(350, 452)
            FormMain.PictureBox51.Location = New Point(396, 452)
            FormMain.PictureBox68.Location = New Point(442, 452)
            FormMain.PictureBox160.Location = New Point(488, 452)
            'Support
            FormMain.PictureBox127.Location = New Point(543, 380)
            FormMain.PictureBox83.Location = New Point(589, 380)
            FormMain.PictureBox50.Location = New Point(635, 380)
            FormMain.PictureBox152.Location = New Point(681, 380)
            FormMain.PictureBox99.Location = New Point(543, 416)
            FormMain.PictureBox33.Location = New Point(589, 416)
            FormMain.PictureBox69.Location = New Point(635, 416)
            FormMain.PictureBox156.Location = New Point(681, 416)
            FormMain.PictureBox100.Location = New Point(543, 452)
            FormMain.PictureBox116.Location = New Point(589, 452)
            FormMain.PictureBox162.Location = New Point(635, 452)
            FormMain.PictureBox164.Location = New Point(681, 452)
            'Caster
            FormMain.PictureBox77.Location = New Point(736, 380)
            FormMain.PictureBox121.Location = New Point(782, 380)
            FormMain.PictureBox106.Location = New Point(828, 380)
            FormMain.PictureBox107.Location = New Point(874, 380)
            FormMain.PictureBox74.Location = New Point(736, 416)
            FormMain.PictureBox59.Location = New Point(782, 416)
            FormMain.PictureBox60.Location = New Point(828, 416)
            FormMain.PictureBox61.Location = New Point(874, 416)
            FormMain.PictureBox62.Location = New Point(736, 452)
            FormMain.PictureBox63.Location = New Point(782, 452)
            FormMain.PictureBox154.Location = New Point(828, 452)
            FormMain.PictureBox31.Location = New Point(874, 452)
            FormMain.PictureBox113.Location = New Point(736, 488)
            FormMain.PictureBox126.Location = New Point(782, 488)
            FormMain.PictureBox137.Location = New Point(828, 488)
            FormMain.PictureBox163.Location = New Point(874, 488)
            'Armor
            FormMain.PictureBox88.Location = New Point(159, 526)
            FormMain.PictureBox39.Location = New Point(205, 526)
            FormMain.PictureBox153.Location = New Point(251, 526)
            FormMain.PictureBox144.Location = New Point(297, 526)
            FormMain.PictureBox38.Location = New Point(159, 562)
            FormMain.PictureBox140.Location = New Point(205, 562)
            FormMain.PictureBox96.Location = New Point(251, 562)
            FormMain.PictureBox43.Location = New Point(297, 562)
            FormMain.PictureBox92.Location = New Point(159, 598)
            FormMain.PictureBox35.Location = New Point(205, 598)
            FormMain.PictureBox85.Location = New Point(251, 598)
            'Artifacts
            FormMain.PictureBox87.Location = New Point(350, 526)
            FormMain.PictureBox98.Location = New Point(396, 526)
            FormMain.PictureBox134.Location = New Point(442, 526)
            FormMain.PictureBox159.Location = New Point(488, 526)
            FormMain.PictureBox93.Location = New Point(350, 562)
            FormMain.PictureBox66.Location = New Point(396, 562)
            FormMain.PictureBox67.Location = New Point(442, 562)
            FormMain.PictureBox65.Location = New Point(488, 562)
            FormMain.PictureBox135.Location = New Point(350, 598)
            FormMain.PictureBox102.Location = New Point(396, 598)
            FormMain.PictureBox75.Location = New Point(442, 598)
            FormMain.PictureBox136.Location = New Point(488, 598)
            FormMain.PictureBox161.Location = New Point(350, 634)
            'Secret Shop
            FormMain.PictureBox112.Location = New Point(543, 526)
            FormMain.PictureBox128.Location = New Point(589, 526)
            FormMain.PictureBox157.Location = New Point(635, 526)
            FormMain.PictureBox72.Location = New Point(681, 526)
            FormMain.PictureBox155.Location = New Point(543, 562)
            FormMain.PictureBox118.Location = New Point(589, 562)
            FormMain.PictureBox89.Location = New Point(635, 562)
            FormMain.PictureBox64.Location = New Point(681, 562)
            FormMain.PictureBox105.Location = New Point(543, 598)
            FormMain.PictureBox125.Location = New Point(589, 598)
            FormMain.PictureBox71.Location = New Point(635, 598)
            FormMain.PictureBox132.Location = New Point(681, 598)
            'Delete
            FormMain.PictureBox165.Location = New Point(782, 562)
        Else
            FormMain.Label13.Visible = False
            FormMain.Label14.Visible = False
            FormMain.Label15.Visible = False
            FormMain.Label16.Visible = False
            FormMain.Label17.Visible = False
            FormMain.Label18.Visible = False
            FormMain.Label19.Visible = False
            FormMain.Label20.Visible = False
            FormMain.Label21.Visible = False
            FormMain.Label22.Visible = False
            FormMain.Label23.Visible = False
            FormMain.PictureBox160.Location = New Point(201, 276)
            FormMain.PictureBox31.Location = New Point(247, 276)
            FormMain.PictureBox32.Location = New Point(293, 276)
            FormMain.PictureBox33.Location = New Point(339, 276)
            FormMain.PictureBox34.Location = New Point(385, 276)
            FormMain.PictureBox35.Location = New Point(431, 276)
            FormMain.PictureBox36.Location = New Point(477, 276)
            FormMain.PictureBox37.Location = New Point(523, 276)
            FormMain.PictureBox38.Location = New Point(569, 276)
            FormMain.PictureBox39.Location = New Point(615, 276)
            FormMain.PictureBox40.Location = New Point(661, 276)
            FormMain.PictureBox41.Location = New Point(707, 276)
            FormMain.PictureBox42.Location = New Point(753, 276)
            FormMain.PictureBox43.Location = New Point(799, 276)
            FormMain.PictureBox44.Location = New Point(845, 276)
            FormMain.PictureBox45.Location = New Point(201, 312)
            FormMain.PictureBox46.Location = New Point(247, 312)
            FormMain.PictureBox47.Location = New Point(293, 312)
            FormMain.PictureBox48.Location = New Point(339, 312)
            FormMain.PictureBox49.Location = New Point(385, 312)
            FormMain.PictureBox50.Location = New Point(431, 312)
            FormMain.PictureBox51.Location = New Point(477, 312)
            FormMain.PictureBox52.Location = New Point(523, 312)
            FormMain.PictureBox53.Location = New Point(569, 312)
            FormMain.PictureBox54.Location = New Point(615, 312)
            FormMain.PictureBox55.Location = New Point(661, 312)
            FormMain.PictureBox56.Location = New Point(707, 312)
            FormMain.PictureBox57.Location = New Point(753, 312)
            FormMain.PictureBox58.Location = New Point(799, 312)
            FormMain.PictureBox59.Location = New Point(845, 312)
            FormMain.PictureBox60.Location = New Point(201, 348)
            FormMain.PictureBox61.Location = New Point(247, 348)
            FormMain.PictureBox62.Location = New Point(293, 348)
            FormMain.PictureBox63.Location = New Point(339, 348)
            FormMain.PictureBox64.Location = New Point(385, 348)
            FormMain.PictureBox65.Location = New Point(431, 348)
            FormMain.PictureBox66.Location = New Point(477, 348)
            FormMain.PictureBox67.Location = New Point(523, 348)
            FormMain.PictureBox68.Location = New Point(569, 348)
            FormMain.PictureBox69.Location = New Point(615, 348)
            FormMain.PictureBox70.Location = New Point(661, 348)
            FormMain.PictureBox71.Location = New Point(707, 348)
            FormMain.PictureBox72.Location = New Point(753, 348)
            FormMain.PictureBox73.Location = New Point(799, 348)
            FormMain.PictureBox74.Location = New Point(845, 348)
            FormMain.PictureBox75.Location = New Point(201, 384)
            FormMain.PictureBox76.Location = New Point(247, 384)
            FormMain.PictureBox77.Location = New Point(293, 384)
            FormMain.PictureBox78.Location = New Point(339, 384)
            FormMain.PictureBox79.Location = New Point(385, 384)
            FormMain.PictureBox80.Location = New Point(431, 384)
            FormMain.PictureBox81.Location = New Point(477, 384)
            FormMain.PictureBox82.Location = New Point(523, 384)
            FormMain.PictureBox83.Location = New Point(569, 384)
            FormMain.PictureBox84.Location = New Point(615, 384)
            FormMain.PictureBox85.Location = New Point(661, 384)
            FormMain.PictureBox161.Location = New Point(707, 384)
            FormMain.PictureBox86.Location = New Point(753, 384)
            FormMain.PictureBox87.Location = New Point(799, 384)
            FormMain.PictureBox88.Location = New Point(845, 384)
            FormMain.PictureBox89.Location = New Point(201, 420)
            FormMain.PictureBox90.Location = New Point(247, 420)
            FormMain.PictureBox91.Location = New Point(293, 420)
            FormMain.PictureBox92.Location = New Point(339, 420)
            FormMain.PictureBox93.Location = New Point(385, 420)
            FormMain.PictureBox94.Location = New Point(431, 420)
            FormMain.PictureBox95.Location = New Point(477, 420)
            FormMain.PictureBox96.Location = New Point(523, 420)
            FormMain.PictureBox97.Location = New Point(569, 420)
            FormMain.PictureBox98.Location = New Point(615, 420)
            FormMain.PictureBox99.Location = New Point(661, 420)
            FormMain.PictureBox100.Location = New Point(707, 420)
            FormMain.PictureBox101.Location = New Point(753, 420)
            FormMain.PictureBox102.Location = New Point(799, 420)
            FormMain.PictureBox103.Location = New Point(845, 420)
            FormMain.PictureBox104.Location = New Point(201, 456)
            FormMain.PictureBox105.Location = New Point(247, 456)
            FormMain.PictureBox121.Location = New Point(293, 456)
            FormMain.PictureBox106.Location = New Point(339, 456)
            FormMain.PictureBox107.Location = New Point(385, 456)
            FormMain.PictureBox108.Location = New Point(431, 456)
            FormMain.PictureBox109.Location = New Point(477, 456)
            FormMain.PictureBox110.Location = New Point(523, 456)
            FormMain.PictureBox111.Location = New Point(569, 456)
            FormMain.PictureBox112.Location = New Point(615, 456)
            FormMain.PictureBox113.Location = New Point(661, 456)
            FormMain.PictureBox114.Location = New Point(707, 456)
            FormMain.PictureBox115.Location = New Point(753, 456)
            FormMain.PictureBox116.Location = New Point(799, 456)
            FormMain.PictureBox117.Location = New Point(845, 456)
            FormMain.PictureBox118.Location = New Point(201, 492)
            FormMain.PictureBox119.Location = New Point(247, 492)
            FormMain.PictureBox120.Location = New Point(293, 492)
            FormMain.PictureBox122.Location = New Point(339, 492)
            FormMain.PictureBox123.Location = New Point(385, 492)
            FormMain.PictureBox124.Location = New Point(431, 492)
            FormMain.PictureBox125.Location = New Point(477, 492)
            FormMain.PictureBox126.Location = New Point(523, 492)
            FormMain.PictureBox127.Location = New Point(569, 492)
            FormMain.PictureBox162.Location = New Point(615, 492)
            FormMain.PictureBox128.Location = New Point(661, 492)
            FormMain.PictureBox129.Location = New Point(707, 492)
            FormMain.PictureBox130.Location = New Point(753, 492)
            FormMain.PictureBox131.Location = New Point(799, 492)
            FormMain.PictureBox132.Location = New Point(845, 492)
            FormMain.PictureBox163.Location = New Point(201, 528)
            FormMain.PictureBox133.Location = New Point(247, 528)
            FormMain.PictureBox134.Location = New Point(293, 528)
            FormMain.PictureBox135.Location = New Point(339, 528)
            FormMain.PictureBox136.Location = New Point(385, 528)
            FormMain.PictureBox137.Location = New Point(431, 528)
            FormMain.PictureBox138.Location = New Point(477, 528)
            FormMain.PictureBox139.Location = New Point(523, 528)
            FormMain.PictureBox140.Location = New Point(569, 528)
            FormMain.PictureBox141.Location = New Point(615, 528)
            FormMain.PictureBox142.Location = New Point(661, 528)
            FormMain.PictureBox143.Location = New Point(707, 528)
            FormMain.PictureBox144.Location = New Point(753, 528)
            FormMain.PictureBox145.Location = New Point(799, 528)
            FormMain.PictureBox146.Location = New Point(845, 528)
            FormMain.PictureBox147.Location = New Point(201, 564)
            FormMain.PictureBox148.Location = New Point(247, 564)
            FormMain.PictureBox149.Location = New Point(293, 564)
            FormMain.PictureBox150.Location = New Point(339, 564)
            FormMain.PictureBox164.Location = New Point(385, 564)
            FormMain.PictureBox151.Location = New Point(431, 564)
            FormMain.PictureBox152.Location = New Point(477, 564)
            FormMain.PictureBox153.Location = New Point(523, 564)
            FormMain.PictureBox154.Location = New Point(569, 564)
            FormMain.PictureBox155.Location = New Point(615, 564)
            FormMain.PictureBox156.Location = New Point(661, 564)
            FormMain.PictureBox157.Location = New Point(707, 564)
            FormMain.PictureBox158.Location = New Point(753, 564)
            FormMain.PictureBox159.Location = New Point(799, 564)
            FormMain.PictureBox165.Location = New Point(845, 564)
        End If
    End Sub

End Class
