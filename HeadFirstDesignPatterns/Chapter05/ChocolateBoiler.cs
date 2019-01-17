using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
    /// <summary>
    /// A thread-safe implementation of Singleton pattern (credits: http://csharpindepth.com/Articles/General/Singleton.aspx).
    /// </summary>
    class ChocolateBoiler
    {
        private bool _empty;
        public bool Empty => _empty;

        private bool _boiled;
        public bool Boiled => _boiled;

        public static ChocolateBoiler Instance => Inner._instance;

        private ChocolateBoiler()
        {
            _empty = true;
            _boiled = false;
        }

        public void Fill()
        {
            if (Empty)
            {
                _empty = false;
                _boiled = false;
                // fill the boiler with a milk/chocolate mixture
            }
        }

        public void Drain()
        {
            if (!Empty && Boiled)
            {
                // drain the boiled milk and chocolate
                _empty = true;
            }
        }

        public void Boil()
        {
            if (!Empty && !Boiled)
            {
                _boiled = true;
            }
        }

        #region Singleton Pattern implementation using an inner class
        private class Inner
        {
            internal static ChocolateBoiler _instance = new ChocolateBoiler();

            /// <summary>
            /// Explicit static constructor to tell C# compiler not to mark type as beforefieldinit.
            /// </summary>
            static Inner() { }
        }
        #endregion
    }
}
