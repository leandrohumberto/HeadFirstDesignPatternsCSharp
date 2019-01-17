namespace SingletonDesignPatternExamples.SimpleThreadSafety
{
    /// <summary>
    /// A simple thread safe implementation of Singleton pattern.
    /// </summary>
    sealed class Singleton
    {
        private static Singleton _instance;
        private static readonly object _padlock = new object();

        private Singleton() { }

        /// <summary>
        /// Performance suffers as a lock is acquired every time the instance is requested.
        /// </summary>
        public static Singleton Instance
        {
            get
            {
                lock(_padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }

                return _instance;
            }
        }
    }
}
