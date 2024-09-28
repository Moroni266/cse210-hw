using System.Security.Cryptography.X509Certificates;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string prompt1 = "If I had one thing I could do over today, what would it be?";
    public string prompt2 = "What was the best part of my day?";
    public string prompt3 = "What is the more memorable thing of my day?";
    public string prompt4 = "Theres a person who I need to speak?";

    public string prompt5 = "Who was the most interesting person I interacted with today?";

    public string prompt6 = "How did I see the hand of the Lord in my life today?";
    public string prompt7 = "What was the strongest emotion I felt today?";

    public PromptGenerator()
    {
        _prompts.Add(prompt1);
        _prompts.Add(prompt2);
        _prompts.Add(prompt3);
        _prompts.Add(prompt4);
        _prompts.Add(prompt5);
        _prompts.Add(prompt6);
        _prompts.Add(prompt7);
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string prompt = _prompts[randomIndex];
        return prompt;
    }
}