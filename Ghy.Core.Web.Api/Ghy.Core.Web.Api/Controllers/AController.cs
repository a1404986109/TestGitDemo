using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ghy.Core.Service;
using Ghy.Core.Web.Api.Models;

namespace Ghy.Core.Web.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AController : ControllerBase
    {
        public AService _aServer;
        public AController(AService aService)
        {
            _aServer = aService;
        }
        [HttpGet]
        public JsonResult<dynamic> deleteA(int id)
        {
            JsonResult<dynamic> result = new JsonResult<dynamic>();
            result.Success(_aServer.DeleteA(id));
            return result;
        }
    }
}