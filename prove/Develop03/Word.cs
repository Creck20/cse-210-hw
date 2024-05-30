using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

public class Word{
    private string _word;
    private bool _revealed;
    public Word(string word){
        _word = word;
        _revealed = true;
    }
    public void Display(){

        if(_revealed == true){
            Console.Write(_word);
        }

        else{
            for(int i=0; i < _word.Length; i++){
                Console.Write("_");
            }
        }

    }
    public void Hide(){
        _revealed = false;
    }
    public bool GetBool(){return _revealed;}
   

}
