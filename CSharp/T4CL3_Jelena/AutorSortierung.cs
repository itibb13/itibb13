using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class AutorSortierung : IComparer<Buch>
    {
        public int Compare(Buch a1, Buch a2)
        {
            return a1.Autor.CompareTo(a2.Autor);
        }
    }
}
