
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

public sealed class SepVector :  Luban.EditorBeanBase 
{
    public SepVector(Action<Luban.EditorBeanBase> setChangeAction = null) 
    {
        _setChangeAction = setChangeAction;
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["x"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  x = _fieldJson;
            }
            else
            {
                x = 0;
            }
        }
        
        { 
            var _fieldJson = _json["y"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  y = _fieldJson;
            }
            else
            {
                y = 0;
            }
        }
        
        { 
            var _fieldJson = _json["z"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  z = _fieldJson;
            }
            else
            {
                z = 0;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            _json["x"] = new JSONNumber(x);
        }
        {
            _json["y"] = new JSONNumber(y);
        }
        {
            _json["z"] = new JSONNumber(z);
        }
    }

    private static GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);

    public static void RenderSepVector(SepVector obj)
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
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x", "x"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x", ""), GUILayout.Width(100));
}
this.x = UnityEditor.EditorGUILayout.IntField(this.x, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("y", "y"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("y", ""), GUILayout.Width(100));
}
this.y = UnityEditor.EditorGUILayout.IntField(this.y, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("z", "z"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("z", ""), GUILayout.Width(100));
}
this.z = UnityEditor.EditorGUILayout.IntField(this.z, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}    }
    public static SepVector LoadJsonSepVector(SimpleJSON.JSONNode _json, Action<Luban.EditorBeanBase> setChangeAction = null)
    {
        SepVector obj = new test.SepVector();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonSepVector(SepVector _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int x;
    public int y;
    public int z;

    public override string ToString()
    {
        return "{ "
        + "x:" + x + ","
        + "y:" + y + ","
        + "z:" + z + ","
        + "}";
    }
}

}

