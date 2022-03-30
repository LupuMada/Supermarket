using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket
{
    class Furnizori
    {
        public string nume_furnizori;
        public string adresa_furnizori;
        public string numar_telefon;



        public Furnizori(string Nume_Furnizori, string Adresa_Furnizori, string Numar_Telefon)
        {
            this.nume_furnizori = Nume_Furnizori;
            this.adresa_furnizori = Adresa_Furnizori;
            this.numar_telefon = Numar_Telefon;
        }

        public string GetNumeFurnizori()
        {
            return nume_furnizori;
        }
        public string GetAdresaFurnizori()
        {
            return adresa_furnizori;
        }
        public string GetNumarTelefon()
        {
            return numar_telefon;
        }

        public Furnizori()
        {
            nume_furnizori = adresa_furnizori =numar_telefon =  string.Empty;
        }




    }
}
