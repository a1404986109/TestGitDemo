using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///自建工单流程表
    ///</summary>
    public partial class sheetdetail
    {
           public sheetdetail(){


           }
           /// <summary>
           /// Desc:ID，自增
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:关联工单ID
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int sheet_id {get;set;}

           /// <summary>
           /// Desc:操作
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string action {get;set;}

           /// <summary>
           /// Desc:流程步骤
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int step {get;set;}

           /// <summary>
           /// Desc:是否为并发
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int isjoin {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string remark {get;set;}

           /// <summary>
           /// Desc:流程人员编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string usercode {get;set;}

           /// <summary>
           /// Desc:流程人员姓名
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string username {get;set;}

           /// <summary>
           /// Desc:流程完成时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? completetime {get;set;}

           /// <summary>
           /// Desc:流程创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime createtime {get;set;}

    }
}
