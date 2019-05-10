using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///维保巡检点
    ///</summary>
    public partial class checkpoint
    {
           public checkpoint(){


           }
           /// <summary>
           /// Desc:ID，自增
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:巡检点编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string code {get;set;}

           /// <summary>
           /// Desc:启用状态，0为停用，1为启用
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public int state {get;set;}

           /// <summary>
           /// Desc:关联设备ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string relate_device {get;set;}

           /// <summary>
           /// Desc:巡检点名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string name {get;set;}

           /// <summary>
           /// Desc:巡检点描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string description {get;set;}

           /// <summary>
           /// Desc:创建人编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string creater {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime create_time {get;set;}

           /// <summary>
           /// Desc:可以使用设备Code指定为该检查点的Code
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string device_code {get;set;}

    }
}
