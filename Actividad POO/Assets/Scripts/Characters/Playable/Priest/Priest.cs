using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Priest : Playable
{
    [SerializeField] private GameObject holylight;
    [SerializeField] private GameObject holybomb;
    [SerializeField] public List<Ability> abilitiesData;
    protected override void Awake()
    {
        base.Awake();

        mana.CurrentMana = 100;
        mana.regenerationSpeed = 5;

        abilities.Add(new Holylight(2.5f, gameObject, holylight));
        abilities.Add(new Restauration(10f, gameObject, abilitiesData[1]));
        abilities.Add(new Holybomb(7f, gameObject, holybomb));
    }

    // Update is called once per frame
    void Update()
    {
        mana.ManaRegen();
        CDUpdate();
        CastSelector();
        Dead();
    }
}
