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
            Console.WriteLine("Hello world!");
        }

        static string Listen(NetworkStream networkStream) => "I am alive!";
    }
}