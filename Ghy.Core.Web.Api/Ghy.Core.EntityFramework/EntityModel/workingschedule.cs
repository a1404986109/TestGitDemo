using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///排班表
    ///</summary>
    public partial class workingschedule
    {
           public workingschedule(){


           }
           /// <summary>
           /// Desc:排班表id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Id {get;set;}

           /// <summary>
           /// Desc:员工id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int userId {get;set;}

           /// <summary>
           /// Desc:所属班次
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int scheduleId {get;set;}

           /// <summary>
           /// Desc:部门id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int deptId {get;set;}

           /// <summary>
           /// Desc:标准上班时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? woringStartTime {get;set;}

           /// <summary>
           /// Desc:标准下班时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? woringEndTime {get;set;}

           /// <summary>
           /// Desc:排班日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? workingDate {get;set;}

    }
}
