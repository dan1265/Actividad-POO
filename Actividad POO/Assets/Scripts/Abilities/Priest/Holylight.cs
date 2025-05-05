using UnityEngine;
using static Holybomb;

[System.Serializable]
public class Holylight : Ability
{
    private GameObject projectile;
    private Priest casterRef;

    public Holylight(Sprite icon, float cD, GameObject caster, GameObject projectile, Abilityscriptable abilityData) : base(icon, nameof(Holylight), "Summons a beam of holy light that deals damage to the first enemy it hits.", cD, 10, caster, abilityData)
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
}
