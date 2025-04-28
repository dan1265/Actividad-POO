using UnityEngine;

[System.Serializable]
public abstract class Ability
{
    private Sprite icon;
    private string abilityName;
    private string abilityDescription;
    private float damageOrHeal;
    private float cost;
    public float cD;
    

    public float cDtimer;
    public bool canCast => cDtimer <= 0f;

    public float DamageOrHeal { get => damageOrHeal; set => damageOrHeal = value; }
    public float Cost { get => cost; set => cost = value; }

    public Ability(Sprite icon, string abilityName, string abilityDescription, float cD, float damageOrHeal, float cost)
    {
        this.icon = icon;
        this.abilityName = abilityName;
        this.abilityDescription = abilityDescription;
        this.cD = cD;
        DamageOrHeal = damageOrHeal;
        Cost = cost;
    }

    public abstract void Cast(GameObject gameObject);

    public abstract void RefUpdate();
}
