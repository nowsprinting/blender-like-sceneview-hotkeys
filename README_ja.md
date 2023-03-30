# Blender-like SceneView Hotkeys

[![Meta file check](https://github.com/nowsprinting/blender-like-sceneview-hotkeys/actions/workflows/metacheck.yml/badge.svg)](https://github.com/nowsprinting/blender-like-sceneview-hotkeys/actions/workflows/metacheck.yml)
[![Test](https://github.com/nowsprinting/blender-like-sceneview-hotkeys/actions/workflows/test.yml/badge.svg)](https://github.com/nowsprinting/blender-like-sceneview-hotkeys/actions/workflows/test.yml)
[![openupm](https://img.shields.io/npm/v/com.nowsprinting.blender-like-sceneview-hotkeys?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.nowsprinting.blender-like-sceneview-hotkeys/)
[![BOOTH](https://img.shields.io/badge/-BOOTH-EE524C)](https://ikagoya.booth.pm/items/2644683)

[Blender](https://www.blender.org/) と同じホットキーでSceneViewの視線方向を切り替えることができるUnityエディタ拡張です。

例えば、テンキーの1/3/7で、正面/右/上からの視点に切り替えられます。
テンキーの5で、正投影/透視投影を切り替えられます。

Click [English](./README.md) for English page if you need.


## 機能

いくつかの Blender ホットキーが実装されています。
現時点で実装されているホットキーについては [Documentation](./Documentation~/blender-like-sceneview-hotkeys.md) ページ、もしくはブログ記事『[Blender 的なテンキー操作で視点操作できる Unityエディタ拡張 - やらなイカ？](https://www.nowsprinting.com/entry/2020/09/26/204307)』を参照してください。

Blender のホットキーについては [Navigating - Blender Manual](https://docs.blender.org/manual/en/latest/editors/3dview/navigate/index.html) を参照してください。


## 設定

テンキーが無い場合は、
**Preferences > Blender-like SceneView Hotkeys**
を開き、**Emulate Numpad** をonにすることでキーボードの数字キーで操作できます。

ただし、Unityエディタではすでに`2`キーに機能が割り当てられています。Unity 2019以降であれば Shortcuts Manager で割り当てを変更できます。


## インストール方法

主に2通りの方法でインストールできます。

### Package Manager ウィンドウを使用する場合

1. Player Settings ウィンドウ（**Editor > Player Settings**）にある、**Package Manager** タブを開きます
2. **Scoped Registries** の下にある **+** ボタンをクリックし、次の項目を設定します（図 1）
   1. **Name:** `package.openupm.com`
   2. **URL:** `https://package.openupm.com`
   3. **Scope(s):** `com.nowsprinting`
3. Package Managerウィンドウを開き（**Window > Package Manager**）、レジストリ選択ドロップダウンで **My Registries** を選択します（図 2）
4. `com.nowsprinting.blender-like-sceneview-hotkeys` パッケージの **Install** ボタンをクリックします

**図 1.** Player Settings ウィンドウの Package Manager タブ

![](Documentation~/ProjectSettings_Dark.png#gh-dark-mode-only)
![](Documentation~/ProjectSettings_Light.png#gh-light-mode-only)

**図 2.** Package Manager ウィンドウのレジストリ選択ドロップダウン

![](Documentation~/PackageManager_Dark.png/#gh-dark-mode-only)
![](Documentation~/PackageManager_Light.png/#gh-light-mode-only)

### openupm-cli を使用する場合

[openupm-cli](https://github.com/openupm/openupm-cli) がインストールされている状態で、ターミナルから次のコマンドを実行します。

```bash
openupm add com.nowsprinting.blender-like-sceneview-hotkeys
```


## ライセンス

MIT License


## コントリビュート

Issue や Pull request を歓迎します。日本語でokです！


Pull requestには `enhancement`, `bug`, `chore`, `documentation` といったラベルを付けてもらえるとありがたいです。
ブランチ名から自動的にラベルを付ける設定もあります。[PR Labeler settings](.github/pr-labeler.yml) を参照してください。


## 開発方法

本リポジトリをUnityプロジェクトのサブモジュールとして Packages/ ディレクトリ下に置いてください。

ターミナルから次のコマンドを実行します。

```bash
git submodule add https://github.com/nowsprinting/blender-like-sceneview-hotkeys.git Packages/com.nowsprinting.blender-like-sceneview-hotkeys
```


## リリースワークフロー

**Actions > Create release pull request > Run workflow** を実行し、作られたpull requestをデフォルトブランチにマージすることでリリース処理が実行されます。
（もしくは、デフォルトブランチのpackage.json内のバージョン番号を書き換えます）

リリース処理は、[Release](.github/workflows/release.yml)ワークフローで自動的に行われます。
tagが付与されると、OpenUPMがtagを収集して更新してくれます。

以下の操作は手動で行わないでください。

- リリースタグの作成
- ドラフトリリースの公開
