using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ghy.Core.Service;

namespace Ghy.Core.Web.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        public ApiService _apiService;
        public ApiController(ApiService apiService)
        {
            _apiService = apiService;
        }
        [HttpGet]
        public string test()
        {
            return _apiService.test();
        }
    }
}