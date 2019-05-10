using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///角色表
    ///</summary>
    public partial class role
    {
           public role(){


           }
           /// <summary>
           /// Desc:角色id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:角色名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string roleName {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime createDate {get;set;}

           /// <summary>
           /// Desc:创建人编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string createCode {get;set;}

           /// <summary>
           /// Desc:创建人姓名
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string createName {get;set;}

           /// <summary>
           /// Desc:更新时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? updateDate {get;set;}

           /// <summary>
           /// Desc:更新人编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string updateCode {get;set;}

           /// <summary>
           /// Desc:更新人性别
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string updateName {get;set;}

           /// <summary>
           /// Desc:描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Describe {get;set;}

    }
}
