using System.IO;
using System;
using System.IO.Ports;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main()
        {
            SerialPortManager manager = new SerialPortManager("COM1", "COM2");
            manager.ConfigurePorts();
            await manager.ReadWriteDataInParallel();
        }

    }
}
