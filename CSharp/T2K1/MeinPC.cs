using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2K1
{
    public class MeinPC
    {
        
        private bool status;

        public MeinPC()
        {
            status = false;
        }

        public MeinPC(bool status)
        {
            this.status = status;
        }

        public bool Einschalten()
        { 
            return status = true ;
        }
        public bool  Ausschalten()
        { 
            return status = false;
        }
        
        public bool Status()
        { 
            return status;
        }

        public void Drucken()
        {
            Console.WriteLine("PC ist " + (this.status ? "eingeschaltet" : "ausgeschaltet"));
        }
    }
}
