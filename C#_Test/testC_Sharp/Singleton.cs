using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testC_Sharp
{
    /// <summary>
    /// przyklad wzorca projektowego Singleton
    /// </summary>
    public sealed class Singleton//sealed - blokada dziedziczenia z tej klasy
    {
        private static Singleton nullStaticZmienna = null;//Prywatnego statycznego pola z instancja własnej klasy z przypisana wartością null
        private static readonly object lock1 = new object();
        private int Licznik = 0;

        /// <summary>
        /// Publiczna statyczna properties, zwraca obiekt swojej klasy (wykorzystuje do tego pole instancjaNullStatic) i tworzy ten obiekt w sytuacji kiedy właściwość pobierana jest pierwszy raz
        /// </summary>
        public static Singleton InstancjaStaticProperties
        {
            get
            {
                lock (lock1)
                {
                    if (nullStaticZmienna == null)
                    {
                        nullStaticZmienna = new Singleton();
                    }
                    return nullStaticZmienna;
                }
            }
        }

        /// <summary>
        /// jakas metoda
        /// </summary>
        public void DoSomething(int licz)
        {
            for (int i = 0; i < licz; i++)
                MessageBox.Show("Licznik po raz : "+Licznik++.ToString());
                //Console.WriteLine("Licznik po raz {0}!", Licznik++);
        }

        /// <summary>
        /// Prywatny konstruktor, blokujacy możliwość tworzenia obiektów tej klasy normalną drogą i zapewni, że dostęp odbywać się będzie jedynie za pomocą naszej statycznej właściwości
        /// </summary>
        private Singleton()
        {
            Licznik = 1;
        }
    }
}
