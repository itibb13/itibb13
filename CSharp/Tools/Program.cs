using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

// using ITIBB.Logging;

namespace Tools
{
    /*
    public class ThreadA
    {
        ITIBB.Logging.Logger logger = ITIBB.Logging.Logger.GetInstance();
        ITIBB.Logging.ConsoleLogAppender console = new ITIBB.Logging.ConsoleLogAppender(LogFormat.LEVEL_TIMESTAMP_MSG);

        public ThreadA() { }

        public void Run()
        {
            logger.Register(console);

            while (true)
            {
                logger.Info("ThreadA is running ... x");
            }
        }
    }

    public class ThreadB
    {
        ITIBB.Logging.Logger logger = ITIBB.Logging.Logger.GetInstance();
        ITIBB.Logging.ConsoleLogAppender console = new ITIBB.Logging.ConsoleLogAppender(LogFormat.LEVEL_TIMESTAMP_MSG);

        public ThreadB() { }

        public void Run()
        {
           logger.Register(console);

            while (true)
            {
                Console.WriteLine("ThreadB is running ............... x");
            }
        }
    }
    */

    class Program
    {
        static void Main(string[] args)
        {
            /*
            ITIBB.Logging.Logger logger = ITIBB.Logging.Logger.GetInstance();
            ITIBB.Logging.ConsoleLogAppender console = new ITIBB.Logging.ConsoleLogAppender(LogFormat.LEVEL_TIMESTAMP_MSG);
            logger.Register(console);
            ITIBB.Logging.LogLevel.EnableAll();


            ThreadA threadA = new ThreadA();
            ThreadB threadB = new ThreadB();

            //ITIBB.Logging.LogfileAppender logfile = new ITIBB.Logging.LogfileAppender("C:\\Users\\Roland\\Downloads\\logfile.txt");
            //logger.Register(console);
            //logger.Register(logfile);

            ITIBB.Utils.Header.Print("TEST", "BUBU");
            logger.Info("--- Start ---");

            Thread aThread = new Thread(new ThreadStart( threadA.Run ));
            Thread bThread = new Thread(new ThreadStart( threadB.Run ));


            // Start the thread
            aThread.Start();
            bThread.Start();

            // Spin for a while waiting for the started thread to become
            // alive:
            while (!aThread.IsAlive && !bThread.IsAlive ) ;

            // Put the Main thread to sleep for 1 millisecond to allow oThread
            // to do some work:
            Thread.Sleep(100000);

            // Request that oThread be stopped
            aThread.Abort();
            bThread.Abort();
      
            logger.Info("---- END ----");
            */
        }
    }
}
