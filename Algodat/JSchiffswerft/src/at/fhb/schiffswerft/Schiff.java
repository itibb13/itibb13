/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package at.fhb.schiffswerft;

import inout.them.fhb.at.InOut;

/**
 *
 * @author roland
 */
public abstract class Schiff 
{

  private static int _naechsteFreieNummer = 0;
  private static int _anzahlAktiveSchiffe = 0;
  private static int _anzahlGesunkeneSchiffe = 0;

  private int _schiffsKennung ;
  private double _rostFaktor;
  private int _anzahlAnstriche ;
  
  public Schiff()
  {
    _schiffsKennung = _naechsteFreieNummer;
    _naechsteFreieNummer ++;
    _rostFaktor = 1.0;
    _anzahlAnstriche = 1;
    InOut.printString("");
  }
  
  /**
   * 
   * 
   * @return 
   */
  public boolean istVerrostet() 
  {
    boolean v = false;
 
    if ( _rostFaktor < Definitions.MIN_ROST_FAKTOR )
    {
      _anzahlAktiveSchiffe =  _anzahlAktiveSchiffe - 1;
      _anzahlGesunkeneSchiffe = _anzahlGesunkeneSchiffe + 1;
      v = true;
    }
    return v ;
  }

  /**
   * 
   */
  void rostetEinenMonat() 
  {
    _rostFaktor = _rostFaktor * Definitions.ROST_PRO_MONAT;
    InOut.printString("Schiff ["+ _schiffsKennung +"] hat einen Rostfaktor von ["+ _rostFaktor +"]");
  }

  protected void resetRostFaktor()
  {
    _rostFaktor = 1.0;
  }
  /**
   * 
   */
  protected void erhoeheAnzahlAnstriche()
  {
    this._anzahlAnstriche++;
  }
  
  /**
   * 
   * @return 
   */
  public int getAnzahlAnstriche()
  {
    return _anzahlAnstriche;
  }
  
  abstract boolean streichen() throws SpielVerlorenException ;
  
  abstract double getKostenAnstrich() ;
  
  abstract double getKostenVerschrottung();
  
  /**
   * 
   * @return 
   */
  public int getSchiffsKennung()
  {
    return _schiffsKennung;
  }
  
  /**
   * 
   * 
   * @return 
   */
  abstract double getBauKosten();

  /**
   * 
   * 
   * @return 
   */
  abstract double getGewinnProMonat();
  
} // end class
