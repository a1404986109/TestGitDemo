using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///部门表
    ///</summary>
    public partial class department
    {
           public department(){


           }
           /// <summary>
           /// Desc:ID，自增
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Id {get;set;}

           /// <summary>
           /// Desc:部门编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Code {get;set;}

           /// <summary>
           /// Desc:部门名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Name {get;set;}

           /// <summary>
           /// Desc:部门父级
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Parent {get;set;}

           /// <summary>
           /// Desc:部门状态
           /// Default:
           /// Nullable:False
           /// </summary>           
           public bool State {get;set;}

           /// <summary>
           /// Desc:部门描述
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Describe {get;set;}

    }
}
