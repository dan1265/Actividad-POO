using UnityEngine;

[System.Serializable]
public abstract class Ability
{
    private Sprite icon;
    private string abilityName;
    private string abilityDescription;
    private float value;
    private float cost;
    public float cD;
    protected GameObject caster;
    

    public float cDtimer;
    public bool canCast => cDtimer <= 0f;

    public float Value { get => value; set => this.value = value; }
    public float Cost { get => cost; set => cost = value; }

    public Ability(Sprite icon, string abilityName, string abilityDescription, float cD, float value, float cost, GameObject caster)
    {
        this.icon = icon;
        this.abilityName = abilityName;
        this.abilityDescription = abilityDescription;
        this.cD = cD;
        this.value = value;
        Cost = cost;
        this.caster = caster;
    }

    public abstract void Cast();

    public abstract void RefUpdate();
}
