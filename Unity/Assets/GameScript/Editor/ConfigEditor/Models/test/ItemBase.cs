
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

public abstract class ItemBase :  Luban.EditorBeanBase 
{
    public ItemBase()
    {
            name = "";
            desc = "";
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
    public ItemBase Instance { get; set;}
    public static List<string> Types = new List<string>()
    {
        "test.Item",
        "test.Equipment",
        "test.Decorator",
    };

    public static ItemBase Create(string type)
    {
        switch (type)
        {
            case "test.Item":   
            case "Item":return new test.Item();
            case "test.Equipment":   
            case "Equipment":return new test.Equipment();
            case "test.Decorator":   
            case "Decorator":return new test.Decorator();
            default: return null;
        }
    }

    private GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);

    public override void Render()
    {
{
    var __list0 = test.ItemBase.Types.Select(t => new GUIContent(t)).ToArray();
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

    public static ItemBase LoadJsonItemBase(SimpleJSON.JSONNode _json)
    {
        string type = _json["$type"];
        ItemBase obj;
        switch (type)
        {
            case "test.Item":   
            case "Item":obj = new test.Item(); break;
            case "test.Equipment":   
            case "Equipment":obj = new test.Equipment(); break;
            case "test.Decorator":   
            case "Decorator":obj = new test.Decorator(); break;
            default: throw new SerializationException();
        }
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonItemBase(ItemBase _obj, SimpleJSON.JSONNode _json)
    {
        _json["$type"] = _obj.Instance.GetTypeStr();
        _obj.Instance.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int id;
    public string name;
    public string desc;

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "name:" + name + ","
        + "desc:" + desc + ","
        + "}";
    }
}

}

