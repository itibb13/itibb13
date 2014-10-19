using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2H7
{
    /// <summary>
    /// Klasse Angestellter, abgeleitet von Mitarbeiter
    /// </summary>
    class Angestellter : Mitarbeiter
    {
        /// <summary>
        /// Initialisiert ein Mitarbeiter Objekt
        /// </summary>
        /// <param name="personalnummer">Personalnummer</param>
        /// <param name="name">Name</param>
        /// <param name="adresse">Adresse</param>
        /// <param name="eintrittsjahr">Eintrittsjahr</param>
        /// <param name="stundenlohn">Stundenlohn</param>
         public Angestellter (int personalnummer, string name, 
                         string adresse, int eintrittsjahr,
                         double stundenlohn) 
                        : base (personalnummer,name,adresse,eintrittsjahr,stundenlohn)
        {
        }

        // Da fehlt doch was? 
        // Oder vielleicht doch nicht? 
        // ;-) 
 
    } // end class
} // end namespace
