using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Buch
    {
        private string inventarnummer;
        private string titel;
        private string autor;
        private int erscheinungsjahr;
        private string verlag;

        public Buch(string i, string t, string a, int e, string v)
        {
            inventarnummer = i;
            titel = t;
            autor = a;
            erscheinungsjahr = e;
            verlag = v;
        }

        public string Inventarnummer {get {return inventarnummer;}}

        public string Autor { get {return autor;}}

        public int Erscheinungsjahr { get { return erscheinungsjahr;}}
       
        public override string ToString()
        {
 	        return inventarnummer + "__" + titel + "__" + autor +"__"+ erscheinungsjahr+ "__"+ verlag ;
        }

        
    }
}
