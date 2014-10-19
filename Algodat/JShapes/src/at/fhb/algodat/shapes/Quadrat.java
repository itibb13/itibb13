/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package at.fhb.algodat.shapes;

import inout.them.fhb.at.InOut;
import inout.them.fhb.at.InOutException;

/**
 *
 * @author
 */
public class Quadrat extends Rechteck
{
	public Quadrat (double laenge)
	{
		super (laenge, laenge);
	}
	
	public static Shape generate() throws InOutException
	{
		double laenge = InOut.readDouble("Bitte Seitenlaenge eingeben: ");
		return new Quadrat (laenge);
	}

	
}
