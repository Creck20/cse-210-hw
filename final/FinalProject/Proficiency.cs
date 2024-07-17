using System.Dynamic;

public class Proficiency{
    private List<string> _skills = new List<string>();
    private List<string> _savingTh = new List<string>();
    private int _passivePerc; 
    private List<string> _equipment = new List<string>();
    private List<string> _languages = new List<string>();
    public List<string> GetSkills(){return _skills;}
    public List<string> GetSavingTh(){return _savingTh;}
    public int GetPassivePerc(){return _passivePerc;}
    public List<string> GetEquipment(){return _equipment;}
    public List<string> GetLang(){return _languages;}
    public void AddSkills(List<string> skills){_skills.AddRange(skills);}
    public void AddSavingTh(List<string> ST){_savingTh.AddRange(ST);}
    public void AddEquipment(List<string> equipment){_equipment.AddRange(equipment);}
    public void AddLanguage(List<string> lang){_languages.AddRange(lang);}
    public void SetPassivePerc(int wisMod){_passivePerc = wisMod;}
}

