using System;

namespace NumberGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            String start = "yes";

            while (start == "yes")
            {
                Console.ForegroundColor =
                    ConsoleColor.Green;

                int number = new Random().Next(1, 101);
                Console.Write("Guess the secret number between 1 and 100:");
                int tries = 1;
                try
                {
                    String guess = Console.ReadLine();
                    int guessconvert = Convert.ToInt32(guess);

                    while (guessconvert != number)
                    {
                        Console.ForegroundColor =
                                ConsoleColor.Red;

                        if (guessconvert > 100 || guessconvert < 1)
                        {
                            Console.WriteLine("Your number isn't between 1 and 100, try again:");
                            Console.Beep();
                                                       
                                guess = Console.ReadLine();
                                guessconvert = Convert.ToInt32(guess);
                                tries = tries + 1;                                                 
                        }
                        else
                        {
                            if (guessconvert < number)
                                Console.WriteLine("try a bigger number:");
                            Console.Beep();

                            if (guessconvert > number)
                                Console.WriteLine("Try a smaller number:");
                            Console.Beep();
                            
                            guess = Console.ReadLine();
                            guessconvert = Convert.ToInt32(guess);                            
                            tries = tries + 1;
                        }
                    }
                    String x = "";
                    if (tries == 1)
                        x = "time";
                    if (tries > 1)
                        x = "times";
                    if (guessconvert == number)
                        Console.ForegroundColor =
                            ConsoleColor.Green;
                    Console.WriteLine("you did it! You tried " + tries +" "+ x + ".");

                    Console.WriteLine("Do you want to try it again? [yes|no]");
                    start = Console.ReadLine();
                    Console.Clear();
                }
                catch
                {

                    Console.ForegroundColor =
                                ConsoleColor.Red;
                    Console.WriteLine("Your input ins't a number.");
                    Console.Beep();
                    Console.ForegroundColor =
                                ConsoleColor.Green;

                    Console.WriteLine("Do you want to try it again? [yes|no]");
                    start = Console.ReadLine();
                    Console.Clear();
                }


            } 
            
        }
    }
}
