using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Tekija
    {
        private String nimi;
        private String syntymaaika;

        public Tekija(String nimi, String syntymaaika)
        {
            this.nimi = nimi;
            this.syntymaaika = syntymaaika;
        }

        public void tulostaTekija()
        {
            Console.WriteLine("Tekijä: " + nimi + " Syntymäaika: " + syntymaaika);
        }

    }
}
