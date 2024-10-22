
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using SimpleJSON;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;




namespace editor.cfg.test
{
    public partial class TbTestString : IConfigEditorTable
    {
        private List<editor.cfg.test.TestString> _datas = new List<editor.cfg.test.TestString>();
        private readonly string _dataFilePath;
        private readonly Dictionary<string, string> _originalDataJsons = new Dictionary<string, string>();
        private string _originalTableJson;

        public bool IsLoaded => _datas.Count > 0;
        private string _name => "TbTestString";
        private GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);


        public TbTestString(string dataFilePath)
        {
            _dataFilePath = dataFilePath;
        }

        public void Load()
        {
            _datas.Clear();
            _originalDataJsons.Clear();

            if (File.Exists(_dataFilePath))
            {
                var jsonText = File.ReadAllText(_dataFilePath);
                var json = JSON.Parse(jsonText);
                if (json.IsArray)
                {
                    foreach (var node in json.AsArray)
                    {
                        var data = editor.cfg.test.TestString.LoadJsonTestString(node.Value);
                        _datas.Add(data);
                        var dataJson = node.Value.ToString(4);
                        data.OriginalDataJson = dataJson;
                        _originalDataJsons.Add(GetId(data), dataJson);
                    }
                }
                else
                {
                    var data = editor.cfg.test.TestString.LoadJsonTestString(json);
                    _datas.Add(data);
                    var dataJson = json.ToString(4);
                    data.OriginalDataJson = dataJson;
                    _originalDataJsons.Add(GetId(data), dataJson);
                }
            }

            _originalTableJson = GetTableJson();
        }

        public void Save()
        {
            for (int i = 0; i < _datas.Count; i++)
            {
                if (string.IsNullOrEmpty(GetId(_datas[i])))
                {
                    EditorUtility.DisplayDialog("提示", $"{_name}表第[{i}]个元素的id为空", "确定");
                    return;
                }
            }
            var ids = new Dictionary<string, List<int>>();
            for (int i = 0; i < _datas.Count; i++)
            {
                var id = GetId(_datas[i]);
                if (!ids.ContainsKey(id))
                {
                    ids.Add(id, new List<int>());
                }
                ids[id].Add(i);
            }
            var repeatIds = ids.Where(pair => pair.Value.Count > 1).Select(pair => pair.Key).ToList();
            if (repeatIds.Count > 0)
            {
                var sb = new StringBuilder();
                foreach (var id in repeatIds)
                {
                    sb.Append($"{id}重复出现在{string.Join(", ", ids[id])}\n");
                }
                EditorUtility.DisplayDialog("提示", $"{_name}表id重复\n{sb}", "确定");
                return;
            }

            var jsonText = GetTableJson();
            File.WriteAllText(_dataFilePath, jsonText);

            _originalDataJsons.Clear();
            foreach (var data in _datas)
            {
                data.OriginalDataJson = GetDataJson(data);
                _originalDataJsons.Add(GetId(data), data.OriginalDataJson);
            }
            _originalTableJson = jsonText;
        }

        private string GetTableJson()
        {
            var jsonArray = new JSONArray();
            foreach (var data in _datas)
            {
                var json = new JSONObject();
                editor.cfg.test.TestString.SaveJsonTestString(data, json);
                jsonArray.Add(json);
            }
            return jsonArray.ToString(4);
        }

        private string GetDataJson(editor.cfg.test.TestString data)
        {
            var json = new JSONObject();
            editor.cfg.test.TestString.SaveJsonTestString(data, json);
            return json.ToString(4);
        }


