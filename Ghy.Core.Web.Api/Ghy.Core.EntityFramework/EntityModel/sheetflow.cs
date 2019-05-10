using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///工单分类流程表
    ///</summary>
    public partial class sheetflow
    {
           public sheetflow(){


           }
           /// <summary>
           /// Desc:ID，自增
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:用户编码
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string usercode {get;set;}

           /// <summary>
           /// Desc:用户姓名
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string username {get;set;}

           /// <summary>
           /// Desc:用户电话
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public string userphone {get;set;}

           /// <summary>
           /// Desc:步骤
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int step {get;set;}

           /// <summary>
           /// Desc:是否为并发
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int isjoin {get;set;}

           /// <summary>
           /// Desc:工单分类ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int sheetcategory_id {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime createtime {get;set;}

    }
}
