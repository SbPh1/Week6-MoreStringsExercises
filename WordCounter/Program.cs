using System;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab, mitu sõna on lauses "Hello World!"

            string helloW = "Hello World!";

            //while

            //int i = 0;
            //int wordCounter = 1;

            /*while(i < helloW.Length)
            {
                if(helloW[i] == ' ')
                {
                    wordCounter++;
                }
                i++;
            }*/
            int wordCounter = 1;
            for (int i = 0; i < helloW.Length; i++)
            {
                if (helloW[i] == ' ')
                {
                    wordCounter++;
                }
            }

            Console.WriteLine($"Lauses {helloW} on {wordCounter} sõna");


        }
    }
    
}
