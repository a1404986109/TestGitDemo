using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///巡检点配置表
    ///</summary>
    public partial class inspectpoint
    {
           public inspectpoint(){


           }
           /// <summary>
           /// Desc:ID，自增
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:巡检点名称
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string inspectpointname {get;set;}

           /// <summary>
           /// Desc:巡检点描述
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public string inspectpointdescription {get;set;}

           /// <summary>
           /// Desc:巡检点标准模板ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int inspecttemplet_id {get;set;}

           /// <summary>
           /// Desc:巡检点编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string inspectpointcode {get;set;}

           /// <summary>
           /// Desc:设备编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string devicecode {get;set;}

           /// <summary>
           /// Desc:巡检点状态，1为启用，0为停用
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int state {get;set;}

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
           /// Desc:创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime createtime {get;set;}

    }
}
