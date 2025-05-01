using UnityEngine;

public class Restauration : Ability
{
    private Priest casterRef;
    public Restauration(Sprite icon, float cD, GameObject caster) : base(icon, nameof(Restauration), "The gods illuminate you with their sacred light regenerating life.", cD, 30f, 30, caster)
    {
        casterRef = caster.GetComponent<Priest>();
    }

    public override void Cast(GameObject gameObject)
    {
        if (canCast)
        {
            cDtimer = cD;
            RestaurationAbility();
        }
    }

    public override void RefUpdate()
    {

    }

    public void RestaurationAbility()
    {
        if (casterRef.Mana >= Cost)
        {
            caster.GetComponent<Priest>().Heal(DamageOrHeal);
            casterRef.Mana -= Cost;
        }
    }
}
