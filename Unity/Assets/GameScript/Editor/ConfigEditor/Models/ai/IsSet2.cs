
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

public sealed class IsSet2 :  ai.KeyQueryOperator 
{
    public IsSet2()
    {
    }
    public override string GetTypeStr() => TYPE_STR;
    private const string TYPE_STR = "IsSet2";

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
    }

    private static GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);

    public static void RenderIsSet2(IsSet2 obj)
    {
        obj.Render();
    }

    public override void Render()
    {
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);    UnityEditor.EditorGUILayout.EndVertical();
}    }
    public static IsSet2 LoadJsonIsSet2(SimpleJSON.JSONNode _json)
    {
        IsSet2 obj = new ai.IsSet2();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonIsSet2(IsSet2 _obj, SimpleJSON.JSONNode _json)
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

