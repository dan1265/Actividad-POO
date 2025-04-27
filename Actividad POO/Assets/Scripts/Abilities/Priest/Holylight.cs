using UnityEngine;

[System.Serializable]
public class Holylight : Ability
{
    public Holylight(Sprite icon, float cD) : base(icon, nameof(Holylight), "Summons a beam of holy light that deals damage to the first enemy it hits.", cD, 20f)
    {

    }

    public override void Cast(GameObject gameObject)
    {
        if (canCast)
        {
            cDtimer = cD;
            gameObject.GetComponent<Priest>().HolylightAbility();
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
