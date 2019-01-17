namespace SingletonDesignPatternExamples.WithoutUsingLocks
{
    /// <summary>
    /// A thread safe implementation of Singleton pattern without using locks.
    /// </summary>
    sealed class Singleton
    {
        private static readonly Singleton _instance = new Singleton();

        /// <summary>
        /// If the class has static members other than Instance, 
        /// the first reference to those members will involve creating the instance.
        /// </summary>
        public Singleton Instance => _instance;
        
        /// <summary>
        /// Explicit static constructor to tell C# compiler not to mark type as beforefieldinit. Affects performance.
        /// </summary>
        static Singleton() { }

        private Singleton() { }
    }
}
