using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///巡检工单主表
    ///</summary>
    public partial class inspectsheet
    {
           public inspectsheet(){


           }
           /// <summary>
           /// Desc:ID，自增
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:工单等级
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string sheetlevel {get;set;}

           /// <summary>
           /// Desc:工单类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string sheettype {get;set;}

           /// <summary>
           /// Desc:工单编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string number {get;set;}

           /// <summary>
           /// Desc:巡检任务名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string name {get;set;}

           /// <summary>
           /// Desc:任务描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string description {get;set;}

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
           /// Desc:来源
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string from {get;set;}

           /// <summary>
           /// Desc:关联任务ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int task_id {get;set;}

           /// <summary>
           /// Desc:部门ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? department_id {get;set;}

           /// <summary>
           /// Desc:巡检周期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? cyclenumber {get;set;}

           /// <summary>
           /// Desc:巡检周期单位
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string cycledateunit {get;set;}

           /// <summary>
           /// Desc:工单接收人编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string receivepersoncode {get;set;}

           /// <summary>
           /// Desc:工单接收人姓名
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
           /// Desc:工单创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime createtime {get;set;}

           /// <summary>
           /// Desc:工单变更时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime changetime {get;set;}

    }
}
