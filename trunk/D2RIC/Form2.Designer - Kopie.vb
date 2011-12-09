<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label0 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox30 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.ComboBox8 = New System.Windows.Forms.ComboBox()
        Me.ComboBox9 = New System.Windows.Forms.ComboBox()
        Me.ComboBox10 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Alchemist", "Ancient Apparition", "Anti-Mage", "Axe", "Batrider", "Beastmaster", "Bloodseeker", "Broodmother", "Chen", "Clockwerk", "Crystal Maiden", "Dark Seer", "Dazzle", "Doom Bringer", "Dragon Knight", "Drow Ranger", "Earthshaker", "Enchantress", "Enigma", "Faceless Void", "Huskar", "Jakiro", "Juggernaut", "Kunkka", "Leshrac", "Lich", "Lifestealer", "Lina", "Lion", "Mirana", "Morphling", "Nature's Prophet", "Necrolyte", "Night Stalker", "Omniknight", "Puck", "Pudge", "Pugna", "Queen of Pain", "Razor", "Riki", "Sand King", "Shadow Fiend", "Shadow Shaman", "Skeleton King", "Slardar", "Sniper", "Spectre", "Storm Spirit", "Sven", "Tidehunter", "Tinker", "Tiny", "Vengeful Spirit", "Venomancer", "Viper", "Warlock", "Weaver", "Windrunner", "Witch Doctor", "Zeus"})
        Me.ListBox1.Location = New System.Drawing.Point(12, 34)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(143, 550)
        Me.ListBox1.TabIndex = 0
        '
        'Label0
        '
        Me.Label0.AutoSize = True
        Me.Label0.Location = New System.Drawing.Point(13, 13)
        Me.Label0.Name = "Label0"
        Me.Label0.Size = New System.Drawing.Size(157, 13)
        Me.Label0.TabIndex = 1
        Me.Label0.Text = "Heroes (double click to choose)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(179, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Starting Items"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"none", "Aghanim's Scepter", "Animal Courier", "Arcane Boots", "Armlet", "Assault Cuirass", "Battle Fury", "Belt of Strength", "Black King Bar", "Blade Mail", "Blade of Alacrity", "Blades of Attack", "Blink Dagger", "Bloodstone", "Boots of Elvenskin", "Boots of Speed", "Boots of Travel", "Bottle", "Bracer", "Broadsword", "Buckler", "Butterfly", "Chainmail", "Circlet", "Clarity", "Claymore", "Cloak", "Crystalys", "Daedalus", "Dagon 1", "Dagon 2", "Dagon 3", "Dagon 4", "Dagon 5", "Demon Edge", "Desolator", "Diffusal Blade 1", "Diffusal Blade 2", "Divine Rapier", "Drum of Endurance", "Dust of Appearance", "Eaglesong", "Energy Booster", "Ethereal Blade", "Eul's Scepter of Divinity", "Eye of Skadi", "Flying Courier", "Force Staff", "Gauntlets of Strength", "Gem of True Sight", "Ghost Scepter", "Gloves of Haste", "Hand of Midas", "Headdress", "Healing Salve", "Heart of Tarrasque", "Helm of Iron Will", "Helm of the Dominator", "Hood of Defiance", "Hyperstone", "Iron Branch", "Javelin", "Linken's Sphere", "Maelstrom", "Magic Stick", "Magic Wand", "Manta Style", "Mantle of Intelligence", "Mask of Madness", "Medallion of Courage", "Mekansm", "Mithril Hammer", "Mjollnir", "Monkey King Bar", "Morbid Mask", "Mystic Staff", "Necronomicon 1", "Necronomicon 2", "Necronomicon 3", "Null Talisman", "Oblivion Staff", "Observer Ward", "Ogre Club", "Orb of Venom", "Orchid Malevolence", "Perseverance", "Phase Boots", "Pipe of Insight", "Platemail", "Point Booster", "Poor Man's Shield", "Power Treads", "Quarterstaff", "Quelling Blade", "Radiance", "Reaver", "Recipe: Aghanim's Scepter", "Recipe: Arcane Boots", "Recipe: Armlet", "Recipe: Assault Cuirass", "Recipe: Battle Fury", "Recipe: Black King Bar", "Recipe: Blade Mail", "Recipe: Bloodstone", "Recipe: Boots of Travel", "Recipe: Bracer", "Recipe: Buckler", "Recipe: Butterfly", "Recipe: Crystalys", "Recipe: Daedalus", "Recipe: Dagon 1", "Recipe: Dagon 2", "Recipe: Dagon 3", "Recipe: Dagon 4", "Recipe: Dagon 5", "Recipe: Desolator", "Recipe: Diffusal Blade 1", "Recipe: Diffusal Blade 2", "Recipe: Divine Rapier", "Recipe: Drum of Endurance", "Recipe: Ethereal Blade", "Recipe: Eul's Scepter of Divinity", "Recipe: Eye of Skadi", "Recipe: Force Staff", "Recipe: Hand of Midas", "Recipe: Headdress", "Recipe: Heart of Tarrasque", "Recipe: Helm of the Dominator", "Recipe: Hood of Defiance", "Recipe: Linken's Sphere", "Recipe: Maelstrom", "Recipe: Magic Wand", "Recipe: Manta Style", "Recipe: Mask of Madness", "Recipe: Medallion of Courage", "Recipe: Mekansm", "Recipe: Mjollnir", "Recipe: Monkey King Bar", "Recipe: Necronomicon 1", "Recipe: Necronomicon 2", "Recipe: Necronomicon 3", "Recipe: Null Talisman", "Recipe: Oblivion Staff", "Recipe: Orchid Malevolence", "Recipe: Perseverance", "Recipe: Phase Boots", "Recipe: Pipe of Insight", "Recipe: Poor Man's Shield", "Recipe: Power Treads", "Recipe: Radiance", "Recipe: Refresher Orb", "Recipe: Ring of Basilius", "Recipe: Sange", "Recipe: Sange and Yasha", "Recipe: Satanic", "Recipe: Scythe of Vyse", "Recipe: Shadow Blade", "Recipe: Shiva's Guard", "Recipe: Skull Basher", "Recipe: Soul Booster", "Recipe: Soul Ring", "Recipe: Urn of Shadows", "Recipe: Vanguard", "Recipe: Veil of Discord", "Recipe: Vladmir's Offering", "Recipe: Wraith Band", "Recipe: Yasha", "Refresher Orb", "Ring of Basilius", "Ring of Health", "Ring of Protection", "Ring of Regen", "Robe of the Magi", "Sacred Relic", "Sage's Mask", "Sange", "Sange and Yasha", "Satanic", "Sentry Ward", "Shadow Blade", "Sheepstick", "Shiva's Guard", "Skull Basher", "Slippers of Agility", "Smoke of Deceit", "Soul Booster", "Soul Ring", "Staff of Wizardry", "Stout Shield", "Talisman of Evasion", "Tango", "Town Portal Scroll", "Ultimate Orb", "Urn of Shadows", "Vanguard", "Veil of Discord", "Vitality Booster", "Vladmir's Offering", "Void Stone", "Wraith Band", "Yasha"})
        Me.ComboBox1.Location = New System.Drawing.Point(273, 31)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(210, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(211, 561)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(132, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Open Itembuilds Folder"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(687, 561)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(179, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Early Game"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(179, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Core Items"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(179, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 15)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Luxury"
        '
        'ComboBox30
        '
        Me.ComboBox30.FormattingEnabled = True
        Me.ComboBox30.Items.AddRange(New Object() {"none", "Aghanim's Scepter", "Animal Courier", "Arcane Boots", "Armlet", "Assault Cuirass", "Battle Fury", "Belt of Strength", "Black King Bar", "Blade Mail", "Blade of Alacrity", "Blades of Attack", "Blink Dagger", "Bloodstone", "Boots of Elvenskin", "Boots of Speed", "Boots of Travel", "Bottle", "Bracer", "Broadsword", "Buckler", "Butterfly", "Chainmail", "Circlet", "Clarity", "Claymore", "Cloak", "Crystalys", "Daedalus", "Dagon 1", "Dagon 2", "Dagon 3", "Dagon 4", "Dagon 5", "Demon Edge", "Desolator", "Diffusal Blade 1", "Diffusal Blade 2", "Divine Rapier", "Drum of Endurance", "Dust of Appearance", "Eaglesong", "Energy Booster", "Ethereal Blade", "Eul's Scepter of Divinity", "Eye of Skadi", "Flying Courier", "Force Staff", "Gauntlets of Strength", "Gem of True Sight", "Ghost Scepter", "Gloves of Haste", "Hand of Midas", "Headdress", "Healing Salve", "Heart of Tarrasque", "Helm of Iron Will", "Helm of the Dominator", "Hood of Defiance", "Hyperstone", "Iron Branch", "Javelin", "Linken's Sphere", "Maelstrom", "Magic Stick", "Magic Wand", "Manta Style", "Mantle of Intelligence", "Mask of Madness", "Medallion of Courage", "Mekansm", "Mithril Hammer", "Mjollnir", "Monkey King Bar", "Morbid Mask", "Mystic Staff", "Necronomicon 1", "Necronomicon 2", "Necronomicon 3", "Null Talisman", "Oblivion Staff", "Observer Ward", "Ogre Club", "Orb of Venom", "Orchid Malevolence", "Perseverance", "Phase Boots", "Pipe of Insight", "Platemail", "Point Booster", "Poor Man's Shield", "Power Treads", "Quarterstaff", "Quelling Blade", "Radiance", "Reaver", "Recipe: Aghanim's Scepter", "Recipe: Arcane Boots", "Recipe: Armlet", "Recipe: Assault Cuirass", "Recipe: Battle Fury", "Recipe: Black King Bar", "Recipe: Blade Mail", "Recipe: Bloodstone", "Recipe: Boots of Travel", "Recipe: Bracer", "Recipe: Buckler", "Recipe: Butterfly", "Recipe: Crystalys", "Recipe: Daedalus", "Recipe: Dagon 1", "Recipe: Dagon 2", "Recipe: Dagon 3", "Recipe: Dagon 4", "Recipe: Dagon 5", "Recipe: Desolator", "Recipe: Diffusal Blade 1", "Recipe: Diffusal Blade 2", "Recipe: Divine Rapier", "Recipe: Drum of Endurance", "Recipe: Ethereal Blade", "Recipe: Eul's Scepter of Divinity", "Recipe: Eye of Skadi", "Recipe: Force Staff", "Recipe: Hand of Midas", "Recipe: Headdress", "Recipe: Heart of Tarrasque", "Recipe: Helm of the Dominator", "Recipe: Hood of Defiance", "Recipe: Linken's Sphere", "Recipe: Maelstrom", "Recipe: Magic Wand", "Recipe: Manta Style", "Recipe: Mask of Madness", "Recipe: Medallion of Courage", "Recipe: Mekansm", "Recipe: Mjollnir", "Recipe: Monkey King Bar", "Recipe: Necronomicon 1", "Recipe: Necronomicon 2", "Recipe: Necronomicon 3", "Recipe: Null Talisman", "Recipe: Oblivion Staff", "Recipe: Orchid Malevolence", "Recipe: Perseverance", "Recipe: Phase Boots", "Recipe: Pipe of Insight", "Recipe: Poor Man's Shield", "Recipe: Power Treads", "Recipe: Radiance", "Recipe: Refresher Orb", "Recipe: Ring of Basilius", "Recipe: Sange", "Recipe: Sange and Yasha", "Recipe: Satanic", "Recipe: Scythe of Vyse", "Recipe: Shadow Blade", "Recipe: Shiva's Guard", "Recipe: Skull Basher", "Recipe: Soul Booster", "Recipe: Soul Ring", "Recipe: Urn of Shadows", "Recipe: Vanguard", "Recipe: Veil of Discord", "Recipe: Vladmir's Offering", "Recipe: Wraith Band", "Recipe: Yasha", "Refresher Orb", "Ring of Basilius", "Ring of Health", "Ring of Protection", "Ring of Regen", "Robe of the Magi", "Sacred Relic", "Sage's Mask", "Sange", "Sange and Yasha", "Satanic", "Sentry Ward", "Shadow Blade", "Sheepstick", "Shiva's Guard", "Skull Basher", "Slippers of Agility", "Smoke of Deceit", "Soul Booster", "Soul Ring", "Staff of Wizardry", "Stout Shield", "Talisman of Evasion", "Tango", "Town Portal Scroll", "Ultimate Orb", "Urn of Shadows", "Vanguard", "Veil of Discord", "Vitality Booster", "Vladmir's Offering", "Void Stone", "Wraith Band", "Yasha"})
        Me.ComboBox30.Location = New System.Drawing.Point(580, 409)
        Me.ComboBox30.Name = "ComboBox30"
        Me.ComboBox30.Size = New System.Drawing.Size(210, 21)
        Me.ComboBox30.TabIndex = 49
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(179, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Core Items"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(179, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Core Items"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(179, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "Core Items"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(179, 223)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "Core Items"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(179, 250)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "Core Items"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(179, 277)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "Core Items"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(179, 304)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 13)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "Core Items"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(179, 331)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 13)
        Me.Label12.TabIndex = 75
        Me.Label12.Text = "Core Items"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(179, 358)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 13)
        Me.Label13.TabIndex = 76
        Me.Label13.Text = "Core Items"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(179, 385)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 13)
        Me.Label14.TabIndex = 77
        Me.Label14.Text = "Core Items"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(179, 412)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 13)
        Me.Label15.TabIndex = 78
        Me.Label15.Text = "Core Items"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(809, 34)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(67, 13)
        Me.Label16.TabIndex = 93
        Me.Label16.Text = "Core Items"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(809, 61)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 13)
        Me.Label17.TabIndex = 92
        Me.Label17.Text = "Core Items"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(809, 88)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(67, 13)
        Me.Label18.TabIndex = 91
        Me.Label18.Text = "Core Items"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(809, 115)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(67, 13)
        Me.Label19.TabIndex = 90
        Me.Label19.Text = "Core Items"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(809, 142)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(67, 13)
        Me.Label20.TabIndex = 89
        Me.Label20.Text = "Core Items"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(809, 169)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(67, 13)
        Me.Label21.TabIndex = 88
        Me.Label21.Text = "Core Items"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(809, 196)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(67, 13)
        Me.Label22.TabIndex = 87
        Me.Label22.Text = "Core Items"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(809, 223)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(67, 13)
        Me.Label23.TabIndex = 86
        Me.Label23.Text = "Core Items"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(809, 250)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(67, 13)
        Me.Label24.TabIndex = 85
        Me.Label24.Text = "Core Items"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(809, 277)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(67, 13)
        Me.Label25.TabIndex = 84
        Me.Label25.Text = "Core Items"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(809, 304)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(67, 13)
        Me.Label26.TabIndex = 83
        Me.Label26.Text = "Core Items"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(809, 356)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(49, 15)
        Me.Label27.TabIndex = 82
        Me.Label27.Text = "Luxury"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(809, 331)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(67, 13)
        Me.Label28.TabIndex = 81
        Me.Label28.Text = "Core Items"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(809, 385)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(71, 13)
        Me.Label29.TabIndex = 80
        Me.Label29.Text = "Early Game"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(809, 412)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(85, 13)
        Me.Label30.TabIndex = 79
        Me.Label30.Text = "Starting Items"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"none", "Aghanim's Scepter", "Animal Courier", "Arcane Boots", "Armlet", "Assault Cuirass", "Battle Fury", "Belt of Strength", "Black King Bar", "Blade Mail", "Blade of Alacrity", "Blades of Attack", "Blink Dagger", "Bloodstone", "Boots of Elvenskin", "Boots of Speed", "Boots of Travel", "Bottle", "Bracer", "Broadsword", "Buckler", "Butterfly", "Chainmail", "Circlet", "Clarity", "Claymore", "Cloak", "Crystalys", "Daedalus", "Dagon 1", "Dagon 2", "Dagon 3", "Dagon 4", "Dagon 5", "Demon Edge", "Desolator", "Diffusal Blade 1", "Diffusal Blade 2", "Divine Rapier", "Drum of Endurance", "Dust of Appearance", "Eaglesong", "Energy Booster", "Ethereal Blade", "Eul's Scepter of Divinity", "Eye of Skadi", "Flying Courier", "Force Staff", "Gauntlets of Strength", "Gem of True Sight", "Ghost Scepter", "Gloves of Haste", "Hand of Midas", "Headdress", "Healing Salve", "Heart of Tarrasque", "Helm of Iron Will", "Helm of the Dominator", "Hood of Defiance", "Hyperstone", "Iron Branch", "Javelin", "Linken's Sphere", "Maelstrom", "Magic Stick", "Magic Wand", "Manta Style", "Mantle of Intelligence", "Mask of Madness", "Medallion of Courage", "Mekansm", "Mithril Hammer", "Mjollnir", "Monkey King Bar", "Morbid Mask", "Mystic Staff", "Necronomicon 1", "Necronomicon 2", "Necronomicon 3", "Null Talisman", "Oblivion Staff", "Observer Ward", "Ogre Club", "Orb of Venom", "Orchid Malevolence", "Perseverance", "Phase Boots", "Pipe of Insight", "Platemail", "Point Booster", "Poor Man's Shield", "Power Treads", "Quarterstaff", "Quelling Blade", "Radiance", "Reaver", "Recipe: Aghanim's Scepter", "Recipe: Arcane Boots", "Recipe: Armlet", "Recipe: Assault Cuirass", "Recipe: Battle Fury", "Recipe: Black King Bar", "Recipe: Blade Mail", "Recipe: Bloodstone", "Recipe: Boots of Travel", "Recipe: Bracer", "Recipe: Buckler", "Recipe: Butterfly", "Recipe: Crystalys", "Recipe: Daedalus", "Recipe: Dagon 1", "Recipe: Dagon 2", "Recipe: Dagon 3", "Recipe: Dagon 4", "Recipe: Dagon 5", "Recipe: Desolator", "Recipe: Diffusal Blade 1", "Recipe: Diffusal Blade 2", "Recipe: Divine Rapier", "Recipe: Drum of Endurance", "Recipe: Ethereal Blade", "Recipe: Eul's Scepter of Divinity", "Recipe: Eye of Skadi", "Recipe: Force Staff", "Recipe: Hand of Midas", "Recipe: Headdress", "Recipe: Heart of Tarrasque", "Recipe: Helm of the Dominator", "Recipe: Hood of Defiance", "Recipe: Linken's Sphere", "Recipe: Maelstrom", "Recipe: Magic Wand", "Recipe: Manta Style", "Recipe: Mask of Madness", "Recipe: Medallion of Courage", "Recipe: Mekansm", "Recipe: Mjollnir", "Recipe: Monkey King Bar", "Recipe: Necronomicon 1", "Recipe: Necronomicon 2", "Recipe: Necronomicon 3", "Recipe: Null Talisman", "Recipe: Oblivion Staff", "Recipe: Orchid Malevolence", "Recipe: Perseverance", "Recipe: Phase Boots", "Recipe: Pipe of Insight", "Recipe: Poor Man's Shield", "Recipe: Power Treads", "Recipe: Radiance", "Recipe: Refresher Orb", "Recipe: Ring of Basilius", "Recipe: Sange", "Recipe: Sange and Yasha", "Recipe: Satanic", "Recipe: Scythe of Vyse", "Recipe: Shadow Blade", "Recipe: Shiva's Guard", "Recipe: Skull Basher", "Recipe: Soul Booster", "Recipe: Soul Ring", "Recipe: Urn of Shadows", "Recipe: Vanguard", "Recipe: Veil of Discord", "Recipe: Vladmir's Offering", "Recipe: Wraith Band", "Recipe: Yasha", "Refresher Orb", "Ring of Basilius", "Ring of Health", "Ring of Protection", "Ring of Regen", "Robe of the Magi", "Sacred Relic", "Sage's Mask", "Sange", "Sange and Yasha", "Satanic", "Sentry Ward", "Shadow Blade", "Sheepstick", "Shiva's Guard", "Skull Basher", "Slippers of Agility", "Smoke of Deceit", "Soul Booster", "Soul Ring", "Staff of Wizardry", "Stout Shield", "Talisman of Evasion", "Tango", "Town Portal Scroll", "Ultimate Orb", "Urn of Shadows", "Vanguard", "Veil of Discord", "Vitality Booster", "Vladmir's Offering", "Void Stone", "Wraith Band", "Yasha"})
        Me.ComboBox2.Location = New System.Drawing.Point(273, 58)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(210, 21)
        Me.ComboBox2.TabIndex = 94
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"none", "Aghanim's Scepter", "Animal Courier", "Arcane Boots", "Armlet", "Assault Cuirass", "Battle Fury", "Belt of Strength", "Black King Bar", "Blade Mail", "Blade of Alacrity", "Blades of Attack", "Blink Dagger", "Bloodstone", "Boots of Elvenskin", "Boots of Speed", "Boots of Travel", "Bottle", "Bracer", "Broadsword", "Buckler", "Butterfly", "Chainmail", "Circlet", "Clarity", "Claymore", "Cloak", "Crystalys", "Daedalus", "Dagon 1", "Dagon 2", "Dagon 3", "Dagon 4", "Dagon 5", "Demon Edge", "Desolator", "Diffusal Blade 1", "Diffusal Blade 2", "Divine Rapier", "Drum of Endurance", "Dust of Appearance", "Eaglesong", "Energy Booster", "Ethereal Blade", "Eul's Scepter of Divinity", "Eye of Skadi", "Flying Courier", "Force Staff", "Gauntlets of Strength", "Gem of True Sight", "Ghost Scepter", "Gloves of Haste", "Hand of Midas", "Headdress", "Healing Salve", "Heart of Tarrasque", "Helm of Iron Will", "Helm of the Dominator", "Hood of Defiance", "Hyperstone", "Iron Branch", "Javelin", "Linken's Sphere", "Maelstrom", "Magic Stick", "Magic Wand", "Manta Style", "Mantle of Intelligence", "Mask of Madness", "Medallion of Courage", "Mekansm", "Mithril Hammer", "Mjollnir", "Monkey King Bar", "Morbid Mask", "Mystic Staff", "Necronomicon 1", "Necronomicon 2", "Necronomicon 3", "Null Talisman", "Oblivion Staff", "Observer Ward", "Ogre Club", "Orb of Venom", "Orchid Malevolence", "Perseverance", "Phase Boots", "Pipe of Insight", "Platemail", "Point Booster", "Poor Man's Shield", "Power Treads", "Quarterstaff", "Quelling Blade", "Radiance", "Reaver", "Recipe: Aghanim's Scepter", "Recipe: Arcane Boots", "Recipe: Armlet", "Recipe: Assault Cuirass", "Recipe: Battle Fury", "Recipe: Black King Bar", "Recipe: Blade Mail", "Recipe: Bloodstone", "Recipe: Boots of Travel", "Recipe: Bracer", "Recipe: Buckler", "Recipe: Butterfly", "Recipe: Crystalys", "Recipe: Daedalus", "Recipe: Dagon 1", "Recipe: Dagon 2", "Recipe: Dagon 3", "Recipe: Dagon 4", "Recipe: Dagon 5", "Recipe: Desolator", "Recipe: Diffusal Blade 1", "Recipe: Diffusal Blade 2", "Recipe: Divine Rapier", "Recipe: Drum of Endurance", "Recipe: Ethereal Blade", "Recipe: Eul's Scepter of Divinity", "Recipe: Eye of Skadi", "Recipe: Force Staff", "Recipe: Hand of Midas", "Recipe: Headdress", "Recipe: Heart of Tarrasque", "Recipe: Helm of the Dominator", "Recipe: Hood of Defiance", "Recipe: Linken's Sphere", "Recipe: Maelstrom", "Recipe: Magic Wand", "Recipe: Manta Style", "Recipe: Mask of Madness", "Recipe: Medallion of Courage", "Recipe: Mekansm", "Recipe: Mjollnir", "Recipe: Monkey King Bar", "Recipe: Necronomicon 1", "Recipe: Necronomicon 2", "Recipe: Necronomicon 3", "Recipe: Null Talisman", "Recipe: Oblivion Staff", "Recipe: Orchid Malevolence", "Recipe: Perseverance", "Recipe: Phase Boots", "Recipe: Pipe of Insight", "Recipe: Poor Man's Shield", "Recipe: Power Treads", "Recipe: Radiance", "Recipe: Refresher Orb", "Recipe: Ring of Basilius", "Recipe: Sange", "Recipe: Sange and Yasha", "Recipe: Satanic", "Recipe: Scythe of Vyse", "Recipe: Shadow Blade", "Recipe: Shiva's Guard", "Recipe: Skull Basher", "Recipe: Soul Booster", "Recipe: Soul Ring", "Recipe: Urn of Shadows", "Recipe: Vanguard", "Recipe: Veil of Discord", "Recipe: Vladmir's Offering", "Recipe: Wraith Band", "Recipe: Yasha", "Refresher Orb", "Ring of Basilius", "Ring of Health", "Ring of Protection", "Ring of Regen", "Robe of the Magi", "Sacred Relic", "Sage's Mask", "Sange", "Sange and Yasha", "Satanic", "Sentry Ward", "Shadow Blade", "Sheepstick", "Shiva's Guard", "Skull Basher", "Slippers of Agility", "Smoke of Deceit", "Soul Booster", "Soul Ring", "Staff of Wizardry", "Stout Shield", "Talisman of Evasion", "Tango", "Town Portal Scroll", "Ultimate Orb", "Urn of Shadows", "Vanguard", "Veil of Discord", "Vitality Booster", "Vladmir's Offering", "Void Stone", "Wraith Band", "Yasha"})
        Me.ComboBox3.Location = New System.Drawing.Point(273, 85)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(210, 21)
        Me.ComboBox3.TabIndex = 95
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"none", "Aghanim's Scepter", "Animal Courier", "Arcane Boots", "Armlet", "Assault Cuirass", "Battle Fury", "Belt of Strength", "Black King Bar", "Blade Mail", "Blade of Alacrity", "Blades of Attack", "Blink Dagger", "Bloodstone", "Boots of Elvenskin", "Boots of Speed", "Boots of Travel", "Bottle", "Bracer", "Broadsword", "Buckler", "Butterfly", "Chainmail", "Circlet", "Clarity", "Claymore", "Cloak", "Crystalys", "Daedalus", "Dagon 1", "Dagon 2", "Dagon 3", "Dagon 4", "Dagon 5", "Demon Edge", "Desolator", "Diffusal Blade 1", "Diffusal Blade 2", "Divine Rapier", "Drum of Endurance", "Dust of Appearance", "Eaglesong", "Energy Booster", "Ethereal Blade", "Eul's Scepter of Divinity", "Eye of Skadi", "Flying Courier", "Force Staff", "Gauntlets of Strength", "Gem of True Sight", "Ghost Scepter", "Gloves of Haste", "Hand of Midas", "Headdress", "Healing Salve", "Heart of Tarrasque", "Helm of Iron Will", "Helm of the Dominator", "Hood of Defiance", "Hyperstone", "Iron Branch", "Javelin", "Linken's Sphere", "Maelstrom", "Magic Stick", "Magic Wand", "Manta Style", "Mantle of Intelligence", "Mask of Madness", "Medallion of Courage", "Mekansm", "Mithril Hammer", "Mjollnir", "Monkey King Bar", "Morbid Mask", "Mystic Staff", "Necronomicon 1", "Necronomicon 2", "Necronomicon 3", "Null Talisman", "Oblivion Staff", "Observer Ward", "Ogre Club", "Orb of Venom", "Orchid Malevolence", "Perseverance", "Phase Boots", "Pipe of Insight", "Platemail", "Point Booster", "Poor Man's Shield", "Power Treads", "Quarterstaff", "Quelling Blade", "Radiance", "Reaver", "Recipe: Aghanim's Scepter", "Recipe: Arcane Boots", "Recipe: Armlet", "Recipe: Assault Cuirass", "Recipe: Battle Fury", "Recipe: Black King Bar", "Recipe: Blade Mail", "Recipe: Bloodstone", "Recipe: Boots of Travel", "Recipe: Bracer", "Recipe: Buckler", "Recipe: Butterfly", "Recipe: Crystalys", "Recipe: Daedalus", "Recipe: Dagon 1", "Recipe: Dagon 2", "Recipe: Dagon 3", "Recipe: Dagon 4", "Recipe: Dagon 5", "Recipe: Desolator", "Recipe: Diffusal Blade 1", "Recipe: Diffusal Blade 2", "Recipe: Divine Rapier", "Recipe: Drum of Endurance", "Recipe: Ethereal Blade", "Recipe: Eul's Scepter of Divinity", "Recipe: Eye of Skadi", "Recipe: Force Staff", "Recipe: Hand of Midas", "Recipe: Headdress", "Recipe: Heart of Tarrasque", "Recipe: Helm of the Dominator", "Recipe: Hood of Defiance", "Recipe: Linken's Sphere", "Recipe: Maelstrom", "Recipe: Magic Wand", "Recipe: Manta Style", "Recipe: Mask of Madness", "Recipe: Medallion of Courage", "Recipe: Mekansm", "Recipe: Mjollnir", "Recipe: Monkey King Bar", "Recipe: Necronomicon 1", "Recipe: Necronomicon 2", "Recipe: Necronomicon 3", "Recipe: Null Talisman", "Recipe: Oblivion Staff", "Recipe: Orchid Malevolence", "Recipe: Perseverance", "Recipe: Phase Boots", "Recipe: Pipe of Insight", "Recipe: Poor Man's Shield", "Recipe: Power Treads", "Recipe: Radiance", "Recipe: Refresher Orb", "Recipe: Ring of Basilius", "Recipe: Sange", "Recipe: Sange and Yasha", "Recipe: Satanic", "Recipe: Scythe of Vyse", "Recipe: Shadow Blade", "Recipe: Shiva's Guard", "Recipe: Skull Basher", "Recipe: Soul Booster", "Recipe: Soul Ring", "Recipe: Urn of Shadows", "Recipe: Vanguard", "Recipe: Veil of Discord", "Recipe: Vladmir's Offering", "Recipe: Wraith Band", "Recipe: Yasha", "Refresher Orb", "Ring of Basilius", "Ring of Health", "Ring of Protection", "Ring of Regen", "Robe of the Magi", "Sacred Relic", "Sage's Mask", "Sange", "Sange and Yasha", "Satanic", "Sentry Ward", "Shadow Blade", "Sheepstick", "Shiva's Guard", "Skull Basher", "Slippers of Agility", "Smoke of Deceit", "Soul Booster", "Soul Ring", "Staff of Wizardry", "Stout Shield", "Talisman of Evasion", "Tango", "Town Portal Scroll", "Ultimate Orb", "Urn of Shadows", "Vanguard", "Veil of Discord", "Vitality Booster", "Vladmir's Offering", "Void Stone", "Wraith Band", "Yasha"})
        Me.ComboBox4.Location = New System.Drawing.Point(273, 112)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(210, 21)
        Me.ComboBox4.TabIndex = 96
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"none", "Aghanim's Scepter", "Animal Courier", "Arcane Boots", "Armlet", "Assault Cuirass", "Battle Fury", "Belt of Strength", "Black King Bar", "Blade Mail", "Blade of Alacrity", "Blades of Attack", "Blink Dagger", "Bloodstone", "Boots of Elvenskin", "Boots of Speed", "Boots of Travel", "Bottle", "Bracer", "Broadsword", "Buckler", "Butterfly", "Chainmail", "Circlet", "Clarity", "Claymore", "Cloak", "Crystalys", "Daedalus", "Dagon 1", "Dagon 2", "Dagon 3", "Dagon 4", "Dagon 5", "Demon Edge", "Desolator", "Diffusal Blade 1", "Diffusal Blade 2", "Divine Rapier", "Drum of Endurance", "Dust of Appearance", "Eaglesong", "Energy Booster", "Ethereal Blade", "Eul's Scepter of Divinity", "Eye of Skadi", "Flying Courier", "Force Staff", "Gauntlets of Strength", "Gem of True Sight", "Ghost Scepter", "Gloves of Haste", "Hand of Midas", "Headdress", "Healing Salve", "Heart of Tarrasque", "Helm of Iron Will", "Helm of the Dominator", "Hood of Defiance", "Hyperstone", "Iron Branch", "Javelin", "Linken's Sphere", "Maelstrom", "Magic Stick", "Magic Wand", "Manta Style", "Mantle of Intelligence", "Mask of Madness", "Medallion of Courage", "Mekansm", "Mithril Hammer", "Mjollnir", "Monkey King Bar", "Morbid Mask", "Mystic Staff", "Necronomicon 1", "Necronomicon 2", "Necronomicon 3", "Null Talisman", "Oblivion Staff", "Observer Ward", "Ogre Club", "Orb of Venom", "Orchid Malevolence", "Perseverance", "Phase Boots", "Pipe of Insight", "Platemail", "Point Booster", "Poor Man's Shield", "Power Treads", "Quarterstaff", "Quelling Blade", "Radiance", "Reaver", "Recipe: Aghanim's Scepter", "Recipe: Arcane Boots", "Recipe: Armlet", "Recipe: Assault Cuirass", "Recipe: Battle Fury", "Recipe: Black King Bar", "Recipe: Blade Mail", "Recipe: Bloodstone", "Recipe: Boots of Travel", "Recipe: Bracer", "Recipe: Buckler", "Recipe: Butterfly", "Recipe: Crystalys", "Recipe: Daedalus", "Recipe: Dagon 1", "Recipe: Dagon 2", "Recipe: Dagon 3", "Recipe: Dagon 4", "Recipe: Dagon 5", "Recipe: Desolator", "Recipe: Diffusal Blade 1", "Recipe: Diffusal Blade 2", "Recipe: Divine Rapier", "Recipe: Drum of Endurance", "Recipe: Ethereal Blade", "Recipe: Eul's Scepter of Divinity", "Recipe: Eye of Skadi", "Recipe: Force Staff", "Recipe: Hand of Midas", "Recipe: Headdress", "Recipe: Heart of Tarrasque", "Recipe: Helm of the Dominator", "Recipe: Hood of Defiance", "Recipe: Linken's Sphere", "Recipe: Maelstrom", "Recipe: Magic Wand", "Recipe: Manta Style", "Recipe: Mask of Madness", "Recipe: Medallion of Courage", "Recipe: Mekansm", "Recipe: Mjollnir", "Recipe: Monkey King Bar", "Recipe: Necronomicon 1", "Recipe: Necronomicon 2", "Recipe: Necronomicon 3", "Recipe: Null Talisman", "Recipe: Oblivion Staff", "Recipe: Orchid Malevolence", "Recipe: Perseverance", "Recipe: Phase Boots", "Recipe: Pipe of Insight", "Recipe: Poor Man's Shield", "Recipe: Power Treads", "Recipe: Radiance", "Recipe: Refresher Orb", "Recipe: Ring of Basilius", "Recipe: Sange", "Recipe: Sange and Yasha", "Recipe: Satanic", "Recipe: Scythe of Vyse", "Recipe: Shadow Blade", "Recipe: Shiva's Guard", "Recipe: Skull Basher", "Recipe: Soul Booster", "Recipe: Soul Ring", "Recipe: Urn of Shadows", "Recipe: Vanguard", "Recipe: Veil of Discord", "Recipe: Vladmir's Offering", "Recipe: Wraith Band", "Recipe: Yasha", "Refresher Orb", "Ring of Basilius", "Ring of Health", "Ring of Protection", "Ring of Regen", "Robe of the Magi", "Sacred Relic", "Sage's Mask", "Sange", "Sange and Yasha", "Satanic", "Sentry Ward", "Shadow Blade", "Sheepstick", "Shiva's Guard", "Skull Basher", "Slippers of Agility", "Smoke of Deceit", "Soul Booster", "Soul Ring", "Staff of Wizardry", "Stout Shield", "Talisman of Evasion", "Tango", "Town Portal Scroll", "Ultimate Orb", "Urn of Shadows", "Vanguard", "Veil of Discord", "Vitality Booster", "Vladmir's Offering", "Void Stone", "Wraith Band", "Yasha"})
        Me.ComboBox5.Location = New System.Drawing.Point(273, 139)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(210, 21)
        Me.ComboBox5.TabIndex = 97
        '
        'ComboBox6
        '
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Items.AddRange(New Object() {"none", "Aghanim's Scepter", "Animal Courier", "Arcane Boots", "Armlet", "Assault Cuirass", "Battle Fury", "Belt of Strength", "Black King Bar", "Blade Mail", "Blade of Alacrity", "Blades of Attack", "Blink Dagger", "Bloodstone", "Boots of Elvenskin", "Boots of Speed", "Boots of Travel", "Bottle", "Bracer", "Broadsword", "Buckler", "Butterfly", "Chainmail", "Circlet", "Clarity", "Claymore", "Cloak", "Crystalys", "Daedalus", "Dagon 1", "Dagon 2", "Dagon 3", "Dagon 4", "Dagon 5", "Demon Edge", "Desolator", "Diffusal Blade 1", "Diffusal Blade 2", "Divine Rapier", "Drum of Endurance", "Dust of Appearance", "Eaglesong", "Energy Booster", "Ethereal Blade", "Eul's Scepter of Divinity", "Eye of Skadi", "Flying Courier", "Force Staff", "Gauntlets of Strength", "Gem of True Sight", "Ghost Scepter", "Gloves of Haste", "Hand of Midas", "Headdress", "Healing Salve", "Heart of Tarrasque", "Helm of Iron Will", "Helm of the Dominator", "Hood of Defiance", "Hyperstone", "Iron Branch", "Javelin", "Linken's Sphere", "Maelstrom", "Magic Stick", "Magic Wand", "Manta Style", "Mantle of Intelligence", "Mask of Madness", "Medallion of Courage", "Mekansm", "Mithril Hammer", "Mjollnir", "Monkey King Bar", "Morbid Mask", "Mystic Staff", "Necronomicon 1", "Necronomicon 2", "Necronomicon 3", "Null Talisman", "Oblivion Staff", "Observer Ward", "Ogre Club", "Orb of Venom", "Orchid Malevolence", "Perseverance", "Phase Boots", "Pipe of Insight", "Platemail", "Point Booster", "Poor Man's Shield", "Power Treads", "Quarterstaff", "Quelling Blade", "Radiance", "Reaver", "Recipe: Aghanim's Scepter", "Recipe: Arcane Boots", "Recipe: Armlet", "Recipe: Assault Cuirass", "Recipe: Battle Fury", "Recipe: Black King Bar", "Recipe: Blade Mail", "Recipe: Bloodstone", "Recipe: Boots of Travel", "Recipe: Bracer", "Recipe: Buckler", "Recipe: Butterfly", "Recipe: Crystalys", "Recipe: Daedalus", "Recipe: Dagon 1", "Recipe: Dagon 2", "Recipe: Dagon 3", "Recipe: Dagon 4", "Recipe: Dagon 5", "Recipe: Desolator", "Recipe: Diffusal Blade 1", "Recipe: Diffusal Blade 2", "Recipe: Divine Rapier", "Recipe: Drum of Endurance", "Recipe: Ethereal Blade", "Recipe: Eul's Scepter of Divinity", "Recipe: Eye of Skadi", "Recipe: Force Staff", "Recipe: Hand of Midas", "Recipe: Headdress", "Recipe: Heart of Tarrasque", "Recipe: Helm of the Dominator", "Recipe: Hood of Defiance", "Recipe: Linken's Sphere", "Recipe: Maelstrom", "Recipe: Magic Wand", "Recipe: Manta Style", "Recipe: Mask of Madness", "Recipe: Medallion of Courage", "Recipe: Mekansm", "Recipe: Mjollnir", "Recipe: Monkey King Bar", "Recipe: Necronomicon 1", "Recipe: Necronomicon 2", "Recipe: Necronomicon 3", "Recipe: Null Talisman", "Recipe: Oblivion Staff", "Recipe: Orchid Malevolence", "Recipe: Perseverance", "Recipe: Phase Boots", "Recipe: Pipe of Insight", "Recipe: Poor Man's Shield", "Recipe: Power Treads", "Recipe: Radiance", "Recipe: Refresher Orb", "Recipe: Ring of Basilius", "Recipe: Sange", "Recipe: Sange and Yasha", "Recipe: Satanic", "Recipe: Scythe of Vyse", "Recipe: Shadow Blade", "Recipe: Shiva's Guard", "Recipe: Skull Basher", "Recipe: Soul Booster", "Recipe: Soul Ring", "Recipe: Urn of Shadows", "Recipe: Vanguard", "Recipe: Veil of Discord", "Recipe: Vladmir's Offering", "Recipe: Wraith Band", "Recipe: Yasha", "Refresher Orb", "Ring of Basilius", "Ring of Health", "Ring of Protection", "Ring of Regen", "Robe of the Magi", "Sacred Relic", "Sage's Mask", "Sange", "Sange and Yasha", "Satanic", "Sentry Ward", "Shadow Blade", "Sheepstick", "Shiva's Guard", "Skull Basher", "Slippers of Agility", "Smoke of Deceit", "Soul Booster", "Soul Ring", "Staff of Wizardry", "Stout Shield", "Talisman of Evasion", "Tango", "Town Portal Scroll", "Ultimate Orb", "Urn of Shadows", "Vanguard", "Veil of Discord", "Vitality Booster", "Vladmir's Offering", "Void Stone", "Wraith Band", "Yasha"})
        Me.ComboBox6.Location = New System.Drawing.Point(273, 166)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(210, 21)
        Me.ComboBox6.TabIndex = 98
        '
        'ComboBox7
        '
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Items.AddRange(New Object() {"none", "Aghanim's Scepter", "Animal Courier", "Arcane Boots", "Armlet", "Assault Cuirass", "Battle Fury", "Belt of Strength", "Black King Bar", "Blade Mail", "Blade of Alacrity", "Blades of Attack", "Blink Dagger", "Bloodstone", "Boots of Elvenskin", "Boots of Speed", "Boots of Travel", "Bottle", "Bracer", "Broadsword", "Buckler", "Butterfly", "Chainmail", "Circlet", "Clarity", "Claymore", "Cloak", "Crystalys", "Daedalus", "Dagon 1", "Dagon 2", "Dagon 3", "Dagon 4", "Dagon 5", "Demon Edge", "Desolator", "Diffusal Blade 1", "Diffusal Blade 2", "Divine Rapier", "Drum of Endurance", "Dust of Appearance", "Eaglesong", "Energy Booster", "Ethereal Blade", "Eul's Scepter of Divinity", "Eye of Skadi", "Flying Courier", "Force Staff", "Gauntlets of Strength", "Gem of True Sight", "Ghost Scepter", "Gloves of Haste", "Hand of Midas", "Headdress", "Healing Salve", "Heart of Tarrasque", "Helm of Iron Will", "Helm of the Dominator", "Hood of Defiance", "Hyperstone", "Iron Branch", "Javelin", "Linken's Sphere", "Maelstrom", "Magic Stick", "Magic Wand", "Manta Style", "Mantle of Intelligence", "Mask of Madness", "Medallion of Courage", "Mekansm", "Mithril Hammer", "Mjollnir", "Monkey King Bar", "Morbid Mask", "Mystic Staff", "Necronomicon 1", "Necronomicon 2", "Necronomicon 3", "Null Talisman", "Oblivion Staff", "Observer Ward", "Ogre Club", "Orb of Venom", "Orchid Malevolence", "Perseverance", "Phase Boots", "Pipe of Insight", "Platemail", "Point Booster", "Poor Man's Shield", "Power Treads", "Quarterstaff", "Quelling Blade", "Radiance", "Reaver", "Recipe: Aghanim's Scepter", "Recipe: Arcane Boots", "Recipe: Armlet", "Recipe: Assault Cuirass", "Recipe: Battle Fury", "Recipe: Black King Bar", "Recipe: Blade Mail", "Recipe: Bloodstone", "Recipe: Boots of Travel", "Recipe: Bracer", "Recipe: Buckler", "Recipe: Butterfly", "Recipe: Crystalys", "Recipe: Daedalus", "Recipe: Dagon 1", "Recipe: Dagon 2", "Recipe: Dagon 3", "Recipe: Dagon 4", "Recipe: Dagon 5", "Recipe: Desolator", "Recipe: Diffusal Blade 1", "Recipe: Diffusal Blade 2", "Recipe: Divine Rapier", "Recipe: Drum of Endurance", "Recipe: Ethereal Blade", "Recipe: Eul's Scepter of Divinity", "Recipe: Eye of Skadi", "Recipe: Force Staff", "Recipe: Hand of Midas", "Recipe: Headdress", "Recipe: Heart of Tarrasque", "Recipe: Helm of the Dominator", "Recipe: Hood of Defiance", "Recipe: Linken's Sphere", "Recipe: Maelstrom", "Recipe: Magic Wand", "Recipe: Manta Style", "Recipe: Mask of Madness", "Recipe: Medallion of Courage", "Recipe: Mekansm", "Recipe: Mjollnir", "Recipe: Monkey King Bar", "Recipe: Necronomicon 1", "Recipe: Necronomicon 2", "Recipe: Necronomicon 3", "Recipe: Null Talisman", "Recipe: Oblivion Staff", "Recipe: Orchid Malevolence", "Recipe: Perseverance", "Recipe: Phase Boots", "Recipe: Pipe of Insight", "Recipe: Poor Man's Shield", "Recipe: Power Treads", "Recipe: Radiance", "Recipe: Refresher Orb", "Recipe: Ring of Basilius", "Recipe: Sange", "Recipe: Sange and Yasha", "Recipe: Satanic", "Recipe: Scythe of Vyse", "Recipe: Shadow Blade", "Recipe: Shiva's Guard", "Recipe: Skull Basher", "Recipe: Soul Booster", "Recipe: Soul Ring", "Recipe: Urn of Shadows", "Recipe: Vanguard", "Recipe: Veil of Discord", "Recipe: Vladmir's Offering", "Recipe: Wraith Band", "Recipe: Yasha", "Refresher Orb", "Ring of Basilius", "Ring of Health", "Ring of Protection", "Ring of Regen", "Robe of the Magi", "Sacred Relic", "Sage's Mask", "Sange", "Sange and Yasha", "Satanic", "Sentry Ward", "Shadow Blade", "Sheepstick", "Shiva's Guard", "Skull Basher", "Slippers of Agility", "Smoke of Deceit", "Soul Booster", "Soul Ring", "Staff of Wizardry", "Stout Shield", "Talisman of Evasion", "Tango", "Town Portal Scroll", "Ultimate Orb", "Urn of Shadows", "Vanguard", "Veil of Discord", "Vitality Booster", "Vladmir's Offering", "Void Stone", "Wraith Band", "Yasha"})
        Me.ComboBox7.Location = New System.Drawing.Point(273, 193)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(210, 21)
        Me.ComboBox7.TabIndex = 99
        '
        'ComboBox8
        '
        Me.ComboBox8.FormattingEnabled = True
        Me.ComboBox8.Items.AddRange(New Object() {"none", "Aghanim's Scepter", "Animal Courier", "Arcane Boots", "Armlet", "Assault Cuirass", "Battle Fury", "Belt of Strength", "Black King Bar", "Blade Mail", "Blade of Alacrity", "Blades of Attack", "Blink Dagger", "Bloodstone", "Boots of Elvenskin", "Boots of Speed", "Boots of Travel", "Bottle", "Bracer", "Broadsword", "Buckler", "Butterfly", "Chainmail", "Circlet", "Clarity", "Claymore", "Cloak", "Crystalys", "Daedalus", "Dagon 1", "Dagon 2", "Dagon 3", "Dagon 4", "Dagon 5", "Demon Edge", "Desolator", "Diffusal Blade 1", "Diffusal Blade 2", "Divine Rapier", "Drum of Endurance", "Dust of Appearance", "Eaglesong", "Energy Booster", "Ethereal Blade", "Eul's Scepter of Divinity", "Eye of Skadi", "Flying Courier", "Force Staff", "Gauntlets of Strength", "Gem of True Sight", "Ghost Scepter", "Gloves of Haste", "Hand of Midas", "Headdress", "Healing Salve", "Heart of Tarrasque", "Helm of Iron Will", "Helm of the Dominator", "Hood of Defiance", "Hyperstone", "Iron Branch", "Javelin", "Linken's Sphere", "Maelstrom", "Magic Stick", "Magic Wand", "Manta Style", "Mantle of Intelligence", "Mask of Madness", "Medallion of Courage", "Mekansm", "Mithril Hammer", "Mjollnir", "Monkey King Bar", "Morbid Mask", "Mystic Staff", "Necronomicon 1", "Necronomicon 2", "Necronomicon 3", "Null Talisman", "Oblivion Staff", "Observer Ward", "Ogre Club", "Orb of Venom", "Orchid Malevolence", "Perseverance", "Phase Boots", "Pipe of Insight", "Platemail", "Point Booster", "Poor Man's Shield", "Power Treads", "Quarterstaff", "Quelling Blade", "Radiance", "Reaver", "Recipe: Aghanim's Scepter", "Recipe: Arcane Boots", "Recipe: Armlet", "Recipe: Assault Cuirass", "Recipe: Battle Fury", "Recipe: Black King Bar", "Recipe: Blade Mail", "Recipe: Bloodstone", "Recipe: Boots of Travel", "Recipe: Bracer", "Recipe: Buckler", "Recipe: Butterfly", "Recipe: Crystalys", "Recipe: Daedalus", "Recipe: Dagon 1", "Recipe: Dagon 2", "Recipe: Dagon 3", "Recipe: Dagon 4", "Recipe: Dagon 5", "Recipe: Desolator", "Recipe: Diffusal Blade 1", "Recipe: Diffusal Blade 2", "Recipe: Divine Rapier", "Recipe: Drum of Endurance", "Recipe: Ethereal Blade", "Recipe: Eul's Scepter of Divinity", "Recipe: Eye of Skadi", "Recipe: Force Staff", "Recipe: Hand of Midas", "Recipe: Headdress", "Recipe: Heart of Tarrasque", "Recipe: Helm of the Dominator", "Recipe: Hood of Defiance", "Recipe: Linken's Sphere", "Recipe: Maelstrom", "Recipe: Magic Wand", "Recipe: Manta Style", "Recipe: Mask of Madness", "Recipe: Medallion of Courage", "Recipe: Mekansm", "Recipe: Mjollnir", "Recipe: Monkey King Bar", "Recipe: Necronomicon 1", "Recipe: Necronomicon 2", "Recipe: Necronomicon 3", "Recipe: Null Talisman", "Recipe: Oblivion Staff", "Recipe: Orchid Malevolence", "Recipe: Perseverance", "Recipe: Phase Boots", "Recipe: Pipe of Insight", "Recipe: Poor Man's Shield", "Recipe: Power Treads", "Recipe: Radiance", "Recipe: Refresher Orb", "Recipe: Ring of Basilius", "Recipe: Sange", "Recipe: Sange and Yasha", "Recipe: Satanic", "Recipe: Scythe of Vyse", "Recipe: Shadow Blade", "Recipe: Shiva's Guard", "Recipe: Skull Basher", "Recipe: Soul Booster", "Recipe: Soul Ring", "Recipe: Urn of Shadows", "Recipe: Vanguard", "Recipe: Veil of Discord", "Recipe: Vladmir's Offering", "Recipe: Wraith Band", "Recipe: Yasha", "Refresher Orb", "Ring of Basilius", "Ring of Health", "Ring of Protection", "Ring of Regen", "Robe of the Magi", "Sacred Relic", "Sage's Mask", "Sange", "Sange and Yasha", "Satanic", "Sentry Ward", "Shadow Blade", "Sheepstick", "Shiva's Guard", "Skull Basher", "Slippers of Agility", "Smoke of Deceit", "Soul Booster", "Soul Ring", "Staff of Wizardry", "Stout Shield", "Talisman of Evasion", "Tango", "Town Portal Scroll", "Ultimate Orb", "Urn of Shadows", "Vanguard", "Veil of Discord", "Vitality Booster", "Vladmir's Offering", "Void Stone", "Wraith Band", "Yasha"})
        Me.ComboBox8.Location = New System.Drawing.Point(273, 220)
        Me.ComboBox8.Name = "ComboBox8"
        Me.ComboBox8.Size = New System.Drawing.Size(210, 21)
        Me.ComboBox8.TabIndex = 100
        '
        'ComboBox9
        '
        Me.ComboBox9.FormattingEnabled = True
        Me.ComboBox9.Items.AddRange(New Object() {"none", "Aghanim's Scepter", "Animal Courier", "Arcane Boots", "Armlet", "Assault Cuirass", "Battle Fury", "Belt of Strength", "Black King Bar", "Blade Mail", "Blade of Alacrity", "Blades of Attack", "Blink Dagger", "Bloodstone", "Boots of Elvenskin", "Boots of Speed", "Boots of Travel", "Bottle", "Bracer", "Broadsword", "Buckler", "Butterfly", "Chainmail", "Circlet", "Clarity", "Claymore", "Cloak", "Crystalys", "Daedalus", "Dagon 1", "Dagon 2", "Dagon 3", "Dagon 4", "Dagon 5", "Demon Edge", "Desolator", "Diffusal Blade 1", "Diffusal Blade 2", "Divine Rapier", "Drum of Endurance", "Dust of Appearance", "Eaglesong", "Energy Booster", "Ethereal Blade", "Eul's Scepter of Divinity", "Eye of Skadi", "Flying Courier", "Force Staff", "Gauntlets of Strength", "Gem of True Sight", "Ghost Scepter", "Gloves of Haste", "Hand of Midas", "Headdress", "Healing Salve", "Heart of Tarrasque", "Helm of Iron Will", "Helm of the Dominator", "Hood of Defiance", "Hyperstone", "Iron Branch", "Javelin", "Linken's Sphere", "Maelstrom", "Magic Stick", "Magic Wand", "Manta Style", "Mantle of Intelligence", "Mask of Madness", "Medallion of Courage", "Mekansm", "Mithril Hammer", "Mjollnir", "Monkey King Bar", "Morbid Mask", "Mystic Staff", "Necronomicon 1", "Necronomicon 2", "Necronomicon 3", "Null Talisman", "Oblivion Staff", "Observer Ward", "Ogre Club", "Orb of Venom", "Orchid Malevolence", "Perseverance", "Phase Boots", "Pipe of Insight", "Platemail", "Point Booster", "Poor Man's Shield", "Power Treads", "Quarterstaff", "Quelling Blade", "Radiance", "Reaver", "Recipe: Aghanim's Scepter", "Recipe: Arcane Boots", "Recipe: Armlet", "Recipe: Assault Cuirass", "Recipe: Battle Fury", "Recipe: Black King Bar", "Recipe: Blade Mail", "Recipe: Bloodstone", "Recipe: Boots of Travel", "Recipe: Bracer", "Recipe: Buckler", "Recipe: Butterfly", "Recipe: Crystalys", "Recipe: Daedalus", "Recipe: Dagon 1", "Recipe: Dagon 2", "Recipe: Dagon 3", "Recipe: Dagon 4", "Recipe: Dagon 5", "Recipe: Desolator", "Recipe: Diffusal Blade 1", "Recipe: Diffusal Blade 2", "Recipe: Divine Rapier", "Recipe: Drum of Endurance", "Recipe: Ethereal Blade", "Recipe: Eul's Scepter of Divinity", "Recipe: Eye of Skadi", "Recipe: Force Staff", "Recipe: Hand of Midas", "Recipe: Headdress", "Recipe: Heart of Tarrasque", "Recipe: Helm of the Dominator", "Recipe: Hood of Defiance", "Recipe: Linken's Sphere", "Recipe: Maelstrom", "Recipe: Magic Wand", "Recipe: Manta Style", "Recipe: Mask of Madness", "Recipe: Medallion of Courage", "Recipe: Mekansm", "Recipe: Mjollnir", "Recipe: Monkey King Bar", "Recipe: Necronomicon 1", "Recipe: Necronomicon 2", "Recipe: Necronomicon 3", "Recipe: Null Talisman", "Recipe: Oblivion Staff", "Recipe: Orchid Malevolence", "Recipe: Perseverance", "Recipe: Phase Boots", "Recipe: Pipe of Insight", "Recipe: Poor Man's Shield", "Recipe: Power Treads", "Recipe: Radiance", "Recipe: Refresher Orb", "Recipe: Ring of Basilius", "Recipe: Sange", "Recipe: Sange and Yasha", "Recipe: Satanic", "Recipe: Scythe of Vyse", "Recipe: Shadow Blade", "Recipe: Shiva's Guard", "Recipe: Skull Basher", "Recipe: Soul Booster", "Recipe: Soul Ring", "Recipe: Urn of Shadows", "Recipe: Vanguard", "Recipe: Veil of Discord", "Recipe: Vladmir's Offering", "Recipe: Wraith Band", "Recipe: Yasha", "Refresher Orb", "Ring of Basilius", "Ring of Health", "Ring of Protection", "Ring of Regen", "Robe of the Magi", "Sacred Relic", "Sage's Mask", "Sange", "Sange and Yasha", "Satanic", "Sentry Ward", "Shadow Blade", "Sheepstick", "Shiva's Guard", "Skull Basher", "Slippers of Agility", "Smoke of Deceit", "Soul Booster", "Soul Ring", "Staff of Wizardry", "Stout Shield", "Talisman of Evasion", "Tango", "Town Portal Scroll", "Ultimate Orb", "Urn of Shadows", "Vanguard", "Veil of Discord", "Vitality Booster", "Vladmir's Offering", "Void Stone", "Wraith Band", "Yasha"})
        Me.ComboBox9.Location = New System.Drawing.Point(273, 247)
        Me.ComboBox9.Name = "ComboBox9"
        Me.ComboBox9.Size = New System.Drawing.Size(210, 21)
        Me.ComboBox9.TabIndex = 101
        '
        'ComboBox10
        '
        Me.ComboBox10.FormattingEnabled = True
        Me.ComboBox10.Items.AddRange(New Object() {"none", "Aghanim's Scepter", "Animal Courier", "Arcane Boots", "Armlet", "Assault Cuirass", "Battle Fury", "Belt of Strength", "Black King Bar", "Blade Mail", "Blade of Alacrity", "Blades of Attack", "Blink Dagger", "Bloodstone", "Boots of Elvenskin", "Boots of Speed", "Boots of Travel", "Bottle", "Bracer", "Broadsword", "Buckler", "Butterfly", "Chainmail", "Circlet", "Clarity", "Claymore", "Cloak", "Crystalys", "Daedalus", "Dagon 1", "Dagon 2", "Dagon 3", "Dagon 4", "Dagon 5", "Demon Edge", "Desolator", "Diffusal Blade 1", "Diffusal Blade 2", "Divine Rapier", "Drum of Endurance", "Dust of Appearance", "Eaglesong", "Energy Booster", "Ethereal Blade", "Eul's Scepter of Divinity", "Eye of Skadi", "Flying Courier", "Force Staff", "Gauntlets of Strength", "Gem of True Sight", "Ghost Scepter", "Gloves of Haste", "Hand of Midas", "Headdress", "Healing Salve", "Heart of Tarrasque", "Helm of Iron Will", "Helm of the Dominator", "Hood of Defiance", "Hyperstone", "Iron Branch", "Javelin", "Linken's Sphere", "Maelstrom", "Magic Stick", "Magic Wand", "Manta Style", "Mantle of Intelligence", "Mask of Madness", "Medallion of Courage", "Mekansm", "Mithril Hammer", "Mjollnir", "Monkey King Bar", "Morbid Mask", "Mystic Staff", "Necronomicon 1", "Necronomicon 2", "Necronomicon 3", "Null Talisman", "Oblivion Staff", "Observer Ward", "Ogre Club", "Orb of Venom", "Orchid Malevolence", "Perseverance", "Phase Boots", "Pipe of Insight", "Platemail", "Point Booster", "Poor Man's Shield", "Power Treads", "Quarterstaff", "Quelling Blade", "Radiance", "Reaver", "Recipe: Aghanim's Scepter", "Recipe: Arcane Boots", "Recipe: Armlet", "Recipe: Assault Cuirass", "Recipe: Battle Fury", "Recipe: Black King Bar", "Recipe: Blade Mail", "Recipe: Bloodstone", "Recipe: Boots of Travel", "Recipe: Bracer", "Recipe: Buckler", "Recipe: Butterfly", "Recipe: Crystalys", "Recipe: Daedalus", "Recipe: Dagon 1", "Recipe: Dagon 2", "Recipe: Dagon 3", "Recipe: Dagon 4", "Recipe: Dagon 5", "Recipe: Desolator", "Recipe: Diffusal Blade 1", "Recipe: Diffusal Blade 2", "Recipe: Divine Rapier", "Recipe: Drum of Endurance", "Recipe: Ethereal Blade", "Recipe: Eul's Scepter of Divinity", "Recipe: Eye of Skadi", "Recipe: Force Staff", "Recipe: Hand of Midas", "Recipe: Headdress", "Recipe: Heart of Tarrasque", "Recipe: Helm of the Dominator", "Recipe: Hood of Defiance", "Recipe: Linken's Sphere", "Recipe: Maelstrom", "Recipe: Magic Wand", "Recipe: Manta Style", "Recipe: Mask of Madness", "Recipe: Medallion of Courage", "Recipe: Mekansm", "Recipe: Mjollnir", "Recipe: Monkey King Bar", "Recipe: Necronomicon 1", "Recipe: Necronomicon 2", "Recipe: Necronomicon 3", "Recipe: Null Talisman", "Recipe: Oblivion Staff", "Recipe: Orchid Malevolence", "Recipe: Perseverance", "Recipe: Phase Boots", "Recipe: Pipe of Insight", "Recipe: Poor Man's Shield", "Recipe: Power Treads", "Recipe: Radiance", "Recipe: Refresher Orb", "Recipe: Ring of Basilius", "Recipe: Sange", "Recipe: Sange and Yasha", "Recipe: Satanic", "Recipe: Scythe of Vyse", "Recipe: Shadow Blade", "Recipe: Shiva's Guard", "Recipe: Skull Basher", "Recipe: Soul Booster", "Recipe: Soul Ring", "Recipe: Urn of Shadows", "Recipe: Vanguard", "Recipe: Veil of Discord", "Recipe: Vladmir's Offering", "Recipe: Wraith Band", "Recipe: Yasha", "Refresher Orb", "Ring of Basilius", "Ring of Health", "Ring of Protection", "Ring of Regen", "Robe of the Magi", "Sacred Relic", "Sage's Mask", "Sange", "Sange and Yasha", "Satanic", "Sentry Ward", "Shadow Blade", "Sheepstick", "Shiva's Guard", "Skull Basher", "Slippers of Agility", "Smoke of Deceit", "Soul Booster", "Soul Ring", "Staff of Wizardry", "Stout Shield", "Talisman of Evasion", "Tango", "Town Portal Scroll", "Ultimate Orb", "Urn of Shadows", "Vanguard", "Veil of Discord", "Vitality Booster", "Vladmir's Offering", "Void Stone", "Wraith Band", "Yasha"})
        Me.ComboBox10.Location = New System.Drawing.Point(273, 274)
        Me.ComboBox10.Name = "ComboBox10"
        Me.ComboBox10.Size = New System.Drawing.Size(210, 21)
        Me.ComboBox10.TabIndex = 102
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1129, 596)
        Me.Controls.Add(Me.ComboBox10)
        Me.Controls.Add(Me.ComboBox9)
        Me.Controls.Add(Me.ComboBox8)
        Me.Controls.Add(Me.ComboBox7)
        Me.Controls.Add(Me.ComboBox6)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBox30)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label0)
        Me.Controls.Add(Me.ListBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DotA 2 Recommended Items Customizer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label0 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox30 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox6 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox7 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox8 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox9 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox10 As System.Windows.Forms.ComboBox
End Class
