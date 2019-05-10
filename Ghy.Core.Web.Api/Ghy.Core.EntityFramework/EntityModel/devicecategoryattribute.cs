using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///设备分类扩展属性
    ///</summary>
    public partial class devicecategoryattribute
    {
           public devicecategoryattribute(){


           }
           /// <summary>
           /// Desc:ID，自增
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Id {get;set;}

           /// <summary>
           /// Desc:名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Name {get;set;}

           /// <summary>
           /// Desc:分类ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int DeviceCategoryId {get;set;}

    }
}
