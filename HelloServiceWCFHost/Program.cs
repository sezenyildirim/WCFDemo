using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;


namespace HelloServiceWCFHost
{
    public class Program
    {
        static void Main(string[] args)
        {
            using(ServiceHost host = new ServiceHost(typeof(HelloServiceWCF.HelloServiceWCF)))
            {
                host.Open();
                Console.WriteLine("host started @ " + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}
