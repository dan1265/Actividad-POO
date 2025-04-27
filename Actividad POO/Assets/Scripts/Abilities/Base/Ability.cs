using UnityEngine;

[System.Serializable]
public abstract class Ability
{
    private Sprite icon;
    private string abilityName;
    private string abilityDescription;
    private float damageOrHeal;
    public float cD;

    public float cDtimer;
    public bool canCast => cDtimer <= 0f;

    public float DamageOrHeal { get => damageOrHeal; set => damageOrHeal = value; }

    public Ability(Sprite icon, string abilityName, string abilityDescription, float cD, float damageOrHeal)
    {
        this.icon = icon;
        this.abilityName = abilityName;
        this.abilityDescription = abilityDescription;
        this.cD = cD;
        this.DamageOrHeal = damageOrHeal;
    }

    public abstract void Cast(GameObject gameObject);
}
