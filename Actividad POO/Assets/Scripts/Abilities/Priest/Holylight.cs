using UnityEngine;
using static Holybomb;

[System.Serializable]
public class Holylight : Ability
{
    public delegate void HolylightDamage(float damage);
    public static event HolylightDamage Holylightdamage;

    private GameObject projectile;
    private Priest casterRef;

    public Holylight(Sprite icon, float cD, GameObject caster, GameObject projectile) : base(icon, nameof(Holylight), "Summons a beam of holy light that deals damage to the first enemy it hits.", cD, 20f, 10, caster)
    {
        this.projectile = projectile;
        casterRef = caster.GetComponent<Priest>();
    }

    public override void Cast()
    {
        if (canCast)
        {
            cDtimer = cD;
            HolylightAbility();
        }
    }

    public void HolylightAbility()
    {
        if(casterRef.Mana >= Cost)
        {
            GameObject hL = Object.Instantiate(projectile, Camera.main.transform.position, Camera.main.transform.rotation);
            casterRef.Mana -= Cost;
        }

    }

    public void Damage()
    {
        Holylightdamage?.Invoke(Value);
    }

    public override void RefUpdate()
    {
        Damage();
    }
}
