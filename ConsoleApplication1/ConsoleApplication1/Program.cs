using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Methods;//aby mozna uzyc metody CheckNumberParity

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ilosc = 100;
            int wylosowanaLiczba, licznik = 0;
            int[] tablicaLiczb = new int[ilosc];//deklaracja tablicy liczb

            for (int i = 0; i < ilosc; i++)
            {
                int seed = Guid.NewGuid().GetHashCode();//losowanie liczb
                Random random = new Random(seed);
                wylosowanaLiczba = random.Next(0, 100);

                tablicaLiczb[i] = wylosowanaLiczba;//wypelnienie tablicy liczbami
            }

            Calc calc = new Calc();
            calc.CheckNumberParity1(3);//wywolanie metody niestatycznej z instancji klasy

            Calc.CheckNumberParity(3);//wywolanie metody statycznej bezpośrednio z klasy

            //za pomoca metody CheckNumberParity dostepnej w solucji wypisz na konsoli wszystkie parzyste liczby z tablicy tablicaLiczb[]
            //wskazowki - mozna uzyc for lub foreach oraz  Console.Write()  Console.WriteLine()
            //w jednym wierszu niech bedzie wypisane 10 liczb jak na skanie jpg
            //powyzej dostepna jest tablica tablicaLiczb[] wypelniona przypadkowymi liczbami z zakresu 0-100
            foreach (var item in tablicaLiczb)
            {
                
            }


        }
    }
}
