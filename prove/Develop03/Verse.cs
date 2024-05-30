using System.ComponentModel.DataAnnotations;

public class Verse {
    private static Random _rand = new Random();
    private List<Word> _wordList = new List<Word>();
    
    public Verse(string verse) {
        string[] stringList = verse.Split(" ");
        for(int i = 0; i < stringList.Length; i++) {
            _wordList.Add(new Word(stringList[i]));
        }
    }

    public void Display() {
        foreach(Word word in _wordList) {
            word.Display();
            if(_wordList.IndexOf(word) != _wordList.Count - 1) {
                Console.Write(" ");
            }
        }
    }

    public int GetRevealedCount() {
        int wordCount = 0;
        foreach(Word word in _wordList) {
            if(word.GetBool() == true) {
                wordCount++;
            }
        }
        return wordCount;
    }
    
    public void HideRandomWord() {
        int index = _rand.Next(0, _wordList.Count);
        _wordList[index].Hide();
    }
}
