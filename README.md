# Labirinth Coin Challenge 
- **Developer**: ValliKaz 
- **Assets**: 
  - Third-person controller and camera logic by the EasyStart Third Person Controller team.
  - Maze assets by the Maze Modular Puzzle Kit creators.
  - Skybox assets by Key Mouse (Customizable Skybox).
  - Environment assets by Moon Tribe (Flat Cube Environment).
## Project Overview
"Labirinth Coin Challenge" is a 3D Unity game where players navigate a maze as a third-person capsule character. The objective is to collect all coins scattered throughout the maze and reach the "Gate" within a 2-minute time limit. The game features a Main Menu with instructions, background music, sound effects for coin collection and win/lose conditions, and a modular maze design.

### Key Features
- **Gameplay**: Move with WASD/arrow keys, sprint with Shift, jump with Spacebar, collect coins, and reach the Gate.
- **Win Condition**: Collect all coins and touch the Gate within 120 seconds.
- **Lose Condition**: Timer runs out before completing the objective.
- **UI**: In-game HUD (timer, coin count), Result Canvas (win/lose messages), and Main Menu with instructions.
- **Audio**: Background music for Main Menu and game, plus sound effects for coin collection, winning, and losing. Was downloaded from Web-site [freeSound](https://freesound.org/).
- **Assets Used**:
  - [EasyStart Third Person Controller](https://assetstore.unity.com/packages/tools/game-toolkits/easystart-third-person-controller-278977)
  - [Maze Modular Puzzle Kit](https://assetstore.unity.com/packages/3d/environments/maze-modular-puzzle-kit-302221)
  - [Customizable skybox](https://assetstore.unity.com/packages/2d/textures-materials/sky/customizable-skybox-174576)
  - [Flat Cube Environment](https://assetstore.unity.com/packages/3d/environments/fantasy/flat-cube-environment-195664)

### Scenes
1. **MainScene**: Title screen with "Start Game," "Instructions," and "Exit Game" buttons, plus background music.
2. **GameScene**: The core gameplay scene with the maze, player, coins, Gate, and audio effects.

---

## Game Preview
Below are GIF previews showcasing key moments and features of the LabyrinthCoinChallenge game:

- **Main Menu & Instructions**: Displays the main menu with game instructions.
![MainMenu_Instructions](https://github.com/user-attachments/assets/c717f2fa-1ae3-47fb-b1fa-c3e03ebe1ed0)

- **Required Notification & Gate Reaction**: Shows the notification system and gate interaction.
![RequiredNotification_GateReact-ezgif com-optimize](https://github.com/user-attachments/assets/66684498-287a-4821-b0ef-1a7df1bed5a0)

- **Win Game**: Demonstrates the winning scenario.
![WinGame-ezgif com-optimize](https://github.com/user-attachments/assets/ff5528f0-adbc-414d-99fe-2d849410bb9d)

- **Lose Game**: Illustrates the game-over scenario.
![LoseGame-ezgif com-optimize](https://github.com/user-attachments/assets/f1c3c17e-305b-4137-ac42-e9bf6a4b9359)

---

## How to Install and Play the Game

### Prerequisites
- **Unity**: Version 2022.3 LTS or later (recommended).
- **Operating System**: Windows, macOS, or Linux (for development and building).
- **Audio Files**: Background music (e.g., `MainMenuMusic.wav`, `MainGameMusic.wav`), and sound effects (`WinSound.wav`, `LoseSound.wav`, `CoinCollect.wav`)—replace placeholders if not included.

### Installation Steps
1. **Download Unity**:
   - Install Unity Hub from [Unity's official website](https://unity.com/download).
   - Use Unity Hub to install Unity version 2022.3 LTS or later.

2. **Obtain Project Files**:
   - Download the "Labirinth Coin Challenge" project files from the provided source (e.g., GitHub repository, developer's website, or asset bundle).
   - Extract the project folder to a local directory.

3. **Import Assets**:
   - Open Unity Hub, click "Add," and select the extracted project folder.
   - Open the project in Unity.
   - Import required assets from the Unity Asset Store:
     - [EasyStart Third Person Controller](https://assetstore.unity.com/packages/tools/game-toolkits/easystart-third-person-controller-278977)
     - [Maze Modular Puzzle Kit](https://assetstore.unity.com/packages/3d/environments/maze-modular-puzzle-kit-302221)
     - [Customizable Skybox](https://assetstore.unity.com/packages/2d/textures-materials/sky/customizable-skybox-174576)
     - [Flat Cube Environment](https://assetstore.unity.com/packages/3d/environments/fantasy/flat-cube-environment-195664)
   - Follow each asset’s import instructions in Unity.

4. **Add Audio Files**:
   - Download audio files from [Freesound](https://freesound.org/) or use provided placeholders.
   - Place audio files (`MainMenuMusic.wav`, `MainGameMusic.wav`, `WinSound.wav`, `LoseSound.wav`, `CoinCollect.wav`) in the project’s `Assets/Audio` folder.
   - Assign these files to the corresponding Audio Source components in the `MainScene` and `GameScene` via the Unity Editor.

5. **Build the Game**:
   - In Unity, go to `File > Build Settings`.
   - Select your target platform (e.g., Windows, macOS, Linux).
   - Ensure `MainScene` is the first scene in the build order, followed by `GameScene` (add scenes via `Add Open Scenes` if needed).
   - Click `Build` and choose an output folder for the executable.

6. **Run the Game**:
   - Navigate to the output folder and run the generated executable (e.g., `LabirinthCoinChallenge.exe` on Windows).
   - Alternatively, play directly in Unity by selecting `MainScene` and clicking the Play button.
