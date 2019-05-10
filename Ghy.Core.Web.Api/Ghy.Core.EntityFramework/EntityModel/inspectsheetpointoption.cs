using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///巡检工单巡检点检查项表
    ///</summary>
    public partial class inspectsheetpointoption
    {
           public inspectsheetpointoption(){


           }
           /// <summary>
           /// Desc:ID，自增
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:巡检点ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int inspectpoint_id {get;set;}

           /// <summary>
           /// Desc:检查项
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string option {get;set;}

           /// <summary>
           /// Desc:检查结果
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? optionresult {get;set;}

           /// <summary>
           /// Desc:检查备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string optionremark {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime createtime {get;set;}

    }
}
