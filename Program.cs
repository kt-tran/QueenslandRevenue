using System;

namespace QueenslandRevenue
{
    class Program
    {
        static void Main()
        {
            //Task 1: Display the competition's motto surrounded by a border
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+ The Stars shine in Queensland for n11159243. +");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");

            //Task 2: Prompt user for number of contestants
            int lastYear, thisYear;
            const int LOWER = 0, UPPER = 30;

            //while 
            Console.Write("Please enter the number of contestants who entered in last year's competition: ");
            lastYear = Convert.ToInt32(Console.ReadLine());
            if (lastYear >= LOWER && lastYear <= UPPER)
            {
                Console.WriteLine("Confirmed. {0} contestants entered in last year's competition.",
                    lastYear);
            }
            else
            {
                Console.WriteLine("Invalid entry. Please enter a number between 0 and 30.");
            }
            Console.Write("Please enter the number of contestants who entered in this year's competition: ");
            thisYear = Convert.ToInt32(Console.ReadLine());

            //Task 3: Display input data & revenue for this year's competition
            int revenue;
            revenue = thisYear * 25;
            Console.WriteLine("{0} contestants entered last year's competition." +
                "The revenue for this year's competition is {1} for the {2} contestants who entered.",
                lastYear, revenue, thisYear);

            //Task 4: Display statement comparing number of contestants for this year vs last year
            int doubleLastYear = lastYear * 2;
            if (thisYear >= doubleLastYear)
                Console.WriteLine("The competition is more than twice as big this year!");
            else if (thisYear > lastYear)
                Console.WriteLine("The competition is bigger than ever!");
            else if (thisYear <= lastYear)
                Console.WriteLine("A tighter race this year! Come out and cast your vote!");

            //Task 5: Contestant talents
            Console.WriteLine("The talents and names of the contestants are required.");

            while
            Console.Write("Please enter the name of the contestant: ");
            Console.Write("Please enter the contestant's talent: S for singing, D for dancing, " +
                "M for playing a musical instrument, or O for other: ");
        }
    }
}