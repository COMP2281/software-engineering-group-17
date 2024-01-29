#import "template.typ": *

// Take a look at the file `template.typ` in the file panel
// to customize this template and discover how it works.
#show: project.with(
  title: "Test Plan Report",
  authors: (
    "Nam Le - jssb25",
    "Charles Dubois-Veltman - rklb65",
    "Joshua Pulham - tgbp44",
    "James Watson - nqcv52",
    "Sam Ezeh - vqqw43",
    "Akanksha - nwrz52 "
  ),
)

// We generated the example code below so you can see how
// your document will look. Go ahead and replace it with
// your own content!
= Introduction
This  report outlines the plan for our tests, and is divided into three main sections.\
1. The Test Overview, in which we list all our unit tests, system tests and integration tests. We also describe our plan for integration testing. It also includes a diagram of our test workflow, which summarises our plan concisely.
2. The Test Case section outlines some test cases in detail, covering unit tests, system tests and user acceptance tests. Note that we do not include the integration tests in this section, as they are just a combination of previous tests. For each test procedure, it is assumed we start by launching the game.
3. The Testing Context, which gives additional background information around the tests. This includes the development workflow, our choice of testing environment and our choice of classes of severity. This section will not only outline these choices, but also explain the reasoning and provide justification for these choices.

= Project Summary

Our project is to reimagine Skills Build as an RPG game, which facilitates accessing IBM Skills Build courses by linking to them throughout the game, and having at least part of our game have questions from the IBM Skills Build website where the player is rewarded for answering them correctly.
We are doing this by making a 2D educational RPG game where there are puzzles for the player to complete and then bosses which the player must defeat by answering questions from the IBM Skills Build website.

= Tests Overview

#figure(
 image("testing-diagram.svg", width: 100%),
  caption: [Testing workflow],
) <testing-workflow>

#pagebreak()

== Unit Tests

#table(
  columns: (20%, 40%, 40%),
  inset: 10pt,
  align: horizon,
  [Test ID], [Description], [Oracle],
  [unit_test-01], [Directional player movement], [Player moves in expected direction when WASD keys are pressed],
  [unit_test-02], [Camera moves with player], [Camera shifts when the player would be off-screen],
  [unit_test-03], [Combat damage logic], [When an entity takes damage, they lose health proportional to enemy's attack value],
  [unit_test-04], [Random multiple Choice Questions], [Questions appear in different order when trying them again],
  [unit_test-05], [Switching worlds], [Completing boss triggers checks to progress the player onto the next world (or completes game)], 
  [unit_test-06], [Accessible inventory], [Inventory opens when specific button is pressed],
  [unit_test-07], [Accessible Pause menu], [Pause menu opens when escape key is pressed],
  [unit_test-08], [Game starts], [Main game starts when pressing "Start Game" button],
  [unit_test-09], [Game exit], [Go back to main menu when "quit" button is pressed in pause menu],
  [unit_test-10], [Close game], [Game is closed when pressing "exit game" button in main menu],
  [unit_test-11], [Collisions], [Player cannot go through objects],
)

== System Tests

#table(
  columns: (20%, 30%, 30%, 20%),
  inset: 10pt,
  align: horizon,
  [Test ID], [Description], [Oracle], [FR/NFR],
  [sys_test-01], [Combat], [], [FR],
  [sys_test-02], [Skill tree], [Unlocking nodes in skill tree should have appropriate affect on the player's stats], [FR],
  [sys_test-03], [Sound], [Background music plays at all times, sound effects play when event happens], [FR],
  [sys_test-04], [Puzzles], [Puzzles completed by answering questions correctly. Player progresses when completing puzzles.], [FR],
  [sys_test-05], [Boos fights], [Player can start boss fight, complete questions to complete boss fight, is rewarded for correct answers, penalized for incorrect answers. ], [FR],
  [sys_test-06], [Frame rate], [The frame rate should be around 60FPS at all times], [NFR]
)
== User Acceptance Tests

