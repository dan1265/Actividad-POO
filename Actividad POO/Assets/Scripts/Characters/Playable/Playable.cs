using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[System.Serializable]
public class Playable : CharactersBase
{
    [SerializeField] public List<Ability> abilities = new List<Ability>();
    protected PlayerInput playerInput;

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
        abilities[ability - 1].RefUpdate();
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
