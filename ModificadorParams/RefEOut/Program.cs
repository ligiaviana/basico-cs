using System;

namespace RefEOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int triple;
            Calculator2.Triple(a, out triple);
            Console.WriteLine(triple);
        }
    }
}
