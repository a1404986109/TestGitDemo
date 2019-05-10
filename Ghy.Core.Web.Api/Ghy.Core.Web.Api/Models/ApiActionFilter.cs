using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ghy.Core.Web.Api.Models;

namespace Ghy.Core.Web.Api.Models
{
    public class ApiActionFilter:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext actionContext)
        {
            if (actionContext.Filters.Any(item => item is AllowAnonymousFilter))
            {
                return;
            }
            HttpContext context = (HttpContext)actionContext.HttpContext;//获取传统的Context
            var headers = context.Request.Headers;
            var requestPath = context.Request.Path;
            context.Response.ContentType = "application/json";
            if (!headers.ContainsKey("Authorization"))
            {
                if (requestPath.Equals("/api/Account/login") || requestPath.Value.Contains("/swagger"))
                {
                    return;
                }
                JsonResult<EmptyDTO> errResult = new JsonResult<EmptyDTO>();
                errResult.Fail("请求无效,由于找不到凭证，访问被拒绝");
                actionContext.Result = new Microsoft.AspNetCore.Mvc.JsonResult(errResult);
            }
        }
    }
}
