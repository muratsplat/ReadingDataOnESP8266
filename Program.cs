using System;
using System.IO.Ports;
namespace ReadingDataOnESP8266
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Listing ports... \n");
            foreach (var portName in SerialPort.GetPortNames())
            {
                Console.WriteLine(System.String.Format("Port names: {0}", portName));
            }
        }
    }
}
