using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;
using Ghy.Core.EntityFramework.Dto;
using Ghy.Core.EntityFramework.EntityModel;
using System.Linq.Expressions;

namespace Ghy.Core.Dal
{
    public class Repository<T> : DbContext, IRepository<T> where T : class, new()
    {
        protected DbContext context;
        public Repository(IUnitOfWork repositoryContext)
        {
            context = repositoryContext.dbContext;
        }

        public T AddOne(T entity, bool look = false)
        {
            T newEntity = null;
            if (look)
            {
                newEntity = context.Db.Insertable(entity).With(SqlWith.RowLock).ExecuteReturnEntity();
            }
            else
            {
                newEntity = context.Db.Insertable(entity).ExecuteReturnEntity();
            }
            return newEntity;
        }
        public bool AddList(List<T> items, bool look = false)
        {
            var result = look ?
            context.Db.Insertable(items).With(SqlWith.RowLock).ExecuteCommandIdentityIntoEntity() :
            context.Db.Insertable(items).ExecuteCommandIdentityIntoEntity();
            return result;
        }
        public bool DeleteOne(T entity, bool look = false)
        {
            var result = look ?
            context.Db.Deleteable<T>().Where(entity).With(SqlWith.RowLock).ExecuteCommandHasChange() :
            context.Db.Deleteable<T>().Where(entity).ExecuteCommandHasChange();
            return result;
        }
        
        public bool DeleteList(List<T> items, bool look = false)
        {
            var result = look ?
            context.Db.Deleteable<T>().Where(items).With(SqlWith.RowLock).ExecuteCommandHasChange() :
            context.Db.Deleteable<T>().Where(items).ExecuteCommandHasChange();
            return result;
        }
        public bool UpdateOne(T entity, bool look = false)
        {
            var result = look ?
            context.Db.Updateable(entity).With(SqlWith.RowLock).ExecuteCommandHasChange() :
            context.Db.Updateable(entity).ExecuteCommandHasChange();
            return result;
        }
        public bool UpdateList(List<T> items, bool look = false)
        {
            var result = look ?
            context.Db.Updateable(items).With(SqlWith.RowLock).ExecuteCommandHasChange() :
            context.Db.Updateable(items).ExecuteCommandHasChange();

            //GetDb<T>().UpdateRange(items);
            return result;
        }
        public List<T> FindList(Expression<Func<T, bool>> condition, Expression<Func<T, object>> order, PageModel pageModel, bool desc = true, string field = null)
        {
            if (string.IsNullOrWhiteSpace(field))
            {
                field = "Id";
                return context.Db.Queryable<T>().Where(condition).OrderByIF(desc, order, OrderByType.Desc).ToPageList(pageModel.PageIndex, pageModel.PageSize);
            }
            else
            {
                return context.Db.Queryable<T>().Where(condition).OrderByIF(desc, order, OrderByType.Desc).ToPageList(pageModel.PageIndex, pageModel.PageSize);
            }
        }
        public T FindOne(Expression<Func<T, bool>> condition)
        {
            return GetDb<T>().GetSingle(condition);
        }
        public T FindOneById(int Id)
        {
            return GetDb<T>().GetById(Id);
        }
        public bool DeleteOneById(int Id, bool look = false)
        {
            var result = look ?
            context.Db.Deleteable<T>().In(Id).With(SqlWith.RowLock).ExecuteCommandHasChange() :
            context.Db.Deleteable<T>().In(Id).ExecuteCommandHasChange();
            return result;
        }
        public bool DeleteListById(int[] Ids, bool look = false)
        {
            var result = look ?
            context.Db.Deleteable<T>().In(Ids).With(SqlWith.RowLock).ExecuteCommandHasChange() :
            context.Db.Deleteable<T>().In(Ids).ExecuteCommandHasChange();
            return result;
        }
    }
}