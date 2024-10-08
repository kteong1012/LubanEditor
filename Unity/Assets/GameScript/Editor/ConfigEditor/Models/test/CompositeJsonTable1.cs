
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

public sealed class CompositeJsonTable1 :  Luban.EditorBeanBase 
{
    public CompositeJsonTable1()
    {
            x = "";
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["id"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  id = _fieldJson;
            }
            else
            {
                id = 0;
            }
        }
        
        { 
            var _fieldJson = _json["x"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  x = _fieldJson;
            }
            else
            {
                x = "";
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            _json["id"] = new JSONNumber(id);
        }

        if (x != null)
        {
            _json["x"] = new JSONString(x);
        }
    }

    private static GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);

    public static void RenderCompositeJsonTable1(CompositeJsonTable1 obj)
    {
        obj.Render();
    }

    public override void Render()
    {
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("id", "id"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("id", ""), GUILayout.Width(100));
}
this.id = UnityEditor.EditorGUILayout.IntField(this.id, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x", "x"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x", ""), GUILayout.Width(100));
}
this.x = UnityEditor.EditorGUILayout.TextField(this.x, GUILayout.Width(150));
if (GUILayout.Button("…", GUILayout.Width(20)))
{
    TextInputWindow.GetTextAsync(this.x,__x =>this.x = __x);
}
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}    }
    public static CompositeJsonTable1 LoadJsonCompositeJsonTable1(SimpleJSON.JSONNode _json)
    {
        CompositeJsonTable1 obj = new test.CompositeJsonTable1();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonCompositeJsonTable1(CompositeJsonTable1 _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int id;
    public string x;

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "x:" + x + ","
        + "}";
    }
}

}