        private Vector2 _idScrollPos;
        private Vector2 _dataScrollPos;
        private int _selectIndex;
        public void OnGUI()
        {
            GUILayout.BeginHorizontal("Box");
            GUILayout.BeginVertical("Box");
            _idScrollPos = GUILayout.BeginScrollView(_idScrollPos, GUILayout.Width(200));
            for (int i = 0; i < _datas.Count; i++)
            {
                GUILayout.BeginHorizontal();
                if (_selectIndex == i)
                {
                    GUI.color = Color.cyan;
                }
                else
                {
                    GUI.color = Color.white;
                }
                EditorGUILayout.LabelField($"[{i}]", GUILayout.Width(50));
                if (GUILayout.Button(GetId(_datas[i])))
                {
                    _selectIndex = i;
                }
                GUI.color = Color.white;
                GUILayout.EndHorizontal();
            }

            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            if (GUILayout.Button("+", GUILayout.Width(20)))
            {
                _datas.Add(new editor.cfg.test.TestString());
            }
            if (GUILayout.Button("-", GUILayout.Width(20)))
            {
                if (_selectIndex >= 0 && _selectIndex < _datas.Count)
                {
                    _datas.RemoveAt(_selectIndex);
                    if (_selectIndex >= _datas.Count)
                    {
                        _selectIndex = _datas.Count - 1;
                    }
                }
            }
            GUILayout.EndHorizontal();

            GUILayout.EndScrollView();
            GUILayout.EndVertical();
            GUILayout.BeginVertical("Box");
            GUILayout.BeginHorizontal();
            if (GUILayout.Button("复制Json", GUILayout.Width(100)))
            {
                if (__SelectData != null)
                {
                    var text = GetDataJson(__SelectData);
                    GUIUtility.systemCopyBuffer = text;
                    EditorUtility.DisplayDialog("提示", $"已复制到剪切板:\n{text}", "确定");
                }
                else
                {
                    EditorUtility.DisplayDialog("提示", "请选择数据", "确定");
                }
            }
            if (GUILayout.Button("新增拷贝", GUILayout.Width(100)))
            {
                if (__SelectData != null)
                {
                    var text = GetDataJson(__SelectData);
                    var json = JSON.Parse(text);
                    var data = editor.cfg.test.TestString.LoadJsonTestString(json);
                    _selectIndex = _datas.Count;
                    _datas.Add(data);
                }
                else
                {
                    EditorUtility.DisplayDialog("提示", "请选择数据", "确定");
                }
            }
            if (GUILayout.Button("预览差异", GUILayout.Width(100)))
            {
                if (__SelectData != null)
                {
                    var id = GetId(__SelectData);
                    var originalJson = __SelectData.OriginalDataJson ?? "";
                    var newJson = GetDataJson(__SelectData);
                    FileDiffTool.ShowWindow(originalJson, newJson, $"{_name}:{id}");
                }
            }
            if (GUILayout.Button("预览表差异", GUILayout.Width(100)))
            {
                var originalJson = _originalTableJson;
                var newJson = GetTableJson();
                FileDiffTool.ShowWindow(originalJson, newJson, _name);
            }
            GUILayout.EndHorizontal();
            _dataScrollPos = GUILayout.BeginScrollView(_dataScrollPos);
            if (__SelectData != default)
            {
                var renderData = __SelectData;
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
renderData.id = UnityEditor.EditorGUILayout.TextField(renderData.id, GUILayout.Width(150));
if (GUILayout.Button("…", GUILayout.Width(20)))
{
    TextInputWindow.GetTextAsync(renderData.id,__x =>renderData.id = __x);
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("s1", "s1"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("s1", ""), GUILayout.Width(100));
}
renderData.s1 = UnityEditor.EditorGUILayout.TextField(renderData.s1, GUILayout.Width(150));
if (GUILayout.Button("…", GUILayout.Width(20)))
{
    TextInputWindow.GetTextAsync(renderData.s1,__x =>renderData.s1 = __x);
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("s2", "s2"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("s2", ""), GUILayout.Width(100));
}
renderData.s2 = UnityEditor.EditorGUILayout.TextField(renderData.s2, GUILayout.Width(150));
if (GUILayout.Button("…", GUILayout.Width(20)))
{
    TextInputWindow.GetTextAsync(renderData.s2,__x =>renderData.s2 = __x);
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("cs1", "cs1"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("cs1", ""), GUILayout.Width(100));
}
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
renderData.cs1.id = UnityEditor.EditorGUILayout.IntField(renderData.cs1.id, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("s2", "s2"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("s2", ""), GUILayout.Width(100));
}
renderData.cs1.s2 = UnityEditor.EditorGUILayout.TextField(renderData.cs1.s2, GUILayout.Width(150));
if (GUILayout.Button("…", GUILayout.Width(20)))
{
    TextInputWindow.GetTextAsync(renderData.cs1.s2,__x =>renderData.cs1.s2 = __x);
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("s3", "s3"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("s3", ""), GUILayout.Width(100));
}
renderData.cs1.s3 = UnityEditor.EditorGUILayout.TextField(renderData.cs1.s3, GUILayout.Width(150));
if (GUILayout.Button("…", GUILayout.Width(20)))
{
    TextInputWindow.GetTextAsync(renderData.cs1.s3,__x =>renderData.cs1.s3 = __x);
}
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("cs2", "cs2"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("cs2", ""), GUILayout.Width(100));
}
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
renderData.cs2.id = UnityEditor.EditorGUILayout.IntField(renderData.cs2.id, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("s2", "s2"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("s2", ""), GUILayout.Width(100));
}
renderData.cs2.s2 = UnityEditor.EditorGUILayout.TextField(renderData.cs2.s2, GUILayout.Width(150));
if (GUILayout.Button("…", GUILayout.Width(20)))
{
    TextInputWindow.GetTextAsync(renderData.cs2.s2,__x =>renderData.cs2.s2 = __x);
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("s3", "s3"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("s3", ""), GUILayout.Width(100));
}
renderData.cs2.s3 = UnityEditor.EditorGUILayout.TextField(renderData.cs2.s3, GUILayout.Width(150));
if (GUILayout.Button("…", GUILayout.Width(20)))
{
    TextInputWindow.GetTextAsync(renderData.cs2.s3,__x =>renderData.cs2.s3 = __x);
}
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}                //editor.cfg.test.TestString.RenderTestString(__SelectData);
            }
            GUILayout.EndScrollView();
            GUILayout.EndVertical();
            GUILayout.EndHorizontal();
        }

        private string GetId(editor.cfg.test.TestString data)
        {
            if (data == null)
            {
                throw new Exception("data is null");
            }
            return data.id.ToString();
        }

        public void Sort()
        {
            var temp = GetId(__SelectData);
            _datas = _datas.OrderBy(data => Convert.ToInt64(GetId(data))).ToList();
            if (!string.IsNullOrEmpty(temp))
            {
                _selectIndex = _datas.FindIndex(data => GetId(data) == temp);
            }
        }

        public void ResolveRef(Tables tables)
        {
        }

        private editor.cfg.test.TestString __SelectData
        {
            get
            {
                if (_selectIndex >= 0 && _selectIndex < _datas.Count)
                {
                    return _datas[_selectIndex];
                }
                return null;
            }
        }
    }
}

