using UnityEngine;

public class Restauration : Ability
{
    private Priest player;
    public Restauration(Sprite icon, float cD, Priest player) : base(icon, nameof(Restauration), "The gods illuminate you with their sacred light regenerating life.", cD, 30f, 0)
    {
        this.player = player;
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
        player.Heal(DamageOrHeal);
    }
}
