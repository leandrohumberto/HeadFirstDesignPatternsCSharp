namespace SingletonDesignPatternExamples.FullLazyInstantiation
{
    /// <summary>
    /// A thread safe inplementation of Singleton pattern with fully lazy instantiation.
    /// </summary>
    sealed class Singleton
    {
        public static Singleton Instance => Nested._instance;

        private Singleton() { }

        private class Nested
        {
            /// <summary>
            /// // Explicit static constructor to tell C# compiler not to mark type as beforefieldinit
            /// </summary>
            static Nested() { }

            internal static readonly Singleton _instance = new Singleton();
        }
    }
}
