using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///菜单表
    ///</summary>
    public partial class menu
    {
           public menu(){


           }
           /// <summary>
           /// Desc:主键id,自增
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:父级菜单id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int pid {get;set;}

           /// <summary>
           /// Desc:标题
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string title {get;set;}

           /// <summary>
           /// Desc:路径
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string path {get;set;}

           /// <summary>
           /// Desc:类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string type {get;set;}

           /// <summary>
           /// Desc:状态
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int state {get;set;}

           /// <summary>
           /// Desc:描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string description {get;set;}

           /// <summary>
           /// Desc:1=pc 2=app
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int client_type {get;set;}

    }
}
