#import "template.typ": *

// Take a look at the file `template.typ` in the file panel
// to customize this template and discover how it works.
#show: project.with(
  title: "User Manual",
  authors: (
    "Nam Le - jssb25",
    "Charles Dubois-Veltman - rklb65",
    "Joshua Pulham - tgbp44",
    "James Watson - nqcv52",
    "Sam Ezeh - vqqw43",
    "Akanksha Sirohia - nwrz52 "
  ),
)

#set heading(numbering: "1.")

#show outline.entry.where(
  level: 1
): it => {
  v(12pt, weak: true)
  strong(it)
}

#outline(indent: auto, depth: 3)
#pagebreak()

= Project introduction

[TODO] Recap briefly the client request
- Issue with IBM Skills Build
- What John wants us to make (a game), and how this will help solve the issues

= Solution discussion

[TODO] Provide analysis of Project Brief + John Email
- Show project brief and John's email
- Split and analyse project description section in the word docs
- Say we currently implemented RPG game with IBM questions linked from badge topics, and have implemented fully AI, DS, and partially Cloud/Threat

[TODO] Discuss impact our project has currently, and might have in the future
- Currently, a game that can be played alongside doing IBM badges
- Helps navigate Skills Build website
- In the future, perhaps permanently implemented as one of IBM Skills Build's official game
- Can make learning more fun, helps students remember more, especially if project is adapted to:
  - Include more worlds based on badges
  - Link the learning more directly into the game instead of Q&A
  - Have personal tile maps and assets made instead of publicly online ones

== Copyright concerns

[TODO] Include email Josh sent

Our game uses a wide variety of copyrighted assets such as music and some images. Since this game is for educational purposes and we will not be charging people to play the game, we are excempt for the copyright laws concerning use of copyrighted assets. 

However, if we were to consider making the game a paid experience, here is the list of copyrighted material used:

Audio:
- 16 Bit SNES Super Street Fighter II Guile Stage Type B KDL3 Style AMK Commission 
- Mario Sonic at the Olympic Winter Games DS Adventure Tours Blizland 
- Mario Sonic at the Olympic Winter Games DS Dream Ice Hockey Fever Hockey 
- Hollow Knight Queen's Gardens
- Doki Doki Literature Club Just Monika
- Mario Luigi Bowser's Inside Story Mini Game 2 
- OneShot On Little Cat Feet
- Pokémon Diamond Pearl Platinum Route 216 Day 
- Last Bible 3 Underworld Forest
- South Park End Credits
- Super Mario Galaxy 2 Soundtrack Sweet Mystery Yoshi 
- Super Mario Galaxy 2 Soundtrack World 2
- Super Mario Galaxy 2 Soundtrack World 4
- Super Mario Galaxy 2 Soundtrack World 6

Art:
- Deltarune Spamton sprite
- Doki Doki Literature Club Monika
- Doki Doki Literature Club Dialogue Box
- Sprite Mancer Ice Cave 

These can be found under the [FOLDER NAME CONTAINING THESE COPYRIGHTED ITEMS]

= Initial ideas and current integration

[TODO] Explain our ideas that we brainstormed from way before at the beginning of the project
- Use the project idea and market research extensively as a reference point
- In fact, since market research wasn't part of any coursework related stuff, just bring the entire thing into this user manual lmao. I wont make more sections besides 3.1 since this might as well be the plan

== Market Research

Role Playing Games [add to glossary] (RPGs) are a genre of video game that has been continuously iterated upon since the 1970s @first-rpg, as such before starting development on our game, we decided to do market research into some pre-existing RPG titles, alongside some other games we felt were relevant to our game.

This market research can be broken down into 4 categories:
- Combat
- Menus
- Sprites
- Health

-- Others: Hub world

=== Combat
RPG combat has incredible variation, and there is far from one set presentation or style that must be followed for an RPG game, thus we need to decide on what format we want the question and answer (Q&A) combat to be in, firstly in how we want our player and our enemies to be represented in battle.

[Talk about the fact that they're all turn based maybe]

==== Undertale
One of the first RPGs that come to mind when we consider combat encounters that allow you to talk to your enemies is the 2015 game Undertale, which does not feature the player character, and has a front shot of the enemy you are fighting or talking to.

#figure(
  image("Images/battle1.png", width: 100%),
)

==== Final Fantasy VI
Alongside the likes of Dragon Quest, the Final Fantasy series is one of the forefathers of the RPG genre; Final Fantasy VI is the last 2D mainline Final Fantasy game, the game features combat where players and enemies face each other from opposite sides of the screen, with sprites that show their full bodies.

#figure(
  image("Images/battle2.png", width: 100%),
)

==== Pokemon
As the highest grossing media franchise in the world@franchises, the original Pokemon games have captivated many people over the years, featuring two characters facing off on opposite corners, both with a 3/4 perspective sprite, with the player character facing away from the camera.

#figure(
  image("Images/battle3.png", width: 100%),
)

==== Ace Attorney Investigations
While not an RPG series, the Ace Attorney games are puzzle games, where the main "combat" encounters take place with a courtroom, featuring the attorney and prosecutor in a battle of wits. In the mainline games these characters take up a full screen to themselves, however, the spinoff Ace Attorney Investigations features the two characters on one screen, duking with their words. Considering the dynamic experessions and how it requires you to "talk to fight", I thought this would be a good fit for the style of game we are making.

#figure(
  image("Images/battle4.png", width: 100%),
)

==== Fear and Hunger
As a relatively unknown RPGMaker [maybe talk about what rpgmaker is] Horror game, Fear and Hunger features gruelling and cruel combat encounters, many of which encounters you can talk to the enemy to try and distract them, find out information or damage their mind by answering their questions. This game features front on enemies, similar to Undertale, while the player characters you see from the back in 3/4 perspective, like with Pokemon.

#figure(
  image("Images/battle5.png", width: 100%),
)

==== Mario and Luigi RPG
The Mario and Luigi RPG games differ from regular RPGs, as while they are still predominantly turn based, it also involves timing button inputs to do additional damage, or avoid enemy attacks. This makes very a particularly engaging combat system that requires both strategy and skill. The games displayed below are Mario and Luigi: Bowser's Inside Story and Paper Mario The Thousand Year Door.

#figure(
  image("Images/battle6.jpg", width: 100%),
)
MAKE THE ABOVE IMAGE FIT THE STYLE + INCLUDE TTYD

=== Menu
We also need to consider how the player will answer questions, and what type of menu we want the player to use.

==== List Style
This is arguably the most popular style of menu in RPG games, and involves a scrollable list, to which players will move down the list, relatively simple to implement and does what it needs to.

#figure(
  image("Images/menu1.png", width: 100%),
)

==== Square Style
Having a square menu style with 4 options is less popular in the genre, but is still featured in the monolithic franchise Pokemon, this style may work quite well for Q&A style combat, however is slightly more difficult to implement however, and limits us to 4 answers.

#figure(
  image("Images/menu2.png", width: 100%),
)

=== Sprites
While combat sprites depend on the combat style we choose, all of the characters in the game need to have consistent sprites in the overworld, and so we looked into the different sprite sheets used in various other RPG games, both from a complexity standpoint, due to our limited knowledge of art, and stylistic standpoint

One of the biggest things to consider with sprite sheets is the amount of space they take up relative to the world around them, traditional RPG style has the world split into "tiles", which can be thought of like a square grid, in which the characters normally move between these tiles, and normally mean that sprites have to fit into that square area. However newer top-down 2D games are less restrictive, and have more free movement, which also means that character sprites do not have to conform to set tile space

The sprites I am showing off in this section are all walking animation sprites, with a step-stand-step style of animation, which is simple to animate, but works brilliantly, and is still used in modern top down games today.

#figure(
  image("Images/spritesheet.png", width: 100%),
)

==== Final Fantasy VI
Final Fantasy 6 sprites differ from the rest as they only have 2 frames on their sideways walk, they are slightly taller than a single tile, but would work for a tile-based game, and are relatively simple. And considering the person doing the art for our group does not have a great deal of experience, simple sprites are probably better.

==== Fear and Hunger
Fear and Hunger sprites are 2 tiles tall, this means that while their hitbox is in their lower half, they also have an upper half, which lets them appear much more human and realistic. These sprites are much more complicated, but look amazing because of it.

==== Stardew Valley
Stardew Valley's sprites do not conform to the tile system, but character designs are still simple, yet appear move humanlike by not conforming to tiles.

==== Pokemon
Pokemon games are the classic representation of tile-based sprite sheets, and while simple and stylised, they also carry alot of detail.

==== RPGMaker
RPGMaker is a game engine inspired by classic RPG games, and thus operate off a tile system, with their example sprites all fitting into one tile.

==== Simple
Finally, we have the super simple 16x16 sprites, which conform to tiles, but lack a lot of detail.

==== Faith: Unholy Trinity
Faith: Unholy Trinity sprites were purposfully created to be as simple as possible to emulate old 90s game sprites, thus they use limited colours and no shading, but are visable enough to make out what the sprites are.

==== Party Hard
Party Hard Sprites are similar to the Faith sprites, in that they are very minimalistic, but express enough detail to be identifiable.

==== Mario and Luigi Superstar Saga
The Mario and Luigi sprites are iconic for the Game Boy Advanced era. As the hardware was not very bright due to the screens limitations, the work around to make the characters seem more eye-catching and visible was to give them a thick black outline. This made the characters pop out more from the background scenery and became a staple for the series even after the hardware limitations were fixed.

[TODO] Clean up text, maybe split up sprite sheets/ combine final ones

=== Health
We need to be able to keep track of how many questions have been answered correctly and there are several ways to do this, however keeping in line with RPG games, the best way is through Hit Points (HP), these normally represent how much damage the player has taken [CHECK DEFINITION]. Converting this to Q&A style combat, we can say that if the player answers a question correctly, the enemy takes damage, and if you answer a question wrong, the player character takes damage.

There are multiple ways of representing HP, however we will be deciding between health bars and heart bars.

==== Health Bars
A health bar is quite simply a bar to display health, normally analogue in nature.
Take this screenshot from Guilty Gear Xrd, a fighting game released in 2014. At the top of the screen there are two health bars to represent each character's health.

