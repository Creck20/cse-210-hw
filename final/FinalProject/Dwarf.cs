public class Dwarf:Race{
    public Dwarf(){
        _bonus1 = "Constitution";
        _bonus2 = "Strength";
        _speed = "25 ft";
        _size = "medium";
        _traits.Add("Darkvision. Accustomed to life underground,\n" +
        "you have superior vision in dark and dim conditions.\n" + 
        "You can see in dim light within 60 feet of you as if it \n" + 
        "were bright light, and in darkness as if it were dim light.\n" +
        "You can't discern color in darkness, only shades of gray.");
        _traits.Add("Dwarven Resilience. You have advantage on saving throws against poison,\n" +
        "and you have resistance against poison damage.");
        _traits.Add("Dwarven Combat Training. You have proficiency with the battleaxe, handaxe,\n" +
        "light hammer, and warhammer.");
        _traits.Add("Tool Proficiency. You gain proficiency with the artisan's tools of your choice:\n" +
        "smith's tools, brewer's supplies, or mason's tools.");
        _traits.Add("Stonecunning. Whenever you make an Intelligence (History) check related to the\n" +
        "origin of stonework, you are considered proficient in the History skill and add double your\n" + 
        "proficiency bonus to the check, instead of your normal proficiency bonus.");
        _languages.Add("Common");
        _languages.Add("Dwarvish");
    }
}