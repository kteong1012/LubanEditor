
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

public sealed class MultiRowTitle :  Luban.EditorBeanBase 
{
    public MultiRowTitle()
    {
            name = "";
            x1 = new test.H1();
            x2 = new System.Collections.Generic.List<test.H2>();
            x3 = System.Array.Empty<test.H2>();
            x4 = System.Array.Empty<test.H2>();
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
            var _fieldJson = _json["x1"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsObject) { throw new SerializationException(); }  x1 = editor.cfg.test.H1.LoadJsonH1(_fieldJson);
            }
            else
            {
                x1 = new test.H1();
            }
        }
        
        { 
            var _fieldJson = _json["x2_0"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsObject) { throw new SerializationException(); }  x20 = editor.cfg.test.H2.LoadJsonH2(_fieldJson);
            }
            else
            {
                x20 = new test.H2();
            }
        }
        
        { 
            var _fieldJson = _json["x2"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } x2 = new System.Collections.Generic.List<test.H2>(); foreach(SimpleJSON.JSONNode __e0 in _fieldJson.Children) { test.H2 __v0;  if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = editor.cfg.test.H2.LoadJsonH2(__e0);  x2.Add(__v0); }  
            }
            else
            {
                x2 = new System.Collections.Generic.List<test.H2>();
            }
        }
        
        { 
            var _fieldJson = _json["x3"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } int __n0 = _fieldJson.Count; x3 = new test.H2[__n0]; int __i0=0; foreach(SimpleJSON.JSONNode __e0 in _fieldJson.Children) { test.H2 __v0;  if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = editor.cfg.test.H2.LoadJsonH2(__e0);  x3[__i0++] = __v0; }  
            }
            else
            {
                x3 = System.Array.Empty<test.H2>();
            }
        }
        
        { 
            var _fieldJson = _json["x4"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } int __n0 = _fieldJson.Count; x4 = new test.H2[__n0]; int __i0=0; foreach(SimpleJSON.JSONNode __e0 in _fieldJson.Children) { test.H2 __v0;  if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = editor.cfg.test.H2.LoadJsonH2(__e0);  x4[__i0++] = __v0; }  
            }
            else
            {
                x4 = System.Array.Empty<test.H2>();
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            _json["id"] = new JSONNumber(id);
        }
        {
            if (name == null) { throw new System.ArgumentNullException(); }
            _json["name"] = new JSONString(name);
        }
        {
            if (x1 == null) { throw new System.ArgumentNullException(); }
            { var __bjson = new JSONObject();  editor.cfg.test.H1.SaveJsonH1(x1, __bjson); _json["x1"] = __bjson; }
        }

        if (x20 != null)
        {
            { var __bjson = new JSONObject();  editor.cfg.test.H2.SaveJsonH2(x20, __bjson); _json["x2_0"] = __bjson; }
        }
        {
            if (x2 == null) { throw new System.ArgumentNullException(); }
            { var __cjson0 = new JSONArray(); foreach(var __e0 in x2) { { var __bjson = new JSONObject();  editor.cfg.test.H2.SaveJsonH2(__e0, __bjson); __cjson0["null"] = __bjson; } } _json["x2"] = __cjson0; }
        }
        {
            if (x3 == null) { throw new System.ArgumentNullException(); }
            { var __cjson0 = new JSONArray(); foreach(var __e0 in x3) { { var __bjson = new JSONObject();  editor.cfg.test.H2.SaveJsonH2(__e0, __bjson); __cjson0["null"] = __bjson; } } _json["x3"] = __cjson0; }
        }
        {
            if (x4 == null) { throw new System.ArgumentNullException(); }
            { var __cjson0 = new JSONArray(); foreach(var __e0 in x4) { { var __bjson = new JSONObject();  editor.cfg.test.H2.SaveJsonH2(__e0, __bjson); __cjson0["null"] = __bjson; } } _json["x4"] = __cjson0; }
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
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("name", "name"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("name", ""), GUILayout.Width(100));
}
this.name = UnityEditor.EditorGUILayout.TextField(this.name, GUILayout.Width(150));
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
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("y2", "y2"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("y2", ""), GUILayout.Width(100));
}
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("z2", "z2"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("z2", ""), GUILayout.Width(100));
}
this.x1.y2.z2 = UnityEditor.EditorGUILayout.IntField(this.x1.y2.z2, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("z3", "z3"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("z3", ""), GUILayout.Width(100));
}
this.x1.y2.z3 = UnityEditor.EditorGUILayout.IntField(this.x1.y2.z3, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("y3", "y3"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("y3", ""), GUILayout.Width(100));
}
this.x1.y3 = UnityEditor.EditorGUILayout.IntField(this.x1.y3, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x2_0", "x2_0"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x2_0", ""), GUILayout.Width(100));
}
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("z2", "z2"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("z2", ""), GUILayout.Width(100));
}
this.x20.z2 = UnityEditor.EditorGUILayout.IntField(this.x20.z2, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("z3", "z3"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("z3", ""), GUILayout.Width(100));
}
this.x20.z3 = UnityEditor.EditorGUILayout.IntField(this.x20.z3, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
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
        test.H2 __e1 = this.x2[__i1];
        {
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("z2", "z2"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("z2", ""), GUILayout.Width(100));
}
__e1.z2 = UnityEditor.EditorGUILayout.IntField(__e1.z2, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("z3", "z3"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("z3", ""), GUILayout.Width(100));
}
__e1.z3 = UnityEditor.EditorGUILayout.IntField(__e1.z3, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
};
        this.x2[__i1] = __e1;
        UnityEditor.EditorGUILayout.EndHorizontal();
    }
    UnityEditor.EditorGUILayout.BeginHorizontal();
    if (GUILayout.Button("+", GUILayout.Width(20)))
    {
        this.x2.Add(new test.H2());
    }
    if (GUILayout.Button("import", GUILayout.Width(100)))
    {
        ConfigEditorImportWindow.Open((__importJsonText1) => 
        {
            var __importJson1 = SimpleJSON.JSON.Parse(__importJsonText1);
            test.H2 __importElement1;
            if(!__importJson1.IsObject) { throw new SerializationException(); }  __importElement1 = editor.cfg.test.H2.LoadJsonH2(__importJson1);
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
    int __n1 = this.x3.Length;
    for (int __i1 = 0; __i1 < __n1; __i1++)
    {
        UnityEditor.EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("-", GUILayout.Width(20)))
        {
            var __list1 = new System.Collections.Generic.List<test.H2>(this.x3);
            __list1.RemoveAt(__i1);
            this.x3 = __list1.ToArray();
            UnityEditor.EditorGUILayout.EndHorizontal();
            break;
        }
        UnityEditor.EditorGUILayout.LabelField(__i1.ToString(), GUILayout.Width(20));
        test.H2 __e1 = this.x3[__i1];
        {
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("z2", "z2"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("z2", ""), GUILayout.Width(100));
}
__e1.z2 = UnityEditor.EditorGUILayout.IntField(__e1.z2, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("z3", "z3"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("z3", ""), GUILayout.Width(100));
}
__e1.z3 = UnityEditor.EditorGUILayout.IntField(__e1.z3, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
};
        this.x3[__i1] = __e1;
        UnityEditor.EditorGUILayout.EndHorizontal();
    }
    UnityEditor.EditorGUILayout.BeginHorizontal();
    if (GUILayout.Button("+", GUILayout.Width(20)))
    {
        var __list1 = new System.Collections.Generic.List<test.H2>(this.x3);
        __list1.Add(new test.H2());
        this.x3 = __list1.ToArray();
    }
    if (GUILayout.Button("import", GUILayout.Width(100)))
    {
        ConfigEditorImportWindow.Open((__importJsonText1) => 
        {
            var __importJson1 = SimpleJSON.JSON.Parse(__importJsonText1);
            test.H2 __importElement1;
            if(!__importJson1.IsObject) { throw new SerializationException(); }  __importElement1 = editor.cfg.test.H2.LoadJsonH2(__importJson1);
            var __list1 = new System.Collections.Generic.List<test.H2>(this.x3);
            __list1.Add(__importElement1);
            this.x3 = __list1.ToArray();
        });
    }
    UnityEditor.EditorGUILayout.EndHorizontal();
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
    int __n1 = this.x4.Length;
    for (int __i1 = 0; __i1 < __n1; __i1++)
    {
        UnityEditor.EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("-", GUILayout.Width(20)))
        {
            var __list1 = new System.Collections.Generic.List<test.H2>(this.x4);
            __list1.RemoveAt(__i1);
            this.x4 = __list1.ToArray();
            UnityEditor.EditorGUILayout.EndHorizontal();
            break;
        }
        UnityEditor.EditorGUILayout.LabelField(__i1.ToString(), GUILayout.Width(20));
        test.H2 __e1 = this.x4[__i1];
        {
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("z2", "z2"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("z2", ""), GUILayout.Width(100));
}
__e1.z2 = UnityEditor.EditorGUILayout.IntField(__e1.z2, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("z3", "z3"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("z3", ""), GUILayout.Width(100));
}
__e1.z3 = UnityEditor.EditorGUILayout.IntField(__e1.z3, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
};
        this.x4[__i1] = __e1;
        UnityEditor.EditorGUILayout.EndHorizontal();
    }
    UnityEditor.EditorGUILayout.BeginHorizontal();
    if (GUILayout.Button("+", GUILayout.Width(20)))
    {
        var __list1 = new System.Collections.Generic.List<test.H2>(this.x4);
        __list1.Add(new test.H2());
        this.x4 = __list1.ToArray();
    }
    if (GUILayout.Button("import", GUILayout.Width(100)))
    {
        ConfigEditorImportWindow.Open((__importJsonText1) => 
        {
            var __importJson1 = SimpleJSON.JSON.Parse(__importJsonText1);
            test.H2 __importElement1;
            if(!__importJson1.IsObject) { throw new SerializationException(); }  __importElement1 = editor.cfg.test.H2.LoadJsonH2(__importJson1);
            var __list1 = new System.Collections.Generic.List<test.H2>(this.x4);
            __list1.Add(__importElement1);
            this.x4 = __list1.ToArray();
        });
    }
    UnityEditor.EditorGUILayout.EndHorizontal();
    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}    }

    public static MultiRowTitle LoadJsonMultiRowTitle(SimpleJSON.JSONNode _json)
    {
        MultiRowTitle obj = new test.MultiRowTitle();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonMultiRowTitle(MultiRowTitle _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int id;
    public string name;
    public test.H1 x1;
    public test.H2 x20;
    public System.Collections.Generic.List<test.H2> x2;
    public test.H2[] x3;
    public test.H2[] x4;

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "name:" + name + ","
        + "x1:" + x1 + ","
        + "x20:" + x20 + ","
        + "x2:" + Luban.StringUtil.CollectionToString(x2) + ","
        + "x3:" + Luban.StringUtil.CollectionToString(x3) + ","
        + "x4:" + Luban.StringUtil.CollectionToString(x4) + ","
        + "}";
    }
}

}

