using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp8
{
    public class Kirja : Teos, ISivumaara
    {
        private int Sivumaara;    

        public Kirja(String n, Tekija t, int s)
        {
            Nimi = n;
            Tekija = t;
            Sivumaara = s;
        }

        public override void TulostaTiedot()
        {
            Console.WriteLine("Nimi: " + Nimi);
            //Console.WriteLine("Tekijä: " + Tekija);
            Tekija.tulostaTekija();
        }

        public void TulostaSivumaara()
        {
            Console.WriteLine("Sivumäärä: " + Sivumaara);
        }
    }
}