
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

public sealed class UeCooldown :  ai.Decorator 
{
    public UeCooldown()
    {
    }
    public override string GetTypeStr() => TYPE_STR;
    private const string TYPE_STR = "UeCooldown";

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
            var _fieldJson = _json["flow_abort_mode"];
            if (_fieldJson != null)
            {
                if(_fieldJson.IsString) { flowAbortMode = (editor.cfg.ai.EFlowAbortMode)System.Enum.Parse(typeof(editor.cfg.ai.EFlowAbortMode), _fieldJson); } else if(_fieldJson.IsNumber) { flowAbortMode = (editor.cfg.ai.EFlowAbortMode)(int)_fieldJson; } else { throw new SerializationException(); }  
            }
            else
            {
                flowAbortMode = editor.cfg.ai.EFlowAbortMode.NONE;
            }
        }
        
        { 
            var _fieldJson = _json["cooldown_time"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  cooldownTime = _fieldJson;
            }
            else
            {
                cooldownTime = 0;
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
        {
            _json["flow_abort_mode"] = new JSONNumber((int)flowAbortMode);
        }
        {
            _json["cooldown_time"] = new JSONNumber(cooldownTime);
        }
    }

    private static GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);

    public static void RenderUeCooldown(UeCooldown obj)
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
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("flow_abort_mode", "flow_abort_mode"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("flow_abort_mode", ""), GUILayout.Width(100));
}
{
    if (ConfigEditorSettings.showComment)
    {
        var __index1 = (int)this.flowAbortMode;
        var __alias1 = (ai.EFlowAbortMode_Alias)this.flowAbortMode;
        __alias1 = (ai.EFlowAbortMode_Alias)UnityEditor.EditorGUILayout.EnumPopup(__alias1, GUILayout.Width(150));
        var __item1 = ai.EFlowAbortMode_Metadata.GetByNameOrAlias(__alias1.ToString());
        this.flowAbortMode = (editor.cfg.ai.EFlowAbortMode)__item1.Value;
    }
    else
    {
        this.flowAbortMode = (editor.cfg.ai.EFlowAbortMode)UnityEditor.EditorGUILayout.EnumPopup(this.flowAbortMode, GUILayout.Width(150));
    }
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("cooldown_time", "cooldown_time"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("cooldown_time", ""), GUILayout.Width(100));
}
this.cooldownTime = UnityEditor.EditorGUILayout.DoubleField(this.cooldownTime, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}    }
    public static UeCooldown LoadJsonUeCooldown(SimpleJSON.JSONNode _json)
    {
        UeCooldown obj = new ai.UeCooldown();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonUeCooldown(UeCooldown _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public double cooldownTime;

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "nodeName:" + nodeName + ","
        + "flowAbortMode:" + flowAbortMode + ","
        + "cooldownTime:" + cooldownTime + ","
        + "}";
    }
}

}

