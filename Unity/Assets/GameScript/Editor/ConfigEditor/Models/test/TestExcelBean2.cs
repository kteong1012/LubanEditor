
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
public sealed class TestExcelBean2 :  Luban.EditorBeanBase 
{
    public TestExcelBean2()
    {
            y2 = "";
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["y1"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  y1 = _fieldJson;
            }
            else
            {
                y1 = 0;
            }
        }
        
        { 
            var _fieldJson = _json["y2"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  y2 = _fieldJson;
            }
            else
            {
                y2 = "";
            }
        }
        
        { 
            var _fieldJson = _json["y3"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  y3 = _fieldJson;
            }
            else
            {
                y3 = 0;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            _json["y1"] = new JSONNumber(y1);
        }

        if (y2 != null)
        {
            _json["y2"] = new JSONString(y2);
        }
        {
            _json["y3"] = new JSONNumber(y3);
        }
    }

    private static GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);

    public static void RenderTestExcelBean2(TestExcelBean2 obj)
    {
        obj.Render();
    }

    public override void Render()
    {
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("最高品质", "y1"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("y1", "最高品质"), GUILayout.Width(100));
}
this.y1 = UnityEditor.EditorGUILayout.IntField(this.y1, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("黑色的", "y2"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("y2", "黑色的"), GUILayout.Width(100));
}
this.y2 = UnityEditor.EditorGUILayout.TextField(this.y2, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("蓝色的", "y3"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("y3", "蓝色的"), GUILayout.Width(100));
}
this.y3 = UnityEditor.EditorGUILayout.DoubleField(this.y3, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}    }
    public static TestExcelBean2 LoadJsonTestExcelBean2(SimpleJSON.JSONNode _json)
    {
        TestExcelBean2 obj = new test.TestExcelBean2();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonTestExcelBean2(TestExcelBean2 _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    /// <summary>
    /// 最高品质
    /// </summary>
    public int y1;
    /// <summary>
    /// 黑色的
    /// </summary>
    public string y2;
    /// <summary>
    /// 蓝色的
    /// </summary>
    public double y3;

    public override string ToString()
    {
        return "{ "
        + "y1:" + y1 + ","
        + "y2:" + y2 + ","
        + "y3:" + y3 + ","
        + "}";
    }
}

}

