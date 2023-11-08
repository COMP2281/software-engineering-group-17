## 1 - Introduction

### 1.1 - Overview and Justification

Our client is IBM, and our contact at IBM is Mr John McNamara. We have been tasked to reimagine Skills Build as an RPG game. This RPG game must facilitate accessing IBM Skills Build courses by linking the courses and its subsequent knowledge check questions, as well as reward users with in-game items (powerups and progression) if they are able to answer them. The game should also be fun and engaging to the user; it would be an amazing study tool integrated smoothly into an engaging RPG experience. However, the game does not need to teach the course content, but can refer to the courses from which the IBM Skills Build badges are obtained. This game is aimed to appeal to high school and university students, and hence should be accessible to people with little or no knowledge of Computer Science.

This document is the Requirement Specification for our RPG IBM Skills Build project. There are three parts to this document. The first part is the introduction, which gives a high-level description of the project, its scope, and domain area. The second part, the Solution Requirments, is the main part of the requirement specification. This part specifies the projects functional and non-functional requirements, and assess the risks/issues which may occur when undertaking the project. The third part describes our approach to the development of the game, as well as our time schedule in order to complete the project within the agreed deadline.

### 1.2 - Project Scope

### 1.3 - System Description

The system the team came up with to solves IBM's SkillBuild website problem is the creation of an educational 2D RPG game featuring questions from IBM's SkillsBuild website. These questions will be at the forefront of the game and required to be solved by the player in order to progress. In order to solve these questions, the player must complete room puzzles to progress. Each course on the SkillBuild website will be represented by an area in the game and puzzles will have a different theme for each area. Furthermore, each area of the game will feature an area boss, which tests the player with more challenging questions through combat. The combat will be inspired by the Phoenix Wright games and the answer menu for the questions will be a dynamic list, due to having a non-even number of questions. Combat will also include an extra element of risk, involving a health system, where the player has hearts which are removed when answering a question wrong. Run out of heart and you restart the entire fight. The hearts will be modeled after the ones in games such as Minecraft and Hollow Knight. The player will also have access to a skill tree, where they can alter combat to fit their play-style by choosing power-ups after each defeated boss. All areas of the game will be linked with a hub world, where the player can choose which area to enter in any order they please. The game will include original character sprites based on sprites from the Pokemon games and during boss combat, combat sprites will be based on sprites from the Pheonix Wright games.

Our team did a plethora of research to support our decision on the above mentioned system. Firstly, the focus on the entire game needs to be on the questions, as specified by the client, so the team wanted gameplay to support this idea. This is why the team came up with the idea of puzzles and combat, as these forms of gameplay enable us to build questions into them. The combat being based on Phoenix Wright was chosen due to the debates in that game being a fitting template for combat based on questions. It also allows for easy incorporation of the menu the team chose, being a list of possible answers, especially due to the varying lengths of answers. The health system being hearts instead of a health bar was chosen due to the fact that answering a question wrong will always deal the same amount of damage and visually representing this is easier in heart format. This reason is the same as to why Hollow Knight uses hearts, so we based it of that. The character sprites were also heavily researched and the team chosen to appropriate the Pokemon player sprites, due to their moderate complexity and 2.5D view models. This allows our rookie artist enough freedom to create sprites of moderate complexity and not have the worry about creating masterpieces. 

The game engine our team decided to work on is Unity, as some of us already have experience in it and Unity has a built in 2D build template, which enables users more freedom when creating 2D environments. We chose not to use RPG Maker, even though the tools is incredibly useful for making RPGs due to the engines limitations: RPG maker is incredibly user friendly, but offers little for more advanced users wanting to implement new features. Writing code is difficult due to the fact that, even though the engine does support it, it is not a direct feature of the engine, so users have to create code on a separate developing environment, then import the created code into RPG maker. Consequently, our team did not want to use RPG maker, as the team wanted to write code in our game. Another game engine researched by the team was Unreal Engine. This engine was quickly dismissed for the same reason RPG maker was: Code. Even though Unreal Engine does support code writing and has its own independent development environment, it uses C++, which is a language unfamiliar to our team. This itself wouldn't be a problem, but there is not much documentation on how to use C++ with Unreal Engine and there are also not many tutorials by Unreal Engine users on C++ either. Furthermore, there Unreal Engine is known for making visually stunning 3D games, with state of the art lighting and graphics, which are features we will not need for our simple 2D RPG. So we decided against using Unreal Engine. 


