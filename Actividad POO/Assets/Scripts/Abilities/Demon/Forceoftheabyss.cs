using UnityEngine;

public class Forceoftheabyss : Ability
{
    private Demon casterRef;
    public Forceoftheabyss(Sprite icon, float cD, GameObject caster) : base(icon, nameof(Forceoftheabyss), "you consume a cursed soul to absorb its power and regenerate your life", cD, 30f, 5, caster)
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

    public override void RefUpdate()
    {

    }

    public void ForceOfTheAbyssAbility()
    {
        if (casterRef.Life >= Cost + 1)
        {
            caster.GetComponent<Demon>().Heal(Value);
            casterRef.Life -= Cost;
        }
    }
}
