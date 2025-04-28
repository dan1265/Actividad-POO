using UnityEngine;
using static Holybomb;

[System.Serializable]
public class Holylight : Ability
{
    public delegate void HolylightDamage(float damage);
    public static event HolylightDamage Holylightdamage;

    private GameObject projectile;
    public Holylight(Sprite icon, float cD, Transform shootpoint, GameObject projectile) : base(icon, nameof(Holylight), "Summons a beam of holy light that deals damage to the first enemy it hits.", cD, 20f, 0)
    {
        this.projectile = projectile;
    }

    public override void Cast(GameObject gameObject)
    {
        if (canCast)
        {
            cDtimer = cD;
            HolylightAbility();
        }
    }

    public void HolylightAbility()
    {
        GameObject hL = Object.Instantiate(projectile, Camera.main.transform.position, Camera.main.transform.rotation);
    }

    public void Damage()
    {
        Holylightdamage?.Invoke(DamageOrHeal);
    }

    public override void RefUpdate()
    {
        Damage();
    }
}
