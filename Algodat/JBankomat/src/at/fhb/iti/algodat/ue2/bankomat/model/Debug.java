/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package at.fhb.iti.algodat.ue2.bankomat.model;

/**
 *
 * @author roland
 */
public class Debug
{

  private static boolean debug = true;

  /**
   * 
   * @param i
   * @param theState 
   */
  public static void debug(int i, BankomatState theState)
  {
    if (debug)
    {
      System.out.println("Digit input [" + i + "] changes state " + theState.name());
    }
  }

  /**
   * 
   * @param theState 
   */
  public static void debug(BankomatState theState)
  {
    if (debug)
    {
      System.out.println("State changes to " + theState.name());
    }
  }
  /**
   * 
   * @param fromState
   * @param toState 
   */
  public static void debug(BankomatState fromState, BankomatState toState)
  {
    if (debug)
    {
      System.out.println("State changes from " + fromState + " to " + toState.name());
    }
  }
}
