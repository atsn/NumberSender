using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NumberSenderClient
{
    class NumberSenderConnection
    {

        public static void reshivenumbers()
        {
            try
            {
                UdpClient Myclient = new UdpClient(9999);

                IPAddress ip = IPAddress.Any;

                IPEndPoint endPoint = new IPEndPoint(ip,9999);
                Myclient.EnableBroadcast = true;


                while (true)
                {

                    Byte[] reshiveBytes = Myclient.Receive(ref endPoint);

                    string reshived = Encoding.ASCII.GetString(reshiveBytes);

                    int reshivednumber = Convert.ToInt32(reshived);

                    Console.WriteLine("Number Reshived: " + reshivednumber);

                    Thread.Sleep(1);
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        } 
      

        


    }
}