#figure(
  image("Images/GGX1.jpg", width: 100%),
)

As this health bar depletes it will "empty" towards the centre of the screen.

#figure(
  image("Images/GGX2.jpg", width: 100%),
)

Or take this screenshot from Trails from Zero, an RPG originally released in 2010, which features 4 "party members" each of which having 3 bars, "Health Points", "Energy Points" and "Craft Points", each of which deplete towards the left as you use them or are damaged. In addition, if you bring your Craft Points over 100, there is another bar, in a lighter colour of green, that overlaps the original bar, which is commonly used in games to represent a strong character having multiple health bars.

#figure(
  image("Images/TrailsZero.jpg", width: 100%),
)

The advantages of health bars is that they simple and easy to look at, as they can be represented numerically, and thus can be manipulated freely.

==== Heart Bars

Heart bars are a more discrete representation of health bars, as instead of having a large number to represent health, you instead have a more constant smaller numerical representation, and each piece of damage would represent one "heart".

In Minecraft you have 10 hearts, where each piece of damage counts for a quarter of a heart, thus giving a visual representation of 40 hit points.

#figure(
  image("Images/minecraft.png", width: 100%),
)

In addition, if you have the "absorption" effect, you get bonus hearts, which overlay the regular hearts, represented by their yellow colour.

#figure(
  image("Images/minecraftYellow.png", width: 100%),
)

The positives of heart bars are they also allow you to represent health in unique ways, for example in hollow knight, each piece of health is represented by a "mask", thus this concept allows for more creativity, as we can represent health as whichever item we desire, however this would require a lot more programming and asset creation.

#figure(
  image("Images/mask.jpg", width: 80%),
)



[TODO] Explain why our game is designed like Undertale/Deltarune
- Top down 2D RPG
- Lots of puzzles as well as combat
- Simple but effective

[TODO] Explain hub world and concepts of worlds
- Wrath of cortex
- Modularity, can easily add and remove things in parallel, without disrupting ongoing works
- Fits well into user req

== Current Implementation

From the above market rearch we decided to model the combat on Ace Attorney Investigations, with 2 big sprites of the characters on each side, the menu used will be list style and the character sprites will be modeled on pokemon characters, and the health system will be based on hearts.

We took futher inspiration from Undertale 

& Hub world explanation

=== Overworld Sprites

=== Combat Sprites

=== Menu Sprites


= Game instruction manual

The structure of the game instruction manual is inspired by a manual from a Nintendo title called "Pokémon Mystery Dungeon: Gates to Infinity" @Pokemon-MD-manual. 

== Getting started

[TODO] FOR EACH SECTION, LINK TO THE CORRESPONDING FUNCTIONAL REQUIREMENTS

=== Introduction
[TODO] Add images of the 4 worlds, a puzzle, a boss fight and IBM question (the room w the 4 option buttons)

Our game's story begins with the player, an IBM employee doing work in his office like any other day, when they are suddenly sucked into their computer and transported to the world of the IBM Tower of Skills Build Mastery. Dazed and confused, the player wakes up in the Hub world and decides to explore their new surroundings when suddenly, they are beckoned to an altar by an unknown voice. When arriving at the altar, they are greeted by the spirit of the altar, a helper character giving the player insight on where they are and what they must do to leave. The IBM Tower of Skills Build Mastery is a world that exists between time and space and needs to disappear in order for the real world to continue functioning. Destroying the world is also the only way for the player to go back home, so they agree to help the spirit in destroying it. The altar instructs the player to find 4 relics of alternate worlds and bring them back to the altar. Only then can they reach the creator of the world and defeat him to destroy the world. Armed with this knowledge, the player embarked on a journey through each of the worlds, solving puzzles, playing mini-games, answering questions from Skills Build to progress and fighting battles of whits against corrupted IBM co-workers who have also been trapped in the Tower of Skills Build Mastery.

Will you succeed in saving them and returning to your world? 

#figure(
  image("Images/Objection.png", width: 80%),
  caption: [Image of ... sprite when answering a question right during combat.],
)

#figure(
  image("Images/Sighing.png", width: 50%),
  caption: [Image of ... sprite when answering a question wrong during combat.],
)

Each World the player can enter will represent a Skills Build course, with questions in the world coresponding to that course. Boss fights in each world will also invlove these question, with combat being a knowledge based fight, in which the player must answer Skills Build question correctly  to defeat the enemy.

The game will also feature a skill tree, in which the player can choose different status upgrades when defeating a boss in combat, making subsequent boss fights easier. 

#figure(
  image("Images/DS.png", width: 100%),
  caption: [Image of Data Sciene world level 5, including snow particle effects.],
)


=== Main menu

[TODO] Link with FRs

[TODO] UPDATE IMAGES

[TODO] Restructure the next sections to lead into each other? Like moving control to be after worlds?

The Main menu is an inviting location for new players, with sombre music and a futuristic background image with the IBM logo in it. Furthermore, to give the main menu more liveliness, the background image moves around at random intervals in time, and blur and unblur itself too. 

#table(
  columns: (50%, 50%),
  inset: 10pt,
  align: horizon,
  [*Main Menu Button*], [*Description*],
  [New game], [The new game button starts creates a new save file and loads the first level of the game.],

  [Continue], [The continue button loads the last save file and loads the level that was last saved.],

  [Settings], [The settings button opens the settings menu.],
  
  [Credits], [The credits button loads the credits for the game.],
  
  [Quit], [The quit button closes the game.])


  
#figure(
  image("Images/main_menu.png", width: 100%),
  caption: [Image of Main menu including background image and all buttons, with the "New Game" button being highlighted.],
)

#pagebreak()

#table(
  columns: (50%, 50%),
  inset: 10pt,
  align: horizon,
  [*Settings Menu Button*], [*Description*],
  [Graphics], [The graphics dropdown allows the user to change the graphical quality of the game. The 3 options are high, medium or low.],

  [Enable Particles], [Allows the user to enable or disable particle effects in the game.],

  [Volume], [Allows the user to altar the volume of the game.],
  
  [Back], [This button returns the user back to the main menu.],)
  
#figure(
  image("Images/settings_menu.png", width: 100%),
  caption: [Image of Settings menu including background image and all buttons.],
)

Now that you've seen all that we have to offer in the main menu, let us explore The _IBM Tower of Skills Build Mastery_ by starting a New Game!



== Controls

[TODO] Rewrite introduction section to be better + fill in any gaps missed, like world specific controls + update controls to reflect final version or whatever

This game is designed to be played using either a gamepad, or a keyboard and mouse. While the game should be compatable with most gamepads, it has been designed primarily for the Playstation DualSense™ Controllers, the Xbox Wireless Controllers and the Nintendo Switch Pro Controllers. As each of these controllers have different layouts, below is a graphic that can be mapped onto any controller, used for our control descriptions (rewrite this), for keyboard controls we will be referencing the keys.

For the controls below, Left/Right Stick Up/Down/Left/Right refers to pushing the Left/Right stick in the specified direction enough for the game to register it as an input. Similarly for D-Pad Up/Down/Left/Right and the other buttons listed, these require pushing the button enough for the game to register this as an input.

#figure(
  image("Images/Controller.png", width: 80%),
  caption: [Generic Gamepad with Button Labels @ps2-gamepad],
)

=== Menu
#table(
  columns: (25%, 25%, 50%),
  inset: 10pt,
  align: horizon,
  [*Keyboard*], [*Controller*], [*Action*],
  [W / Arrow Up], [Left Stick Up /\ D-Pad Up], [Navigate menu up],
  [S / Arrow Down], [Left Stick Down /\ D-Pad Down], [Navigate menu down down],
  [A / Arrow Left], [Left Stick Left /\ D-Pad Left], [Adjust menu item left],
  [D / Arrow Right], [Left Stick Right /\ D-Pad Right], [Adjust menu item right],
  [Space], [Button 1], [Select highlighted menu item],
)

=== Overworld

#table(
  columns: (25%, 25%, 50%),
  inset: 10pt,
  align: horizon,
  [*Keyboard*], [*Controller*], [*Action*],
  [W / Arrow Up], [Left Stick Up /\ D-Pad Up], [Main character walks upwards],
  [A / Arrow Left], [Left Stick Left /\ D-Pad Left], [Main character walks left],
  [S / Arrow Down], [Left Stick Down /\ D-Pad Down], [Main character walks downwards],
  [D / Arrow Right], [Left Stick Right /\ D-Pad Right], [Main character walks right],
  [Space / Z], [Button 1], [Interact / Advance text],
  [Escape / Tab], [Start], [Enter pause menu]
)

=== Battle

#table(
  columns: (25%, 25%, 50%),
  inset: 10pt,
  align: horizon,
  [*Keyboard*], [*Controller*], [*Action*],
  [W / Arrow Up], [Left Stick Up /\ D-Pad Up], [Navigate menu up],
  [S / Arrow Down], [Left Stick Down /\ D-Pad Down], [Navigate menu down down],
  [Space], [Button 1], [Accept answer/choice / Advance text]
)

=== World Specific

[TODO] Explain world specific controls
- Dash/shield in AI world
- Table format

#table(
  columns: (25%, 25%, 50%),
  inset: 10pt,
  align: horizon,
  [*Keyboard*], [*Controller*], [*Action*],
)

== Taking a break

[TODO] Explain how saving works
- Show demo, like having character next to hub world altar, save, then reload, bringing you to hub world spawn

Need a break from the game? Have something unexpecidly occur whilst playing that needs your attention? Worry not because we have added a pause menu! When entering the pause menu you will see a familiar sight; the same background image as the main menu. This is intentional, as the main menu is designed to be a welcoming and relaxing menu. We wanted the user to experience the same in the pause menu, as the pause menu should also be a safe retreat whenever needed whilst playing the game. When in the pause menu, the game is paused, so no need to worry about dying whilst in here.

