package at.fhb.iti.algodat.ue1;

import at.fhb.iti.algodat.ue1.balls.BasicBall;
import at.fhb.iti.algodat.ue1.grafics.BallsPanel;

public class Ball extends BasicBall implements Runnable
{

    private final BallRectangle theRectangle;
    private Thread _thread;
    private boolean _running;
    //public static int TOUCHING_BALLS = 0;

    public Ball(BallsPanel ballsPanel, BallRectangle br)
    {
        super(ballsPanel);
        theRectangle = br;

        // TODO Make them fly here
        _thread = new Thread(this);
        _thread.start();
        _running = true;
        Debugger.DEBUG_MODE = true;
        Debugger.info("Ball [" + this.number + "] created");
    }

    /**
     * 
     */
    public void run()
    {
        long startTime = System.currentTimeMillis();
        
        while (_running)
        {
            // ausserhalb des box
            while (!this.isTouching(theRectangle))
            {
                try
                {
                    Thread.sleep(25);
                } catch (InterruptedException e)
                {
                }
                move();
            }

            // wir besetzen die box 
            theRectangle.occupy();

            
            // innerhalb der box
            while (this.isTouching(theRectangle))
            {
                try
                {
                    Thread.sleep(25);
                } catch (InterruptedException e)
                {
                }
                move();
            }

            // rechteck freigeben
            theRectangle.free();
            
            
        } // end while
        
        long runTime = System.currentTimeMillis() - startTime;
        Debugger.info("Ball [" + this.number + "] after ["+ runTime + "] msec stopped. ");
    }

    /**
     * 
     */
    public void stop()
    {
        _running = false;
        Debugger.info("Trying to stop Ball [" + this.number + "] ... ");
    }

}
