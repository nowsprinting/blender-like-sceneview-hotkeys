# Blender-like SceneView Hotkeys

[![openupm](https://img.shields.io/npm/v/com.nowsprinting.blender-like-sceneview-hotkeys?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.nowsprinting.blender-like-sceneview-hotkeys/)
[![BOOTH](https://img.shields.io/badge/-BOOTH-EE524C)](https://ikagoya.booth.pm/items/2644683)

This Unity Editor Extensions allows you to select the viewing direction for a SceneView with the [Blender](https://www.blender.org/) -like hotkeys.

e.g. Numpad 1/3/7 as switch front/right/top view.
Numpad 5 as toggle orthographic projection.

Click [日本語](./README_ja.md) for Japanese page if you need.


## Installation

You can install in 3 ways.

### By unitypackage

1. Get installer.unitypackage from OpenUPM's package page [📦 Blender-like SceneView Hotkeys - com.nowsprinting.blender-like-sceneview-hotkeys | OpenUPM](https://openupm.com/packages/com.nowsprinting.blender-like-sceneview-hotkeys/)
2. Open your Unity project by Unity Editor, import installer.unitypackage

### By openupm-cli

1. If you installed [openupm-cli](https://github.com/openupm/openupm-cli), run command below

```
$ openupm add com.nowsprinting.blender-like-sceneview-hotkeys
```

### By Unity Package Manager directly

#### Unity 2019.3 or newer

1. Open Package Manager window (Window | Package Manager)
2. Click `+` on upper-left of window, and "Add package from git URL..."

![](./Documentation~/add_package_from_git_url.png)

3. Input `https://github.com/nowsprinting/blender-like-sceneview-hotkeys.git`, and click `Add`

#### Unity 2019.2 or earlier

1. Close Unity Editor
2. Open `Packages/manifest.json` by any Text editor
3. Insert the follow line after `"dependencies": {`, and save file.

```
"com.nowsprinting.blender-like-sceneview-hotkeys": "https://github.com/nowsprinting/blender-like-sceneview-hotkeys.git",
```

4. Reopen Unity project in Unity Editor


## Settings

If your keyboard without a numpad, open preferences... | Blender-like SceneView Hotkeys, and turn on `Emulate Numpad`.

However, in the Unity Editor, already assigned the `2` key. If you are using Unity 2019 or later, you can change the assignment with Shortcuts Manager.


## Features

Implements some of Blender's hotkeys.
See [Documentation](./Documentation~/blender-like-sceneview-hotkeys.md) page for implemented hotkeys.

See [Navigating - Blender Manual](https://docs.blender.org/manual/en/latest/editors/3dview/navigate/index.html) for all Blender's hotkeys.


## License

MIT License


## How to contribute

Open an issue or create a pull request.
