
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

public sealed class TestSize :  Luban.EditorBeanBase 
{
    public TestSize(Action<Luban.EditorBeanBase> setChangeAction = null) 
    {
        _setChangeAction = setChangeAction;
            x1 = System.Array.Empty<int>();
            x2 = new System.Collections.Generic.List<int>();
            x3 = new System.Collections.Generic.List<int>();
            x4 = new System.Collections.Generic.List<object[]>();
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
                id = 0;
            }
        }
        
        { 
            var _fieldJson = _json["x1"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } int __n0 = _fieldJson.Count; x1 = new int[__n0]; int __i0=0; foreach(SimpleJSON.JSONNode __e0 in _fieldJson.Children) { int __v0;  if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = __e0;  x1[__i0++] = __v0; }  
            }
            else
            {
                x1 = System.Array.Empty<int>();
            }
        }
        
        { 
            var _fieldJson = _json["x2"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } x2 = new System.Collections.Generic.List<int>(); foreach(SimpleJSON.JSONNode __e0 in _fieldJson.Children) { int __v0;  if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = __e0;  x2.Add(__v0); }  
            }
            else
            {
                x2 = new System.Collections.Generic.List<int>();
            }
        }
        
        { 
            var _fieldJson = _json["x3"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } x3 = new System.Collections.Generic.List<int>(); foreach(SimpleJSON.JSONNode __e0 in _fieldJson.Children) { int __v0;  if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = __e0;  x3.Add(__v0); }  
            }
            else
            {
                x3 = new System.Collections.Generic.List<int>();
            }
        }
        
        { 
            var _fieldJson = _json["x4"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } x4 = new System.Collections.Generic.List<object[]>(); foreach(SimpleJSON.JSONNode __e0 in _fieldJson.Children) { int __k0;  if(!__e0[0].IsNumber) { throw new SerializationException(); }  __k0 = __e0[0]; int __v0;  if(!__e0[1].IsNumber) { throw new SerializationException(); }  __v0 = __e0[1];  x4.Add(new object[] { __k0, __v0 }); }  
            }
            else
            {
                x4 = new System.Collections.Generic.List<object[]>();
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            _json["id"] = new JSONNumber(id);
        }

        if (x1 != null)
        {
            { var __cjson0 = new JSONArray(); foreach(var __e0 in x1) { __cjson0["null"] = new JSONNumber(__e0); } __cjson0.Inline = __cjson0.Count == 0; _json["x1"] = __cjson0; }
        }

        if (x2 != null)
        {
            { var __cjson0 = new JSONArray(); foreach(var __e0 in x2) { __cjson0["null"] = new JSONNumber(__e0); } __cjson0.Inline = __cjson0.Count == 0; _json["x2"] = __cjson0; }
        }

        if (x3 != null)
        {
            { var __cjson0 = new JSONArray(); foreach(var __e0 in x3) { __cjson0["null"] = new JSONNumber(__e0); } __cjson0.Inline = __cjson0.Count == 0; _json["x3"] = __cjson0; }
        }

        if (x4 != null)
        {
            {
                var __cjson0 = new JSONArray();
                foreach(var __e0 in x4)
                {
                    var __entry0 = new JSONArray();
                    __cjson0[null] = __entry0;
                    __entry0["null"] = new JSONNumber((int)__e0[0]);
                    __entry0["null"] = new JSONNumber((int)__e0[1]);
                }
                __cjson0.Inline = __cjson0.Count == 0;
                _json["x4"] = __cjson0;
            }
        }
    }

    private static GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);

    public static void RenderTestSize(TestSize obj)
    {
        UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
        obj?.Render();
        UnityEditor.EditorGUILayout.EndVertical();
    }

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
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    int __n1 = this.x1.Length;
    for (int __i1 = 0; __i1 < __n1; __i1++)
    {
        UnityEditor.EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("-", GUILayout.Width(20)))
        {
            var __list1 = new System.Collections.Generic.List<int>(this.x1);
            __list1.RemoveAt(__i1);
            this.x1 = __list1.ToArray();
            UnityEditor.EditorGUILayout.EndHorizontal();
            break;
        }
        UnityEditor.EditorGUILayout.LabelField(__i1.ToString(), GUILayout.Width(20));
        int __e1 = this.x1[__i1];
        __e1 = UnityEditor.EditorGUILayout.IntField(__e1, GUILayout.Width(150));;
        this.x1[__i1] = __e1;
        UnityEditor.EditorGUILayout.EndHorizontal();
    }
    UnityEditor.EditorGUILayout.BeginHorizontal();
    if (GUILayout.Button("+", GUILayout.Width(20)))
    {
        var __list1 = new System.Collections.Generic.List<int>(this.x1);
        int __e1;
        __e1 = 0;;
        __list1.Add(__e1);
        this.x1 = __list1.ToArray();
    }
    if (GUILayout.Button("import", GUILayout.Width(100)))
    {
        ConfigEditorImportWindow.Open((__importJsonText1) => 
        {
            var __importJson1 = SimpleJSON.JSON.Parse(__importJsonText1);
            int __importElement1;
            if(!__importJson1.IsNumber) { throw new SerializationException(); }  __importElement1 = __importJson1;
            var __list1 = new System.Collections.Generic.List<int>(this.x1);
            __list1.Add(__importElement1);
            this.x1 = __list1.ToArray();
        });
    }
    UnityEditor.EditorGUILayout.EndHorizontal();
    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x2", "x2"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x2", ""), GUILayout.Width(100));
}
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    int __n1 = this.x2.Count;
    for (int __i1 = 0; __i1 < __n1; __i1++)
    {
        UnityEditor.EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("-", GUILayout.Width(20)))
        {
            this.x2.RemoveAt(__i1);
            UnityEditor.EditorGUILayout.EndHorizontal();
            break;
        }
        UnityEditor.EditorGUILayout.LabelField(__i1.ToString(), GUILayout.Width(20));
        int __e1 = this.x2[__i1];
        __e1 = UnityEditor.EditorGUILayout.IntField(__e1, GUILayout.Width(150));;
        this.x2[__i1] = __e1;
        UnityEditor.EditorGUILayout.EndHorizontal();
    }
    UnityEditor.EditorGUILayout.BeginHorizontal();
    if (GUILayout.Button("+", GUILayout.Width(20)))
    {
        int __e1;
        __e1 = 0;;
        this.x2.Add(__e1);
    }
    if (GUILayout.Button("import", GUILayout.Width(100)))
    {
        ConfigEditorImportWindow.Open((__importJsonText1) => 
        {
            var __importJson1 = SimpleJSON.JSON.Parse(__importJsonText1);
            int __importElement1;
            if(!__importJson1.IsNumber) { throw new SerializationException(); }  __importElement1 = __importJson1;
            this.x2.Add(__importElement1);
        });
    }
    UnityEditor.EditorGUILayout.EndHorizontal();
    UnityEditor.EditorGUILayout.EndVertical();
}
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
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    int __n1 = this.x3.Count;
    for (int __i1 = 0; __i1 < __n1; __i1++)
    {
        UnityEditor.EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("-", GUILayout.Width(20)))
        {
            this.x3.RemoveAt(__i1);
            UnityEditor.EditorGUILayout.EndHorizontal();
            break;
        }
        UnityEditor.EditorGUILayout.LabelField(__i1.ToString(), GUILayout.Width(20));
        int __e1 = this.x3[__i1];
        __e1 = UnityEditor.EditorGUILayout.IntField(__e1, GUILayout.Width(150));;
        this.x3[__i1] = __e1;
        UnityEditor.EditorGUILayout.EndHorizontal();
    }
    if (GUILayout.Button("+", GUILayout.Width(20)))
    {
        int __e1;
        __e1 = 0;;
        this.x3.Add(__e1);
    }
    UnityEditor.EditorGUILayout.EndVertical();
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
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    int __n1 = this.x4.Count;
    for (int __i1 = 0; __i1 < __n1; __i1++)
    {
        UnityEditor.EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("-", GUILayout.Width(20)))
        {
            this.x4.RemoveAt(__i1);
            UnityEditor.EditorGUILayout.EndHorizontal();
            break;
        }
        UnityEditor.EditorGUILayout.LabelField(__i1.ToString(), GUILayout.Width(20));
        var __e1 = this.x4[__i1];
        int __key1 = 0;
        int __value1 = 0;
        if (__e1 == null)
        {
            __e1 = new object[2] { __key1, __value1 };
            this.x4[__i1] = __e1;
        }
        else
        {
            __key1 = __e1[0] != null ? (int)__e1[0] : default;
            __value1 = __e1[1] != null ? (int)__e1[1] : default;
        }
        __key1 = UnityEditor.EditorGUILayout.IntField(__key1, GUILayout.Width(150));;
        __value1 = UnityEditor.EditorGUILayout.IntField(__value1, GUILayout.Width(150));;
        __e1[0] = __key1;
        __e1[1] = __value1;
        UnityEditor.EditorGUILayout.EndHorizontal();
    }
    if (GUILayout.Button("+", GUILayout.Width(20)))
    {
        this.x4.Add(new object[2]);
    }
    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}    }
    public static TestSize LoadJsonTestSize(SimpleJSON.JSONNode _json, Action<Luban.EditorBeanBase> setChangeAction = null)
    {
        TestSize obj = new test.TestSize();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonTestSize(TestSize _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int id;
    public int[] x1;
    public System.Collections.Generic.List<int> x2;
    public System.Collections.Generic.List<int> x3;
    public System.Collections.Generic.List<object[]> x4;

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "x1:" + Luban.StringUtil.CollectionToString(x1) + ","
        + "x2:" + Luban.StringUtil.CollectionToString(x2) + ","
        + "x3:" + Luban.StringUtil.CollectionToString(x3) + ","
        + "x4:" + Luban.StringUtil.CollectionToString(x4) + ","
        + "}";
    }
}

}

