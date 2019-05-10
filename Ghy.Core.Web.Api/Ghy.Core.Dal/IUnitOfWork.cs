using System;
using System.Collections.Generic;
using System.Text;
using Ghy.Core.EntityFramework.Dto;

namespace Ghy.Core.Dal
{
   public interface IUnitOfWork
    {
        DbContext dbContext { get; }
        /// <summary>
        /// 开启事务
        /// </summary>
        void BeginTransaction();
        /// <summary>
        /// 提交事务
        /// </summary>
        void CommitTransaction();
        /// <summary>
        /// 回滚事务
        /// </summary>
        void RollBackTran();
    }
}
