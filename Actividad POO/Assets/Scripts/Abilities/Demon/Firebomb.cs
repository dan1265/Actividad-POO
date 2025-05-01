using UnityEngine;

public class Firebomb : Ability
{
    public delegate void FirebombDamage(float damage);
    public static event FirebombDamage Firebombdamage;

    private Demon casterRef;
    private GameObject projectile;
    public Firebomb(Sprite icon, float cD, GameObject caster, GameObject projectile) : base(icon, nameof(Firebomb), "Throws a fire bomb that explodes and incinerates the ground causing damage to all enemies that stand on it.", cD, 0.1f, 15, caster)
    {
        this.projectile = projectile;
        casterRef = caster.GetComponent<Demon>();
    }

    public override void Cast(GameObject gameObject)
    {
        if (canCast)
        {
            cDtimer = cD;
            FireBombAbility();
        }
    }

    private void FireBombAbility()
    {
        if (casterRef.Life >= Cost + 1)
        {
            GameObject fB = Object.Instantiate(projectile, caster.transform.position, Camera.main.transform.rotation);
            casterRef.Life -= Cost;
        }
    }
    public void Damage()
    {
        Firebombdamage?.Invoke(DamageOrHeal);
    }

    public override void RefUpdate()
    {
        Damage();
    }
}
