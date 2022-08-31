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
            int lastYear = -1;
            int thisYear = -1;
            const int LOWER = 0, UPPER = 30;

            Console.Write("Please enter the number of contestants who entered in last year's competition, " +
                "within the range of {0} and {1}: ", LOWER, UPPER);

            int validCount = 0;
            while (validCount < 2)
            {
                if (validCount == 0)
                {
                    lastYear = Convert.ToInt32(Console.ReadLine());
                    if (lastYear >= LOWER && lastYear <= UPPER && validCount < 1)
                    {
                        Console.WriteLine("Confirmed. {0} contestants entered in last year's competition.", lastYear);
                        validCount++;
                        Console.Write("Please enter the number of contestants who entered in this year's competition, " +
                            "within the range of {0} and {1}: ", LOWER, UPPER);
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry. Please enter a number between 0 and 30.");
                    }
                }

                //lastYear code is repeated for this year input
                if (validCount == 1)
                {
                    thisYear = Convert.ToInt32(Console.ReadLine());
                    if (thisYear >= LOWER && thisYear <= UPPER)
                    {
                        Console.WriteLine("Confirmed. {0} contestants entered this year.", thisYear);
                        validCount++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry. Please enter a number between 0 and 30.");
                    }
                }
            }

            //Task 3: Display input data & revenue for this year's competition
            int revenue;
            
            revenue = thisYear * 25; //total revenue = (number of contestants x $25 per contestant)
            
            //print to user
            Console.WriteLine("{0} contestants entered last year's competition. " +
                "{1} contestants entered this year's competition. " +
                "The revenue for this year's competition is ${2}.",
                lastYear, thisYear, revenue);


            //Task 4: Display statement comparing number of contestants for this year vs last year
            int doubleLastYear = lastYear * 2;

            if (thisYear >= doubleLastYear)
                Console.WriteLine("The competition is more than twice as big this year!");
            else if (thisYear > lastYear)
                Console.WriteLine("The competition is bigger than ever!");
            else if (thisYear <= lastYear)
                Console.WriteLine("A tighter race this year! Come out and cast your vote!");

            //TODO
            //Task 5: Contestant talents data entry & search
            string[] names = new string[thisYear];
            char[] talents = new char[thisYear];
            bool validTalent = false;
            Console.WriteLine("The talents and names of the contestants for this year are required.");

            for (int i = 0; i < thisYear; i++)
            {
                //ask user for name & store in array
                Console.Write("Please enter the name of the contestant: ");
                names[i] = Console.ReadLine();
                //ask user for talent & store in parallel array
                Console.Write("Please enter {0}'s special talent: S for singing, D for dancing, " +
                "M for playing a musical instrument, or O for other: ", names[i]);
                //talents[i] = Char.Parse(Console.ReadLine());

                while(!validTalent)
                {
                    talents[i] = Char.Parse(Console.ReadLine());
                    switch (talents[i])
                    {
                        case 'S':
                        case 'D':
                        case 'M':
                        case 'O':
                            Console.WriteLine("Confirmed. {0} is an {1}.", names[i], talents[i]);
                            validTalent = true;
                            break;
                        default:
                            Console.WriteLine("That was not a valid code. Please enter S for singing, D for dancing," +
                            "M for playing a musical instrument or 0 for other: ");
                            break;
                    }
                }

            }

            /*
            //TODO: search arrays &  return talent count
            string S = "sing", D = "dance", M = "play a musical instrument", O = "have a unique talent"; 

            Console.Write("Enter a code: S, D, M or O >> ");

            Console.WriteLine("That was not a valid code. Please enter S, D, M or O.");

            Console.WriteLine("There are {0} contestants who {1}.", )
            */
        }
    }
}