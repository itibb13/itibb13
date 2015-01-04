package at.fhb.iti.algodat.ue1;

import at.fhb.iti.algodat.ue1.balls.BasicBallRectangle;
import at.fhb.iti.algodat.ue1.defs.Definitions;

public class BallRectangle extends BasicBallRectangle
{
  private boolean _isOccupied;
  private static int _TOUCHING_BALLS;
  
  public BallRectangle(int d, int e, int f, int g)
  {
    super(d, e, f, g);
    _isOccupied = false;
  }

  public synchronized boolean occupy()
  {               
    // TODO
    while (this._isOccupied )
    {
      try
      {
        wait();
      } catch (InterruptedException ex)
      {
      }
    }

    // das ist der schmäh
    // wir setzen die variable genau hier 
    // nach der while-schleife auf true !!!
    //_isOccupied = true; // gilt für 1 ball
    
    // ansonsten gilt für mehrere bälle
    _TOUCHING_BALLS++;
    
    Debugger.debug("Number of touching balls: " + _TOUCHING_BALLS);
    
    if ( _TOUCHING_BALLS >= Definitions.MAX_TOUCHING_BALLS)
    {
        
      Debugger.info("Box has reached the maximum of its capacity. Reason: [" + 
              _TOUCHING_BALLS +"] >= [" + Definitions.MAX_TOUCHING_BALLS +"]");
      
      _isOccupied = true;
    }
    Debugger.info("Box is occupied by [" + _TOUCHING_BALLS +"] balls");    
    return _isOccupied;
  }

  /**
   * 
   * @return 
   */
  public boolean isOccupied()
  {
    return _isOccupied;
  }

  /**
   * 
   */
  public synchronized void free()
  {
    // TODO
    _isOccupied = false;
    _TOUCHING_BALLS--;
    Debugger.info("Box freed. Notification have been sent to other balls");
    Debugger.debug("Number of touching balls: " + _TOUCHING_BALLS);
    notifyAll();
  }

}
