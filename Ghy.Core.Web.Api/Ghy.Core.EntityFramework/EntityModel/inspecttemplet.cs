using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///巡检任务检查项主表
    ///</summary>
    public partial class inspecttemplet
    {
           public inspecttemplet(){


           }
           /// <summary>
           /// Desc:ID，自增
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:模板名称
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string templetname {get;set;}

           /// <summary>
           /// Desc:模板描述
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public string templetdescription {get;set;}

           /// <summary>
           /// Desc:模板状态，1为启用，0为停用
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int state {get;set;}

           /// <summary>
           /// Desc:创建人编码
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string creatercode {get;set;}

           /// <summary>
           /// Desc:创建人姓名
           /// Default:0
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
