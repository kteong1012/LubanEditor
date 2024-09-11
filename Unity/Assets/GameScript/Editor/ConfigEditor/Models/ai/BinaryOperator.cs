
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

public sealed class BinaryOperator :  ai.KeyQueryOperator 
{
    public BinaryOperator()
    {
            oper = editor.cfg.ai.EOperator.IS_EQUAL_TO;
    }
    public override string GetTypeStr() => TYPE_STR;
    private const string TYPE_STR = "BinaryOperator";

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["oper"];
            if (_fieldJson != null)
            {
                if(_fieldJson.IsString) { oper = (editor.cfg.ai.EOperator)System.Enum.Parse(typeof(editor.cfg.ai.EOperator), _fieldJson); } else if(_fieldJson.IsNumber) { oper = (editor.cfg.ai.EOperator)(int)_fieldJson; } else { throw new SerializationException(); }  
            }
            else
            {
                oper = editor.cfg.ai.EOperator.IS_EQUAL_TO;
            }
        }
        
        { 
            var _fieldJson = _json["data"];
            if (_fieldJson != null)
            {
                
                if (!_fieldJson.IsObject)
                {
                    throw new SerializationException();
                }
                data = editor.cfg.ai.KeyData.LoadJsonKeyData(_fieldJson);
            }
            else
            {
                data = ai.KeyData.Create("FloatKeyData");
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            _json["oper"] = new JSONNumber((int)oper);
        }

        if (data != null)
        {
            { var __bjson = new JSONObject();  editor.cfg.ai.KeyData.SaveJsonKeyData(data, __bjson); _json["data"] = __bjson; }
        }
    }

    private static GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);

    public static void RenderBinaryOperator(BinaryOperator obj)
    {
        obj.Render();
    }

    public override void Render()
    {
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("oper", "oper"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("oper", ""), GUILayout.Width(100));
}
{
    if (ConfigEditorSettings.showComment)
    {
        var __index1 = (int)this.oper;
        var __alias1 = (ai.EOperator_Alias)this.oper;
        __alias1 = (ai.EOperator_Alias)UnityEditor.EditorGUILayout.EnumPopup(__alias1, GUILayout.Width(150));
        var __item1 = ai.EOperator_Metadata.GetByNameOrAlias(__alias1.ToString());
        this.oper = (editor.cfg.ai.EOperator)__item1.Value;
    }
    else
    {
        this.oper = (editor.cfg.ai.EOperator)UnityEditor.EditorGUILayout.EnumPopup(this.oper, GUILayout.Width(150));
    }
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("data", "data"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("data", ""), GUILayout.Width(100));
}
{
    if (this.data == null)
{   
    this.data = ai.KeyData.Create("FloatKeyData");
}
    ai.KeyData.RenderKeyData(ref this.data);
}
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}    }
    public static BinaryOperator LoadJsonBinaryOperator(SimpleJSON.JSONNode _json)
    {
        BinaryOperator obj = new ai.BinaryOperator();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonBinaryOperator(BinaryOperator _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public editor.cfg.ai.EOperator oper;
    public editor.cfg.ai.KeyData data;

    public override string ToString()
    {
        return "{ "
        + "oper:" + oper + ","
        + "data:" + data + ","
        + "}";
    }
}

}

