
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

public sealed class StringKeyData :  ai.KeyData 
{
    public StringKeyData(Action<Luban.EditorBeanBase> setChangeAction = null)  : base(setChangeAction) 
    {
        _setChangeAction = setChangeAction;
            value = "";
    }
    public override string GetTypeStr() => TYPE_STR;
    private const string TYPE_STR = "StringKeyData";

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["value"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  value = _fieldJson;
            }
            else
            {
                value = "";
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {

        if (value != null)
        {
            _json["value"] = new JSONString(value);
        }
    }

    private static GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);

    public static void RenderStringKeyData(StringKeyData obj)
    {
        UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
        obj?.Render();
        UnityEditor.EditorGUILayout.EndVertical();
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
this.value = UnityEditor.EditorGUILayout.TextField(this.value, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}    }
    public static StringKeyData LoadJsonStringKeyData(SimpleJSON.JSONNode _json, Action<Luban.EditorBeanBase> setChangeAction = null)
    {
        StringKeyData obj = new ai.StringKeyData();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonStringKeyData(StringKeyData _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public string value;

    public override string ToString()
    {
        return "{ "
        + "value:" + value + ","
        + "}";
    }
}

}

