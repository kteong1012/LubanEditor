
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

public sealed class MultiRowRecord :  Luban.EditorBeanBase 
{
    public MultiRowRecord()
    {
            name = "";
            oneRows = new System.Collections.Generic.List<editor.cfg.test.MultiRowType1>();
            multiRows1 = new System.Collections.Generic.List<editor.cfg.test.MultiRowType1>();
            multiRows2 = System.Array.Empty<editor.cfg.test.MultiRowType1>();
            multiRows4 = new System.Collections.Generic.List<object[]>();
            multiRows5 = new System.Collections.Generic.List<editor.cfg.test.MultiRowType3>();
            multiRows6 = new System.Collections.Generic.List<object[]>();
            multiRows7 = new System.Collections.Generic.List<object[]>();
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
            var _fieldJson = _json["name"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  name = _fieldJson;
            }
            else
            {
                name = "";
            }
        }
        
        { 
            var _fieldJson = _json["one_rows"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } oneRows = new System.Collections.Generic.List<editor.cfg.test.MultiRowType1>(); foreach(SimpleJSON.JSONNode __e0 in _fieldJson.Children) { editor.cfg.test.MultiRowType1 __v0;  if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = editor.cfg.test.MultiRowType1.LoadJsonMultiRowType1(__e0);  oneRows.Add(__v0); }  
            }
            else
            {
                oneRows = new System.Collections.Generic.List<editor.cfg.test.MultiRowType1>();
            }
        }
        
        { 
            var _fieldJson = _json["multi_rows1"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } multiRows1 = new System.Collections.Generic.List<editor.cfg.test.MultiRowType1>(); foreach(SimpleJSON.JSONNode __e0 in _fieldJson.Children) { editor.cfg.test.MultiRowType1 __v0;  if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = editor.cfg.test.MultiRowType1.LoadJsonMultiRowType1(__e0);  multiRows1.Add(__v0); }  
            }
            else
            {
                multiRows1 = new System.Collections.Generic.List<editor.cfg.test.MultiRowType1>();
            }
        }
        
        { 
            var _fieldJson = _json["multi_rows2"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } int __n0 = _fieldJson.Count; multiRows2 = new editor.cfg.test.MultiRowType1[__n0]; int __i0=0; foreach(SimpleJSON.JSONNode __e0 in _fieldJson.Children) { editor.cfg.test.MultiRowType1 __v0;  if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = editor.cfg.test.MultiRowType1.LoadJsonMultiRowType1(__e0);  multiRows2[__i0++] = __v0; }  
            }
            else
            {
                multiRows2 = System.Array.Empty<editor.cfg.test.MultiRowType1>();
            }
        }
        
        { 
            var _fieldJson = _json["multi_rows4"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } multiRows4 = new System.Collections.Generic.List<object[]>(); foreach(SimpleJSON.JSONNode __e0 in _fieldJson.Children) { int __k0;  if(!__e0[0].IsNumber) { throw new SerializationException(); }  __k0 = __e0[0]; editor.cfg.test.MultiRowType2 __v0;  if(!__e0[1].IsObject) { throw new SerializationException(); }  __v0 = editor.cfg.test.MultiRowType2.LoadJsonMultiRowType2(__e0[1]);  multiRows4.Add(new object[] { __k0, __v0 }); }  
            }
            else
            {
                multiRows4 = new System.Collections.Generic.List<object[]>();
            }
        }
        
        { 
            var _fieldJson = _json["multi_rows5"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } multiRows5 = new System.Collections.Generic.List<editor.cfg.test.MultiRowType3>(); foreach(SimpleJSON.JSONNode __e0 in _fieldJson.Children) { editor.cfg.test.MultiRowType3 __v0;  if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = editor.cfg.test.MultiRowType3.LoadJsonMultiRowType3(__e0);  multiRows5.Add(__v0); }  
            }
            else
            {
                multiRows5 = new System.Collections.Generic.List<editor.cfg.test.MultiRowType3>();
            }
        }
        
        { 
            var _fieldJson = _json["multi_rows6"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } multiRows6 = new System.Collections.Generic.List<object[]>(); foreach(SimpleJSON.JSONNode __e0 in _fieldJson.Children) { int __k0;  if(!__e0[0].IsNumber) { throw new SerializationException(); }  __k0 = __e0[0]; editor.cfg.test.MultiRowType2 __v0;  if(!__e0[1].IsObject) { throw new SerializationException(); }  __v0 = editor.cfg.test.MultiRowType2.LoadJsonMultiRowType2(__e0[1]);  multiRows6.Add(new object[] { __k0, __v0 }); }  
            }
            else
            {
                multiRows6 = new System.Collections.Generic.List<object[]>();
            }
        }
        
        { 
            var _fieldJson = _json["multi_rows7"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } multiRows7 = new System.Collections.Generic.List<object[]>(); foreach(SimpleJSON.JSONNode __e0 in _fieldJson.Children) { int __k0;  if(!__e0[0].IsNumber) { throw new SerializationException(); }  __k0 = __e0[0]; int __v0;  if(!__e0[1].IsNumber) { throw new SerializationException(); }  __v0 = __e0[1];  multiRows7.Add(new object[] { __k0, __v0 }); }  
            }
            else
            {
                multiRows7 = new System.Collections.Generic.List<object[]>();
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            _json["id"] = new JSONNumber(id);
        }

        if (name != null)
        {
            _json["name"] = new JSONString(name);
        }

        if (oneRows != null)
        {
            { var __cjson0 = new JSONArray(); foreach(var __e0 in oneRows) { { var __bjson = new JSONObject();  editor.cfg.test.MultiRowType1.SaveJsonMultiRowType1(__e0, __bjson); __cjson0["null"] = __bjson; } } __cjson0.Inline = __cjson0.Count == 0; _json["one_rows"] = __cjson0; }
        }

        if (multiRows1 != null)
        {
            { var __cjson0 = new JSONArray(); foreach(var __e0 in multiRows1) { { var __bjson = new JSONObject();  editor.cfg.test.MultiRowType1.SaveJsonMultiRowType1(__e0, __bjson); __cjson0["null"] = __bjson; } } __cjson0.Inline = __cjson0.Count == 0; _json["multi_rows1"] = __cjson0; }
        }

        if (multiRows2 != null)
        {
            { var __cjson0 = new JSONArray(); foreach(var __e0 in multiRows2) { { var __bjson = new JSONObject();  editor.cfg.test.MultiRowType1.SaveJsonMultiRowType1(__e0, __bjson); __cjson0["null"] = __bjson; } } __cjson0.Inline = __cjson0.Count == 0; _json["multi_rows2"] = __cjson0; }
        }

        if (multiRows4 != null)
        {
            {
                var __cjson0 = new JSONArray();
                foreach(var __e0 in multiRows4)
                {
                    var __entry0 = new JSONArray();
                    __cjson0[null] = __entry0;
                    __entry0["null"] = new JSONNumber((int)__e0[0]);
                    { var __bjson = new JSONObject();  editor.cfg.test.MultiRowType2.SaveJsonMultiRowType2((editor.cfg.test.MultiRowType2)__e0[1], __bjson); __entry0["null"] = __bjson; }
                }
                __cjson0.Inline = __cjson0.Count == 0;
                _json["multi_rows4"] = __cjson0;
            }
        }

        if (multiRows5 != null)
        {
            { var __cjson0 = new JSONArray(); foreach(var __e0 in multiRows5) { { var __bjson = new JSONObject();  editor.cfg.test.MultiRowType3.SaveJsonMultiRowType3(__e0, __bjson); __cjson0["null"] = __bjson; } } __cjson0.Inline = __cjson0.Count == 0; _json["multi_rows5"] = __cjson0; }
        }

        if (multiRows6 != null)
        {
            {
                var __cjson0 = new JSONArray();
                foreach(var __e0 in multiRows6)
                {
                    var __entry0 = new JSONArray();
                    __cjson0[null] = __entry0;
                    __entry0["null"] = new JSONNumber((int)__e0[0]);
                    { var __bjson = new JSONObject();  editor.cfg.test.MultiRowType2.SaveJsonMultiRowType2((editor.cfg.test.MultiRowType2)__e0[1], __bjson); __entry0["null"] = __bjson; }
                }
                __cjson0.Inline = __cjson0.Count == 0;
                _json["multi_rows6"] = __cjson0;
            }
        }

        if (multiRows7 != null)
        {
            {
                var __cjson0 = new JSONArray();
                foreach(var __e0 in multiRows7)
                {
                    var __entry0 = new JSONArray();
                    __cjson0[null] = __entry0;
                    __entry0["null"] = new JSONNumber((int)__e0[0]);
                    __entry0["null"] = new JSONNumber((int)__e0[1]);
                }
                __cjson0.Inline = __cjson0.Count == 0;
                _json["multi_rows7"] = __cjson0;
            }
        }
    }

    private static GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);

    public static void RenderMultiRowRecord(MultiRowRecord obj)
    {
        obj.Render();
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
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("name", "name"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("name", ""), GUILayout.Width(100));
}
this.name = UnityEditor.EditorGUILayout.TextField(this.name, GUILayout.Width(150));
if (GUILayout.Button("…", GUILayout.Width(20)))
{
    TextInputWindow.GetTextAsync(this.name,__x =>this.name = __x);
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("one_rows", "one_rows"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("one_rows", ""), GUILayout.Width(100));
}
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    int __n1 = this.oneRows.Count;
    UnityEditor.EditorGUILayout.LabelField("长度: " + __n1.ToString());
    for (int __i1 = 0; __i1 < __n1; __i1++)
    {
        UnityEditor.EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("-", GUILayout.Width(20)))
        {
            this.oneRows.RemoveAt(__i1);
            UnityEditor.EditorGUILayout.EndHorizontal();
            break;
        }
        UnityEditor.EditorGUILayout.LabelField(__i1.ToString(), GUILayout.Width(20));
        editor.cfg.test.MultiRowType1 __e1 = this.oneRows[__i1];
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
__e1.id = UnityEditor.EditorGUILayout.IntField(__e1.id, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x", "x"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x", ""), GUILayout.Width(100));
}
__e1.x = UnityEditor.EditorGUILayout.IntField(__e1.x, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
};
        this.oneRows[__i1] = __e1;
        UnityEditor.EditorGUILayout.EndHorizontal();
    }
    UnityEditor.EditorGUILayout.BeginHorizontal();
    if (GUILayout.Button("+", GUILayout.Width(20)))
    {
        editor.cfg.test.MultiRowType1 __e1;
        __e1 = new test.MultiRowType1();;
        this.oneRows.Add(__e1);
    }
    if (ConfigEditorSettings.showImportButton && GUILayout.Button("import", GUILayout.Width(100)))
    {
        ConfigEditorImportWindow.Open((__importJsonText1) => 
        {
            var __importJson1 = SimpleJSON.JSON.Parse(__importJsonText1);
            editor.cfg.test.MultiRowType1 __importElement1;
            if(!__importJson1.IsObject) { throw new SerializationException(); }  __importElement1 = editor.cfg.test.MultiRowType1.LoadJsonMultiRowType1(__importJson1);
            this.oneRows.Add(__importElement1);
        });
    }
    UnityEditor.EditorGUILayout.EndHorizontal();
    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("multi_rows1", "multi_rows1"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("multi_rows1", ""), GUILayout.Width(100));
}
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    int __n1 = this.multiRows1.Count;
    UnityEditor.EditorGUILayout.LabelField("长度: " + __n1.ToString());
    for (int __i1 = 0; __i1 < __n1; __i1++)
    {
        UnityEditor.EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("-", GUILayout.Width(20)))
        {
            this.multiRows1.RemoveAt(__i1);
            UnityEditor.EditorGUILayout.EndHorizontal();
            break;
        }
        UnityEditor.EditorGUILayout.LabelField(__i1.ToString(), GUILayout.Width(20));
        editor.cfg.test.MultiRowType1 __e1 = this.multiRows1[__i1];
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
__e1.id = UnityEditor.EditorGUILayout.IntField(__e1.id, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x", "x"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x", ""), GUILayout.Width(100));
}
__e1.x = UnityEditor.EditorGUILayout.IntField(__e1.x, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
};
        this.multiRows1[__i1] = __e1;
        UnityEditor.EditorGUILayout.EndHorizontal();
    }
    UnityEditor.EditorGUILayout.BeginHorizontal();
    if (GUILayout.Button("+", GUILayout.Width(20)))
    {
        editor.cfg.test.MultiRowType1 __e1;
        __e1 = new test.MultiRowType1();;
        this.multiRows1.Add(__e1);
    }
    if (ConfigEditorSettings.showImportButton && GUILayout.Button("import", GUILayout.Width(100)))
    {
        ConfigEditorImportWindow.Open((__importJsonText1) => 
        {
            var __importJson1 = SimpleJSON.JSON.Parse(__importJsonText1);
            editor.cfg.test.MultiRowType1 __importElement1;
            if(!__importJson1.IsObject) { throw new SerializationException(); }  __importElement1 = editor.cfg.test.MultiRowType1.LoadJsonMultiRowType1(__importJson1);
            this.multiRows1.Add(__importElement1);
        });
    }
    UnityEditor.EditorGUILayout.EndHorizontal();
    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("multi_rows2", "multi_rows2"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("multi_rows2", ""), GUILayout.Width(100));
}
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    int __n1 = this.multiRows2.Length;
    UnityEditor.EditorGUILayout.LabelField("长度: " + __n1.ToString());
    for (int __i1 = 0; __i1 < __n1; __i1++)
    {
        UnityEditor.EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("-", GUILayout.Width(20)))
        {
            var __list1 = new System.Collections.Generic.List<editor.cfg.test.MultiRowType1>(this.multiRows2);
            __list1.RemoveAt(__i1);
            this.multiRows2 = __list1.ToArray();
            UnityEditor.EditorGUILayout.EndHorizontal();
            break;
        }
        UnityEditor.EditorGUILayout.LabelField(__i1.ToString(), GUILayout.Width(20));
        editor.cfg.test.MultiRowType1 __e1 = this.multiRows2[__i1];
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
__e1.id = UnityEditor.EditorGUILayout.IntField(__e1.id, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x", "x"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x", ""), GUILayout.Width(100));
}
__e1.x = UnityEditor.EditorGUILayout.IntField(__e1.x, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
};
        this.multiRows2[__i1] = __e1;
        UnityEditor.EditorGUILayout.EndHorizontal();
    }
    UnityEditor.EditorGUILayout.BeginHorizontal();
    if (GUILayout.Button("+", GUILayout.Width(20)))
    {
        var __list1 = new System.Collections.Generic.List<editor.cfg.test.MultiRowType1>(this.multiRows2);
        editor.cfg.test.MultiRowType1 __e1;
        __e1 = new test.MultiRowType1();;
        __list1.Add(__e1);
        this.multiRows2 = __list1.ToArray();
    }
    if (ConfigEditorSettings.showImportButton && GUILayout.Button("import", GUILayout.Width(100)))
    {
        ConfigEditorImportWindow.Open((__importJsonText1) => 
        {
            var __importJson1 = SimpleJSON.JSON.Parse(__importJsonText1);
            editor.cfg.test.MultiRowType1 __importElement1;
            if(!__importJson1.IsObject) { throw new SerializationException(); }  __importElement1 = editor.cfg.test.MultiRowType1.LoadJsonMultiRowType1(__importJson1);
            var __list1 = new System.Collections.Generic.List<editor.cfg.test.MultiRowType1>(this.multiRows2);
            __list1.Add(__importElement1);
            this.multiRows2 = __list1.ToArray();
        });
    }
    UnityEditor.EditorGUILayout.EndHorizontal();
    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("multi_rows4", "multi_rows4"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("multi_rows4", ""), GUILayout.Width(100));
}
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    int __n1 = this.multiRows4.Count;
    UnityEditor.EditorGUILayout.LabelField("长度: " + __n1.ToString());
    for (int __i1 = 0; __i1 < __n1; __i1++)
    {
        UnityEditor.EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("-", GUILayout.Width(20)))
        {
            this.multiRows4.RemoveAt(__i1);
            UnityEditor.EditorGUILayout.EndHorizontal();
            break;
        }
        UnityEditor.EditorGUILayout.LabelField(__i1.ToString(), GUILayout.Width(20));
        var __e1 = this.multiRows4[__i1];
        int __key1 = 0;
        editor.cfg.test.MultiRowType2 __value1 = new editor.cfg.test.MultiRowType2();
        if (__e1 == null)
        {
            __e1 = new object[2] { __key1, __value1 };
            this.multiRows4[__i1] = __e1;
        }
        else
        {
            __key1 = __e1[0] != null ? (int)__e1[0] : default;
            __value1 = __e1[1] != null ? (editor.cfg.test.MultiRowType2)__e1[1] : default;
        }
        __key1 = UnityEditor.EditorGUILayout.IntField(__key1, GUILayout.Width(150));;
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
__value1.id = UnityEditor.EditorGUILayout.IntField(__value1.id, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x", "x"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x", ""), GUILayout.Width(100));
}
__value1.x = UnityEditor.EditorGUILayout.IntField(__value1.x, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("y", "y"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("y", ""), GUILayout.Width(100));
}
__value1.y = UnityEditor.EditorGUILayout.DoubleField(__value1.y, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
};
        __e1[0] = __key1;
        __e1[1] = __value1;
        UnityEditor.EditorGUILayout.EndHorizontal();
    }
    if (GUILayout.Button("+", GUILayout.Width(20)))
    {
        this.multiRows4.Add(new object[2]);
    }
    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("multi_rows5", "multi_rows5"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("multi_rows5", ""), GUILayout.Width(100));
}
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    int __n1 = this.multiRows5.Count;
    UnityEditor.EditorGUILayout.LabelField("长度: " + __n1.ToString());
    for (int __i1 = 0; __i1 < __n1; __i1++)
    {
        UnityEditor.EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("-", GUILayout.Width(20)))
        {
            this.multiRows5.RemoveAt(__i1);
            UnityEditor.EditorGUILayout.EndHorizontal();
            break;
        }
        UnityEditor.EditorGUILayout.LabelField(__i1.ToString(), GUILayout.Width(20));
        editor.cfg.test.MultiRowType3 __e1 = this.multiRows5[__i1];
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
__e1.id = UnityEditor.EditorGUILayout.IntField(__e1.id, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("items", "items"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("items", ""), GUILayout.Width(100));
}
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    int __n3 = __e1.items.Count;
    UnityEditor.EditorGUILayout.LabelField("长度: " + __n3.ToString());
    for (int __i3 = 0; __i3 < __n3; __i3++)
    {
        UnityEditor.EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("-", GUILayout.Width(20)))
        {
            __e1.items.RemoveAt(__i3);
            UnityEditor.EditorGUILayout.EndHorizontal();
            break;
        }
        UnityEditor.EditorGUILayout.LabelField(__i3.ToString(), GUILayout.Width(20));
        editor.cfg.test.MultiRowType1 __e3 = __e1.items[__i3];
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
__e3.id = UnityEditor.EditorGUILayout.IntField(__e3.id, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x", "x"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x", ""), GUILayout.Width(100));
}
__e3.x = UnityEditor.EditorGUILayout.IntField(__e3.x, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
};
        __e1.items[__i3] = __e3;
        UnityEditor.EditorGUILayout.EndHorizontal();
    }
    UnityEditor.EditorGUILayout.BeginHorizontal();
    if (GUILayout.Button("+", GUILayout.Width(20)))
    {
        editor.cfg.test.MultiRowType1 __e3;
        __e3 = new test.MultiRowType1();;
        __e1.items.Add(__e3);
    }
    if (ConfigEditorSettings.showImportButton && GUILayout.Button("import", GUILayout.Width(100)))
    {
        ConfigEditorImportWindow.Open((__importJsonText3) => 
        {
            var __importJson3 = SimpleJSON.JSON.Parse(__importJsonText3);
            editor.cfg.test.MultiRowType1 __importElement3;
            if(!__importJson3.IsObject) { throw new SerializationException(); }  __importElement3 = editor.cfg.test.MultiRowType1.LoadJsonMultiRowType1(__importJson3);
            __e1.items.Add(__importElement3);
        });
    }
    UnityEditor.EditorGUILayout.EndHorizontal();
    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
};
        this.multiRows5[__i1] = __e1;
        UnityEditor.EditorGUILayout.EndHorizontal();
    }
    UnityEditor.EditorGUILayout.BeginHorizontal();
    if (GUILayout.Button("+", GUILayout.Width(20)))
    {
        editor.cfg.test.MultiRowType3 __e1;
        __e1 = new test.MultiRowType3();;
        this.multiRows5.Add(__e1);
    }
    if (ConfigEditorSettings.showImportButton && GUILayout.Button("import", GUILayout.Width(100)))
    {
        ConfigEditorImportWindow.Open((__importJsonText1) => 
        {
            var __importJson1 = SimpleJSON.JSON.Parse(__importJsonText1);
            editor.cfg.test.MultiRowType3 __importElement1;
            if(!__importJson1.IsObject) { throw new SerializationException(); }  __importElement1 = editor.cfg.test.MultiRowType3.LoadJsonMultiRowType3(__importJson1);
            this.multiRows5.Add(__importElement1);
        });
    }
    UnityEditor.EditorGUILayout.EndHorizontal();
    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("multi_rows6", "multi_rows6"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("multi_rows6", ""), GUILayout.Width(100));
}
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    int __n1 = this.multiRows6.Count;
    UnityEditor.EditorGUILayout.LabelField("长度: " + __n1.ToString());
    for (int __i1 = 0; __i1 < __n1; __i1++)
    {
        UnityEditor.EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("-", GUILayout.Width(20)))
        {
            this.multiRows6.RemoveAt(__i1);
            UnityEditor.EditorGUILayout.EndHorizontal();
            break;
        }
        UnityEditor.EditorGUILayout.LabelField(__i1.ToString(), GUILayout.Width(20));
        var __e1 = this.multiRows6[__i1];
        int __key1 = 0;
        editor.cfg.test.MultiRowType2 __value1 = new editor.cfg.test.MultiRowType2();
        if (__e1 == null)
        {
            __e1 = new object[2] { __key1, __value1 };
            this.multiRows6[__i1] = __e1;
        }
        else
        {
            __key1 = __e1[0] != null ? (int)__e1[0] : default;
            __value1 = __e1[1] != null ? (editor.cfg.test.MultiRowType2)__e1[1] : default;
        }
        __key1 = UnityEditor.EditorGUILayout.IntField(__key1, GUILayout.Width(150));;
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
__value1.id = UnityEditor.EditorGUILayout.IntField(__value1.id, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x", "x"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x", ""), GUILayout.Width(100));
}
__value1.x = UnityEditor.EditorGUILayout.IntField(__value1.x, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("y", "y"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("y", ""), GUILayout.Width(100));
}
__value1.y = UnityEditor.EditorGUILayout.DoubleField(__value1.y, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
};
        __e1[0] = __key1;
        __e1[1] = __value1;
        UnityEditor.EditorGUILayout.EndHorizontal();
    }
    if (GUILayout.Button("+", GUILayout.Width(20)))
    {
        this.multiRows6.Add(new object[2]);
    }
    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("multi_rows7", "multi_rows7"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("multi_rows7", ""), GUILayout.Width(100));
}
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    int __n1 = this.multiRows7.Count;
    UnityEditor.EditorGUILayout.LabelField("长度: " + __n1.ToString());
    for (int __i1 = 0; __i1 < __n1; __i1++)
    {
        UnityEditor.EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("-", GUILayout.Width(20)))
        {
            this.multiRows7.RemoveAt(__i1);
            UnityEditor.EditorGUILayout.EndHorizontal();
            break;
        }
        UnityEditor.EditorGUILayout.LabelField(__i1.ToString(), GUILayout.Width(20));
        var __e1 = this.multiRows7[__i1];
        int __key1 = 0;
        int __value1 = 0;
        if (__e1 == null)
        {
            __e1 = new object[2] { __key1, __value1 };
            this.multiRows7[__i1] = __e1;
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
        this.multiRows7.Add(new object[2]);
    }
    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}    }
    public static MultiRowRecord LoadJsonMultiRowRecord(SimpleJSON.JSONNode _json)
    {
        MultiRowRecord obj = new test.MultiRowRecord();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonMultiRowRecord(MultiRowRecord _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int id;
    public string name;
    public System.Collections.Generic.List<editor.cfg.test.MultiRowType1> oneRows;
    public System.Collections.Generic.List<editor.cfg.test.MultiRowType1> multiRows1;
    public editor.cfg.test.MultiRowType1[] multiRows2;
    public System.Collections.Generic.List<object[]> multiRows4;
    public System.Collections.Generic.List<editor.cfg.test.MultiRowType3> multiRows5;
    public System.Collections.Generic.List<object[]> multiRows6;
    public System.Collections.Generic.List<object[]> multiRows7;

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "name:" + name + ","
        + "oneRows:" + Luban.StringUtil.CollectionToString(oneRows) + ","
        + "multiRows1:" + Luban.StringUtil.CollectionToString(multiRows1) + ","
        + "multiRows2:" + Luban.StringUtil.CollectionToString(multiRows2) + ","
        + "multiRows4:" + Luban.StringUtil.CollectionToString(multiRows4) + ","
        + "multiRows5:" + Luban.StringUtil.CollectionToString(multiRows5) + ","
        + "multiRows6:" + Luban.StringUtil.CollectionToString(multiRows6) + ","
        + "multiRows7:" + Luban.StringUtil.CollectionToString(multiRows7) + ","
        + "}";
    }
}

}

