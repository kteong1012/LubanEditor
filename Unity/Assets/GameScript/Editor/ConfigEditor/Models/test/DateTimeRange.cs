
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

public sealed class DateTimeRange :  Luban.EditorBeanBase 
{
    public DateTimeRange()
    {
            startTime = 0;
            endTime = 0;
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
            else
            {
                startTime = 0;
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
            else
            {
                endTime = 0;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            _json["start_time"] = new JSONNumber(startTime);
        }
        {
            _json["end_time"] = new JSONNumber(endTime);
        }
    }

    private static GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);

    public static void RenderDateTimeRange(DateTimeRange obj)
    {
        obj.Render();
    }

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
this.startTime = UnityEditor.EditorGUILayout.LongField(this.startTime, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("end_time", "end_time"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("end_time", ""), GUILayout.Width(100));
}
this.endTime = UnityEditor.EditorGUILayout.LongField(this.endTime, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}    }
    public static DateTimeRange LoadJsonDateTimeRange(SimpleJSON.JSONNode _json)
    {
        DateTimeRange obj = new test.DateTimeRange();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonDateTimeRange(DateTimeRange _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public long startTime;
    public long endTime;

    public override string ToString()
    {
        return "{ "
        + "startTime:" + startTime + ","
        + "endTime:" + endTime + ","
        + "}";
    }
}

}

