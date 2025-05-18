using UnityEngine;

public class Forceoftheabyss : Ability
{
    private Demon casterRef;
    private Ability ability;
    public Forceoftheabyss(float cD, GameObject caster, Ability ability) : base(cD, 5, caster)
    {
        casterRef = caster.GetComponent<Demon>();
        this.ability = ability;
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
            cDtimer = CD;
            casterRef.lifesystem.TakeDamage(Cost);
            casterRef.lifesystem.Heal(ability.abilityValue);
        }
    }
}
