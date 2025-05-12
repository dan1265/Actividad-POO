using UnityEngine;

public class Restauration : Ability
{
    private Priest casterRef;
    public Restauration(Sprite icon, float cD, GameObject caster, Abilityscriptable abilityData) : base(icon, nameof(Restauration), "The gods illuminate you with their sacred light regenerating life.", cD, 30, caster, abilityData)
    {
        casterRef = caster.GetComponent<Priest>();
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
        if (casterRef.Mana >= Cost)
        {
            cDtimer = cD;
            caster.GetComponent<Priest>().lifesystem.Heal(abilityData.abilityValue);
            casterRef.Mana -= Cost;
        }
    }
}
