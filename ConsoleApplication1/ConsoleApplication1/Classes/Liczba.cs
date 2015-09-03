using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Classes
{
    public class Liczba
    {
        private int liczba;//pole

        public Liczba() { }//konstruktor bezparametrowy

        protected Liczba (int _liczba)//konstruktor
        {
            liczba = _liczba;
        }

        protected int MojaLiczba//properties - wlasciwosci
        {
            get { return liczba; }
            set { liczba = value; }
        }
        protected int GetLiczbaKwadrat ()//tradycyjna metoda
        {
            return liczba*liczba;
        }
    }
}
