
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

namespace editor.cfg.test2
{

/// <summary>
/// 矩形
/// </summary>
public sealed class Rectangle :  test.Shape 
{
    public Rectangle()
    {
    }
    public override string GetTypeStr() => TYPE_STR;
    private const string TYPE_STR = "test2.Rectangle";

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["width"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  width = _fieldJson;
            }
            else
            {
                width = 0;
            }
        }
        
        { 
            var _fieldJson = _json["height"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  height = _fieldJson;
            }
            else
            {
                height = 0;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            _json["width"] = new JSONNumber(width);
        }
        {
            _json["height"] = new JSONNumber(height);
        }
    }

    private static GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);

    public static void RenderRectangle(Rectangle obj)
    {
        obj.Render();
    }

    public override void Render()
    {
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("宽度", "width"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("width", "宽度"), GUILayout.Width(100));
}
this.width = UnityEditor.EditorGUILayout.DoubleField(this.width, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("高度", "height"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("height", "高度"), GUILayout.Width(100));
}
this.height = UnityEditor.EditorGUILayout.DoubleField(this.height, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}    }
    public static Rectangle LoadJsonRectangle(SimpleJSON.JSONNode _json)
    {
        Rectangle obj = new test2.Rectangle();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonRectangle(Rectangle _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    /// <summary>
    /// 宽度
    /// </summary>
    public double width;
    /// <summary>
    /// 高度
    /// </summary>
    public double height;

    public override string ToString()
    {
        return "{ "
        + "width:" + width + ","
        + "height:" + height + ","
        + "}";
    }
}

}