#table(
  columns: (20%, 30%, 30%, 20%),
  inset: 10pt,
  align: horizon,
  [Test ID], [Description], [Oracle], [FR/NFR],
  [uat_test-01], [Response time], [], [NFR],
  [uat_test-02], [Movement Smoothness], [], [NFR],
  [uat_test-03], [Accessibility], [], [NFR],
)

== Integration Testing Overview

Our project has many components which combine to make the final product, therefore we have judged it appropriate to carry out Integration Tests @Integration-rationale as to make sure that the modules not only work on their own but also work in conjunction with each other. 

The main strategies for integration testing are big-bang, bottom-up, top-down and hybrid @Integration-testing-methods. Out of all of these, we have chosen to use bottom-up testing for the following reasons:

- *Phased approach:* A bottom-up approach allows us to start integration testing before all components are ready.
- *Helps identify the source of problems efficiently:*  If a combination of tests is not working,  we know that one of its components is at fault.
- *Compatibility with Agile:* The incremental nature of bottom-up testing fits with agile @Integration-rationale. 
- *Parallel development:* We can each work on the base components separately and independently. 
- *Drivers vs Stubs:* Writing drivers is usually more simple than writing stubs

== Integration Tests

#table(
  columns: (20%, 30%, 30%, 20%),
  inset: 10pt,
  align: horizon,
  [Test ID], [Description], [Oracle], [FR/NFR],
  [int_test-01], [], [], [],
  [int_test-02], [], [], [],
  [int_test-03], [], [], [],
  [int_test-04], [], [], [],
  [int_test-05], [], [], [],
)

= Test Cases

== Unit Tests


#figure(
  table(
    columns: (2fr, 2fr),
    inset: 10pt,
    align: left,
    [Test Case ID], [unit_test-01],
    [Description of test], [Assess player movement functionality while in game, player should be able to move in any direction using one or more of the directional keys (WASD or arrow keys)],
    [Related requirement specification], [FR1.1 FR1.2 FR1.3 FR4.3 NFR2.1],
    [Pre-requisite for test], [
      - Player object in world with sprite
    - Correct game loading
    - Player initialise correctly],
    [Test procedure], [
    1. Ensure that player has loaded correctly
    2. Attempt to move around with directional keys
    3. Ensure that player can move around free space, but cannot walk through walls and other objects
],
    [Test material used], [Computer with keyboard input and screen],
    [Expected result (test oracle)], [
    - The player should move around the world appropriately to the direction of the directional key(s) pressed.
    - Animation of the sprite should change depending on direction moving, based on the first key pressed in one direction: up/down, left/right.
    - When the player stops moving, the sprite should be standing sprite based on direction walked],
    [Comments], [None],
    [Created by], [JW],
    [Test environment], [Windows 10/11, Unity],
    [Failure Severity], [Catastrophic]
  )
)
#figure(
  table(
    columns: (2fr, 2fr),
    inset: 10pt,
    align: left,
    [Test Case ID], [unit_test-02],
    [Description of test], [Camera should move as the player moves so that player is on screen at all times],
    [Related requirement specification], [FR1.1 FR1.2 FR1.3 FR2.5 FR4.3 NFR2.1 ],
    [Pre-requisite for test], [
    - Player character and movement
    - Camera
    - At least two rooms
    ],
    [Test procedure], [
    1. Given aspect ratio, move player enough so that the player would be off screen if the camera did not move
    2. Verify that the player is still on screen
    ],
    [Test material used], [Computer with keyboard input and screen],
    [Expected result (test oracle)], [Once the player attempts to move off screen, the camera should move such that the player is at the centre of the screen],
    [Comments], [None],
    [Created by], [CDV],
    [Test environment], [Windows 10/11, Unity],
    [Failure Severity], [Catastrophic]
  )
)
#figure(
  table(
    columns: (2fr, 2fr),
    inset: 10pt,
    align: left,
    [Test Case ID], [unit_test-03],
    [Description of test], [Relevant characters loses correct amount of health],
    [Related requirement specification], [FR1.1 FR1.3, FR3.1 FR4.5 FR4.6],
    [Pre-requisite for test], [
    - Combat System
    - Health Bars
    - Set of questions, potential answers, and actual answers
    ],
    [Test procedure], [
    1. Load combat
    2. Answer question correctly
    3. Ensure enemy damage taken is proportional to player attack stat
    4. Answer next question incorrectly
    5. Ensure player damage taken is proportional to enemy attack stat
    ],
    [Test material used], [Computer with keyboard input and screen],
    [Expected result (test oracle)], [
      - When the question is answered correctly, the boss will lose health points equal to player attack stat
    - When the question is answered incorrectly, the player loses health points equal to enemy attack status],
    [Comments], [User knows if the player/enemy loses health based on the health bar updating.],
    [Created by], [JW],
    [Test environment], [Windows 10/11, Unity],
    [Failure Severity], [Catastrophic]
  )
)

