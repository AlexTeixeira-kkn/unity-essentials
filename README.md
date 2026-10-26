# Unity Essentials – Course Project

This repository is my completed project for the **[Unity Essentials](https://learn.unity.com/pathway/unity-essentials)** pathway on Unity Learn. It is the evidence that I worked through every mission of the pathway: each tutorial unit has its own scene in this project, built by me in the Unity Editor while following the course.

| | |
|---|---|
| **Author** | Alex Teixeira |
| **Engine** | Unity 6 (`6000.6.6f1`) |
| **Render pipeline** | Universal Render Pipeline (URP) |
| **Target platform** | Web (WebGL) |
| **Course** | Unity Learn – Unity Essentials pathway |

---

## Why this repo exists

The Unity Essentials pathway ends with publishing a playable build. This repo keeps the full **source project** alongside that, so anyone can open it and verify the work:

- every course scene is present and listed in the build settings, in course order;
- the scripts written during the programming mission are included, with my own comments;
- my own materials and prefabs made during the 3D mission are in their own `My Materials` / `My Prefabs` folders;
- the project was built and published for the Web, completing the final publishing mission.

---

## Course progress – one scene per mission

All scenes live in `Web Build_1.0/Assets/_Unity Essentials/Scenes/`.

| # | Scene | Course mission | What it covers |
|---|---|---|---|
| 0 | `0_MainMenu_Scene` | – | Main menu that loads each mission scene |
| 1 | `1_Playground_Navigation_Scene` | Editor Essentials | Navigating the Scene view, selecting and transforming GameObjects |
| 2 | `2_KidsRoom_3D_Scene` | 3D Essentials | Placing 3D models and prefabs, materials, lighting, Rigidbody physics |
| 3 | `3_Kitchen_Audio_Scene` | Audio Essentials | Audio sources, music, ambient and spatial sound effects |
| 4 | `4_LivingRoom_Programming_Scene` | Programming Essentials | C# scripts: player movement, collectibles, particle effects |
| 5 | `5_TopDown_2D_Scene` | 2D Essentials | Sprites, 2D physics, a top-down 2D character and collectibles |
| 6 | `6_Bonus_Custom_Scene` | Publishing / Bonus | Customised scene, then the Web build and publishing step |

`-1_Starter_Scene` is the course's starter scene and isn't part of the build.

---

## Main features

- **Main menu with scene navigation.** Start from `0_MainMenu_Scene` to jump into any mission scene.
- **Player movement (`PlayerController.cs`).** Tank-style controls with the new **Input System**: W/S or ↑/↓ to move, A/D or ←/→ to turn, **Space** to jump. Movement uses Rigidbody physics (`MovePosition` / `MoveRotation` in `FixedUpdate`).
- **Collectibles (`Collectible.cs`).** Pickups spin in place and, when the Player touches them, disappear and spawn a particle effect.
- **Animated doors (`DoorOpener.cs`).** Trigger zones play a door-opening animation when the Player walks in.
- **Day/night cycle (`DayNightCycle.cs`).** Rotates the Directional Light to move the sun across the sky. The day length, start time and sun direction can be set in the Inspector, and the time of day can be previewed outside Play mode.
- **Custom 3D content.** Block, block-tower and room prefabs (`Prefabs/My Prefabs`) plus custom materials, including a bouncy physic material (`Materials/My Materials`).
- **2D top-down level.** Built with sprites, 2D physics and the provided 2D controller and collectible scripts.
- **Audio.** Music tracks and sound effects in the kitchen scene.
- **Web build.** Built with a dedicated *Web – Desktop – Release* build profile and published for the browser.

---

## Project structure

```
Unity_Essentials/
├── Web Build_1.0/                  ← the Unity project (open this folder in Unity Hub)
│   ├── Assets/
│   │   └── _Unity Essentials/
│   │       ├── Scenes/             ← one scene per course mission
│   │       ├── Scripts/            ← scripts written during the course
│   │       │   └── Provided Scripts/   (2D scripts supplied by the course)
│   │       ├── Prefabs/My Prefabs/ ← my own prefabs
│   │       ├── Materials/My Materials/
│   │       ├── Audio/  Models/  Sprites/  Textures/
│   │       ├── Source Files/       ← course-provided assets and helper scripts
│   │       └── Tutorials/          ← in-editor tutorial content (M_01 to M_06)
│   ├── Packages/
│   └── ProjectSettings/
├── .gitignore
└── .gitattributes
```

Most art, audio and the scripts in `Source Files/` and `Provided Scripts/` come from the course. The scenes and the scripts directly in `Scripts/` are what I put together while following it.

---

## How to open and run

1. Install **Unity 6000.6.6f1** (or a later Unity 6 release) through Unity Hub.
2. Install **Git LFS** before cloning, because textures, models and audio are stored with LFS:
   ```bash
   git lfs install
   git clone https://github.com/AlexTeixeira-kkn/unity-essentials.git
   ```
3. In Unity Hub, click **Add → Add project from disk** and select the `Web Build_1.0` folder.
4. Open `Assets/_Unity Essentials/Scenes/0_MainMenu_Scene.unity` and press **Play**.

The first time you open the project, Unity rebuilds the `Library` folder, which can take a few minutes. That folder isn't in the repo.

---

## Credits

Course content, starter assets and tutorial framework: **Unity Technologies – [Unity Learn](https://learn.unity.com)**.
Scene work and the scripts in `Scripts/`: **Alex Teixeira**.
