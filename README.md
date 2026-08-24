# 🎮 MyFirstGodot

A small 2D game project built with **Godot Engine and C#**.

This repository is my first hands-on project with Godot. It is mainly focused on learning the fundamentals of Godot's scene system, nodes, C# scripting, player movement, scene switching, UI interaction, and basic game mechanics.

> 🚧 **Work in Progress**
>
> This project is actively being developed as I learn Godot and C# game development.

---

## ✨ Current Features

### 🕹️ Player Movement

The project currently includes a controllable Pac-Man-style player.

**Controls:**

| Key     | Action                  |
| ------- | ----------------------- |
| `W`     | Move Up                 |
| `S`     | Move Down               |
| `A`     | Move Left               |
| `D`     | Move Right              |
| `Shift` | Increase movement speed |

The player can also flip horizontally depending on the movement direction.

---

### 🍎 Eatable System

The game currently contains an apple-like collectible.

When the player gets close enough to the eatable:

* The player receives **20 points**
* The score UI is updated
* The eatable is moved to a random position inside the visible viewport

The current implementation uses a simple distance check between the player and the collectible.

```text
Player
   │
   │ Distance < 30
   ▼
Eatable
   │
   ├── +20 Score
   └── Move to random position
```

This system is intentionally simple for now and will likely be replaced with proper Godot collision/`Area2D` detection as the project evolves.

---

### 🏆 Score System

The game has a basic score counter.

The current score starts at:

```text
Score = 0
```

Eating a collectible increases the score by:

```text
+20
```

---

### 🚪 Scene Switching

The project contains a main menu scene with:

* `Play`
* `Quit`

The `Play` option switches from the main menu to the game scene.

The project uses Godot's scene switching API:

```csharp
GetTree().ChangeSceneToFile("res://scenes/node_2d.tscn");
```

---

### 🖱️ Main Menu Interaction

The main menu player can move around and interact with the `Play` and `Quit` labels.

When the player gets close to a label:

* The label changes color
* The label becomes the currently selected option
* Pressing `Space` activates the option

Current menu actions:

```text
Play → Start Game

Quit → Exit Application
```

---

## 📂 Project Structure

```text
MyFirstGodot/
│
├── assets/
│   └── images/
│       ├── apple.png
│       ├── backgroundmain.jpg
│       ├── icon.svg
│       └── packman.png
│
├── scenes/
│   ├── mainwindow.tscn
│   └── node_2d.tscn
│
├── scripts/
│   ├── Eatable.cs
│   ├── GamePlayer.cs
│   └── Sprite2d.cs
│
├── MyLearnings.csproj
├── MyLearnings.sln
├── export_presets.cfg
└── project.godot
```

---

## 🧩 Scenes

### `mainwindow.tscn`

The main menu scene.

It contains:

* Background
* `Play` label
* `Quit` label
* Pac-Man/player sprite
* UI elements

The main menu is configured as the project's starting scene:

```text
res://scenes/mainwindow.tscn
```

---

### `node_2d.tscn`

The main gameplay scene.

Current structure:

```text
Node2D
├── Sprite2D
├── Eatable
├── Pacman
└── Label
```

The scene contains:

* Game background
* Pac-Man player
* Eatable/Apple
* Score label

---

## 💻 Scripts

### `GamePlayer.cs`

Controls the gameplay player.

Responsibilities currently include:

* WASD movement
* Sprinting with Shift
* Horizontal sprite flipping
* Screen boundary limitation
* Detecting proximity to the eatable
* Increasing score
* Moving the eatable to a random location

---

### `Eatable.cs`

The script attached to the current collectible.

At the moment it is a lightweight `Sprite2D` script.

The actual detection logic currently lives in `GamePlayer.cs`.

This is intentionally kept simple while learning Godot's basic architecture.

---

### `Sprite2d.cs`

Controls the player in the main menu.

Responsibilities:

* Moving around the menu
* Detecting proximity to menu labels
* Highlighting selectable labels
* Handling `Space` interaction
* Starting the game
* Exiting the application

---

## 🛠️ Technology Stack

| Technology     | Version / Details     |
| -------------- | --------------------- |
| Engine         | Godot 4.7             |
| Language       | C#                    |
| Godot SDK      | `Godot.NET.Sdk/4.7.2` |
| .NET           | .NET 8                |
| Mobile Target  | .NET 9                |
| Renderer       | GL Compatibility      |
| Project Type   | 2D                    |
| IDE / Solution | .NET / C#             |

The project is configured as a Godot C# project and uses `Godot.NET.Sdk/4.7.2`.

---

## 🚀 Running the Project

### Requirements

Install:

* [Godot Engine](https://godotengine.org/)
* Godot .NET / C# support
* .NET SDK compatible with the project

### Clone

```bash
git clone https://github.com/M0binMoharrami/MyFirstGodot.git
cd MyFirstGodot
```

Open the project in Godot and run it with:

```text
F6
```

or run the project normally with:

```text
F5
```

The configured main scene is:

```text
res://scenes/mainwindow.tscn
```

---

## 🎯 Learning Goals

This project is being used to learn and experiment with:

* Godot scenes
* Godot nodes
* C# scripting
* `Sprite2D`
* `Node2D`
* Labels and UI
* Player movement
* Input handling
* Scene switching
* Random positions
* Basic game state
* Score systems
* Object interaction
* Collision and detection concepts
* Godot project/export configuration

---

## 🔮 Planned Features

The project is still in its early stages.

Possible future improvements include:

* [ ] Proper `Area2D` collision for eatables
* [ ] Multiple randomly spawned eatables
* [ ] Prevent eatables from spawning inside obstacles
* [ ] Better player collision
* [ ] Pac-Man maze
* [ ] Walls and obstacles
* [ ] Ghost enemies
* [ ] Lives system
* [ ] Game over screen
* [ ] Multiple levels
* [ ] Better score system
* [ ] Sound effects
* [ ] Background music
* [ ] Animations
* [ ] Pause menu
* [ ] High-score system
* [ ] Android export
* [ ] Improved UI
* [ ] Better code architecture

---

## 📚 Project Philosophy

This isn't intended to be a polished commercial game.

The main purpose of **MyFirstGodot** is learning by actually building things.

Instead of trying to understand the entire Godot API before writing a game, the project evolves feature by feature:

```text
Learn
  ↓
Build
  ↓
Break something
  ↓
Debug
  ↓
Understand
  ↓
Improve
  ↓
Repeat
```

That's basically the development cycle. Sometimes with more compiler errors than expected. 💀

---

## 👨‍💻 Author

**Mobin Moharrami**

Programmer interested in:

* Game Development
* C#
* .NET
* Godot
* Game Servers
* Automation
* Software Development

GitHub:

https://github.com/M0binMoharrami

---

## 📜 License

No explicit project license is currently defined.

Unless a license is added to this repository, the project should not be assumed to be freely reusable, modified, or redistributed.

---

## ⭐ Status

**Early Development / Learning Project**

The project is intentionally evolving as new Godot and C# concepts are learned.
