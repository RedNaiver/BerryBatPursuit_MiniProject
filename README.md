# BerryBatPursuit_MiniProject
Programming of interactive 3D worlds, MED3 - Mini project

Project Description / Initial idea
Berry Bat Pursuits is a Mini 3D platforming game, where the player controls a Bat-like creature and collects berries around the game-map. The initial idea was inspired by the Nintendo game Super Mario Odyssey (Nintendo, 2017), where the main character, Mario, runs around different worlds and collects Power Moons. Where in this project, you are instead a Bat, which collected Berries. 

Design & 3D-Modelling
The design of the Bat (Figure 1) was inspired by the Pokémon franchise, where the character was drawn using Paint Tool Sai, and modelled and animated in Blender. For Blender-screenshots [See Appendix A] The animation process of the model was learned through the tutorial “Walking Animation in Blender” by the YouTube channel Critical Giants. (Critical Giants, 2022) All imported 3D-Assets and textures (Berry, grass, star-particles etc.) were created by me. All sound effects were provided from the website Mixkit. (MixKit, 2024)

Game-Map
The game-map was inspired by a level-world in the game Super Mario Odyssey called “Cap Kingdom”. The map has black grass and a black sky, along with a huge yellow moon in the background. Which inspired the overall aesthetic of a ”night” world in my game, with glowing objects floating around. The bat sets out to collect glowing berries as its mission. (Figure 2) For the glowing effect of the stars, post-processing was used and applied to the Main Camera. 

Hierarchy Objects
The initial Hierarchy is sorted and divided into 8 categorized “GameObjects” which each have their own purpose. [See Appendix B], a Gameobject for the “Player”, “CameraManager”  containing a CameraPivot object and the Main Camera, applied with post-processing for the Bloom effect of the berries and stars.  “UI_Canvas” with all the UI-related elements, such as text, icons and replay button, and the last 4 GameObjects keep track of all the Map-related objects in the scene. 
“The Map” keeping track of the main boxed-in playground components and the stars in the space background. “Obstacles” being for the pillars, tunnels, hills and platforming in the scene. “MapDecorations” for the decorations, being all the grass in the scene. “MovingPlatforms” for the animated platforms, and finally “AllBerries” which, you guessed it, is home to all the Berry prefabs in the scene. Each of the berries has an idle animation and a particle system, and its dedicated script and colliders. 

Movement / 3rd Person Controller Scripts
Note: All scripts can be fully seen within the projects repository linked in down in references. 
For the game's 3rd person controller, the YouTube tutorial series “How to create a 3rd person controller in Unity” by Sebastian Graves was used (Sebastian Graves, 2021). This controller makes use of the New Input System, using an Action Map. (Figure 3) The scripts for the controller consist mainly of 5 different scripts, where each of them focuses on specific aspects of the controller.

  InputManager → Reads the players inputs and converts them into actions for the movement, sprinting, and jumping.
  PlayerManager → Acts as a “lobby” or central controller to manage the inputs from movement and interactions. Processes the inputs, updates the states, and delegates actions, etc. It’s just a way to keep everything that is called in one central place.
  PlayerLocomotion → Manages the players movement, falling, jumping and rotations.
  AnimationManager → Manages the animations for the player character, which includes the transitions and values. 
  CameraManager → Manages the 3rd-person camera system, which includes the camera to follow the player rotations, along with collision adjustments and adaptation, if for example it’s angled into other objects in the scene. 

Berry Collection Scripts
For the inventory / berry collection system, the YouTube tutorial “How to Collect Items (Unity Tutorial)” by Ketra grames was used. (Ketra Games, 2022), with the addition of adding a simple sound effect upon collision with the object. The system of the collection divided into 3 very simple scripts, along with an additional script for the display of some UI elements:

  PlayerInventory → Tracks the player's inventory of collected berries and triggers events. When a berry is collected, it is added to the counter, and if all 10 berries have been collected, we invoke the event OnAllBerriesCollected..
  CollectibleBerry → handles the interactions with berries in the game. So when the player collides with a berry, the method BerryCollected() on the player's inventory is called, along with a sound being played. We use an OnTriggerEnter for this. 
  InventoryUI → Manages the UI for displaying the player's berry counter and victory message. It subscribes to the OnBerryCollected and  OnAllBerriesCollected events to update the counter or show the victory message, and also show the restart button so the player can try again. 
  GameManager Script → and finally, a script to manage the reloading of the scene, and showing the restart button upon completing the level. 

Timetable 
The initial time used on each process within development of the game. I’d like to note however, that these are very rough estimates of the time spent on the different parts, as the hours marked for each process varied when it came to debugging, and taking breaks in between. 


3D-Modelling (Character + Assets) : 12 Hours
Animations (Character + Assets) : 6 Hours
Scripting : 8 Hours
Level-Map : 4 Hours
Materials : 1 Hour
Physics : 1 Hour
Debugging : 8 hours


References / Tutorial Links
  Nintendo. (2017, October 27). Super Mario Odyssey. https://www.nintendo.dk/nintendo-switch-familien/spil/super-mario-odyssey
  Critical Giants. (2022, June 10). Walking Animation in Blender [Video]. YouTube. https://www.youtube.com/watch?v=zJzY6Sy_MCU
  Sound effect: “Video game treasure” and “Completion of a level”. Download free game Sound Effects | MixKit Eovendo (2024). https://mixkit.co/free-sound-effects/game/
  Sebastian Graves. (2021, January 1). HOW TO CREATE A THIRD PERSON CONTROLLER IN UNITY [Video]. YouTube. https://www.youtube.com/watch?v=gdp-O6z8x28
  Ketra Games. (2022, January 25). How to collect items (Unity tutorial) [Video]. YouTube. https://www.youtube.com/watch?v=EfUCEwKmcjc

Link to Unity Project Files - Github
  Github repository link: https://github.com/RedNaiver/BerryBatPursuit_MiniProject

Showcase Video
  Link to Video: https://www.youtube.com/watch?v=88Z3ov4boYA



