public class BackGround{
    protected List<string> _skills = new List<string>();
    protected string _trait;
    protected List<string> _proficiency = new List<string>();
    protected List<string> _equipment = new List<string>();
    protected List<string> _languages = new List<string>();
    public List<string> GetSkills(){return _skills;}
    public List<string> GetProf(){return _proficiency;}
    public List<string> GetEquipment(){return _equipment;}
    public List<string> GetLang(){return _languages;}
    public string GetTrait(){return _trait;}

}