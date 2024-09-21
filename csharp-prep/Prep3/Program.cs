using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");
        //First part of the process
        // Console.Write("What is the magic number? ");
        // string magic_number = Console.ReadLine();
        // Console.Write("What is your guess? ");
        // string user_guess = Console.ReadLine();

        // int mn = int.Parse(magic_number);
        // int un = int.Parse(user_guess);

        // if (un != mn)
        // {
        //     if (un > mn)
        //     {
        //         Console.WriteLine("Lower");
        //     }
        //     else if (un < mn)
        //     {
        //         Console.WriteLine("Higher");
        //     }
        // }
        // else if (un == mn)
        // {
        //     Console.WriteLine("You guessed it!");
        // }

        //Second part of the process

        // bool flag = false;

        // do
        // {
        //     Console.Write("What is the magic number? ");
        //     string magic_number = Console.ReadLine();
        //     Console.Write("What is your guess? ");
        //     string user_guess = Console.ReadLine();

        //     int mn = int.Parse(magic_number);
        //     int un = int.Parse(user_guess);

        //     if (un != mn)
        //     {
        //         if (un > mn)
        //         {
        //             Console.WriteLine("Lower");
        //         }
        //         else if (un < mn)
        //         {
        //             Console.WriteLine("Higher");
        //         }
        //     }
        //     else if (un == mn)
        //     {
        //         flag = true;
        //     }
        // } while (flag == false);

        // Console.WriteLine("You guessed it!");

        bool play_again = true;

        while (play_again)

        {
            bool flag = false;
            Console.Write("The magic number was choose.");
            Console.WriteLine("");
            Random randomGenerator = new Random();
            int magic_number = randomGenerator.Next(1, 11);

            do
            {
                Console.Write("What is your guess? ");
                string user_guess = Console.ReadLine();

                int user_number = int.Parse(user_guess);

                if (user_number != magic_number)
                {
                    if (user_number > magic_number)
                    {
                        Console.WriteLine("Lower");
                    }
                    else if (user_number < magic_number)
                    {
                        Console.WriteLine("Higher");
                    }
                }
                else if (user_number == magic_number)
                {
                    flag = true;
                }
            } while (flag == false);

            Console.WriteLine("You guessed it!");

            Console.Write("Do you want to play again? (yes/no): ");
            string play_again_response = Console.ReadLine().ToLower();

            if (play_again_response != "yes")
            {
                play_again = false;
            }
        }

        Console.WriteLine("Thanks for playing!");
    }
}