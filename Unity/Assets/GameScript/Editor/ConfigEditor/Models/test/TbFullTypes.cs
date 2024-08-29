
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
    public partial class TbFullTypes : IConfigEditorTable
    {
        private List<editor.cfg.test.DemoType2> _datas = new List<editor.cfg.test.DemoType2>();
        private readonly string _dataFilePath;
        private readonly Dictionary<string, string> _originalDataJsons = new Dictionary<string, string>();
        private string _originalTableJson;

        public bool IsLoaded => _datas.Count > 0;
        private string _name => "TbFullTypes";
        private GUIStyle _areaStyle = new GUIStyle(GUI.skin.button);


        public TbFullTypes(string dataFilePath)
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
                        var data = editor.cfg.test.DemoType2.LoadJsonDemoType2(node.Value);
                        _datas.Add(data);
                        var dataJson = node.Value.ToString(4);
                        data.OriginalDataJson = dataJson;
                        _originalDataJsons.Add(GetId(data), dataJson);
                    }
                }
                else
                {
                    var data = editor.cfg.test.DemoType2.LoadJsonDemoType2(json);
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
                editor.cfg.test.DemoType2.SaveJsonDemoType2(data, json);
                jsonArray.Add(json);
            }
            return jsonArray.ToString(4);
        }

        private string GetDataJson(editor.cfg.test.DemoType2 data)
        {
            var json = new JSONObject();
            editor.cfg.test.DemoType2.SaveJsonDemoType2(data, json);
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
                EditorGUILayout.LabelField($"[{i}]", GUILayout.Width(20));
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
                _datas.Add(new editor.cfg.test.DemoType2());
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
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x4", "x4"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x4", ""), GUILayout.Width(100));
}
__SelectData.x4 = UnityEditor.EditorGUILayout.IntField(__SelectData.x4, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x1", "x1"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x1", ""), GUILayout.Width(100));
}
__SelectData.x1 = UnityEditor.EditorGUILayout.Toggle(__SelectData.x1, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x2", "x2"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x2", ""), GUILayout.Width(100));
}
__SelectData.x2 = (byte)UnityEditor.EditorGUILayout.IntField(__SelectData.x2, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x3", "x3"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x3", ""), GUILayout.Width(100));
}
__SelectData.x3 = (short)UnityEditor.EditorGUILayout.IntField(__SelectData.x3, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x5", "x5"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x5", ""), GUILayout.Width(100));
}
__SelectData.x5 = UnityEditor.EditorGUILayout.LongField(__SelectData.x5, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x6", "x6"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x6", ""), GUILayout.Width(100));
}
__SelectData.x6 = UnityEditor.EditorGUILayout.DoubleField(__SelectData.x6, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x7", "x7"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x7", ""), GUILayout.Width(100));
}
__SelectData.x7 = UnityEditor.EditorGUILayout.DoubleField(__SelectData.x7, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x8_0", "x8_0"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x8_0", ""), GUILayout.Width(100));
}
__SelectData.x80 = (short)UnityEditor.EditorGUILayout.IntField(__SelectData.x80, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x8", "x8"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x8", ""), GUILayout.Width(100));
}
__SelectData.x8 = UnityEditor.EditorGUILayout.IntField(__SelectData.x8, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x9", "x9"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x9", ""), GUILayout.Width(100));
}
__SelectData.x9 = UnityEditor.EditorGUILayout.LongField(__SelectData.x9, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x10", "x10"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x10", ""), GUILayout.Width(100));
}
__SelectData.x10 = UnityEditor.EditorGUILayout.TextField(__SelectData.x10, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x12", "x12"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x12", ""), GUILayout.Width(100));
}
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x1", "x1"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x1", ""), GUILayout.Width(100));
}
__SelectData.x12.x1 = UnityEditor.EditorGUILayout.IntField(__SelectData.x12.x1, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x13", "x13"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x13", ""), GUILayout.Width(100));
}

