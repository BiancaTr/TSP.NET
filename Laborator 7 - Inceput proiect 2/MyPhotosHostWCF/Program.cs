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
            ServiceHost host = new ServiceHost(typeof(MyPhotosService), new Uri("http://localhost:8000/MyPhotos"));
            foreach (ServiceEndpoint serviceEndpoint in host.Description.Endpoints)
                Console.WriteLine("A  (Address): {0} \nB  (Binding): {1}\nC (Contract): {2}\n", serviceEndpoint.Address, serviceEndpoint.Binding.Name, serviceEndpoint.Contract.Name);
            host.Open();
            Console.WriteLine("Server running");
            Console.ReadLine();
            host.Close();
        }
    }
}
