using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket
{
    class Produs
    {
        public string nume_produs;
        public string tip;
        public string data_expirare;
        public string produs_nou;
        public const int nr_maxim_produse = 10;


        public Produs(string Nume, string Tip, string Data_expirare)
        {
            this.nume_produs = Nume;
            this.tip = Tip;
            this.data_expirare = Data_expirare;


        }

        public string Get_nume()
        {
            return nume_produs;
        }

        public string Get_tip()
        {
            return tip;
        }
        public string Get_data_expirare()
        {
            return data_expirare;
        }

        public void AdaugaProdus()
        {
            if (produs_nou.Split(' ').Length + 1 > nr_maxim_produse)
            {
                string carte_noua = Console.ReadLine();
                produs_nou = produs_nou + " " + produs_nou;
            }
            else
            {
                Console.WriteLine("Ati ajuns la numarul maxim de produse " + nume_produs + "!");
            }
        }


        public void StergeProdus(string produse_de_sters)
        {
            int i = 0, de_sters = 0;
            string[] produs_nou_nou = produs_nou.Split(' ');
            foreach (var nume in produs_nou_nou)
            {
                i++;
                if (produse_de_sters == nume.ToString())
                {
                    de_sters = i;
                    break;
                }
            }
            for (int j = de_sters; j < produs_nou_nou.Length; j++)
            {
                produs_nou_nou[de_sters] = produs_nou_nou[j];
            }
            string produs_nou_final = string.Join(' ', produs_nou_nou);
            produs_nou = produs_nou_final;
        }

        public bool CautareProdus(string produs_de_cautat)
        {
            foreach (var nume in produs_nou.Split(' '))
            {
                if (nume == produs_de_cautat)
                {
                    return true;
                }
            }
            return false;
        }





    }
}