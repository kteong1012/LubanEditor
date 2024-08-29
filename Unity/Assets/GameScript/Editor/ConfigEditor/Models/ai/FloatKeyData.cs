
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

public sealed class FloatKeyData :  ai.KeyData 
{
    public FloatKeyData(Action<Luban.EditorBeanBase> setChangeAction = null)  : base(setChangeAction) 
    {
        _setChangeAction = setChangeAction;
    }
    public override string GetTypeStr() => TYPE_STR;
    private const string TYPE_STR = "FloatKeyData";

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
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            _json["value"] = new JSONNumber(value);
        }
    }

    private GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);

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
this.value = UnityEditor.EditorGUILayout.DoubleField(this.value, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}    }
    public static FloatKeyData LoadJsonFloatKeyData(SimpleJSON.JSONNode _json, Action<Luban.EditorBeanBase> setChangeAction = null)
    {
        FloatKeyData obj = new ai.FloatKeyData();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonFloatKeyData(FloatKeyData _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public double value;

    public override string ToString()
    {
        return "{ "
        + "value:" + value + ","
        + "}";
    }
}

}

