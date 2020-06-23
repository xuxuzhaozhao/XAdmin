using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using XAdmin.Model.Menu;

namespace XAdmin.API.Controllers.Authority
{
    /// <summary>
    /// 权限相关控制器
    /// </summary>
    [Route("Api/Authority")]
    [ApiController]
    public class XAuthorityController : ControllerBase
    {
        /// <summary>
        /// 获取当前登录用户已授权的菜单权限
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route(nameof(GetAuthorizedMenu))]
        public object GetAuthorizedMenu()
        {
            var authoriedMenu = @"[{
    'ID': 73774,
    '模块名称': '办公自动化',
    '层级': '10',
    '备注': '',
    '是否禁用': 0,
    '模块图标': 'OA',
    '元数据配置': '',
    '请求url': '',
    '模块路径': '',
    '是否自动生成': false,
    '菜单显示': true,
    '存在订单状态': false,
    '字段配置模块': '',
    '图标路径': ''
  },
  {
    'ID': 73934,
    '模块名称': '个人页面',
    '层级': '10,1',
    '备注': '',
    '是否禁用': 0,
    '模块图标': '',
    '元数据配置': '',
    '请求url': '',
    '模块路径': '',
    '是否自动生成': false,
    '菜单显示': true,
    '存在订单状态': false,
    '字段配置模块': '',
    '图标路径': null
  },
  {
    'ID': 73935,
    '模块名称': '个人中心',
    '层级': '10,1,0',
    '备注': '',
    '是否禁用': 0,
    '模块图标': '',
    '元数据配置': '',
    '请求url': '/myhome/personalCenter',
    '模块路径': '',
    '是否自动生成': false,
    '菜单显示': true,
    '存在订单状态': false,
    '字段配置模块': '',
    '图标路径': null
  },
  {
    'ID': 74101,
    '模块名称': '身份证认证',
    '层级': '10,1,0,1',
    '备注': '',
    '是否禁用': 0,
    '模块图标': '',
    '元数据配置': '',
    '请求url': '/Home',
    '模块路径': '',
    '是否自动生成': false,
    '菜单显示': true,
    '存在订单状态': false,
    '字段配置模块': '',
    '图标路径': null
  },
  {
    'ID': 74221,
    '模块名称': '银行卡认证',
    '层级': '10,1,0,2',
    '备注': '',
    '是否禁用': 0,
    '模块图标': '',
    '元数据配置': '',
    '请求url': '/About',
    '模块路径': '',
    '是否自动生成': false,
    '菜单显示': true,
    '存在订单状态': false,
    '字段配置模块': '',
    '图标路径': null
  },
  {
    'ID': 74141,
    '模块名称': '图片编辑',
    '层级': '10,1,0,3',
    '备注': '',
    '是否禁用': 0,
    '模块图标': '',
    '元数据配置': '',
    '请求url': '/myhome/pictureEdit',
    '模块路径': '',
    '是否自动生成': false,
    '菜单显示': true,
    '存在订单状态': false,
    '字段配置模块': '',
    '图标路径': null
  },
  {
    'ID': 74158,
    '模块名称': '我的保障',
    '层级': '10,1,0,4',
    '备注': '',
    '是否禁用': 0,
    '模块图标': '',
    '元数据配置': '',
    '请求url': '/myhome/myGuarantee',
    '模块路径': '',
    '是否自动生成': false,
    '菜单显示': true,
    '存在订单状态': false,
    '字段配置模块': '',
    '图标路径': null
  },
  {
    'ID': 74217,
    '模块名称': '邀请商家',
    '层级': '10,1,0,5',
    '备注': '',
    '是否禁用': 0,
    '模块图标': '',
    '元数据配置': '',
    '请求url': '/myhome/inviteMerchants',
    '模块路径': '',
    '是否自动生成': false,
    '菜单显示': true,
    '存在订单状态': false,
    '字段配置模块': '',
    '图标路径': null
  }]";


            return JsonConvert.DeserializeObject<List<XAutorizedMenu>>(authoriedMenu);
        }
    }
}
