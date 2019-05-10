using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///资产巡检子表
    ///</summary>
    public partial class assesinspectsheetdevices
    {
           public assesinspectsheetdevices(){


           }
           /// <summary>
           /// Desc:ID，自增
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:资产巡检工单ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? assesInspectsheet_id {get;set;}

           /// <summary>
           /// Desc:资产巡检工单编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string sheetnumber {get;set;}

           /// <summary>
           /// Desc:设备编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string device_code {get;set;}

           /// <summary>
           /// Desc:设备名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string device_name {get;set;}

           /// <summary>
           /// Desc:资产巡检工单描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string assesInspectsheet_description {get;set;}

           /// <summary>
           /// Desc:巡检坐标
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? item_lat {get;set;}

           /// <summary>
           /// Desc:巡检坐标
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? item_lng {get;set;}

           /// <summary>
           /// Desc:设备坐标
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? point_lat {get;set;}

           /// <summary>
           /// Desc:设备坐标
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? point_lng {get;set;}

           /// <summary>
           /// Desc:部门ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int department_id {get;set;}

           /// <summary>
           /// Desc:巡检反馈结果
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string feedback {get;set;}

           /// <summary>
           /// Desc:巡检备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string remark {get;set;}

           /// <summary>
           /// Desc:巡检人编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string creatercode {get;set;}

           /// <summary>
           /// Desc:巡检人姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string creatername {get;set;}

           /// <summary>
           /// Desc:完成时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? completetime {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime createtime {get;set;}

    }
}
