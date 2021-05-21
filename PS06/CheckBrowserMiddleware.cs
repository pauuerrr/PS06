using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS06
{
    public class CheckBrowserMiddleware
    {
        private RequestDelegate next;

        public CheckBrowserMiddleware(RequestDelegate next)
        {
            this.next = next;
        }
    }
}
