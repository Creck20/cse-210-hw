public class Citation{
    private string _book;
    private int _chapter;
    private int _firstVerse;
    private int _lastVerse;
    
    public Citation(string book, int chapter, int firstVerse, int lastVerse){
        _book = book; 
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;
    }
    public void Display(){
        if(_lastVerse == 0){
            Console.WriteLine($"{_book} {_chapter}: {_firstVerse}");
        }
        else{
            Console.WriteLine($"{_book} {_chapter}: {_firstVerse}-{_lastVerse}");
        } 
    }
}