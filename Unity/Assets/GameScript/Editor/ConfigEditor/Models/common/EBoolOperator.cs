
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace editor.cfg.common
{
    public enum EBoolOperator
    {
        AND = 0,
        OR = 1,
    }

    public static class EBoolOperator_Metadata
    {
        public static readonly Luban.EditorEnumItemInfo AND = new Luban.EditorEnumItemInfo("AND", "", 0, "");
        public static readonly Luban.EditorEnumItemInfo OR = new Luban.EditorEnumItemInfo("OR", "", 1, "");

        private static readonly System.Collections.Generic.List<Luban.EditorEnumItemInfo> __items = new System.Collections.Generic.List<Luban.EditorEnumItemInfo>
        {
            AND,
            OR,
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

