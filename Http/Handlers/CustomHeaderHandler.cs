using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace LoginProject.Http.Handlers
{
    public class CustomHeaderHandler : DelegatingHandler
    {
        //LINK: http://www.asp.net/web-api/overview/working-with-http/http-message-handlers

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
                                                                     CancellationToken cancellationToken)
        {
            // Call the Inner Handler
            var response = await base.SendAsync(request, cancellationToken);

            //Process Response
            response.Headers.Add("X-Powered-By", "CFY PowerMyLearning.");
            response.Headers.Add("X-Designed-By", "Karuppiah Ganesan");

            return response;
        }
    }
}

