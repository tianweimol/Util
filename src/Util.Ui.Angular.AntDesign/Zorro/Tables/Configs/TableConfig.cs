﻿using System.Collections.Generic;
using Util.Ui.Configs;
using Util.Ui.Extensions;
using Util.Ui.TagHelpers;

namespace Util.Ui.Zorro.Tables.Configs {
    /// <summary>
    /// 表格配置
    /// </summary>
    public class TableConfig : Config {
        /// <summary>
        /// 初始化表格配置
        /// </summary>
        /// <param name="context">上下文</param>
        public TableConfig( Context context ) : base( context ) {
        }

        /// <summary>
        /// 表格共享键
        /// </summary>
        public const string TableShareKey = "TableShare";

        /// <summary>
        /// 表格标识
        /// </summary>
        public string Id => Context.GetValueFromItems<TableShareConfig>( TableShareKey ).TableId;

        /// <summary>
        /// 标题集合
        /// </summary>
        public List<string> Titles => Context.GetValueFromItems<TableShareConfig>( TableShareKey ).Titles;

        /// <summary>
        /// 是否自动创建行
        /// </summary>
        public bool AutoCreateRow => Context.GetValueFromItems<TableShareConfig>( TableShareKey ).AutoCreateRow;

        /// <summary>
        /// 是否自动创建表头
        /// </summary>
        public bool AutoCreateHead => Context.GetValueFromItems<TableShareConfig>( TableShareKey ).AutoCreateHead;

        /// <summary>
        /// 是否自动创建表头复选框
        /// </summary>
        public bool AutoCreateHeadCheckbox => Context.GetValueFromItems<TableShareConfig>( TableShareKey ).AutoCreateHeadCheckbox;
    }
}