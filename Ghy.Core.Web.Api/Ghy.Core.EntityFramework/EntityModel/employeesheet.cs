using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///考勤打卡记录表
    ///</summary>
    public partial class employeesheet
    {
           public employeesheet(){


           }
           /// <summary>
           /// Desc:主键id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:员工id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int userid {get;set;}

           /// <summary>
           /// Desc:排班id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int workingscheduleid {get;set;}

           /// <summary>
           /// Desc:打卡时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? startTimeclock {get;set;}

           /// <summary>
           /// Desc:打卡状态
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string TimeclockType {get;set;}

           /// <summary>
           /// Desc:0:上班,1:下班,2:旷工
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int isWorking {get;set;}

    }
}
