
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

public sealed class MultiUnionIndexList :  Luban.EditorBeanBase 
{
    public MultiUnionIndexList()
    {
            id3 = "";
            desc = "";
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["id1"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  id1 = _fieldJson;
            }
            else
            {
                id1 = 0;
            }
        }
        
        { 
            var _fieldJson = _json["id2"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  id2 = _fieldJson;
            }
            else
            {
                id2 = 0;
            }
        }
        
        { 
            var _fieldJson = _json["id3"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  id3 = _fieldJson;
            }
            else
            {
                id3 = "";
            }
        }
        
        { 
            var _fieldJson = _json["num"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  num = _fieldJson;
            }
            else
            {
                num = 0;
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
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            _json["id1"] = new JSONNumber(id1);
        }
        {
            _json["id2"] = new JSONNumber(id2);
        }

        if (id3 != null)
        {
            _json["id3"] = new JSONString(id3);
        }
        {
            _json["num"] = new JSONNumber(num);
        }

        if (desc != null)
        {
            _json["desc"] = new JSONString(desc);
        }
    }

    private static GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);

    public static void RenderMultiUnionIndexList(MultiUnionIndexList obj)
    {
        obj.Render();
    }

    public override void Render()
    {
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("id1", "id1"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("id1", ""), GUILayout.Width(100));
}
this.id1 = UnityEditor.EditorGUILayout.IntField(this.id1, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("id2", "id2"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("id2", ""), GUILayout.Width(100));
}
this.id2 = UnityEditor.EditorGUILayout.LongField(this.id2, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("id3", "id3"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("id3", ""), GUILayout.Width(100));
}
this.id3 = UnityEditor.EditorGUILayout.TextField(this.id3, GUILayout.Width(150));
if (GUILayout.Button("…", GUILayout.Width(20)))
{
    TextInputWindow.GetTextAsync(this.id3,__x =>this.id3 = __x);
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("num", "num"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("num", ""), GUILayout.Width(100));
}
this.num = UnityEditor.EditorGUILayout.IntField(this.num, GUILayout.Width(150));
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
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}    }
    public static MultiUnionIndexList LoadJsonMultiUnionIndexList(SimpleJSON.JSONNode _json)
    {
        MultiUnionIndexList obj = new test.MultiUnionIndexList();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonMultiUnionIndexList(MultiUnionIndexList _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int id1;
    public long id2;
    public string id3;
    public int num;
    public string desc;

    public override string ToString()
    {
        return "{ "
        + "id1:" + id1 + ","
        + "id2:" + id2 + ","
        + "id3:" + id3 + ","
        + "num:" + num + ","
        + "desc:" + desc + ","
        + "}";
    }
}

}

