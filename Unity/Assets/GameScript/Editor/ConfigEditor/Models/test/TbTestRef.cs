
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
    public partial class TbTestRef : IConfigEditorTable
    {
        private List<editor.cfg.test.TestRef> _datas = new List<editor.cfg.test.TestRef>();
        private readonly string _dataFilePath;
        private readonly Dictionary<string, string> _originalDataJsons = new Dictionary<string, string>();
        private string _originalTableJson;

        public bool IsLoaded => _datas.Count > 0;
        private string _name => "TbTestRef";
        private GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);


        public TbTestRef(string dataFilePath)
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
                        var data = editor.cfg.test.TestRef.LoadJsonTestRef(node.Value);
                        _datas.Add(data);
                        var dataJson = node.Value.ToString(4);
                        data.OriginalDataJson = dataJson;
                        _originalDataJsons.Add(GetId(data), dataJson);
                    }
                }
                else
                {
                    var data = editor.cfg.test.TestRef.LoadJsonTestRef(json);
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
                editor.cfg.test.TestRef.SaveJsonTestRef(data, json);
                jsonArray.Add(json);
            }
            return jsonArray.ToString(4);
        }

        private string GetDataJson(editor.cfg.test.TestRef data)
        {
            var json = new JSONObject();
            editor.cfg.test.TestRef.SaveJsonTestRef(data, json);
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
                _datas.Add(new editor.cfg.test.TestRef());
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
                    var data = editor.cfg.test.TestRef.LoadJsonTestRef(json);
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
renderData.id = UnityEditor.EditorGUILayout.IntField(renderData.id, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x1", "x1"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x1", ""), GUILayout.Width(100));
}
renderData.x1 = UnityEditor.EditorGUILayout.IntField(renderData.x1, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x1_2", "x1_2"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x1_2", ""), GUILayout.Width(100));
}
renderData.x12 = UnityEditor.EditorGUILayout.IntField(renderData.x12, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x2", "x2"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x2", ""), GUILayout.Width(100));
}
renderData.x2 = UnityEditor.EditorGUILayout.IntField(renderData.x2, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x3", "x3"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x3", ""), GUILayout.Width(100));
}
renderData.x3 = UnityEditor.EditorGUILayout.IntField(renderData.x3, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x4", "x4"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x4", ""), GUILayout.Width(100));
}
renderData.x4 = UnityEditor.EditorGUILayout.IntField(renderData.x4, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("a1", "a1"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("a1", ""), GUILayout.Width(100));
}
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    int __n1 = renderData.a1.Length;
    UnityEditor.EditorGUILayout.LabelField("长度: " + __n1.ToString());
    for (int __i1 = 0; __i1 < __n1; __i1++)
    {
        UnityEditor.EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("-", GUILayout.Width(20)))
        {
            var __list1 = new System.Collections.Generic.List<int>(renderData.a1);
            __list1.RemoveAt(__i1);
            renderData.a1 = __list1.ToArray();
            UnityEditor.EditorGUILayout.EndHorizontal();
            break;
        }
        UnityEditor.EditorGUILayout.LabelField(__i1.ToString(), GUILayout.Width(20));
        int __e1 = renderData.a1[__i1];
        __e1 = UnityEditor.EditorGUILayout.IntField(__e1, GUILayout.Width(150));;
        renderData.a1[__i1] = __e1;
        UnityEditor.EditorGUILayout.EndHorizontal();
    }
    UnityEditor.EditorGUILayout.BeginHorizontal();
    if (GUILayout.Button("+", GUILayout.Width(20)))
    {
        var __list1 = new System.Collections.Generic.List<int>(renderData.a1);
        int __e1;
        __e1 = 0;;
        __list1.Add(__e1);
        renderData.a1 = __list1.ToArray();
    }
    if (ConfigEditorSettings.showImportButton && GUILayout.Button("import", GUILayout.Width(100)))
    {
        ConfigEditorImportWindow.Open((__importJsonText1) => 
        {
            var __importJson1 = SimpleJSON.JSON.Parse(__importJsonText1);
            int __importElement1;
            if(!__importJson1.IsNumber) { throw new SerializationException(); }  __importElement1 = __importJson1;
            var __list1 = new System.Collections.Generic.List<int>(renderData.a1);
            __list1.Add(__importElement1);
            renderData.a1 = __list1.ToArray();
        });
    }
    UnityEditor.EditorGUILayout.EndHorizontal();
    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("a2", "a2"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("a2", ""), GUILayout.Width(100));
}
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    int __n1 = renderData.a2.Length;
    UnityEditor.EditorGUILayout.LabelField("长度: " + __n1.ToString());
    for (int __i1 = 0; __i1 < __n1; __i1++)
    {
        UnityEditor.EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("-", GUILayout.Width(20)))
        {
            var __list1 = new System.Collections.Generic.List<int>(renderData.a2);
            __list1.RemoveAt(__i1);
            renderData.a2 = __list1.ToArray();
            UnityEditor.EditorGUILayout.EndHorizontal();
            break;
        }
        UnityEditor.EditorGUILayout.LabelField(__i1.ToString(), GUILayout.Width(20));
        int __e1 = renderData.a2[__i1];
        __e1 = UnityEditor.EditorGUILayout.IntField(__e1, GUILayout.Width(150));;
        renderData.a2[__i1] = __e1;
        UnityEditor.EditorGUILayout.EndHorizontal();
    }
    UnityEditor.EditorGUILayout.BeginHorizontal();
    if (GUILayout.Button("+", GUILayout.Width(20)))
    {
        var __list1 = new System.Collections.Generic.List<int>(renderData.a2);
        int __e1;
        __e1 = 0;;
        __list1.Add(__e1);
        renderData.a2 = __list1.ToArray();
    }
    if (ConfigEditorSettings.showImportButton && GUILayout.Button("import", GUILayout.Width(100)))
    {
        ConfigEditorImportWindow.Open((__importJsonText1) => 
        {
            var __importJson1 = SimpleJSON.JSON.Parse(__importJsonText1);
            int __importElement1;
            if(!__importJson1.IsNumber) { throw new SerializationException(); }  __importElement1 = __importJson1;
            var __list1 = new System.Collections.Generic.List<int>(renderData.a2);
            __list1.Add(__importElement1);
            renderData.a2 = __list1.ToArray();
        });
    }
    UnityEditor.EditorGUILayout.EndHorizontal();
    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("b1", "b1"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("b1", ""), GUILayout.Width(100));
}
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    int __n1 = renderData.b1.Count;
    UnityEditor.EditorGUILayout.LabelField("长度: " + __n1.ToString());
    for (int __i1 = 0; __i1 < __n1; __i1++)
    {
        UnityEditor.EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("-", GUILayout.Width(20)))
        {
            renderData.b1.RemoveAt(__i1);
            UnityEditor.EditorGUILayout.EndHorizontal();
            break;
        }
        UnityEditor.EditorGUILayout.LabelField(__i1.ToString(), GUILayout.Width(20));
        int __e1 = renderData.b1[__i1];
        __e1 = UnityEditor.EditorGUILayout.IntField(__e1, GUILayout.Width(150));;
        renderData.b1[__i1] = __e1;
        UnityEditor.EditorGUILayout.EndHorizontal();
    }
    UnityEditor.EditorGUILayout.BeginHorizontal();
    if (GUILayout.Button("+", GUILayout.Width(20)))
    {
        int __e1;
        __e1 = 0;;
        renderData.b1.Add(__e1);
    }
    if (ConfigEditorSettings.showImportButton && GUILayout.Button("import", GUILayout.Width(100)))
    {
        ConfigEditorImportWindow.Open((__importJsonText1) => 
        {
            var __importJson1 = SimpleJSON.JSON.Parse(__importJsonText1);
            int __importElement1;
            if(!__importJson1.IsNumber) { throw new SerializationException(); }  __importElement1 = __importJson1;
            renderData.b1.Add(__importElement1);
        });
    }
    UnityEditor.EditorGUILayout.EndHorizontal();
    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("b2", "b2"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("b2", ""), GUILayout.Width(100));
}
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    int __n1 = renderData.b2.Count;
    UnityEditor.EditorGUILayout.LabelField("长度: " + __n1.ToString());
    for (int __i1 = 0; __i1 < __n1; __i1++)
    {
        UnityEditor.EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("-", GUILayout.Width(20)))
        {
            renderData.b2.RemoveAt(__i1);
            UnityEditor.EditorGUILayout.EndHorizontal();
            break;
        }
        UnityEditor.EditorGUILayout.LabelField(__i1.ToString(), GUILayout.Width(20));
        int __e1 = renderData.b2[__i1];
        __e1 = UnityEditor.EditorGUILayout.IntField(__e1, GUILayout.Width(150));;
        renderData.b2[__i1] = __e1;
        UnityEditor.EditorGUILayout.EndHorizontal();
    }
    UnityEditor.EditorGUILayout.BeginHorizontal();
    if (GUILayout.Button("+", GUILayout.Width(20)))
    {
        int __e1;
        __e1 = 0;;
        renderData.b2.Add(__e1);
    }
    if (ConfigEditorSettings.showImportButton && GUILayout.Button("import", GUILayout.Width(100)))
    {
        ConfigEditorImportWindow.Open((__importJsonText1) => 
        {
            var __importJson1 = SimpleJSON.JSON.Parse(__importJsonText1);
            int __importElement1;
            if(!__importJson1.IsNumber) { throw new SerializationException(); }  __importElement1 = __importJson1;
            renderData.b2.Add(__importElement1);
        });
    }
    UnityEditor.EditorGUILayout.EndHorizontal();
    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("c1", "c1"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("c1", ""), GUILayout.Width(100));
}
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    int __n1 = renderData.c1.Count;
    UnityEditor.EditorGUILayout.LabelField("长度: " + __n1.ToString());
    for (int __i1 = 0; __i1 < __n1; __i1++)
    {
        UnityEditor.EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("-", GUILayout.Width(20)))
        {
            renderData.c1.RemoveAt(__i1);
            UnityEditor.EditorGUILayout.EndHorizontal();
            break;
        }
        UnityEditor.EditorGUILayout.LabelField(__i1.ToString(), GUILayout.Width(20));
        int __e1 = renderData.c1[__i1];
        __e1 = UnityEditor.EditorGUILayout.IntField(__e1, GUILayout.Width(150));;
        renderData.c1[__i1] = __e1;
        UnityEditor.EditorGUILayout.EndHorizontal();
    }
    UnityEditor.EditorGUILayout.BeginHorizontal();
    if (GUILayout.Button("+", GUILayout.Width(20)))
    {
        int __e1;
        __e1 = 0;;
        renderData.c1.Add(__e1);
    }
    if (ConfigEditorSettings.showImportButton && GUILayout.Button("import", GUILayout.Width(100)))
    {
        ConfigEditorImportWindow.Open((__importJsonText1) => 
        {
            var __importJson1 = SimpleJSON.JSON.Parse(__importJsonText1);
            int __importElement1;
            if(!__importJson1.IsNumber) { throw new SerializationException(); }  __importElement1 = __importJson1;
            renderData.c1.Add(__importElement1);
        });
    }
    UnityEditor.EditorGUILayout.EndHorizontal();
    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("c2", "c2"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("c2", ""), GUILayout.Width(100));
}
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    int __n1 = renderData.c2.Count;
    UnityEditor.EditorGUILayout.LabelField("长度: " + __n1.ToString());
    for (int __i1 = 0; __i1 < __n1; __i1++)
    {
        UnityEditor.EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("-", GUILayout.Width(20)))
        {
            renderData.c2.RemoveAt(__i1);
            UnityEditor.EditorGUILayout.EndHorizontal();
            break;
        }
        UnityEditor.EditorGUILayout.LabelField(__i1.ToString(), GUILayout.Width(20));
        int __e1 = renderData.c2[__i1];
        __e1 = UnityEditor.EditorGUILayout.IntField(__e1, GUILayout.Width(150));;
        renderData.c2[__i1] = __e1;
        UnityEditor.EditorGUILayout.EndHorizontal();
    }
    UnityEditor.EditorGUILayout.BeginHorizontal();
    if (GUILayout.Button("+", GUILayout.Width(20)))
    {
        int __e1;
        __e1 = 0;;
        renderData.c2.Add(__e1);
    }
    if (ConfigEditorSettings.showImportButton && GUILayout.Button("import", GUILayout.Width(100)))
    {
        ConfigEditorImportWindow.Open((__importJsonText1) => 
        {
            var __importJson1 = SimpleJSON.JSON.Parse(__importJsonText1);
            int __importElement1;
            if(!__importJson1.IsNumber) { throw new SerializationException(); }  __importElement1 = __importJson1;
            renderData.c2.Add(__importElement1);
        });
    }
    UnityEditor.EditorGUILayout.EndHorizontal();
    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("d1", "d1"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("d1", ""), GUILayout.Width(100));
}
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    int __n1 = renderData.d1.Count;
    UnityEditor.EditorGUILayout.LabelField("长度: " + __n1.ToString());
    for (int __i1 = 0; __i1 < __n1; __i1++)
    {
        UnityEditor.EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("-", GUILayout.Width(20)))
        {
            renderData.d1.RemoveAt(__i1);
            UnityEditor.EditorGUILayout.EndHorizontal();
            break;
        }
        UnityEditor.EditorGUILayout.LabelField(__i1.ToString(), GUILayout.Width(20));
        var __e1 = renderData.d1[__i1];
        int __key1 = 0;
        int __value1 = 0;
        if (__e1 == null)
        {
            __e1 = new object[2] { __key1, __value1 };
            renderData.d1[__i1] = __e1;
        }
        else
        {
            __key1 = __e1[0] != null ? (int)__e1[0] : default;
            __value1 = __e1[1] != null ? (int)__e1[1] : default;
        }
        __key1 = UnityEditor.EditorGUILayout.IntField(__key1, GUILayout.Width(150));;
        __value1 = UnityEditor.EditorGUILayout.IntField(__value1, GUILayout.Width(150));;
        __e1[0] = __key1;
        __e1[1] = __value1;
        UnityEditor.EditorGUILayout.EndHorizontal();
    }
    if (GUILayout.Button("+", GUILayout.Width(20)))
    {
        renderData.d1.Add(new object[2]);
    }
    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("d2", "d2"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("d2", ""), GUILayout.Width(100));
}
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    int __n1 = renderData.d2.Count;
    UnityEditor.EditorGUILayout.LabelField("长度: " + __n1.ToString());
    for (int __i1 = 0; __i1 < __n1; __i1++)
    {
        UnityEditor.EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("-", GUILayout.Width(20)))
        {
            renderData.d2.RemoveAt(__i1);
            UnityEditor.EditorGUILayout.EndHorizontal();
            break;
        }
        UnityEditor.EditorGUILayout.LabelField(__i1.ToString(), GUILayout.Width(20));
        var __e1 = renderData.d2[__i1];
        int __key1 = 0;
        int __value1 = 0;
        if (__e1 == null)
        {
            __e1 = new object[2] { __key1, __value1 };
            renderData.d2[__i1] = __e1;
        }
        else
        {
            __key1 = __e1[0] != null ? (int)__e1[0] : default;
            __value1 = __e1[1] != null ? (int)__e1[1] : default;
        }
        __key1 = UnityEditor.EditorGUILayout.IntField(__key1, GUILayout.Width(150));;
        __value1 = UnityEditor.EditorGUILayout.IntField(__value1, GUILayout.Width(150));;
        __e1[0] = __key1;
        __e1[1] = __value1;
        UnityEditor.EditorGUILayout.EndHorizontal();
    }
    if (GUILayout.Button("+", GUILayout.Width(20)))
    {
        renderData.d2.Add(new object[2]);
    }
    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("e1", "e1"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("e1", ""), GUILayout.Width(100));
}
renderData.e1 = UnityEditor.EditorGUILayout.IntField(renderData.e1, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("e2", "e2"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("e2", ""), GUILayout.Width(100));
}
renderData.e2 = UnityEditor.EditorGUILayout.LongField(renderData.e2, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("e3", "e3"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("e3", ""), GUILayout.Width(100));
}
renderData.e3 = UnityEditor.EditorGUILayout.TextField(renderData.e3, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("f1", "f1"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("f1", ""), GUILayout.Width(100));
}
renderData.f1 = UnityEditor.EditorGUILayout.IntField(renderData.f1, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("f2", "f2"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("f2", ""), GUILayout.Width(100));
}
renderData.f2 = UnityEditor.EditorGUILayout.LongField(renderData.f2, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("f3", "f3"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("f3", ""), GUILayout.Width(100));
}
renderData.f3 = UnityEditor.EditorGUILayout.TextField(renderData.f3, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("s1", "s1"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("s1", ""), GUILayout.Width(100));
}
{
    if (renderData.s1 == null)
{   
    renderData.s1 = test.RefDynamicBase.Create("RefBean");
}
    test.RefDynamicBase.RenderRefDynamicBase(ref renderData.s1);
}
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}                //editor.cfg.test.TestRef.RenderTestRef(__SelectData);
            }
            GUILayout.EndScrollView();
            GUILayout.EndVertical();
            GUILayout.EndHorizontal();
        }

        private string GetId(editor.cfg.test.TestRef data)
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

        private editor.cfg.test.TestRef __SelectData
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

