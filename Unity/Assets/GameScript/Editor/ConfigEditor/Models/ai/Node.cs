
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

public abstract class Node :  Luban.EditorBeanBase 
{
    public Node(Action<Luban.EditorBeanBase> setChangeAction = null) 
    {
        _setChangeAction = setChangeAction;
            nodeName = "";
    }
    public abstract string GetTypeStr();

    private int _typeIndex = -1;
    public int TypeIndex
    {
        get => _typeIndex;
        set
        {
            if(_typeIndex == value)
            {
                return;
            }
            _typeIndex = value;
            var obj = Create(Types[value], _setChangeAction);
            _setChangeAction(obj);
        }
    }
    private static string[] Types = new string[]
    {
        "UeSetDefaultFocus",
        "ExecuteTimeStatistic",
        "ChooseTarget",
        "KeepFaceTarget",
        "GetOwnerPlayer",
        "UpdateDailyBehaviorProps",
        "UeLoop",
        "UeCooldown",
        "UeTimeLimit",
        "UeBlackboard",
        "UeForceSuccess",
        "IsAtLocation",
        "DistanceLessThan",
        "Sequence",
        "Selector",
        "SimpleParallel",
        "UeWait",
        "UeWaitBlackboardTime",
        "MoveToTarget",
        "ChooseSkill",
        "MoveToRandomLocation",
        "MoveToLocation",
        "DebugPrint",
    };
    private static string[] TypeAlias = new string[]
    {
        "UeSetDefaultFocus",
        "ExecuteTimeStatistic",
        "ChooseTarget",
        "KeepFaceTarget",
        "GetOwnerPlayer",
        "UpdateDailyBehaviorProps",
        "UeLoop",
        "UeCooldown",
        "UeTimeLimit",
        "UeBlackboard",
        "UeForceSuccess",
        "IsAtLocation",
        "DistanceLessThan",
        "Sequence",
        "Selector",
        "SimpleParallel",
        "UeWait",
        "UeWaitBlackboardTime",
        "MoveToTarget",
        "ChooseSkill",
        "MoveToRandomLocation",
        "MoveToLocation",
        "DebugPrint",
    };

