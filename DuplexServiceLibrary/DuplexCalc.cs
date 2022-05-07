using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace DuplexServiceLibrary
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Single)]
    //[ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class DuplexCalc : IDuplexCalc
    {

        Thread watek;
        double wynik = 0.0D;
        string rownanie;
        int licznik=0;
        bool startLicznik = false;
        System.Timers.Timer czas;

        public DuplexCalc()
        {
            rownanie = wynik.ToString();
            LicznikStart();
        }

        public void Wyczysc()
        {
            Callback.Rownanie(rownanie + " = " + wynik.ToString());
            rownanie = wynik.ToString();
            LicznikStart();
        }

        public void DodajDo(double n)
        {
            wynik += n;
            rownanie += " + " + n.ToString();
            Callback.Wynik(wynik);
            LicznikStart();
        }

        public void OdejmijOd(double n)
        {
            wynik -= n;
            rownanie += " - " + n.ToString();
            Callback.Wynik(wynik);
            LicznikStart();
        }

        public void PomnozPrzez(double n)
        {
            wynik *= n;
            rownanie += " * " + n.ToString();
            Callback.Wynik(wynik);
            LicznikStart();
        }

        public void PodzielPrzez(double n)
        {
            wynik /= n;
            rownanie += " / " + n.ToString();
            Callback.Wynik(wynik);
            LicznikStart();
        }

        public void WatekLicznika(object callBack)
        {
            IDuplexCalcCallback callback = (IDuplexCalcCallback)callBack;
            czas = new System.Timers.Timer(1000);
            czas.Elapsed += (source, e) => WyslijLicznik(source, e, callback);
            czas.Enabled = true;
        }


        public void LicznikStart()
        {
            licznik++;
            if (startLicznik == false)
            {
                startLicznik = true;
                watek = new Thread(WatekLicznika);
                watek.Start(Callback);
            }
        }

        public void LicznikStop()
        {
            czas.Stop();
            czas.Dispose();
            startLicznik = false;
            watek.Abort();
            watek = null;
        }

        public void WyslijLicznik(object source, System.Timers.ElapsedEventArgs e, IDuplexCalcCallback callback)
        {
                callback.LicznikStan(licznik);
        }

        IDuplexCalcCallback Callback
        {
            get
            {
                return OperationContext.Current.GetCallbackChannel<IDuplexCalcCallback>();
            }
        }

    }
}