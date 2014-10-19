using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    /*
    namespace Logging
    {
        /// <summary>
        /// 
        /// </summary>
        public sealed class Logger
        {
            /// <summary>
            ///  This static call is specified to be executed only when 
            ///  an instance of this class is created or a static member 
            ///  is referenced.
            ///  
            ///  This construct is also known as "Singleton class".
            /// </summary>
            static readonly Logger instance = new Logger();

            // private List<ILogAppender> members = new List<ILogAppender>();
            private List<ILogAppender> members = new List<ILogAppender>();


            /// <summary>
            /// The private constructor
            /// </summary>
            private Logger() { }

            /// <summary>
            /// 
            /// </summary>
            private System.Object lockThis = new Object();

            /// <summary>
            /// Return the Logger instance 
            /// </summary>
            /// <returns></returns>
            public static Logger GetInstance()
            {
                return instance;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="iLogAppender"></param>
            /// <returns></returns>
            public void Register(ILogAppender logAppender)
            {
                if (false == members.Contains(logAppender))
                    members.Add(logAppender);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public void Unregister(ILogAppender logAppender)
            {
                members.Remove(logAppender);
            }

            /// <summary>
            /// Log an information message.
            /// </summary>
            /// <param name="message">message</param>
            public void Info(object message)
            {
                Info(message, null);
            }

            /// <summary>
            /// Log an information message
            /// </summary>
            /// <param name="message">message</param>
            /// <param name="exeption">exepction</param>
            public void Info(object message, Exception exception)
            {
                if (ITIBB.Logging.LogLevel.isEnabled(ITIBB.Logging.LogLevel.INFO))
                    Log(LogLevel.INFO, DateTime.Now, message, exception);
            }

            /// <summary>
            /// Log an information message.
            /// </summary>
            /// <param name="message">message</param>
            public void Warning(object message)
            {
                Warning(message, null);
            }

            /// <summary>
            /// Log an information message
            /// </summary>
            /// <param name="message">message</param>
            /// <param name="exeption">exepction</param>
            public void Warning(object message, Exception exception)
            {
                if (ITIBB.Logging.LogLevel.isEnabled(ITIBB.Logging.LogLevel.WARNING))
                    Log(LogLevel.WARNING, DateTime.Now, message, exception);
            }

            /// <summary>
            /// Log an information message.
            /// </summary>
            /// <param name="message">message</param>
            public void Error(object message)
            {
                Error(message, null);
            }

            /// <summary>
            /// Log an information message
            /// </summary>
            /// <param name="message">message</param>
            /// <param name="exeption">exepction</param>
            public void Error(object message, Exception exception)
            {
                if (ITIBB.Logging.LogLevel.isEnabled(ITIBB.Logging.LogLevel.ERROR))
                    Log(LogLevel.ERROR, DateTime.Now, message, exception);
            }

            /// <summary>
            /// Log an information message.
            /// </summary>
            /// <param name="message">message</param>
            public void Exception(object message)
            {
                Exception(message, null);
            }

            /// <summary>
            /// Log an information message
            /// </summary>
            /// <param name="message">message</param>
            /// <param name="exeption">exepction</param>
            public void Exception(object message, Exception exception)
            {
                if (LogLevel.isEnabled(LogLevel.EXCEPTION))
                    Log(LogLevel.EXCEPTION, DateTime.Now, message, exception);
            }

            /// <summary>
            /// Log an information message.
            /// </summary>
            /// <param name="message">message</param>
            public void Fatal(object message)
            {
                Fatal(message, null);
            }

            /// <summary>
            /// Log an information message
            /// </summary>
            /// <param name="message">message</param>
            /// <param name="exeption">exepction</param>
            public void Fatal(object message, Exception exception)
            {
                if (ITIBB.Logging.LogLevel.isEnabled(ITIBB.Logging.LogLevel.FATAL))
                    Log(LogLevel.FATAL, DateTime.Now, message, exception);
            }
            /// <summary>
            /// Log an information message.
            /// </summary>
            /// <param name="message">message</param>
            public void Debug(object message)
            {
                Debug(message, null);
            }

            /// <summary>
            /// Log an information message
            /// </summary>
            /// <param name="message">message</param>
            /// <param name="exeption">exepction</param>
            public void Debug(object message, Exception exception)
            {
                if (ITIBB.Logging.LogLevel.isEnabled(ITIBB.Logging.LogLevel.DEBUG))
                    Log(LogLevel.DEBUG, DateTime.Now, message, exception);
            }

            /// <summary>
            /// Log an information message.
            /// </summary>
            /// <param name="message">message</param>
            public void Userdefined(object message)
            {
                Userdefined(message, null);
            }

            /// <summary>
            /// Log an information message
            /// </summary>
            /// <param name="message">message</param>
            /// <param name="exeption">exepction</param>
            public void Userdefined(object message, Exception exception)
            {
                if (ITIBB.Logging.LogLevel.isEnabled(ITIBB.Logging.LogLevel.USERDEFINED))
                    Log(LogLevel.USERDEFINED, DateTime.Now, message, exception);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="level"></param>
            /// <param name="timestamp"></param>
            /// <param name="message"></param>
            /// <param name="exception"></param>
            private void Log(int level, DateTime timestamp, object message, Exception exception)
            {
                if (members.Count == 0)
                    return;

                lock (lockThis)
                {
                    LogMessage msg = new LogMessage(level, timestamp, message, exception);

                    foreach (ILogAppender appender in members)
                    {
                        appender.Notify(msg);
                    }
                } // end lock
            }

        } // end class 

        /// <summary>
        /// 
        /// </summary>
        public sealed class LogLevel
        {
            /// <summary>
            /// 
            /// </summary>
            private LogLevel()
            { }

            /// <summary>
            /// 
            /// </summary>
            public static readonly int INFO = 0;
            public static readonly int WARNING = 1;
            public static readonly int ERROR = 2;
            public static readonly int EXCEPTION = 3;
            public static readonly int FATAL = 4;
            public static readonly int DEBUG = 5;
            public static readonly int USERDEFINED = 6;

            /// <summary>
            /// 
            /// </summary>
            public static readonly string[] loglevel = new string[7] { "INFO", "WARNING", "ERROR", "EXCEPTION", "FATAL", "DEBUG", "USERDEF" };

            /// <summary>
            /// 
            /// </summary>
            private static bool[] loggable = new bool[7] { true, true, true, true, true, false, false };

            /// <summary>
            /// Enable one specific loglevel
            /// </summary>
            /// <param name="level">loglevel</param>
            public static void Enable(int level)
            {
                if (level >= LogLevel.INFO && level <= LogLevel.USERDEFINED)
                    loggable[level] = true;
            }

            /// <summary>
            /// Enables all loglevels, including Debug and User-defined levels
            /// </summary>
            public static void EnableAll()
            {
                for (int i = LogLevel.INFO; i <= LogLevel.USERDEFINED; i++)
                    loggable[i] = true;
            }

            /// <summary>
            /// Disable one specific loglevel
            /// </summary>
            /// <param name="level">loglevel</param>
            public static void Disable(int level)
            {
                if (level >= LogLevel.INFO && level <= LogLevel.USERDEFINED)
                    loggable[level] = false;
            }

            /// <summary>
            /// Disables all Loglevels
            /// </summary>
            public static void DisableAll()
            {
                for (int i = LogLevel.INFO; i < LogLevel.USERDEFINED; i++)
                    loggable[i] = true;
            }

            /// <summary>
            /// Check if the given level is enabled or not
            /// </summary>
            /// <param name="level"></param>
            /// <returns></returns>
            public static bool isEnabled(int level)
            {
                if (level >= LogLevel.INFO && level <= LogLevel.USERDEFINED)
                    return loggable[level];
                return false;
            }

        } // end class LogLevel

        /// <summary>
        /// 
        /// </summary>
        public sealed class LogMessage
        {
            /// <summary>
            /// 
            /// </summary>
            private int level;

            /// <summary>
            /// 
            /// </summary>
            private object message;

            /// <summary>
            /// 
            /// </summary>
            private Exception exception;

            /// <summary>
            /// 
            /// </summary>
            private DateTime timestamp;

            /// <summary>
            /// 
            /// </summary>
            /// <param name="level"></param>
            /// <param name="timestamp"></param>
            /// <param name="message"></param>
            /// <param name="exception"></param>
            public LogMessage(int level, DateTime timestamp, object message, Exception exception)
            {
                this.level = level;
                this.timestamp = timestamp;
                this.message = message;
                this.exception = exception;
            }

            /// <summary>
            /// Return the level
            /// </summary>
            public int Level
            {
                get { return level; }
            }

            /// <summary>
            /// Return the timestamp
            /// </summary>
            public DateTime Timestamp
            {
                get { return timestamp; }
            }

            /// <summary>
            /// Return the Exception
            /// </summary>
            public Exception Exception
            {
                get { return exception; }
            }

            /// <summary>
            /// 
            /// </summary>
            public object Message
            {
                get { return message; }
            }

        } // end class LogMessage

        /// <summary>
        /// 
        /// </summary>
        public sealed class LogFormat
        {
            /// <summary>
            /// Timestamp format = "yyyy-MM-dd HH':'mm':'ss"
            /// Example: "2013-12-31 23:59:59"
            /// </summary>
            public static readonly string DATE_TIME = "yyyy-MM-dd HH':'mm':'ss";

            /// <summary>
            /// Timestamp format = "HH:mm:ss.ffff"
            /// Example: "2013-12-31 23:59:59.1234" 
            /// </summary>
            public static readonly string DATE_TIME_MSEC = "yyyy-MM-dd HH':'mm':'ss.ffff";

            /// <summary>
            /// Output is comma-separated
            /// </summary>
            public static readonly string LEVEL_TIMESTAMP_MSG_DELIM = "{0};{1};{2}";

            /// <summary>
            /// Output is more human-readable
            /// </summary>
            public static readonly string LEVEL_TIMESTAMP_MSG = "{0} {1,-10} {2}";


            /// <summary>
            /// Only the message will be displayed 
            /// </summary>
            public static readonly string MSG_ONLY = "{2}";
        } // end class

        /// <summary>
        /// 
        /// </summary>
        public interface ILogAppender
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="message"></param>
            void Notify(LogMessage message);

        } // end interface

        /// <summary>
        /// 
        /// </summary>
        public class ConsoleLogAppender : ILogAppender
        {
            /// <summary>
            /// 
            /// </summary>
            private string output_format = LogFormat.LEVEL_TIMESTAMP_MSG;

            /// <summary>
            /// 
            /// </summary>
            private string timestamp_format = LogFormat.DATE_TIME;

            /// <summary>
            /// 
            /// </summary>
            public ConsoleLogAppender()
                : this(LogFormat.LEVEL_TIMESTAMP_MSG,
                LogFormat.DATE_TIME)
            { }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="output_format"></param>
            public ConsoleLogAppender(string output_format)
                : this(output_format, LogFormat.DATE_TIME)
            { }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="output_format"></param>
            /// <param name="timestamp_format"></param>
            public ConsoleLogAppender(string output_format, string timestamp_format)
            {
                this.output_format = output_format;
                this.timestamp_format = timestamp_format;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="message"></param>
            public void Notify(LogMessage message)
            {
                string logtext = String.Format(output_format,
                                                message.Timestamp.ToString(timestamp_format),
                                                LogLevel.loglevel[message.Level],
                                                message.Message);
                Console.WriteLine(logtext);
                Console.Out.Flush(); // sicher ist sicher 
            }

        } // end class


        public class LogfileAppender : ILogAppender
        {
            /// <summary>
            /// 
            /// </summary>
            private string output_format = LogFormat.LEVEL_TIMESTAMP_MSG_DELIM;

            /// <summary>
            /// 
            /// </summary>
            private string timestamp_format = LogFormat.DATE_TIME_MSEC;

            /// <summary>
            /// 
            /// </summary>
            private System.IO.StreamWriter file;

            /// <summary>
            /// 
            /// </summary>
            /// <param name="logfile"></param>
            public LogfileAppender(string logfile)
                : this(logfile, true)
            {
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="logfile"></param>
            /// <param name="append"></param>
            public LogfileAppender(string logfile, bool append)
            {
                file = new System.IO.StreamWriter(@logfile, append);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="message"></param>
            public void Notify(LogMessage message)
            {
                string logtext = String.Format(output_format,
                                    message.Timestamp.ToString(timestamp_format),
                                    LogLevel.loglevel[message.Level],
                                    message.Message);

                file.WriteLine(logtext);
                file.Flush();
            }
        } // end class
    } // end namespace logging
    */
}
