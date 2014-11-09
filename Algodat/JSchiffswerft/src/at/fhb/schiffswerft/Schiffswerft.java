/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package at.fhb.schiffswerft;

import inout.them.fhb.at.InOut;
import inout.them.fhb.at.InOutException;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author
 */
public class Schiffswerft 
{
  private List<Schiff> _schiffe;
  private Kassa _kassa = Kassa.getInstance();
  
  private int _spielrunde;
          
  /**
   * 
   * 
   */
  public Schiffswerft()
  {
    // Kassa.initialisieren(0.0);
    _schiffe = new ArrayList();
    _spielrunde = 0;
  }
  
  /**
   * 
   * 
   * 
   * @throws SpielVerlorenException 
   */
  void einMonatVergeht() throws SpielVerlorenException 
  {
    InOut.printString("----------------------------------");
    InOut.printString("Spielrunde : " + _spielrunde );
    InOut.printString("----------------------------------");
    _spielrunde++;    
    
    List<Schiff> gesunkeneSchiffe = new ArrayList<Schiff>();
    
    for (Schiff x: _schiffe)
    {
      // TPDP Alle Schiffe fahren und rosten
      x.rostetEinenMonat();
      if ( x.istVerrostet() )
      {
        double bergungskosten =  Definitions.BERGUNGSKOSTEN * x.getBauKosten();
        InOut.printString("Das Schiff [" + x.getSchiffsKennung() + "] ist leider wegen Rostschaden gesunken.");
        InOut.printString("Die Bergungskosten für Schiff [" + x.getSchiffsKennung() + "] betragen " + bergungskosten);
        
        _kassa.entnehmen( bergungskosten );
        
        // TODO Schiff ausgliedern
        gesunkeneSchiffe.add(x);
      }
      else
      {
        double gewinn = x.getGewinnProMonat();
         InOut.printString("Schiff [" + x.getSchiffsKennung() + "] bringt einen Gewinn vom [" + gewinn + "] ein.");
        _kassa.einzahlen( gewinn );
      }
      // anzahl der anstriche ausgeben
      InOut.printString("Schiff [" + x.getSchiffsKennung() + "] hat [" + x.getAnzahlAnstriche() + "] Anstriche.");
    }
    // alle gesunkenen Schiffe aus der Werft rausschmeissen  
    _schiffe.removeAll(gesunkeneSchiffe);
    
    // if ( _kassa.getBestand()  ) throw new SpielVerlorenException();
    
    // TODO wenn zuviel Rost, dann sinkt das Schiff
    
    // TODO Alle schiffe bringen geld
   
    // wieviele schiffe sind noch aktiv
    InOut.printString("Derzeit sind " + _schiffe.size() + " Schiffe aktiv." );
    
    // wieviele schiffe sind heute gesunken
    if ( gesunkeneSchiffe.size() == 0 )
      InOut.printString ("Heute ist kein Schiff aufgrund Rostmängel gesunken." );      
    else
      InOut.printString ("Heute ist/sind leider " + gesunkeneSchiffe.size() + " Schiffe aufgrund Rostmängel gesunken." );
      
    // Kassabestand ausgeben
    _kassa.printKassaBestand();

    //
    InOut.printString("");
    
  }

  public void taetigkeit() throws SpielVerlorenException
  {
    try {
      Schiff schiff = null;
      int schiffsnummer = 0;
      int choice = InOut.readMenu("Was wollen Sie tun?", "Frachtschiff bauen@Tankschiff bauen@Passagierschiff bauen@Schiff streichen@Schriff verschrotten@nichts tun");
      switch (choice)
      {
        case 1:
          schiff = new Frachtschiff();
          _schiffe.add( schiff );
          _kassa.entnehmen( schiff.getBauKosten() );
          break;
        case 2:
          schiff = new Tankschiff();
          _schiffe.add( schiff );
          _kassa.entnehmen( schiff.getBauKosten() );
          break;
        case 3:
          schiff = new Passagierschiff();
          _schiffe.add( schiff );
          _kassa.entnehmen( schiff.getBauKosten() );
          break;
        case 4:
          schiffsnummer = InOut.readInt("> Schiffsnummer eingeben: ");
          schiffStreichen(schiffsnummer);
          break;
        case 5:
          schiffsnummer = InOut.readInt("> Schiffsnummer eingeben: ");
          schiffVerschrotten(schiffsnummer);
          break;          
        default:
          // Do nothing
          break;
      } // end switch
    } 
    catch (InOutException ex) {
      // Do nothing, just log
      // Logger.getLogger(Schiffswerft.class.getName()).log(Level.SEVERE, null, ex);
    }

  }

  /**
   * 
   * @param nr 
   */
  private void schiffStreichen (int nr) throws SpielVerlorenException
  {  
      Iterator itr = _schiffe.iterator();
      Schiff s = null;
      boolean gefunden = false;
      
      while(itr.hasNext() && gefunden != true ) 
      {
         s = (Schiff) itr.next();
         if ( nr == s.getSchiffsKennung() )
         {
          gefunden = true;
         }
      }
      
    if (gefunden)
    {
      if ( s.streichen() )
        InOut.printString("Das Schiff [" + nr +"] wurde um [" + 
              s.getKostenAnstrich() + "] neu gestrichen."); 
    }
    else
      InOut.printString("Schiff [" + nr +"] existiert nicht.");
  }

  /**
   * 
   * @param nr 
   */
  private void schiffVerschrotten (int nr) throws SpielVerlorenException 
  {
      Iterator itr = _schiffe.iterator();
      Schiff s = null;
      boolean gefunden = false;
      
      while(itr.hasNext() && gefunden != true ) 
      {
         s = (Schiff) itr.next();
         if ( nr == s.getSchiffsKennung() )
         {
           gefunden = true;
         }
      }
      
    if (gefunden)
    {
      _schiffe.remove(s);
      Kassa.getInstance().entnehmen( s.getKostenVerschrottung() );
      InOut.printString("Das Schiff [" + nr +"] wurde um [" + 
              s.getKostenVerschrottung() + "]verschrottet."); 
    }
    else
      InOut.printString("Schiff [" + nr +"] existiert nicht.");
  
  }


}
