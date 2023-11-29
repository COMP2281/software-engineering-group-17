# Video Script

## Key info beforehand

**Video name**: 17.mp4 or 17.avi (Group_Number.mp4 or .avi)

**Length**: 8-10 min

**About**:
- Current state of project
- Design ideas developed
- Features we want to implement

**Format**: Encore recording (Screen capture with audio overlay)

**Requirement**: Every member has to speak for AT LEAST 1 minutes. Video of the speaker should be on top of, or besides slides

**Aims**: Explain in technical manner how to tackle the SE problem. Demonstrate understanding of lecture and relation to project

## Script

### Introduction (25%) [2 minutes]

#### Introduction of client [20s] [Akanksha]

- Our client is IBM, and the company contact is John McNamara

>     Slide with IBM Logo and Jon's picture

#### Summary of agreed deliverables from req spec [40s] [Akanksha]


- Make an RPG game that 're-imagine IBM Skills Build' with resources linked in-game, helping students navigate Skills Build and get badges from topics successfully
- After acquiring a badge, students are rewarded with in-game items reflecting their growth 
- The game must be made using Unity and for Windows machines.

>     Slide with Project Brief and emails from Jon

#### Introduce our project goals and aims [1min] [Josh]

Our goal is to solve IBM's Skills Build Website problem. IBM described this website as "complex to navigate and students can lose their way". We aim to solve this by providing a fun way to navigate the website and discover IBM Skills Build courses, through the medium of video games. We will create a top-down 2D RPG game with questions from the courses linked throughout the game. 

The game will contain worlds with puzzle rooms that need to be solved in order to answer the questions. The worlds will each have a theme that corresponds to a Skills Build course. 

Similar to Skills Build, our game will also have final knowledge checks in the format of bosses, in which you need to answer enough questions correctly in order to win.

Slides:

>     Slide 1: Introduction to our project goals and aims
>     - Goal: Solve IBM's Skills Build website problem
>     Slide 2:
>     "complex to navigate and students can lose their way."
>     Slide 3: Video Game
>     - Top down 2D RPG game
>     - questions from Skills Build linked
>     - Puzzles
>     - Boss fights!


Slide with tidbits from ideas.md

### Technical Outline (45%) [6 minutes]

#### Description of technical design [2min] [Nam & Sam]

##### Saving Mechanism \[Sam\]
For storing preferences and information about the game state, we can build two separate classes. The first of which will be PreferencesManager for explicitly storing user preferences.
The second of which will be a StateManager class for storing the Game state.

The game state is composed of the player's location, the items that they currently have and any world-specific information that should be replicated once they rejoin.
And, the game preferences will be composed of settings such as audio levels so the users don't need to re-configure the game environment each time that they re-join the world.

The PreferencesManager and the StateManager will serialise game states to JSON files and be responsible for loading preferences from the disk.
An instance of the PreferencesManager will be shared among the world classes using Dependency Injection.

We will regularly save game state and preferences at intervals however we will also expose a method to force a write to disk if a world needs to ensure that data is saved immediately or the user would like to ensure that their current progress is saved.

Through our state classes, we will also offer an API for storing structured data. This will make it easier for the other developers on our team to manage and define their own data for their own use cases.

##### \[Nam\]

- Entity relationship diagram
  - Main character
    - sprite
  - World
    - rooms
      - state of room
- Combat aspects

#### Walkthrough of features and ideas [1min] [James]

- For each of the following, also talk about the alternative options briefly:
  - Character sprites inspired by Pokemon games for their 2.5D models
  - Combat inspired by Phoenix Wright since it fits with the idea of knowledge battles
  - Questions through combat (multiple choice) and puzzles (more discreet multiple choice)
  - Combat menu inspired by Final Fantasy for its ease of use and dynamic display
  - Health system based on Minecraft for simplified combat, and designed like Hollow Knight because its pretty

>     Slides with original sections from market research next to our choice

#### Development approach [1min] [Nam] 

>     Slides with the development approach (agile, scrum)

#### Flow diagrams of user experience [1min] [James]

- Quick walkthrough of the game states
- Showing what the sprites might look like for the user

>     Slide with game flow diagram and some sprites from market research

#### Limitations/problems [1min] [Josh]

One problem our game faces is that the user is able to brute force answering questions, by instead of thinking what the right answer might be and answering, just guessing until they get it right. We aim to mitigate this behaviour by resetting the puzzle if the question is answered wrong, thus encouraging the player to think hard before answering. The boss fights will also combat this behaviour as if you answer too many questions wrong you need to restart the entire boss fight.

The opposite is also a limitation of the game, where a player could be struggling to answer questions and the game does not offer them any help besides directing them to the Skills Build Website. We aim to mitigate this by have a link to the website in the pause menu so that the player can access the website at anytime they feel they need to.

The player is also able to do what is known as "save scumming", in which the player saves before answering a question to a puzzle and then resets to an old save file if they answer wrongly. One way of solving this problem is only allow saving a specific points in room, such as at the start or end.

>     Slide 1: Limitations/Problems
>     - Brute Force: Answering questions without learning
>     - Struggling Player: Unable to help a struggling player
>     - Save scumming: Not playing the game as intended 

### Future Plan (15%) [2 minutes]

#### Project plan and timeline [1min] [Charles]

- Say in which order the game will be done in
- Show gant chart and describe it

>     Slides showing gant chart

#### Expectation by Week 14 [1min] [Charles]

- From gant chart, say what we expect to be done
- Ideally, all the must FR should be done

>     Slides showing gant chart
