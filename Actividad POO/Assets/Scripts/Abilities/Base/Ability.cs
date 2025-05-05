using UnityEngine;

[System.Serializable]
public abstract class Ability
{
    private Sprite icon;
    public string abilityName;
    private string abilityDescription;
    private float cost;
    public float cD;
    protected GameObject caster;
    protected Abilityscriptable abilityData;
    

    public float cDtimer;
    public bool canCast => cDtimer <= 0f;

    public float Cost { get => cost; set => cost = value; }

    public Ability(Sprite icon, string abilityName, string abilityDescription, float cD, float cost, GameObject caster, Abilityscriptable abilityData)
    {
        this.icon = icon;
        this.abilityName = abilityName;
        this.abilityDescription = abilityDescription;
        this.cD = cD;
        Cost = cost;
        this.caster = caster;
        this.abilityData = abilityData;
    }

    public abstract void Cast();
}
