using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///自建工单流程附件表
    ///</summary>
    public partial class sheetdetailattachment
    {
           public sheetdetailattachment(){


           }
           /// <summary>
           /// Desc:ID，自增
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:流程ID
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int sheetdetail_id {get;set;}

           /// <summary>
           /// Desc:文件路径
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string filepath {get;set;}

           /// <summary>
           /// Desc:文件大小
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int filesize {get;set;}

           /// <summary>
           /// Desc:文件类型
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string filetype {get;set;}

           /// <summary>
           /// Desc:image为图片，attachment为附件
           /// Default:image
           /// Nullable:False
           /// </summary>           
           public string type {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime createtime {get;set;}

    }
}
