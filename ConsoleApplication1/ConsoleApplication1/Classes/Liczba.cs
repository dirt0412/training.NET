using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Classes
{
    public class Liczba
    {
        private int liczba;//pole prywatne

        public Liczba() { }//konstruktor bezparametrowy

        protected Liczba (int _liczba)//konstruktor z parametrem
        {
            liczba = _liczba;//przypisanie argumentu metody do pola private liczba w klasie Liczba
        }

        protected int MojaLiczba//properties - wlasciwosci
        {
            get { return liczba; }//zwraca wartosc
            set { liczba = value; }//przypisuje wartosc
        }
        protected int GetLiczbaKwadrat ()//tradycyjna metoda
        {
            return liczba*liczba;//zwraca kwadrat liczby
        }
    }
}
