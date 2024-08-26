using editor.cfg;
using System.IO;
using UnityEditor;

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

    private void OnGUI()
    {
        EditorConfig.OnGUI();
    }

    private string GetPath(string tableName)
    {
        var pathDir = "../Config/DataTables/EditorDatas";
        if(File.Exists(Path.Combine(pathDir, tableName + ".json")))
        {
            return Path.Combine(pathDir, tableName + ".json");
        }
        return null;
    }
}
