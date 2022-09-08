// See https://aka.ms/new-console-template for more information
using NetworkingSub.HttpServer;
using NetworkingSub.IP;
using NetworkingSub.ProxyServer;

AddressAndPorts addressAndPorts = new AddressAndPorts();

//addressAndPorts.IPAddressAdd();
//addressAndPorts.HttpURI();
ProxyServers pro = new ProxyServers();

pro.ProxiyServerRun();

SimpleHttpServer simpleHttpServer = new SimpleHttpServer();
// Make a client request:
Console.WriteLine(await new HttpClient().GetStringAsync("http://localhost:51111/MyApp/Request.txt"));

var server = new WebServer("http://localhost:51111/", @"d:\webroot");
try
{
    server.Start();
    Console.WriteLine("Server running... press Enter to stop");
    Console.ReadLine();
}
finally { server.Stop(); }