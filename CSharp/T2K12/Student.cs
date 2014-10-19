using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2K12
{
    class Student
    {
        private string name;
        private string matrikelNummer;

        /// <summary>
        /// Initialisiert eine Instanz Student
        /// </summary>
        /// <param name="name">Name des Studenten</param>
        /// <param name="matrikelNummer">matrikelNummer</param>
        public Student(string name, string matrikelNummer)
        {
            this.name = name;
            this.matrikelNummer = matrikelNummer;
        }

        /// <summary>
        /// Liefert Matrikelnummer zurück
        /// </summary>
        public string Matrikelnummer
        {
            get { return this.matrikelNummer; }
            // set { matrikelNummer = value; }
        } // end getter-setter

        /// <summary>
        /// Gibt Student und Matrikelnummer auf Console aus
        /// </summary>
        public void Drucken()
        {
            Console.WriteLine("Student: [" + this.name + "] matrikelNummer: [" + this.matrikelNummer + "]");
        }
    } // end class
}
