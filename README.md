# Blood Balance Game

This is a 'serious' game made for the course Technology for Games during my MSc in Artificial Intelligence at the University of Amsterdam. The game is implemented with Unity3D. The 'serious' purpose of this game, is to raise awareness about blood balance.

### Story

A blood drop (the player), runs in the veins and tries to avoid microbes. Apart from avoiding them, he needs to hit them until they are destroyed, so that his health is boosted. When the microbes hit the blood drop–player, he loses energy (health) and he's prone to lose the game, whilst when getting blood cells (if they are needed) he becomes stronger (healthier). The player is also prone to lose the game if he gains cells that are not needed and they harm the blood chemical balance. 

<!-- In order to get a balance of white and red cells, if white-cells are doubled the red-cells the blood’s health decreases, and if no red cells exists his health is halved. This creates a bit of action while the player needs to think and act fast. -->
 
While running the player can lose red-cells, and if he shoots he loses white cells. This is inspired by the role of white cells in human blood which is to protect and boost the immune system.


### Space

The world is a 2D discrete world where the player only moves forward in a straight line, and jumps up to a certain height.

![](space.png?raw=true "Fig.1")


### Attributes and States

The blood drop has a level of white and red cells, speed, strength and a position. The blood drop–player is running with a constant speed, able to jump, or shoot, but not at the same time. The microbes have a position attribute, while the microbes have also a health bar. Both green and blue microbes have the same strength and need the same amount of shoots to be destroyed.

### Actions and Goals

The player has only one subject to control; the blood drop. The blood drop has only two possible operative actions. Jump (either to avoid a microbe or to gain a blood cell), or shoot a microbe that is in the human’s blood. The action mechanics are very simple, and do not give rise to emerge behavior except from the resultant actions of choosing between being weak (avoiding microbes) or being vulnerable (losing white cells when shooting microbes). The goal of the game is simply finish the platform with a good score, where score is the time.
Sub-goals are: to collect the appeared blood cells (keep a good health condition), and to avoid or destroy the microbes.

### Interface

Before starting the game, these few basic rules are available, to ensure the player knows how to play and explain which keys to use (fig.2). In the game view, there is an indication of the amount of red and white cells obtained (top left of the scene), so that the player has the important information during the whole game. If the player is prone to lose, a constant heart beat sound heard in the game becomes faster, making the player more anxious. Moreover, the microbes have health
bars, showing how much power they lose when being hit. Innovation is introduced by switching the worlds while playing, i.e. changing the background (fig.3), to confuse or excite the player.

![](instructions.png?raw=true "Fig.2")

![](background.png?raw=true "Fig.3")

The overall game has a minimalistic view, easy to focus on the goal, and easy to play by everyone. It follows the 'old school' playing games combined with modern graphics. The fact that the main character is not a human, but a blood drop, makes the game more story-wise and interesting.


### TODOs

1. generate from the beginning the data regarding a "track", so that each time you lose and restart you play the same "track".
2. check why (and if) microbes appearing after some time are bigger
3. increase the speed with time or based on the track or based on settings
4. decrease health if microbes are not destroyed
5. improve UI
    - add a button that pauses and goes to settings while playing
    - make the info more appealing
6. maybe add an "age" bar ? or win lives ?
