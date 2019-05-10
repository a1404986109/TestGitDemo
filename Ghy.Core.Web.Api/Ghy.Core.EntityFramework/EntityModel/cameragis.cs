using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///摄像机GIS表
    ///</summary>
    public partial class cameragis
    {
           public cameragis(){


           }
           /// <summary>
           /// Desc:ID，自增
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:摄像机ID
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int camera_id {get;set;}

           /// <summary>
           /// Desc:摄像机坐标
           /// Default:0.0000000
           /// Nullable:True
           /// </summary>           
           public decimal? gis_lat {get;set;}

           /// <summary>
           /// Desc:摄像机坐标
           /// Default:0.0000000
           /// Nullable:True
           /// </summary>           
           public decimal? gis_lng {get;set;}

           /// <summary>
           /// Desc:摄像机区域
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public string gis_area {get;set;}

           /// <summary>
           /// Desc:摄像机楼层
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public string gis_layer {get;set;}

    }
}
