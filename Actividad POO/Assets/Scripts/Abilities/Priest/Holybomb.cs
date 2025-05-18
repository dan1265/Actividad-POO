using UnityEngine;

public class Holybomb : Ability
{
    private Priest casterRef;
    private GameObject projectile;
    public Holybomb(float cD, GameObject caster, GameObject projectile) : base(cD, 15, caster)
    {
        this.projectile = projectile;
        casterRef = caster.GetComponent<Priest>();
    }

    public override void Cast()
    {
        if (canCast)
        {
            HolybombAbility();
        }
    }

    private void HolybombAbility()
    {
        if (casterRef.mana.CurrentMana >= Cost)
        {
            cDtimer = CD;
            GameObject hB = Object.Instantiate(projectile, caster.transform.position, Camera.main.transform.rotation);
            casterRef.mana.UseMana(Cost);
        }
    }
}
