using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NetworkingSub.IP
{
    internal class AddressAndPorts
    {

        public void IPAddressAdd()
        {
            IPAddress iPAddress =  new IPAddress(new byte[] {192,168,0,122});
            IPAddress a2 = IPAddress.Parse("192.168.0.122");

            Console.WriteLine(iPAddress.Equals(a2));
            Console.WriteLine(iPAddress.AddressFamily);
        }

        public void HttpURI()
        {
            Uri info = new Uri("http://www.facebook.com");
            Uri info1 = new Uri("http://www.twiter.com");

            Console.WriteLine("host Info : "+ info.Host);
            Console.WriteLine("host Port Nunber : "+ info.Port);

            Console.WriteLine(info +" " +info1);
        }
    }
}
