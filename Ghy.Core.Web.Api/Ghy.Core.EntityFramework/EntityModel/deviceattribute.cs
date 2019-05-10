using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///设备属性
    ///</summary>
    public partial class deviceattribute
    {
           public deviceattribute(){


           }
           /// <summary>
           /// Desc:ID，自增
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Id {get;set;}

           /// <summary>
           /// Desc:属性名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Name {get;set;}

           /// <summary>
           /// Desc:属性值
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Value {get;set;}

           /// <summary>
           /// Desc:设备ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int DeviceId {get;set;}

    }
}
