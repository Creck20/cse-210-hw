using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

public class Abililty{
    private int _strength = 0;
    private int _dexterity = 0;
    private int _constitution = 0;
    private int _intelligence = 0;
    private int _wisdom = 0;
    private int _charisma = 0;
    private int _strMod = -999;
    private int _dexMod = -999;
    private int _conMod = -999;
    private int _intMod = -999;
    private int _wisMod = -999;
    private int _chaMod = -999;
    private int _profBonus = 2;
    private List<int> _rollList = new List<int>();
    public int GetInt(){
        return _intelligence;
    }
    public void SetInt(int intelligence){
        _intelligence = intelligence;
    }
    public int GetStr(){
        return _strength;
    }
    public void SetStr(int strength){
        _strength = strength;
    }
    public int GetDex(){
        return _dexterity;
    }
    public void SetDex(int dexterity){
        _dexterity = dexterity;
    }
    public int GetCon(){
        return _constitution;
    }
    public void SetCon(int constitution){
        _constitution = constitution;
    }
    public int GetWis(){
        return _wisdom;
    }
    public void SetWis(int wisdom){
        _wisdom = wisdom;
    }
    public int GetCha(){
        return _charisma;
    }
    public void SetCha(int charisma){
        _charisma = charisma;
    }
    public int GetStrMod(){
        return _strMod;
    }
    public void SetStrMod(int str){
        _strMod = str;
    }
    public int GetDexMod(){
        return _dexMod;
    }
    public void SetDexMod(int dex){
        _dexMod = dex;
    }
    public int GetConMod(){
        return _conMod;
    }
    public void SetConMod(int con){
        _conMod = con;
    }
    public int GetWisMod(){
        return _wisMod;
    }
    public void SetWisMod(int wis){
        _wisMod = wis;
    }
    public int GetIntMod(){
        return _intMod;
    }
    public void SetIntMod(int intel){
        _intMod = intel;
    }
    public int GetChaMod(){
        return _chaMod;
    }
    public void SetChaMod(int cha){
        _chaMod = cha;
    }
    public int GetProfBonus(){
        return _profBonus;
    }
    public void ChooseAbility(){
        // Select a score from RollList:
        Console.WriteLine("\nPlease select a value: ");
        Console.WriteLine($"    0. {_rollList[0]}");
        Console.WriteLine($"    1. {_rollList[1]}");
        Console.WriteLine($"    2. {_rollList[2]}");
        Console.WriteLine($"    3. {_rollList[3]}");
        Console.WriteLine($"    4. {_rollList[4]}");
        Console.WriteLine($"    5. {_rollList[5]}");
        Console.WriteLine("YourChoice: ");
        int index = int.Parse(Console.ReadLine());

        // Assign that score to an ability: 
        Console.WriteLine("\nPlease select an ability to assign: ");
        Console.WriteLine("    1. Strength");
        Console.WriteLine("    2. Dexterity");
        Console.WriteLine("    3. Constitution");
        Console.WriteLine("    4. Intelligence");
        Console.WriteLine("    5. Wisdom");
        Console.WriteLine("    6. Charisma");
        Console.Write("Your choice: ");
        int choice = int.Parse(Console.ReadLine());

        switch(choice){
            case 1: 
                _strength = _rollList[index];
                _strMod = ReturnModifier(_strength);
                break;
            case 2: 
                _dexterity = _rollList[index];
                _dexMod = ReturnModifier(_dexterity);
                break;
            case 3: 
                _constitution = _rollList[index];
                _conMod = ReturnModifier(_constitution);
                break;
            case 4:
                _intelligence = _rollList[index];
                _intMod = ReturnModifier(_intelligence);
                break;
            case 5: 
                _wisdom = _rollList[index];
                _wisMod = ReturnModifier(_wisdom);
                break;
            case 6:
                _charisma = _rollList[index];
                _chaMod = ReturnModifier(_charisma);
                break;
        }


    }
    public int RandomRoll(){
        // Generate a d6 roll
        Random rand = new Random();
        int roll = rand.Next(1,6);
        return roll;
    }
    public void GenerateRollList(){
        for (int i = 0; i < 6; i++){
            List<int> subList = new List<int>();
            subList.Add(RandomRoll());
            subList.Add(RandomRoll());
            subList.Add(RandomRoll());
            subList.Add(RandomRoll());
            int minRoll = subList.Min();
            subList.Remove(minRoll);
            int sum = subList.Sum();
            _rollList.Add(sum);
        }
    }
    public void DisplayAbilities(){
        Console.WriteLine("\nYour abilities are:");
        if (_strMod > 0){
            Console.WriteLine($"    Strength: {_strength} (+{_strMod})");
        } 
        else{
            Console.WriteLine($"    Strength: {_strength} ({_strMod})");
        }
        if (_dexMod > 0){
            Console.WriteLine($"    Dexterity: {_dexterity} (+{_dexMod})");
        } 
        else{
            Console.WriteLine($"    Dexterity: {_dexterity} ({_dexMod})");
        }
        if (_conMod > 0){
            Console.WriteLine($"    Constitution: {_constitution} (+{_conMod})");
        } 
        else{
            Console.WriteLine($"    Constitution: {_constitution} ({_conMod})");
        }
        if (_intMod > 0){
            Console.WriteLine($"    Intelligence: {_intelligence} (+{_intMod})");
        } 
        else{
            Console.WriteLine($"    Intelligence: {_intelligence} ({_intMod})");
        }
        if (_wisMod > 0){
            Console.WriteLine($"    Wisdom: {_wisdom} (+{_wisMod})");
        } 
        else{
            Console.WriteLine($"    Wisdom: {_wisdom} ({_wisMod})");
        }
        if (_chaMod > 0){
            Console.WriteLine($"    Charisma: {_charisma} (+{_chaMod})");
        } 
        else{
            Console.WriteLine($"    Charisma: {_charisma} ({_chaMod})");
        }
    }
    public int ReturnModifier(int mod){
        Dictionary<int, int> modifier = new Dictionary<int, int>
        {
            {0, -999}, {1,-5}, {2, -4}, {3, -4}, {4, -3}, {5, -3}, {6, -2},
            {7, -2}, {8, -1}, {9, -1}, {10, 0}, {11, 0}, {12, 1}, {13, 1},
            {14, 2}, {15, 2}, {16, 3}, {17, 13}, {18, 4}, {19, 4}, {20, 5}
        };

        return modifier[mod];
    }
}