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
public class Ellipse extends Shape
{
	private final double _radius1; 
	private final double _radius2;
	public Ellipse (double radius1, double radius2)
	{
		_radius1 = radius1;
		_radius2 = radius2;
	}
	
	public static Shape generate() throws InOutException
	{
		double radius1 = InOut.readDouble("Bitte Radius1 eingeben: ");
		double radius2 = InOut.readDouble("Bitte Radius2 eingeben: ");
		
		return new Ellipse (radius1, radius2);
	}

	@Override
	protected String getID()
	{
		return "Ellipse";
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
		return (_radius1 * _radius2 * Math.PI);
	}

}
