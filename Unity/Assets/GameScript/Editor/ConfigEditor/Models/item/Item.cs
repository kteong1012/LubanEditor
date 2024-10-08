
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

namespace editor.cfg.item
{

/// <summary>
/// 道具
/// </summary>
public sealed class Item :  Luban.EditorBeanBase 
{
    public Item()
    {
            name = "";
            majorType = editor.cfg.item.EMajorType.CURRENCY;
            minorType = editor.cfg.item.EMinorType.DIAMOND;
            quality = editor.cfg.item.EItemQuality.WHITE;
            icon = "";
            iconBackgroud = "";
            iconMask = "";
            desc = "";
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
            var _fieldJson = _json["major_type"];
            if (_fieldJson != null)
            {
                if(_fieldJson.IsString) { majorType = (editor.cfg.item.EMajorType)System.Enum.Parse(typeof(editor.cfg.item.EMajorType), _fieldJson); } else if(_fieldJson.IsNumber) { majorType = (editor.cfg.item.EMajorType)(int)_fieldJson; } else { throw new SerializationException(); }  
            }
            else
            {
                majorType = editor.cfg.item.EMajorType.CURRENCY;
            }
        }
        
        { 
            var _fieldJson = _json["minor_type"];
            if (_fieldJson != null)
            {
                if(_fieldJson.IsString) { minorType = (editor.cfg.item.EMinorType)System.Enum.Parse(typeof(editor.cfg.item.EMinorType), _fieldJson); } else if(_fieldJson.IsNumber) { minorType = (editor.cfg.item.EMinorType)(int)_fieldJson; } else { throw new SerializationException(); }  
            }
            else
            {
                minorType = editor.cfg.item.EMinorType.DIAMOND;
            }
        }
        
        { 
            var _fieldJson = _json["max_pile_num"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  maxPileNum = _fieldJson;
            }
            else
            {
                maxPileNum = 0;
            }
        }
        
        { 
            var _fieldJson = _json["quality"];
            if (_fieldJson != null)
            {
                if(_fieldJson.IsString) { quality = (editor.cfg.item.EItemQuality)System.Enum.Parse(typeof(editor.cfg.item.EItemQuality), _fieldJson); } else if(_fieldJson.IsNumber) { quality = (editor.cfg.item.EItemQuality)(int)_fieldJson; } else { throw new SerializationException(); }  
            }
            else
            {
                quality = editor.cfg.item.EItemQuality.WHITE;
            }
        }
        
        { 
            var _fieldJson = _json["icon"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  icon = _fieldJson;
            }
            else
            {
                icon = "";
            }
        }
        
        { 
            var _fieldJson = _json["icon_backgroud"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  iconBackgroud = _fieldJson;
            }
            else
            {
                iconBackgroud = "";
            }
        }
        
        { 
            var _fieldJson = _json["icon_mask"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  iconMask = _fieldJson;
            }
            else
            {
                iconMask = "";
            }
        }
        
        { 
            var _fieldJson = _json["desc"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  desc = _fieldJson;
            }
            else
            {
                desc = "";
            }
        }
        
        { 
            var _fieldJson = _json["show_order"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  showOrder = _fieldJson;
            }
            else
            {
                showOrder = 0;
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
        {
            _json["major_type"] = new JSONNumber((int)majorType);
        }
        {
            _json["minor_type"] = new JSONNumber((int)minorType);
        }
        {
            _json["max_pile_num"] = new JSONNumber(maxPileNum);
        }
        {
            _json["quality"] = new JSONNumber((int)quality);
        }

        if (icon != null)
        {
            _json["icon"] = new JSONString(icon);
        }

        if (iconBackgroud != null)
        {
            _json["icon_backgroud"] = new JSONString(iconBackgroud);
        }

        if (iconMask != null)
        {
            _json["icon_mask"] = new JSONString(iconMask);
        }

        if (desc != null)
        {
            _json["desc"] = new JSONString(desc);
        }
        {
            _json["show_order"] = new JSONNumber(showOrder);
        }
    }

    private static GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);

    public static void RenderItem(Item obj)
    {
        obj.Render();
    }

