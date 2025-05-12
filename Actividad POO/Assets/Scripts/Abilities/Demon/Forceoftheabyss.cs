using UnityEngine;

public class Forceoftheabyss : Ability
{
    private Demon casterRef;
    public Forceoftheabyss(Sprite icon, float cD, GameObject caster, Abilityscriptable abilityData) : base(icon, "Force of the abyss", "you consume a cursed soul to absorb its power and regenerate your life", cD, 5, caster, abilityData)
    {
        casterRef = caster.GetComponent<Demon>();
    }

    public override void Cast()
    {
        if (canCast)
        {
            ForceOfTheAbyssAbility();
        }
    }
    public void ForceOfTheAbyssAbility()
    {
        if (casterRef.lifesystem.CurrentLife >= Cost + 1)
        {
            cDtimer = cD;
            casterRef.lifesystem.CurrentLife -= Cost;
            caster.GetComponent<Demon>().lifesystem.Heal(abilityData.abilityValue);

        }
    }
}
