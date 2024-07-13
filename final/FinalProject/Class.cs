using System.Configuration.Assemblies;

public abstract class Class{
    public string GetHitDice(){
        return "";
    }
    public virtual void ChooseSkills(){}
    public string GetSkill1(){
        return"";
    }
    public string GetSkill2(){
        return"";
    }
    public virtual void GetOtherProf(){}
    public virtual void ChooseEquipment(){}

}