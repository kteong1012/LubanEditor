
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

public sealed class ExcelFromJson :  Luban.EditorBeanBase 
{
    public ExcelFromJson()
    {
            s1 = "";
            s2 = "";
            t1 = "1970-01-01 00:00:00";
            x12 = new test.DemoType1();
            x13 = test.DemoEnum.NONE;
            k1 = System.Array.Empty<int>();
            k8 = new System.Collections.Generic.List<object[]>();
            k9 = new System.Collections.Generic.List<test.DemoE2>();
            k15 = System.Array.Empty<test.DemoDynamic>();
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["x4"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  x4 = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["x1"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsBoolean) { throw new SerializationException(); }  x1 = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["x5"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  x5 = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["x6"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  x6 = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["s1"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  s1 = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["s2"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  s2 = _fieldJson;
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
        }
        
        { 
            var _fieldJson = _json["x12"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsObject) { throw new SerializationException(); }  x12 = test.DemoType1.LoadJsonDemoType1(_fieldJson);
            }
        }
        
        { 
            var _fieldJson = _json["x13"];
            if (_fieldJson != null)
            {
                if(_fieldJson.IsString) { x13 = (test.DemoEnum)System.Enum.Parse(typeof(test.DemoEnum), _fieldJson); } else if(_fieldJson.IsNumber) { x13 = (test.DemoEnum)(int)_fieldJson; } else { throw new SerializationException(); }  
            }
        }
        
        { 
            var _fieldJson = _json["x14"];
            if (_fieldJson != null)
            {
                
                if (!_fieldJson.IsObject)
                {
                    throw new SerializationException();
                }
                x14 = test.DemoDynamic.LoadJsonDemoDynamic(_fieldJson);
                var __index0 = test.DemoDynamic.Types.IndexOf(x14.GetTypeStr());
                if (__index0 == -1)
                {
                    throw new SerializationException();
                }
                x14.TypeIndex = __index0;
                x14.Instance = test.DemoDynamic.LoadJsonDemoDynamic(_fieldJson);
            }
        }
        
        { 
            var _fieldJson = _json["k1"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } int __n0 = _fieldJson.Count; k1 = new int[__n0]; int __i0=0; foreach(SimpleJSON.JSONNode __e0 in _fieldJson.Children) { int __v0;  if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = __e0;  k1[__i0++] = __v0; }  
            }
        }
        
        { 
            var _fieldJson = _json["k8"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } k8 = new System.Collections.Generic.List<object[]>(); foreach(SimpleJSON.JSONNode __e0 in _fieldJson.Children) { int __k0;  if(!__e0[0].IsNumber) { throw new SerializationException(); }  __k0 = __e0[0]; int __v0;  if(!__e0[1].IsNumber) { throw new SerializationException(); }  __v0 = __e0[1];  k8.Add(new object[] { __k0, __v0 }); }  
            }
        }
        
        { 
            var _fieldJson = _json["k9"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } k9 = new System.Collections.Generic.List<test.DemoE2>(); foreach(SimpleJSON.JSONNode __e0 in _fieldJson.Children) { test.DemoE2 __v0;  if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = test.DemoE2.LoadJsonDemoE2(__e0);  k9.Add(__v0); }  
            }
        }
        
        { 
            var _fieldJson = _json["k15"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } int __n0 = _fieldJson.Count; k15 = new test.DemoDynamic[__n0]; int __i0=0; foreach(SimpleJSON.JSONNode __e0 in _fieldJson.Children) { test.DemoDynamic __v0;  
                if (!__e0.IsObject)
                {
                    throw new SerializationException();
                }
                __v0 = test.DemoDynamic.LoadJsonDemoDynamic(__e0);
                var __index0 = test.DemoDynamic.Types.IndexOf(__v0.GetTypeStr());
                if (__index0 == -1)
                {
                    throw new SerializationException();
                }
                __v0.TypeIndex = __index0;
                __v0.Instance = test.DemoDynamic.LoadJsonDemoDynamic(__e0);  k15[__i0++] = __v0; }  
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            _json["x4"] = new JSONNumber(x4);
        }
        {
            _json["x1"] = new JSONBool(x1);
        }
        {
            _json["x5"] = new JSONNumber(x5);
        }
        {
            _json["x6"] = new JSONNumber(x6);
        }
        {
            if (s1 == null) { throw new System.ArgumentNullException(); }
            _json["s1"] = new JSONString(s1);
        }
        {
            if (s2 == null) { throw new System.ArgumentNullException(); }
            _json["s2"] = new JSONString(s2);
        }
        {
            _json["t1"] = new JSONString(t1);
        }
        {
            if (x12 == null) { throw new System.ArgumentNullException(); }
            { var __bjson = new JSONObject();  test.DemoType1.SaveJsonDemoType1(x12, __bjson); _json["x12"] = __bjson; }
        }
        {
            _json["x13"] = new JSONNumber((int)x13);
        }
        {
            if (x14 == null) { throw new System.ArgumentNullException(); }
            { var __bjson = new JSONObject();  test.DemoDynamic.SaveJsonDemoDynamic(x14, __bjson); _json["x14"] = __bjson; }
        }
        {
            if (k1 == null) { throw new System.ArgumentNullException(); }
            { var __cjson0 = new JSONArray(); foreach(var __e0 in k1) { __cjson0["null"] = new JSONNumber(__e0); } _json["k1"] = __cjson0; }
        }
        {
            if (k8 == null) { throw new System.ArgumentNullException(); }
            {
                var __cjson0 = new JSONArray();
                foreach(var __e0 in k8)
                {
                    var __entry0 = new JSONArray();
                    __cjson0[null] = __entry0;
                    __entry0["null"] = new JSONNumber((int)__e0[0]);
                    __entry0["null"] = new JSONNumber((int)__e0[1]);
                }
                _json["k8"] = __cjson0;
            }
        }
        {
            if (k9 == null) { throw new System.ArgumentNullException(); }
            { var __cjson0 = new JSONArray(); foreach(var __e0 in k9) { { var __bjson = new JSONObject();  test.DemoE2.SaveJsonDemoE2(__e0, __bjson); __cjson0["null"] = __bjson; } } _json["k9"] = __cjson0; }
        }
        {
            if (k15 == null) { throw new System.ArgumentNullException(); }
            { var __cjson0 = new JSONArray(); foreach(var __e0 in k15) { { var __bjson = new JSONObject();  test.DemoDynamic.SaveJsonDemoDynamic(__e0, __bjson); __cjson0["null"] = __bjson; } } _json["k15"] = __cjson0; }
        }
    }

