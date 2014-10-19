using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2K12
{
    class Program
    {
        static void Main(string[] args)
        {

            // ----------------------------------------------
            // Header
            // ----------------------------------------------

            Console.WriteLine("#############################");
            Console.WriteLine("Übung    : T2K12");
            Console.WriteLine("Autor    : Pellegrini Roland");
            Console.WriteLine("#############################");
            Console.WriteLine("");
            // ----------------------------------------------
            // 
            // ----------------------------------------------

            // einen Studiengang anlegen
            Studiengang itibb13 = new Studiengang("ITIbb13");
            Console.WriteLine("[DEBUG] Studiengang initialisieren");
            itibb13.Drucken();
            Console.WriteLine("");

            // einige Lehrveranstaltungen anlegen
            Lehrveranstaltung prog = new Lehrveranstaltung("LVA01", "Programmieren I");
            Lehrveranstaltung prop = new Lehrveranstaltung("LVA02", "Propädeutikum");
            Lehrveranstaltung bwl = new Lehrveranstaltung("LVA03", "Betriebswirtschaftslehre");
            
            // das ist eine leer-veranstaltung
            // es gilt zu beweisen, dass der notenschnitt korrekt mit 0 gerechnet wird
            Lehrveranstaltung religion = new Lehrveranstaltung("LVA04", "Religion für Informatiker");

            Console.WriteLine("[DEBUG] LVA initialisieren");
            prog.Drucken();
            prop.Drucken();
            bwl.Drucken();
            religion.Drucken();
            Console.WriteLine("");

            // einige Studenten anlegen
            Student anton = new Student("Anton","MAT01");
            Student berta = new Student("Berta", "MAT02");
            Student casar = new Student("Casar", "MAT03");
            Console.WriteLine("[DEBUG] Studenten initialisieren");
            anton.Drucken();
            berta.Drucken();
            casar.Drucken();
            Console.WriteLine("");

            // lehrveranstaltungen zum studiengang hinzufügen
            itibb13.AddLehrveranstaltung(prog);
            itibb13.AddLehrveranstaltung(prop);
            itibb13.AddLehrveranstaltung(bwl);
            itibb13.AddLehrveranstaltung(religion);

            // student ist nicht einer lva hinzugefügt worden,
            // daher muss dieser aufruf ignoriert werden,
            // sonst gäbe es eine null-pointer exception
            prog.SetNote("MAT03", 1);

            // studenten zu einzelnen lehrveranstaltungen hinzufügen
            // und entsprechende noten setzen
            prog.AddStudent(anton);
            prog.AddStudent(berta);
            prog.AddStudent(casar);
            prog.SetNote("MAT01", 1);
            Console.WriteLine("[DEBUG] Note 1 in LVA Programmieren hinzugefügt, Notendurchschnitt = " + prog.NotenSchnitt());
            prog.SetNote("MAT02", 3);
            Console.WriteLine("[DEBUG] Note 3 in LVA Programmieren hinzugefügt, Notendurchschnitt = " + prog.NotenSchnitt());
            prog.SetNote("MAT03", 5);
            Console.WriteLine("[DEBUG] Note 5 in LVA Programmieren hinzugefügt, Notendurchschnitt = " + prog.NotenSchnitt());
            Console.WriteLine("");
         
            // dann propädeutikum
            prop.AddStudent(anton);
            prop.AddStudent(berta);
            prop.SetNote("MAT01", 1);
            prop.SetNote("MAT02", 3);

            // zum schluss bwl
            bwl.AddStudent(anton);
            bwl.SetNote("MAT01", 1);            

            // wir testen die fehlerbehandlung (returnwert = false)
            Console.WriteLine("[DEBUG] Rückgabewert der Methode SetNote() auf true/false prüfen"); 
            if ( prog.SetNote("MAT02", 3) )
                Console.WriteLine("Note kann nicht hinzugefügt werden, da\nStudent Berta [MAT02] nicht für die LVA PROG angemeldet ist");
            Console.WriteLine("[DEBUG] Stimmt ;-)");
            Console.WriteLine(""); 

            // Alle Durchschnitte ausgeben
            Console.WriteLine("[DEBUG] Notendurchschnitt aller LVAs ausgeben");
            Console.WriteLine("Notendurchschnitt LVA Programmieren : " + prog.NotenSchnitt());
            Console.WriteLine("Notendurchschnitt LVA Propädeutikum : " + prop.NotenSchnitt());
            Console.WriteLine("Notendurchschnitt LVA BWL           : " + bwl.NotenSchnitt());
            Console.WriteLine("Notendurchschnitt LVA Religion      : " + religion.NotenSchnitt());
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Notendurchschnitt Studiengang       : " + itibb13.NotenSchnitt());
            Console.WriteLine("");
        } // end main
    } // end class
} // end namespace
