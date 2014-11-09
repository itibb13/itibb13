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
public class Kassa 
{

  /**
   * Singleton Pattern
   */
  private static Kassa _INSTANCE = new Kassa() ;
  
  /**
   * 
   */
  private double _kassaBestand ;
  
  /**
   * 
   * @param betrag 
   */
  private Kassa()
  {
    _kassaBestand = Definitions.KASSA_ANFANGSBETRAG;
  }
  
  /**
   * 
   * @return 
   */
  public static Kassa getInstance()
  {
    return _INSTANCE;
  }
  
  /**
   * 
   * @param betrag 
   */
  public void einzahlen (double betrag)
  {
    _kassaBestand = _kassaBestand + betrag ;
  }
  
  /**
   * 
   * @param betrag
   * @throws at.fhb.schiffswerft.SpielVerlorenException
   */
  public void entnehmen (double betrag) throws SpielVerlorenException
  {
    double zwischenrechnung = _kassaBestand - betrag ;
    
    if ( 0.0 > zwischenrechnung )
      throw new SpielVerlorenException () ;
    else
      _kassaBestand = zwischenrechnung;
  }
  
  /**
   * 
   * @return 
   */
  public double getBestand ()
  {
    return _kassaBestand;
  }
  
  /**
   * 
   */
  public void printKassaBestand()
  {
    InOut.printString( toString() );
  }
  
  /**
   * 
   * @return 
   */
  public String toString()
  {
    return "Aktueller Kassabestand = " + _kassaBestand;
  }
}
