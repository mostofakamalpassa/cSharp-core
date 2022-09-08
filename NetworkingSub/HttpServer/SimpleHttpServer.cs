using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NetworkingSub.HttpServer
{
    public class SimpleHttpServer : IDisposable
    {
        public void Dispose() => listener.Close();


        readonly HttpListener listener = new HttpListener();
        public SimpleHttpServer() => ListenAsync();
        async void ListenAsync()
        {
            listener.Prefixes.Add("http://localhost:51111/MyApp/"); // Listen on
            listener.Start(); // port 51111
                              // Await a client request:
            HttpListenerContext context = await listener.GetContextAsync();
            // Respond to the request:
            string msg = "You asked for: " + context.Request.RawUrl;
            context.Response.ContentLength64 = Encoding.UTF8.GetByteCount(msg);
            context.Response.StatusCode = (int)HttpStatusCode.OK;
            using (Stream s = context.Response.OutputStream)
            using (StreamWriter writer = new StreamWriter(s))
                await writer.WriteAsync(msg);
        }
    }
}
