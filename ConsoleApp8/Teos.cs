using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp8
{
    public abstract class Teos : IComparable<Teos>
    {
        public String Nimi;
        public Tekija Tekija;

        public abstract void TulostaTiedot();

        public int CompareTo(Teos vertaileTeos)
        {
            if (vertaileTeos == null)
                return 1;
            else
                return this.Nimi.CompareTo(vertaileTeos.Nimi);
        }

    }
}