## 1 - Introduction

### 1.1 - Overview and Justification

Our client is IBM, and our contact to IBM is Mr John McNamara. We have been tasked to reimagine Skills Build as an RPG game. This RPG game must facilitate accessing IBM Skills Build courses by linking the courses and its subsequent knowledge check questions, as well as reward users with in-game items (powerups and progression) if they are able to answer them. The game should also be fun and engaging to the user; it would be both an amazing study tool integrated smoothly into an engaging RPG experience. IBM's Skills Build will be much easier to navigate through the in-game links, and users can more easily get the badges.

This document is the Requirement Specification for our RPG IBM skills build project. There are three parts to this document. The first part is the introduction, which gives a (high-level) description of the project, its scope and domain area. The second part, which is the main part of the requirement specification, is the Solution Requirements. This part specifies what the functional and non-functional requirements for the project are, as well as assessing the risks/issues which may occur when making the project. The third part describes our approach to the development of the game, and introduces our intended schedule to finish the project in time.

### 1.2 - Prokect Scope



## 2 - Solution Requirements

This part of the document has three sections - functional requirements, non-functional requirements and risks/issues.

Add UML Diagram here

### 2.1 - Function Requirements

| Title        | Player Movement                                    |
| ------------ | --------------------------------------------------------------------- |
| Description  | Player must be abe to move conveniently in whatever platforms they are playing |
| Importance   | Highly Important                                                      |
| Dependencies |                                                                       |

| Title        | Camera and Player                                    |
| ------------ | --------------------------------------------------------------------- |
| Description  | The camera must track the player for the player to see what they are doing |
| Importance   | Highly Important                                                      |
| Dependencies |                                                                       |

| Title        | Collisons                                    |
| ------------ | --------------------------------------------------------------------- |
| Description  | The player must not be able to go through walls/doors |
| Importance   | Highly Important                                                      |
| Dependencies |                                                                       |

| Title        | Manual Saving                                 |
| ------------ | --------------------------------------------------------------------- |
| Description  | The player must be able to save at any point in the game |
| Importance   | Highly Important                                                      |
| Dependencies |                                                                       |

| Title        | Auto-Saving                                 |
| ------------ | --------------------------------------------------------------------- |
| Description  | The game should save after going to the next room, in case the player forgets to save so no progress is lost |
| Importance   | Medium importance                                                  |
| Dependencies | Manual Saving                                                              |

| Title        | World Access                               |
| ------------ | --------------------------------------------------------------------- |
| Description  | There should be a world where the player can easily jump into any world (except the final one), so they can complete the game in whatever order pleases them |
| Importance   | Medium importance                                                  |
| Dependencies |                                                            |

| Title        | Doors                               |
| ------------ | --------------------------------------------------------------------- |
| Description  | Each world should have doors which the player must solve a problem / beat a boss in order to complete |
| Importance   | High importance                                                  |
| Dependencies |                                                             |

| Title        | Multiple Choice                               |
| ------------ | --------------------------------------------------------------------- |
| Description  | Each world should have a section where the player is forced to answer questions based on what they learnt from badges |
| Importance   | High importance                                                  |
| Dependencies |    

| Title        | Worlds                               |
| ------------ | --------------------------------------------------------------------- |
| Description  | Game has at least 4 distinct worlds |
| Importance   | High importance                                                  |
| Dependencies |                                                           |

| Title        | Puzzles                              |
| ------------ | --------------------------------------------------------------------- |
| Description  | Game has at least 1 distinct puzzle concept per worlds |
| Importance   | High importance                                                  |
| Dependencies |                                                           |

| Title        | Pause & Main Menu                               |
| ------------ | --------------------------------------------------------------------- |
| Description  | Game should have a pause & main menu |
| Importance   | High importance                                                  |
| Dependencies |           

| Title        | Options Menu                             |
| ------------ | --------------------------------------------------------------------- |
| Description  | Game should contain an options menu where you can change volume, colour blind settings, resolution, full screen, and view the controls |
| Importance   | Medium importance                                                  |
| Dependencies |                                                  |

| Title        | Executable                               |
| ------------ | --------------------------------------------------------------------- |
| Description  | Game should run of an executable file  |
| Importance   | High importance                                                  |
| Dependencies | 

| Title        | Sound Effects                               |
| ------------ | --------------------------------------------------------------------- |
| Description  | Game should include sound effects between room transitions  |
| Importance   | Low importance                                                  |
| Dependencies | 

| Title        | Boss Fight                             |
| ------------ | --------------------------------------------------------------------- |
| Description  | Game should include a final boss  |
| Importance   | High importance                                                  |
| Dependencies | 

| Title        | John                              |
| ------------ | --------------------------------------------------------------------- |
| Description  | John must be in the game  |
| Importance   | Medium importance                                                  |
| Dependencies | 

| Title        | Boss Questions                             |
| ------------ | --------------------------------------------------------------------- |
| Description  | Final boss must include questions from all sections of the game  |
| Importance   | Medium importance                                                  |
| Dependencies | 

| Title        | Health System                             |
| ------------ | --------------------------------------------------------------------- |
| Description  | Game should include a health system / health bar  |
| Importance   | High importance                                                  |
| Dependencies |

### 2.2 - Non-Functional Requirements

| Title        | Graphics for Colour Blind people                                      |
| ------------ | --------------------------------------------------------------------- |
| Description  | Graphics must be enjoyable to look at for people with colourblindness |
| Importance   | Highly Important                                                      |
| Dependencies |                                                                       |

| Title        | Progression                             |
| ------------ | --------------------------------------------------------------------- |
| Description  | The game must have an aspect of progression where items are gained which benefits them |
| Importance   | Highly Important                                                      |
| Dependencies |                                                                       |

| Title        | Platforms                                      |
| ------------ | --------------------------------------------------------------------- |
| Description  | Game should be playable on mouse & keyboard as well as controller |
| Importance   | Medium Importance                                                   |
| Dependencies |                                                                       |

| Title        | Controls                                |
| ------------ | --------------------------------------------------------------------- |
| Description  | Controls should be customizable |
| Importance   | Low Importance                                                   |
| Dependencies |                                                                       |

| Title        | Windows                                |
| ------------ | --------------------------------------------------------------------- |
| Description  | Game should run on windows |
| Importance   | High Importance                                                   |
| Dependencies |                                                                       |

| Title        | Player movement                                |
| ------------ | --------------------------------------------------------------------- |
| Description  | Player movement feels smooth |
| Importance   | High Importance                                                   |
| Dependencies |                                                                       |

| Title        | Game World                               |
| ------------ | --------------------------------------------------------------------- |
| Description  | Game world should feel alive |
| Importance   | Low Importance                                                   |
| Dependencies |                                                                       |

| Title        | Room Transitions                               |
| ------------ | --------------------------------------------------------------------- |
| Description  | Transition between scenes should be smooth |
| Importance   | Low Importance                                                   |
| Dependencies |                                                                       |

| Title        | Boss Battles                               |
| ------------ | --------------------------------------------------------------------- |
| Description  | Battle should engaging |
| Importance   | Medium Importance                                                   |
| Dependencies |                                                                       |

| Title        | Music                               |
| ------------ | --------------------------------------------------------------------- |
| Description  | Music should fit each area |
| Importance   | Medium Importance                                                   |
| Dependencies |                                                                       |

### 2.3 - Risks and Issues

## 3 - Project Development

### 3.1 - Development Approach

### 3.2 - Project Schedule

Add gantt chart
