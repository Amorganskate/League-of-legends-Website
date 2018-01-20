using SummonerAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Filters;

namespace SummonerAPI.filters
{
    public class ExceptionHandlingAttribute : ExceptionFilterAttribute
    {
        IErrorService _errorService;

        public ExceptionHandlingAttribute(IErrorService errorService)
        {
            _errorService = errorService;
        }

        public override void OnException(HttpActionExecutedContext context)
        {
            // Log error
            _errorService.log(context.Exception);


            // Set Response
            throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError)
            {
                Content = new StringContent("An Error Has Occurred"),
                ReasonPhrase = "Internal Server Error"
            });
        }
    }
}