    public static Node Create(string type, Action<Luban.EditorBeanBase> setChangeAction)
    {
        switch (type)
        {
            case "ai.UeSetDefaultFocus":   
            case "UeSetDefaultFocus":
            {
                var obj = new ai.UeSetDefaultFocus(setChangeAction);
                obj._typeIndex = Array.IndexOf(Types,type);
                return obj;
            }
            case "ai.ExecuteTimeStatistic":   
            case "ExecuteTimeStatistic":
            {
                var obj = new ai.ExecuteTimeStatistic(setChangeAction);
                obj._typeIndex = Array.IndexOf(Types,type);
                return obj;
            }
            case "ai.ChooseTarget":   
            case "ChooseTarget":
            {
                var obj = new ai.ChooseTarget(setChangeAction);
                obj._typeIndex = Array.IndexOf(Types,type);
                return obj;
            }
            case "ai.KeepFaceTarget":   
            case "KeepFaceTarget":
            {
                var obj = new ai.KeepFaceTarget(setChangeAction);
                obj._typeIndex = Array.IndexOf(Types,type);
                return obj;
            }
            case "ai.GetOwnerPlayer":   
            case "GetOwnerPlayer":
            {
                var obj = new ai.GetOwnerPlayer(setChangeAction);
                obj._typeIndex = Array.IndexOf(Types,type);
                return obj;
            }
            case "ai.UpdateDailyBehaviorProps":   
            case "UpdateDailyBehaviorProps":
            {
                var obj = new ai.UpdateDailyBehaviorProps(setChangeAction);
                obj._typeIndex = Array.IndexOf(Types,type);
                return obj;
            }
            case "ai.UeLoop":   
            case "UeLoop":
            {
                var obj = new ai.UeLoop(setChangeAction);
                obj._typeIndex = Array.IndexOf(Types,type);
                return obj;
            }
            case "ai.UeCooldown":   
            case "UeCooldown":
            {
                var obj = new ai.UeCooldown(setChangeAction);
                obj._typeIndex = Array.IndexOf(Types,type);
                return obj;
            }
            case "ai.UeTimeLimit":   
            case "UeTimeLimit":
            {
                var obj = new ai.UeTimeLimit(setChangeAction);
                obj._typeIndex = Array.IndexOf(Types,type);
                return obj;
            }
            case "ai.UeBlackboard":   
            case "UeBlackboard":
            {
                var obj = new ai.UeBlackboard(setChangeAction);
                obj._typeIndex = Array.IndexOf(Types,type);
                return obj;
            }
            case "ai.UeForceSuccess":   
            case "UeForceSuccess":
            {
                var obj = new ai.UeForceSuccess(setChangeAction);
                obj._typeIndex = Array.IndexOf(Types,type);
                return obj;
            }
            case "ai.IsAtLocation":   
            case "IsAtLocation":
            {
                var obj = new ai.IsAtLocation(setChangeAction);
                obj._typeIndex = Array.IndexOf(Types,type);
                return obj;
            }
            case "ai.DistanceLessThan":   
            case "DistanceLessThan":
            {
                var obj = new ai.DistanceLessThan(setChangeAction);
                obj._typeIndex = Array.IndexOf(Types,type);
                return obj;
            }
            case "ai.Sequence":   
            case "Sequence":
            {
                var obj = new ai.Sequence(setChangeAction);
                obj._typeIndex = Array.IndexOf(Types,type);
                return obj;
            }
            case "ai.Selector":   
            case "Selector":
            {
                var obj = new ai.Selector(setChangeAction);
                obj._typeIndex = Array.IndexOf(Types,type);
                return obj;
            }
            case "ai.SimpleParallel":   
            case "SimpleParallel":
            {
                var obj = new ai.SimpleParallel(setChangeAction);
                obj._typeIndex = Array.IndexOf(Types,type);
                return obj;
            }
            case "ai.UeWait":   
            case "UeWait":
            {
                var obj = new ai.UeWait(setChangeAction);
                obj._typeIndex = Array.IndexOf(Types,type);
                return obj;
            }
            case "ai.UeWaitBlackboardTime":   
            case "UeWaitBlackboardTime":
            {
                var obj = new ai.UeWaitBlackboardTime(setChangeAction);
                obj._typeIndex = Array.IndexOf(Types,type);
                return obj;
            }
            case "ai.MoveToTarget":   
            case "MoveToTarget":
            {
                var obj = new ai.MoveToTarget(setChangeAction);
                obj._typeIndex = Array.IndexOf(Types,type);
                return obj;
            }
            case "ai.ChooseSkill":   
            case "ChooseSkill":
            {
                var obj = new ai.ChooseSkill(setChangeAction);
                obj._typeIndex = Array.IndexOf(Types,type);
                return obj;
            }
            case "ai.MoveToRandomLocation":   
            case "MoveToRandomLocation":
            {
                var obj = new ai.MoveToRandomLocation(setChangeAction);
                obj._typeIndex = Array.IndexOf(Types,type);
                return obj;
            }
            case "ai.MoveToLocation":   
            case "MoveToLocation":
            {
                var obj = new ai.MoveToLocation(setChangeAction);
                obj._typeIndex = Array.IndexOf(Types,type);
                return obj;
            }
            case "ai.DebugPrint":   
            case "DebugPrint":
            {
                var obj = new ai.DebugPrint(setChangeAction);
                obj._typeIndex = Array.IndexOf(Types,type);
                return obj;
            }
            default: return null;
        }
    }