    private GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);

    public override void Render()
    {
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);UnityEditor.EditorGUILayout.BeginHorizontal();
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
this.x6 = UnityEditor.EditorGUILayout.FloatField(this.x6, GUILayout.Width(150));
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
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("t1", "t1"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("t1", ""), GUILayout.Width(100));
}
this.t1 = UnityEditor.EditorGUILayout.TextField(this.t1, GUILayout.Width(150));
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
this.x13 = (test.DemoEnum)UnityEditor.EditorGUILayout.EnumPopup(this.x13, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x14", "x14"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x14", ""), GUILayout.Width(100));
}
{
    var __list1 = test.DemoDynamic.Types.Select(t => new GUIContent(t)).ToArray();
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    if (this.x14 == null)
    {
        this.x14 = new test.DemoD2();
        this.x14.TypeIndex = 0;
    }
    UnityEditor.EditorGUILayout.BeginHorizontal();
    UnityEditor.EditorGUILayout.LabelField("类型", GUILayout.Width(100));
    this.x14.TypeIndex = UnityEditor.EditorGUILayout.Popup(this.x14.TypeIndex, __list1, GUILayout.Width(200));
    UnityEditor.EditorGUILayout.EndHorizontal();
    this.x14.Instance.Render();
    UnityEditor.EditorGUILayout.EndVertical();
}
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
        __list1.Add(default);
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
        int __key1 = default;
        int __value1 = default;
        if (__e1 == null)
        {
            __e1 = new object[2] { __key1, __value1 };
            this.k8[__i1] = __e1;
        }
        else
        {
            __key1 = (int)__e1[0];
            __value1 = (int)__e1[1];
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
        test.DemoE2 __e1 = this.k9[__i1];
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
__e1.y1 = UnityEditor.EditorGUILayout.IntField(__e1.y1.Value, GUILayout.Width(150));
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
        this.k9.Add(new test.DemoE2());
    }
    if (GUILayout.Button("import", GUILayout.Width(100)))
    {
        ConfigEditorImportWindow.Open((__importJsonText1) => 
        {
            var __importJson1 = SimpleJSON.JSON.Parse(__importJsonText1);
            test.DemoE2 __importElement1;
            if(!__importJson1.IsObject) { throw new SerializationException(); }  __importElement1 = test.DemoE2.LoadJsonDemoE2(__importJson1);
            this.k9.Add(__importElement1);
        });
    }
    UnityEditor.EditorGUILayout.EndHorizontal();
    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("k15", "k15"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("k15", ""), GUILayout.Width(100));
}
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    int __n1 = this.k15.Length;
    for (int __i1 = 0; __i1 < __n1; __i1++)
    {
        UnityEditor.EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("-", GUILayout.Width(20)))
        {
            var __list1 = new System.Collections.Generic.List<test.DemoDynamic>(this.k15);
            __list1.RemoveAt(__i1);
            this.k15 = __list1.ToArray();
            UnityEditor.EditorGUILayout.EndHorizontal();
            break;
        }
        UnityEditor.EditorGUILayout.LabelField(__i1.ToString(), GUILayout.Width(20));
        test.DemoDynamic __e1 = this.k15[__i1];
        {
    var __list2 = test.DemoDynamic.Types.Select(t => new GUIContent(t)).ToArray();
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    if (__e1 == null)
    {
        __e1 = new test.DemoD2();
        __e1.TypeIndex = 0;
    }
    UnityEditor.EditorGUILayout.BeginHorizontal();
    UnityEditor.EditorGUILayout.LabelField("类型", GUILayout.Width(100));
    __e1.TypeIndex = UnityEditor.EditorGUILayout.Popup(__e1.TypeIndex, __list2, GUILayout.Width(200));
    UnityEditor.EditorGUILayout.EndHorizontal();
    __e1.Instance.Render();
    UnityEditor.EditorGUILayout.EndVertical();
};
        this.k15[__i1] = __e1;
        UnityEditor.EditorGUILayout.EndHorizontal();
    }
    UnityEditor.EditorGUILayout.BeginHorizontal();
    if (GUILayout.Button("+", GUILayout.Width(20)))
    {
        var __list1 = new System.Collections.Generic.List<test.DemoDynamic>(this.k15);
        __list1.Add(default);
        this.k15 = __list1.ToArray();
    }
    if (GUILayout.Button("import", GUILayout.Width(100)))
    {
        ConfigEditorImportWindow.Open((__importJsonText1) => 
        {
            var __importJson1 = SimpleJSON.JSON.Parse(__importJsonText1);
            test.DemoDynamic __importElement1;
            
if (!__importJson1.IsObject)
{
    throw new SerializationException();
}
__importElement1 = test.DemoDynamic.LoadJsonDemoDynamic(__importJson1);
var __index2 = test.DemoDynamic.Types.IndexOf(__importElement1.GetTypeStr());
if (__index2 == -1)
{
    throw new SerializationException();
}
__importElement1.TypeIndex = __index2;
__importElement1.Instance = test.DemoDynamic.LoadJsonDemoDynamic(__importJson1);
            var __list1 = new System.Collections.Generic.List<test.DemoDynamic>(this.k15);
            __list1.Add(__importElement1);
            this.k15 = __list1.ToArray();
        });
    }
    UnityEditor.EditorGUILayout.EndHorizontal();
    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}    }

    public static ExcelFromJson LoadJsonExcelFromJson(SimpleJSON.JSONNode _json)
    {
        ExcelFromJson obj = new test.ExcelFromJson();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonExcelFromJson(ExcelFromJson _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int x4;
    public bool x1;
    public long x5;
    public float x6;
    public string s1;
    public string s2;
    public string t1;
    public test.DemoType1 x12;
    public test.DemoEnum x13;
    public test.DemoDynamic x14;
    public int[] k1;
    public System.Collections.Generic.List<object[]> k8;
    public System.Collections.Generic.List<test.DemoE2> k9;
    public test.DemoDynamic[] k15;

    public override string ToString()
    {
        return "{ "
        + "x4:" + x4 + ","
        + "x1:" + x1 + ","
        + "x5:" + x5 + ","
        + "x6:" + x6 + ","
        + "s1:" + s1 + ","
        + "s2:" + s2 + ","
        + "t1:" + t1 + ","
        + "x12:" + x12 + ","
        + "x13:" + x13 + ","
        + "x14:" + x14 + ","
        + "k1:" + Luban.StringUtil.CollectionToString(k1) + ","
        + "k8:" + Luban.StringUtil.CollectionToString(k8) + ","
        + "k9:" + Luban.StringUtil.CollectionToString(k9) + ","
        + "k15:" + Luban.StringUtil.CollectionToString(k15) + ","
        + "}";
    }
}

}