#table(
  columns: (50%, 50%),
  inset: 10pt,
  align: horizon,
  [*Pause Menu Button*], [*Description*],
  [Resume], [This button resumes the game.],

  [Skills Build], [This button opens a link to the Skills Build website, in case the user would like to review the content there.],

  [Inventory], [This button opens the user's inventory],
  
  [Skip Level], [If the user is struggling in the current level, then pressing this button skips the current level. ],
  
  [Settings], [The settings button opens the settings menu.],

  [Save], [The save button saves the user's progress up to the current level.],
  
  [Save and Quit], [The save and quit button saves the game, then opens the main menu.])

  #figure(
  image("Images/pause_menu.png", width: 100%),
  caption: [Image of Pause Menu including background image and all buttons.],
)

  
  The Settings Menu in the pause menu is the same as in the main menu, containing the same buttons and layout.

  Skipping a level cannot be done in a boss world or in the hub world, meaning that the user must beat the boss of each world to progress. 

  When saving the game, the game does not save progress within the current level, meaning that if the user now decided to close the game after saving, the user would have to redo everything in the current scene. Saving is also not possible during a boss fight.
  


== Worlds

This game is split into multiple "worlds", every world is a collection of levels that represent a different section of IBM Skills Build, each with its own themes and challenges, in addition to the hub world and final world.

The hub world exists to connect each of the worlds together, as well as being a safe location for the player to reside.
Within this area the player can speak to the Spirit of the Altar, who gives the player their mission, opening the gates to the 4 major worlds. 

#figure(
  image("Images/Altar.png", width: 100%),
  caption: [Image of player in front of the Altar],)

As the game progresses, non-player characters (NPCs) will begin to populate this area, giving the player hints and advice, often related to the IBM Skills Build.
[Image of NPCs]

Once the portals have opened in the hub world the player can travel to one of the four worlds:
- The hostile futuristic Artificial Intelligence world.
- The dark cold Data Science world.
- The bright sky islands of the Cloud world
- The threat intelligence world? [fill in]

After completing each world, the player will be rewarded with a [magic maguffin skills build thing] which will be placed on the altar, after collecting all 4 [magic maguffins] a new portal will open to the final boss world.

=== Central hub

[TODO] Explain purpose of hub world
- Central place that player can call home
- NPC that can be talked to and hidden secrets to be found
- The altar to go to boss world

[TODO] Explain the world transitions
- Show image of doors from hub to worlds, as well as the altar in centre of hub world 

=== Shared-world mechanics

[TODO] Showcase shared world mechanics
- Timers, those funny arrows that point towards a location, trivia questions at the end of puzzle, boss fight at end of world
- Collectable item after boss fights used in hub world

[TODO] Explain world-specific mechanics
- Each world has puzzles centred around its specific themes
- Each world has its own sprites and textures

=== AI World

[TODO] Showcase all world-specific mechanics
- Heart system, turrets, chasing monsters, heart pickups, dash boots, shielding, portals, moving platforms
- SPAM SCREENSHOTS

=== DS World

[TODO] Showcase all world-specific mechanics
- Sliding ice, darkness, sound-based mazes
- SPAM SCREENSHOTS

=== The other two worlds

The other two worlds are still a work in progress, we have

[TODO] Explain its WIP
- Describe the puzzle specific quirks of these missing worlds
- Show the sprite/texture of these missing worlds

=== Final Boss World

