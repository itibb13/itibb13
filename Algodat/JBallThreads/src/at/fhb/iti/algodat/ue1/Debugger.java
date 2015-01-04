/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package at.fhb.iti.algodat.ue1;

/**
 *
 * @author roland
 */
public class Debugger
{

    public static boolean DEBUG_MODE = true;

    /**
     * 
     * @param message 
     */
    public static void debug(String message)
    {
        print(message, DEBUG_MODE);
    }
    
    /**
     * 
     * @param message 
     */
    public static void info (String message)
    {
        print(message, true);
    }
    
    /**
     * 
     * @param message
     * @param active 
     */
    private static void print (String message, boolean active)
    {
        if (active)
        {
            System.out.println(message);
        }
    }
    
}
