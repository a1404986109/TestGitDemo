using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///bim表
    ///</summary>
    public partial class bimface
    {
           public bimface(){


           }
           /// <summary>
           /// Desc:ID，自增
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Id {get;set;}

           /// <summary>
           /// Desc:绑定类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string type {get;set;}

           /// <summary>
           /// Desc:构件ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string element_id {get;set;}

           /// <summary>
           /// Desc:模型ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string model_id {get;set;}

           /// <summary>
           /// Desc:其他参数
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string options {get;set;}

    }
}
