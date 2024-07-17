using System.Xml.Serialization;

public class Wizard: Class{
    private int _SSDC; 
    private int _SAM;
    public Wizard(){
        _hitDice = "1d6";
        _spellCasting = true;
        _armorProf = "none";
        _weaponProf = "daggers, darts, slings, quarterstaffs, light crossbows";
        _toolProf = "none";
        _equipment.Add("a Spellbook");
        _savingThrows.Add("Intelligence");
        _savingThrows.Add("Wisdom");
    }
    public override void SetHitPoints(int conMod){_hp = conMod + 6;}
    public override void ChooseSkills(){
        List<string> skills = new List<string>{
            "Arcana", "History", "Insight", "Investigation", "Medicine", "Religion"
        };

        Console.WriteLine("\nChoose two from:" +
         "\n   1. Arcana\n   2. History\n   3. Insight\n   4. Investigation" + 
         "\n   5. Medicine\n   6. Religion");

        Console.Write("Choice 1: ");
        int choice_1 = int.Parse(Console.ReadLine());
        Console.Write("Choice 2: ");
        int choice_2 = int.Parse(Console.ReadLine());

        switch (choice_1){
            case 1:
                _skillList.Add(skills[0]);
                break;
            case 2: 
                _skillList.Add(skills[1]);
                break;
            case 3: 
                _skillList.Add(skills[2]);
                break;
            case 4: 
                _skillList.Add(skills[3]);
                break;
            case 5: 
                _skillList.Add(skills[4]);
                break;
            case 6: 
                _skillList.Add(skills[5]);
                break;
        }

         switch (choice_2){
            case 1:
                _skillList.Add(skills[0]);
                break;
            case 2: 
                _skillList.Add(skills[1]);
                break;
            case 3: 
                _skillList.Add(skills[2]);
                break;
            case 4: 
                _skillList.Add(skills[3]);
                break;
            case 5: 
                _skillList.Add(skills[4]);
                break;
            case 6: 
                _skillList.Add(skills[5]);
                break;
        }
    }
    public override void ChooseEquipment(){
        Console.WriteLine("\nChoose Equipment: ");

        // Choice 1: 
        Console.WriteLine("\n(a) a quarterstaff or (b) a dagger");
        Console.Write("Your choice: ");
        string choice1 = Console.ReadLine();

        if (choice1 == "a"){_equipment.Add("a quaterstaff");}
        else{_equipment.Add("a dagger");}

        // Choice 2: 
        Console.WriteLine("\n(a) a component pouch or (b) an arcane focus");
        Console.Write("Your choice: ");
        string choice2 = Console.ReadLine();

        if (choice2 == "a"){_equipment.Add("a component pouch");}
        else{_equipment.Add("an arcane focus");}

        // Choice 3: 
        Console.WriteLine("\n(a) a scholar's pack or (b) an explorer's pack");
        Console.Write("Your choice: ");
        string choice3 = Console.ReadLine();

        if (choice3 == "a"){_equipment.Add("a scholar's pack");}
        else{_equipment.Add("an explorer's pack");}
    }
    public int GetSSDC(){return _SSDC;}
    public void SetSSDC(int intMod){_SSDC = intMod + 10;}
    public int GetSAM(){return _SAM;}
    public void SetSAM(int intMod){_SAM = intMod + 2;}
    
    
    
    

}