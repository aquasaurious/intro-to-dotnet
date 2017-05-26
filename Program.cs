using System;

namespace dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the name of your band?");
            string bandName = Console.ReadLine();

            Console.WriteLine("How many people are in your band?");
            int numberOfMembers = 0;
            if(!int.TryParse(Console.ReadLine(), out numberOfMembers))
            {
                Console.WriteLine("Invalid input");
                Environment.Exit(0);
            }

            if (numberOfMembers < 1)
            {
                Console.WriteLine("You must have at least 1 member");
                Environment.Exit(0);
            }
            else if (numberOfMembers == 1)
                Console.WriteLine(bandName + " is a solo act.");
            else if (numberOfMembers == 2)
                Console.WriteLine(bandName + " is a duo.");
            else if (numberOfMembers == 3)
                Console.WriteLine(bandName + " is a power trio, YESSSSSS!!!");
            else if (numberOfMembers > 8)
                Console.WriteLine(bandName + " must require a ridiculous per diem with " + numberOfMembers + " members.");
            else
                Console.WriteLine(bandName + " has " + numberOfMembers + " members.");
        }
    }
}
