
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

public sealed class TestNull :  Luban.EditorBeanBase 
{
    public TestNull(Action<Luban.EditorBeanBase> setChangeAction = null) 
    {
        _setChangeAction = setChangeAction;
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["id"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  id = _fieldJson;
            }
            else
            {
            }
        }
        
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
                if(_fieldJson.IsString) { x2 = (editor.cfg.test.DemoEnum)System.Enum.Parse(typeof(editor.cfg.test.DemoEnum), _fieldJson); } else if(_fieldJson.IsNumber) { x2 = (editor.cfg.test.DemoEnum)(int)_fieldJson; } else { throw new SerializationException(); }  
            }
            else
            {
                x2 = editor.cfg.test.DemoEnum.NONE;
            }
        }
        
        { 
            var _fieldJson = _json["x3"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsObject) { throw new SerializationException(); }  x3 = editor.cfg.test.DemoType1.LoadJsonDemoType1(_fieldJson);
            }
            else
            {
                x3 = new editor.cfg.test.DemoType1();
                x3.SetChangeAction((__x) => x3 = __x as editor.cfg.test.DemoType1);
            }
        }
        
        { 
            var _fieldJson = _json["x4"];
            if (_fieldJson != null)
            {
                
                if (!_fieldJson.IsObject)
                {
                    throw new SerializationException();
                }
                x4 = editor.cfg.test.DemoDynamic.LoadJsonDemoDynamic(_fieldJson, (__newIns0)=>{ x4 = __newIns0 as test.DemoDynamic ; });
                var __index0 = editor.cfg.test.DemoDynamic.Types.IndexOf(x4.GetTypeStr());
                if (__index0 == -1)
                {
                    throw new SerializationException();
                }
                x4.TypeIndex = __index0;
            }
            else
            {
                x4 = new test.DemoD2();
                x4.SetChangeAction((__x) => x4 = __x as editor.cfg.test.DemoDynamic);
            }
        }
        
        { 
            var _fieldJson = _json["s1"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  s1 = _fieldJson;
            }
            else
            {
                s1 = "";
            }
        }
        
        { 
            var _fieldJson = _json["s2"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  s2 = _fieldJson;
            }
            else
            {
                s2 = "";
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            _json["id"] = new JSONNumber(id);
        }
        {
            _json["x1"] = new JSONNumber(x1);
        }
        {
            _json["x2"] = new JSONNumber((int)x2);
        }

        if (x3 != null)
        {
            { var __bjson = new JSONObject();  editor.cfg.test.DemoType1.SaveJsonDemoType1(x3, __bjson); _json["x3"] = __bjson; }
        }

        if (x4 != null)
        {
            { var __bjson = new JSONObject();  editor.cfg.test.DemoDynamic.SaveJsonDemoDynamic(x4, __bjson); _json["x4"] = __bjson; }
        }

        if (s1 != null)
        {
            _json["s1"] = new JSONString(s1);
        }

        if (s2 != null)
        {
            _json["s2"] = new JSONString(s2);
        }
    }

    private GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);

    public override void Render()
    {
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("id", "id"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("id", ""), GUILayout.Width(100));
}
this.id = UnityEditor.EditorGUILayout.IntField(this.id, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x1", "x1"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x1", ""), GUILayout.Width(100));
}
this.x1 = UnityEditor.EditorGUILayout.IntField(this.x1, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x2", "x2"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x2", ""), GUILayout.Width(100));
}

this.x2 = (editor.cfg.test.DemoEnum)UnityEditor.EditorGUILayout.EnumPopup(this.x2, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x3", "x3"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x3", ""), GUILayout.Width(100));
}
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x1", "x1"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x1", ""), GUILayout.Width(100));
}
this.x3.x1 = UnityEditor.EditorGUILayout.IntField(this.x3.x1, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x4", "x4"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x4", ""), GUILayout.Width(100));
}
{
    var __list1 = test.DemoDynamic.Types.Select(t => new GUIContent(t)).ToArray();
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    if (this.x4 == null)
    {
        this.x4 = new test.DemoD2();
this.x4.SetChangeAction((__x) => { this.x4 = __x as test.DemoDynamic; });
        this.x4.TypeIndex = 0;
    }
    UnityEditor.EditorGUILayout.BeginHorizontal();
    UnityEditor.EditorGUILayout.LabelField("类型", GUILayout.Width(100));
    this.x4.TypeIndex = UnityEditor.EditorGUILayout.Popup(this.x4.TypeIndex, __list1, GUILayout.Width(200));
    UnityEditor.EditorGUILayout.EndHorizontal();
    this.x4?.Render();
    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("s1", "s1"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("s1", ""), GUILayout.Width(100));
}
this.s1 = UnityEditor.EditorGUILayout.TextField(this.s1, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("s2", "s2"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("s2", ""), GUILayout.Width(100));
}
this.s2 = UnityEditor.EditorGUILayout.TextField(this.s2, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}    }
    public static TestNull LoadJsonTestNull(SimpleJSON.JSONNode _json, Action<Luban.EditorBeanBase> setChangeAction = null)
    {
        TestNull obj = new test.TestNull();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonTestNull(TestNull _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int id;
    public int x1;
    public editor.cfg.test.DemoEnum x2;
    public editor.cfg.test.DemoType1 x3;
    public editor.cfg.test.DemoDynamic x4;
    public string s1;
    public string s2;

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "x1:" + x1 + ","
        + "x2:" + x2 + ","
        + "x3:" + x3 + ","
        + "x4:" + x4 + ","
        + "s1:" + s1 + ","
        + "s2:" + s2 + ","
        + "}";
    }
}

}

