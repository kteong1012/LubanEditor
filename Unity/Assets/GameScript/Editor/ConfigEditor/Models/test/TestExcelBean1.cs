
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

/// <summary>
/// 这是个测试excel结构
/// </summary>
public sealed class TestExcelBean1 :  Luban.EditorBeanBase 
{
    public TestExcelBean1()
    {
            x2 = "";
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["x1"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  x1 = _fieldJson;
            }
            else
            {
                x1 = 0;
            }
        }
        
        { 
            var _fieldJson = _json["x2"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  x2 = _fieldJson;
            }
            else
            {
                x2 = "";
            }
        }
        
        { 
            var _fieldJson = _json["x3"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  x3 = _fieldJson;
            }
            else
            {
                x3 = 0;
            }
        }
        
        { 
            var _fieldJson = _json["x4"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  x4 = _fieldJson;
            }
            else
            {
                x4 = 0;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            _json["x1"] = new JSONNumber(x1);
        }

        if (x2 != null)
        {
            _json["x2"] = new JSONString(x2);
        }
        {
            _json["x3"] = new JSONNumber(x3);
        }
        {
            _json["x4"] = new JSONNumber(x4);
        }
    }

    private static GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);

    public static void RenderTestExcelBean1(TestExcelBean1 obj)
    {
        obj.Render();
    }

    public override void Render()
    {
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("最高品质", "x1"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x1", "最高品质"), GUILayout.Width(100));
}
this.x1 = UnityEditor.EditorGUILayout.IntField(this.x1, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("黑色的", "x2"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x2", "黑色的"), GUILayout.Width(100));
}
this.x2 = UnityEditor.EditorGUILayout.TextField(this.x2, GUILayout.Width(150));
if (GUILayout.Button("…", GUILayout.Width(20)))
{
    TextInputWindow.GetTextAsync(this.x2,__x =>this.x2 = __x);
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("蓝色的", "x3"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x3", "蓝色的"), GUILayout.Width(100));
}
this.x3 = UnityEditor.EditorGUILayout.IntField(this.x3, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("最差品质", "x4"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x4", "最差品质"), GUILayout.Width(100));
}
this.x4 = UnityEditor.EditorGUILayout.DoubleField(this.x4, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}    }
    public static TestExcelBean1 LoadJsonTestExcelBean1(SimpleJSON.JSONNode _json)
    {
        TestExcelBean1 obj = new test.TestExcelBean1();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonTestExcelBean1(TestExcelBean1 _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    /// <summary>
    /// 最高品质
    /// </summary>
    public int x1;
    /// <summary>
    /// 黑色的
    /// </summary>
    public string x2;
    /// <summary>
    /// 蓝色的
    /// </summary>
    public int x3;
    /// <summary>
    /// 最差品质
    /// </summary>
    public double x4;

    public override string ToString()
    {
        return "{ "
        + "x1:" + x1 + ","
        + "x2:" + x2 + ","
        + "x3:" + x3 + ","
        + "x4:" + x4 + ","
        + "}";
    }
}

}

