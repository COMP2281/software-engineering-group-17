## 1 - Introduction

### 1.1 - Overview and Justification

Our client is IBM, and our contact at IBM is Mr John McNamara. We have been tasked to reimagine Skills Build as an RPG game. This RPG game must facilitate accessing IBM Skills Build courses by linking the courses and its subsequent knowledge check questions, as well as reward users with in-game items (powerups and progression) if they are able to answer them. The game should also be fun and engaging to the user; it would be an amazing study tool integrated smoothly into an engaging RPG experience. However, the game does not need to teach the course content, but can refer to the courses from which the IBM Skills Build badges are obtained. This game is aimed to appeal to high school and university students, and hence should be accessible to people with little or no knowledge of Computer Science.

This document is the Requirement Specification for our RPG IBM Skills Build project. There are three parts to this document. The first part is the introduction, which gives a high-level description of the project, its scope, and domain area. The second part, the Solution Requirments, is the main part of the requirement specification. This part specifies the projects functional and non-functional requirements, and assess the risks/issues which may occur when undertaking the project. The third part describes our approach to the development of the game, as well as our time schedule in order to complete the project within the agreed deadline.

### 1.2 - Prokect Scope



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

| Title        | Windows                                |
| ------------ | --------------------------------------------------------------------- |
| Description  | Game should run on windows |
| Priority |                                                                       |
| MuShCo   | Must have                                                   |
| Dependencies |                                                                       |
| Expected results | |
| Exception handling | |

| Title        | Executable file |
| ------------ | --------------------------------------------------------------------- |
| Description  | An executable file that runs the full game |
| Priority | Low |
| MuShCo   | Must have |
| Dependencies | N/A |
| Expected results | After being run, the player should see a window popup, greeting them with the game's main menu |
| Exception handling | If the game cannot be run, an error code should pop up |

| Title        | Platforms                                      |
| ------------ | --------------------------------------------------------------------- |
| Description  | Game should be playable on mouse & keyboard as well as controller |
| Priority |                                                                       |
| MuShCo   | Should have                                                   |
| Dependencies |                                                                       |
| Expected results | |
| Exception handling | |

#### **Customization**

| Title        | Graphics for Colour Blind people                                      |
| ------------ | --------------------------------------------------------------------- |
| Description  | Graphics must be enjoyable to look at for people with colourblindness |
| Priority |                                                                       |
| MuShCo   | Must have                                                      |
| Dependencies |                                                                       |
| Expected results | |
| Exception handling | |

| Title        | Controls customization |
| ------------ | --------------------------------------------------------------------- |
| Description  | Player should be able to rebind controls |
| Priority |                                                                       |
| MuShCo   | Could have                                                   |
| Dependencies |                                                                       |
| Expected results | |
| Exception handling | |

#### **Gameplay**

| Title        | Player movement                                |
| ------------ | --------------------------------------------------------------------- |
| Description  | Player movement feels smooth |
| Priority |                                                                       |
| MuShCo   | Must have                                                   |
| Dependencies |                                                                       |
| Expected results | |
| Exception handling | |

| Title        | Game World                               |
| ------------ | --------------------------------------------------------------------- |
| Description  | Game world should feel alive |
| Priority |                                                                       |
| MuShCo   | Could have                                                   |
| Dependencies |                                                                       |
| Expected results | |
| Exception handling | |

| Title        | Room Transitions                               |
| ------------ | --------------------------------------------------------------------- |
| Description  | Transition between scenes should be smooth |
| Priority |                                                                       |
| MuShCo   | Should have                                                   |
| Dependencies |                                                                       |
| Expected results | |
| Exception handling | |

| Title        | Boss Battles                               |
| ------------ | --------------------------------------------------------------------- |
| Description  | Battle should engaging |
| Priority |                                                                       |
| MuShCo   | Should have                                                   |
| Dependencies |                                                                       |
| Expected results | |
| Exception handling | |

| Title        | Music                               |
| ------------ | --------------------------------------------------------------------- |
| Description  | Music should fit each area |
| Priority |                                                                       |
| MuShCo   | Should have                                                   |
| Dependencies |                                                                       |
| Expected results | |
| Exception handling | |

| Title        | Progression                             |
| ------------ | --------------------------------------------------------------------- |
| Description  | The game must have an aspect of progression where items are gained which benefits them |
| Priority |                                                                       |
| MuShCo   | Must have                                                      |
| Dependencies |                                                                       |
| Expected results | |
| Exception handling | |

### 2.3 - Risks and Issues
This section outlines our potential risks, how they could harm out project, and how we plan to mitigate these risks.
| Probability of Happening / Potential Consequences | Almost Impossible (1)| Not Likely (2) | Could Happen (3) | Known to Happen (4) |
| - | - | - | - | - |
| Insignificant (1) | 1 | 2 | 3 | 4 |
| Minor (2) | 2 | 4 | 6 (R4) | 8 |
| Moderate (3) | 3 | 6(R7) | 9 (R2) | 12 (R5) |
| Major (4) | 4 | 8 (R8) | 12 (R4,R1) | 16 (R3,R6) |

| Hazard | What is at Risk? | How could they be harmful? | Uncontrolled Risk Level | How to minimize the risks | Controlled Risk Level |
| - | - | - | - | - | - |
| R1 - Not being completed on time | Project timeline & client satisfaction | Delays result in missing milestones, which will disappoint the client | 12 | Implement a well-defined project schedule and closely monitor progress to deal with any issues that arise. | 6 |
| R2 - Group Dynamic | Team cohesion & project quality | Group not getting along could cause arguments, lower quality product, and delays | 9 | Establish clear roles and responsibilities, address issues promptly | 4 |
| R3 - Lack of Group’s Technical Knowledge | Project Quality and Timeline | Insufficient knowledge can lead to inability to meet project requirements | 16 | Identify where knowledge is lacking, and spend time training members in skill gaps | 9 |
| R4 - Scope Creep (uncontrolled expansion of project) | Project timeline | Project not completed on time due to base features not being completed, leading to an unhappy client | 6 | Define project scope clearly, use agile methodology to mean that we only start expanding once the base is complete | 4 |
| R5 - Team Member Drops out or is Unavailable | Group Members & project timeline | Group members have more work, if said group member is a key member who knows how to use a technology then we will have delays or compromise on quality | 12 | Cross Train team members, or have backup plans | 6 |
| R5 - Poor User Feedback | User Acceptance & Client Happiness | Failing to create a positive user experience is essentially a huge problem, as our game should be fun to play | 9 | Conduct occasional user testing and gather feedback | 4 |
| R6 - Requirements Change | Project scope & timeline | Will have to go back and change content, potentially from a fundamental level | 16 | Document and manage project requirements, make the game flexibly so that we can change things if needed | 8 |
| R7 - Hardware Compatibility | Game performance or accessibility | Poor performance or being unable to play on systems it is supposed to be compatible with is a major issue | 6 | Test on a number of platforms and hardware configurations | 2 |
| R8 - Legal and Copyright Issues | IBM & our artist | New sprites will have to made in the event that our current ideas for sprites causes issues | 8 | Instead of making sprite edits of other games, make new sprites based of sprites or 3d models | 3 |
## 3 - Project Development

### 3.1 - Development Approach

### 3.2 - Project Schedule

Add gantt chart
