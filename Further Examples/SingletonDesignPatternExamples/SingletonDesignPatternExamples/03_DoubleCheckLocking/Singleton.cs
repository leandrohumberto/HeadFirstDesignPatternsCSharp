using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPatternExamples.DoubleCheckLocking
{
    /// <summary>
    /// An thread safe implementation attempt of Singleton pattern using double-check locking.
    /// </summary>
    sealed class Singleton
    {
        private static Singleton _instance;
        private static readonly object _padlock = new object();

        private Singleton() { }

        /// <summary>
        /// It still doesn't perform as well as other implementations.
        /// </summary>
        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton();
                        }
                    }
                }

                return _instance;
            }
        }
    }
}
