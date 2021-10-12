using System;

namespace MoreStringsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab sõna "racecar" tagurpidi
            //*kasutame for-tsüklit

            string raceCar = "racecar";

            for (int i = raceCar.Length - 1; i >= 0; i--)
            {
                Console.Write(raceCar[i]);
            }
        }
    }
}
