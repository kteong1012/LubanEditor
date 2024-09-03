using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luban
{
    public abstract class EditorBeanBase
    {
        public abstract void LoadJson(SimpleJSON.JSONObject json);

        public abstract void SaveJson(SimpleJSON.JSONObject json);

        protected Action<Luban.EditorBeanBase> _setChangeAction;
        public void SetChangeAction(Action<Luban.EditorBeanBase> action) => _setChangeAction = action;
        public string OriginalDataJson { get; set; }
        public abstract void Render();

        public void LoadJsonFile(string file)
        {
            string jsonText = System.IO.File.ReadAllText(file, Encoding.UTF8);
            LoadJson((SimpleJSON.JSONObject)SimpleJSON.JSON.Parse(jsonText));
        }

        public void SaveJsonFile(string file)
        {
            var json = new SimpleJSON.JSONObject();
            SaveJson(json);
            System.IO.File.WriteAllText(file, json.ToString(), System.Text.Encoding.UTF8);
        }
    }
}
