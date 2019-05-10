using System;
using System.Collections.Generic;
using System.Text;
using Ghy.Core.EntityFramework.Dto;

namespace Ghy.Core.Dal
{
    public class UnitOfWork : IUnitOfWork,IDisposable
    {
        private DbContext mbContext;
        public DbContext dbContext
        {
            get { return mbContext; }
        }
        
        public UnitOfWork(DbContext _mbContext)
        {
            if (mbContext == null)
            {
                mbContext = _mbContext;
            }
        }
        public void BeginTransaction()
        {
            mbContext.Db.Ado.BeginTran();
            IsExecute = true;
        }

        public void CommitTransaction()
        {
            mbContext.Db.Ado.CommitTran();
            IsExecute = false;
        }
        public void RollBackTran()
        {
            mbContext.Db.Ado.RollbackTran();
            IsExecute = false;
        }
        public bool IsExecute
        {
            get;
            private set;
        }
        public void Dispose()
        {
            if (IsExecute)
            {
                mbContext.Db.Ado.RollbackTran();
                IsExecute = false;
            }
            if(mbContext==null)
            {
                mbContext.Db.Ado.Dispose();
                mbContext = null;
            }
        }
    }
}
