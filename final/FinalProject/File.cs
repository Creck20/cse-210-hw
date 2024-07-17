public class File{
    // Ability Scores: 
    private int _strength;
    private int _dexterity;
    private int _constitution;
    private int _intelligence;
    private int _wisdom;
    private int _charisma;
    private int _strMod;
    private int _dexMod;
    private int _conMod;
    private int _intMod;
    private int _wisMod;
    private int _chaMod;

    // Class Specific:
    private int _hp;
    private string _hitDice;
    private List<string> _skillList = new List<string>();
    private List<string> _savingThrows = new List<string>();
    private string _armorProf;
    private string _weaponProf;
    private string _toolProf;
    private List<string> _equipment = new List<string>();

    // Wizard Specific: 
    private int _SSDC; 
    private int _SAM;

    // Proficiency Specific: 
    private int _passivePerc;
    private List<string> _languages = new List<string>();

    // BackGround Specific: 
    private string _backgroundTrait;

    // Race Specific: 
    private string _size;
    private string _speed;
    private List<string> _raceTraits = new List<string>();

    // Constructor for Wizard:
    public File(int str, int dex, int con, int intel, int wis, int cha,
    int strMod, int dexMod, int conMod, int intMod, int wisMod, int chaMod,
    int hp, string hitDice, List<string> skillList, List<string> savingTh,
    string armorProf, string toolProf, string weaponProf, List<string> equipment,
    int SSDC, int SAM, int passivePerc, List<string> languages,
    string backgroundTrait, string size, string speed, List<string> raceTraits){
        _strength = str;
        _dexterity = dex;
        _constitution = con;
        _intelligence = intel;
        _wisdom = wis;
        _charisma = cha;
        _strMod = strMod;
        _dexMod = dexMod;
        _conMod = conMod;
        _intMod = intMod;
        _wisMod = wisMod;
        _chaMod = chaMod;
        _hp = hp;
        _hitDice = hitDice;
        _skillList = skillList;
        _savingThrows = savingTh;
        _armorProf = armorProf;
        _toolProf = toolProf;
        _weaponProf = weaponProf;
        _equipment = equipment;
        _SSDC = SSDC;
        _SAM = SAM;
        _passivePerc = passivePerc;
        _languages = languages;
        _backgroundTrait = backgroundTrait;
        _size = size;
        _speed = speed;
        _raceTraits = raceTraits;
    }

    // Constructor for Fighter:
    public File(int str, int dex, int con, int intel, int wis, int cha,
    int strMod, int dexMod, int conMod, int intMod, int wisMod, int chaMod,
    int hp, string hitDice, List<string> skillList, List<string> savingTh,
    string armorProf, string toolProf, string weaponProf, List<string> equipment,
     int passivePerc, List<string> languages, string backgroundTrait, string size, 
     string speed, List<string> raceTraits){
        _strength = str;
        _dexterity = dex;
        _constitution = con;
        _intelligence = intel;
        _wisdom = wis;
        _charisma = cha;
        _strMod = strMod;
        _dexMod = dexMod;
        _conMod = conMod;
        _intMod = intMod;
        _wisMod = wisMod;
        _chaMod = chaMod;
        _hp = hp;
        _hitDice = hitDice;
        _skillList = skillList;
        _savingThrows = savingTh;
        _armorProf = armorProf;
        _toolProf = toolProf;
        _weaponProf = weaponProf;
        _equipment = equipment;
        _passivePerc = passivePerc;
        _languages = languages;
        _backgroundTrait = backgroundTrait;
        _size = size;
        _speed = speed;
        _raceTraits = raceTraits;
    }
    public void WriteFile(string CLASS){
        if (CLASS == "wizard"){
            using(StreamWriter outputFile = new StreamWriter("character.txt", false)){
                outputFile.WriteLine("\nYour abilities are:");
                // Ability Scores: 
                if (_strMod > 0){
                    outputFile.WriteLine($"    Strength: {_strength} (+{_strMod})");
                } 
                else{
                    outputFile.WriteLine($"    Strength: {_strength} ({_strMod})");
                }
                if (_dexMod > 0){
                    outputFile.WriteLine($"    Dexterity: {_dexterity} (+{_dexMod})");
                } 
                else{
                    outputFile.WriteLine($"    Dexterity: {_dexterity} ({_dexMod})");
                }
                if (_conMod > 0){
                    outputFile.WriteLine($"    Constitution: {_constitution} (+{_conMod})");
                } 
                else{
                    outputFile.WriteLine($"    Constitution: {_constitution} ({_conMod})");
                }
                if (_intMod > 0){
                    outputFile.WriteLine($"    Intelligence: {_intelligence} (+{_intMod})");
                } 
                else{
                    outputFile.WriteLine($"    Intelligence: {_intelligence} ({_intMod})");
                }
                if (_wisMod > 0){
                    outputFile.WriteLine($"    Wisdom: {_wisdom} (+{_wisMod})");
                } 
                else{
                    outputFile.WriteLine($"    Wisdom: {_wisdom} ({_wisMod})");
                }
                if (_chaMod > 0){
                    outputFile.WriteLine($"    Charisma: {_charisma} (+{_chaMod})");
                } 
                else{
                    outputFile.WriteLine($"    Charisma: {_charisma} ({_chaMod})");
                }

                // Class Specific:
                outputFile.WriteLine($"\nHit Points: {_hp}");
                outputFile.WriteLine($"Hit dice: {_hitDice}");
                outputFile.WriteLine("\nSkills:");
                foreach(string skill in _skillList){
                    outputFile.WriteLine(skill);
                }
                outputFile.WriteLine($"\nSaving Throws:");
                foreach(string st in _savingThrows){
                    outputFile.WriteLine(st);
                }
                outputFile.WriteLine($"\nArmor Proficiency: {_armorProf}");
                outputFile.WriteLine($"Weapon Proficiency: {_weaponProf}");
                outputFile.WriteLine($"Tool Proficiency: {_toolProf}");
                outputFile.WriteLine("\nEquipment: ");
                foreach(string eq in _equipment){
                    outputFile.WriteLine(eq);
                }

                // Proficiency Specific: 
                outputFile.WriteLine($"\nPassive Perception: {_passivePerc}");
                outputFile.WriteLine("\nLanguages: ");
                foreach(string lang in _languages){
                    outputFile.WriteLine(lang);
                }

                // Background Specific:
                outputFile.WriteLine($"\nBackground Trait: {_backgroundTrait}");

                // Race specific: 
                outputFile.WriteLine($"\n Size: {_size}");
                outputFile.WriteLine($"Speed: {_speed}");
                outputFile.WriteLine("\nRacial Traits:");
                foreach(string rt in _raceTraits){
                    outputFile.WriteLine(rt);
                }

                // Wizard Specific: 
                outputFile.WriteLine($"\nSpell Save DC: {_SSDC}");
                outputFile.WriteLine($"Spell Attack Modifier: {_SAM}");
            }
        }
        else{
            using(StreamWriter outputFile = new StreamWriter("character.txt", false)){
                outputFile.WriteLine("\nYour abilities are:");
                // Ability Scores: 
                if (_strMod > 0){
                    outputFile.WriteLine($"    Strength: {_strength} (+{_strMod})");
                } 
                else{
                    outputFile.WriteLine($"    Strength: {_strength} ({_strMod})");
                }
                if (_dexMod > 0){
                    outputFile.WriteLine($"    Dexterity: {_dexterity} (+{_dexMod})");
                } 
                else{
                    outputFile.WriteLine($"    Dexterity: {_dexterity} ({_dexMod})");
                }
                if (_conMod > 0){
                    outputFile.WriteLine($"    Constitution: {_constitution} (+{_conMod})");
                } 
                else{
                    outputFile.WriteLine($"    Constitution: {_constitution} ({_conMod})");
                }
                if (_intMod > 0){
                    outputFile.WriteLine($"    Intelligence: {_intelligence} (+{_intMod})");
                } 
                else{
                    outputFile.WriteLine($"    Intelligence: {_intelligence} ({_intMod})");
                }
                if (_wisMod > 0){
                    outputFile.WriteLine($"    Wisdom: {_wisdom} (+{_wisMod})");
                } 
                else{
                    outputFile.WriteLine($"    Wisdom: {_wisdom} ({_wisMod})");
                }
                if (_chaMod > 0){
                    outputFile.WriteLine($"    Charisma: {_charisma} (+{_chaMod})");
                } 
                else{
                    outputFile.WriteLine($"    Charisma: {_charisma} ({_chaMod})");
                }

                // Class Specific:
                outputFile.WriteLine($"\nHit Points: {_hp}");
                outputFile.WriteLine($"Hit dice: {_hitDice}");
                outputFile.WriteLine("\nSkills:");
                foreach(string skill in _skillList){
                    outputFile.WriteLine(skill);
                }
                outputFile.WriteLine($"\nSaving Throws:");
                foreach(string st in _savingThrows){
                    outputFile.WriteLine(st);
                }
                outputFile.WriteLine($"\nArmor Proficiency: {_armorProf}");
                outputFile.WriteLine($"Weapon Proficiency: {_weaponProf}");
                outputFile.WriteLine($"Tool Proficiency: {_toolProf}");
                outputFile.WriteLine("\nEquipment: ");
                foreach(string eq in _equipment){
                    outputFile.WriteLine(eq);
                }

                // Proficiency Specific: 
                outputFile.WriteLine($"\nPassive Perception: {_passivePerc}");
                outputFile.WriteLine("\nLanguages: ");
                foreach(string lang in _languages){
                    outputFile.WriteLine(lang);
                }

                // Background Specific:
                outputFile.WriteLine($"\nBackground Trait: {_backgroundTrait}");

                // Race specific: 
                outputFile.WriteLine($"\n Size: {_size}");
                outputFile.WriteLine($"Speed: {_speed}");
                outputFile.WriteLine("\nRacial Traits:");
                foreach(string rt in _raceTraits){
                    outputFile.WriteLine(rt);
                }
            }
        }
    }

}