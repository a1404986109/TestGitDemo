using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///流媒体服务器
    ///</summary>
    public partial class streamserver
    {
           public streamserver(){


           }
           /// <summary>
           /// Desc:ID，自增
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:服务器名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string servername {get;set;}

           /// <summary>
           /// Desc:服务器IP
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string serverip {get;set;}

           /// <summary>
           /// Desc:服务器用户名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string serveruser {get;set;}

           /// <summary>
           /// Desc:服务器密码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string serverpassword {get;set;}

           /// <summary>
           /// Desc:服务器端口
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string serverport {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime createtime {get;set;}

    }
}
