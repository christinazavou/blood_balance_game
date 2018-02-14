# blood_balance_game
A 'serious' game made for the course Technology for Games, in Unity3D. The 'serious' purpose of this game, is to raise awareness about blood balance.

### Story

A blood drop (the player), runs in the veins and tries to avoid microbes. Apart from avoiding them, he needs to hit them until they are destroyed, so that his health is increased. When the microbes hit the blood drop–player, he loses energy (health) and he's prone to lose the game, whilst when getting blood cells (if they are needed) he becomes stronger (healthier). The player is also prone to lose the game if he gains cells that are not needed and they harm the blood chemical balance. 

<!-- In order to get a balance of white and red cells, if white-cells are doubled the red-cells the blood’s health decreases, and if no red cells exists his health is halved. This creates a bit of action while the player needs to think and act fast. -->
 
While running the player can lose red-cells, and if he shoots he loses white cells. This is inspired by the real role of white cells which is to protect and boost the immune system.


### Space

The world is a 2D discrete world where the player only moves forward in a straight line, and jumps up to a certain height.

[Fig.1](space.png?raw=true "Title")

Attributes and States

The blood drop has a level of white and red cells, speed, strength and a position. The blood drop–player is running with a constant speed, able to jump, or shoot, but not at the same time. The microbes have a position attribute, while the microbes have also a health bar. Both green and blue microbes have the same strength and need the same amount of shoots to be destroyed.

### Actions and Goals

The player has only one subject to control; the blood drop. The blood drop has only two possible operative actions. Jump (either to avoid a microbe or to gain a blood cell), or shoot a microbe that is in the human’s blood. The action mechanics are very simple, and do not give rise to emerge behavior except from the resultant actions of choosing between being weak (avoiding microbes) or being vulnerable (losing white cells when shooting microbes). The goal of the game is simply finish the platform with a good score, where score is the time.
Sub-goals are: to collect the appeared blood cells (keep a good health condition), and to avoid or destroy the microbes.

### Interface

Before starting the game, these few basic rules are available, to ensure the player knows how to play and explain which keys to use (fig.2). In the game view, there is an indication of the amount of red and white cells obtained (top left of the scene), so that the player has the important information during the whole game. If the player is prone to lose, a constant heart beat sound heard in the game becomes faster, making the player more anxious. Moreover, the microbes have health
bars, showing how much power they lose when being hit. Innovation is introduced by switching the worlds while playing, i.e. changing the background (fig.3), to confuse or excite the player.

[Fig.2](instructions.png?raw=true "Title")

[Fig.3](background.png?raw=true "Title")

The overall game has a minimalist view, easy to focus on the goal, and easy to play by everyone. It follows the old school playing games combined with modern graphics. The fact that the main character is not a human, but a blood drop, makes the game more story-wise and interesting.


### Future Additions

- increase speed with time
- decrease health if microbes are not destroyed