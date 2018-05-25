using System;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie groß möchten Sie das Feld?");
            String länge = Console.In.ReadLine();
            int length = Int32.Parse(länge);
            Console.WriteLine(length);
            Map map = new Map(length, length);


        }
    }
}
