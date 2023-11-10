## 1 - Introduction

### 1.1 - Overview and Justification

Our client is IBM, and our contact at IBM is Mr John McNamara. We have been tasked to reimagine Skills Build as an RPG game. This RPG game must facilitate accessing IBM Skills Build courses by linking the courses and its subsequent knowledge check questions, as well as reward users with in-game items (powerups and progression) if they are able to answer them. 

The game should also be fun and engaging to the user; it would be an amazing study tool integrated smoothly into an engaging RPG experience. However, the game does not need to teach the course content, but can refer to the courses from which the IBM Skills Build badges are obtained. This game is aimed to appeal to high school and university students, and hence should be accessible to people with little or no knowledge of Computer Science.

This document is the Requirement Specification for our RPG IBM Skills Build project. There are three parts to this document. The first part is the introduction, which gives a high-level description of the project, its scope, and domain area. The second part, the Solution Requirments, is the main part of the requirement specification. This part specifies the projects functional and non-functional requirements, and assess the risks/issues which may occur when undertaking the project. The third part describes our approach to the development of the game, as well as our time schedule in order to complete the project within the agreed deadline.

### 1.2 - Project Scope
The goal of our project is to create an RPG game to reimagine Skills Build, IBM's platform to provide people with job skills, courses and credentials. The purpose of this project is to make Skills Build easier to navigate and make it more interactive so that it increases receptiveness for students. The base of our game is a hub world with areas corresponding to different courses, each area would have a boss that would be the center of combat gameplay. Upon choosing an area the player will have to complete puzzles and combat that havecourse questions as the core. This will allow them to progress further. A health system also comes into play with combat themed games, whereby running out of hearts would result in restarting the fight, this would be somewhat similar to quiz questions in courses where achieving a score less than 80% would require you to take it again.

This game aims to address the problem of accessibility for people with little to no knowledge of Computer Science. It resolves this problem by creating puzzles and combat themed areas to answer challenging questions, earn skillbuild badges and complete courses. Rewarding users with power-ups and level progressions incentivises them, particularly high school and university students, it also makes learning more engaging.

Future Versions of the game could include:
Expansion of the amount of courses provided, right now only introductory lessons would be connected to the game, further development could increase the amount of courses the game would provide.
Altering game content to include teaching material instead of just knowledge checks.
Changing sprites to original characters.

### 1.3 - System Description

The system the team came up with to solves IBM's SkillBuild website problem is the creation of an educational 2D RPG game featuring questions from IBM's SkillsBuild website. These questions will be at the forefront of the game and required to be solved by the player in order to progress. In order to solve these questions, the player must complete room puzzles to progress. Each course on the SkillBuild website will be represented by an area in the game and puzzles will have a different theme for each area. Furthermore, each area of the game will feature an area boss, which tests the player with more challenging questions through combat. The combat will be inspired by the Phoenix Wright games and the answer menu for the questions will be a dynamic list, due to having a non-even number of questions. Combat will also include an extra element of risk, involving a health system, where the player has hearts which are removed when answering a question wrong. Run out of heart and you restart the entire fight. The hearts will be modeled after the ones in games such as Minecraft and Hollow Knight. The player will also have access to a skill tree, where they can alter combat to fit their play-style by choosing power-ups after each defeated boss. All areas of the game will be linked with a hub world, where the player can choose which area to enter in any order they please. The game will include original character sprites based on sprites from the Pokemon games and during boss combat, combat sprites will be based on sprites from the Pheonix Wright games.

Our team did a plethora of research to support our decision on the above mentioned system. Firstly, the focus on the entire game needs to be on the questions, as specified by the client, so the team wanted gameplay to support this idea. This is why the team came up with the idea of puzzles and combat, as these forms of gameplay enable us to build questions into them. The combat being based on Phoenix Wright was chosen due to the debates in that game being a fitting template for combat based on questions. It also allows for easy incorporation of the menu the team chose, being a list of possible answers, especially due to the varying lengths of answers. The health system being hearts instead of a health bar was chosen due to the fact that answering a question wrong will always deal the same amount of damage and visually representing this is easier in heart format. This reason is the same as to why Hollow Knight uses hearts, so we based it of that. The character sprites were also heavily researched and the team chosen to appropriate the Pokemon player sprites, due to their moderate complexity and 2.5D view models. This allows our rookie artist enough freedom to create sprites of moderate complexity and not have the worry about creating masterpieces. 

The game engine our team decided to work on is Unity, as some of us already have experience in it and Unity has a built in 2D build template, which enables users more freedom when creating 2D environments. We chose not to use RPG Maker, even though the tools is incredibly useful for making RPGs due to the engines limitations: RPG maker is incredibly user friendly, but offers little for more advanced users wanting to implement new features. Writing code is difficult due to the fact that, even though the engine does support it, it is not a direct feature of the engine, so users have to create code on a separate developing environment, then import the created code into RPG maker. Consequently, our team did not want to use RPG maker, as the team wanted to write code in our game. Another game engine researched by the team was Unreal Engine. This engine was quickly dismissed for the same reason RPG maker was: Code. Even though Unreal Engine does support code writing and has its own independent development environment, it uses C++, which is a language unfamiliar to our team. This itself wouldn't be a problem, but there is not much documentation on how to use C++ with Unreal Engine and there are also not many tutorials by Unreal Engine users on C++ either. Furthermore, there Unreal Engine is known for making visually stunning 3D games, with state of the art lighting and graphics, which are features we will not need for our simple 2D RPG. So we decided against using Unreal Engine. 


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
