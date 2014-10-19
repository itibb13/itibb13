using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2K1
{
    class Program
    {
        static void Main(string[] args)
        {
            MeinPC pc1 = new MeinPC();
            MeinPC pc2 = new MeinPC(true);

            pc1.Drucken();
            pc2.Drucken();
        }
    }
}
