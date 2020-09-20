# Blender-like SceneView Hotkeys

This Unity Editor Extensions allows you to select the viewing direction for a SceneView with the [Blender](https://www.blender.org/) -like hotkeys.


## Installation

### Unity 2019.3 or newer

1. Open Package Manager window (Window | Package Manager)
2. Click `+`, and "Add package from git URL..."
3. Input `https://github.com/nowsprinting/blender-like-sceneview-hotkeys.git`, and click `Add`

### Unity 2019.2 or earlier

1. Close Unity Editor
2. Open `Packages/manifest.json` by any Text editor
3. Insert the follow line after `"dependencies": {`

```
"com.nowsprinting.blender-like-sceneview-hotkeys": "https://github.com/nowsprinting/blender-like-sceneview-hotkeys.git",
```

4. Reopen Unity project in Unity Editor


## Settings

If your keyboard without a numpad, open preferences... | Blender-like SceneView Hotkeys, and turn on `Emulate Numpad`.

However, in the Unity Editor, already assigned the `2` key. If you are using Unity 2019 or later, you can change the assignment with Shortcuts Manager.


## Features

Implements some of Blender's hotkeys.
See [Navigating- Blender Manual](https://docs.blender.org/manual/en/latest/editors/3dview/navigate/index.html) for all Blender's hotkeys.

See [documentation](./Documentation~/BlenderLikeSceneViewHotkeys.md) for implemented hotkeys.


## License

MIT License


## How to contribute

Open an issue or create a pull request.
