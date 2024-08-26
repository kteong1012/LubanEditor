# LubanEditor
Luban较为通用的编辑器工具


源码地址：https://github.com/kteong1012/luban_fork/tree/unity_editor

除了编辑器功能外，新增了string#obj标签，能支持拖unity的物体。

定义方式，在type里的string加上obj的tag即可，如 string#obj=sprite

```CSharp
        if (objType == "sprite")
        {
            return "UnityEngine.Sprite";
        }
        else if (objType == "texture")
        {
            return "UnityEngine.Texture2D";
        }
        else if (objType == "audioClip")
        {
            return "UnityEngine.AudioClip";
        }
        else if (objType == "animationClip")
        {
            return "UnityEngine.AnimationClip";
        }
        else if (objType == "material")
        {
            return "UnityEngine.Material";
        }
        else if (objType == "gameObject")
        {
            return "UnityEngine.GameObject";
        }
        else if (objType == "prefab")
        {
            return "UnityEngine.GameObject";
        }
        else if (objType == "font")
        {
            return "UnityEngine.Font";
        }
        else if (objType == "textAsset")
        {
            return "UnityEngine.TextAsset";
        }
        else if (objType == "shader")
        {
            return "UnityEngine.Shader";
        }
        else if (objType == "scriptableObject")
        {
            return "UnityEngine.ScriptableObject";
        }
```