The final world is designed to test everything the player learned from the 4 major worlds, though [combinations of puzzles from all worlds (is this the intention?) (We probably just make it a boss fight with questions from all worlds -NAM- We don't have time for this imo, so just a boss I would say -JOSH-)] and a final combat section utilizing Skills Build Questions from all 4 bosses.
The texture theme of this world is:

== Combat

=== Skills Build#super([TM]) system

[TODO] Showcase skill tree
- Explain what it affects, which are health and attack values inside of fights
- Show screenshots of the skill tree

=== Bosses

[TODO] Showcase boss fight
- Fight being trivia battle, wrong answer damages player while correct one damages boss
- Both player and boss have a health bar
- Show image of boss battle UI

== System requirements and installation guide

[TODO] Explain compatible platform
- Only available on Windows 10/11
- Can either be played using KBR+Mouse or controller

[TODO] Talk about .exe build
- Downloadable from GitHub page, which client has access to
- Show screenshot of steps to get this from the repo
- Launch .exe file

#pagebreak()
= Service manual

[TODO] Add a massive UML diagram (RIP THIS IDEA OUR PROJECT WILL HAVE NONE)

== Code accessibility

[TODO] Provide instructions to access code base
- Link to GitHub project
- Guide on installing Unity Hub
- Choosing the right Unity version
- Explain why code base is separated in terms of people working on project (Merge conflicts)

== Code maintenance

[TODO] Scene description and how to work with it

[TODO] Not sure yet tbh probably want some unit tests in here but we dont really have any atm hmm

== Future developments

[TODO] Describe steps to create another world (Charles would probably be good at this section)

[TODO] Changing combat mechanics
- Adding/removing states
- Show code

== Class documentation

In this section, we provide the documentation for the classes used to build the game. The following section will be divided into general classes which are used throughout the game, as well as world specific classes.

=== Overview

The following section is a table overview of the classes, containing its name, description, functions

==== General classes

[TODO] Add combat-related classes, and question importer

#table(
  columns: (1fr, 1fr, 1fr),
  inset: 10pt,
  align: horizon,
  [*Class*], [*Description*], [*Functions*],
  
  [`AnswerButton` \ (@AnswerButtonDetailed)], [Handles functionality for combat answer buttons], [`SetAnswer` \ `SetIsCorrect` \ `OnClick`],
  
  [`Arrow` \ (@ArrowDetailed)], [Point an arrow `GameObject` towards a specified `GameObject`], [`Update`],

  [`BattleCutscene` \ (@BattleCutscene)], [Displays the cutscene before combat], [`Start` \ `Update` \ `FadeOutRoutine`],

  [`BattleHud` \ (@BattleHudDetailed)], [Handles combat HUD information display], [`SetHud` \ `SetHP`],

  [`BattleSystem` \ (@BattleSystemDetailed)], [Handles combat using a finite state machine system. Inherits from `StateMachine`], [`Start` \ `OnAnswer`],

  [`Begin` \ (@BeginDetailed)], [One of the combat states. Responsible for the start sequence of the fight. Inherits from State], [`Start`],

  [`ButtonManager` \ (@ButtonManagerDetailed)], [Handles functionality which affects all the combat buttons at once], [`DisplayButtons` \ `ClearButtons`],

  [`CombatUnit` \ (@CombatUnitDetailed)], [Stores key information about either the player or the boss for fights, including `unitName`, `damage`, `maxHP`, and `currentHp`], [`TakeDamage`],

  [`Credits` \ (@CreditsDetailed)], [Play the end credit scene], [`Start` \ `Update` \ `TheEnd`],
  
  [`EnableArrow` \ (@EnableArrowDetailed)], [Enables the arrow `GameObject`], [`OnTriggerEnter2D`],

  [`EnemyTurn` \ (@EnemyTurnDetailed)], [One of the combat states. Responsible for the enemy turn. Inherits from State], [`Start`],
  
  [`GM` \ (@GMDetailed)], [Defines utility methods that allow other classes to manipulate game information such as game save data and game volume], [`Update` \ `Awake` \ `GetParticle` \ `SetParticle` \ `GetVolume` \ `SetVolume` \ `GetGraphics` \ `SetGraphics`],

  [`ImportQuestions` \ (@ImportQuestionsDetailed)], [One of the combat states. Responsible for the enemy turn. Inherits from State], [`Start`],

  [`Lost` \ (@LostDetailed)], [One of the combat states. Responsible for handling what happens after the player loses a fight. Inherits from State], [`Start`],

  [`MainMenuBackground` \ (@MainMenuBackgroundDetailed)], [Moves the background image around at random intervals and blurs the backgrouund image at random intervals], [`Start` \ `Update`],
  
  [`MainMenuButtons` \ (@MainMenuButtonsDetailed)], [Implements the functionality for the game's main menu. These include starting the game, entering full-screen mode and modifying the game's volume.], [`Start` \ `NewGame` \ `Quit` \ `Volume` \ `Particles` \ `FullScreen` \ `MainMenu` \ `OptionsMenu` \ `SetQuality` \ `Credits`],
  
  [`MusicManager` \ (@MusicManagerDetailed)], [Manages the music in all scenes], [`Awake` \ `PlayMusic` \ `StopMusic` \ `ChangeMusic`],
  
  [`PauseMenu` \ (@PauseMenuDetailed)], [Defines methods related to the game's pause menu. Implemented functionality include pausing the game, resuming the game and modifying the game's volume], [`Start` \ `Resume` \ `Pause` \ `QuitGame` \ `MainMenu` \ `OptionsMenu` \ `Volume` \ `Particles` \ `SkillsBuild` \ `SkipLevel` \ `DisplayText` \ `SetQuality`],

  [`PlayerTurn` \ (@PlayerTurnDetailed)], [One of the combat states. Responsible for the player turn. Inherits from State], [`Answer`],

  [`QuestionData` \ (@QuestionDataDetailed)], [Stores the information necessary for a question], [None],

  [`QuestionSetup` \ (@QuestionSetupDetailed)], [Generates a question for combat. The order in which they are generated is randomized, and if all questions are exhausted then allow for reuse], [`Awake` \ `GetQuestionAssets` \ `Generate`],
  
  [`Sign` \ (@SignDetailed)], [Used to display dialogue when `GameObject` is interacted with], [`Update` \ `OnTriggerEnter2D` \ `OnTriggerExit2D`],

  [`State` \ (@StateDetailed)], [An abstract class which represents a state in the combat sequence. Every combat states inherit from this. Initializes with `BattleSystem`], [`Start` \ `Answer`],

  [`StateMachine` \ (@StateMachineDetailed)], [An abstract class which represents a finite state machine. `BattleSystem` inherits from this], [`SetState`],

  [`Won` \ (@WonDetailed)], [One of the combat states. Responsible for handling what happens after the player wins a fight. Inherits from State], [`Start`],
)

#pagebreak()
==== Hub World classes

#table(
  columns: (1fr, 1fr, 1fr),
  inset: 10pt,
  align: horizon,
  [*Class*], [*Description*], [*Functions*],
  [`AltarCutscene1` \ (@AltarCutscene1Detailed)], [Loads dialogue for the first cutscene with altar], [`Update` \ `OnTriggerEnter2D`],
  
  [`AltarCutscene2` \ (@AltarCutscene2Detailed)], [Loads dialogue for the second cutscene with altar], [`Start` \ `Update` \ `OnTriggerEnter2D`],
  
  [`AltarCutscene3` \ (@AltarCutscene3Detailed)], [Loads dialogue for the third cutscene with altar], [`Start` \ `Update` \ `OnTriggerEnter2D`], 
  
  [`AltarCutscene4` \ (@AltarCutscene4Detailed)], [Loads dialogue for the fourth cutscene with altar], [`Start` \ `Update` \ `OnTriggerEnter2D`],
  
  [`AltarItemGet` \ (@AltarItemGetDetailed)], [Loads dialogue for cutscene when the player has got an item], [`Update` \ `OnTriggerEnter2D`],
  
  [`CreepyCutscene` \ (@CreepyCutsceneDetailed)], [Load dialogue boxes of cutscene and open a URL link], [`Update`],
  
  [`HubDoor` \ (@HubDoorDetailed)], [Open and close the door `GameObject` in the hub world when interacted with], [`Update` \ `OnTriggerEnter2D` \ `OnTriggerExit2D`],

  [`HubDoorTrigger` \ (@HubDoorTriggerDetailed)], [Move player to a different room when interacted with (used behind a door `GameObject` to simulate entering a room)], [`OnTriggerEnter2D`],

  [`HubTeleport` \ (@HubTeleportDetailed)], [Load a specified scene when interacted with], [`OnTriggerEnter2D`],

  [`IntroCutscene` \ (@IntroCutsceneDetailed)], [Loads dialogue of the introduction cutscene], [`Update` \ `OnTriggerEnter2D`],
  
  [`GMHub` \ (@GMHubdetail)], [], [],
  
  [`HubBackground` \ (@HubBackgroundDetailed)], [Rotate the background image], [`Update`],

  [`NamePlayer` \ (@NamePlayerDetailed)], [Accesses the player's real-life name. Used during dialogue], [`Start`],
  
  [`Portal` \ (@PortalDetailed)], [Script to enable a `GameObjects` sprite and collision], [`Start` \ `Update`],
)

#pagebreak()
==== Data Science World classes

#table(
  columns: (1fr, 1fr, 1fr),
  inset: 10pt,
  align: horizon,
  [*Class*], [*Description*], [*Functions*],

  [`Button` \ (@ButtonDetailed)], [Button corresponding to the questions on signs, used to input the answer to the signs questions], [`Start` \ `Update` \ `OnTriggerEnter2D` \ `OnTriggerExit2D` \ `Return` \ `OpenDoor`],

  [`ButtonSpawner` \ (@ButtonSpawnerDetailed)], [Button `GameObject` that when interacted with, moves to a random different location out of a specified list. Must be interacted with a specified amount of times], [`Start` \ `Update` \ `Spawn` \ `OnTriggerEnter2D` \ `OnTriggerExit2D`],

  [`CameraFollow` \ (@CameraFollowDetailed)], [Used to switch between a camera that follows the player and stationary cameras], [`OnTriggerEnter2D`],

  [`CameraManager` \ (@CameraManagerDetailed)], [Switch between Stationary cameras], [`OnTriggerEnter2D` \ `OnTriggerExit2D`],

  [`DoorTriggerLeft` \ (@DoorTriggerLeftDetailed)], [Check door collision. Used in the `LabyrinthDoor` script], [`OnTriggerEnter2D`],

  [`DoorTriggerRight` \ (@DoorTriggerRightDetailed)], [Check door collision. Used in the `LabyrinthDoor` script], [`OnTriggerEnter2D`],

  [`DoorTriggerTop` \ (@DoorTriggerTopDetailed)], [Check door collision. Used in the `LabyrinthDoor` script], [`OnTriggerEnter2D`],

  [`Hole` \ (@HoleDetailed)], [Enables the hole `GameObject`], [`OnTriggerEnter2D`],

  [`LabyrinthDoor` \ (@LabyrinthDoorDetailed)], [Keeps track of, and updates player progress in a specific puzzle on collision (Puzzle archetype 1)], [`OnTriggerEnter2D`],

  [`LevelChanger` \ (@LevelChangerDetailed)], [Changes the level to the next level], [`OnTriggerEnter2D`],

  [`PlayerIceScript` \ (@PlayerIceScriptDetailed)], [`Player` script, but updated to change the ice physics. In this script there is no failsafe for if the player gets stuck on ice], [`Update` \ `FixedUpdate` \ `Flip` \ `OnTriggerEnter2D` \ `OnTriggerExit2D`],

  [`PlayerScript` \ (@PlayerScriptDetailed)], [Enables player movement input], [`Update` \ `FixedUpdate` \ `Flip` \ `OnTriggerEnter2D` \ `OnTriggerExit2D` \ `Unfreeze` \ `Frozen`], 

  [`RemoveArrow` \ (@RemoveArrowDetailed)], [Disable the arrow `GameObject`], [`OnTriggerEnter2D`],

  [`SecretRoom` \ (@SecretRoomDetailed)], [If player is in range of `GameObject`, disable physical collision], [`Update` \ `OnTriggerEnter2D` \ `OnTriggerExit2D`],
  
  [`Snow` \ (@SnowDetailed)], [Enables snow particle to fall], [`Start` \ `Update`],

  [`SnowGenerator` \ (@SnowGeneratorDetailed)], [Updates the snow generator's location based on the current active camera], [`Update`],

  [`Spawner` \ (@SpawnerDetailed)], [Places the player at a specific location in a scene. Linked to Puzzle 1], [`Start` \ `Update` \ `FixedUpdate` \ `OnTriggerEnter2D` \ `MovePlayer`],

  [`SpecialTimer` \ (@SpecialTimerDetailed)], [Starts a timer and counts down to 0. The same as `Timer` script, only it takes in a different player script], [`Update` \ `UpdateTimer` \ `TimerEnded` \ `OnTriggerEnter2D` \ `Restart` \ `PlayMusic`],

  [`Teleporter` \ (@TeleporterDetailed)], [Move the player to a specified loction in the scene and disable the hole `GameObject`], [`OnTriggerEnter2D`],

  [`Timer` \ (@TimerDetailed)], [Starts a timer and counts down to 0], [`Update` \ `UpdateTimer` \ `TimerEnded` \ `OnTriggerEnter2D` \ `Restart` \ `PlayMusic`],

  [`TimerStop` \ (@TimerStopDetailed)], [Stops the timer from running], [`OnTriggerEnter2D`],

  [`TimerStopSpecial` \ (@TimerStopSpecialDetailed)], [Stops the timer from running. The same script as TimerStop, only it uses SpecialTimer instead of Timer], [`OnTriggerEnter2D`], 

  [`WallMaker` \ (@WallMakerDetailed)], [Enables a collision GameObject when interacted with], [`OnTriggerEnter2D`],
)

#pagebreak()

==== AI World classes

#table(
  columns: (1fr, 1fr, 1fr),
  inset: 10pt,
  align:horizon,
  [*Class*], [*Descriptions*], [*Functions*],
  [`AddEscape` \ (@AddEscapeDetailed)], [Adds objects specified and removes other objects specified], [`Start` \ `Update` \ `StartEscape`],
  
  [`AIPortal` \ (@AIPortalDetailed)], [Teleports player on collision to another portal (this portal is specified by the parent object of the portal itself)],[`Start` \ `OnTriggerEnter2d`],
  
  [`AudioManager` \ (@AudioManagerDetailed)], [Manage the music that plays on collision. Attached to an empty object with a collision box for when the player enters/exits], [`OnTriggerEnter2D` \ `OnTriggerExit2D`], 
  
  [`BasicEnemyTurret` \ (@BasicEnemyTurretDetailed)], [Inherits from the abstract class `TurretStateMachine`, which changes between 4 states], [`Start` \ `Update` \ `FixedUpdate` \ `ShootHandler` \ `StartTimer` \ `GetVelocity` \ `Fire`],
  
  [`Beam` \ (@BeamDetailed)], [Draws a beam which damages the player if the laser hits the player, the laser stops at any collision (unless it is within a specific `ignoreRayCast` layer)], [`Start` \ `Update` \ `DeathTimer` \ `Shoot` \ `DrawBeam` \ `ManagePhase`], 
  
  [`Bullet` \ (@BulletDetailed)], [Moves the attached gameobject in its current direction at a specified velocity and damages the player on contact (if the player is vulnerable)], [`Update` \ `OnTriggerEnterCollision2D`], 
  
  [`Dash` \ (@DashDetailed)], [Adds the ability to dash to the player], [`Update` \ `StartDash`],
  
  [`DashItem` \ (@DashItemDetailed)], [Grants the player the ability to dash upon collision with the item with this script enabled], [`Update` \ `OnTriggerEnter2D`\  `PlayAudio`],
  
  [`EscapeButton` \ (@EscapeButtonDetailed)], [Changes the `keyManager`'s `escapeStart` to true to when the player collides with the gameobject], [`OnTriggerEnter2D`], 
  
  [`Hearts` \ (@HeartsDetailed)], [Ensures that the number of hearts showing on the canvas corresponds to the number of lives the player has], [Start \ Update \ ShowHearts],
  
  [`HomingDrone` \ (@HomingDroneDetailed)], [Moves the attached object towards the player and damages the player if too close to the player], [`Start` \ `StartPhaseTimer` \ `DeathTimer` \ `FixedUpdate` \ `Update` \ `OnTriggerEnter2D` \ `EndDrone`], 
  
  [`KeyManager` \ (@KeyManagerDetailed)], [Activates specified objects and deactivates other specified objects when the number of keys is 0], [`Update` \ `StartMusic`], 
  
  [`Keys` \ (@KeysDetailed)], [Reduces the `keyNum` variable in `keyManager` on collision with player.], [`OnTriggerEnter2D`], 

  [`KillPlayer` \ (@KillPlayerDetailed)], [Damages the player on collision with the player], [`OnTriggerEnter2D`],
  
  [`Lives` \ (@LivesDetailed)], [Manages the number of lives of the player, when the player should die, and invincibility], [`Start` \ `Update` \ `DamagePlayer` \ `Flicker` \ `InvincibleTimer` \ `OnTriggerEnter2D`], 
  
  [`MovingPlatform` \ (@MovingPlatformDetailed)], [Moves the object between the two specified gameobjects at a constant speed with the specified direction], [`Start` \ `FixedUpdate`], 
  
  [`PlayerMovement2` \ (@PlayerMovement2Detailed)], [Same as the `Player` Script but allows the player to dash], [],
  
  [`PortalParent` \ (@PortalParentDetailed)], [Manages multiple portals and controls what portals the portals teleport to, also manages the cooldown of the portals.], [`Start` \ `GetNextPortal` \ `StartCooldown` \ `DisableAll`], 
  
  [`Shield` \ (@ShieldDetailed)], [Manages the shield which follows the player and blocks projectiles when activated but has a limited amount of time to use], [`Start` \ `Update` \ `FixedUpdate` \ `OnTriggerEnter2D`],
  
  [`ShieldItem` \ (@ShieldItemDetailed)], [Activates the shield upon collision with the player.], [`OnTriggerEnter2D`], 
  
  [`SpeedBoost` \ (@SpeedBoostDetailed)], [Increases the player's movement speed upon collision with the player.], [`OnTriggerEnter2D`], 
  
  [`TimedRoom` \ (@TimedRoomDetailed)], [Starts a timer upon collision with player and activates a portal after this timer has elapsed], [`Start` \ `FixedUpdate` \ `OnTriggerEnter2D`], 
    
  [`Timer2` \ (@Timer2Detailed)], [Same as the Timer class but only uses 1 audio source], [],
  
  [`TimerStop2` \ (@TimerStop2Detailed)], [Stops the timer on collision with player], [`OnTriggerEnter2D`],
  
  [`Turret` \ (@TurretDetailed)], [Manages a turret which fires bullets and can rotate], [`Start` \ `FixedUpdate` \ `FireBullets` \ `Fire`], 
  
  [`TurretStateMachine` \ (@TurretStateMachineDetailed)], [Defines an abstract class for turrets which have 4 set phases], [`SetStartPoint` \ `GetSpawnPoints` \ `MakeEnemy` \ `ShootScatter` \ `ShootStraight` \ `ShootBeam` \ `RotateTurret` \ `GetPrefab`], 
)

#pagebreak()
=== Detailed class description

[TODO] Change order for alphabetic order

==== `AnswerButton` <AnswerButtonDetailed>

[TODO] Image

/ Function description:

- `SetAnswer`: Set the `option` Text GUI string to the input string. 

- `SetIsCorrect`: Set the `newBool` boolean to true or false based on the input.

- `OnClick`: Calls the `battleSystem` gameobject's `OnAnswer` function while passing in either true or false based on `AnswerButton`'s `isCorrect`.

==== `Arrow` <ArrowDetailed>

#figure(
  image("Images/arrow.png", width: 100%),
)

The `Arrow` gameobject is linked to the player in Hub World, DS World Level 3 and DS World Level 5 scenes and follows the player when they move.

/ Function description:

- `Update`: Change the rotation of the arrow to always point towards the specified `GameObject`.

==== `BattleCutscene` <BattleCutscene>

#figure(
  image("Images/battlecutscene.png", width: 100%),
)

