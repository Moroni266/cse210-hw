using System;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths";
        Scripture scripture = new Scripture(reference, text);
        bool quit = false;

        do
        {
            if (scripture.IsCompletelyHidden())
            {
                quit = true;
            }
            Console.Clear();
            Console.WriteLine($"{reference.DisplayText()} {scripture.GetDisplayText()}");
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            Console.Write("");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                scripture.HideRandomWords(3);
                if (!scripture.IsCompletelyHidden())
                {
                    Console.WriteLine(scripture.GetDisplayText());
                }

            }
            else if (input == "quit")
            {
                quit = true;
            }
            else
            {
                Console.WriteLine("That is not a valid option!!");
            }

        } while (quit == false);
    }
}