
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
    public partial class TbMultiIndexList : IConfigEditorTable
    {
        private List<test.MultiIndexList> _datas = new List<test.MultiIndexList>();
        private readonly string _dataFilePath;
        private readonly Dictionary<string, string> _originalDataJsons = new Dictionary<string, string>();
        private string _originalTableJson;

        public bool IsLoaded => _datas.Count > 0;
        private string _name => "TbMultiIndexList";


        public TbMultiIndexList(string dataFilePath)
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
                        var data = new test.MultiIndexList();
                        var dataNode = (JSONObject)node;
                        data.LoadJson(dataNode);
                        _datas.Add(data);
                        _originalDataJsons.Add(GetId(data), dataNode.ToString(4));
                    }
                }
                else
                {
                    var data = new test.MultiIndexList();
                    data.LoadJson((JSONObject)json);
                    _datas.Add(data);
                    _originalDataJsons.Add(GetId(data), json.ToString(4));
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

            var jsonText = GetTableJson();
            File.WriteAllText(_dataFilePath, jsonText);

            _originalDataJsons.Clear();
            foreach (var data in _datas)
            {
                _originalDataJsons.Add(GetId(data), GetDataJson(data));
            }
            _originalTableJson = jsonText;
        }

        private string GetTableJson()
        {
            var jsonArray = new JSONArray();
            foreach (var data in _datas)
            {
                var json = new JSONObject();
                data.SaveJson(json);
                jsonArray.Add(json);
            }
            return jsonArray.ToString(4);
        }

        private string GetDataJson(test.MultiIndexList data)
        {
            var json = new JSONObject();
            data?.SaveJson(json);
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
                _datas.Add(new test.MultiIndexList());
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
                if (SelectData != null)
                {
                    var text = GetDataJson(SelectData);
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
                if (SelectData != null)
                {
                    var id = GetId(SelectData);
                    var originalJson = "";
                    var newJson = GetDataJson(SelectData);
                    _originalDataJsons.TryGetValue(id, out originalJson);
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
            SelectData?.Render();
            GUILayout.EndScrollView();
            GUILayout.EndVertical();
            GUILayout.EndHorizontal();
        }

        private string GetId(test.MultiIndexList data)
        {
            if (data == null)
            {
                throw new Exception("data is null");
            }
            return _datas.IndexOf(data).ToString();
        }

        public void Sort()
        {
            var temp = GetId(SelectData);
            _datas = _datas.OrderBy(data => Convert.ToInt64(GetId(data))).ToList();
            if (!string.IsNullOrEmpty(temp))
            {
                _selectIndex = _datas.FindIndex(data => GetId(data) == temp);
            }
        }

        public void ResolveRef(Tables tables)
        {
        }

        private test.MultiIndexList SelectData
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

