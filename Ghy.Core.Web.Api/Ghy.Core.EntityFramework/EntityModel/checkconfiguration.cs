using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///
    ///</summary>
    public partial class checkconfiguration
    {
           public checkconfiguration(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? forwardTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? backwardsTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? advanceTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? delaythetime {get;set;}

    }
}
