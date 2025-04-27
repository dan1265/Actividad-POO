using UnityEngine;

public class Demon : Playable
{
    protected override void Awake()
    {
        base.Awake();

        abilities.Add(new Darkspear(null, 5f));
        abilities.Add(new Forceoftheabyss(null, 5f));
        abilities.Add(new Firebomb(null, 5f));

    }

    void Start()
    {
    }

    void Update()
    {
        
    }
}