    public override void Render()
    {
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("道具id", "id"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("id", "道具id"), GUILayout.Width(100));
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
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("major_type", "major_type"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("major_type", ""), GUILayout.Width(100));
}
{
    if (ConfigEditorSettings.showComment)
    {
        var __index1 = (int)this.majorType;
        var __alias1 = (item.EMajorType_Alias)this.majorType;
        __alias1 = (item.EMajorType_Alias)UnityEditor.EditorGUILayout.EnumPopup(__alias1, GUILayout.Width(150));
        var __item1 = item.EMajorType_Metadata.GetByNameOrAlias(__alias1.ToString());
        this.majorType = (editor.cfg.item.EMajorType)__item1.Value;
    }
    else
    {
        this.majorType = (editor.cfg.item.EMajorType)UnityEditor.EditorGUILayout.EnumPopup(this.majorType, GUILayout.Width(150));
    }
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("minor_type", "minor_type"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("minor_type", ""), GUILayout.Width(100));
}
{
    if (ConfigEditorSettings.showComment)
    {
        var __index1 = (int)this.minorType;
        var __alias1 = (item.EMinorType_Alias)this.minorType;
        __alias1 = (item.EMinorType_Alias)UnityEditor.EditorGUILayout.EnumPopup(__alias1, GUILayout.Width(150));
        var __item1 = item.EMinorType_Metadata.GetByNameOrAlias(__alias1.ToString());
        this.minorType = (editor.cfg.item.EMinorType)__item1.Value;
    }
    else
    {
        this.minorType = (editor.cfg.item.EMinorType)UnityEditor.EditorGUILayout.EnumPopup(this.minorType, GUILayout.Width(150));
    }
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("max_pile_num", "max_pile_num"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("max_pile_num", ""), GUILayout.Width(100));
}
this.maxPileNum = UnityEditor.EditorGUILayout.IntField(this.maxPileNum, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("quality", "quality"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("quality", ""), GUILayout.Width(100));
}
{
    if (ConfigEditorSettings.showComment)
    {
        var __index1 = (int)this.quality;
        var __alias1 = (item.EItemQuality_Alias)this.quality;
        __alias1 = (item.EItemQuality_Alias)UnityEditor.EditorGUILayout.EnumPopup(__alias1, GUILayout.Width(150));
        var __item1 = item.EItemQuality_Metadata.GetByNameOrAlias(__alias1.ToString());
        this.quality = (editor.cfg.item.EItemQuality)__item1.Value;
    }
    else
    {
        this.quality = (editor.cfg.item.EItemQuality)UnityEditor.EditorGUILayout.EnumPopup(this.quality, GUILayout.Width(150));
    }
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("icon", "icon"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("icon", ""), GUILayout.Width(100));
}
this.icon = UnityEditor.EditorGUILayout.TextField(this.icon, GUILayout.Width(150));
if (GUILayout.Button("…", GUILayout.Width(20)))
{
    TextInputWindow.GetTextAsync(this.icon,__x =>this.icon = __x);
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("icon_backgroud", "icon_backgroud"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("icon_backgroud", ""), GUILayout.Width(100));
}
this.iconBackgroud = UnityEditor.EditorGUILayout.TextField(this.iconBackgroud, GUILayout.Width(150));
if (GUILayout.Button("…", GUILayout.Width(20)))
{
    TextInputWindow.GetTextAsync(this.iconBackgroud,__x =>this.iconBackgroud = __x);
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("icon_mask", "icon_mask"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("icon_mask", ""), GUILayout.Width(100));
}
this.iconMask = UnityEditor.EditorGUILayout.TextField(this.iconMask, GUILayout.Width(150));
if (GUILayout.Button("…", GUILayout.Width(20)))
{
    TextInputWindow.GetTextAsync(this.iconMask,__x =>this.iconMask = __x);
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("desc", "desc"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("desc", ""), GUILayout.Width(100));
}
this.desc = UnityEditor.EditorGUILayout.TextField(this.desc, GUILayout.Width(150));
if (GUILayout.Button("…", GUILayout.Width(20)))
{
    TextInputWindow.GetTextAsync(this.desc,__x =>this.desc = __x);
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("show_order", "show_order"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("show_order", ""), GUILayout.Width(100));
}
this.showOrder = UnityEditor.EditorGUILayout.IntField(this.showOrder, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}    }
    public static Item LoadJsonItem(SimpleJSON.JSONNode _json)
    {
        Item obj = new item.Item();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonItem(Item _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    /// <summary>
    /// 道具id
    /// </summary>
    public int id;
    public string name;
    public editor.cfg.item.EMajorType majorType;
    public editor.cfg.item.EMinorType minorType;
    public int maxPileNum;
    public editor.cfg.item.EItemQuality quality;
    public string icon;
    public string iconBackgroud;
    public string iconMask;
    public string desc;
    public int showOrder;

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "name:" + name + ","
        + "majorType:" + majorType + ","
        + "minorType:" + minorType + ","
        + "maxPileNum:" + maxPileNum + ","
        + "quality:" + quality + ","
        + "icon:" + icon + ","
        + "iconBackgroud:" + iconBackgroud + ","
        + "iconMask:" + iconMask + ","
        + "desc:" + desc + ","
        + "showOrder:" + showOrder + ","
        + "}";
    }
}

}

