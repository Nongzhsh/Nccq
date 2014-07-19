﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNCQ.UI.Models.Web.MetroUICSS
{
    public class MucDialogue_CreateOrEdit:IViewComponentModel
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string CssClass { get; set; }
        public string CssStyle { get; set; }

        public string CaptionName { get;set;} // 对话框标题
        public string IconName {get;set;}     // 对话框图标
        public int Width { get; set; }
        public int Height { get; set; }

        public string InnerHtmlContent { get; set; }

        /// <summary>
        /// 设置缺省对话框样式
        /// </summary>
        private void _SetDeafultCssForMetroUICss()
        {
            this.CssClass = "window";
            this.CaptionName="新建业务对象数据";
            this.IconName="icon-grid-view";
            this.CssStyle = "";
        }


    }
}
