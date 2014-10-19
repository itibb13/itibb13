using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2K4
{
    class Spieler
    {
        private string name;
        private Random rand;

        public Spieler(string name, Random rand)
        {
            this.name = name;
            this.rand = rand;
        }

        public int RateZahl()
        {
            return ( rand.Next(0,10) ) ; 
        }

        public string Name()
        {
            return this.name;
        }

    }
}
