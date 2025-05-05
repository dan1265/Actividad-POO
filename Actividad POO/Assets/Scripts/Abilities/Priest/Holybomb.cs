using UnityEngine;

public class Holybomb : Ability
{
    private Priest casterRef;
    private GameObject projectile;
    public Holybomb(Sprite icon, float cD, GameObject caster, GameObject projectile, Abilityscriptable abilityData) : base(icon, nameof(Holybomb), "throws a flask of holy water that explodes on impact with the ground, inflicts damage to enemies standing on the water", cD, 15, caster, abilityData)
    {
        this.projectile = projectile;
        casterRef = caster.GetComponent<Priest>();
    }

    public override void Cast()
    {
        if (canCast)
        {
            cDtimer = cD;
            HolybombAbility();
        }
    }

    private void HolybombAbility()
    {
        if (casterRef.Mana >= Cost)
        {
            GameObject hB = Object.Instantiate(projectile, caster.transform.position, Camera.main.transform.rotation);
            casterRef.Mana -= Cost;
        }
    }
}
