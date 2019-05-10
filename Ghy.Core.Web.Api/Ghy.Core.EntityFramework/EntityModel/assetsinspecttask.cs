using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///资产巡检任务表
    ///</summary>
    public partial class assetsinspecttask
    {
           public assetsinspecttask(){


           }
           /// <summary>
           /// Desc:ID，自增
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:资产巡检任务名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string assetsinspecttaskname {get;set;}

           /// <summary>
           /// Desc:巡检类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string typetask {get;set;}

           /// <summary>
           /// Desc:资产巡检描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string assetsinspecttaskdescription {get;set;}

           /// <summary>
           /// Desc:部门id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int department_id {get;set;}

           /// <summary>
           /// Desc:任务状态
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int state {get;set;}

           /// <summary>
           /// Desc:任务等级
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string tasklevel {get;set;}

           /// <summary>
           /// Desc:任务关联设备id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string device_Code {get;set;}

           /// <summary>
           /// Desc:循环长度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? cyclenumber {get;set;}

           /// <summary>
           /// Desc:循环周期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string cycledateunit {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? lastworkdate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? nextworkdate {get;set;}

           /// <summary>
           /// Desc:计划开始时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? assetstaskstarttime {get;set;}

           /// <summary>
           /// Desc:计划结束时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? assetstaskendtime {get;set;}

           /// <summary>
           /// Desc:创建人编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string creatercode {get;set;}

           /// <summary>
           /// Desc:创建人姓名
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string creatername {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime createtime {get;set;}

    }
}