__SelectData.x13 = (editor.cfg.test.DemoEnum)UnityEditor.EditorGUILayout.EnumPopup(__SelectData.x13, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x14", "x14"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("x14", ""), GUILayout.Width(100));
}
{
    var __list1 = test.DemoDynamic.Types.Select(t => new GUIContent(t)).ToArray();
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    if (__SelectData.x14 == null)
    {
        __SelectData.x14 = new test.DemoD2();
__SelectData.x14.SetChangeAction((__x) => { __SelectData.x14 = __x as test.DemoDynamic; });
        __SelectData.x14.TypeIndex = 0;
    }
    UnityEditor.EditorGUILayout.BeginHorizontal();
    UnityEditor.EditorGUILayout.LabelField("类型", GUILayout.Width(100));
    __SelectData.x14.TypeIndex = UnityEditor.EditorGUILayout.Popup(__SelectData.x14.TypeIndex, __list1, GUILayout.Width(200));
    UnityEditor.EditorGUILayout.EndHorizontal();
    __SelectData.x14?.Render();
    UnityEditor.EditorGUILayout.EndVertical();
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
__SelectData.s1 = UnityEditor.EditorGUILayout.TextField(__SelectData.s1, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("t1", "t1"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("t1", ""), GUILayout.Width(100));
}
__SelectData.t1 = UnityEditor.EditorGUILayout.LongField(__SelectData.t1, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("k1", "k1"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("k1", ""), GUILayout.Width(100));
}
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    int __n1 = __SelectData.k1.Length;
    for (int __i1 = 0; __i1 < __n1; __i1++)
    {
        UnityEditor.EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("-", GUILayout.Width(20)))
        {
            var __list1 = new System.Collections.Generic.List<int>(__SelectData.k1);
            __list1.RemoveAt(__i1);
            __SelectData.k1 = __list1.ToArray();
            UnityEditor.EditorGUILayout.EndHorizontal();
            break;
        }
        UnityEditor.EditorGUILayout.LabelField(__i1.ToString(), GUILayout.Width(20));
        int __e1 = __SelectData.k1[__i1];
        __e1 = UnityEditor.EditorGUILayout.IntField(__e1, GUILayout.Width(150));;
        __SelectData.k1[__i1] = __e1;
        UnityEditor.EditorGUILayout.EndHorizontal();
    }
    UnityEditor.EditorGUILayout.BeginHorizontal();
    if (GUILayout.Button("+", GUILayout.Width(20)))
    {
        var __list1 = new System.Collections.Generic.List<int>(__SelectData.k1);
        __list1.Add(0);
        __SelectData.k1 = __list1.ToArray();
    }
    if (GUILayout.Button("import", GUILayout.Width(100)))
    {
        ConfigEditorImportWindow.Open((__importJsonText1) => 
        {
            var __importJson1 = SimpleJSON.JSON.Parse(__importJsonText1);
            int __importElement1;
            if(!__importJson1.IsNumber) { throw new SerializationException(); }  __importElement1 = __importJson1;
            var __list1 = new System.Collections.Generic.List<int>(__SelectData.k1);
            __list1.Add(__importElement1);
            __SelectData.k1 = __list1.ToArray();
        });
    }
    UnityEditor.EditorGUILayout.EndHorizontal();
    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("k2", "k2"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("k2", ""), GUILayout.Width(100));
}
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    int __n1 = __SelectData.k2.Count;
    for (int __i1 = 0; __i1 < __n1; __i1++)
    {
        UnityEditor.EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("-", GUILayout.Width(20)))
        {
            __SelectData.k2.RemoveAt(__i1);
            UnityEditor.EditorGUILayout.EndHorizontal();
            break;
        }
        UnityEditor.EditorGUILayout.LabelField(__i1.ToString(), GUILayout.Width(20));
        int __e1 = __SelectData.k2[__i1];
        __e1 = UnityEditor.EditorGUILayout.IntField(__e1, GUILayout.Width(150));;
        __SelectData.k2[__i1] = __e1;
        UnityEditor.EditorGUILayout.EndHorizontal();
    }
    UnityEditor.EditorGUILayout.BeginHorizontal();
    if (GUILayout.Button("+", GUILayout.Width(20)))
    {
        __SelectData.k2.Add(0);
    }
    if (GUILayout.Button("import", GUILayout.Width(100)))
    {
        ConfigEditorImportWindow.Open((__importJsonText1) => 
        {
            var __importJson1 = SimpleJSON.JSON.Parse(__importJsonText1);
            int __importElement1;
            if(!__importJson1.IsNumber) { throw new SerializationException(); }  __importElement1 = __importJson1;
            __SelectData.k2.Add(__importElement1);
        });
    }
    UnityEditor.EditorGUILayout.EndHorizontal();
    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("k5", "k5"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("k5", ""), GUILayout.Width(100));
}
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    int __n1 = __SelectData.k5.Count;
    for (int __i1 = 0; __i1 < __n1; __i1++)
    {
        UnityEditor.EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("-", GUILayout.Width(20)))
        {
            __SelectData.k5.RemoveAt(__i1);
            UnityEditor.EditorGUILayout.EndHorizontal();
            break;
        }
        UnityEditor.EditorGUILayout.LabelField(__i1.ToString(), GUILayout.Width(20));
        int __e1 = __SelectData.k5[__i1];
        __e1 = UnityEditor.EditorGUILayout.IntField(__e1, GUILayout.Width(150));;
        __SelectData.k5[__i1] = __e1;
        UnityEditor.EditorGUILayout.EndHorizontal();
    }
    if (GUILayout.Button("+", GUILayout.Width(20)))
    {
        __SelectData.k5.Add(0);
    }
    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("k8", "k8"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("k8", ""), GUILayout.Width(100));
}
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    int __n1 = __SelectData.k8.Count;
    for (int __i1 = 0; __i1 < __n1; __i1++)
    {
        UnityEditor.EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("-", GUILayout.Width(20)))
        {
            __SelectData.k8.RemoveAt(__i1);
            UnityEditor.EditorGUILayout.EndHorizontal();
            break;
        }
        UnityEditor.EditorGUILayout.LabelField(__i1.ToString(), GUILayout.Width(20));
        var __e1 = __SelectData.k8[__i1];
        int __key1 = 0;
        int __value1 = 0;
        if (__e1 == null)
        {
            __e1 = new object[2] { __key1, __value1 };
            __SelectData.k8[__i1] = __e1;
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
        __SelectData.k8.Add(new object[2]);
    }
    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("k9", "k9"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("k9", ""), GUILayout.Width(100));
}
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    int __n1 = __SelectData.k9.Count;
    for (int __i1 = 0; __i1 < __n1; __i1++)
    {
        UnityEditor.EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("-", GUILayout.Width(20)))
        {
            __SelectData.k9.RemoveAt(__i1);
            UnityEditor.EditorGUILayout.EndHorizontal();
            break;
        }
        UnityEditor.EditorGUILayout.LabelField(__i1.ToString(), GUILayout.Width(20));
        editor.cfg.test.DemoE2 __e1 = __SelectData.k9[__i1];
        {
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("y1", "y1"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("y1", ""), GUILayout.Width(100));
}
__e1.y1 = UnityEditor.EditorGUILayout.IntField(__e1.y1, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("y2", "y2"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("y2", ""), GUILayout.Width(100));
}
__e1.y2 = UnityEditor.EditorGUILayout.Toggle(__e1.y2, GUILayout.Width(150));
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
};
        __SelectData.k9[__i1] = __e1;
        UnityEditor.EditorGUILayout.EndHorizontal();
    }
    UnityEditor.EditorGUILayout.BeginHorizontal();
    if (GUILayout.Button("+", GUILayout.Width(20)))
    {
        __SelectData.k9.Add(new editor.cfg.test.DemoE2());
    }
    if (GUILayout.Button("import", GUILayout.Width(100)))
    {
        ConfigEditorImportWindow.Open((__importJsonText1) => 
        {
            var __importJson1 = SimpleJSON.JSON.Parse(__importJsonText1);
            editor.cfg.test.DemoE2 __importElement1;
            if(!__importJson1.IsObject) { throw new SerializationException(); }  __importElement1 = editor.cfg.test.DemoE2.LoadJsonDemoE2(__importJson1);
            __SelectData.k9.Add(__importElement1);
        });
    }
    UnityEditor.EditorGUILayout.EndHorizontal();
    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
