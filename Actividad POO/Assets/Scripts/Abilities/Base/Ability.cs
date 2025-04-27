using UnityEngine;

[System.Serializable]
public abstract class Ability
{
    private Sprite icon;
    private string abilityName;
    private string abilityDescription;
    public float cD;

    public float cDtimer;
    public bool canCast => cDtimer <= 0f;


    public Ability(Sprite icon, string abilityName, string abilityDescription, float cD)
    {
        this.icon = icon;
        this.abilityName = abilityName;
        this.abilityDescription = abilityDescription;
        this.cD = cD;
    }

    public abstract void Cast(GameObject gameObject);
}
