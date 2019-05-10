using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///巡检任务－巡检点 中间表
    ///</summary>
    public partial class inspecttask_inspectpoint
    {
           public inspecttask_inspectpoint(){


           }
           /// <summary>
           /// Desc:ID，自增
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:巡检任务ID
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int inspecttask_id {get;set;}

           /// <summary>
           /// Desc:巡检点ID
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int inspectpoint_id {get;set;}

    }
}
