using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;
using Common;
using Ghy.Core.Service;

namespace Ghy.Core.Web.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DbContextController : ControllerBase
    {
        public CreateModelService _createModelService;
        public DbContextController(CreateModelService createModelService)
        {
            _createModelService = createModelService;
        }
        [HttpGet]
        public string GetConn()
        {
            IConfiguration configuration = AppConfigurtaionService.Configuration;
            string conn = AppConfigurtaionService.Configuration.GetSection("SqlSugarStrings:MySqlConnection").Value;
            return conn;
        }
        /// <summary>
        /// 创建实体
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        public bool CreateModel()
        {
            return _createModelService.CreateModel();
        }
    }
}   