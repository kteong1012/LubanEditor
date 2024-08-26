
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

namespace editor.cfg.common
{

public sealed class DateTimeRange :  Luban.EditorBeanBase 
{
    public DateTimeRange()
    {
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["start_time"];
            if (_fieldJson != null)
            {
                if (_fieldJson.IsString)
                {
                    startTime = _fieldJson;
                }
                else if (_fieldJson.IsNumber)
                {
                    startTime = _fieldJson;
                }
                else
                {
                    throw new SerializationException();
                }
            }
        }
        
        { 
            var _fieldJson = _json["end_time"];
            if (_fieldJson != null)
            {
                if (_fieldJson.IsString)
                {
                    endTime = _fieldJson;
                }
                else if (_fieldJson.IsNumber)
                {
                    endTime = _fieldJson;
                }
                else
                {
                    throw new SerializationException();
                }
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {

        if (startTime != null)
        {
            _json["start_time"] = new JSONString(startTime);
        }

        if (endTime != null)
        {
            _json["end_time"] = new JSONString(endTime);
        }
    }

    private GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);

    public override void Render()
    {
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("start_time", "start_time"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("start_time", ""), GUILayout.Width(100));
}
this.startTime = UnityEditor.EditorGUILayout.TextField(this.startTime, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("end_time", "end_time"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("end_time", ""), GUILayout.Width(100));
}
this.endTime = UnityEditor.EditorGUILayout.TextField(this.endTime, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}    }

    public static DateTimeRange LoadJsonDateTimeRange(SimpleJSON.JSONNode _json)
    {
        DateTimeRange obj = new common.DateTimeRange();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonDateTimeRange(DateTimeRange _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public string startTime;
    public string endTime;

    public override string ToString()
    {
        return "{ "
        + "startTime:" + startTime + ","
        + "endTime:" + endTime + ","
        + "}";
    }
}

}

