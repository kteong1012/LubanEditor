
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

namespace editor.cfg.tag
{

public sealed class TestTag :  Luban.EditorBeanBase 
{
    public TestTag()
    {
            value = "";
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["id"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  id = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["value"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  value = _fieldJson;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            _json["id"] = new JSONNumber(id);
        }
        {
            if (value == null) { throw new System.ArgumentNullException(); }
            _json["value"] = new JSONString(value);
        }
    }

    private GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);

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
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("value", "value"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("value", ""), GUILayout.Width(100));
}
this.value = UnityEditor.EditorGUILayout.TextField(this.value, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}    }

    public static TestTag LoadJsonTestTag(SimpleJSON.JSONNode _json)
    {
        TestTag obj = new tag.TestTag();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonTestTag(TestTag _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int id;
    public string value;

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "value:" + value + ","
        + "}";
    }
}

}
