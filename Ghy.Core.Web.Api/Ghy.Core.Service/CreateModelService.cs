using System;
using System.Collections.Generic;
using System.Text;
using Ghy.Core.EntityFramework.Dto;
using Microsoft.Extensions.Configuration;

namespace Ghy.Core.Service
{
   public class CreateModelService
    {
       public DbContext  _dbContext{ get; set; }
        public CreateModelService(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool CreateModel()
        {
           return _dbContext.CreateEntity();
        }
    }
}
