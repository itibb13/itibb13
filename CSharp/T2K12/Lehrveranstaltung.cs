using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2K12
{
    class Lehrveranstaltung
    {
        /*
         UML Notation
         
        -lvaId: string
        -lvaTitel: string
        -studentenListe: Student[]
        -notenListe: int[]
        ---------------------------------------------------
        +Lehrveranstaltung(lvaId: string, lvaTitel: string)
        +AddStudent(student: Student): bool
        +RemoveStudent(matrikelNummer: string): bool
        +SetNote(matrikelNummer: string, note: int): bool
        +NotenSchnitt(): double
        +Drucken()
        */

        internal string lvaID ;
        private string lvaTitel ;
        private Student[] studentenListe ;
        private int[] notenListe ;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="lvaID">ID der Lehrveranstaltung</param>
        /// <param name="lvaTitel">Name der Lehrveranstaltung</param>
        public Lehrveranstaltung (string lvaID, string lvaTitel)
        {
            this.lvaID = lvaID;
            this.lvaTitel = lvaTitel;
            studentenListe = new Student [10] ;
            notenListe = new int[10];
        }

        /// <summary>
        /// Fügt einen Studenten hinzu. Die Position des Studenten
        /// wird als Position in der Notenliste verwendet, da beide listen
        /// synchronisiert sind.
        /// </summary>
        /// <param name="student">Student</param>
        /// <returns>true, wenn Student hinzugefügt wurde</returns>
        public bool AddStudent(Student student)
        {
            for (int i = 0; i < this.studentenListe.Length; i++)
            {
                if (this.studentenListe[i] == null)
                {
                    this.studentenListe[i] = student;
                    this.notenListe[i] = 0; // muessen wir mitziehen
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Entfernt einen Studenten von der Lehrveranstaltung.
        /// Notenliste und Studentenliste sind synchron, daher
        /// muss die Note in der Notenliste auf 0 gesetzt werden,
        /// wenn der Student in der Studentenliste gelöscht wird.
        /// </summary>
        /// <param name="matrikelNummer">ID des Studenten</param>
        /// <returns>true, wenn Entfernen erfolgreich war</returns>
        public bool RemoveStudent(string matrikelNummer)
        {
            for (int i = 0; i < this.studentenListe.Length; i++)
            {
                // wichtige abfrage auf null, 
                // sonst gibts eine null pointer exception
                if ((studentenListe[i] != null) && (this.studentenListe[i].Matrikelnummer == matrikelNummer))
                {
                    this.studentenListe[i] = null;
                    this.notenListe[i] = 0; // muessen wir mitziehen
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Setzt eine Note für einen bestimmten Studenten.
        /// Als ID wird die Matrikelnummer verwendet.
        /// Daher muss zuerst die Position des Studenten in der Studenten-
        /// liste festgestellt werden. Notenliste und Studentenliste sind
        /// synchronisiert. Daher kann die Note an der entsprechenden
        /// Position in der Notenliste gesetzt werden.
        /// </summary>
        /// <param name="matrikelNummer">ID des Studenten</param>
        /// <param name="note">Note von 1 - 5</param>
        /// <returns></returns>
        public bool SetNote(string matrikelNummer, int note)
        {
            for (int i = 0; i < this.studentenListe.Length; i++)
            {
                // wichtige abfrage auf null, 
                // sonst gibts eine null pointer exception
                if ( (studentenListe[i] != null) && (this.studentenListe[i].Matrikelnummer == matrikelNummer) )
                {
                    this.notenListe[i] = note;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Rechnet den Notenschnitt für die Lehrveranstaltung aus.
        /// Es wird nur die Notenliste durchgearbeitet.
        /// </summary>
        /// <returns>Notenschnitt</returns>
        public double NotenSchnitt()
        {

            double summe = 0.0;
            double anz = 0.0;

            for (int i = 0; i < this.notenListe.Length; i++)
            {
                // wenn note = null, dann ist das
                // keine gültige schulnote
                if ( notenListe[i] != 0 )
                {
                    summe = summe + notenListe[i];
                    anz++;
                }
            } // end for

            // soll ja schon mal vorgekommen sein
            if ( anz != 0 )
                return (summe / anz) ;
            
            return 0.0;
        }

        
        /// <summary>
        /// Gibt Titel und ID der Lehrveranstaltung aus
        /// </summary>
        public void Drucken()
        {
           Console.WriteLine("Lehrveranstaltung [" + this.lvaTitel + "] ID: [" + this.lvaID + "]");
        }
    }
}
