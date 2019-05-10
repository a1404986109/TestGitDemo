using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ghy.Core.Service;
using Ghy.Core.EntityFramework.EntityModel;
using SqlSugar;
using Ghy.Core.Web.Api.Models;

namespace Ghy.Core.Web.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserService _userService;
        public UserController(UserService userService)
        {
            _userService = userService;
        }
        [HttpPost]
        public JsonResult<List<user>> UserList([FromForm]PageModel pageModel)
        {
            JsonResult<List<user>> result = new JsonResult<List<user>>();
            result.Success(_userService.GetUserList(pageModel));
            return result;
        }
        [HttpPost]
        public JsonResult<user> AddUserOne([FromForm]user user)
        {
            JsonResult<user> result = new JsonResult<user>();
            result.Success(_userService.AddUserOne(user));
            return result;
        }
        [HttpGet]
        public JsonResult<EmptyDTO> DelUser(int userId)
        {
            JsonResult<EmptyDTO> result = new JsonResult<EmptyDTO>();
            bool delResult = _userService.DeleteUser(userId);
            if (delResult)
            {
                return result;
            }
            result.Fail("删除失败");
            return result;
        }
    }
}