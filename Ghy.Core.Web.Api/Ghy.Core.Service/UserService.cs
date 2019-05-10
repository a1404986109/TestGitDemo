using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Ghy.Core.Dal;
using Ghy.Core.EntityFramework.EntityModel;
using SqlSugar;

namespace Ghy.Core.Service
{
    public class UserService
    {
        private IRepository<user> _repository;
        public IUnitOfWork _unifOfWork;
        public UserService(IRepository<user> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unifOfWork = unitOfWork;
        }
        public List<user> GetUserList(PageModel pageModel)
        {
            try
            {
                Expression<Func<user, bool>> fun = x => true;
                Expression<Func<user, object>> order = x => new { x.UserState, x.CreateDate };
                List<user> list = _repository.FindList(fun, order, pageModel);
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        public bool DeleteUser(int userId)
        {
            try
            {
                _unifOfWork.BeginTransaction();
                var delResult = _repository.DeleteOneById(userId);
                if (delResult)
                {
                    _unifOfWork.CommitTransaction();
                    return delResult;
                }
                throw new Exception("用户不存在");
            }
            catch (Exception ex)
            {
                _unifOfWork.RollBackTran();
                throw new Exception(ex.Message, ex);
            }
        }
        /// <summary>
        /// 添加一条
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public user AddUserOne(user user)
        {
            try
            {
                return _repository.AddOne(user, true);
            }
            catch (Exception ex)
            {
                _unifOfWork.RollBackTran();
                throw new Exception(ex.Message, ex);
            }
        }
        /// <summary>
        /// 添加集合
        /// </summary>
        /// <param name="userList"></param>
        /// <returns></returns>
        public bool AddUserList(List<user> userList)
        {
            try
            {
                return _repository.AddList(userList, true);
            }
            catch (Exception ex)
            {
                _unifOfWork.RollBackTran();
                throw new Exception(ex.Message, ex);
            }
        }

    }
}