using System.Numerics;

public class Entry
{
    public string _entryText;
    public string _entryDate;
    public string _entryPrompt;
    public int _entryLength;
    public int NumberOfWords()
    {
       string[] length = _entryText.Split(" ");
        int number = length.Count();
        return number;

    }
    public string CompileEntry()
    {
        string entry_total = $"Date: {_entryDate}; Prompt: {_entryPrompt}\nEntry: {_entryText}\nEntry Length: {_entryLength}\n";
        return entry_total;
    }
    
}