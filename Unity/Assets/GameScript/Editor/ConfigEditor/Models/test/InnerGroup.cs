
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

namespace editor.cfg.test
{

public sealed class InnerGroup :  Luban.EditorBeanBase 
{
    private Action<Luban.EditorBeanBase> _setChangeAction;
    public void SetChangeAction(Action<Luban.EditorBeanBase> action) => _setChangeAction = action;
    public InnerGroup(Action<Luban.EditorBeanBase> setChangeAction = null) 
    {
        _setChangeAction = setChangeAction;
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["y1"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  y1 = _fieldJson;
            }
            else
            {
            }
        }
        
        { 
            var _fieldJson = _json["y2"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  y2 = _fieldJson;
            }
            else
            {
            }
        }
        
        { 
            var _fieldJson = _json["y3"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  y3 = _fieldJson;
            }
            else
            {
            }
        }
        
        { 
            var _fieldJson = _json["y4"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  y4 = _fieldJson;
            }
            else
            {
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            _json["y1"] = new JSONNumber(y1);
        }
        {
            _json["y2"] = new JSONNumber(y2);
        }
        {
            _json["y3"] = new JSONNumber(y3);
        }
        {
            _json["y4"] = new JSONNumber(y4);
        }
    }

    private GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);

    public override void Render()
    {
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("y1", "y1"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("y1", ""), GUILayout.Width(100));
}
this.y1 = UnityEditor.EditorGUILayout.IntField(this.y1, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("y2", "y2"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("y2", ""), GUILayout.Width(100));
}
this.y2 = UnityEditor.EditorGUILayout.IntField(this.y2, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("y3", "y3"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("y3", ""), GUILayout.Width(100));
}
this.y3 = UnityEditor.EditorGUILayout.IntField(this.y3, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("y4", "y4"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("y4", ""), GUILayout.Width(100));
}
this.y4 = UnityEditor.EditorGUILayout.IntField(this.y4, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}    }
    public static InnerGroup LoadJsonInnerGroup(SimpleJSON.JSONNode _json, Action<Luban.EditorBeanBase> setChangeAction = null)
    {
        InnerGroup obj = new test.InnerGroup();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonInnerGroup(InnerGroup _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int y1;
    public int y2;
    public int y3;
    public int y4;

    public override string ToString()
    {
        return "{ "
        + "y1:" + y1 + ","
        + "y2:" + y2 + ","
        + "y3:" + y3 + ","
        + "y4:" + y4 + ","
        + "}";
    }
}

}

