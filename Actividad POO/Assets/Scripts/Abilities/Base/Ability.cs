using UnityEngine;

[CreateAssetMenu(fileName = "New Ability", menuName = "Ability", order = 1)]
public class Ability : ScriptableObject
{
    public Sprite icon;
    public string abilityName;
    public string abilityDescription;
    private float cost;
    private float cD;
    protected GameObject caster;
    public float abilityValue;
    public float cDtimer;
    public bool canCast => cDtimer <= 0f;

    public float Cost { get => cost; set => cost = value; }
    public float CD { get => cD; set => cD = value; }

    public Ability(float cD, float cost, GameObject caster)
    {
        this.CD = cD;
        Cost = cost;
        this.caster = caster;
    }

    public virtual void Cast()
    {

    }
}