#figure(
  table(
    columns: (2fr, 2fr),
    inset: 10pt,
    align: left,
    [Test Case ID], [unit_test-04],
    [Description of test], [Entering a room/world transition places player in intended room/world],
    [Related requirement specification], [FR1.1 FR1.2 FR1.3 FR4.1 FR4.2 FR4.3 NFR3.4 NFR3.7],
    [Pre-requisite for test], [
      - Player Character + movement
      - At least 2 rooms, with room transitions between them],
    [Test procedure], [
    1. Walk to area transition to move to a different room/world
    2. If intended to be able to return to original room/world, test that this transition works too
    3. Repeat test for all room/world transitions
    ],
    [Test material used], [Computer with keyboard input and screen],
    [Expected result (test oracle)], [When the player enters an area transition:
    - Camera should move to new area correctly
    - Player should be placed in this new area in the intended position],
    [Comments], [It is critically important to make sure that the player doesn’t get sent to an unintended room/world, as a mistake like this could “softlock” making it unbeatable.],
    [Created by], [JW],
    [Test environment], [Windows 10/11, Unity],
    [Failure Severity], [Catastrophic]
  )
)
#figure(
  table(
    columns: (2fr, 2fr),
    inset: 10pt,
    align: left,
    [Test Case ID], [unit_test-05],
    [Description of test], [Inventory can be accessed through a button in the pause menu],
    [Related requirement specification], [FR1.1 FR1.3 FR2.2 FR2.4 FR4.3],
    [Pre-requisite for test], [
      - Pause menu is functional
      - Pause menu can be accessed by the player through a key press],
    [Test procedure], [
      1. Access pause menu
      2. Click on the inventory button in pause menu
      3. Ensure that inventory menu opens up],
    [Test material used], [Computer with keyboard input and screen],
    [Expected result (test oracle)], [When the user attempts to access the inventory through the pause menu, the inventory button opens the inventory],
    [Comments], [Pause menu can not be accessed during room transitions and cutscenes],
    [Created by], [JP],
    [Test environment], [Windows 10/11, Unity],
    [Failure Severity], [Moderate]
  )
)
#figure(
  table(
    columns: (2fr, 2fr),
    inset: 10pt,
    align: left,
    [Test Case ID], [unit_test-08],
    [Description of test], [Main menu enables the player to start a new game],
    [Related requirement specification], [FR1.3 FR2.1],
    [Pre-requisite for test], [User is able to move around using WASD or the arrow keys],
    [Test procedure], [
      1. Launch Game
      2. Click on New Game button on main menu
    ],
    [Test material used], [Computer with keyboard input and screen],
    [Expected result (test oracle)], [When the user attempts to start a new game, a new game begins],
    [Comments], [There will be a separate button for continuing to play a saved game],
    [Created by], [JP],
    [Test environment], [Windows 10/11, Unity],
    [Failure Severity], [Catastrophic]
  )
)

//#pagebreak()

== System Tests

