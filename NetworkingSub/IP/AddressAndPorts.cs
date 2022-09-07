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
    }
}
