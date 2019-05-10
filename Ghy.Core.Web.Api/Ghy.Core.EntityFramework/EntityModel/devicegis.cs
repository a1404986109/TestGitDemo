using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///设备GIS表
    ///</summary>
    public partial class devicegis
    {
           public devicegis(){


           }
           /// <summary>
           /// Desc:ID，自增
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Id {get;set;}

           /// <summary>
           /// Desc:设备ID
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int device_id {get;set;}

           /// <summary>
           /// Desc:设备类型
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public string gis_devicetype {get;set;}

           /// <summary>
           /// Desc:经度
           /// Default:0.0000000
           /// Nullable:True
           /// </summary>           
           public decimal? lat {get;set;}

           /// <summary>
           /// Desc:纬度
           /// Default:0.0000000
           /// Nullable:True
           /// </summary>           
           public decimal? lng {get;set;}

           /// <summary>
           /// Desc:区域
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string gis_area {get;set;}

           /// <summary>
           /// Desc:楼层
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public string gis_layer {get;set;}

    }
}
