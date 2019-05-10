using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///自建工单表
    ///</summary>
    public partial class sheet
    {
           public sheet(){


           }
           /// <summary>
           /// Desc:ID，自增
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:工单编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string number {get;set;}

           /// <summary>
           /// Desc:工单分类名称
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string sheettype {get;set;}

           /// <summary>
           /// Desc:工单模板
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string templete {get;set;}

           /// <summary>
           /// Desc:工单模板
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string templeteform {get;set;}

           /// <summary>
           /// Desc:计划完成时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? planfinishtime {get;set;}

           /// <summary>
           /// Desc:工单状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string state {get;set;}

           /// <summary>
           /// Desc:工单等级
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string level {get;set;}

           /// <summary>
           /// Desc:工单督办人员
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string supervisor {get;set;}

           /// <summary>
           /// Desc:工单是否为协同
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int isjoin {get;set;}

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

           /// <summary>
           /// Desc:变更时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime changetime {get;set;}

    }
}
