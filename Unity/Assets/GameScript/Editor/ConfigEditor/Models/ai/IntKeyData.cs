
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

public sealed class IntKeyData :  ai.KeyData 
{
    public IntKeyData()
    {
    }
    public override string GetTypeStr() => TYPE_STR;
    private const string TYPE_STR = "IntKeyData";

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["value"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  value = _fieldJson;
            }
            else
            {
                value = 0;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            _json["value"] = new JSONNumber(value);
        }
    }

    private static GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);

    public static void RenderIntKeyData(IntKeyData obj)
    {
        obj.Render();
    }

    public override void Render()
    {
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("value", "value"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("value", ""), GUILayout.Width(100));
}
this.value = UnityEditor.EditorGUILayout.IntField(this.value, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}    }
    public static IntKeyData LoadJsonIntKeyData(SimpleJSON.JSONNode _json)
    {
        IntKeyData obj = new ai.IntKeyData();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonIntKeyData(IntKeyData _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int value;

    public override string ToString()
    {
        return "{ "
        + "value:" + value + ","
        + "}";
    }
}

}

