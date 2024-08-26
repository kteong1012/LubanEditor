
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

namespace editor.cfg.test
{

public abstract class RefDynamicBase :  Luban.EditorBeanBase 
{
    public RefDynamicBase()
    {
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
            Instance = Create(Types[value]);
        }
    }
    public RefDynamicBase Instance { get; set;}
    public static List<string> Types = new List<string>()
    {
        "test.RefBean",
    };

    public static RefDynamicBase Create(string type)
    {
        switch (type)
        {
            case "test.RefBean":   
            case "RefBean":return new test.RefBean();
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
    this.Instance.Render();
    UnityEditor.EditorGUILayout.EndVertical();
}    }

    public static RefDynamicBase LoadJsonRefDynamicBase(SimpleJSON.JSONNode _json)
    {
        string type = _json["$type"];
        RefDynamicBase obj;
        switch (type)
        {
            case "test.RefBean":   
            case "RefBean":obj = new test.RefBean(); break;
            default: throw new SerializationException();
        }
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonRefDynamicBase(RefDynamicBase _obj, SimpleJSON.JSONNode _json)
    {
        _json["$type"] = _obj.Instance.GetTypeStr();
        _obj.Instance.SaveJson((SimpleJSON.JSONObject)_json);
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

