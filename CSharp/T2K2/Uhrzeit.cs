using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2K2
{
    public class Uhrzeit
    {
        private long sec;

        public Uhrzeit(int hh, int mm, int ss)
        {
            this.setUhrzeit(hh, mm, ss);
        }

        public void setUhrzeit(int hh, int mm, int ss)
        {
            sec = hh * 3600 + mm * 60 + ss;
        }

        public void addUhrzeit( Uhrzeit uhrzeit )
        {
            sec = sec + uhrzeit.sec;

            while (sec >= 86400)
            {
                sec = sec - 86400;
            }
        }

        public void subUhrzeit(Uhrzeit uhrzeit)
        {
            sec = sec - uhrzeit.sec;
            while (sec < 0)
            {
                sec = sec + 86400;
            }
        }

        public void diffUhrzeit(Uhrzeit uhrzeit)
        {

            long diff = 0;

            if (sec >= uhrzeit.sec)
                diff = sec - uhrzeit.sec;
            else
                diff = uhrzeit.sec - diff;

  
            long hh = diff / 3600;
            long min = diff % 3600 / 60;
            long ss = diff % 3600 % 60;

            Console.WriteLine("Differenz beträgt " + hh + ":"+min+":"+ss);
        }

        public void Drucken()
        {
            long hh, min, ss ;

            hh = sec / 3600;
            min = sec % 3600 / 60;
            ss = sec % 3600 % 60;

            Console.WriteLine(hh + ":" + min + ":" + ss);
        }

    }
}
