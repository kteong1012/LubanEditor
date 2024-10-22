
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace editor.cfg.item
{
    public enum EUseType
    {
        /// <summary>
        /// 手动
        /// </summary>
        MANUAL = 0,
        /// <summary>
        /// 自动
        /// </summary>
        AUTO = 1,
    }

    public enum EUseType_Alias
    {
        手动 = 0,
        自动 = 1,
    }

    public static class EUseType_Metadata
    {
        public static readonly Luban.EditorEnumItemInfo MANUAL = new Luban.EditorEnumItemInfo("MANUAL", "手动", 0, "手动");
        public static readonly Luban.EditorEnumItemInfo AUTO = new Luban.EditorEnumItemInfo("AUTO", "自动", 1, "自动");

        private static readonly System.Collections.Generic.List<Luban.EditorEnumItemInfo> __items = new System.Collections.Generic.List<Luban.EditorEnumItemInfo>
        {
            MANUAL,
            AUTO,
        };

        public static System.Collections.Generic.List<Luban.EditorEnumItemInfo> GetItems() => __items;

        public static Luban.EditorEnumItemInfo GetByName(string name)
        {
            return __items.Find(c => c.Name == name);
        }

        public static Luban.EditorEnumItemInfo GetByNameOrAlias(string name)
        {
            return __items.Find(c => c.Name == name || c.Alias == name);
        }

        public static Luban.EditorEnumItemInfo GetByValue(int value)
        {
            return __items.Find(c => c.Value == value);
        }
    }

} 

