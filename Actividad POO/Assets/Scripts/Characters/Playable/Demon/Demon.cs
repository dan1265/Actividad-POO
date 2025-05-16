using System.Collections.Generic;
using UnityEngine;

public class Demon : Playable
{
    [SerializeField] protected float regenerationTimer;
    [SerializeField] protected float regenerationSpeed;

    [SerializeField] private GameObject darkspear;
    [SerializeField] private GameObject firebomb;

    [SerializeField] public List<Ability> abilitiesData;
    protected override void Awake()
    {
        base.Awake();

        abilities.Add(new Darkspear(2.5f, gameObject, darkspear));
        abilities.Add(new Forceoftheabyss(10f, gameObject, abilitiesData[1]));
        abilities.Add(new Firebomb(7f, gameObject, firebomb));
    }


    void Update()
    {
        LifeRegen();
        CDUpdate();
        CastSelector();
        Dead();
    }

    protected void LifeRegen()
    {
        if (lifesystem.CurrentLife < 100)
        {
            regenerationTimer -= Time.deltaTime;
        }

        if (regenerationTimer <= 0)
        {
            lifesystem.CurrentLife += 1;
            regenerationTimer = regenerationSpeed;
        }

        if (lifesystem.CurrentLife == 100)
        {
            regenerationTimer = regenerationSpeed;
        }
    }
}
