using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2K9___Punkt_und_Strecke
{
    class Program
    {
        static void Main(string[] args)
        {

            Punkt salzburg = new Punkt(1, 1);
            Punkt wien = new Punkt(0, 0);
            Punkt eisenstadt = new Punkt(10, 10);

            Strecke autobahn = new Strecke(salzburg, wien);
            double entfernung = autobahn.Laenge();
            Console.WriteLine("Entfernung zw. Salzbug und Wienauf der Autobahn beträgt: " + entfernung);

            Strecke landstrasse = new Strecke (wien, eisenstadt);
            entfernung = landstrasse.Laenge();
            Console.WriteLine("Entfernung zw. Wien und Eistenstadt auf der Landstrasse beträgt : " + entfernung);

        }
    } // end class program



class Punkt
{
    /// <summary>
    /// UML: -x : int
    /// </summary>
    private int x;
    
    /// <summary>
    /// UML : -y : int
    /// </summary>
    private int y;
    
    /// <summary>
    /// Konstruktor
    /// lt. Angabe: +Punkt(i:int, j:int)
    /// </summary>
    /// <param name="i">i entspricht der x-koordinate</param>
    /// <param name="j">j entspricht der y-koordinate</param>
    public Punkt(int i, int j)
    {
        x = i;
        y = j;
    }
    /// <summary>
    /// liefert x-koordinate zurück
    /// </summary>
    public int X
    { get { return x; } }
    
    /// <summary>
    /// liefert y-koordinate zurück
    /// </summary>
    public int Y
    { get { return y; } }

    /// <summary>
    /// rap: liefert X Koordinate zurück
    /// </summary>
    /// <returns></returns>
    /* public int GetX()
    {
        return x;
    }
    */

} // end class Punkt



    /// <summary>
    /// 
    /// </summary>
class Strecke
{ 
    /// <summary>
    /// UML: -p : Punkt
    /// </summary>
    private Punkt p;
    /// <summary>
    /// UML -q : Punkt
    /// </summary>
    private Punkt q;

    /// <summary>
    /// Erzeugt eine Strecke aus zwei Punkten
    /// und liefert die Distanz zw den Punkten zurück
    /// </summary>
    /// <param name="p1">Startpunkt</param>
    /// <param name="p2">Endpunkt</param>
    public Strecke(Punkt p1, Punkt p2)
    {
        p = p1;
        q = p2;
    }

    /// <summary>
    /// Berechnet die Länge zw zwei Punkten.
    /// </summary>
    /// <returns>strecke im einheitswert</returns>
    public double Laenge()
    {
        double ergebnis = 0;

        double x1x2 = 0;
        double y1y2 = 0;
 
        // x1x2 = (q.X - p.X) ^ 2;
        x1x2 = Math.Pow( (q.X - p.X) , 2 );
        y1y2 = Math.Pow( (q.Y - p.Y) , 2 );

        ergebnis = Math.Sqrt( (x1x2 + y1y2) );
        // ergebnis = Math.Pow((x1x2 + y1y2), -2 ); 
        
        return ergebnis;
    }
}   // end class Strecke

} // end namespace
