using UnityEngine;

public class Forceoftheabyss : Ability
{
    public Forceoftheabyss(Sprite icon, float cD) : base(icon, nameof(Forceoftheabyss), "you consume a cursed soul to absorb its power and regenerate your life", cD, 30f, 0)
    {
    }

    public override void Cast(GameObject gameObject)
    {
        throw new System.NotImplementedException();
    }

    public override void RefUpdate()
    {
        throw new System.NotImplementedException();
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
