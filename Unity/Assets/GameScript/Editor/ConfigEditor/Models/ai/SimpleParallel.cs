
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

public sealed class SimpleParallel :  ai.ComposeNode 
{
    public SimpleParallel()
    {
            finishMode = editor.cfg.ai.EFinishMode.IMMEDIATE;
    }
    public override string GetTypeStr() => TYPE_STR;
    private const string TYPE_STR = "SimpleParallel";

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
            var _fieldJson = _json["finish_mode"];
            if (_fieldJson != null)
            {
                if(_fieldJson.IsString) { finishMode = (editor.cfg.ai.EFinishMode)System.Enum.Parse(typeof(editor.cfg.ai.EFinishMode), _fieldJson); } else if(_fieldJson.IsNumber) { finishMode = (editor.cfg.ai.EFinishMode)(int)_fieldJson; } else { throw new SerializationException(); }  
            }
            else
            {
                finishMode = editor.cfg.ai.EFinishMode.IMMEDIATE;
            }
        }
        
        { 
            var _fieldJson = _json["main_task"];
            if (_fieldJson != null)
            {
                
                if (!_fieldJson.IsObject)
                {
                    throw new SerializationException();
                }
                mainTask = editor.cfg.ai.Task.LoadJsonTask(_fieldJson);
            }
            else
            {
                mainTask = ai.Task.Create("UeWait");
            }
        }
        
        { 
            var _fieldJson = _json["background_node"];
            if (_fieldJson != null)
            {
                
                if (!_fieldJson.IsObject)
                {
                    throw new SerializationException();
                }
                backgroundNode = editor.cfg.ai.FlowNode.LoadJsonFlowNode(_fieldJson);
            }
            else
            {
                backgroundNode = ai.FlowNode.Create("Sequence");
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
            _json["finish_mode"] = new JSONNumber((int)finishMode);
        }

        if (mainTask != null)
        {
            { var __bjson = new JSONObject();  editor.cfg.ai.Task.SaveJsonTask(mainTask, __bjson); _json["main_task"] = __bjson; }
        }

        if (backgroundNode != null)
        {
            { var __bjson = new JSONObject();  editor.cfg.ai.FlowNode.SaveJsonFlowNode(backgroundNode, __bjson); _json["background_node"] = __bjson; }
        }
    }

    private static GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);

    public static void RenderSimpleParallel(SimpleParallel obj)
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
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("finish_mode", "finish_mode"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("finish_mode", ""), GUILayout.Width(100));
}
{
    if (ConfigEditorSettings.showComment)
    {
        var __index1 = (int)this.finishMode;
        var __alias1 = (ai.EFinishMode_Alias)this.finishMode;
        __alias1 = (ai.EFinishMode_Alias)UnityEditor.EditorGUILayout.EnumPopup(__alias1, GUILayout.Width(150));
        var __item1 = ai.EFinishMode_Metadata.GetByNameOrAlias(__alias1.ToString());
        this.finishMode = (editor.cfg.ai.EFinishMode)__item1.Value;
    }
    else
    {
        this.finishMode = (editor.cfg.ai.EFinishMode)UnityEditor.EditorGUILayout.EnumPopup(this.finishMode, GUILayout.Width(150));
    }
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("main_task", "main_task"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("main_task", ""), GUILayout.Width(100));
}
{
    if (this.mainTask == null)
{   
    this.mainTask = ai.Task.Create("UeWait");
}
    ai.Task.RenderTask(ref this.mainTask);
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("background_node", "background_node"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("background_node", ""), GUILayout.Width(100));
}
{
    if (this.backgroundNode == null)
{   
    this.backgroundNode = ai.FlowNode.Create("Sequence");
}
    ai.FlowNode.RenderFlowNode(ref this.backgroundNode);
}
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}    }
    public static SimpleParallel LoadJsonSimpleParallel(SimpleJSON.JSONNode _json)
    {
        SimpleParallel obj = new ai.SimpleParallel();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonSimpleParallel(SimpleParallel _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public editor.cfg.ai.EFinishMode finishMode;
    public editor.cfg.ai.Task mainTask;
    public editor.cfg.ai.FlowNode backgroundNode;

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "nodeName:" + nodeName + ","
        + "decorators:" + Luban.StringUtil.CollectionToString(decorators) + ","
        + "services:" + Luban.StringUtil.CollectionToString(services) + ","
        + "finishMode:" + finishMode + ","
        + "mainTask:" + mainTask + ","
        + "backgroundNode:" + backgroundNode + ","
        + "}";
    }
}

}

