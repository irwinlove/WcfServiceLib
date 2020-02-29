using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLib;

namespace WcfHostConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            ServiceHost serviceHost = new ServiceHost(typeof(Service1));
            serviceHost.Open();
            Console.WriteLine("Wcf服务已启动。");
            Console.ReadLine();
            serviceHost.Close();
        }
    }
}
