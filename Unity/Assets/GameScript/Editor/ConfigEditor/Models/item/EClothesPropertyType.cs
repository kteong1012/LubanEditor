
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace editor.cfg.item
{
    public enum EClothesPropertyType
    {
        /// <summary>
        /// 简约
        /// </summary>
        JIAN_YUE = 1,
        /// <summary>
        /// 华丽
        /// </summary>
        HUA_LI = 2,
        /// <summary>
        /// 可爱
        /// </summary>
        KE_AI = 3,
        /// <summary>
        /// 成熟
        /// </summary>
        CHENG_SHU = 4,
        /// <summary>
        /// 活泼
        /// </summary>
        HUO_PO = 5,
        /// <summary>
        /// 优雅
        /// </summary>
        YOU_YA = 6,
        /// <summary>
        /// 清纯
        /// </summary>
        QING_CHUN = 7,
        /// <summary>
        /// 性感
        /// </summary>
        XING_GAN = 8,
        /// <summary>
        /// 清凉
        /// </summary>
        QING_LIANG = 9,
        /// <summary>
        /// 保暖
        /// </summary>
        BAO_NUAN = 10,
    }

    public enum EClothesPropertyType_Alias
    {
        简约 = 1,
        华丽 = 2,
        可爱 = 3,
        成熟 = 4,
        活泼 = 5,
        优雅 = 6,
        清纯 = 7,
        性感 = 8,
        清凉 = 9,
        保暖 = 10,
    }

    public static class EClothesPropertyType_Metadata
    {
        public static readonly Luban.EditorEnumItemInfo JIAN_YUE = new Luban.EditorEnumItemInfo("JIAN_YUE", "简约", 1, "简约");
        public static readonly Luban.EditorEnumItemInfo HUA_LI = new Luban.EditorEnumItemInfo("HUA_LI", "华丽", 2, "华丽");
        public static readonly Luban.EditorEnumItemInfo KE_AI = new Luban.EditorEnumItemInfo("KE_AI", "可爱", 3, "可爱");
        public static readonly Luban.EditorEnumItemInfo CHENG_SHU = new Luban.EditorEnumItemInfo("CHENG_SHU", "成熟", 4, "成熟");
        public static readonly Luban.EditorEnumItemInfo HUO_PO = new Luban.EditorEnumItemInfo("HUO_PO", "活泼", 5, "活泼");
        public static readonly Luban.EditorEnumItemInfo YOU_YA = new Luban.EditorEnumItemInfo("YOU_YA", "优雅", 6, "优雅");
        public static readonly Luban.EditorEnumItemInfo QING_CHUN = new Luban.EditorEnumItemInfo("QING_CHUN", "清纯", 7, "清纯");
        public static readonly Luban.EditorEnumItemInfo XING_GAN = new Luban.EditorEnumItemInfo("XING_GAN", "性感", 8, "性感");
        public static readonly Luban.EditorEnumItemInfo QING_LIANG = new Luban.EditorEnumItemInfo("QING_LIANG", "清凉", 9, "清凉");
        public static readonly Luban.EditorEnumItemInfo BAO_NUAN = new Luban.EditorEnumItemInfo("BAO_NUAN", "保暖", 10, "保暖");

        private static readonly System.Collections.Generic.List<Luban.EditorEnumItemInfo> __items = new System.Collections.Generic.List<Luban.EditorEnumItemInfo>
        {
            JIAN_YUE,
            HUA_LI,
            KE_AI,
            CHENG_SHU,
            HUO_PO,
            YOU_YA,
            QING_CHUN,
            XING_GAN,
            QING_LIANG,
            BAO_NUAN,
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

