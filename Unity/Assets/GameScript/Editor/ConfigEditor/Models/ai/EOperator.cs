
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace editor.cfg.ai
{
    public enum EOperator
    {
        IS_EQUAL_TO = 0,
        IS_NOT_EQUAL_TO = 1,
        IS_LESS_THAN = 2,
        IS_LESS_THAN_OR_EQUAL_TO = 3,
        IS_GREAT_THAN = 4,
        IS_GREAT_THAN_OR_EQUAL_TO = 5,
        CONTAINS = 6,
        NOT_CONTAINS = 7,
    }

    public enum EOperator_Alias
    {
        IS_EQUAL_TO = 0,
        IS_NOT_EQUAL_TO = 1,
        IS_LESS_THAN = 2,
        IS_LESS_THAN_OR_EQUAL_TO = 3,
        IS_GREAT_THAN = 4,
        IS_GREAT_THAN_OR_EQUAL_TO = 5,
        CONTAINS = 6,
        NOT_CONTAINS = 7,
    }

    public static class EOperator_Metadata
    {
        public static readonly Luban.EditorEnumItemInfo IS_EQUAL_TO = new Luban.EditorEnumItemInfo("IS_EQUAL_TO", "", 0, "");
        public static readonly Luban.EditorEnumItemInfo IS_NOT_EQUAL_TO = new Luban.EditorEnumItemInfo("IS_NOT_EQUAL_TO", "", 1, "");
        public static readonly Luban.EditorEnumItemInfo IS_LESS_THAN = new Luban.EditorEnumItemInfo("IS_LESS_THAN", "", 2, "");
        public static readonly Luban.EditorEnumItemInfo IS_LESS_THAN_OR_EQUAL_TO = new Luban.EditorEnumItemInfo("IS_LESS_THAN_OR_EQUAL_TO", "", 3, "");
        public static readonly Luban.EditorEnumItemInfo IS_GREAT_THAN = new Luban.EditorEnumItemInfo("IS_GREAT_THAN", "", 4, "");
        public static readonly Luban.EditorEnumItemInfo IS_GREAT_THAN_OR_EQUAL_TO = new Luban.EditorEnumItemInfo("IS_GREAT_THAN_OR_EQUAL_TO", "", 5, "");
        public static readonly Luban.EditorEnumItemInfo CONTAINS = new Luban.EditorEnumItemInfo("CONTAINS", "", 6, "");
        public static readonly Luban.EditorEnumItemInfo NOT_CONTAINS = new Luban.EditorEnumItemInfo("NOT_CONTAINS", "", 7, "");

        private static readonly System.Collections.Generic.List<Luban.EditorEnumItemInfo> __items = new System.Collections.Generic.List<Luban.EditorEnumItemInfo>
        {
            IS_EQUAL_TO,
            IS_NOT_EQUAL_TO,
            IS_LESS_THAN,
            IS_LESS_THAN_OR_EQUAL_TO,
            IS_GREAT_THAN,
            IS_GREAT_THAN_OR_EQUAL_TO,
            CONTAINS,
            NOT_CONTAINS,
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

