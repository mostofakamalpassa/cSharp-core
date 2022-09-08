using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NetworkingSub.ProxyServer
{
    public class ProxyServers
    {
        public void ProxiyServerRun()
        {
            WebProxy cli = new WebProxy("192.168.0.122");
            cli.Credentials = new NetworkCredential("mostofa kamal", "mk6683*", "abc.com");

            var handler = new HttpClientHandler { Proxy = cli };
            var client = new HttpClient(handler);

            Console.WriteLine(client);
        }
    }
}
