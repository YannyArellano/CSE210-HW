public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What was the best part of your day?",
        "What are you grateful for today?",
        "How did you overcome a challenge?",
        "Describe something you learned today.",
        "What made you smile today?"
    }; 
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}