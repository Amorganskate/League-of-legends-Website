using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SummonerAPI.Services
{
    public interface IErrorService
    {
        void log(Exception exception);
    }
}