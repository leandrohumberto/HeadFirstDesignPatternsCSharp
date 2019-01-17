namespace SingletonDesignPatternExamples.NotThreadSafe
{
    /// <summary>
    /// A non-thread safe implementation of Singleton pattern.
    /// </summary>
    sealed class Singleton
    {
        private static Singleton _instance = null;

        private Singleton() { }

        /// <summary>
        /// The instance creation is not thread safe.
        /// </summary>
        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }

                return _instance;
            }
        }
    }
}
