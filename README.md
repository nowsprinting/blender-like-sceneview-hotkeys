# Blender-like SceneView Hotkeys

[![Meta file check](https://github.com/nowsprinting/blender-like-sceneview-hotkeys/actions/workflows/metacheck.yml/badge.svg)](https://github.com/nowsprinting/blender-like-sceneview-hotkeys/actions/workflows/metacheck.yml)
[![Test](https://github.com/nowsprinting/blender-like-sceneview-hotkeys/actions/workflows/test.yml/badge.svg)](https://github.com/nowsprinting/blender-like-sceneview-hotkeys/actions/workflows/test.yml)
[![openupm](https://img.shields.io/npm/v/com.nowsprinting.blender-like-sceneview-hotkeys?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.nowsprinting.blender-like-sceneview-hotkeys/)
[![BOOTH](https://img.shields.io/badge/-BOOTH-EE524C)](https://ikagoya.booth.pm/items/2644683)

This Unity Editor extension allows you to select the viewing direction for a SceneView with the [Blender](https://www.blender.org/) -like hotkeys.

e.g. Numpad 1/3/7 as switch front/right/top view.
Numpad 5 as toggle orthographic projection.

Click [日本語](./README_ja.md) for the Japanese page if you need it.


## Features

Some of Blender's hotkeys Implement.
See [Documentation](./Documentation~/blender-like-sceneview-hotkeys.md) page for implemented hotkeys.

See [Navigating - Blender Manual](https://docs.blender.org/manual/en/latest/editors/3dview/navigate/index.html) for all Blender's hotkeys.


## Settings

If your keyboard is without a Numpad, open
**Preferences > Blender-like SceneView Hotkeys**
, and turn on **Emulate Numpad**.

However, the Unity Editor already assigned the `2` key. If you are using Unity 2019 or later, you can change the assignment with Shortcuts Manager.


## Installation

You can choose from two typical installation methods.

### Install via Package Manager window

1. Open the **Package Manager** tab in Project Settings window (**Editor > Project Settings**)
2. Click **+** button under the **Scoped Registries** and enter the following settings (figure 1.):
   1. **Name:** `package.openupm.com`
   2. **URL:** `https://package.openupm.com`
   3. **Scope(s):** `com.nowsprinting`
3. Open the Package Manager window (**Window > Package Manager**) and select **My Registries** in registries drop-down list (figure 2.)
4. Click **Install** button on the `com.nowsprinting.blender-like-sceneview-hotkeys` package

**Figure 1.** Package Manager tab in Project Settings window.

![](Documentation~/ProjectSettings_Dark.png#gh-dark-mode-only)
![](Documentation~/ProjectSettings_Light.png#gh-light-mode-only)

**Figure 2.** Select registries drop-down list in Package Manager window.

![](Documentation~/PackageManager_Dark.png#gh-dark-mode-only)
![](Documentation~/PackageManager_Light.png#gh-light-mode-only)

### Install via OpenUPM-CLI

If you installed [openupm-cli](https://github.com/openupm/openupm-cli), run the command below:

```bash
openupm add com.nowsprinting.blender-like-sceneview-hotkeys
```


## License

MIT License


## How to contribute

Open an issue or create a pull request.

Be grateful if you could label the pull request as `enhancement`, `bug`, `chore`, and `documentation`. See [PR Labeler settings](.github/pr-labeler.yml) for automatically labeling from the branch name.


## How to development

### Clone repo as a embedded package

Add this repository as a submodule to the Packages/ directory in your project.

Run the command below:

```bash
git submodule add git@github.com:nowsprinting/blender-like-sceneview-hotkeys.git Packages/com.nowsprinting.blender-like-sceneview-hotkeys
```


### Run tests

Generate a temporary project and run tests on each Unity version from the command line.

```bash
make create_project
UNITY_VERSION=2019.4.40f1 make -k test
```


### Release workflow

The release process is as follows:

1. Run **Actions > Create release pull request > Run workflow**
2. Merge created pull request

Then, will do the release process automatically by [Release](.github/workflows/release.yml) workflow.
After tagging, [OpenUPM](https://openupm.com/) retrieves the tag and updates it.

> [!CAUTION]  
> Do **NOT** manually operation the following operations:
> - Create a release tag
> - Publish draft releases

> [!CAUTION]  
> You must modify the package name to publish a forked package.
