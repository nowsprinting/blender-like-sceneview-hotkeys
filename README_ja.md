# Blender-like SceneView Hotkeys

[![openupm](https://img.shields.io/npm/v/com.nowsprinting.blender-like-sceneview-hotkeys?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.nowsprinting.blender-like-sceneview-hotkeys/)
[![BOOTH](https://img.shields.io/badge/-BOOTH-EE524C)](https://ikagoya.booth.pm/items/2644683)

[Blender](https://www.blender.org/) と同じホットキーでSceneViewの視線方向を切り替えることができるUnityエディタ拡張です。

例えば、テンキーの1/3/7で、正面/右/上からの視点に切り替えられます。
テンキーの5で、正投影/透視投影を切り替えられます。

Click [English](./README.md) for English page if you need.


## インストール

3通りの方法でインストールできます

### unitypackage を使用する場合

1. OpenUPM のパッケージページ [📦 Blender-like SceneView Hotkeys - com.nowsprinting.blender-like-sceneview-hotkeys | OpenUPM](https://openupm.com/packages/com.nowsprinting.blender-like-sceneview-hotkeys/) を開き、右上の "Get installer.unitypackage" をクリックしてダウンロードします
2. Unityエディタでプロジェクトを開き、ダウンロードした unitypackage ファイルをインポートします

### openupm-cli を使用する場合

1. [openupm-cli](https://github.com/openupm/openupm-cli) がインストールされている状態で、ターミナルから下記コマンドを実行します

```bash
openupm add com.nowsprinting.blender-like-sceneview-hotkeys
```

### Unity Package Managerで直接指定する場合

#### Unity 2019.3 以降の場合

1. Package Manager ウィンドウを開きます (Window | Package Manager)
2. 左上の `+` をクリックし、続いて "Add package from git URL..." をクリックします

![](./Documentation~/add_package_from_git_url.png)

3. 表示される入力フィールドに次のURLを入力して `Add` をクリックします

```
https://github.com/nowsprinting/blender-like-sceneview-hotkeys.git
```

#### Unity 2019.2 以前の場合

1. Unityエディタを閉じます
2. テキストエディタで `Packages/manifest.json` ファイルを開きます
3. `"dependencies": {` の次の行に下の行を追加して保存します

```
"com.nowsprinting.blender-like-sceneview-hotkeys": "https://github.com/nowsprinting/blender-like-sceneview-hotkeys.git",
```

4. 再度、Unityエディタでプロジェクトを開きます


## 設定

テンキーが無い場合は、Preferences... | Blender-like SceneView Hotkeys を開き、`Emulate Numpad`をonにすることでキーボードの数字キーで操作できます。

ただし、Unityエディタではすでに`2`キーに機能が割り当てられています。Unity 2019以降であれば Shortcuts Manager で割り当てを変更できます。


## 機能

いくつかの Blender ホットキーが実装されています。
現時点で実装されているホットキーについては [Documentation](./Documentation~/blender-like-sceneview-hotkeys.md) ページ、もしくはブログ記事『[Blender 的なテンキー操作で視点操作できる Unityエディタ拡張 - やらなイカ？](https://www.nowsprinting.com/entry/2020/09/26/204307)』を参照してください。

Blender のホットキーについては [Navigating - Blender Manual](https://docs.blender.org/manual/en/latest/editors/3dview/navigate/index.html) を参照してください。


## ライセンス

MIT License


## コントリビュート

Issue や Pull request を歓迎します。日本語でokです！


Pull Requestには `enhancement`, `bug`, `chore`, `documentation` といったラベルを付けてもらえるとありがたいです。
ブランチ名から自動的にラベルを付ける設定もあります。[PR Labeler settings](.github/pr-labeler.yml) を参照してください。


## 開発方法

本リポジトリをUnityプロジェクトのサブモジュールとして Packages/ ディレクトリ下に置いてください。

ターミナルから次のコマンドを実行します。

```bash
git submodule add https://github.com/nowsprinting/blender-like-sceneview-hotkeys.git Packages/com.nowsprinting.blender-like-sceneview-hotkeys
```


## リリースワークフロー

**Actions > Create release pull request > Run workflow** を実行し、作られたPull Requestをデフォルトブランチにマージすることでリリース処理が実行されます。
（もしくは、デフォルトブランチのpackage.json内のバージョン番号を書き換えます）

リリース処理は、[Release](.github/workflows/release.yml)ワークフローで自動的に行われます。
tagが付与されると、OpenUPMがtagを収集して更新してくれます。

以下の操作は手動で行わないでください。

- リリースタグの作成
- ドラフトリリースの公開
