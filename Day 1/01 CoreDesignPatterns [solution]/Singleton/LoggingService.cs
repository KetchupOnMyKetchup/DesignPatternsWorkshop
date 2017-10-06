using System;

namespace Singleton
{
    // Marked Sealed as to prevent any deriving, which could add instances.
    public sealed class LoggingService : IDisposable
    {
        // Implements Double-Check Locking Pattern ==> https://msdn.microsoft.com/en-us/library/ff650316.aspx
        private static readonly object _lockObject = new object();

        // Holds reference of instance of itself.
        // Make volatile to ensure that assignment to variable completes before 
        // variable can be accessed
        private static volatile LoggingService _instance;

        // Might create loging service here, but is is thread safe?
        //private static LoggingService _instance = new LoggingService();
        private readonly string _returnValue;

        // Private constructor is dead-giveaway of LoggingService object - prevents 
        // other classes from creating instances of it.
        // Note here how object implements lazy-instantiation -- does not
        // instantiate object until absolutely needed by application.
        private LoggingService()
        {
            _returnValue = "Successfully Logged";
        }

        // Here is how we instantiate LoggingService: Publically-scoped static property 
        // that returns reference of class.
        // Property determine whether object has been instantiated.
        public static LoggingService Instance
        {
            get
            {
                if (_instance == null)
                {
                    // CLR cannot ensure thread safety
                    // Double-check locking approach solves thread concurrency issues
                    // Add 'lock' statement to ensure only thread can enter critical section of code
                    // 'lock' will block until it is released 
                    lock (_lockObject)
                        // Implement "double-check" lock to prevent multiple threads from
                        // creating separate instances of singleton at same time
                        if (_instance == null)
                            //Finally, instantiate singleton class
                            _instance = new LoggingService();
                }

                return _instance;
            }
        }

        public void Dispose()
        {
            // Release objects 
            _instance = null;
        }

        public string LogMessage(string message)
        {
            // Implement Logging Code.
            // Most likely a factory pattern that 
            // would return the current logging framework.

            return _returnValue;
        }
    }
}