/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package at.fhb.schiffswerft;

import inout.them.fhb.at.InOut;

/**
 *
 * @author 
 */
public class Main 
{

  public static void main (String[] args)
  {
    // TODO das Spiel spielen
    
    Schiffswerft schiffswerft = new Schiffswerft();
    boolean weiterSpielen = true;
    
    // TODO solange der User will
    try
    {
      while (weiterSpielen)
      {
        // TODO ein Monat vergeht
        schiffswerft.einMonatVergeht();

          // TODO Tätigkeit in der Schiffswerft
          schiffswerft.taetigkeit();
      } // end while
    } catch (SpielVerlorenException ex)
    {
      InOut.printString("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
      InOut.printString("Sie sind in den Konkurs geschlittert.");
      InOut.printString("Sie haben daher das Spiel verloren.");
      InOut.printString("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
      
      System.exit(0);
    }
  } // end main
} // end class
