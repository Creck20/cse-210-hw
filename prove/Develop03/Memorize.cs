using System.Net;
using System.Reflection.Emit;

public class Memorize{
    private Citation _reference;
    private List<Verse> _verses = new List<Verse>();
    public Memorize(Citation reference, string scriptureString){

        string[] verseList = scriptureString.Split("\n");

        for(int i = 0; i < verseList.Length; i++){
            _verses.Add(new Verse(verseList[i]));
        }

        _reference = reference;
    }
    public void Display(){

        _reference.Display();

        foreach(Verse verse in _verses){
            verse.Display();
            Console.Write("\n");
        }
    }
    public void HideTwoRandom(){

        foreach(Verse verse in _verses){
            verse.HideRandomWord();
            verse.HideRandomWord();
        }
    }
    public int GetRevealedCount(){

        int count = 0;

        foreach(Verse verse in _verses){
            count += verse.GetRevealedCount();
        }

        return count;

    }

}