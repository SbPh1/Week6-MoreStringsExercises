using System;

namespace ForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab sõne "Hello World!" pikkust Length omaduse kasutamata
            string helloW = "Hello World!";
            int charCounter = 0;

            foreach (char c in helloW)
            {
                charCounter++;
            }

            Console.WriteLine($"Lause pikkus {helloW} on {charCounter}.");
        }
    }
}
