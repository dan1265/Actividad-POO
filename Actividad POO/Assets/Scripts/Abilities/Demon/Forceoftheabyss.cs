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
            cDtimer = cD;
            ForceOfTheAbyssAbility();
        }
    }
    public void ForceOfTheAbyssAbility()
    {
        if (casterRef.Life >= Cost + 1)
        {
            caster.GetComponent<Demon>().Heal(abilityData.abilityValue);
            casterRef.Life -= Cost;
        }
    }
}
