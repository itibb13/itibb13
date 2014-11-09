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
   * Diese Konstruktor ist privat, daher muss jeder Aufruf 
   * ueber die Methode getInstance() gemacht werden
   * @param betrag 
   */
  private Kassa()
  {
    _kassaBestand = Definitions.KASSA_ANFANGSBETRAG;
  }
  
  /**
   * Liefert eine Instanz zurueck
   * @return 
   */
  public static Kassa getInstance()
  {
    return _INSTANCE;
  }
  
  /**
   * Es wird ein Betrag in die Kassa eingezahlt
   * @param betrag 
   */
  public void einzahlen (double betrag)
  {
    _kassaBestand = _kassaBestand + betrag ;
  }
  
  /**
   * Hier wird Geld aus der Kassa entnommen.
   * Wenn kein Geld mehr in der Kassa ist, dann wird eine
   * Exception geworfen
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
   * Liefert den aktuellen Kassabestand zuruech
   * @return 
   */
  public double getBestand ()
  {
    return _kassaBestand;
  }
  
  /**
   * Druckt den Kassabestand aus (mit Text)
   */
  public void printKassaBestand()
  {
    InOut.printString( toString() );
  }
  
  /**
   * Druckt den aktuellen Kassabestand aus
   * @return 
   */
  public String toString()
  {
    return "Aktueller Kassabestand = " + _kassaBestand;
  }
}
