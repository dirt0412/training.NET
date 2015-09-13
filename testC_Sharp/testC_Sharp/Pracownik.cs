using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testC_Sharp
{
    public class Pracownik 
    {
        /// <summary>
        /// pola klasy
        /// </summary>
        private string id;
        private string nazwisko;
        private string imie;
        private int rokUrodzenia;
        private string mail;
        private string telefon;
        private static string nazwaFirmy;

        #region Properties (właściwości)
        /// <summary>
        /// Properties tylko do odczytu
        /// </summary>
        protected string ID
        {
            get { return id; }            
        }
        /// <summary>
        /// properties do odczytu i do zapisu
        /// </summary>
        public string Nazwisko
        {
            get { return nazwisko; }
            set
            {
                if (value.Length > 2 && value.Length < 25)
                    nazwisko = value;
                else
                {
                    nazwisko = null;
                    MessageBox.Show("Nieprawidłowa długość nazwiska","Uwaga");
                }
            }
        }
        public string Imie
        {
            get { return imie; }
            set
            {
                if (value.Length > 2 && value.Length < 25)
                    imie = value;
                else
                {
                    imie = null;
                    MessageBox.Show( "Nieprawidłowa długość imie","Uwaga");
                }
            }
        }
        public int RokUrodzenia
        {
            get { return rokUrodzenia; }
            set
            {
                int liczba;
                if (int.TryParse(value.ToString(), out liczba))
                    rokUrodzenia = value;
                else
                {
                    rokUrodzenia = 0;
                    MessageBox.Show("Nieprawidłowy rok urodzenia","Uwaga");
                }
            }
        }
        public string Mail
        {
            get { return mail; }
            set
            {
                if (value.Contains("@") && value.Contains("."))
                    mail = value;
                else
                {
                    mail = null;
                    MessageBox.Show( "Nieprawidłowy adres mail", "Uwaga");
                }
            }
        }
        /// <summary>
        /// Properties (właściwości) automatyczne
        /// </summary>
        public string Telefon { get; set; }

        public static string NazwaFirmy { get { return nazwaFirmy; } set {nazwaFirmy = value;} }

        #endregion

        #region Konstruktory
        /// <summary>
        /// konstruktory bezparametrowy
        /// </summary>
        public Pracownik()
        {
            Random random = new Random();
            id = "XxxXxx"+random.Next(1000, 9999).ToString();
        }
        /// <summary>
        /// konstruktor z parametrami
        /// </summary>
        /// <param name="id1"></param>
        /// <param name="nazwisko1"></param>
        /// <param name="imie1"></param>
        /// <param name="rokUrodzenia1"></param>
        /// <param name="mail1"></param>
        /// <param name="telefon1"></param>
        public Pracownik(string nazwisko1, string imie1, int rokUrodzenia1, string mail1, string telefon1)
        {
            Random random = new Random();
            if (nazwisko1.Length > 2 && imie1.Length > 2)
                id = nazwisko1.Substring(0, 3) + imie1.Substring(0, 3) + random.Next(1000, (rokUrodzenia1 < 1900) ? rokUrodzenia1 : 2999).ToString();
            else id = null;
            //--------------
            if (nazwisko1.Length > 2 && nazwisko1.Length < 25)
                nazwisko = nazwisko1;
            else
            {
                nazwisko = null;
                MessageBox.Show("Nieprawidłowa długość nazwiska", "Uwaga");
            }
            //--------------
            if (imie1.Length > 2 && imie1.Length < 25)
                imie = imie1;
            else
            {
                imie = null;
                MessageBox.Show("Nieprawidłowa długość imie", "Uwaga");
            }
            //--------------
            int liczba2;
            if (int.TryParse(rokUrodzenia1.ToString(), out liczba2))
                rokUrodzenia = rokUrodzenia1;
            else
            {
                rokUrodzenia = 0;
                MessageBox.Show("Nieprawidłowy rok urodzenia", "Uwaga");
            }
            //--------------
            if (mail1.Contains("@") && mail1.Contains("."))
                mail = mail1;
            else
            {
                mail = null;
                MessageBox.Show("Nieprawidłowy adres mail", "Uwaga");
            }
            //--------------
            telefon = telefon1;
        }
        #endregion

        #region Metody
        /// <summary>
        /// metody-funkcje
        /// </summary>
        /// <param name="id1"></param>
        /// <param name="rokUrodzenia1"></param>
        /// <returns></returns>
        protected int PodajWiekPracownika(uint id1, int rokUrodzenia1)
        {
            if (DateTime.Now.Year > rokUrodzenia1)
                return DateTime.Now.Year - rokUrodzenia1;
            else
                return -1;
        }

        public Pracownik PodajPracownika(string id1)
        {
            if (id1 == id)
                return new Pracownik(Nazwisko, Imie, RokUrodzenia, Mail, Telefon);//konstruktor z parametrami
            else
                return new Pracownik();//konstruktor bezparametrowy
        }
        #endregion

       


    }
}
