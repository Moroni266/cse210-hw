public class Menu
{
    public List<string> menuOptions = new List<string>();
    public string option1 = "1. Write";
    public string option2 = "2. Display";
    public string option3 = "3. Load";
    public string option4 = "4. Save";
    public string option5 = "5. Quit";

    public Menu()
    {
        menuOptions.Add(option1);
        menuOptions.Add(option2);
        menuOptions.Add(option3);
        menuOptions.Add(option4);
        menuOptions.Add(option5);
    }

    public void DisplayMenu()
    {
        foreach (string option in menuOptions)
        {
            Console.WriteLine(option);
        }
    }
}