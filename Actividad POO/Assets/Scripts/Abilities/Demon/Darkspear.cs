using UnityEngine;

public class Darkspear : Ability
{

    public delegate void DarkspearDamage(float damage);
    public static event DarkspearDamage Darkspeardamage;

    private Demon casterRef;
    private GameObject projectile;
    public Darkspear(Sprite icon, float cD, GameObject caster, GameObject projectile) : base(icon, nameof(Darkspear), "Summons a dark spear in front of you that hits the first enemy hit.", cD, 20f, 10, caster)
    {
        this.projectile = projectile;
        casterRef = caster.GetComponent<Demon>();
    }

    public override void Cast(GameObject gameObject)
    {
        if (canCast)
        {
            cDtimer = cD;
            DarkSpearAbility();
        }
    }

    public void DarkSpearAbility()
    {
        if (casterRef.Life >= Cost + 1)
        {
            GameObject dS = Object.Instantiate(projectile, Camera.main.transform.position, Camera.main.transform.rotation);
            casterRef.Life -= Cost;
        }

    }

    public void Damage()
    {
        Darkspeardamage?.Invoke(DamageOrHeal);
    }

    public override void RefUpdate()
    {
        Damage();
    }
}
