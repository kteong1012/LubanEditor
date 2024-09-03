
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

public sealed class UeBlackboard :  ai.Decorator 
{
    public UeBlackboard()
    {
            notifyObserver = editor.cfg.ai.ENotifyObserverMode.ON_VALUE_CHANGE;
            blackboardKey = "";
    }
    public override string GetTypeStr() => TYPE_STR;
    private const string TYPE_STR = "UeBlackboard";

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
            var _fieldJson = _json["notify_observer"];
            if (_fieldJson != null)
            {
                if(_fieldJson.IsString) { notifyObserver = (editor.cfg.ai.ENotifyObserverMode)System.Enum.Parse(typeof(editor.cfg.ai.ENotifyObserverMode), _fieldJson); } else if(_fieldJson.IsNumber) { notifyObserver = (editor.cfg.ai.ENotifyObserverMode)(int)_fieldJson; } else { throw new SerializationException(); }  
            }
            else
            {
                notifyObserver = editor.cfg.ai.ENotifyObserverMode.ON_VALUE_CHANGE;
            }
        }
        
        { 
            var _fieldJson = _json["blackboard_key"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  blackboardKey = _fieldJson;
            }
            else
            {
                blackboardKey = "";
            }
        }
        
        { 
            var _fieldJson = _json["key_query"];
            if (_fieldJson != null)
            {
                
                if (!_fieldJson.IsObject)
                {
                    throw new SerializationException();
                }
                keyQuery = editor.cfg.ai.KeyQueryOperator.LoadJsonKeyQueryOperator(_fieldJson);
            }
            else
            {
                keyQuery = ai.KeyQueryOperator.Create("IsSet2");
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
            _json["notify_observer"] = new JSONNumber((int)notifyObserver);
        }

        if (blackboardKey != null)
        {
            _json["blackboard_key"] = new JSONString(blackboardKey);
        }

        if (keyQuery != null)
        {
            { var __bjson = new JSONObject();  editor.cfg.ai.KeyQueryOperator.SaveJsonKeyQueryOperator(keyQuery, __bjson); _json["key_query"] = __bjson; }
        }
    }

    private static GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);

    public static void RenderUeBlackboard(UeBlackboard obj)
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

this.flowAbortMode = (editor.cfg.ai.EFlowAbortMode)UnityEditor.EditorGUILayout.EnumPopup(this.flowAbortMode, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("notify_observer", "notify_observer"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("notify_observer", ""), GUILayout.Width(100));
}

this.notifyObserver = (editor.cfg.ai.ENotifyObserverMode)UnityEditor.EditorGUILayout.EnumPopup(this.notifyObserver, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("blackboard_key", "blackboard_key"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("blackboard_key", ""), GUILayout.Width(100));
}
this.blackboardKey = UnityEditor.EditorGUILayout.TextField(this.blackboardKey, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("key_query", "key_query"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("key_query", ""), GUILayout.Width(100));
}
{
    ai.KeyQueryOperator.RenderKeyQueryOperator(ref this.keyQuery);
}
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}    }
    public static UeBlackboard LoadJsonUeBlackboard(SimpleJSON.JSONNode _json)
    {
        UeBlackboard obj = new ai.UeBlackboard();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonUeBlackboard(UeBlackboard _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public editor.cfg.ai.ENotifyObserverMode notifyObserver;
    public string blackboardKey;
    public editor.cfg.ai.KeyQueryOperator keyQuery;

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "nodeName:" + nodeName + ","
        + "flowAbortMode:" + flowAbortMode + ","
        + "notifyObserver:" + notifyObserver + ","
        + "blackboardKey:" + blackboardKey + ","
        + "keyQuery:" + keyQuery + ","
        + "}";
    }
}

}

