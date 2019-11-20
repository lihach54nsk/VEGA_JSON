using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace VEGA_JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Auth auth = new Auth("auth_req", "root", "123");
            string sending = JsonConvert.SerializeObject(auth);
            byte[] data = System.Text.Encoding.UTF8.GetBytes(sending);

            TcpClient tcpClient = new TcpClient();
            tcpClient.Connect(IPAddress.Parse("192.168.100.7"), 8002);

            NetworkStream networkStream = tcpClient.GetStream();
            //var task = Task.Factory.StartNew(() => Listen(networkStream));
            networkStream.Write(data, 0, data.Length);

            Console.WriteLine("SENT");
            byte[] dataread = new byte[1000];
            var read = networkStream.Read(dataread, 0, dataread.Length);
            Console.WriteLine(System.Text.Encoding.UTF8.GetString(dataread, 0, read));
            Console.ReadLine();
        }

        static void Listen(NetworkStream networkStream)
        {
            
        }
    }
}