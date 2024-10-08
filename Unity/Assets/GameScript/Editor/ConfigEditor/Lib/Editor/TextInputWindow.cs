using UnityEditor;
using UnityEngine;
using System;

public class TextInputWindow : EditorWindow
{
    private string _inputText = "";
    private Action<string> _onComplete;

    public static void GetTextAsync(string text, Action<string> onComplete)
    {
        var window = GetWindow<TextInputWindow>("编辑文本");
        window._inputText = text;
        window._onComplete = onComplete;
        window.Show();
    }

    private void OnGUI()
    {
        GUILayout.Label("请输入文本：", EditorStyles.boldLabel);
        _inputText = EditorGUILayout.TextArea(_inputText, GUILayout.ExpandHeight(true), GUILayout.ExpandWidth(true));

        GUILayout.BeginHorizontal();
        GUILayout.FlexibleSpace(); // 占据剩余空间

        if (GUILayout.Button("确认", GUILayout.Width(100)))
        {
            _onComplete?.Invoke(_inputText);
            Close();
        }

        GUILayout.FlexibleSpace(); // 占据剩余空间
        GUILayout.EndHorizontal();
    }
}
