using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2K12
{
    /*
     UML Notation:
     
    -lvaListe: Lehrveranstaltung[] 
    -name: string 
    =====================================
    +Studiengang(name: string)
    +AddLva(lva: Lehrveranstaltung): bool
    +RemoveLva(lvaId: string): bool
    +NotenSchnitt(): double
    +Drucken()
    */

    /// <summary>
    /// 
    /// </summary>
    class Studiengang
    {
        /// <summary>
        /// Vorgabe: ein Studiengang besteht bis zu max 10 Lehrveranstaltungen
        /// </summary>
        private Lehrveranstaltung[] lvaListe ;
        
        /// <summary>
        /// 
        /// </summary>
        private string name;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="name">Name des Studienganges</param>
        public Studiengang( string name )
        {
            this.name = name;
            this.lvaListe = new Lehrveranstaltung[10];
        }

        /// <summary>
        /// Fügt eine Lehrveranstaltung zum Studiengang hinzu.
        /// </summary>
        /// <param name="lva">eine Lehrveranstaltung</param>
        /// <returns>true, wenn Hinufügen erfolgreich war</returns>
        public bool AddLehrveranstaltung(Lehrveranstaltung lva)
        {
            for (int i = 0; i < lvaListe.Length; i++)
            {
                // wenn position leer, dann darf
                // die lehrveranstaltung hinzugefügt werden
                if (lvaListe[i] == null)
                {
                    lvaListe[i] = lva;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Entfernt Lehrveranstaltung aus dem Studiengang.
        /// Damit ist LVA nicht mehr Teil des Studienganges.
        /// </summary>
        /// <param name="lvaID">ID der zu entfernenden Lehrveranstaltung</param>
        /// <returns>Liefert true zurück, wenn LVA gelöscht wurde, sonst false</returns>
        public bool RemoveLehrveranstaltung (string lvaID)
        {
            for (int i = 0; i < this.lvaListe.Length; i++) 
            {
                // wichtige abfrage auf null, 
                // sonst gibts eine null pointer exception
                if ( (this.lvaListe[i] != null) && (this.lvaListe[i].lvaID == lvaID) )
                {
                    lvaListe[i] = null;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Rechnet den Notenschnitt des Studienganges aus.
        /// Dazu werden alle zum Studiengang gehörigen
        /// Lehrveranstaltungen abgefragt
        /// </summary>
        /// <returns>Notenschnitt</returns>
        public double NotenSchnitt()
        {
            double summe = 0.0;
            double anz = 0.0;

            for (int i = 0; i < this.lvaListe.Length; i++)
            {
                // wir bearbeiten nur eingetragenen
                // lehrveranstaltungen
                if (lvaListe[i] != null)
                {
                    summe = summe + lvaListe[i].NotenSchnitt();
                    anz++;
                } // end if
            } // end for

            if ( anz != 0 )
                return (summe / anz );
            return 0.0;
        }
        /// <summary>
        /// Gibt Name des Studienganges aus
        /// </summary>
        public void Drucken()
        {
            Console.WriteLine("Studiengang: [" + this.name + "]");
        }

    } // end class
}
