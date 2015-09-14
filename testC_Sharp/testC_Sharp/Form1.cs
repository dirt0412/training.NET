using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testC_Sharp.Classes;
using testC_Sharp.Methods;


namespace testC_Sharp
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        MethodsPracownik methodsPracownik = new MethodsPracownik();
        public Form1()
        {
            InitializeComponent();
        }

        private void btDodajPracownika_Click(object sender, EventArgs e)
        {
            #region Pracownik            
            dt.Clear();
            methodsPracownik.AddColumnToDataTable(dt);//tworzenie obiektu DataTable

            Pracownik pracownik1 = new Pracownik( "Kowalski", "Jan", 1970, "kj@poczta.onet.pl", "12345678900");//tworzenie obiektu Pracownik za pomoca konstruktora
            methodsPracownik.AddRowPracownik(pracownik1, dt);//dodanie do DataTable nowego wiersza z danymi
            Pracownik pracownik2 = new Pracownik { Nazwisko = "Nowak", Imie = "Stefan", Mail = "ns@poczta.onet.pl", RokUrodzenia = 1991, Telefon = "12345556711" };//tworzenie obiektu Pracownik za pomoca konstruktora - inny sposob
            methodsPracownik.AddRowPracownik(pracownik2, dt);//dodanie do DataTable nowego wiersza z danymi
            dataGridView1.DataSource = dt;//polaczenie danych o pracownikach z obiektem dataGridView - wyswietlenie danych

            //pracownik1.
            #endregion

            #region pracownikProdukcja
            //operacje dla klasy PracownikProdukcja - dodawanie za pomoca konstruktora
            PracownikProdukcja pp1 = new PracownikProdukcja { Dzial = "Pakownia", GodzinyPrzepracowane = 16, Imie = "Edward", Nazwisko = "Smiały", Mail = "mail1@op.pl", RokUrodzenia = 1966, StawkaZaGodzine = 22.5, Telefon = "345678234" };

            //operacje dla klasy PracownikProdukcja - dodawanie za pomoca przypisania do wlasciwosci z klasy PracownikProdukcja oraz z klasy po ktorej jest dziedziczenie tj Pracownik
            PracownikProdukcja pp2 = new PracownikProdukcja();
            pp2.Nazwisko = "Falkowski";
            pp2.Imie = "Piotr";
            pp2.StawkaZaGodzine = 27.55;
            pp2.GodzinyPrzepracowane = 32;
            pp2.Dzial = "Magazyn";
            pp2.Mail = "mail22@op.pl";
            pp2.RokUrodzenia = 1982;
            pp2.Telefon = "232343232";

            //realizacja interfejsu z IPracownik
            pp1.Wynagrodzenie(pp1.GodzinyPrzepracowane, pp1.StawkaZaGodzine);
            pp2.Wynagrodzenie(0, 0);

            //przyklad przeciazenia metod WypiszPracownika
            label1.Text = pp1.WypiszPracownika(pracownik1);//metoda z polimorfizmu WypiszPracownika(Pracownik pracownik)
            label2.Text = pp1.WypiszPracownika(pp1);//metoda z polimorfizmu WypiszPracownika(PracownikProdukcja pracProd)
            label3.Text = pracownik1.PodajRokUrodzeniaPracownika(pracownik2).ToString();//metoda z klasy abstrakcyjnej AbstractClass zdefiniowana w klasie Pracownik

            PracownikProdukcja pp3 = new PracownikProdukcja();
            //wywolanie metody NIE abstrakcyjnej DodajWynagrodzeniaPracownikow z klasy abstrakcyjnej AbstractClass
            label4.Text = pp3.DodajWynagrodzeniaPracownikow(pp1, pp2).ToString();

            //MessageBox.Show(pracownik1.ID + "\n" + pracownik2.ID, "ID Pracownikow");
            #endregion

            //Singleton sing1 = new Singleton();//błąd !!!
            //sing1.DoSomething();//błąd !!!
            //Singleton.InstancjaStaticProperties.DoSomething(5);
            
        }
    }
}
