using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Priest : Playable
{
    [SerializeField] protected float regenerationTimer;
    [SerializeField] protected float regenerationSpeed;

    [SerializeField] private GameObject holylight;
    [SerializeField] private GameObject holybomb;
    [SerializeField] public List<Ability> abilitiesData;
    protected override void Awake()
    {
        base.Awake();

        mana.CurrentMana = 100;

        abilities.Add(new Holylight(2.5f, gameObject, holylight));
        abilities.Add(new Restauration(10f, gameObject, abilitiesData[1]));
        abilities.Add(new Holybomb(7f, gameObject, holybomb));
    }

    // Update is called once per frame
    void Update()
    {
        ManaRegen();
        CDUpdate();
        CastSelector();
        Dead();
    }

    protected void ManaRegen()
    {
        if (mana.CurrentMana < 100)
        {
            regenerationTimer -= Time.deltaTime;
        }

        if (regenerationTimer <= 0)
        {
            mana.CurrentMana += 1;
            regenerationTimer = regenerationSpeed;
        }

        if (mana.CurrentMana == 100)
        {
            regenerationTimer = regenerationSpeed;
        }
    }
}
