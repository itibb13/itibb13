using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace T4DB2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // unsere pre-prepared sql statements
            string sqlCreateDB = "if not exists (select * from sys.databases where name='PersonenDB') " + 
                                " create database [PersonenDB] else begin drop database [PersonenDB] " + 
                                " create database [PersonenDB] end";

            string sqlCreateTbl = "create table Person (SVNummer varchar(10) not null, " + 
                                " Name varchar(100), Adresse varchar(100), Telnummer varchar(20)," + 
                                " Email varchar(100) constraint PK_SVNummer primary key (SVNummer) )";

            string sqlSelectAllPersons = "select * from Person";

            // um eigene datenbanken anlegen zu können, müssen wir uns zuerst zur master-db verbinden
            // wenn keine datenbank an gelegt werden kann, dann drucken wir den tracestack auf die console aus
            // und ziehen die notbremse (exit program)

            DatabaseConnection dbConn = new DatabaseConnection ("Data Source=localhost;Initial Catalog=master;Integrated Security=True");

            Console.Write("\nDatenbank anlegen ... ");
            try
            {
                dbConn.Connect();
                dbConn.ExecuteQuery(sqlCreateDB);
                // zur sicherheit zerstören wir das objekt gleich wieder,
                // weil wir anschliessend auf die personendb umschalten wollen
                // die methode dbConn.disconnect() wird eigentlich automatisch ausgeführt,
                // wir führen sie hier nur zwecks dokumentation nochmals an
                dbConn.Disconnect();
                dbConn = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
                Environment.Exit(1);
            }
            Console.WriteLine("erledigt");

            // jetzt verbinden wir uns zur eigentlichen datenbank und legen die tabelle an.
            // wenn keine tabelle angelegt werden kann, dann drucken wir den tracestack auf die console aus
            // und ziehen erst recht die notbremse (exit program).
            // wie gesagt, die methode disconnect wäre hier überflüssig, da die methode innerhald
            // der databaseconnection klasse aufgerufen wird, aber es dient zur veranschaulichung
            Console.Write("\nTabelle in der Datenbank anlegen ... ");
            try
            {
                dbConn = new DatabaseConnection("Data Source=localhost;Initial Catalog=PersonenDB;Integrated Security=True");
                dbConn.Connect();
                dbConn.ExecuteQuery(sqlCreateTbl);
                dbConn.Disconnect();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
                Environment.Exit(1);
            }
            Console.WriteLine("erledigt");

            // jetzt schreiben wir ein paar daten in die tabelle
            // wenn das nicht klappen sollte, dann passiert was? .... richtig: notbremse !

            // aber zuerst generieren wir uns ein datatable, welches wir weiter unten 
            // ein paar mal wiederverwenden werden.
            // und warum ein datatable? weil im jahr 2014 schreiben wir keine sql statements mehr ;-)
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Reset();
            dt.TableName = "Person";

            dt.Columns.Add("SVNumer", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Adresse", typeof(string));
            dt.Columns.Add("Telnummer", typeof(string));
            dt.Columns.Add("Email", typeof(string));

            // wir speichern die ninja turtles in die datenbank 
            dt.Rows.Add("001", "Leonardo", "Sheraton Hotel", "+1(0)111", "Leonardo@ninjaturtles.com");
            dt.Rows.Add("002", "Michelangelo", "Sheraton Hotel", "+1(0)222", "michelangelo@ninjaturtles.com");
            dt.Rows.Add("003", "Donatello", "Sheraton Hotel", "+1(0)333", "donatella@ninjaturtles.com");
            dt.Rows.Add("004", "Raphael", "Sheraton Hotel", "+1(0)444", "raphael@ninjaturtles.com");
            dt.Rows.Add("005", "Splinter", "Sheraton Hotel", "+1(0)555", "splinter@ninjaturtles.com");
            dt.Rows.Add("006", "April O'Neil", "Sheraton Hotel", "+1(0)666", "april.oneil@ninjaturtles.com");
            dt.Rows.Add("007", "Casey Jones", "Sheraton Hotel", "+1(0)777", "casey.jones@ninjaturtles.com");
            dt.Rows.Add("008", "Shredder", "Sheraton Hotel", "+1(0)888", "shredder@ninjaturtles.com");
            dt.Rows.Add("009", "Karai", "Sheraton Hotel", "+1(0)999", "karai@ninjaturtles.com");

            // geniale sache. kein insert statement, sondern einfach 
            // die datatable in die datenbank-tabelle importieren.
            // wenn trotzdem was schiefgeht --> catch the ex and die4ever
            Console.Write("\nAlle Datensätze in die Datenbank schreiben ... ");
            try
            {
                dbConn.Connect();
                dbConn.InsertDataTable("Person", dt);
                dbConn.Disconnect();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
                Environment.Exit(1);
            }
            Console.WriteLine("erledigt");

            // jetzt sind wir endlich dort, wo wir mal etwas auslesen können.
            // ausser es passiert etwas unerwartetes, dann full stop und exit.
            // wir recyclen die datatable.
            // übrigens: was ist der Unterschied zw clear und reset? ;-)
            dt.Clear();
            dt.Reset(); 

            try
            {
                dbConn.Connect();
                dt = dbConn.ReturnDataTable(sqlSelectAllPersons);
                dbConn.Disconnect();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
                Environment.Exit(1);
            }

            // jetzt geben wir alle personendaten wieder aus
            // das wars dann eigentlich schon wieder.
            Console.WriteLine("\nAlle Datensätze ausgeben ...");

            foreach (System.Data.DataRow row in dt.Rows)
            {
                Console.WriteLine(String.Format("{0,-3} | {1,-12} | {2,-12} | {3,-8} | {4} ",
                                   row["SVNummer"], row["Name"], row["Adresse"],
                                   row["Telnummer"],row["Email"]));
            }

            Console.WriteLine("\nÜbungsbeispiel erfolgreich abgeschlossen.\nBitte Taste betätigen!");
            Console.ReadKey();            
        }
    } // end class
} // end namespace
