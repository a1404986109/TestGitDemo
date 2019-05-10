using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///资产巡检主表
    ///</summary>
    public partial class assetsinspectsheet
    {
           public assetsinspectsheet(){


           }
           /// <summary>
           /// Desc:ID，自增
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:资产巡检等级
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string assetssheetlevel {get;set;}

           /// <summary>
           /// Desc:资产巡检类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string assetssheettype {get;set;}

           /// <summary>
           /// Desc:资产巡检编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string number {get;set;}

           /// <summary>
           /// Desc:资产巡检名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string name {get;set;}

           /// <summary>
           /// Desc:资产巡检描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string description {get;set;}

           /// <summary>
           /// Desc:资产巡检创建人编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string createcode {get;set;}

           /// <summary>
           /// Desc:资产巡检创建人姓名
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string createname {get;set;}

           /// <summary>
           /// Desc:资产巡检来源
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string from {get;set;}

           /// <summary>
           /// Desc:资产巡检任务ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int task_id {get;set;}

           /// <summary>
           /// Desc:部门ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int department_id {get;set;}

           /// <summary>
           /// Desc:循环天数
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
           /// Desc:任务接收人编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string receivepersoncode {get;set;}

           /// <summary>
           /// Desc:任务接收人姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string recevicepersonname {get;set;}

           /// <summary>
           /// Desc:计划完成时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? planfinishtime {get;set;}

           /// <summary>
           /// Desc:实际完成时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? completetime {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime createtime {get;set;}

           /// <summary>
           /// Desc:变更时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime changetime {get;set;}

    }
}
