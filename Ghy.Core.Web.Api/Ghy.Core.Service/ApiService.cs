using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Ghy.Core.Dal;
using Ghy.Core.EntityFramework.EntityModel;

namespace Ghy.Core.Service
{
    public class ApiService
    {
        private IRepository<api> _repository;
        public IUnitOfWork _unitOfWork;
        public ApiService(IRepository<api> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }
        public string test()
        {
            List<api> apis = new List<api>();
            Stopwatch stw1 = new Stopwatch();
            Stopwatch stw2 = new Stopwatch();
            int i = 0;
            stw2.Start();
            api a1 = null;
            while (i < 5000)
            {
                a1 = new api()
                {
                    Action = "1",
                    Controller = "1",
                    Describe = "1",
                    Name = "1"
                };
                apis.Add(a1);
                i++;
            }
            stw2.Stop();
            string stw2Str = stw2.Elapsed.TotalMilliseconds.ToString();
            Stopwatch stw3 = new Stopwatch();
            List<api> api2 = new List<api>();
           stw3.Start();
            api a = null; 
            for (int j = 0; j < 5000; j++)
            {
                a = new api()
                {
                    Action = "1",
                    Controller = "1",
                    Describe = "1",
                    Name = "1"
                };
                api2.Add(a);
            }
            stw3.Stop();
            //string stw3Str = stw3.Elapsed.TotalMilliseconds.ToString();
            //stw1.Start();
            //_repository.AddList(apis);
            //stw1.Stop();

            string stw1Str = stw3.Elapsed.TotalMilliseconds.ToString();
            return stw1Str +"_"+ stw2Str;
        }
    }
}
