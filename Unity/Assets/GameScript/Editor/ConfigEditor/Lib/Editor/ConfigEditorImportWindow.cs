using System;
using UnityEditor;
using UnityEngine;


public class ConfigEditorImportWindow : EditorWindow
{
    public static void Open(Action<string> onConfirm)
    {
        var window = GetWindow<ConfigEditorImportWindow>();
        window.titleContent = new GUIContent("Json导入配置");
        window.Show();
        window._onConfirm = onConfirm;
    }

    private Action<string> _onConfirm;

    private string _jsonText;
    private Vector2 _scrollPos;

    private void OnGUI()
    {
        _scrollPos = EditorGUILayout.BeginScrollView(_scrollPos);
        DrawIntroduce();
        _jsonText = EditorGUILayout.TextArea(_jsonText, GUILayout.MinHeight(300));
        if (GUILayout.Button("导入"))
        {
            try
            {
                _onConfirm?.Invoke(_jsonText);
            }
            catch (Exception)
            {
                EditorUtility.DisplayDialog("导入失败", "导入失败，请检查json格式", "确定");
                return;
            }
            Close();
        }
        EditorGUILayout.EndScrollView();
    }

    private void DrawIntroduce()
    {
        // 一个多行文本的label，介绍如何导入配置
        GUILayout.Label("导入配置说明：");
        GUILayout.Label("1. 若输入Object类型的json，将会导入1个对象：格式如下");
        GUILayout.TextArea($@"
            {{
                ""id"": 1,
                ""name"": ""test""
                ""array"": [1, 2, 3]
            }}");
        GUILayout.Label("2. 若输入Array类型的json，将会导入多个对象");
        GUILayout.TextArea($@"
            [
                {{
                    ""id"": 1,
                    ""name"": ""test1""
                }},
                {{
                    ""id"": 2,
                    ""name"": ""test2""
                }}
            ]");

    }
}