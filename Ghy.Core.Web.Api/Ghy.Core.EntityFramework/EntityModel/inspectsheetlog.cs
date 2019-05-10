using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///巡检工单日志表
    ///</summary>
    public partial class inspectsheetlog
    {
           public inspectsheetlog(){


           }
           /// <summary>
           /// Desc:ID，自增
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:巡检工单ID
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int inspectsheet_id {get;set;}

           /// <summary>
           /// Desc:巡检工单编号
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string sheetnumber {get;set;}

           /// <summary>
           /// Desc:操作
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string action {get;set;}

           /// <summary>
           /// Desc:操作人编码
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string creatercode {get;set;}

           /// <summary>
           /// Desc:操作人姓名
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
