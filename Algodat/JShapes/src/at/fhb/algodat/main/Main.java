/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package at.fhb.algodat.main;

import at.fhb.algodat.shapes.Kreis;
import at.fhb.algodat.shapes.Ellipse;
import at.fhb.algodat.shapes.Quadrat;
import at.fhb.algodat.shapes.Rechteck;
import at.fhb.algodat.shapes.Shape;
import inout.them.fhb.at.InOutException;
import inout.them.fhb.at.InOut;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author
 */
public class Main 
{
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) 
    {
			// TODO code application logic here
			inout.them.fhb.at.InOut.printString("HELLO STRING");
			try
			{
				// TODO solange der User will, soll der user einen shape eingeben
				boolean weiter = true;
				Shape shape;
				
				while (weiter)
				{
					
					// TODO einen Shape einlesen
					int choice = InOut.readMenu("Bitte wählen Sie", "Rechteck@Quadrat@Ellipse@Kreis@Ende");
					
					switch (choice)
					{
						case 1:
							// TODO Rechteck generieren 
							shape = Rechteck.generate();
							InOut.printString( shape.toString() );
							// TODO Rechteck ausgeben
							break;
						case 2:
							// TODO Quadrat generieren 
							shape = Quadrat.generate();
							// TODO Quadrat ausgeben
							InOut.printString( shape.toString() );
							break;
						case 3:
							// TODO Ellipse generieren 
							shape = Ellipse.generate();
							// TODO Ellipse ausgeben
							InOut.printString( shape.toString() );

							break;
					   case 4:
							// TODO Kreis generieren
							 shape = Kreis.generate();
							InOut.printString( shape.toString() );
							// TODO Kreis ausgeben
							break;
						case 5:
							// TODO Ende
							weiter = false;
							break;
							// TODO weitere Shapes ?
						default:
							// TODO eigentlich löschen wenn alle shapes definiert sind
							InOut.printString("Unknown Shape");
							break;
					}
					
				}
				
				// TODO Daten ausgeben
				
				/*
				int choice = InOut.readMenu("Eingabe", "AAA@BBB@CCCC");
				InOut.printString( "Choice is " + choice);
				*/
		} catch (InOutException ex)
			{
				Logger.getLogger(Main.class.getName()).log(Level.SEVERE, null, ex);
			}
			
    }
    
} // end class
