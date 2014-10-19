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
public class Kreis extends Ellipse
{
	private final double _radius;
	
	public Kreis(double radius)
	{
		super(radius, radius);
		_radius = radius;
	}	
	
	public static Shape generate() throws InOutException
	{
		double radius = InOut.readDouble("Bitte Radius eingeben: ");		
		return new Kreis (radius);
	}

	@Override
	protected String getID()
	{
		return "Kreis";
	}

	@Override
	protected int getNodes()
	{
		return 0;
	}

	@Override
	protected int getLines()
	{
		return 0;
	}

	@Override
	protected double getArea()
	{
		return (_radius * _radius * Math.PI);
	}

}