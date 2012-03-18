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
        End With

        'PRESELECT THE BOX
        FormMain.ComboBox3.SelectedItem = "All"

        FormMain.CheckBox2.Checked = True
        ClearNotImplemented()
    End Sub

    Public Sub InitializeListbox()
        'Listview füllen
        With FormMain.ListView1
            .Clear()
            .Items.Add("Abyssal Blade", 0)
            .Items.Add("Aghanim's Scepter", 1)
            .Items.Add("Animal Courier", 2)
            .Items.Add("Arcane Boots", 3)
            .Items.Add("Armlet", 4)
            .Items.Add("Assault Cuirass", 5)
            .Items.Add("Battle Fury", 6)
            .Items.Add("Belt of Strength", 7)
            .Items.Add("Black King Bar", 8)
            .Items.Add("Blade Mail", 9)
            .Items.Add("Blade of Alacrity", 10)
            .Items.Add("Blades of Attack", 11)
            .Items.Add("Blink Dagger", 12)
            .Items.Add("Bloodstone", 13)
            .Items.Add("Boots of Elvenskin", 14)
            .Items.Add("Boots of Speed", 15)
            .Items.Add("Boots of Travel", 16)
            .Items.Add("Bottle", 17)
            .Items.Add("Bracer", 18)
            .Items.Add("Broadsword", 19)
            .Items.Add("Buckler", 20)
            .Items.Add("Butterfly", 21)
            .Items.Add("Chainmail", 22)
            .Items.Add("Circlet", 23)
            .Items.Add("Clarity", 24)
            .Items.Add("Claymore", 25)
            .Items.Add("Cloak", 26)
            .Items.Add("Crystalys", 27)
            .Items.Add("Daedalus", 28)
            .Items.Add("Dagon 1", 29)
            .Items.Add("Dagon 2", 30)
            .Items.Add("Dagon 3", 31)
            .Items.Add("Dagon 4", 32)
            .Items.Add("Dagon 5", 33)
            .Items.Add("Demon Edge", 34)
            .Items.Add("Desolator", 35)
            .Items.Add("Diffusal Blade 1", 36)
            .Items.Add("Diffusal Blade 2", 37)
            .Items.Add("Divine Rapier", 38)
            .Items.Add("Drum of Endurance", 39)
            .Items.Add("Dust of Appearance", 40)
            .Items.Add("Eaglesong", 41)
            .Items.Add("Energy Booster", 42)
            .Items.Add("Ethereal Blade", 43)
            .Items.Add("Eul's Scepter of Divinity", 44)
            .Items.Add("Eye of Skadi", 45)
            .Items.Add("Flying Courier", 46)
            .Items.Add("Force Staff", 47)
            .Items.Add("Gauntlets of Strength", 48)
            .Items.Add("Gem of True Sight", 49)
            .Items.Add("Ghost Scepter", 50)
            .Items.Add("Gloves of Haste", 51)
            .Items.Add("Hand of Midas", 52)
            .Items.Add("Headdress", 53)
            .Items.Add("Healing Salve", 54)
            .Items.Add("Heart of Tarrasque", 55)
            .Items.Add("Heaven's Halberd", 56)
            .Items.Add("Helm of Iron Will", 57)
            .Items.Add("Helm of the Dominator", 58)
            .Items.Add("Hood of Defiance", 59)
            .Items.Add("Hyperstone", 60)
            .Items.Add("Iron Branch", 61)
            .Items.Add("Javelin", 62)
            .Items.Add("Linken's Sphere", 63)
            .Items.Add("Maelstrom", 64)
            .Items.Add("Magic Stick", 65)
            .Items.Add("Magic Wand", 66)
            .Items.Add("Manta Style", 67)
            .Items.Add("Mantle of Intelligence", 68)
            .Items.Add("Mask of Madness", 69)
            .Items.Add("Medallion of Courage", 70)
            .Items.Add("Mekansm", 71)
            .Items.Add("Mithril Hammer", 72)
            .Items.Add("Mjollnir", 73)
            .Items.Add("Monkey King Bar", 74)
            .Items.Add("Morbid Mask", 75)
            .Items.Add("Mystic Staff", 76)
            .Items.Add("Necronomicon 1", 77)
            .Items.Add("Necronomicon 2", 78)
            .Items.Add("Necronomicon 3", 79)
            .Items.Add("Null Talisman", 80)
            .Items.Add("Oblivion Staff", 81)
            .Items.Add("Observer Ward", 82)
            .Items.Add("Ogre Club", 83)
            .Items.Add("Orb of Venom", 84)
            .Items.Add("Orchid Malevolence", 85)
            .Items.Add("Perseverance", 86)
            .Items.Add("Phase Boots", 87)
            .Items.Add("Pipe of Insight", 88)
            .Items.Add("Platemail", 89)
            .Items.Add("Point Booster", 90)
            .Items.Add("Poor Man's Shield", 91)
            .Items.Add("Power Treads", 92)
            .Items.Add("Quarterstaff", 93)
            .Items.Add("Quelling Blade", 94)
            .Items.Add("Radiance", 95)
            .Items.Add("Reaver", 96)
            .Items.Add("Refresher Orb", 97)
            .Items.Add("Ring of Aquila", 98)
            .Items.Add("Ring of Basilius", 99)
            .Items.Add("Ring of Health", 100)
            .Items.Add("Ring of Protection", 101)
            .Items.Add("Ring of Regen", 102)
            .Items.Add("Robe of the Magi", 103)
            .Items.Add("Rod of Atos", 104)
            .Items.Add("Sacred Relic", 105)
            .Items.Add("Sage's Mask", 106)
            .Items.Add("Sange", 107)
            .Items.Add("Sange and Yasha", 108)
            .Items.Add("Satanic", 109)
            .Items.Add("Scythe of Vyse", 110)
            .Items.Add("Sentry Ward", 111)
            .Items.Add("Shadow Blade", 112)
            .Items.Add("Shiva's Guard", 113)
            .Items.Add("Skull Basher", 114)
            .Items.Add("Slippers of Agility", 115)
            .Items.Add("Smoke of Deceit", 116)
            .Items.Add("Soul Booster", 117)
            .Items.Add("Soul Ring", 118)
            .Items.Add("Staff of Wizardry", 119)
            .Items.Add("Stout Shield", 120)
            .Items.Add("Talisman of Evasion", 121)
            .Items.Add("Tango", 122)
            .Items.Add("Town Portal Scroll", 123)
            .Items.Add("Tranquil Boots", 124)
            .Items.Add("Ultimate Orb", 125)
            .Items.Add("Urn of Shadows", 126)
            .Items.Add("Vanguard", 127)
            .Items.Add("Veil of Discord", 128)
            .Items.Add("Vitality Booster", 129)
            .Items.Add("Vladmir's Offering", 130)
            .Items.Add("Void Stone", 131)
            .Items.Add("Wraith Band", 132)
            .Items.Add("Yasha", 133)
            'Bilder ändern
            If FormMain.ComboBoxItemIcons.SelectedItem = "DotA 1" Then
                'Change Items Icons to DotA 1
                FormMain.ListView1.Items(0).ImageIndex = 134
                FormMain.ListView1.Items(1).ImageIndex = 135
                FormMain.ListView1.Items(2).ImageIndex = 136
                FormMain.ListView1.Items(3).ImageIndex = 137
                FormMain.ListView1.Items(4).ImageIndex = 138
                FormMain.ListView1.Items(5).ImageIndex = 139
                FormMain.ListView1.Items(6).ImageIndex = 140
                FormMain.ListView1.Items(7).ImageIndex = 141
                FormMain.ListView1.Items(8).ImageIndex = 142
                FormMain.ListView1.Items(9).ImageIndex = 143
                FormMain.ListView1.Items(10).ImageIndex = 144
                FormMain.ListView1.Items(11).ImageIndex = 145
                FormMain.ListView1.Items(12).ImageIndex = 146
                FormMain.ListView1.Items(13).ImageIndex = 147
                FormMain.ListView1.Items(14).ImageIndex = 148
                FormMain.ListView1.Items(15).ImageIndex = 149
                FormMain.ListView1.Items(16).ImageIndex = 150
                FormMain.ListView1.Items(17).ImageIndex = 151
                FormMain.ListView1.Items(18).ImageIndex = 152
                FormMain.ListView1.Items(19).ImageIndex = 153
                FormMain.ListView1.Items(20).ImageIndex = 154
                FormMain.ListView1.Items(21).ImageIndex = 155
                FormMain.ListView1.Items(22).ImageIndex = 156
                FormMain.ListView1.Items(23).ImageIndex = 157
                FormMain.ListView1.Items(24).ImageIndex = 158
                FormMain.ListView1.Items(25).ImageIndex = 159
                FormMain.ListView1.Items(26).ImageIndex = 160
                FormMain.ListView1.Items(27).ImageIndex = 161
                FormMain.ListView1.Items(28).ImageIndex = 162
                FormMain.ListView1.Items(29).ImageIndex = 163
                FormMain.ListView1.Items(30).ImageIndex = 164
                FormMain.ListView1.Items(31).ImageIndex = 165
                FormMain.ListView1.Items(32).ImageIndex = 166
                FormMain.ListView1.Items(33).ImageIndex = 167
                FormMain.ListView1.Items(34).ImageIndex = 168
                FormMain.ListView1.Items(35).ImageIndex = 169
                FormMain.ListView1.Items(36).ImageIndex = 170
                FormMain.ListView1.Items(37).ImageIndex = 171
                FormMain.ListView1.Items(38).ImageIndex = 172
                FormMain.ListView1.Items(39).ImageIndex = 173
                FormMain.ListView1.Items(40).ImageIndex = 174
                FormMain.ListView1.Items(41).ImageIndex = 175
                FormMain.ListView1.Items(42).ImageIndex = 176
                FormMain.ListView1.Items(43).ImageIndex = 177
                FormMain.ListView1.Items(44).ImageIndex = 178
                FormMain.ListView1.Items(45).ImageIndex = 179
                FormMain.ListView1.Items(46).ImageIndex = 180
                FormMain.ListView1.Items(47).ImageIndex = 181
                FormMain.ListView1.Items(48).ImageIndex = 182
                FormMain.ListView1.Items(49).ImageIndex = 183
                FormMain.ListView1.Items(50).ImageIndex = 184
                FormMain.ListView1.Items(51).ImageIndex = 185
                FormMain.ListView1.Items(52).ImageIndex = 186
                FormMain.ListView1.Items(53).ImageIndex = 187
                FormMain.ListView1.Items(54).ImageIndex = 188
                FormMain.ListView1.Items(55).ImageIndex = 189
                FormMain.ListView1.Items(56).ImageIndex = 190
                FormMain.ListView1.Items(57).ImageIndex = 191
                FormMain.ListView1.Items(58).ImageIndex = 192
                FormMain.ListView1.Items(59).ImageIndex = 193
                FormMain.ListView1.Items(60).ImageIndex = 194
                FormMain.ListView1.Items(61).ImageIndex = 195
                FormMain.ListView1.Items(62).ImageIndex = 196
                FormMain.ListView1.Items(63).ImageIndex = 197
                FormMain.ListView1.Items(64).ImageIndex = 198
                FormMain.ListView1.Items(65).ImageIndex = 199
                FormMain.ListView1.Items(66).ImageIndex = 200
                FormMain.ListView1.Items(67).ImageIndex = 201
                FormMain.ListView1.Items(68).ImageIndex = 202
                FormMain.ListView1.Items(69).ImageIndex = 203
                FormMain.ListView1.Items(70).ImageIndex = 204
                FormMain.ListView1.Items(71).ImageIndex = 205
                FormMain.ListView1.Items(72).ImageIndex = 206
                FormMain.ListView1.Items(73).ImageIndex = 207
                FormMain.ListView1.Items(74).ImageIndex = 208
                FormMain.ListView1.Items(75).ImageIndex = 209
                FormMain.ListView1.Items(76).ImageIndex = 210
                FormMain.ListView1.Items(77).ImageIndex = 211
                FormMain.ListView1.Items(78).ImageIndex = 212
                FormMain.ListView1.Items(79).ImageIndex = 213
                FormMain.ListView1.Items(80).ImageIndex = 214
                FormMain.ListView1.Items(81).ImageIndex = 215
                FormMain.ListView1.Items(82).ImageIndex = 216
                FormMain.ListView1.Items(83).ImageIndex = 217
                FormMain.ListView1.Items(84).ImageIndex = 218
                FormMain.ListView1.Items(85).ImageIndex = 219
                FormMain.ListView1.Items(86).ImageIndex = 220
                FormMain.ListView1.Items(87).ImageIndex = 221
                FormMain.ListView1.Items(88).ImageIndex = 222
                FormMain.ListView1.Items(89).ImageIndex = 223
                FormMain.ListView1.Items(90).ImageIndex = 224
                FormMain.ListView1.Items(91).ImageIndex = 225
                FormMain.ListView1.Items(92).ImageIndex = 226
                FormMain.ListView1.Items(93).ImageIndex = 227
                FormMain.ListView1.Items(94).ImageIndex = 228
                FormMain.ListView1.Items(95).ImageIndex = 229
                FormMain.ListView1.Items(96).ImageIndex = 230
                FormMain.ListView1.Items(97).ImageIndex = 231
                FormMain.ListView1.Items(98).ImageIndex = 232
                FormMain.ListView1.Items(99).ImageIndex = 233
                FormMain.ListView1.Items(100).ImageIndex = 234
                FormMain.ListView1.Items(101).ImageIndex = 235
                FormMain.ListView1.Items(102).ImageIndex = 236
                FormMain.ListView1.Items(103).ImageIndex = 237
                FormMain.ListView1.Items(104).ImageIndex = 238
                FormMain.ListView1.Items(105).ImageIndex = 239
                FormMain.ListView1.Items(106).ImageIndex = 240
                FormMain.ListView1.Items(107).ImageIndex = 241
                FormMain.ListView1.Items(108).ImageIndex = 242
                FormMain.ListView1.Items(109).ImageIndex = 243
                FormMain.ListView1.Items(110).ImageIndex = 244
                FormMain.ListView1.Items(111).ImageIndex = 245
                FormMain.ListView1.Items(112).ImageIndex = 246
                FormMain.ListView1.Items(113).ImageIndex = 247
                FormMain.ListView1.Items(114).ImageIndex = 248
                FormMain.ListView1.Items(115).ImageIndex = 249
                FormMain.ListView1.Items(116).ImageIndex = 250
                FormMain.ListView1.Items(117).ImageIndex = 251
                FormMain.ListView1.Items(118).ImageIndex = 252
                FormMain.ListView1.Items(119).ImageIndex = 253
                FormMain.ListView1.Items(120).ImageIndex = 254
                FormMain.ListView1.Items(121).ImageIndex = 255
                FormMain.ListView1.Items(122).ImageIndex = 256
                FormMain.ListView1.Items(123).ImageIndex = 257
                FormMain.ListView1.Items(124).ImageIndex = 258
                FormMain.ListView1.Items(125).ImageIndex = 259
                FormMain.ListView1.Items(126).ImageIndex = 260
                FormMain.ListView1.Items(127).ImageIndex = 261
                FormMain.ListView1.Items(128).ImageIndex = 262
                FormMain.ListView1.Items(129).ImageIndex = 263
                FormMain.ListView1.Items(130).ImageIndex = 264
                FormMain.ListView1.Items(131).ImageIndex = 265
                FormMain.ListView1.Items(132).ImageIndex = 266
                FormMain.ListView1.Items(133).ImageIndex = 267
            ElseIf FormMain.ComboBoxItemIcons.SelectedItem = "HoN" Then
                'Change Items Icons to HoN
                FormMain.ListView1.Items(0).ImageIndex = 0
                FormMain.ListView1.Items(1).ImageIndex = 268
                FormMain.ListView1.Items(2).ImageIndex = 269
                FormMain.ListView1.Items(3).ImageIndex = 270
                FormMain.ListView1.Items(4).ImageIndex = 271
                FormMain.ListView1.Items(5).ImageIndex = 272
                FormMain.ListView1.Items(6).ImageIndex = 273
                FormMain.ListView1.Items(7).ImageIndex = 274
                FormMain.ListView1.Items(8).ImageIndex = 275
                FormMain.ListView1.Items(9).ImageIndex = 276
                FormMain.ListView1.Items(10).ImageIndex = 277
                FormMain.ListView1.Items(11).ImageIndex = 278
                FormMain.ListView1.Items(12).ImageIndex = 279
                FormMain.ListView1.Items(13).ImageIndex = 280
                FormMain.ListView1.Items(14).ImageIndex = 281
                FormMain.ListView1.Items(15).ImageIndex = 282
                FormMain.ListView1.Items(16).ImageIndex = 283
                FormMain.ListView1.Items(17).ImageIndex = 284
                FormMain.ListView1.Items(18).ImageIndex = 285
                FormMain.ListView1.Items(19).ImageIndex = 286
                FormMain.ListView1.Items(20).ImageIndex = 287
                FormMain.ListView1.Items(21).ImageIndex = 288
                FormMain.ListView1.Items(22).ImageIndex = 289
                FormMain.ListView1.Items(23).ImageIndex = 290
                FormMain.ListView1.Items(24).ImageIndex = 291
                FormMain.ListView1.Items(25).ImageIndex = 292
                FormMain.ListView1.Items(26).ImageIndex = 293
                FormMain.ListView1.Items(27).ImageIndex = 294
                FormMain.ListView1.Items(28).ImageIndex = 28
                FormMain.ListView1.Items(29).ImageIndex = 295
                FormMain.ListView1.Items(30).ImageIndex = 296
                FormMain.ListView1.Items(31).ImageIndex = 297
                FormMain.ListView1.Items(32).ImageIndex = 298
                FormMain.ListView1.Items(33).ImageIndex = 299
                FormMain.ListView1.Items(34).ImageIndex = 300
                FormMain.ListView1.Items(35).ImageIndex = 301
                FormMain.ListView1.Items(36).ImageIndex = 302
                FormMain.ListView1.Items(37).ImageIndex = 303
                FormMain.ListView1.Items(38).ImageIndex = 304
                FormMain.ListView1.Items(39).ImageIndex = 39
                FormMain.ListView1.Items(40).ImageIndex = 305
                FormMain.ListView1.Items(41).ImageIndex = 306
                FormMain.ListView1.Items(42).ImageIndex = 307
                FormMain.ListView1.Items(43).ImageIndex = 43
                FormMain.ListView1.Items(44).ImageIndex = 308
                FormMain.ListView1.Items(45).ImageIndex = 309
                FormMain.ListView1.Items(46).ImageIndex = 310
                FormMain.ListView1.Items(47).ImageIndex = 311
                FormMain.ListView1.Items(48).ImageIndex = 312
                FormMain.ListView1.Items(49).ImageIndex = 313
                FormMain.ListView1.Items(50).ImageIndex = 314
                FormMain.ListView1.Items(51).ImageIndex = 315
                FormMain.ListView1.Items(52).ImageIndex = 316
                FormMain.ListView1.Items(53).ImageIndex = 317
                FormMain.ListView1.Items(54).ImageIndex = 318
                FormMain.ListView1.Items(55).ImageIndex = 319
                FormMain.ListView1.Items(56).ImageIndex = 56
                FormMain.ListView1.Items(57).ImageIndex = 320
                FormMain.ListView1.Items(58).ImageIndex = 321
                FormMain.ListView1.Items(59).ImageIndex = 322
                FormMain.ListView1.Items(60).ImageIndex = 323
                FormMain.ListView1.Items(61).ImageIndex = 324
                FormMain.ListView1.Items(62).ImageIndex = 325
                FormMain.ListView1.Items(63).ImageIndex = 326
                FormMain.ListView1.Items(64).ImageIndex = 327
                FormMain.ListView1.Items(65).ImageIndex = 328
                FormMain.ListView1.Items(66).ImageIndex = 329
                FormMain.ListView1.Items(67).ImageIndex = 330
                FormMain.ListView1.Items(68).ImageIndex = 331
                FormMain.ListView1.Items(69).ImageIndex = 332
                FormMain.ListView1.Items(70).ImageIndex = 70
                FormMain.ListView1.Items(71).ImageIndex = 333
                FormMain.ListView1.Items(72).ImageIndex = 334
                FormMain.ListView1.Items(73).ImageIndex = 335
                FormMain.ListView1.Items(74).ImageIndex = 336
                FormMain.ListView1.Items(75).ImageIndex = 337
                FormMain.ListView1.Items(76).ImageIndex = 338
                FormMain.ListView1.Items(77).ImageIndex = 339
                FormMain.ListView1.Items(78).ImageIndex = 340
                FormMain.ListView1.Items(79).ImageIndex = 341
                FormMain.ListView1.Items(80).ImageIndex = 342
                FormMain.ListView1.Items(81).ImageIndex = 343
                FormMain.ListView1.Items(82).ImageIndex = 344
                FormMain.ListView1.Items(83).ImageIndex = 345
                FormMain.ListView1.Items(84).ImageIndex = 84
                FormMain.ListView1.Items(85).ImageIndex = 346
                FormMain.ListView1.Items(86).ImageIndex = 347
                FormMain.ListView1.Items(87).ImageIndex = 348
                FormMain.ListView1.Items(88).ImageIndex = 349
                FormMain.ListView1.Items(89).ImageIndex = 350
                FormMain.ListView1.Items(90).ImageIndex = 351
                FormMain.ListView1.Items(91).ImageIndex = 352
                FormMain.ListView1.Items(92).ImageIndex = 353
                FormMain.ListView1.Items(93).ImageIndex = 354
                FormMain.ListView1.Items(94).ImageIndex = 355
                FormMain.ListView1.Items(95).ImageIndex = 356
                FormMain.ListView1.Items(96).ImageIndex = 357
                FormMain.ListView1.Items(97).ImageIndex = 358
                FormMain.ListView1.Items(98).ImageIndex = 98
                FormMain.ListView1.Items(99).ImageIndex = 359
                FormMain.ListView1.Items(100).ImageIndex = 360
                FormMain.ListView1.Items(101).ImageIndex = 361
                FormMain.ListView1.Items(102).ImageIndex = 362
                FormMain.ListView1.Items(103).ImageIndex = 363
                FormMain.ListView1.Items(104).ImageIndex = 104
                FormMain.ListView1.Items(105).ImageIndex = 364
                FormMain.ListView1.Items(106).ImageIndex = 365
                FormMain.ListView1.Items(107).ImageIndex = 366
                FormMain.ListView1.Items(108).ImageIndex = 367
                FormMain.ListView1.Items(109).ImageIndex = 368
                FormMain.ListView1.Items(110).ImageIndex = 369
                FormMain.ListView1.Items(111).ImageIndex = 370
                FormMain.ListView1.Items(112).ImageIndex = 371
                FormMain.ListView1.Items(113).ImageIndex = 372
                FormMain.ListView1.Items(114).ImageIndex = 373
                FormMain.ListView1.Items(115).ImageIndex = 374
                FormMain.ListView1.Items(116).ImageIndex = 116
                FormMain.ListView1.Items(117).ImageIndex = 375
                FormMain.ListView1.Items(118).ImageIndex = 376
                FormMain.ListView1.Items(119).ImageIndex = 377
                FormMain.ListView1.Items(120).ImageIndex = 378
                FormMain.ListView1.Items(121).ImageIndex = 379
                FormMain.ListView1.Items(122).ImageIndex = 380
                FormMain.ListView1.Items(123).ImageIndex = 381
                FormMain.ListView1.Items(124).ImageIndex = 382
                FormMain.ListView1.Items(125).ImageIndex = 383
                FormMain.ListView1.Items(126).ImageIndex = 126
                FormMain.ListView1.Items(127).ImageIndex = 384
                FormMain.ListView1.Items(128).ImageIndex = 128
                FormMain.ListView1.Items(129).ImageIndex = 385
                FormMain.ListView1.Items(130).ImageIndex = 386
                FormMain.ListView1.Items(131).ImageIndex = 387
                FormMain.ListView1.Items(132).ImageIndex = 388
                FormMain.ListView1.Items(133).ImageIndex = 389
            Else
                'Nothing because the Items are set to DotA 2
            End If
            'Listview Tooltips hinzufügen
            .Items(0).ToolTipText = "Abyssal Blade" + vbNewLine + vbNewLine + "+100 Damage" + vbNewLine + "+10 Strength" + vbNewLine + "Bash" + vbNewLine + "Overwhelm (active)"
            .Items(1).ToolTipText = "Aghanim's Scepter" + vbNewLine + vbNewLine + "+10 All Attributes" + vbNewLine + "+200 HP" + vbNewLine + "+150 Mana" + vbNewLine + "Ultimate Upgrade (passive)"
            .Items(2).ToolTipText = "Animal Courier" + vbNewLine + vbNewLine + "Summon Animal Courier"
            .Items(3).ToolTipText = "Arcane Boots" + vbNewLine + vbNewLine + "+65 Movement Speed " + vbNewLine + "+250 Mana" + vbNewLine + "Replenish Mana (active)"
            .Items(4).ToolTipText = "Armlet" + vbNewLine + vbNewLine + "+9 Damage" + vbNewLine + "+15 Attack Speed" + vbNewLine + "+5 Armor" + vbNewLine + "+5 HP/sec Regeneration" + vbNewLine + "Unholy Strength (active)"
            .Items(5).ToolTipText = "Assault Cuirass" + vbNewLine + vbNewLine + "+10 Armor" + vbNewLine + "+35 Attack Speed" + vbNewLine + "Positive Armor (Aura)" + vbNewLine + "Negative Armor (Aura)" + vbNewLine + "Attack Speed (Aura)"
            .Items(6).ToolTipText = "Battle Fury" + vbNewLine + vbNewLine + "+65 Damage" + vbNewLine + "+6 HP/sec Regeneration" + vbNewLine + "+150% Mana Regeneration" + vbNewLine + "Cleave"
            .Items(7).ToolTipText = "Belt of Strength" + vbNewLine + vbNewLine + "+6 Strength"
            .Items(8).ToolTipText = "Black King Bar" + vbNewLine + vbNewLine + "+10 Strength" + vbNewLine + "+24 Damage" + vbNewLine + "Avatar (active)"
            .Items(9).ToolTipText = "Blade Mail" + vbNewLine + vbNewLine + "+22 Damage" + vbNewLine + "+5 Armor" + vbNewLine + "+10 Intelligence" + vbNewLine + "Damage Return (active)"
            .Items(10).ToolTipText = "Blade of Alacrity" + vbNewLine + vbNewLine + "+10 Agility"
            .Items(11).ToolTipText = "Blades of Attack" + vbNewLine + vbNewLine + "+9 Damage"
            .Items(12).ToolTipText = "Blink Dagger" + vbNewLine + vbNewLine + "Blink"
            .Items(13).ToolTipText = "Bloodstone" + vbNewLine + vbNewLine + "+500 HP" + vbNewLine + "+400 Mana" + vbNewLine + "+8 HP/sec Regeneration" + vbNewLine + "+200% Mana Regeneration" + vbNewLine + "Bloodpact" + vbNewLine + "5 Charges"
            .Items(14).ToolTipText = "Boots of Elvenskin" + vbNewLine + vbNewLine + "+6 Agility"
            .Items(15).ToolTipText = "Boots of Speed" + vbNewLine + vbNewLine + "+55 Movement Speed"
            .Items(16).ToolTipText = "Boots of Travel" + vbNewLine + vbNewLine + "+95 Movement Speed" + vbNewLine + "Teleport (active)"
            .Items(17).ToolTipText = "Bottle" + vbNewLine + vbNewLine + "Regenerate" + vbNewLine + "Rune Capture"
            .Items(18).ToolTipText = "Bracer" + vbNewLine + vbNewLine + "+3 Damage" + vbNewLine + "+6 Strength" + vbNewLine + "+3 Agility" + vbNewLine + "+3 Intelligence"
            .Items(19).ToolTipText = "Broadsword" + vbNewLine + vbNewLine + "+18 Damage"
            .Items(20).ToolTipText = "Buckler" + vbNewLine + vbNewLine + "+5 Armor" + vbNewLine + "+2 All Attributes" + vbNewLine + "Armor Bonus (active)"
            .Items(21).ToolTipText = "Butterfly" + vbNewLine + vbNewLine + "+30 Agility" + vbNewLine + "+30 Damage" + vbNewLine + "30% Evasion" + vbNewLine + "+30 Attack Speed"
            .Items(22).ToolTipText = "Chainmail" + vbNewLine + vbNewLine + "+5 Armor"
            .Items(23).ToolTipText = "Circlet" + vbNewLine + vbNewLine + "+2 All Attributes"
            .Items(24).ToolTipText = "Clarity" + vbNewLine + vbNewLine + "Regenerate Mana" + vbNewLine + "1 Charges"
            .Items(25).ToolTipText = "Claymore" + vbNewLine + vbNewLine + "+21 Damage"
            .Items(26).ToolTipText = "Cloak" + vbNewLine + vbNewLine + "+15% Magic Resistance"
            .Items(27).ToolTipText = "Crystalys" + vbNewLine + vbNewLine + "+35 Damage" + vbNewLine + "Critical Strike"
            .Items(28).ToolTipText = "Daedalus" + vbNewLine + vbNewLine + "+81 Damage" + vbNewLine + "Critical Strike"
            .Items(29).ToolTipText = "Dagon 1" + vbNewLine + vbNewLine + "+13 Intelligence" + vbNewLine + "+3 All Attributes" + vbNewLine + "+9 Damage" + vbNewLine + "Energy Burst (active)"
            .Items(30).ToolTipText = "Dagon 2" + vbNewLine + vbNewLine + "+15 Intelligence" + vbNewLine + "+3 All Attributes" + vbNewLine + "+9 Damage" + vbNewLine + "Energy Burst (active)"
            .Items(31).ToolTipText = "Dagon 3" + vbNewLine + vbNewLine + "+17 Intelligence" + vbNewLine + "+3 All Attributes" + vbNewLine + "+9 Damage" + vbNewLine + "Energy Burst (active)"
            .Items(32).ToolTipText = "Dagon 4" + vbNewLine + vbNewLine + "+19 Intelligence" + vbNewLine + "+3 All Attributes" + vbNewLine + "+9 Damage" + vbNewLine + "Energy Burst (active)"
            .Items(33).ToolTipText = "Dagon 5" + vbNewLine + vbNewLine + "+21 Intelligence" + vbNewLine + "+3 All Attributes" + vbNewLine + "+9 Damage" + vbNewLine + "Energy Burst (active)"
            .Items(34).ToolTipText = "Demon Edge" + vbNewLine + vbNewLine + "+46 Damage"
            .Items(35).ToolTipText = "Desolator" + vbNewLine + vbNewLine + "+60 Damage" + vbNewLine + "Corruption"
            .Items(36).ToolTipText = "Diffusal Blade 1" + vbNewLine + vbNewLine + "+22 Agility" + vbNewLine + "+6 Intelligence" + vbNewLine + "Feedback" + vbNewLine + "Purge (active)" + vbNewLine + "8 Charges"
            .Items(37).ToolTipText = "Diffusal Blade 2" + vbNewLine + vbNewLine + "+26 Agility" + vbNewLine + "+10 Intelligence" + vbNewLine + "Feedback" + vbNewLine + "Purge (active)" + vbNewLine + "8 Charges"
            .Items(38).ToolTipText = "Divine Rapier" + vbNewLine + vbNewLine + "+250 Damage"
            .Items(39).ToolTipText = "Drum of Endurance" + vbNewLine + vbNewLine + "+9 All Attributes" + vbNewLine + "+9 Damage" + vbNewLine + "Endurance Aura" + vbNewLine + "Endurance (active)" + vbNewLine + "4 Charges"
            .Items(40).ToolTipText = "Dust of Appearance" + vbNewLine + vbNewLine + "Reveal" + vbNewLine + "2 Charges"
            .Items(41).ToolTipText = "Eaglesong" + vbNewLine + vbNewLine + "+25 Agility"
            .Items(42).ToolTipText = "Energy Booster" + vbNewLine + vbNewLine + "+250 Mana"
            .Items(43).ToolTipText = "Ethereal Blade" + vbNewLine + vbNewLine + "+40 Agility" + vbNewLine + "+10 Strength" + vbNewLine + "+10 Intelligence" + vbNewLine + "Ether Blast (active)"
            .Items(44).ToolTipText = "Eul's Scepter of Divinity" + vbNewLine + vbNewLine + "+10 Intelligence" + vbNewLine + "+150% Mana Regeneration" + vbNewLine + "+25 Movement Speed" + vbNewLine + "Cyclone (active)"
            .Items(45).ToolTipText = "Eye of Skadi" + vbNewLine + vbNewLine + "+25 All Attributes" + vbNewLine + "+200 HP" + vbNewLine + "+150 Mana" + vbNewLine + "Cold Attack"
            .Items(46).ToolTipText = "Flying Courier" + vbNewLine + vbNewLine + "Summon Flying Courier"
            .Items(47).ToolTipText = "Force Staff" + vbNewLine + vbNewLine + "+10 Intelligence" + vbNewLine + "+10 Damage" + vbNewLine + "+10 Attack Speed" + vbNewLine + "Force (active)"
            .Items(48).ToolTipText = "Gauntlets of Strength" + vbNewLine + vbNewLine + "+3 Strength"
            .Items(49).ToolTipText = "Gem of True Sight" + vbNewLine + vbNewLine + "True Sight"
            .Items(50).ToolTipText = "Ghost Scepter" + vbNewLine + vbNewLine + "+7 All Attributes" + vbNewLine + "Ghost Form (active)"
            .Items(51).ToolTipText = "Gloves of Haste" + vbNewLine + vbNewLine + "+15 Attack Speed"
            .Items(52).ToolTipText = "Hand of Midas" + vbNewLine + vbNewLine + "+30 Attack Speed" + vbNewLine + "Transmute (active)"
            .Items(53).ToolTipText = "Headdress" + vbNewLine + vbNewLine + "+2 All Attributes" + vbNewLine + "Regeneration Aura"
            .Items(54).ToolTipText = "Healing Salve" + vbNewLine + vbNewLine + "Regenerate Health" + vbNewLine + "1 Charges"
            .Items(55).ToolTipText = "Heart of Tarrasque" + vbNewLine + vbNewLine + "+40 Strength" + vbNewLine + "+300 HP" + vbNewLine + "Health Regeneration"
            .Items(56).ToolTipText = "Heaven's Halberd" + vbNewLine + vbNewLine + "+25 Damage" + vbNewLine + "+20 Strength" + vbNewLine + "+25 Evasion" + vbNewLine + "Lesser Maim" + vbNewLine + "Disarm (active)"
            .Items(57).ToolTipText = "Helm of Iron Will" + vbNewLine + vbNewLine + "+5 Armor" + vbNewLine + "+3 HP/sec Regeneration"
            .Items(58).ToolTipText = "Helm of the Dominator" + vbNewLine + vbNewLine + "+20 Damage" + vbNewLine + "+5 Armor" + vbNewLine + "+15% Lifesteal" + vbNewLine + "Dominate (active)"
            .Items(59).ToolTipText = "Hood of Defiance" + vbNewLine + vbNewLine + "+30% Magic Resistance" + vbNewLine + "+8 HP/sec Regeneration"
            .Items(60).ToolTipText = "Hyperstone" + vbNewLine + vbNewLine + "+55 Attack Speed"
            .Items(61).ToolTipText = "Iron Branch" + vbNewLine + vbNewLine + "+1 All Attributes"
            .Items(62).ToolTipText = "Javelin" + vbNewLine + vbNewLine + "+21 Damage" + vbNewLine + "20% chance to deal 40 bonus damage"
            .Items(63).ToolTipText = "Linken's Sphere" + vbNewLine + vbNewLine + "+15 All Attributes" + vbNewLine + "+6 HP/sec regeneration" + vbNewLine + "+150% Mana Regeneration" + vbNewLine + "Spell Block"
            .Items(64).ToolTipText = "Maelstrom" + vbNewLine + vbNewLine + "+24 Damage" + vbNewLine + "+25 Attack Speed" + vbNewLine + "Chain Lightning"
            .Items(65).ToolTipText = "Magic Stick" + vbNewLine + vbNewLine + "Energy Charge (active)"
            .Items(66).ToolTipText = "Magic Wand" + vbNewLine + vbNewLine + "+3 All Attributes" + vbNewLine + "Energy Charge (active)"
            .Items(67).ToolTipText = "Manta Style" + vbNewLine + vbNewLine + "+26 Agility" + vbNewLine + "+10 Strength" + vbNewLine + "+10 Intelligence" + vbNewLine + "+15 Attack Speed" + vbNewLine + "+10% Movement Speed" + vbNewLine + "Mirror Image (active)"
            .Items(68).ToolTipText = "Mantle of Intelligence" + vbNewLine + vbNewLine + "+3 Intelligence"
            .Items(69).ToolTipText = "Mask of Madness" + vbNewLine + vbNewLine + "+17% Lifesteal" + vbNewLine + "Berserk (active)"
            .Items(70).ToolTipText = "Medallion of Courage" + vbNewLine + vbNewLine + "+6 Armor" + vbNewLine + "+50% Mana Regeneration" + vbNewLine + "Valor (active)"
            .Items(71).ToolTipText = "Mekansm" + vbNewLine + vbNewLine + "+5 All Attributes" + vbNewLine + "+5 Armor" + vbNewLine + "Mekansm Aura" + vbNewLine + "Restore (active)"
            .Items(72).ToolTipText = "Mithril Hammer" + vbNewLine + vbNewLine + "+24 Damage"
            .Items(73).ToolTipText = "Mjollnir" + vbNewLine + vbNewLine + "+80 Attack Speed" + vbNewLine + "+24 Damage" + vbNewLine + "Chain Lightning" + vbNewLine + "Static Charge (active)"
            .Items(74).ToolTipText = "Monkey King Bar" + vbNewLine + vbNewLine + "+88 Damage" + vbNewLine + "+15 Attack Speed" + vbNewLine + "True Strike" + vbNewLine + "Mini-Bash"
            .Items(75).ToolTipText = "Morbid Mask" + vbNewLine + vbNewLine + "+15% Lifesteal"
            .Items(76).ToolTipText = "Mystic Staff" + vbNewLine + vbNewLine + "+25 Intelligence"
            .Items(77).ToolTipText = "Necronomicon 1" + vbNewLine + vbNewLine + "+15 Intelligence" + vbNewLine + "+8 Strength" + vbNewLine + "Demonic Summoning (active)"
            .Items(78).ToolTipText = "Necronomicon 2" + vbNewLine + vbNewLine + "+21 Intelligence" + vbNewLine + "+12 Strength" + vbNewLine + "Demonic Summoning (active)"
            .Items(79).ToolTipText = "Necronomicon 3" + vbNewLine + vbNewLine + "+24 Intelligence" + vbNewLine + "+16 Strength" + vbNewLine + "Demonic Summoning (active)"
            .Items(80).ToolTipText = "Null Talisman" + vbNewLine + vbNewLine + "+3 Damage" + vbNewLine + "+6 Intelligence" + vbNewLine + "+3 Strength" + vbNewLine + "+3 Agility"
            .Items(81).ToolTipText = "Oblivion Staff" + vbNewLine + vbNewLine + "+6 Intelligence" + vbNewLine + "+10 Attack Speed" + vbNewLine + "+15 Damage" + vbNewLine + "+75% Mana Regeneration"
            .Items(82).ToolTipText = "Observer Ward" + vbNewLine + vbNewLine + "Place Ward" + vbNewLine + "2 Charges"
            .Items(83).ToolTipText = "Ogre Club" + vbNewLine + vbNewLine + "+10 Strength"
            .Items(84).ToolTipText = "Orb of Venom" + vbNewLine + vbNewLine + "Poison Attack"
            .Items(85).ToolTipText = "Orchid Malevolence" + vbNewLine + vbNewLine + "+20 Intelligence" + vbNewLine + "+30 Attack Speed" + vbNewLine + "+45 Damage" + vbNewLine + "+225% Mana Regeneration" + vbNewLine + "Soul Burn (active)"
            .Items(86).ToolTipText = "Perseverance" + vbNewLine + vbNewLine + "+10 Damage" + vbNewLine + "+5 HP/sec Regeneration" + vbNewLine + "+125% Mana Regeneration"
            .Items(87).ToolTipText = "Phase Boots" + vbNewLine + vbNewLine + "+60 Movement Speed" + vbNewLine + "+24 damage" + vbNewLine + "Phase (active)"
            .Items(88).ToolTipText = "Pipe of Insight" + vbNewLine + vbNewLine + "+11 HP/sec Regeneration" + vbNewLine + "+30% Magic Resistance" + vbNewLine + "Barrier (active)"
            .Items(89).ToolTipText = "Platemail" + vbNewLine + vbNewLine + "+10 Armor"
            .Items(90).ToolTipText = "Point Booster" + vbNewLine + vbNewLine + "+200 HP" + vbNewLine + "+150 Mana"
            .Items(91).ToolTipText = "Poor Man's Shield" + vbNewLine + vbNewLine + "+6 Agility" + vbNewLine + "Damage Block"
            .Items(92).ToolTipText = "Power Treads" + vbNewLine + vbNewLine + "+60 Move Speed" + vbNewLine + "+8 Selected Attribute" + vbNewLine + "+25 Attack Speed" + vbNewLine + "Switch Attribute (active)"
            .Items(93).ToolTipText = "Quarterstaff" + vbNewLine + vbNewLine + "+10 Damage" + vbNewLine + "+10 Attack Speed"
            .Items(94).ToolTipText = "Quelling Blade" + vbNewLine + vbNewLine + "Demolish" + vbNewLine + "Tree Chop (active)"
            .Items(95).ToolTipText = "Radiance" + vbNewLine + vbNewLine + "+60 Damage" + vbNewLine + "Burn Damage"
            .Items(96).ToolTipText = "Reaver" + vbNewLine + vbNewLine + "+25 Strength"
            .Items(97).ToolTipText = "Refresher Orb" + vbNewLine + vbNewLine + "+5 HP/Sec Regeneration" + vbNewLine + "+200% Mana Regeneration" + vbNewLine + "+40 Damage" + vbNewLine + "Reset Cooldowns (active)"
            .Items(98).ToolTipText = "Ring of Aquila" + vbNewLine + vbNewLine + "+9 Damage" + vbNewLine + "+3 All Stats" + vbNewLine + "+3 Agility" + vbNewLine + "+1 Armor" + vbNewLine + "Armor Aura" + vbNewLine + "Mana Aura"
            .Items(99).ToolTipText = "Ring of Basilius" + vbNewLine + vbNewLine + "+6 Damage" + vbNewLine + "+1 Armor" + vbNewLine + "Mana Aura" + vbNewLine + "Armor Aura"
            .Items(100).ToolTipText = "Ring of Health" + vbNewLine + vbNewLine + "+5 HP/sec Regeneration"
            .Items(101).ToolTipText = "Ring of Protection" + vbNewLine + vbNewLine + "+2 Armor"
            .Items(102).ToolTipText = "Ring of Regen" + vbNewLine + vbNewLine + "+2 HP/sec Regeneration"
            .Items(103).ToolTipText = "Robe of the Magi" + vbNewLine + vbNewLine + "+6 Intelligence"
            .Items(104).ToolTipText = "Rod of Atos" + vbNewLine + vbNewLine + "+25 Intelligence" + vbNewLine + "+250 HP" + vbNewLine + "Cripple (active)"
            .Items(105).ToolTipText = "Sacred Relic" + vbNewLine + vbNewLine + "+60 Damage"
            .Items(106).ToolTipText = "Sage's Mask" + vbNewLine + vbNewLine + "+50% Mana Regeneration"
            .Items(107).ToolTipText = "Sange" + vbNewLine + vbNewLine + "+16 Strength" + vbNewLine + "+10 Damage" + vbNewLine + "Lesser Maim"
            .Items(108).ToolTipText = "Sange and Yasha" + vbNewLine + vbNewLine + "+16 Agility" + vbNewLine + "+16 Strength" + vbNewLine + "+12 Damage" + vbNewLine + "+15 Attack Speed" + vbNewLine + "+12% Movement Speed" + vbNewLine + "Greater Maim"
            .Items(109).ToolTipText = "Satanic" + vbNewLine + vbNewLine + "+25 Strength" + vbNewLine + "+20 Damage" + vbNewLine + "+5 Armor" + vbNewLine + "Lifesteal" + vbNewLine + "Unholy Rage (active)"
            .Items(110).ToolTipText = "Scythe of Vyse" + vbNewLine + vbNewLine + "+35 Intelligence" + vbNewLine + "+10 Strength" + vbNewLine + "+10 Agility" + vbNewLine + "+150% Mana Regeneration" + vbNewLine + "Hex (active)"
            .Items(111).ToolTipText = "Sentry Ward" + vbNewLine + vbNewLine + "Place Ward" + vbNewLine + "950 Radius True Sight" + vbNewLine + "2 Charges"
            .Items(112).ToolTipText = "Shadow Blade" + vbNewLine + vbNewLine + "+38 Damage" + vbNewLine + "+10 Attack Speed" + vbNewLine + "Shadow Walk (active)"
            .Items(113).ToolTipText = "Shiva's Guard" + vbNewLine + vbNewLine + "+30 Intelligence" + vbNewLine + "+15 Armor" + vbNewLine + "Freezing Aura" + vbNewLine + "Arctic Blast (active)"
            .Items(114).ToolTipText = "Skull Basher" + vbNewLine + vbNewLine + "+40 Damage" + vbNewLine + "+6 Strength" + vbNewLine + "Bash"
            .Items(115).ToolTipText = "Slippers of Agility" + vbNewLine + vbNewLine + "+3 Agility"
            .Items(116).ToolTipText = "Smoke of Deceit" + vbNewLine + vbNewLine + "Smoke of Deceit (active)" + vbNewLine + "1 Charges"
            .Items(117).ToolTipText = "Soul Booster" + vbNewLine + vbNewLine + "+450 HP" + vbNewLine + "+400 Mana" + vbNewLine + "+4 HP/sec Regeneration" + vbNewLine + "+100% Mana Regeneration"
            .Items(118).ToolTipText = "Soul Ring" + vbNewLine + vbNewLine + "+3 HP/sec Regeneration" + vbNewLine + "+50% Mana Regeneration" + vbNewLine + "Sacrifice (active)"
            .Items(119).ToolTipText = "Staff of Wizardry" + vbNewLine + vbNewLine + "+10 Intelligence"
            .Items(120).ToolTipText = "Stout Shield" + vbNewLine + vbNewLine + "Damage Block"
            .Items(121).ToolTipText = "Talisman of Evasion" + vbNewLine + vbNewLine + "+25% Evasion"
            .Items(122).ToolTipText = "Tango" + vbNewLine + vbNewLine + "Eat Tree (active)" + vbNewLine + "3 Charges"
            .Items(123).ToolTipText = "Town Portal Scroll" + vbNewLine + vbNewLine + "Teleport (active)" + vbNewLine + "1 Charges"
            .Items(124).ToolTipText = "Tranquil Boots" + vbNewLine + vbNewLine + "+80 Movement Speed" + vbNewLine + "+3 HP/sec Regeneration" + vbNewLine + "+3 Armor" + vbNewLine + "Rejuvenate (active)"
            .Items(125).ToolTipText = "Ultimate Orb" + vbNewLine + vbNewLine + "+10 All Attributes"
            .Items(126).ToolTipText = "Urn of Shadows" + vbNewLine + vbNewLine + "+50% Mana Regeneration" + vbNewLine + "+6 Strength" + vbNewLine + "Soul Release (active)"
            .Items(127).ToolTipText = "Vanguard" + vbNewLine + vbNewLine + "+6 HP/sec Regeneration" + vbNewLine + "+250 HP" + vbNewLine + "Damage Block"
            .Items(128).ToolTipText = "Veil of Discord" + vbNewLine + vbNewLine + "+5 Armor" + vbNewLine + "+5 HP/sec Regeneration" + vbNewLine + "+12 Intelligence" + vbNewLine + "Discord (active)"
            .Items(129).ToolTipText = "Vitality Booster" + vbNewLine + vbNewLine + "+250 HP"
            .Items(130).ToolTipText = "Vladmir's Offering" + vbNewLine + vbNewLine + "+2 HP/sec Regeneration" + vbNewLine + "Vampiric Aura" + vbNewLine + "Damage Aura" + vbNewLine + "Armor Aura" + vbNewLine + "Mana Regeneration Aura"
            .Items(131).ToolTipText = "Void Stone" + vbNewLine + vbNewLine + "+100% Mana Regeneration"
            .Items(132).ToolTipText = "Wraith Band" + vbNewLine + vbNewLine + "+3 Damage" + vbNewLine + "+6 Agility" + vbNewLine + "+3 Strength" + vbNewLine + "+3 Intelligence"
            .Items(133).ToolTipText = "Yasha" + vbNewLine + vbNewLine + "+16 Agility" + vbNewLine + "+15 Attack Speed" + vbNewLine + "+10% Movement Speed"
        End With
    End Sub

    Public Sub ClearSingle()
        FormMain.TextBox1.Text = ""
        FormMain.Label1.Text = ""
        FormMain.Label15.Text = "0"
        FormMain.Label16.Text = "0"
        FormMain.Label18.Text = "0"
        FormMain.Label20.Text = "0"
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
            Dim price As Object = FormMain.Label15
            Dim int As Integer
            For Each Zeile As String In IO.File.ReadAllLines(DeinPfad)
                If Zeile.Contains("item_") And i <= 39 Then
                    pb = FormMain.TabPage1.Controls.Item("Item" & i)
                    pb.image = FormMain.ChangePicture(FormMain.RenameItem(Zeile))
                    FormMain.ToolTip1.SetToolTip(pb, GetToolTip(FormMain.RenameItem(Zeile)))
                    int = (CInt(price.Text) + GetPrice(FormMain.RenameItem(Zeile)))
                    price.Text = int.ToString
                    i = i + 1
                ElseIf Zeile.Contains("Early_Game") Then
                    ItemPlace = "Early Game"
                    i = 10
                    price = FormMain.Label16
                    NeuerText &= Zeile & vbNewLine
                ElseIf Zeile.Contains("Core_Items") Then
                    ItemPlace = "Core Items"
                    i = 19
                    price = FormMain.Label18
                    NeuerText &= Zeile & vbNewLine
                ElseIf Zeile.Contains("Luxury") Then
                    ItemPlace = "Luxury"
                    i = 28
                    price = FormMain.Label20
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
            .Items.Remove("Lycanthrope")
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

    Public Function GetPrice(ByVal itemname As String) As Integer
        Select Case itemname
            Case "Abyssal Blade"
                Return 6750
            Case "Aghanim's Scepter"
                Return 4200
            Case "Animal Courier"
                Return 150
            Case "Arcane Boots"
                Return 1500
            Case "Armlet of Mordiggian"
                Return 2600
            Case "Assault Cuirass"
                Return 5350
            Case "Battle Fury"
                Return 4350
            Case "Belt of Strength"
                Return 450
            Case "Black King Bar"
                Return 3900
            Case "Blade Mail"
                Return 2200
            Case "Blade of Alacrity"
                Return 1000
            Case "Blades of Attack"
                Return 450
            Case "Blink Dagger"
                Return 2150
            Case "Bloodstone"
                Return 5050
            Case "Boots of Elvenskin"
                Return 450
            Case "Boots of Speed"
                Return 500
            Case "Boots of Travel"
                Return 2500
            Case "Bottle"
                Return 600
            Case "Bracer"
                Return 525
            Case "Broadsword"
                Return 1200
            Case "Buckler"
                Return 803
            Case "Butterfly"
                Return 6000
            Case "Chainmail"
                Return 550
            Case "Circlet"
                Return 185
            Case "Clarity"
                Return 50
            Case "Claymore"
                Return 1400
            Case "Cloak"
                Return 550
            Case "Crystalys"
                Return 2150
            Case "Daedalus"
                Return 5750
            Case "Dagon 1"
                Return 2805
            Case "Dagon 2"
                Return 2805 + 1300
            Case "Dagon 3"
                Return 2805 + 1300 + 1300
            Case "Dagon 4"
                Return 2805 + 1300 + 1300 + 1300
            Case "Dagon 5"
                Return 2805 + 1300 + 1300 + 1300 + 1300
            Case "Demon Edge"
                Return 2400
            Case "Desolator"
                Return 4100
            Case "Diffusal Blade 1"
                Return 3300
            Case "Diffusal Blade 2"
                Return 3300 + 850
            Case "Divine Rapier"
                Return 6200
            Case "Drum of Endurance"
                Return 1725
            Case "Dust of Appearance"
                Return 180
            Case "Eaglesong"
                Return 3300
            Case "Energy Booster"
                Return 1000
            Case "Ethereal Blade"
                Return 4900
            Case "Eul's Scepter of Divinity"
                Return 2800
            Case "Eye of Skadi"
                Return 5750
            Case "Flying Courier"
                Return 390
            Case "Force Staff"
                Return 2200
            Case "Gauntlets of Strength"
                Return 150
            Case "Gem of True Sight"
                Return 700
            Case "Ghost Scepter"
                Return 1600
            Case "Gloves of Haste"
                Return 500
            Case "Hand of Midas"
                Return 1900
            Case "Headdress"
                Return 603
            Case "Healing Salve"
                Return 100
            Case "Heart of Tarrasque"
                Return 5500
            Case "Heaven's Halberd"
                Return 3950
            Case "Helm of Iron Will"
                Return 950
            Case "Helm of the Dominator"
                Return 1850
            Case "Hood of Defiance"
                Return 2125
            Case "Hyperstone"
                Return 2100
            Case "Iron Branch"
                Return 53
            Case "Javelin"
                Return 1500
            Case "Linken's Sphere"
                Return 5175
            Case "Maelstrom"
                Return 2700
            Case "Magic Stick"
                Return 200
            Case "Magic Wand"
                Return 509
            Case "Manta Style"
                Return 4900
            Case "Mantle of Intelligence"
                Return 150
            Case "Mask of Madness"
                Return 1900
            Case "Medallion of Courage"
                Return 1075
            Case "Mekansm"
                Return 2306
            Case "Mithril Hammer"
                Return 1600
            Case "Mjollnir"
                Return 5400
            Case "Monkey King Bar"
                Return 5400
            Case "Morbid Mask"
                Return 900
            Case "Mystic Staff"
                Return 2700
            Case "Necronomicon 1"
                Return 2700
            Case "Necronomicon 2"
                Return 2700 + 1250
            Case "Necronomicon 3"
                Return 2700 + 1250 + 1250
            Case "Null Talisman"
                Return 505
            Case "Oblivion Staff"
                Return 1675
            Case "Observer Ward"
                Return 200
            Case "Ogre Club"
                Return 1000
            Case "Orb of Venom"
                Return 350
            Case "Orchid Malevolence"
                Return 4125
            Case "Perseverance"
                Return 1750
            Case "Phase Boots"
                Return 1400
            Case "Pipe of Insight"
                Return 3628
            Case "Platemail"
                Return 1400
            Case "Point Booster"
                Return 1200
            Case "Poor Man's Shield"
                Return 550
            Case "Power Treads"
                Return 1450
            Case "Quarterstaff"
                Return 900
            Case "Quelling Blade"
                Return 225
            Case "Radiance"
                Return 5150
            Case "Reaver"
                Return 3200
            Case "Refresher Orb"
                Return 5300
            Case "Ring of Aquila"
                Return 985
            Case "Ring of Basilius"
                Return 500
            Case "Ring of Health"
                Return 875
            Case "Ring of Protection"
                Return 175
            Case "Ring of Regen"
                Return 350
            Case "Robe of the Magi"
                Return 450
            Case "Rod of Atos"
                Return 3100
            Case "Sacred Relic"
                Return 3800
            Case "Sage's Mask"
                Return 325
            Case "Sange"
                Return 2150
            Case "Sange and Yasha"
                Return 4300
            Case "Satanic"
                Return 6150
            Case "Scythe of Vyse"
                Return 5675
            Case "Sentry Ward"
                Return 200
            Case "Shadow Blade"
                Return 3300
            Case "Shiva's Guard"
                Return 4700
            Case "Skull Basher"
                Return 2950
            Case "Slippers of Agility"
                Return 150
            Case "Smoke of Deceit"
                Return 100
            Case "Soul Booster"
                Return 3300
            Case "Soul Ring"
                Return 800
            Case "Staff of Wizardry"
                Return 1000
            Case "Stout Shield"
                Return 250
            Case "Talisman of Evasion"
                Return 1800
            Case "Tango"
                Return 90
            Case "Town Portal Scroll"
                Return 135
            Case "Tranquil Boots"
                Return 1025
            Case "Ultimate Orb"
                Return 2100
            Case "Urn of Shadows"
                Return 875
            Case "Vanguard"
                Return 2225
            Case "Veil of Discord"
                Return 5000
            Case "2650"
                Return 5000
            Case "Vitality Booster"
                Return 1100
            Case "Vladmir's Offering"
                Return 2050
            Case "Void Stone"
                Return 875
            Case "Wraith Band"
                Return 485
            Case "Yasha"
                Return 2150
            Case Else
                Return 0
        End Select
    End Function

End Class
