
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

namespace editor.cfg.common
{

public sealed class IntRange :  Luban.EditorBeanBase 
{
    private Action<Luban.EditorBeanBase> _setChangeAction;
    public void SetChangeAction(Action<Luban.EditorBeanBase> action) => _setChangeAction = action;
    public IntRange(Action<Luban.EditorBeanBase> setChangeAction = null) 
    {
        _setChangeAction = setChangeAction;
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["min"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  min = _fieldJson;
            }
            else
            {
            }
        }
        
        { 
            var _fieldJson = _json["max"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  max = _fieldJson;
            }
            else
            {
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            _json["min"] = new JSONNumber(min);
        }
        {
            _json["max"] = new JSONNumber(max);
        }
    }

    private GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);

    public override void Render()
    {
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("min", "min"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("min", ""), GUILayout.Width(100));
}
this.min = UnityEditor.EditorGUILayout.IntField(this.min, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("max", "max"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("max", ""), GUILayout.Width(100));
}
this.max = UnityEditor.EditorGUILayout.IntField(this.max, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}    }
    public static IntRange LoadJsonIntRange(SimpleJSON.JSONNode _json, Action<Luban.EditorBeanBase> setChangeAction = null)
    {
        IntRange obj = new common.IntRange();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonIntRange(IntRange _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int min;
    public int max;

    public override string ToString()
    {
        return "{ "
        + "min:" + min + ","
        + "max:" + max + ","
        + "}";
    }
}

}

