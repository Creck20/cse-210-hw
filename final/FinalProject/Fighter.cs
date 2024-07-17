public class Fighter: Class{
    public Fighter(){
        _hitDice = "1d10";
        _spellCasting = false;
        _armorProf = "All armor, sheilds";
        _weaponProf = "All weapons";
        _toolProf = "none";
        _savingThrows.Add("Strength");
        _savingThrows.Add("Constitution");
    }

    public override void SetHitPoints(int conMod){_hp = conMod + 10;}
    public override void ChooseSkills(){
        List<string> skills = new List<string>{
            "Acrobatics", "Animal Handling", "Athletics", "History", "Insight", 
            "Intimidation", "Perception", "Survival"
        };

        Console.WriteLine("\nChoose two from:" +
         "\n   1. Acrobatics\n   2. Animal Handling\n   3. Athletics\n   4. History" + 
         "\n   5. Insight\n   6. Intimidation\n   7. Perception\n   8. Survival");

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
            case 7: 
                _skillList.Add(skills[6]);
                break;
            case 8: 
                _skillList.Add(skills[7]);
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
             case 7: 
                _skillList.Add(skills[6]);
                break;
            case 8: 
                _skillList.Add(skills[7]);
                break;
        }
    }
    public override void ChooseEquipment(){
        Console.WriteLine("\nChoose Equipment: ");

        // Choice 1: 
        Console.WriteLine("\n(a) chain mail (b) leather armor, longbow");
        Console.Write("Your choice: ");
        string choice1 = Console.ReadLine();

        if (choice1 == "a"){_equipment.Add("chain mail");}
        else{
            _equipment.Add("leather armor");
            _equipment.Add("a long bow");
        }

        // Choice 2: 
        Console.WriteLine("\n(a) longsword and shield (b) long sword, great axe");
        Console.Write("Your choice: ");
        string choice2 = Console.ReadLine();

        if (choice2 == "a"){
            _equipment.Add("a longsword");
            _equipment.Add("a shield");
        }
        else{
            _equipment.Add("a longsword");
            _equipment.Add("a great axe");
        }


        // Choice 3: 
        Console.WriteLine("\n(a) a light crossbow or (b) two handaxes");
        Console.Write("Your choice: ");
        string choice3 = Console.ReadLine();

        if (choice3 == "a"){_equipment.Add("a light crossbow");}
        else{_equipment.Add("two handaxes");}

        // Choice 4: 
        Console.WriteLine("\n(a) a dungeoneer's pack or (b) an explorer's pack");
        Console.Write("Your choice: ");
        string choice4 = Console.ReadLine();

        if (choice4 == "a"){_equipment.Add("a dungeoneer's pack");}
        else{_equipment.Add("an explorer's pack");}
    }
   
}