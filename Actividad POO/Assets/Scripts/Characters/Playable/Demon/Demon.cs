using System.Collections.Generic;
using UnityEngine;

public class Demon : Playable
{
    [SerializeField] protected float regenerationTimer;
    [SerializeField] protected float regenerationSpeed;

    [SerializeField] private GameObject darkspear;
    [SerializeField] private GameObject firebomb;

    [SerializeField]private List<Abilityscriptable> abilitiesData;
    protected override void Awake()
    {
        base.Awake();

        abilities.Add(new Darkspear(null, 2.5f, gameObject, darkspear, abilitiesData[0]));
        abilities.Add(new Forceoftheabyss(null, 10f, gameObject, abilitiesData[1]));
        abilities.Add(new Firebomb(null, 7f, gameObject, firebomb, abilitiesData[2]));
    }


    void Update()
    {
        LifeRegen();
        CDUpdate();
        CastSelector();
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
