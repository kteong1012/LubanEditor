
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

public abstract class KeyData :  Luban.EditorBeanBase 
{
    public KeyData()
    {
    }
    public abstract string GetTypeStr();

    private int _typeIndex = -1;
    private int TypeIndex => _typeIndex;
    private static string[] Types = new string[]
    {
        "FloatKeyData",
        "IntKeyData",
        "StringKeyData",
        "BlackboardKeyData",
    };
    private static string[] TypeAlias = new string[]
    {
        "FloatKeyData",
        "IntKeyData",
        "StringKeyData",
        "BlackboardKeyData",
    };

    public static KeyData Create(string type)
    {
        switch (type)
        {
            case "ai.FloatKeyData":   
            case "FloatKeyData":
            {
                var obj = new ai.FloatKeyData();
                obj._typeIndex = Array.IndexOf(Types,type);
                return obj;
            }
            case "ai.IntKeyData":   
            case "IntKeyData":
            {
                var obj = new ai.IntKeyData();
                obj._typeIndex = Array.IndexOf(Types,type);
                return obj;
            }
            case "ai.StringKeyData":   
            case "StringKeyData":
            {
                var obj = new ai.StringKeyData();
                obj._typeIndex = Array.IndexOf(Types,type);
                return obj;
            }
            case "ai.BlackboardKeyData":   
            case "BlackboardKeyData":
            {
                var obj = new ai.BlackboardKeyData();
                obj._typeIndex = Array.IndexOf(Types,type);
                return obj;
            }
            default: return null;
        }
    }

    private static GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);

    public static void RenderKeyData(ref KeyData obj)
    {
        UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
        var array = ConfigEditorSettings.showComment ? TypeAlias : Types;
        UnityEditor.EditorGUILayout.BeginHorizontal();
        UnityEditor.EditorGUILayout.LabelField("类型", GUILayout.Width(100));
        var index = UnityEditor.EditorGUILayout.Popup(obj.TypeIndex, array, GUILayout.Width(200));
        if (obj.TypeIndex != index)
        {
            obj = Create(Types[index]);
        }
        UnityEditor.EditorGUILayout.EndHorizontal();
        obj?.Render();
        UnityEditor.EditorGUILayout.EndVertical();
    }

    public override void Render()
    {
    }
    public static KeyData LoadJsonKeyData(SimpleJSON.JSONNode _json)
    {
        string type = _json["$type"];
        KeyData obj;
        switch (type)
        {
            case "ai.FloatKeyData":   
            case "FloatKeyData":
            {
                obj = new ai.FloatKeyData(); 
                obj._typeIndex = Array.IndexOf(Types, "FloatKeyData");
                break;
            }
            case "ai.IntKeyData":   
            case "IntKeyData":
            {
                obj = new ai.IntKeyData(); 
                obj._typeIndex = Array.IndexOf(Types, "IntKeyData");
                break;
            }
            case "ai.StringKeyData":   
            case "StringKeyData":
            {
                obj = new ai.StringKeyData(); 
                obj._typeIndex = Array.IndexOf(Types, "StringKeyData");
                break;
            }
            case "ai.BlackboardKeyData":   
            case "BlackboardKeyData":
            {
                obj = new ai.BlackboardKeyData(); 
                obj._typeIndex = Array.IndexOf(Types, "BlackboardKeyData");
                break;
            }
            default: throw new SerializationException();
        }
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonKeyData(KeyData _obj, SimpleJSON.JSONNode _json)
    {
        _json["$type"] = _obj.GetTypeStr();
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }


    public override string ToString()
    {
        return "{ "
        + "}";
    }
}

}