(add links to markdown reasearch file)
## 2 - Solution Requirements

This part of the document has three sections - functional requirements, non-functional requirements and risks/issues.

Add UML Diagram here

### 2.1 - Function Requirements

#### **Player**

| Title        | Player Character |
| ------------ | --------------------------------------------------------------------- |
| Description  | Main playable character which the game centers around |
| Priority | High |
| MuShCo   | Must have |
| Dependencies | Controls |
| Expected results | Character should have distinct/unique sprite both in and out of battle |

| Title        | Player Character Movement |
| ------------ | --------------------------------------------------------------------- |
| Description  | Buttons which allows the player character to move in any direction |
| Priority | High |
| MuShCo   | Must have |
| Dependencies | Player Character, Camera |
| Expected results | Player character should be able to move in the four cardinal directions and diagonally with either WASD or the arrow keys (holding a combination of two keys, say W and A, would make the player move diagonally up and left)|

| Title        | Control |
| ------------ | --------------------------------------------------------------------- |
| Description  | Buttons which allows the player to interact with both the game entities (items/characters) and the menu |
| Priority | High |
| MuShCo   | Must have |
| Dependencies | N/A |
| Expected results | There should be at least two buttons like that of the old gameboy. [A] generally for accept, and [B] generally for cancel |

| Title        | Camera |
| ------------ | --------------------------------------------------------------------- |
| Description  | A camera that is able to track the player character, and move around a room |
| Priority | High |
| MuShCo   | Must have |
| Dependencies | Player Character |
| Expected results | This is the main tool to display the game. Most of the time, the camera will be centered on the player character, but it can be used to pan around a room |

| Title        | Collisons |
| ------------ | --------------------------------------------------------------------- |
| Description  | Checks that makes sure the player cannot go through walls/closed doors and makes sure the player does not get stuck on tiles |
| Priority | High |
| MuShCo   | Must have |
| Dependencies | Controls |
| Expected results | Player character should not be able to move from a ground tile to a wall or closed door tile |
| Exception handling | If character goes out of bound, they should be placed back at the room entrance |

#### **Menus & Menu Items**

| Title        | Main Menu |
| ------------ | --------------------------------------------------------------------- |
| Description  | A menu which is opened at after launching the game |
| Priority | Low |
| MuShCo   | Must have |
| Dependencies | N/A |
| Expected results | The menu should have the game title on top, a background, and buttons. Contains buttons to: Make a new game, continue an ongoing session, open the options, quit and close the game window |

| Title        | Pause Menu |
| ------------ | --------------------------------------------------------------------- |
| Description  | A menu which pauses the game when opened |
| Priority | Low |
| MuShCo   | Must have |
| Dependencies | Controls, Inventory, Manual Saving, Options Menu, Quit |
| Expected results | After pressing the [Esc] button, a menu should open up. When this menu is open, all entities and events should be paused. This menu contains buttons to: Access the inventory, save the game, open the options menu, or quit (to the main menu or to the desktop) |

| Title        | Options Menu |
| ------------ | --------------------------------------------------------------------- |
| Description  | An options menu where the player can change their game settings |
| Priority |  |
| MuShCo   | Should have |
| Dependencies | Controls, Sound Effects, Music |
| Expected results | The player should be able to change the following aspects: Volume, colour blind settings, resolution, full screen, and controls |

| Title        | Quit |
| ------------ | --------------------------------------------------------------------- |
| Description  | A button which allows the player to either quit to the main menu or desktop |
| Priority | Low |
| MuShCo   | Must have |
| Dependencies | Main Menu |
| Expected results | This button only presents two choices when pressed in the pause menu. In the main screen, it automatically quits to the desktop. Maybe the button should also ask the player if they want to save their game by warning them that they will lose any unsaved progress |

| Title        | Manual Saving |
| ------------ | --------------------------------------------------------------------- |
| Description  | A button to save the player's progress at any point in the game |
| Priority | Low |
| MuShCo   | Must have |
| Dependencies | N/A |
| Expected results | In the  |
| Exception handling | If the save failed, the player should be notified and asked if they want to save again |

