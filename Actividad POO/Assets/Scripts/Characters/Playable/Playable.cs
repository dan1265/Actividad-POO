using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[System.Serializable]
public class Playable : CharactersBase, IDamageable
{
    [SerializeField] public List<Ability> abilities = new List<Ability>();
    protected PlayerInput playerInput;

    [SerializeField] public Manasystem mana;

    protected override void Awake()
    {
        base.Awake();
        mana = new Manasystem(100, 0, 100);
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

    protected void Dead()
    {
        if(lifesystem.CurrentLife <= 0)
        {
            transform.position = Vector3.zero;
            lifesystem.CurrentLife = 100;
        }
    }

    public void TakeDamage(float damage)
    {
        lifesystem.TakeDamage(damage);
    }

    public void Heal(float amount)
    {
        lifesystem.Heal(amount);
    }
}
