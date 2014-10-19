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
public class Rechteck extends Shape
{
	
	public static Shape generate() throws InOutException
	{
		double laenge = InOut.readDouble("Bitte Länge eingeben: ");
		double breite = InOut.readDouble("Bitte Breite eingeben: ");
		
		
		return new Rechteck(laenge, breite);
	}
	private final double _breite;
	private final double _laenge;

	Rechteck(double laenge, double breite)
	{
		_laenge = laenge;
		_breite = breite;
	}

	@Override
	protected String getID()
	{
		return "Rechteck";
	}

	@Override
	protected int getNodes()
	{
		return 4;
	}

	@Override
	protected int getLines()
	{
		return 4;
	}

	@Override
	protected double getArea()
	{
		return (_laenge * _breite );
	}
}
