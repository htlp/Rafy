﻿/*******************************************************
 * 
 * 作者：胡庆访
 * 创建日期：20130830
 * 运行环境：.NET 4.0
 * 版本号：1.0.0
 * 
 * 历史记录：
 * 创建文件 胡庆访 20130830 14:57
 * 
*******************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rafy.MetaModel;
using Rafy.MetaModel.View;

namespace JXC.WPF.ViewConfig
{
    public class JXCEntityConfig : WPFViewConfig<JXCEntity>
    {
        protected override void ConfigView()
        {
            View.UseDetailLayoutMode(DetailLayoutMode.AutoGrid);
        }
    }
}