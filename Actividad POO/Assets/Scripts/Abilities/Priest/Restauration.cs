using UnityEngine;

public class Restauration : Ability
{
    private Priest casterRef;
    private Ability ability;
    public Restauration(float cD, GameObject caster, Ability ability) : base(cD, 30, caster)
    {
        casterRef = caster.GetComponent<Priest>();
        this.ability = ability;
    }

    public override void Cast()
    {
        if (canCast)
        {
            RestaurationAbility();
        }
    }
    public void RestaurationAbility()
    {
        if (casterRef.mana.CurrentMana >= Cost)
        {
            cDtimer = CD;
            caster.GetComponent<Priest>().lifesystem.Heal(ability.abilityValue);
            casterRef.mana.CurrentMana -= Cost;
        }
    }
}
