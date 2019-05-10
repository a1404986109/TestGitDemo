using SqlSugar;
using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///用户表
    ///</summary>
    public partial class user
    {
        public user()
        {


        }
        /// <summary>
        /// Desc:ID，自增
        /// Default:
        /// Nullable:False
        /// </summary>  
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }

        /// <summary>
        /// Desc:用户编码
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string Code { get; set; }

        /// <summary>
        /// Desc:用户姓名
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string Name { get; set; }

        /// <summary>
        /// Desc:用户状态
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string UserState { get; set; }

        /// <summary>
        /// Desc:电话
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string PhoneNum { get; set; }

        /// <summary>
        /// Desc:是否为管理员
        /// Default:
        /// Nullable:False
        /// </summary>           
        public byte IsAdmin { get; set; }

        /// <summary>
        /// Desc:部门ID
        /// Default:
        /// Nullable:False
        /// </summary>           
        public int DepartMentId { get; set; }

        /// <summary>
        /// Desc:创建时间
        /// Default:
        /// Nullable:False
        /// </summary>           
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Desc:用户头像
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string userImage { get; set; }

        /// <summary>
        /// Desc:绑定微信
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string WeiXinOpenID { get; set; }

    }
}
