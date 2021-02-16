using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp8
{
    public class Lehti : Teos, ISivumaara
    {
        private int Numero;
        private int Vuosikerta;
        private int Sivumaara;

        private String Kustantaja;
        public Lehti(String n, String k, int nn, int vv, int s)
        {
            Nimi = n;
            Kustantaja = k;
            Numero = nn;
            Vuosikerta = vv;
            Sivumaara = s;
        }

        public Lehti(String n, String k, int nn, int vv)
        {
            Nimi = n;
            Kustantaja = k;
            Numero = nn;
            Vuosikerta = vv;  
        }

        public override void TulostaTiedot()
        {
            Console.WriteLine("Nimi: " + Nimi);
            Console.WriteLine("Kustantaja: " + Kustantaja);
            Console.WriteLine("Numero: " + Numero + "/" + Vuosikerta);
        }

        public void TulostaSivumaara()
        {
            Console.WriteLine("Sivumäärä: " + Sivumaara);
        }
    }
}