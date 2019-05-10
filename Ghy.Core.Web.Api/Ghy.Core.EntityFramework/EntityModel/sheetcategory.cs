using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///自建工单分类表
    ///</summary>
    public partial class sheetcategory
    {
           public sheetcategory(){


           }
           /// <summary>
           /// Desc:ID，自增
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:分类名称
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string name {get;set;}

           /// <summary>
           /// Desc:分类模板
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string templete {get;set;}

           /// <summary>
           /// Desc:分类模板
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string templeteform {get;set;}

           /// <summary>
           /// Desc:督办人员
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string supervisor {get;set;}

           /// <summary>
           /// Desc:是否为协同
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int isjoin {get;set;}

           /// <summary>
           /// Desc:启用状态，1为启用，0为停用
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int state {get;set;}

           /// <summary>
           /// Desc:创建人编码
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string creatercode {get;set;}

           /// <summary>
           /// Desc:创建人姓名
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string creatername {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime createtime {get;set;}

    }
}
