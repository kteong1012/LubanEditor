
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

public sealed class TestUeType :  Luban.EditorBeanBase 
{
    public TestUeType()
    {
            x10 = "";
            x12 = new editor.cfg.test.DemoType1();
            x13 = editor.cfg.test.ETestUeType.WHITE;
            t1 = 0;
            k1 = System.Array.Empty<int>();
            k2 = new System.Collections.Generic.List<int>();
            k5 = new System.Collections.Generic.List<int>();
            k8 = new System.Collections.Generic.List<object[]>();
            k9 = new System.Collections.Generic.List<editor.cfg.test.DemoE2>();
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["x1"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsBoolean) { throw new SerializationException(); }  x1 = _fieldJson;
            }
            else
            {
                x1 = false;
            }
        }
        
        { 
            var _fieldJson = _json["x2"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  x2 = _fieldJson;
            }
            else
            {
                x2 = 0;
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
        
        { 
            var _fieldJson = _json["x5"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  x5 = _fieldJson;
            }
            else
            {
                x5 = 0;
            }
        }
        
        { 
            var _fieldJson = _json["x6"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  x6 = _fieldJson;
            }
            else
            {
                x6 = 0;
            }
        }
        
        { 
            var _fieldJson = _json["x10"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  x10 = _fieldJson;
            }
            else
            {
                x10 = "";
            }
        }
        
        { 
            var _fieldJson = _json["x12"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsObject) { throw new SerializationException(); }  x12 = editor.cfg.test.DemoType1.LoadJsonDemoType1(_fieldJson);
            }
            else
            {
                x12 = new test.DemoType1();
            }
        }
        
        { 
            var _fieldJson = _json["x13"];
            if (_fieldJson != null)
            {
                if(_fieldJson.IsString) { x13 = (editor.cfg.test.ETestUeType)System.Enum.Parse(typeof(editor.cfg.test.ETestUeType), _fieldJson); } else if(_fieldJson.IsNumber) { x13 = (editor.cfg.test.ETestUeType)(int)_fieldJson; } else { throw new SerializationException(); }  
            }
            else
            {
                x13 = editor.cfg.test.ETestUeType.WHITE;
            }
        }
        
        { 
            var _fieldJson = _json["t1"];
            if (_fieldJson != null)
            {
                if (_fieldJson.IsString)
                {
                    t1 = _fieldJson;
                }
                else if (_fieldJson.IsNumber)
                {
                    t1 = _fieldJson;
                }
                else
                {
                    throw new SerializationException();
                }
            }
            else
            {
                t1 = 0;
            }
        }
        
        { 
            var _fieldJson = _json["k1"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } int __n0 = _fieldJson.Count; k1 = new int[__n0]; int __i0=0; foreach(SimpleJSON.JSONNode __e0 in _fieldJson.Children) { int __v0;  if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = __e0;  k1[__i0++] = __v0; }  
            }
            else
            {
                k1 = System.Array.Empty<int>();
            }
        }
        
        { 
            var _fieldJson = _json["k2"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } k2 = new System.Collections.Generic.List<int>(); foreach(SimpleJSON.JSONNode __e0 in _fieldJson.Children) { int __v0;  if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = __e0;  k2.Add(__v0); }  
            }
            else
            {
                k2 = new System.Collections.Generic.List<int>();
            }
        }
        
        { 
            var _fieldJson = _json["k5"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } k5 = new System.Collections.Generic.List<int>(); foreach(SimpleJSON.JSONNode __e0 in _fieldJson.Children) { int __v0;  if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = __e0;  k5.Add(__v0); }  
            }
            else
            {
                k5 = new System.Collections.Generic.List<int>();
            }
        }
        
        { 
            var _fieldJson = _json["k8"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } k8 = new System.Collections.Generic.List<object[]>(); foreach(SimpleJSON.JSONNode __e0 in _fieldJson.Children) { int __k0;  if(!__e0[0].IsNumber) { throw new SerializationException(); }  __k0 = __e0[0]; int __v0;  if(!__e0[1].IsNumber) { throw new SerializationException(); }  __v0 = __e0[1];  k8.Add(new object[] { __k0, __v0 }); }  
            }
            else
            {
                k8 = new System.Collections.Generic.List<object[]>();
            }
        }
        
        { 
            var _fieldJson = _json["k9"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } k9 = new System.Collections.Generic.List<editor.cfg.test.DemoE2>(); foreach(SimpleJSON.JSONNode __e0 in _fieldJson.Children) { editor.cfg.test.DemoE2 __v0;  if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = editor.cfg.test.DemoE2.LoadJsonDemoE2(__e0);  k9.Add(__v0); }  
            }
            else
            {
                k9 = new System.Collections.Generic.List<editor.cfg.test.DemoE2>();
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            _json["x1"] = new JSONBool(x1);
        }
        {
            _json["x2"] = new JSONNumber(x2);
        }
        {
            _json["x3"] = new JSONNumber(x3);
        }
        {
            _json["x4"] = new JSONNumber(x4);
        }
        {
            _json["x5"] = new JSONNumber(x5);
        }
        {
            _json["x6"] = new JSONNumber(x6);
        }

        if (x10 != null)
        {
            _json["x10"] = new JSONString(x10);
        }

        if (x12 != null)
        {
            { var __bjson = new JSONObject();  editor.cfg.test.DemoType1.SaveJsonDemoType1(x12, __bjson); _json["x12"] = __bjson; }
        }
        {
            _json["x13"] = new JSONNumber((int)x13);
        }
        {
            _json["t1"] = new JSONNumber(t1);
        }

        if (k1 != null)
        {
            { var __cjson0 = new JSONArray(); foreach(var __e0 in k1) { __cjson0["null"] = new JSONNumber(__e0); } __cjson0.Inline = __cjson0.Count == 0; _json["k1"] = __cjson0; }
        }

        if (k2 != null)
        {
            { var __cjson0 = new JSONArray(); foreach(var __e0 in k2) { __cjson0["null"] = new JSONNumber(__e0); } __cjson0.Inline = __cjson0.Count == 0; _json["k2"] = __cjson0; }
        }

        if (k5 != null)
        {
            { var __cjson0 = new JSONArray(); foreach(var __e0 in k5) { __cjson0["null"] = new JSONNumber(__e0); } __cjson0.Inline = __cjson0.Count == 0; _json["k5"] = __cjson0; }
        }

        if (k8 != null)
        {
            {
                var __cjson0 = new JSONArray();
                foreach(var __e0 in k8)
                {
                    var __entry0 = new JSONArray();
                    __cjson0[null] = __entry0;
                    __entry0["null"] = new JSONNumber((int)__e0[0]);
                    __entry0["null"] = new JSONNumber((int)__e0[1]);
                }
                __cjson0.Inline = __cjson0.Count == 0;
                _json["k8"] = __cjson0;
            }
        }

        if (k9 != null)
        {
            { var __cjson0 = new JSONArray(); foreach(var __e0 in k9) { { var __bjson = new JSONObject();  editor.cfg.test.DemoE2.SaveJsonDemoE2(__e0, __bjson); __cjson0["null"] = __bjson; } } __cjson0.Inline = __cjson0.Count == 0; _json["k9"] = __cjson0; }
        }
    }

    private static GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);

    public static void RenderTestUeType(TestUeType obj)
    {
        obj.Render();
    }

    public override void Render()
    {
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
this.x1 = UnityEditor.EditorGUILayout.Toggle(this.x1, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x2", "x2"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x2", ""), GUILayout.Width(100));
}
this.x2 = (byte)UnityEditor.EditorGUILayout.IntField(this.x2, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x3", "x3"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x3", ""), GUILayout.Width(100));
}
this.x3 = (short)UnityEditor.EditorGUILayout.IntField(this.x3, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x4", "x4"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x4", ""), GUILayout.Width(100));
}
this.x4 = UnityEditor.EditorGUILayout.IntField(this.x4, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x5", "x5"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x5", ""), GUILayout.Width(100));
}
this.x5 = UnityEditor.EditorGUILayout.LongField(this.x5, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x6", "x6"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x6", ""), GUILayout.Width(100));
}
this.x6 = UnityEditor.EditorGUILayout.DoubleField(this.x6, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x10", "x10"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x10", ""), GUILayout.Width(100));
}
this.x10 = UnityEditor.EditorGUILayout.TextField(this.x10, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x12", "x12"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x12", ""), GUILayout.Width(100));
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
this.x12.x1 = UnityEditor.EditorGUILayout.IntField(this.x12.x1, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x13", "x13"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x13", ""), GUILayout.Width(100));
}
{
    if (ConfigEditorSettings.showComment)
    {
        var __items1 = test.ETestUeType_Metadata.GetItems();
        var __names1 = __items1.Select(x => x.Alias).ToArray();
        var __index1 = __items1.IndexOf(test.ETestUeType_Metadata.GetByName(this.x13.ToString()));
        __index1 = UnityEditor.EditorGUILayout.Popup(__index1, __names1, GUILayout.Width(150));
        this.x13 = (editor.cfg.test.ETestUeType)__items1[__index1].Value;
    }
    else
    {
        this.x13 = (editor.cfg.test.ETestUeType)UnityEditor.EditorGUILayout.EnumPopup(this.x13, GUILayout.Width(150));
    }
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("t1", "t1"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("t1", ""), GUILayout.Width(100));
}
this.t1 = UnityEditor.EditorGUILayout.LongField(this.t1, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("k1", "k1"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("k1", ""), GUILayout.Width(100));
}
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    int __n1 = this.k1.Length;
    for (int __i1 = 0; __i1 < __n1; __i1++)
    {
        UnityEditor.EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("-", GUILayout.Width(20)))
        {
            var __list1 = new System.Collections.Generic.List<int>(this.k1);
            __list1.RemoveAt(__i1);
            this.k1 = __list1.ToArray();
            UnityEditor.EditorGUILayout.EndHorizontal();
            break;
        }
        UnityEditor.EditorGUILayout.LabelField(__i1.ToString(), GUILayout.Width(20));
        int __e1 = this.k1[__i1];
        __e1 = UnityEditor.EditorGUILayout.IntField(__e1, GUILayout.Width(150));;
        this.k1[__i1] = __e1;
        UnityEditor.EditorGUILayout.EndHorizontal();
    }
    UnityEditor.EditorGUILayout.BeginHorizontal();
    if (GUILayout.Button("+", GUILayout.Width(20)))
    {
        var __list1 = new System.Collections.Generic.List<int>(this.k1);
        int __e1;
        __e1 = 0;;
        __list1.Add(__e1);
        this.k1 = __list1.ToArray();
    }
    if (GUILayout.Button("import", GUILayout.Width(100)))
    {
        ConfigEditorImportWindow.Open((__importJsonText1) => 
        {
            var __importJson1 = SimpleJSON.JSON.Parse(__importJsonText1);
            int __importElement1;
            if(!__importJson1.IsNumber) { throw new SerializationException(); }  __importElement1 = __importJson1;
            var __list1 = new System.Collections.Generic.List<int>(this.k1);
            __list1.Add(__importElement1);
            this.k1 = __list1.ToArray();
        });
    }
    UnityEditor.EditorGUILayout.EndHorizontal();
    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("k2", "k2"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("k2", ""), GUILayout.Width(100));
}
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    int __n1 = this.k2.Count;
    for (int __i1 = 0; __i1 < __n1; __i1++)
    {
        UnityEditor.EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("-", GUILayout.Width(20)))
        {
            this.k2.RemoveAt(__i1);
            UnityEditor.EditorGUILayout.EndHorizontal();
            break;
        }
        UnityEditor.EditorGUILayout.LabelField(__i1.ToString(), GUILayout.Width(20));
        int __e1 = this.k2[__i1];
        __e1 = UnityEditor.EditorGUILayout.IntField(__e1, GUILayout.Width(150));;
        this.k2[__i1] = __e1;
        UnityEditor.EditorGUILayout.EndHorizontal();
    }
    UnityEditor.EditorGUILayout.BeginHorizontal();
    if (GUILayout.Button("+", GUILayout.Width(20)))
    {
        int __e1;
        __e1 = 0;;
        this.k2.Add(__e1);
    }
    if (GUILayout.Button("import", GUILayout.Width(100)))
    {
        ConfigEditorImportWindow.Open((__importJsonText1) => 
        {
            var __importJson1 = SimpleJSON.JSON.Parse(__importJsonText1);
            int __importElement1;
            if(!__importJson1.IsNumber) { throw new SerializationException(); }  __importElement1 = __importJson1;
            this.k2.Add(__importElement1);
        });
    }
    UnityEditor.EditorGUILayout.EndHorizontal();
    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("k5", "k5"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("k5", ""), GUILayout.Width(100));
}
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    int __n1 = this.k5.Count;
    for (int __i1 = 0; __i1 < __n1; __i1++)
    {
        UnityEditor.EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("-", GUILayout.Width(20)))
        {
            this.k5.RemoveAt(__i1);
            UnityEditor.EditorGUILayout.EndHorizontal();
            break;
        }
        UnityEditor.EditorGUILayout.LabelField(__i1.ToString(), GUILayout.Width(20));
        int __e1 = this.k5[__i1];
        __e1 = UnityEditor.EditorGUILayout.IntField(__e1, GUILayout.Width(150));;
        this.k5[__i1] = __e1;
        UnityEditor.EditorGUILayout.EndHorizontal();
    }
    if (GUILayout.Button("+", GUILayout.Width(20)))
    {
        int __e1;
        __e1 = 0;;
        this.k5.Add(__e1);
    }
    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("k8", "k8"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("k8", ""), GUILayout.Width(100));
}
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    int __n1 = this.k8.Count;
    for (int __i1 = 0; __i1 < __n1; __i1++)
    {
        UnityEditor.EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("-", GUILayout.Width(20)))
        {
            this.k8.RemoveAt(__i1);
            UnityEditor.EditorGUILayout.EndHorizontal();
            break;
        }
        UnityEditor.EditorGUILayout.LabelField(__i1.ToString(), GUILayout.Width(20));
        var __e1 = this.k8[__i1];
        int __key1 = 0;
        int __value1 = 0;
        if (__e1 == null)
        {
            __e1 = new object[2] { __key1, __value1 };
            this.k8[__i1] = __e1;
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
        this.k8.Add(new object[2]);
    }
    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("k9", "k9"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("k9", ""), GUILayout.Width(100));
}
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    int __n1 = this.k9.Count;
    for (int __i1 = 0; __i1 < __n1; __i1++)
    {
        UnityEditor.EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("-", GUILayout.Width(20)))
        {
            this.k9.RemoveAt(__i1);
            UnityEditor.EditorGUILayout.EndHorizontal();
            break;
        }
        UnityEditor.EditorGUILayout.LabelField(__i1.ToString(), GUILayout.Width(20));
        editor.cfg.test.DemoE2 __e1 = this.k9[__i1];
        {
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("y1", "y1"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("y1", ""), GUILayout.Width(100));
}
__e1.y1 = UnityEditor.EditorGUILayout.IntField(__e1.y1, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("y2", "y2"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("y2", ""), GUILayout.Width(100));
}
__e1.y2 = UnityEditor.EditorGUILayout.Toggle(__e1.y2, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
};
        this.k9[__i1] = __e1;
        UnityEditor.EditorGUILayout.EndHorizontal();
    }
    UnityEditor.EditorGUILayout.BeginHorizontal();
    if (GUILayout.Button("+", GUILayout.Width(20)))
    {
        editor.cfg.test.DemoE2 __e1;
        __e1 = new test.DemoE2();;
        this.k9.Add(__e1);
    }
    if (GUILayout.Button("import", GUILayout.Width(100)))
    {
        ConfigEditorImportWindow.Open((__importJsonText1) => 
        {
            var __importJson1 = SimpleJSON.JSON.Parse(__importJsonText1);
            editor.cfg.test.DemoE2 __importElement1;
            if(!__importJson1.IsObject) { throw new SerializationException(); }  __importElement1 = editor.cfg.test.DemoE2.LoadJsonDemoE2(__importJson1);
            this.k9.Add(__importElement1);
        });
    }
    UnityEditor.EditorGUILayout.EndHorizontal();
    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}    }
    public static TestUeType LoadJsonTestUeType(SimpleJSON.JSONNode _json)
    {
        TestUeType obj = new test.TestUeType();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonTestUeType(TestUeType _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public bool x1;
    public byte x2;
    public short x3;
    public int x4;
    public long x5;
    public double x6;
    public string x10;
    public editor.cfg.test.DemoType1 x12;
    public editor.cfg.test.ETestUeType x13;
    public long t1;
    public int[] k1;
    public System.Collections.Generic.List<int> k2;
    public System.Collections.Generic.List<int> k5;
    public System.Collections.Generic.List<object[]> k8;
    public System.Collections.Generic.List<editor.cfg.test.DemoE2> k9;

    public override string ToString()
    {
        return "{ "
        + "x1:" + x1 + ","
        + "x2:" + x2 + ","
        + "x3:" + x3 + ","
        + "x4:" + x4 + ","
        + "x5:" + x5 + ","
        + "x6:" + x6 + ","
        + "x10:" + x10 + ","
        + "x12:" + x12 + ","
        + "x13:" + x13 + ","
        + "t1:" + t1 + ","
        + "k1:" + Luban.StringUtil.CollectionToString(k1) + ","
        + "k2:" + Luban.StringUtil.CollectionToString(k2) + ","
        + "k5:" + Luban.StringUtil.CollectionToString(k5) + ","
        + "k8:" + Luban.StringUtil.CollectionToString(k8) + ","
        + "k9:" + Luban.StringUtil.CollectionToString(k9) + ","
        + "}";
    }
}

}

