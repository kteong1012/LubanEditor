
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

public sealed class IsNotSet :  ai.KeyQueryOperator 
{
    public IsNotSet(Action<Luban.EditorBeanBase> setChangeAction = null)  : base(setChangeAction) 
    {
        _setChangeAction = setChangeAction;
    }
    public override string GetTypeStr() => TYPE_STR;
    private const string TYPE_STR = "IsNotSet";

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
    }

    private GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);

    public override void Render()
    {
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);    UnityEditor.EditorGUILayout.EndVertical();
}    }
    public static IsNotSet LoadJsonIsNotSet(SimpleJSON.JSONNode _json, Action<Luban.EditorBeanBase> setChangeAction = null)
    {
        IsNotSet obj = new ai.IsNotSet();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonIsNotSet(IsNotSet _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }


    public override string ToString()
    {
        return "{ "
        + "}";
    }
}

}

