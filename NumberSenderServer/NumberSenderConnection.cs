using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NumberSenderServer
{
    class NumberSenderConnection
    {
        

        public static void Sendnumbers()
        {
            int numbers = 1;
            try
            {
                UdpClient Myclient = new UdpClient();

                IPEndPoint endPoint = new IPEndPoint(IPAddress.Broadcast, 9999);
                while (true)
                {
                    string senddata = numbers.ToString();
                    Byte[] sendbytes = Encoding.ASCII.GetBytes(senddata);
                    Myclient.Send(sendbytes, sendbytes.Length, endPoint);
                    

                    Console.WriteLine("Number sendt" + numbers );
                    numbers++;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }



    }
}
