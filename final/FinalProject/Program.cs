using System;

class Program
{
    static void Main(string[] args)
    {
        // Program Explanation:
        Console.WriteLine("Welcome to the Lvl 1 DND 5e Character Creator!");
        Console.WriteLine("Lets get started by choosing your ability scores: ");

        // Use for testing: 
        Abililty ability = new Abililty("test");
        ability.DisplayAbilities();


        // Use in program: 
        // Choose ability scores: 
        // Abililty abililty = new Abililty();
        // abililty.GenerateRollList();
        // abililty.DisplayAbilities();
        
        // bool done = false;
        // while (!done){
        //     abililty.ChooseAbility();
        //     abililty.DisplayAbilities();
        //     Console.WriteLine("Are you finished? (y/n) ");
        //     string finished = Console.ReadLine();
        //     if (finished == "y"){
        //         done = true;
        //     }
        // }

        // Define Classes: 
        Proficiency proficiency = new Proficiency();
        Wizard wizard = new Wizard();
        Fighter fighter = new Fighter();
        Dwarf dwarf = new Dwarf();
        Dragonborn dragonborn = new Dragonborn();
        Criminal criminal = new Criminal();
        Sage sage = new Sage();

        // Class choice
        Console.WriteLine("\nChoose your class: ");
        Console.WriteLine("    1. Wizard");
        Console.WriteLine("    2. Fighter");
        Console.Write("Your choice: ");
        int CLASS = int.Parse(Console.ReadLine());

        switch (CLASS){
            case 1: 

                
                wizard.SetHitPoints(ability.GetConMod());
                wizard.ChooseSkills();
                wizard.ChooseEquipment();
                wizard.SetSSDC(ability.GetIntMod());
                wizard.SetSAM(ability.GetIntMod());

                // Save to proficiency: 
                proficiency.AddSkills(wizard.GetSkills());
                proficiency.AddSavingTh(wizard.GetSavingThrows());
                proficiency.AddEquipment(wizard.GetEquipment());

                break;

            case 2: 

                
                fighter.SetHitPoints(ability.GetConMod());
                fighter.ChooseSkills();
                fighter.ChooseEquipment();

                // Save to proficiency: 
                proficiency.AddSkills(fighter.GetSkills());
                proficiency.AddSavingTh(fighter.GetSavingThrows());
                proficiency.AddEquipment(fighter.GetEquipment());

                break;
        }

        // Race Choice
        Console.WriteLine("\nChoose a race: ");
        Console.WriteLine("    1. Dwarf");
        Console.WriteLine("    2. Dragonborn");
        Console.Write("Your choice: ");
        int RACE = int.Parse(Console.ReadLine());

        if (RACE == 1){
            
            ability.SetCon(2);
            ability.SetStr(1);
            int dwarfCon = ability.ReturnModifier(ability.GetCon());
            int dwarfStr = ability.ReturnModifier(ability.GetStr());
            ability.SetConMod(dwarfCon);
            ability.SetStrMod(dwarfStr);
            proficiency.AddLanguage(dwarf.GetLanguage());
        }
        else{
            
            ability.SetStr(2);
            ability.SetCha(1);
            int dragonStr= ability.ReturnModifier(ability.GetStr());
            int dragonCha = ability.ReturnModifier(ability.GetCha());
            ability.SetStrMod(dragonStr);
            ability.SetChaMod(dragonCha);
            proficiency.AddLanguage(dragonborn.GetLanguage());
        }

        ability.DisplayAbilities();
        
        // Background Choice
        Console.WriteLine("\nChoose a background: ");
        Console.WriteLine("    1. Criminal");
        Console.WriteLine("    2. Sage");
        Console.Write("Your choice: ");
        int BACKGROUND = int.Parse(Console.ReadLine());

        if (BACKGROUND == 1){
            
            proficiency.AddSkills(criminal.GetSkills());
            proficiency.AddEquipment(criminal.GetEquipment());
        }
        else{
            
            proficiency.AddSkills(sage.GetSkills());
            proficiency.AddEquipment(sage.GetEquipment());
        }

        proficiency.SetPassivePerc(ability.GetWisMod());

        // Save 8 possible combinations to file 

        if (CLASS == 1 & RACE == 1 & BACKGROUND == 1){
            // Wizard Dwarf Criminal:
            File file = new File(ability.GetStr(), ability.GetDex(), ability.GetCon(),
            ability.GetInt(), ability.GetWis(), ability.GetCha(), ability.GetStrMod(), 
            ability.GetDexMod(), ability.GetConMod(), ability.GetIntMod(), 
            ability.GetWisMod(), ability.GetChaMod(), wizard.GetHitPoints(), 
            wizard.GetHitDice(), proficiency.GetSkills(), proficiency.GetSavingTh(), 
            wizard.GetArmorProf(), wizard.GetToolProf(), wizard.GetWeaponProf(), 
            proficiency.GetEquipment(), wizard.GetSSDC(), wizard.GetSAM(), 
            proficiency.GetPassivePerc(), proficiency.GetLang(), criminal.GetTrait(), dwarf.GetSize(),
            dwarf.GetSpeed(), dwarf.GetTraits());

            file.WriteFile("wizard");
        }
        else if (CLASS == 1 & RACE == 1 & BACKGROUND == 2){
            // Wizard Dwarf Sage: 
            File file = new File(ability.GetStr(), ability.GetDex(), ability.GetCon(),
            ability.GetInt(), ability.GetWis(), ability.GetCha(), ability.GetStrMod(), 
            ability.GetDexMod(), ability.GetConMod(), ability.GetIntMod(), 
            ability.GetWisMod(), ability.GetChaMod(), wizard.GetHitPoints(), 
            wizard.GetHitDice(), proficiency.GetSkills(), proficiency.GetSavingTh(), 
            wizard.GetArmorProf(), wizard.GetToolProf(), wizard.GetWeaponProf(), 
            proficiency.GetEquipment(), wizard.GetSSDC(), wizard.GetSAM(), 
            proficiency.GetPassivePerc(), proficiency.GetLang(), sage.GetTrait(), dwarf.GetSize(),
            dwarf.GetSpeed(), dwarf.GetTraits());

            file.WriteFile("wizard");
        }
        else if (CLASS == 1 & RACE == 2 & BACKGROUND == 1){
            // Wizard Dragonborn Criminal: 
            File file = new File(ability.GetStr(), ability.GetDex(), ability.GetCon(),
            ability.GetInt(), ability.GetWis(), ability.GetCha(), ability.GetStrMod(), 
            ability.GetDexMod(), ability.GetConMod(), ability.GetIntMod(), 
            ability.GetWisMod(), ability.GetChaMod(), wizard.GetHitPoints(), 
            wizard.GetHitDice(), proficiency.GetSkills(), proficiency.GetSavingTh(), 
            wizard.GetArmorProf(), wizard.GetToolProf(), wizard.GetWeaponProf(), 
            proficiency.GetEquipment(), wizard.GetSSDC(), wizard.GetSAM(), 
            proficiency.GetPassivePerc(), proficiency.GetLang(), criminal.GetTrait(), dragonborn.GetSize(),
            dragonborn.GetSpeed(), dragonborn.GetTraits());

            file.WriteFile("wizard");
        }
        else if (CLASS == 1 & RACE == 2 & BACKGROUND == 2){
            // Wizard Dragonborn Sage: 
            File file = new File(ability.GetStr(), ability.GetDex(), ability.GetCon(),
            ability.GetInt(), ability.GetWis(), ability.GetCha(), ability.GetStrMod(), 
            ability.GetDexMod(), ability.GetConMod(), ability.GetIntMod(), 
            ability.GetWisMod(), ability.GetChaMod(), wizard.GetHitPoints(), 
            wizard.GetHitDice(), proficiency.GetSkills(), proficiency.GetSavingTh(), 
            wizard.GetArmorProf(), wizard.GetToolProf(), wizard.GetWeaponProf(), 
            proficiency.GetEquipment(), wizard.GetSSDC(), wizard.GetSAM(), 
            proficiency.GetPassivePerc(), proficiency.GetLang(), sage.GetTrait(), dragonborn.GetSize(),
            dragonborn.GetSpeed(), dragonborn.GetTraits());

            file.WriteFile("wizard");
        }
        else if (CLASS == 2 & RACE == 1 & BACKGROUND == 1){
            // Fighter Dwarf Criminal: 
            File file = new File(ability.GetStr(), ability.GetDex(), ability.GetCon(),
            ability.GetInt(), ability.GetWis(), ability.GetCha(), ability.GetStrMod(), 
            ability.GetDexMod(), ability.GetConMod(), ability.GetIntMod(), 
            ability.GetWisMod(), ability.GetChaMod(), fighter.GetHitPoints(), 
            fighter.GetHitDice(), proficiency.GetSkills(), proficiency.GetSavingTh(), 
            fighter.GetArmorProf(), fighter.GetToolProf(), fighter.GetWeaponProf(), 
            proficiency.GetEquipment(), proficiency.GetPassivePerc(), proficiency.GetLang(), 
            criminal.GetTrait(), dwarf.GetSize(),
            dwarf.GetSpeed(), dwarf.GetTraits());

            file.WriteFile("fighter");
        }
        else if (CLASS == 2 & RACE == 1 & BACKGROUND == 2){
            // Fighter Dwarf Sage: 
            File file = new File(ability.GetStr(), ability.GetDex(), ability.GetCon(),
            ability.GetInt(), ability.GetWis(), ability.GetCha(), ability.GetStrMod(), 
            ability.GetDexMod(), ability.GetConMod(), ability.GetIntMod(), 
            ability.GetWisMod(), ability.GetChaMod(), fighter.GetHitPoints(), 
            fighter.GetHitDice(), proficiency.GetSkills(), proficiency.GetSavingTh(), 
            fighter.GetArmorProf(), fighter.GetToolProf(), fighter.GetWeaponProf(), 
            proficiency.GetEquipment(), proficiency.GetPassivePerc(), proficiency.GetLang(), 
            sage.GetTrait(), dwarf.GetSize(),
            dwarf.GetSpeed(), dwarf.GetTraits());

            file.WriteFile("fighter");
        }
        else if (CLASS == 2 & RACE == 2 & BACKGROUND == 1){
            // Fighter Dragonborn Criminal: 
            File file = new File(ability.GetStr(), ability.GetDex(), ability.GetCon(),
            ability.GetInt(), ability.GetWis(), ability.GetCha(), ability.GetStrMod(), 
            ability.GetDexMod(), ability.GetConMod(), ability.GetIntMod(), 
            ability.GetWisMod(), ability.GetChaMod(), fighter.GetHitPoints(), 
            fighter.GetHitDice(), proficiency.GetSkills(), proficiency.GetSavingTh(), 
            fighter.GetArmorProf(), fighter.GetToolProf(), fighter.GetWeaponProf(), 
            proficiency.GetEquipment(), proficiency.GetPassivePerc(), proficiency.GetLang(), 
            criminal.GetTrait(), dragonborn.GetSize(),
            dragonborn.GetSpeed(), dragonborn.GetTraits());

            file.WriteFile("fighter");
        }
        else if (CLASS == 2 & RACE == 2 & BACKGROUND == 2){
            // Fighter Dragonborn Criminal: 
            File file = new File(ability.GetStr(), ability.GetDex(), ability.GetCon(),
            ability.GetInt(), ability.GetWis(), ability.GetCha(), ability.GetStrMod(), 
            ability.GetDexMod(), ability.GetConMod(), ability.GetIntMod(), 
            ability.GetWisMod(), ability.GetChaMod(), fighter.GetHitPoints(), 
            fighter.GetHitDice(), proficiency.GetSkills(), proficiency.GetSavingTh(), 
            fighter.GetArmorProf(), fighter.GetToolProf(), fighter.GetWeaponProf(), 
            proficiency.GetEquipment(), proficiency.GetPassivePerc(), proficiency.GetLang(), 
            sage.GetTrait(), dragonborn.GetSize(),
            dragonborn.GetSpeed(), dragonborn.GetTraits());

            file.WriteFile("fighter");
        }

    }
}