#figure(
  table(
    columns: (2fr, 2fr),
    inset: 10pt,
    align: left,
    [Test Case ID], [sys_test-01],
    [Description of test], [All combat systems should work together as intended: question shuffling, menus, health bars, sprites and animations, game over, battle win.],
    [Related requirement specification], [FR1.1 FR1.3 FR2.1, FR3.1, FR4.6 FR 5.1 NFR3.5 NFR3.6],
    [Pre-requisite for test], [
      - Functional Combat System
      - Set of questions, and answers from IBM Skills Build
      - Health Bars
      - Combat Sprites
      - Post Combat Functionality
    ],
    [Test procedure], [
    1. Load into Combat
    2. Ensure default sprites load
    3. Ensure enemy asks question in text box and relevant answers load correctly
    4. Choose correct answer, ensure sprites change to relevant states and enemy loses health
    5. Ensure that question shuffles correctly and new question is asked
    6. Choose incorrect answer, ensure sprites change to relevant states, and player loses health
    7. Repeat until boss dies, ensure that combat ends correctly
    8. Repeat combat again, but this time lose the encounter, ensuring that game over works correctly],
    [Test material used], [Computer with keyboard input and screen],
    [Expected result (test oracle)], [
      - Correct combat sprites load when necessary
    - Questions shuffle correctly
    - Player loses health if question is answered incorrectly
    - Boss loses health if question is answered correctly
    - Once combat finishes, game should either game over, and return to main menu, or upon winning the combat, receive a skills build point.],
    [Comments], [This test will also include that sound effects play at the correct time, however we have separated this into a separate test.],
    [Created by], [JW],
    [Test environment], [Windows 10/11, Unity],
    [Failure Severity], [Catastrophic]
  )
)
#figure(
  table(
    columns: (2fr, 2fr),
    inset: 10pt,
    align: left,
    [Test Case ID], [sys_test-02],
    [Description of test], [Skills Build skill tree, when the player earns points/items which they can use to unlock nodes in tree: attack nodes and defence nodes],
    [Related requirement specification], [FR1.3, FR2.4 FR3.1 FR3.2 FR4.5 FR4.6],
    [Pre-requisite for test], [
      - Functional Combat System
      - Skill Tree Menu
      - Various Skills implemented],
    [Test procedure], [
2. Unlock a point/item to upgrade skill tree
3. Allocate point/item to a node in skill tree
4. Enter combat
5. Ensure that skill has intended effect
6. Repeat for all skills
],
    [Test material used], [Computer with keyboard input and screen],
    [Expected result (test oracle)], [
      - Attack nodes increase the amount of damage dealt when questions are answered correctly. 
      - Defence nodes decrease the amount of damage received when questions are answered incorrectly.],
    [Comments], [None],
    [Created by], [JW],
    [Test environment], [Windows 10/11, Unity],
    [Failure Severity], [Serious]
  )
)
#figure(
  table(
    columns: (2fr, 2fr),
    inset: 10pt,
    align: left,
    [Test Case ID], [sys_test-03],
    [Description of test], [Application successfully plays audio sound effects and music where implemented.],
    [Related requirement specification], [FR1.1 FR1.2 FR1.3 FR4.3 FR5.1 NFR3.6],
    [Pre-requisite for test], [
      - Audio of user computer system is functional
      - Object that plays sound is correctly loaded in the level. 
      - Object interaction must be implemented],
    [Test procedure], [
    1. Player interacts with object 
    2. Audio is played globally from the object
    ],
    [Test material used], [Computer with functioning audio system],
    [Expected result (test oracle)], [
      - Audio is played globally when object is interacted with.],
    [Comments], [Player does not need to interact with certain objects in order for the sound effect to be played, but must touch them. Example, transitioning from one room to another through a door, should play the sound effect, but the player does not need to hit the interact key for this to occur.],
    [Created by], [JP],
    [Test environment], [Windows 10/11, Unity],
    [Failure Severity], [Moderate]
  )
)
#figure(
  table(
    columns: (2fr, 2fr),
    inset: 10pt,
    align: left,
    [Test Case ID], [sys_test-04],
    [Description of test], [Puzzles are solvable by the player answering the corresponding question correctly and can then proceed.],
    [Related requirement specification], [FR1.1 FR1.2 FR1.3 FR2.5 FR4.3 FR4.4 FR4.5],
    [Pre-requisite for test], [
    - Player can move
    - Player can interact with objects
    - Camera must follow the player
    - All skills build questions must be implemented in code
],
    [Test procedure], [
    1. Enter room with puzzle 
    2. Complete puzzle in order to access skills build question
    3. Answer question correctly and proceed
    4. Repeat steps 1. to 3. for each puzzle room in the game

],
    [Test material used], [Computer with keyboard input and screen],
    [Expected result (test oracle)], [If the player answers the question correctly the path should open so that the player can progress],
    [Comments], [If the question is answered incorrectly the room should reset.],
    [Created by], [JP],
    [Test environment], [Windows 10/11, Unity],
    [Failure Severity], [Catastrophic]
  )
)

