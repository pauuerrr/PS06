using Microsoft.AspNetCore.Http;
using Shyjus.BrowserDetection;
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

        public async Task InvokeAsync(HttpContext httpContext,IBrowserDetector detector)
        {
            var browser = detector.Browser;

            if ((browser.Name == BrowserNames.Edge)|| (browser.Name == BrowserNames.EdgeChromium) || (browser.Name == BrowserNames.InternetExplorer))
            {
                await httpContext.Response.WriteAsync("<p>Przegladarka nie jest obsugiwana</p>");
            }
            else
            {
                await this.next.Invoke(httpContext);
            }
        }
    }
}