    private static GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);

    public static void RenderNode(Node obj)
    {
        UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
        var array = ConfigEditorSettings.showComment ? TypeAlias : Types;
        UnityEditor.EditorGUILayout.BeginHorizontal();
        UnityEditor.EditorGUILayout.LabelField("类型", GUILayout.Width(100));
        obj.TypeIndex = UnityEditor.EditorGUILayout.Popup(obj.TypeIndex, array, GUILayout.Width(200));
        UnityEditor.EditorGUILayout.EndHorizontal();
        obj?.Render();
        UnityEditor.EditorGUILayout.EndVertical();
    }

    public override void Render()
    {
{
    ai.Node.RenderNode(this);
}    }
    public static Node LoadJsonNode(SimpleJSON.JSONNode _json, Action<Luban.EditorBeanBase> setChangeAction = null)
    {
        string type = _json["$type"];
        Node obj;
        switch (type)
        {
            case "ai.UeSetDefaultFocus":   
            case "UeSetDefaultFocus":
            {
                obj = new ai.UeSetDefaultFocus(setChangeAction); 
                obj._typeIndex = Array.IndexOf(Types, "UeSetDefaultFocus");
                break;
            }
            case "ai.ExecuteTimeStatistic":   
            case "ExecuteTimeStatistic":
            {
                obj = new ai.ExecuteTimeStatistic(setChangeAction); 
                obj._typeIndex = Array.IndexOf(Types, "ExecuteTimeStatistic");
                break;
            }
            case "ai.ChooseTarget":   
            case "ChooseTarget":
            {
                obj = new ai.ChooseTarget(setChangeAction); 
                obj._typeIndex = Array.IndexOf(Types, "ChooseTarget");
                break;
            }
            case "ai.KeepFaceTarget":   
            case "KeepFaceTarget":
            {
                obj = new ai.KeepFaceTarget(setChangeAction); 
                obj._typeIndex = Array.IndexOf(Types, "KeepFaceTarget");
                break;
            }
            case "ai.GetOwnerPlayer":   
            case "GetOwnerPlayer":
            {
                obj = new ai.GetOwnerPlayer(setChangeAction); 
                obj._typeIndex = Array.IndexOf(Types, "GetOwnerPlayer");
                break;
            }
            case "ai.UpdateDailyBehaviorProps":   
            case "UpdateDailyBehaviorProps":
            {
                obj = new ai.UpdateDailyBehaviorProps(setChangeAction); 
                obj._typeIndex = Array.IndexOf(Types, "UpdateDailyBehaviorProps");
                break;
            }
            case "ai.UeLoop":   
            case "UeLoop":
            {
                obj = new ai.UeLoop(setChangeAction); 
                obj._typeIndex = Array.IndexOf(Types, "UeLoop");
                break;
            }
            case "ai.UeCooldown":   
            case "UeCooldown":
            {
                obj = new ai.UeCooldown(setChangeAction); 
                obj._typeIndex = Array.IndexOf(Types, "UeCooldown");
                break;
            }
            case "ai.UeTimeLimit":   
            case "UeTimeLimit":
            {
                obj = new ai.UeTimeLimit(setChangeAction); 
                obj._typeIndex = Array.IndexOf(Types, "UeTimeLimit");
                break;
            }
            case "ai.UeBlackboard":   
            case "UeBlackboard":
            {
                obj = new ai.UeBlackboard(setChangeAction); 
                obj._typeIndex = Array.IndexOf(Types, "UeBlackboard");
                break;
            }
            case "ai.UeForceSuccess":   
            case "UeForceSuccess":
            {
                obj = new ai.UeForceSuccess(setChangeAction); 
                obj._typeIndex = Array.IndexOf(Types, "UeForceSuccess");
                break;
            }
            case "ai.IsAtLocation":   
            case "IsAtLocation":
            {
                obj = new ai.IsAtLocation(setChangeAction); 
                obj._typeIndex = Array.IndexOf(Types, "IsAtLocation");
                break;
            }
            case "ai.DistanceLessThan":   
            case "DistanceLessThan":
            {
                obj = new ai.DistanceLessThan(setChangeAction); 
                obj._typeIndex = Array.IndexOf(Types, "DistanceLessThan");
                break;
            }
            case "ai.Sequence":   
            case "Sequence":
            {
                obj = new ai.Sequence(setChangeAction); 
                obj._typeIndex = Array.IndexOf(Types, "Sequence");
                break;
            }
            case "ai.Selector":   
            case "Selector":
            {
                obj = new ai.Selector(setChangeAction); 
                obj._typeIndex = Array.IndexOf(Types, "Selector");
                break;
            }
            case "ai.SimpleParallel":   
            case "SimpleParallel":
            {
                obj = new ai.SimpleParallel(setChangeAction); 
                obj._typeIndex = Array.IndexOf(Types, "SimpleParallel");
                break;
            }
            case "ai.UeWait":   
            case "UeWait":
            {
                obj = new ai.UeWait(setChangeAction); 
                obj._typeIndex = Array.IndexOf(Types, "UeWait");
                break;
            }
            case "ai.UeWaitBlackboardTime":   
            case "UeWaitBlackboardTime":
            {
                obj = new ai.UeWaitBlackboardTime(setChangeAction); 
                obj._typeIndex = Array.IndexOf(Types, "UeWaitBlackboardTime");
                break;
            }
            case "ai.MoveToTarget":   
            case "MoveToTarget":
            {
                obj = new ai.MoveToTarget(setChangeAction); 
                obj._typeIndex = Array.IndexOf(Types, "MoveToTarget");
                break;
            }
            case "ai.ChooseSkill":   
            case "ChooseSkill":
            {
                obj = new ai.ChooseSkill(setChangeAction); 
                obj._typeIndex = Array.IndexOf(Types, "ChooseSkill");
                break;
            }
            case "ai.MoveToRandomLocation":   
            case "MoveToRandomLocation":
            {
                obj = new ai.MoveToRandomLocation(setChangeAction); 
                obj._typeIndex = Array.IndexOf(Types, "MoveToRandomLocation");
                break;
            }
            case "ai.MoveToLocation":   
            case "MoveToLocation":
            {
                obj = new ai.MoveToLocation(setChangeAction); 
                obj._typeIndex = Array.IndexOf(Types, "MoveToLocation");
                break;
            }
            case "ai.DebugPrint":   
            case "DebugPrint":
            {
                obj = new ai.DebugPrint(setChangeAction); 
                obj._typeIndex = Array.IndexOf(Types, "DebugPrint");
                break;
            }
            default: throw new SerializationException();
        }
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonNode(Node _obj, SimpleJSON.JSONNode _json)
    {
        _json["$type"] = _obj.GetTypeStr();
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int id;
    public string nodeName;

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "nodeName:" + nodeName + ","
        + "}";
    }
}

}

