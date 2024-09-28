using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program");
        Menu myMenu = new Menu();
        PromptGenerator myPrompt = new PromptGenerator();
        Journal myJournal = new Journal();
        bool quit = false;
        do
        {
            myMenu.DisplayMenu();
            Console.Write("What would you like to do? ");
            string menuOption = Console.ReadLine();
            int user_choose = int.Parse(menuOption);

            if (user_choose == 1)
            {
                string prompt = myPrompt.GetRandomPrompt();
                Console.WriteLine($"{prompt}");
                Console.Write(">");
                string user_response = Console.ReadLine();
                DateTime currentTime = DateTime.Now;
                string dateText = currentTime.ToShortDateString();
                Entry myEntry = new Entry();
                myEntry._date = dateText;
                myEntry._promptText = prompt;
                myEntry._entryText = user_response;

                myJournal.AddEntry(myEntry);
            }
            else if (user_choose == 2)
            {
                myJournal.DisplayAll();
            }
            else if (user_choose == 3)
            {
                Console.Write("What is the file name? ");
                string fileName = Console.ReadLine();
                myJournal.LoadFromFile(fileName);
            }
            else if (user_choose == 4)
            {
                Console.Write("What will be the file name? ");
                string fileName = Console.ReadLine();
                myJournal.SaveToFile(fileName);
            }
            else if (user_choose == 5)
            {
                quit = true;
            }
        } while (quit == false);

        Console.WriteLine("Thank for using the Journal Program");
    }
}