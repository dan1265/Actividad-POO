using UnityEngine;

public class Holybomb : Ability
{
    public Holybomb(Sprite icon, float cD) : base(icon, nameof(Holybomb), "throws a flask of holy water that explodes on impact with the ground, inflicts damage to enemies standing on the water", cD)
    {
    }

    public override void Cast()
    {
        Debug.Log("Holybomb");
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
