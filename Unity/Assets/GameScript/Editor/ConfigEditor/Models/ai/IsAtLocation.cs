
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

public sealed class IsAtLocation :  ai.Decorator 
{
    public IsAtLocation(Action<Luban.EditorBeanBase> setChangeAction = null)  : base(setChangeAction) 
    {
        _setChangeAction = setChangeAction;
            keyboardKey = "";
    }
    public override string GetTypeStr() => TYPE_STR;
    private const string TYPE_STR = "IsAtLocation";

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
            var _fieldJson = _json["acceptable_radius"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  acceptableRadius = _fieldJson;
            }
            else
            {
                acceptableRadius = 0;
            }
        }
        
        { 
            var _fieldJson = _json["keyboard_key"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  keyboardKey = _fieldJson;
            }
            else
            {
                keyboardKey = "";
            }
        }
        
        { 
            var _fieldJson = _json["inverse_condition"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsBoolean) { throw new SerializationException(); }  inverseCondition = _fieldJson;
            }
            else
            {
                inverseCondition = false;
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
            _json["acceptable_radius"] = new JSONNumber(acceptableRadius);
        }

        if (keyboardKey != null)
        {
            _json["keyboard_key"] = new JSONString(keyboardKey);
        }
        {
            _json["inverse_condition"] = new JSONBool(inverseCondition);
        }
    }

    private static GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);

    public static void RenderIsAtLocation(IsAtLocation obj)
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

this.flowAbortMode = (editor.cfg.ai.EFlowAbortMode)UnityEditor.EditorGUILayout.EnumPopup(this.flowAbortMode, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("acceptable_radius", "acceptable_radius"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("acceptable_radius", ""), GUILayout.Width(100));
}
this.acceptableRadius = UnityEditor.EditorGUILayout.DoubleField(this.acceptableRadius, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("keyboard_key", "keyboard_key"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("keyboard_key", ""), GUILayout.Width(100));
}
this.keyboardKey = UnityEditor.EditorGUILayout.TextField(this.keyboardKey, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("inverse_condition", "inverse_condition"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("inverse_condition", ""), GUILayout.Width(100));
}
this.inverseCondition = UnityEditor.EditorGUILayout.Toggle(this.inverseCondition, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}    }
    public static IsAtLocation LoadJsonIsAtLocation(SimpleJSON.JSONNode _json, Action<Luban.EditorBeanBase> setChangeAction = null)
    {
        IsAtLocation obj = new ai.IsAtLocation();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonIsAtLocation(IsAtLocation _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public double acceptableRadius;
    public string keyboardKey;
    public bool inverseCondition;

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "nodeName:" + nodeName + ","
        + "flowAbortMode:" + flowAbortMode + ","
        + "acceptableRadius:" + acceptableRadius + ","
        + "keyboardKey:" + keyboardKey + ","
        + "inverseCondition:" + inverseCondition + ","
        + "}";
    }
}

}