The BattleCutscene script exists in every combat level.

/ Function description:

- `Start`: Gets all `image components` from every `gameobject` in the cutscene.

- `Update`: Moves all images to their specified location in the `scene`

- `FadeOutRoutine`: Fades out all images in the cutscene.

==== `BattleHud` <BattleHudDetailed>

[TODO] Image

/ Function description:

- `SetHud`: Initialize HUD with associated `CombatUnit`'s attributes. This includes `unitName`, `currentHP`, `maxHP`.

- `SetHp`: Set the HP shown on the HUD to input amount. If the input amount is less than 0, set it equals to zero.

==== `BattleSystem` <BattleSystemDetailed>

[TODO] Image

/ Function description:

- `Start`: Call the `SetState` function inherited from `StateMachine`, and pass in a newly created `Begin` state to start off combat sequence.

- `OnAnswer`: Call the `ButtonManager`'s `ClearButtons` function, then run the current state's `Answer` function with a passed in boolean from the selected answer.

==== `Begin` <BeginDetailed>

[TODO] Image

/ Function description:

- `Start`: Initialize player and enemy object, waits until combat cutscene finishes playing, then transition into `EnemyTurn` state.

==== `ButtonManager` <ButtonManagerDetailed>

[TODO] Image

/ Function description:

- `DisplayButtons`: Set number of buttons active based on given input amount. Reset selected gameobject to the first button.

- `ClearButtons`: Deactivate all buttons.

==== `CombatUnit` <CombatUnitDetailed>

[TODO] Image

/ Function description:

- `TakeDamage`: Subtract `currentHP` variable by input amount. Returns true if `currentHP` is at or below 0 from the damage, otherwise return false.

==== `Credits` <CreditsDetailed>

#figure(
  image("Images/namlosinghiskneecaps.png", width: 100%),
)

The credits script is linked to the `TextManager`. 

/ Function description:

- `Start`: Runs the `TheEnd` function.

- `Update`: Moves the credit text upwards by a small amount every frame.

- `TheEnd`: Wait for 12 seconds, then display the "The End" text. Wait for another 10 seconds after that and quits the game.

==== `EnableArrow` <EnableArrowDetailed>

#figure(
  image("Images/enablearrow.png", width: 100%),
)


`EnableArrow` is linked to 2 gameobjects in the game: Altar Cutscene 3 in the Hub World and Timer in DS World Level 5. Both gameobjects are not physical gameobjects, but contain trigger colliders to enable the arrow.

/ Function description:

- `OnTriggerEnter2D`: If the player collides with the `GameObject` holding this script, the arrow `GameObject` is enabled.

==== `EnemyTurn` <EnemyTurnDetailed>

[TODO] Image

/ Function description:

- `Start`: Generate a question from `QuestionSetup`'s `Generate` function, then transition to `PlayerTurn`.

==== `GM` <GMDetailed>

[TODO] Image

/ Function description:

- Function: Desc

==== `ImportQuestions` <ImportQuestionsDetailed>

[TODO] Image

/ Function description:

- `Import`: Reads from a CSV, and creates `questionData` `ScriptableObject` from each CSV lines in the specified Resources folder.

- `SplitCSVLine`: Parse through a line and splits on semicolons outside of quotation marks.

==== `Lost` <LostDetailed>

[TODO] Image

/ Function description:

- `Start`: Display text after player loses, call `ButtonManager`'s `ClearButtons` function and quits combat scene.

==== `MainMenuBackground` <MainMenuBackgroundDetailed>

[TODO] Image

/ Function description:

- `Start`: Get the animation component to move the image around the screen.
  
- `Update`: Get a random number between 0 and 9. If a 0 is rolled, the image is blurred. If a 1, 2, 3 or 4 is rolled, the image moves around the scene whereas a 5, 6 or 7 is rolled, the image is blurred and moves around the scene. Otherwise, nothing happens. This random number is rolled once every 4 seconds.

==== `MainMenuButtons` <MainMenuButtonsDetailed>

[TODO] Image

/ Function description:

- Function: Desc

==== `MusicManager` <MusicManagerDetailed>

#figure(
  image("Images/musicmanager.png", width: 100%),
)

`MusicManager` exists in every scene and is not a physical gameobject.

/ Function description:

- `Awake`: Check if an instance of the `MusicManger` script exists in the current scene. If it does, do nothing. If it doesn't, take the instance from the last scene and import into this scene. 

- `PlayMusic`: Plays an audio clip when the function is called.

- `StopMusic`: Stops the current audio clip from running when the function is called.

- `ChangeMusic`: Updates the current playing audio clip to a different one.

==== `PauseMenu` <PauseMenuDetailed>

[TODO] Image

/ Function description:

- Function: Desc

==== `PlayerTurn` <PlayerTurnDetailed>

[TODO] Image

/ Function description:

- `Answer`: Depending on input, run `CombatUnit`'s `TakeDamage` function on either the player unit or the enemy unit. Both actions updates the HUD using the `SetHp` function for HP, changes `BattleSystem`'s `dialogue` variable for text display, and changes the player and enemy sprites with gameObject transforms. After resolving the damage, go to the `Won` or `Lost` state depending on whether the enemy or the player is dead. If none of these occur, transition to `EnemyTurn`.

==== `QuestionData` <QuestionDataDetailed>

[TODO] Image

/ Function description:

- `Start`: Display text after player loses, call `ButtonManager`'s `ClearButtons` function and quits combat scene.

==== `QuestionSetup` <QuestionSetupDetailed>

[TODO] Image

/ Function description:

- `Start`: Display text after player loses, call `ButtonManager`'s `ClearButtons` function and quits combat scene.

==== `Sign` <SignDetailed>

#figure(
  image("Images/sign.png", width: 100%),
)

/ Function description:

- `Update`: If the player is in range of `GameObject` and presses the interact key, a dialogue box is enabled.

- `OnTriggerEnter2D`: Check if the player collides with `GameObject` and if this is the case, the player is in range.

- `OnTriggerExit2D`: Check if the player leaves the collision range and if this is the case, the player is no longer in range and the dialogue box is disabled.

==== `State` <StateDetailed>

[TODO] Image

/ Function description:

- `Start`: Empty function to override. Used whenever a state is instantiated. 

- `Answer`: Empty function to override. Used for answering questions in combat.

==== `StateMachine` <StateMachineDetailed>

[TODO] Image

/ Function description:

- `SetState`: Set the current `State` variable to input state, then run the current state's `Start` function.

==== `Won` <WonDetailed>

[TODO] Image

/ Function description:

- `Start`: Display text after player wins, call `ButtonManager`'s `ClearButtons` function and quits combat scene.

==== `AltarCutscene1` <AltarCutscene1Detailed>

#figure(
  image("Images/altarcutscene1.png", width: 100%),
)

`AltarCutscene1` is triggered when entering one of the locations in the image above in the Hub World, during act 1.

/ Function description:

- `Update`: Load next dialogue box when player presses interact key. If there are no more dialogue boxes to load, destroy the `GameObject`.
  
