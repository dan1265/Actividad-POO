using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[System.Serializable]
public class Playable : CharactersBase
{
    [SerializeField] public List<Ability> abilities = new List<Ability>();
    protected PlayerInput playerInput;

    [SerializeField] private float mana;

    public float Mana
    {
        get => mana;
        set
        {
            if (value < 0)
                mana = 0;
            else if (value > 100)
                mana = 100;
            else
                mana = value;
        }
    }

    protected override void Awake()
    {
        base.Awake();
        playerInput = GetComponent<PlayerInput>();
    }

    protected void CastSelector()
    {
        if (Keyboard.current.digit1Key.wasPressedThisFrame)
        {
            Cast(1);
        }
        else if (Keyboard.current.digit2Key.wasPressedThisFrame)
        {
            Cast(2);
        }
        else if (Keyboard.current.digit3Key.wasPressedThisFrame)
        {
            Cast(3);
        }
    }

    private void Cast(int ability)
    {
        abilities[ability - 1].Cast();
    }

    protected void CDUpdate()
    {
        foreach (var ability in abilities)
        {

            if (ability.cDtimer >= 0)
            {
                ability.cDtimer -= Time.deltaTime;
            }
        }
    }
}