| Title        | Auto-Saving |
| ------------ | --------------------------------------------------------------------- |
| Description  | Automatic saving feature |
| Priority | Low |
| MuShCo   | Should have |
| Dependencies | Manual Saving |
| Expected results | Every room transition will save the game. This is in case the player forgets to save so no progress is lost |
| Exception handling | If the save failed, the player should be notified that their automatic save could not be done |

| Title        | Inventory |
| ------------ | --------------------------------------------------------------------- |
| Description  | A menu where the player can see all their currently collected items |
| Priority | Low |
| MuShCo   | Must have |
| Dependencies | Skill Build System |
| Expected results | A menu that shows the player their current items and their descriptions. Perhaps this menu can also display the other items the player can get, but shade them out if the player has not gotten them yet. The player cannot read the descriptions of shaded items. This menu also shows the player their skill build |

#### **Game Systems**

| Title        | Health System |
| ------------ | --------------------------------------------------------------------- |
| Description  | A health bar that shows the player's and enemies' life points |
| Priority | Low |
| MuShCo   | Must have |
| Dependencies | Damage System |
| Expected results | A (decorated) bar which depicts the health of an entity. Once this reaches zero, the entity should die. It should show the current health, and the maximum health |

| Title        | Damage System |
| ------------ | --------------------------------------------------------------------- |
| Description  | A value which dictates how much health the player and enemies loses if attacked |
| Priority | Low |
| MuShCo   | Must have |
| Dependencies | Health System |
| Expected results | A numerical value which both the player character and enemies has. If an entity is hit by an attack of damage [n], they should lose [n] health points |

| Title        | Skill Build System |
| ------------ | --------------------------------------------------------------------- |
| Description  | A system which permanently upgrades the player character as the game progresses |
| Priority | low |
| MuShCo   | Must have |
| Dependencies | Health System, Damage System, Worlds |
| Expected results | A skill tree which has nodes that provides various benefits, like giving the player more health or attack. After finishing a world, the skill associated with that world unlocks |

#### **Gameplay**

| Title        | Central Hub |
| ------------ | --------------------------------------------------------------------- |
| Description | A central hub world where the player can access other world |
| Priority | Medium |
| MuShCo   | Should have |
| Dependencies | Doors |
| Expected results | The player can, from the hub world, access all the main worlds in any order. This place will be more fleshed out compared to other place since the player will return here a lot |

| Title        | Worlds |
| ------------ | --------------------------------------------------------------------- |
| Description  | The different realms where the game takes place. Each world contains many rooms |
| Priority | Medium |
| MuShCo   | Must have |
| Dependencies | Central Hub, Puzzles, Rooms |
| Expected results | At least five main worlds, each with their own puzzle style accessible through the central hub. Each world represents a Skills Build course |

| Title        | Doors |
| ------------ | --------------------------------------------------------------------- |
| Description  | A tile which the player go through and move to another room |
| Priority | Medium |
| MuShCo   | Must have |
| Dependencies | N/A |
| Expected results | Each world should have doors which the player must solve a problem / beat a boss in order to open. Some doors are just open by default (like the ones in the hub world) |

| Title        | Rooms |
| ------------ | --------------------------------------------------------------------- |
| Description  | A room that contains a puzzle |
| Priority | High |
| MuShCo   | Must have |
| Dependencies | Doors |
| Expected results | A room has at least one entrance, and can have none or multiple exits. The room size can be from one screen to multiple screens. After entering through a door, the player character is placed right outside the door of another room |

| Title        | Puzzles |
| ------------ | --------------------------------------------------------------------- |
| Description  | Themed minigames |
| Priority | Medium |
| MuShCo   | Must have |
| Dependencies | Multiple Choice Questions, Rooms |
| Expected results | Puzzles have a theme in each world. Most puzzles will be a multiple choice question disguised as a minigame |
| Exception handling | Some puzzles will require a reset button, which restores the state of the room its in to how it originaly was |

| Title        | Multiple Choice Question |
| ------------ | --------------------------------------------------------------------- |
| Description  | Questions from a Skills Build course which the player must answer |
| Priority | Medium |
| MuShCo   | Must have |
| Dependencies | N/A | 
| Expected results | Questions are taken from the Skills Build quizzes. Some are multiple choice, others are typed in answers |