#figure(
  table(
    columns: (2fr, 2fr),
    inset: 10pt,
    align: left,
    [Test Case ID], [sys_test-05],
    [Description of test], [The game includes boss fights which are dispersed throughout scenes, these boss fights involve dialogue and question-answer style combat akin to what can be seen in games such as Ace Attorney. Players should be able to enter combat],
    [Related requirement specification], [FR1.1 FR3.1 FR4.5 FR4.6 FR5.1 NFR3.5],
    [Pre-requisite for test], [
    - Functional computer system
    - Generic user interaction
    ],
    [Test procedure], [
    1. Enter room with boss scene 
    2. Interact with the scene to induce boss fight
    3. Boss dialogue plays
    4. User may use combat mechanics

    ],
    [Test material used], [Computer with keyboard input and screen],
    [Expected result (test oracle)], [
    - The player can initiate a boss fight
    - The player can hear boss audio
    - The player can fight boss
    - The player can follow boss dialogue
    - The player may answer skills build questions
    - The player is rewarded for correct answers to skills-build questions
    - The player is punished for incorrect answers to skills-build questions
],
    [Comments], [],
    [Created by], [SE],
    [Test environment], [Windows 10/11, Unity],
    [Failure Severity], [Catastrophic]
  )
)
#figure(
  table(
    columns: (2fr, 2fr),
    inset: 10pt,
    align: left,
    [Test Case ID], [sys_test-06],
    [Description of test], [Game runs at stable 60fps or above.],
    [Related requirement specification], [FR1.1 FR1.2 FR2.5 FR4.3 NFR1.1 NFR3.1],
    [Pre-requisite for test], [
      - Game is able to run using an executable file],
    [Test procedure], [
    1. Enter area with most sprite objects in game
    2. Move around in area 
    3. Check FPS counter whilst moving],
    [Test material used], [Laptop with downloaded games executable file],
    [Expected result (test oracle)], [Games FPS should run consistently at 60 FPS or above.],
    [Comments], [Tests should be done on various laptops running windows to test varying GPUs and CPUs.],
    [Created by], [JP],
    [Test environment], [Windows 10/11, Executable],
    [Failure Severity], [Serious]
  )
)

== User Acceptance Tests

