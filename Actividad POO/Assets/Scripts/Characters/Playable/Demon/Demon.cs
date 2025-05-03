using UnityEngine;

public class Demon : Playable
{
    [SerializeField] protected float regenerationTimer;
    [SerializeField] protected float regenerationSpeed;

    [SerializeField] private GameObject darkspear;
    [SerializeField] private GameObject firebomb;
    protected override void Awake()
    {
        base.Awake();

        abilities.Add(new Darkspear(null, 5f, gameObject, darkspear));
        abilities.Add(new Forceoftheabyss(null, 5f, gameObject));
        abilities.Add(new Firebomb(null, 5f, gameObject, firebomb));
    }


    void Update()
    {
        LifeRegen();
        CDUpdate();
        CastSelector();
    }

    protected void LifeRegen()
    {
        if (Life < 100)
        {
            regenerationTimer -= Time.deltaTime;
        }

        if (regenerationTimer <= 0)
        {
            Life += 1;
            regenerationTimer = regenerationSpeed;
        }

        if (Life == 100)
        {
            regenerationTimer = regenerationSpeed;
        }
    }
}
