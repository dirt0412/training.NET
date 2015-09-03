using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Classes
{
    public class Ulamek : Liczba //dziedziczenie klasy Liczba w klasie Ulamek
    {
        private Liczba licznik = new Liczba();
        private Liczba mianownik = new Liczba();

        protected Liczba Mianownik
        {
            get { return mianownik; }
            set { mianownik = value; }
        }
        protected int Licznik
        {
            get { return base.MojaLiczba; }//odwolanie do klasy bazowej tj Liczba
            set { base.MojaLiczba = value; }
        }
        
    }
}