| Title        | Boss Fight |
| ------------ | --------------------------------------------------------------------- |
| Description  | Fights where the player has to correctly answer an enemy's questions |
| Priority | Low |
| MuShCo   | Must have |
| Dependencies | Health System, Damage System |
| Expected results | Both the player and the boss has a health bar. If the player answers a question correctly, they get to attack the boss. If they dont answer correctly, they get hit by the boss |
| Exception handling | If the fight lasts long enough, there will not be enough unique questions to ask the player. To prevent this happening, questions can be reused after all other questions gets exausted |

| Title        | Boss Questions |
| ------------ | --------------------------------------------------------------------- |
| Description  | Boss must include questions from its own world |
| Priority | Low |
| MuShCo   | Should have |
| Dependencies | Multiple Choice Question |
| Expected results | Bosses can ask any questions from the previous puzzles, and maybe more, in their respective world. The final boss should be able to ask questions from any of the other worlds |

#### **Audio**

| Title        | SFX |
| ------------ | --------------------------------------------------------------------- |
| Description  | Sound effects for some actions, such as room transitions |
| Priority | Low |
| MuShCo   | Could have |
| Dependencies | N/A |
| Expected results | Sounds should be made for most of the common actions, like opening menu, or attack an enemy, or walking through a room |

| Title        | Music |
| ------------ | --------------------------------------------------------------------- |
| Description  | Background music for the game, and combat music for fights |
| Priority | Low |
| MuShCo   | Could have |
| Dependencies | N/A |
| Expected results | Music which loops indefinitely. If possible, this music should change depending on the world the player is in, and whether they are in combat or not |


### 2.2 - Non-Functional Requirements

#### **Playability**

| ID and Title | NFR1.1 - Windows                                |
| ------------ | --------------------------------------------------------------------- |
| Type | Compatibality |
| Metrics | Game should be able to run on windows 10 and 11 |

| ID and Title | NFR1.2 - Executable file |
| ------------ | --------------------------------------------------------------------- |
| Type  | Usability |
| Metric | The game can be launched by running a single executable file |

| ID and Title | NFR1.3 - Platforms                                      |
| ------------ | --------------------------------------------------------------------- |
| Type | Usability |
| Metric | Game should be playable on mouse & keyboard as well as controller |


#### **Customization**

| ID and Title | NFR2.1 - Graphics                                                      |
| ------------ | --------------------------------------------------------------------- |
| Type  | Usability |
| Metric | Graphics abide by the Game Accessibility Guidelines so the game is enjoyable for users suffering from colourblindness |


#### **Gameplay**

| ID and Title  | NFR3.1 - Response Time                              |
| ------------ | --------------------------------------------------------------------- |
| Type | Performance |
| Metrics  | There should be less than 0.1 seconds of delay between pressing the movement/interacting keys and the player moving/interacting |

| ID and Title | NFR 3.2 - Smooth Movement |
| ------------ | --------------------------------------------------------------------- |
| Type | User Experience |
| Metrics  | Movement speed and animation should be such that the movement feel natural |

| ID and Title | NFR 3.3 - Beginner Friendly                               |
| ------------ | --------------------------------------------------------------------- |
| Type         | Usability |
| Metric | Game and UI should be intuitive to use even for people who have not played games |

| ID and Title        | NFR 3.4 - Room Transitions                               |
| ------------ | --------------------------------------------------------------------- |
| Type         | Performance |
| Metric | Transition between scenes should be smooth - there should be no more than an x second delay when moving to another room |

| ID and Title        | NFR 3.5 - Boss Battles                               |
| ------------ | --------------------------------------------------------------------- |
| Type | User Experience |
| Metric | Battle should feel engaging to the user |


| ID and Title        | NFR 3.6 Music                               |
| ------------ | --------------------------------------------------------------------- |
| Type | User Experience |
| Metric | Music should fit each area |

| ID and Title        | NFR 3.7 Progression                             |
| ------------ | --------------------------------------------------------------------- |
| Type | User Experience |
| Metric  | The game must have an aspect of progression where items are gained which benefits them |

### 2.3 - Risks and Issues

## 3 - Project Development

### 3.1 - Development Approach

### 3.2 - Project Schedule

Add gantt chart