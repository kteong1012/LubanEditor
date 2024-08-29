
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

public abstract class RefDynamicBase :  Luban.EditorBeanBase 
{
    private Action<Luban.EditorBeanBase> _setChangeAction;
    public void SetChangeAction(Action<Luban.EditorBeanBase> action) => _setChangeAction = action;
    public RefDynamicBase(Action<Luban.EditorBeanBase> setChangeAction = null) 
    {
        _setChangeAction = setChangeAction;
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
    public static List<string> Types = new List<string>()
    {
        "RefBean",
    };

    public static RefDynamicBase Create(string type, Action<Luban.EditorBeanBase> setChangeAction)
    {
        switch (type)
        {
            case "test.RefBean":   
            case "RefBean":
            {
                var obj = new test.RefBean(setChangeAction);
                obj._typeIndex = Types.IndexOf(type);
                return obj;
            }
            default: return null;
        }
    }

    private GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);

    public override void Render()
    {
{
    var __list0 = test.RefDynamicBase.Types.Select(t => new GUIContent(t)).ToArray();
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    if (this == null)
    {
        
        this.TypeIndex = 0;
    }
    UnityEditor.EditorGUILayout.BeginHorizontal();
    UnityEditor.EditorGUILayout.LabelField("类型", GUILayout.Width(100));
    this.TypeIndex = UnityEditor.EditorGUILayout.Popup(this.TypeIndex, __list0, GUILayout.Width(200));
    UnityEditor.EditorGUILayout.EndHorizontal();
    this?.Render();
    UnityEditor.EditorGUILayout.EndVertical();
}    }
    public static RefDynamicBase LoadJsonRefDynamicBase(SimpleJSON.JSONNode _json, Action<Luban.EditorBeanBase> setChangeAction = null)
    {
        string type = _json["$type"];
        RefDynamicBase obj;
        switch (type)
        {
            case "test.RefBean":   
            case "RefBean":
            {
                obj = new test.RefBean(setChangeAction); 
                obj._typeIndex = Types.IndexOf("RefBean");
                break;
            }
            default: throw new SerializationException();
        }
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonRefDynamicBase(RefDynamicBase _obj, SimpleJSON.JSONNode _json)
    {
        _json["$type"] = _obj.GetTypeStr();
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int x;

    public override string ToString()
    {
        return "{ "
        + "x:" + x + ","
        + "}";
    }
}

}

