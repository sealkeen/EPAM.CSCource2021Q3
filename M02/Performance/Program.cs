using System;
using System.Diagnostics;

namespace Performance
{
    class C : IComparable<C> {
        public int i = 0;
        public override bool Equals(object obj)
        {
            return ((C)obj).i == this.i;
        }
        public int CompareTo(C that) 
        {
            if (this.i < that.i) return -1;
            if (this.i > that.i) return 1;
            return 0;
        }
    }
    struct S : IComparable<S> 
    {
        public int i;
        public int CompareTo(S that)
        {
            if (this.i < that.i) return -1;
            if (this.i > that.i) return 1;
            return 0;
        }
    }
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var deltaStart = System.Diagnostics.Process.GetCurrentProcess().PrivateMemorySize64;
            Console.WriteLine("Private memory size before initializing (kb): " +
                $"{Process.GetCurrentProcess().PrivateMemorySize64 / 1024}"); 

            const int sz = 100000;
            Random rnd = new Random();
            C[] cArray = new C[sz];
            for (int i = 0; i < sz; i++) 
            {
                cArray[i] = new C();
                cArray[i].i = rnd.Next(int.MaxValue);
            }

            S[] sArray = new S[100000];
            for (int i = 0; i < sz; i++) 
            {
                sArray[i].i = rnd.Next(int.MaxValue);
            }

            var deltaInitilized = System.Diagnostics.Process.GetCurrentProcess().PrivateMemorySize64;

            Console.WriteLine($"Private memory size after initializing arrays (kb) : " +
                $"{Process.GetCurrentProcess().PrivateMemorySize64 / 1024}");

            Console.WriteLine( $"Difference between initialization (kb) = " +
                $"{ (deltaInitilized - deltaStart) / 1024 }" );

            var beforeSort = DateTime.Now;
            Array.Sort(cArray);
            var afterSort = DateTime.Now;
            Console.WriteLine($"Time of sorting class array (ms): {(afterSort - beforeSort).Milliseconds}");

            beforeSort = DateTime.Now;
            Array.Sort(sArray);
            afterSort = DateTime.Now;

            Console.WriteLine($"Time of sorting struct array (ms): {(afterSort - beforeSort).Milliseconds}");
            Console.ReadKey();
        }
    }
}
