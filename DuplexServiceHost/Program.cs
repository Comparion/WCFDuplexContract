using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using DuplexServiceLibrary;

namespace DuplexServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tworzymy adres pod którym będzie dostępna usługa
            Uri baseAddress = new Uri("http://localhost:8001/DuplexCalcService/");

            // Tworzymy obiekt klasy DuplexCalc
            ServiceHost selfHost = new ServiceHost(typeof(DuplexCalc), baseAddress);

            try
            {
                // Dodajemy Endopoint usługi

                selfHost.AddServiceEndpoint(typeof(IDuplexCalc), new WSDualHttpBinding(), "CalculatorService");

                // Umożliwiamy wymianę metadanych
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                // Umożliwiamy przesłanie dodatkowych danych na temat wyjątku
                selfHost.Description.Behaviors.Find<ServiceDebugBehavior>().IncludeExceptionDetailInFaults = true;
                selfHost.Description.Behaviors.Add(smb);


                // Startujemy serwis
                selfHost.Open();
                Console.WriteLine("Serwis działa....");
                Console.WriteLine("Naciśnij <ENTER> by zakończyć.");
                Console.WriteLine();
                Console.ReadLine();

                // zamykamy serwis
                selfHost.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("Przechwyciłem wyjątek: {0}", ce.Message);
                selfHost.Abort();
            }
        }
    }
}

