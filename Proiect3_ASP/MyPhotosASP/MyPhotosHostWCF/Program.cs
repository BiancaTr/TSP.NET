using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using MyPhotosWCF;

namespace MyPhotosHostWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lansare server WCF...");
            ServiceHost host = new ServiceHost(typeof(Service), new Uri("http://localhost:8000/PC"));
            foreach (ServiceEndpoint se in host.Description.Endpoints)
                Console.WriteLine($"A (address): {se.Address} \nB (binding): {se.Binding.Name}\nC(Contract): {se.Contract.Name}\n");
            host.Open();
            Console.WriteLine("Server in executie. Se asteapta conexiuni...");
            
            Console.ReadKey();
            host.Close();
        }
    }
}
