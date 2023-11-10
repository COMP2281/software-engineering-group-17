## 1 - Introduction

### 1.1 - Overview and Justification

Our client is IBM, and our contact at IBM is Mr John McNamara. We have been tasked to reimagine Skills Build as an RPG game. This RPG game must facilitate accessing IBM Skills Build courses by linking the courses and its subsequent knowledge check questions, as well as reward users with in-game items (powerups and progression) if they are able to answer them. 

The game should also be fun and engaging to the user; it would be an amazing study tool integrated smoothly into an engaging RPG experience. However, the game does not need to teach the course content, but can refer to the courses from which the IBM Skills Build badges are obtained. This game is aimed to appeal to high school and university students, and hence should be accessible to people with little or no knowledge of Computer Science.

This document is the Requirement Specification for our RPG IBM Skills Build project. There are three parts to this document. The first part is the introduction, which gives a high-level description of the project, its scope, and domain area. The second part, the Solution Requirments, is the main part of the requirement specification. This part specifies the projects functional and non-functional requirements, and assess the risks/issues which may occur when undertaking the project. The third part describes our approach to the development of the game, as well as our time schedule in order to complete the project within the agreed deadline.

### 1.2 - Project Scope

<div style="page-break-after: always;"></div>

### 1.3 - System Description

#### Our proposed System

Our proposed solution to IBM's Skill Build Website issue is the creation of an educational 2D RPG game, featuring questions from the copanies Skill Build website. These questions will be at the forefront of the game and will allow the player to progress through play, when answered correctly. Each Skill Build website course will be represented by an area in the game and each area will feature puzzles and an area boss, which will pose questions to the player. Combat will introduce a further element of risk, in the form of a health system which deducts a heart from a player on answering a question incorrectly. Loss of all hearts results in the player restarting the entire fight. A skill tree will enable the player to alter combat to suit their playstyle, by choosing powerups after defeeting each boss. All areas will be linked by a hub world, allowing the player to select an area in which to enter, in any order they please.

| Key aspect of the Game | Research | Justification |
| - | - | - | 
|Character Sprites | Inspired by sprites from Pokemon games | Moderate complexity and 2.5D view models allow our rookie artist enough freedom to create sprites of moderate complexity |
|Combat|Inspired by Phoenix Wright games| Debates in Phoenix Wright provide a fitting template for combat based on questions|
|Questions|To be introduced through combat and puzzles| These forms of gameplay enable us to build questions into them easily|
|Combat Menu|Dynamic list|Easy incorporation with the chosen combat style|
|Health system|Based on Minecraft and Hollow Knight| An incorrect answer to a question will always generate the same amount of damage. This is easily represnted in a heart format|

#### Existing Solutions

