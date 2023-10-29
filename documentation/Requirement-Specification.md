## 1 - Introduction

### 1.1 - Overview and Justification

Our client is IBM, and our contact to IBM is Mr John McNamara. We have been tasked to reimagine Skills Build as an RPG game. This RPG game must facilitate accessing IBM Skills Build courses by linking the courses and its subsequent knowledge check questions, as well as reward users with in-game items (powerups and progression) if they are able to answer them. The game should also be fun and engaging to the user; it would be both an amazing study tool integrated smoothly into an engaging RPG experience. IBM's Skills Build will be much easier to navigate through the in-game links, and users can more easily get the badges.

This document is the Requirement Specification for our RPG IBM skills build project. There are three parts to this document. The first part is the introduction, which gives a (high-level) description of the project, its scope and domain area. The second part, which is the main part of the requirement specification, is the Solution Requirements. This part specifies what the functional and non-functional requirements for the project are, as well as assessing the risks/issues which may occur when making the project. The third part describes our approach to the development of the game, and introduces our intended schedule to finish the project in time.

### 1.2 - Prokect Scope



## 2 - Solution Requirements

This part of the document has three sections - functional requirements, non-functional requirements and risks/issues.

Add UML Diagram here

### 2.1 - Function Requirements

| Title        | Player Character |
| ------------ | --------------------------------------------------------------------- |
| Description  | Main playable character which the game centers around |
| Priority | High |
| MuShCo   | Must have |
| Dependencies | Controls |
| Expected results | Character should have distinct/unique sprite both in and out of battle |
| Exception handling | N/A |

| Title        | Camera |
| ------------ | --------------------------------------------------------------------- |
| Description  | The camera must both be able to track the player character, and move around a stage/scene |
| Priority | High |
| MuShCo   | Must have |
| Dependencies | Player |
| Expected results | This is the main tool to display the game. Most of the time, the camera will be centered on the player character, but it can be used to pan around a stage |
| Exception handling | N/A |

| Title        | Player Character Movement |
| ------------ | --------------------------------------------------------------------- |
| Description  | Player character must be abe to move in any direction |
| Priority | High |
| MuShCo   | Must have |
| Dependencies | Player |
| Expected results | Player character should be able to move in the four cardinal directions and diagonally with either WASD or the arrow keys (holding a combination of two keys, say W and A, would make you move diagonally up and left)|
| Exception handling | N/A |

| Title        | Collisons                                    |
| ------------ | --------------------------------------------------------------------- |
| Description  | The player must not be able to go through walls/closed doors |
| Priority | High |
| MuShCo   | Must have                                                      |
| Dependencies | Controls |
| Expected results | Player character should not be able to move from a ground tile to a wall or closed door tile |
| Exception handling | If character goes out of bound, they should be placed back at the room entrance |

| Title        | World Access |
| ------------ | --------------------------------------------------------------------- |
| Priority |
| Description | There should be a world where the player can easily jump into any world (except the final one), so they can complete the game in 
whatever order pleases them |
| Expected results | |
| Exception handling | |
| MuShCo   | Should have                                                  |
| Dependencies |                                                            |

| Title        | Doors                               |
| ------------ | --------------------------------------------------------------------- |
| Description  | Each world should have doors which the player must solve a problem / beat a boss in order to complete |
| Priority |                                                                       |
| MuShCo   | Must have                                                  |
| Dependencies |                                                             |
| Expected results | |
| Exception handling | |

| Title        | Multiple Choice Question |
| ------------ | --------------------------------------------------------------------- |
| Description  | Each world should have a section where the player is forced to answer questions based on what they learnt from badges |
| Priority |                                                                       |
| MuShCo   | Must have                                                  |
| Dependencies |    
| Expected results | |
| Exception handling | |

| Title        | Worlds                               |
| ------------ | --------------------------------------------------------------------- |
| Description  | Game has at least 4 distinct worlds |
| Priority |                                                                       |
| MuShCo   | Must have                                                  |
| Dependencies |                                                           |
| Expected results | |
| Exception handling | |

