<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ListView5 = New System.Windows.Forms.ListView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ListView4 = New System.Windows.Forms.ListView()
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBoxItemsearch = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ButtonDefaultItembuild = New System.Windows.Forms.Button()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label0 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ButtonOpenFolder = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ButtonOpenTextfile = New System.Windows.Forms.Button()
        Me.ButtonImport = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.ButtonSaveTextfile = New System.Windows.Forms.Button()
        Me.ButtonCopy = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBoxClient = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ButtonOpenBackupFolder = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButtonChangeSteam = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ButtonBackup = New System.Windows.Forms.Button()
        Me.ButtonDeleteBackup = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.LabelWait = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(2, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(906, 708)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AllowDrop = True
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.ListView5)
        Me.TabPage1.Controls.Add(Me.ListView4)
        Me.TabPage1.Controls.Add(Me.ListView3)
        Me.TabPage1.Controls.Add(Me.ListView2)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.ComboBox2)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.ComboBox1)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.TextBoxItemsearch)
        Me.TabPage1.Controls.Add(Me.ListView1)
        Me.TabPage1.Controls.Add(Me.ButtonDefaultItembuild)
        Me.TabPage1.Controls.Add(Me.CheckBox2)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.ComboBox3)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label0)
        Me.TabPage1.Controls.Add(Me.ListBox1)
        Me.TabPage1.Controls.Add(Me.ButtonOpenFolder)
        Me.TabPage1.Controls.Add(Me.ButtonSave)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(898, 682)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Change Itembuild"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ListView5
        '
        Me.ListView5.LargeImageList = Me.ImageList1
        Me.ListView5.Location = New System.Drawing.Point(731, 66)
        Me.ListView5.MultiSelect = False
        Me.ListView5.Name = "ListView5"
        Me.ListView5.ShowGroups = False
        Me.ListView5.ShowItemToolTips = True
        Me.ListView5.Size = New System.Drawing.Size(160, 110)
        Me.ListView5.SmallImageList = Me.ImageList1
        Me.ListView5.TabIndex = 555
        Me.ListView5.TileSize = New System.Drawing.Size(44, 34)
        Me.ListView5.UseCompatibleStateImageBehavior = False
        Me.ListView5.View = System.Windows.Forms.View.Tile
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "40px-Abyssal_Blade.png")
        Me.ImageList1.Images.SetKeyName(1, "40px-Aghanim's_Scepter.png")
        Me.ImageList1.Images.SetKeyName(2, "40px-Animal_Courier_(Radiant).png")
        Me.ImageList1.Images.SetKeyName(3, "40px-Arcane_Boots.png")
        Me.ImageList1.Images.SetKeyName(4, "40px-Armlet_of_Mordiggian.png")
        Me.ImageList1.Images.SetKeyName(5, "40px-Assault_Cuirass.png")
        Me.ImageList1.Images.SetKeyName(6, "40px-Battle_Fury.png")
        Me.ImageList1.Images.SetKeyName(7, "40px-Belt_of_Strength.png")
        Me.ImageList1.Images.SetKeyName(8, "40px-Black_King_Bar.png")
        Me.ImageList1.Images.SetKeyName(9, "40px-Blade_Mail.png")
        Me.ImageList1.Images.SetKeyName(10, "40px-Blade_of_Alacrity.png")
        Me.ImageList1.Images.SetKeyName(11, "40px-Blades_of_Attack.png")
        Me.ImageList1.Images.SetKeyName(12, "40px-Blink_Dagger.png")
        Me.ImageList1.Images.SetKeyName(13, "40px-Bloodstone.png")
        Me.ImageList1.Images.SetKeyName(14, "40px-Band_of_Elvenskin.png")
        Me.ImageList1.Images.SetKeyName(15, "40px-Boots_of_Speed.png")
        Me.ImageList1.Images.SetKeyName(16, "40px-Boots_of_Travel.png")
        Me.ImageList1.Images.SetKeyName(17, "40px-Bottle.png")
        Me.ImageList1.Images.SetKeyName(18, "40px-Bracer.png")
        Me.ImageList1.Images.SetKeyName(19, "40px-Broadsword.png")
        Me.ImageList1.Images.SetKeyName(20, "40px-Buckler.png")
        Me.ImageList1.Images.SetKeyName(21, "40px-Butterfly.png")
        Me.ImageList1.Images.SetKeyName(22, "40px-Chainmail.png")
        Me.ImageList1.Images.SetKeyName(23, "40px-Circlet.png")
        Me.ImageList1.Images.SetKeyName(24, "40px-Clarity.png")
        Me.ImageList1.Images.SetKeyName(25, "40px-Claymore.png")
        Me.ImageList1.Images.SetKeyName(26, "40px-Cloak.png")
        Me.ImageList1.Images.SetKeyName(27, "40px-Crystalys.png")
        Me.ImageList1.Images.SetKeyName(28, "40px-Daedalus.png")
        Me.ImageList1.Images.SetKeyName(29, "40px-Dagon.png")
        Me.ImageList1.Images.SetKeyName(30, "40px-Dagon2.png")
        Me.ImageList1.Images.SetKeyName(31, "40px-Dagon3.png")
        Me.ImageList1.Images.SetKeyName(32, "40px-Dagon4.png")
        Me.ImageList1.Images.SetKeyName(33, "40px-Dagon5.png")
        Me.ImageList1.Images.SetKeyName(34, "40px-Demon_Edge.png")
        Me.ImageList1.Images.SetKeyName(35, "40px-Desolator.png")
        Me.ImageList1.Images.SetKeyName(36, "40px-Diffusal_Blade.png")
        Me.ImageList1.Images.SetKeyName(37, "40px-Diffusal_Blade2.png")
        Me.ImageList1.Images.SetKeyName(38, "40px-Divine_Rapier.png")
        Me.ImageList1.Images.SetKeyName(39, "40px-Drum_of_Endurance.png")
        Me.ImageList1.Images.SetKeyName(40, "40px-Dust_of_Appearance.png")
        Me.ImageList1.Images.SetKeyName(41, "40px-Eaglesong.png")
        Me.ImageList1.Images.SetKeyName(42, "40px-Energy_Booster.png")
        Me.ImageList1.Images.SetKeyName(43, "40px-Ethereal_Blade.png")
        Me.ImageList1.Images.SetKeyName(44, "40px-Eul's_Scepter_of_Divinity.png")
        Me.ImageList1.Images.SetKeyName(45, "40px-Eye_of_Skadi.png")
        Me.ImageList1.Images.SetKeyName(46, "40px-Flying_Courier_(Radiant).png")
        Me.ImageList1.Images.SetKeyName(47, "40px-Force_Staff.png")
        Me.ImageList1.Images.SetKeyName(48, "40px-Gauntlets_of_Strength.png")
        Me.ImageList1.Images.SetKeyName(49, "40px-Gem_of_True_Sight.png")
        Me.ImageList1.Images.SetKeyName(50, "40px-Ghost_Scepter.png")
        Me.ImageList1.Images.SetKeyName(51, "40px-Gloves_of_Haste.png")
        Me.ImageList1.Images.SetKeyName(52, "40px-Hand_of_Midas.png")
        Me.ImageList1.Images.SetKeyName(53, "40px-Headdress.png")
        Me.ImageList1.Images.SetKeyName(54, "40px-Healing_Salve.png")
        Me.ImageList1.Images.SetKeyName(55, "40px-Heart_of_Tarrasque.png")
        Me.ImageList1.Images.SetKeyName(56, "40px-Heaven's_Halberd.png")
        Me.ImageList1.Images.SetKeyName(57, "40px-Helm_of_Iron_Will.png")
        Me.ImageList1.Images.SetKeyName(58, "40px-Helm_of_the_Dominator.png")
        Me.ImageList1.Images.SetKeyName(59, "40px-Hood_of_Defiance.png")
        Me.ImageList1.Images.SetKeyName(60, "40px-Hyperstone.png")
        Me.ImageList1.Images.SetKeyName(61, "40px-Iron_Branch.png")
        Me.ImageList1.Images.SetKeyName(62, "40px-Javelin.png")
        Me.ImageList1.Images.SetKeyName(63, "40px-Linken's_Sphere.png")
        Me.ImageList1.Images.SetKeyName(64, "40px-Maelstrom.png")
        Me.ImageList1.Images.SetKeyName(65, "40px-Magic_Stick.png")
        Me.ImageList1.Images.SetKeyName(66, "40px-Magic_Wand.png")
        Me.ImageList1.Images.SetKeyName(67, "40px-Manta_Style.png")
        Me.ImageList1.Images.SetKeyName(68, "40px-Mantle_of_Intelligence.png")
        Me.ImageList1.Images.SetKeyName(69, "40px-Mask_of_Madness.png")
        Me.ImageList1.Images.SetKeyName(70, "40px-Medallion_of_Courage.png")
        Me.ImageList1.Images.SetKeyName(71, "40px-Mekansm.png")
        Me.ImageList1.Images.SetKeyName(72, "40px-Mithril_Hammer.png")
        Me.ImageList1.Images.SetKeyName(73, "40px-Mjollnir.png")
        Me.ImageList1.Images.SetKeyName(74, "40px-Monkey_King_Bar.png")
        Me.ImageList1.Images.SetKeyName(75, "40px-Morbid_Mask.png")
        Me.ImageList1.Images.SetKeyName(76, "40px-Mystic_Staff.png")
        Me.ImageList1.Images.SetKeyName(77, "40px-Necronomicon.png")
        Me.ImageList1.Images.SetKeyName(78, "40px-Necronomicon2.png")
        Me.ImageList1.Images.SetKeyName(79, "40px-Necronomicon3.png")
        Me.ImageList1.Images.SetKeyName(80, "40px-Null_Talisman.png")
        Me.ImageList1.Images.SetKeyName(81, "40px-Oblivion_Staff.png")
        Me.ImageList1.Images.SetKeyName(82, "40px-Observer_Ward.png")
        Me.ImageList1.Images.SetKeyName(83, "40px-Ogre_Club.png")
        Me.ImageList1.Images.SetKeyName(84, "40px-Orb_of_Venom.png")
        Me.ImageList1.Images.SetKeyName(85, "40px-Orchid_Malevolence.png")
        Me.ImageList1.Images.SetKeyName(86, "40px-Perseverance.png")
        Me.ImageList1.Images.SetKeyName(87, "40px-Phase_Boots.png")
        Me.ImageList1.Images.SetKeyName(88, "40px-Pipe_of_Insight.png")
        Me.ImageList1.Images.SetKeyName(89, "40px-Platemail.png")
        Me.ImageList1.Images.SetKeyName(90, "40px-Point_Booster.png")
        Me.ImageList1.Images.SetKeyName(91, "40px-Poor_Man's_Shield.png")
        Me.ImageList1.Images.SetKeyName(92, "40px-Power_Treads.png")
        Me.ImageList1.Images.SetKeyName(93, "40px-Quarterstaff.png")
        Me.ImageList1.Images.SetKeyName(94, "40px-Quelling_Blade.png")
        Me.ImageList1.Images.SetKeyName(95, "40px-Radiance.png")
        Me.ImageList1.Images.SetKeyName(96, "40px-Reaver.png")
        Me.ImageList1.Images.SetKeyName(97, "40px-Refresher_Orb.png")
        Me.ImageList1.Images.SetKeyName(98, "40px-Ring_of_Aquila.png")
        Me.ImageList1.Images.SetKeyName(99, "40px-Ring_of_Basilius.png")
        Me.ImageList1.Images.SetKeyName(100, "40px-Ring_of_Health.png")
        Me.ImageList1.Images.SetKeyName(101, "40px-Ring_of_Protection.png")
        Me.ImageList1.Images.SetKeyName(102, "40px-Ring_of_Regen.png")
        Me.ImageList1.Images.SetKeyName(103, "40px-Robe_of_the_Magi.png")
        Me.ImageList1.Images.SetKeyName(104, "40px-Rod_of_Atos.png")
        Me.ImageList1.Images.SetKeyName(105, "40px-Sacred_Relic.png")
        Me.ImageList1.Images.SetKeyName(106, "40px-Sage's_Mask.png")
        Me.ImageList1.Images.SetKeyName(107, "40px-Sange.png")
        Me.ImageList1.Images.SetKeyName(108, "40px-Sange_and_Yasha.png")
        Me.ImageList1.Images.SetKeyName(109, "40px-Satanic.png")
        Me.ImageList1.Images.SetKeyName(110, "40px-Scythe_of_Vyse.png")
        Me.ImageList1.Images.SetKeyName(111, "40px-Sentry_Ward.png")
        Me.ImageList1.Images.SetKeyName(112, "40px-Shadow_Blade.png")
        Me.ImageList1.Images.SetKeyName(113, "40px-Shiva's_Guard.png")
        Me.ImageList1.Images.SetKeyName(114, "40px-Skull_Basher.png")
        Me.ImageList1.Images.SetKeyName(115, "40px-Slippers_of_Agility.png")
        Me.ImageList1.Images.SetKeyName(116, "40px-Smoke_of_Deceit.png")
        Me.ImageList1.Images.SetKeyName(117, "40px-Soul_Booster.png")
        Me.ImageList1.Images.SetKeyName(118, "40px-Soul_Ring.png")
        Me.ImageList1.Images.SetKeyName(119, "40px-Staff_of_Wizardry.png")
        Me.ImageList1.Images.SetKeyName(120, "40px-Stout_Shield.png")
        Me.ImageList1.Images.SetKeyName(121, "40px-Talisman_of_Evasion.png")
        Me.ImageList1.Images.SetKeyName(122, "40px-Tango.png")
        Me.ImageList1.Images.SetKeyName(123, "40px-Town_Portal_Scroll.png")
        Me.ImageList1.Images.SetKeyName(124, "40px-Tranquil_Boots.png")
        Me.ImageList1.Images.SetKeyName(125, "40px-Ultimate_Orb.png")
        Me.ImageList1.Images.SetKeyName(126, "40px-Urn_of_Shadows.png")
        Me.ImageList1.Images.SetKeyName(127, "40px-Vanguard.png")
        Me.ImageList1.Images.SetKeyName(128, "40px-Veil_of_Discord.png")
        Me.ImageList1.Images.SetKeyName(129, "40px-Vitality_Booster.png")
        Me.ImageList1.Images.SetKeyName(130, "40px-Vladmir's_Offering.png")
        Me.ImageList1.Images.SetKeyName(131, "40px-Void_Stone.png")
        Me.ImageList1.Images.SetKeyName(132, "40px-Wraith_Band.png")
        Me.ImageList1.Images.SetKeyName(133, "40px-Yasha.png")
        Me.ImageList1.Images.SetKeyName(134, "Recipe_Scroll.png")
        '
        'ListView4
        '
        Me.ListView4.LargeImageList = Me.ImageList1
        Me.ListView4.Location = New System.Drawing.Point(549, 66)
        Me.ListView4.MultiSelect = False
        Me.ListView4.Name = "ListView4"
        Me.ListView4.ShowGroups = False
        Me.ListView4.ShowItemToolTips = True
        Me.ListView4.Size = New System.Drawing.Size(160, 110)
        Me.ListView4.SmallImageList = Me.ImageList1
        Me.ListView4.TabIndex = 554
        Me.ListView4.TileSize = New System.Drawing.Size(44, 34)
        Me.ListView4.UseCompatibleStateImageBehavior = False
        Me.ListView4.View = System.Windows.Forms.View.Tile
        '
        'ListView3
        '
        Me.ListView3.LargeImageList = Me.ImageList1
        Me.ListView3.Location = New System.Drawing.Point(365, 66)
        Me.ListView3.MultiSelect = False
        Me.ListView3.Name = "ListView3"
        Me.ListView3.ShowGroups = False
        Me.ListView3.ShowItemToolTips = True
        Me.ListView3.Size = New System.Drawing.Size(160, 110)
        Me.ListView3.SmallImageList = Me.ImageList1
        Me.ListView3.TabIndex = 553
        Me.ListView3.TileSize = New System.Drawing.Size(44, 34)
        Me.ListView3.UseCompatibleStateImageBehavior = False
        Me.ListView3.View = System.Windows.Forms.View.Tile
        '
        'ListView2
        '
        Me.ListView2.LargeImageList = Me.ImageList1
        Me.ListView2.Location = New System.Drawing.Point(181, 66)
        Me.ListView2.MultiSelect = False
        Me.ListView2.Name = "ListView2"
        Me.ListView2.ShowGroups = False
        Me.ListView2.ShowItemToolTips = True
        Me.ListView2.Size = New System.Drawing.Size(160, 110)
        Me.ListView2.SmallImageList = Me.ImageList1
        Me.ListView2.TabIndex = 552
        Me.ListView2.TileSize = New System.Drawing.Size(44, 34)
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Tile
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(546, 231)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(54, 13)
        Me.Label22.TabIndex = 551
        Me.Label22.Text = "Shopfilter:"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"All", "Arcane", "Armaments", "Armor", "Artifacts", "Attributes", "Caster", "Common", "Consumables", "Secret Shop", "Side Lane Shop", "Support", "Weapons"})
        Me.ComboBox2.Location = New System.Drawing.Point(606, 228)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 550
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(227, 52)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(14, 13)
        Me.Label15.TabIndex = 543
        Me.Label15.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(190, 52)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 13)
        Me.Label14.TabIndex = 542
        Me.Label14.Text = "Cost:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(362, 231)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 13)
        Me.Label13.TabIndex = 541
        Me.Label13.Text = "Itemfilter:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"", "Agility", "All Attributes", "Armor", "Attack Speed", "Aura", "Damage", "Evasion", "HP", "HP/sec Regeneration", "Intelligence", "Lifesteal", "Magic Resistance", "Mana", "Mana Regeneration", "Movement Speed", "Recipe", "Strength"})
        Me.ComboBox1.Location = New System.Drawing.Point(417, 228)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 540
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(178, 231)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 539
        Me.Label11.Text = "Itemsearch:"
        '
        'TextBoxItemsearch
        '
        Me.TextBoxItemsearch.Location = New System.Drawing.Point(246, 228)
        Me.TextBoxItemsearch.Name = "TextBoxItemsearch"
        Me.TextBoxItemsearch.Size = New System.Drawing.Size(101, 20)
        Me.TextBoxItemsearch.TabIndex = 538
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(158, 255)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.ShowGroups = False
        Me.ListView1.ShowItemToolTips = True
        Me.ListView1.Size = New System.Drawing.Size(733, 392)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListView1.TabIndex = 537
        Me.ListView1.TileSize = New System.Drawing.Size(175, 34)
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Tile
        '
        'ButtonDefaultItembuild
        '
        Me.ButtonDefaultItembuild.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonDefaultItembuild.Location = New System.Drawing.Point(444, 653)
        Me.ButtonDefaultItembuild.Name = "ButtonDefaultItembuild"
        Me.ButtonDefaultItembuild.Size = New System.Drawing.Size(95, 23)
        Me.ButtonDefaultItembuild.TabIndex = 536
        Me.ButtonDefaultItembuild.Text = "Default Itembuild"
        Me.ButtonDefaultItembuild.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(71, 2)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(137, 17)
        Me.CheckBox2.TabIndex = 535
        Me.CheckBox2.Text = "Show only implemented"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(178, 179)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(254, 13)
        Me.Label24.TabIndex = 534
        Me.Label24.Text = "You can delete items with right clicking at the image."
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"All", "Strength", "Agility", "Intelligence", "Carry", "Support", "Ganker", "Initiator", "Pusher", "Jungler", "Tank"})
        Me.ComboBox3.Location = New System.Drawing.Point(72, 22)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(80, 21)
        Me.ComboBox3.TabIndex = 505
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 504
        Me.Label12.Text = "Sort Heros:"
        '
        'Label0
        '
        Me.Label0.AutoSize = True
        Me.Label0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label0.Location = New System.Drawing.Point(6, 3)
        Me.Label0.Name = "Label0"
        Me.Label0.Size = New System.Drawing.Size(47, 13)
        Me.Label0.TabIndex = 326
        Me.Label0.Text = "Heroes"
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {" "})
        Me.ListBox1.Location = New System.Drawing.Point(5, 50)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(147, 628)
        Me.ListBox1.Sorted = True
        Me.ListBox1.TabIndex = 325
        '
        'ButtonOpenFolder
        '
        Me.ButtonOpenFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonOpenFolder.Location = New System.Drawing.Point(201, 653)
        Me.ButtonOpenFolder.Name = "ButtonOpenFolder"
        Me.ButtonOpenFolder.Size = New System.Drawing.Size(132, 23)
        Me.ButtonOpenFolder.TabIndex = 327
        Me.ButtonOpenFolder.Text = "Open Itembuilds Folder"
        Me.ButtonOpenFolder.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonSave.Location = New System.Drawing.Point(615, 653)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(59, 23)
        Me.ButtonSave.TabIndex = 328
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(178, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 330
        Me.Label2.Text = "Author:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(225, 202)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(122, 20)
        Me.TextBox1.TabIndex = 331
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(453, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 20)
        Me.Label1.TabIndex = 332
        Me.Label1.Text = "No hero selected!"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(204, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 15)
        Me.Label3.TabIndex = 367
        Me.Label3.Text = "Starting Items"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(398, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 15)
        Me.Label4.TabIndex = 368
        Me.Label4.Text = "Early Game"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(581, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 15)
        Me.Label5.TabIndex = 369
        Me.Label5.Text = "Core Items"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(775, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 15)
        Me.Label6.TabIndex = 370
        Me.Label6.Text = "Luxury"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ButtonOpenTextfile)
        Me.TabPage3.Controls.Add(Me.ButtonImport)
        Me.TabPage3.Controls.Add(Me.TextBox2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(898, 682)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Import Itembuild"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ButtonOpenTextfile
        '
        Me.ButtonOpenTextfile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonOpenTextfile.Location = New System.Drawing.Point(451, 653)
        Me.ButtonOpenTextfile.Name = "ButtonOpenTextfile"
        Me.ButtonOpenTextfile.Size = New System.Drawing.Size(106, 23)
        Me.ButtonOpenTextfile.TabIndex = 7
        Me.ButtonOpenTextfile.Text = "Open from textfile"
        Me.ButtonOpenTextfile.UseVisualStyleBackColor = True
        '
        'ButtonImport
        '
        Me.ButtonImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonImport.Location = New System.Drawing.Point(370, 653)
        Me.ButtonImport.Name = "ButtonImport"
        Me.ButtonImport.Size = New System.Drawing.Size(75, 23)
        Me.ButtonImport.TabIndex = 5
        Me.ButtonImport.Text = "Import"
        Me.ButtonImport.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Location = New System.Drawing.Point(6, 3)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox2.Size = New System.Drawing.Size(885, 644)
        Me.TextBox2.TabIndex = 4
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.ButtonSaveTextfile)
        Me.TabPage4.Controls.Add(Me.ButtonCopy)
        Me.TabPage4.Controls.Add(Me.TextBox3)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(898, 682)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Export Itembuild"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'ButtonSaveTextfile
        '
        Me.ButtonSaveTextfile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonSaveTextfile.Location = New System.Drawing.Point(451, 653)
        Me.ButtonSaveTextfile.Name = "ButtonSaveTextfile"
        Me.ButtonSaveTextfile.Size = New System.Drawing.Size(88, 23)
        Me.ButtonSaveTextfile.TabIndex = 7
        Me.ButtonSaveTextfile.Text = "Save as textfile"
        Me.ButtonSaveTextfile.UseVisualStyleBackColor = True
        '
        'ButtonCopy
        '
        Me.ButtonCopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonCopy.Location = New System.Drawing.Point(370, 653)
        Me.ButtonCopy.Name = "ButtonCopy"
        Me.ButtonCopy.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCopy.TabIndex = 5
        Me.ButtonCopy.Text = "Copy"
        Me.ButtonCopy.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.Location = New System.Drawing.Point(3, 3)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox3.Size = New System.Drawing.Size(888, 644)
        Me.TextBox3.TabIndex = 4
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Label10)
        Me.TabPage5.Controls.Add(Me.ComboBoxClient)
        Me.TabPage5.Controls.Add(Me.CheckBox1)
        Me.TabPage5.Controls.Add(Me.ButtonOpenBackupFolder)
        Me.TabPage5.Controls.Add(Me.Label9)
        Me.TabPage5.Controls.Add(Me.Label8)
        Me.TabPage5.Controls.Add(Me.Label7)
        Me.TabPage5.Controls.Add(Me.ButtonChangeSteam)
        Me.TabPage5.Controls.Add(Me.TextBox4)
        Me.TabPage5.Controls.Add(Me.ButtonBackup)
        Me.TabPage5.Controls.Add(Me.ButtonDeleteBackup)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(898, 682)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "D2RIC Options"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(21, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 15)
        Me.Label10.TabIndex = 350
        Me.Label10.Text = "Client"
        '
        'ComboBoxClient
        '
        Me.ComboBoxClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxClient.FormattingEnabled = True
        Me.ComboBoxClient.Items.AddRange(New Object() {"Test Client", "Beta Client"})
        Me.ComboBoxClient.Location = New System.Drawing.Point(19, 99)
        Me.ComboBoxClient.Name = "ComboBoxClient"
        Me.ComboBoxClient.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxClient.TabIndex = 349
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.CheckBox1.Location = New System.Drawing.Point(24, 368)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(213, 19)
        Me.CheckBox1.TabIndex = 346
        Me.CheckBox1.Text = "Check for Updates on Startup"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ButtonOpenBackupFolder
        '
        Me.ButtonOpenBackupFolder.Location = New System.Drawing.Point(24, 303)
        Me.ButtonOpenBackupFolder.Name = "ButtonOpenBackupFolder"
        Me.ButtonOpenBackupFolder.Size = New System.Drawing.Size(116, 23)
        Me.ButtonOpenBackupFolder.TabIndex = 344
        Me.ButtonOpenBackupFolder.Text = "Open Backup Folder"
        Me.ButtonOpenBackupFolder.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(21, 246)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 15)
        Me.Label9.TabIndex = 343
        Me.Label9.Text = "Backup"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 154)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 15)
        Me.Label8.TabIndex = 342
        Me.Label8.Text = "Steampath"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(395, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 24)
        Me.Label7.TabIndex = 341
        Me.Label7.Text = "Options"
        '
        'ButtonChangeSteam
        '
        Me.ButtonChangeSteam.Location = New System.Drawing.Point(378, 181)
        Me.ButtonChangeSteam.Name = "ButtonChangeSteam"
        Me.ButtonChangeSteam.Size = New System.Drawing.Size(75, 23)
        Me.ButtonChangeSteam.TabIndex = 340
        Me.ButtonChangeSteam.Text = "Search"
        Me.ButtonChangeSteam.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(24, 183)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(348, 20)
        Me.TextBox4.TabIndex = 339
        '
        'ButtonBackup
        '
        Me.ButtonBackup.Location = New System.Drawing.Point(24, 274)
        Me.ButtonBackup.Name = "ButtonBackup"
        Me.ButtonBackup.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBackup.TabIndex = 337
        Me.ButtonBackup.Text = "Backup"
        Me.ButtonBackup.UseVisualStyleBackColor = True
        '
        'ButtonDeleteBackup
        '
        Me.ButtonDeleteBackup.Location = New System.Drawing.Point(105, 274)
        Me.ButtonDeleteBackup.Name = "ButtonDeleteBackup"
        Me.ButtonDeleteBackup.Size = New System.Drawing.Size(111, 23)
        Me.ButtonDeleteBackup.TabIndex = 338
        Me.ButtonDeleteBackup.Text = "Delete backups"
        Me.ButtonDeleteBackup.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonUpdate.Location = New System.Drawing.Point(795, 4)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(109, 23)
        Me.ButtonUpdate.TabIndex = 1
        Me.ButtonUpdate.Text = "Check for Updates"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'LabelWait
        '
        Me.LabelWait.AutoSize = True
        Me.LabelWait.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWait.ForeColor = System.Drawing.Color.Red
        Me.LabelWait.Location = New System.Drawing.Point(458, 1)
        Me.LabelWait.Name = "LabelWait"
        Me.LabelWait.Size = New System.Drawing.Size(269, 26)
        Me.LabelWait.TabIndex = 2
        Me.LabelWait.Text = "Checking for Updates ..."
        Me.LabelWait.Visible = False
        '
        'BackgroundWorker1
        '
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Timer2
        '
        Me.Timer2.Interval = 50
        '
        'Timer3
        '
        Me.Timer3.Interval = 50
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(816, 226)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 556
        Me.Button1.Text = "Reset filter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(909, 722)
        Me.Controls.Add(Me.LabelWait)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(925, 500)
        Me.Name = "FormMain"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DotA 2 Recommended Items Customizer"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Label0 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ButtonOpenFolder As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ButtonOpenTextfile As System.Windows.Forms.Button
    Friend WithEvents ButtonImport As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSaveTextfile As System.Windows.Forms.Button
    Friend WithEvents ButtonCopy As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents ButtonBackup As System.Windows.Forms.Button
    Friend WithEvents ButtonDeleteBackup As System.Windows.Forms.Button
    Friend WithEvents ButtonChangeSteam As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ButtonOpenBackupFolder As System.Windows.Forms.Button
    Friend WithEvents ButtonUpdate As System.Windows.Forms.Button
    Friend WithEvents LabelWait As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonDefaultItembuild As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxClient As System.Windows.Forms.ComboBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents TextBoxItemsearch As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ListView3 As System.Windows.Forms.ListView
    Friend WithEvents ListView5 As System.Windows.Forms.ListView
    Friend WithEvents ListView4 As System.Windows.Forms.ListView
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
