using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///角色关联菜单表
    ///</summary>
    public partial class rolemenu
    {
           public rolemenu(){


           }
           /// <summary>
           /// Desc:主键id,自增
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:角色Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int roleid {get;set;}

           /// <summary>
           /// Desc:菜单id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int menid {get;set;}

    }
}
