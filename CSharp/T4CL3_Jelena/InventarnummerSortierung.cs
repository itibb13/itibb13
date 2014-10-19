using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class InventarnummerSortierung : IComparer<Buch>
    {
        public int Compare(Buch b1, Buch b2)
        {
            return b1.Inventarnummer.CompareTo(b2.Inventarnummer);
        }


            }
}
