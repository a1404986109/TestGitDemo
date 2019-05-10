using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///报修工单
    ///</summary>
    public partial class repairsheet
    {
           public repairsheet(){


           }
           /// <summary>
           /// Desc:ID，自增
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:报修工单编号
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public string number {get;set;}

           /// <summary>
           /// Desc:设备编号
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public string devicecode {get;set;}

           /// <summary>
           /// Desc:设备名称
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public string devicename {get;set;}

           /// <summary>
           /// Desc:设备区域
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public string areaname {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string remark {get;set;}

           /// <summary>
           /// Desc:图片附件
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string attachment {get;set;}

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
           /// Desc:创建人电话
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public string createrphone {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime createtime {get;set;}

           /// <summary>
           /// Desc:工单状态，包括未处理、进行中、已完成、已拒绝
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string state {get;set;}

           /// <summary>
           /// Desc:拒绝原因
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string reason {get;set;}

           /// <summary>
           /// Desc:关联维修工单ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? sheet_id {get;set;}

           /// <summary>
           /// Desc:关联维修工单编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string sheet_number {get;set;}

           /// <summary>
           /// Desc:处理人编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string managercode {get;set;}

           /// <summary>
           /// Desc:处理人姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string managername {get;set;}

           /// <summary>
           /// Desc:处理时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? managetime {get;set;}

    }
}