#figure(
  table(
    columns: (1fr, 3fr),
    inset: 10pt,
    align: left,
    [Test Case ID], [uat_test-01],
    [Description of test], [The game includes several components that request that the player perform some interaction with the scene and the player will contractually expect some event to occur in response. To provide the player with the best in-game experience, we must ensure that every event in response to user input occurs with as little delay as possible as this will prevent the game from appearing "laggy" which will harm the user experience and make the game less enjoyable, reducing engagement and making it harder for the student to absorb information from the IBM skills-build program.],
    [Related requirement specification], [NFR3.1],
    [Pre-requisite for test], [
    - Functional computer system
    - Functional audio
    - Object that plays sound
    - Generic user interaction

],
    [Test procedure], [
    1. Start screen recording software
    2. Start game
    3. Open scene
    4. Perform user interaction
    5. Close game
    6. End screen recording
    7. Open screen recorded video
    8. Verify all user interaction events receive responses within the allotted time
],
    [Test material used], [
    - Computer with a keyboard input 
    - Mouse input
    - Screen recording software
    - Video player
    ],
    [Expected result (test oracle)], [- All events occur within 10 milliseconds],
    [Comments], [
      Due to the vast amounts of scenes involving user interaction, it will be infeasible to manually verify the response time to all potential series of user interactions. As such, we will take a random sample of scenes from the game and perform only a handful of player actions. In the case that a large number of similar actions lead to slow response times, we will perform generalised rewrites of any slow components that could be causing the poor performance of our application.
    ],
    [Created by], [SE],
    [Test environment], [Windows 10/11, Unity],
    [Failure Severity], [Serious]
  )
)

#figure(
  table(
    columns: (2fr, 2fr),
    inset: 10pt,
    align: left,
    [Test Case ID], [uat_test-02],
    [Description of test], [The can move in all cardinal directions and diagonally using the WASD keys with a satisfactory feel to it. Test will be evaluated by asking several users to test their satisfaction with the movement of the player. If 70% of users are satisfied with the movement, the test is successful],
    [Related requirement specification], [FR1.1 FR1.2 NFR3.2],
    [Pre-requisite for test], [
      - Movement is implemented in game
      - User has access to a computer with a functional keyboard],
    [Test procedure], [
    1. Load game
    2. Enter hub world
    3. Use WASD to move
    ],
    [Test material used], [Computer with functional keyboard],
    [Expected result (test oracle)], [User is satisfied with the smoothness of the movement],
    [Comments], [],
    [Created by], [JP],
    [Test environment], [Windows 10/11, Unity],
    [Failure Severity], [Moderate]
  )
)

#figure(
  table(
    columns: (2fr, 2fr),
    inset: 10pt,
    align: left,
    [Test Case ID], [uat_test-03],
    [Description of test], [The game contains a myriad of different tasks and mechanics such as in-game combat and "skill trees". As such, it is of utmost importance that at every stage of the game, users understand what is going on so that they can fully engage with the game. This will ensure that players can benefit as much as possible from the integration with the IBM skills-build program.],
    [Related requirement specification], [FR1.1 FR1.2 FR1.3 FR2.5 FR3.1 FR4.3 FR4.4 FR4.5 FR4.6 NFR3.3],
    [Pre-requisite for test], [
    - Functional computer system
    - Functional audio
    - Object that plays sound
    - Generic user interaction
    - Non-trivial in-game tasks
    ],
    [Test procedure], [
    1. Recruit survey participants
    2. Present survey participants with game
    3. Survey participants play the game for an allotted amount of time
    4. Present survey participants with the question “How well did you understand the game?”
    5. Present survey participants with the question "How well did you engage with the IBM skills-build content?"
    6. Collect responses

    ],
    [Test material used], [
      - Computer with a keyboard input 
      - Mouse input
      - Screen recording software
      - Video player
      - Survey participants
    ],
    [Expected result (test oracle)], [- All users have a high degree of confidence in how well they have understood the game],
    [Comments], [],
    [Created by], [SE],
    [Test environment], [Windows 10/11, Unity],
    [Failure Severity], [Serious]
  )
)



= Testing Context

This section will go through our tools and environment used. We will also go through our choice of failure severity.

== Workflow

We make use of GitHub and automated testing in order to provide a continuous integration workflow. Frequent commits and pushes helps our members understand the code more, allowing for easier merges and bug fix. @Github-continuous-integration

#figure(
 image("workflow-diagram.svg", width: 100%),
  caption: [Development workflow],
) <development-workflow>

