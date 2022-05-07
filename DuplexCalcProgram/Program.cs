using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using DuplexCalcProgram.DuplexCalcServiceRef;

namespace DuplexCalcProgram
{

    public class CallbackHandler : IDuplexCalcCallback
    {
        public void Wynik(double result)
        {
            Console.WriteLine("Wynik({0})", result);
        }

        public void Rownanie(string eqn)
        {
            Console.WriteLine("Równanie({0})", eqn);
        }
        public void LicznikStan(int licznik)
        {
            Console.WriteLine("Licznik({0})", licznik);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            InstanceContext instanceContext = new InstanceContext(new CallbackHandler());

            DuplexCalcClient client = new DuplexCalcClient(instanceContext);
            client.Open();
            
            client.DodajDo(5.0);
            Thread.Sleep(2000);
            client.DodajDo(3.0);
            client.PomnozPrzez(2.0);
            Thread.Sleep(2000);
            client.PodzielPrzez(4.0);
            client.LicznikStop();
            client.OdejmijOd(1);
            client.Wyczysc();
            Thread.Sleep(5000);
            
            Console.ReadLine();

            client.Close();
        }
    }
}
