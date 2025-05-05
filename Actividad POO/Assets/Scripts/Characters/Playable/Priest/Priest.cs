using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Priest : Playable
{
    [SerializeField] protected float regenerationTimer;
    [SerializeField] protected float regenerationSpeed;

    [SerializeField] private List<Abilityscriptable> abilitiesData;


    [SerializeField] private GameObject holylight;
    [SerializeField] private GameObject holybomb;
    protected override void Awake()
    {
        base.Awake();

        Mana = 100;

        abilities.Add(new Holylight(null, 2.5f, gameObject, holylight, abilitiesData[0]));
        abilities.Add(new Restauration(null, 10f, gameObject, abilitiesData[1]));
        abilities.Add(new Holybomb(null, 7f, gameObject, holybomb, abilitiesData[2]));
    }

    // Update is called once per frame
    void Update()
    {
        ManaRegen();
        CDUpdate();
        CastSelector();
    }

    protected void ManaRegen()
    {
        if (Mana < 100)
        {
            regenerationTimer -= Time.deltaTime;
        }

        if (regenerationTimer <= 0)
        {
            Mana += 1;
            regenerationTimer = regenerationSpeed;
        }

        if (Mana == 100)
        {
            regenerationTimer = regenerationSpeed;
        }
    }
}
