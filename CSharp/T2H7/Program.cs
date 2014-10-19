using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2H7
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------
            // Header
            // ----------------------------------------------
            ITIBB.ExerciseInfo.Print("T1H7", "Pellegrini Roland");

            //Console.WriteLine("#############################");
            //Console.WriteLine("Übung    : T1H7");
            //Console.WriteLine("Autor    : Pellegrini Roland");
            //Console.WriteLine("#############################");
            //Console.WriteLine("\n");

            // Zwei Hinweise bzw Informationen:
            //
            // 1. Klassenhierarchie
            // Die klassenhierarchie sieht bei mir so aus: 
            // Mitarbeiter (=abstrakte Superklasse)
            // +--> Arbeiter 
            // +--> Angestellter 
            // +--> Manager 
            //      +--> CEO (abgeleitet von Manager)
            //
            // Die Klasse CEO ist also von der Klasse 
            // Manager abgeleitet und die wiederum von
            // Klasse Mitarbeiter. Als Grund gilt die 
            // Annahme, dass die CEO Klasse eine weitere 
            // Ausprägung der Klasse Manager ist.
            // 
            // 2. Polymorphie
            // Damit die Polymorphie richtig funktioniert, 
            // müssen die Methoden in der Superklasse mit
            // virtual und in den abgeleiteten Klassen mit
            // override markiert werden.
            //
            // Wenn man das nicht macht, dann muss mittels
            // is-Operator den Klassentyp festgestellt
            // und eine explizite Umwandlung vorgenommen
            // werden, damit dann erst die richtige Methode
            // gefunden und ausgeführt wird. Bei grossen 
            // Hierarchien kann das ziemlich mühsam werden. 
            //
            // Hier zwei Beispiele. Im Bsp 1 wird ohne
            // viel Trara das gesamte Array abgearbeitet 
            // und die Lohnkosten von allen Mitarbeitern 
            // berechnet. Im Bsp 2 muss wegen der fehlenden
            // dynamischen Bindung immer zuerst festgestellt
            // werden, um welchen Typ von Objekt es sich handelt,
            // und erst dann kann richtige Methode Berechnen 
            // aufgerufen werden. 
            //
            // Bsp 1 mit virtual/override
            // foreach (Mitarbeiter mitarbeiter in personal)
            // {
            //   lohnkosten += mitarbeiter.Berechnen();
            // }
            //
            // Bsp 2 ohne virtual/override
            // foreach (object mitarbeiter in personal)
            // {
            //   if (mitarbeiter is Arbeiter)
            //      lohnkosten += ((Arbeiter)mitarbeiter).Berechnen();
            //   else if (mitarbeiter is Angestellter)
            //      lohnkosten += ((Angestellter)mitarbeiter).Berechnen();
            //   usw
            // }
            // 

            // ----------------------------------------------
            // Definition and Initialisierung von Variablen
            // ----------------------------------------------

            // hier speichern wir das gesamte personal
            Mitarbeiter[] personal = new Mitarbeiter[10];

            // wir adden jetzt ein paar mitarbeiter
            personal[0] = new CEO(1, "Chef McSalad", "7000 Eisenstadt, Chefstrasse 1", 1961, 40.0, 1000, 1000);

            personal[1] = new Manager(2, "Larry Checkman", "7000 Eisenstadt, Managerweg 1", 1972, 30.0, 500);
            personal[2] = new Manager(3, "Tony Mahoni", "7000 Eisenstadt, Managerweg 2", 1973, 30.0, 500);
            
            personal[3] = new Angestellter(4, "Dreibein Fredi", "7000 Eisenstadt, Bürogasse 1", 1984, 20.0);
            personal[4] = new Angestellter(5, "Chuck Norris", "7000 Eisenstadt, Bürogasse 2", 1985, 20.0);
            personal[5] = new Angestellter(6, "Britney Spareribs", "7000 Eisenstadt, Bürogasse 3", 1986, 20.0);
            
            personal[6] = new Arbeiter(7, "Otto Kringer", "7000 Eisenstadt, Arbeitersackgasse 1", 1997, 10.0, 300.0);
            personal[7] = new Arbeiter(8, "Berny Burnes", "7000 Eisenstadt, Arbeitersackgasse 2", 1998, 10.0, 200.0);
            personal[8] = new Arbeiter(9, "H.P. Hackler", "7000 Eisenstadt, Arbeitersackgasse 3", 1999, 10.0, 100.0);
            personal[9] = new Arbeiter(10, "Danny Dancer", "7000 Eisenstadt, Arbeitersackgasse 4", 2014, 10.0, 0.0);

            // jetzt gehen wir das gesamte Array durch, 
            // geben Mitarbeiterdetails aus und
            // berechnen die Gesamtlohnkosten pro Monat
 
            double lohnkosten = 0.0 ; // zur berechnung der gesamtkosten
            double monatsgehalt = 0.0; // pro Mitarbeiter 

            // TEST: wir löschen einen arbeiter aus dem array
            // damit wollen wir prüfen, ob die abfrage auf null
            // funktioniert (siehe unten)
            personal[3] = null;

            foreach (Mitarbeiter mitarbeiter in personal)
            {
                // wir prüfen ob objekt existiert
                // wenn wir das nicht machen, dann wirft das
                // programm eine null reference exception und
                // das wollen wir nicht ;-)
                if (mitarbeiter == null)
                    continue;

                monatsgehalt = mitarbeiter.Berechnen(); // <--- dynamische bindung
                mitarbeiter.Drucken(); // <--- dynamische bindung
                
                // wir geben das Monatsgehalt gleich unterhalb
                // des Outputs an, sehr praktisch
                Console.WriteLine("Monatsgehalt    : " + monatsgehalt);
                Console.WriteLine(""); // wegen der übersichtlichkeit
                
                // wir summieren alle gehälter
                lohnkosten +=  monatsgehalt;
            }

            // jetzt geben wir noch schnell die gesamten lohnkosten aus
            // und wir sind fertig mit der Übung
            Console.WriteLine("Kostenübersicht:");
            Console.WriteLine("==============================");
            Console.WriteLine("Lohnkosten p.M.: " + lohnkosten );

            Console.WriteLine("\n                         q.e.d\n");
        } // end main
    } // end class
} // end namespace
