
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

public sealed class OneDayTimeRange :  Luban.EditorBeanBase 
{
    public OneDayTimeRange()
    {
            startTime = new common.TimeOfDay();
            endTime = new common.TimeOfDay();
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["start_time"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsObject) { throw new SerializationException(); }  startTime = common.TimeOfDay.LoadJsonTimeOfDay(_fieldJson);
            }
        }
        
        { 
            var _fieldJson = _json["end_time"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsObject) { throw new SerializationException(); }  endTime = common.TimeOfDay.LoadJsonTimeOfDay(_fieldJson);
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            if (startTime == null) { throw new System.ArgumentNullException(); }
            { var __bjson = new JSONObject();  common.TimeOfDay.SaveJsonTimeOfDay(startTime, __bjson); _json["start_time"] = __bjson; }
        }
        {
            if (endTime == null) { throw new System.ArgumentNullException(); }
            { var __bjson = new JSONObject();  common.TimeOfDay.SaveJsonTimeOfDay(endTime, __bjson); _json["end_time"] = __bjson; }
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
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("hour", "hour"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("hour", ""), GUILayout.Width(100));
}
this.startTime.hour = UnityEditor.EditorGUILayout.IntField(this.startTime.hour, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("minute", "minute"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("minute", ""), GUILayout.Width(100));
}
this.startTime.minute = UnityEditor.EditorGUILayout.IntField(this.startTime.minute, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("second", "second"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("second", ""), GUILayout.Width(100));
}
this.startTime.second = UnityEditor.EditorGUILayout.IntField(this.startTime.second, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("end_time", "end_time"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("end_time", ""), GUILayout.Width(100));
}
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("hour", "hour"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("hour", ""), GUILayout.Width(100));
}
this.endTime.hour = UnityEditor.EditorGUILayout.IntField(this.endTime.hour, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("minute", "minute"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("minute", ""), GUILayout.Width(100));
}
this.endTime.minute = UnityEditor.EditorGUILayout.IntField(this.endTime.minute, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("second", "second"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("second", ""), GUILayout.Width(100));
}
this.endTime.second = UnityEditor.EditorGUILayout.IntField(this.endTime.second, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}    }

    public static OneDayTimeRange LoadJsonOneDayTimeRange(SimpleJSON.JSONNode _json)
    {
        OneDayTimeRange obj = new common.OneDayTimeRange();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonOneDayTimeRange(OneDayTimeRange _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public common.TimeOfDay startTime;
    public common.TimeOfDay endTime;

    public override string ToString()
    {
        return "{ "
        + "startTime:" + startTime + ","
        + "endTime:" + endTime + ","
        + "}";
    }
}

}
