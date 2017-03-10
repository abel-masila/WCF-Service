using GettingStartedLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace GettingStartedHost
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uri for base address
            Uri baseUri = new Uri("http://localhost:8083/GettingStarted/");
            //create a servicehost instance
            ServiceHost selfhost = new ServiceHost(typeof(CalculatorServce), baseUri);
            try
            {
                //add a service endpoint
                selfhost.AddServiceEndpoint(typeof(ICalculator), new WSHttpBinding(), "CalculatorService");
                // Enable metadata exchange
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfhost.Description.Behaviors.Add(smb);

                //Start the service.
                selfhost.Open();
                Console.WriteLine("The service is ready");
                Console.WriteLine("Press <ENTER> to terminate");
                Console.WriteLine();
                Console.ReadLine();

                // Close the ServiceHostBase to shutdown the service. 
                selfhost.Close();
            } catch(CommunicationException ex)
            {
                Console.WriteLine("An exception has occured: {0}", ex.Message);
                selfhost.Abort();
            }
        }
    }
}
