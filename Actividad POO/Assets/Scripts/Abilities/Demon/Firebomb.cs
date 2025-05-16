using UnityEngine;

public class Firebomb : Ability
{
    private Demon casterRef;
    private GameObject projectile;
    public Firebomb(float cD, GameObject caster, GameObject projectile) : base(cD, 15, caster)
    {
        this.projectile = projectile;
        casterRef = caster.GetComponent<Demon>();
    }

    public override void Cast()
    {
        if (canCast)
        {
            FireBombAbility();
        }
    }

    private void FireBombAbility()
    {
        if (casterRef.lifesystem.CurrentLife >= Cost + 1)
        {
            cDtimer = CD;
            GameObject fB = Object.Instantiate(projectile, caster.transform.position, Camera.main.transform.rotation);
            casterRef.lifesystem.CurrentLife -= Cost;
        }
    }
}
