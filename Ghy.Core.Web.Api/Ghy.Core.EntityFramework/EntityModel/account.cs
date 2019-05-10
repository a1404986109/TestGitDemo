using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///登录账号表
    ///</summary>
    public partial class account
    {
           public account(){


           }
           /// <summary>
           /// Desc:ID，自增
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Id {get;set;}

           /// <summary>
           /// Desc:登录名
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Name {get;set;}

           /// <summary>
           /// Desc:密码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Password {get;set;}

           /// <summary>
           /// Desc:是否启用，1为启用，0为停用
           /// Default:
           /// Nullable:False
           /// </summary>           
           public bool State {get;set;}

           /// <summary>
           /// Desc:创建日期
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime CreateDate {get;set;}

           /// <summary>
           /// Desc:查询数据列表权限，1为仅查看自己的数据,2为仅查看本部门的数据,3为查看所有数据
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int isOnly {get;set;}

    }
}
