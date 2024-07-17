public class Dragonborn: Race{
    public Dragonborn(){
        _bonus1 = "Strength";
        _bonus2 = "Charisma";
        _speed = "30 ft";
        _size = "medium";
        _traits.Add("Draconic Ancestry Bronze:  2d6 Fire Damage, 5' by 30' line (Dex Save)");
        _traits.Add("Resistant to fire damage");
        _languages.Add("Common");
        _languages.Add("Draconic");
    }
}