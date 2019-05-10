using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///设备扩展表
    ///</summary>
    public partial class device_extend
    {
           public device_extend(){


           }
           /// <summary>
           /// Desc:ID，自增
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Id {get;set;}

           /// <summary>
           /// Desc:设备ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int device_id {get;set;}

           /// <summary>
           /// Desc:参数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string options {get;set;}

    }
}
