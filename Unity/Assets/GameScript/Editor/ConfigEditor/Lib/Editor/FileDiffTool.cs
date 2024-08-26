using UnityEditor;
using UnityEngine;
using DiffPlex;
using DiffPlex.DiffBuilder;
using DiffPlex.DiffBuilder.Model;
using System.IO;
using System;

public class FileDiffTool : EditorWindow
{
    private string _text1;
    private string _text2;
    private string _title;
    private DiffPaneModel _diff;
    private GUIStyle _textStyle;

    public static void ShowWindow(string text1, string text2, string title = "")
    {
        var window = GetWindow<FileDiffTool>(string.IsNullOrEmpty(title) ? "差异" : title);
        window._text1 = text1 ?? "";
        window._text2 = text2 ?? "";
        window._title = title;
        window.HandleDiff();
        window.Show();
    }

    private void Awake()
    {
        _textStyle = new GUIStyle();
        _textStyle.richText = true;
        // 默认字体颜色
        _textStyle.normal.textColor = Color.white;
    }

    public void HandleDiff()
    {
        var diffBuilder = new InlineDiffBuilder(new Differ());
        var diff = diffBuilder.BuildDiffModel(_text1, _text2);
        _diff = diff;
    }

    private Vector2 _scollPos;
    private void OnGUI()
    {
        EditorGUILayout.LabelField(_title, EditorStyles.boldLabel);

        _scollPos = EditorGUILayout.BeginScrollView(_scollPos);
        foreach (var line in _diff.Lines)
        {
            var text = "";
            if (line.Position.HasValue)
            {
                text += $"<color=#FFFFFF>{line.Position.Value}</color>";
            }
            text += "\t";
            switch (line.Type)
            {
                case ChangeType.Inserted:
                    GUI.color = Color.green;
                    GUI.contentColor = Color.green;
                    text += "+\t";
                    break;
                case ChangeType.Deleted:
                    GUI.color = Color.red;
                    GUI.contentColor = Color.red;
                    text += "-\t";
                    break;
                default:
                    GUI.color = Color.white;
                    GUI.contentColor = Color.white;
                    text += " \t";
                    break;
            }
            text += line.Text;
            // 显示富文本
            EditorGUILayout.LabelField(text, _textStyle);
        }
        EditorGUILayout.EndScrollView();
    }
}