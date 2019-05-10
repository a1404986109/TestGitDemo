using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ghy.Core.Service;
using Ghy.Core.EntityFramework.EntityModel;
using Ghy.Core.Web.Api.Models;
using Common;

namespace Ghy.Core.Web.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        public AccountService _accountService;
        public AccountController(AccountService accountService)
        {
            _accountService = accountService;
        }
        [HttpGet]
        public JsonResult<account> Login(string accountName,string passWord)
        {
            JsonResult<account> result = new JsonResult<account>();
            result.Success(_accountService.Login(accountName, passWord));
            return result;
        }
        [HttpGet]
        public JsonResult<string> Decryption(string passWord)
        {
            string password = new DesHelper().Decrypt(passWord);
            JsonResult<string> result = new JsonResult<string>();
            result.Success(password);
            return result;
        }
    }
}