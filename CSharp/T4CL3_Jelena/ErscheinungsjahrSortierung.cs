using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class ErscheinungsjahrSortierung : IComparer<Buch>
    {
        public int Compare(Buch c1, Buch c2)
        {
            return c1.Erscheinungsjahr.CompareTo(c2.Erscheinungsjahr);
        }
    }
}
