using UnityEngine;

public class Darkspear : Ability
{
    private Demon casterRef;
    private GameObject projectile;
    public Darkspear(float cD, GameObject caster, GameObject projectile) : base(2.5f, 10, caster)
    {
        this.projectile = projectile;
        casterRef = caster.GetComponent<Demon>();
    }

    public override void Cast()
    {
        if (canCast)
        {
            DarkSpearAbility();
        }
    }

    public void DarkSpearAbility()
    {
        if (casterRef.lifesystem.CurrentLife >= Cost + 1)
        {
            cDtimer = CD;
            GameObject dS = Object.Instantiate(projectile, Camera.main.transform.position, Camera.main.transform.rotation);
            casterRef.lifesystem.CurrentLife -= Cost;
        }

    }
}