- `OnTriggerEnter2D`: Check if player collides with `GameObject` and if this is the case, load the first dialogue box.

==== `AltarCutscene2` <AltarCutscene2Detailed>

#figure(
  image("Images/altarcutscene2.png", width: 100%),
)

The `Altar Cutscene 2` gameobject is not a physical gameobject and is enabled during act 1.

/ Function description:

- `Start`: Get the `BoxCollider2D` component from `GameObject` using this script. 
  
- `Update`: Load next dialogue box when player presses interact key. 

- `OnTriggerEnter2D`: Check if player collides with `GameObject` and if this is the case, load the first dialogue box.

==== `AltarCutscene3` <AltarCutscene3Detailed>

#figure(
  image("Images/altarcutscene3.png", width: 100%),
)

The `Altar Cutscene 3` gameobject is not a physical gameobject and is enabled during act 1.

/ Function description:

- `Start`: Get the `BoxCollider2D` component from `GameObject` using this script. 
  
- `Update`: Load next dialogue box when player presses interact key. If there are no more dialogue boxes to load, destroy the `GameObject`. When the 6th dialogue box is loaded, enable the arrow `GameObject`. 

- `OnTriggerEnter2D`: Check if player collides with `GameObject` and if this is the case, load the first dialogue box.

==== `AltarCutscene4` <AltarCutscene4Detailed>

#figure(
  image("Images/altarcutscene4.png", width: 100%),
)

The `Altar Cutscene 4` gameobject is not a physical gameobject and is enabled during act 2. `Altar Cutscene 4` is also used by the `Altar Cutscene 5, 6 and 7` gameobjects, as the script can be used universally by these cutscenes. 

/ Function description:

- `Start`: Get the `BoxCollider2D` component from `GameObject` using this script. 
  
- `Update`: Load the next dialogue box when the player presses the interact key. When the first dialogue box is loaded, start the music track. 

- `OnTriggerEnter2D`: Check if the player collides with `GameObject` and if this is the case, load the first dialogue box.

==== `AltarItemGet` <AltarItemGetDetailed>

#figure(
  image("Images/altaritemget.png", width: 100%),
)

`AltarItemGet` is the same as `AltarCutscene1`, but displays different dialogue. 

/ Function description:

- `Update`: Load next dialogue box when the player presses the interact key. If there are no more dialogue boxes to load, destroy the `GameObject`. 

- `OnTriggerEnter2D`: Check if the player collides with `GameObject` and if this is the case, load the first dialogue box.

==== `CreepyCutscene` <CreepyCutsceneDetailed>

#figure(
  image("Images/creepycutscene.png", width: 100%),
)

The `cutscene` gameobject is not a physical gameobject.

/ Function description:

- `Update`: Load next dialogue box when player presses interact key. When the last dialogue box has been reached, force quit the game and load the URL link.

==== `HubDoor` <HubDoorDetailed>

#figure(
  image("Images/hubdoor.png", width: 100%),
)

Each `Wood Gate` gameobject has a `HubDoor` script attached to it. 2 of the 4 doors, currently do not have a connected room, as we have only created 2 worlds so far.

/ Function description:

- `Update`: Check if the player is in range of the `GameObject` holding this script and if so and the interact key is pressed the door sprite changes to that of an open door and the door no longer has collision so that the player can enter.

- `OnTriggerEnter2D`: Check if the player collides with `GameObject` and if this is the case, the player can press the interact key.

- `OnTriggerExit2D`: Check if the player leaves the collision range of the `GameObject` and if this is the case, the player can no longer press the interact button, the door sprite changes to a closed door and the door's collision is enabled.

==== `HubDoorTrigger` <HubDoorTriggerDetailed>

#figure(
  image("Images/hubdoortrigger.png", width: 100%),
)

Each `Wood Gate` gameobject has a door trigger as a child object attached to it. This door trigger has the script attached to it. 2 of the 4 doors, currently do not have a connected room, as we have only created 2 worlds so far.

/ Function description:

- `OnTriggerEnter2D`: Check if player collides with the GameObject holding this script and if this is the case, the player is moved to a specified location (a different room), the current camera is disabled and the next rooms camera is enabled.

==== `HubTeleport` <HubTeleportDetailed>

#figure(
  image("Images/hubteleport.png", width: 100%),
)

The `HubTeleport` script is attached to each `Magic_Circle` gameobject in the Hub World.

/ Function description:

- `OnTriggerEnter2D`: Check if player collides with the `GameObject` holding this script and if this is the case, a specified scene is loaded.

==== IntroCutscene <IntroCutsceneDetailed>

#figure(
  image("Images/introcutscene.png", width: 100%),
)

The `Intro Cutscene` gameobject is not a physical gameobject, but has a collision trigger that is enabled during act 1.

/ Function description:

- `Update`: Load next dialogue box when player presses interact key. If there are no more dialogue boxes to load, destroy the `GameObject`.

- `OnTriggerEnter2D`: Check if player collides with GameObject and if this is the case, load the first dialogue box.

==== `GMHub` <GMHubdetail>

[TODO] Image

/ Function description:

- Function: Desc

==== `HubBackground` <HubBackgroundDetailed>

#figure(
  image("Images/hubbackground.png", width: 100%),
)

The script is linked to the `Background` gameobject, which is just an image.

/ Function description:

- `Update`: Rotate the background object on the z-axis by a set speed every frame.

==== `NamePlayer` <NamePlayerDetailed>

#figure(
  image("Images/nameplayer.png", width: 100%),
)

The `Text` gameobject which the `NamePlayer` script is attached to is not a physical gameobject.

/ Function description:

- `Start`: Access the player's real-life name by checking their system environment's name (files).

==== `Portal` <PortalDetailed>

#figure(
  image("Images/portal.png", width: 100%),
)

The `Portal` gameobject is enabeled during act 5.

/ Function description:

- `Start`: Gets the `BoxCollider2D` component from the `GameObject` holding this script. Gets the `SpriteRenderer` component from the `GameObject` holding this script. Disables the `BoxCollider2D` component and disables the `SpriteRenderer` component

- `Update`: If the specified cutscene is done, enable both the `BoxCollider2d` and `SpriteRenderer` components.

==== `Button` <ButtonDetailed>

#figure(
  image("Images/button.png", width: 100%),
)

The `button` gameobject exists in every level where the player must answer a question to continue. 

/ Function description:

- `Start`: Get `AudioSource` Component.

- `Update`: If the player is in range of the button `GameObject`, presses the interact key and the button corresponds to a correct answer, then the `OpenDoor` function is run, the wall `GameObject` is disabled and dialogue is shown. If the button corresponds to an incorrect answer, then the `Return` function is run and dialogue is shown.

- `OnTriggerEnter2D`: Check if the player collides with `GameObject` and if this is the case, the player can press the interact key.

- `OnTriggerExit2D`: Check if the player leaves the collision range of the `GameObject` and if this is the case, the player can no longer press the interact button.

- `Return`: Waits for 2 seconds, then destroys the `GameObject` that is attached to this script and disables the corresponding dialogue. 

- `OpenDoor`: Waits for 2 seconds, then destroys the `GameObject` attached to this script and disables the corresponding dialogue.

==== `ButtonSpawner` <ButtonSpawnerDetailed>

#figure(
  image("Images/buttonspawner.png", width: 100%),
)

The `ButtonSpawner` is attached to the `button` gameobject in the image above in DS World Level 5.

/ Function description:

- `Start`: Generates a random number between 0 and 19, then runs the Spawn Function.

- `Update`: Check if the player is in range of the `GameObject` holding this script and if so and the interact key is pressed the specified number of times the button was hit updates and then the `Spawn` function is run with a new random number. If the specified number of hits is reached, then the player `GameObject` is teleported to a specified location.

- `Spawn`: Sets the button `GameObjects` spawn location to that of the index in the location list of the random number.

- `OnTriggerEnter2D`: Check if the player collides with `GameObject` and if this is the case, the player can press the interact key.

- `OnTriggerExit2D`: Check if the player leaves the collision range of the `GameObject` and if this is the case, the player can no longer press the interact button.

==== `CameraFollow` <CameraFollowDetailed>

#figure(
  image("Images/camerafollow.png", width: 100%),
)

The `camera fixer` gameobject is not a physical gameobject, but contains a collision trigger that triggers the script to run.

/ Function description:

- `OnTriggerEnter2D`: If the player collides with the `GameObject` holding this script, the follow camera is enabled and the stationary cameras are disabled.

==== `CameraManager` <CameraManagerDetailed>

#figure(
  image("Images/cameramanager.png", width: 100%),
)

Every Level that contains cameras that do not follow the player have this script attached to it. This exists in the DS and AI world.

/ Function description:

- `OnTriggerEnter2D`: If the player collides with the `GameObject` holding this script, the camera `GameObject` is enabled.

- `OnTriggerExit2D`:  If the player leaves the collision range of the `GameObject` holding this script the camera `GameObject` is disabled.

==== `DoorTriggerLeft` <DoorTriggerLeftDetailed>

#figure(
  image("Images/doortriggerleft.png", width: 100%),
)

This script is attached to the `door trigger left` gameobject, which exists in DS World Level 2 and Level 4.

/ Function description:

- `OnTriggerEnter2D`: If the player collides with the `GameObject`, set the `was_hit` string of the `LabyrinthDoor` script to "left", indicating that the left door has been interacted with.

==== `DoorTriggerRight` <DoorTriggerRightDetailed>

#figure(
  image("Images/doortriggerright.png", width: 100%),
)
This script is attached to the `door trigger right` gameobject, which exists in DS World Level 2 and Level 4.

/ Function description:

- `OnTriggerEnter2D`: If the player collides with the `GameObject`, set the `was_hit` string of the `LabyrinthDoor` script to "right", indicating that the right door has been interacted with.

==== `DoorTriggerTop`: <DoorTriggerTopDetailed>

#figure(
  image("Images/doortriggertop.png", width: 100%),
)
This script is attached to the `door trigger top` gameobject, which exists in DS World Level 2 and Level 4.

/ Function description:

- `OnTriggerEnter2D`: If the player collides with the GameObject, set the `was_hit` string of the `LabyrinthDoor` script to "top", indicating that the top door has been interacted with.

