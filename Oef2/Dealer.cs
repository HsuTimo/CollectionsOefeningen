using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef2
{
    public class Dealer
    {
        public Adres Adres { get; set; }
        public Dictionary<string,IVoertuig> Voertuigen { get; set; }
        public Decimal Kassa { get; set; }
        public decimal TotalValueCars
        {
            get 
            {
                decimal value = 0;
                foreach (var item in Voertuigen)
                {
                    value += item.Value.Prijs;
                }
                return value; 
            }
        }
        public int AmountOfCars
        {
            get
            {
                return Voertuigen.Count();
            }
        }

        public Dealer(Adres adres)
        {
            Kassa = 0;
            Voertuigen = new Dictionary<string, IVoertuig>();
        }
        public void VoegAutoToe(IVoertuig voertuig)
        {
            Voertuigen.Add(voertuig.Kenteken, voertuig);
        }
        public void VerkoopAuto(string kenteken)
        {
            Kassa += Voertuigen[kenteken].Prijs;
            Voertuigen.Remove(kenteken);
        }
        public void ShowInfo()
        {
            foreach (var item in Voertuigen.Values)
            {
                Console.WriteLine($"==> Type: {item.GetType().Name} met nummer: {item.Kenteken} ==> Merk {item.Merk} ({item.Prijs} euro)");
            }
            Console.WriteLine();
            Console.WriteLine($"Er zijn {AmountOfCars} autos in de dealer.");
            Console.WriteLine($"Er is {Kassa} euro in de kassa.");
            Console.WriteLine($"De totale waarde van de autos in de dealer: {TotalValueCars}.");
        }
    }
}
