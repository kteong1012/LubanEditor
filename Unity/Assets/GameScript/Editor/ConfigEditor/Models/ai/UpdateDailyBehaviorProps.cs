
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

public sealed class UpdateDailyBehaviorProps :  ai.Service 
{
    public UpdateDailyBehaviorProps()
    {
            satietyKey = "";
            energyKey = "";
            moodKey = "";
            satietyLowerThresholdKey = "";
            satietyUpperThresholdKey = "";
            energyLowerThresholdKey = "";
            energyUpperThresholdKey = "";
            moodLowerThresholdKey = "";
            moodUpperThresholdKey = "";
    }
    public override string GetTypeStr() => TYPE_STR;
    private const string TYPE_STR = "UpdateDailyBehaviorProps";

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
            var _fieldJson = _json["node_name"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  nodeName = _fieldJson;
            }
            else
            {
                nodeName = "";
            }
        }
        
        { 
            var _fieldJson = _json["satiety_key"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  satietyKey = _fieldJson;
            }
            else
            {
                satietyKey = "";
            }
        }
        
        { 
            var _fieldJson = _json["energy_key"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  energyKey = _fieldJson;
            }
            else
            {
                energyKey = "";
            }
        }
        
        { 
            var _fieldJson = _json["mood_key"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  moodKey = _fieldJson;
            }
            else
            {
                moodKey = "";
            }
        }
        
        { 
            var _fieldJson = _json["satiety_lower_threshold_key"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  satietyLowerThresholdKey = _fieldJson;
            }
            else
            {
                satietyLowerThresholdKey = "";
            }
        }
        
        { 
            var _fieldJson = _json["satiety_upper_threshold_key"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  satietyUpperThresholdKey = _fieldJson;
            }
            else
            {
                satietyUpperThresholdKey = "";
            }
        }
        
        { 
            var _fieldJson = _json["energy_lower_threshold_key"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  energyLowerThresholdKey = _fieldJson;
            }
            else
            {
                energyLowerThresholdKey = "";
            }
        }
        
        { 
            var _fieldJson = _json["energy_upper_threshold_key"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  energyUpperThresholdKey = _fieldJson;
            }
            else
            {
                energyUpperThresholdKey = "";
            }
        }
        
        { 
            var _fieldJson = _json["mood_lower_threshold_key"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  moodLowerThresholdKey = _fieldJson;
            }
            else
            {
                moodLowerThresholdKey = "";
            }
        }
        
        { 
            var _fieldJson = _json["mood_upper_threshold_key"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  moodUpperThresholdKey = _fieldJson;
            }
            else
            {
                moodUpperThresholdKey = "";
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            _json["id"] = new JSONNumber(id);
        }

        if (nodeName != null)
        {
            _json["node_name"] = new JSONString(nodeName);
        }

        if (satietyKey != null)
        {
            _json["satiety_key"] = new JSONString(satietyKey);
        }

        if (energyKey != null)
        {
            _json["energy_key"] = new JSONString(energyKey);
        }

        if (moodKey != null)
        {
            _json["mood_key"] = new JSONString(moodKey);
        }

        if (satietyLowerThresholdKey != null)
        {
            _json["satiety_lower_threshold_key"] = new JSONString(satietyLowerThresholdKey);
        }

        if (satietyUpperThresholdKey != null)
        {
            _json["satiety_upper_threshold_key"] = new JSONString(satietyUpperThresholdKey);
        }

        if (energyLowerThresholdKey != null)
        {
            _json["energy_lower_threshold_key"] = new JSONString(energyLowerThresholdKey);
        }

        if (energyUpperThresholdKey != null)
        {
            _json["energy_upper_threshold_key"] = new JSONString(energyUpperThresholdKey);
        }

        if (moodLowerThresholdKey != null)
        {
            _json["mood_lower_threshold_key"] = new JSONString(moodLowerThresholdKey);
        }

        if (moodUpperThresholdKey != null)
        {
            _json["mood_upper_threshold_key"] = new JSONString(moodUpperThresholdKey);
        }
    }

    private static GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);

    public static void RenderUpdateDailyBehaviorProps(UpdateDailyBehaviorProps obj)
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
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("node_name", "node_name"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("node_name", ""), GUILayout.Width(100));
}
this.nodeName = UnityEditor.EditorGUILayout.TextField(this.nodeName, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("satiety_key", "satiety_key"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("satiety_key", ""), GUILayout.Width(100));
}
this.satietyKey = UnityEditor.EditorGUILayout.TextField(this.satietyKey, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("energy_key", "energy_key"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("energy_key", ""), GUILayout.Width(100));
}
this.energyKey = UnityEditor.EditorGUILayout.TextField(this.energyKey, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("mood_key", "mood_key"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("mood_key", ""), GUILayout.Width(100));
}
this.moodKey = UnityEditor.EditorGUILayout.TextField(this.moodKey, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("satiety_lower_threshold_key", "satiety_lower_threshold_key"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("satiety_lower_threshold_key", ""), GUILayout.Width(100));
}
this.satietyLowerThresholdKey = UnityEditor.EditorGUILayout.TextField(this.satietyLowerThresholdKey, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("satiety_upper_threshold_key", "satiety_upper_threshold_key"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("satiety_upper_threshold_key", ""), GUILayout.Width(100));
}
this.satietyUpperThresholdKey = UnityEditor.EditorGUILayout.TextField(this.satietyUpperThresholdKey, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("energy_lower_threshold_key", "energy_lower_threshold_key"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("energy_lower_threshold_key", ""), GUILayout.Width(100));
}
this.energyLowerThresholdKey = UnityEditor.EditorGUILayout.TextField(this.energyLowerThresholdKey, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("energy_upper_threshold_key", "energy_upper_threshold_key"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("energy_upper_threshold_key", ""), GUILayout.Width(100));
}
this.energyUpperThresholdKey = UnityEditor.EditorGUILayout.TextField(this.energyUpperThresholdKey, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("mood_lower_threshold_key", "mood_lower_threshold_key"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("mood_lower_threshold_key", ""), GUILayout.Width(100));
}
this.moodLowerThresholdKey = UnityEditor.EditorGUILayout.TextField(this.moodLowerThresholdKey, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("mood_upper_threshold_key", "mood_upper_threshold_key"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("mood_upper_threshold_key", ""), GUILayout.Width(100));
}
this.moodUpperThresholdKey = UnityEditor.EditorGUILayout.TextField(this.moodUpperThresholdKey, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}    }
    public static UpdateDailyBehaviorProps LoadJsonUpdateDailyBehaviorProps(SimpleJSON.JSONNode _json)
    {
        UpdateDailyBehaviorProps obj = new ai.UpdateDailyBehaviorProps();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonUpdateDailyBehaviorProps(UpdateDailyBehaviorProps _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public string satietyKey;
    public string energyKey;
    public string moodKey;
    public string satietyLowerThresholdKey;
    public string satietyUpperThresholdKey;
    public string energyLowerThresholdKey;
    public string energyUpperThresholdKey;
    public string moodLowerThresholdKey;
    public string moodUpperThresholdKey;

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "nodeName:" + nodeName + ","
        + "satietyKey:" + satietyKey + ","
        + "energyKey:" + energyKey + ","
        + "moodKey:" + moodKey + ","
        + "satietyLowerThresholdKey:" + satietyLowerThresholdKey + ","
        + "satietyUpperThresholdKey:" + satietyUpperThresholdKey + ","
        + "energyLowerThresholdKey:" + energyLowerThresholdKey + ","
        + "energyUpperThresholdKey:" + energyUpperThresholdKey + ","
        + "moodLowerThresholdKey:" + moodLowerThresholdKey + ","
        + "moodUpperThresholdKey:" + moodUpperThresholdKey + ","
        + "}";
    }
}

}

