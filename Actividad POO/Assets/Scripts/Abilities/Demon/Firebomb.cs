using UnityEngine;

public class Firebomb : Ability
{
    private Demon casterRef;
    private GameObject projectile;
    public Firebomb(Sprite icon, float cD, GameObject caster, GameObject projectile, Abilityscriptable abilityData) : base(icon, nameof(Firebomb), "Throws a fire bomb that explodes and incinerates the ground causing damage to all enemies that stand on it.", cD, 15, caster, abilityData)
    {
        this.projectile = projectile;
        casterRef = caster.GetComponent<Demon>();
    }

    public override void Cast()
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
}
