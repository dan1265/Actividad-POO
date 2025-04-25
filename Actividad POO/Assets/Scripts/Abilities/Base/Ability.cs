using UnityEngine;

[System.Serializable]
public abstract class Ability
{
    private Sprite icon;
    private string abilityName;
    private string abilityDescription;
    private float cD;

    public Ability(Sprite icon, string abilityName, string abilityDescription, float cD)
    {
        this.icon = icon;
        this.abilityName = abilityName;
        this.abilityDescription = abilityDescription;
        this.cD = cD;
    }

    public abstract void Cast();

}
