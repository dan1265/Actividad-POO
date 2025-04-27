using UnityEngine;

public class Restauration : Ability
{
    public Restauration(Sprite icon, float cD) : base(icon, nameof(Restauration), "The gods illuminate you with their sacred light regenerating life.", cD)
    {
    }

    public override void Cast(GameObject gameObject)
    {
        if (canCast)
        {
            cDtimer = cD;
            gameObject.GetComponent<Priest>().RestaurationAbility();
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
