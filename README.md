# JobBars
A plugin for [XIVQuickLauncher](https://github.com/goatcorp/FFXIVQuickLauncher) which provides extra job gauges, a party buff tracker, and more.

- Number of GCDs under buffs (Fight or Flight, Inner Release)
- DoT tracker (Dia, Miasma)
- Proc display (Verfire/Verstone Ready)
- Number of charges (Ricochet, Gauss Round)
- Number of stacks (Ruin IV)
- Icon replacement (time until DoT refresh, duration left on buffs)
- Party buffs coming off of cooldown
- Mitigation tracker
- Cursor displays (cast time, GCD timer, MP tick, DoT tick)

Icon by [PAPACHIN](https://www.xivmodarchive.com/user/192152)

https://user-images.githubusercontent.com/18051158/130377508-ee88e07f-b41f-4a39-83db-4b9cc79a47b0.mp4

https://user-images.githubusercontent.com/18051158/130377516-5c299fb5-9a3a-4b47-bb5f-b03297c3ea6f.mp4

https://user-images.githubusercontent.com/18051158/130377606-2490ab26-1c2b-43fa-93f3-80e6c95e9fff.mp4

https://user-images.githubusercontent.com/18051158/130377610-86fb7e17-9780-4827-81df-0739908bd709.mp4

https://user-images.githubusercontent.com/18051158/130377598-2398d33a-9c0c-4d0c-8fd7-4187451a7e56.mp4

## Usage
To open the settings menu, use `/jobbars`. When changing icon positions on your hotbars, you may need to switch to a different job and then back to update the icon displays.

## Why?
The goal of this project is to augment the existing UI by displaying information in a more convenient format. It is not meant to be a complete overhaul, or to replace existing job gauges. If you personally only find certain parts useful, every gauge/buff/mitigation/etc. can be enabled and disabled individually.

## Jobs

**Feel like something is missing? Open an [issue](https://github.com/0ceal0t/JobBars/issues)**

### <img src="assets/job_icons/DRK.png" height="20px" width="20px"> Dark Knight

| Gauges<img width="150" height="0"> | Buffs<img width="150" height="0"> | Migitation<img width="150" height="0"> | Icon Display<img width="150" height="0"> |
|------------------------------------|-----------------------------------|----------------------------------------|------------------------------------------|
| GCDs in Delirium                   | Delirium                          | Living Dead                            | Delirium                                 |
| GCDs in Blood Weapon               | Living Shadow                     | Reprisal                               | Blood Weapon                             |
| MP                                 |                                   | Dark Missionary                        |                                          |
|                                    |                                   | The Blackest Night                     |                                          |


### <img src="assets/job_icons/WAR.png" height="20px" width="20px"> Warrior

| Gauges<img width="150" height="0"> | Buffs<img width="150" height="0"> | Migitation<img width="150" height="0"> | Icon Display<img width="150" height="0"> |
|------------------------------------|-----------------------------------|----------------------------------------|------------------------------------------|
| GCDs in Inner Release              | Inner Release                     | Holmgang                               | Inner Release                            |
| Storm's Eye                        |                                   | Reprisal                               | Storm's Eye                              |
|                                    |                                   | Shake it Off                           |                                          |
|                                    |                                   | Nascent Flash                          |                                          |


### <img src="assets/job_icons/PLD.png" height="20px" width="20px"> Paladin

| Gauges<img width="150" height="0"> | Buffs<img width="150" height="0"> | Migitation<img width="150" height="0"> | Icon Display<img width="150" height="0"> |
|------------------------------------|-----------------------------------|----------------------------------------|------------------------------------------|
| GCDs in Requiescat                 |                                   | Hallowed Ground                        | Requiescat                               |
| GCDs in Fight or Flight            |                                   | Reprisal                               | Goring Blade                             |
| Goring Blade                       |                                   | Divine Veil                            | Fight or Flight                          |
|                                    |                                   | Passage of Arms                        |                                          |

### <img src="assets/job_icons/GNB.png" height="20px" width="20px"> Gunbreaker

| Gauges<img width="150" height="0"> | Buffs<img width="150" height="0"> | Migitation<img width="150" height="0"> | Icon Display<img width="150" height="0"> |
|------------------------------------|-----------------------------------|----------------------------------------|------------------------------------------|
| GCDs in No Mercy                   |                                   | Superbolide                            | No Mercy                                 |
|                                    |                                   | Reprisal                               |                                          |
|                                    |                                   | Heart  of Light                        |                                          |

### <img src="assets/job_icons/SCH.png" height="20px" width="20px"> Scholar

| Gauges<img width="150" height="0"> | Buffs<img width="150" height="0"> | Migitation<img width="150" height="0"> | Icon Display<img width="150" height="0"> |
|------------------------------------|-----------------------------------|----------------------------------------|------------------------------------------|
| Excog                              | Chain Stratagem                   | Seraph                                 | Biolysis                                 |
| Biolysis                           |                                   | Deployment Tactics                     | Chain Stratagem                          |
|                                    |                                   | Recitation                             |                                          |

### <img src="assets/job_icons/WHM.png" height="20px" width="20px"> White Mage

| Gauges<img width="150" height="0"> | Buffs<img width="150" height="0"> | Migitation<img width="150" height="0"> | Icon Display<img width="150" height="0"> |
|------------------------------------|-----------------------------------|----------------------------------------|------------------------------------------|
| Dia                                |                                   | Temperance                             | Dia                                      |
|                                    |                                   | Benediction                            | Presence of Mind                         |
|                                    |                                   | Asylum                                 |                                          |

### <img src="assets/job_icons/AST.png" height="20px" width="20px"> Astrologian

| Gauges<img width="150" height="0"> | Buffs<img width="150" height="0"> | Migitation<img width="150" height="0"> | Icon Display<img width="150" height="0"> |
|------------------------------------|-----------------------------------|----------------------------------------|------------------------------------------|
| Combust                            | Cards                             | Netural Sect                           | Combust                                  |
| Upgraded Earthly Star              | Divination                        | Celestial Opposition                   | Lightspeed                               |
| Goring Blade                       |                                   | Collective Unconscious                 |                                          |
|                                    |                                   | Earthly Star                           |                                          |

### <img src="assets/job_icons/MNK.png" height="20px" width="20px"> Monk
+ **Gauges**: Twin Snakes, Demolish, Charges + time left on Riddle of Earth / True North
+ **Buffs**: Brotherhood, Riddle of Fire
+ **Mitigation**: Feint, Mantra,
+ **Icon Display**: Twin Snakes, Demolish, Riddle of Fire

### <img src="assets/job_icons/DRG.png" height="20px" width="20px"> Dragoon
+ **Gauges**: GCDS used in Lance Charge, GCDS used in Dragonsight, Charges + time left on True North
+ **Buffs**: Battle Litany, Dragonsight, Lance Charge
+ **Mitigation**: Feint
+ **Icon Display**: Dragonsight, Lance Charge, Disembowel, Chaos Thrust

### <img src="assets/job_icons/NIN.png" height="20px" width="20px"> Ninja
+ **Gauges**: GCDS used in Bunshin, Charges + time left on True North
+ **Buffs**: Trick Attack, Bunshin
+ **Mitigation**: Feint
+ **Icon Display**: Trick Attack

### <img src="assets/job_icons/SAM.png" height="20px" width="20px"> Samurai
+ **Gauges**: Jinpu, Shifu, Higanbana, Charges + time left on True North
+ **Buffs**: Double Midare
+ **Mitigation**: Feint
+ **Icon Display**: Jinpu, Shifu, Higanbana

### <img src="assets/job_icons/BRD.png" height="20px" width="20px"> Bard
+ **Gauges**: GCDS used in Raging Strikes, Caustic Bite, Stormbite
+ **Buffs**: Battle Voice, Raging Strikes, Barrage
+ **Mitigation**: Troubadour, Nature's Minne
+ **Icon Display**: Caustic Bite, Stormbite, Raging Strikes

### <img src="assets/job_icons/MCH.png" height="20px" width="20px"> Machinist
+ **Gauges**: GCDS used in Hypercharge, GCDS used in Wildfire, Charges of Ricochet, Charges of Gauss Round
+ **Buffs**: Wildfire, Reassemble
+ **Mitigation**: Tactician
+ **Icon Display**: Wildfire

### <img src="assets/job_icons/DNC.png" height="20px" width="20px"> Dancer
+ **Gauges**: Procs
+ **Buffs**: Technical Step, Devilment
+ **Mitigation**: Shield Samba, Improvisation
+ **Icon Display**: Devilment

### <img src="assets/job_icons/BLM.png" height="20px" width="20px"> Black Mage
+ **Gauges**: Thunder 3+4, Fire and Thunder procs
+ **Mitigation**: Addle
+ **Icon Display**: Thunder 3+4, Leylines, Sharpcast

### <img src="assets/job_icons/SMN.png" height="20px" width="20px"> Summoner
+ **Gauges**: Ruin 4, Bio, Miasma, Wyrmwave and Scarlet Flame
+ **Buffs**: Devotion, Summon Bahamut, Firebird Trance
+ **Mitigation**: Addle
+ **Icon Display**: Bio, Miasma

### <img src="assets/job_icons/RDM.png" height="20px" width="20px"> Red Mage
+ **Gauges**: GCDS used in Manification, Fire and Stone procs, Acceleration stacks
+ **Buffs**: Embolden, Manafication
+ **Mitigation**: Addle
+ **Icon Display**: Manafication

### <img src="assets/job_icons/BLU.png" height="20px" width="20px"> Blue Mage
+ **Gauges**: Song of Torment, Bad Breath, Condensed Libra
+ **Buffs**: Off-guard, Peculiar Light
+ **Mitigation**: Addle, Angel Whisper
+ **Icon Display**: Song of Torment, Bad Breath

## TODO
- [ ] Vertical gauges
- [ ] Custom text spacing
- [ ] Text above/below gauges
- [ ] Completely custom gauges/buffs/cds (requires big rework)
- [ ] Support crossbar better for icon replacement
- [ ] Hide based on level
- [ ] How many people got hit by buffs
- [ ] Split up party buffs and personal buffs
- [ ] SMN DoTs at 6 seconds [see this issue](https://github.com/0ceal0t/JobBars/issues/9)
- [x] ~~Support crossbar better for icon replacement~~
- [x] ~~Proc order changing~~
- [x] ~~GCD timer~~ (cursor)
- [x] ~~DoT tick timer / MP timer~~ (cursor)
- [x] ~~Add invert counter option to GCDs~~
- [x] ~~Better bar placement options~~
- [x] ~~Animate gauge movement~~ (kinda)
- [x] ~~Hide all gauges options~~
- [x] ~~Hide all buffs options~~
- [x] ~~MCH number of charges of Gauss Round / Richochet~~
- [x] ~~Track DoTs based on target~~
- [x] ~~AST upgraded star~~
- [x] ~~Move gauges independently~~
- [x] ~~Sound effect when DoTs are low~~
- [x] ~~Red text when DoTs are low~~
- [x] ~~Remove buffs on instance end~~
- [x] ~~Remove buffs on party change~~
- [x] ~~Dia messes up battle stance icon~~
- [x] ~~Border around buffs~~
