using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Ghy.Core.Dal
{
    public interface IRepository<T> where T : class
    {
        List<T> FindList(Expression<Func<T, bool>> condition, Expression<Func<T,object>> order,PageModel pageModel, bool desc = true, string field = null);
        T FindOne(Expression<Func<T, bool>> condition);
        T AddOne(T entity, bool look = false);
        T FindOneById(int Id);
        bool AddList(List<T> items, bool look = false);
        bool DeleteOne(T entity, bool look = false);
        bool DeleteOneById(int Id, bool look = false);
        bool DeleteListById(int[] Ids, bool look = false);
        bool UpdateOne(T entity, bool look = false);
        bool DeleteList(List<T> items, bool look = false);
    }
}
