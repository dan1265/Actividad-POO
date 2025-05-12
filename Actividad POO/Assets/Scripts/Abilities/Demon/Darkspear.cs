using UnityEngine;

public class Darkspear : Ability
{
    private Demon casterRef;
    private GameObject projectile;
    public Darkspear(Sprite icon, float cD, GameObject caster, GameObject projectile, Abilityscriptable abilityData) : base(icon, nameof(Darkspear), "Summons a dark spear in front of you that hits the first enemy hit.", cD, 10, caster, abilityData)
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
            cDtimer = cD;
            GameObject dS = Object.Instantiate(projectile, Camera.main.transform.position, Camera.main.transform.rotation);
            casterRef.lifesystem.CurrentLife -= Cost;
        }

    }
}
