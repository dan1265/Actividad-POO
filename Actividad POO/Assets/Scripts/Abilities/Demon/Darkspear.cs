using UnityEngine;

public class Darkspear : Ability
{
    public Darkspear(Sprite icon, float cD) : base(icon, nameof(Darkspear), "Summons a dark spear in front of you that hits the first enemy hit.", cD)
    {
    }

    public override void Cast(GameObject gameObject)
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
