using UnityEngine;
using static Holybomb;

[System.Serializable]
public class Holylight : Ability
{
    private GameObject projectile;
    private Priest casterRef;

    public Holylight(float cD, GameObject caster, GameObject projectile) : base(cD, 10, caster)
    {
        this.projectile = projectile;
        casterRef = caster.GetComponent<Priest>();
    }

    public override void Cast()
    {
        if (canCast)
        {
            HolylightAbility();
        }
    }

    public void HolylightAbility()
    {
        if(casterRef.mana.CurrentMana >= Cost)
        {
            cDtimer = CD;
            GameObject hL = Object.Instantiate(projectile, Camera.main.transform.position, Camera.main.transform.rotation);
            casterRef.mana.CurrentMana -= Cost;
        }

    }
}
