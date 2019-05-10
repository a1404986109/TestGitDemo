using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///摄像机监控表
    ///</summary>
    public partial class camera
    {
           public camera(){


           }
           /// <summary>
           /// Desc:ID，自增
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Id {get;set;}

           /// <summary>
           /// Desc:分组ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int group_id {get;set;}

           /// <summary>
           /// Desc:摄像机Token
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string camera_token {get;set;}

           /// <summary>
           /// Desc:摄像机参数
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string options {get;set;}

    }
}
