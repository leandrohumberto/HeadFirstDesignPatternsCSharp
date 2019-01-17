using System;

namespace SingletonDesignPatternExamples.UsingLazyType
{
    /// <summary>
    /// A implementation of Singleton using System.Lazy<T>.
    /// </summary>
    sealed class Singleton
    {
        /// <summary>
        /// Instantiation of a System.Lazy<T> object in order to provide a laziness Singleton pattern implementation.
        /// </summary>
        private static readonly Lazy<Singleton> _lazy = new Lazy<Singleton>(() => new Singleton());

        /// <summary>
        /// Using simple laziness instantiation through System.Lazy<T>.
        /// </summary>
        public static Singleton Instance => _lazy.Value;

        private Singleton() { }
    }
}
