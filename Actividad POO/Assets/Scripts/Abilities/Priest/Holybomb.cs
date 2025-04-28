using UnityEngine;

public class Holybomb : Ability
{
    public delegate void HolybombDamage(float damage);
    public static event HolybombDamage Holybombdamage;

    private Transform shootpoint;
    private GameObject projectile;
    public Holybomb(Sprite icon, float cD, Transform shootpoint, GameObject projectile) : base(icon, nameof(Holybomb), "throws a flask of holy water that explodes on impact with the ground, inflicts damage to enemies standing on the water", cD, 0.1f, 10)
    {
        this.shootpoint = shootpoint;
        this.projectile = projectile;
    }

    public override void Cast(GameObject gameObject)
    {
        if (canCast)
        {
            cDtimer = cD;
            HolybombAbility();
        }
    }

    private void HolybombAbility()
    {
        GameObject hB = Object.Instantiate(projectile, shootpoint.position, Camera.main.transform.rotation);
    }
    public void Damage()
    {
        Holybombdamage?.Invoke(DamageOrHeal);
    }

    public override void RefUpdate()
    {
        Damage();
    }
}
