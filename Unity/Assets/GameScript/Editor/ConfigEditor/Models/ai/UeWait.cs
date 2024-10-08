
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

namespace editor.cfg.ai
{

public sealed class UeWait :  ai.Task 
{
    public UeWait()
    {
    }
    public override string GetTypeStr() => TYPE_STR;
    private const string TYPE_STR = "UeWait";

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
            var _fieldJson = _json["node_name"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  nodeName = _fieldJson;
            }
            else
            {
                nodeName = "";
            }
        }
        
        { 
            var _fieldJson = _json["decorators"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } decorators = new System.Collections.Generic.List<editor.cfg.ai.Decorator>(); foreach(SimpleJSON.JSONNode __e0 in _fieldJson.Children) { editor.cfg.ai.Decorator __v0;  
                if (!__e0.IsObject)
                {
                    throw new SerializationException();
                }
                __v0 = editor.cfg.ai.Decorator.LoadJsonDecorator(__e0);  decorators.Add(__v0); }  
            }
            else
            {
                decorators = new System.Collections.Generic.List<editor.cfg.ai.Decorator>();
            }
        }
        
        { 
            var _fieldJson = _json["services"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } services = new System.Collections.Generic.List<editor.cfg.ai.Service>(); foreach(SimpleJSON.JSONNode __e0 in _fieldJson.Children) { editor.cfg.ai.Service __v0;  
                if (!__e0.IsObject)
                {
                    throw new SerializationException();
                }
                __v0 = editor.cfg.ai.Service.LoadJsonService(__e0);  services.Add(__v0); }  
            }
            else
            {
                services = new System.Collections.Generic.List<editor.cfg.ai.Service>();
            }
        }
        
        { 
            var _fieldJson = _json["ignore_restart_self"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsBoolean) { throw new SerializationException(); }  ignoreRestartSelf = _fieldJson;
            }
            else
            {
                ignoreRestartSelf = false;
            }
        }
        
        { 
            var _fieldJson = _json["wait_time"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  waitTime = _fieldJson;
            }
            else
            {
                waitTime = 0;
            }
        }
        
        { 
            var _fieldJson = _json["random_deviation"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  randomDeviation = _fieldJson;
            }
            else
            {
                randomDeviation = 0;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            _json["id"] = new JSONNumber(id);
        }

        if (nodeName != null)
        {
            _json["node_name"] = new JSONString(nodeName);
        }

        if (decorators != null)
        {
            { var __cjson0 = new JSONArray(); foreach(var __e0 in decorators) { { var __bjson = new JSONObject();  editor.cfg.ai.Decorator.SaveJsonDecorator(__e0, __bjson); __cjson0["null"] = __bjson; } } __cjson0.Inline = __cjson0.Count == 0; _json["decorators"] = __cjson0; }
        }

        if (services != null)
        {
            { var __cjson0 = new JSONArray(); foreach(var __e0 in services) { { var __bjson = new JSONObject();  editor.cfg.ai.Service.SaveJsonService(__e0, __bjson); __cjson0["null"] = __bjson; } } __cjson0.Inline = __cjson0.Count == 0; _json["services"] = __cjson0; }
        }
        {
            _json["ignore_restart_self"] = new JSONBool(ignoreRestartSelf);
        }
        {
            _json["wait_time"] = new JSONNumber(waitTime);
        }
        {
            _json["random_deviation"] = new JSONNumber(randomDeviation);
        }
    }

    private static GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);

    public static void RenderUeWait(UeWait obj)
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
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("node_name", "node_name"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("node_name", ""), GUILayout.Width(100));
}
this.nodeName = UnityEditor.EditorGUILayout.TextField(this.nodeName, GUILayout.Width(150));
if (GUILayout.Button("…", GUILayout.Width(20)))
{
    TextInputWindow.GetTextAsync(this.nodeName,__x =>this.nodeName = __x);
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("decorators", "decorators"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("decorators", ""), GUILayout.Width(100));
}
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    int __n1 = this.decorators.Count;
    UnityEditor.EditorGUILayout.LabelField("长度: " + __n1.ToString());
    for (int __i1 = 0; __i1 < __n1; __i1++)
    {
        UnityEditor.EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("-", GUILayout.Width(20)))
        {
            this.decorators.RemoveAt(__i1);
            UnityEditor.EditorGUILayout.EndHorizontal();
            break;
        }
        UnityEditor.EditorGUILayout.LabelField(__i1.ToString(), GUILayout.Width(20));
        editor.cfg.ai.Decorator __e1 = this.decorators[__i1];
        {
    if (__e1 == null)
{   
    __e1 = ai.Decorator.Create("UeLoop");
}
    ai.Decorator.RenderDecorator(ref __e1);
};
        this.decorators[__i1] = __e1;
        UnityEditor.EditorGUILayout.EndHorizontal();
    }
    UnityEditor.EditorGUILayout.BeginHorizontal();
    if (GUILayout.Button("+", GUILayout.Width(20)))
    {
        editor.cfg.ai.Decorator __e1;
        __e1 = ai.Decorator.Create("UeLoop");;
        this.decorators.Add(__e1);
    }
    if (ConfigEditorSettings.showImportButton && GUILayout.Button("import", GUILayout.Width(100)))
    {
        ConfigEditorImportWindow.Open((__importJsonText1) => 
        {
            var __importJson1 = SimpleJSON.JSON.Parse(__importJsonText1);
            editor.cfg.ai.Decorator __importElement1;
            
if (!__importJson1.IsObject)
{
    throw new SerializationException();
}
__importElement1 = editor.cfg.ai.Decorator.LoadJsonDecorator(__importJson1);
            this.decorators.Add(__importElement1);
        });
    }
    UnityEditor.EditorGUILayout.EndHorizontal();
    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("services", "services"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("services", ""), GUILayout.Width(100));
}
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    int __n1 = this.services.Count;
    UnityEditor.EditorGUILayout.LabelField("长度: " + __n1.ToString());
    for (int __i1 = 0; __i1 < __n1; __i1++)
    {
        UnityEditor.EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("-", GUILayout.Width(20)))
        {
            this.services.RemoveAt(__i1);
            UnityEditor.EditorGUILayout.EndHorizontal();
            break;
        }
        UnityEditor.EditorGUILayout.LabelField(__i1.ToString(), GUILayout.Width(20));
        editor.cfg.ai.Service __e1 = this.services[__i1];
        {
    if (__e1 == null)
{   
    __e1 = ai.Service.Create("UeSetDefaultFocus");
}
    ai.Service.RenderService(ref __e1);
};
        this.services[__i1] = __e1;
        UnityEditor.EditorGUILayout.EndHorizontal();
    }
    UnityEditor.EditorGUILayout.BeginHorizontal();
    if (GUILayout.Button("+", GUILayout.Width(20)))
    {
        editor.cfg.ai.Service __e1;
        __e1 = ai.Service.Create("UeSetDefaultFocus");;
        this.services.Add(__e1);
    }
    if (ConfigEditorSettings.showImportButton && GUILayout.Button("import", GUILayout.Width(100)))
    {
        ConfigEditorImportWindow.Open((__importJsonText1) => 
        {
            var __importJson1 = SimpleJSON.JSON.Parse(__importJsonText1);
            editor.cfg.ai.Service __importElement1;
            
if (!__importJson1.IsObject)
{
    throw new SerializationException();
}
__importElement1 = editor.cfg.ai.Service.LoadJsonService(__importJson1);
            this.services.Add(__importElement1);
        });
    }
    UnityEditor.EditorGUILayout.EndHorizontal();
    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("ignore_restart_self", "ignore_restart_self"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("ignore_restart_self", ""), GUILayout.Width(100));
}
this.ignoreRestartSelf = UnityEditor.EditorGUILayout.Toggle(this.ignoreRestartSelf, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("wait_time", "wait_time"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("wait_time", ""), GUILayout.Width(100));
}
this.waitTime = UnityEditor.EditorGUILayout.DoubleField(this.waitTime, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("random_deviation", "random_deviation"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("random_deviation", ""), GUILayout.Width(100));
}
this.randomDeviation = UnityEditor.EditorGUILayout.DoubleField(this.randomDeviation, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}    }
    public static UeWait LoadJsonUeWait(SimpleJSON.JSONNode _json)
    {
        UeWait obj = new ai.UeWait();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonUeWait(UeWait _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public double waitTime;
    public double randomDeviation;

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "nodeName:" + nodeName + ","
        + "decorators:" + Luban.StringUtil.CollectionToString(decorators) + ","
        + "services:" + Luban.StringUtil.CollectionToString(services) + ","
        + "ignoreRestartSelf:" + ignoreRestartSelf + ","
        + "waitTime:" + waitTime + ","
        + "randomDeviation:" + randomDeviation + ","
        + "}";
    }
}

}

