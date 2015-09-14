using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testC_Sharp.Classes
{
    /// <summary>
    /// Metoda abstrakcyjna w C# jest metodą polimorficzną. Musi być zadeklarowana jako funkcja składowa abstrakcyjnej klasy, poprzedzona przedrostkiem abstract. 
    /// Metoda abstrakcyjna zachowuje się tak samo jak metoda wirtualna, jedyna różnica leży w braku definicji ciała funkcji. 
    /// Tworząc metodę abstrakcyjną deklarujemy funkcję (deklaracja to typ zwracany, nazwa i argumenty) ale nie definiujemy ciała funkcji. Metodę abstrakcyjną można zadeklarować tylko w klasie abstrakcyjnej (także poprzedzonej słowem abstract). Klasa abstrakcyjna jest klasą, której instancji nie da się stworzyć. Można po niej tylko dziedziczyć, rozszerzając ją o inne klasy. 
    /// Klasy dziedziczące muszą implementować metody abstrakcyjne klasy abstrakcyjnej, podobnie jest dla interfejsów. 
    /// W klasie abstrakcyjnej może byc metoda bez definicji ciała ale nie moze być ona abstrakcyjna - tym różni się klasa abstrakcyjna od interfejsu
    /// </summary>
    public abstract class AbstractClass
    {
        protected abstract string PodajNazwiskoImiePracownika(Pracownik pracownik);
        public abstract int PodajRokUrodzeniaPracownika(Pracownik pracownik);
        protected abstract double PodajWynagrodzeniePracownika(PracownikProdukcja pracProdukcja);
        //metoda nie abstrakcyjna z cialem w klasie abstrakcyjnej
        public double DodajWynagrodzeniaPracownikow(PracownikProdukcja pracProdukcja1,PracownikProdukcja pracProdukcja2)
        {
            return pracProdukcja1.PodajWynagrodzeniePracownika(pracProdukcja1) + pracProdukcja2.PodajWynagrodzeniePracownika(pracProdukcja2);
        }
    }
}
