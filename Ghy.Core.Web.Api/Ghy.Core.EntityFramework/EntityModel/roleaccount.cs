using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///角色关联账号表
    ///</summary>
    public partial class roleaccount
    {
           public roleaccount(){


           }
           /// <summary>
           /// Desc:主键id,自增
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:账号id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int AccountId {get;set;}

           /// <summary>
           /// Desc:角色id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int roleId {get;set;}

    }
}
