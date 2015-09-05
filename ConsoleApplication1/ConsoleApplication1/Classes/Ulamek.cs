using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Classes
{
    public class Ulamek : Liczba //dziedziczenie klasy Liczba w klasie Ulamek
    {
        private Liczba licznik = new Liczba();//pola prywatne klasy
        private Liczba mianownik = new Liczba();

        protected Liczba Mianownik//properties - wlasciwosci
        {
            get { return mianownik; }//zwraca wartosc
            set { mianownik = value; }//przypisuje wartosc
        }
        protected int Licznik//properties - wlasciwosci
        {
            get { return base.MojaLiczba; }//odwolanie do klasy bazowej tj Liczba, //zwraca wartosc
            set { base.MojaLiczba = value; }//odwolanie do klasy bazowej tj Liczba, //przypisuje wartosc
        }
        
    }
}
