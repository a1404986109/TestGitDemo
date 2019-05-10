using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///班次表
    ///</summary>
    public partial class schedule
    {
           public schedule(){


           }
           /// <summary>
           /// Desc:班次id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Id {get;set;}

           /// <summary>
           /// Desc:班次名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string name {get;set;}

           /// <summary>
           /// Desc:开始上班时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? startTime {get;set;}

           /// <summary>
           /// Desc:下班时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? endTime {get;set;}

           /// <summary>
           /// Desc:班次所属部门
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int scheduleByDept {get;set;}

    }
}
