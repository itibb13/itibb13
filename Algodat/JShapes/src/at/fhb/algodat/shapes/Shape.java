/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package at.fhb.algodat.shapes;

/**
 *
 * @author
 */
public abstract class Shape
{
	
	@Override
	public String toString()
	{
		return	"Das ist ein " + getID() + 
						", es hat " + getLines() + 
						" Linien, " + getNodes() + 
						" Eckpunkte und eine Fläche von " + getArea(); 
	}
	
	protected abstract String getID();
	protected abstract int getNodes();
	protected abstract int getLines();
	protected abstract double getArea();
}
