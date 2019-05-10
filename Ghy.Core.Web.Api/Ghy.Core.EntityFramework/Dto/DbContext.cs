using Microsoft.Extensions.Configuration;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Common;

namespace Ghy.Core.EntityFramework.Dto
{
    public class DbContext
    {
        public SqlSugarClient Db;//用来处理数据库查询和复杂的操作
        public DbContext()
        {
            Db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = AppConfigurtaionService.Configuration.GetConnectionString("MySqlConnection"),
                DbType = DbType.MySql,
                InitKeyType = InitKeyType.SystemTable,
                IsAutoCloseConnection = true,//开启自动释放模式
            });
            TimeSpan complteTime = Db.Ado.SqlExecutionTime;
            Db.Aop.OnLogExecuting = (sql, pars) =>
            {
                Console.WriteLine(sql + "\r\n" +
                    Db.Utilities.SerializeObject(pars.ToDictionary(x => x.ParameterName, x => x.Value)));
                Console.WriteLine();
            };
        }
        public DbSet<T> GetDb<T>() where T : class, new()
        {
            return new DbSet<T>(Db);
        }
        /// <summary>
        /// 生成实体类
        /// </summary>
        /// <returns></returns>
        public virtual bool CreateEntity()
        {
            try
            {
                Db.DbFirst.CreateClassFile("D:\\ASPNETCOREDEMO\\Ghy.Core.Web.Api\\Ghy.Core.EntityFramework\\EntityModel", "Ghy.Core.EntityFramework.EntityModel");
                return true;

            }
            catch (SqlSugarException)
            {
                return false;
            }
        }
    }
    public class DbSet<T> : SimpleClient<T> where T : class, new()
    {
        public DbSet(SqlSugarClient context) : base(context)
        {

        }
    }
}
