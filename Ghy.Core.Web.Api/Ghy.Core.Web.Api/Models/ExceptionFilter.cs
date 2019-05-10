using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ghy.Core.Web.Api.Models
{
    public class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.ExceptionHandled == false)
            {
                JsonResult<EmptyDTO> errResult = new JsonResult<EmptyDTO>();
                errResult.Fail(context.Exception.Message);
                context.Result = new Microsoft.AspNetCore.Mvc.JsonResult(errResult);
            }
            context.ExceptionHandled = true;
        }
        public Task OnExceptionAsync(ExceptionContext context)
        {
            OnException(context);
            return Task.CompletedTask;
        }
    }
}
