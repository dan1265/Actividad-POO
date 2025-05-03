using UnityEngine;

public class Holybomb : Ability
{
    public delegate void HolybombDamage(float damage);
    public static event HolybombDamage Holybombdamage;

    private Priest casterRef;
    private GameObject projectile;
    public Holybomb(Sprite icon, float cD, GameObject caster, GameObject projectile) : base(icon, nameof(Holybomb), "throws a flask of holy water that explodes on impact with the ground, inflicts damage to enemies standing on the water", cD, 0.1f, 15, caster)
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
    public void Damage()
    {
        Holybombdamage?.Invoke(Value);
    }

    public override void RefUpdate()
    {
        Damage();
    }
}
