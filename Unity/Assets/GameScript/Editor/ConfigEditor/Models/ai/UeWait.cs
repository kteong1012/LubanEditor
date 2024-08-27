
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

namespace editor.cfg.ai
{

public sealed class UeWait :  ai.Task 
{
    public UeWait()
    {
    }
    public override string GetTypeStr() => TYPE_STR;
    private const string TYPE_STR = "ai.UeWait";

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
                if(!_fieldJson.IsArray) { throw new SerializationException(); } decorators = new System.Collections.Generic.List<ai.Decorator>(); foreach(SimpleJSON.JSONNode __e0 in _fieldJson.Children) { ai.Decorator __v0;  
                if (!__e0.IsObject)
                {
                    throw new SerializationException();
                }
                __v0 = editor.cfg.ai.Decorator.LoadJsonDecorator(__e0);
                var __index0 = editor.cfg.ai.Decorator.Types.IndexOf(__v0.GetTypeStr());
                if (__index0 == -1)
                {
                    throw new SerializationException();
                }
                __v0.TypeIndex = __index0;
                __v0.Instance = editor.cfg.ai.Decorator.LoadJsonDecorator(__e0);  decorators.Add(__v0); }  
            }
            else
            {
                decorators = new System.Collections.Generic.List<ai.Decorator>();
            }
        }
        
        { 
            var _fieldJson = _json["services"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } services = new System.Collections.Generic.List<ai.Service>(); foreach(SimpleJSON.JSONNode __e0 in _fieldJson.Children) { ai.Service __v0;  
                if (!__e0.IsObject)
                {
                    throw new SerializationException();
                }
                __v0 = editor.cfg.ai.Service.LoadJsonService(__e0);
                var __index0 = editor.cfg.ai.Service.Types.IndexOf(__v0.GetTypeStr());
                if (__index0 == -1)
                {
                    throw new SerializationException();
                }
                __v0.TypeIndex = __index0;
                __v0.Instance = editor.cfg.ai.Service.LoadJsonService(__e0);  services.Add(__v0); }  
            }
            else
            {
                services = new System.Collections.Generic.List<ai.Service>();
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
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            _json["id"] = new JSONNumber(id);
        }
        {
            if (nodeName == null) { throw new System.ArgumentNullException(); }
            _json["node_name"] = new JSONString(nodeName);
        }
        {
            if (decorators == null) { throw new System.ArgumentNullException(); }
            { var __cjson0 = new JSONArray(); foreach(var __e0 in decorators) { { var __bjson = new JSONObject();  editor.cfg.ai.Decorator.SaveJsonDecorator(__e0, __bjson); __cjson0["null"] = __bjson; } } _json["decorators"] = __cjson0; }
        }
        {
            if (services == null) { throw new System.ArgumentNullException(); }
            { var __cjson0 = new JSONArray(); foreach(var __e0 in services) { { var __bjson = new JSONObject();  editor.cfg.ai.Service.SaveJsonService(__e0, __bjson); __cjson0["null"] = __bjson; } } _json["services"] = __cjson0; }
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
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("node_name", "node_name"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("node_name", ""), GUILayout.Width(100));
}
this.nodeName = UnityEditor.EditorGUILayout.TextField(this.nodeName, GUILayout.Width(150));
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
        ai.Decorator __e1 = this.decorators[__i1];
        {
    var __list2 = ai.Decorator.Types.Select(t => new GUIContent(t)).ToArray();
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    if (__e1 == null)
    {
        __e1 = new ai.UeLoop();
        __e1.TypeIndex = 0;
    }
    UnityEditor.EditorGUILayout.BeginHorizontal();
    UnityEditor.EditorGUILayout.LabelField("类型", GUILayout.Width(100));
    __e1.TypeIndex = UnityEditor.EditorGUILayout.Popup(__e1.TypeIndex, __list2, GUILayout.Width(200));
    UnityEditor.EditorGUILayout.EndHorizontal();
    __e1.Instance.Render();
    UnityEditor.EditorGUILayout.EndVertical();
};
        this.decorators[__i1] = __e1;
        UnityEditor.EditorGUILayout.EndHorizontal();
    }
    UnityEditor.EditorGUILayout.BeginHorizontal();
    if (GUILayout.Button("+", GUILayout.Width(20)))
    {
        this.decorators.Add(new ai.UeLoop(){ TypeIndex = 0});
    }
    if (GUILayout.Button("import", GUILayout.Width(100)))
    {
        ConfigEditorImportWindow.Open((__importJsonText1) => 
        {
            var __importJson1 = SimpleJSON.JSON.Parse(__importJsonText1);
            ai.Decorator __importElement1;
            
if (!__importJson1.IsObject)
{
    throw new SerializationException();
}
__importElement1 = editor.cfg.ai.Decorator.LoadJsonDecorator(__importJson1);
var __index2 = editor.cfg.ai.Decorator.Types.IndexOf(__importElement1.GetTypeStr());
if (__index2 == -1)
{
    throw new SerializationException();
}
__importElement1.TypeIndex = __index2;
__importElement1.Instance = editor.cfg.ai.Decorator.LoadJsonDecorator(__importJson1);
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
        ai.Service __e1 = this.services[__i1];
        {
    var __list2 = ai.Service.Types.Select(t => new GUIContent(t)).ToArray();
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    if (__e1 == null)
    {
        __e1 = new ai.UeSetDefaultFocus();
        __e1.TypeIndex = 0;
    }
    UnityEditor.EditorGUILayout.BeginHorizontal();
    UnityEditor.EditorGUILayout.LabelField("类型", GUILayout.Width(100));
    __e1.TypeIndex = UnityEditor.EditorGUILayout.Popup(__e1.TypeIndex, __list2, GUILayout.Width(200));
    UnityEditor.EditorGUILayout.EndHorizontal();
    __e1.Instance.Render();
    UnityEditor.EditorGUILayout.EndVertical();
};
        this.services[__i1] = __e1;
        UnityEditor.EditorGUILayout.EndHorizontal();
    }
    UnityEditor.EditorGUILayout.BeginHorizontal();
    if (GUILayout.Button("+", GUILayout.Width(20)))
    {
        this.services.Add(new ai.UeSetDefaultFocus(){ TypeIndex = 0});
    }
    if (GUILayout.Button("import", GUILayout.Width(100)))
    {
        ConfigEditorImportWindow.Open((__importJsonText1) => 
        {
            var __importJson1 = SimpleJSON.JSON.Parse(__importJsonText1);
            ai.Service __importElement1;
            
if (!__importJson1.IsObject)
{
    throw new SerializationException();
}
__importElement1 = editor.cfg.ai.Service.LoadJsonService(__importJson1);
var __index2 = editor.cfg.ai.Service.Types.IndexOf(__importElement1.GetTypeStr());
if (__index2 == -1)
{
    throw new SerializationException();
}
__importElement1.TypeIndex = __index2;
__importElement1.Instance = editor.cfg.ai.Service.LoadJsonService(__importJson1);
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
this.waitTime = UnityEditor.EditorGUILayout.FloatField(this.waitTime, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("random_deviation", "random_deviation"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("random_deviation", ""), GUILayout.Width(100));
}
this.randomDeviation = UnityEditor.EditorGUILayout.FloatField(this.randomDeviation, GUILayout.Width(150));
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

    public float waitTime;
    public float randomDeviation;

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

