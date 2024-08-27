using editor.cfg;
using System.IO;
using UnityEditor;
using UnityEngine;

public class DemoWindow : EditorWindow
{
    private Tables _editorConfig;
    public Tables EditorConfig
    {
        get
        {
            if (_editorConfig == null)
            {
                _editorConfig = new Tables(GetPath);
            }
            return _editorConfig;
        }
    }

    [MenuItem("Tool/Demo Window")]
    public static void ShowWindow()
    {
        var window = GetWindow<DemoWindow>("Demo Window");
        window.Show();
    }

    private bool _movingTab = false;
    private void OnGUI()
    {
        try
        {
            _movingTab = GUILayout.Toggle(_movingTab, "轮询测试", GUILayout.Width(100));
            EditorConfig.OnGUI();
        }
        catch (System.Exception)
        {
            _movingTab = false;
            throw;
        }
    }

    private void Update()
    {
        if (_movingTab)
        {
            EditorConfig.MoveTab();
        }
    }

    private string GetPath(string tableName)
    {
        var pathDir = "../Config/DataTables/EditorDatas";
        if (File.Exists(Path.Combine(pathDir, tableName + ".json")))
        {
            return Path.Combine(pathDir, tableName + ".json");
        }
        return null;
    }
}
