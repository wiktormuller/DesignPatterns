namespace Singleton
{
    // This Singleton implementation is called "double check lock". It is safe
    // in multithreaded environment and provides lazy initialization for the
    // Singleton object.
    public class MultithreadingSingleton
    {
        private MultithreadingSingleton() {}

        private static MultithreadingSingleton _instance;
        
        //We will use this property to prove that our Singleton really works.
        public string Value { get; set; }

        // We now have a lock object that will be used to synchronize threads
        // during first access to the Singleton.
        private static readonly object _lock = new object();

        // This conditional is needed to prevent threads stumbling over the
        // lock once the instance is ready.
        public static MultithreadingSingleton GetInstance(string value)
        {
            if (_instance == null)
            {
                // Now, imagine that the program has just been launched. Since
                // there's no Singleton instance yet, multiple threads can
                // simultaneously pass the previous conditional and reach this
                // point almost at the same time. The first of them will acquire
                // lock and will proceed further, while the rest will wait here.
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new MultithreadingSingleton();
                        _instance.Value = value;
                    }
                }
            }

            return _instance;
        }
    }
}