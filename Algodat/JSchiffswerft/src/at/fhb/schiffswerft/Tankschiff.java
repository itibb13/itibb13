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
class Tankschiff extends Schiff 
{

  public Tankschiff() 
  {
    super();
    InOut.printString("Es wird ein Tankschiff [" + super.getSchiffsKennung() + "] gebaut");
    InOut.printString("Die Baukosten für  Tankschiff [" + super.getSchiffsKennung() + "] betragen " + getBauKosten() );
  }

  @Override
  public double getBauKosten() 
  {
    return Definitions.TANKSCHIFF_BAUKOSTEN;
  }

  @Override
  public double getGewinnProMonat() 
  {
    return Definitions.TANKSCHIFF_GEWINN_PRO_MONAT ;
  }
  
  public double getKostenVerschrottung()
  {
    return Definitions.TANKSCHIFF_BAUKOSTEN * 0.1;
  }

  public double getKostenAnstrich()
  {
    return Definitions.TANKSCHIFF_KOSTEN_ANSTRICH;
  }
  
  public void streichen()  throws SpielVerlorenException
  {
    if ( getAnzahlAnstriche() <= Definitions.SCHIFFSANSTRICH_MAX)
    {
      resetRostFaktor();
      Kassa.getInstance().entnehmen( Definitions.TANKSCHIFF_KOSTEN_ANSTRICH );
    }
  }
  
  
}