if (ConfigEditorSettings.showComment)
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("k15", "k15"), GUILayout.Width(100));
}
else
{
    UnityEditor.EditorGUILayout.LabelField(new UnityEngine.GUIContent("k15", ""), GUILayout.Width(100));
}
{
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    int __n1 = __SelectData.k15.Length;
    for (int __i1 = 0; __i1 < __n1; __i1++)
    {
        UnityEditor.EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("-", GUILayout.Width(20)))
        {
            var __list1 = new System.Collections.Generic.List<editor.cfg.test.DemoDynamic>(__SelectData.k15);
            __list1.RemoveAt(__i1);
            __SelectData.k15 = __list1.ToArray();
            UnityEditor.EditorGUILayout.EndHorizontal();
            break;
        }
        UnityEditor.EditorGUILayout.LabelField(__i1.ToString(), GUILayout.Width(20));
        editor.cfg.test.DemoDynamic __e1 = __SelectData.k15[__i1];
        {
    var __list2 = test.DemoDynamic.Types.Select(t => new GUIContent(t)).ToArray();
    UnityEditor.EditorGUILayout.BeginVertical(_areaStyle);
    if (__e1 == null)
    {
        __e1 = new test.DemoD2();
__e1.SetChangeAction((__x) => { __e1 = __x as test.DemoDynamic; });
        __e1.TypeIndex = 0;
    }
    UnityEditor.EditorGUILayout.BeginHorizontal();
    UnityEditor.EditorGUILayout.LabelField("类型", GUILayout.Width(100));
    __e1.TypeIndex = UnityEditor.EditorGUILayout.Popup(__e1.TypeIndex, __list2, GUILayout.Width(200));
    UnityEditor.EditorGUILayout.EndHorizontal();
    __e1?.Render();
    UnityEditor.EditorGUILayout.EndVertical();
};
        __SelectData.k15[__i1] = __e1;
        UnityEditor.EditorGUILayout.EndHorizontal();
    }
    UnityEditor.EditorGUILayout.BeginHorizontal();
    if (GUILayout.Button("+", GUILayout.Width(20)))
    {
        var __list1 = new System.Collections.Generic.List<editor.cfg.test.DemoDynamic>(__SelectData.k15);
        __list1.Add(new test.DemoD2());
        __SelectData.k15 = __list1.ToArray();
    }
    if (GUILayout.Button("import", GUILayout.Width(100)))
    {
        ConfigEditorImportWindow.Open((__importJsonText1) => 
        {
            var __importJson1 = SimpleJSON.JSON.Parse(__importJsonText1);
            editor.cfg.test.DemoDynamic __importElement1;
            
if (!__importJson1.IsObject)
{
    throw new SerializationException();
}
__importElement1 = editor.cfg.test.DemoDynamic.LoadJsonDemoDynamic(__importJson1, (__newIns2)=>{ __importElement1 = __newIns2 as test.DemoDynamic ; });
var __index2 = editor.cfg.test.DemoDynamic.Types.IndexOf(__importElement1.GetTypeStr());
if (__index2 == -1)
{
    throw new SerializationException();
}
__importElement1.TypeIndex = __index2;
            var __list1 = new System.Collections.Generic.List<editor.cfg.test.DemoDynamic>(__SelectData.k15);
            __list1.Add(__importElement1);
            __SelectData.k15 = __list1.ToArray();
        });
    }
    UnityEditor.EditorGUILayout.EndHorizontal();
    UnityEditor.EditorGUILayout.EndVertical();
}
UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
}            }
            GUILayout.EndScrollView();
            GUILayout.EndVertical();
            GUILayout.EndHorizontal();
        }

        private string GetId(editor.cfg.test.DemoType2 data)
        {
            if (data == null)
            {
                throw new Exception("data is null");
            }
            return data.x4.ToString();
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

        private editor.cfg.test.DemoType2 __SelectData
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

