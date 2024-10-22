
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using SimpleJSON;
using Luban;
using UnityEngine;
using System.Linq;
using System;

namespace editor.cfg.ai
{

public sealed class BlackboardKey :  Luban.EditorBeanBase 
{
    public BlackboardKey()
    {
            name = "";
            desc = "";
            keyType = editor.cfg.ai.EKeyType.BOOL;
            typeClassName = "";
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["name"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  name = _fieldJson;
            }
            else
            {
                name = "";
            }
        }
        
        { 
            var _fieldJson = _json["desc"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  desc = _fieldJson;
            }
            else
            {
                desc = "";
            }
        }
        
        { 
            var _fieldJson = _json["is_static"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsBoolean) { throw new SerializationException(); }  isStatic = _fieldJson;
            }
            else
            {
                isStatic = false;
            }
        }
        
        { 
            var _fieldJson = _json["key_type"];
            if (_fieldJson != null)
            {
                if(_fieldJson.IsString) { keyType = (editor.cfg.ai.EKeyType)System.Enum.Parse(typeof(editor.cfg.ai.EKeyType), _fieldJson); } else if(_fieldJson.IsNumber) { keyType = (editor.cfg.ai.EKeyType)(int)_fieldJson; } else { throw new SerializationException(); }  
            }
            else
            {
                keyType = editor.cfg.ai.EKeyType.BOOL;
            }
        }
        
        { 
            var _fieldJson = _json["type_class_name"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  typeClassName = _fieldJson;
            }
            else
            {
                typeClassName = "";
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {

        if (name != null)
        {
            _json["name"] = new JSONString(name);
        }

        if (desc != null)
        {
            _json["desc"] = new JSONString(desc);
        }
        {
            _json["is_static"] = new JSONBool(isStatic);
        }
        {
            _json["key_type"] = new JSONNumber((int)keyType);
        }

        if (typeClassName != null)
        {
            _json["type_class_name"] = new JSONString(typeClassName);
        }
    }

    private static GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);

    public static void RenderBlackboardKey(BlackboardKey obj)
    {
        obj.Render();
    }

    public override void Render()
    {
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("name", "name"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("name", ""), GUILayout.Width(100));
}
this.name = UnityEditor.EditorGUILayout.TextField(this.name, GUILayout.Width(150));
if (GUILayout.Button("…", GUILayout.Width(20)))
{
    TextInputWindow.GetTextAsync(this.name,__x =>this.name = __x);
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("desc", "desc"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("desc", ""), GUILayout.Width(100));
}
this.desc = UnityEditor.EditorGUILayout.TextField(this.desc, GUILayout.Width(150));
if (GUILayout.Button("…", GUILayout.Width(20)))
{
    TextInputWindow.GetTextAsync(this.desc,__x =>this.desc = __x);
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("is_static", "is_static"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("is_static", ""), GUILayout.Width(100));
}
this.isStatic = UnityEditor.EditorGUILayout.Toggle(this.isStatic, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("key_type", "key_type"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("key_type", ""), GUILayout.Width(100));
}
{
    if (ConfigEditorSettings.showComment)
    {
        var __index1 = (int)this.keyType;
        var __alias1 = (ai.EKeyType_Alias)this.keyType;
        __alias1 = (ai.EKeyType_Alias)UnityEditor.EditorGUILayout.EnumPopup(__alias1, GUILayout.Width(150));
        var __item1 = ai.EKeyType_Metadata.GetByNameOrAlias(__alias1.ToString());
        this.keyType = (editor.cfg.ai.EKeyType)__item1.Value;
    }
    else
    {
        this.keyType = (editor.cfg.ai.EKeyType)UnityEditor.EditorGUILayout.EnumPopup(this.keyType, GUILayout.Width(150));
    }
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("type_class_name", "type_class_name"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("type_class_name", ""), GUILayout.Width(100));
}
this.typeClassName = UnityEditor.EditorGUILayout.TextField(this.typeClassName, GUILayout.Width(150));
if (GUILayout.Button("…", GUILayout.Width(20)))
{
    TextInputWindow.GetTextAsync(this.typeClassName,__x =>this.typeClassName = __x);
}
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}    }
    public static BlackboardKey LoadJsonBlackboardKey(SimpleJSON.JSONNode _json)
    {
        BlackboardKey obj = new ai.BlackboardKey();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonBlackboardKey(BlackboardKey _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public string name;
    public string desc;
    public bool isStatic;
    public editor.cfg.ai.EKeyType keyType;
    public string typeClassName;

    public override string ToString()
    {
        return "{ "
        + "name:" + name + ","
        + "desc:" + desc + ","
        + "isStatic:" + isStatic + ","
        + "keyType:" + keyType + ","
        + "typeClassName:" + typeClassName + ","
        + "}";
    }
}

}

