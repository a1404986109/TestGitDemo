using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///巡检工单巡检点表
    ///</summary>
    public partial class inspectsheetpoint
    {
           public inspectsheetpoint(){


           }
           /// <summary>
           /// Desc:ID，自增
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:巡检工单ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? inspectsheet_id {get;set;}

           /// <summary>
           /// Desc:巡检工单编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string sheetnumber {get;set;}

           /// <summary>
           /// Desc:巡检点名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string inspectpoint_name {get;set;}

           /// <summary>
           /// Desc:巡检点描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string inspectpoint_description {get;set;}

           /// <summary>
           /// Desc:巡检点编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string inspectpoint_code {get;set;}

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
           /// Desc:巡检点坐标
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? point_lat {get;set;}

           /// <summary>
           /// Desc:巡检点坐标
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
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string remark {get;set;}

           /// <summary>
           /// Desc:创建人编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string creatercode {get;set;}

           /// <summary>
           /// Desc:创建人姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string creatername {get;set;}

           /// <summary>
           /// Desc:巡检点完成时间
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
