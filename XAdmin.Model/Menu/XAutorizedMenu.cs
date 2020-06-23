/*
*┌────────────────────────────────────────────────┐
*│　描    述：XAutorizedMenu                                                    
*│　作    者：徐程意                                              
*│　版    本：1.0                                              
*│　创建时间：2020/6/23 14:59:02                        
*└────────────────────────────────────────────────┘
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace XAdmin.Model.Menu
{
    public class XAutorizedMenu
    {
        public string 模块名称 { get; set; }
        public string 层级 { get; set; }
        public string 模块图标 { get; set; }
        public string 元数据配置 { get; set; }
        public string 请求url { get; set; }
        public bool 是否自动生成 { get; set; }
        public bool 菜单显示 { get; set; }
        public bool 存在订单状态 { get; set; }
        public string 图标路径 { get; set; }
    }
}