==== `Hole` <HoleDetailed>

#figure(
  image("Images/hole.png", width: 100%),
)

The `Hole` script is attached to a child object of the main camera in DS World Level 6. The child object is initally disabled.

/ Function description:

- `OnTriggerEnter2D`: If the player collides with the GameObject holding this script, the hole `GameObject` is enabled.

==== `LabyrinthDoor` <LabyrinthDoorDetailed>

#figure(
  image("Images/labyrinthdoor.png", width: 100%),
)

The `door manager` object is the parent object of the gameobjects containing the `DoorTriggerLeft`, `DoorTriggerRight` and `DoorTriggerTop` scripts.

/ Function description:

- `OnTriggerEnter2D`: Check if player collides with `GameObject` and if this is the case, get the current string out of a list of strings corresponding to either "top", "left" or "right". If this string is equal to that of the door interacted with (left door = "left", right door = "right", top door = "top"), which is got from the `DoorTrigger` scripts, then increase the counter by one. Once the counter reaches a specified maximum, set the `finished` boolean to true.

==== `LevelChanger` <LevelChangerDetailed>

#figure(
  image("Images/levelchanger.png", width: 100%),
)

The `LevelChanger` script exists in every level in DS World and is attached to the `change level` gameobject.

/ Function description:

- `OnTriggerEnter2D`: Check if player collides with `GameObject` and if this is the case, load the next scene ID. Scene ID is set in the build settings.

==== `PlayerIceScript` <PlayerIceScriptDetailed>

#figure(
  image("Images/playericescript.png", width: 100%),
)

The `player` gameobjecct holds this script, but only in DS World Level 5.

/ Function description:

- `Update`: Updates the player's position based on the directional input keys pressed and updates the player's animation sprites based on this movement. Also disables the players' movement when on ice.

- `FixedUpdate`: Physically moves the player rather than just updating the movement values. 

- `Flip`: Flips the player sprite when moving left.

- `OnTriggerEnter2D`: Check if player collides with a `GameObject` of type ice and if this is the case, disables the movement input.

- `OnTriggerExit2D`: Check if player leaves the collision range of the ice `GameObjects` and if this is the case, re-enable the player's movement input.

==== `PlayerScript` <PlayerScriptDetailed>

#figure(
  image("Images/playerscript.png", width: 100%),
)

The `player` gameobject holds this script in every level in DS World and the Hub World. 

/ Function description:

- `Update`: Updates the players position based on the directional input keys pressed and updates the players animation sprites based on this movement. Also disables the player's movement when on ice.

- `FixedUpdate`: Physically moves the player rather than just updating the movement values. 

- `Flip`: Flips the player sprite when moving left.

- `OnTriggerEnter2D`: Check if player collides with `GameObject` of type ice and if this is the case, disables the movement input for some time.

- `OnTriggerExit2D`: Check if player leaves the collision range of the ice `GameObjects` and if this is the case, re-enable the player's movement input.

- `Unfreeze`: Waits for a specified amount of seconds, then re-enables the player's movement input.

- `Frozen`: Waits for 5 seconds, then reloads the current scene.

==== `RemoveArrow` <RemoveArrowDetailed>

#figure(
  image("Images/removearrow.png", width: 100%),
)

The remove `arrow` gameobject is not a physical obejct but has 2 collsion triggers attatched that activate the scripts function.

/ Function description:

- `OnTriggerEnter2D`: Check if player collides with `GameObject` and if this is the case, destroys the arrow `GameObject`.

==== `SecretRoom` <SecretRoomDetailed>

#figure(
  image("Images/secretroom.png", width: 100%),
)

The `SecretRoom` script is attached to a `wall tile` gameobject.

/ Function description:

- `Update`: If player is in range of `GameObject`, then disable its physical collision.

- `OnTriggerEnter2D`: Check if player collides with `GameObject` and if this is the case, the player is in range.

- `OnTriggerExit2D`: Check if player leaves the collision range and if this is the case, the player is no longer in range and the physical collision is re-enabled.

==== `Snow` <SnowDetailed>

#figure(
  image("Images/snow.png", width: 100%),
)

The `snow` gameobject is not a physical gameobject.

/ Function description:

- `Start`: Gets the child `GameObject`. 
  
- `Update`: If particle effects are ever disabled in the pause menu, then the child `GameObject` is disabled.

==== `SnowGenerator` <SnowGeneratorDetailed>

#figure(
  image("Images/snowgenerator.png", width: 100%),
)

The `snow generator` gameobject is a child object of the `snow` gameobject.

/ Function description:

- `Update`: Checks with camera is currently active and move the `snow generator` `GameObject` above the currently active camera.

==== `Spawner` <SpawnerDetailed>

#figure(
  image("Images/spawner.png", width: 100%),
)

The `spawner` gameobject exists in DS World Level 2 and level 4 only.

/ Function description:

- `Start`: disables last used camera.

- `Update`: Check if the `finished` boolean has been triggered from the `LabyrinthDoor` script.

- `FixedUpdate`: move the player up by a fixed amount (simulates the player pressing a directional input).

- `OnTriggerEnter2D`: Check if player collides with `GameObject` and if this is the case teleport the player to a specified location, update the animation sprites and disable the player's movement input.

- `MovePlayer`: Wait 0.75 seconds, then re-enable the player's movement input.

==== `SpecialTimer` <SpecialTimerDetailed>

#figure(
  image("Images/specialtimer.png", width: 100%),
)

The `SpecialTimer` script is attached to the `timer` gameobject in DS World level 5 and the `timer` gameobject is not a physical object.

/ Function description:

- `Update`: Update the timer by counting down. 

- `UpdateTimer`: Update the UI for the timer.

- `OnTriggerEnter2D`: Check if player collides with `GameObject` and if this is the case, start the timer countdown.

- `Restart`: Wait for 5 seconds, then reload the current scene.

- `PlayMusic`: Wait for 3 seconds, then change the music and play the music.

==== `Teleporter` <TeleporterDetailed>

#figure(
  image("Images/teleporter.png", width: 100%),
)

The `teleporter` gameobject is not a physical object but has a collision trigger attatched that activate the scripts function.

/ Function description:

- `OnTriggerEnter2D`: Check if player collides with `GameObject` and if this is the case, move the player to a specified loction in the scene and disable the hole `GameObject`.

==== `Timer` <TimerDetailed>

#figure(
  image("Images/timer.png", width: 100%),
)

The `timer` gameobject has the `Timer` script attached, which is used in DS World Level 3 and 6.

/ Function description:

- `Update`: Update the timer by counting down. 

- `UpdateTimer`: Update the UI for the timer.

- `OnTriggerEnter2D`: Check if player collides with `GameObject` and if this is the case, start the timer countdown.

- `Restart`: Wait for 5 seconds, then reload the current scene.

- `PlayMusic`: Wait for 3 seconds, then change the music and play the music.

==== `TimerStop` <TimerStopDetailed>

#figure(
  image("Images/timerstop.png", width: 100%),
)

The `timer_stop` gameobject has the `TimerStop` script attached, which is used in DS World Level 3 and 6. The `timer_stop` gameobject is not a physical gameobject.

/ Function description:

- `OnTriggerEnter2D`: Check if player collides with `GameObject` and if this is the case, stop the timer from running.

==== `TimerStopSpecial` <TimerStopSpecialDetailed>

#figure(
  image("Images/timerstopspecial.png", width: 100%),
)

The `timer_stop` gameobject has the `TimerStopSpecial` script attached, which is used in DS World Level 5. The `timer_stop` gameobject is not a physical gameobject.

/ Function description:

- `OnTriggerEnter2D`: Check if player collides with `GameObject` and if this is the case, stop the timer from running.

==== `WallMaker` <WallMakerDetailed>

#figure(
  image("Images/wallmaker.png", width: 100%),
)

Thw `wall maker` gameobject is not a physical object but has a collision trigger attatched that activate the scripts function.

/ Function description:

- `OnTriggerEnter2D`: Check if player collides with `GameObject` and if this is the case, enable a `Child` `GameObject`, which has a collision `GameObject`.

==== `AddEscape` <AddEscapeDetailed>

/ Function description:

- `Start`: Intializes objects to add as an array which is made up of all the children of an object specified.
  
- `Update`: checks if the objects should start being added based on public boolean variable.
  
- `StartEscape`: Adds the desired objects, removes the other objects specified.

==== `AIPortal` <AIPortalDetailed>

#figure(
image("Images/AIPortal.png", width:100%)
)


/ Function description:

- `Start`: Initialise parent from `GameObject`, initialise player object by getting its tag.
  
- `OnTriggerEnter2D`: If the parent object is not on cooldown, and if the object which collided is the player, teleports the player to the next portal.

==== `AudioManager` <AudioManagerDetailed>

#figure(
  image("Images/AudioManager.png", width:100%)
)

/ Function description:

- `OnTriggerEnter2D`: Plays background music specified.
  
- `OnTriggerExit2D`: Stops background music played when the player entered the box.

==== `BasicEnemyTurret` <BasicEnemyTurretDetailed>

#figure(
  image("Images/BasicTurret.png", width:100%)
)

/ Function description:

- `Start`: Calls the `Set Start` Rotation and `Get Spawn Points` methods from the abstract parent class.
  
- `FixedUpdate`: Calls the `RotateTurret` method from the abstract parent class.
  
- `ShootHandler`: Alternates through each state of the machine and calls the `Fire` method whilst the object is in a state (waits specified reloading time for this state between each shot). Calls the `Coroutine` `StartTimer` to change state. Changes the direction of the turret if the boolean `statesChangesDirection` is set to true, calls at the end to move on to the next state.
  
- `StartTimer`: Waits an amount of time specified for current state and then changes to the next state based on `nextState` dictionary.

- `GetVelocity`: Uses a `switch` statement to get the velocity of the current state.
  
- `Fire`: Uses a `switch` statement to get the appropriate firing function of the current state.

==== `Beam` <BeamDetailed>

[TODO] Image

/ Function description:

- `Start`: Calls the `Coroutine` `DestroyTimer` and `ManagePhase`, intialises the `line renderer` and `player` variables.
  
- `Update`: Calls the shoot function and updates the gameobject's position and rotation based on the spawn point's position and rotation.
  