| Title        | Puzzles                              |
| ------------ | --------------------------------------------------------------------- |
| Description  | Game has at least 1 distinct puzzle concept per worlds |
| Priority |                                                                       |
| MuShCo   | Must have                                                  |
| Dependencies |                                                           |
| Expected results | |
| Exception handling | |

| Title        | Pause & Main Menu                               |
| ------------ | --------------------------------------------------------------------- |
| Description  | Game should have a pause & main menu |
| Priority |                                                                       |
| MuShCo   | Must have                                                  |
| Dependencies |           
| Expected results | |
| Exception handling | |

| Title        | Manual Saving |
| ------------ | --------------------------------------------------------------------- |
| Description  | The player must be able to save at any point in the game |
| Priority | Medium |
| MuShCo   | Must have |
| Dependencies | Menu & Main Menu |
| Expected results | In the  |
| Exception handling | If save failed, player should be notified and asked if they want to save again |

| Title        | Auto-Saving                                 |
| ------------ | --------------------------------------------------------------------- |
| Description  | The game should save automatically |
| Priority | Medium |
| MuShCo   | Should have |
| Dependencies | Manual Saving |
| Expected results | Every room transition will save the game. This is in case the player forgets to save so no progress is lost |
| Exception handling | |

| Title        | Options Menu                             |
| ------------ | --------------------------------------------------------------------- |
| Priority |                                                                       || Description  | Game should contain an options menu where you can change volume, colour blind settings, resolution, full screen, and view the 
controls |
| Expected results | |
| Exception handling | |
| MuShCo   | Should have                                                  |
| Dependencies |                                                  |

| Title        | Executable                               |
| ------------ | --------------------------------------------------------------------- |
| Description  | Game should run of an executable file  |
| Priority |                                                                       |
| MuShCo   | Must have                                                  |
| Dependencies | 
| Expected results | |
| Exception handling | |

| Title        | Sound Effects                               |
| ------------ | --------------------------------------------------------------------- |
| Description  | Game should include sound effects between room transitions  |
| Priority |                                                                       |
| MuShCo   | Could have                                                  |
| Dependencies | 
| Expected results | |
| Exception handling | |

| Title        | Boss Fight                             |
| ------------ | --------------------------------------------------------------------- |
| Description  | Game should include a final boss  |
| Priority |                                                                       |
| MuShCo   | Must have                                                  |
| Dependencies | 
| Expected results | |
| Exception handling | |

| Title        | John                              |
| ------------ | --------------------------------------------------------------------- |
| Description  | John must be in the game  |
| Priority |                                                                       |
| MuShCo   | Should have                                                  |
| Dependencies | 
| Expected results | |
| Exception handling | |

| Title        | Boss Questions                             |
| ------------ | --------------------------------------------------------------------- |
| Description  | Final boss must include questions from all sections of the game  |
| Priority |                                                                       |
| MuShCo   | Should have                                                  |
| Dependencies | 
| Expected results | |
| Exception handling | |

| Title        | Health System                             |
| ------------ | --------------------------------------------------------------------- |
| Description  | Game should include a health system / health bar  |
| Priority |                                                                       |
| MuShCo   | Must have                                                  |
| Dependencies |
| Expected results | |
| Exception handling | |

### 2.2 - Non-Functional Requirements

| Title        | Graphics for Colour Blind people                                      |
| ------------ | --------------------------------------------------------------------- |
| Description  | Graphics must be enjoyable to look at for people with colourblindness |
| Priority |                                                                       |
| MuShCo   | Must have                                                      |
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

| Title        | Platforms                                      |
| ------------ | --------------------------------------------------------------------- |
| Description  | Game should be playable on mouse & keyboard as well as controller |
| Priority |                                                                       |
| MuShCo   | Should have                                                   |
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

| Title        | Windows                                |
| ------------ | --------------------------------------------------------------------- |
| Description  | Game should run on windows |
| Priority |                                                                       |
| MuShCo   | Must have                                                   |
| Dependencies |                                                                       |
| Expected results | |
| Exception handling | |

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
| MuShCo   | Could have                                                   |
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

### 2.3 - Risks and Issues

## 3 - Project Development

### 3.1 - Development Approach

### 3.2 - Project Schedule

Add gantt chart
