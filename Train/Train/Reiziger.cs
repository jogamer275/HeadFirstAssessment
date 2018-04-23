using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Reiziger
    {
        //Declaratie variabelen
        private int Klas;
        private bool Kaart;
        private string Bestemming;

        //Constructor
        public Reiziger()
        {
            Klas = 2;
            Kaart = true;
            Bestemming = "Vlissingen";
        }

        //Method
        public string VerkrijgBestemming()
        {
            return this.Bestemming;
        }
    }
}
