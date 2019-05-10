using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///巡检工单附件表
    ///</summary>
    public partial class inspectsheetpoint_attachment
    {
           public inspectsheetpoint_attachment(){


           }
           /// <summary>
           /// Desc:ID，自增
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:巡检点ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int inspectsheetpoint_id {get;set;}

           /// <summary>
           /// Desc:文件路径
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string fileurl {get;set;}

           /// <summary>
           /// Desc:文件大小
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int filesize {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime createtime {get;set;}

    }
}
