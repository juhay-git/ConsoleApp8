using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static List<Teos> lista;

        static void Main(string[] args)
        {
            lista = new List<Teos>();

            Tekija t1 = new Tekija("J.R.R. Tolkien", "1892");
            Tekija t2 = new Tekija("Alf Henrikson", "1905");

            lista.Add(new Kirja("Hobitti", t1, 546));
            lista.Add(new Kirja("Silmarillion", t1, 697));
            lista.Add(new Kirja("Antiikin tarinoita 1-2", t2, 331));

            lista.Add(new Lehti("Tekniikan maailma", "A-lehdet", 3, 1984, 78));

            lista.Add(new Aanite("Olavi Virta", "Suomilevyt", 1966));


            for (int i = 0; i < lista.Count; i++)
            {
                Teos t = lista.ElementAt(i);
                t.TulostaTiedot();
                //lista.ElementAt(i).TulostaTiedot();

                if (t is ISivumaara sivut)
                {
                    //ISivumaara sivut = t as ISivumaara;
                    sivut.TulostaSivumaara();
                }
                
                Console.WriteLine();
            }

            Console.WriteLine("Järjestetään lista..");
            lista.Sort();
            
            for (int i = 0; i < lista.Count; i++)
            {
                Teos t = lista.ElementAt(i);
                t.TulostaTiedot();
                //lista.ElementAt(i).TulostaTiedot();

                if (t is ISivumaara sivut)
                {
                    sivut.TulostaSivumaara();
                }
                
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
