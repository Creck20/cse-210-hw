using System.Configuration.Assemblies;

public abstract class Class{
    protected int _hp;
    protected string _hitDice;
    protected List<string> _skillList = new List<string>();
    protected List<string> _savingThrows = new List<string>();
    protected string _armorProf;
    protected string _weaponProf;
    protected string _toolProf;
    protected List<string> _equipment = new List<string>();
    protected bool _spellCasting;
    public virtual void SetHitPoints( int conMod){}
    public int GetHitPoints(){return _hp;}
    public bool GetSpellCasting(){return _spellCasting;}
    public string GetHitDice(){return _hitDice;}
    public string GetArmorProf(){return _armorProf;}
    public string GetWeaponProf(){return _weaponProf;}
    public string GetToolProf(){return _toolProf;}
    public List<string> GetSavingThrows(){return _savingThrows;}
    public List<string> GetSkills(){return _skillList;}
    public List<string> GetEquipment(){return _equipment;}
    public virtual void ChooseEquipment(){}
    public virtual void ChooseSkills(){}

}