> **Mario is Missing (by Nintendo)**
>
> **Description:** The educationl game, Mario is Missing, challenges the player to save global landmarks stolen by Bowser. By learning about geography from non playable characters (NPC's) the player is able to identify and return the landmarks to their correct geographical location | The game acts as an  educational tool by improving the players geographical knowledge through exploration of locations.
>
> **Advantage:** The game acts as an educational tool by improving the players geographical knowledge through exploration of locations.
>
> **Disadvantage:** As the games target audience is children, it is extremely easy. Furthermore, the answering of questions during play is not mandatory and so the educational aspect of the game can be avoided.
>
> **Use for our System:** Negative reviews suggest the gameplay cycle of finding landmarks to be tedious and the questions unnecessary. Our game should contain essential questions with other gameplay elements to engage players.



> **Minecraft Education (by Microsoft)**
>
> **Description:** Minecraft Education enables students to engage with lessons created by teachers in Minecraft which focused on academic subjects.
>
> **Advantage:** The game facilitates learning through fun interactive classees. Learning is at the forefront of the game and knowledge gained can be directly applied to non gaming environments.
>
> **Disadvantage:** Players familiar with Minecraft will feel frustrated, as many core gameplay features are limited to facilitate learning.
>
> **Use for our System:** Players of our game who know the answers to all questions should be able to complete the game more quickly, but the game should still have interactive puzzles to engage players.


> **Mario and Sonic at the Olympic Winter Games 2010 DS (by Nintendo and Sega)**
>
> **Description:** Bowser and Dr. Eggman have imprisoned the Snow Spirits to sabotage the Olympic Winter Games and Mario and Sonic must save them. The educational aspect of the game is delivered through Winter Olympic themed trivia scatterdd around the game world.
>
> **Advantage:** The trivia notes, which are location specific, are hidden around the world and so well integrated into the game. The player is rewarded for finding the information, with completionist badges.
>
> **Disadvantage:** The game is not focused on these trivia notes, rather they are an additional feature, which although do give the player a badge, does not facilitate progression: They are a side quest.
>
> **Use for our System:** Our game should reward the player for answering questions correctly and enable progression. Without correctly answering the questions, the player should not be able to progress. The questions asked should fit the environment of the game.

(add links to markdown reasearch file)
## 2 - Solution Requirements

This part of the document has three sections - functional requirements, non-functional requirements and risks/issues.

Add UML Diagram here

### 2.1 - Function Requirements

#### **Player-Based system**

| ID, Type, Title | FR1.1 - Player-Based system - Player Character |
| ------------ | --------------------------------------------------------------------- |
| Description  | Main playable character which the game centers around, which should be a student (user) stand-in |
| Priority | High |
| MuShCo   | Must have |
| Dependencies | N/A |
| Expected results | Character should have distinct/unique sprite both in and out of battle (small zoomed out model out of battle, portrait outside) |
| Exception handling | If a sprite cannot be loaded, character sprite will be a placeholder |

| ID, Type, Title | FR1.2 - Player-Based system - Player Character Movement |
| ------------ | --------------------------------------------------------------------- |
| Description  | Buttons which allows the player character to move in any direction (even though the stages are built within a grid) |
| Priority | High |
| MuShCo   | Must have |
| Dependencies | FR1.1, FR2.8 |
| Expected results | Player character should be able to move in the four cardinal directions and diagonally with either WASD, the arrow keys (holding a combination of two keys, say W and A, would make the player move diagonally up and left) or via controller |
| Exception handling | If the player gets stuck on a tile, they should be able to wiggle out and free themselves either by mashing all directions or holding one direction |

| ID, Type, Title | FR1.3 - Player-Based system - Controls |
| ------------ | --------------------------------------------------------------------- |
| Description  | Buttons which allows the player to interact with both the game entities (items/characters) and the menu |
| Priority | High |
| MuShCo   | Must have |
| Dependencies | N/A |
| Expected results | There should be at least two buttons like that of the old gameboy. [A] generally for accept, and [B] generally for cancel. If a player character is between two game objects, the one they are closer two should be the one being interacted with |
| Exception handling | N/A |

| ID, Type, Title | FR1.4 - Player-Based system - Collisons |
| ------------ | --------------------------------------------------------------------- |
| Description  | Checks that makes sure the player cannot go through walls, closed door, or occupied tiles |
| Priority | High |
| MuShCo   | Must have |
| Dependencies | FR1.2 |
| Expected results | Player character should not be able to move from a ground tile to a wall or closed door tile |
| Exception handling | If character goes out of bound, they should be placed back at the room entrance |

#### **Game System**

| ID, Type, Title | FR2.1 - Game System - Main Menu |
| ------------ | --------------------------------------------------------------------- |
| Description  | A menu which is opened at after launching the game |
| Priority | Low |
| MuShCo   | Must have |
| Dependencies | N/A |
| Expected results | The menu should have the game ID, Type, title, a background, and buttons. Contains buttons to: Make a new game, continue an ongoing session, open the options, quit and close the game window |
| Exception handling | N/A |

| ID, Type, Title | FR2.2 - Game System - Pause Menu |
| ------------ | --------------------------------------------------------------------- |
| Description  | A menu which pauses the game when opened |
| Priority | Low |
| MuShCo   | Must have |
| Dependencies | FR1.3, FR2.7, FR2.5, FR2.3, FR2.4 |
| Expected results | After pressing the [Esc] button, a menu should open up. When this menu is open, all entities and events should be paused. This menu contains buttons to: Access the inventory, save the game, open the options menu, or quit (to the main menu or to the desktop) |
| Exception handling | If opened during a timed event, the menu should not open |

| ID, Type, Title | FR2.3 - Game System - Options Menu |
| ------------ | --------------------------------------------------------------------- |
| Description  | An options menu where the player can change their game settings |
| Priority |  |
| MuShCo   | Should have |
| Dependencies | N/A |
| Expected results | The user should be able to change the following aspects: Volume, colour blind settings, resolution and full screen |
| Exception handling | After changing resolution, a user might not be able to press the revert button. A solution could be to make sure the user presses confirm within 15s, otherwise the setting is reverted |

| ID, Type, Title | FR2.4 - Game System - Quit |
| ------------ | --------------------------------------------------------------------- |
| Description  | A button which allows the player to either quit to the main menu or desktop |
| Priority | Low |
| MuShCo   | Must have |
| Dependencies | FR2.1, FR2.2, FR2.5 |
| Expected results | This button only presents two choices when pressed in the pause menu. In the main screen, it automatically quits to the desktop. Maybe the button should also ask the user if they want to save their game by warning them that they will lose any unsaved progress |
| Exception handling | N/A |

| ID, Type, Title | FR2.5 - Game System - Manual Saving |
| ------------ | --------------------------------------------------------------------- |
| Description  | A button to save the player's progress at any point in the game |
| Priority | Low |
| MuShCo   | Must have |
| Dependencies | N/A |
| Expected results | In the case that the user wants to take a break, or wants to go on Skills Build to learn about the topic, they should be able to save their progress in case they did something wrong, or in case the game crashes and be able to load back their save file |
| Exception handling | If the save failed, the user should be notified and asked if they want to save again |

| ID, Type, Title | FR2.6 - Game System - Auto-Saving |
| ------------ | --------------------------------------------------------------------- |
| Description  | Automatic saving feature |
| Priority | Low |
| MuShCo   | Should have |
| Dependencies | FR2.5 |
| Expected results | Every room transition will save the game. This is in case the player forgets to save so no progress is lost |
| Exception handling | If the save failed, the user should be notified that their automatic save could not be done |

| ID, Type, Title | FR2.7 - Game System - Inventory |
| ------------ | --------------------------------------------------------------------- |
| Description  | A menu where the player can see all their currently collected items |
| Priority | Low |
| MuShCo   | Must have |
| Dependencies | FR3.3 |
| Expected results | A menu that shows the user their current items and their descriptions. Perhaps this menu can also display the other items the user can get, but shade them out if the user has not gotten them yet. The user cannot read the descriptions of shaded items. This menu also shows the user their Skills Build |
| Exception handling | N/A |

| ID, Type, Title | FR2.8 - Game System - Camera |
| ------------ | --------------------------------------------------------------------- |
| Description  | A camera that is able to track the player character, and move around a room |
| Priority | High |
| MuShCo   | Must have |
| Dependencies | FR1.1 |
| Expected results | This is the main tool to display the game. Most of the time, the camera will be centered on the player character, but it can be used to pan around a room |
| Exception handling | In the rare case that the camera is not centered around the player character, there should be a button (in the pause menu) to center the camera. Only implement if the camera gets stuck frequently |

#### **Gameplay Systems**

| ID, Type, Title | FR3.1 - Gameplay Systems - Health System |
| ------------ | --------------------------------------------------------------------- |
| Description  | A health bar that shows the player character's and enemies' life points |
| Priority | Low |
| MuShCo   | Must have |
| Dependencies | FR3.2 (Co-dependencies) |
| Expected results | A (decorated) bar which depicts the health of an entity. Once this reaches zero, the entity should die. It should show the current health, and the maximum health |
| Exception handling | If the player character somehow stays alive with negative health, they should lose at the start of their next action |

| ID, Type, Title | FR3.2 - Gameplay Systems - Damage System |
| ------------ | --------------------------------------------------------------------- |
| Description  | A value which dictates how much health the player character and enemies loses if attacked |
| Priority | Low |
| MuShCo   | Must have |
| Dependencies | FR3.1 (Co-dependencies) |
| Expected results | A numerical value which both the player character and enemies has. If an entity is hit by an attack of damage [n], they should lose [n] health points |
| Exception handling | The minimum damage dealt should be 1, so even if the player character deals less than 1 damage, they still have a way to win the fight |

| ID, Type, Title | FR3.3 - Gameplay Systems - Skills Build System |
| ------------ | --------------------------------------------------------------------- |
| Description  | A system which permanently upgrades the player character as the game progresses. Can be accessed through a menu |
| Priority | low |
| MuShCo   | Must have |
| Dependencies | FR3.1, FR3.2 |
| Expected results | A skill tree which has nodes that provides various benefits, like giving the player character more health or attack. After finishing a world, the skill associated with that world unlocks. Nodes can be activated by spending skill points/ or acquiring unique items |
| Exception handling | If the player somehow has negative skill points, they should not be able to quit the Skills Build menu |

#### **Gameplay**

| ID, Type, Title | FR4.1 - Gameplay - Central Hub |
| ------------ | --------------------------------------------------------------------- |
| Description | A central hub world where the user can access other world |
| Priority | Medium |
| MuShCo   | Should have |
| Dependencies | FR4.3 |
| Expected results | The user can, from the hub world, access all the main worlds in any order. This place will be more fleshed out compared to other place since the user will return here a lot |
| Exception handling | N/A |

| ID, Type, Title | FR4.2 - Gameplay - Worlds |
| ------------ | --------------------------------------------------------------------- |
| Description  | The different realms where the game takes place. Each world contains many rooms |
| Priority | Medium |
| MuShCo   | Must have |
| Dependencies | FR4.5, FR4.4 |
| Expected results | At least five main worlds, each with their own puzzle style accessible through the central hub. Each world represents a Skills Build course |
| Exception handling | N/A |

| ID, Type, Title | FR4.3 - Gameplay - Doors |
| ------------ | --------------------------------------------------------------------- |
| Description  | A tile which the player character go through and move to another room |
| Priority | Medium |
| MuShCo   | Must have |
| Dependencies | N/A |
| Expected results | Each world should have doors which the user must solve a problem / beat a boss in order to open. Some doors are just open by default (like the ones in the hub world) |
| Exception handling | N/A |

| ID, Type, Title | FR4.4 - Gameplay - Rooms |
| ------------ | --------------------------------------------------------------------- |
| Description  | A room that contains a puzzle |
| Priority | High |
| MuShCo   | Must have |
| Dependencies | FR4.3 |
| Expected results | A room has at least one entrance, and can have none or multiple exits. The room size can be from one screen to multiple screens. After entering through a door, the player character is placed right outside the door of another room |
| Exception handling | N/A |

| ID, Type, Title | FR4.5 - Gameplay - Puzzles |
| ------------ | --------------------------------------------------------------------- |
| Description  | Themed minigames |
| Priority | Medium |
| MuShCo   | Must have |
| Dependencies | FR4.4, FR4.6 |
| Expected results | Puzzles have a theme in each world. Most puzzles will be a multiple choice question disguised as a minigame |
| Exception handling | Some puzzles will require a reset button, which restores the state of the room its in to how it originaly was |

| ID, Type, Title | FR4.6 - Gameplay - Multiple Choice Question |
| ------------ | --------------------------------------------------------------------- |
| Description  | Questions from a Skills Build course which the user must answer |
| Priority | Medium |
| MuShCo   | Must have |
| Dependencies | N/A | 
| Expected results | Questions are taken from the Skills Build quizzes. Some are multiple choice, others are typed in answers |
| Exception handling | N/A |

| ID, Type, Title | FR4.7 - Gameplay - Boss Fight |
| ------------ | --------------------------------------------------------------------- |
| Description  | Fights where the user has to correctly answer questions from the world its in |
| Priority | Low |
| MuShCo   | Must have |
| Dependencies | FR3.1, FR3.2, FR4.6 |
| Expected results | Both the player character and the boss has a health bar. If the user answers a question correctly, they get to attack the boss. If they dont answer correctly, they get hit by the boss. Bosses can ask any questions from the previous puzzles, and maybe more, in their respective world. The final boss should be able to ask questions from any of the other worlds |
| Exception handling | If the fight lasts long enough, there will not be enough unique questions to ask the user. To prevent this happening, questions can be reused after all other questions gets exausted |

#### **Audio**

| ID, Type, Title | FR5.1 - Audio - SFX |
| ------------ | --------------------------------------------------------------------- |
| Description  | Sound effects for some actions, such as room transitions |
| Priority | Low |
| MuShCo   | Could have |
| Dependencies | N/A |
| Expected results | Sounds should be made for most of the common actions, like opening menu, or attack an enemy, or walking through a room |
| Exception handling | N/A |

| ID, Type, Title | FR5.2 - Audio - Music |
| ------------ | --------------------------------------------------------------------- |
| Description  | Background music for the game, and combat music for fights |
| Priority | Low |
| MuShCo   | Could have |
| Dependencies | N/A |
| Expected results | Music which loops indefinitely. If possible, this music should change depending on the world the user is in, and whether they are in combat or not |
| Exception handling | N/A |

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