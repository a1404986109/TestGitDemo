using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///资产巡检子表附件表
    ///</summary>
    public partial class assetsinspectsheetdevices_attachment
    {
           public assetsinspectsheetdevices_attachment(){


           }
           /// <summary>
           /// Desc:ID，自增
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:子表ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int assetsinspectsheetdevicesid {get;set;}

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
