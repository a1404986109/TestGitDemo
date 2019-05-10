using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///摄像机分组
    ///</summary>
    public partial class camera_group
    {
           public camera_group(){


           }
           /// <summary>
           /// Desc:ID，自增
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:分组名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string name {get;set;}

           /// <summary>
           /// Desc:分组父ID
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int pid {get;set;}

    }
}
