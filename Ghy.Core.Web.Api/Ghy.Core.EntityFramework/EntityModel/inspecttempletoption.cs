using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///巡检任务检查项子表
    ///</summary>
    public partial class inspecttempletoption
    {
           public inspecttempletoption(){


           }
           /// <summary>
           /// Desc:ID，自增
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:巡检检查项主表ID
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int inspecttemplet_id {get;set;}

           /// <summary>
           /// Desc:检查项明细
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string option {get;set;}

    }
}
