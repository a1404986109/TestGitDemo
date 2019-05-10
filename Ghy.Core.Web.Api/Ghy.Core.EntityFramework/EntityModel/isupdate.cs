using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///
    ///</summary>
    public partial class isupdate
    {
           public isupdate(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int updateOrNot {get;set;}

           /// <summary>
           /// Desc:修改1,增加0, 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? userId {get;set;}

    }
}