When developing the game, we will go through a few phases following the GitHub recommended workflow @Github-suggested-workflow:

1. Coding and updating the game codebase.
2. Running automatic test suit.
3. Make a pull request onto the development branch.
4. Pull request review and quality check code.
5. Merge PR to main branch for deployment. For our use case, deployment means that this code can belong in the main code base, and if we decide to make an executable, the included feature should function as expected.
6. Automatic regression test every 24 hours at midnight every day.

For all tests, if any failure is detected, we will immediately go into a review phase and go back to step 1.

Notice that this is a general development workflow with testing interwoven within, not necessarily the steps we will take to conduct the tests mentioned above.

== Tools and Environment
As per the request of our client @Jon-email-requirements, our game must run on Windows and be developed using Unity. Using an executable for UAT is an option, however we will lose the built-in benefits provided by Unity for testing (Unity testing environment, Unity Profiler, ...). Despite this, some tests (like FPS), will require the use of an executable. 

For that reason, we have chosen the Unity testing environment for UAT, as it is easier to fix or change the code for users in real-time in-case of a game breaking bug. Also, it comes with a developer console, so we could more closely monitor and log which component of the code caused the issue. For more performance related tests, Unity also offers the Unity Profiler, a tool that will help us analyse more accurately @Unity-testing.

For unit and systems tests, we will use the Unity Test Framework (UTF), as it allows for easy test writing and automatic execution, especially when it comes to unit tests @Unity-test-unit. It would also be easier to set up this on Unity, and has a lower barrier of entry, allowing access to all members of our group to write and run tests.

We decided on testing on Windows 10/11 and forego older versions as the majority of users will be on these newer OS (95% of users are on these versions @Windows-old-support-data). Also, since Microsoft has officially stopped support for Windows 7/8.1 and other older versions @Microsoft-windows7-support, we do not want to spend any time on backwards compatibility. The difference between Windows 10 and 11 should be very minor, but we will tolerate a 5-10% difference in performance between the two platform @Windows-10-vs-11-performance.

Therefore, all our testing will be done on a Windows 10/11 machine, and we will be using the built-in Unity testing environment for all our testing.

All tests will be stored in a separate folder for reuse. All automatable tests (all units tests, integration tests and some system tests) will be automatically ran using GitHub Actions at the start each day as a form of regression testing @Github-regression-testing. Feedback will be sent by email to all member of our team, and any failed tests will be dealt with by our Technical Lead (specified in the Requirement Specification).

== Failure severity
For our testing system, we decided on using a 3-level scale to categorize faults, as this method is traditional for game development @Fault-rationale. These include:

#figure(
  table(
    columns: (1fr, 2fr, 2fr, 1fr),
    inset: 10pt,
    align: left,
    [Severity], [Explanation], [Example], [Associated tests],
    [Moderate], [Minor graphical or textual issues. Inconveniences which does not take away from the game.], [Missing textures, missing sound effects, grammatical mistakes, music not looping.], [],
    [Serious], [Bugs which impedes/gets in the way of game progression, whilst not totally breaking the game or stopping progress.], [Frequent FPS drops, hitbox misaligned, camera not functioning as expected (trailing behind, off-centered). Wrong room transition/warp.], [],
    [Catastrophic], [Game breaking issues, requiring a full restart or forcing player to fully restart to resume progression. Can maybe cause data loss (like corrupting save files).], [Game freeze, game crash, massive FPS drop, game mechanics breaking (negative health, infinite damage), softlocks, camera/keyboard non-functional.], []
  )
)

This system also maps nicely to our functional requirement's *MuShCo* system. *Catastrophic* faults *must* be addressed first, then *serious* faults *should* be addressed, and *moderate* faults *could* be addressed later. This allows us to infer the severity of faults by matching the tests with our functional requirements.

Due to the inherent nature of our project, some severity levels are not applicable, such as *infectious*, as we only have one running component in our project (the game) and so this shutting down cannot spread to anything else.

#bibliography("refs.yml")