
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

public abstract class Shape :  Luban.EditorBeanBase 
{
    public Shape()
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
    public Shape Instance { get; set;}
    public static List<string> Types = new List<string>()
    {
        "test.Circle",
        "test2.Rectangle",
    };

    public static Shape Create(string type)
    {
        switch (type)
        {
            case "test.Circle":   
            case "Circle":return new test.Circle();
            case "test2.Rectangle":return new test2.Rectangle();
            default: return null;
        }
    }

    private GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);

    public override void Render()
    {
{
    var __list0 = test.Shape.Types.Select(t => new GUIContent(t)).ToArray();
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

    public static Shape LoadJsonShape(SimpleJSON.JSONNode _json)
    {
        string type = _json["$type"];
        Shape obj;
        switch (type)
        {
            case "test.Circle":   
            case "Circle":obj = new test.Circle(); break;
            case "test2.Rectangle":obj = new test2.Rectangle(); break;
            default: throw new SerializationException();
        }
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonShape(Shape _obj, SimpleJSON.JSONNode _json)
    {
        _json["$type"] = _obj.Instance.GetTypeStr();
        _obj.Instance.SaveJson((SimpleJSON.JSONObject)_json);
    }


    public override string ToString()
    {
        return "{ "
        + "}";
    }
}

}

