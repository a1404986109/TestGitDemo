using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Ghy.Core.Dal;
using Ghy.Core.EntityFramework;
using Ghy.Core.EntityFramework.EntityModel;
using Common;

namespace Ghy.Core.Service
{
    public class AccountService
    {
        private IRepository<account> _repository;
        public IUnitOfWork _unitOfWork;
        public AccountService(IRepository<account> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }
        public account Login(string accountName, string passWord)
        {
            try
            {
                Expression<Func<account, bool>> func = x => x.Name == accountName && x.Password ==new DesHelper().Encrypt(passWord);
                account loginUser = _repository.FindOne(func);
                if (loginUser != null)
                {
                    return loginUser;
                }
                else
                {
                    throw new Exception("用户名或密码错误");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message,ex);
            }
        }
    }
}
