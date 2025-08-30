# Blender-like SceneView Hotkeys

[![Meta file check](https://github.com/nowsprinting/blender-like-sceneview-hotkeys/actions/workflows/metacheck.yml/badge.svg)](https://github.com/nowsprinting/blender-like-sceneview-hotkeys/actions/workflows/metacheck.yml)
[![Test](https://github.com/nowsprinting/blender-like-sceneview-hotkeys/actions/workflows/test.yml/badge.svg)](https://github.com/nowsprinting/blender-like-sceneview-hotkeys/actions/workflows/test.yml)
[![openupm](https://img.shields.io/npm/v/com.nowsprinting.blender-like-sceneview-hotkeys?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.nowsprinting.blender-like-sceneview-hotkeys/)
[![BOOTH](https://img.shields.io/badge/-BOOTH-EE524C)](https://ikagoya.booth.pm/items/2644683)
[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/nowsprinting/blender-like-sceneview-hotkeys)

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

1. Project Settings ウィンドウ（**Editor > Project Settings**）にある、**Package Manager** タブを開きます（図 1）
2. **Scoped Registries** の下にある **+** ボタンをクリックし、次の項目を設定します
   1. **Name:** `package.openupm.com`
   2. **URL:** `https://package.openupm.com`
   3. **Scope(s):** `com.nowsprinting`
3. Package Managerウィンドウ（**Window > Package Manager**）にある、 **My Registries** タブを開きます（図 2）
4. **Blender-like SceneView Hotkeys** を選択して **Install** ボタンをクリックします

**図 1.** Project Settings ウィンドウの Scoped Registries 設定

![](Documentation~/ScopedRegistries_Dark.png#gh-dark-mode-only)
![](Documentation~/ScopedRegistries_Light.png#gh-light-mode-only)

**図 2.** Package Manager ウィンドウの My Registries

![](Documentation~/PackageManager_Dark.png#gh-dark-mode-only)
![](Documentation~/PackageManager_Light.png#gh-light-mode-only)


## ライセンス

MIT License


## コントリビュート

Issue や Pull request を歓迎します。日本語でokです！


Pull requestには `enhancement`, `bug`, `chore`, `documentation` といったラベルを付けてもらえるとありがたいです。
ブランチ名から自動的にラベルを付ける設定もあります。[PR Labeler settings](.github/pr-labeler.yml) を参照してください。


## 開発方法

### リポジトリを埋め込みパッケージとしてクローン

本リポジトリをUnityプロジェクトのサブモジュールとして Packages/ ディレクトリ下に置いてください。
ターミナルから次のコマンドを実行します。

```bash
git submodule add git@github.com:nowsprinting/blender-like-sceneview-hotkeys.git Packages/com.nowsprinting.blender-like-sceneview-hotkeys
```


### テスト

次のコマンドで、 テスト用のプロジェクトを生成して指定したUnityバージョンでテストを実行します。

```bash
make create_project
UNITY_VERSION=2019.4.40f1 make -k test
```


### リリースワークフロー

次の手順でリリースします。

1. **Actions > Create release pull request > Run workflow** を実行
2. 生成されたプルリクエストをマージ

リリース処理は、[Release](.github/workflows/release.yml) ワークフローで自動的に行われます。
tagが付与されると、[OpenUPM](https://openupm.com/) がtagを収集して更新してくれます。

> [!CAUTION]  
> 次の操作は手動で行わないでください
> - リリースタグの作成
> - ドラフトリリースの公開

> [!CAUTION]  
> フォークしたパッケージを公開する場合は、パッケージ名を変更する必要があります
