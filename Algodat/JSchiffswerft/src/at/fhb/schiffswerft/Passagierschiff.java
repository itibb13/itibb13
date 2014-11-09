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
public class Passagierschiff  extends Schiff {

  public Passagierschiff() 
  {
    super();
    InOut.printString("Es wird ein Passagierschiff [" + super.getSchiffsKennung() + "] gebaut");
    InOut.printString("Die Baukosten für Passagierschiff [" + super.getSchiffsKennung() + "] betragen " + getBauKosten() );
  }

  @Override
  public double getBauKosten() 
  {
    return Definitions.PASSAGIERSCHIFF_BAUKOSTEN;
  }

  @Override
  public double getGewinnProMonat() 
  {
    return Definitions.PASSAGIERSCHIFF_GEWINN_PRO_MONAT ;
  }
  
  public double getKostenVerschrottung()
  {
    return Definitions.PASSAGIERSCHIFF_BAUKOSTEN * 0.1;
  }
    
  public double getKostenAnstrich()
  {
    return Definitions.PASSAGIERSCHIFF_KOSTEN_ANSTRICH;
  }
  
  public boolean streichen()  throws SpielVerlorenException
  {
    if ( getAnzahlAnstriche() <= Definitions.SCHIFFSANSTRICH_MAX)
    {
      resetRostFaktor();
      Kassa.getInstance().entnehmen( Definitions.PASSAGIERSCHIFF_KOSTEN_ANSTRICH );
      this.erhoeheAnzahlAnstriche();
      return true;
    }
    else
      InOut.printString("Passagierschiff [" + this.getSchiffsKennung() +"] kann nicht mehr gestrichen werden. Es sollte verschrottet werden.");
    
    return false;
  }
}