using System;

namespace Adapter_Base
{
    static class Adapter
    {
        static Adapter()
        {
            Console.WriteLine("Adapter::.actor");
        }

        public static bool ProcessOrder(string orderId)
        {
            Console.WriteLine("Adapter::ProcessOrder(string)");
            return true;
        }
    }

    class ProcessorBase
    {
        public ProcessorBase()
        {
            Console.WriteLine("ProcessorBase::.actor");
        }
    }

    class Processor : ProcessorBase
    {
        public Processor(string orderId)
        {
            Console.WriteLine("Processor::.actor(string)");
            Adapter.ProcessOrder(orderId);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Processor p = new Processor("G700");
            Console.ReadLine();
        }
    }
}

