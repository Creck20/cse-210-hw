public class Race{
    protected string _bonus1;
    protected string _bonus2;
    protected string _size;
    protected string _speed;
    protected List<string> _traits = new List<string>();
    protected List<string> _languages = new List<string>();
    public string GetBonus1(){return _bonus1;}
    public string GetBonus2(){return _bonus2;}
    public string GetSize(){return _size;}
    public string GetSpeed(){return _speed;}
    public List<string> GetTraits(){return _traits;}
    public List<string> GetLanguage(){return _languages;}
    

}