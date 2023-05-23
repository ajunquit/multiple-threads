using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiple_threads
{
    public class SubProcessA
    {
        public void Execute()
        {
            Console.WriteLine("SubProcessA running.");
            Thread.Sleep(1000);
            Console.WriteLine("SubProcessA executed.");
        }
    }

    public class SubProcessB
    {
        public void Execute()
        {
            Console.WriteLine("SubProcessB running.");
            Thread.Sleep(10000);
            Console.WriteLine("SubProcessB executed.");
        }
    }

    public class SubProcessC
    {
        public void Execute()
        {
            Console.WriteLine("SubProcessC running.");
            Thread.Sleep(1000);
            Console.WriteLine("SubProcessC executed.");
        }
    }

    public class SubProcessD
    {
        public void Execute()
        {
            Console.WriteLine("SubProcessD running.");
            Thread.Sleep(7000);
            Console.WriteLine("SubProcessD executed.");
        }
    }

    public class SubProcessE
    {
        public void Execute()
        {
            Console.WriteLine("SubProcessE running.");
            Thread.Sleep(1000);
            Console.WriteLine("SubProcessE executed.");
        }
    }
}
