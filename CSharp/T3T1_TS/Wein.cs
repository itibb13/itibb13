using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3T1
{
    public class Wein
    {
        public string name {get;set;}
        public Winzer winzer {get;set;}
        public string sorte {get; set;}
        public int jahrgang {get; set;}
        public int alkoholgehalt {get; set;}
        public string bild {get; set;}
        public string typ { get; set;}

        public Wein(string name, string typ,Winzer winzer, string sorte, int jahrgang, int alkoholgehalt, string bild)
        {
            this.name = name;
            this.winzer = winzer;
            this.sorte = sorte;
            this.jahrgang = jahrgang;
            this.alkoholgehalt = alkoholgehalt;
            this.bild = bild;
            this.typ = typ;

        }

        public override string ToString()
        {
            return this.winzer.name + ", " + this.name + " " + this.jahrgang;
        }

    }
}
