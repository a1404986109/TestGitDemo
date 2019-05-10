using Ghy.Core.Dal;
using System;
using System.Collections.Generic;
using System.Text;
using Ghy.Core.EntityFramework.EntityModel;
using System.Linq;
using System.Linq.Expressions;

namespace Ghy.Core.Service
{
    public class AService
    {
        private IRepository<a> _repository;
        public IUnitOfWork _unitOfWork;
        public AService(IRepository<a> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }
        public dynamic DeleteA(int id)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                Expression<Func<a, bool>> func = x => x.id == 1;
                var a = _repository.FindOne(func);
                var result = _repository.DeleteOne(a);
                if (result == true)
                {
                    _unitOfWork.CommitTransaction();
                }
                return result;
            }
            catch (Exception ex)
            {
                _unitOfWork.RollBackTran();
                throw new Exception(ex.Message);
            }
        }
    }
}
