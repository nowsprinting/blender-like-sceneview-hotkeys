# Blender-like SceneView Hotkeys

[Blender](https://www.blender.org/) と同じホットキーでSceneViewの視線方向を切り替えることができるUnityエディタ拡張です。

例えば、テンキーの1/3/7で、正面/右/上からの視点に切り替えられます。
テンキーの5で、正投影/透視投影を切り替えられます。

Click [English](./README.md) for English page if you need.


## インストール

### Unity 2019.3 以降

1. Package Manager ウィンドウを開きます (Window | Package Manager)
2. 右上の `+` をクリックし、続いて "Add package from git URL..." をクリックします
3. 入力フィールドに `https://github.com/nowsprinting/BlenderLikeSceneViewHotkeys.git` を入力して `Add` をクリックします

### Unity 2019.2 以前

1. Unityエディタを閉じます
2. テキストエディタで `Packages/manifest.json` ファイルを開きます
3. `"dependencies": {` の次の行に下の行を追加します

```
"com.nowsprinting.blender-like-sceneview-hotkeys": "https://github.com/nowsprinting/BlenderLikeSceneViewHotkeys.git",
```

4. 再度、Unityエディタでプロジェクトを開きます


## 設定

テンキーが無い場合は、Preferences... | Blender-like SceneView Hotkeys を開き、`Emulate Numpad`をonにすることでキーボードの数字キーで操作できます。

ただし、Unityエディタではすでに`2`キーに機能が割り当てられています。Unity 2019以降であれば Shortcuts Manager で割り当てを変更できます。


## 機能

いくつかの Blender ホットキーが実装されています。
Blender のホットキーについては [Navigating- Blender Manual](https://docs.blender.org/manual/en/latest/editors/3dview/navigate/index.html) を参照してください。

現時点で実装されているホットキー（すべてではありません）については [documentation](./Documentation~/BlenderLikeSceneViewHotkeys.md) ページを参照してください。


## ライセンス

MIT License


## コントリビュート

Issue や Pull request を歓迎します。日本語でokです！
