using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testC_Sharp.Classes;
using testC_Sharp.Interface;

namespace testC_Sharp.Classes
{
    public class PracownikProdukcja : Pracownik, IPracownik //dziedziczenie po klasie Pracownik, realizacja-"dziedziczenie" interfejsu IPracownik
    {
        /// <summary>
        /// pola klasy
        /// </summary>
        private string dzial;
        private int godzinyPrzepracowane;
        private double stawkaZaGodzine;

        /// <summary>
        /// Konstruktor bezparametrowy
        /// </summary>
        public PracownikProdukcja()
        {
        }

        #region Properties 
        /// <summary>
        /// Properties Pracownik Produkcja
        /// </summary>
        public string Dzial
        {
            get { return dzial; }
            set
            {
                dzial = value;
            }
        }
        public int GodzinyPrzepracowane
        {
            get { return godzinyPrzepracowane; }
            set
            {
                int liczba;
                if (int.TryParse(value.ToString(), out liczba))
                    godzinyPrzepracowane = value;
            }
        }
        public double StawkaZaGodzine
        {
            get { return stawkaZaGodzine; }
            set
            {
                double liczba;
                if (double.TryParse(value.ToString(), out liczba))
                    stawkaZaGodzine = value;
            }
        }
        #endregion

       /// <summary>
        /// realizacja interfejsu IPracownik
       /// </summary>
       /// <param name="godzinyPrzepracowane"></param>
       /// <param name="stawkaZaGodzine"></param>
       /// <returns></returns>
        public double Wynagrodzenie(int godzinyPrzepracowane, double stawkaZaGodzine)
        {
            return godzinyPrzepracowane * stawkaZaGodzine * 0.98;
        }
    }
}
