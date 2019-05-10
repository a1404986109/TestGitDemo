using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ghy.Core.Web.Api.Models
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true)]
    public class ValidationModelAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                JsonResult<EmptyDTO> errJson = new JsonResult<EmptyDTO>();
                string msg = "";
                foreach (var item in context.ModelState.Values)
                {
                    foreach (var error in item.Errors)
                    {
                        msg += error.ErrorMessage + "|";
                    }
                }
                errJson.Fail(msg);
                context.HttpContext.Response.WriteAsync(JsonConvert.SerializeObject(errJson));
            }
            base.OnActionExecuting(context);
        }
    }
    public class ActionFilter : IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext context)
        {
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            if (context.Result is BadRequestObjectResult)
            {
                BadRequestObjectResult res = (BadRequestObjectResult)context.Result;
                SerializableError obj = res.Value as SerializableError;
                StringBuilder sb = new StringBuilder();
                foreach (var item in obj)
                {
                    var vals = item.Value as string[];
                    if (vals != null)
                    {
                        sb.AppendLine(vals[0]);
                    }
                }
                JsonResult<EmptyDTO> errResult = new JsonResult<EmptyDTO>();
                errResult.Fail(sb.ToString());
                context.Result = new JsonResult(errResult);
                return;
            }
        }
    }
}
