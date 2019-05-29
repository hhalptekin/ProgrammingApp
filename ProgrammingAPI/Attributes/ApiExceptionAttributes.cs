using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace ProgrammingAPI.Attributes
{
    public class ApiExceptionAttributes : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            HttpResponseMessage errorRespnsive = new HttpResponseMessage(System.Net.HttpStatusCode.NotImplemented);
            errorRespnsive.ReasonPhrase = actionExecutedContext.Exception.Message;
            actionExecutedContext.Response = errorRespnsive;
            base.OnException(actionExecutedContext);
        }
    }
}