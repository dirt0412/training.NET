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

        /// <summary>
        /// przeciazenie metody
        /// przesloniecie metody wirtualnej WypiszPracownika z klasy bazowej Pracownik za pomoca override - polimorfizm
        /// </summary>
        /// <param name="pracownik"></param>
        /// <returns></returns>
        public override string WypiszPracownika(Pracownik pracownik)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.WypiszPracownika(pracownik));//odwolanie do klasy bazowej Pracownik i jej metody wirtualnej WypiszPracownika(Pracownik pracownik)
            sb.AppendLine(", ");
            sb.Append("Mail: ");
            sb.Append(pracownik.Mail);
            sb.AppendLine(", ");
            sb.Append("Telefon: ");
            sb.Append(pracownik.Telefon);
            return sb.ToString();
        }

        /// <summary>
        /// przeciazenie metody
        /// przesloniecie metody wirtualnej WypiszPracownika z klasy bazowej Pracownik za pomoca override - polimorfizm
        /// </summary>
        /// <param name="pracProd"></param>
        /// <returns></returns>
        public override string WypiszPracownika(PracownikProdukcja pracProd)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.WypiszPracownika(pracProd));//odwolanie do klasy bazowej Pracownik i jej metody wirtualnej WypiszPracownika(PracownikProdukcja pracownik)
            sb.AppendLine(", ");
            sb.Append("Godz pracy: ");
            sb.Append(pracProd.GodzinyPrzepracowane);
            return sb.ToString();
        }

        //protected override string PodajNazwiskoImiePracownika(Pracownik pracownik)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
