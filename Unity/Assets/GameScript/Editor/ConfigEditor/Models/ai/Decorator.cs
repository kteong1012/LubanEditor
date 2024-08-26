
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

namespace editor.cfg.ai
{

public abstract class Decorator :  ai.Node 
{
    public Decorator()
    {
            flowAbortMode = ai.EFlowAbortMode.NONE;
    }
    public override string GetTypeStr() => TYPE_STR;
    private const string TYPE_STR = "ai.Decorator";

    private int _typeIndex = -1;
    public new int TypeIndex
    {
        get => _typeIndex;
        set
        {
            if(_typeIndex == value)
            {
                return;
            }
            _typeIndex = value;
            Instance = Create(Types[value]);
        }
    }
    public new Decorator Instance { get; set;}
    public new static List<string> Types = new List<string>()
    {
        "ai.UeLoop",
        "ai.UeCooldown",
        "ai.UeTimeLimit",
        "ai.UeBlackboard",
        "ai.UeForceSuccess",
        "ai.IsAtLocation",
        "ai.DistanceLessThan",
    };

    public new static Decorator Create(string type)
    {
        switch (type)
        {
            case "ai.UeLoop":   
            case "UeLoop":return new ai.UeLoop();
            case "ai.UeCooldown":   
            case "UeCooldown":return new ai.UeCooldown();
            case "ai.UeTimeLimit":   
            case "UeTimeLimit":return new ai.UeTimeLimit();
            case "ai.UeBlackboard":   
            case "UeBlackboard":return new ai.UeBlackboard();
            case "ai.UeForceSuccess":   
            case "UeForceSuccess":return new ai.UeForceSuccess();
            case "ai.IsAtLocation":   
            case "IsAtLocation":return new ai.IsAtLocation();
            case "ai.DistanceLessThan":   
            case "DistanceLessThan":return new ai.DistanceLessThan();
            default: return null;
        }
    }

    private GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);

    public override void Render()
    {
{
    var __list0 = ai.Decorator.Types.Select(t => new GUIContent(t)).ToArray();
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    if (this == null)
    {
        
        this.TypeIndex = 0;
    }
    UnityEditor.EditorGUILayout.BeginHorizontal();
    UnityEditor.EditorGUILayout.LabelField("类型", GUILayout.Width(100));
    this.TypeIndex = UnityEditor.EditorGUILayout.Popup(this.TypeIndex, __list0, GUILayout.Width(200));
    UnityEditor.EditorGUILayout.EndHorizontal();
    this.Instance.Render();
    UnityEditor.EditorGUILayout.EndVertical();
}    }

    public static Decorator LoadJsonDecorator(SimpleJSON.JSONNode _json)
    {
        string type = _json["$type"];
        Decorator obj;
        switch (type)
        {
            case "ai.UeLoop":   
            case "UeLoop":obj = new ai.UeLoop(); break;
            case "ai.UeCooldown":   
            case "UeCooldown":obj = new ai.UeCooldown(); break;
            case "ai.UeTimeLimit":   
            case "UeTimeLimit":obj = new ai.UeTimeLimit(); break;
            case "ai.UeBlackboard":   
            case "UeBlackboard":obj = new ai.UeBlackboard(); break;
            case "ai.UeForceSuccess":   
            case "UeForceSuccess":obj = new ai.UeForceSuccess(); break;
            case "ai.IsAtLocation":   
            case "IsAtLocation":obj = new ai.IsAtLocation(); break;
            case "ai.DistanceLessThan":   
            case "DistanceLessThan":obj = new ai.DistanceLessThan(); break;
            default: throw new SerializationException();
        }
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonDecorator(Decorator _obj, SimpleJSON.JSONNode _json)
    {
        _json["$type"] = _obj.Instance.GetTypeStr();
        _obj.Instance.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public ai.EFlowAbortMode flowAbortMode;

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "nodeName:" + nodeName + ","
        + "flowAbortMode:" + flowAbortMode + ","
        + "}";
    }
}

}
