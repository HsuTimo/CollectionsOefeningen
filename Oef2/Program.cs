using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef2
{
    class Program
    {
        public static Dealer Dealer;
        static void Main(string[] args)
        {
            AddTestData();
            Dealer.ShowInfo();
        }
        static void AddTestData()
        {
            Dealer = new Dealer(new Adres("Rouppeplein", "16", "Brussel", "1000"));
            Dealer.VoegAutoToe(new Vrachtwagen("VFU-736", "SCANIA", 95569,500));
            Dealer.VoegAutoToe(new Auto("LOP-317", "BMW", 98280));
            Dealer.VoegAutoToe(new Auto("RWB-418", "BMW", 93280));
            Dealer.VoegAutoToe(new Auto("MNM-333", "VOLVO", 39451));
            Dealer.VoegAutoToe(new Vrachtwagen("JHV-944", "VOLVO", 98712,300));
            Dealer.VoegAutoToe(new Auto("LCB-878", "VOLVO", 78014));
            Dealer.VerkoopAuto("RWB-418");
        }
    }
}