- `DestroyTimer`: Waits a specified time and then destroys the gameobject.

- `Shoot`: Uses Unity's 2D Physics' `Raycast` method to get the stopping point the laser, and the box which collided with it. Calls the player's `DamagePlayer` method if the raycast hit the player (whilst the beam is not in its start phase), it then draws the beam using the position of the raycast hit as the end position.
  
- `DrawBeam`: Takes in two arguments, `startPosition` and `endPosition` and uses this to draw the beam using the `line renderer` of the beam.
  
- `ManagePhase`: Changes the colour and phase of the beam after a specfied amount of time.

==== `Bullet` <BulletDetailed>

[TODO] Image

/ Function description:

- `Update`: moves the bullet with specified velocity towards its current direction.
  
- `OnTriggerEnterCollision2D`: Calls the player's `DamagePlayer` function if the object it collided with has the "`Player`"" tag and the player was not dashing. Destroys the `gameobject` if the object collided with has the "`Collide`" tag.

==== `Dash` <DashDetailed>

/ Function description:

- `Update`: Calls the `StartDash` function if the dash is not on cooldown and the player presses the space key.
  
- `StartDash`: Moves the player in its current direction for a set amount of time and starts puts the dash on cooldown.

==== `DashItem` <DashItemDetailed>

[TODO] Image

/ Function description:

- `Update`: Pauses current background music if any background music is playing.

- `OnTriggerEnter2D`: Sets the `canDash` value of the `Dash` object attached to the player's to true.

- `PlayAudio`: Plays the attached sound effect and disables the object's collision box and sprite renderer. Waits for a set amount of time and then stops the sound effect and resumes the background music.

==== `EscapeButton` <EscapeButtonDetailed>

[TODO] Image

/ Function description:

- `OnTriggerEnter2D`: if the collided object has the "`Player`", sets the `key manager`'s `escapeStart` boolean to true and destroys the gameobject.

==== `Hearts` <HeartsDetailed>

[TODO] Image

/ Function description:

- `Start`: Initalises the `player` variable, and the `heart` variables by getting the child objects of the object.
  
- `Update`: Gets the number of lives of the player and calls the `ShowHearts` function if the number of lives has changed.
  
- `ShowHearts`: Activates the hearts on the canvas to active if their index in the hearts array is less than the number of hearts, and deactivates the rest.

==== `HomingDrone` <HomingDroneDetailed>

[TODO] Image

/ Function description:

- `Start`: Initialises the player object variable and starts the coroutines `DeathTimer` and `StartPhaseTimer`

- `StartPhaseTimer`: Waits a specified amount of time and then sets the `homingPhase` boolean to true.
  
- `DestroyTimer`: Waits a specified amount of time and then starts the animation and starts the `EndDrone` coroutine.
  
- `FixedUpdate`: If during `homingPhase`, moves the object towards the player, else moves object in current direction.
  
- `Update`: If the object is not in ending animation and the player is close enough, calls the player's `DamagePlayer` method, starts the end animation and calls the `EndDrone` coroutine.
  
- `OnTriggerEnter2D`: If the collided object has the "`Collide`" tag, starts the `EndDrone` Coroutine.
  
- `EndDrone`: Waits a specified amount of time and then destroys the object.

==== `KeyManager` <KeyManagerDetailed>


/ Function description:

- `Update`: Checks the number of keys, if this is 0 activates and deactivates specified objects and (if specified) calls the `StartMusic` coroutine.
  
- `StartMusic`: Deactivates/activates the specified gameobjects, and changes the audio playing.

==== `Keys` <KeysDetailed>

[TODO] Image

/ Function description:

- `OnTriggerEnter2D`: If the object that collided has the "`Player`" tag, reduces the variable `keyNum` of the `KeyManager` by 1, and destroys the object.

==== `KillPlayer` <KillPlayerDetailed>

[TODO] Image

/ Function description:

- `OnTriggerEnter2D`: If the collided object has the player tag, calls the `DamagePlayer` method of the player.

==== `Lives` <LivesDetailed>

[TODO] Image

/ Function description:

- `Start`: Initialise the `sprite` and `anim` variables by getting them from the object component.
  
- `Update`: Checks the number of lives of the player and reloads the scene if this is 0.
  
- `DamagePlayer`: If the player is not invincible, reduces the number of lives by 1, sets invincibility to true and calls the `Flicker` and `Invincible Timer` coroutines.

- `Flicker`: turns the animation and sprite on and off at specified rate whilst the player is invincible.

- `InvincibleTimer`: Waits a set number of seconds and then turns the invincibility off.

- `OnTriggerEnter2D`: If the collided object has the "`Heart`" tag, increase the number of lives by 1 and destroy the object which collided (not the object the script is attached to).

==== `MovingPlatform` <MovingPlatformDetailed>

[TODO] Image

/ Function description:

- `Start`: Gets the `startPoint` and `endPoint` as the positions of the specified start and end gameobjects, sets the velocity variable to the specified velocity.

- `FixedUpdate`: Change the position of the object by the set velocity. Checks if the object is within a specified distance from the end/start (depending on `movingDown` boolean) and if so multiples the velocity by -1 to reverse its direction.

==== `PlayerMovement2` <PlayerMovement2Detailed>

/ Function description:

- `Function`: Desc

==== `PortalParent` <PortalParentDetailed>

[TODO] Image

/ Function description:

- `Start`: Gets the number of portals and initalises the portals array.

- `GetNextPortal`: Starts the teleport cooldown and returns the next portal in the array (loops back around on the last index).

- `StartCooldown`: Sets the `cooldown` boolean to true, then waits for a specified amount of time before switching the `cooldown` boolean back to false. If the portal should disable on use, calls the `DisableAll` function.

- `DisableAll`: Deactives all the portals in the portal array.

==== `Shield` <ShieldDetailed>

[TODO] Image

/ Function description:

- `Start`: Intialises the `player`, `shieldBar` (the slider on the canvas), `shieldCollider` and `sprite` variables, sets the shield to ignore collision with the player.

- `Update`: if the `canShield` boolean is true and the player holds down the "`Fire3`" button, activates the collider and sprite of the shield, else, disables the sprite and collider of the shield. Updates the shield's position so that is equal to that of the player.
  
- `FixedUpdate`: if the player `isShielding`, decrease the value of the shield bar slider by a fixed rate. If the value of the shield bar is 0, set the `canShield` boolean to false.

==== `ShieldItem` <ShieldItemDetailed>

[TODO] Image

/ Function description:

- `OnTriggerEnter2D`: If the collided object has the player tag, set the `canShield` boolean of the shield to true, activate the shield and destroy the object attached to the script.

==== `SpeedBoost` <SpeedBoostDetailed>

[TODO] Image

/ Function description:

- `OnTriggerEnter2D`: If the collided object has the "`player`" tag, changes the player's movement speed to 10 (double normal movement speed) and destroys the object the script is attached to.

==== `TimedRoom` <TimedRoomDetailed>

[TODO] Image

/ Function description:

- `Start`: Initialises portal object and sets the `timeBar` value to 0, deactivates the portal.
  
- `FixedUpdate`: If the timer is on, decreases the value of the `timeBar`. If this value is 0, activate the portal and deactive the parent of the slider, resets the value of the `timeBar`.

- `OnTriggerEnter2D`: If the collided object has the "`Player`" tag, turn the timer on and enable the slider as well as the parent object of the silder.

==== `Timer2` <Timer2Detailed>

[TODO] Image

/ Function description:

- Function: Desc

==== `TimerStop2` <TimerStop2Detailed>

[TODO] Image

/ Function description:

- `OnTriggerEnter2D`: If the collided object has the "`Player`" tag, sets the `stoptimer` boolean of the timer to true and enables collider of the object the script is attached to.

==== `Turret` <TurretDetailed>

[TODO] Image

/ Function description:

- `Start`: Initialises the start angle.

- `FixedUpdate`: Rotates the object by specified speed, inverses direction if close to start or end angle.

- `Fire`: Takes in a `spawn` gameobject as a parameter and instantiates a specified prefab at the `spawn`'s position and rotation. Sets the instantiated object's speed to a specified speed.

- `FireBullets`: Waits for a specified number of seconds and then calls the Fire method at a specified rate, after which it reloads for a specified number of seconds. If the turret is meant to shoot in both directions, calls the Fire method twice for each spawn point.

==== `TurretStateMachine` <TurretStateMachineDetailed>

/ Function description:

- `SetStartPoint`: Initialise the starting angle.

- `GetSpawnPoints`: Makes an array with all the children objects of the object which have "`Point`" in their name.

- `MakeEnemy`: For all spawn points with "`All`" or "`Enemies`" in their name, instantiate an object (which must have the `homingDrone` class) with the spawn point's position and rotation, and set the speed of this object to the speed specified.

- `ShootScatter`: For all spawn points with "`All`" or "`Enemies`" in their name, instantiate a `bullet` with a specified speed a specified rate.

- `ShootStraight`: For all spawn points with "`All`" or "`Enemies`" in their name, instantiate a `bullet` with a specified speed a specified number of times at a specified rate.

- `ShootBeam`: For all spawn points with "`Beam`" in their name, instantiate a `beam` which lasts for a specified time.

- `GetPrefab`: Returns the prefab corresponding to the current state.

==== `name` <Detailed>

[TODO] Image

/ Function description:

- `Function`: Desc

= Glossary

[TODO] Add more sources
- Maybe find a link to an online game glossary?

Player: The person controlling the game. Similar to how the person controlling a car is a driver.

Player Character: The character inside the game that the player controls.

NPC: Non-Player Character, any character in the game that is not the player character.

Gamepad: A gamepad is a type of video game controller held in two hands, where the fingers (especially thumbs) are used to provide input. @gamepad-wiki

Level: A level is any space available to the player during the course of completion of an objective.

World: A world is a level or collection of levels with a specific theme.

Portal: Inspired by the concept of a wormhole, it is a spacial distortion that will transport the player to a different world.

Sprite:

Sprite sheet:

2D: Two-dimensional,

HP: Hit Points,

Enemy:

Boss:

HUD: Heads-up display, 

#pagebreak()
#bibliography("refs.yml")
