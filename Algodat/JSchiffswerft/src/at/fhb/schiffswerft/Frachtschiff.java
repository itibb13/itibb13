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
public class Frachtschiff  extends Schiff 
{
  public Frachtschiff() 
  {
    super();
    InOut.printString("Es wird ein Frachtschiff [" + super.getSchiffsKennung() + "] gebaut");
    InOut.printString("Die Baukosten für Frachtschiff [" + super.getSchiffsKennung() + "] betragen " + getBauKosten() );
  }

  @Override
  public double getBauKosten() 
  {
    return Definitions.FRACHTSCHIFF_BAUKOSTEN;
  }

  @Override
  public double getGewinnProMonat() 
  {
    return Definitions.FRACHTSCHIFF_GEWINN_PRO_MONAT ;
  }

  public double getKostenVerschrottung()
  {
    return Definitions.FRACHTSCHIFF_BAUKOSTEN * 0.1;
  }
  
  public double getKostenAnstrich()
  {
    return Definitions.FRACHTSCHIFF_KOSTEN_ANSTRICH;
  }
    
  public boolean streichen() throws SpielVerlorenException
  {
    if ( getAnzahlAnstriche() <= Definitions.SCHIFFSANSTRICH_MAX)
    {
      resetRostFaktor();
      Kassa.getInstance().entnehmen( Definitions.FRACHTSCHIFF_KOSTEN_ANSTRICH );
      this.erhoeheAnzahlAnstriche();
      return true;
    }
    else
      InOut.printString("Schiff [" + this.getSchiffsKennung() +"] kann nicht mehr gestrichen werden. Es sollte verschrottet werden.");
    
    return false;
  }
}
