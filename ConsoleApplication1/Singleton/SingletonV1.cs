using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Singleton
{
    /// <summary>
    /// http://www.csharpindepth.com/Articles/General/Singleton.aspx
    /// </summary>
    sealed class SingletonV1
    {
        private static SingletonV1 instance = null;

        private SingletonV1() { }
        /// <summary>
        /// As hinted at before, the above is not thread-safe. Two different threads could both 
        /// have evaluated the test if (instance==null) and found it to be true, then both create instances, 
        /// which violates the singleton pattern. 
        /// Note that in fact the instance may already have been created before the expression is evaluated,
        /// but the memory model doesn't guarantee that the new value of instance will be seen 
        /// by other threads unless suitable memory barriers have been passed.
        /// </summary>
        public static SingletonV1 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonV1();
                }

                return instance;
            }
        }


    }

    //Second version - simple thread-safety

    public sealed class SingletonV2
    {
        private SingletonV2() { }

        private static SingletonV2 instance;
        private static readonly object padlock = new object();

        public static SingletonV2 Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SingletonV2();
                    }
                    return instance;
                }
            }
        }

    }


    //Third version - attempted thread-safety using double-check locking

    public sealed class SingletonV3
    {
        private SingletonV3() { }

        private static SingletonV3 instance;
        private static readonly object padlock = new object();

        public SingletonV3 Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonV3();
                        }
                    }
                }
                return instance;
            }
        }
    }

    //Fourth version - not quite as lazy, but thread-safe without using locks

    public sealed class SingletonV4
    {
        private static readonly SingletonV4 instance = new SingletonV4();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static SingletonV4()
        {
        }

        private SingletonV4()
        {
        }

        public static SingletonV4 Instance
        {
            get
            {
                return instance;
            }
        }
    }


    //Fifth version - fully lazy instantiation

    public sealed class SingletonV5
    {
        private SingletonV5()
        {
        }

        public static SingletonV5 Instance { get { return Nested.instance; } }

        private class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }

            internal static readonly SingletonV5 instance = new SingletonV5();
        }
    }

    //Sixth version - using .NET 4's Lazy<T> type

    public sealed class SingletonV6
    {
        private static readonly Lazy<SingletonV6> lazy =
            new Lazy<SingletonV6>(() => new SingletonV6());

        public static SingletonV6 Instance { get { return lazy.Value; } }

        private SingletonV6()
        {
            
        }
    }
}
