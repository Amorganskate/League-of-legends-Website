using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SummonerAPI.Services.Impl
{
    public class ErrorService : IErrorService
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();

        public void log(Exception exception)
        {
            if(exception != null)
            {
                logger.Error(exception, exception.Message, new object[] { });
            }
        }
    }
}