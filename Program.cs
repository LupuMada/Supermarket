using System;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
        //Citire produs de la tastatura
        public static Produs CitireProdusTastatura()
        {
            Console.WriteLine("Introduceti numele produsului:");
            string nume = Console.ReadLine();
            Console.WriteLine("Introduceti tipul produsului :");
            string tip_produs = Console.ReadLine();
            Console.WriteLine("Introduceti data de expirare :");
            string data_exp = Console.ReadLine();
            Produs produs = new Produs(nume, tip_produs, data_exp);

            return produs;
        }
        //Afisare produs
        public static void AfisareProdus(Produs produs)
        {
            string infoProdus = string.Format("Produsul cu numele #{0} este un produs de tip: {1} si are data de expirare: {2} ",
                   produs.Get_nume(),
                   produs.Get_tip() ?? " Necunoscut ",
                   produs.Get_data_expirare() ?? " Necunoscut ");

            Console.WriteLine(infoProdus);
        }

    }
}


