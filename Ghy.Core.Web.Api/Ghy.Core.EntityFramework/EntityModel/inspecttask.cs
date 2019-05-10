using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///巡检任务主表
    ///</summary>
    public partial class inspecttask
    {
           public inspecttask(){


           }
           /// <summary>
           /// Desc:ID，自增
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:巡检任务名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string inspecttaskname {get;set;}

           /// <summary>
           /// Desc:任务类型
           /// Default:巡检任务
           /// Nullable:False
           /// </summary>           
           public string tasktype {get;set;}

           /// <summary>
           /// Desc:任务描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string inspecttaskdescription {get;set;}

           /// <summary>
           /// Desc:部门ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int department_id {get;set;}

           /// <summary>
           /// Desc:巡检任务状态，1为启用，0为停用
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public int state {get;set;}

           /// <summary>
           /// Desc:巡检任务等级
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string tasklevel {get;set;}

           /// <summary>
           /// Desc:任务周期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? cyclenumber {get;set;}

           /// <summary>
           /// Desc:任务周期单位
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
           /// Desc:任务开始时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? taskstarttime {get;set;}

           /// <summary>
           /// Desc:任务结束时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? taskendtime {get;set;}

           /// <summary>
           /// Desc:任务创建人编码
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
